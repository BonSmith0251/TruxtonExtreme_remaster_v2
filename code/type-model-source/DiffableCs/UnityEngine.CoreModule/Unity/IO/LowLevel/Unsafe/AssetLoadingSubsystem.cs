namespace Unity.IO.LowLevel.Unsafe;

[Token(Token = "0x200003E")]
public enum AssetLoadingSubsystem : int
{
	Other = 0,
	Texture = 1,
	VirtualTexture = 2,
	Mesh = 3,
	Audio = 4,
	Scripts = 5,
	EntitiesScene = 6,
	EntitiesStreamBinaryReader = 7,
	FileInfo = 8,
	ContentLoading = 9,
}

