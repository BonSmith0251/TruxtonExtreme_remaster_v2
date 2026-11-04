using System.Collections.Generic;
using UnityEngine;

// MeteoEnemy movement (PhysicsMove / PhysicsUpdater; evidence/physics/SPEC.md). Each meteor is a non-kinematic Rigidbody on
// layer physics3d, which collides only with physics3d: other meteors, and the colliders of the 13 PhysicsEnemy users
// (Lb01, Sl01, Ma01, Mb01, Mc01, Md01, Mi01, Mj01b, Mj01h, Mo01, Mp01, Mp02, Mq01), which their enemies teleport onto the
// model pose every frame. Every other enemy is not in 3D physics: meteors pass through it. PhysicsUpdater.ProgressLate
// (0x1D3B310) steps Physics.Simulate(0.02) by script with the leftover time carried; ApplyTransformFromPhysics (0x1D18EE0)
// copies the body's position to the enemy root and its rotation to _modelTop. This is a small solver with the same settings
// in the enemy layer's source units (Y frozen): inelastic contacts (Meteo material: bounce 0, friction 0.6, Minimum),
// 3 position iterations, overlap removed at no more than the default max depenetration velocity (10 units/s). An enemy
// collider is static or a teleported kinematic body: no velocity, never moved. PhysicsAttackAttr triggers (Lb01's head,
// Bos03's body) kill a meteor that touches them (PawnEnemy.SetSuside: no player credit).
public class Round1MeteorField
{
    public const float Step=.02f;
    // Prefab Rigidbody/SphereCollider values per size, physics material "Meteo" and the project's PhysicsManager.
    const float Friction=.6f,AngularDrag=.05f,MaxAngularSpeed=7,MaxDepenetration=10,ContactOffset=.01f;
    const int SolverIterations=3;
    public class Body
    {
        public Vector3 position,velocity,angularVelocity;public Quaternion rotation=Quaternion.identity;
        public float mass,radius;public bool removed;
        // Touched a PhysicsAttackAttr trigger: the host kills it (SetSuside).
        public bool suside;
        public float InverseMass=>1/mass;
        public float InverseInertia=>1/(.4f*mass*radius*radius);
    }
    // physics_xx sphere radius and Rigidbody mass: Sa01 r7, Sa02 r8 (mass 7), Ma r13 (12), La r24 (22).
    public static (float mass,float radius) Size(string model)=>model.Contains("La0")?(22,24):model.Contains("Ma0")?(12,13):model.Contains("Sa01")?(7,7):(7,8);
    // PhysicsMove.ProgressStart (0x1D19320): heading = _firstRotate * Euler(0, Range(-10,10), 0); _initializeRigid
    // (0x1D19B00) adds that * speed and _angularVelocity = Range(-1,1)^3 * _RotateScale 0.5 as VelocityChange.
    public static Body Create(string model,Vector3 position,Quaternion rotate,float speed,System.Random rng)
    {
        float Range(float min,float max)=>min+(max-min)*(float)rng.NextDouble();
        var (mass,radius)=Size(model);
        var heading=rotate*Quaternion.Euler(0,Range(-10,10),0)*Vector3.forward;heading.y=0;
        return new Body{position=new Vector3(position.x,0,position.z),velocity=heading.normalized*speed,
            angularVelocity=new Vector3(Range(-1,1),Range(-1,1),Range(-1,1))*.5f,mass=mass,radius=radius};
    }
    // An enemy's physics3d collider this frame, in the meteors' source frame: kind 0 sphere (radius), 1 box (half extents),
    // 2 capsule (radius, half segment along local axis); trigger = PhysicsAttackAttr.
    public struct Obstacle { public int kind,axis;public bool trigger;public Vector3 centre,half;public Quaternion rotation;public float radius,segment; }

    readonly List<Body> bodies=new List<Body>();
    readonly List<Obstacle> obstacles=new List<Obstacle>();
    float time;
    public int Count=>bodies.Count;
    public float Time=>time;
    public void Reset(float now){bodies.Clear();obstacles.Clear();time=now;}
    public void Add(Body body)=>bodies.Add(body);
    public void SetObstacles(List<Obstacle> list){obstacles.Clear();obstacles.AddRange(list);}
    public void Remove(Body body){if(body!=null)body.removed=true;}
    // Runs every whole step up to now. Like the original, a body shows its latest simulated state between steps.
    // Call after SetObstacles.
    public void Advance(float now)
    {
        bodies.RemoveAll(b=>b.removed);
        if(now<time-.0001f)time=now;
        while(time+Step<=now+.00001f){Simulate(Step);time+=Step;}
    }

