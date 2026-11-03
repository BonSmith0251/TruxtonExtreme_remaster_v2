namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[NativeHeader("IMGUIScriptingClasses.h")]
[RequiredByNativeCode]
[Token(Token = "0x200001A")]
public sealed class GUIStyle
{
	[Token(Token = "0x200001B")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000170")]
		public static IntPtr ConvertToNative(GUIStyle guiStyle) { }

	}

	[Token(Token = "0x40000AD")]
	internal static bool showKeyboardFocus; //Field offset: 0x0
	[Token(Token = "0x40000AE")]
	private static GUIStyle s_None; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009F")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A0")]
	private GUIStyleState m_Normal; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A1")]
	private GUIStyleState m_Hover; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A2")]
	private GUIStyleState m_Active; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000A3")]
	private GUIStyleState m_Focused; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000A4")]
	private GUIStyleState m_OnNormal; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000A5")]
	private GUIStyleState m_OnHover; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000A6")]
	private GUIStyleState m_OnActive; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000A7")]
	private GUIStyleState m_OnFocused; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000A8")]
	private RectOffset m_Border; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000A9")]
	private RectOffset m_Padding; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000AA")]
	private RectOffset m_Margin; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000AB")]
	private RectOffset m_Overflow; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000AC")]
	private string m_Name; //Field offset: 0x78

	[NativeProperty("m_Alignment", False, TargetType::Field (1))]
	[Token(Token = "0x17000052")]
	public TextAnchor alignment
	{
		[Address(RVA = "0x30ED330", Offset = "0x30EC730", Length = "0x8B")]
		[Token(Token = "0x600011E")]
		 get { } //Length: 139
		[Address(RVA = "0x30EE5C0", Offset = "0x30ED9C0", Length = "0x98")]
		[Token(Token = "0x600011F")]
		 set { } //Length: 152
	}

	[NativeProperty("m_Clipping", False, TargetType::Field (1))]
	[Token(Token = "0x17000054")]
	public TextClipping clipping
	{
		[Address(RVA = "0x30ED400", Offset = "0x30EC800", Length = "0x8B")]
		[Token(Token = "0x6000121")]
		 get { } //Length: 139
	}

	[NativeProperty("m_FixedHeight", False, TargetType::Field (1))]
	[Token(Token = "0x17000056")]
	public float fixedHeight
	{
		[Address(RVA = "0x30ED4D0", Offset = "0x30EC8D0", Length = "0x8B")]
		[Token(Token = "0x6000123")]
		 get { } //Length: 139
	}

	[NativeProperty("m_FixedWidth", False, TargetType::Field (1))]
	[Token(Token = "0x17000055")]
	public float fixedWidth
	{
		[Address(RVA = "0x30ED5A0", Offset = "0x30EC9A0", Length = "0x8B")]
		[Token(Token = "0x6000122")]
		 get { } //Length: 139
	}

	[NativeProperty("Font", False, TargetType::Function (0))]
	[Token(Token = "0x17000050")]
	public Font font
	{
		[Address(RVA = "0x30ED810", Offset = "0x30ECC10", Length = "0xA5")]
		[Token(Token = "0x600011C")]
		 get { } //Length: 165
	}

	[NativeProperty("m_FontSize", False, TargetType::Field (1))]
	[Token(Token = "0x17000059")]
	public int fontSize
	{
		[Address(RVA = "0x30ED670", Offset = "0x30ECA70", Length = "0x8B")]
		[Token(Token = "0x6000127")]
		 get { } //Length: 139
	}

	[NativeProperty("m_FontStyle", False, TargetType::Field (1))]
	[Token(Token = "0x1700005A")]
	public FontStyle fontStyle
	{
		[Address(RVA = "0x30ED740", Offset = "0x30ECB40", Length = "0x8B")]
		[Token(Token = "0x6000128")]
		 get { } //Length: 139
	}

	[NativeProperty("m_ImagePosition", False, TargetType::Field (1))]
	[Token(Token = "0x17000051")]
	public ImagePosition imagePosition
	{
		[Address(RVA = "0x30ED900", Offset = "0x30ECD00", Length = "0x8B")]
		[Token(Token = "0x600011D")]
		 get { } //Length: 139
	}

	[NativeProperty("m_ClipOffset", False, TargetType::Field (1))]
	[Token(Token = "0x1700005C")]
	internal Vector2 Internal_clipOffset
	{
		[Address(RVA = "0x30ED250", Offset = "0x30EC650", Length = "0x9C")]
		[Token(Token = "0x600012A")]
		internal get { } //Length: 156
	}

	[Token(Token = "0x17000063")]
	public bool isHeightDependantOnWidth
	{
		[Address(RVA = "0x30ED990", Offset = "0x30ECD90", Length = "0x18D")]
		[Token(Token = "0x600014B")]
		 get { } //Length: 397
	}

	[Token(Token = "0x17000061")]
	public float lineHeight
	{
		[Address(RVA = "0x30EDB20", Offset = "0x30ECF20", Length = "0x1CA")]
		[Token(Token = "0x6000141")]
		 get { } //Length: 458
	}

	[Token(Token = "0x1700005F")]
	public RectOffset margin
	{
		[Address(RVA = "0x30EDCF0", Offset = "0x30ED0F0", Length = "0xEE")]
		[Token(Token = "0x600013F")]
		 get { } //Length: 238
	}

	[Token(Token = "0x1700005D")]
	public string name
	{
		[Address(RVA = "0x30EDDE0", Offset = "0x30ED1E0", Length = "0x3F")]
		[Token(Token = "0x600013C")]
		 get { } //Length: 63
		[Address(RVA = "0x30EE660", Offset = "0x30EDA60", Length = "0x35")]
		[Token(Token = "0x600013D")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000062")]
	public static GUIStyle none
	{
		[Address(RVA = "0x30EDE20", Offset = "0x30ED220", Length = "0xB1")]
		[Token(Token = "0x6000146")]
		 get { } //Length: 177
	}

	[Token(Token = "0x1700005E")]
	public GUIStyleState normal
	{
		[Address(RVA = "0x30EDEE0", Offset = "0x30ED2E0", Length = "0xF8")]
		[Token(Token = "0x600013E")]
		 get { } //Length: 248
	}

	[Token(Token = "0x17000060")]
	public RectOffset padding
	{
		[Address(RVA = "0x30EDFE0", Offset = "0x30ED3E0", Length = "0xEE")]
		[Token(Token = "0x6000140")]
		 get { } //Length: 238
	}

	[NativeProperty("Name", False, TargetType::Function (0))]
	[Token(Token = "0x1700004F")]
	internal string rawName
	{
		[Address(RVA = "0x30EE120", Offset = "0x30ED520", Length = "0x11B")]
		[Token(Token = "0x600011A")]
		internal get { } //Length: 283
		[Address(RVA = "0x30EE6F0", Offset = "0x30EDAF0", Length = "0x1DC")]
		[Token(Token = "0x600011B")]
		internal set { } //Length: 476
	}

	[NativeProperty("m_RichText", False, TargetType::Field (1))]
	[Token(Token = "0x1700005B")]
	public bool richText
	{
		[Address(RVA = "0x30EE280", Offset = "0x30ED680", Length = "0x8B")]
		[Token(Token = "0x6000129")]
		 get { } //Length: 139
	}

	[NativeProperty("m_StretchHeight", False, TargetType::Field (1))]
	[Token(Token = "0x17000058")]
	public bool stretchHeight
	{
		[Address(RVA = "0x30EE350", Offset = "0x30ED750", Length = "0x8B")]
		[Token(Token = "0x6000125")]
		 get { } //Length: 139
		[Address(RVA = "0x30EE920", Offset = "0x30EDD20", Length = "0x9B")]
		[Token(Token = "0x6000126")]
		 set { } //Length: 155
	}

	[NativeProperty("m_StretchWidth", False, TargetType::Field (1))]
	[Token(Token = "0x17000057")]
	public bool stretchWidth
	{
		[Address(RVA = "0x30EE420", Offset = "0x30ED820", Length = "0x8B")]
		[Token(Token = "0x6000124")]
		 get { } //Length: 139
	}

	[NativeProperty("m_WordWrap", False, TargetType::Field (1))]
	[Token(Token = "0x17000053")]
	public bool wordWrap
	{
		[Address(RVA = "0x30EE4F0", Offset = "0x30ED8F0", Length = "0x8B")]
		[Token(Token = "0x6000120")]
		 get { } //Length: 139
	}

	[Address(RVA = "0x30ED140", Offset = "0x30EC540", Length = "0x36")]
	[Token(Token = "0x6000152")]
	private static GUIStyle() { }

	[Address(RVA = "0x30ED180", Offset = "0x30EC580", Length = "0x72")]
	[Token(Token = "0x600013A")]
	public GUIStyle() { }

	[Address(RVA = "0x30EAD00", Offset = "0x30EA100", Length = "0xAA")]
	[Token(Token = "0x6000149")]
	public float CalcHeight(GUIContent content, float width) { }

	[Address(RVA = "0x30EADB0", Offset = "0x30EA1B0", Length = "0xCB")]
	[Token(Token = "0x600014C")]
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	[Address(RVA = "0x30EAE80", Offset = "0x30EA280", Length = "0xE7")]
	[Token(Token = "0x6000148")]
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	[Address(RVA = "0x30EB230", Offset = "0x30EA630", Length = "0x210")]
	[Token(Token = "0x6000144")]
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	[Address(RVA = "0x30EB1F0", Offset = "0x30EA5F0", Length = "0x34")]
	[Token(Token = "0x6000143")]
	public void Draw(Rect position, GUIContent content, int controlID) { }

	[Address(RVA = "0x30EB100", Offset = "0x30EA500", Length = "0xE1")]
	[Token(Token = "0x6000142")]
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[Address(RVA = "0x30EAF70", Offset = "0x30EA370", Length = "0x182")]
	[Token(Token = "0x6000145")]
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[Address(RVA = "0x30EB450", Offset = "0x30EA850", Length = "0xCC")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000151")]
	internal static void EmptyManagedCache() { }

	[Address(RVA = "0x30EB520", Offset = "0x30EA920", Length = "0xBE")]
	[Token(Token = "0x600013B")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x30ED330", Offset = "0x30EC730", Length = "0x8B")]
	[Token(Token = "0x600011E")]
	public TextAnchor get_alignment() { }

	[Address(RVA = "0x30ED2F0", Offset = "0x30EC6F0", Length = "0x33")]
	[Token(Token = "0x6000157")]
	private static TextAnchor get_alignment_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30ED400", Offset = "0x30EC800", Length = "0x8B")]
	[Token(Token = "0x6000121")]
	public TextClipping get_clipping() { }

	[Address(RVA = "0x30ED3C0", Offset = "0x30EC7C0", Length = "0x33")]
	[Token(Token = "0x600015A")]
	private static TextClipping get_clipping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30ED4D0", Offset = "0x30EC8D0", Length = "0x8B")]
	[Token(Token = "0x6000123")]
	public float get_fixedHeight() { }

	[Address(RVA = "0x30ED490", Offset = "0x30EC890", Length = "0x33")]
	[Token(Token = "0x600015C")]
	private static float get_fixedHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30ED5A0", Offset = "0x30EC9A0", Length = "0x8B")]
	[Token(Token = "0x6000122")]
	public float get_fixedWidth() { }

	[Address(RVA = "0x30ED560", Offset = "0x30EC960", Length = "0x33")]
	[Token(Token = "0x600015B")]
	private static float get_fixedWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30ED810", Offset = "0x30ECC10", Length = "0xA5")]
	[Token(Token = "0x600011C")]
	public Font get_font() { }

	[Address(RVA = "0x30ED7D0", Offset = "0x30ECBD0", Length = "0x33")]
	[Token(Token = "0x6000155")]
	private static IntPtr get_font_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30ED670", Offset = "0x30ECA70", Length = "0x8B")]
	[Token(Token = "0x6000127")]
	public int get_fontSize() { }

	[Address(RVA = "0x30ED630", Offset = "0x30ECA30", Length = "0x33")]
	[Token(Token = "0x6000160")]
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30ED740", Offset = "0x30ECB40", Length = "0x8B")]
	[Token(Token = "0x6000128")]
	public FontStyle get_fontStyle() { }

	[Address(RVA = "0x30ED700", Offset = "0x30ECB00", Length = "0x33")]
	[Token(Token = "0x6000161")]
	private static FontStyle get_fontStyle_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30ED900", Offset = "0x30ECD00", Length = "0x8B")]
	[Token(Token = "0x600011D")]
	public ImagePosition get_imagePosition() { }

	[Address(RVA = "0x30ED8C0", Offset = "0x30ECCC0", Length = "0x33")]
	[Token(Token = "0x6000156")]
	private static ImagePosition get_imagePosition_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30ED250", Offset = "0x30EC650", Length = "0x9C")]
	[Token(Token = "0x600012A")]
	internal Vector2 get_Internal_clipOffset() { }

	[Address(RVA = "0x30ED200", Offset = "0x30EC600", Length = "0x42")]
	[Token(Token = "0x6000163")]
	private static void get_Internal_clipOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x30ED990", Offset = "0x30ECD90", Length = "0x18D")]
	[Token(Token = "0x600014B")]
	public bool get_isHeightDependantOnWidth() { }

	[Address(RVA = "0x30EDB20", Offset = "0x30ECF20", Length = "0x1CA")]
	[Token(Token = "0x6000141")]
	public float get_lineHeight() { }

	[Address(RVA = "0x30EDCF0", Offset = "0x30ED0F0", Length = "0xEE")]
	[Token(Token = "0x600013F")]
	public RectOffset get_margin() { }

	[Address(RVA = "0x30EDDE0", Offset = "0x30ED1E0", Length = "0x3F")]
	[Token(Token = "0x600013C")]
	public string get_name() { }

	[Address(RVA = "0x30EDE20", Offset = "0x30ED220", Length = "0xB1")]
	[Token(Token = "0x6000146")]
	public static GUIStyle get_none() { }

	[Address(RVA = "0x30EDEE0", Offset = "0x30ED2E0", Length = "0xF8")]
	[Token(Token = "0x600013E")]
	public GUIStyleState get_normal() { }

	[Address(RVA = "0x30EDFE0", Offset = "0x30ED3E0", Length = "0xEE")]
	[Token(Token = "0x6000140")]
	public RectOffset get_padding() { }

	[Address(RVA = "0x30EE120", Offset = "0x30ED520", Length = "0x11B")]
	[Token(Token = "0x600011A")]
	internal string get_rawName() { }

	[Address(RVA = "0x30EE0D0", Offset = "0x30ED4D0", Length = "0x42")]
	[Token(Token = "0x6000153")]
	private static void get_rawName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x30EE280", Offset = "0x30ED680", Length = "0x8B")]
	[Token(Token = "0x6000129")]
	public bool get_richText() { }

	[Address(RVA = "0x30EE240", Offset = "0x30ED640", Length = "0x33")]
	[Token(Token = "0x6000162")]
	private static bool get_richText_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30EE350", Offset = "0x30ED750", Length = "0x8B")]
	[Token(Token = "0x6000125")]
	public bool get_stretchHeight() { }

	[Address(RVA = "0x30EE310", Offset = "0x30ED710", Length = "0x33")]
	[Token(Token = "0x600015E")]
	private static bool get_stretchHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30EE420", Offset = "0x30ED820", Length = "0x8B")]
	[Token(Token = "0x6000124")]
	public bool get_stretchWidth() { }

	[Address(RVA = "0x30EE3E0", Offset = "0x30ED7E0", Length = "0x33")]
	[Token(Token = "0x600015D")]
	private static bool get_stretchWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30EE4F0", Offset = "0x30ED8F0", Length = "0x8B")]
	[Token(Token = "0x6000120")]
	public bool get_wordWrap() { }

	[Address(RVA = "0x30EE4B0", Offset = "0x30ED8B0", Length = "0x33")]
	[Token(Token = "0x6000159")]
	private static bool get_wordWrap_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30EB5E0", Offset = "0x30EA9E0", Length = "0x565")]
	[Token(Token = "0x6000147")]
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[Address(RVA = "0x30EBB80", Offset = "0x30EAF80", Length = "0x75")]
	[FreeFunction(Name = "GUIStyle::GetDefaultFont")]
	[Token(Token = "0x6000138")]
	internal static Font GetDefaultFont() { }

	[Address(RVA = "0x30EBB50", Offset = "0x30EAF50", Length = "0x2A")]
	[Token(Token = "0x600016F")]
	private static IntPtr GetDefaultFont_Injected() { }

	[Address(RVA = "0x30EBC00", Offset = "0x30EB000", Length = "0x115")]
	[RequiredByNativeCode]
	[Token(Token = "0x600014F")]
	internal static void GetDimensions(GUIStyle style, Color color, string content, Rect rect, ref Vector2 dimensions) { }

	[Address(RVA = "0x30EBD20", Offset = "0x30EB120", Length = "0x24")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000150")]
	internal static void GetLineHeight(GUIStyle style, ref float lineHeight) { }

	[Address(RVA = "0x30EBD50", Offset = "0x30EB150", Length = "0x4B8")]
	[RequiredByNativeCode]
	[Token(Token = "0x600014E")]
	internal static void GetMeshInfo(GUIStyle style, Color color, string content, Rect rect, ref MeshInfoBindings[] meshInfos, ref Vector2 dimensions, ref int generationId) { }

	[Address(RVA = "0x30EC210", Offset = "0x30EB610", Length = "0xE7")]
	[Token(Token = "0x600014A")]
	internal Vector2 GetPreferredSize(string content, Rect rect) { }

	[Address(RVA = "0x30EC340", Offset = "0x30EB740", Length = "0x98")]
	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	[Token(Token = "0x600012E")]
	private IntPtr GetRectOffsetPtr(int idx) { }

	[Address(RVA = "0x30EC300", Offset = "0x30EB700", Length = "0x40")]
	[Token(Token = "0x6000165")]
	private static IntPtr GetRectOffsetPtr_Injected(IntPtr _unity_self, int idx) { }

	[Address(RVA = "0x30EC420", Offset = "0x30EB820", Length = "0x98")]
	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x600012D")]
	private IntPtr GetStyleStatePtr(int idx) { }

	[Address(RVA = "0x30EC3E0", Offset = "0x30EB7E0", Length = "0x40")]
	[Token(Token = "0x6000164")]
	private static IntPtr GetStyleStatePtr_Injected(IntPtr _unity_self, int idx) { }

	[Address(RVA = "0x30EAD00", Offset = "0x30EA100", Length = "0xAA")]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = True)]
	[Token(Token = "0x6000132")]
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[Address(RVA = "0x30EC4C0", Offset = "0x30EB8C0", Length = "0x52")]
	[Token(Token = "0x6000169")]
	private static float Internal_CalcHeight_Injected(IntPtr _unity_self, GUIContent content, float width) { }

	[Address(RVA = "0x30EC580", Offset = "0x30EB980", Length = "0xAB")]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = True)]
	[Token(Token = "0x6000133")]
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[Address(RVA = "0x30EC520", Offset = "0x30EB920", Length = "0x52")]
	[Token(Token = "0x600016A")]
	private static void Internal_CalcMinMaxWidth_Injected(IntPtr _unity_self, GUIContent content, out Vector2 ret) { }

	[Address(RVA = "0x30EC6A0", Offset = "0x30EBAA0", Length = "0xB5")]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = True)]
	[Token(Token = "0x6000131")]
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[Address(RVA = "0x30EC630", Offset = "0x30EBA30", Length = "0x62")]
	[Token(Token = "0x6000168")]
	private static void Internal_CalcSizeWithConstraints_Injected(IntPtr _unity_self, GUIContent content, in Vector2 maxSize, out Vector2 ret) { }

	[Address(RVA = "0x30EC760", Offset = "0x30EBB60", Length = "0x33")]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	[Token(Token = "0x600012B")]
	private static IntPtr Internal_Create(GUIStyle self) { }

	[Address(RVA = "0x30EC7E0", Offset = "0x30EBBE0", Length = "0x33")]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	[Token(Token = "0x600012C")]
	private static void Internal_Destroy(IntPtr self) { }

	[Address(RVA = "0x30EC7A0", Offset = "0x30EBBA0", Length = "0x31")]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DestroyTextGenerator")]
	[Token(Token = "0x6000139")]
	internal static void Internal_DestroyTextGenerator(int meshInfoId) { }

	[Address(RVA = "0x30EC9F0", Offset = "0x30EBDF0", Length = "0xE0")]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	[Token(Token = "0x600012F")]
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[Address(RVA = "0x30EC960", Offset = "0x30EBD60", Length = "0x87")]
	[Token(Token = "0x6000166")]
	private static void Internal_Draw_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[Address(RVA = "0x30EC890", Offset = "0x30EBC90", Length = "0xC5")]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	[Token(Token = "0x6000130")]
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[Address(RVA = "0x30EC820", Offset = "0x30EBC20", Length = "0x6D")]
	[Token(Token = "0x6000167")]
	private static void Internal_Draw2_Injected(IntPtr _unity_self, in Rect position, GUIContent content, int controlID, bool on) { }

	[Address(RVA = "0x30ECB50", Offset = "0x30EBF50", Length = "0xBB")]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetTextRectOffset", HasExplicitThis = True)]
	[Token(Token = "0x6000134")]
	internal Vector2 Internal_GetTextRectOffset(Rect screenRect, GUIContent content, Vector2 textSize) { }

	[Address(RVA = "0x30ECAE0", Offset = "0x30EBEE0", Length = "0x62")]
	[Token(Token = "0x600016B")]
	private static void Internal_GetTextRectOffset_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, in Vector2 textSize, out Vector2 ret) { }

	[Address(RVA = "0x30ECC50", Offset = "0x30EC050", Length = "0x1AE")]
	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	[Token(Token = "0x6000136")]
	internal static bool IsTooltipActive(string tooltip) { }

	[Address(RVA = "0x30ECC10", Offset = "0x30EC010", Length = "0x33")]
	[Token(Token = "0x600016D")]
	private static bool IsTooltipActive_Injected(ref ManagedSpanWrapper tooltip) { }

	[Address(RVA = "0x30EE5C0", Offset = "0x30ED9C0", Length = "0x98")]
	[Token(Token = "0x600011F")]
	public void set_alignment(TextAnchor value) { }

	[Address(RVA = "0x30EE580", Offset = "0x30ED980", Length = "0x40")]
	[Token(Token = "0x6000158")]
	private static void set_alignment_Injected(IntPtr _unity_self, TextAnchor value) { }

	[Address(RVA = "0x30EE660", Offset = "0x30EDA60", Length = "0x35")]
	[Token(Token = "0x600013D")]
	public void set_name(string value) { }

	[Address(RVA = "0x30EE6F0", Offset = "0x30EDAF0", Length = "0x1DC")]
	[Token(Token = "0x600011B")]
	internal void set_rawName(string value) { }

	[Address(RVA = "0x30EE6A0", Offset = "0x30EDAA0", Length = "0x42")]
	[Token(Token = "0x6000154")]
	private static void set_rawName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x30EE920", Offset = "0x30EDD20", Length = "0x9B")]
	[Token(Token = "0x6000126")]
	public void set_stretchHeight(bool value) { }

	[Address(RVA = "0x30EE8D0", Offset = "0x30EDCD0", Length = "0x42")]
	[Token(Token = "0x600015F")]
	private static void set_stretchHeight_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x30ECE40", Offset = "0x30EC240", Length = "0x8C")]
	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	[Token(Token = "0x6000137")]
	internal static void SetDefaultFont(Font font) { }

	[Address(RVA = "0x30ECE00", Offset = "0x30EC200", Length = "0x33")]
	[Token(Token = "0x600016E")]
	private static void SetDefaultFont_Injected(IntPtr font) { }

	[Address(RVA = "0x30ECF20", Offset = "0x30EC320", Length = "0x1A8")]
	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	[Token(Token = "0x6000135")]
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[Address(RVA = "0x30ECED0", Offset = "0x30EC2D0", Length = "0x42")]
	[Token(Token = "0x600016C")]
	private static void SetMouseTooltip_Injected(ref ManagedSpanWrapper tooltip, in Rect screenRect) { }

	[Address(RVA = "0x30ED0D0", Offset = "0x30EC4D0", Length = "0x6B")]
	[Token(Token = "0x600014D")]
	public virtual string ToString() { }

}

