namespace TMPro;

[ExcludeFromPreset]
[Token(Token = "0x200004A")]
public class TMP_FontAsset : TMP_Asset
{
	[CompilerGenerated]
	[Token(Token = "0x200004B")]
	private sealed class <>c
	{
		[Token(Token = "0x400021F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000220")]
		public static Func<TMP_Character, UInt32> <>9__145_0; //Field offset: 0x8
		[Token(Token = "0x4000221")]
		public static Func<Glyph, UInt32> <>9__146_0; //Field offset: 0x10

		[Address(RVA = "0x2ED98F0", Offset = "0x2ED8CF0", Length = "0x67")]
		[Token(Token = "0x6000294")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000295")]
		public <>c() { }

		[Address(RVA = "0x2ED9790", Offset = "0x2ED8B90", Length = "0x16")]
		[Token(Token = "0x6000296")]
		internal uint <SortCharacterTable>b__145_0(TMP_Character c) { }

		[Address(RVA = "0x2ED9830", Offset = "0x2ED8C30", Length = "0x1F")]
		[Token(Token = "0x6000297")]
		internal uint <SortGlyphTable>b__146_0(Glyph c) { }

	}

	[Token(Token = "0x4000203")]
	private static readonly List<WeakReference`1<TMP_FontAsset>> s_CallbackInstances; //Field offset: 0x0
	[Token(Token = "0x4000204")]
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; //Field offset: 0x8
	[Token(Token = "0x4000205")]
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; //Field offset: 0x10
	[Token(Token = "0x4000206")]
	private static ProfilerMarker k_TryAddGlyphMarker; //Field offset: 0x18
	[Token(Token = "0x4000207")]
	private static ProfilerMarker k_TryAddCharacterMarker; //Field offset: 0x20
	[Token(Token = "0x4000208")]
	private static ProfilerMarker k_TryAddCharactersMarker; //Field offset: 0x28
	[Token(Token = "0x4000209")]
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; //Field offset: 0x30
	[Token(Token = "0x400020A")]
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; //Field offset: 0x38
	[Token(Token = "0x400020B")]
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; //Field offset: 0x40
	[Token(Token = "0x400020C")]
	private static ProfilerMarker k_ClearFontAssetDataMarker; //Field offset: 0x48
	[Token(Token = "0x400020D")]
	private static ProfilerMarker k_UpdateFontAssetDataMarker; //Field offset: 0x50
	[Token(Token = "0x400020E")]
	private static string s_DefaultMaterialSuffix; //Field offset: 0x58
	[Token(Token = "0x400020F")]
	private static HashSet<Int32> k_SearchedFontAssetLookup; //Field offset: 0x60
	[Token(Token = "0x4000210")]
	private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; //Field offset: 0x68
	[Token(Token = "0x4000211")]
	private static HashSet<Int32> k_FontAssets_FontFeaturesUpdateQueueLookup; //Field offset: 0x70
	[Token(Token = "0x4000212")]
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; //Field offset: 0x78
	[Token(Token = "0x4000213")]
	private static HashSet<Int32> k_FontAssets_AtlasTexturesUpdateQueueLookup; //Field offset: 0x80
	[Token(Token = "0x400021E")]
	internal static UInt32[] k_GlyphIndexArray; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x40001DA")]
	internal string m_SourceFontFileGUID; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40001DB")]
	internal FontAssetCreationSettings m_CreationSettings; //Field offset: 0xA0
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x40001DC")]
	private Font m_SourceFontFile; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x40001DD")]
	private string m_SourceFontFilePath; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40001DE")]
	private AtlasPopulationMode m_AtlasPopulationMode; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[Token(Token = "0x40001DF")]
	internal bool InternalDynamicOS; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40001E0")]
	private int m_FamilyNameHashCode; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x40001E1")]
	private int m_StyleNameHashCode; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x40001E2")]
	internal List<Glyph> m_GlyphTable; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40001E3")]
	internal Dictionary<UInt32, Glyph> m_GlyphLookupDictionary; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x40001E4")]
	internal List<TMP_Character> m_CharacterTable; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40001E5")]
	internal Dictionary<UInt32, TMP_Character> m_CharacterLookupDictionary; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40001E6")]
	internal Texture2D m_AtlasTexture; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x40001E7")]
	internal Texture2D[] m_AtlasTextures; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x40001E8")]
	internal int m_AtlasTextureIndex; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[SerializeField]
	[Token(Token = "0x40001E9")]
	private bool m_IsMultiAtlasTexturesEnabled; //Field offset: 0x154
	[FieldOffset(Offset = "0x155")]
	[SerializeField]
	[Token(Token = "0x40001EA")]
	private bool m_GetFontFeatures; //Field offset: 0x155
	[FieldOffset(Offset = "0x156")]
	[SerializeField]
	[Token(Token = "0x40001EB")]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0x156
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x40001EC")]
	internal int m_AtlasWidth; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[SerializeField]
	[Token(Token = "0x40001ED")]
	internal int m_AtlasHeight; //Field offset: 0x15C
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Token(Token = "0x40001EE")]
	internal int m_AtlasPadding; //Field offset: 0x160
	[FieldOffset(Offset = "0x164")]
	[SerializeField]
	[Token(Token = "0x40001EF")]
	internal GlyphRenderMode m_AtlasRenderMode; //Field offset: 0x164
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x40001F0")]
	private List<GlyphRect> m_UsedGlyphRects; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	[Token(Token = "0x40001F1")]
	private List<GlyphRect> m_FreeGlyphRects; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	[Token(Token = "0x40001F2")]
	internal TMP_FontFeatureTable m_FontFeatureTable; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x40001F3")]
	internal bool m_ShouldReimportFontFeatures; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[Token(Token = "0x40001F4")]
	internal List<TMP_FontAsset> m_FallbackFontAssetTable; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	[Token(Token = "0x40001F5")]
	private TMP_FontWeightPair[] m_FontWeightTable; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	[Token(Token = "0x40001F6")]
	private TMP_FontWeightPair[] fontWeights; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40001F7")]
	public float normalStyle; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x40001F8")]
	public float normalSpacingOffset; //Field offset: 0x1A4
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40001F9")]
	public float boldStyle; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x40001FA")]
	public float boldSpacing; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40001FB")]
	public byte italicStyle; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B1")]
	[Token(Token = "0x40001FC")]
	public byte tabSize; //Field offset: 0x1B1
	[FieldOffset(Offset = "0x1B2")]
	[Token(Token = "0x40001FD")]
	internal bool IsFontAssetLookupTablesDirty; //Field offset: 0x1B2
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x40001FE")]
	private FaceInfo_Legacy m_fontInfo; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x40001FF")]
	internal List<TMP_Glyph> m_glyphInfoList; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[FormerlySerializedAs("m_kerningInfo")]
	[SerializeField]
	[Token(Token = "0x4000200")]
	internal KerningTable m_KerningTable; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x4000201")]
	private List<TMP_FontAsset> fallbackFontAssets; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Token(Token = "0x4000202")]
	public Texture2D atlas; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000214")]
	private List<Glyph> m_GlyphsToRender; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000215")]
	private List<Glyph> m_GlyphsRendered; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000216")]
	private List<UInt32> m_GlyphIndexList; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000217")]
	private List<UInt32> m_GlyphIndexListNewlyAdded; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000218")]
	internal List<UInt32> m_GlyphsToAdd; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000219")]
	internal HashSet<UInt32> m_GlyphsToAddLookup; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400021A")]
	internal List<TMP_Character> m_CharactersToAdd; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400021B")]
	internal HashSet<UInt32> m_CharactersToAddLookup; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400021C")]
	internal List<UInt32> s_MissingCharacterList; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x400021D")]
	internal HashSet<UInt32> m_MissingUnicodesFromFontFile; //Field offset: 0x228

	[Token(Token = "0x17000074")]
	public internal int atlasHeight
	{
		[Address(RVA = "0x2EC3330", Offset = "0x2EC2730", Length = "0x7")]
		[Token(Token = "0x6000236")]
		 get { } //Length: 7
		[Address(RVA = "0x2EC3610", Offset = "0x2EC2A10", Length = "0x7")]
		[Token(Token = "0x6000237")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000075")]
	public internal int atlasPadding
	{
		[Address(RVA = "0x2EC3340", Offset = "0x2EC2740", Length = "0x7")]
		[Token(Token = "0x6000238")]
		 get { } //Length: 7
		[Address(RVA = "0x2EC3620", Offset = "0x2EC2A20", Length = "0x7")]
		[Token(Token = "0x6000239")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000066")]
	public AtlasPopulationMode atlasPopulationMode
	{
		[Address(RVA = "0x1E2A1A0", Offset = "0x1E295A0", Length = "0x7")]
		[Token(Token = "0x600021E")]
		 get { } //Length: 7
		[Address(RVA = "0x2D686B0", Offset = "0x2D67AB0", Length = "0x7")]
		[Token(Token = "0x600021F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000076")]
	public internal GlyphRenderMode atlasRenderMode
	{
		[Address(RVA = "0x2C0A1F0", Offset = "0x2C095F0", Length = "0x7")]
		[Token(Token = "0x600023A")]
		 get { } //Length: 7
		[Address(RVA = "0x2BF5F40", Offset = "0x2BF5340", Length = "0x7")]
		[Token(Token = "0x600023B")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700006D")]
	public Texture2D atlasTexture
	{
		[Address(RVA = "0x2EC3360", Offset = "0x2EC2760", Length = "0x9C")]
		[Token(Token = "0x600022A")]
		 get { } //Length: 156
	}

	[Token(Token = "0x1700006F")]
	public int atlasTextureCount
	{
		[Address(RVA = "0x2EC3350", Offset = "0x2EC2750", Length = "0x9")]
		[Token(Token = "0x600022D")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700006E")]
	public Texture2D[] atlasTextures
	{
		[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
		[Token(Token = "0x600022B")]
		 get { } //Length: 8
		[Address(RVA = "0x29B4B60", Offset = "0x29B3F60", Length = "0x13")]
		[Token(Token = "0x600022C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000073")]
	public internal int atlasWidth
	{
		[Address(RVA = "0x2EC3400", Offset = "0x2EC2800", Length = "0x7")]
		[Token(Token = "0x6000234")]
		 get { } //Length: 7
		[Address(RVA = "0x2EC3630", Offset = "0x2EC2A30", Length = "0x7")]
		[Token(Token = "0x6000235")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700006C")]
	public Dictionary<UInt32, TMP_Character> characterLookupTable
	{
		[Address(RVA = "0x2EC3410", Offset = "0x2EC2810", Length = "0x34")]
		[Token(Token = "0x6000229")]
		 get { } //Length: 52
	}

	[Token(Token = "0x1700006B")]
	public internal List<TMP_Character> characterTable
	{
		[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
		[Token(Token = "0x6000227")]
		 get { } //Length: 8
		[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
		[Token(Token = "0x6000228")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000072")]
	internal bool clearDynamicDataOnBuild
	{
		[Address(RVA = "0x2EC3450", Offset = "0x2EC2850", Length = "0x8")]
		[Token(Token = "0x6000232")]
		internal get { } //Length: 8
		[Address(RVA = "0x2EC3640", Offset = "0x2EC2A40", Length = "0x7")]
		[Token(Token = "0x6000233")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000064")]
	public FontAssetCreationSettings creationSettings
	{
		[Address(RVA = "0x2EC3460", Offset = "0x2EC2860", Length = "0x45")]
		[Token(Token = "0x600021A")]
		 get { } //Length: 69
		[Address(RVA = "0x2EC3650", Offset = "0x2EC2A50", Length = "0x4F")]
		[Token(Token = "0x600021B")]
		 set { } //Length: 79
	}

	[Token(Token = "0x1700007A")]
	public List<TMP_FontAsset> fallbackFontAssetTable
	{
		[Address(RVA = "0x22EAA80", Offset = "0x22E9E80", Length = "0x8")]
		[Token(Token = "0x6000242")]
		 get { } //Length: 8
		[Address(RVA = "0x291FDF0", Offset = "0x291F1F0", Length = "0x13")]
		[Token(Token = "0x6000243")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000067")]
	internal int familyNameHashCode
	{
		[Address(RVA = "0x2EC34B0", Offset = "0x2EC28B0", Length = "0x77")]
		[Token(Token = "0x6000220")]
		internal get { } //Length: 119
		[Address(RVA = "0x2EC36A0", Offset = "0x2EC2AA0", Length = "0x7")]
		[Token(Token = "0x6000221")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000079")]
	public internal TMP_FontFeatureTable fontFeatureTable
	{
		[Address(RVA = "0x1D11BB0", Offset = "0x1D10FB0", Length = "0x8")]
		[Token(Token = "0x6000240")]
		 get { } //Length: 8
		[Address(RVA = "0x24CEC90", Offset = "0x24CE090", Length = "0x13")]
		[Token(Token = "0x6000241")]
		internal set { } //Length: 19
	}

	[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
	[Token(Token = "0x1700007C")]
	public FaceInfo_Legacy fontInfo
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[Token(Token = "0x6000246")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700007B")]
	public internal TMP_FontWeightPair[] fontWeightTable
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[Token(Token = "0x6000244")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[Token(Token = "0x6000245")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000078")]
	internal List<GlyphRect> freeGlyphRects
	{
		[Address(RVA = "0x1D4E690", Offset = "0x1D4DA90", Length = "0x8")]
		[Token(Token = "0x600023E")]
		internal get { } //Length: 8
		[Address(RVA = "0x291FE10", Offset = "0x291F210", Length = "0x13")]
		[Token(Token = "0x600023F")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000071")]
	public bool getFontFeatures
	{
		[Address(RVA = "0x2EC3530", Offset = "0x2EC2930", Length = "0x8")]
		[Token(Token = "0x6000230")]
		 get { } //Length: 8
		[Address(RVA = "0x2EC36B0", Offset = "0x2EC2AB0", Length = "0x7")]
		[Token(Token = "0x6000231")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700006A")]
	public Dictionary<UInt32, Glyph> glyphLookupTable
	{
		[Address(RVA = "0x2EC3540", Offset = "0x2EC2940", Length = "0x34")]
		[Token(Token = "0x6000226")]
		 get { } //Length: 52
	}

	[Token(Token = "0x17000069")]
	public internal List<Glyph> glyphTable
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[Token(Token = "0x6000224")]
		 get { } //Length: 8
		[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
		[Token(Token = "0x6000225")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000070")]
	public bool isMultiAtlasTexturesEnabled
	{
		[Address(RVA = "0x2EC3580", Offset = "0x2EC2980", Length = "0x8")]
		[Token(Token = "0x600022E")]
		 get { } //Length: 8
		[Address(RVA = "0x2EC36C0", Offset = "0x2EC2AC0", Length = "0x7")]
		[Token(Token = "0x600022F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000065")]
	public internal Font sourceFontFile
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x600021C")]
		 get { } //Length: 8
		[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
		[Token(Token = "0x600021D")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000068")]
	internal int styleNameHashCode
	{
		[Address(RVA = "0x2EC3590", Offset = "0x2EC2990", Length = "0x77")]
		[Token(Token = "0x6000222")]
		internal get { } //Length: 119
		[Address(RVA = "0x2EC36D0", Offset = "0x2EC2AD0", Length = "0x7")]
		[Token(Token = "0x6000223")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000077")]
	internal List<GlyphRect> usedGlyphRects
	{
		[Address(RVA = "0x1D11CC0", Offset = "0x1D110C0", Length = "0x8")]
		[Token(Token = "0x600023C")]
		internal get { } //Length: 8
		[Address(RVA = "0x2726E30", Offset = "0x2726230", Length = "0x13")]
		[Token(Token = "0x600023D")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x2EC2AC0", Offset = "0x2EC1EC0", Length = "0x484")]
	[Token(Token = "0x6000293")]
	private static TMP_FontAsset() { }

	[Address(RVA = "0x2EC2F50", Offset = "0x2EC2350", Length = "0x3D2")]
	[Token(Token = "0x6000292")]
	public TMP_FontAsset() { }

	[Address(RVA = "0x2EB7470", Offset = "0x2EB6870", Length = "0x9F")]
	[Token(Token = "0x600025B")]
	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character, FontStyles fontStyle = 0, FontWeight fontWeight = 400, bool isAlternativeTypeface = false) { }

	[Address(RVA = "0x2EB7510", Offset = "0x2EB6910", Length = "0x1F")]
	[Token(Token = "0x6000274")]
	internal bool AddGlyphInternal(uint glyphIndex) { }

	[Address(RVA = "0x2EB7530", Offset = "0x2EB6930", Length = "0x430")]
	[Token(Token = "0x6000281")]
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	[Address(RVA = "0x2EB7970", Offset = "0x2EB6D70", Length = "0x2FB")]
	[Token(Token = "0x6000286")]
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	[Address(RVA = "0x2EB7C70", Offset = "0x2EB7070", Length = "0x2FB")]
	[Token(Token = "0x6000287")]
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	[Address(RVA = "0x2EB7F70", Offset = "0x2EB7370", Length = "0x323")]
	[Token(Token = "0x6000283")]
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	[Address(RVA = "0x2EB82A0", Offset = "0x2EB76A0", Length = "0x31A")]
	[Token(Token = "0x600025A")]
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false) { }

	[Address(RVA = "0x2EB85C0", Offset = "0x2EB79C0", Length = "0x22F")]
	[Token(Token = "0x6000259")]
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	[Address(RVA = "0x2EB87F0", Offset = "0x2EB7BF0", Length = "0x25D")]
	[Token(Token = "0x600028F")]
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false) { }

	[Address(RVA = "0x2EB8A80", Offset = "0x2EB7E80", Length = "0x209")]
	[Token(Token = "0x600028D")]
	private void ClearCharacterAndGlyphTables() { }

	[Address(RVA = "0x2EB8A50", Offset = "0x2EB7E50", Length = "0x2C")]
	[Token(Token = "0x600028B")]
	internal void ClearCharacterAndGlyphTablesInternal() { }

	[Address(RVA = "0x2EB8C90", Offset = "0x2EB8090", Length = "0x326")]
	[Token(Token = "0x6000254")]
	internal void ClearFallbackCharacterTable() { }

	[Address(RVA = "0x2EB8FC0", Offset = "0x2EB83C0", Length = "0x21C")]
	[Token(Token = "0x600028A")]
	public void ClearFontAssetData(bool setAtlasSizeToZero = false) { }

	[Address(RVA = "0x2EB91E0", Offset = "0x2EB85E0", Length = "0x1F")]
	[Token(Token = "0x600028C")]
	internal void ClearFontFeaturesInternal() { }

	[Address(RVA = "0x2EB9200", Offset = "0x2EB8600", Length = "0xF5")]
	[Token(Token = "0x600028E")]
	private void ClearFontFeaturesTables() { }

	[Address(RVA = "0x93F6D0", Offset = "0x93EAD0", Length = "0x1C5")]
	[Token(Token = "0x6000288")]
	private void CopyListDataToArray(List<T> srcList, ref T[] dstArray) { }

	[Address(RVA = "0x2EB9FE0", Offset = "0x2EB93E0", Length = "0x165")]
	[Token(Token = "0x6000249")]
	private static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x2EB9B50", Offset = "0x2EB8F50", Length = "0x19A")]
	[Token(Token = "0x600024A")]
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	[Address(RVA = "0x2EB9E50", Offset = "0x2EB9250", Length = "0x182")]
	[Token(Token = "0x600024B")]
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x2EB9CF0", Offset = "0x2EB90F0", Length = "0x158")]
	[Token(Token = "0x600024C")]
	private static TMP_FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x2EB9920", Offset = "0x2EB8D20", Length = "0x220")]
	[Token(Token = "0x6000247")]
	public static TMP_FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	[Address(RVA = "0x2EBA150", Offset = "0x2EB9550", Length = "0xAC")]
	[Token(Token = "0x6000248")]
	public static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	[Address(RVA = "0x2EB9300", Offset = "0x2EB8700", Length = "0x619")]
	[Token(Token = "0x600024D")]
	private static TMP_FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	[Address(RVA = "0x2EBA200", Offset = "0x2EB9600", Length = "0xE7")]
	[Token(Token = "0x6000290")]
	private void DestroyAtlasTextures() { }

	[Address(RVA = "0x2EC3330", Offset = "0x2EC2730", Length = "0x7")]
	[Token(Token = "0x6000236")]
	public int get_atlasHeight() { }

	[Address(RVA = "0x2EC3340", Offset = "0x2EC2740", Length = "0x7")]
	[Token(Token = "0x6000238")]
	public int get_atlasPadding() { }

	[Address(RVA = "0x1E2A1A0", Offset = "0x1E295A0", Length = "0x7")]
	[Token(Token = "0x600021E")]
	public AtlasPopulationMode get_atlasPopulationMode() { }

	[Address(RVA = "0x2C0A1F0", Offset = "0x2C095F0", Length = "0x7")]
	[Token(Token = "0x600023A")]
	public GlyphRenderMode get_atlasRenderMode() { }

	[Address(RVA = "0x2EC3360", Offset = "0x2EC2760", Length = "0x9C")]
	[Token(Token = "0x600022A")]
	public Texture2D get_atlasTexture() { }

	[Address(RVA = "0x2EC3350", Offset = "0x2EC2750", Length = "0x9")]
	[Token(Token = "0x600022D")]
	public int get_atlasTextureCount() { }

	[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
	[Token(Token = "0x600022B")]
	public Texture2D[] get_atlasTextures() { }

	[Address(RVA = "0x2EC3400", Offset = "0x2EC2800", Length = "0x7")]
	[Token(Token = "0x6000234")]
	public int get_atlasWidth() { }

	[Address(RVA = "0x2EC3410", Offset = "0x2EC2810", Length = "0x34")]
	[Token(Token = "0x6000229")]
	public Dictionary<UInt32, TMP_Character> get_characterLookupTable() { }

	[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
	[Token(Token = "0x6000227")]
	public List<TMP_Character> get_characterTable() { }

	[Address(RVA = "0x2EC3450", Offset = "0x2EC2850", Length = "0x8")]
	[Token(Token = "0x6000232")]
	internal bool get_clearDynamicDataOnBuild() { }

	[Address(RVA = "0x2EC3460", Offset = "0x2EC2860", Length = "0x45")]
	[Token(Token = "0x600021A")]
	public FontAssetCreationSettings get_creationSettings() { }

	[Address(RVA = "0x22EAA80", Offset = "0x22E9E80", Length = "0x8")]
	[Token(Token = "0x6000242")]
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	[Address(RVA = "0x2EC34B0", Offset = "0x2EC28B0", Length = "0x77")]
	[Token(Token = "0x6000220")]
	internal int get_familyNameHashCode() { }

	[Address(RVA = "0x1D11BB0", Offset = "0x1D10FB0", Length = "0x8")]
	[Token(Token = "0x6000240")]
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[Token(Token = "0x6000246")]
	public FaceInfo_Legacy get_fontInfo() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[Token(Token = "0x6000244")]
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	[Address(RVA = "0x1D4E690", Offset = "0x1D4DA90", Length = "0x8")]
	[Token(Token = "0x600023E")]
	internal List<GlyphRect> get_freeGlyphRects() { }

	[Address(RVA = "0x2EC3530", Offset = "0x2EC2930", Length = "0x8")]
	[Token(Token = "0x6000230")]
	public bool get_getFontFeatures() { }

	[Address(RVA = "0x2EC3540", Offset = "0x2EC2940", Length = "0x34")]
	[Token(Token = "0x6000226")]
	public Dictionary<UInt32, Glyph> get_glyphLookupTable() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[Token(Token = "0x6000224")]
	public List<Glyph> get_glyphTable() { }

	[Address(RVA = "0x2EC3580", Offset = "0x2EC2980", Length = "0x8")]
	[Token(Token = "0x600022E")]
	public bool get_isMultiAtlasTexturesEnabled() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x600021C")]
	public Font get_sourceFontFile() { }

	[Address(RVA = "0x2EC3590", Offset = "0x2EC2990", Length = "0x77")]
	[Token(Token = "0x6000222")]
	internal int get_styleNameHashCode() { }

	[Address(RVA = "0x1D11CC0", Offset = "0x1D110C0", Length = "0x8")]
	[Token(Token = "0x600023C")]
	internal List<GlyphRect> get_usedGlyphRects() { }

	[Address(RVA = "0x2EBA3D0", Offset = "0x2EB97D0", Length = "0xE0")]
	[Token(Token = "0x6000267")]
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2EBA2F0", Offset = "0x2EB96F0", Length = "0xDE")]
	[Token(Token = "0x6000268")]
	public static Int32[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2EBA4C0", Offset = "0x2EB98C0", Length = "0xD9")]
	[Token(Token = "0x6000269")]
	internal uint GetGlyphIndex(uint unicode) { }

	[Address(RVA = "0x2EBA5A0", Offset = "0x2EB99A0", Length = "0x82")]
	[Token(Token = "0x600026A")]
	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	[Address(RVA = "0x2EBA880", Offset = "0x2EB9C80", Length = "0x75")]
	[Token(Token = "0x6000261")]
	public bool HasCharacter(int character) { }

	[Address(RVA = "0x2EBA900", Offset = "0x2EB9D00", Length = "0x604")]
	[Token(Token = "0x6000262")]
	public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x2EBA630", Offset = "0x2EB9A30", Length = "0x24E")]
	[Token(Token = "0x6000263")]
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x2EBAF10", Offset = "0x2EBA310", Length = "0x185")]
	[Token(Token = "0x6000264")]
	public bool HasCharacters(string text, out List<Char>& missingCharacters) { }

	[Address(RVA = "0x2EBB0A0", Offset = "0x2EBA4A0", Length = "0x766")]
	[Token(Token = "0x6000265")]
	public bool HasCharacters(string text, out UInt32[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x2EBB810", Offset = "0x2EBAC10", Length = "0xE5")]
	[Token(Token = "0x6000266")]
	public bool HasCharacters(string text) { }

	[Address(RVA = "0x2EBB900", Offset = "0x2EBAD00", Length = "0xFF")]
	[Token(Token = "0x600027E")]
	internal void ImportFontFeatures() { }

	[Address(RVA = "0x2EBBA00", Offset = "0x2EBAE00", Length = "0x209")]
	[Token(Token = "0x6000253")]
	internal void InitializeCharacterLookupDictionary() { }

	[Address(RVA = "0x2EBBC10", Offset = "0x2EBB010", Length = "0x495")]
	[Token(Token = "0x6000251")]
	internal void InitializeDictionaryLookupTables() { }

	[Address(RVA = "0x2EBC0B0", Offset = "0x2EBB4B0", Length = "0x275")]
	[Token(Token = "0x6000252")]
	internal void InitializeGlyphLookupDictionary() { }

	[Address(RVA = "0x2EBC330", Offset = "0x2EBB730", Length = "0x2AC")]
	[Token(Token = "0x6000256")]
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x2EBC5E0", Offset = "0x2EBB9E0", Length = "0x296")]
	[Token(Token = "0x6000255")]
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	[Address(RVA = "0x2EBC880", Offset = "0x2EBBC80", Length = "0x1B9")]
	[Token(Token = "0x6000257")]
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x2EBCA40", Offset = "0x2EBBE40", Length = "0x1B9")]
	[Token(Token = "0x6000258")]
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x2EBCC00", Offset = "0x2EBC000", Length = "0x151")]
	[Token(Token = "0x600025C")]
	internal FontEngineError LoadFontFace() { }

	[Address(RVA = "0x2EBCD60", Offset = "0x2EBC160", Length = "0x132")]
	[Token(Token = "0x600024F")]
	private void OnDestroy() { }

	[Address(RVA = "0x2EBCEA0", Offset = "0x2EBC2A0", Length = "0x763")]
	[Token(Token = "0x6000250")]
	public void ReadFontAssetDefinition() { }

	[Address(RVA = "0x2EBD610", Offset = "0x2EBCA10", Length = "0x140")]
	[Token(Token = "0x600026D")]
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	[Address(RVA = "0x2EBD760", Offset = "0x2EBCB60", Length = "0x342")]
	[Token(Token = "0x600024E")]
	private void RegisterCallbackInstance(TMP_FontAsset instance) { }

	[Address(RVA = "0x2EBDAB0", Offset = "0x2EBCEB0", Length = "0x14A")]
	[Token(Token = "0x600026B")]
	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2EC3610", Offset = "0x2EC2A10", Length = "0x7")]
	[Token(Token = "0x6000237")]
	internal void set_atlasHeight(int value) { }

	[Address(RVA = "0x2EC3620", Offset = "0x2EC2A20", Length = "0x7")]
	[Token(Token = "0x6000239")]
	internal void set_atlasPadding(int value) { }

	[Address(RVA = "0x2D686B0", Offset = "0x2D67AB0", Length = "0x7")]
	[Token(Token = "0x600021F")]
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	[Address(RVA = "0x2BF5F40", Offset = "0x2BF5340", Length = "0x7")]
	[Token(Token = "0x600023B")]
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	[Address(RVA = "0x29B4B60", Offset = "0x29B3F60", Length = "0x13")]
	[Token(Token = "0x600022C")]
	public void set_atlasTextures(Texture2D[] value) { }

	[Address(RVA = "0x2EC3630", Offset = "0x2EC2A30", Length = "0x7")]
	[Token(Token = "0x6000235")]
	internal void set_atlasWidth(int value) { }

	[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
	[Token(Token = "0x6000228")]
	internal void set_characterTable(List<TMP_Character> value) { }

	[Address(RVA = "0x2EC3640", Offset = "0x2EC2A40", Length = "0x7")]
	[Token(Token = "0x6000233")]
	internal void set_clearDynamicDataOnBuild(bool value) { }

	[Address(RVA = "0x2EC3650", Offset = "0x2EC2A50", Length = "0x4F")]
	[Token(Token = "0x600021B")]
	public void set_creationSettings(FontAssetCreationSettings value) { }

	[Address(RVA = "0x291FDF0", Offset = "0x291F1F0", Length = "0x13")]
	[Token(Token = "0x6000243")]
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	[Address(RVA = "0x2EC36A0", Offset = "0x2EC2AA0", Length = "0x7")]
	[Token(Token = "0x6000221")]
	internal void set_familyNameHashCode(int value) { }

	[Address(RVA = "0x24CEC90", Offset = "0x24CE090", Length = "0x13")]
	[Token(Token = "0x6000241")]
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[Token(Token = "0x6000245")]
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	[Address(RVA = "0x291FE10", Offset = "0x291F210", Length = "0x13")]
	[Token(Token = "0x600023F")]
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	[Address(RVA = "0x2EC36B0", Offset = "0x2EC2AB0", Length = "0x7")]
	[Token(Token = "0x6000231")]
	public void set_getFontFeatures(bool value) { }

	[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
	[Token(Token = "0x6000225")]
	internal void set_glyphTable(List<Glyph> value) { }

	[Address(RVA = "0x2EC36C0", Offset = "0x2EC2AC0", Length = "0x7")]
	[Token(Token = "0x600022F")]
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
	[Token(Token = "0x600021D")]
	internal void set_sourceFontFile(Font value) { }

	[Address(RVA = "0x2EC36D0", Offset = "0x2EC2AD0", Length = "0x7")]
	[Token(Token = "0x6000223")]
	internal void set_styleNameHashCode(int value) { }

	[Address(RVA = "0x2726E30", Offset = "0x2726230", Length = "0x13")]
	[Token(Token = "0x600023D")]
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	[Address(RVA = "0x2EBDC00", Offset = "0x2EBD000", Length = "0x2A7")]
	[Token(Token = "0x600027A")]
	private void SetupNewAtlasTexture() { }

	[Address(RVA = "0x2EBDEB0", Offset = "0x2EBD2B0", Length = "0x300")]
	[Token(Token = "0x6000260")]
	internal void SortAllTables() { }

	[Address(RVA = "0x2EBE1C0", Offset = "0x2EBD5C0", Length = "0x178")]
	[Token(Token = "0x600025D")]
	internal void SortCharacterTable() { }

	[Address(RVA = "0x2EBE340", Offset = "0x2EBD740", Length = "0x4C")]
	[Token(Token = "0x600025F")]
	internal void SortFontFeatureTable() { }

	[Address(RVA = "0x2EBE390", Offset = "0x2EBD790", Length = "0x178")]
	[Token(Token = "0x600025E")]
	internal void SortGlyphTable() { }

	[Address(RVA = "0x2EBE510", Offset = "0x2EBD910", Length = "0x900")]
	[Token(Token = "0x6000276")]
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	[Address(RVA = "0x2EBEE20", Offset = "0x2EBE220", Length = "0xC2A")]
	[Token(Token = "0x6000271")]
	public bool TryAddCharacters(UInt32[] unicodes, out UInt32[] missingUnicodes, bool includeFontFeatures = false) { }

	[Address(RVA = "0x2EC06D0", Offset = "0x2EBFAD0", Length = "0x23")]
	[Token(Token = "0x6000270")]
	public bool TryAddCharacters(UInt32[] unicodes, bool includeFontFeatures = false) { }

	[Address(RVA = "0x2EBFA50", Offset = "0x2EBEE50", Length = "0x23")]
	[Token(Token = "0x6000272")]
	public bool TryAddCharacters(string characters, bool includeFontFeatures = false) { }

	[Address(RVA = "0x2EBFA80", Offset = "0x2EBEE80", Length = "0xC45")]
	[Token(Token = "0x6000273")]
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false) { }

	[Address(RVA = "0x2EC0700", Offset = "0x2EBFB00", Length = "0x675")]
	[Token(Token = "0x6000275")]
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000278")]
	internal void TryAddGlyphsToAtlasTextures() { }

	[Address(RVA = "0x2EC0D80", Offset = "0x2EC0180", Length = "0x493")]
	[Token(Token = "0x6000279")]
	private bool TryAddGlyphsToNewAtlasTexture() { }

	[Address(RVA = "0x2EC1220", Offset = "0x2EC0620", Length = "0x4B4")]
	[Token(Token = "0x6000277")]
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) { }

	[Address(RVA = "0x2EC16E0", Offset = "0x2EC0AE0", Length = "0x1A9")]
	[Token(Token = "0x600027B")]
	internal void UpdateAtlasTexture() { }

	[Address(RVA = "0x2EC1890", Offset = "0x2EC0C90", Length = "0x189")]
	[Token(Token = "0x600026E")]
	internal static void UpdateAtlasTexturesInQueue() { }

	[Address(RVA = "0x2EC1A20", Offset = "0x2EC0E20", Length = "0xA6")]
	[Token(Token = "0x6000285")]
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	[Address(RVA = "0x2EC1AD0", Offset = "0x2EC0ED0", Length = "0x196")]
	[Token(Token = "0x6000289")]
	internal void UpdateFontAssetData() { }

	[Address(RVA = "0x2EC1C70", Offset = "0x2EC1070", Length = "0x1B9")]
	[Token(Token = "0x600026F")]
	internal static void UpdateFontAssetsInUpdateQueue() { }

	[Address(RVA = "0x2EC1E30", Offset = "0x2EC1230", Length = "0x22A")]
	[Token(Token = "0x600026C")]
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	[Address(RVA = "0x2EC2060", Offset = "0x2EC1460", Length = "0x103")]
	[Token(Token = "0x600027C")]
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	[Address(RVA = "0x2EC2300", Offset = "0x2EC1700", Length = "0x306")]
	[Token(Token = "0x6000284")]
	internal void UpdateGlyphAdjustmentRecords(UInt32[] glyphIndexes) { }

	[Address(RVA = "0x2EC2290", Offset = "0x2EC1690", Length = "0x6D")]
	[Token(Token = "0x6000282")]
	internal void UpdateGlyphAdjustmentRecords() { }

	[Address(RVA = "0x2EC2170", Offset = "0x2EC1570", Length = "0xAE")]
	[Token(Token = "0x600027D")]
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	[Address(RVA = "0x2EC2220", Offset = "0x2EC1620", Length = "0x67")]
	[Token(Token = "0x600027F")]
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	[Address(RVA = "0x2EC2610", Offset = "0x2EC1A10", Length = "0x6D")]
	[Token(Token = "0x6000280")]
	internal void UpdateLigatureSubstitutionRecords() { }

	[Address(RVA = "0x2EC2680", Offset = "0x2EC1A80", Length = "0x433")]
	[Token(Token = "0x6000291")]
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

}

