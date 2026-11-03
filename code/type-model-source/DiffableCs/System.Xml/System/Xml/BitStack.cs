namespace System.Xml;

[Token(Token = "0x2000019")]
internal class BitStack
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000CA")]
	private UInt32[] bitStack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000CB")]
	private int stackPos; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000CC")]
	private uint curr; //Field offset: 0x1C

	[Address(RVA = "0x23F2E50", Offset = "0x23F2250", Length = "0x1D")]
	[Token(Token = "0x60000D8")]
	public BitStack() { }

	[Address(RVA = "0x23F2BC0", Offset = "0x23F1FC0", Length = "0x7")]
	[Token(Token = "0x60000DB")]
	public bool PeekBit() { }

	[Address(RVA = "0x23F2BD0", Offset = "0x23F1FD0", Length = "0x56")]
	[Token(Token = "0x60000DA")]
	public bool PopBit() { }

	[Address(RVA = "0x23F2C30", Offset = "0x23F2030", Length = "0x3E")]
	[Token(Token = "0x60000DD")]
	private void PopCurr() { }

	[Address(RVA = "0x23F2C70", Offset = "0x23F2070", Length = "0xFF")]
	[Token(Token = "0x60000D9")]
	public void PushBit(bool bit) { }

	[Address(RVA = "0x23F2D70", Offset = "0x23F2170", Length = "0xDF")]
	[Token(Token = "0x60000DC")]
	private void PushCurr() { }

}

