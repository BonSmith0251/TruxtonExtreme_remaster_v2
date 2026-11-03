namespace System.Xml.Schema;

[Token(Token = "0x2000163")]
internal class NamespaceListNode : SyntaxTreeNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400075D")]
	protected NamespaceList namespaceList; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400075E")]
	protected object particle; //Field offset: 0x18

	[Token(Token = "0x170003ED")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x2585200", Offset = "0x2584600", Length = "0x3E")]
		[Token(Token = "0x6000F14")]
		 get { } //Length: 62
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000F10")]
	public NamespaceListNode(NamespaceList namespaceList, object particle) { }

	[Address(RVA = "0x2584E20", Offset = "0x2584220", Length = "0x3E")]
	[Token(Token = "0x6000F13")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x2584E60", Offset = "0x2584260", Length = "0x36B")]
	[Token(Token = "0x6000F12")]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0x2585200", Offset = "0x2584600", Length = "0x3E")]
	[Token(Token = "0x6000F14")]
	public virtual bool get_IsNullable() { }

	[Address(RVA = "0x25851D0", Offset = "0x25845D0", Length = "0x24")]
	[Token(Token = "0x6000F11")]
	public override ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

}

