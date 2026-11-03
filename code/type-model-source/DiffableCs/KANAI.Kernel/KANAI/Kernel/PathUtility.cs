namespace KANAI.Kernel;

[Token(Token = "0x2000021")]
public class PathUtility
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600012A")]
	public PathUtility() { }

	[Address(RVA = "0x1DED5A0", Offset = "0x1DEC9A0", Length = "0xB1")]
	[Token(Token = "0x6000126")]
	public static string CreatePath(string bpath, string fname, string extname) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000128")]
	public static string FullpathToAssetpath(string fullpath) { }

	[Address(RVA = "0x1DED660", Offset = "0x1DECA60", Length = "0x49")]
	[Token(Token = "0x6000127")]
	public static string GetFileName(string bpath) { }

	[Address(RVA = "0x1DED6B0", Offset = "0x1DECAB0", Length = "0x104")]
	[Token(Token = "0x6000125")]
	public static string GetRelativePathFromProjectRoot(string path) { }

	[Address(RVA = "0x1DED7C0", Offset = "0x1DECBC0", Length = "0x8B")]
	[Token(Token = "0x6000129")]
	public static string GetTargetAssetPath(string bpath, string tpath) { }

	[Address(RVA = "0x1DED850", Offset = "0x1DECC50", Length = "0x166")]
	[Token(Token = "0x6000124")]
	public static string PathFromSourceDirectory(string relativePath, string sourcePath = "") { }

}

