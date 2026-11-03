namespace System.IO;

[Token(Token = "0x2000672")]
internal static class __Error
{

	[Address(RVA = "0x2005310", Offset = "0x2004710", Length = "0x5F")]
	[Token(Token = "0x6003024")]
	internal static void EndOfFile() { }

	[Address(RVA = "0x2005370", Offset = "0x2004770", Length = "0x61")]
	[Token(Token = "0x6003025")]
	internal static void FileNotOpen() { }

	[Address(RVA = "0x20053E0", Offset = "0x20047E0", Length = "0x14C")]
	[Token(Token = "0x6003027")]
	internal static string GetDisplayablePath(string path, bool isInvalidPath) { }

	[Address(RVA = "0x2005530", Offset = "0x2004930", Length = "0x61")]
	[Token(Token = "0x6003026")]
	internal static void ReaderClosed() { }

	[Address(RVA = "0x20055A0", Offset = "0x20049A0", Length = "0x82B")]
	[Token(Token = "0x6003028")]
	internal static void WinIOError(int errorCode, string maybeFullPath) { }

	[Address(RVA = "0x2005DD0", Offset = "0x20051D0", Length = "0x61")]
	[Token(Token = "0x6003029")]
	internal static void WriterClosed() { }

}

