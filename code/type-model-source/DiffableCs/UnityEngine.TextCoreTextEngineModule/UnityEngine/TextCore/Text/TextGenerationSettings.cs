namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200004B")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal class TextGenerationSettings : IEquatable<TextGenerationSettings>
{
	[Token(Token = "0x40002B5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static Func<Boolean> IsEditorTextRenderingModeBitmap; //Field offset: 0x0
	[Token(Token = "0x40002D4")]
	public const int maxVisibleCharacters = 99999; //Field offset: 0x0
	[Token(Token = "0x40002CD")]
	public const bool tagNoParsing = False; //Field offset: 0x0
	[Token(Token = "0x40002D5")]
	public const int maxVisibleWords = 99999; //Field offset: 0x0
	[Token(Token = "0x40002D6")]
	public const int maxVisibleLines = 99999; //Field offset: 0x0
	[Token(Token = "0x40002D7")]
	public const int firstVisibleCharacter = 0; //Field offset: 0x0
	[Token(Token = "0x40002D8")]
	public const bool useMaxVisibleDescender = False; //Field offset: 0x0
	[Token(Token = "0x40002DB")]
	public const float charWidthMaxAdj = 0; //Field offset: 0x0
	[Token(Token = "0x40002C5")]
	public const float fontSizeMax = 0; //Field offset: 0x0
	[Token(Token = "0x40002C4")]
	public const float fontSizeMin = 0; //Field offset: 0x0
	[Token(Token = "0x40002C3")]
	public const bool autoSize = False; //Field offset: 0x0
	[Token(Token = "0x40002D2")]
	public const float lineSpacingMax = 0; //Field offset: 0x0
	[Token(Token = "0x40002D0")]
	public const float lineSpacing = 0; //Field offset: 0x0
	[Token(Token = "0x40002BF")]
	public const float wordWrappingRatio = 0.4; //Field offset: 0x0
	[Token(Token = "0x40002B6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static Func<Boolean> IsEditorTextRenderingModeRaster; //Field offset: 0x8
	[Token(Token = "0x40002C6")]
	internal static readonly List<OTL_FeatureTag> fontFeatures; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002B7")]
	private RenderedText m_RenderedText; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002B8")]
	private string m_CachedRenderedText; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002B9")]
	public Rect screenRect; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002BA")]
	public FontAsset fontAsset; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002BB")]
	public FontStyles fontStyle; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002BC")]
	public TextSettings textSettings; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002BD")]
	public TextAlignment textAlignment; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40002BE")]
	public TextOverflowMode overflowMode; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002C0")]
	public Color color; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002C1")]
	public bool shouldConvertToLinearSpace; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40002C2")]
	public int fontSize; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002C7")]
	public bool emojiFallbackSupport; //Field offset: 0x80
	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x40002C8")]
	public bool richText; //Field offset: 0x81
	[FieldOffset(Offset = "0x82")]
	[Token(Token = "0x40002C9")]
	public bool isRightToLeft; //Field offset: 0x82
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40002CA")]
	public float extraPadding; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40002CB")]
	public bool parseControlCharacters; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[Token(Token = "0x40002CC")]
	public bool isPlaceholder; //Field offset: 0x89
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40002CE")]
	public float characterSpacing; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002CF")]
	public float wordSpacing; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40002D1")]
	public float paragraphSpacing; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40002D3")]
	public TextWrappingMode textWrappingMode; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40002D9")]
	public TextFontWeight fontWeight; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40002DA")]
	public bool isIMGUI; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40002DC")]
	public float pixelsPerPoint; //Field offset: 0xA4

	[Token(Token = "0x17000069")]
	public RenderedText renderedText
	{
		[Address(RVA = "0x661A70", Offset = "0x660E70", Length = "0x13")]
		[Token(Token = "0x600021D")]
		 get { } //Length: 19
		[Address(RVA = "0x31B77C0", Offset = "0x31B6BC0", Length = "0x3B")]
		[Token(Token = "0x600021E")]
		 set { } //Length: 59
	}

	[Token(Token = "0x1700006A")]
	public string text
	{
		[Address(RVA = "0x31B7740", Offset = "0x31B6B40", Length = "0x56")]
		[Token(Token = "0x600021F")]
		 get { } //Length: 86
		[Address(RVA = "0x31B7800", Offset = "0x31B6C00", Length = "0x105")]
		[Token(Token = "0x6000220")]
		 set { } //Length: 261
	}

	[Address(RVA = "0x31B75D0", Offset = "0x31B69D0", Length = "0xF2")]
	[Token(Token = "0x6000227")]
	private static TextGenerationSettings() { }

	[Address(RVA = "0x31B76D0", Offset = "0x31B6AD0", Length = "0x63")]
	[Token(Token = "0x6000221")]
	public TextGenerationSettings() { }

	[Address(RVA = "0x31B5C00", Offset = "0x31B5000", Length = "0x35A")]
	[Token(Token = "0x6000222")]
	public override bool Equals(TextGenerationSettings other) { }

	[Address(RVA = "0x31B5F60", Offset = "0x31B5360", Length = "0xF8")]
	[Token(Token = "0x6000223")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x661A70", Offset = "0x660E70", Length = "0x13")]
	[Token(Token = "0x600021D")]
	public RenderedText get_renderedText() { }

	[Address(RVA = "0x31B7740", Offset = "0x31B6B40", Length = "0x56")]
	[Token(Token = "0x600021F")]
	public string get_text() { }

	[Address(RVA = "0x31B6060", Offset = "0x31B5460", Length = "0x2D9")]
	[Token(Token = "0x6000224")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x31B77A0", Offset = "0x31B6BA0", Length = "0x13")]
	[Token(Token = "0x6000225")]
	public static bool op_Inequality(TextGenerationSettings left, TextGenerationSettings right) { }

	[Address(RVA = "0x31B77C0", Offset = "0x31B6BC0", Length = "0x3B")]
	[Token(Token = "0x600021E")]
	public void set_renderedText(RenderedText value) { }

	[Address(RVA = "0x31B7800", Offset = "0x31B6C00", Length = "0x105")]
	[Token(Token = "0x6000220")]
	public void set_text(string value) { }

	[Address(RVA = "0x31B6340", Offset = "0x31B5740", Length = "0x1280")]
	[Token(Token = "0x6000226")]
	public virtual string ToString() { }

}

