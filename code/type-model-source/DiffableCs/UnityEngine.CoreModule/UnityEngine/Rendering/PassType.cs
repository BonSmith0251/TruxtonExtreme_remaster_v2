namespace UnityEngine.Rendering;

[Token(Token = "0x2000352")]
public enum PassType : int
{
	Normal = 0,
	Vertex = 1,
	VertexLM = 2,
	VertexLMRGBM = 3,
	ForwardBase = 4,
	ForwardAdd = 5,
	LightPrePassBase = 6,
	LightPrePassFinal = 7,
	ShadowCaster = 8,
	Deferred = 10,
	Meta = 11,
	MotionVectors = 12,
	ScriptableRenderPipeline = 13,
	ScriptableRenderPipelineDefaultUnlit = 14,
	GrabPass = 15,
}

