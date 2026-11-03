namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader("Modules/TextCoreTextEngine/Native/TextSettings.h")]
[Token(Token = "0x200003D")]
public class TextSettings : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x200003F")]
	private sealed class <>c__DisplayClass96_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001B8")]
		public List<IntPtr> globalFontAssetFallbacks; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001CA")]
		public <>c__DisplayClass96_0() { }

		[Address(RVA = "0x31C37F0", Offset = "0x31C2BF0", Length = "0x142")]
		[Token(Token = "0x60001CB")]
		internal void <GetGlobalFallbacks>b__0(FontAsset fallback) { }

		[Address(RVA = "0x31C3940", Offset = "0x31C2D40", Length = "0x147")]
		[Token(Token = "0x60001CC")]
		internal void <GetGlobalFallbacks>b__1(TextAsset fallback) { }

		[Address(RVA = "0x31C3A90", Offset = "0x31C2E90", Length = "0x142")]
		[Token(Token = "0x60001CD")]
		internal void <GetGlobalFallbacks>b__2(FontAsset fallback) { }

		[Address(RVA = "0x31C3BE0", Offset = "0x31C2FE0", Length = "0x181")]
		[Token(Token = "0x60001CE")]
		internal void <GetGlobalFallbacks>b__3(TextAsset fallback) { }

	}

	[Token(Token = "0x200003E")]
	public struct FontReferenceMap
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B6")]
		public Font font; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001B7")]
		public FontAsset fontAsset; //Field offset: 0x8

		[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
		[Token(Token = "0x60001C9")]
		public FontReferenceMap(Font font, FontAsset fontAsset) { }

	}

	[Token(Token = "0x40001A2")]
	private static List<FontAsset> s_FallbackOSFontAssetInternal; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40001AB")]
	private static SpriteAsset <s_GlobalSpriteAsset>k__BackingField; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400019E")]
	protected string m_Version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_defaultFontAsset")]
	[SerializeField]
	[Token(Token = "0x400019F")]
	protected FontAsset m_DefaultFontAsset; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_defaultFontAssetPath")]
	[SerializeField]
	[Token(Token = "0x40001A0")]
	protected string m_DefaultFontAssetPath; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_fallbackFontAssets")]
	[SerializeField]
	[Token(Token = "0x40001A1")]
	protected List<FontAsset> m_FallbackFontAssets; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_matchMaterialPreset")]
	[SerializeField]
	[Token(Token = "0x40001A3")]
	protected bool m_MatchMaterialPreset; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("m_missingGlyphCharacter")]
	[SerializeField]
	[Token(Token = "0x40001A4")]
	protected int m_MissingCharacterUnicode; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40001A5")]
	protected bool m_ClearDynamicDataOnBuild; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	[Token(Token = "0x40001A6")]
	private bool m_EnableEmojiSupport; //Field offset: 0x41
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40001A7")]
	private List<TextAsset> m_EmojiFallbackTextAssets; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("m_defaultSpriteAsset")]
	[SerializeField]
	[Token(Token = "0x40001A8")]
	protected SpriteAsset m_DefaultSpriteAsset; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[FormerlySerializedAs("m_defaultSpriteAssetPath")]
	[SerializeField]
	[Token(Token = "0x40001A9")]
	protected string m_DefaultSpriteAssetPath; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40001AA")]
	protected List<SpriteAsset> m_FallbackSpriteAssets; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40001AC")]
	protected uint m_MissingSpriteCharacterUnicode; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("m_defaultStyleSheet")]
	[SerializeField]
	[Token(Token = "0x40001AD")]
	protected TextStyleSheet m_DefaultStyleSheet; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001AE")]
	private string m_StyleSheetsResourcePath; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
	[SerializeField]
	[Token(Token = "0x40001AF")]
	protected string m_DefaultColorGradientPresetsPath; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40001B0")]
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[FormerlySerializedAs("m_warningsDisabled")]
	[SerializeField]
	[Token(Token = "0x40001B1")]
	protected bool m_DisplayWarnings; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40001B2")]
	internal Dictionary<Int32, FontAsset> m_FontLookup; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40001B3")]
	internal List<FontReferenceMap> m_FontReferences; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40001B4")]
	private IntPtr m_NativeTextSettings; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40001B5")]
	private bool m_IsNativeTextSettingsDirty; //Field offset: 0xB0

	[Token(Token = "0x17000048")]
	public bool clearDynamicDataOnBuild
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x60001A0")]
		 get { } //Length: 5
		[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
		[Token(Token = "0x60001A1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000052")]
	public string defaultColorGradientPresetsPath
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x60001B4")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[Token(Token = "0x60001B5")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000042")]
	public FontAsset defaultFontAsset
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000192")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000193")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000043")]
	public string defaultFontAssetPath
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000194")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000195")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004B")]
	public SpriteAsset defaultSpriteAsset
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60001A6")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60001A7")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004C")]
	public string defaultSpriteAssetPath
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x60001A9")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000050")]
	public TextStyleSheet defaultStyleSheet
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x60001B0")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x60001B1")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000054")]
	public bool displayWarnings
	{
		[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
		[Token(Token = "0x60001B8")]
		 get { } //Length: 8
		[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
		[Token(Token = "0x60001B9")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700004A")]
	public List<TextAsset> emojiFallbackTextAssets
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60001A4")]
		 get { } //Length: 5
		[Address(RVA = "0x31C2E50", Offset = "0x31C2250", Length = "0x23")]
		[Token(Token = "0x60001A5")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000049")]
	public bool enableEmojiSupport
	{
		[Address(RVA = "0x31C2CA0", Offset = "0x31C20A0", Length = "0x7")]
		[Token(Token = "0x60001A2")]
		 get { } //Length: 7
		[Address(RVA = "0x1DDDAB0", Offset = "0x1DDCEB0", Length = "0x4")]
		[Token(Token = "0x60001A3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000044")]
	public List<FontAsset> fallbackFontAssets
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000196")]
		 get { } //Length: 5
		[Address(RVA = "0x31C2E80", Offset = "0x31C2280", Length = "0x23")]
		[Token(Token = "0x6000197")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000045")]
	internal List<FontAsset> fallbackOSFontAssets
	{
		[Address(RVA = "0x31C2CB0", Offset = "0x31C20B0", Length = "0xAB")]
		[Token(Token = "0x6000198")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 171
	}

	[Obsolete("The Fallback Sprite Assets list is now obsolete. Use the emojiFallbackTextAssets instead.", True)]
	[Token(Token = "0x1700004D")]
	public List<SpriteAsset> fallbackSpriteAssets
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60001AA")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x60001AB")]
		 set { } //Length: 995
	}

	[Token(Token = "0x17000053")]
	public UnicodeLineBreakingRules lineBreakingRules
	{
		[Address(RVA = "0x31C2D60", Offset = "0x31C2160", Length = "0x8D")]
		[Token(Token = "0x60001B6")]
		 get { } //Length: 141
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[Token(Token = "0x60001B7")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000046")]
	public bool matchMaterialPreset
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x600019C")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[Token(Token = "0x600019D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000047")]
	public int missingCharacterUnicode
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x600019E")]
		 get { } //Length: 4
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[Token(Token = "0x600019F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700004F")]
	public uint missingSpriteCharacterUnicode
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[Token(Token = "0x60001AE")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
		[Token(Token = "0x60001AF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000055")]
	internal IntPtr nativeTextSettings
	{
		[Address(RVA = "0x31C2DF0", Offset = "0x31C21F0", Length = "0x1D")]
		[Token(Token = "0x60001C2")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 29
	}

	[Token(Token = "0x1700004E")]
	internal static SpriteAsset s_GlobalSpriteAsset
	{
		[Address(RVA = "0x31C2E10", Offset = "0x31C2210", Length = "0x37")]
		[CompilerGenerated]
		[Token(Token = "0x60001AD")]
		internal get { } //Length: 55
		[Address(RVA = "0x31C2EB0", Offset = "0x31C22B0", Length = "0x56")]
		[CompilerGenerated]
		[Token(Token = "0x60001AC")]
		private set { } //Length: 86
	}

	[Obsolete("styleSheetsResourcePath is no longer used and will be removed in a future version.", False)]
	[Token(Token = "0x17000051")]
	public string styleSheetsResourcePath
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x60001B2")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[Token(Token = "0x60001B3")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000041")]
	public internal string version
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000190")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000191")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x31C2B60", Offset = "0x31C1F60", Length = "0x13C")]
	[Token(Token = "0x60001C6")]
	public TextSettings() { }

	[Address(RVA = "0x31C1C10", Offset = "0x31C1010", Length = "0xCB")]
	[NativeMethod(Name = "TextSettings::Create")]
	[Token(Token = "0x60001BF")]
	private static IntPtr CreateNativeObject(IntPtr[] fallbacks, IntPtr managedObject) { }

	[Address(RVA = "0x31C1BC0", Offset = "0x31C0FC0", Length = "0x42")]
	[Token(Token = "0x60001C7")]
	private static IntPtr CreateNativeObject_Injected(ref ManagedSpanWrapper fallbacks, IntPtr managedObject) { }

	[Address(RVA = "0x31C1CE0", Offset = "0x31C10E0", Length = "0x42")]
	[NativeMethod(Name = "TextSettings::Destroy")]
	[Token(Token = "0x60001C0")]
	private static void DestroyNativeObject(IntPtr m_NativeTextSettings, IntPtr managedObject) { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x60001A0")]
	public bool get_clearDynamicDataOnBuild() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x60001B4")]
	public string get_defaultColorGradientPresetsPath() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000192")]
	public FontAsset get_defaultFontAsset() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000194")]
	public string get_defaultFontAssetPath() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60001A6")]
	public SpriteAsset get_defaultSpriteAsset() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60001A8")]
	public string get_defaultSpriteAssetPath() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x60001B0")]
	public TextStyleSheet get_defaultStyleSheet() { }

	[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
	[Token(Token = "0x60001B8")]
	public bool get_displayWarnings() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60001A4")]
	public List<TextAsset> get_emojiFallbackTextAssets() { }

	[Address(RVA = "0x31C2CA0", Offset = "0x31C20A0", Length = "0x7")]
	[Token(Token = "0x60001A2")]
	public bool get_enableEmojiSupport() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000196")]
	public List<FontAsset> get_fallbackFontAssets() { }

	[Address(RVA = "0x31C2CB0", Offset = "0x31C20B0", Length = "0xAB")]
	[Token(Token = "0x6000198")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal List<FontAsset> get_fallbackOSFontAssets() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60001AA")]
	public List<SpriteAsset> get_fallbackSpriteAssets() { }

	[Address(RVA = "0x31C2D60", Offset = "0x31C2160", Length = "0x8D")]
	[Token(Token = "0x60001B6")]
	public UnicodeLineBreakingRules get_lineBreakingRules() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x600019C")]
	public bool get_matchMaterialPreset() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x600019E")]
	public int get_missingCharacterUnicode() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[Token(Token = "0x60001AE")]
	public uint get_missingSpriteCharacterUnicode() { }

	[Address(RVA = "0x31C2DF0", Offset = "0x31C21F0", Length = "0x1D")]
	[Token(Token = "0x60001C2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal IntPtr get_nativeTextSettings() { }

	[Address(RVA = "0x31C2E10", Offset = "0x31C2210", Length = "0x37")]
	[CompilerGenerated]
	[Token(Token = "0x60001AD")]
	internal static SpriteAsset get_s_GlobalSpriteAsset() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x60001B2")]
	public string get_styleSheetsResourcePath() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000190")]
	public string get_version() { }

	[Address(RVA = "0x31C1D30", Offset = "0x31C1130", Length = "0x2BB")]
	[Token(Token = "0x60001BD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal FontAsset GetCachedFontAsset(Font font) { }

	[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
	[Token(Token = "0x600019B")]
	internal override List<FontAsset> GetFallbackFontAssets(bool isRaster, int textPixelSize = -1) { }

	[Address(RVA = "0x31C1FF0", Offset = "0x31C13F0", Length = "0x2C9")]
	[Token(Token = "0x60001C3")]
	private IntPtr[] GetGlobalFallbacks() { }

	[Address(RVA = "0x31C22C0", Offset = "0x31C16C0", Length = "0x56")]
	[Token(Token = "0x60001BE")]
	private List<FontAsset> GetOSFontAssetList() { }

	[Address(RVA = "0x31C2320", Offset = "0x31C1720", Length = "0x36")]
	[Token(Token = "0x6000199")]
	internal override List<FontAsset> GetStaticFallbackOSFontAsset() { }

	[Address(RVA = "0x31C2360", Offset = "0x31C1760", Length = "0x248")]
	[Token(Token = "0x60001BC")]
	protected void InitializeFontReferenceLookup() { }

	[Address(RVA = "0x31C25B0", Offset = "0x31C19B0", Length = "0x71")]
	[Token(Token = "0x60001BB")]
	private void OnDestroy() { }

	[Address(RVA = "0x31C2630", Offset = "0x31C1A30", Length = "0x19F")]
	[Token(Token = "0x60001BA")]
	private void OnEnable() { }

	[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
	[Token(Token = "0x60001A1")]
	public void set_clearDynamicDataOnBuild(bool value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x60001B5")]
	public void set_defaultColorGradientPresetsPath(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000193")]
	public void set_defaultFontAsset(FontAsset value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000195")]
	public void set_defaultFontAssetPath(string value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60001A7")]
	public void set_defaultSpriteAsset(SpriteAsset value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x60001A9")]
	public void set_defaultSpriteAssetPath(string value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x60001B1")]
	public void set_defaultStyleSheet(TextStyleSheet value) { }

	[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
	[Token(Token = "0x60001B9")]
	public void set_displayWarnings(bool value) { }

	[Address(RVA = "0x31C2E50", Offset = "0x31C2250", Length = "0x23")]
	[Token(Token = "0x60001A5")]
	public void set_emojiFallbackTextAssets(List<TextAsset> value) { }

	[Address(RVA = "0x1DDDAB0", Offset = "0x1DDCEB0", Length = "0x4")]
	[Token(Token = "0x60001A3")]
	public void set_enableEmojiSupport(bool value) { }

	[Address(RVA = "0x31C2E80", Offset = "0x31C2280", Length = "0x23")]
	[Token(Token = "0x6000197")]
	public void set_fallbackFontAssets(List<FontAsset> value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x60001AB")]
	public void set_fallbackSpriteAssets(List<SpriteAsset> value) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[Token(Token = "0x60001B7")]
	public void set_lineBreakingRules(UnicodeLineBreakingRules value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[Token(Token = "0x600019D")]
	public void set_matchMaterialPreset(bool value) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[Token(Token = "0x600019F")]
	public void set_missingCharacterUnicode(int value) { }

	[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
	[Token(Token = "0x60001AF")]
	public void set_missingSpriteCharacterUnicode(uint value) { }

	[Address(RVA = "0x31C2EB0", Offset = "0x31C22B0", Length = "0x56")]
	[CompilerGenerated]
	[Token(Token = "0x60001AC")]
	private static void set_s_GlobalSpriteAsset(SpriteAsset value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[Token(Token = "0x60001B3")]
	public void set_styleSheetsResourcePath(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000191")]
	internal void set_version(string value) { }

	[Address(RVA = "0x31C27D0", Offset = "0x31C1BD0", Length = "0x8")]
	[Token(Token = "0x60001C4")]
	internal void SetNativeTextSettingsDirty() { }

	[Address(RVA = "0x31C27E0", Offset = "0x31C1BE0", Length = "0x51")]
	[Token(Token = "0x600019A")]
	internal override void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

	[Address(RVA = "0x31C2890", Offset = "0x31C1C90", Length = "0xCB")]
	[Token(Token = "0x60001C1")]
	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	[Address(RVA = "0x31C2840", Offset = "0x31C1C40", Length = "0x42")]
	[Token(Token = "0x60001C8")]
	private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks) { }

	[Address(RVA = "0x31C2960", Offset = "0x31C1D60", Length = "0x1F2")]
	[Token(Token = "0x60001C5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void UpdateNativeTextSettings() { }

}

