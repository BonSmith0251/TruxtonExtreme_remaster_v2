namespace System.Xml;

[Token(Token = "0x200001B")]
internal class ByteStack
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D2")]
	private Byte[] stack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D3")]
	private int growthRate; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000D4")]
	private int top; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D5")]
	private int size; //Field offset: 0x20

	[Address(RVA = "0x23F31C0", Offset = "0x23F25C0", Length = "0x6B")]
	[Token(Token = "0x60000E1")]
	public ByteStack(int growthRate) { }

	[Address(RVA = "0x23F30A0", Offset = "0x23F24A0", Length = "0x43")]
	[Token(Token = "0x60000E3")]
	public byte Pop() { }

	[Address(RVA = "0x23F30F0", Offset = "0x23F24F0", Length = "0xC7")]
	[Token(Token = "0x60000E2")]
	public void Push(byte data) { }

}

