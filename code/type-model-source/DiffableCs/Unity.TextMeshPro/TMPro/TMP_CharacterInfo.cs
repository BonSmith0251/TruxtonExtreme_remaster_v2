namespace TMPro;

[DebuggerDisplay("Unicode '{character}'  ({((uint)character).ToString(\"X\")})")]
[Token(Token = "0x2000030")]
public struct TMP_CharacterInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000142")]
	public TMP_TextElementType elementType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000143")]
	public char character; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000144")]
	public int index; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000145")]
	public int stringLength; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000146")]
	public TMP_TextElement textElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000147")]
	public Glyph alternativeGlyph; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000148")]
	public TMP_FontAsset fontAsset; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000149")]
	public Material material; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400014A")]
	public int materialReferenceIndex; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400014B")]
	public bool isUsingAlternateTypeface; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400014C")]
	public float pointSize; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400014D")]
	public int lineNumber; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400014E")]
	public int pageNumber; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400014F")]
	public int vertexIndex; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000150")]
	public TMP_Vertex vertex_BL; //Field offset: 0x48
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000151")]
	public TMP_Vertex vertex_TL; //Field offset: 0x70
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000152")]
	public TMP_Vertex vertex_TR; //Field offset: 0x98
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000153")]
	public TMP_Vertex vertex_BR; //Field offset: 0xC0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000154")]
	public Vector3 topLeft; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000155")]
	public Vector3 bottomLeft; //Field offset: 0xF4
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000156")]
	public Vector3 topRight; //Field offset: 0x100
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4000157")]
	public Vector3 bottomRight; //Field offset: 0x10C
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000158")]
	public float origin; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000159")]
	public float xAdvance; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400015A")]
	public float ascender; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x400015B")]
	public float baseLine; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400015C")]
	public float descender; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x400015D")]
	internal float adjustedAscender; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400015E")]
	internal float adjustedDescender; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x400015F")]
	internal float adjustedHorizontalAdvance; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000160")]
	public float aspectRatio; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x4000161")]
	public float scale; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000162")]
	public Color32 color; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x4000163")]
	public Color32 underlineColor; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000164")]
	public int underlineVertexIndex; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x4000165")]
	public Color32 strikethroughColor; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000166")]
	public int strikethroughVertexIndex; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4000167")]
	public Color32 highlightColor; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000168")]
	public HighlightState highlightState; //Field offset: 0x158
	[FieldOffset(Offset = "0x16C")]
	[Token(Token = "0x4000169")]
	public FontStyles style; //Field offset: 0x16C
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400016A")]
	public bool isVisible; //Field offset: 0x170

}