    // b is always a meteor; a is a meteor or null (an enemy collider: infinite mass, no velocity).
    struct Contact { public Body a,b;public Vector3 normal;public float depth,normalImpulse,frictionImpulse; }
    readonly List<Contact> contacts=new List<Contact>();
    void Simulate(float dt)
    {
        contacts.Clear();
        for(int i=0;i<bodies.Count;i++)
        {
            var b=bodies[i];
            for(int j=i+1;j<bodies.Count;j++)
            {
                var d=b.position-bodies[j].position;d.y=0;float reach=b.radius+bodies[j].radius+ContactOffset,distance=d.magnitude;
                if(distance<reach)contacts.Add(new Contact{a=bodies[j],b=b,normal=distance>1e-5f?d/distance:Vector3.right,depth=reach-ContactOffset-distance});
            }
            foreach(var o in obstacles)
            {
                if(!Closest(o,b.position,out var normal,out float gap) || gap>=b.radius+ContactOffset)continue;
                if(o.trigger){b.suside=true;continue;}
                contacts.Add(new Contact{b=b,normal=normal,depth=b.radius-gap});
            }
        }
        for(int k=0;k<SolverIterations;k++)
            for(int c=0;c<contacts.Count;c++)
            {
                var ct=contacts[c];var a=ct.a;var b=ct.b;var n=ct.normal;
                Vector3 rb=-n*b.radius,ra=a!=null?n*a.radius:Vector3.zero;
                float inverse=b.InverseMass+(a!=null?a.InverseMass:0);
                // Normal: no bounce (restitution 0), only stops the approach.
                Vector3 relative=Velocity(b,rb)-(a!=null?Velocity(a,ra):Vector3.zero);
                float jn=-Vector3.Dot(relative,n)/inverse;
                float accumulated=Mathf.Max(0,ct.normalImpulse+jn);jn=accumulated-ct.normalImpulse;ct.normalImpulse=accumulated;
                Apply(a,b,ra,rb,n*jn);
                // Friction (0.6, Minimum combine) on the contact's tangential slip, which also trades spin between meteors.
                relative=Velocity(b,rb)-(a!=null?Velocity(a,ra):Vector3.zero);
                var slip=relative-n*Vector3.Dot(relative,n);float speed=slip.magnitude;
                if(speed>1e-5f)
                {
                    var t=slip/speed;float flat=t.x*t.x+t.z*t.z;
                    float k2=inverse*flat+b.InverseInertia*Vector3.Cross(rb,t).sqrMagnitude+(a!=null?a.InverseInertia*Vector3.Cross(ra,t).sqrMagnitude:0);
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
        // Overlap is removed at most MaxDepenetration * dt per step (by inverse mass between meteors), so a fast enemy
        // collider can run through a meteor.
        float cap=MaxDepenetration*dt;
        foreach(var ct in contacts)
        {
            float push=Mathf.Min(ct.depth,cap);if(push<=0)continue;
            if(ct.a==null){ct.b.position+=ct.normal*push;continue;}
            float total=ct.a.InverseMass+ct.b.InverseMass;
            ct.b.position+=ct.normal*push*ct.b.InverseMass/total;ct.a.position-=ct.normal*push*ct.a.InverseMass/total;
        }
        static Vector3 Velocity(Body x,Vector3 r)=>x.velocity+Vector3.Cross(x.angularVelocity,r);
    }
    // Closest point of collider o to point p (the meteor centre at y 0): outward normal in XZ (Y frozen) and the distance
    // from the collider's surface to p (negative inside).
    static bool Closest(in Obstacle o,Vector3 p,out Vector3 normal,out float gap)
    {
        var local=Quaternion.Inverse(o.rotation)*(p-o.centre);Vector3 q;float r=0;
        if(o.kind==0)q=Vector3.zero;
        else if(o.kind==2){q=Vector3.zero;q[o.axis]=Mathf.Clamp(local[o.axis],-o.segment,o.segment);}
        else
        {
            q=new Vector3(Mathf.Clamp(local.x,-o.half.x,o.half.x),Mathf.Clamp(local.y,-o.half.y,o.half.y),Mathf.Clamp(local.z,-o.half.z,o.half.z));
            if(q==local)
            {   // centre inside the box: out through the nearest XZ face
                float dx=o.half.x-Mathf.Abs(local.x),dz=o.half.z-Mathf.Abs(local.z);
                var face=dx<dz?new Vector3(Mathf.Sign(local.x),0,0):new Vector3(0,0,Mathf.Sign(local.z));
                normal=o.rotation*face;normal.y=0;gap=-Mathf.Min(dx,dz);
                if(normal.sqrMagnitude<1e-8f)return false;normal.Normalize();return true;
            }
        }
        if(o.kind!=1)r=o.radius;
        var d=local-q;float distance=d.magnitude;
        normal=o.rotation*(distance>1e-5f?d/distance:Vector3.right);normal.y=0;gap=distance-r;
        if(normal.sqrMagnitude<1e-8f){normal=Vector3.right;return true;}
        normal.Normalize();return true;
    }
    // Impulse p on b and -p on a at the contact arms (a null: an immovable collider). Constraints FreezePositionY: no linear Y.
    static void Apply(Body a,Body b,Vector3 ra,Vector3 rb,Vector3 p)
    {
        var flat=new Vector3(p.x,0,p.z);
        b.velocity+=flat*b.InverseMass;b.angularVelocity+=Vector3.Cross(rb,p)*b.InverseInertia;
        if(a!=null){a.velocity-=flat*a.InverseMass;a.angularVelocity-=Vector3.Cross(ra,p)*a.InverseInertia;}
    }
}
