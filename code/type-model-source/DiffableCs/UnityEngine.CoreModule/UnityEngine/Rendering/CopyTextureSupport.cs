namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x2000367")]
public enum CopyTextureSupport : int
{
	None = 0,
	Basic = 1,
	Copy3D = 2,
	DifferentTypes = 4,
	TextureToRT = 8,
	RTToTexture = 16,
}

