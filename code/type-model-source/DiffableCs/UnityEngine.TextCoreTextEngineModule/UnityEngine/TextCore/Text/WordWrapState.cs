namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000058")]
internal struct WordWrapState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000339")]
	public int previousWordBreak; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400033A")]
	public int totalCharacterCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400033B")]
	public int visibleCharacterCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400033C")]
	public int visibleSpaceCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400033D")]
	public int visibleSpriteCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400033E")]
	public int visibleLinkCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400033F")]
	public int firstCharacterIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000340")]
	public int firstVisibleCharacterIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000341")]
	public int lastCharacterIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000342")]
	public int lastVisibleCharIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000343")]
	public int lineNumber; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000344")]
	public float maxCapHeight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000345")]
	public float maxAscender; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000346")]
	public float maxDescender; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000347")]
	public float maxLineAscender; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000348")]
	public float maxLineDescender; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000349")]
	public float startOfLineAscender; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400034A")]
	public float xAdvance; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400034B")]
	public float preferredWidth; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400034C")]
	public float preferredHeight; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400034D")]
	public float previousLineScale; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400034E")]
	public float pageAscender; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400034F")]
	public int wordCount; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000350")]
	public FontStyles fontStyle; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000351")]
	public float fontScale; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000352")]
	public float fontScaleMultiplier; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000353")]
	public int italicAngle; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000354")]
	public float currentFontSize; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000355")]
	public float baselineOffset; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000356")]
	public float lineOffset; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000357")]
	public TextInfo textInfo; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000358")]
	public LineInfo lineInfo; //Field offset: 0x80
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000359")]
	public Color32 vertexColor; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x400035A")]
	public Color32 underlineColor; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400035B")]
	public Color32 strikethroughColor; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x400035C")]
	public Color32 highlightColor; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400035D")]
	public HighlightState highlightState; //Field offset: 0xF0
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400035E")]
	public FontStyleStack basicStyleStack; //Field offset: 0x104
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400035F")]
	public TextProcessingStack<Int32> italicAngleStack; //Field offset: 0x110
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000360")]
	public TextProcessingStack<Color32> colorStack; //Field offset: 0x130
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000361")]
	public TextProcessingStack<Color32> underlineColorStack; //Field offset: 0x150
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000362")]
	public TextProcessingStack<Color32> strikethroughColorStack; //Field offset: 0x170
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000363")]
	public TextProcessingStack<Color32> highlightColorStack; //Field offset: 0x190
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000364")]
	public TextProcessingStack<HighlightState> highlightStateStack; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000365")]
	public TextProcessingStack<TextColorGradient> colorGradientStack; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000366")]
	public TextProcessingStack<Single> sizeStack; //Field offset: 0x208
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000367")]
	public TextProcessingStack<Single> indentStack; //Field offset: 0x228
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000368")]
	public TextProcessingStack<TextFontWeight> fontWeightStack; //Field offset: 0x248
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000369")]
	public TextProcessingStack<Int32> styleStack; //Field offset: 0x268
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x400036A")]
	public TextProcessingStack<Single> baselineStack; //Field offset: 0x288
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x400036B")]
	public TextProcessingStack<Int32> actionStack; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x400036C")]
	public TextProcessingStack<MaterialReference> materialReferenceStack; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x400036D")]
	public TextProcessingStack<TextAlignment> lineJustificationStack; //Field offset: 0x320
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x400036E")]
	public int lastBaseGlyphIndex; //Field offset: 0x340
	[FieldOffset(Offset = "0x344")]
	[Token(Token = "0x400036F")]
	public int spriteAnimationId; //Field offset: 0x344
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x4000370")]
	public FontAsset currentFontAsset; //Field offset: 0x348
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x4000371")]
	public SpriteAsset currentSpriteAsset; //Field offset: 0x350
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000372")]
	public Material currentMaterial; //Field offset: 0x358
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000373")]
	public int currentMaterialIndex; //Field offset: 0x360
	[FieldOffset(Offset = "0x364")]
	[Token(Token = "0x4000374")]
	public Extents meshExtents; //Field offset: 0x364
	[FieldOffset(Offset = "0x374")]
	[Token(Token = "0x4000375")]
	public bool tagNoParsing; //Field offset: 0x374
	[FieldOffset(Offset = "0x375")]
	[Token(Token = "0x4000376")]
	public bool isNonBreakingSpace; //Field offset: 0x375
	[FieldOffset(Offset = "0x376")]
	[Token(Token = "0x4000377")]
	public bool isDrivenLineSpacing; //Field offset: 0x376
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x4000378")]
	public Vector3 fxScale; //Field offset: 0x378
	[FieldOffset(Offset = "0x384")]
	[Token(Token = "0x4000379")]
	public Quaternion fxRotation; //Field offset: 0x384

}

