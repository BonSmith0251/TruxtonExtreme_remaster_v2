namespace System.Xml.Schema;

[Token(Token = "0x2000161")]
internal abstract class SyntaxTreeNode
{

	[Token(Token = "0x170003E9")]
	public abstract bool IsNullable
	{
		[Token(Token = "0x6000F07")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170003EA")]
	public override bool IsRangeNode
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000F08")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000F09")]
	protected SyntaxTreeNode() { }

	[Token(Token = "0x6000F06")]
	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Token(Token = "0x6000F05")]
	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Token(Token = "0x6000F07")]
	public abstract bool get_IsNullable() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000F08")]
	public override bool get_IsRangeNode() { }

}

