namespace UnityEngine.UIElements;

[Token(Token = "0x20003FB")]
internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D5A")]
	public Cursor cursor; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D5B")]
	public TextOverflow textOverflow; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000D5C")]
	public Color unityBackgroundImageTintColor; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000D5D")]
	public OverflowClipBox unityOverflowClipBox; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D5E")]
	public int unitySliceBottom; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000D5F")]
	public int unitySliceLeft; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D60")]
	public int unitySliceRight; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000D61")]
	public float unitySliceScale; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D62")]
	public int unitySliceTop; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000D63")]
	public SliceType unitySliceType; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000D64")]
	public TextOverflowPosition unityTextOverflowPosition; //Field offset: 0x48

	[Address(RVA = "0x3275080", Offset = "0x3274480", Length = "0x2A")]
	[Token(Token = "0x6001E41")]
	public override RareData Copy() { }

	[Address(RVA = "0x3275050", Offset = "0x3274450", Length = "0x2D")]
	[Token(Token = "0x6001E42")]
	public override void CopyFrom(ref RareData other) { }

	[Address(RVA = "0x3275170", Offset = "0x3274570", Length = "0x1BB")]
	[Token(Token = "0x6001E44")]
	public override bool Equals(RareData other) { }

	[Address(RVA = "0x32750B0", Offset = "0x32744B0", Length = "0xBA")]
	[Token(Token = "0x6001E45")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3275330", Offset = "0x3274730", Length = "0xEB")]
	[Token(Token = "0x6001E46")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3275420", Offset = "0x3274820", Length = "0x16B")]
	[Token(Token = "0x6001E43")]
	public static bool op_Equality(RareData lhs, RareData rhs) { }

}

