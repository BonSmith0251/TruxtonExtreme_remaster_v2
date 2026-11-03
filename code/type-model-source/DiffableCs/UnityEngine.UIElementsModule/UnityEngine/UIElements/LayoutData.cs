namespace UnityEngine.UIElements;

[Token(Token = "0x20003FA")]
internal struct LayoutData : IStyleDataGroup<LayoutData>, IEquatable<LayoutData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D38")]
	public Align alignContent; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000D39")]
	public Align alignItems; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D3A")]
	public Align alignSelf; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000D3B")]
	public Ratio aspectRatio; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D3C")]
	public float borderBottomWidth; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D3D")]
	public float borderLeftWidth; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D3E")]
	public float borderRightWidth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000D3F")]
	public float borderTopWidth; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D40")]
	public Length bottom; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D41")]
	public DisplayStyle display; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000D42")]
	public Length flexBasis; //Field offset: 0x2C
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000D43")]
	public FlexDirection flexDirection; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D44")]
	public float flexGrow; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000D45")]
	public float flexShrink; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D46")]
	public Wrap flexWrap; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000D47")]
	public Length height; //Field offset: 0x44
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000D48")]
	public Justify justifyContent; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000D49")]
	public Length left; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D4A")]
	public Length marginBottom; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D4B")]
	public Length marginLeft; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D4C")]
	public Length marginRight; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D4D")]
	public Length marginTop; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D4E")]
	public Length maxHeight; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D4F")]
	public Length maxWidth; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000D50")]
	public Length minHeight; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000D51")]
	public Length minWidth; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000D52")]
	public Length paddingBottom; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000D53")]
	public Length paddingLeft; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000D54")]
	public Length paddingRight; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000D55")]
	public Length paddingTop; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000D56")]
	public Position position; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000D57")]
	public Length right; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000D58")]
	public Length top; //Field offset: 0xC4
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x4000D59")]
	public Length width; //Field offset: 0xCC

	[Address(RVA = "0x326F140", Offset = "0x326E540", Length = "0x80")]
	[Token(Token = "0x6001E3B")]
	public override LayoutData Copy() { }

	[Address(RVA = "0x326F030", Offset = "0x326E430", Length = "0x10F")]
	[Token(Token = "0x6001E3C")]
	public override void CopyFrom(ref LayoutData other) { }

	[Address(RVA = "0x326F2E0", Offset = "0x326E6E0", Length = "0x12A")]
	[Token(Token = "0x6001E3E")]
	public override bool Equals(LayoutData other) { }

	[Address(RVA = "0x326F1C0", Offset = "0x326E5C0", Length = "0x11E")]
	[Token(Token = "0x6001E3F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x326F410", Offset = "0x326E810", Length = "0x353")]
	[Token(Token = "0x6001E40")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x326F770", Offset = "0x326EB70", Length = "0x2939")]
	[Token(Token = "0x6001E3D")]
	public static bool op_Equality(LayoutData lhs, LayoutData rhs) { }

}

