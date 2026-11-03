namespace Unity.Collections;

[Token(Token = "0x2000039")]
internal sealed class BitField32DebugView
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000083")]
	private BitField32 BitField; //Field offset: 0x10

	[Token(Token = "0x1700002A")]
	public Boolean[] Bits
	{
		[Address(RVA = "0x28A9B50", Offset = "0x28A8F50", Length = "0x83")]
		[Token(Token = "0x600012A")]
		 get { } //Length: 131
	}

	[Address(RVA = "0x28A9B20", Offset = "0x28A8F20", Length = "0x24")]
	[Token(Token = "0x6000129")]
	public BitField32DebugView(BitField32 bitfield) { }

	[Address(RVA = "0x28A9B50", Offset = "0x28A8F50", Length = "0x83")]
	[Token(Token = "0x600012A")]
	public Boolean[] get_Bits() { }

}

