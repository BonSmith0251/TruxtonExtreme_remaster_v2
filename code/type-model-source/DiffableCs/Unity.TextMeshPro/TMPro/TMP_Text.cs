namespace TMPro;

[Token(Token = "0x20000A1")]
public abstract class TMP_Text : MaskableGraphic
{
	[CompilerGenerated]
	[Token(Token = "0x20000A8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000631")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000632")]
		public static Action<TMP_TextInfo> <>9__649_0; //Field offset: 0x8

		[Address(RVA = "0x2F19250", Offset = "0x2F18650", Length = "0x67")]
		[Token(Token = "0x6000677")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000678")]
		public <>c() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000679")]
		internal void <.ctor>b__649_0(TMP_TextInfo <p0>) { }

	}

	[Token(Token = "0x20000A3")]
	internal struct CharacterSubstitution
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000620")]
		public int index; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000621")]
		public uint unicode; //Field offset: 0x4

		[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
		[Token(Token = "0x600066D")]
		public CharacterSubstitution(int index, uint unicode) { }

	}

	[Token(Token = "0x20000A2")]
	internal sealed class MissingCharacterEventCallback : MulticastDelegate
	{

		[Address(RVA = "0x2F03F50", Offset = "0x2F03350", Length = "0xA6")]
		[Token(Token = "0x6000669")]
		public MissingCharacterEventCallback(object object, IntPtr method) { }

		[Address(RVA = "0x2F03EB0", Offset = "0x2F032B0", Length = "0x9A")]
		[Token(Token = "0x600066B")]
		public override IAsyncResult BeginInvoke(int unicode, int stringIndex, string text, TMP_FontAsset fontAsset, TMP_Text textComponent, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600066C")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
		[Token(Token = "0x600066A")]
		public override void Invoke(int unicode, int stringIndex, string text, TMP_FontAsset fontAsset, TMP_Text textComponent) { }

	}

	[Token(Token = "0x20000A6")]
	internal struct SpecialCharacter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062B")]
		public TMP_Character character; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400062C")]
		public TMP_FontAsset fontAsset; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400062D")]
		public Material material; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400062E")]
		public int materialIndex; //Field offset: 0x18

		[Address(RVA = "0x2F07700", Offset = "0x2F06B00", Length = "0x15A")]
		[Token(Token = "0x600066E")]
		public SpecialCharacter(TMP_Character character, int materialIndex) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x20000A7")]
	private struct TextBackingContainer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062F")]
		private UInt32[] m_Array; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000630")]
		private int m_Index; //Field offset: 0x8

		[Token(Token = "0x1700018A")]
		public int Capacity
		{
			[Address(RVA = "0xA8E460", Offset = "0xA8D860", Length = "0x19")]
			[Token(Token = "0x6000670")]
			 get { } //Length: 25
		}

		[Token(Token = "0x1700018B")]
		public int Count
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[Token(Token = "0x6000671")]
			 get { } //Length: 4
			[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
			[Token(Token = "0x6000672")]
			 set { } //Length: 4
		}

		[Token(Token = "0x1700018C")]
		public uint Item
		{
			[Address(RVA = "0x2F17CF0", Offset = "0x2F170F0", Length = "0x2A")]
			[Token(Token = "0x6000673")]
			 get { } //Length: 42
			[Address(RVA = "0x2F17D20", Offset = "0x2F17120", Length = "0x5B")]
			[Token(Token = "0x6000674")]
			 set { } //Length: 91
		}

		[Token(Token = "0x17000189")]
		public UInt32[] Text
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x600066F")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x2F17C90", Offset = "0x2F17090", Length = "0x59")]
		[Token(Token = "0x6000675")]
		public TextBackingContainer(int size) { }

		[Address(RVA = "0xA8E460", Offset = "0xA8D860", Length = "0x19")]
		[Token(Token = "0x6000670")]
		public int get_Capacity() { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000671")]
		public int get_Count() { }

		[Address(RVA = "0x2F17CF0", Offset = "0x2F170F0", Length = "0x2A")]
		[Token(Token = "0x6000673")]
		public uint get_Item(int index) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600066F")]
		public UInt32[] get_Text() { }

		[Address(RVA = "0x2F17C20", Offset = "0x2F17020", Length = "0x68")]
		[Token(Token = "0x6000676")]
		public void Resize(int size) { }

		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x6000672")]
		public void set_Count(int value) { }

		[Address(RVA = "0x2F17D20", Offset = "0x2F17120", Length = "0x5B")]
		[Token(Token = "0x6000674")]
		public void set_Item(int index, uint value) { }

	}

	[Token(Token = "0x20000A4")]
	public enum TextInputSources : int
	{
		TextInputBox = 0,
		SetText = 1,
		SetTextArray = 2,
		TextString = 3,
	}

	[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
	[Token(Token = "0x20000A5")]
	public struct TextProcessingElement
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000627")]
		public TextProcessingElementType elementType; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000628")]
		public uint unicode; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000629")]
		public int stringIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400062A")]
		public int length; //Field offset: 0xC

	}

