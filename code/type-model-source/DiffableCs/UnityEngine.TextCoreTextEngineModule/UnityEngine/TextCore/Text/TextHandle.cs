namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("{settings.text}")]
[Token(Token = "0x200005E")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule", "UnityEditor.QuickSearchModule"})]
internal class TextHandle
{
	[CompilerGenerated]
	[Token(Token = "0x2000060")]
	private sealed class <>c
	{
		[Token(Token = "0x4000397")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000398")]
		public static Func<TextGenerationSettings> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x4000399")]
		public static Func<TextGenerator> <>9__3_1; //Field offset: 0x10
		[Token(Token = "0x400039A")]
		public static Func<TextInfo> <>9__3_2; //Field offset: 0x18
		[Token(Token = "0x400039B")]
		public static Func<TextGenerationSettings> <>9__6_0; //Field offset: 0x20
		[Token(Token = "0x400039C")]
		public static Func<TextGenerator> <>9__9_0; //Field offset: 0x28
		[Token(Token = "0x400039D")]
		public static Func<TextInfo> <>9__12_0; //Field offset: 0x30

		[Address(RVA = "0x31C9770", Offset = "0x31C8B70", Length = "0x67")]
		[Token(Token = "0x60002FA")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002FB")]
		public <>c() { }

		[Address(RVA = "0x31C9680", Offset = "0x31C8A80", Length = "0x44")]
		[Token(Token = "0x6000300")]
		internal TextGenerator <get_generators>b__9_0() { }

		[Address(RVA = "0x31C96D0", Offset = "0x31C8AD0", Length = "0x44")]
		[Token(Token = "0x60002FF")]
		internal TextGenerationSettings <get_settingsArray>b__6_0() { }

		[Address(RVA = "0x31C9720", Offset = "0x31C8B20", Length = "0x44")]
		[Token(Token = "0x6000301")]
		internal TextInfo <get_textInfosCommon>b__12_0() { }

		[Address(RVA = "0x31C9590", Offset = "0x31C8990", Length = "0x44")]
		[Token(Token = "0x60002FC")]
		internal TextGenerationSettings <InitThreadArrays>b__3_0() { }

		[Address(RVA = "0x31C95E0", Offset = "0x31C89E0", Length = "0x44")]
		[Token(Token = "0x60002FD")]
		internal TextGenerator <InitThreadArrays>b__3_1() { }

		[Address(RVA = "0x31C9630", Offset = "0x31C8A30", Length = "0x44")]
		[Token(Token = "0x60002FE")]
		internal TextInfo <InitThreadArrays>b__3_2() { }

	}

	[Flags]
	[Token(Token = "0x200005F")]
	internal enum TextHandleFlags : int
	{
		IsCachedPermanentTextCore = 2,
		IsCachedPermanentATG = 4,
	}

	[Token(Token = "0x4000382")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static TextHandleTemporaryCache s_TemporaryCache; //Field offset: 0x0
	[Token(Token = "0x4000383")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static TextHandlePermanentCache s_PermanentCache; //Field offset: 0x8
	[Token(Token = "0x4000384")]
	private static TextGenerationSettings[] s_Settings; //Field offset: 0x10
	[Token(Token = "0x4000385")]
	private static TextGenerator[] s_Generators; //Field offset: 0x18
	[Token(Token = "0x4000386")]
	private static TextInfo[] s_TextInfosCommon; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000387")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal NativeTextGenerationSettings nativeSettings; //Field offset: 0x10
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000388")]
	protected Vector2 pixelPreferedSize; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000389")]
	private Rect m_ScreenRect; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400038A")]
	private float m_LineHeightDefault; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x400038B")]
	private bool m_IsPlaceholder; //Field offset: 0x9C
	[FieldOffset(Offset = "0x9D")]
	[Token(Token = "0x400038C")]
	protected bool m_IsElided; //Field offset: 0x9D
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400038D")]
	private int m_CreateGenerationIteration; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400038E")]
	private IntPtr m_TextGenerationInfo; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400038F")]
	private LinkedListNode<TextCacheEntry> <TextInfoNode>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000390")]
	private bool <IsCachedTemporary>k__BackingField; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000391")]
	 TextHandleFlags m_TextHandleFlags; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000392")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal int m_PreviousGenerationSettingsHash; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000393")]
	protected bool isDirty; //Field offset: 0xC4

	[Token(Token = "0x17000084")]
	internal int characterCount
	{
		[Address(RVA = "0x31BED00", Offset = "0x31BE100", Length = "0x6F")]
		[Token(Token = "0x60002C8")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 111
	}

	[Token(Token = "0x1700007A")]
	private static TextGenerator generator
	{
		[Address(RVA = "0x31BED70", Offset = "0x31BE170", Length = "0x207")]
		[Token(Token = "0x60002B5")]
		private get { } //Length: 519
	}

	[Token(Token = "0x17000077")]
	internal static TextGenerator[] generators
	{
		[Address(RVA = "0x31BEF80", Offset = "0x31BE380", Length = "0x1C7")]
		[Token(Token = "0x60002B1")]
		internal get { } //Length: 455
	}

	[Token(Token = "0x1700007F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	protected private bool IsCachedPermanent
	{
		[Address(RVA = "0x31BECF0", Offset = "0x31BE0F0", Length = "0xB")]
		[Token(Token = "0x60002C0")]
		private get { } //Length: 11
	}

	[Token(Token = "0x17000080")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool IsCachedPermanentATG
	{
		[Address(RVA = "0x31BEA90", Offset = "0x31BDE90", Length = "0x8A")]
		[Token(Token = "0x60002C1")]
		internal get { } //Length: 138
		[Address(RVA = "0x31BFB10", Offset = "0x31BEF10", Length = "0x1F")]
		[Token(Token = "0x60002C2")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x17000081")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool IsCachedPermanentTextCore
	{
		[Address(RVA = "0x31BEB20", Offset = "0x31BDF20", Length = "0x1CA")]
		[Token(Token = "0x60002C3")]
		internal get { } //Length: 458
		[Address(RVA = "0x31BFB30", Offset = "0x31BEF30", Length = "0x1F")]
		[Token(Token = "0x60002C4")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x17000082")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool IsCachedTemporary
	{
		[Address(RVA = "0x2D67DB0", Offset = "0x2D671B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60002C5")]
		internal get { } //Length: 8
		[Address(RVA = "0x2D687F0", Offset = "0x2D67BF0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60002C6")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000086")]
	public override bool IsPlaceholder
	{
		[Address(RVA = "0x2424CE0", Offset = "0x24240E0", Length = "0x8")]
		[Token(Token = "0x60002D3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700007C")]
	internal Vector2 preferredSize
	{
		[Address(RVA = "0x31BF150", Offset = "0x31BE550", Length = "0x50")]
		[Token(Token = "0x60002B7")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 80
	}

	[Token(Token = "0x1700007B")]
	internal static TextGenerationSettings settings
	{
		[Address(RVA = "0x31BF370", Offset = "0x31BE770", Length = "0x207")]
		[Token(Token = "0x60002B6")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 519
	}

	[Token(Token = "0x17000076")]
	internal static TextGenerationSettings[] settingsArray
	{
		[Address(RVA = "0x31BF1A0", Offset = "0x31BE5A0", Length = "0x1C7")]
		[Token(Token = "0x60002B0")]
		internal get { } //Length: 455
	}

	[Token(Token = "0x1700007D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal IntPtr textGenerationInfo
	{
		[Address(RVA = "0x31BF580", Offset = "0x31BE980", Length = "0xD6")]
		[Token(Token = "0x60002BC")]
		internal get { } //Length: 214
		[Address(RVA = "0x31BFB50", Offset = "0x31BEF50", Length = "0xC5")]
		[Token(Token = "0x60002BD")]
		internal set { } //Length: 197
	}

	[Token(Token = "0x17000085")]
	internal TextInfo textInfo
	{
		[Address(RVA = "0x31BF870", Offset = "0x31BEC70", Length = "0xC3")]
		[Token(Token = "0x60002D0")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 195
	}

	[Token(Token = "0x17000079")]
	internal static TextInfo textInfoCommon
	{
		[Address(RVA = "0x31BF660", Offset = "0x31BEA60", Length = "0x207")]
		[Token(Token = "0x60002B4")]
		internal get { } //Length: 519
	}

	[Token(Token = "0x1700007E")]
	internal LinkedListNode<TextCacheEntry> TextInfoNode
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60002BE")]
		internal get { } //Length: 8
		[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60002BF")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000078")]
	internal static TextInfo[] textInfosCommon
	{
		[Address(RVA = "0x31BF940", Offset = "0x31BED40", Length = "0x1C7")]
		[Token(Token = "0x60002B2")]
		internal get { } //Length: 455
	}

	[Token(Token = "0x17000083")]
	internal bool useAdvancedText
	{
		[Address(RVA = "0x2077B00", Offset = "0x2076F00", Length = "0x14")]
		[Token(Token = "0x60002C7")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 20
	}

	[Address(RVA = "0x31BE940", Offset = "0x31BDD40", Length = "0xC4")]
	[Token(Token = "0x60002F9")]
	private static TextHandle() { }

	[Address(RVA = "0x31BEA10", Offset = "0x31BDE10", Length = "0x7C")]
	[Token(Token = "0x60002F8")]
	public TextHandle() { }

	[Address(RVA = "0x31BBA80", Offset = "0x31BAE80", Length = "0x91")]
	[Token(Token = "0x60002CA")]
	public void AddTextInfoToTemporaryCache(int hashCode) { }

	[Address(RVA = "0x31BBB20", Offset = "0x31BAF20", Length = "0xCC")]
	[Token(Token = "0x60002C9")]
	public override void AddToPermanentCacheAndGenerateMesh() { }

	[Address(RVA = "0x31BBBF0", Offset = "0x31BAFF0", Length = "0xDA")]
	[Token(Token = "0x60002D9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static float ConvertPixelUnitsToTextCoreRelativeUnits(float fontSize, FontAsset fontAsset) { }

	[Address(RVA = "0x31BBCD0", Offset = "0x31BB0D0", Length = "0x1FE")]
	[Token(Token = "0x60002AE")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x31BBED0", Offset = "0x31BB2D0", Length = "0x14E")]
	[Token(Token = "0x60002E1")]
	public int FindIntersectingLink(Vector3 position, bool inverseYAxis = true) { }

	[Address(RVA = "0x31BED00", Offset = "0x31BE100", Length = "0x6F")]
	[Token(Token = "0x60002C8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal int get_characterCount() { }

	[Address(RVA = "0x31BED70", Offset = "0x31BE170", Length = "0x207")]
	[Token(Token = "0x60002B5")]
	private static TextGenerator get_generator() { }

	[Address(RVA = "0x31BEF80", Offset = "0x31BE380", Length = "0x1C7")]
	[Token(Token = "0x60002B1")]
	internal static TextGenerator[] get_generators() { }

	[Address(RVA = "0x31BECF0", Offset = "0x31BE0F0", Length = "0xB")]
	[Token(Token = "0x60002C0")]
	protected private bool get_IsCachedPermanent() { }

	[Address(RVA = "0x31BEA90", Offset = "0x31BDE90", Length = "0x8A")]
	[Token(Token = "0x60002C1")]
	internal bool get_IsCachedPermanentATG() { }

	[Address(RVA = "0x31BEB20", Offset = "0x31BDF20", Length = "0x1CA")]
	[Token(Token = "0x60002C3")]
	internal bool get_IsCachedPermanentTextCore() { }

	[Address(RVA = "0x2D67DB0", Offset = "0x2D671B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60002C5")]
	internal bool get_IsCachedTemporary() { }

	[Address(RVA = "0x2424CE0", Offset = "0x24240E0", Length = "0x8")]
	[Token(Token = "0x60002D3")]
	public override bool get_IsPlaceholder() { }

	[Address(RVA = "0x31BF150", Offset = "0x31BE550", Length = "0x50")]
	[Token(Token = "0x60002B7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Vector2 get_preferredSize() { }

	[Address(RVA = "0x31BF370", Offset = "0x31BE770", Length = "0x207")]
	[Token(Token = "0x60002B6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static TextGenerationSettings get_settings() { }

	[Address(RVA = "0x31BF1A0", Offset = "0x31BE5A0", Length = "0x1C7")]
	[Token(Token = "0x60002B0")]
	internal static TextGenerationSettings[] get_settingsArray() { }

	[Address(RVA = "0x31BF580", Offset = "0x31BE980", Length = "0xD6")]
	[Token(Token = "0x60002BC")]
	internal IntPtr get_textGenerationInfo() { }

	[Address(RVA = "0x31BF870", Offset = "0x31BEC70", Length = "0xC3")]
	[Token(Token = "0x60002D0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo get_textInfo() { }

	[Address(RVA = "0x31BF660", Offset = "0x31BEA60", Length = "0x207")]
	[Token(Token = "0x60002B4")]
	internal static TextInfo get_textInfoCommon() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60002BE")]
	internal LinkedListNode<TextCacheEntry> get_TextInfoNode() { }

	[Address(RVA = "0x31BF940", Offset = "0x31BED40", Length = "0x1C7")]
	[Token(Token = "0x60002B2")]
	internal static TextInfo[] get_textInfosCommon() { }

	[Address(RVA = "0x2077B00", Offset = "0x2076F00", Length = "0x14")]
	[Token(Token = "0x60002C7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool get_useAdvancedText() { }

	[Address(RVA = "0x31BC020", Offset = "0x31BB420", Length = "0xB6")]
	[Token(Token = "0x60002E7")]
	public float GetCharacterHeightFromIndex(int index) { }

	[Address(RVA = "0x31BC0E0", Offset = "0x31BB4E0", Length = "0x56")]
	[Token(Token = "0x60002E2")]
	public int GetCorrespondingStringIndex(int index) { }

	[Address(RVA = "0x31BC140", Offset = "0x31BB540", Length = "0xFD")]
	[Token(Token = "0x60002DE")]
	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = true) { }

	[Address(RVA = "0x31BC240", Offset = "0x31BB640", Length = "0x128")]
	[Token(Token = "0x60002DB")]
	public override Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = true) { }

	[Address(RVA = "0x31BC370", Offset = "0x31BB770", Length = "0x130")]
	[Token(Token = "0x60002DC")]
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = false, bool inverseYAxis = true) { }

	[Address(RVA = "0x31BC4B0", Offset = "0x31BB8B0", Length = "0xBF")]
	[Token(Token = "0x60002EC")]
	public int GetEndOfPreviousWord(int currentIndex) { }

	[Address(RVA = "0x31BC570", Offset = "0x31BB970", Length = "0x97")]
	[Token(Token = "0x60002ED")]
	public int GetFirstCharacterIndexOnLine(int currentIndex) { }

	[Address(RVA = "0x31BC610", Offset = "0x31BBA10", Length = "0x19D")]
	[Token(Token = "0x60002DD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Rect[] GetHighlightRectangles(int cursorIndex, int selectIndex) { }

	[Address(RVA = "0x31BC7B0", Offset = "0x31BBBB0", Length = "0x99")]
	[Token(Token = "0x60002EE")]
	public int GetLastCharacterIndexOnLine(int currentIndex) { }

	[Address(RVA = "0x31BCAD0", Offset = "0x31BBED0", Length = "0xB6")]
	[Token(Token = "0x60002E5")]
	public float GetLineHeight(int lineNumber) { }

	[Address(RVA = "0x31BC850", Offset = "0x31BBC50", Length = "0x1B7")]
	[Token(Token = "0x60002DA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal static float GetLineHeightDefault(TextGenerationSettings settings) { }

	[Address(RVA = "0x31BCA10", Offset = "0x31BBE10", Length = "0xB6")]
	[Token(Token = "0x60002E6")]
	public float GetLineHeightFromCharacterIndex(int index) { }

	[Address(RVA = "0x31BCB90", Offset = "0x31BBF90", Length = "0x127")]
	[Token(Token = "0x60002E3")]
	public LineInfo GetLineInfoFromCharacterIndex(int index) { }

	[Address(RVA = "0x31BCCC0", Offset = "0x31BC0C0", Length = "0x8B")]
	[Token(Token = "0x60002E4")]
	public int GetLineNumber(int index) { }

	[Address(RVA = "0x21D6EB0", Offset = "0x21D62B0", Length = "0x9")]
	[Token(Token = "0x60002BB")]
	protected override float GetPixelsPerPoint() { }

	[Address(RVA = "0x31BCD50", Offset = "0x31BC150", Length = "0xBF")]
	[Token(Token = "0x60002EB")]
	public int GetStartOfNextWord(int currentIndex) { }

	[Address(RVA = "0x31BCE10", Offset = "0x31BC210", Length = "0xC3")]
	[Token(Token = "0x60002EF")]
	public int IndexOf(char value, int startIndex) { }

	[Address(RVA = "0x943520", Offset = "0x942920", Length = "0xFE")]
	[Token(Token = "0x60002B3")]
	private static void InitArray(ref T[] array, Func<T> createInstance) { }

	[Address(RVA = "0x31BCEE0", Offset = "0x31BC2E0", Length = "0x3E6")]
	[Token(Token = "0x60002AF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static void InitThreadArrays() { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[Token(Token = "0x60002F7")]
	internal override bool IsAdvancedTextEnabledForElement() { }

	[Address(RVA = "0x31BD2D0", Offset = "0x31BC6D0", Length = "0x2B")]
	[Token(Token = "0x60002D2")]
	public bool IsDirty(int hashCode) { }

	[Address(RVA = "0x31BD300", Offset = "0x31BC700", Length = "0xC3")]
	[Token(Token = "0x60002F0")]
	public int LastIndexOf(char value, int startIndex) { }

	[Address(RVA = "0x31BD3D0", Offset = "0x31BC7D0", Length = "0x8B")]
	[Token(Token = "0x60002DF")]
	public int LineDownCharacterPosition(int originalLogicalPos) { }

	[Address(RVA = "0x31BD460", Offset = "0x31BC860", Length = "0x8B")]
	[Token(Token = "0x60002E0")]
	public int LineUpCharacterPosition(int originalLogicalPos) { }

	[Address(RVA = "0x31BD4F0", Offset = "0x31BC8F0", Length = "0xBF")]
	[Token(Token = "0x60002EA")]
	public int NextCodePointIndex(int currentIndex) { }

	[Address(RVA = "0x31BD5B0", Offset = "0x31BC9B0", Length = "0x3D")]
	[Token(Token = "0x60002BA")]
	protected Vector2 PixelsToPoints(Vector2 pixel) { }

	[Address(RVA = "0x31BD5F0", Offset = "0x31BC9F0", Length = "0x30")]
	[Token(Token = "0x60002B8")]
	protected float PixelsToPoints(float pixel) { }

	[Address(RVA = "0x31BD620", Offset = "0x31BCA20", Length = "0x3D")]
	[Token(Token = "0x60002B9")]
	protected Vector2 PointsToPixels(Vector2 point) { }

	[Address(RVA = "0x31BD660", Offset = "0x31BCA60", Length = "0x140")]
	[Token(Token = "0x60002D7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool PrepareFontAsset() { }

	[Address(RVA = "0x31BD7B0", Offset = "0x31BCBB0", Length = "0xBF")]
	[Token(Token = "0x60002E9")]
	public int PreviousCodePointIndex(int currentIndex) { }

	[Address(RVA = "0x31BD9D0", Offset = "0x31BCDD0", Length = "0x145")]
	[Token(Token = "0x60002CC")]
	public void RemoveFromPermanentCache() { }

	[Address(RVA = "0x31BD870", Offset = "0x31BCC70", Length = "0xEB")]
	[Token(Token = "0x60002CE")]
	public void RemoveFromPermanentCacheATG() { }

	[Address(RVA = "0x31BD960", Offset = "0x31BCD60", Length = "0x69")]
	[Token(Token = "0x60002CD")]
	public void RemoveFromPermanentCacheTextCore() { }

	[Address(RVA = "0x31BDB20", Offset = "0x31BCF20", Length = "0x68")]
	[Token(Token = "0x60002CB")]
	public void RemoveFromTemporaryCache() { }

	[Address(RVA = "0x31BDB90", Offset = "0x31BCF90", Length = "0xD4")]
	[Token(Token = "0x60002F2")]
	public void SelectCurrentParagraph(ref int cursorIndex, ref int selectIndex) { }

	[Address(RVA = "0x31BDC70", Offset = "0x31BD070", Length = "0xD4")]
	[Token(Token = "0x60002F1")]
	public void SelectCurrentWord(int index, ref int cursorIndex, ref int selectIndex) { }

	[Address(RVA = "0x31BDD50", Offset = "0x31BD150", Length = "0xBF")]
	[Token(Token = "0x60002F6")]
	public void SelectToEndOfParagraph(ref int cursorIndex) { }

	[Address(RVA = "0x31BDE10", Offset = "0x31BD210", Length = "0xBF")]
	[Token(Token = "0x60002F4")]
	public void SelectToNextParagraph(ref int cursorIndex) { }

	[Address(RVA = "0x31BDED0", Offset = "0x31BD2D0", Length = "0xBF")]
	[Token(Token = "0x60002F3")]
	public void SelectToPreviousParagraph(ref int cursorIndex) { }

	[Address(RVA = "0x31BDF90", Offset = "0x31BD390", Length = "0xBF")]
	[Token(Token = "0x60002F5")]
	public void SelectToStartOfParagraph(ref int cursorIndex) { }

	[Address(RVA = "0x31BFB10", Offset = "0x31BEF10", Length = "0x1F")]
	[Token(Token = "0x60002C2")]
	internal void set_IsCachedPermanentATG(bool value) { }

	[Address(RVA = "0x31BFB30", Offset = "0x31BEF30", Length = "0x1F")]
	[Token(Token = "0x60002C4")]
	internal void set_IsCachedPermanentTextCore(bool value) { }

	[Address(RVA = "0x2D687F0", Offset = "0x2D67BF0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60002C6")]
	internal void set_IsCachedTemporary(bool value) { }

	[Address(RVA = "0x31BFB50", Offset = "0x31BEF50", Length = "0xC5")]
	[Token(Token = "0x60002BD")]
	internal void set_textGenerationInfo(IntPtr value) { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60002BF")]
	internal void set_TextInfoNode(LinkedListNode<TextCacheEntry> value) { }

	[Address(RVA = "0x31BE050", Offset = "0x31BD450", Length = "0x8")]
	[Token(Token = "0x60002D1")]
	public override void SetDirty() { }

	[Address(RVA = "0x31BE060", Offset = "0x31BD460", Length = "0x87")]
	[Token(Token = "0x60002E8")]
	public string Substring(int startIndex, int length) { }

	[Address(RVA = "0x31BE8C0", Offset = "0x31BDCC0", Length = "0x74")]
	[Token(Token = "0x60002D5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo Update() { }

	[Address(RVA = "0x31BE0F0", Offset = "0x31BD4F0", Length = "0x5E")]
	[Token(Token = "0x60002CF")]
	public static void UpdateCurrentFrame() { }

	[Address(RVA = "0x31BE150", Offset = "0x31BD550", Length = "0x31D")]
	[Token(Token = "0x60002D8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal void UpdatePreferredSize() { }

	[Address(RVA = "0x31BE470", Offset = "0x31BD870", Length = "0xA3")]
	[Token(Token = "0x60002D4")]
	protected void UpdatePreferredValues(TextGenerationSettings tgs) { }

	[Address(RVA = "0x31BE520", Offset = "0x31BD920", Length = "0x399")]
	[Token(Token = "0x60002D6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo UpdateWithHash(int hashCode) { }

}

