namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000048")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class TextGenerator
{
	[Token(Token = "0x2000049")]
	internal sealed class MissingCharacterEventCallback : MulticastDelegate
	{

		[Address(RVA = "0x31B0210", Offset = "0x31AF610", Length = "0xA6")]
		[Token(Token = "0x600021A")]
		public MissingCharacterEventCallback(object object, IntPtr method) { }

		[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
		[Token(Token = "0x600021B")]
		public override void Invoke(uint unicode, int stringIndex, TextInfo text, FontAsset fontAsset) { }

	}

	[Token(Token = "0x200004A")]
	internal struct SpecialCharacter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B1")]
		public Character character; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002B2")]
		public FontAsset fontAsset; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002B3")]
		public Material material; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002B4")]
		public int materialIndex; //Field offset: 0x18

		[Address(RVA = "0x31B0D30", Offset = "0x31B0130", Length = "0x157")]
		[Token(Token = "0x600021C")]
		public SpecialCharacter(Character character, int materialIndex) { }

	}

	[Token(Token = "0x400020B")]
	private const int k_Tab = 9; //Field offset: 0x0
	[Token(Token = "0x4000226")]
	private const int k_RightSingleQuote = 8217; //Field offset: 0x0
	[Token(Token = "0x4000227")]
	private const int k_Square = 9633; //Field offset: 0x0
	[Token(Token = "0x4000228")]
	private const int k_HangulJamoStart = 4352; //Field offset: 0x0
	[Token(Token = "0x4000229")]
	private const int k_HangulJamoEnd = 4607; //Field offset: 0x0
	[Token(Token = "0x400022A")]
	private const int k_CjkStart = 11904; //Field offset: 0x0
	[Token(Token = "0x400022B")]
	private const int k_CjkEnd = 40959; //Field offset: 0x0
	[Token(Token = "0x400022C")]
	private const int k_HangulJameExtendedStart = 43360; //Field offset: 0x0
	[Token(Token = "0x400022D")]
	private const int k_HangulJameExtendedEnd = 43391; //Field offset: 0x0
	[Token(Token = "0x400022E")]
	private const int k_HangulSyllablesStart = 44032; //Field offset: 0x0
	[Token(Token = "0x4000225")]
	private const int k_ParagraphSeparator = 8233; //Field offset: 0x0
	[Token(Token = "0x400022F")]
	private const int k_HangulSyllablesEnd = 55295; //Field offset: 0x0
	[Token(Token = "0x4000231")]
	private const int k_CjkIdeographsEnd = 64255; //Field offset: 0x0
	[Token(Token = "0x4000232")]
	private const int k_CjkFormsStart = 65072; //Field offset: 0x0
	[Token(Token = "0x4000233")]
	private const int k_CjkFormsEnd = 65103; //Field offset: 0x0
	[Token(Token = "0x4000234")]
	private const int k_CjkHalfwidthStart = 65280; //Field offset: 0x0
	[Token(Token = "0x4000235")]
	private const int k_CjkHalfwidthEnd = 65519; //Field offset: 0x0
	[Token(Token = "0x4000236")]
	private const int k_EndOfText = 3; //Field offset: 0x0
	[Token(Token = "0x4000237")]
	private const float k_FloatUnset = -32767; //Field offset: 0x0
	[Token(Token = "0x4000238")]
	private const int k_MaxCharacters = 8; //Field offset: 0x0
	[Token(Token = "0x4000239")]
	private static TextGenerator s_TextGenerator; //Field offset: 0x0
	[Token(Token = "0x4000230")]
	private const int k_CjkIdeographsStart = 63744; //Field offset: 0x0
	[Token(Token = "0x4000224")]
	private const int k_LineSeparator = 8232; //Field offset: 0x0
	[Token(Token = "0x4000223")]
	private const int k_HorizontalEllipsis = 8230; //Field offset: 0x0
	[Token(Token = "0x4000216")]
	private const int k_LesserThan = 60; //Field offset: 0x0
	[Token(Token = "0x400020D")]
	private const int k_VerticalTab = 11; //Field offset: 0x0
	[Token(Token = "0x400020E")]
	private const int k_CarriageReturn = 13; //Field offset: 0x0
	[Token(Token = "0x400020F")]
	private const int k_Space = 32; //Field offset: 0x0
	[Token(Token = "0x4000210")]
	private const int k_DoubleQuotes = 34; //Field offset: 0x0
	[Token(Token = "0x4000211")]
	private const int k_NumberSign = 35; //Field offset: 0x0
	[Token(Token = "0x4000212")]
	private const int k_PercentSign = 37; //Field offset: 0x0
	[Token(Token = "0x4000213")]
	private const int k_SingleQuote = 39; //Field offset: 0x0
	[Token(Token = "0x4000214")]
	private const int k_Plus = 43; //Field offset: 0x0
	[Token(Token = "0x4000215")]
	private const int k_Period = 46; //Field offset: 0x0
	[Token(Token = "0x4000222")]
	private const int k_WordJoiner = 8288; //Field offset: 0x0
	[Token(Token = "0x4000217")]
	private const int k_Equal = 61; //Field offset: 0x0
	[Token(Token = "0x4000218")]
	private const int k_GreaterThan = 62; //Field offset: 0x0
	[Token(Token = "0x4000219")]
	private const int k_Underline = 95; //Field offset: 0x0
	[Token(Token = "0x400021A")]
	private const int k_NoBreakSpace = 160; //Field offset: 0x0
	[Token(Token = "0x400021B")]
	private const int k_SoftHyphen = 173; //Field offset: 0x0
	[Token(Token = "0x400021C")]
	private const int k_HyphenMinus = 45; //Field offset: 0x0
	[Token(Token = "0x400021D")]
	private const int k_FigureSpace = 8199; //Field offset: 0x0
	[Token(Token = "0x400021E")]
	private const int k_Hyphen = 8208; //Field offset: 0x0
	[Token(Token = "0x400021F")]
	private const int k_NonBreakingHyphen = 8209; //Field offset: 0x0
	[Token(Token = "0x4000220")]
	private const int k_ZeroWidthSpace = 8203; //Field offset: 0x0
	[Token(Token = "0x4000221")]
	private const int k_NarrowNoBreakSpace = 8239; //Field offset: 0x0
	[Token(Token = "0x400020C")]
	private const int k_LineFeed = 10; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400023A")]
	private static bool <IsExecutingJob>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000243")]
	private static MissingCharacterEventCallback OnMissingCharacter; //Field offset: 0x10
	[Token(Token = "0x40002AF")]
	internal static readonly bool EnableTextAlignmentAssertions; //Field offset: 0x18
	[Token(Token = "0x40002B0")]
	internal static readonly bool EnableCheckerboardPattern; //Field offset: 0x19
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400023B")]
	private TextBackingContainer m_TextBackingArray; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400023C")]
	internal TextProcessingElement[] m_TextProcessingArray; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400023D")]
	internal int m_InternalTextProcessingArraySize; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400023E")]
	protected bool m_VertexBufferAutoSizeReduction; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400023F")]
	private Char[] m_HtmlTag; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000240")]
	internal HighlightState m_HighlightState; //Field offset: 0x38
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000241")]
	protected bool m_IsIgnoringAlignment; //Field offset: 0x4C
	[FieldOffset(Offset = "0x4D")]
	[Token(Token = "0x4000242")]
	protected bool m_IsTextTruncated; //Field offset: 0x4D
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000244")]
	private Vector3[] m_RectTransformCorners; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000245")]
	private float m_MarginWidth; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000246")]
	private float m_MarginHeight; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000247")]
	private float m_PreferredWidth; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000248")]
	private float m_PreferredHeight; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000249")]
	private FontAsset m_CurrentFontAsset; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400024A")]
	private Material m_CurrentMaterial; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400024B")]
	private int m_CurrentMaterialIndex; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400024C")]
	private TextProcessingStack<MaterialReference> m_MaterialReferenceStack; //Field offset: 0x80
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400024D")]
	private float m_Padding; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400024E")]
	private SpriteAsset m_CurrentSpriteAsset; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400024F")]
	private int m_TotalCharacterCount; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000250")]
	private float m_FontSize; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000251")]
	private float m_FontScaleMultiplier; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000252")]
	private bool m_ShouldRenderBitmap; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000253")]
	private float m_CurrentFontSize; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000254")]
	private TextProcessingStack<Single> m_SizeStack; //Field offset: 0x100
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000255")]
	protected TextProcessingStack<Int32>[] m_TextStyleStacks; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000256")]
	protected int m_TextStyleStackDepth; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4000257")]
	private FontStyles m_FontStyleInternal; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000258")]
	private FontStyleStack m_FontStyleStack; //Field offset: 0x130
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x4000259")]
	private TextFontWeight m_FontWeightInternal; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400025A")]
	private TextProcessingStack<TextFontWeight> m_FontWeightStack; //Field offset: 0x140
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400025B")]
	private TextAlignment m_LineJustification; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400025C")]
	private TextProcessingStack<TextAlignment> m_LineJustificationStack; //Field offset: 0x168
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x400025D")]
	private float _m_BaselineOffset; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x400025E")]
	private TextProcessingStack<Single> m_BaselineOffsetStack; //Field offset: 0x190
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400025F")]
	private Color32 m_FontColor32; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x4000260")]
	private Color32 m_HtmlColor; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000261")]
	private Color32 m_UnderlineColor; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x4000262")]
	private Color32 m_StrikethroughColor; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000263")]
	private TextProcessingStack<Color32> m_ColorStack; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000264")]
	private TextProcessingStack<Color32> m_UnderlineColorStack; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000265")]
	private TextProcessingStack<Color32> m_StrikethroughColorStack; //Field offset: 0x200
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000266")]
	private TextProcessingStack<Color32> m_HighlightColorStack; //Field offset: 0x220
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000267")]
	private TextProcessingStack<HighlightState> m_HighlightStateStack; //Field offset: 0x240
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000268")]
	private TextProcessingStack<Int32> m_ItalicAngleStack; //Field offset: 0x270
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000269")]
	private TextColorGradient m_ColorGradientPreset; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x400026A")]
	private TextProcessingStack<TextColorGradient> m_ColorGradientStack; //Field offset: 0x298
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x400026B")]
	private bool m_ColorGradientPresetIsTinted; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x400026C")]
	private TextProcessingStack<Int32> m_ActionStack; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x400026D")]
	private float _m_LineOffset; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2EC")]
	[Token(Token = "0x400026E")]
	private float _m_LineHeight; //Field offset: 0x2EC
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x400026F")]
	private bool m_IsDrivenLineSpacing; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x4000270")]
	private float m_CSpacing; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000271")]
	private float m_MonoSpacing; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2FC")]
	[Token(Token = "0x4000272")]
	private bool m_DuoSpace; //Field offset: 0x2FC
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000273")]
	private float _m_XAdvance; //Field offset: 0x300
	[FieldOffset(Offset = "0x304")]
	[Token(Token = "0x4000274")]
	private float m_TagLineIndent; //Field offset: 0x304
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000275")]
	private float m_TagIndent; //Field offset: 0x308
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000276")]
	private TextProcessingStack<Single> m_IndentStack; //Field offset: 0x310
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000277")]
	private bool m_TagNoParsing; //Field offset: 0x330
	[FieldOffset(Offset = "0x334")]
	[Token(Token = "0x4000278")]
	private int m_CharacterCount; //Field offset: 0x334
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x4000279")]
	private int m_FirstCharacterOfLine; //Field offset: 0x338
	[FieldOffset(Offset = "0x33C")]
	[Token(Token = "0x400027A")]
	private int m_LastCharacterOfLine; //Field offset: 0x33C
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x400027B")]
	private int m_FirstVisibleCharacterOfLine; //Field offset: 0x340
	[FieldOffset(Offset = "0x344")]
	[Token(Token = "0x400027C")]
	private int m_LastVisibleCharacterOfLine; //Field offset: 0x344
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x400027D")]
	private float m_MaxLineAscender; //Field offset: 0x348
	[FieldOffset(Offset = "0x34C")]
	[Token(Token = "0x400027E")]
	private float m_MaxLineDescender; //Field offset: 0x34C
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x400027F")]
	private int m_LineNumber; //Field offset: 0x350
	[FieldOffset(Offset = "0x354")]
	[Token(Token = "0x4000280")]
	private int m_LineVisibleCharacterCount; //Field offset: 0x354
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000281")]
	private int m_LineVisibleSpaceCount; //Field offset: 0x358
	[FieldOffset(Offset = "0x35C")]
	[Token(Token = "0x4000282")]
	private int m_FirstOverflowCharacterIndex; //Field offset: 0x35C
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000283")]
	private float m_MarginLeft; //Field offset: 0x360
	[FieldOffset(Offset = "0x364")]
	[Token(Token = "0x4000284")]
	private float m_MarginRight; //Field offset: 0x364
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x4000285")]
	private float m_Width; //Field offset: 0x368
	[FieldOffset(Offset = "0x36C")]
	[Token(Token = "0x4000286")]
	private Extents m_MeshExtents; //Field offset: 0x36C
	[FieldOffset(Offset = "0x37C")]
	[Token(Token = "0x4000287")]
	private float m_MaxCapHeight; //Field offset: 0x37C
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x4000288")]
	private float m_MaxAscender; //Field offset: 0x380
	[FieldOffset(Offset = "0x384")]
	[Token(Token = "0x4000289")]
	private float m_MaxDescender; //Field offset: 0x384
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x400028A")]
	private bool m_IsNonBreakingSpace; //Field offset: 0x388
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x400028B")]
	private WordWrapState m_SavedWordWrapState; //Field offset: 0x390
	[FieldOffset(Offset = "0x728")]
	[Token(Token = "0x400028C")]
	private WordWrapState m_SavedLineState; //Field offset: 0x728
	[FieldOffset(Offset = "0xAC0")]
	[Token(Token = "0x400028D")]
	private WordWrapState m_SavedEllipsisState; //Field offset: 0xAC0
	[FieldOffset(Offset = "0xE58")]
	[Token(Token = "0x400028E")]
	private WordWrapState m_SavedLastValidState; //Field offset: 0xE58
	[FieldOffset(Offset = "0x11F0")]
	[Token(Token = "0x400028F")]
	private WordWrapState m_SavedSoftLineBreakState; //Field offset: 0x11F0
	[FieldOffset(Offset = "0x1588")]
	[Token(Token = "0x4000290")]
	private TextElementType m_TextElementType; //Field offset: 0x1588
	[FieldOffset(Offset = "0x1589")]
	[Token(Token = "0x4000291")]
	private bool m_isTextLayoutPhase; //Field offset: 0x1589
	[FieldOffset(Offset = "0x158C")]
	[Token(Token = "0x4000292")]
	private int m_SpriteIndex; //Field offset: 0x158C
	[FieldOffset(Offset = "0x1590")]
	[Token(Token = "0x4000293")]
	private Color32 m_SpriteColor; //Field offset: 0x1590
	[FieldOffset(Offset = "0x1598")]
	[Token(Token = "0x4000294")]
	private TextElement m_CachedTextElement; //Field offset: 0x1598
	[FieldOffset(Offset = "0x15A0")]
	[Token(Token = "0x4000295")]
	private Color32 m_HighlightColor; //Field offset: 0x15A0
	[FieldOffset(Offset = "0x15A4")]
	[Token(Token = "0x4000296")]
	private float m_CharWidthAdjDelta; //Field offset: 0x15A4
	[FieldOffset(Offset = "0x15A8")]
	[Token(Token = "0x4000297")]
	private float m_MaxFontSize; //Field offset: 0x15A8
	[FieldOffset(Offset = "0x15AC")]
	[Token(Token = "0x4000298")]
	private float m_MinFontSize; //Field offset: 0x15AC
	[FieldOffset(Offset = "0x15B0")]
	[Token(Token = "0x4000299")]
	private int m_AutoSizeIterationCount; //Field offset: 0x15B0
	[FieldOffset(Offset = "0x15B4")]
	[Token(Token = "0x400029A")]
	private int m_AutoSizeMaxIterationCount; //Field offset: 0x15B4
	[FieldOffset(Offset = "0x15B8")]
	[Token(Token = "0x400029B")]
	private float m_StartOfLineAscender; //Field offset: 0x15B8
	[FieldOffset(Offset = "0x15BC")]
	[Token(Token = "0x400029C")]
	private float m_LineSpacingDelta; //Field offset: 0x15BC
	[FieldOffset(Offset = "0x15C0")]
	[Token(Token = "0x400029D")]
	internal MaterialReference[] m_MaterialReferences; //Field offset: 0x15C0
	[FieldOffset(Offset = "0x15C8")]
	[Token(Token = "0x400029E")]
	private int m_SpriteCount; //Field offset: 0x15C8
	[FieldOffset(Offset = "0x15D0")]
	[Token(Token = "0x400029F")]
	private TextProcessingStack<Int32> m_StyleStack; //Field offset: 0x15D0
	[FieldOffset(Offset = "0x15F0")]
	[Token(Token = "0x40002A0")]
	private TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; //Field offset: 0x15F0
	[FieldOffset(Offset = "0x19A8")]
	[Token(Token = "0x40002A1")]
	private int m_SpriteAnimationId; //Field offset: 0x19A8
	[FieldOffset(Offset = "0x19AC")]
	[Token(Token = "0x40002A2")]
	private int m_ItalicAngle; //Field offset: 0x19AC
	[FieldOffset(Offset = "0x19B0")]
	[Token(Token = "0x40002A3")]
	private Vector3 m_FXScale; //Field offset: 0x19B0
	[FieldOffset(Offset = "0x19BC")]
	[Token(Token = "0x40002A4")]
	private Quaternion m_FXRotation; //Field offset: 0x19BC
	[FieldOffset(Offset = "0x19CC")]
	[Token(Token = "0x40002A5")]
	private int m_LastBaseGlyphIndex; //Field offset: 0x19CC
	[FieldOffset(Offset = "0x19D0")]
	[Token(Token = "0x40002A6")]
	private float m_PageAscender; //Field offset: 0x19D0
	[FieldOffset(Offset = "0x19D8")]
	[Token(Token = "0x40002A7")]
	private RichTextTagAttribute[] m_XmlAttribute; //Field offset: 0x19D8
	[FieldOffset(Offset = "0x19E0")]
	[Token(Token = "0x40002A8")]
	private Single[] m_AttributeParameterValues; //Field offset: 0x19E0
	[FieldOffset(Offset = "0x19E8")]
	[Token(Token = "0x40002A9")]
	private Dictionary<Int32, Int32> m_MaterialReferenceIndexLookup; //Field offset: 0x19E8
	[FieldOffset(Offset = "0x19F0")]
	[Token(Token = "0x40002AA")]
	private bool m_IsCalculatingPreferredValues; //Field offset: 0x19F0
	[FieldOffset(Offset = "0x19F1")]
	[Token(Token = "0x40002AB")]
	private bool m_TintSprite; //Field offset: 0x19F1
	[FieldOffset(Offset = "0x19F8")]
	[Token(Token = "0x40002AC")]
	protected SpecialCharacter m_Ellipsis; //Field offset: 0x19F8
	[FieldOffset(Offset = "0x1A18")]
	[Token(Token = "0x40002AD")]
	protected SpecialCharacter m_Underline; //Field offset: 0x1A18
	[FieldOffset(Offset = "0x1A38")]
	[Token(Token = "0x40002AE")]
	private TextElementInfo[] m_InternalTextElementInfo; //Field offset: 0x1A38

	[Token(Token = "0x17000062")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool IsExecutingJob
	{
		[Address(RVA = "0x31AE160", Offset = "0x31AD560", Length = "0x37")]
		[CompilerGenerated]
		[Token(Token = "0x60001EC")]
		internal get { } //Length: 55
		[Address(RVA = "0x31AE1D0", Offset = "0x31AD5D0", Length = "0x3C")]
		[CompilerGenerated]
		[Token(Token = "0x60001ED")]
		internal set { } //Length: 60
	}

	[Token(Token = "0x17000063")]
	public bool isTextTruncated
	{
		[Address(RVA = "0x31AE1B0", Offset = "0x31AD5B0", Length = "0x7")]
		[Token(Token = "0x60001EF")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000064")]
	private float m_BaselineOffset
	{
		[Address(RVA = "0x31AE1C0", Offset = "0x31AD5C0", Length = "0xB")]
		[Token(Token = "0x60001F0")]
		private get { } //Length: 11
		[Address(RVA = "0x31AE210", Offset = "0x31AD610", Length = "0x3E")]
		[Token(Token = "0x60001F1")]
		private set { } //Length: 62
	}

	[Token(Token = "0x17000066")]
	private float m_LineHeight
	{
		[Address(RVA = "0x2EF5140", Offset = "0x2EF4540", Length = "0x9")]
		[Token(Token = "0x60001F4")]
		private get { } //Length: 9
		[Address(RVA = "0x31AE250", Offset = "0x31AD650", Length = "0x3E")]
		[Token(Token = "0x60001F5")]
		private set { } //Length: 62
	}

	[Token(Token = "0x17000065")]
	private float m_LineOffset
	{
		[Address(RVA = "0x2EF4290", Offset = "0x2EF3690", Length = "0x9")]
		[Token(Token = "0x60001F2")]
		private get { } //Length: 9
		[Address(RVA = "0x31AE290", Offset = "0x31AD690", Length = "0x3E")]
		[Token(Token = "0x60001F3")]
		private set { } //Length: 62
	}

	[Token(Token = "0x17000067")]
	private float m_XAdvance
	{
		[Address(RVA = "0x2EF4720", Offset = "0x2EF3B20", Length = "0x9")]
		[Token(Token = "0x60001F6")]
		private get { } //Length: 9
		[Address(RVA = "0x31AE2D0", Offset = "0x31AD6D0", Length = "0x88")]
		[Token(Token = "0x60001F7")]
		private set { } //Length: 136
	}

	[Token(Token = "0x17000068")]
	private bool NeedToRound
	{
		[Address(RVA = "0x31AE1A0", Offset = "0x31AD5A0", Length = "0x8")]
		[Token(Token = "0x6000206")]
		private get { } //Length: 8
	}

	[Address(RVA = "0x31AD760", Offset = "0x31ACB60", Length = "0xA00")]
	[Token(Token = "0x6000219")]
	public TextGenerator() { }

	[Address(RVA = "0x31912A0", Offset = "0x31906A0", Length = "0x3B2F")]
	[Token(Token = "0x600020C")]
	protected override Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x3194DD0", Offset = "0x31941D0", Length = "0x5D")]
	[Token(Token = "0x60001FD")]
	private void ClearMarkupTagAttributes() { }

	[Address(RVA = "0x3194E30", Offset = "0x3194230", Length = "0x23")]
	[Token(Token = "0x6000204")]
	private static void ClearMesh(bool updateMesh, TextInfo textInfo) { }

	[Address(RVA = "0x3194E60", Offset = "0x3194260", Length = "0x63")]
	[Token(Token = "0x60001FB")]
	internal void CloseAllLinkTags(TextInfo textInfo) { }

	[Address(RVA = "0x3194ED0", Offset = "0x31942D0", Length = "0x85")]
	[Token(Token = "0x60001FA")]
	internal void CloseLastLinkTag(TextInfo textInfo) { }

	[Address(RVA = "0x3194F60", Offset = "0x3194360", Length = "0x6D")]
	[Token(Token = "0x60001FC")]
	private void CloseLinkTag(TextInfo textInfo, int index) { }

	[Address(RVA = "0x3194FD0", Offset = "0x31943D0", Length = "0x138")]
	[Token(Token = "0x6000214")]
	private void ComputeMarginSize(Rect rect, Vector4 margins) { }

	[Address(RVA = "0x3195110", Offset = "0x3194510", Length = "0x7D")]
	[Token(Token = "0x6000218")]
	protected void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo) { }

	[Address(RVA = "0x3195190", Offset = "0x3194590", Length = "0x5B8")]
	[Token(Token = "0x6000203")]
	private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x3195750", Offset = "0x3194B50", Length = "0xC1F")]
	[Token(Token = "0x6000202")]
	private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x3196A00", Offset = "0x3195E00", Length = "0x187")]
	[Token(Token = "0x60001EE")]
	public void GenerateText(TextGenerationSettings settings, TextInfo textInfo) { }

	[Address(RVA = "0x3196370", Offset = "0x3195770", Length = "0x687")]
	[Token(Token = "0x60001F8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x31AE160", Offset = "0x31AD560", Length = "0x37")]
	[CompilerGenerated]
	[Token(Token = "0x60001EC")]
	internal static bool get_IsExecutingJob() { }

	[Address(RVA = "0x31AE1B0", Offset = "0x31AD5B0", Length = "0x7")]
	[Token(Token = "0x60001EF")]
	public bool get_isTextTruncated() { }

	[Address(RVA = "0x31AE1C0", Offset = "0x31AD5C0", Length = "0xB")]
	[Token(Token = "0x60001F0")]
	private float get_m_BaselineOffset() { }

	[Address(RVA = "0x2EF5140", Offset = "0x2EF4540", Length = "0x9")]
	[Token(Token = "0x60001F4")]
	private float get_m_LineHeight() { }

	[Address(RVA = "0x2EF4290", Offset = "0x2EF3690", Length = "0x9")]
	[Token(Token = "0x60001F2")]
	private float get_m_LineOffset() { }

	[Address(RVA = "0x2EF4720", Offset = "0x2EF3B20", Length = "0x9")]
	[Token(Token = "0x60001F6")]
	private float get_m_XAdvance() { }

	[Address(RVA = "0x31AE1A0", Offset = "0x31AD5A0", Length = "0x8")]
	[Token(Token = "0x6000206")]
	private bool get_NeedToRound() { }

	[Address(RVA = "0x3196B90", Offset = "0x3195F90", Length = "0x34D")]
	[Token(Token = "0x6000216")]
	protected bool GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x3197050", Offset = "0x3196450", Length = "0x26B")]
	[Token(Token = "0x600020A")]
	public Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo) { }

	[Address(RVA = "0x3196EE0", Offset = "0x31962E0", Length = "0x165")]
	[Token(Token = "0x600020B")]
	private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x31972C0", Offset = "0x31966C0", Length = "0x52")]
	[Token(Token = "0x6000215")]
	protected bool GetSpecialCharacters(TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x3197320", Offset = "0x3196720", Length = "0x53A")]
	[Token(Token = "0x6000210")]
	private TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface, bool populateLigatures) { }

	[Address(RVA = "0x3197860", Offset = "0x3196C60", Length = "0x543")]
	[Token(Token = "0x6000217")]
	protected bool GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x3197DB0", Offset = "0x31971B0", Length = "0x93D")]
	[Token(Token = "0x6000209")]
	private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x31986F0", Offset = "0x3197AF0", Length = "0x368F")]
	[Token(Token = "0x6000205")]
	public void LayoutPhase(TextInfo textInfo, TextGenerationSettings generationSettings, float maxVisibleDescender) { }

	[Address(RVA = "0x319BD80", Offset = "0x319B180", Length = "0x3CAC")]
	[Token(Token = "0x6000208")]
	public void ParsingPhase(TextInfo textInfo, TextGenerationSettings generationSettings, out uint charCode, out float maxVisibleDescender) { }

	[Address(RVA = "0x31A19A0", Offset = "0x31A0DA0", Length = "0x14DC")]
	[Token(Token = "0x6000213")]
	private bool PopulateFontAsset(TextGenerationSettings generationSettings, TextProcessingElement[] textProcessingArray) { }

	[Address(RVA = "0x31A2E80", Offset = "0x31A2280", Length = "0xFE")]
	[Token(Token = "0x6000211")]
	private void PopulateTextBackingArray(in RenderedText sourceText) { }

	[Address(RVA = "0x31A2F80", Offset = "0x31A2380", Length = "0xDC8")]
	[Token(Token = "0x6000212")]
	private void PopulateTextProcessingArray(TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x31A3E60", Offset = "0x31A3260", Length = "0x2BF")]
	[Token(Token = "0x600020D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x31A3D70", Offset = "0x31A3170", Length = "0xE2")]
	[Token(Token = "0x600020E")]
	internal bool PrepareFontAsset(TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x31A4120", Offset = "0x31A3520", Length = "0x5D3")]
	[Token(Token = "0x60001FF")]
	private int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo) { }

	[Address(RVA = "0x31A4700", Offset = "0x31A3B00", Length = "0x1D")]
	[Token(Token = "0x6000207")]
	private float Round(float v) { }

	[Address(RVA = "0x31A4720", Offset = "0x31A3B20", Length = "0xCE6")]
	[Token(Token = "0x6000200")]
	private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x31A5410", Offset = "0x31A4810", Length = "0x7A5")]
	[Token(Token = "0x6000201")]
	private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x31A5BC0", Offset = "0x31A4FC0", Length = "0x589")]
	[Token(Token = "0x60001FE")]
	private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo) { }

	[Address(RVA = "0x31AE1D0", Offset = "0x31AD5D0", Length = "0x3C")]
	[CompilerGenerated]
	[Token(Token = "0x60001ED")]
	internal static void set_IsExecutingJob(bool value) { }

	[Address(RVA = "0x31AE210", Offset = "0x31AD610", Length = "0x3E")]
	[Token(Token = "0x60001F1")]
	private void set_m_BaselineOffset(float value) { }

	[Address(RVA = "0x31AE250", Offset = "0x31AD650", Length = "0x3E")]
	[Token(Token = "0x60001F5")]
	private void set_m_LineHeight(float value) { }

	[Address(RVA = "0x31AE290", Offset = "0x31AD690", Length = "0x3E")]
	[Token(Token = "0x60001F3")]
	private void set_m_LineOffset(float value) { }

	[Address(RVA = "0x31AE2D0", Offset = "0x31AD6D0", Length = "0x88")]
	[Token(Token = "0x60001F7")]
	private void set_m_XAdvance(float value) { }

	[Address(RVA = "0x31A6150", Offset = "0x31A5550", Length = "0x1F42")]
	[Token(Token = "0x600020F")]
	private int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x31A80A0", Offset = "0x31A74A0", Length = "0x56B0")]
	[Token(Token = "0x60001F9")]
	private bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo, out bool isThreadSuccess) { }

}

