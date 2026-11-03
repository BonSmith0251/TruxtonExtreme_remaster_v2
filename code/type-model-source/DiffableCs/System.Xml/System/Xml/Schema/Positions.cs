namespace System.Xml.Schema;

[DefaultMember("Item")]
[Token(Token = "0x2000160")]
internal class Positions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400075B")]
	private ArrayList positions; //Field offset: 0x10

	[Token(Token = "0x170003E8")]
	public int Count
	{
		[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
		[Token(Token = "0x6000F03")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003E7")]
	public Position Item
	{
		[Address(RVA = "0x25887D0", Offset = "0x2587BD0", Length = "0x9A")]
		[Token(Token = "0x6000F02")]
		 get { } //Length: 154
	}

	[Address(RVA = "0x2588760", Offset = "0x2587B60", Length = "0x66")]
	[Token(Token = "0x6000F04")]
	public Positions() { }

	[Address(RVA = "0x25886B0", Offset = "0x2587AB0", Length = "0xA5")]
	[Token(Token = "0x6000F01")]
	public int Add(int symbol, object particle) { }

	[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
	[Token(Token = "0x6000F03")]
	public int get_Count() { }

	[Address(RVA = "0x25887D0", Offset = "0x2587BD0", Length = "0x9A")]
	[Token(Token = "0x6000F02")]
	public Position get_Item(int pos) { }

}

