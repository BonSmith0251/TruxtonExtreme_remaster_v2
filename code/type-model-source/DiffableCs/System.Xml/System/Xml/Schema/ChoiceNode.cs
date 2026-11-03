namespace System.Xml.Schema;

[Token(Token = "0x2000167")]
internal sealed class ChoiceNode : InteriorNode
{

	[Token(Token = "0x170003F1")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x257F530", Offset = "0x257E930", Length = "0x8E")]
		[Token(Token = "0x6000F23")]
		 get { } //Length: 142
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000F25")]
	public ChoiceNode() { }

	[Address(RVA = "0x257F0A0", Offset = "0x257E4A0", Length = "0x17C")]
	[Token(Token = "0x6000F21")]
	private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x257F220", Offset = "0x257E620", Length = "0x2FC")]
	[Token(Token = "0x6000F22")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x257F520", Offset = "0x257E920", Length = "0xE")]
	[Token(Token = "0x6000F24")]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0x257F530", Offset = "0x257E930", Length = "0x8E")]
	[Token(Token = "0x6000F23")]
	public virtual bool get_IsNullable() { }

}

