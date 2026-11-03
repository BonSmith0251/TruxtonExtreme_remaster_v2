namespace TMPro;

[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/Sprites.html")]
[Token(Token = "0x200008C")]
public class TMP_SpriteAsset : TMP_Asset
{
	[CompilerGenerated]
	[Token(Token = "0x200008D")]
	private sealed class <>c
	{
		[Token(Token = "0x400049F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40004A0")]
		public static Func<TMP_SpriteGlyph, UInt32> <>9__32_0; //Field offset: 0x8
		[Token(Token = "0x40004A1")]
		public static Func<TMP_SpriteCharacter, UInt32> <>9__33_0; //Field offset: 0x10

		[Address(RVA = "0x2F192C0", Offset = "0x2F186C0", Length = "0x67")]
		[Token(Token = "0x60004BB")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004BC")]
		public <>c() { }

		[Address(RVA = "0x2ED9790", Offset = "0x2ED8B90", Length = "0x16")]
		[Token(Token = "0x60004BE")]
		internal uint <SortCharacterTable>b__33_0(TMP_SpriteCharacter c) { }

		[Address(RVA = "0x2ED9830", Offset = "0x2ED8C30", Length = "0x1F")]
		[Token(Token = "0x60004BD")]
		internal uint <SortGlyphTable>b__32_0(TMP_SpriteGlyph item) { }

	}

	[Token(Token = "0x400049E")]
	private static HashSet<Int32> k_searchedSpriteAssets; //Field offset: 0x0
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000494")]
	internal Dictionary<Int32, Int32> m_NameLookup; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000495")]
	internal Dictionary<UInt32, Int32> m_GlyphIndexLookup; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000496")]
	public Texture spriteSheet; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000497")]
	private List<TMP_SpriteCharacter> m_SpriteCharacterTable; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000498")]
	internal Dictionary<UInt32, TMP_SpriteCharacter> m_SpriteCharacterLookup; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[FormerlySerializedAs("m_SpriteGlyphTable")]
	[SerializeField]
	[Token(Token = "0x4000499")]
	private List<TMP_SpriteGlyph> m_GlyphTable; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400049A")]
	internal Dictionary<UInt32, TMP_SpriteGlyph> m_SpriteGlyphLookup; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400049B")]
	public List<TMP_Sprite> spriteInfoList; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x400049C")]
	public List<TMP_SpriteAsset> fallbackSpriteAssets; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400049D")]
	internal bool m_IsSpriteAssetLookupTablesDirty; //Field offset: 0xE0

	[Token(Token = "0x17000107")]
	public internal Dictionary<UInt32, TMP_SpriteCharacter> spriteCharacterLookupTable
	{
		[Address(RVA = "0x2F12BA0", Offset = "0x2F11FA0", Length = "0x34")]
		[Token(Token = "0x60004A6")]
		 get { } //Length: 52
		[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
		[Token(Token = "0x60004A7")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000106")]
	public internal List<TMP_SpriteCharacter> spriteCharacterTable
	{
		[Address(RVA = "0x2F12BE0", Offset = "0x2F11FE0", Length = "0x34")]
		[Token(Token = "0x60004A4")]
		 get { } //Length: 52
		[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
		[Token(Token = "0x60004A5")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000108")]
	public internal List<TMP_SpriteGlyph> spriteGlyphTable
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x60004A8")]
		 get { } //Length: 8
		[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
		[Token(Token = "0x60004A9")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x2F12AD0", Offset = "0x2F11ED0", Length = "0xC9")]
	[Token(Token = "0x60004BA")]
	public TMP_SpriteAsset() { }

	[Address(RVA = "0x2F10AE0", Offset = "0x2F0FEE0", Length = "0x7A")]
	[Token(Token = "0x60004AA")]
	private void Awake() { }

	[Address(RVA = "0x2F12BA0", Offset = "0x2F11FA0", Length = "0x34")]
	[Token(Token = "0x60004A6")]
	public Dictionary<UInt32, TMP_SpriteCharacter> get_spriteCharacterLookupTable() { }

	[Address(RVA = "0x2F12BE0", Offset = "0x2F11FE0", Length = "0x34")]
	[Token(Token = "0x60004A4")]
	public List<TMP_SpriteCharacter> get_spriteCharacterTable() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x60004A8")]
	public List<TMP_SpriteGlyph> get_spriteGlyphTable() { }

	[Address(RVA = "0x2F10B60", Offset = "0x2F0FF60", Length = "0xCF")]
	[Token(Token = "0x60004AB")]
	private Material GetDefaultSpriteMaterial() { }

	[Address(RVA = "0x2F10C30", Offset = "0x2F10030", Length = "0x86")]
	[Token(Token = "0x60004AD")]
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	[Address(RVA = "0x2F10CC0", Offset = "0x2F100C0", Length = "0x76")]
	[Token(Token = "0x60004AF")]
	public int GetSpriteIndexFromName(string name) { }

	[Address(RVA = "0x2F10D40", Offset = "0x2F10140", Length = "0x98")]
	[Token(Token = "0x60004AE")]
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	[Address(RVA = "0x2F11030", Offset = "0x2F10430", Length = "0x4BD")]
	[Token(Token = "0x60004B3")]
	public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x2F10EA0", Offset = "0x2F102A0", Length = "0x18D")]
	[Token(Token = "0x60004B4")]
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x2F10DE0", Offset = "0x2F101E0", Length = "0xB3")]
	[Token(Token = "0x60004B5")]
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x2F11740", Offset = "0x2F10B40", Length = "0x2C0")]
	[Token(Token = "0x60004B0")]
	public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x2F11680", Offset = "0x2F10A80", Length = "0xB3")]
	[Token(Token = "0x60004B2")]
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x2F114F0", Offset = "0x2F108F0", Length = "0x18D")]
	[Token(Token = "0x60004B1")]
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
	[Token(Token = "0x60004A7")]
	internal void set_spriteCharacterLookupTable(Dictionary<UInt32, TMP_SpriteCharacter> value) { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[Token(Token = "0x60004A5")]
	internal void set_spriteCharacterTable(List<TMP_SpriteCharacter> value) { }

	[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
	[Token(Token = "0x60004A9")]
	internal void set_spriteGlyphTable(List<TMP_SpriteGlyph> value) { }

	[Address(RVA = "0x2F11A10", Offset = "0x2F10E10", Length = "0x178")]
	[Token(Token = "0x60004B7")]
	internal void SortCharacterTable() { }

	[Address(RVA = "0x2F11B90", Offset = "0x2F10F90", Length = "0x2C3")]
	[Token(Token = "0x60004B8")]
	internal void SortGlyphAndCharacterTables() { }

	[Address(RVA = "0x2F11E60", Offset = "0x2F11260", Length = "0x178")]
	[Token(Token = "0x60004B6")]
	public void SortGlyphTable() { }

	[Address(RVA = "0x2F11FE0", Offset = "0x2F113E0", Length = "0x5DE")]
	[Token(Token = "0x60004AC")]
	public void UpdateLookupTables() { }

	[Address(RVA = "0x2F125C0", Offset = "0x2F119C0", Length = "0x50E")]
	[Token(Token = "0x60004B9")]
	private void UpgradeSpriteAsset() { }

}

