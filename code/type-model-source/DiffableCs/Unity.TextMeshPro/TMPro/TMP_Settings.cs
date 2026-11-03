namespace TMPro;

[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/Settings.html")]
[Token(Token = "0x2000086")]
public class TMP_Settings : ScriptableObject
{
	[Token(Token = "0x2000087")]
	internal class LineBreakingTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000431")]
		public HashSet<UInt32> leadingCharacters; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000432")]
		public HashSet<UInt32> followingCharacters; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600048B")]
		public LineBreakingTable() { }

	}

	[Token(Token = "0x400040B")]
	private static TMP_Settings s_Instance; //Field offset: 0x0
	[Token(Token = "0x400040D")]
	internal static string s_CurrentAssetVersion; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400040C")]
	internal string assetVersion; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_enableWordWrapping")]
	[SerializeField]
	[Token(Token = "0x400040E")]
	private TextWrappingModes m_TextWrappingMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400040F")]
	private bool m_enableKerning; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000410")]
	private List<OTL_FeatureTag> m_ActiveFontFeatures; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000411")]
	private bool m_enableExtraPadding; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	[Token(Token = "0x4000412")]
	private bool m_enableTintAllSprites; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[SerializeField]
	[Token(Token = "0x4000413")]
	private bool m_enableParseEscapeCharacters; //Field offset: 0x32
	[FieldOffset(Offset = "0x33")]
	[SerializeField]
	[Token(Token = "0x4000414")]
	private bool m_EnableRaycastTarget; //Field offset: 0x33
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000415")]
	private bool m_GetFontFeaturesAtRuntime; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000416")]
	private int m_missingGlyphCharacter; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000417")]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0x3C
	[FieldOffset(Offset = "0x3D")]
	[SerializeField]
	[Token(Token = "0x4000418")]
	private bool m_warningsDisabled; //Field offset: 0x3D
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000419")]
	private TMP_FontAsset m_defaultFontAsset; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400041A")]
	private string m_defaultFontAssetPath; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400041B")]
	private float m_defaultFontSize; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x400041C")]
	private float m_defaultAutoSizeMinRatio; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400041D")]
	private float m_defaultAutoSizeMaxRatio; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x400041E")]
	private Vector2 m_defaultTextMeshProTextContainerSize; //Field offset: 0x5C
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x400041F")]
	private Vector2 m_defaultTextMeshProUITextContainerSize; //Field offset: 0x64
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x4000420")]
	private bool m_autoSizeTextContainer; //Field offset: 0x6C
	[FieldOffset(Offset = "0x6D")]
	[SerializeField]
	[Token(Token = "0x4000421")]
	private bool m_IsTextObjectScaleStatic; //Field offset: 0x6D
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000422")]
	private List<TMP_FontAsset> m_fallbackFontAssets; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000423")]
	private bool m_matchMaterialPreset; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[SerializeField]
	[Token(Token = "0x4000424")]
	private bool m_HideSubTextObjects; //Field offset: 0x79
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000425")]
	private TMP_SpriteAsset m_defaultSpriteAsset; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000426")]
	private string m_defaultSpriteAssetPath; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000427")]
	private bool m_enableEmojiSupport; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	[Token(Token = "0x4000428")]
	private uint m_MissingCharacterSpriteUnicode; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000429")]
	private List<TMP_Asset> m_EmojiFallbackTextAssets; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x400042A")]
	private string m_defaultColorGradientPresetsPath; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x400042B")]
	private TMP_StyleSheet m_defaultStyleSheet; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x400042C")]
	private string m_StyleSheetsResourcePath; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x400042D")]
	private TextAsset m_leadingCharacters; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x400042E")]
	private TextAsset m_followingCharacters; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x400042F")]
	private LineBreakingTable m_linebreakingRules; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x4000430")]
	private bool m_UseModernHangulLineBreakingRules; //Field offset: 0xD0

	[Token(Token = "0x170000EF")]
	public static bool autoSizeTextContainer
	{
		[Address(RVA = "0x2F0F390", Offset = "0x2F0E790", Length = "0x4F")]
		[Token(Token = "0x6000467")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000E6")]
	public static bool clearDynamicDataOnBuild
	{
		[Address(RVA = "0x2F0F3E0", Offset = "0x2F0E7E0", Length = "0x4F")]
		[Token(Token = "0x600045D")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000F9")]
	public static string defaultColorGradientPresetsPath
	{
		[Address(RVA = "0x2F0F430", Offset = "0x2F0E830", Length = "0x52")]
		[Token(Token = "0x6000477")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000E8")]
	public static TMP_FontAsset defaultFontAsset
	{
		[Address(RVA = "0x2F0F4E0", Offset = "0x2F0E8E0", Length = "0x4F")]
		[Token(Token = "0x600045F")]
		 get { } //Length: 79
		[Address(RVA = "0x2F103C0", Offset = "0x2F0F7C0", Length = "0x60")]
		[Token(Token = "0x6000460")]
		 set { } //Length: 96
	}

	[Token(Token = "0x170000E9")]
	public static string defaultFontAssetPath
	{
		[Address(RVA = "0x2F0F490", Offset = "0x2F0E890", Length = "0x4F")]
		[Token(Token = "0x6000461")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000EA")]
	public static float defaultFontSize
	{
		[Address(RVA = "0x2F0F530", Offset = "0x2F0E930", Length = "0x50")]
		[Token(Token = "0x6000462")]
		 get { } //Length: 80
	}

	[Token(Token = "0x170000F4")]
	public static TMP_SpriteAsset defaultSpriteAsset
	{
		[Address(RVA = "0x2F0F5F0", Offset = "0x2F0E9F0", Length = "0x52")]
		[Token(Token = "0x600046E")]
		 get { } //Length: 82
		[Address(RVA = "0x2F10430", Offset = "0x2F0F830", Length = "0x66")]
		[Token(Token = "0x600046F")]
		 set { } //Length: 102
	}

	[Token(Token = "0x170000F5")]
	public static string defaultSpriteAssetPath
	{
		[Address(RVA = "0x2F0F590", Offset = "0x2F0E990", Length = "0x52")]
		[Token(Token = "0x6000470")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000FA")]
	public static TMP_StyleSheet defaultStyleSheet
	{
		[Address(RVA = "0x2F0F650", Offset = "0x2F0EA50", Length = "0x52")]
		[Token(Token = "0x6000478")]
		 get { } //Length: 82
		[Address(RVA = "0x2F104A0", Offset = "0x2F0F8A0", Length = "0x66")]
		[Token(Token = "0x6000479")]
		 set { } //Length: 102
	}

	[Token(Token = "0x170000EC")]
	public static float defaultTextAutoSizingMaxRatio
	{
		[Address(RVA = "0x2F0F6B0", Offset = "0x2F0EAB0", Length = "0x50")]
		[Token(Token = "0x6000464")]
		 get { } //Length: 80
	}

	[Token(Token = "0x170000EB")]
	public static float defaultTextAutoSizingMinRatio
	{
		[Address(RVA = "0x2F0F710", Offset = "0x2F0EB10", Length = "0x50")]
		[Token(Token = "0x6000463")]
		 get { } //Length: 80
	}

	[Token(Token = "0x170000ED")]
	public static Vector2 defaultTextMeshProTextContainerSize
	{
		[Address(RVA = "0x2F0F770", Offset = "0x2F0EB70", Length = "0x5D")]
		[Token(Token = "0x6000465")]
		 get { } //Length: 93
	}

	[Token(Token = "0x170000EE")]
	public static Vector2 defaultTextMeshProUITextContainerSize
	{
		[Address(RVA = "0x2F0F7D0", Offset = "0x2F0EBD0", Length = "0x5D")]
		[Token(Token = "0x6000466")]
		 get { } //Length: 93
	}

	[Token(Token = "0x170000F8")]
	public static List<TMP_Asset> emojiFallbackTextAssets
	{
		[Address(RVA = "0x2F0F830", Offset = "0x2F0EC30", Length = "0x52")]
		[Token(Token = "0x6000475")]
		 get { } //Length: 82
		[Address(RVA = "0x2F10510", Offset = "0x2F0F910", Length = "0x66")]
		[Token(Token = "0x6000476")]
		 set { } //Length: 102
	}

	[Token(Token = "0x170000F6")]
	public static bool enableEmojiSupport
	{
		[Address(RVA = "0x2F0F890", Offset = "0x2F0EC90", Length = "0x52")]
		[Token(Token = "0x6000471")]
		 get { } //Length: 82
		[Address(RVA = "0x2F10580", Offset = "0x2F0F980", Length = "0x57")]
		[Token(Token = "0x6000472")]
		 set { } //Length: 87
	}

	[Token(Token = "0x170000E0")]
	public static bool enableExtraPadding
	{
		[Address(RVA = "0x2F0F8F0", Offset = "0x2F0ECF0", Length = "0x4F")]
		[Token(Token = "0x6000456")]
		 get { } //Length: 79
	}

	[Obsolete("The \"enableKerning\" property has been deprecated. Use the \"fontFeatures\" property to control what features are enabled by default on newly created text components.")]
	[Token(Token = "0x170000DE")]
	public static bool enableKerning
	{
		[Address(RVA = "0x2F0F940", Offset = "0x2F0ED40", Length = "0xBB")]
		[Token(Token = "0x6000454")]
		 get { } //Length: 187
	}

	[Token(Token = "0x170000E2")]
	public static bool enableParseEscapeCharacters
	{
		[Address(RVA = "0x2F0FA00", Offset = "0x2F0EE00", Length = "0x4F")]
		[Token(Token = "0x6000458")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000E3")]
	public static bool enableRaycastTarget
	{
		[Address(RVA = "0x2F0FA50", Offset = "0x2F0EE50", Length = "0x4F")]
		[Token(Token = "0x6000459")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000E1")]
	public static bool enableTintAllSprites
	{
		[Address(RVA = "0x2F0FAA0", Offset = "0x2F0EEA0", Length = "0x4F")]
		[Token(Token = "0x6000457")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000F1")]
	public static List<TMP_FontAsset> fallbackFontAssets
	{
		[Address(RVA = "0x2F0FAF0", Offset = "0x2F0EEF0", Length = "0x4F")]
		[Token(Token = "0x600046A")]
		 get { } //Length: 79
		[Address(RVA = "0x2F105E0", Offset = "0x2F0F9E0", Length = "0x60")]
		[Token(Token = "0x600046B")]
		 set { } //Length: 96
	}

	[Token(Token = "0x170000FD")]
	public static TextAsset followingCharacters
	{
		[Address(RVA = "0x2F0FB40", Offset = "0x2F0EF40", Length = "0x52")]
		[Token(Token = "0x600047C")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000DF")]
	public static List<OTL_FeatureTag> fontFeatures
	{
		[Address(RVA = "0x2F0FBA0", Offset = "0x2F0EFA0", Length = "0x4F")]
		[Token(Token = "0x6000455")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000E4")]
	public static bool getFontFeaturesAtRuntime
	{
		[Address(RVA = "0x2F0FBF0", Offset = "0x2F0EFF0", Length = "0x4F")]
		[Token(Token = "0x600045A")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000F3")]
	public static bool hideSubTextObjects
	{
		[Address(RVA = "0x2F0FC40", Offset = "0x2F0F040", Length = "0x4F")]
		[Token(Token = "0x600046D")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000100")]
	public static TMP_Settings instance
	{
		[Address(RVA = "0x2F0FC90", Offset = "0x2F0F090", Length = "0x2CA")]
		[Token(Token = "0x6000480")]
		 get { } //Length: 714
	}

	[Token(Token = "0x170000F0")]
	public static bool isTextObjectScaleStatic
	{
		[Address(RVA = "0x2F0FFE0", Offset = "0x2F0F3E0", Length = "0x4F")]
		[Token(Token = "0x6000468")]
		 get { } //Length: 79
		[Address(RVA = "0x2F10650", Offset = "0x2F0FA50", Length = "0x54")]
		[Token(Token = "0x6000469")]
		 set { } //Length: 84
	}

	[Token(Token = "0x17000101")]
	internal static bool isTMPSettingsNull
	{
		[Address(RVA = "0x2F0FF60", Offset = "0x2F0F360", Length = "0x7E")]
		[Token(Token = "0x6000481")]
		internal get { } //Length: 126
	}

	[Token(Token = "0x170000FC")]
	public static TextAsset leadingCharacters
	{
		[Address(RVA = "0x2F10030", Offset = "0x2F0F430", Length = "0x52")]
		[Token(Token = "0x600047B")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000FE")]
	public static LineBreakingTable linebreakingRules
	{
		[Address(RVA = "0x2F10090", Offset = "0x2F0F490", Length = "0x99")]
		[Token(Token = "0x600047D")]
		 get { } //Length: 153
	}

	[Token(Token = "0x170000F2")]
	public static bool matchMaterialPreset
	{
		[Address(RVA = "0x2F10130", Offset = "0x2F0F530", Length = "0x4F")]
		[Token(Token = "0x600046C")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000F7")]
	public static uint missingCharacterSpriteUnicode
	{
		[Address(RVA = "0x2F10180", Offset = "0x2F0F580", Length = "0x51")]
		[Token(Token = "0x6000473")]
		 get { } //Length: 81
		[Address(RVA = "0x2F106B0", Offset = "0x2F0FAB0", Length = "0x56")]
		[Token(Token = "0x6000474")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170000E5")]
	public static int missingGlyphCharacter
	{
		[Address(RVA = "0x2F101E0", Offset = "0x2F0F5E0", Length = "0x4E")]
		[Token(Token = "0x600045B")]
		 get { } //Length: 78
		[Address(RVA = "0x2F10710", Offset = "0x2F0FB10", Length = "0x53")]
		[Token(Token = "0x600045C")]
		 set { } //Length: 83
	}

	[Token(Token = "0x170000FB")]
	public static string styleSheetsResourcePath
	{
		[Address(RVA = "0x2F10230", Offset = "0x2F0F630", Length = "0x52")]
		[Token(Token = "0x600047A")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000DD")]
	public static TextWrappingModes textWrappingMode
	{
		[Address(RVA = "0x2F10290", Offset = "0x2F0F690", Length = "0x4E")]
		[Token(Token = "0x6000453")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170000FF")]
	public static bool useModernHangulLineBreakingRules
	{
		[Address(RVA = "0x2F102E0", Offset = "0x2F0F6E0", Length = "0x52")]
		[Token(Token = "0x600047E")]
		 get { } //Length: 82
		[Address(RVA = "0x2F10770", Offset = "0x2F0FB70", Length = "0x57")]
		[Token(Token = "0x600047F")]
		 set { } //Length: 87
	}

	[Token(Token = "0x170000DC")]
	public static string version
	{
		[Address(RVA = "0x2F10340", Offset = "0x2F0F740", Length = "0x2C")]
		[Token(Token = "0x6000451")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170000E7")]
	public static bool warningsDisabled
	{
		[Address(RVA = "0x2F10370", Offset = "0x2F0F770", Length = "0x4F")]
		[Token(Token = "0x600045E")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x2F0F230", Offset = "0x2F0E630", Length = "0x67")]
	[Token(Token = "0x600048A")]
	private static TMP_Settings() { }

	[Address(RVA = "0x2F0F2A0", Offset = "0x2F0E6A0", Length = "0xEB")]
	[Token(Token = "0x6000489")]
	public TMP_Settings() { }

	[Address(RVA = "0x2F0F390", Offset = "0x2F0E790", Length = "0x4F")]
	[Token(Token = "0x6000467")]
	public static bool get_autoSizeTextContainer() { }

	[Address(RVA = "0x2F0F3E0", Offset = "0x2F0E7E0", Length = "0x4F")]
	[Token(Token = "0x600045D")]
	public static bool get_clearDynamicDataOnBuild() { }

	[Address(RVA = "0x2F0F430", Offset = "0x2F0E830", Length = "0x52")]
	[Token(Token = "0x6000477")]
	public static string get_defaultColorGradientPresetsPath() { }

	[Address(RVA = "0x2F0F4E0", Offset = "0x2F0E8E0", Length = "0x4F")]
	[Token(Token = "0x600045F")]
	public static TMP_FontAsset get_defaultFontAsset() { }

	[Address(RVA = "0x2F0F490", Offset = "0x2F0E890", Length = "0x4F")]
	[Token(Token = "0x6000461")]
	public static string get_defaultFontAssetPath() { }

	[Address(RVA = "0x2F0F530", Offset = "0x2F0E930", Length = "0x50")]
	[Token(Token = "0x6000462")]
	public static float get_defaultFontSize() { }

	[Address(RVA = "0x2F0F5F0", Offset = "0x2F0E9F0", Length = "0x52")]
	[Token(Token = "0x600046E")]
	public static TMP_SpriteAsset get_defaultSpriteAsset() { }

	[Address(RVA = "0x2F0F590", Offset = "0x2F0E990", Length = "0x52")]
	[Token(Token = "0x6000470")]
	public static string get_defaultSpriteAssetPath() { }

	[Address(RVA = "0x2F0F650", Offset = "0x2F0EA50", Length = "0x52")]
	[Token(Token = "0x6000478")]
	public static TMP_StyleSheet get_defaultStyleSheet() { }

	[Address(RVA = "0x2F0F6B0", Offset = "0x2F0EAB0", Length = "0x50")]
	[Token(Token = "0x6000464")]
	public static float get_defaultTextAutoSizingMaxRatio() { }

	[Address(RVA = "0x2F0F710", Offset = "0x2F0EB10", Length = "0x50")]
	[Token(Token = "0x6000463")]
	public static float get_defaultTextAutoSizingMinRatio() { }

	[Address(RVA = "0x2F0F770", Offset = "0x2F0EB70", Length = "0x5D")]
	[Token(Token = "0x6000465")]
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	[Address(RVA = "0x2F0F7D0", Offset = "0x2F0EBD0", Length = "0x5D")]
	[Token(Token = "0x6000466")]
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	[Address(RVA = "0x2F0F830", Offset = "0x2F0EC30", Length = "0x52")]
	[Token(Token = "0x6000475")]
	public static List<TMP_Asset> get_emojiFallbackTextAssets() { }

	[Address(RVA = "0x2F0F890", Offset = "0x2F0EC90", Length = "0x52")]
	[Token(Token = "0x6000471")]
	public static bool get_enableEmojiSupport() { }

	[Address(RVA = "0x2F0F8F0", Offset = "0x2F0ECF0", Length = "0x4F")]
	[Token(Token = "0x6000456")]
	public static bool get_enableExtraPadding() { }

	[Address(RVA = "0x2F0F940", Offset = "0x2F0ED40", Length = "0xBB")]
	[Token(Token = "0x6000454")]
	public static bool get_enableKerning() { }

	[Address(RVA = "0x2F0FA00", Offset = "0x2F0EE00", Length = "0x4F")]
	[Token(Token = "0x6000458")]
	public static bool get_enableParseEscapeCharacters() { }

	[Address(RVA = "0x2F0FA50", Offset = "0x2F0EE50", Length = "0x4F")]
	[Token(Token = "0x6000459")]
	public static bool get_enableRaycastTarget() { }

	[Address(RVA = "0x2F0FAA0", Offset = "0x2F0EEA0", Length = "0x4F")]
	[Token(Token = "0x6000457")]
	public static bool get_enableTintAllSprites() { }

	[Address(RVA = "0x2F0FAF0", Offset = "0x2F0EEF0", Length = "0x4F")]
	[Token(Token = "0x600046A")]
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	[Address(RVA = "0x2F0FB40", Offset = "0x2F0EF40", Length = "0x52")]
	[Token(Token = "0x600047C")]
	public static TextAsset get_followingCharacters() { }

	[Address(RVA = "0x2F0FBA0", Offset = "0x2F0EFA0", Length = "0x4F")]
	[Token(Token = "0x6000455")]
	public static List<OTL_FeatureTag> get_fontFeatures() { }

	[Address(RVA = "0x2F0FBF0", Offset = "0x2F0EFF0", Length = "0x4F")]
	[Token(Token = "0x600045A")]
	public static bool get_getFontFeaturesAtRuntime() { }

	[Address(RVA = "0x2F0FC40", Offset = "0x2F0F040", Length = "0x4F")]
	[Token(Token = "0x600046D")]
	public static bool get_hideSubTextObjects() { }

	[Address(RVA = "0x2F0FC90", Offset = "0x2F0F090", Length = "0x2CA")]
	[Token(Token = "0x6000480")]
	public static TMP_Settings get_instance() { }

	[Address(RVA = "0x2F0FFE0", Offset = "0x2F0F3E0", Length = "0x4F")]
	[Token(Token = "0x6000468")]
	public static bool get_isTextObjectScaleStatic() { }

	[Address(RVA = "0x2F0FF60", Offset = "0x2F0F360", Length = "0x7E")]
	[Token(Token = "0x6000481")]
	internal static bool get_isTMPSettingsNull() { }

	[Address(RVA = "0x2F10030", Offset = "0x2F0F430", Length = "0x52")]
	[Token(Token = "0x600047B")]
	public static TextAsset get_leadingCharacters() { }

	[Address(RVA = "0x2F10090", Offset = "0x2F0F490", Length = "0x99")]
	[Token(Token = "0x600047D")]
	public static LineBreakingTable get_linebreakingRules() { }

	[Address(RVA = "0x2F10130", Offset = "0x2F0F530", Length = "0x4F")]
	[Token(Token = "0x600046C")]
	public static bool get_matchMaterialPreset() { }

	[Address(RVA = "0x2F10180", Offset = "0x2F0F580", Length = "0x51")]
	[Token(Token = "0x6000473")]
	public static uint get_missingCharacterSpriteUnicode() { }

	[Address(RVA = "0x2F101E0", Offset = "0x2F0F5E0", Length = "0x4E")]
	[Token(Token = "0x600045B")]
	public static int get_missingGlyphCharacter() { }

	[Address(RVA = "0x2F10230", Offset = "0x2F0F630", Length = "0x52")]
	[Token(Token = "0x600047A")]
	public static string get_styleSheetsResourcePath() { }

	[Address(RVA = "0x2F10290", Offset = "0x2F0F690", Length = "0x4E")]
	[Token(Token = "0x6000453")]
	public static TextWrappingModes get_textWrappingMode() { }

	[Address(RVA = "0x2F102E0", Offset = "0x2F0F6E0", Length = "0x52")]
	[Token(Token = "0x600047E")]
	public static bool get_useModernHangulLineBreakingRules() { }

	[Address(RVA = "0x2F10340", Offset = "0x2F0F740", Length = "0x2C")]
	[Token(Token = "0x6000451")]
	public static string get_version() { }

	[Address(RVA = "0x2F10370", Offset = "0x2F0F770", Length = "0x4F")]
	[Token(Token = "0x600045E")]
	public static bool get_warningsDisabled() { }

	[Address(RVA = "0x2F0EB30", Offset = "0x2F0DF30", Length = "0xC7")]
	[Token(Token = "0x6000488")]
	private static HashSet<UInt32> GetCharacters(TextAsset file) { }

	[Address(RVA = "0x2F0EC00", Offset = "0x2F0E000", Length = "0xAB")]
	[Token(Token = "0x6000484")]
	public static TMP_FontAsset GetFontAsset() { }

	[Address(RVA = "0x2F0ECB0", Offset = "0x2F0E0B0", Length = "0x9C")]
	[Token(Token = "0x6000483")]
	public static TMP_Settings GetSettings() { }

	[Address(RVA = "0x2F0ED50", Offset = "0x2F0E150", Length = "0xAE")]
	[Token(Token = "0x6000485")]
	public static TMP_SpriteAsset GetSpriteAsset() { }

	[Address(RVA = "0x2F0EE00", Offset = "0x2F0E200", Length = "0xAE")]
	[Token(Token = "0x6000486")]
	public static TMP_StyleSheet GetStyleSheet() { }

	[Address(RVA = "0x2F0EEB0", Offset = "0x2F0E2B0", Length = "0x13F")]
	[Token(Token = "0x6000482")]
	public static TMP_Settings LoadDefaultSettings() { }

	[Address(RVA = "0x2F0EFF0", Offset = "0x2F0E3F0", Length = "0x1C0")]
	[Token(Token = "0x6000487")]
	public static void LoadLinebreakingRules() { }

	[Address(RVA = "0x2F103C0", Offset = "0x2F0F7C0", Length = "0x60")]
	[Token(Token = "0x6000460")]
	public static void set_defaultFontAsset(TMP_FontAsset value) { }

	[Address(RVA = "0x2F10430", Offset = "0x2F0F830", Length = "0x66")]
	[Token(Token = "0x600046F")]
	public static void set_defaultSpriteAsset(TMP_SpriteAsset value) { }

	[Address(RVA = "0x2F104A0", Offset = "0x2F0F8A0", Length = "0x66")]
	[Token(Token = "0x6000479")]
	public static void set_defaultStyleSheet(TMP_StyleSheet value) { }

	[Address(RVA = "0x2F10510", Offset = "0x2F0F910", Length = "0x66")]
	[Token(Token = "0x6000476")]
	public static void set_emojiFallbackTextAssets(List<TMP_Asset> value) { }

	[Address(RVA = "0x2F10580", Offset = "0x2F0F980", Length = "0x57")]
	[Token(Token = "0x6000472")]
	public static void set_enableEmojiSupport(bool value) { }

	[Address(RVA = "0x2F105E0", Offset = "0x2F0F9E0", Length = "0x60")]
	[Token(Token = "0x600046B")]
	public static void set_fallbackFontAssets(List<TMP_FontAsset> value) { }

	[Address(RVA = "0x2F10650", Offset = "0x2F0FA50", Length = "0x54")]
	[Token(Token = "0x6000469")]
	public static void set_isTextObjectScaleStatic(bool value) { }

	[Address(RVA = "0x2F106B0", Offset = "0x2F0FAB0", Length = "0x56")]
	[Token(Token = "0x6000474")]
	public static void set_missingCharacterSpriteUnicode(uint value) { }

	[Address(RVA = "0x2F10710", Offset = "0x2F0FB10", Length = "0x53")]
	[Token(Token = "0x600045C")]
	public static void set_missingGlyphCharacter(int value) { }

	[Address(RVA = "0x2F10770", Offset = "0x2F0FB70", Length = "0x57")]
	[Token(Token = "0x600047F")]
	public static void set_useModernHangulLineBreakingRules(bool value) { }

	[Address(RVA = "0x2F0F1C0", Offset = "0x2F0E5C0", Length = "0x61")]
	[Token(Token = "0x6000452")]
	internal void SetAssetVersion() { }

}

