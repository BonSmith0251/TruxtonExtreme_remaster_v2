namespace System.Xml.Schema;

[Token(Token = "0x2000165")]
internal sealed class SequenceNode : InteriorNode
{
	[Token(Token = "0x2000166")]
	private struct SequenceConstructPosContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000761")]
		public SequenceNode this_; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000762")]
		public BitSet firstpos; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000763")]
		public BitSet lastpos; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000764")]
		public BitSet lastposLeft; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000765")]
		public BitSet firstposRight; //Field offset: 0x20

		[Address(RVA = "0x2589080", Offset = "0x2588480", Length = "0x6F")]
		[Token(Token = "0x6000F20")]
		public SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

	}


	[Token(Token = "0x170003F0")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x25898E0", Offset = "0x2588CE0", Length = "0x19D")]
		[Token(Token = "0x6000F1D")]
		 get { } //Length: 413
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000F1F")]
	public SequenceNode() { }

	[Address(RVA = "0x25890F0", Offset = "0x25884F0", Length = "0x7EC")]
	[Token(Token = "0x6000F1C")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x257F520", Offset = "0x257E920", Length = "0xE")]
	[Token(Token = "0x6000F1E")]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0x25898E0", Offset = "0x2588CE0", Length = "0x19D")]
	[Token(Token = "0x6000F1D")]
	public virtual bool get_IsNullable() { }

}

