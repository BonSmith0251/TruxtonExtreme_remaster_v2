using UnityEngine;
using UnityEngine.Rendering;

// The stage's own render settings, as InGame.Kernel.BG.InGameBGObject.UpdateSkyBox (native RVA 0x1D15260) applies them
// when a stage enters the game. The values are copied from the stage prefab's InGameBGObject by
// Editor/ReconstructionStageRenderSettings (the recovered class is a stub, so nothing here calls it).
// The playable stage scenes are built from Round 1's BG03 template; without this they keep BG03's fog (dark teal,
// 100-1000 linear) and the old remaster's trilight ambient, which hides BG08's far battleship in flat fog colour.
public sealed class StageRenderSettings : MonoBehaviour
{
    public string source;
    public string adjustment;   // non-empty when a user-requested look replaced some original values
    public Material skyboxMaterial;
    public Color skyboxShadowColor;
    public bool useFog;
    public Color fogColor=Color.white;
    public FogMode fogMode=FogMode.Linear;
    public float fogStart,fogEnd;
    public float reflectionIntensity=1,ambientIntensity=1;
    public int reflectionBounces=1,reflectionResolution=128;
    public DefaultReflectionMode reflectionMode;
    public AmbientMode ambientMode;
    // With a user-requested fog on a stage the original keeps fog-free: the stage's URP Particles/Unlit renderers get
    // runtime copies of their materials on this fog-free shader, so far additive backdrops (BG08 nebula and stars)
    // keep the original look instead of turning into fog-coloured sheets. Shared material assets are not touched.
    public Shader unfogParticles;
    public Transform stageRoot;

    void Awake()=>Apply();
    void Start()=>UnfogParticles();

    void UnfogParticles()
    {
        if(!unfogParticles||!stageRoot||!RenderSettings.fog)return;
        var copies=new System.Collections.Generic.Dictionary<Material,Material>();
        foreach(var r in stageRoot.GetComponentsInChildren<ParticleSystemRenderer>(true))
        {
            var mats=r.sharedMaterials;bool changed=false;
            for(int i=0;i<mats.Length;i++)
            {
                var m=mats[i];if(!m||m.shader.name!="Universal Render Pipeline/Particles/Unlit")continue;
                if(!copies.TryGetValue(m,out var copy)){copy=new Material(m){name=m.name+" (no fog)"};int queue=m.renderQueue;copy.shader=unfogParticles;copy.renderQueue=queue;copies[m]=copy;}
                mats[i]=copy;changed=true;
            }
            if(changed)r.sharedMaterials=mats;
        }
    }

    // Same order and conditions as the native method: fog parameters only with fog on; skybox, ambient, reflection,
    // shadow colour and the environment update only when the stage names a skybox material.
    public void Apply()
    {
        RenderSettings.fog=useFog;
        if(useFog){RenderSettings.fogColor=fogColor;RenderSettings.fogMode=fogMode;RenderSettings.fogStartDistance=fogStart;RenderSettings.fogEndDistance=fogEnd;}
        if(!skyboxMaterial)return;
        RenderSettings.skybox=skyboxMaterial;
        RenderSettings.ambientIntensity=ambientIntensity;
        RenderSettings.ambientMode=ambientMode;
        RenderSettings.defaultReflectionMode=reflectionMode;
        RenderSettings.defaultReflectionResolution=reflectionResolution;
        RenderSettings.reflectionIntensity=reflectionIntensity;
        RenderSettings.reflectionBounces=reflectionBounces;
        RenderSettings.subtractiveShadowColor=skyboxShadowColor;
        DynamicGI.UpdateEnvironment();
    }
}
