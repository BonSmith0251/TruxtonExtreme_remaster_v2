namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000046")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct TextElementInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D6")]
	public uint character; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001D7")]
	public int index; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001D8")]
	public TextElementType elementType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001D9")]
	public int stringLength; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001DA")]
	public TextElement textElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001DB")]
	public Glyph alternativeGlyph; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001DC")]
	public FontAsset fontAsset; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001DD")]
	public SpriteAsset spriteAsset; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001DE")]
	public Material material; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001DF")]
	public int materialReferenceIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40001E0")]
	public bool isUsingAlternateTypeface; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001E1")]
	public float pointSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40001E2")]
	public int lineNumber; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001E3")]
	public int vertexIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40001E4")]
	public TextVertex vertexTopLeft; //Field offset: 0x4C
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40001E5")]
	public TextVertex vertexBottomLeft; //Field offset: 0x74
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40001E6")]
	public TextVertex vertexTopRight; //Field offset: 0x9C
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40001E7")]
	public TextVertex vertexBottomRight; //Field offset: 0xC4
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x40001E8")]
	public Vector3 topLeft; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40001E9")]
	public Vector3 bottomLeft; //Field offset: 0xF8
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x40001EA")]
	public Vector3 topRight; //Field offset: 0x104
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40001EB")]
	public Vector3 bottomRight; //Field offset: 0x110
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x40001EC")]
	public float origin; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40001ED")]
	public float ascender; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x40001EE")]
	public float baseLine; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40001EF")]
	public float descender; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x40001F0")]
	internal float adjustedAscender; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40001F1")]
	internal float adjustedDescender; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x40001F2")]
	internal float adjustedHorizontalAdvance; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40001F3")]
	public float xAdvance; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x40001F4")]
	public float aspectRatio; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40001F5")]
	public float scale; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x40001F6")]
	public Color32 color; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40001F7")]
	public Color32 underlineColor; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x40001F8")]
	public int underlineVertexIndex; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40001F9")]
	public Color32 strikethroughColor; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x40001FA")]
	public int strikethroughVertexIndex; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40001FB")]
	public Color32 highlightColor; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x40001FC")]
	public HighlightState highlightState; //Field offset: 0x15C
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40001FD")]
	public FontStyles style; //Field offset: 0x170
	[FieldOffset(Offset = "0x174")]
	[Token(Token = "0x40001FE")]
	public bool isVisible; //Field offset: 0x174

	[Address(RVA = "0x31B34D0", Offset = "0x31B28D0", Length = "0x20B4")]
	[Token(Token = "0x60001E9")]
	public virtual string ToString() { }

}

