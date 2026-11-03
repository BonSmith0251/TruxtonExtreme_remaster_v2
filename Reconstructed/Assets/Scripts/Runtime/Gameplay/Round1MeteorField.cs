using System.Collections.Generic;
using UnityEngine;

// MeteoEnemy movement (PhysicsMove / PhysicsUpdater). Each meteor is a non-kinematic Rigidbody on layer physics3d, which
// collides only with physics3d, so meteors push each other but pass through ordinary enemies. PhysicsUpdater.ProgressLate
// (RVA 0x181d3b310) steps Physics.Simulate(0.02) by script; ApplyTransformFromPhysics (0x181d18ee0) copies the body's
// position to the enemy root and its rotation to _modelTop. This is a small sphere solver with the same settings, in the
// enemy layer's source units (X/Z; Y frozen).
// Remaster rule (not the original's, which lets meteors pass through other enemies): meteors never overlap. Other air
// enemies' hit circles are immovable kinematic obstacles, and after every step (and at spawn) bodies are projected fully
// out of each other and out of the obstacles instead of separating at the max depenetration velocity.
public class Round1MeteorField
{
    public const float Step=.02f;
    // Prefab Rigidbody/SphereCollider values per size, physics material "Meteo" and the project's PhysicsManager.
    const float Friction=.6f,AngularDrag=.05f,MaxAngularSpeed=7;
    const int SolverIterations=3,ProjectionIterations=16;
    public class Body
    {
        public Vector3 position,velocity,angularVelocity;public Quaternion rotation=Quaternion.identity;
        public float mass,radius;public bool removed,kinematic;public int group;public Vector3 groupCentre;
        public float InverseMass=>kinematic?0:1/mass;
        public float InverseInertia=>kinematic?0:1/(.4f*mass*radius*radius);
    }
    public static (float mass,float radius) Size(string model)=>model.Contains("La02")?(22,24):model.Contains("Ma02")?(12,13):(7,8);
    // PhysicsMove.ProgressStart (0x181d19320): heading = _firstRotate * Euler(0, Range(-10,10), 0); _initializeRigid
    // (0x181d19b00) adds that * speed and _angularVelocity = Range(-1,1)^3 * _RotateScale 0.5 as VelocityChange.
    public static Body Create(string model,Vector3 position,Quaternion rotate,float speed,System.Random rng)
    {
        float Range(float min,float max)=>min+(max-min)*(float)rng.NextDouble();
        var (mass,radius)=Size(model);
        var heading=rotate*Quaternion.Euler(0,Range(-10,10),0)*Vector3.forward;heading.y=0;
        return new Body{position=new Vector3(position.x,0,position.z),velocity=heading.normalized*speed,
            angularVelocity=new Vector3(Range(-1,1),Range(-1,1),Range(-1,1))*.5f,mass=mass,radius=radius};
    }

    readonly List<Body> bodies=new List<Body>();
    readonly List<Body> obstacles=new List<Body>();
    float time;
    public int Count=>bodies.Count;
    public float Time=>time;
    public void Reset(float now){bodies.Clear();obstacles.Clear();time=now;}
    public void Add(Body body){bodies.Add(body);Project();}
    // Enemy hit circles this frame (source position, velocity, radius, owning enemy and its centre); they push meteors but
    // are not moved.
    public void SetObstacles(List<(Vector3 position,Vector3 velocity,float radius,int group,Vector3 centre)> circles)
    {
        while(obstacles.Count<circles.Count)obstacles.Add(new Body{kinematic=true,mass=1});
        obstacles.RemoveRange(circles.Count,obstacles.Count-circles.Count);
        for(int i=0;i<circles.Count;i++)
        {
            var o=obstacles[i];var c=circles[i];
            o.position=c.position;o.position.y=0;o.velocity=c.velocity;o.velocity.y=0;o.radius=c.radius;o.group=c.group;o.groupCentre=c.centre;o.groupCentre.y=0;
        }
    }
    public void Remove(Body body){if(body!=null)body.removed=true;}
    // Runs every whole step up to now. Like the original, a body shows its latest simulated state between steps.
    // Call after SetObstacles.
    public void Advance(float now)
    {
        bodies.RemoveAll(b=>b.removed);
        if(now<time-.0001f)time=now;
        while(time+Step<=now+.00001f){Simulate(Step);time+=Step;}
        // Enemies move every frame, so keep meteors out of them between physics steps too.
        Project();
    }