	[Token(Token = "0x400053A")]
	protected static MaterialReference[] m_materialReferences; //Field offset: 0x0
	[Token(Token = "0x400053B")]
	protected static Dictionary<Int32, Int32> m_materialReferenceIndexLookup; //Field offset: 0x8
	[Token(Token = "0x400053C")]
	protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; //Field offset: 0x10
	[Token(Token = "0x4000544")]
	protected static Color32 s_colorWhite; //Field offset: 0x68
	[CompilerGenerated]
	[Token(Token = "0x40005B8")]
	private static Func<Int32, String, TMP_FontAsset> OnFontAssetRequest; //Field offset: 0x70
	[CompilerGenerated]
	[Token(Token = "0x40005B9")]
	private static Func<Int32, String, TMP_SpriteAsset> OnSpriteAssetRequest; //Field offset: 0x78
	[CompilerGenerated]
	[Token(Token = "0x40005BA")]
	private static MissingCharacterEventCallback OnMissingCharacter; //Field offset: 0x80
	[Token(Token = "0x40005D1")]
	private static Char[] m_htmlTag; //Field offset: 0x88
	[Token(Token = "0x40005D2")]
	private static RichTextTagAttribute[] m_xmlAttribute; //Field offset: 0x90
	[Token(Token = "0x40005D3")]
	private static Single[] m_attributeParameterValues; //Field offset: 0x98
	[Token(Token = "0x40005DF")]
	internal static WordWrapState m_SavedWordWrapState; //Field offset: 0xA0
	[Token(Token = "0x40005E0")]
	internal static WordWrapState m_SavedLineState; //Field offset: 0x458
	[Token(Token = "0x40005E1")]
	internal static WordWrapState m_SavedEllipsisState; //Field offset: 0x810
	[Token(Token = "0x40005E2")]
	internal static WordWrapState m_SavedLastValidState; //Field offset: 0xBC8
	[Token(Token = "0x40005E3")]
	internal static WordWrapState m_SavedSoftLineBreakState; //Field offset: 0xF80
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[TextArea(5, 10)]
	[Token(Token = "0x4000531")]
	protected string m_text; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000532")]
	private bool m_IsTextBackingStringDirty; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000533")]
	protected ITextPreprocessor m_TextPreprocessor; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4000534")]
	protected bool m_isRightToLeft; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000535")]
	protected TMP_FontAsset m_fontAsset; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000536")]
	protected TMP_FontAsset m_currentFontAsset; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000537")]
	protected bool m_isSDFShader; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4000538")]
	protected Material m_sharedMaterial; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000539")]
	protected Material m_currentMaterial; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400053D")]
	protected int m_currentMaterialIndex; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x400053E")]
	protected Material[] m_fontSharedMaterials; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x400053F")]
	protected Material m_fontMaterial; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4000540")]
	protected Material[] m_fontMaterials; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000541")]
	protected bool m_isMaterialDirty; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[SerializeField]
	[Token(Token = "0x4000542")]
	protected Color32 m_fontColor32; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x4000543")]
	protected Color m_fontColor; //Field offset: 0x150
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000545")]
	protected Color32 m_underlineColor; //Field offset: 0x160
	[FieldOffset(Offset = "0x164")]
	[Token(Token = "0x4000546")]
	protected Color32 m_strikethroughColor; //Field offset: 0x164
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000547")]
	internal HighlightState m_HighlightState; //Field offset: 0x168
	[FieldOffset(Offset = "0x17C")]
	[Token(Token = "0x4000548")]
	internal bool m_ConvertToLinearSpace; //Field offset: 0x17C
	[FieldOffset(Offset = "0x17D")]
	[SerializeField]
	[Token(Token = "0x4000549")]
	protected bool m_enableVertexGradient; //Field offset: 0x17D
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x400054A")]
	protected ColorMode m_colorMode; //Field offset: 0x180
	[FieldOffset(Offset = "0x184")]
	[SerializeField]
	[Token(Token = "0x400054B")]
	protected VertexGradient m_fontColorGradient; //Field offset: 0x184
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	[Token(Token = "0x400054C")]
	protected TMP_ColorGradient m_fontColorGradientPreset; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x400054D")]
	protected TMP_SpriteAsset m_spriteAsset; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Token(Token = "0x400054E")]
	protected bool m_tintAllSprites; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1D9")]
	[Token(Token = "0x400054F")]
	protected bool m_tintSprite; //Field offset: 0x1D9
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4000550")]
	protected Color32 m_spriteColor; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	[Token(Token = "0x4000551")]
	protected TMP_StyleSheet m_StyleSheet; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000552")]
	internal TMP_Style m_TextStyle; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	[Token(Token = "0x4000553")]
	protected int m_TextStyleHashCode; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F4")]
	[SerializeField]
	[Token(Token = "0x4000554")]
	protected bool m_overrideHtmlColors; //Field offset: 0x1F4
	[FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	[Token(Token = "0x4000555")]
	protected Color32 m_faceColor; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x1FC")]
	[Token(Token = "0x4000556")]
	protected Color32 m_outlineColor; //Field offset: 0x1FC
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000557")]
	protected float m_outlineWidth; //Field offset: 0x200
	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x4000558")]
	protected Vector3 m_currentEnvMapRotation; //Field offset: 0x204
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000559")]
	protected bool m_hasEnvMapProperty; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[SerializeField]
	[Token(Token = "0x400055A")]
	protected float m_fontSize; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400055B")]
	protected float m_currentFontSize; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[SerializeField]
	[Token(Token = "0x400055C")]
	protected float m_fontSizeBase; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400055D")]
	protected TMP_TextProcessingStack<Single> m_sizeStack; //Field offset: 0x220
	[FieldOffset(Offset = "0x240")]
	[SerializeField]
	[Token(Token = "0x400055E")]
	protected FontWeight m_fontWeight; //Field offset: 0x240
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x400055F")]
	protected FontWeight m_FontWeightInternal; //Field offset: 0x244
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000560")]
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; //Field offset: 0x248
	[FieldOffset(Offset = "0x268")]
	[SerializeField]
	[Token(Token = "0x4000561")]
	protected bool m_enableAutoSizing; //Field offset: 0x268
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x4000562")]
	protected float m_maxFontSize; //Field offset: 0x26C
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000563")]
	protected float m_minFontSize; //Field offset: 0x270
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x4000564")]
	protected int m_AutoSizeIterationCount; //Field offset: 0x274
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000565")]
	protected int m_AutoSizeMaxIterationCount; //Field offset: 0x278
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4000566")]
	protected bool m_IsAutoSizePointSizeSet; //Field offset: 0x27C
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	[Token(Token = "0x4000567")]
	protected float m_fontSizeMin; //Field offset: 0x280
	[FieldOffset(Offset = "0x284")]
	[SerializeField]
	[Token(Token = "0x4000568")]
	protected float m_fontSizeMax; //Field offset: 0x284
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	[Token(Token = "0x4000569")]
	protected FontStyles m_fontStyle; //Field offset: 0x288
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x400056A")]
	protected FontStyles m_FontStyleInternal; //Field offset: 0x28C
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400056B")]
	protected TMP_FontStyleStack m_fontStyleStack; //Field offset: 0x290
	[FieldOffset(Offset = "0x29A")]
	[Token(Token = "0x400056C")]
	protected bool m_isUsingBold; //Field offset: 0x29A
	[FieldOffset(Offset = "0x29C")]
	[SerializeField]
	[Token(Token = "0x400056D")]
	protected HorizontalAlignmentOptions m_HorizontalAlignment; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	[Token(Token = "0x400056E")]
	protected VerticalAlignmentOptions m_VerticalAlignment; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A4")]
	[FormerlySerializedAs("m_lineJustification")]
	[SerializeField]
	[Token(Token = "0x400056F")]
	protected TextAlignmentOptions m_textAlignment; //Field offset: 0x2A4
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000570")]
	protected HorizontalAlignmentOptions m_lineJustification; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000571")]
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000572")]
	protected Vector3[] m_textContainerLocalCorners; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[SerializeField]
	[Token(Token = "0x4000573")]
	protected float m_characterSpacing; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2DC")]
	[Token(Token = "0x4000574")]
	protected float m_cSpacing; //Field offset: 0x2DC
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000575")]
	protected float m_monoSpacing; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E4")]
	[Token(Token = "0x4000576")]
	protected bool m_duoSpace; //Field offset: 0x2E4
	[FieldOffset(Offset = "0x2E8")]
	[SerializeField]
	[Token(Token = "0x4000577")]
	 float m_characterHorizontalScale; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2EC")]
	[SerializeField]
	[Token(Token = "0x4000578")]
	protected float m_wordSpacing; //Field offset: 0x2EC
	[FieldOffset(Offset = "0x2F0")]
	[SerializeField]
	[Token(Token = "0x4000579")]
	protected float m_lineSpacing; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x400057A")]
	protected float m_lineSpacingDelta; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x400057B")]
	protected float m_lineHeight; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2FC")]
	[Token(Token = "0x400057C")]
	protected bool m_IsDrivenLineSpacing; //Field offset: 0x2FC
	[FieldOffset(Offset = "0x300")]
	[SerializeField]
	[Token(Token = "0x400057D")]
	protected float m_lineSpacingMax; //Field offset: 0x300
	[FieldOffset(Offset = "0x304")]
	[SerializeField]
	[Token(Token = "0x400057E")]
	protected float m_paragraphSpacing; //Field offset: 0x304
	[FieldOffset(Offset = "0x308")]
	[SerializeField]
	[Token(Token = "0x400057F")]
	protected float m_charWidthMaxAdj; //Field offset: 0x308
	[FieldOffset(Offset = "0x30C")]
	[Token(Token = "0x4000580")]
	protected float m_charWidthAdjDelta; //Field offset: 0x30C
	[FieldOffset(Offset = "0x310")]
	[FormerlySerializedAs("m_enableWordWrapping")]
	[SerializeField]
	[Token(Token = "0x4000581")]
	protected TextWrappingModes m_TextWrappingMode; //Field offset: 0x310
	[FieldOffset(Offset = "0x314")]
	[Token(Token = "0x4000582")]
	protected bool m_isCharacterWrappingEnabled; //Field offset: 0x314
	[FieldOffset(Offset = "0x315")]
	[Token(Token = "0x4000583")]
	protected bool m_isNonBreakingSpace; //Field offset: 0x315
	[FieldOffset(Offset = "0x316")]
	[Token(Token = "0x4000584")]
	protected bool m_isIgnoringAlignment; //Field offset: 0x316
	[FieldOffset(Offset = "0x318")]
	[SerializeField]
	[Token(Token = "0x4000585")]
	protected float m_wordWrappingRatios; //Field offset: 0x318
	[FieldOffset(Offset = "0x31C")]
	[SerializeField]
	[Token(Token = "0x4000586")]
	protected TextOverflowModes m_overflowMode; //Field offset: 0x31C
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4000587")]
	protected int m_firstOverflowCharacterIndex; //Field offset: 0x320
	[FieldOffset(Offset = "0x328")]
	[SerializeField]
	[Token(Token = "0x4000588")]
	protected TMP_Text m_linkedTextComponent; //Field offset: 0x328
	[FieldOffset(Offset = "0x330")]
	[SerializeField]
	[Token(Token = "0x4000589")]
	internal TMP_Text parentLinkedComponent; //Field offset: 0x330
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x400058A")]
	protected bool m_isTextTruncated; //Field offset: 0x338
	[Token(Token = "0x40005E4")]
	internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; //Field offset: 0x1338
	[FieldOffset(Offset = "0x339")]
	[SerializeField]
	[Token(Token = "0x400058B")]
	protected bool m_enableKerning; //Field offset: 0x339
	[FieldOffset(Offset = "0x33C")]
	[Token(Token = "0x400058C")]
	protected int m_LastBaseGlyphIndex; //Field offset: 0x33C
	[FieldOffset(Offset = "0x340")]
	[SerializeField]
	[Token(Token = "0x400058D")]
	protected List<OTL_FeatureTag> m_ActiveFontFeatures; //Field offset: 0x340
	[FieldOffset(Offset = "0x348")]
	[SerializeField]
	[Token(Token = "0x400058E")]
	protected bool m_enableExtraPadding; //Field offset: 0x348
	[FieldOffset(Offset = "0x349")]
	[SerializeField]
	[Token(Token = "0x400058F")]
	protected bool checkPaddingRequired; //Field offset: 0x349
	[FieldOffset(Offset = "0x34A")]
	[SerializeField]
	[Token(Token = "0x4000590")]
	protected bool m_isRichText; //Field offset: 0x34A
	[FieldOffset(Offset = "0x34B")]
	[SerializeField]
	[Token(Token = "0x4000591")]
	private bool m_EmojiFallbackSupport; //Field offset: 0x34B
	[FieldOffset(Offset = "0x34C")]
	[SerializeField]
	[Token(Token = "0x4000592")]
	protected bool m_parseCtrlCharacters; //Field offset: 0x34C
	[FieldOffset(Offset = "0x34D")]
	[Token(Token = "0x4000593")]
	protected bool m_isOverlay; //Field offset: 0x34D
	[FieldOffset(Offset = "0x34E")]
	[SerializeField]
	[Token(Token = "0x4000594")]
	protected bool m_isOrthographic; //Field offset: 0x34E
	[FieldOffset(Offset = "0x34F")]
	[SerializeField]
	[Token(Token = "0x4000595")]
	protected bool m_isCullingEnabled; //Field offset: 0x34F
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x4000596")]
	protected bool m_isMaskingEnabled; //Field offset: 0x350
	[FieldOffset(Offset = "0x351")]
	[Token(Token = "0x4000597")]
	protected bool isMaskUpdateRequired; //Field offset: 0x351
	[FieldOffset(Offset = "0x352")]
	[Token(Token = "0x4000598")]
	protected bool m_ignoreCulling; //Field offset: 0x352
	[FieldOffset(Offset = "0x354")]
	[SerializeField]
	[Token(Token = "0x4000599")]
	protected TextureMappingOptions m_horizontalMapping; //Field offset: 0x354
	[FieldOffset(Offset = "0x358")]
	[SerializeField]
	[Token(Token = "0x400059A")]
	protected TextureMappingOptions m_verticalMapping; //Field offset: 0x358
	[FieldOffset(Offset = "0x35C")]
	[SerializeField]
	[Token(Token = "0x400059B")]
	protected float m_uvLineOffset; //Field offset: 0x35C
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x400059C")]
	protected TextRenderFlags m_renderMode; //Field offset: 0x360
	[FieldOffset(Offset = "0x364")]
	[SerializeField]
	[Token(Token = "0x400059D")]
	protected VertexSortingOrder m_geometrySortingOrder; //Field offset: 0x364
	[FieldOffset(Offset = "0x368")]
	[SerializeField]
	[Token(Token = "0x400059E")]
	protected bool m_IsTextObjectScaleStatic; //Field offset: 0x368
	[FieldOffset(Offset = "0x369")]
	[SerializeField]
	[Token(Token = "0x400059F")]
	protected bool m_VertexBufferAutoSizeReduction; //Field offset: 0x369
	[FieldOffset(Offset = "0x36C")]
	[Token(Token = "0x40005A0")]
	protected int m_firstVisibleCharacter; //Field offset: 0x36C
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x40005A1")]
	protected int m_maxVisibleCharacters; //Field offset: 0x370
	[FieldOffset(Offset = "0x374")]
	[Token(Token = "0x40005A2")]
	protected int m_maxVisibleWords; //Field offset: 0x374
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x40005A3")]
	protected int m_maxVisibleLines; //Field offset: 0x378
	[FieldOffset(Offset = "0x37C")]
	[SerializeField]
	[Token(Token = "0x40005A4")]
	protected bool m_useMaxVisibleDescender; //Field offset: 0x37C
	[FieldOffset(Offset = "0x380")]
	[SerializeField]
	[Token(Token = "0x40005A5")]
	protected int m_pageToDisplay; //Field offset: 0x380
	[FieldOffset(Offset = "0x384")]
	[Token(Token = "0x40005A6")]
	protected bool m_isNewPage; //Field offset: 0x384
	[FieldOffset(Offset = "0x388")]
	[SerializeField]
	[Token(Token = "0x40005A7")]
	protected Vector4 m_margin; //Field offset: 0x388
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x40005A8")]
	protected float m_marginLeft; //Field offset: 0x398
	[FieldOffset(Offset = "0x39C")]
	[Token(Token = "0x40005A9")]
	protected float m_marginRight; //Field offset: 0x39C
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x40005AA")]
	protected float m_marginWidth; //Field offset: 0x3A0
	[FieldOffset(Offset = "0x3A4")]
	[Token(Token = "0x40005AB")]
	protected float m_marginHeight; //Field offset: 0x3A4
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x40005AC")]
	protected float m_width; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x3B0")]
	[Token(Token = "0x40005AD")]
	protected TMP_TextInfo m_textInfo; //Field offset: 0x3B0
	[FieldOffset(Offset = "0x3B8")]
	[Token(Token = "0x40005AE")]
	protected bool m_havePropertiesChanged; //Field offset: 0x3B8
	[FieldOffset(Offset = "0x3B9")]
	[SerializeField]
	[Token(Token = "0x40005AF")]
	protected bool m_isUsingLegacyAnimationComponent; //Field offset: 0x3B9
	[FieldOffset(Offset = "0x3C0")]
	[Token(Token = "0x40005B0")]
	protected Transform m_transform; //Field offset: 0x3C0
	[FieldOffset(Offset = "0x3C8")]
	[Token(Token = "0x40005B1")]
	protected RectTransform m_rectTransform; //Field offset: 0x3C8
	[FieldOffset(Offset = "0x3D0")]
	[Token(Token = "0x40005B2")]
	protected Vector2 m_PreviousRectTransformSize; //Field offset: 0x3D0
	[FieldOffset(Offset = "0x3D8")]
	[Token(Token = "0x40005B3")]
	protected Vector2 m_PreviousPivotPosition; //Field offset: 0x3D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x40005B4")]
	private bool <autoSizeTextContainer>k__BackingField; //Field offset: 0x3E0
	[FieldOffset(Offset = "0x3E1")]
	[Token(Token = "0x40005B5")]
	protected bool m_autoSizeTextContainer; //Field offset: 0x3E1
	[FieldOffset(Offset = "0x3E8")]
	[Token(Token = "0x40005B6")]
	protected Mesh m_mesh; //Field offset: 0x3E8
	[FieldOffset(Offset = "0x3F0")]
	[SerializeField]
	[Token(Token = "0x40005B7")]
	protected bool m_isVolumetricText; //Field offset: 0x3F0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3F8")]
	[Token(Token = "0x40005BB")]
	private Action<TMP_TextInfo> OnPreRenderText; //Field offset: 0x3F8
	[FieldOffset(Offset = "0x400")]
	[Token(Token = "0x40005BC")]
	protected TMP_SpriteAnimator m_spriteAnimator; //Field offset: 0x400
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x40005BD")]
	protected float m_flexibleHeight; //Field offset: 0x408
	[FieldOffset(Offset = "0x40C")]
	[Token(Token = "0x40005BE")]
	protected float m_flexibleWidth; //Field offset: 0x40C
	[FieldOffset(Offset = "0x410")]
	[Token(Token = "0x40005BF")]
	protected float m_minWidth; //Field offset: 0x410
	[FieldOffset(Offset = "0x414")]
	[Token(Token = "0x40005C0")]
	protected float m_minHeight; //Field offset: 0x414
	[FieldOffset(Offset = "0x418")]
	[Token(Token = "0x40005C1")]
	protected float m_maxWidth; //Field offset: 0x418
	[FieldOffset(Offset = "0x41C")]
	[Token(Token = "0x40005C2")]
	protected float m_maxHeight; //Field offset: 0x41C
	[FieldOffset(Offset = "0x420")]
	[Token(Token = "0x40005C3")]
	protected LayoutElement m_LayoutElement; //Field offset: 0x420
	[FieldOffset(Offset = "0x428")]
	[Token(Token = "0x40005C4")]
	protected float m_preferredWidth; //Field offset: 0x428
	[FieldOffset(Offset = "0x42C")]
	[Token(Token = "0x40005C5")]
	protected float m_RenderedWidth; //Field offset: 0x42C
	[FieldOffset(Offset = "0x430")]
	[Token(Token = "0x40005C6")]
	protected bool m_isPreferredWidthDirty; //Field offset: 0x430
	[FieldOffset(Offset = "0x434")]
	[Token(Token = "0x40005C7")]
	protected float m_preferredHeight; //Field offset: 0x434
	[FieldOffset(Offset = "0x438")]
	[Token(Token = "0x40005C8")]
	protected float m_RenderedHeight; //Field offset: 0x438
	[FieldOffset(Offset = "0x43C")]
	[Token(Token = "0x40005C9")]
	protected bool m_isPreferredHeightDirty; //Field offset: 0x43C
	[FieldOffset(Offset = "0x43D")]
	[Token(Token = "0x40005CA")]
	protected bool m_isCalculatingPreferredValues; //Field offset: 0x43D
	[FieldOffset(Offset = "0x440")]
	[Token(Token = "0x40005CB")]
	protected int m_layoutPriority; //Field offset: 0x440
	[FieldOffset(Offset = "0x444")]
	[Token(Token = "0x40005CC")]
	protected bool m_isLayoutDirty; //Field offset: 0x444
	[FieldOffset(Offset = "0x445")]
	[Token(Token = "0x40005CD")]
	protected bool m_isAwake; //Field offset: 0x445
	[FieldOffset(Offset = "0x446")]
	[Token(Token = "0x40005CE")]
	internal bool m_isWaitingOnResourceLoad; //Field offset: 0x446
	[FieldOffset(Offset = "0x448")]
	[Token(Token = "0x40005CF")]
	internal TextInputSources m_inputSource; //Field offset: 0x448
	[FieldOffset(Offset = "0x44C")]
	[Token(Token = "0x40005D0")]
	protected float m_fontScaleMultiplier; //Field offset: 0x44C
	[FieldOffset(Offset = "0x450")]
	[Token(Token = "0x40005D4")]
	protected float tag_LineIndent; //Field offset: 0x450
	[FieldOffset(Offset = "0x454")]
	[Token(Token = "0x40005D5")]
	protected float tag_Indent; //Field offset: 0x454
	[FieldOffset(Offset = "0x458")]
	[Token(Token = "0x40005D6")]
	protected TMP_TextProcessingStack<Single> m_indentStack; //Field offset: 0x458
	[FieldOffset(Offset = "0x478")]
	[Token(Token = "0x40005D7")]
	protected bool tag_NoParsing; //Field offset: 0x478
	[FieldOffset(Offset = "0x479")]
	[Token(Token = "0x40005D8")]
	protected bool m_isTextLayoutPhase; //Field offset: 0x479
	[FieldOffset(Offset = "0x47C")]
	[Token(Token = "0x40005D9")]
	protected Quaternion m_FXRotation; //Field offset: 0x47C
	[FieldOffset(Offset = "0x48C")]
	[Token(Token = "0x40005DA")]
	protected Vector3 m_FXScale; //Field offset: 0x48C
	[FieldOffset(Offset = "0x498")]
	[Token(Token = "0x40005DB")]
	internal TextProcessingElement[] m_TextProcessingArray; //Field offset: 0x498
	[FieldOffset(Offset = "0x4A0")]
	[Token(Token = "0x40005DC")]
	internal int m_InternalTextProcessingArraySize; //Field offset: 0x4A0
	[FieldOffset(Offset = "0x4A8")]
	[Token(Token = "0x40005DD")]
	private TMP_CharacterInfo[] m_internalCharacterInfo; //Field offset: 0x4A8
	[FieldOffset(Offset = "0x4B0")]
	[Token(Token = "0x40005DE")]
	protected int m_totalCharacterCount; //Field offset: 0x4B0
	[FieldOffset(Offset = "0x4B4")]
	[Token(Token = "0x40005E5")]
	protected int m_characterCount; //Field offset: 0x4B4
	[FieldOffset(Offset = "0x4B8")]
	[Token(Token = "0x40005E6")]
	protected int m_firstCharacterOfLine; //Field offset: 0x4B8
	[FieldOffset(Offset = "0x4BC")]
	[Token(Token = "0x40005E7")]
	protected int m_firstVisibleCharacterOfLine; //Field offset: 0x4BC
	[FieldOffset(Offset = "0x4C0")]
	[Token(Token = "0x40005E8")]
	protected int m_lastCharacterOfLine; //Field offset: 0x4C0
	[FieldOffset(Offset = "0x4C4")]
	[Token(Token = "0x40005E9")]
	protected int m_lastVisibleCharacterOfLine; //Field offset: 0x4C4
	[FieldOffset(Offset = "0x4C8")]
	[Token(Token = "0x40005EA")]
	protected int m_lineNumber; //Field offset: 0x4C8
	[FieldOffset(Offset = "0x4CC")]
	[Token(Token = "0x40005EB")]
	protected int m_lineVisibleCharacterCount; //Field offset: 0x4CC
	[FieldOffset(Offset = "0x4D0")]
	[Token(Token = "0x40005EC")]
	protected int m_lineVisibleSpaceCount; //Field offset: 0x4D0
	[FieldOffset(Offset = "0x4D4")]
	[Token(Token = "0x40005ED")]
	protected int m_pageNumber; //Field offset: 0x4D4
	[FieldOffset(Offset = "0x4D8")]
	[Token(Token = "0x40005EE")]
	protected float m_PageAscender; //Field offset: 0x4D8
	[FieldOffset(Offset = "0x4DC")]
	[Token(Token = "0x40005EF")]
	protected float m_maxTextAscender; //Field offset: 0x4DC
	[FieldOffset(Offset = "0x4E0")]
	[Token(Token = "0x40005F0")]
	protected float m_maxCapHeight; //Field offset: 0x4E0
	[FieldOffset(Offset = "0x4E4")]
	[Token(Token = "0x40005F1")]
	protected float m_ElementAscender; //Field offset: 0x4E4
	[FieldOffset(Offset = "0x4E8")]
	[Token(Token = "0x40005F2")]
	protected float m_ElementDescender; //Field offset: 0x4E8
	[FieldOffset(Offset = "0x4EC")]
	[Token(Token = "0x40005F3")]
	protected float m_maxLineAscender; //Field offset: 0x4EC
	[FieldOffset(Offset = "0x4F0")]
	[Token(Token = "0x40005F4")]
	protected float m_maxLineDescender; //Field offset: 0x4F0
	[FieldOffset(Offset = "0x4F4")]
	[Token(Token = "0x40005F5")]
	protected float m_startOfLineAscender; //Field offset: 0x4F4
	[FieldOffset(Offset = "0x4F8")]
	[Token(Token = "0x40005F6")]
	protected float m_startOfLineDescender; //Field offset: 0x4F8
	[FieldOffset(Offset = "0x4FC")]
	[Token(Token = "0x40005F7")]
	protected float m_lineOffset; //Field offset: 0x4FC
	[FieldOffset(Offset = "0x500")]
	[Token(Token = "0x40005F8")]
	protected Extents m_meshExtents; //Field offset: 0x500
	[FieldOffset(Offset = "0x510")]
	[Token(Token = "0x40005F9")]
	protected Color32 m_htmlColor; //Field offset: 0x510
	[FieldOffset(Offset = "0x518")]
	[Token(Token = "0x40005FA")]
	protected TMP_TextProcessingStack<Color32> m_colorStack; //Field offset: 0x518
	[FieldOffset(Offset = "0x538")]
	[Token(Token = "0x40005FB")]
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; //Field offset: 0x538
	[FieldOffset(Offset = "0x558")]
	[Token(Token = "0x40005FC")]
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; //Field offset: 0x558
	[FieldOffset(Offset = "0x578")]
	[Token(Token = "0x40005FD")]
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; //Field offset: 0x578
	[FieldOffset(Offset = "0x5A8")]
	[Token(Token = "0x40005FE")]
	protected TMP_ColorGradient m_colorGradientPreset; //Field offset: 0x5A8
	[FieldOffset(Offset = "0x5B0")]
	[Token(Token = "0x40005FF")]
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; //Field offset: 0x5B0
	[FieldOffset(Offset = "0x5D8")]
	[Token(Token = "0x4000600")]
	protected bool m_colorGradientPresetIsTinted; //Field offset: 0x5D8
	[FieldOffset(Offset = "0x5DC")]
	[Token(Token = "0x4000601")]
	protected float m_tabSpacing; //Field offset: 0x5DC
	[FieldOffset(Offset = "0x5E0")]
	[Token(Token = "0x4000602")]
	protected float m_spacing; //Field offset: 0x5E0
	[FieldOffset(Offset = "0x5E8")]
	[Token(Token = "0x4000603")]
	protected TMP_TextProcessingStack<Int32>[] m_TextStyleStacks; //Field offset: 0x5E8
	[FieldOffset(Offset = "0x5F0")]
	[Token(Token = "0x4000604")]
	protected int m_TextStyleStackDepth; //Field offset: 0x5F0
	[FieldOffset(Offset = "0x5F8")]
	[Token(Token = "0x4000605")]
	protected TMP_TextProcessingStack<Int32> m_ItalicAngleStack; //Field offset: 0x5F8
	[FieldOffset(Offset = "0x618")]
	[Token(Token = "0x4000606")]
	protected int m_ItalicAngle; //Field offset: 0x618
	[FieldOffset(Offset = "0x620")]
	[Token(Token = "0x4000607")]
	protected TMP_TextProcessingStack<Int32> m_actionStack; //Field offset: 0x620
	[FieldOffset(Offset = "0x640")]
	[Token(Token = "0x4000608")]
	protected float m_padding; //Field offset: 0x640
	[FieldOffset(Offset = "0x644")]
	[Token(Token = "0x4000609")]
	protected float m_baselineOffset; //Field offset: 0x644
	[FieldOffset(Offset = "0x648")]
	[Token(Token = "0x400060A")]
	protected TMP_TextProcessingStack<Single> m_baselineOffsetStack; //Field offset: 0x648
	[FieldOffset(Offset = "0x668")]
	[Token(Token = "0x400060B")]
	protected float m_xAdvance; //Field offset: 0x668
	[FieldOffset(Offset = "0x66C")]
	[Token(Token = "0x400060C")]
	protected TMP_TextElementType m_textElementType; //Field offset: 0x66C
	[FieldOffset(Offset = "0x670")]
	[Token(Token = "0x400060D")]
	protected TMP_TextElement m_cached_TextElement; //Field offset: 0x670
	[FieldOffset(Offset = "0x678")]
	[Token(Token = "0x400060E")]
	protected SpecialCharacter m_Ellipsis; //Field offset: 0x678
	[FieldOffset(Offset = "0x698")]
	[Token(Token = "0x400060F")]
	protected SpecialCharacter m_Underline; //Field offset: 0x698
	[FieldOffset(Offset = "0x6B8")]
	[Token(Token = "0x4000610")]
	protected TMP_SpriteAsset m_defaultSpriteAsset; //Field offset: 0x6B8
	[FieldOffset(Offset = "0x6C0")]
	[Token(Token = "0x4000611")]
	protected TMP_SpriteAsset m_currentSpriteAsset; //Field offset: 0x6C0
	[FieldOffset(Offset = "0x6C8")]
	[Token(Token = "0x4000612")]
	protected int m_spriteCount; //Field offset: 0x6C8
	[FieldOffset(Offset = "0x6CC")]
	[Token(Token = "0x4000613")]
	protected int m_spriteIndex; //Field offset: 0x6CC
	[FieldOffset(Offset = "0x6D0")]
	[Token(Token = "0x4000614")]
	protected int m_spriteAnimationID; //Field offset: 0x6D0
	[FieldOffset(Offset = "0x6D4")]
	[Token(Token = "0x4000617")]
	protected bool m_ignoreActiveState; //Field offset: 0x6D4
	[FieldOffset(Offset = "0x6D8")]
	[Token(Token = "0x4000618")]
	private TextBackingContainer m_TextBackingArray; //Field offset: 0x6D8
	[FieldOffset(Offset = "0x6E8")]
	[Token(Token = "0x4000619")]
	private readonly Decimal[] k_Power; //Field offset: 0x6E8
	[Token(Token = "0x4000615")]
	private static ProfilerMarker k_ParseTextMarker; //Field offset: 0x1710
	[Token(Token = "0x4000616")]
	private static ProfilerMarker k_InsertNewLineMarker; //Field offset: 0x1718
	[Token(Token = "0x400061A")]
	protected static Vector2 k_LargePositiveVector2; //Field offset: 0x1720
	[Token(Token = "0x400061B")]
	protected static Vector2 k_LargeNegativeVector2; //Field offset: 0x1728
	[Token(Token = "0x400061C")]
	protected static float k_LargePositiveFloat; //Field offset: 0x1730
	[Token(Token = "0x400061D")]
	protected static float k_LargeNegativeFloat; //Field offset: 0x1734
	[Token(Token = "0x400061E")]
	protected static int k_LargePositiveInt; //Field offset: 0x1738
	[Token(Token = "0x400061F")]
	protected static int k_LargeNegativeInt; //Field offset: 0x173C

	[Token(Token = "0x14000003")]
	public static event Func<Int32, String, TMP_FontAsset> OnFontAssetRequest
	{
		[Address(RVA = "0x2EF3DB0", Offset = "0x2EF31B0", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x60005C8")]
		 add { } //Length: 261
		[Address(RVA = "0x2EF5160", Offset = "0x2EF4560", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x60005C9")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x14000005")]
	public static event MissingCharacterEventCallback OnMissingCharacter
	{
		[Address(RVA = "0x2EF3EC0", Offset = "0x2EF32C0", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x60005CC")]
		 add { } //Length: 242
		[Address(RVA = "0x2EF5270", Offset = "0x2EF4670", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x60005CD")]
		 remove { } //Length: 242
	}

	[Token(Token = "0x14000006")]
	public override event Action<TMP_TextInfo> OnPreRenderText
	{
		[Address(RVA = "0x2EF3FC0", Offset = "0x2EF33C0", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x60005CE")]
		 add { } //Length: 186
		[Address(RVA = "0x2EF5370", Offset = "0x2EF4770", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x60005CF")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000004")]
	public static event Func<Int32, String, TMP_SpriteAsset> OnSpriteAssetRequest
	{
		[Address(RVA = "0x2EF4080", Offset = "0x2EF3480", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x60005CA")]
		 add { } //Length: 261
		[Address(RVA = "0x2EF5430", Offset = "0x2EF4830", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x60005CB")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x1700014A")]
	public TextAlignmentOptions alignment
	{
		[Address(RVA = "0x2EF4190", Offset = "0x2EF3590", Length = "0xD")]
		[Token(Token = "0x600056D")]
		 get { } //Length: 13
		[Address(RVA = "0x2EF5540", Offset = "0x2EF4940", Length = "0x41")]
		[Token(Token = "0x600056E")]
		 set { } //Length: 65
	}

	[Token(Token = "0x17000134")]
	public float alpha
	{
		[Address(RVA = "0x2EF41A0", Offset = "0x2EF35A0", Length = "0x9")]
		[Token(Token = "0x6000543")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF5590", Offset = "0x2EF4990", Length = "0x33")]
		[Token(Token = "0x6000544")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000177")]
	public override bool autoSizeTextContainer
	{
		[Address(RVA = "0x2EF41B0", Offset = "0x2EF35B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60005C1")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF55D0", Offset = "0x2EF49D0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60005C2")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700017A")]
	public Bounds bounds
	{
		[Address(RVA = "0x2EF41C0", Offset = "0x2EF35C0", Length = "0xC7")]
		[Token(Token = "0x60005C6")]
		 get { } //Length: 199
	}

	[Token(Token = "0x1700014C")]
	public float characterHorizontalScale
	{
		[Address(RVA = "0x2EF4290", Offset = "0x2EF3690", Length = "0x9")]
		[Token(Token = "0x6000571")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF55E0", Offset = "0x2EF49E0", Length = "0x5C")]
		[Token(Token = "0x6000572")]
		 set { } //Length: 92
	}

	[Token(Token = "0x1700014B")]
	public float characterSpacing
	{
		[Address(RVA = "0x2EF42A0", Offset = "0x2EF36A0", Length = "0x9")]
		[Token(Token = "0x600056F")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF5640", Offset = "0x2EF4A40", Length = "0x5C")]
		[Token(Token = "0x6000570")]
		 set { } //Length: 92
	}

	[Token(Token = "0x17000151")]
	public float characterWidthAdjustment
	{
		[Address(RVA = "0x2EF42B0", Offset = "0x2EF36B0", Length = "0x9")]
		[Token(Token = "0x600057B")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF56A0", Offset = "0x2EF4AA0", Length = "0x5C")]
		[Token(Token = "0x600057C")]
		 set { } //Length: 92
	}

	[Token(Token = "0x17000133")]
	public virtual Color color
	{
		[Address(RVA = "0x2EF42F0", Offset = "0x2EF36F0", Length = "0xE")]
		[Token(Token = "0x6000541")]
		 get { } //Length: 14
		[Address(RVA = "0x2EF5790", Offset = "0x2EF4B90", Length = "0x90")]
		[Token(Token = "0x6000542")]
		 set { } //Length: 144
	}

	[Token(Token = "0x17000136")]
	public VertexGradient colorGradient
	{
		[Address(RVA = "0x2EF42C0", Offset = "0x2EF36C0", Length = "0x2F")]
		[Token(Token = "0x6000547")]
		 get { } //Length: 47
		[Address(RVA = "0x2EF5740", Offset = "0x2EF4B40", Length = "0x46")]
		[Token(Token = "0x6000548")]
		 set { } //Length: 70
	}

	[Token(Token = "0x17000137")]
	public TMP_ColorGradient colorGradientPreset
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[Token(Token = "0x6000549")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF5700", Offset = "0x2EF4B00", Length = "0x3F")]
		[Token(Token = "0x600054A")]
		 set { } //Length: 63
	}

	[Token(Token = "0x1700015E")]
	public bool emojiFallbackSupport
	{
		[Address(RVA = "0x2EF4300", Offset = "0x2EF3700", Length = "0x8")]
		[Token(Token = "0x6000592")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF5820", Offset = "0x2EF4C20", Length = "0x53")]
		[Token(Token = "0x6000593")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000143")]
	public bool enableAutoSizing
	{
		[Address(RVA = "0x1CF2C50", Offset = "0x1CF2050", Length = "0x8")]
		[Token(Token = "0x6000560")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF5880", Offset = "0x2EF4C80", Length = "0x4C")]
		[Token(Token = "0x6000561")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000162")]
	public bool enableCulling
	{
		[Address(RVA = "0x2EF4310", Offset = "0x2EF3710", Length = "0x8")]
		[Token(Token = "0x600059A")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF58D0", Offset = "0x2EF4CD0", Length = "0x37")]
		[Token(Token = "0x600059B")]
		 set { } //Length: 55
	}

	[Obsolete("The \"enableKerning\" property has been deprecated. Use the \"fontFeatures\" property to control what features are enabled on the text component.")]
	[Token(Token = "0x1700015A")]
	public bool enableKerning
	{
		[Address(RVA = "0x2EF4320", Offset = "0x2EF3720", Length = "0x4C")]
		[Token(Token = "0x600058A")]
		 get { } //Length: 76
		[Address(RVA = "0x2EF5910", Offset = "0x2EF4D10", Length = "0x14D")]
		[Token(Token = "0x600058B")]
		 set { } //Length: 333
	}

	[Token(Token = "0x17000135")]
	public bool enableVertexGradient
	{
		[Address(RVA = "0x2EF4370", Offset = "0x2EF3770", Length = "0x8")]
		[Token(Token = "0x6000545")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF5A60", Offset = "0x2EF4E60", Length = "0x2A")]
		[Token(Token = "0x6000546")]
		 set { } //Length: 42
	}

	[Obsolete("The enabledWordWrapping property is now obsolete. Please use the textWrappingMode property instead.")]
	[Token(Token = "0x17000153")]
	public bool enableWordWrapping
	{
		[Address(RVA = "0x2EF4380", Offset = "0x2EF3780", Length = "0x17")]
		[Token(Token = "0x600057F")]
		 get { } //Length: 23
		[Address(RVA = "0x2EF5A90", Offset = "0x2EF4E90", Length = "0x56")]
		[Token(Token = "0x6000580")]
		 set { } //Length: 86
	}

	[Token(Token = "0x1700015C")]
	public bool extraPadding
	{
		[Address(RVA = "0x2EF43A0", Offset = "0x2EF37A0", Length = "0x8")]
		[Token(Token = "0x600058E")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF5AF0", Offset = "0x2EF4EF0", Length = "0x53")]
		[Token(Token = "0x600058F")]
		 set { } //Length: 83
	}

	[Token(Token = "0x1700013D")]
	public Color32 faceColor
	{
		[Address(RVA = "0x2EF43B0", Offset = "0x2EF37B0", Length = "0xE3")]
		[Token(Token = "0x6000555")]
		 get { } //Length: 227
		[Address(RVA = "0x2EF5B50", Offset = "0x2EF4F50", Length = "0x7D")]
		[Token(Token = "0x6000556")]
		 set { } //Length: 125
	}

	[Token(Token = "0x17000157")]
	public int firstOverflowCharacterIndex
	{
		[Address(RVA = "0x1665710", Offset = "0x1664B10", Length = "0x7")]
		[Token(Token = "0x6000586")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700016B")]
	public int firstVisibleCharacter
	{
		[Address(RVA = "0x2EF44A0", Offset = "0x2EF38A0", Length = "0x7")]
		[Token(Token = "0x60005AC")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF5BD0", Offset = "0x2EF4FD0", Length = "0x2A")]
		[Token(Token = "0x60005AD")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700017D")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x2EF44B0", Offset = "0x2EF38B0", Length = "0x9")]
		[Token(Token = "0x60005D1")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700017E")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x2EF44C0", Offset = "0x2EF38C0", Length = "0x9")]
		[Token(Token = "0x60005D2")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700012E")]
	public TMP_FontAsset font
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x6000537")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6080", Offset = "0x2EF5480", Length = "0xCE")]
		[Token(Token = "0x6000538")]
		 set { } //Length: 206
	}

	[Token(Token = "0x1700015B")]
	public List<OTL_FeatureTag> fontFeatures
	{
		[Address(RVA = "0x2EF44D0", Offset = "0x2EF38D0", Length = "0x8")]
		[Token(Token = "0x600058C")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF5C00", Offset = "0x2EF5000", Length = "0x59")]
		[Token(Token = "0x600058D")]
		 set { } //Length: 89
	}

	[Token(Token = "0x17000131")]
	public Material fontMaterial
	{
		[Address(RVA = "0x2EF44E0", Offset = "0x2EF38E0", Length = "0x1B")]
		[Token(Token = "0x600053D")]
		 get { } //Length: 27
		[Address(RVA = "0x2EF5C60", Offset = "0x2EF5060", Length = "0x10A")]
		[Token(Token = "0x600053E")]
		 set { } //Length: 266
	}

	[Token(Token = "0x17000132")]
	public override Material[] fontMaterials
	{
		[Address(RVA = "0x2EF4500", Offset = "0x2EF3900", Length = "0x1B")]
		[Token(Token = "0x600053F")]
		 get { } //Length: 27
		[Address(RVA = "0x2EF5D70", Offset = "0x2EF5170", Length = "0x55")]
		[Token(Token = "0x6000540")]
		 set { } //Length: 85
	}

	[Token(Token = "0x1700012F")]
	public override Material fontSharedMaterial
	{
		[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
		[Token(Token = "0x6000539")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF5DD0", Offset = "0x2EF51D0", Length = "0xBB")]
		[Token(Token = "0x600053A")]
		 set { } //Length: 187
	}

	[Token(Token = "0x17000130")]
	public override Material[] fontSharedMaterials
	{
		[Address(RVA = "0x2EF4520", Offset = "0x2EF3920", Length = "0x14")]
		[Token(Token = "0x600053B")]
		 get { } //Length: 20
		[Address(RVA = "0x2EF5D70", Offset = "0x2EF5170", Length = "0x55")]
		[Token(Token = "0x600053C")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000140")]
	public float fontSize
	{
		[Address(RVA = "0x2EF4560", Offset = "0x2EF3960", Length = "0x9")]
		[Token(Token = "0x600055B")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF5F50", Offset = "0x2EF5350", Length = "0x6D")]
		[Token(Token = "0x600055C")]
		 set { } //Length: 109
	}

	[Token(Token = "0x17000145")]
	public float fontSizeMax
	{
		[Address(RVA = "0x2EF4540", Offset = "0x2EF3940", Length = "0x9")]
		[Token(Token = "0x6000564")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF5E90", Offset = "0x2EF5290", Length = "0x55")]
		[Token(Token = "0x6000565")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000144")]
	public float fontSizeMin
	{
		[Address(RVA = "0x2EF4550", Offset = "0x2EF3950", Length = "0x9")]
		[Token(Token = "0x6000562")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF5EF0", Offset = "0x2EF52F0", Length = "0x55")]
		[Token(Token = "0x6000563")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000146")]
	public FontStyles fontStyle
	{
		[Address(RVA = "0x2EF4570", Offset = "0x2EF3970", Length = "0x7")]
		[Token(Token = "0x6000566")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF5FC0", Offset = "0x2EF53C0", Length = "0x53")]
		[Token(Token = "0x6000567")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000141")]
	public FontWeight fontWeight
	{
		[Address(RVA = "0x2EF4580", Offset = "0x2EF3980", Length = "0x7")]
		[Token(Token = "0x600055D")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF6020", Offset = "0x2EF5420", Length = "0x53")]
		[Token(Token = "0x600055E")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000168")]
	public VertexSortingOrder geometrySortingOrder
	{
		[Address(RVA = "0x2EF4590", Offset = "0x2EF3990", Length = "0x7")]
		[Token(Token = "0x60005A6")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF6150", Offset = "0x2EF5550", Length = "0x21")]
		[Token(Token = "0x60005A7")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000173")]
	public bool havePropertiesChanged
	{
		[Address(RVA = "0x2EF45A0", Offset = "0x2EF39A0", Length = "0x8")]
		[Token(Token = "0x60005BB")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6180", Offset = "0x2EF5580", Length = "0x23")]
		[Token(Token = "0x60005BC")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000148")]
	public HorizontalAlignmentOptions horizontalAlignment
	{
		[Address(RVA = "0x2EF45B0", Offset = "0x2EF39B0", Length = "0x7")]
		[Token(Token = "0x6000569")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF61B0", Offset = "0x2EF55B0", Length = "0x2A")]
		[Token(Token = "0x600056A")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000164")]
	public TextureMappingOptions horizontalMapping
	{
		[Address(RVA = "0x2EF45C0", Offset = "0x2EF39C0", Length = "0x7")]
		[Token(Token = "0x600059E")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF61E0", Offset = "0x2EF55E0", Length = "0x2A")]
		[Token(Token = "0x600059F")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000163")]
	public bool ignoreVisibility
	{
		[Address(RVA = "0x2EF45D0", Offset = "0x2EF39D0", Length = "0x8")]
		[Token(Token = "0x600059C")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6210", Offset = "0x2EF5610", Length = "0x16")]
		[Token(Token = "0x600059D")]
		 set { } //Length: 22
	}

	[Token(Token = "0x17000161")]
	public bool isOrthographic
	{
		[Address(RVA = "0x2EF45E0", Offset = "0x2EF39E0", Length = "0x8")]
		[Token(Token = "0x6000598")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6230", Offset = "0x2EF5630", Length = "0x2A")]
		[Token(Token = "0x6000599")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000160")]
	public bool isOverlay
	{
		[Address(RVA = "0x2EF45F0", Offset = "0x2EF39F0", Length = "0x8")]
		[Token(Token = "0x6000596")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6260", Offset = "0x2EF5660", Length = "0x53")]
		[Token(Token = "0x6000597")]
		 set { } //Length: 83
	}

	[Token(Token = "0x1700012D")]
	public bool isRightToLeftText
	{
		[Address(RVA = "0x2EF4600", Offset = "0x2EF3A00", Length = "0x8")]
		[Token(Token = "0x6000535")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF62C0", Offset = "0x2EF56C0", Length = "0x53")]
		[Token(Token = "0x6000536")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000169")]
	public bool isTextObjectScaleStatic
	{
		[Address(RVA = "0x2EF4610", Offset = "0x2EF3A10", Length = "0x8")]
		[Token(Token = "0x60005A8")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6320", Offset = "0x2EF5720", Length = "0x96")]
		[Token(Token = "0x60005A9")]
		 set { } //Length: 150
	}

	[Token(Token = "0x17000156")]
	public bool isTextOverflowing
	{
		[Address(RVA = "0x2EF4620", Offset = "0x2EF3A20", Length = "0xB")]
		[Token(Token = "0x6000585")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000159")]
	public bool isTextTruncated
	{
		[Address(RVA = "0x2EF4630", Offset = "0x2EF3A30", Length = "0x8")]
		[Token(Token = "0x6000589")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000147")]
	public bool isUsingBold
	{
		[Address(RVA = "0x2EF4640", Offset = "0x2EF3A40", Length = "0x8")]
		[Token(Token = "0x6000568")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000174")]
	public bool isUsingLegacyAnimationComponent
	{
		[Address(RVA = "0x2EF4650", Offset = "0x2EF3A50", Length = "0x8")]
		[Token(Token = "0x60005BD")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF63C0", Offset = "0x2EF57C0", Length = "0x7")]
		[Token(Token = "0x60005BE")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000179")]
	public bool isVolumetricText
	{
		[Address(RVA = "0x2EF4660", Offset = "0x2EF3A60", Length = "0x8")]
		[Token(Token = "0x60005C4")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF63D0", Offset = "0x2EF57D0", Length = "0x68")]
		[Token(Token = "0x60005C5")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000183")]
	protected LayoutElement layoutElement
	{
		[Address(RVA = "0x2EF4670", Offset = "0x2EF3A70", Length = "0x99")]
		[Token(Token = "0x60005D7")]
		 get { } //Length: 153
	}

	[Token(Token = "0x17000188")]
	public override int layoutPriority
	{
		[Address(RVA = "0x2EF4710", Offset = "0x2EF3B10", Length = "0x7")]
		[Token(Token = "0x60005DC")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700014E")]
	public float lineSpacing
	{
		[Address(RVA = "0x2EF4730", Offset = "0x2EF3B30", Length = "0x9")]
		[Token(Token = "0x6000575")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF64A0", Offset = "0x2EF58A0", Length = "0x5C")]
		[Token(Token = "0x6000576")]
		 set { } //Length: 92
	}

	[Token(Token = "0x1700014F")]
	public float lineSpacingAdjustment
	{
		[Address(RVA = "0x2EF4720", Offset = "0x2EF3B20", Length = "0x9")]
		[Token(Token = "0x6000577")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF6440", Offset = "0x2EF5840", Length = "0x5C")]
		[Token(Token = "0x6000578")]
		 set { } //Length: 92
	}

	[Token(Token = "0x17000158")]
	public TMP_Text linkedTextComponent
	{
		[Address(RVA = "0x1665720", Offset = "0x1664B20", Length = "0x8")]
		[Token(Token = "0x6000587")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6500", Offset = "0x2EF5900", Length = "0x114")]
		[Token(Token = "0x6000588")]
		 set { } //Length: 276
	}

	[Token(Token = "0x17000166")]
	public float mappingUvLineOffset
	{
		[Address(RVA = "0x2EF4740", Offset = "0x2EF3B40", Length = "0x9")]
		[Token(Token = "0x60005A2")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF6620", Offset = "0x2EF5A20", Length = "0x33")]
		[Token(Token = "0x60005A3")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000171")]
	public override Vector4 margin
	{
		[Address(RVA = "0x2EF4750", Offset = "0x2EF3B50", Length = "0xE")]
		[Token(Token = "0x60005B8")]
		 get { } //Length: 14
		[Address(RVA = "0x2EF6660", Offset = "0x2EF5A60", Length = "0xB9")]
		[Token(Token = "0x60005B9")]
		 set { } //Length: 185
	}

	[Token(Token = "0x17000182")]
	public float maxHeight
	{
		[Address(RVA = "0x2EF4760", Offset = "0x2EF3B60", Length = "0x9")]
		[Token(Token = "0x60005D6")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700016C")]
	public int maxVisibleCharacters
	{
		[Address(RVA = "0x2EF4770", Offset = "0x2EF3B70", Length = "0x7")]
		[Token(Token = "0x60005AE")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF6720", Offset = "0x2EF5B20", Length = "0x2A")]
		[Token(Token = "0x60005AF")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700016E")]
	public int maxVisibleLines
	{
		[Address(RVA = "0x2EF4780", Offset = "0x2EF3B80", Length = "0x7")]
		[Token(Token = "0x60005B2")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF6750", Offset = "0x2EF5B50", Length = "0x2A")]
		[Token(Token = "0x60005B3")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700016D")]
	public int maxVisibleWords
	{
		[Address(RVA = "0x2EF4790", Offset = "0x2EF3B90", Length = "0x7")]
		[Token(Token = "0x60005B0")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF6780", Offset = "0x2EF5B80", Length = "0x2A")]
		[Token(Token = "0x60005B1")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000181")]
	public float maxWidth
	{
		[Address(RVA = "0x2EF47A0", Offset = "0x2EF3BA0", Length = "0x9")]
		[Token(Token = "0x60005D5")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000178")]
	public override Mesh mesh
	{
		[Address(RVA = "0x2EA4E40", Offset = "0x2EA4240", Length = "0x8")]
		[Token(Token = "0x60005C3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000180")]
	public override float minHeight
	{
		[Address(RVA = "0x2EF47B0", Offset = "0x2EF3BB0", Length = "0x9")]
		[Token(Token = "0x60005D4")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700017F")]
	public override float minWidth
	{
		[Address(RVA = "0x2EF47C0", Offset = "0x2EF3BC0", Length = "0x9")]
		[Token(Token = "0x60005D3")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700013E")]
	public Color32 outlineColor
	{
		[Address(RVA = "0x2EF47D0", Offset = "0x2EF3BD0", Length = "0xE3")]
		[Token(Token = "0x6000557")]
		 get { } //Length: 227
		[Address(RVA = "0x2EF67B0", Offset = "0x2EF5BB0", Length = "0x67")]
		[Token(Token = "0x6000558")]
		 set { } //Length: 103
	}

	[Token(Token = "0x1700013F")]
	public float outlineWidth
	{
		[Address(RVA = "0x2EF48C0", Offset = "0x2EF3CC0", Length = "0xCD")]
		[Token(Token = "0x6000559")]
		 get { } //Length: 205
		[Address(RVA = "0x2EF6820", Offset = "0x2EF5C20", Length = "0x63")]
		[Token(Token = "0x600055A")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000155")]
	public TextOverflowModes overflowMode
	{
		[Address(RVA = "0x2EF4990", Offset = "0x2EF3D90", Length = "0x7")]
		[Token(Token = "0x6000583")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF6890", Offset = "0x2EF5C90", Length = "0x53")]
		[Token(Token = "0x6000584")]
		 set { } //Length: 83
	}

	[Token(Token = "0x1700013C")]
	public bool overrideColorTags
	{
		[Address(RVA = "0x2EF49A0", Offset = "0x2EF3DA0", Length = "0x8")]
		[Token(Token = "0x6000553")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF68F0", Offset = "0x2EF5CF0", Length = "0x2A")]
		[Token(Token = "0x6000554")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000170")]
	public int pageToDisplay
	{
		[Address(RVA = "0x2EF49B0", Offset = "0x2EF3DB0", Length = "0x7")]
		[Token(Token = "0x60005B6")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF6920", Offset = "0x2EF5D20", Length = "0x2A")]
		[Token(Token = "0x60005B7")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000150")]
	public float paragraphSpacing
	{
		[Address(RVA = "0x2EF49C0", Offset = "0x2EF3DC0", Length = "0x9")]
		[Token(Token = "0x6000579")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF6950", Offset = "0x2EF5D50", Length = "0x5C")]
		[Token(Token = "0x600057A")]
		 set { } //Length: 92
	}

	[Token(Token = "0x1700015F")]
	public bool parseCtrlCharacters
	{
		[Address(RVA = "0x2EF49D0", Offset = "0x2EF3DD0", Length = "0x8")]
		[Token(Token = "0x6000594")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF69B0", Offset = "0x2EF5DB0", Length = "0x53")]
		[Token(Token = "0x6000595")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000142")]
	public float pixelsPerUnit
	{
		[Address(RVA = "0x2EF49E0", Offset = "0x2EF3DE0", Length = "0x1F1")]
		[Token(Token = "0x600055F")]
		 get { } //Length: 497
	}

	[Token(Token = "0x17000185")]
	public override float preferredHeight
	{
		[Address(RVA = "0x2EF4BE0", Offset = "0x2EF3FE0", Length = "0x1E")]
		[Token(Token = "0x60005D9")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000184")]
	public override float preferredWidth
	{
		[Address(RVA = "0x2EF4C00", Offset = "0x2EF4000", Length = "0x1E")]
		[Token(Token = "0x60005D8")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000176")]
	public RectTransform rectTransform
	{
		[Address(RVA = "0x2EF4C20", Offset = "0x2EF4020", Length = "0x99")]
		[Token(Token = "0x60005C0")]
		 get { } //Length: 153
	}

	[Token(Token = "0x17000187")]
	public override float renderedHeight
	{
		[Address(RVA = "0x2EE3020", Offset = "0x2EE2420", Length = "0x22")]
		[Token(Token = "0x60005DB")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000186")]
	public override float renderedWidth
	{
		[Address(RVA = "0x2EE3100", Offset = "0x2EE2500", Length = "0x22")]
		[Token(Token = "0x60005DA")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000167")]
	public TextRenderFlags renderMode
	{
		[Address(RVA = "0x2EF4CC0", Offset = "0x2EF40C0", Length = "0x7")]
		[Token(Token = "0x60005A4")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF6A10", Offset = "0x2EF5E10", Length = "0x16")]
		[Token(Token = "0x60005A5")]
		 set { } //Length: 22
	}

	[Token(Token = "0x1700015D")]
	public bool richText
	{
		[Address(RVA = "0x2EF4CD0", Offset = "0x2EF40D0", Length = "0x8")]
		[Token(Token = "0x6000590")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6A30", Offset = "0x2EF5E30", Length = "0x53")]
		[Token(Token = "0x6000591")]
		 set { } //Length: 83
	}

	[Token(Token = "0x1700017C")]
	protected TMP_SpriteAnimator spriteAnimator
	{
		[Address(RVA = "0x2EF4CE0", Offset = "0x2EF40E0", Length = "0x10F")]
		[Token(Token = "0x60005D0")]
		 get { } //Length: 271
	}

	[Token(Token = "0x17000138")]
	public TMP_SpriteAsset spriteAsset
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[Token(Token = "0x600054B")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6A90", Offset = "0x2EF5E90", Length = "0x55")]
		[Token(Token = "0x600054C")]
		 set { } //Length: 85
	}

	[Token(Token = "0x1700013A")]
	public TMP_StyleSheet styleSheet
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[Token(Token = "0x600054F")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6AF0", Offset = "0x2EF5EF0", Length = "0x55")]
		[Token(Token = "0x6000550")]
		 set { } //Length: 85
	}

	[Token(Token = "0x1700012B")]
	public override string text
	{
		[Address(RVA = "0x2EF4F50", Offset = "0x2EF4350", Length = "0xF3")]
		[Token(Token = "0x6000531")]
		 get { } //Length: 243
		[Address(RVA = "0x2EF6C20", Offset = "0x2EF6020", Length = "0xB0")]
		[Token(Token = "0x6000532")]
		 set { } //Length: 176
	}

	[Token(Token = "0x1700017B")]
	public Bounds textBounds
	{
		[Address(RVA = "0x2EF4DF0", Offset = "0x2EF41F0", Length = "0x5A")]
		[Token(Token = "0x60005C7")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000172")]
	public TMP_TextInfo textInfo
	{
		[Address(RVA = "0x2EF4E50", Offset = "0x2EF4250", Length = "0x79")]
		[Token(Token = "0x60005BA")]
		 get { } //Length: 121
	}

	[Token(Token = "0x1700012C")]
	public ITextPreprocessor textPreprocessor
	{
		[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
		[Token(Token = "0x6000533")]
		 get { } //Length: 8
		[Address(RVA = "0xE26C30", Offset = "0xE26030", Length = "0x13")]
		[Token(Token = "0x6000534")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700013B")]
	public TMP_Style textStyle
	{
		[Address(RVA = "0x2EF4ED0", Offset = "0x2EF42D0", Length = "0x7B")]
		[Token(Token = "0x6000551")]
		 get { } //Length: 123
		[Address(RVA = "0x2EF6B50", Offset = "0x2EF5F50", Length = "0x6F")]
		[Token(Token = "0x6000552")]
		 set { } //Length: 111
	}

	[Token(Token = "0x17000152")]
	public TextWrappingModes textWrappingMode
	{
		[Address(RVA = "0x1665700", Offset = "0x1664B00", Length = "0x7")]
		[Token(Token = "0x600057D")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF6BC0", Offset = "0x2EF5FC0", Length = "0x53")]
		[Token(Token = "0x600057E")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000139")]
	public bool tintAllSprites
	{
		[Address(RVA = "0x2EF5050", Offset = "0x2EF4450", Length = "0x8")]
		[Token(Token = "0x600054D")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6CD0", Offset = "0x2EF60D0", Length = "0x2A")]
		[Token(Token = "0x600054E")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000175")]
	public Transform transform
	{
		[Address(RVA = "0x2EF5060", Offset = "0x2EF4460", Length = "0x99")]
		[Token(Token = "0x60005BF")]
		 get { } //Length: 153
	}

	[Token(Token = "0x1700016F")]
	public bool useMaxVisibleDescender
	{
		[Address(RVA = "0x2EF5100", Offset = "0x2EF4500", Length = "0x8")]
		[Token(Token = "0x60005B4")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6D00", Offset = "0x2EF6100", Length = "0x2A")]
		[Token(Token = "0x60005B5")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700016A")]
	public bool vertexBufferAutoSizeReduction
	{
		[Address(RVA = "0x2EF5110", Offset = "0x2EF4510", Length = "0x8")]
		[Token(Token = "0x60005AA")]
		 get { } //Length: 8
		[Address(RVA = "0x2EF6D30", Offset = "0x2EF6130", Length = "0x21")]
		[Token(Token = "0x60005AB")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000149")]
	public VerticalAlignmentOptions verticalAlignment
	{
		[Address(RVA = "0x2EF5120", Offset = "0x2EF4520", Length = "0x7")]
		[Token(Token = "0x600056B")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF6D60", Offset = "0x2EF6160", Length = "0x2A")]
		[Token(Token = "0x600056C")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000165")]
	public TextureMappingOptions verticalMapping
	{
		[Address(RVA = "0x2EF5130", Offset = "0x2EF4530", Length = "0x7")]
		[Token(Token = "0x60005A0")]
		 get { } //Length: 7
		[Address(RVA = "0x2EF6D90", Offset = "0x2EF6190", Length = "0x2A")]
		[Token(Token = "0x60005A1")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700014D")]
	public float wordSpacing
	{
		[Address(RVA = "0x2EF5140", Offset = "0x2EF4540", Length = "0x9")]
		[Token(Token = "0x6000573")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF6DC0", Offset = "0x2EF61C0", Length = "0x5C")]
		[Token(Token = "0x6000574")]
		 set { } //Length: 92
	}

	[Token(Token = "0x17000154")]
	public float wordWrappingRatios
	{
		[Address(RVA = "0x2EF5150", Offset = "0x2EF4550", Length = "0x9")]
		[Token(Token = "0x6000581")]
		 get { } //Length: 9
		[Address(RVA = "0x2EF6E20", Offset = "0x2EF6220", Length = "0x5C")]
		[Token(Token = "0x6000582")]
		 set { } //Length: 92
	}

	[Address(RVA = "0x2EF2A10", Offset = "0x2EF1E10", Length = "0x5FC")]
	[Token(Token = "0x6000668")]
	private static TMP_Text() { }

	[Address(RVA = "0x2EF3010", Offset = "0x2EF2410", Length = "0xD94")]
	[Token(Token = "0x6000667")]
	protected TMP_Text() { }

	[Address(RVA = "0x2EF3DB0", Offset = "0x2EF31B0", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x60005C8")]
	public static void add_OnFontAssetRequest(Func<Int32, String, TMP_FontAsset> value) { }

	[Address(RVA = "0x2EF3EC0", Offset = "0x2EF32C0", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x60005CC")]
	public static void add_OnMissingCharacter(MissingCharacterEventCallback value) { }

	[Address(RVA = "0x2EF3FC0", Offset = "0x2EF33C0", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x60005CE")]
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[Address(RVA = "0x2EF4080", Offset = "0x2EF3480", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x60005CA")]
	public static void add_OnSpriteAssetRequest(Func<Int32, String, TMP_SpriteAsset> value) { }

	[Address(RVA = "0x2ED9A40", Offset = "0x2ED8E40", Length = "0x493")]
	[Token(Token = "0x6000621")]
	private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) { }

	[Address(RVA = "0x2ED9EE0", Offset = "0x2ED92E0", Length = "0x159")]
	[Token(Token = "0x6000622")]
	private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) { }

	[Address(RVA = "0x2EDA040", Offset = "0x2ED9440", Length = "0x446")]
	[Token(Token = "0x6000639")]
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	[Address(RVA = "0x2EDA490", Offset = "0x2ED9890", Length = "0x382E")]
	[Token(Token = "0x6000634")]
	protected override Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingModes textWrapMode) { }

	[Address(RVA = "0x2EDDCC0", Offset = "0x2EDD0C0", Length = "0xD1")]
	[Token(Token = "0x6000665")]
	private void ClearMarkupTagAttributes() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000651")]
	public override void ClearMesh(bool uploadGeometry) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000650")]
	public override void ClearMesh() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600063C")]
	public override void ComputeMarginSize() { }

	[Address(RVA = "0x2EDDDA0", Offset = "0x2EDD1A0", Length = "0x1AB")]
	[Token(Token = "0x6000664")]
	protected float ConvertToFloat(Char[] chars, int startIndex, int length, out int lastIndex) { }

	[Address(RVA = "0x2EDDF50", Offset = "0x2EDD350", Length = "0x23")]
	[Token(Token = "0x6000663")]
	protected float ConvertToFloat(Char[] chars, int startIndex, int length) { }

	[Address(RVA = "0x2EDDF80", Offset = "0x2EDD380", Length = "0xB1")]
	[Token(Token = "0x60005E4")]
	protected override Material CreateMaterialInstance(Material source) { }

	[Address(RVA = "0x2EDE040", Offset = "0x2EDD440", Length = "0x6C")]
	[Token(Token = "0x60005F8")]
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	[Address(RVA = "0x2EDE0B0", Offset = "0x2EDD4B0", Length = "0x98")]
	[Token(Token = "0x60005F7")]
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600064F")]
	protected override void DestroySubMeshObjects() { }

	[Address(RVA = "0x2EDE150", Offset = "0x2EDD550", Length = "0xAC")]
	[Token(Token = "0x6000655")]
	protected void DoMissingGlyphCallback(int unicode, int stringIndex, TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2EDE200", Offset = "0x2EDD600", Length = "0x647")]
	[Token(Token = "0x6000646")]
	protected override void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	[Address(RVA = "0x2EDE850", Offset = "0x2EDDC50", Length = "0x10C8")]
	[Token(Token = "0x6000645")]
	protected override void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	[Address(RVA = "0x2EDF920", Offset = "0x2EDED20", Length = "0xE02")]
	[Token(Token = "0x6000643")]
	protected override void FillCharacterVertexBuffers(int i, bool isVolumetric) { }

	[Address(RVA = "0x2EE0730", Offset = "0x2EDFB30", Length = "0x95C")]
	[Token(Token = "0x6000642")]
	protected override void FillCharacterVertexBuffers(int i) { }

	[Address(RVA = "0x2EE1090", Offset = "0x2EE0490", Length = "0x95C")]
	[Token(Token = "0x6000644")]
	protected override void FillSpriteVertexBuffers(int i) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005F1")]
	public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false) { }

	[Address(RVA = "0x2EF4190", Offset = "0x2EF3590", Length = "0xD")]
	[Token(Token = "0x600056D")]
	public TextAlignmentOptions get_alignment() { }

	[Address(RVA = "0x2EF41A0", Offset = "0x2EF35A0", Length = "0x9")]
	[Token(Token = "0x6000543")]
	public float get_alpha() { }

	[Address(RVA = "0x2EF41B0", Offset = "0x2EF35B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60005C1")]
	public override bool get_autoSizeTextContainer() { }

	[Address(RVA = "0x2EF41C0", Offset = "0x2EF35C0", Length = "0xC7")]
	[Token(Token = "0x60005C6")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x2EF4290", Offset = "0x2EF3690", Length = "0x9")]
	[Token(Token = "0x6000571")]
	public float get_characterHorizontalScale() { }

	[Address(RVA = "0x2EF42A0", Offset = "0x2EF36A0", Length = "0x9")]
	[Token(Token = "0x600056F")]
	public float get_characterSpacing() { }

	[Address(RVA = "0x2EF42B0", Offset = "0x2EF36B0", Length = "0x9")]
	[Token(Token = "0x600057B")]
	public float get_characterWidthAdjustment() { }

	[Address(RVA = "0x2EF42F0", Offset = "0x2EF36F0", Length = "0xE")]
	[Token(Token = "0x6000541")]
	public virtual Color get_color() { }

	[Address(RVA = "0x2EF42C0", Offset = "0x2EF36C0", Length = "0x2F")]
	[Token(Token = "0x6000547")]
	public VertexGradient get_colorGradient() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[Token(Token = "0x6000549")]
	public TMP_ColorGradient get_colorGradientPreset() { }

	[Address(RVA = "0x2EF4300", Offset = "0x2EF3700", Length = "0x8")]
	[Token(Token = "0x6000592")]
	public bool get_emojiFallbackSupport() { }

	[Address(RVA = "0x1CF2C50", Offset = "0x1CF2050", Length = "0x8")]
	[Token(Token = "0x6000560")]
	public bool get_enableAutoSizing() { }

	[Address(RVA = "0x2EF4310", Offset = "0x2EF3710", Length = "0x8")]
	[Token(Token = "0x600059A")]
	public bool get_enableCulling() { }

	[Address(RVA = "0x2EF4320", Offset = "0x2EF3720", Length = "0x4C")]
	[Token(Token = "0x600058A")]
	public bool get_enableKerning() { }

	[Address(RVA = "0x2EF4370", Offset = "0x2EF3770", Length = "0x8")]
	[Token(Token = "0x6000545")]
	public bool get_enableVertexGradient() { }

	[Address(RVA = "0x2EF4380", Offset = "0x2EF3780", Length = "0x17")]
	[Token(Token = "0x600057F")]
	public bool get_enableWordWrapping() { }

	[Address(RVA = "0x2EF43A0", Offset = "0x2EF37A0", Length = "0x8")]
	[Token(Token = "0x600058E")]
	public bool get_extraPadding() { }

	[Address(RVA = "0x2EF43B0", Offset = "0x2EF37B0", Length = "0xE3")]
	[Token(Token = "0x6000555")]
	public Color32 get_faceColor() { }

	[Address(RVA = "0x1665710", Offset = "0x1664B10", Length = "0x7")]
	[Token(Token = "0x6000586")]
	public int get_firstOverflowCharacterIndex() { }

	[Address(RVA = "0x2EF44A0", Offset = "0x2EF38A0", Length = "0x7")]
	[Token(Token = "0x60005AC")]
	public int get_firstVisibleCharacter() { }

	[Address(RVA = "0x2EF44B0", Offset = "0x2EF38B0", Length = "0x9")]
	[Token(Token = "0x60005D1")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x2EF44C0", Offset = "0x2EF38C0", Length = "0x9")]
	[Token(Token = "0x60005D2")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x6000537")]
	public TMP_FontAsset get_font() { }

	[Address(RVA = "0x2EF44D0", Offset = "0x2EF38D0", Length = "0x8")]
	[Token(Token = "0x600058C")]
	public List<OTL_FeatureTag> get_fontFeatures() { }

	[Address(RVA = "0x2EF44E0", Offset = "0x2EF38E0", Length = "0x1B")]
	[Token(Token = "0x600053D")]
	public Material get_fontMaterial() { }

	[Address(RVA = "0x2EF4500", Offset = "0x2EF3900", Length = "0x1B")]
	[Token(Token = "0x600053F")]
	public override Material[] get_fontMaterials() { }

	[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
	[Token(Token = "0x6000539")]
	public override Material get_fontSharedMaterial() { }

	[Address(RVA = "0x2EF4520", Offset = "0x2EF3920", Length = "0x14")]
	[Token(Token = "0x600053B")]
	public override Material[] get_fontSharedMaterials() { }

	[Address(RVA = "0x2EF4560", Offset = "0x2EF3960", Length = "0x9")]
	[Token(Token = "0x600055B")]
	public float get_fontSize() { }

	[Address(RVA = "0x2EF4540", Offset = "0x2EF3940", Length = "0x9")]
	[Token(Token = "0x6000564")]
	public float get_fontSizeMax() { }

	[Address(RVA = "0x2EF4550", Offset = "0x2EF3950", Length = "0x9")]
	[Token(Token = "0x6000562")]
	public float get_fontSizeMin() { }

	[Address(RVA = "0x2EF4570", Offset = "0x2EF3970", Length = "0x7")]
	[Token(Token = "0x6000566")]
	public FontStyles get_fontStyle() { }

	[Address(RVA = "0x2EF4580", Offset = "0x2EF3980", Length = "0x7")]
	[Token(Token = "0x600055D")]
	public FontWeight get_fontWeight() { }

	[Address(RVA = "0x2EF4590", Offset = "0x2EF3990", Length = "0x7")]
	[Token(Token = "0x60005A6")]
	public VertexSortingOrder get_geometrySortingOrder() { }

	[Address(RVA = "0x2EF45A0", Offset = "0x2EF39A0", Length = "0x8")]
	[Token(Token = "0x60005BB")]
	public bool get_havePropertiesChanged() { }

	[Address(RVA = "0x2EF45B0", Offset = "0x2EF39B0", Length = "0x7")]
	[Token(Token = "0x6000569")]
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	[Address(RVA = "0x2EF45C0", Offset = "0x2EF39C0", Length = "0x7")]
	[Token(Token = "0x600059E")]
	public TextureMappingOptions get_horizontalMapping() { }

	[Address(RVA = "0x2EF45D0", Offset = "0x2EF39D0", Length = "0x8")]
	[Token(Token = "0x600059C")]
	public bool get_ignoreVisibility() { }

	[Address(RVA = "0x2EF45E0", Offset = "0x2EF39E0", Length = "0x8")]
	[Token(Token = "0x6000598")]
	public bool get_isOrthographic() { }

	[Address(RVA = "0x2EF45F0", Offset = "0x2EF39F0", Length = "0x8")]
	[Token(Token = "0x6000596")]
	public bool get_isOverlay() { }

	[Address(RVA = "0x2EF4600", Offset = "0x2EF3A00", Length = "0x8")]
	[Token(Token = "0x6000535")]
	public bool get_isRightToLeftText() { }

	[Address(RVA = "0x2EF4610", Offset = "0x2EF3A10", Length = "0x8")]
	[Token(Token = "0x60005A8")]
	public bool get_isTextObjectScaleStatic() { }

	[Address(RVA = "0x2EF4620", Offset = "0x2EF3A20", Length = "0xB")]
	[Token(Token = "0x6000585")]
	public bool get_isTextOverflowing() { }

	[Address(RVA = "0x2EF4630", Offset = "0x2EF3A30", Length = "0x8")]
	[Token(Token = "0x6000589")]
	public bool get_isTextTruncated() { }

	[Address(RVA = "0x2EF4640", Offset = "0x2EF3A40", Length = "0x8")]
	[Token(Token = "0x6000568")]
	public bool get_isUsingBold() { }

	[Address(RVA = "0x2EF4650", Offset = "0x2EF3A50", Length = "0x8")]
	[Token(Token = "0x60005BD")]
	public bool get_isUsingLegacyAnimationComponent() { }

	[Address(RVA = "0x2EF4660", Offset = "0x2EF3A60", Length = "0x8")]
	[Token(Token = "0x60005C4")]
	public bool get_isVolumetricText() { }

	[Address(RVA = "0x2EF4670", Offset = "0x2EF3A70", Length = "0x99")]
	[Token(Token = "0x60005D7")]
	protected LayoutElement get_layoutElement() { }

	[Address(RVA = "0x2EF4710", Offset = "0x2EF3B10", Length = "0x7")]
	[Token(Token = "0x60005DC")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x2EF4730", Offset = "0x2EF3B30", Length = "0x9")]
	[Token(Token = "0x6000575")]
	public float get_lineSpacing() { }

	[Address(RVA = "0x2EF4720", Offset = "0x2EF3B20", Length = "0x9")]
	[Token(Token = "0x6000577")]
	public float get_lineSpacingAdjustment() { }

	[Address(RVA = "0x1665720", Offset = "0x1664B20", Length = "0x8")]
	[Token(Token = "0x6000587")]
	public TMP_Text get_linkedTextComponent() { }

	[Address(RVA = "0x2EF4740", Offset = "0x2EF3B40", Length = "0x9")]
	[Token(Token = "0x60005A2")]
	public float get_mappingUvLineOffset() { }

	[Address(RVA = "0x2EF4750", Offset = "0x2EF3B50", Length = "0xE")]
	[Token(Token = "0x60005B8")]
	public override Vector4 get_margin() { }

	[Address(RVA = "0x2EF4760", Offset = "0x2EF3B60", Length = "0x9")]
	[Token(Token = "0x60005D6")]
	public float get_maxHeight() { }

	[Address(RVA = "0x2EF4770", Offset = "0x2EF3B70", Length = "0x7")]
	[Token(Token = "0x60005AE")]
	public int get_maxVisibleCharacters() { }

	[Address(RVA = "0x2EF4780", Offset = "0x2EF3B80", Length = "0x7")]
	[Token(Token = "0x60005B2")]
	public int get_maxVisibleLines() { }

	[Address(RVA = "0x2EF4790", Offset = "0x2EF3B90", Length = "0x7")]
	[Token(Token = "0x60005B0")]
	public int get_maxVisibleWords() { }

	[Address(RVA = "0x2EF47A0", Offset = "0x2EF3BA0", Length = "0x9")]
	[Token(Token = "0x60005D5")]
	public float get_maxWidth() { }

	[Address(RVA = "0x2EA4E40", Offset = "0x2EA4240", Length = "0x8")]
	[Token(Token = "0x60005C3")]
	public override Mesh get_mesh() { }

	[Address(RVA = "0x2EF47B0", Offset = "0x2EF3BB0", Length = "0x9")]
	[Token(Token = "0x60005D4")]
	public override float get_minHeight() { }

	[Address(RVA = "0x2EF47C0", Offset = "0x2EF3BC0", Length = "0x9")]
	[Token(Token = "0x60005D3")]
	public override float get_minWidth() { }

	[Address(RVA = "0x2EF47D0", Offset = "0x2EF3BD0", Length = "0xE3")]
	[Token(Token = "0x6000557")]
	public Color32 get_outlineColor() { }

	[Address(RVA = "0x2EF48C0", Offset = "0x2EF3CC0", Length = "0xCD")]
	[Token(Token = "0x6000559")]
	public float get_outlineWidth() { }

	[Address(RVA = "0x2EF4990", Offset = "0x2EF3D90", Length = "0x7")]
	[Token(Token = "0x6000583")]
	public TextOverflowModes get_overflowMode() { }

	[Address(RVA = "0x2EF49A0", Offset = "0x2EF3DA0", Length = "0x8")]
	[Token(Token = "0x6000553")]
	public bool get_overrideColorTags() { }

	[Address(RVA = "0x2EF49B0", Offset = "0x2EF3DB0", Length = "0x7")]
	[Token(Token = "0x60005B6")]
	public int get_pageToDisplay() { }

	[Address(RVA = "0x2EF49C0", Offset = "0x2EF3DC0", Length = "0x9")]
	[Token(Token = "0x6000579")]
	public float get_paragraphSpacing() { }

	[Address(RVA = "0x2EF49D0", Offset = "0x2EF3DD0", Length = "0x8")]
	[Token(Token = "0x6000594")]
	public bool get_parseCtrlCharacters() { }

	[Address(RVA = "0x2EF49E0", Offset = "0x2EF3DE0", Length = "0x1F1")]
	[Token(Token = "0x600055F")]
	public float get_pixelsPerUnit() { }

	[Address(RVA = "0x2EF4BE0", Offset = "0x2EF3FE0", Length = "0x1E")]
	[Token(Token = "0x60005D9")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x2EF4C00", Offset = "0x2EF4000", Length = "0x1E")]
	[Token(Token = "0x60005D8")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x2EF4C20", Offset = "0x2EF4020", Length = "0x99")]
	[Token(Token = "0x60005C0")]
	public RectTransform get_rectTransform() { }

	[Address(RVA = "0x2EE3020", Offset = "0x2EE2420", Length = "0x22")]
	[Token(Token = "0x60005DB")]
	public override float get_renderedHeight() { }

	[Address(RVA = "0x2EE3100", Offset = "0x2EE2500", Length = "0x22")]
	[Token(Token = "0x60005DA")]
	public override float get_renderedWidth() { }

	[Address(RVA = "0x2EF4CC0", Offset = "0x2EF40C0", Length = "0x7")]
	[Token(Token = "0x60005A4")]
	public TextRenderFlags get_renderMode() { }

	[Address(RVA = "0x2EF4CD0", Offset = "0x2EF40D0", Length = "0x8")]
	[Token(Token = "0x6000590")]
	public bool get_richText() { }

	[Address(RVA = "0x2EF4CE0", Offset = "0x2EF40E0", Length = "0x10F")]
	[Token(Token = "0x60005D0")]
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[Token(Token = "0x600054B")]
	public TMP_SpriteAsset get_spriteAsset() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[Token(Token = "0x600054F")]
	public TMP_StyleSheet get_styleSheet() { }

	[Address(RVA = "0x2EF4F50", Offset = "0x2EF4350", Length = "0xF3")]
	[Token(Token = "0x6000531")]
	public override string get_text() { }

	[Address(RVA = "0x2EF4DF0", Offset = "0x2EF41F0", Length = "0x5A")]
	[Token(Token = "0x60005C7")]
	public Bounds get_textBounds() { }

	[Address(RVA = "0x2EF4E50", Offset = "0x2EF4250", Length = "0x79")]
	[Token(Token = "0x60005BA")]
	public TMP_TextInfo get_textInfo() { }

	[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
	[Token(Token = "0x6000533")]
	public ITextPreprocessor get_textPreprocessor() { }

	[Address(RVA = "0x2EF4ED0", Offset = "0x2EF42D0", Length = "0x7B")]
	[Token(Token = "0x6000551")]
	public TMP_Style get_textStyle() { }

	[Address(RVA = "0x1665700", Offset = "0x1664B00", Length = "0x7")]
	[Token(Token = "0x600057D")]
	public TextWrappingModes get_textWrappingMode() { }

	[Address(RVA = "0x2EF5050", Offset = "0x2EF4450", Length = "0x8")]
	[Token(Token = "0x600054D")]
	public bool get_tintAllSprites() { }

	[Address(RVA = "0x2EF5060", Offset = "0x2EF4460", Length = "0x99")]
	[Token(Token = "0x60005BF")]
	public Transform get_transform() { }

	[Address(RVA = "0x2EF5100", Offset = "0x2EF4500", Length = "0x8")]
	[Token(Token = "0x60005B4")]
	public bool get_useMaxVisibleDescender() { }

	[Address(RVA = "0x2EF5110", Offset = "0x2EF4510", Length = "0x8")]
	[Token(Token = "0x60005AA")]
	public bool get_vertexBufferAutoSizeReduction() { }

	[Address(RVA = "0x2EF5120", Offset = "0x2EF4520", Length = "0x7")]
	[Token(Token = "0x600056B")]
	public VerticalAlignmentOptions get_verticalAlignment() { }

	[Address(RVA = "0x2EF5130", Offset = "0x2EF4530", Length = "0x7")]
	[Token(Token = "0x60005A0")]
	public TextureMappingOptions get_verticalMapping() { }

	[Address(RVA = "0x2EF5140", Offset = "0x2EF4540", Length = "0x9")]
	[Token(Token = "0x6000573")]
	public float get_wordSpacing() { }

	[Address(RVA = "0x2EF5150", Offset = "0x2EF4550", Length = "0x9")]
	[Token(Token = "0x6000581")]
	public float get_wordWrappingRatios() { }

	[Address(RVA = "0x2EE19F0", Offset = "0x2EE0DF0", Length = "0x213")]
	[Token(Token = "0x6000662")]
	private int GetAttributeParameters(Char[] chars, int startIndex, int length, ref Single[] parameters) { }

	[Address(RVA = "0x2EE1C10", Offset = "0x2EE1010", Length = "0x88")]
	[Token(Token = "0x6000636")]
	internal override Rect GetCanvasSpaceClippingRect() { }

	[Address(RVA = "0xA53C40", Offset = "0xA53040", Length = "0x10")]
	[Token(Token = "0x6000635")]
	protected override Bounds GetCompoundBounds() { }

	[Address(RVA = "0x2EE1CA0", Offset = "0x2EE10A0", Length = "0x320")]
	[Token(Token = "0x6000649")]
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2EE1FD0", Offset = "0x2EE13D0", Length = "0x88")]
	[Token(Token = "0x600064C")]
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	[Address(RVA = "0x2EE2060", Offset = "0x2EE1460", Length = "0xEF")]
	[Token(Token = "0x600061B")]
	private int GetMarkupTagHashCode(UInt32[] styleDefinition, int readIndex) { }

	[Address(RVA = "0x2EE2150", Offset = "0x2EE1550", Length = "0xB6")]
	[Token(Token = "0x600061C")]
	private int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60005DF")]
	protected override Material GetMaterial(Material mat) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60005E3")]
	protected override Material[] GetMaterials(Material[] mats) { }

	[Address(RVA = "0x2EE2360", Offset = "0x2EE1760", Length = "0x115")]
	[Token(Token = "0x60005EF")]
	protected override float GetPaddingForMaterial(Material mat) { }

	[Address(RVA = "0x2EE2210", Offset = "0x2EE1610", Length = "0x140")]
	[Token(Token = "0x60005EE")]
	protected override float GetPaddingForMaterial() { }

	[Address(RVA = "0x2EE2480", Offset = "0x2EE1880", Length = "0xE3")]
	[Token(Token = "0x6000652")]
	public override string GetParsedText() { }

	[Address(RVA = "0x2EE2570", Offset = "0x2EE1970", Length = "0xBD")]
	[Token(Token = "0x600062D")]
	private float GetPreferredHeight(Vector2 margin) { }

	[Address(RVA = "0x2EE2630", Offset = "0x2EE1A30", Length = "0x224")]
	[Token(Token = "0x600062C")]
	protected float GetPreferredHeight() { }

	[Address(RVA = "0x2EE2C90", Offset = "0x2EE2090", Length = "0x51")]
	[Token(Token = "0x6000625")]
	public Vector2 GetPreferredValues() { }

	[Address(RVA = "0x2EE2860", Offset = "0x2EE1C60", Length = "0x65")]
	[Token(Token = "0x6000626")]
	public Vector2 GetPreferredValues(float width, float height) { }

	[Address(RVA = "0x2EE28D0", Offset = "0x2EE1CD0", Length = "0x1A7")]
	[Token(Token = "0x6000627")]
	public Vector2 GetPreferredValues(string text) { }

	[Address(RVA = "0x2EE2A80", Offset = "0x2EE1E80", Length = "0x203")]
	[Token(Token = "0x6000628")]
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	[Address(RVA = "0x2EE2EC0", Offset = "0x2EE22C0", Length = "0x9E")]
	[Token(Token = "0x600062A")]
	private float GetPreferredWidth(Vector2 margin) { }

	[Address(RVA = "0x2EE2F60", Offset = "0x2EE2360", Length = "0x89")]
	[Token(Token = "0x600062B")]
	private float GetPreferredWidth(Vector2 margin, TextWrappingModes wrapMode) { }

	[Address(RVA = "0x2EE2CF0", Offset = "0x2EE20F0", Length = "0x1C1")]
	[Token(Token = "0x6000629")]
	protected float GetPreferredWidth() { }

	[Address(RVA = "0x2EE3020", Offset = "0x2EE2420", Length = "0x22")]
	[Token(Token = "0x6000632")]
	private float GetRenderedHeight() { }

	[Address(RVA = "0x2EE2FF0", Offset = "0x2EE23F0", Length = "0x26")]
	[Token(Token = "0x6000633")]
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	[Address(RVA = "0x2EE3090", Offset = "0x2EE2490", Length = "0x33")]
	[Token(Token = "0x600062E")]
	public Vector2 GetRenderedValues() { }

	[Address(RVA = "0x2EE3050", Offset = "0x2EE2450", Length = "0x37")]
	[Token(Token = "0x600062F")]
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	[Address(RVA = "0x2EE3100", Offset = "0x2EE2500", Length = "0x22")]
	[Token(Token = "0x6000630")]
	private float GetRenderedWidth() { }

	[Address(RVA = "0x2EE30D0", Offset = "0x2EE24D0", Length = "0x26")]
	[Token(Token = "0x6000631")]
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60005E1")]
	protected override Material[] GetSharedMaterials() { }

	[Address(RVA = "0x2EE3130", Offset = "0x2EE2530", Length = "0x30")]
	[Token(Token = "0x6000648")]
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2EE3340", Offset = "0x2EE2740", Length = "0x124")]
	[Token(Token = "0x6000612")]
	private TMP_Style GetStyle(int hashCode) { }

	[Address(RVA = "0x2EE3250", Offset = "0x2EE2650", Length = "0xE6")]
	[Token(Token = "0x600061D")]
	private int GetStyleHashCode(ref UInt32[] text, int index, out int closeIndex) { }

	[Address(RVA = "0x2EE3160", Offset = "0x2EE2560", Length = "0xF0")]
	[Token(Token = "0x600061E")]
	private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	[Address(RVA = "0x2EE3470", Offset = "0x2EE2870", Length = "0x33C")]
	[Token(Token = "0x6000638")]
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	[Address(RVA = "0x2EE37B0", Offset = "0x2EE2BB0", Length = "0x2FA")]
	[Token(Token = "0x6000637")]
	protected Bounds GetTextBounds() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60005F0")]
	protected override Vector3[] GetTextContainerLocalCorners() { }

	[Address(RVA = "0x2EE3AB0", Offset = "0x2EE2EB0", Length = "0x67E")]
	[Token(Token = "0x600064D")]
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600063B")]
	public override TMP_TextInfo GetTextInfo(string text) { }

	[Address(RVA = "0x2EE45B0", Offset = "0x2EE39B0", Length = "0xCA")]
	[Token(Token = "0x600064A")]
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2EE4200", Offset = "0x2EE3600", Length = "0xC1")]
	[Token(Token = "0x600065C")]
	private uint GetUTF16(TextBackingContainer text, int i) { }

	[Address(RVA = "0x2EE4130", Offset = "0x2EE3530", Length = "0xC5")]
	[Token(Token = "0x600065B")]
	private uint GetUTF16(UInt32[] text, int i) { }

	[Address(RVA = "0x2EE4450", Offset = "0x2EE3850", Length = "0x153")]
	[Token(Token = "0x600065F")]
	private uint GetUTF32(TextBackingContainer text, int i) { }

	[Address(RVA = "0x2EE42D0", Offset = "0x2EE36D0", Length = "0x179")]
	[Token(Token = "0x600065E")]
	private uint GetUTF32(UInt32[] text, int i) { }

	[Address(RVA = "0x2EE4680", Offset = "0x2EE3A80", Length = "0x2C1")]
	[Token(Token = "0x6000661")]
	protected Color32 HexCharsToColor(Char[] hexChars, int startIndex, int length) { }

	[Address(RVA = "0x2EE4950", Offset = "0x2EE3D50", Length = "0x662")]
	[Token(Token = "0x6000660")]
	protected Color32 HexCharsToColor(Char[] hexChars, int tagCount) { }

	[Address(RVA = "0x2EE4FC0", Offset = "0x2EE43C0", Length = "0xA8")]
	[Token(Token = "0x6000659")]
	protected uint HexToInt(char hex) { }

	[Address(RVA = "0x2EE50E0", Offset = "0x2EE44E0", Length = "0xA8")]
	[Token(Token = "0x600061A")]
	private void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x2EE5190", Offset = "0x2EE4590", Length = "0xBD")]
	[Token(Token = "0x6000614")]
	private void InsertClosingTextStyle(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x2EE5250", Offset = "0x2EE4650", Length = "0x9DB")]
	[Token(Token = "0x600063D")]
	internal void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	[Address(RVA = "0x2EE5C30", Offset = "0x2EE5030", Length = "0xAB")]
	[Token(Token = "0x6000619")]
	private void InsertOpeningStyleTag(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x2EE5CE0", Offset = "0x2EE50E0", Length = "0xBD")]
	[Token(Token = "0x6000613")]
	private void InsertOpeningTextStyle(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x2EE5DA0", Offset = "0x2EE51A0", Length = "0x46C")]
	[Token(Token = "0x6000615")]
	private void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, UInt32[] styleDefinition) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005FA")]
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005F9")]
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	[Address(RVA = "0x2EE6210", Offset = "0x2EE5610", Length = "0xE5")]
	[Token(Token = "0x6000623")]
	private string InternalTextBackingArrayToString() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000658")]
	internal override void InternalUpdate() { }

	[Address(RVA = "0x2EE6300", Offset = "0x2EE5700", Length = "0xE2")]
	[Token(Token = "0x6000653")]
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	[Address(RVA = "0x2EE63F0", Offset = "0x2EE57F0", Length = "0x71")]
	[Token(Token = "0x600065A")]
	private bool IsValidUTF16(TextBackingContainer text, int index) { }

	[Address(RVA = "0x2EE6470", Offset = "0x2EE5870", Length = "0x71")]
	[Token(Token = "0x600065D")]
	private bool IsValidUTF32(TextBackingContainer text, int index) { }

	[Address(RVA = "0x2EE64F0", Offset = "0x2EE58F0", Length = "0x49B")]
	[Token(Token = "0x6000647")]
	protected void LoadDefaultSettings() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005DD")]
	protected override void LoadFontAsset() { }

	[Address(RVA = "0x2EE69D0", Offset = "0x2EE5DD0", Length = "0x3B")]
	[Token(Token = "0x6000656")]
	protected Vector2 PackUV(float x, float y, float scale) { }

	[Address(RVA = "0x2EE6990", Offset = "0x2EE5D90", Length = "0x39")]
	[Token(Token = "0x6000657")]
	protected float PackUV(float x, float y) { }

	[Address(RVA = "0x2EE6A10", Offset = "0x2EE5E10", Length = "0x1D9")]
	[Token(Token = "0x60005FB")]
	protected void ParseInputText() { }

	[Address(RVA = "0x2EE6BF0", Offset = "0x2EE5FF0", Length = "0x10C")]
	[Token(Token = "0x60005FE")]
	private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) { }

	[Address(RVA = "0x2EE6D00", Offset = "0x2EE6100", Length = "0xF7")]
	[Token(Token = "0x60005FD")]
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	[Address(RVA = "0x2EE6E00", Offset = "0x2EE6200", Length = "0x11D")]
	[Token(Token = "0x60005FF")]
	private void PopulateTextBackingArray(Char[] sourceText, int start, int length) { }

	[Address(RVA = "0x2EE6F20", Offset = "0x2EE6320", Length = "0xC7")]
	[Token(Token = "0x60005FC")]
	private void PopulateTextBackingArray(string sourceText) { }

	[Address(RVA = "0x2EE6FF0", Offset = "0x2EE63F0", Length = "0xE28")]
	[Token(Token = "0x6000600")]
	private void PopulateTextProcessingArray() { }

	[Address(RVA = "0x2EE7E40", Offset = "0x2EE7240", Length = "0x12A")]
	[Token(Token = "0x6000654")]
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	[Address(RVA = "0x2EF5160", Offset = "0x2EF4560", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x60005C9")]
	public static void remove_OnFontAssetRequest(Func<Int32, String, TMP_FontAsset> value) { }

	[Address(RVA = "0x2EF5270", Offset = "0x2EF4670", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x60005CD")]
	public static void remove_OnMissingCharacter(MissingCharacterEventCallback value) { }

	[Address(RVA = "0x2EF5370", Offset = "0x2EF4770", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x60005CF")]
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[Address(RVA = "0x2EF5430", Offset = "0x2EF4830", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x60005CB")]
	public static void remove_OnSpriteAssetRequest(Func<Int32, String, TMP_SpriteAsset> value) { }

	[Address(RVA = "0x2EE7F70", Offset = "0x2EE7370", Length = "0xBB")]
	[Token(Token = "0x6000618")]
	private void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x2EE81E0", Offset = "0x2EE75E0", Length = "0x192")]
	[Token(Token = "0x6000616")]
	private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x2EE8030", Offset = "0x2EE7430", Length = "0x1A5")]
	[Token(Token = "0x6000617")]
	private bool ReplaceOpeningStyleTag(ref UInt32[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x2EE8380", Offset = "0x2EE7780", Length = "0x5F")]
	[Token(Token = "0x600064B")]
	protected void ReplaceTagWithCharacter(Int32[] chars, int insertionIndex, int tagLength, char c) { }

	[Address(RVA = "0x93FB70", Offset = "0x93EF70", Length = "0x72")]
	[Token(Token = "0x600061F")]
	private void ResizeInternalArray(ref T[] array) { }

	[Address(RVA = "0x93FB00", Offset = "0x93EF00", Length = "0x6B")]
	[Token(Token = "0x6000620")]
	private void ResizeInternalArray(ref T[] array, int size) { }

	[Address(RVA = "0x2EE83E0", Offset = "0x2EE77E0", Length = "0x251")]
	[Token(Token = "0x600063A")]
	protected void ResizeLineExtents(int size) { }

	[Address(RVA = "0x2EE8640", Offset = "0x2EE7A40", Length = "0x61D")]
	[Token(Token = "0x600063F")]
	internal int RestoreWordWrappingState(ref WordWrapState state) { }

	[Address(RVA = "0x2EE8C60", Offset = "0x2EE8060", Length = "0x1574")]
	[Token(Token = "0x6000640")]
	protected override void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	[Address(RVA = "0x2EEA1E0", Offset = "0x2EE95E0", Length = "0xA09")]
	[Token(Token = "0x6000641")]
	protected override void SaveSpriteVertexInfo(Color32 vertexColor) { }

	[Address(RVA = "0x2EEABF0", Offset = "0x2EE9FF0", Length = "0x5D2")]
	[Token(Token = "0x600063E")]
	internal void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	[Address(RVA = "0x2EF5540", Offset = "0x2EF4940", Length = "0x41")]
	[Token(Token = "0x600056E")]
	public void set_alignment(TextAlignmentOptions value) { }

	[Address(RVA = "0x2EF5590", Offset = "0x2EF4990", Length = "0x33")]
	[Token(Token = "0x6000544")]
	public void set_alpha(float value) { }

	[Address(RVA = "0x2EF55D0", Offset = "0x2EF49D0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60005C2")]
	public override void set_autoSizeTextContainer(bool value) { }

	[Address(RVA = "0x2EF55E0", Offset = "0x2EF49E0", Length = "0x5C")]
	[Token(Token = "0x6000572")]
	public void set_characterHorizontalScale(float value) { }

	[Address(RVA = "0x2EF5640", Offset = "0x2EF4A40", Length = "0x5C")]
	[Token(Token = "0x6000570")]
	public void set_characterSpacing(float value) { }

	[Address(RVA = "0x2EF56A0", Offset = "0x2EF4AA0", Length = "0x5C")]
	[Token(Token = "0x600057C")]
	public void set_characterWidthAdjustment(float value) { }

	[Address(RVA = "0x2EF5790", Offset = "0x2EF4B90", Length = "0x90")]
	[Token(Token = "0x6000542")]
	public virtual void set_color(Color value) { }

	[Address(RVA = "0x2EF5740", Offset = "0x2EF4B40", Length = "0x46")]
	[Token(Token = "0x6000548")]
	public void set_colorGradient(VertexGradient value) { }

	[Address(RVA = "0x2EF5700", Offset = "0x2EF4B00", Length = "0x3F")]
	[Token(Token = "0x600054A")]
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	[Address(RVA = "0x2EF5820", Offset = "0x2EF4C20", Length = "0x53")]
	[Token(Token = "0x6000593")]
	public void set_emojiFallbackSupport(bool value) { }

	[Address(RVA = "0x2EF5880", Offset = "0x2EF4C80", Length = "0x4C")]
	[Token(Token = "0x6000561")]
	public void set_enableAutoSizing(bool value) { }

	[Address(RVA = "0x2EF58D0", Offset = "0x2EF4CD0", Length = "0x37")]
	[Token(Token = "0x600059B")]
	public void set_enableCulling(bool value) { }

	[Address(RVA = "0x2EF5910", Offset = "0x2EF4D10", Length = "0x14D")]
	[Token(Token = "0x600058B")]
	public void set_enableKerning(bool value) { }

	[Address(RVA = "0x2EF5A60", Offset = "0x2EF4E60", Length = "0x2A")]
	[Token(Token = "0x6000546")]
	public void set_enableVertexGradient(bool value) { }

	[Address(RVA = "0x2EF5A90", Offset = "0x2EF4E90", Length = "0x56")]
	[Token(Token = "0x6000580")]
	public void set_enableWordWrapping(bool value) { }

	[Address(RVA = "0x2EF5AF0", Offset = "0x2EF4EF0", Length = "0x53")]
	[Token(Token = "0x600058F")]
	public void set_extraPadding(bool value) { }

	[Address(RVA = "0x2EF5B50", Offset = "0x2EF4F50", Length = "0x7D")]
	[Token(Token = "0x6000556")]
	public void set_faceColor(Color32 value) { }

	[Address(RVA = "0x2EF5BD0", Offset = "0x2EF4FD0", Length = "0x2A")]
	[Token(Token = "0x60005AD")]
	public void set_firstVisibleCharacter(int value) { }

	[Address(RVA = "0x2EF6080", Offset = "0x2EF5480", Length = "0xCE")]
	[Token(Token = "0x6000538")]
	public void set_font(TMP_FontAsset value) { }

	[Address(RVA = "0x2EF5C00", Offset = "0x2EF5000", Length = "0x59")]
	[Token(Token = "0x600058D")]
	public void set_fontFeatures(List<OTL_FeatureTag> value) { }

	[Address(RVA = "0x2EF5C60", Offset = "0x2EF5060", Length = "0x10A")]
	[Token(Token = "0x600053E")]
	public void set_fontMaterial(Material value) { }

	[Address(RVA = "0x2EF5D70", Offset = "0x2EF5170", Length = "0x55")]
	[Token(Token = "0x6000540")]
	public override void set_fontMaterials(Material[] value) { }

	[Address(RVA = "0x2EF5DD0", Offset = "0x2EF51D0", Length = "0xBB")]
	[Token(Token = "0x600053A")]
	public override void set_fontSharedMaterial(Material value) { }

	[Address(RVA = "0x2EF5D70", Offset = "0x2EF5170", Length = "0x55")]
	[Token(Token = "0x600053C")]
	public override void set_fontSharedMaterials(Material[] value) { }

	[Address(RVA = "0x2EF5F50", Offset = "0x2EF5350", Length = "0x6D")]
	[Token(Token = "0x600055C")]
	public void set_fontSize(float value) { }

	[Address(RVA = "0x2EF5E90", Offset = "0x2EF5290", Length = "0x55")]
	[Token(Token = "0x6000565")]
	public void set_fontSizeMax(float value) { }

	[Address(RVA = "0x2EF5EF0", Offset = "0x2EF52F0", Length = "0x55")]
	[Token(Token = "0x6000563")]
	public void set_fontSizeMin(float value) { }

	[Address(RVA = "0x2EF5FC0", Offset = "0x2EF53C0", Length = "0x53")]
	[Token(Token = "0x6000567")]
	public void set_fontStyle(FontStyles value) { }

	[Address(RVA = "0x2EF6020", Offset = "0x2EF5420", Length = "0x53")]
	[Token(Token = "0x600055E")]
	public void set_fontWeight(FontWeight value) { }

	[Address(RVA = "0x2EF6150", Offset = "0x2EF5550", Length = "0x21")]
	[Token(Token = "0x60005A7")]
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	[Address(RVA = "0x2EF6180", Offset = "0x2EF5580", Length = "0x23")]
	[Token(Token = "0x60005BC")]
	public void set_havePropertiesChanged(bool value) { }

	[Address(RVA = "0x2EF61B0", Offset = "0x2EF55B0", Length = "0x2A")]
	[Token(Token = "0x600056A")]
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	[Address(RVA = "0x2EF61E0", Offset = "0x2EF55E0", Length = "0x2A")]
	[Token(Token = "0x600059F")]
	public void set_horizontalMapping(TextureMappingOptions value) { }

	[Address(RVA = "0x2EF6210", Offset = "0x2EF5610", Length = "0x16")]
	[Token(Token = "0x600059D")]
	public void set_ignoreVisibility(bool value) { }

	[Address(RVA = "0x2EF6230", Offset = "0x2EF5630", Length = "0x2A")]
	[Token(Token = "0x6000599")]
	public void set_isOrthographic(bool value) { }

	[Address(RVA = "0x2EF6260", Offset = "0x2EF5660", Length = "0x53")]
	[Token(Token = "0x6000597")]
	public void set_isOverlay(bool value) { }

	[Address(RVA = "0x2EF62C0", Offset = "0x2EF56C0", Length = "0x53")]
	[Token(Token = "0x6000536")]
	public void set_isRightToLeftText(bool value) { }

	[Address(RVA = "0x2EF6320", Offset = "0x2EF5720", Length = "0x96")]
	[Token(Token = "0x60005A9")]
	public void set_isTextObjectScaleStatic(bool value) { }

	[Address(RVA = "0x2EF63C0", Offset = "0x2EF57C0", Length = "0x7")]
	[Token(Token = "0x60005BE")]
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	[Address(RVA = "0x2EF63D0", Offset = "0x2EF57D0", Length = "0x68")]
	[Token(Token = "0x60005C5")]
	public void set_isVolumetricText(bool value) { }

	[Address(RVA = "0x2EF64A0", Offset = "0x2EF58A0", Length = "0x5C")]
	[Token(Token = "0x6000576")]
	public void set_lineSpacing(float value) { }

	[Address(RVA = "0x2EF6440", Offset = "0x2EF5840", Length = "0x5C")]
	[Token(Token = "0x6000578")]
	public void set_lineSpacingAdjustment(float value) { }

	[Address(RVA = "0x2EF6500", Offset = "0x2EF5900", Length = "0x114")]
	[Token(Token = "0x6000588")]
	public void set_linkedTextComponent(TMP_Text value) { }

	[Address(RVA = "0x2EF6620", Offset = "0x2EF5A20", Length = "0x33")]
	[Token(Token = "0x60005A3")]
	public void set_mappingUvLineOffset(float value) { }

	[Address(RVA = "0x2EF6660", Offset = "0x2EF5A60", Length = "0xB9")]
	[Token(Token = "0x60005B9")]
	public override void set_margin(Vector4 value) { }

	[Address(RVA = "0x2EF6720", Offset = "0x2EF5B20", Length = "0x2A")]
	[Token(Token = "0x60005AF")]
	public void set_maxVisibleCharacters(int value) { }

	[Address(RVA = "0x2EF6750", Offset = "0x2EF5B50", Length = "0x2A")]
	[Token(Token = "0x60005B3")]
	public void set_maxVisibleLines(int value) { }

	[Address(RVA = "0x2EF6780", Offset = "0x2EF5B80", Length = "0x2A")]
	[Token(Token = "0x60005B1")]
	public void set_maxVisibleWords(int value) { }

	[Address(RVA = "0x2EF67B0", Offset = "0x2EF5BB0", Length = "0x67")]
	[Token(Token = "0x6000558")]
	public void set_outlineColor(Color32 value) { }

	[Address(RVA = "0x2EF6820", Offset = "0x2EF5C20", Length = "0x63")]
	[Token(Token = "0x600055A")]
	public void set_outlineWidth(float value) { }

	[Address(RVA = "0x2EF6890", Offset = "0x2EF5C90", Length = "0x53")]
	[Token(Token = "0x6000584")]
	public void set_overflowMode(TextOverflowModes value) { }

	[Address(RVA = "0x2EF68F0", Offset = "0x2EF5CF0", Length = "0x2A")]
	[Token(Token = "0x6000554")]
	public void set_overrideColorTags(bool value) { }

	[Address(RVA = "0x2EF6920", Offset = "0x2EF5D20", Length = "0x2A")]
	[Token(Token = "0x60005B7")]
	public void set_pageToDisplay(int value) { }

	[Address(RVA = "0x2EF6950", Offset = "0x2EF5D50", Length = "0x5C")]
	[Token(Token = "0x600057A")]
	public void set_paragraphSpacing(float value) { }

	[Address(RVA = "0x2EF69B0", Offset = "0x2EF5DB0", Length = "0x53")]
	[Token(Token = "0x6000595")]
	public void set_parseCtrlCharacters(bool value) { }

	[Address(RVA = "0x2EF6A10", Offset = "0x2EF5E10", Length = "0x16")]
	[Token(Token = "0x60005A5")]
	public void set_renderMode(TextRenderFlags value) { }

	[Address(RVA = "0x2EF6A30", Offset = "0x2EF5E30", Length = "0x53")]
	[Token(Token = "0x6000591")]
	public void set_richText(bool value) { }

	[Address(RVA = "0x2EF6A90", Offset = "0x2EF5E90", Length = "0x55")]
	[Token(Token = "0x600054C")]
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	[Address(RVA = "0x2EF6AF0", Offset = "0x2EF5EF0", Length = "0x55")]
	[Token(Token = "0x6000550")]
	public void set_styleSheet(TMP_StyleSheet value) { }

	[Address(RVA = "0x2EF6C20", Offset = "0x2EF6020", Length = "0xB0")]
	[Token(Token = "0x6000532")]
	public override void set_text(string value) { }

	[Address(RVA = "0xE26C30", Offset = "0xE26030", Length = "0x13")]
	[Token(Token = "0x6000534")]
	public void set_textPreprocessor(ITextPreprocessor value) { }

	[Address(RVA = "0x2EF6B50", Offset = "0x2EF5F50", Length = "0x6F")]
	[Token(Token = "0x6000552")]
	public void set_textStyle(TMP_Style value) { }

	[Address(RVA = "0x2EF6BC0", Offset = "0x2EF5FC0", Length = "0x53")]
	[Token(Token = "0x600057E")]
	public void set_textWrappingMode(TextWrappingModes value) { }

	[Address(RVA = "0x2EF6CD0", Offset = "0x2EF60D0", Length = "0x2A")]
	[Token(Token = "0x600054E")]
	public void set_tintAllSprites(bool value) { }

	[Address(RVA = "0x2EF6D00", Offset = "0x2EF6100", Length = "0x2A")]
	[Token(Token = "0x60005B5")]
	public void set_useMaxVisibleDescender(bool value) { }

	[Address(RVA = "0x2EF6D30", Offset = "0x2EF6130", Length = "0x21")]
	[Token(Token = "0x60005AB")]
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	[Address(RVA = "0x2EF6D60", Offset = "0x2EF6160", Length = "0x2A")]
	[Token(Token = "0x600056C")]
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	[Address(RVA = "0x2EF6D90", Offset = "0x2EF6190", Length = "0x2A")]
	[Token(Token = "0x60005A1")]
	public void set_verticalMapping(TextureMappingOptions value) { }

	[Address(RVA = "0x2EF6DC0", Offset = "0x2EF61C0", Length = "0x5C")]
	[Token(Token = "0x6000574")]
	public void set_wordSpacing(float value) { }

	[Address(RVA = "0x2EF6E20", Offset = "0x2EF6220", Length = "0x5C")]
	[Token(Token = "0x6000582")]
	public void set_wordWrappingRatios(float value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600064E")]
	protected override void SetActiveSubMeshes(bool state) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000624")]
	internal override int SetArraySizes(TextProcessingElement[] unicodeChars) { }

	[Address(RVA = "0x2EEB1D0", Offset = "0x2EEA5D0", Length = "0x174")]
	[Token(Token = "0x6000611")]
	public void SetCharArray(Char[] sourceText, int start, int length) { }

	[Address(RVA = "0x2EEB350", Offset = "0x2EEA750", Length = "0x28")]
	[Token(Token = "0x6000610")]
	public void SetCharArray(Char[] sourceText) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005EC")]
	protected override void SetCulling() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005E8")]
	protected override void SetFaceColor(Color32 color) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005E0")]
	protected override void SetFontBaseMaterial(Material mat) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005E9")]
	protected override void SetOutlineColor(Color32 color) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005EA")]
	protected override void SetOutlineThickness(float thickness) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005EB")]
	protected override void SetShaderDepth() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005DE")]
	protected override void SetSharedMaterial(Material mat) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005E2")]
	protected override void SetSharedMaterials(Material[] materials) { }

	[Address(RVA = "0x2EEB7C0", Offset = "0x2EEABC0", Length = "0x12A")]
	[Token(Token = "0x6000602")]
	public void SetText(string sourceText) { }

	[Address(RVA = "0x2EEBA20", Offset = "0x2EEAE20", Length = "0x43")]
	[Token(Token = "0x6000606")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2) { }

	[Address(RVA = "0x2EEBB00", Offset = "0x2EEAF00", Length = "0xE")]
	[Token(Token = "0x600060F")]
	public void SetText(Char[] sourceText, int start, int length) { }

	[Address(RVA = "0x2EEB350", Offset = "0x2EEA750", Length = "0x28")]
	[Token(Token = "0x600060E")]
	public void SetText(Char[] sourceText) { }

	[Address(RVA = "0x2EEBB10", Offset = "0x2EEAF10", Length = "0x161")]
	[Token(Token = "0x600060D")]
	private void SetText(StringBuilder sourceText, int start, int length) { }

	[Address(RVA = "0x2EEB4C0", Offset = "0x2EEA8C0", Length = "0x48")]
	[Token(Token = "0x600060C")]
	public void SetText(StringBuilder sourceText) { }

	[Address(RVA = "0x2EEB510", Offset = "0x2EEA910", Length = "0x158")]
	[Token(Token = "0x600060B")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	[Address(RVA = "0x2EEB950", Offset = "0x2EEAD50", Length = "0x67")]
	[Token(Token = "0x600060A")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	[Address(RVA = "0x2EEB7C0", Offset = "0x2EEABC0", Length = "0x12A")]
	[Obsolete("Use the SetText(string) function instead.")]
	[Token(Token = "0x6000603")]
	public void SetText(string sourceText, bool syncTextInputBox = true) { }

	[Address(RVA = "0x2EEBAC0", Offset = "0x2EEAEC0", Length = "0x3A")]
	[Token(Token = "0x6000604")]
	public void SetText(string sourceText, float arg0) { }

	[Address(RVA = "0x2EEB480", Offset = "0x2EEA880", Length = "0x3A")]
	[Token(Token = "0x6000605")]
	public void SetText(string sourceText, float arg0, float arg1) { }

	[Address(RVA = "0x2EEB8F0", Offset = "0x2EEACF0", Length = "0x5E")]
	[Token(Token = "0x6000609")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	[Address(RVA = "0x2EEBA70", Offset = "0x2EEAE70", Length = "0x4C")]
	[Token(Token = "0x6000607")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) { }

	[Address(RVA = "0x2EEB9C0", Offset = "0x2EEADC0", Length = "0x55")]
	[Token(Token = "0x6000608")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	[Address(RVA = "0x2EEB380", Offset = "0x2EEA780", Length = "0xF7")]
	[Token(Token = "0x6000601")]
	private void SetTextInternal(string sourceText) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005E7")]
	protected void SetTextSortingOrder(Int32[] order) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005E6")]
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	[Address(RVA = "0x2EEBC80", Offset = "0x2EEB080", Length = "0xA9")]
	[Token(Token = "0x60005E5")]
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005F5")]
	public override void SetVertices(Vector3[] vertices) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005ED")]
	internal override void UpdateCulling() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005F2")]
	public override void UpdateGeometry(Mesh mesh, int index) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005F6")]
	public override void UpdateMeshPadding() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005F4")]
	public override void UpdateVertexData() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005F3")]
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	[Address(RVA = "0x2EEBD30", Offset = "0x2EEB130", Length = "0x6CDC")]
	[Token(Token = "0x6000666")]
	internal bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex) { }

}

