namespace TXEKernel;

[Token(Token = "0x20000E1")]
public static class TXEKeyDerivation
{
	[Token(Token = "0x4000497")]
	private static readonly Byte[] MASTER; //Field offset: 0x0

	[Address(RVA = "0x2715770", Offset = "0x2714B70", Length = "0x8C")]
	[Token(Token = "0x60006B6")]
	private static TXEKeyDerivation() { }

	[Address(RVA = "0x27151C0", Offset = "0x27145C0", Length = "0x57")]
	[Token(Token = "0x60006B3")]
	public static Byte[] DeriveAesIvFromPath(string path) { }

	[Address(RVA = "0x2715220", Offset = "0x2714620", Length = "0x1B9")]
	[Token(Token = "0x60006B4")]
	public static Byte[] DeriveAesIvFromPath(string path, Byte[] aesKey) { }

	[Address(RVA = "0x27153E0", Offset = "0x27147E0", Length = "0xA6")]
	[Token(Token = "0x60006B2")]
	public static Byte[] DeriveAesKeyFromPath(string path) { }

	[Address(RVA = "0x2715490", Offset = "0x2714890", Length = "0x53")]
	[Token(Token = "0x60006B0")]
	public static Byte[] DeriveKeyFromBundlePath(string path) { }

	[Address(RVA = "0x27154F0", Offset = "0x27148F0", Length = "0x165")]
	[Token(Token = "0x60006B1")]
	public static Byte[] DeriveKeyFromString(string value) { }

	[Address(RVA = "0x2715660", Offset = "0x2714A60", Length = "0x105")]
	[Token(Token = "0x60006B5")]
	private static string GetBaseName(string path) { }

}

