namespace System.Xml;

[Token(Token = "0x2000036")]
internal class ReadContentAsBinaryHelper
{
	[Token(Token = "0x2000037")]
	private enum State : int
	{
		None = 0,
		InReadContent = 1,
		InReadElementContent = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000118")]
	private XmlReader reader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000119")]
	private State state; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400011A")]
	private int valueOffset; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011B")]
	private bool isEnd; //Field offset: 0x20

	[Address(RVA = "0x24EC9D0", Offset = "0x24EBDD0", Length = "0x64")]
	[Token(Token = "0x600019D")]
	internal void Finish() { }

	[Address(RVA = "0x24ECC20", Offset = "0x24EC020", Length = "0x108")]
	[Token(Token = "0x600019F")]
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	[Address(RVA = "0x24ECD70", Offset = "0x24EC170", Length = "0xA")]
	[Token(Token = "0x600019E")]
	internal void Reset() { }

}

