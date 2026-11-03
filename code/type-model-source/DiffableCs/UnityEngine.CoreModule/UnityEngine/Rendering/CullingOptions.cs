namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x20003CD")]
public enum CullingOptions : int
{
	None = 0,
	ForceEvenIfCameraIsNotActive = 1,
	OcclusionCull = 2,
	NeedsLighting = 4,
	NeedsReflectionProbes = 8,
	Stereo = 16,
	DisablePerObjectCulling = 32,
	ShadowCasters = 64,
}