    struct Contact { public Body a,b;public Vector3 normal;public float depth,normalImpulse,frictionImpulse; }
    readonly List<Contact> contacts=new List<Contact>();
    void Simulate(float dt)
    {
        contacts.Clear();
        for(int i=0;i<bodies.Count;i++)
        {
            for(int j=i+1;j<bodies.Count;j++)Touch(bodies[i],bodies[j]);
            foreach(var o in obstacles)Touch(o,bodies[i]);
        }
        void Touch(Body a,Body b)
        {
            var d=b.position-a.position;d.y=0;
            float reach=a.radius+b.radius,distance=d.magnitude;
            if(distance>=reach)return;
            contacts.Add(new Contact{a=a,b=b,normal=distance>1e-5f?d/distance:Vector3.right,depth=reach-distance});
        }
        for(int k=0;k<SolverIterations;k++)
            for(int c=0;c<contacts.Count;c++)
            {
                var ct=contacts[c];var a=ct.a;var b=ct.b;var n=ct.normal;
                Vector3 ra=n*a.radius,rb=-n*b.radius;
                // Normal: no bounce (bounciness 0). Overlap itself is removed by Project, so contacts only stop approach.
                Vector3 relative=b.velocity+Vector3.Cross(b.angularVelocity,rb)-a.velocity-Vector3.Cross(a.angularVelocity,ra);
                float jn=-Vector3.Dot(relative,n)/(a.InverseMass+b.InverseMass);
                float accumulated=Mathf.Max(0,ct.normalImpulse+jn);jn=accumulated-ct.normalImpulse;ct.normalImpulse=accumulated;
                Apply(a,b,ra,rb,n*jn);
                // Friction (0.6, Minimum combine) on the contact's tangential slip, which also trades spin between meteors.
                relative=b.velocity+Vector3.Cross(b.angularVelocity,rb)-a.velocity-Vector3.Cross(a.angularVelocity,ra);
                var slip=relative-n*Vector3.Dot(relative,n);float speed=slip.magnitude;
                if(speed>1e-5f)
                {
                    var t=slip/speed;
                    float flat=t.x*t.x+t.z*t.z;
                    float k2=(a.InverseMass+b.InverseMass)*flat+a.InverseInertia*Vector3.Cross(ra,t).sqrMagnitude+b.InverseInertia*Vector3.Cross(rb,t).sqrMagnitude;
                    float jt=-speed/Mathf.Max(1e-6f,k2),limit=Friction*ct.normalImpulse;
                    float total=Mathf.Clamp(ct.frictionImpulse+jt,-limit,limit);jt=total-ct.frictionImpulse;ct.frictionImpulse=total;
                    Apply(a,b,ra,rb,t*jt);
                }
                contacts[c]=ct;
            }
        foreach(var body in bodies)
        {
            body.velocity.y=0;
            body.position+=body.velocity*dt;
            body.angularVelocity*=Mathf.Max(0,1-AngularDrag*dt);
            body.angularVelocity=Vector3.ClampMagnitude(body.angularVelocity,MaxAngularSpeed);
            float rate=body.angularVelocity.magnitude;
            if(rate>1e-6f)body.rotation=Quaternion.Normalize(Quaternion.AngleAxis(rate*dt*Mathf.Rad2Deg,body.angularVelocity/rate)*body.rotation);
        }
        Project();
    }
    // Moves meteors out of obstacles entirely and apart from each other in proportion to their inverse masses. Meteor
    // pairs go last, so a pile pinched by enemies keeps its meteors apart; Round1Combat.SeparateAir, which runs after
    // this, moves the enemies off any meteor still touching them.
    public void Project()
    {
        for(int k=0;k<ProjectionIterations;k++)
        {
            bool moved=false;
            foreach(var b in bodies)foreach(var o in obstacles)moved|=Separate(o,b);
            moved|=SeparateMeteors();
            if(!moved)break;
        }
        // A meteor left inside an enemy (a pocket narrower than the meteor, e.g. between Lb01's head and arms) is carried
        // straight out from that enemy's centre until it touches none of its circles.
        foreach(var b in bodies)
        {
            if(b.removed)continue;
            foreach(var o in obstacles)
            {
                if(Gap(o,b)>=-1e-3f)continue;
                var away=b.position-o.groupCentre;away.y=0;away=away.sqrMagnitude>1e-6f?away.normalized:Vector3.right;
                for(int step=0;step<64 && Inside(b,o.group);step++)b.position+=away*b.radius*.25f;
                var v=Vector3.Dot(b.velocity-o.velocity,away);if(v<0)b.velocity-=away*v;
            }
        }
        for(int k=0;k<ProjectionIterations && SeparateMeteors();k++){}
        bool SeparateMeteors(){bool any=false;for(int i=0;i<bodies.Count;i++)for(int j=i+1;j<bodies.Count;j++)any|=Separate(bodies[i],bodies[j]);return any;}
        float Gap(Body a,Body b){var d=b.position-a.position;d.y=0;return d.magnitude-a.radius-b.radius;}
        bool Inside(Body b,int group){foreach(var o in obstacles)if(o.group==group && Gap(o,b)<-1e-3f)return true;return false;}
        bool Separate(Body a,Body b)
        {
            if(a.removed || b.removed)return false;
            var d=b.position-a.position;d.y=0;float reach=a.radius+b.radius,distance=d.magnitude;
            if(distance>=reach-1e-4f)return false;
            var n=distance>1e-5f?d/distance:Vector3.right;float depth=reach-distance,total=a.InverseMass+b.InverseMass;
            if(total<=0)return false;
            a.position-=n*depth*a.InverseMass/total;b.position+=n*depth*b.InverseMass/total;return true;
        }
    }
    // Impulse p on b and -p on a at the contact arms. Constraints FreezePositionY: no linear Y.
    static void Apply(Body a,Body b,Vector3 ra,Vector3 rb,Vector3 p)
    {
        var flat=new Vector3(p.x,0,p.z);
        a.velocity-=flat*a.InverseMass;b.velocity+=flat*b.InverseMass;
        a.angularVelocity-=Vector3.Cross(ra,p)*a.InverseInertia;b.angularVelocity+=Vector3.Cross(rb,p)*b.InverseInertia;
    }
}
