namespace UnityEngine.Experimental.Rendering;

[Flags]
[Token(Token = "0x2000422")]
public enum TextureCreationFlags : int
{
	None = 0,
	MipChain = 1,
	DontInitializePixels = 4,
	Crunch = 64,
	DontUploadUponCreate = 1024,
	IgnoreMipmapLimit = 2048,
}

