namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x200033E")]
public enum MeshUpdateFlags : int
{
	Default = 0,
	DontValidateIndices = 1,
	DontResetBoneBounds = 2,
	DontNotifyMeshUsers = 4,
	DontRecalculateBounds = 8,
	DontValidateLodRanges = 16,
}

