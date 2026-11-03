namespace KANAI.Kernel;

[Token(Token = "0x200001B")]
public static class FileUtility
{

	[Address(RVA = "0x1DEA3D0", Offset = "0x1DE97D0", Length = "0x27")]
	[Token(Token = "0x60000E6")]
	public static void CreateDirectory(string p) { }

	[Address(RVA = "0x1DEA400", Offset = "0x1DE9800", Length = "0x14")]
	[Token(Token = "0x60000E9")]
	public static void CreateFile(string p, Byte[] bytes) { }

	[Address(RVA = "0x1DEA420", Offset = "0x1DE9820", Length = "0x93")]
	[Token(Token = "0x60000EB")]
	public static Texture2D CreateTexture2D(Byte[] bytes) { }

	[Address(RVA = "0x1DEA4C0", Offset = "0x1DE98C0", Length = "0x29")]
	[Token(Token = "0x60000E7")]
	public static void DeleteDirectory(string p) { }

	[Address(RVA = "0x1DEA4F0", Offset = "0x1DE98F0", Length = "0x29")]
	[Token(Token = "0x60000E8")]
	public static void DeleteFile(string p) { }

	[Address(RVA = "0x1DEA520", Offset = "0x1DE9920", Length = "0x71")]
	[Token(Token = "0x60000EC")]
	public static string FullToAssetPath(string tpath) { }

	[Address(RVA = "0x1DEA5A0", Offset = "0x1DE99A0", Length = "0x7")]
	[Token(Token = "0x60000ED")]
	public static bool IsExists(string filePath) { }

	[Address(RVA = "0x1DEA5B0", Offset = "0x1DE99B0", Length = "0x2B")]
	[Token(Token = "0x60000EA")]
	public static Byte[] ReadFile(string p) { }

}

