namespace Mono.Security;

[Token(Token = "0x2000005")]
internal sealed class BitConverterLE
{

	[Address(RVA = "0x1E2E230", Offset = "0x1E2D630", Length = "0x87")]
	[Token(Token = "0x600001C")]
	internal static Byte[] GetBytes(int value) { }

	[Address(RVA = "0x1E2E160", Offset = "0x1E2D560", Length = "0xC1")]
	[Token(Token = "0x600001D")]
	internal static Byte[] GetBytes(long value) { }

	[Address(RVA = "0x1E2E2C0", Offset = "0x1E2D6C0", Length = "0x7F")]
	[Token(Token = "0x600001A")]
	private static Byte[] GetUIntBytes(Byte* bytes) { }

	[Address(RVA = "0x1E2E340", Offset = "0x1E2D740", Length = "0xB3")]
	[Token(Token = "0x600001B")]
	private static Byte[] GetULongBytes(Byte* bytes) { }

	[Address(RVA = "0x1E2E400", Offset = "0x1E2D800", Length = "0x6E")]
	[Token(Token = "0x6000020")]
	internal static int ToInt32(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1E2E470", Offset = "0x1E2D870", Length = "0x45")]
	[Token(Token = "0x6000021")]
	internal static ushort ToUInt16(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1E2E400", Offset = "0x1E2D800", Length = "0x6E")]
	[Token(Token = "0x6000022")]
	internal static uint ToUInt32(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1E2E4C0", Offset = "0x1E2D8C0", Length = "0x66")]
	[Token(Token = "0x600001F")]
	private static void UIntFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	[Address(RVA = "0x1E2E530", Offset = "0x1E2D930", Length = "0x3E")]
	[Token(Token = "0x600001E")]
	private static void UShortFromBytes(Byte* dst, Byte[] src, int startIndex) { }

}

