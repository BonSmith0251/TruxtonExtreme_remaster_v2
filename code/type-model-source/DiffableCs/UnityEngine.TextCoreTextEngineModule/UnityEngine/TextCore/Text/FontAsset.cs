namespace UnityEngine.TextCore.Text;

[ExcludeFromPreset]
[NativeHeader("Modules/TextCoreTextEngine/Native/FontAsset.h")]
[Token(Token = "0x2000031")]
public class FontAsset : TextAsset
{
	[CompilerGenerated]
	[Token(Token = "0x2000032")]
	private sealed class <>c
	{
		[Token(Token = "0x4000174")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000175")]
		public static Func<Character, UInt32> <>9__190_0; //Field offset: 0x8
		[Token(Token = "0x4000176")]
		public static Func<Glyph, UInt32> <>9__191_0; //Field offset: 0x10

		[Address(RVA = "0x31C3DE0", Offset = "0x31C31E0", Length = "0x67")]
		[Token(Token = "0x600013E")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600013F")]
		public <>c() { }

		[Address(RVA = "0x2ED9790", Offset = "0x2ED8B90", Length = "0x16")]
		[Token(Token = "0x6000140")]
		internal uint <SortCharacterTable>b__190_0(Character c) { }

		[Address(RVA = "0x2ED9830", Offset = "0x2ED8C30", Length = "0x1F")]
		[Token(Token = "0x6000141")]
		internal uint <SortGlyphTable>b__191_0(Glyph c) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000033")]
	private sealed class <>c__DisplayClass231_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000177")]
		public HashSet<UInt32> successfullyAddedGlyphIndices; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000142")]
		public <>c__DisplayClass231_0() { }

		[Address(RVA = "0x31C3790", Offset = "0x31C2B90", Length = "0x51")]
		[Token(Token = "0x6000143")]
		internal bool <TryAddGlyphs>b__1(uint id) { }

	}

	[Token(Token = "0x400015F")]
	private static readonly List<WeakReference`1<FontAsset>> s_CallbackInstances; //Field offset: 0x0
	[Token(Token = "0x4000160")]
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; //Field offset: 0x8
	[Token(Token = "0x4000161")]
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; //Field offset: 0x10
	[Token(Token = "0x4000162")]
	private static ProfilerMarker k_TryAddGlyphMarker; //Field offset: 0x18
	[Token(Token = "0x4000163")]
	private static ProfilerMarker k_TryAddCharacterMarker; //Field offset: 0x20
	[Token(Token = "0x4000164")]
	private static ProfilerMarker k_TryAddCharactersMarker; //Field offset: 0x28
	[Token(Token = "0x4000165")]
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; //Field offset: 0x30
	[Token(Token = "0x4000166")]
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; //Field offset: 0x38
	[Token(Token = "0x4000167")]
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; //Field offset: 0x40
	[Token(Token = "0x4000168")]
	private static ProfilerMarker k_ClearFontAssetDataMarker; //Field offset: 0x48
	[Token(Token = "0x4000169")]
	private static ProfilerMarker k_UpdateFontAssetDataMarker; //Field offset: 0x50
	[Token(Token = "0x400016A")]
	private static string s_DefaultMaterialSuffix; //Field offset: 0x58
	[Token(Token = "0x400016B")]
	private static HashSet<Int32> k_SearchedFontAssetLookup; //Field offset: 0x60
	[Token(Token = "0x400016C")]
	private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue; //Field offset: 0x68
	[Token(Token = "0x400016D")]
	private static HashSet<Int32> k_FontAssets_FontFeaturesUpdateQueueLookup; //Field offset: 0x70
	[Token(Token = "0x400016E")]
	private static List<FontAsset> k_FontAssets_KerningUpdateQueue; //Field offset: 0x78
	[Token(Token = "0x400016F")]
	private static HashSet<Int32> k_FontAssets_KerningUpdateQueueLookup; //Field offset: 0x80
	[Token(Token = "0x4000170")]
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; //Field offset: 0x88
	[Token(Token = "0x4000171")]
	private static HashSet<Int32> k_FontAssets_AtlasTexturesUpdateQueueLookup; //Field offset: 0x90
	[Token(Token = "0x4000172")]
	internal static UInt32[] k_GlyphIndexArray; //Field offset: 0x98
	[Token(Token = "0x4000173")]
	private static HashSet<Int32> visitedFontAssets; //Field offset: 0xA0
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400012D")]
	internal string m_SourceFontFileGUID; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400012E")]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; //Field offset: 0x40
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x400012F")]
	private Font m_SourceFontFile; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000130")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal string m_SourceFontFilePath; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000131")]
	private AtlasPopulationMode m_AtlasPopulationMode; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	[Token(Token = "0x4000132")]
	internal bool InternalDynamicOS; //Field offset: 0xAC
	[FieldOffset(Offset = "0xAD")]
	[SerializeField]
	[Token(Token = "0x4000133")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool IsEditorFont; //Field offset: 0xAD
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000134")]
	internal FaceInfo m_FaceInfo; //Field offset: 0xB0
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000135")]
	private int m_FamilyNameHashCode; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000136")]
	private int m_StyleNameHashCode; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Nullable(1)]
	[SerializeField]
	[Token(Token = "0x4000137")]
	internal List<Glyph> m_GlyphTable; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000138")]
	internal Dictionary<UInt32, Glyph> m_GlyphLookupDictionary; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x4000139")]
	internal List<Character> m_CharacterTable; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400013A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Dictionary<UInt32, Character> m_CharacterLookupDictionary; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400013B")]
	internal Texture2D m_AtlasTexture; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x400013C")]
	internal Texture2D[] m_AtlasTextures; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x400013D")]
	internal int m_AtlasTextureIndex; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[SerializeField]
	[Token(Token = "0x400013E")]
	private bool m_IsMultiAtlasTexturesEnabled; //Field offset: 0x14C
	[FieldOffset(Offset = "0x14D")]
	[SerializeField]
	[Token(Token = "0x400013F")]
	private bool m_GetFontFeatures; //Field offset: 0x14D
	[FieldOffset(Offset = "0x14E")]
	[SerializeField]
	[Token(Token = "0x4000140")]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0x14E
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x4000141")]
	internal int m_AtlasWidth; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[SerializeField]
	[Token(Token = "0x4000142")]
	internal int m_AtlasHeight; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x4000143")]
	internal int m_AtlasPadding; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[SerializeField]
	[Token(Token = "0x4000144")]
	internal GlyphRenderMode m_AtlasRenderMode; //Field offset: 0x15C
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Token(Token = "0x4000145")]
	private List<GlyphRect> m_UsedGlyphRects; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x4000146")]
	private List<GlyphRect> m_FreeGlyphRects; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	[Token(Token = "0x4000147")]
	internal FontFeatureTable m_FontFeatureTable; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	[Token(Token = "0x4000148")]
	internal bool m_ShouldReimportFontFeatures; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x4000149")]
	internal List<FontAsset> m_FallbackFontAssetTable; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[Token(Token = "0x400014A")]
	private FontWeightPair[] m_FontWeightTable; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[FormerlySerializedAs("normalStyle")]
	[SerializeField]
	[Token(Token = "0x400014B")]
	internal float m_RegularStyleWeight; //Field offset: 0x190
	[FieldOffset(Offset = "0x194")]
	[FormerlySerializedAs("normalSpacingOffset")]
	[SerializeField]
	[Token(Token = "0x400014C")]
	internal float m_RegularStyleSpacing; //Field offset: 0x194
	[FieldOffset(Offset = "0x198")]
	[FormerlySerializedAs("boldStyle")]
	[SerializeField]
	[Token(Token = "0x400014D")]
	internal float m_BoldStyleWeight; //Field offset: 0x198
	[FieldOffset(Offset = "0x19C")]
	[FormerlySerializedAs("boldSpacing")]
	[SerializeField]
	[Token(Token = "0x400014E")]
	internal float m_BoldStyleSpacing; //Field offset: 0x19C
	[FieldOffset(Offset = "0x1A0")]
	[FormerlySerializedAs("italicStyle")]
	[SerializeField]
	[Token(Token = "0x400014F")]
	internal byte m_ItalicStyleSlant; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A1")]
	[FormerlySerializedAs("tabSize")]
	[SerializeField]
	[Token(Token = "0x4000150")]
	internal byte m_TabMultiple; //Field offset: 0x1A1
	[FieldOffset(Offset = "0x1A2")]
	[Token(Token = "0x4000151")]
	internal bool IsFontAssetLookupTablesDirty; //Field offset: 0x1A2
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000152")]
	private IntPtr m_NativeFontAsset; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000153")]
	private List<Glyph> m_GlyphsToRender; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000154")]
	private List<Glyph> m_GlyphsRendered; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000155")]
	private List<UInt32> m_GlyphIndexList; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000156")]
	private List<UInt32> m_GlyphIndexListNewlyAdded; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000157")]
	internal List<UInt32> m_GlyphsToAdd; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000158")]
	internal HashSet<UInt32> m_GlyphsToAddLookup; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000159")]
	internal List<Character> m_CharactersToAdd; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x400015A")]
	internal HashSet<UInt32> m_CharactersToAddLookup; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x400015B")]
	internal List<UInt32> s_MissingCharacterList; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x400015C")]
	internal HashSet<UInt32> m_MissingUnicodesFromFontFile; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400015D")]
	internal Dictionary<ValueTuple`2<UInt32, UInt32>, UInt32> m_VariantGlyphIndexes; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400015E")]
	internal bool m_IsClone; //Field offset: 0x208

	[Token(Token = "0x17000024")]
	public internal int atlasHeight
	{
		[Address(RVA = "0x31809A0", Offset = "0x317FDA0", Length = "0x9")]
		[Token(Token = "0x60000AB")]
		 get { } //Length: 9
		[Address(RVA = "0x3180D70", Offset = "0x3180170", Length = "0x7")]
		[Token(Token = "0x60000AC")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000025")]
	public internal int atlasPadding
	{
		[Address(RVA = "0x31809B0", Offset = "0x317FDB0", Length = "0x9")]
		[Token(Token = "0x60000AD")]
		 get { } //Length: 9
		[Address(RVA = "0x2EC3630", Offset = "0x2EC2A30", Length = "0x7")]
		[Token(Token = "0x60000AE")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000015")]
	public AtlasPopulationMode atlasPopulationMode
	{
		[Address(RVA = "0x31809C0", Offset = "0x317FDC0", Length = "0x9")]
		[Token(Token = "0x6000091")]
		 get { } //Length: 9
		[Address(RVA = "0x2C9FC60", Offset = "0x2C9F060", Length = "0x7")]
		[Token(Token = "0x6000092")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000026")]
	public internal GlyphRenderMode atlasRenderMode
	{
		[Address(RVA = "0x31809D0", Offset = "0x317FDD0", Length = "0x9")]
		[Token(Token = "0x60000AF")]
		 get { } //Length: 9
		[Address(RVA = "0x2EC3610", Offset = "0x2EC2A10", Length = "0x7")]
		[Token(Token = "0x60000B0")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700001D")]
	public Texture2D atlasTexture
	{
		[Address(RVA = "0x31809F0", Offset = "0x317FDF0", Length = "0x9C")]
		[Token(Token = "0x600009F")]
		 get { } //Length: 156
	}

	[Token(Token = "0x1700001F")]
	public int atlasTextureCount
	{
		[Address(RVA = "0x31809E0", Offset = "0x317FDE0", Length = "0xB")]
		[Token(Token = "0x60000A2")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700001E")]
	public Texture2D[] atlasTextures
	{
		[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 8
		[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
		[Token(Token = "0x60000A1")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000023")]
	public internal int atlasWidth
	{
		[Address(RVA = "0x3180A90", Offset = "0x317FE90", Length = "0x9")]
		[Token(Token = "0x60000A9")]
		 get { } //Length: 9
		[Address(RVA = "0x3180D80", Offset = "0x3180180", Length = "0x7")]
		[Token(Token = "0x60000AA")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700002F")]
	public float boldStyleSpacing
	{
		[Address(RVA = "0x3180AA0", Offset = "0x317FEA0", Length = "0xB")]
		[Token(Token = "0x60000C4")]
		 get { } //Length: 11
		[Address(RVA = "0x3180D90", Offset = "0x3180190", Length = "0x9")]
		[Token(Token = "0x60000C5")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700002E")]
	public float boldStyleWeight
	{
		[Address(RVA = "0x3180AB0", Offset = "0x317FEB0", Length = "0xB")]
		[Token(Token = "0x60000C2")]
		 get { } //Length: 11
		[Address(RVA = "0x3180DA0", Offset = "0x31801A0", Length = "0x9")]
		[Token(Token = "0x60000C3")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700001C")]
	public Dictionary<UInt32, Character> characterLookupTable
	{
		[Address(RVA = "0x3180AC0", Offset = "0x317FEC0", Length = "0x34")]
		[Token(Token = "0x600009E")]
		 get { } //Length: 52
	}

	[Token(Token = "0x1700001B")]
	public internal List<Character> characterTable
	{
		[Address(RVA = "0x3180B00", Offset = "0x317FF00", Length = "0xA")]
		[Token(Token = "0x600009C")]
		 get { } //Length: 10
		[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
		[Token(Token = "0x600009D")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000022")]
	internal bool clearDynamicDataOnBuild
	{
		[Address(RVA = "0x3180B10", Offset = "0x317FF10", Length = "0xA")]
		[Token(Token = "0x60000A7")]
		internal get { } //Length: 10
		[Address(RVA = "0x3180DB0", Offset = "0x31801B0", Length = "0x7")]
		[Token(Token = "0x60000A8")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000016")]
	public FaceInfo faceInfo
	{
		[Address(RVA = "0x3180B20", Offset = "0x317FF20", Length = "0x45")]
		[Token(Token = "0x6000093")]
		 get { } //Length: 69
		[Address(RVA = "0x3180DC0", Offset = "0x31801C0", Length = "0x1B7")]
		[Token(Token = "0x6000094")]
		 set { } //Length: 439
	}

	[Token(Token = "0x1700002A")]
	public List<FontAsset> fallbackFontAssetTable
	{
		[Address(RVA = "0x3180B70", Offset = "0x317FF70", Length = "0xA")]
		[Token(Token = "0x60000BA")]
		 get { } //Length: 10
		[Address(RVA = "0x291FE30", Offset = "0x291F230", Length = "0x13")]
		[Token(Token = "0x60000BB")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000017")]
	internal int familyNameHashCode
	{
		[Address(RVA = "0x3180B80", Offset = "0x317FF80", Length = "0x42")]
		[Token(Token = "0x6000095")]
		internal get { } //Length: 66
		[Address(RVA = "0x2D686B0", Offset = "0x2D67AB0", Length = "0x7")]
		[Token(Token = "0x6000096")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000013")]
	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings
	{
		[Address(RVA = "0x3180BD0", Offset = "0x317FFD0", Length = "0x3B")]
		[Token(Token = "0x600008D")]
		 get { } //Length: 59
		[Address(RVA = "0x3180F80", Offset = "0x3180380", Length = "0x42")]
		[Token(Token = "0x600008E")]
		 set { } //Length: 66
	}

	[Token(Token = "0x17000029")]
	public internal FontFeatureTable fontFeatureTable
	{
		[Address(RVA = "0x3180C10", Offset = "0x3180010", Length = "0xA")]
		[Token(Token = "0x60000B8")]
		 get { } //Length: 10
		[Address(RVA = "0x291FE10", Offset = "0x291F210", Length = "0x13")]
		[Token(Token = "0x60000B9")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700002B")]
	public internal FontWeightPair[] fontWeightTable
	{
		[Address(RVA = "0x3180C20", Offset = "0x3180020", Length = "0xA")]
		[Token(Token = "0x60000BC")]
		 get { } //Length: 10
		[Address(RVA = "0x291FDF0", Offset = "0x291F1F0", Length = "0x13")]
		[Token(Token = "0x60000BD")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000028")]
	internal List<GlyphRect> freeGlyphRects
	{
		[Address(RVA = "0x3180C30", Offset = "0x3180030", Length = "0xA")]
		[Token(Token = "0x60000B6")]
		internal get { } //Length: 10
		[Address(RVA = "0x2726E30", Offset = "0x2726230", Length = "0x13")]
		[Token(Token = "0x60000B7")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000021")]
	public bool getFontFeatures
	{
		[Address(RVA = "0x3180C40", Offset = "0x3180040", Length = "0xA")]
		[Token(Token = "0x60000A5")]
		 get { } //Length: 10
		[Address(RVA = "0x3180FD0", Offset = "0x31803D0", Length = "0x7")]
		[Token(Token = "0x60000A6")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700001A")]
	public Dictionary<UInt32, Glyph> glyphLookupTable
	{
		[Address(RVA = "0x3180C50", Offset = "0x3180050", Length = "0x34")]
		[Token(Token = "0x600009B")]
		 get { } //Length: 52
	}

	[Nullable(1)]
	[Token(Token = "0x17000019")]
	public internal List<Glyph> glyphTable
	{
		[Address(RVA = "0x3180C90", Offset = "0x3180090", Length = "0xA")]
		[NullableContext(1)]
		[Token(Token = "0x6000099")]
		 get { } //Length: 10
		[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
		[NullableContext(1)]
		[Token(Token = "0x600009A")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000020")]
	public bool isMultiAtlasTexturesEnabled
	{
		[Address(RVA = "0x3180CA0", Offset = "0x31800A0", Length = "0xA")]
		[Token(Token = "0x60000A3")]
		 get { } //Length: 10
		[Address(RVA = "0x3180FE0", Offset = "0x31803E0", Length = "0x7")]
		[Token(Token = "0x60000A4")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000030")]
	public byte italicStyleSlant
	{
		[Address(RVA = "0x3180CB0", Offset = "0x31800B0", Length = "0xA")]
		[Token(Token = "0x60000C6")]
		 get { } //Length: 10
		[Address(RVA = "0x3180FF0", Offset = "0x31803F0", Length = "0x7")]
		[Token(Token = "0x60000C7")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000032")]
	internal IntPtr nativeFontAsset
	{
		[Address(RVA = "0x3180CC0", Offset = "0x31800C0", Length = "0x1D")]
		[Token(Token = "0x6000126")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 29
	}

	[Token(Token = "0x1700002D")]
	public float regularStyleSpacing
	{
		[Address(RVA = "0x3180CE0", Offset = "0x31800E0", Length = "0xB")]
		[Token(Token = "0x60000C0")]
		 get { } //Length: 11
		[Address(RVA = "0x1D64B80", Offset = "0x1D63F80", Length = "0x9")]
		[Token(Token = "0x60000C1")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700002C")]
	public float regularStyleWeight
	{
		[Address(RVA = "0x3180CF0", Offset = "0x31800F0", Length = "0xB")]
		[Token(Token = "0x60000BE")]
		 get { } //Length: 11
		[Address(RVA = "0x3181000", Offset = "0x3180400", Length = "0x9")]
		[Token(Token = "0x60000BF")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000014")]
	public internal Font sourceFontFile
	{
		[Address(RVA = "0x2F92D00", Offset = "0x2F92100", Length = "0xA")]
		[Token(Token = "0x600008F")]
		 get { } //Length: 10
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[Token(Token = "0x6000090")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000018")]
	internal int styleNameHashCode
	{
		[Address(RVA = "0x3180D00", Offset = "0x3180100", Length = "0x42")]
		[Token(Token = "0x6000097")]
		internal get { } //Length: 66
		[Address(RVA = "0x3181010", Offset = "0x3180410", Length = "0x7")]
		[Token(Token = "0x6000098")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000031")]
	public byte tabMultiple
	{
		[Address(RVA = "0x3180D50", Offset = "0x3180150", Length = "0xA")]
		[Token(Token = "0x60000C8")]
		 get { } //Length: 10
		[Address(RVA = "0x3181020", Offset = "0x3180420", Length = "0x7")]
		[Token(Token = "0x60000C9")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000027")]
	internal List<GlyphRect> usedGlyphRects
	{
		[Address(RVA = "0x3180D60", Offset = "0x3180160", Length = "0xA")]
		[Token(Token = "0x60000B4")]
		internal get { } //Length: 10
		[Address(RVA = "0x3181030", Offset = "0x3180430", Length = "0x13")]
		[Token(Token = "0x60000B5")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x317FFF0", Offset = "0x317F3F0", Length = "0x574")]
	[Token(Token = "0x6000138")]
	private static FontAsset() { }

	[Address(RVA = "0x3180570", Offset = "0x317F970", Length = "0x424")]
	[Token(Token = "0x6000137")]
	public FontAsset() { }

	[Address(RVA = "0x317EAB0", Offset = "0x317DEB0", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x6000139")]
	private bool <TryAddGlyphs>b__231_0(uint glyphId) { }

	[Address(RVA = "0x3172180", Offset = "0x3171580", Length = "0xD7")]
	[Token(Token = "0x60000E6")]
	internal void AddCharacterToLookupCache(uint unicode, Character character, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[Address(RVA = "0x3172260", Offset = "0x3171660", Length = "0x78")]
	[Token(Token = "0x60000E5")]
	internal void AddCharacterToLookupCache(uint unicode, Character character) { }

	[Address(RVA = "0x31722E0", Offset = "0x31716E0", Length = "0x464")]
	[Token(Token = "0x6000120")]
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	[Address(RVA = "0x3172750", Offset = "0x3171B50", Length = "0x36E")]
	[Token(Token = "0x6000124")]
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	[Address(RVA = "0x3172AC0", Offset = "0x3171EC0", Length = "0x38D")]
	[Token(Token = "0x6000125")]
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	[Address(RVA = "0x3172E50", Offset = "0x3172250", Length = "0x37F")]
	[Token(Token = "0x6000122")]
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	[Address(RVA = "0x31731D0", Offset = "0x31725D0", Length = "0x7BE")]
	[Token(Token = "0x60000E4")]
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false) { }

	[Address(RVA = "0x3173990", Offset = "0x3172D90", Length = "0x1FF")]
	[Token(Token = "0x60000E3")]
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	[Address(RVA = "0x3173B90", Offset = "0x3172F90", Length = "0x24D")]
	[Token(Token = "0x6000103")]
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false) { }

	[Address(RVA = "0x3173E10", Offset = "0x3173210", Length = "0x209")]
	[Token(Token = "0x6000101")]
	private void ClearCharacterAndGlyphTables() { }

	[Address(RVA = "0x3173DE0", Offset = "0x31731E0", Length = "0x2C")]
	[Token(Token = "0x6000100")]
	internal void ClearCharacterAndGlyphTablesInternal() { }

	[Address(RVA = "0x3174020", Offset = "0x3173420", Length = "0x327")]
	[Token(Token = "0x60000DE")]
	internal void ClearFallbackCharacterTable() { }

	[Address(RVA = "0x3174350", Offset = "0x3173750", Length = "0x258")]
	[Token(Token = "0x60000FF")]
	public void ClearFontAssetData(bool setAtlasSizeToZero = false) { }

	[Address(RVA = "0x31745B0", Offset = "0x31739B0", Length = "0xF5")]
	[Token(Token = "0x6000102")]
	private void ClearFontFeaturesTables() { }

	[Address(RVA = "0x31746B0", Offset = "0x3173AB0", Length = "0xC4")]
	[Token(Token = "0x60000E9")]
	internal bool ContainsCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[Address(RVA = "0x3176500", Offset = "0x3175900", Length = "0x479")]
	[Token(Token = "0x6000133")]
	private static IntPtr Create(FaceInfo faceInfo, Font sourceFontFile, Font sourceFont_EditorRef, string sourceFontFilePath, EntityId fontEntityId, IntPtr[] fallbacks, IntPtr[] weightFallbacks, IntPtr[] italicFallbacks, GlyphRenderMode renderMode, IntPtr managedObject) { }

	[Address(RVA = "0x3176490", Offset = "0x3175890", Length = "0x65")]
	[Token(Token = "0x600013C")]
	private static IntPtr Create_Injected(in FaceInfo faceInfo, IntPtr sourceFontFile, IntPtr sourceFont_EditorRef, ref ManagedSpanWrapper sourceFontFilePath, in EntityId fontEntityId, ref ManagedSpanWrapper fallbacks, ref ManagedSpanWrapper weightFallbacks, ref ManagedSpanWrapper italicFallbacks, GlyphRenderMode renderMode, IntPtr managedObject) { }

	[Address(RVA = "0x3174780", Offset = "0x3173B80", Length = "0x1CF")]
	[Token(Token = "0x6000119")]
	private Character CreateCharacterAndAddToCache(uint unicode, Glyph glyph, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[Address(RVA = "0x3174950", Offset = "0x3173D50", Length = "0x67")]
	[Token(Token = "0x60000EA")]
	private uint CreateCompositeKey(uint unicode, FontStyles fontStyle = 0, TextFontWeight fontWeight = 400) { }

	[Address(RVA = "0x3175EA0", Offset = "0x31752A0", Length = "0x5B9")]
	[Token(Token = "0x60000D4")]
	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x3175DF0", Offset = "0x31751F0", Length = "0xAF")]
	[Token(Token = "0x60000D3")]
	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x31758E0", Offset = "0x3174CE0", Length = "0xB5")]
	[Token(Token = "0x60000D2")]
	public static FontAsset CreateFontAsset(Font font) { }

	[Address(RVA = "0x3175740", Offset = "0x3174B40", Length = "0x196")]
	[Token(Token = "0x60000D1")]
	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x3175AA0", Offset = "0x3174EA0", Length = "0xAC")]
	[Token(Token = "0x60000D0")]
	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	[Address(RVA = "0x31759A0", Offset = "0x3174DA0", Length = "0xFA")]
	[NullableContext(1)]
	[Token(Token = "0x60000CC")]
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize, int padding, GlyphRenderMode renderMode) { }

	[Address(RVA = "0x3175B50", Offset = "0x3174F50", Length = "0x293")]
	[Token(Token = "0x60000CA")]
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	[Address(RVA = "0x31749C0", Offset = "0x3173DC0", Length = "0x165")]
	[Token(Token = "0x60000CF")]
	private static FontAsset CreateFontAssetFromFamilyName(string familyName, int pointSize = 90) { }

	[Address(RVA = "0x3174B30", Offset = "0x3173F30", Length = "0x811")]
	[Token(Token = "0x60000D5")]
	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	[Address(RVA = "0x3175350", Offset = "0x3174750", Length = "0xFE")]
	[NullableContext(1)]
	[Token(Token = "0x60000CB")]
	internal static FontAsset CreateFontAssetInternal(string familyName, string styleName, int pointSize = 90) { }

	[Address(RVA = "0x3175450", Offset = "0x3174850", Length = "0x13C")]
	[Token(Token = "0x60000CD")]
	internal static List<FontAsset> CreateFontAssetOSFallbackList(String[] fallbacksFamilyNames, int pointSize = 90) { }

	[Address(RVA = "0x3175590", Offset = "0x3174990", Length = "0x1A8")]
	[Token(Token = "0x60000CE")]
	internal static FontAsset CreateFontAssetWithOSFallbackList(String[] fallbacksFamilyNames, int pointSize = 90) { }

	[Address(RVA = "0x3176460", Offset = "0x3175860", Length = "0x2A")]
	[Token(Token = "0x6000130")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void CreateHbFaceIfNeeded() { }

	[Address(RVA = "0x3176AA0", Offset = "0x3175EA0", Length = "0x42")]
	[FreeFunction("FontAsset::Destroy")]
	[Token(Token = "0x6000136")]
	private static void Destroy(IntPtr ptr, IntPtr managedObject) { }

	[Address(RVA = "0x3176980", Offset = "0x3175D80", Length = "0x119")]
	[Token(Token = "0x6000104")]
	private void DestroyAtlasTextures() { }

	[Address(RVA = "0x810E70", Offset = "0x810270", Length = "0x69")]
	[Token(Token = "0x600008B")]
	private static void EnsureAdditionalCapacity(List<T> container, int additionalCapacity) { }

	[Address(RVA = "0x810FD0", Offset = "0x8103D0", Length = "0x62")]
	[Token(Token = "0x600008C")]
	private static void EnsureAdditionalCapacity(Dictionary<TKey, TValue> container, int additionalCapacity) { }

	[Address(RVA = "0x3176AF0", Offset = "0x3175EF0", Length = "0x340")]
	[Token(Token = "0x6000127")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void EnsureNativeFontAssetIsCreated() { }

	[Address(RVA = "0x31809A0", Offset = "0x317FDA0", Length = "0x9")]
	[Token(Token = "0x60000AB")]
	public int get_atlasHeight() { }

	[Address(RVA = "0x31809B0", Offset = "0x317FDB0", Length = "0x9")]
	[Token(Token = "0x60000AD")]
	public int get_atlasPadding() { }

	[Address(RVA = "0x31809C0", Offset = "0x317FDC0", Length = "0x9")]
	[Token(Token = "0x6000091")]
	public AtlasPopulationMode get_atlasPopulationMode() { }

	[Address(RVA = "0x31809D0", Offset = "0x317FDD0", Length = "0x9")]
	[Token(Token = "0x60000AF")]
	public GlyphRenderMode get_atlasRenderMode() { }

	[Address(RVA = "0x31809F0", Offset = "0x317FDF0", Length = "0x9C")]
	[Token(Token = "0x600009F")]
	public Texture2D get_atlasTexture() { }

	[Address(RVA = "0x31809E0", Offset = "0x317FDE0", Length = "0xB")]
	[Token(Token = "0x60000A2")]
	public int get_atlasTextureCount() { }

	[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
	[Token(Token = "0x60000A0")]
	public Texture2D[] get_atlasTextures() { }

	[Address(RVA = "0x3180A90", Offset = "0x317FE90", Length = "0x9")]
	[Token(Token = "0x60000A9")]
	public int get_atlasWidth() { }

	[Address(RVA = "0x3180AA0", Offset = "0x317FEA0", Length = "0xB")]
	[Token(Token = "0x60000C4")]
	public float get_boldStyleSpacing() { }

	[Address(RVA = "0x3180AB0", Offset = "0x317FEB0", Length = "0xB")]
	[Token(Token = "0x60000C2")]
	public float get_boldStyleWeight() { }

	[Address(RVA = "0x3180AC0", Offset = "0x317FEC0", Length = "0x34")]
	[Token(Token = "0x600009E")]
	public Dictionary<UInt32, Character> get_characterLookupTable() { }

	[Address(RVA = "0x3180B00", Offset = "0x317FF00", Length = "0xA")]
	[Token(Token = "0x600009C")]
	public List<Character> get_characterTable() { }

	[Address(RVA = "0x3180B10", Offset = "0x317FF10", Length = "0xA")]
	[Token(Token = "0x60000A7")]
	internal bool get_clearDynamicDataOnBuild() { }

	[Address(RVA = "0x3180B20", Offset = "0x317FF20", Length = "0x45")]
	[Token(Token = "0x6000093")]
	public FaceInfo get_faceInfo() { }

	[Address(RVA = "0x3180B70", Offset = "0x317FF70", Length = "0xA")]
	[Token(Token = "0x60000BA")]
	public List<FontAsset> get_fallbackFontAssetTable() { }

	[Address(RVA = "0x3180B80", Offset = "0x317FF80", Length = "0x42")]
	[Token(Token = "0x6000095")]
	internal int get_familyNameHashCode() { }

	[Address(RVA = "0x3180BD0", Offset = "0x317FFD0", Length = "0x3B")]
	[Token(Token = "0x600008D")]
	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	[Address(RVA = "0x3180C10", Offset = "0x3180010", Length = "0xA")]
	[Token(Token = "0x60000B8")]
	public FontFeatureTable get_fontFeatureTable() { }

	[Address(RVA = "0x3180C20", Offset = "0x3180020", Length = "0xA")]
	[Token(Token = "0x60000BC")]
	public FontWeightPair[] get_fontWeightTable() { }

	[Address(RVA = "0x3180C30", Offset = "0x3180030", Length = "0xA")]
	[Token(Token = "0x60000B6")]
	internal List<GlyphRect> get_freeGlyphRects() { }

	[Address(RVA = "0x3180C40", Offset = "0x3180040", Length = "0xA")]
	[Token(Token = "0x60000A5")]
	public bool get_getFontFeatures() { }

	[Address(RVA = "0x3180C50", Offset = "0x3180050", Length = "0x34")]
	[Token(Token = "0x600009B")]
	public Dictionary<UInt32, Glyph> get_glyphLookupTable() { }

	[Address(RVA = "0x3180C90", Offset = "0x3180090", Length = "0xA")]
	[NullableContext(1)]
	[Token(Token = "0x6000099")]
	public List<Glyph> get_glyphTable() { }

	[Address(RVA = "0x3180CA0", Offset = "0x31800A0", Length = "0xA")]
	[Token(Token = "0x60000A3")]
	public bool get_isMultiAtlasTexturesEnabled() { }

	[Address(RVA = "0x3180CB0", Offset = "0x31800B0", Length = "0xA")]
	[Token(Token = "0x60000C6")]
	public byte get_italicStyleSlant() { }

	[Address(RVA = "0x3180CC0", Offset = "0x31800C0", Length = "0x1D")]
	[Token(Token = "0x6000126")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal IntPtr get_nativeFontAsset() { }

	[Address(RVA = "0x3180CE0", Offset = "0x31800E0", Length = "0xB")]
	[Token(Token = "0x60000C0")]
	public float get_regularStyleSpacing() { }

	[Address(RVA = "0x3180CF0", Offset = "0x31800F0", Length = "0xB")]
	[Token(Token = "0x60000BE")]
	public float get_regularStyleWeight() { }

	[Address(RVA = "0x2F92D00", Offset = "0x2F92100", Length = "0xA")]
	[Token(Token = "0x600008F")]
	public Font get_sourceFontFile() { }

	[Address(RVA = "0x3180D00", Offset = "0x3180100", Length = "0x42")]
	[Token(Token = "0x6000097")]
	internal int get_styleNameHashCode() { }

	[Address(RVA = "0x3180D50", Offset = "0x3180150", Length = "0xA")]
	[Token(Token = "0x60000C8")]
	public byte get_tabMultiple() { }

	[Address(RVA = "0x3180D60", Offset = "0x3180160", Length = "0xA")]
	[Token(Token = "0x60000B4")]
	internal List<GlyphRect> get_usedGlyphRects() { }

	[Address(RVA = "0x3176E40", Offset = "0x3176240", Length = "0xC9")]
	[Token(Token = "0x60000E7")]
	internal bool GetCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character) { }

	[Address(RVA = "0x3177000", Offset = "0x3176400", Length = "0xE6")]
	[Token(Token = "0x60000F8")]
	public static string GetCharacters(FontAsset fontAsset) { }

	[Address(RVA = "0x3176F10", Offset = "0x3176310", Length = "0xE3")]
	[Token(Token = "0x60000F9")]
	public static Int32[] GetCharactersArray(FontAsset fontAsset) { }

	[Address(RVA = "0x31770F0", Offset = "0x31764F0", Length = "0x2CC")]
	[Token(Token = "0x600012C")]
	internal IntPtr[] GetFallbacks() { }

	[Address(RVA = "0x31773C0", Offset = "0x31767C0", Length = "0x75")]
	[Token(Token = "0x60000FB")]
	internal Glyph GetGlyphInCache(uint glyphID) { }

	[Address(RVA = "0x3177440", Offset = "0x3176840", Length = "0x116")]
	[Token(Token = "0x60000FC")]
	internal uint GetGlyphIndex(uint unicode, out bool success) { }

	[Address(RVA = "0x3177560", Offset = "0x3176960", Length = "0x102")]
	[Token(Token = "0x60000FA")]
	internal uint GetGlyphIndex(uint unicode) { }

	[Address(RVA = "0x3177670", Offset = "0x3176A70", Length = "0x83")]
	[Token(Token = "0x60000FD")]
	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	[Address(RVA = "0x3177700", Offset = "0x3176B00", Length = "0x325")]
	[Token(Token = "0x600012F")]
	private ValueTuple<IntPtr[], IntPtr[]> GetWeightFallbacks() { }

	[Address(RVA = "0x3177D60", Offset = "0x3177160", Length = "0x397")]
	[Token(Token = "0x60000F2")]
	public bool HasCharacter(uint character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x3178100", Offset = "0x3177500", Length = "0x75")]
	[Token(Token = "0x60000F0")]
	public bool HasCharacter(int character) { }

	[Address(RVA = "0x3178180", Offset = "0x3177580", Length = "0x13")]
	[Token(Token = "0x60000F1")]
	public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x3177A60", Offset = "0x3176E60", Length = "0x2F0")]
	[Token(Token = "0x60000F4")]
	private bool HasCharacter_Internal(uint character, FontStyles fontStyle = 0, TextFontWeight fontWeight = 400, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x3178730", Offset = "0x3177B30", Length = "0x158")]
	[Token(Token = "0x60000F5")]
	public bool HasCharacters(string text, out List<Char>& missingCharacters) { }

	[Address(RVA = "0x3178270", Offset = "0x3177670", Length = "0x4B8")]
	[Token(Token = "0x60000F6")]
	public bool HasCharacters(string text, out UInt32[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x31781A0", Offset = "0x31775A0", Length = "0xC8")]
	[Token(Token = "0x60000F7")]
	public bool HasCharacters(string text) { }

	[Address(RVA = "0x3177A30", Offset = "0x3176E30", Length = "0x22")]
	[Token(Token = "0x60000F3")]
	private bool HasCharacterWithStyle_Internal(uint character, FontStyles fontStyle, TextFontWeight fontWeight, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x3178C40", Offset = "0x3178040", Length = "0x93")]
	[Token(Token = "0x600012D")]
	private bool HasRecursion(FontAsset fontAsset) { }

	[Address(RVA = "0x3178890", Offset = "0x3177C90", Length = "0x3AB")]
	[Token(Token = "0x600012E")]
	private bool HasRecursionInternal(FontAsset fontAsset) { }

	[Address(RVA = "0x3178CE0", Offset = "0x31780E0", Length = "0xFF")]
	[Token(Token = "0x600011D")]
	internal void ImportFontFeatures() { }

	[Address(RVA = "0x3178DE0", Offset = "0x31781E0", Length = "0x255")]
	[Token(Token = "0x60000DD")]
	internal void InitializeCharacterLookupDictionary() { }

	[Address(RVA = "0x3179040", Offset = "0x3178440", Length = "0x15A")]
	[Token(Token = "0x60000D9")]
	internal void InitializeDictionaryLookupTables() { }

	[Address(RVA = "0x31791A0", Offset = "0x31785A0", Length = "0x22F")]
	[Token(Token = "0x60000DC")]
	internal void InitializeGlyphLookupDictionary() { }

	[Address(RVA = "0x31793D0", Offset = "0x31787D0", Length = "0x2FA")]
	[Token(Token = "0x60000E0")]
	internal void InitializeGlyphPairAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x31796D0", Offset = "0x3178AD0", Length = "0x34D")]
	[Token(Token = "0x60000DF")]
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	[Address(RVA = "0x8111A0", Offset = "0x8105A0", Length = "0xE7")]
	[Token(Token = "0x60000DB")]
	private static void InitializeList(ICollection source, ref List<T>& list, int defaultCapacity = 16) { }

	[Address(RVA = "0x811290", Offset = "0x810690", Length = "0xEA")]
	[Token(Token = "0x60000DA")]
	private static void InitializeLookup(ICollection source, ref Dictionary<UInt32, T>& lookup, int defaultCapacity = 16) { }

	[Address(RVA = "0x3179A20", Offset = "0x3178E20", Length = "0x22C")]
	[Token(Token = "0x60000E1")]
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x3179C50", Offset = "0x3179050", Length = "0x22C")]
	[Token(Token = "0x60000E2")]
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x3179E80", Offset = "0x3179280", Length = "0x19")]
	[Token(Token = "0x60000B1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool IsBitmap() { }

	[Address(RVA = "0x3179EA0", Offset = "0x31792A0", Length = "0xA")]
	[Token(Token = "0x60000B3")]
	internal bool IsColor() { }

	[Address(RVA = "0x3179EB0", Offset = "0x31792B0", Length = "0xE")]
	[Token(Token = "0x60000B2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool IsRaster() { }

	[Address(RVA = "0x3179EC0", Offset = "0x31792C0", Length = "0x163")]
	[Token(Token = "0x60000EB")]
	internal FontEngineError LoadFontFace() { }

	[Address(RVA = "0x317A030", Offset = "0x3179430", Length = "0x20E")]
	[Token(Token = "0x60000D7")]
	internal virtual void OnDestroy() { }

	[Address(RVA = "0x317A240", Offset = "0x3179640", Length = "0x879")]
	[Token(Token = "0x60000D8")]
	public void ReadFontAssetDefinition() { }

	[Address(RVA = "0x317AAC0", Offset = "0x3179EC0", Length = "0x143")]
	[Token(Token = "0x6000108")]
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	[Address(RVA = "0x317AC10", Offset = "0x317A010", Length = "0x342")]
	[Token(Token = "0x60000D6")]
	private void RegisterCallbackInstance(FontAsset instance) { }

	[Address(RVA = "0x317AF60", Offset = "0x317A360", Length = "0xE3")]
	[Token(Token = "0x6000105")]
	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	[Address(RVA = "0x317B050", Offset = "0x317A450", Length = "0xE6")]
	[Token(Token = "0x6000106")]
	internal static void RegisterFontAssetForKerningUpdate(FontAsset fontAsset) { }

	[Address(RVA = "0x317B140", Offset = "0x317A540", Length = "0xC6")]
	[Token(Token = "0x60000E8")]
	internal void RemoveCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[Address(RVA = "0x3180D70", Offset = "0x3180170", Length = "0x7")]
	[Token(Token = "0x60000AC")]
	internal void set_atlasHeight(int value) { }

	[Address(RVA = "0x2EC3630", Offset = "0x2EC2A30", Length = "0x7")]
	[Token(Token = "0x60000AE")]
	internal void set_atlasPadding(int value) { }

	[Address(RVA = "0x2C9FC60", Offset = "0x2C9F060", Length = "0x7")]
	[Token(Token = "0x6000092")]
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	[Address(RVA = "0x2EC3610", Offset = "0x2EC2A10", Length = "0x7")]
	[Token(Token = "0x60000B0")]
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
	[Token(Token = "0x60000A1")]
	public void set_atlasTextures(Texture2D[] value) { }

	[Address(RVA = "0x3180D80", Offset = "0x3180180", Length = "0x7")]
	[Token(Token = "0x60000AA")]
	internal void set_atlasWidth(int value) { }

	[Address(RVA = "0x3180D90", Offset = "0x3180190", Length = "0x9")]
	[Token(Token = "0x60000C5")]
	public void set_boldStyleSpacing(float value) { }

	[Address(RVA = "0x3180DA0", Offset = "0x31801A0", Length = "0x9")]
	[Token(Token = "0x60000C3")]
	public void set_boldStyleWeight(float value) { }

	[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
	[Token(Token = "0x600009D")]
	internal void set_characterTable(List<Character> value) { }

	[Address(RVA = "0x3180DB0", Offset = "0x31801B0", Length = "0x7")]
	[Token(Token = "0x60000A8")]
	internal void set_clearDynamicDataOnBuild(bool value) { }

	[Address(RVA = "0x3180DC0", Offset = "0x31801C0", Length = "0x1B7")]
	[Token(Token = "0x6000094")]
	public void set_faceInfo(FaceInfo value) { }

	[Address(RVA = "0x291FE30", Offset = "0x291F230", Length = "0x13")]
	[Token(Token = "0x60000BB")]
	public void set_fallbackFontAssetTable(List<FontAsset> value) { }

	[Address(RVA = "0x2D686B0", Offset = "0x2D67AB0", Length = "0x7")]
	[Token(Token = "0x6000096")]
	internal void set_familyNameHashCode(int value) { }

	[Address(RVA = "0x3180F80", Offset = "0x3180380", Length = "0x42")]
	[Token(Token = "0x600008E")]
	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	[Address(RVA = "0x291FE10", Offset = "0x291F210", Length = "0x13")]
	[Token(Token = "0x60000B9")]
	internal void set_fontFeatureTable(FontFeatureTable value) { }

	[Address(RVA = "0x291FDF0", Offset = "0x291F1F0", Length = "0x13")]
	[Token(Token = "0x60000BD")]
	internal void set_fontWeightTable(FontWeightPair[] value) { }

	[Address(RVA = "0x2726E30", Offset = "0x2726230", Length = "0x13")]
	[Token(Token = "0x60000B7")]
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	[Address(RVA = "0x3180FD0", Offset = "0x31803D0", Length = "0x7")]
	[Token(Token = "0x60000A6")]
	public void set_getFontFeatures(bool value) { }

	[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
	[NullableContext(1)]
	[Token(Token = "0x600009A")]
	internal void set_glyphTable(List<Glyph> value) { }

	[Address(RVA = "0x3180FE0", Offset = "0x31803E0", Length = "0x7")]
	[Token(Token = "0x60000A4")]
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	[Address(RVA = "0x3180FF0", Offset = "0x31803F0", Length = "0x7")]
	[Token(Token = "0x60000C7")]
	public void set_italicStyleSlant(byte value) { }

	[Address(RVA = "0x1D64B80", Offset = "0x1D63F80", Length = "0x9")]
	[Token(Token = "0x60000C1")]
	public void set_regularStyleSpacing(float value) { }

	[Address(RVA = "0x3181000", Offset = "0x3180400", Length = "0x9")]
	[Token(Token = "0x60000BF")]
	public void set_regularStyleWeight(float value) { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[Token(Token = "0x6000090")]
	internal void set_sourceFontFile(Font value) { }

	[Address(RVA = "0x3181010", Offset = "0x3180410", Length = "0x7")]
	[Token(Token = "0x6000098")]
	internal void set_styleNameHashCode(int value) { }

	[Address(RVA = "0x3181020", Offset = "0x3180420", Length = "0x7")]
	[Token(Token = "0x60000C9")]
	public void set_tabMultiple(byte value) { }

	[Address(RVA = "0x3181030", Offset = "0x3180430", Length = "0x13")]
	[Token(Token = "0x60000B5")]
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	[Address(RVA = "0x317B210", Offset = "0x317A610", Length = "0x300")]
	[Token(Token = "0x6000118")]
	private void SetupNewAtlasTexture() { }

	[Address(RVA = "0x317B520", Offset = "0x317A920", Length = "0x300")]
	[Token(Token = "0x60000EF")]
	internal void SortAllTables() { }

	[Address(RVA = "0x317B830", Offset = "0x317AC30", Length = "0x178")]
	[Token(Token = "0x60000EC")]
	internal void SortCharacterTable() { }

	[Address(RVA = "0x317B9B0", Offset = "0x317ADB0", Length = "0x4C")]
	[Token(Token = "0x60000EE")]
	internal void SortFontFeatureTable() { }

	[Address(RVA = "0x317BA00", Offset = "0x317AE00", Length = "0x178")]
	[Token(Token = "0x60000ED")]
	internal void SortGlyphTable() { }

	[Address(RVA = "0x317BB80", Offset = "0x317AF80", Length = "0x3AA")]
	[Token(Token = "0x6000114")]
	internal bool TryAddCharacterInternal(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character, bool populateLigatures = true) { }

	[Address(RVA = "0x317BF30", Offset = "0x317B330", Length = "0x2A")]
	[Token(Token = "0x6000113")]
	internal bool TryAddCharacterInternal(uint unicode, out Character character) { }

	[Address(RVA = "0x317BF90", Offset = "0x317B390", Length = "0x23")]
	[Token(Token = "0x600010B")]
	public bool TryAddCharacters(UInt32[] unicodes, bool includeFontFeatures = false) { }

	[Address(RVA = "0x317BFC0", Offset = "0x317B3C0", Length = "0x120D")]
	[Token(Token = "0x600010C")]
	public bool TryAddCharacters(UInt32[] unicodes, out UInt32[] missingUnicodes, bool includeFontFeatures = false) { }

	[Address(RVA = "0x317D1D0", Offset = "0x317C5D0", Length = "0x195")]
	[Token(Token = "0x600010F")]
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false) { }

	[Address(RVA = "0x317BF60", Offset = "0x317B360", Length = "0x23")]
	[Token(Token = "0x600010E")]
	public bool TryAddCharacters(string characters, bool includeFontFeatures = false) { }

	[Address(RVA = "0x317D370", Offset = "0x317C770", Length = "0x1BA")]
	[Token(Token = "0x6000112")]
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph, bool populateLigatures = true) { }

	[Address(RVA = "0x317E320", Offset = "0x317D720", Length = "0x6D3")]
	[Token(Token = "0x600010D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool TryAddGlyphs(List<UInt32> glyphsToAdd) { }

	[Address(RVA = "0x317DE60", Offset = "0x317D260", Length = "0x4B0")]
	[Token(Token = "0x6000117")]
	private bool TryAddGlyphsToNewAtlasTexture() { }

	[Address(RVA = "0x317D530", Offset = "0x317C930", Length = "0x46C")]
	[Token(Token = "0x6000115")]
	private bool TryAddGlyphToAtlas(uint glyphIndex, out Glyph glyph, bool populateLigatures = true) { }

	[Address(RVA = "0x317D9A0", Offset = "0x317CDA0", Length = "0x400")]
	[Token(Token = "0x6000116")]
	private bool TryAddGlyphToTexture(uint glyphIndex, out Glyph glyph, bool populateLigatures = true) { }

	[Address(RVA = "0x317DDB0", Offset = "0x317D1B0", Length = "0xA3")]
	[Token(Token = "0x6000110")]
	internal bool TryAddGlyphVariantIndexInternal(uint unicode, uint nextCharacter, uint variantGlyphIndex) { }

	[Address(RVA = "0x317EA00", Offset = "0x317DE00", Length = "0xA3")]
	[Token(Token = "0x6000111")]
	internal bool TryGetGlyphVariantIndexInternal(uint unicode, uint nextCharacter, out uint variantGlyphIndex) { }

	[Address(RVA = "0x317EB10", Offset = "0x317DF10", Length = "0x18F")]
	[Token(Token = "0x6000109")]
	internal static void UpdateAtlasTexturesInQueue() { }

	[Address(RVA = "0x317ECA0", Offset = "0x317E0A0", Length = "0x140")]
	[Token(Token = "0x6000123")]
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	[Address(RVA = "0x317EE40", Offset = "0x317E240", Length = "0x73")]
	[Token(Token = "0x6000134")]
	private static void UpdateFaceInfo(IntPtr ptr, FaceInfo faceInfo) { }

	[Address(RVA = "0x317EEC0", Offset = "0x317E2C0", Length = "0x156")]
	[Token(Token = "0x600012A")]
	internal void UpdateFaceInfo() { }

	[Address(RVA = "0x317EDF0", Offset = "0x317E1F0", Length = "0x42")]
	[Token(Token = "0x600013D")]
	private static void UpdateFaceInfo_Injected(IntPtr ptr, in FaceInfo faceInfo) { }

	[Address(RVA = "0x317F070", Offset = "0x317E470", Length = "0x138")]
	[Token(Token = "0x6000128")]
	internal void UpdateFallbacks() { }

	[Address(RVA = "0x317F1B0", Offset = "0x317E5B0", Length = "0xEC")]
	[Token(Token = "0x6000131")]
	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	[Address(RVA = "0x317F020", Offset = "0x317E420", Length = "0x42")]
	[Token(Token = "0x600013A")]
	private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks) { }

	[Address(RVA = "0x317F2A0", Offset = "0x317E6A0", Length = "0x167")]
	[Token(Token = "0x60000FE")]
	internal void UpdateFontAssetData() { }

	[Address(RVA = "0x317F410", Offset = "0x317E810", Length = "0x1BF")]
	[Token(Token = "0x600010A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static void UpdateFontAssetsInUpdateQueue() { }

	[Address(RVA = "0x317F5D0", Offset = "0x317E9D0", Length = "0x30F")]
	[Token(Token = "0x6000107")]
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	[Address(RVA = "0x317F8E0", Offset = "0x317ECE0", Length = "0xB8")]
	[Token(Token = "0x600011A")]
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	[Address(RVA = "0x317FAD0", Offset = "0x317EED0", Length = "0x77")]
	[Token(Token = "0x6000121")]
	internal void UpdateGlyphAdjustmentRecords() { }

	[Address(RVA = "0x317FA70", Offset = "0x317EE70", Length = "0x50")]
	[Token(Token = "0x600011B")]
	private void UpdateGlyphAdjustmentRecordsForNewGlyphs() { }

	[Address(RVA = "0x317F9A0", Offset = "0x317EDA0", Length = "0x5A")]
	[Token(Token = "0x600011C")]
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	[Address(RVA = "0x317FA00", Offset = "0x317EE00", Length = "0x67")]
	[Token(Token = "0x600011E")]
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	[Address(RVA = "0x317FB50", Offset = "0x317EF50", Length = "0x6D")]
	[Token(Token = "0x600011F")]
	internal void UpdateLigatureSubstitutionRecords() { }

	[Address(RVA = "0x317FC00", Offset = "0x317F000", Length = "0x86")]
	[Token(Token = "0x600012B")]
	internal void UpdateRenderMode() { }

	[Address(RVA = "0x317FBC0", Offset = "0x317EFC0", Length = "0x40")]
	[Token(Token = "0x6000135")]
	private static void UpdateRenderMode(IntPtr ptr, GlyphRenderMode renderMode) { }

	[Address(RVA = "0x317FEA0", Offset = "0x317F2A0", Length = "0x150")]
	[Token(Token = "0x6000132")]
	private static void UpdateWeightFallbacks(IntPtr ptr, IntPtr[] regularFallbacks, IntPtr[] italicFallbacks) { }

	[Address(RVA = "0x317FCF0", Offset = "0x317F0F0", Length = "0x1A5")]
	[Token(Token = "0x6000129")]
	internal void UpdateWeightFallbacks() { }

	[Address(RVA = "0x317FC90", Offset = "0x317F090", Length = "0x52")]
	[Token(Token = "0x600013B")]
	private static void UpdateWeightFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper regularFallbacks, ref ManagedSpanWrapper italicFallbacks) { }

}

