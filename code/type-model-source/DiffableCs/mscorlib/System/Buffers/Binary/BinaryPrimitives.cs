namespace System.Buffers.Binary;

[Token(Token = "0x2000632")]
public static class BinaryPrimitives
{

	[Address(RVA = "0x1FD37C0", Offset = "0x1FD2BC0", Length = "0x5")]
	[Token(Token = "0x6002DFF")]
	public static int ReverseEndianness(int value) { }

	[Address(RVA = "0x1FD37D0", Offset = "0x1FD2BD0", Length = "0x8")]
	[CLSCompliant(False)]
	[Token(Token = "0x6002E00")]
	public static ushort ReverseEndianness(ushort value) { }

	[Address(RVA = "0x1FD37C0", Offset = "0x1FD2BC0", Length = "0x5")]
	[CLSCompliant(False)]
	[Token(Token = "0x6002E01")]
	public static uint ReverseEndianness(uint value) { }

}

