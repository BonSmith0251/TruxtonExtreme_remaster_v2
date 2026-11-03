namespace Unity.Collections;

[Token(Token = "0x200003B")]
internal sealed class BitField64DebugView
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000085")]
	private BitField64 Data; //Field offset: 0x10

	[Token(Token = "0x1700002B")]
	public Boolean[] Bits
	{
		[Address(RVA = "0x28A9EB0", Offset = "0x28A92B0", Length = "0x85")]
		[Token(Token = "0x6000139")]
		 get { } //Length: 133
	}

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x6000138")]
	public BitField64DebugView(BitField64 data) { }

	[Address(RVA = "0x28A9EB0", Offset = "0x28A92B0", Length = "0x85")]
	[Token(Token = "0x6000139")]
	public Boolean[] get_Bits() { }

}

