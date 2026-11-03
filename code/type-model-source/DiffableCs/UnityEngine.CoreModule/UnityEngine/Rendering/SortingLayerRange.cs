namespace UnityEngine.Rendering;

[Token(Token = "0x20003F5")]
public struct SortingLayerRange : IEquatable<SortingLayerRange>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D1C")]
	private short m_LowerBound; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000D1D")]
	private short m_UpperBound; //Field offset: 0x2

	[Token(Token = "0x17000471")]
	public static SortingLayerRange all
	{
		[Address(RVA = "0x30CD420", Offset = "0x30CC820", Length = "0xD")]
		[Token(Token = "0x6001E93")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700046F")]
	public short lowerBound
	{
		[Address(RVA = "0x30CD430", Offset = "0x30CC830", Length = "0x6")]
		[Token(Token = "0x6001E91")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000470")]
	public short upperBound
	{
		[Address(RVA = "0x30CD440", Offset = "0x30CC840", Length = "0x7")]
		[Token(Token = "0x6001E92")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1F77C20", Offset = "0x1F77020", Length = "0x9")]
	[Token(Token = "0x6001E90")]
	public SortingLayerRange(short lowerBound, short upperBound) { }

	[Address(RVA = "0x30CD340", Offset = "0x30CC740", Length = "0x13")]
	[Token(Token = "0x6001E94")]
	public override bool Equals(SortingLayerRange other) { }

	[Address(RVA = "0x30CD360", Offset = "0x30CC760", Length = "0xA0")]
	[Token(Token = "0x6001E95")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30CD420", Offset = "0x30CC820", Length = "0xD")]
	[Token(Token = "0x6001E93")]
	public static SortingLayerRange get_all() { }

	[Address(RVA = "0x30CD430", Offset = "0x30CC830", Length = "0x6")]
	[Token(Token = "0x6001E91")]
	public short get_lowerBound() { }

	[Address(RVA = "0x30CD440", Offset = "0x30CC840", Length = "0x7")]
	[Token(Token = "0x6001E92")]
	public short get_upperBound() { }

	[Address(RVA = "0x30CD410", Offset = "0x30CC810", Length = "0xF")]
	[Token(Token = "0x6001E96")]
	public virtual int GetHashCode() { }

}

