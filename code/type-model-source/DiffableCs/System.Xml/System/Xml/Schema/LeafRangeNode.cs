namespace System.Xml.Schema;

[Token(Token = "0x200016B")]
internal sealed class LeafRangeNode : LeafNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000766")]
	private decimal min; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000767")]
	private decimal max; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000768")]
	private BitSet nextIteration; //Field offset: 0x38

	[Token(Token = "0x170003F8")]
	public virtual bool IsRangeNode
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000F35")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170003F5")]
	public decimal Max
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[Token(Token = "0x6000F31")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170003F6")]
	public decimal Min
	{
		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[Token(Token = "0x6000F32")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170003F7")]
	public BitSet NextIteration
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000F33")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6000F34")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2583FB0", Offset = "0x25833B0", Length = "0x44")]
	[Token(Token = "0x6000F2F")]
	public LeafRangeNode(decimal min, decimal max) { }

	[Address(RVA = "0x2584000", Offset = "0x2583400", Length = "0x4D")]
	[Token(Token = "0x6000F30")]
	public LeafRangeNode(int pos, decimal min, decimal max) { }

	[Address(RVA = "0x2583F60", Offset = "0x2583360", Length = "0x40")]
	[Token(Token = "0x6000F36")]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000F35")]
	public virtual bool get_IsRangeNode() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[Token(Token = "0x6000F31")]
	public decimal get_Max() { }

	[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
	[Token(Token = "0x6000F32")]
	public decimal get_Min() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000F33")]
	public BitSet get_NextIteration() { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6000F34")]
	public void set_NextIteration(BitSet value) { }

}

