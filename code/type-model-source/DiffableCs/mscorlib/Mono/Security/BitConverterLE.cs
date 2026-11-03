namespace Mono.Security;

[Token(Token = "0x200005E")]
internal sealed class BitConverterLE
{

	[Address(RVA = "0x1E5BA60", Offset = "0x1E5AE60", Length = "0x8A")]
	[Token(Token = "0x600011B")]
	internal static Byte[] GetBytes(float value) { }

	[Address(RVA = "0x1E5BAF0", Offset = "0x1E5AEF0", Length = "0xC2")]
	[Token(Token = "0x600011C")]
	internal static Byte[] GetBytes(double value) { }

	[Address(RVA = "0x1E5BBC0", Offset = "0x1E5AFC0", Length = "0x7F")]
	[Token(Token = "0x6000119")]
	private static Byte[] GetUIntBytes(Byte* bytes) { }

	[Address(RVA = "0x1E5BC40", Offset = "0x1E5B040", Length = "0xB3")]
	[Token(Token = "0x600011A")]
	private static Byte[] GetULongBytes(Byte* bytes) { }

	[Address(RVA = "0x1E5BD00", Offset = "0x1E5B100", Length = "0x51")]
	[Token(Token = "0x6000120")]
	internal static double ToDouble(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1E5BD60", Offset = "0x1E5B160", Length = "0x70")]
	[Token(Token = "0x600011F")]
	internal static float ToSingle(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1E2E4C0", Offset = "0x1E2D8C0", Length = "0x66")]
	[Token(Token = "0x600011D")]
	private static void UIntFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	[Address(RVA = "0x1E5BDE0", Offset = "0x1E5B1E0", Length = "0x48")]
	[Token(Token = "0x600011E")]
	private static void ULongFromBytes(Byte* dst, Byte[] src, int startIndex) { }

}

