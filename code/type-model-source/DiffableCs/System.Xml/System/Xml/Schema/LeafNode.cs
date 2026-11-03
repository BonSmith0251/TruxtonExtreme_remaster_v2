namespace System.Xml.Schema;

[Token(Token = "0x2000162")]
internal class LeafNode : SyntaxTreeNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400075C")]
	private int pos; //Field offset: 0x10

	[Token(Token = "0x170003EC")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000F0F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170003EB")]
	public int Pos
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000F0B")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000F0C")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x6000F0A")]
	public LeafNode(int pos) { }

	[Address(RVA = "0x2583E90", Offset = "0x2583290", Length = "0xC6")]
	[Token(Token = "0x6000F0E")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F0D")]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000F0F")]
	public virtual bool get_IsNullable() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000F0B")]
	public int get_Pos() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000F0C")]
	public void set_Pos(int value) { }

}

