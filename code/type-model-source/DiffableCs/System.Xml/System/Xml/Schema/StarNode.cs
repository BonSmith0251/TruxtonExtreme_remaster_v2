namespace System.Xml.Schema;

[Token(Token = "0x200016A")]
internal sealed class StarNode : InteriorNode
{

	[Token(Token = "0x170003F4")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000F2D")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000F2E")]
	public StarNode() { }

	[Address(RVA = "0x25884F0", Offset = "0x25878F0", Length = "0x1BA")]
	[Token(Token = "0x6000F2C")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000F2D")]
	public virtual bool get_IsNullable() { }

}

