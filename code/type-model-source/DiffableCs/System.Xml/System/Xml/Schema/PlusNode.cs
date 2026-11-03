namespace System.Xml.Schema;

[Token(Token = "0x2000168")]
internal sealed class PlusNode : InteriorNode
{

	[Token(Token = "0x170003F2")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x2370160", Offset = "0x236F560", Length = "0x2A")]
		[Token(Token = "0x6000F27")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000F28")]
	public PlusNode() { }

	[Address(RVA = "0x25884F0", Offset = "0x25878F0", Length = "0x1BA")]
	[Token(Token = "0x6000F26")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x2370160", Offset = "0x236F560", Length = "0x2A")]
	[Token(Token = "0x6000F27")]
	public virtual bool get_IsNullable() { }

}

