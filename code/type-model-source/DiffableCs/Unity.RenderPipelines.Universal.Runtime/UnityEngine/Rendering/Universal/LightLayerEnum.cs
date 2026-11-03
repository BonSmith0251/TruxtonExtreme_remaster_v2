namespace UnityEngine.Rendering.Universal;

[Flags]
[Obsolete("Use RenderingLayerMask instead. #from(6000.2)")]
[Token(Token = "0x20001CE")]
public enum LightLayerEnum : int
{
	Nothing = 0,
	LightLayerDefault = 1,
	LightLayer1 = 2,
	LightLayer2 = 4,
	LightLayer3 = 8,
	LightLayer4 = 16,
	LightLayer5 = 32,
	LightLayer6 = 64,
	LightLayer7 = 128,
	Everything = 255,
}

