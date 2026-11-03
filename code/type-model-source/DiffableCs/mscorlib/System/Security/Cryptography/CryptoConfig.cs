namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000328")]
public class CryptoConfig
{
	[Token(Token = "0x4000D4C")]
	private static readonly object lockObject; //Field offset: 0x0
	[Token(Token = "0x4000D4D")]
	private static Dictionary<String, Type> algorithms; //Field offset: 0x8

	[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
	[Token(Token = "0x17000296")]
	public static bool AllowOnlyFipsAlgorithms
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001998")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x1EC83E0", Offset = "0x1EC77E0", Length = "0x73")]
	[Token(Token = "0x6001999")]
	private static CryptoConfig() { }

	[Address(RVA = "0x1EC76D0", Offset = "0x1EC6AD0", Length = "0x4C")]
	[Token(Token = "0x6001993")]
	public static object CreateFromName(string name) { }

	[Address(RVA = "0x1EC58F0", Offset = "0x1EC4CF0", Length = "0x1DDE")]
	[Token(Token = "0x6001994")]
	public static object CreateFromName(string name, Object[] args) { }

	[Address(RVA = "0x1EC7720", Offset = "0x1EC6B20", Length = "0x1A4")]
	[Token(Token = "0x6001997")]
	private static Byte[] EncodeLongNumber(long x) { }

	[Address(RVA = "0x1EC78D0", Offset = "0x1EC6CD0", Length = "0x447")]
	[Token(Token = "0x6001996")]
	public static Byte[] EncodeOID(string str) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001998")]
	public static bool get_AllowOnlyFipsAlgorithms() { }

	[Address(RVA = "0x1EC7D20", Offset = "0x1EC7120", Length = "0x6B2")]
	[Token(Token = "0x6001995")]
	public static string MapNameToOID(string name) { }

}

