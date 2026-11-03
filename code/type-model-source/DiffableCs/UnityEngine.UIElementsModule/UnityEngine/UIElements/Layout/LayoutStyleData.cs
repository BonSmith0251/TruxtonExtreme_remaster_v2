namespace UnityEngine.UIElements.Layout;

[NativeHeader("Modules/UIElements/Core/Layout/Native/LayoutModel.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000627")]
internal struct LayoutStyleData
{
	[Token(Token = "0x4001698")]
	public static LayoutStyleData Default; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001699")]
	public LayoutDirection Direction; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400169A")]
	public LayoutFlexDirection FlexDirection; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400169B")]
	public LayoutJustify JustifyContent; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400169C")]
	public LayoutAlign AlignContent; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400169D")]
	public LayoutAlign AlignItems; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400169E")]
	public LayoutAlign AlignSelf; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400169F")]
	public LayoutPositionType PositionType; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40016A0")]
	public float AspectRatio; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016A1")]
	public LayoutWrap FlexWrap; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40016A2")]
	public LayoutOverflow Overflow; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40016A3")]
	public LayoutDisplay Display; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40016A4")]
	public float FlexGrow; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40016A5")]
	public float FlexShrink; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40016A6")]
	public LayoutValue FlexBasis; //Field offset: 0x34
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40016A7")]
	public FixedBuffer9<LayoutValue> border; //Field offset: 0x3C
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40016A8")]
	public FixedBuffer9<LayoutValue> position; //Field offset: 0x84
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40016A9")]
	public FixedBuffer9<LayoutValue> margin; //Field offset: 0xCC
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x40016AA")]
	public FixedBuffer9<LayoutValue> padding; //Field offset: 0x114
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x40016AB")]
	public FixedBuffer2<LayoutValue> maxDimensions; //Field offset: 0x15C
	[FieldOffset(Offset = "0x16C")]
	[Token(Token = "0x40016AC")]
	public FixedBuffer2<LayoutValue> minDimensions; //Field offset: 0x16C
	[FieldOffset(Offset = "0x17C")]
	[Token(Token = "0x40016AD")]
	public FixedBuffer2<LayoutValue> dimensions; //Field offset: 0x17C

	[Address(RVA = "0x3323CA0", Offset = "0x33230A0", Length = "0x221")]
	[Token(Token = "0x6002B8B")]
	private static LayoutStyleData() { }

}

