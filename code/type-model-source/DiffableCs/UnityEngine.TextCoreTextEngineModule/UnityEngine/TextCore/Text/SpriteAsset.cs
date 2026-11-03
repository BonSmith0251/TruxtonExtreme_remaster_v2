namespace UnityEngine.TextCore.Text;

[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/2023.3/Documentation/Manual/UIE-sprite.html")]
[Token(Token = "0x2000036")]
public class SpriteAsset : TextAsset
{
	[CompilerGenerated]
	[Token(Token = "0x2000037")]
	private sealed class <>c
	{
		[Token(Token = "0x4000186")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000187")]
		public static Func<SpriteGlyph, UInt32> <>9__44_0; //Field offset: 0x8
		[Token(Token = "0x4000188")]
		public static Func<SpriteCharacter, UInt32> <>9__45_0; //Field offset: 0x10

		[Address(RVA = "0x31C3D70", Offset = "0x31C3170", Length = "0x67")]
		[Token(Token = "0x600016E")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600016F")]
		public <>c() { }

		[Address(RVA = "0x2ED9790", Offset = "0x2ED8B90", Length = "0x16")]
		[Token(Token = "0x6000171")]
		internal uint <SortCharacterTable>b__45_0(SpriteCharacter c) { }

		[Address(RVA = "0x2ED9830", Offset = "0x2ED8C30", Length = "0x1F")]
		[Token(Token = "0x6000170")]
		internal uint <SortGlyphTable>b__44_0(SpriteGlyph item) { }

	}

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017A")]
	internal Dictionary<Int32, Int32> m_NameLookup; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400017B")]
	internal Dictionary<UInt32, Int32> m_GlyphIndexLookup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400017C")]
	internal FaceInfo m_FaceInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0xA8")]
	[FormerlySerializedAs("spriteSheet")]
	[SerializeField]
	[Token(Token = "0x400017D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Texture m_SpriteAtlasTexture; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400017E")]
	private float <width>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x400017F")]
	private float <height>k__BackingField; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x4000180")]
	private List<SpriteCharacter> m_SpriteCharacterTable; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000181")]
	internal Dictionary<UInt32, SpriteCharacter> m_SpriteCharacterLookup; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x4000182")]
	private List<SpriteGlyph> m_SpriteGlyphTable; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000183")]
	internal Dictionary<UInt32, SpriteGlyph> m_SpriteGlyphLookup; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x4000184")]
	public List<SpriteAsset> fallbackSpriteAssets; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000185")]
	internal bool m_IsSpriteAssetLookupTablesDirty; //Field offset: 0xE0

	[Token(Token = "0x17000033")]
	public internal FaceInfo faceInfo
	{
		[Address(RVA = "0x31B2640", Offset = "0x31B1A40", Length = "0x39")]
		[Token(Token = "0x6000151")]
		 get { } //Length: 57
		[Address(RVA = "0x31B2720", Offset = "0x31B1B20", Length = "0x40")]
		[Token(Token = "0x6000152")]
		internal set { } //Length: 64
	}

	[Token(Token = "0x17000036")]
	internal float height
	{
		[Address(RVA = "0x31B2680", Offset = "0x31B1A80", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000157")]
		internal get { } //Length: 9
		[Address(RVA = "0x31B2760", Offset = "0x31B1B60", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000158")]
		private set { } //Length: 9
	}

	[Token(Token = "0x17000038")]
	public internal Dictionary<UInt32, SpriteCharacter> spriteCharacterLookupTable
	{
		[Address(RVA = "0x31B2690", Offset = "0x31B1A90", Length = "0x34")]
		[Token(Token = "0x600015B")]
		 get { } //Length: 52
		[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
		[Token(Token = "0x600015C")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000037")]
	public internal List<SpriteCharacter> spriteCharacterTable
	{
		[Address(RVA = "0x31B26D0", Offset = "0x31B1AD0", Length = "0x31")]
		[Token(Token = "0x6000159")]
		 get { } //Length: 49
		[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
		[Token(Token = "0x600015A")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000039")]
	public internal List<SpriteGlyph> spriteGlyphTable
	{
		[Address(RVA = "0x30E9A90", Offset = "0x30E8E90", Length = "0xA")]
		[Token(Token = "0x600015D")]
		 get { } //Length: 10
		[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
		[Token(Token = "0x600015E")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000034")]
	public internal Texture spriteSheet
	{
		[Address(RVA = "0x30E9A50", Offset = "0x30E8E50", Length = "0xA")]
		[Token(Token = "0x6000153")]
		 get { } //Length: 10
		[Address(RVA = "0x31B2770", Offset = "0x31B1B70", Length = "0x83")]
		[Token(Token = "0x6000154")]
		internal set { } //Length: 131
	}

	[Token(Token = "0x17000035")]
	internal float width
	{
		[Address(RVA = "0x31B2710", Offset = "0x31B1B10", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000155")]
		internal get { } //Length: 9
		[Address(RVA = "0x31B2800", Offset = "0x31B1C00", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000156")]
		private set { } //Length: 9
	}

	[Address(RVA = "0x31B2540", Offset = "0x31B1940", Length = "0xF1")]
	[Token(Token = "0x600016D")]
	public SpriteAsset() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600015F")]
	private void Awake() { }

	[Address(RVA = "0x31B2640", Offset = "0x31B1A40", Length = "0x39")]
	[Token(Token = "0x6000151")]
	public FaceInfo get_faceInfo() { }

	[Address(RVA = "0x31B2680", Offset = "0x31B1A80", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000157")]
	internal float get_height() { }

	[Address(RVA = "0x31B2690", Offset = "0x31B1A90", Length = "0x34")]
	[Token(Token = "0x600015B")]
	public Dictionary<UInt32, SpriteCharacter> get_spriteCharacterLookupTable() { }

	[Address(RVA = "0x31B26D0", Offset = "0x31B1AD0", Length = "0x31")]
	[Token(Token = "0x6000159")]
	public List<SpriteCharacter> get_spriteCharacterTable() { }

	[Address(RVA = "0x30E9A90", Offset = "0x30E8E90", Length = "0xA")]
	[Token(Token = "0x600015D")]
	public List<SpriteGlyph> get_spriteGlyphTable() { }

	[Address(RVA = "0x30E9A50", Offset = "0x30E8E50", Length = "0xA")]
	[Token(Token = "0x6000153")]
	public Texture get_spriteSheet() { }

	[Address(RVA = "0x31B2710", Offset = "0x31B1B10", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000155")]
	internal float get_width() { }

	[Address(RVA = "0x31B0E90", Offset = "0x31B0290", Length = "0x80")]
	[Token(Token = "0x6000161")]
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	[Address(RVA = "0x31B0F20", Offset = "0x31B0320", Length = "0x3F")]
	[Token(Token = "0x6000163")]
	public int GetSpriteIndexFromName(string name) { }

	[Address(RVA = "0x31B0F60", Offset = "0x31B0360", Length = "0x98")]
	[Token(Token = "0x6000162")]
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	[Address(RVA = "0x31B1250", Offset = "0x31B0650", Length = "0x308")]
	[Token(Token = "0x6000167")]
	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings = null) { }

	[Address(RVA = "0x31B1000", Offset = "0x31B0400", Length = "0xBF")]
	[Token(Token = "0x6000169")]
	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[Address(RVA = "0x31B10C0", Offset = "0x31B04C0", Length = "0x182")]
	[Token(Token = "0x6000168")]
	private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[Address(RVA = "0x31B17A0", Offset = "0x31B0BA0", Length = "0x162")]
	[Token(Token = "0x6000164")]
	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x31B1560", Offset = "0x31B0960", Length = "0x172")]
	[Token(Token = "0x6000165")]
	private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[Address(RVA = "0x31B16E0", Offset = "0x31B0AE0", Length = "0xBF")]
	[Token(Token = "0x6000166")]
	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[Address(RVA = "0x31B2720", Offset = "0x31B1B20", Length = "0x40")]
	[Token(Token = "0x6000152")]
	internal void set_faceInfo(FaceInfo value) { }

	[Address(RVA = "0x31B2760", Offset = "0x31B1B60", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000158")]
	private void set_height(float value) { }

	[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
	[Token(Token = "0x600015C")]
	internal void set_spriteCharacterLookupTable(Dictionary<UInt32, SpriteCharacter> value) { }

	[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
	[Token(Token = "0x600015A")]
	internal void set_spriteCharacterTable(List<SpriteCharacter> value) { }

	[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
	[Token(Token = "0x600015E")]
	internal void set_spriteGlyphTable(List<SpriteGlyph> value) { }

	[Address(RVA = "0x31B2770", Offset = "0x31B1B70", Length = "0x83")]
	[Token(Token = "0x6000154")]
	internal void set_spriteSheet(Texture value) { }

	[Address(RVA = "0x31B2800", Offset = "0x31B1C00", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000156")]
	private void set_width(float value) { }

	[Address(RVA = "0x31B1910", Offset = "0x31B0D10", Length = "0x178")]
	[Token(Token = "0x600016B")]
	internal void SortCharacterTable() { }

	[Address(RVA = "0x31B1A90", Offset = "0x31B0E90", Length = "0x2C3")]
	[Token(Token = "0x600016C")]
	internal void SortGlyphAndCharacterTables() { }

	[Address(RVA = "0x31B1D60", Offset = "0x31B1160", Length = "0x178")]
	[Token(Token = "0x600016A")]
	public void SortGlyphTable() { }

	[Address(RVA = "0x31B1EE0", Offset = "0x31B12E0", Length = "0x65E")]
	[Token(Token = "0x6000160")]
	public void UpdateLookupTables() { }

}

