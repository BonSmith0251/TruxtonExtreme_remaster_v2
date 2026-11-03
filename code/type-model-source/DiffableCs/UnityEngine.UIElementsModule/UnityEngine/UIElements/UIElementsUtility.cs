namespace UnityEngine.UIElements;

[Token(Token = "0x20004CF")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule"})]
internal class UIElementsUtility : IUIElementsUtility
{
	[Token(Token = "0x4001038")]
	private static Stack<IMGUIContainer> s_ContainerStack; //Field offset: 0x0
	[Token(Token = "0x4001039")]
	private static Dictionary<Int32, Panel> s_UIElementsCache; //Field offset: 0x8
	[Token(Token = "0x400103A")]
	private static Event s_EventInstance; //Field offset: 0x10
	[Token(Token = "0x400103B")]
	internal static Color editorPlayModeTintColor; //Field offset: 0x18
	[Token(Token = "0x400103C")]
	internal static float singleLineHeight; //Field offset: 0x28
	[Token(Token = "0x400103D")]
	internal static bool s_EnableOSXContextualMenuEventsOnNonOSXPlatforms; //Field offset: 0x2C
	[Token(Token = "0x400103E")]
	private static UIElementsUtility s_Instance; //Field offset: 0x30
	[Token(Token = "0x400103F")]
	internal static List<Panel> s_PanelsIterationList; //Field offset: 0x38
	[Token(Token = "0x4001040")]
	private static Action testFrameUpdateCallback; //Field offset: 0x40
	[Token(Token = "0x4001041")]
	internal static readonly string s_RepaintProfilerMarkerName; //Field offset: 0x48
	[Token(Token = "0x4001042")]
	internal static readonly string s_EventProfilerMarkerName; //Field offset: 0x50
	[Token(Token = "0x4001043")]
	private static readonly ProfilerMarker s_RepaintProfilerMarker; //Field offset: 0x58
	[Token(Token = "0x4001044")]
	private static readonly ProfilerMarker s_EventProfilerMarker; //Field offset: 0x60
	[Token(Token = "0x4001045")]
	internal static Char[] s_Modifiers; //Field offset: 0x68
	[Token(Token = "0x4001046")]
	internal static readonly HashSet<StyleSheet> s_StyleSheetsRequiringRebuilding; //Field offset: 0x70
	[Token(Token = "0x4001047")]
	internal static readonly HashSet<String> s_ReimportedStyleSheetsPath; //Field offset: 0x78
	[Token(Token = "0x4001048")]
	internal static readonly List<StyleSheet> s_StyleSheetsRebuildList; //Field offset: 0x80
	[Token(Token = "0x4001049")]
	internal static readonly List<String> s_ReimportedStyleSheetsPathList; //Field offset: 0x88

	[Token(Token = "0x170009B3")]
	public static bool isOSXContextualMenuPlatform
	{
		[Address(RVA = "0x32BF380", Offset = "0x32BE780", Length = "0x90")]
		[Token(Token = "0x600249E")]
		 get { } //Length: 144
	}

	[Address(RVA = "0x32BED10", Offset = "0x32BE110", Length = "0x5A4")]
	[Token(Token = "0x60024B4")]
	private static UIElementsUtility() { }

	[Address(RVA = "0x32BF2C0", Offset = "0x32BE6C0", Length = "0xB2")]
	[Token(Token = "0x600249F")]
	private UIElementsUtility() { }

	[Address(RVA = "0x32BCFB0", Offset = "0x32BC3B0", Length = "0x25B")]
	[Token(Token = "0x60024A9")]
	internal static void BeginContainerGUI(LayoutCache cache, Event evt, IMGUIContainer container) { }

	[Address(RVA = "0x32BD280", Offset = "0x32BC680", Length = "0xE4")]
	[Token(Token = "0x60024AC")]
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	[Address(RVA = "0x32BD210", Offset = "0x32BC610", Length = "0x6C")]
	[Token(Token = "0x60024AB")]
	internal static EventBase CreateEvent(Event systemEvent) { }

	[Address(RVA = "0x32BD630", Offset = "0x32BCA30", Length = "0x5B7")]
	[Token(Token = "0x60024AD")]
	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x32BDBF0", Offset = "0x32BCFF0", Length = "0x255")]
	[Token(Token = "0x60024AA")]
	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	[Address(RVA = "0x32BF380", Offset = "0x32BE780", Length = "0x90")]
	[Token(Token = "0x600249E")]
	public static bool get_isOSXContextualMenuPlatform() { }

	[Address(RVA = "0x32BDE50", Offset = "0x32BD250", Length = "0x183")]
	[Token(Token = "0x60024AE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	[Address(RVA = "0x32BDFE0", Offset = "0x32BD3E0", Length = "0xAB")]
	[Token(Token = "0x60024AF")]
	internal static Enumerator<Int32, Panel> GetPanelsIterator() { }

	[Address(RVA = "0x32BE090", Offset = "0x32BD490", Length = "0xAE")]
	[Token(Token = "0x60024B2")]
	internal static void MarkStyleSheetAsChanged(StyleSheet styleSheet) { }

	[Address(RVA = "0x32BE140", Offset = "0x32BD540", Length = "0x134")]
	[Token(Token = "0x60024B1")]
	internal static string ParseMenuName(string menuName) { }

	[Address(RVA = "0x32BE280", Offset = "0x32BD680", Length = "0xC9")]
	[Token(Token = "0x60024B0")]
	internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite) { }

	[Address(RVA = "0x32BE350", Offset = "0x32BD750", Length = "0x291")]
	[Token(Token = "0x60024B3")]
	internal static void RebuildDirtyStyleSheets() { }

	[Address(RVA = "0x32BE5F0", Offset = "0x32BD9F0", Length = "0x86")]
	[Token(Token = "0x60024A6")]
	public static void RegisterCachedPanel(int instanceID, Panel panel) { }

	[Address(RVA = "0x32BE680", Offset = "0x32BDA80", Length = "0x77")]
	[Token(Token = "0x60024A7")]
	public static void RemoveCachedPanel(int instanceID) { }

	[Address(RVA = "0x32BE700", Offset = "0x32BDB00", Length = "0x86")]
	[Token(Token = "0x60024A8")]
	public static bool TryGetPanel(int instanceID, out Panel panel) { }

	[Address(RVA = "0x32BE790", Offset = "0x32BDB90", Length = "0xC7")]
	[Token(Token = "0x60024A4")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots() { }

	[Address(RVA = "0x32BE860", Offset = "0x32BDC60", Length = "0xDA")]
	[Token(Token = "0x60024A5")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(Exception exception) { }

	[Address(RVA = "0x32BE940", Offset = "0x32BDD40", Length = "0xBB")]
	[Token(Token = "0x60024A0")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty() { }

	[Address(RVA = "0x32BEA00", Offset = "0x32BDE00", Length = "0x241")]
	[Token(Token = "0x60024A3")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[Token(Token = "0x60024A2")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture() { }

	[Address(RVA = "0x32BEC50", Offset = "0x32BE050", Length = "0xB6")]
	[Token(Token = "0x60024A1")]
	private override bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture() { }

}

