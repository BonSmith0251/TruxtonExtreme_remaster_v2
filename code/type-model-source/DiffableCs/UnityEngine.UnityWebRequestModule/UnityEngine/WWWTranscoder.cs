namespace UnityEngine;

[Token(Token = "0x2000004")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UnityWebRequestWWWModule"})]
internal class WWWTranscoder
{
	[Token(Token = "0x400000A")]
	private static Byte[] ucHexChars; //Field offset: 0x0
	[Token(Token = "0x400000B")]
	private static Byte[] lcHexChars; //Field offset: 0x8
	[Token(Token = "0x400000C")]
	private static byte urlEscapeChar; //Field offset: 0x10
	[Token(Token = "0x400000D")]
	private static Byte[] urlSpace; //Field offset: 0x18
	[Token(Token = "0x400000E")]
	private static Byte[] dataSpace; //Field offset: 0x20
	[Token(Token = "0x400000F")]
	private static Byte[] urlForbidden; //Field offset: 0x28
	[Token(Token = "0x4000010")]
	private static byte qpEscapeChar; //Field offset: 0x30
	[Token(Token = "0x4000011")]
	private static Byte[] qpSpace; //Field offset: 0x38
	[Token(Token = "0x4000012")]
	private static Byte[] qpForbidden; //Field offset: 0x40

	[Address(RVA = "0x347F170", Offset = "0x347E570", Length = "0x31D")]
	[Token(Token = "0x600000C")]
	private static WWWTranscoder() { }

	[Address(RVA = "0x347ECB0", Offset = "0x347E0B0", Length = "0x8F")]
	[Token(Token = "0x600000A")]
	private static bool ByteSubArrayEquals(Byte[] array, int index, Byte[] comperand) { }

	[Address(RVA = "0x347ED40", Offset = "0x347E140", Length = "0x321")]
	[Token(Token = "0x600000B")]
	public static Byte[] Decode(Byte[] input, byte escapeChar, Byte[] space) { }

	[Address(RVA = "0x347F070", Offset = "0x347E470", Length = "0x85")]
	[Token(Token = "0x6000008")]
	private static byte Hex2Byte(Byte[] b, int offset) { }

	[Address(RVA = "0x347F100", Offset = "0x347E500", Length = "0x64")]
	[Token(Token = "0x6000009")]
	public static Byte[] URLDecode(Byte[] toEncode) { }

}

