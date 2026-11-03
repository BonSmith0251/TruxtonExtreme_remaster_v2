namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x2000083")]
internal enum InstanceFlags : byte
{
	None = 0,
	AffectsLightmaps = 1,
	IsShadowsOff = 2,
	IsShadowsOnly = 4,
	HasMeshLod = 8,
	SmallMeshCulling = 16,
}

