namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x200039B")]
public enum BatchDrawCommandFlags : int
{
	None = 0,
	FlipWinding = 1,
	HasMotion = 2,
	IsLightMapped = 4,
	HasSortingPosition = 8,
	LODCrossFadeKeyword = 16,
	LODCrossFadeValuePacked = 32,
	LODCrossFade = 48,
	UseLegacyLightmapsKeyword = 64,
}

