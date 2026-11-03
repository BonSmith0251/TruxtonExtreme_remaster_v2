namespace System.Collections;

[Token(Token = "0x20005A1")]
internal static class HashHelpers
{
	[Token(Token = "0x40017A5")]
	public static readonly Int32[] primes; //Field offset: 0x0
	[Token(Token = "0x40017A6")]
	private static ConditionalWeakTable<Object, SerializationInfo> s_serializationInfoTable; //Field offset: 0x8

	[Token(Token = "0x17000610")]
	internal static ConditionalWeakTable<Object, SerializationInfo> SerializationInfoTable
	{
		[Address(RVA = "0x1FC2510", Offset = "0x1FC1910", Length = "0xF1")]
		[Token(Token = "0x600293D")]
		internal get { } //Length: 241
	}

	[Address(RVA = "0x1FC2480", Offset = "0x1FC1880", Length = "0x8C")]
	[Token(Token = "0x600293E")]
	private static HashHelpers() { }

	[Address(RVA = "0x1FC2140", Offset = "0x1FC1540", Length = "0x73")]
	[Token(Token = "0x600293C")]
	public static int ExpandPrime(int oldSize) { }

	[Address(RVA = "0x1FC2510", Offset = "0x1FC1910", Length = "0xF1")]
	[Token(Token = "0x600293D")]
	internal static ConditionalWeakTable<Object, SerializationInfo> get_SerializationInfoTable() { }

	[Address(RVA = "0x1FC21C0", Offset = "0x1FC15C0", Length = "0x203")]
	[Token(Token = "0x600293B")]
	public static int GetPrime(int min) { }

	[Address(RVA = "0x1FC23D0", Offset = "0x1FC17D0", Length = "0xA1")]
	[Token(Token = "0x600293A")]
	public static bool IsPrime(int candidate) { }

}

