namespace UnityEngine.UIElements;

[Token(Token = "0x20003FE")]
internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D6D")]
	public Color backgroundColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D6E")]
	public Background backgroundImage; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D6F")]
	public BackgroundPosition backgroundPositionX; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000D70")]
	public BackgroundPosition backgroundPositionY; //Field offset: 0x3C
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000D71")]
	public BackgroundRepeat backgroundRepeat; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000D72")]
	public BackgroundSize backgroundSize; //Field offset: 0x50
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000D73")]
	public Color borderBottomColor; //Field offset: 0x64
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000D74")]
	public Length borderBottomLeftRadius; //Field offset: 0x74
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000D75")]
	public Length borderBottomRightRadius; //Field offset: 0x7C
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000D76")]
	public Color borderLeftColor; //Field offset: 0x84
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000D77")]
	public Color borderRightColor; //Field offset: 0x94
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000D78")]
	public Color borderTopColor; //Field offset: 0xA4
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000D79")]
	public Length borderTopLeftRadius; //Field offset: 0xB4
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000D7A")]
	public Length borderTopRightRadius; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000D7B")]
	public List<FilterFunction> filter; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000D7C")]
	public float opacity; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x4000D7D")]
	public OverflowInternal overflow; //Field offset: 0xD4

	[Address(RVA = "0x3282DF0", Offset = "0x32821F0", Length = "0x20D")]
	[Token(Token = "0x6001E53")]
	public override VisualData Copy() { }

	[Address(RVA = "0x3282C70", Offset = "0x3282070", Length = "0x171")]
	[Token(Token = "0x6001E54")]
	public override void CopyFrom(ref VisualData other) { }

	[Address(RVA = "0x3283000", Offset = "0x3282400", Length = "0x12D")]
	[Token(Token = "0x6001E56")]
	public override bool Equals(VisualData other) { }

	[Address(RVA = "0x3283130", Offset = "0x3282530", Length = "0x120")]
	[Token(Token = "0x6001E57")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3283260", Offset = "0x3282660", Length = "0x328")]
	[Token(Token = "0x6001E58")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3283590", Offset = "0x3282990", Length = "0x1517")]
	[Token(Token = "0x6001E55")]
	public static bool op_Equality(VisualData lhs, VisualData rhs) { }

}

