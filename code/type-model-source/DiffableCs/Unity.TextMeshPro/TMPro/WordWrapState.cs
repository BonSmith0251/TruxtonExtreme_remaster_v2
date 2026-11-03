namespace TMPro;

[Token(Token = "0x2000028")]
internal struct WordWrapState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E1")]
	public int previous_WordBreak; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000E2")]
	public int total_CharacterCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000E3")]
	public int visible_CharacterCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000E4")]
	public int visibleSpaceCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000E5")]
	public int visible_SpriteCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000E6")]
	public int visible_LinkCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E7")]
	public int firstCharacterIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000E8")]
	public int firstVisibleCharacterIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E9")]
	public int lastCharacterIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000EA")]
	public int lastVisibleCharIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000EB")]
	public int lineNumber; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000EC")]
	public float maxCapHeight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000ED")]
	public float maxAscender; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000EE")]
	public float maxDescender; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000EF")]
	public float startOfLineAscender; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000F0")]
	public float maxLineAscender; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000F1")]
	public float maxLineDescender; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000F2")]
	public float pageAscender; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000F3")]
	public HorizontalAlignmentOptions horizontalAlignment; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40000F4")]
	public float marginLeft; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000F5")]
	public float marginRight; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40000F6")]
	public float xAdvance; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000F7")]
	public float preferredWidth; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40000F8")]
	public float preferredHeight; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000F9")]
	public float renderedWidth; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40000FA")]
	public float renderedHeight; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000FB")]
	public float previousLineScale; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40000FC")]
	public int wordCount; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000FD")]
	public FontStyles fontStyle; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40000FE")]
	public int italicAngle; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000FF")]
	public float fontScaleMultiplier; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000100")]
	public float currentFontSize; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000101")]
	public float baselineOffset; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000102")]
	public float lineOffset; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000103")]
	public bool isDrivenLineSpacing; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000104")]
	public int lastBaseGlyphIndex; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000105")]
	public float cSpace; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000106")]
	public float mSpace; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000107")]
	public TMP_TextInfo textInfo; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000108")]
	public TMP_LineInfo lineInfo; //Field offset: 0xA0
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000109")]
	public Color32 vertexColor; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400010A")]
	public Color32 underlineColor; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400010B")]
	public Color32 strikethroughColor; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x400010C")]
	public HighlightState highlightState; //Field offset: 0x10C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400010D")]
	public TMP_FontStyleStack basicStyleStack; //Field offset: 0x120
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400010E")]
	public TMP_TextProcessingStack<Int32> italicAngleStack; //Field offset: 0x130
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400010F")]
	public TMP_TextProcessingStack<Color32> colorStack; //Field offset: 0x150
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000110")]
	public TMP_TextProcessingStack<Color32> underlineColorStack; //Field offset: 0x170
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000111")]
	public TMP_TextProcessingStack<Color32> strikethroughColorStack; //Field offset: 0x190
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000112")]
	public TMP_TextProcessingStack<Color32> highlightColorStack; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000113")]
	public TMP_TextProcessingStack<HighlightState> highlightStateStack; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000114")]
	public TMP_TextProcessingStack<TMP_ColorGradient> colorGradientStack; //Field offset: 0x200
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000115")]
	public TMP_TextProcessingStack<Single> sizeStack; //Field offset: 0x228
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000116")]
	public TMP_TextProcessingStack<Single> indentStack; //Field offset: 0x248
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000117")]
	public TMP_TextProcessingStack<FontWeight> fontWeightStack; //Field offset: 0x268
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000118")]
	public TMP_TextProcessingStack<Int32> styleStack; //Field offset: 0x288
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000119")]
	public TMP_TextProcessingStack<Single> baselineStack; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x400011A")]
	public TMP_TextProcessingStack<Int32> actionStack; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x400011B")]
	public TMP_TextProcessingStack<MaterialReference> materialReferenceStack; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x400011C")]
	public TMP_TextProcessingStack<HorizontalAlignmentOptions> lineJustificationStack; //Field offset: 0x340
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x400011D")]
	public int spriteAnimationID; //Field offset: 0x360
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x400011E")]
	public TMP_FontAsset currentFontAsset; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x400011F")]
	public TMP_SpriteAsset currentSpriteAsset; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x4000120")]
	public Material currentMaterial; //Field offset: 0x378
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x4000121")]
	public int currentMaterialIndex; //Field offset: 0x380
	[FieldOffset(Offset = "0x384")]
	[Token(Token = "0x4000122")]
	public Extents meshExtents; //Field offset: 0x384
	[FieldOffset(Offset = "0x394")]
	[Token(Token = "0x4000123")]
	public bool tagNoParsing; //Field offset: 0x394
	[FieldOffset(Offset = "0x395")]
	[Token(Token = "0x4000124")]
	public bool isNonBreakingSpace; //Field offset: 0x395
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x4000125")]
	public Quaternion fxRotation; //Field offset: 0x398
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x4000126")]
	public Vector3 fxScale; //Field offset: 0x3A8

}

