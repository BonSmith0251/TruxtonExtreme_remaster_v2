namespace System.Xml.Schema;

[Token(Token = "0x2000164")]
internal abstract class InteriorNode : SyntaxTreeNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400075F")]
	private SyntaxTreeNode leftChild; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000760")]
	private SyntaxTreeNode rightChild; //Field offset: 0x18

	[Token(Token = "0x170003EE")]
	public SyntaxTreeNode LeftChild
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000F15")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000F16")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170003EF")]
	public SyntaxTreeNode RightChild
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000F17")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000F18")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000F1B")]
	protected InteriorNode() { }

	[Address(RVA = "0x25834D0", Offset = "0x25828D0", Length = "0x7F")]
	[Token(Token = "0x6000F1A")]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0x25832B0", Offset = "0x25826B0", Length = "0x214")]
	[Token(Token = "0x6000F19")]
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000F15")]
	public SyntaxTreeNode get_LeftChild() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000F17")]
	public SyntaxTreeNode get_RightChild() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000F16")]
	public void set_LeftChild(SyntaxTreeNode value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000F18")]
	public void set_RightChild(SyntaxTreeNode value) { }

}

