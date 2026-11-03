namespace System.Xml.Schema;

[Token(Token = "0x2000169")]
internal sealed class QmarkNode : InteriorNode
{

	[Token(Token = "0x170003F3")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000F2A")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000F2B")]
	public QmarkNode() { }

	[Address(RVA = "0x2588870", Offset = "0x2587C70", Length = "0x2F")]
	[Token(Token = "0x6000F29")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000F2A")]
	public virtual bool get_IsNullable() { }

}

