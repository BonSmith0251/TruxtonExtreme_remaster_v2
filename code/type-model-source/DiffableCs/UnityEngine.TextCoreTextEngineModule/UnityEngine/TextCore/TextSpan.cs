namespace UnityEngine.TextCore;

[Token(Token = "0x2000007")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct TextSpan
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001C")]
	public int startIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400001D")]
	public int length; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001E")]
	public IntPtr fontAsset; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001F")]
	public IntPtr gradientAsset; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000020")]
	public int fontSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000021")]
	public Color32 color; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000022")]
	public FontStyles fontStyle; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000023")]
	public TextFontWeight fontWeight; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000024")]
	public int mspace; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000025")]
	public TagUnitType mspaceUnitType; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000026")]
	public int cspace; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000027")]
	public TagUnitType cspaceUnitType; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000028")]
	public int linkID; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000029")]
	public HorizontalAlignment alignment; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400002A")]
	public Color32 highlightColor; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400002B")]
	public Vector4 highlightPadding; //Field offset: 0x44
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400002C")]
	public GlyphMetrics spriteMetrics; //Field offset: 0x54
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400002D")]
	public int spriteID; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400002E")]
	public bool spriteTint; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400002F")]
	public int spriteScale; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000030")]
	public Color32 spriteColor; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000031")]
	public int margin; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000032")]
	public MarginDirection marginDirection; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000033")]
	public TagUnitType marginUnitType; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000034")]
	public int lineHeight; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000035")]
	public TagUnitType lineHeightUnitType; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000036")]
	public int indent; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000037")]
	public TagUnitType indentUnitType; //Field offset: 0x90

	[Address(RVA = "0x3190DB0", Offset = "0x31901B0", Length = "0x3B0")]
	[Token(Token = "0x600000C")]
	public virtual string ToString() { }

}

