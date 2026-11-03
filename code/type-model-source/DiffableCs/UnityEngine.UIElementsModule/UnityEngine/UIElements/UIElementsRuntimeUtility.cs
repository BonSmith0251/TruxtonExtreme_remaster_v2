namespace UnityEngine.UIElements;

[Token(Token = "0x20004C9")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
internal static class UIElementsRuntimeUtility
{
	[CompilerGenerated]
	[Token(Token = "0x20004CB")]
	private sealed class <>c
	{
		[Token(Token = "0x4001034")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001035")]
		public static Comparison<BaseRuntimePanel> <>9__60_0; //Field offset: 0x8

		[Address(RVA = "0x32BB4C0", Offset = "0x32BA8C0", Length = "0x67")]
		[Token(Token = "0x6002484")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002485")]
		public <>c() { }

		[Address(RVA = "0x32BB050", Offset = "0x32BA450", Length = "0x5B")]
		[Token(Token = "0x6002486")]
		internal void <.cctor>b__6_0(int displayIndex, int sortOrder) { }

		[Address(RVA = "0x32BACA0", Offset = "0x32BA0A0", Length = "0xF5")]
		[Token(Token = "0x6002487")]
		internal int <SortPanels>b__60_0(BaseRuntimePanel runtimePanelA, BaseRuntimePanel runtimePanelB) { }

	}

	[Token(Token = "0x20004CA")]
	internal sealed class CreateRuntimePanelDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1BB1770", Offset = "0x1BB0B70", Length = "0x124")]
		[Token(Token = "0x6002482")]
		public CreateRuntimePanelDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6002483")]
		public override BaseRuntimePanel Invoke(ScriptableObject ownerObject) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4001026")]
	private static Action<BaseRuntimePanel> onCreatePanel; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4001027")]
	private static Action<BaseRuntimePanel> onWillDestroyPanel; //Field offset: 0x8
	[Token(Token = "0x4001028")]
	private static bool s_RegisteredPlayerloopCallback; //Field offset: 0x10
	[Token(Token = "0x4001029")]
	private static readonly List<BaseRuntimePanel> s_SortedScreenOverlayPanels; //Field offset: 0x18
	[Token(Token = "0x400102A")]
	private static readonly List<BaseRuntimePanel> s_CachedWorldSpacePanels; //Field offset: 0x20
	[Token(Token = "0x400102B")]
	private static readonly List<BaseRuntimePanel> s_SortedPlayerPanels; //Field offset: 0x28
	[Token(Token = "0x400102C")]
	private static bool s_PanelOrderingOrDrawInCameraDirty; //Field offset: 0x30
	[Token(Token = "0x400102D")]
	internal static int s_ResolvedSortingIndexMax; //Field offset: 0x34
	[Token(Token = "0x400102E")]
	private static int currentOverlayIndex; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400102F")]
	private static object <activeEventSystem>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4001030")]
	private static Nullable<Boolean> <overrideUseDefaultEventSystem>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4001031")]
	private static bool <autoUpdateEventSystem>k__BackingField; //Field offset: 0x4A
	[Token(Token = "0x4001032")]
	private static DefaultEventSystem s_DefaultEventSystem; //Field offset: 0x50
	[Token(Token = "0x4001033")]
	private static List<PanelSettings> s_PotentiallyEmptyPanelSettings; //Field offset: 0x58

	[Token(Token = "0x1400002D")]
	public static event Action<BaseRuntimePanel> onCreatePanel
	{
		[Address(RVA = "0x32B49C0", Offset = "0x32B3DC0", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x6002455")]
		 add { } //Length: 257
		[Address(RVA = "0x32B4DD0", Offset = "0x32B41D0", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x6002456")]
		 remove { } //Length: 257
	}

	[Token(Token = "0x170009AE")]
	internal static object activeEventSystem
	{
		[Address(RVA = "0x32B4AD0", Offset = "0x32B3ED0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6002465")]
		internal get { } //Length: 79
		[Address(RVA = "0x32B4EE0", Offset = "0x32B42E0", Length = "0x6E")]
		[CompilerGenerated]
		[Token(Token = "0x6002466")]
		private set { } //Length: 110
	}

	[Token(Token = "0x170009B1")]
	internal static bool autoUpdateEventSystem
	{
		[Address(RVA = "0x32B4B20", Offset = "0x32B3F20", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x600246A")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170009B2")]
	internal static DefaultEventSystem defaultEventSystem
	{
		[Address(RVA = "0x32B4B70", Offset = "0x32B3F70", Length = "0xC7")]
		[Token(Token = "0x600246D")]
		internal get { } //Length: 199
	}

	[Token(Token = "0x170009B0")]
	internal static Nullable<Boolean> overrideUseDefaultEventSystem
	{
		[Address(RVA = "0x32B4C40", Offset = "0x32B4040", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6002468")]
		internal get { } //Length: 79
		[Address(RVA = "0x32B4F50", Offset = "0x32B4350", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6002469")]
		internal set { } //Length: 85
	}

	[Token(Token = "0x170009AF")]
	internal static bool useDefaultEventSystem
	{
		[Address(RVA = "0x32B4C90", Offset = "0x32B4090", Length = "0x132")]
		[Token(Token = "0x6002467")]
		internal get { } //Length: 306
	}

	[Address(RVA = "0x32B45D0", Offset = "0x32B39D0", Length = "0x3E4")]
	[Token(Token = "0x6002457")]
	private static UIElementsRuntimeUtility() { }

	[Address(RVA = "0x32B49C0", Offset = "0x32B3DC0", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x6002455")]
	public static void add_onCreatePanel(Action<BaseRuntimePanel> value) { }

	[Address(RVA = "0x32B1630", Offset = "0x32B0A30", Length = "0x52")]
	[Token(Token = "0x6002461")]
	internal static void BeginRenderOverlays(int displayIndex) { }

	[Address(RVA = "0x32B1690", Offset = "0x32B0A90", Length = "0x6C")]
	[Token(Token = "0x6002458")]
	public static EventBase CreateEvent(Event systemEvent) { }

	[Address(RVA = "0x32B1700", Offset = "0x32B0B00", Length = "0x8E")]
	[Token(Token = "0x6002473")]
	public static void DisableRenderingAndInputCallbacks() { }

	[Address(RVA = "0x32B1790", Offset = "0x32B0B90", Length = "0x162")]
	[Token(Token = "0x600245A")]
	public static void DisposeRuntimePanel(ScriptableObject ownerObject) { }

	[Address(RVA = "0x32B1900", Offset = "0x32B0D00", Length = "0xA8")]
	[Token(Token = "0x6002472")]
	public static void EnableRenderingAndInputCallbacks() { }

	[Address(RVA = "0x32B19B0", Offset = "0x32B0DB0", Length = "0x66")]
	[Token(Token = "0x6002463")]
	internal static void EndRenderOverlays(int displayIndex) { }

	[Address(RVA = "0x32B1A20", Offset = "0x32B0E20", Length = "0x33A")]
	[Token(Token = "0x6002459")]
	public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate) { }

	[Address(RVA = "0x310D830", Offset = "0x310CC30", Length = "0x1E")]
	[Token(Token = "0x6002480")]
	private static Vector2 FlipDeltaY(Vector2 delta) { }

	[Address(RVA = "0x32B1D60", Offset = "0x32B1160", Length = "0x17")]
	[Token(Token = "0x600247F")]
	internal static Vector2 FlipY(Vector2 p, float displayHeight) { }

	[Address(RVA = "0x32B4AD0", Offset = "0x32B3ED0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6002465")]
	internal static object get_activeEventSystem() { }

	[Address(RVA = "0x32B4B20", Offset = "0x32B3F20", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x600246A")]
	internal static bool get_autoUpdateEventSystem() { }

	[Address(RVA = "0x32B4B70", Offset = "0x32B3F70", Length = "0xC7")]
	[Token(Token = "0x600246D")]
	internal static DefaultEventSystem get_defaultEventSystem() { }

	[Address(RVA = "0x32B4C40", Offset = "0x32B4040", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6002468")]
	internal static Nullable<Boolean> get_overrideUseDefaultEventSystem() { }

	[Address(RVA = "0x32B4C90", Offset = "0x32B4090", Length = "0x132")]
	[Token(Token = "0x6002467")]
	internal static bool get_useDefaultEventSystem() { }

	[Address(RVA = "0x32B1D80", Offset = "0x32B1180", Length = "0x2CF")]
	[Token(Token = "0x600245B")]
	private static void GetPlayerPanelsByRenderMode(List<BaseRuntimePanel> outScreenSpaceOverlayPanels, List<BaseRuntimePanel> outWorldSpacePanels) { }

	[Address(RVA = "0x32B2050", Offset = "0x32B1450", Length = "0xBF")]
	[Token(Token = "0x6002481")]
	private static float GetRuntimeDisplayHeight(int targetDisplay) { }

	[Address(RVA = "0x32B2110", Offset = "0x32B1510", Length = "0x9A")]
	[Token(Token = "0x6002478")]
	public static List<BaseRuntimePanel> GetSortedPlayerPanels() { }

	[Address(RVA = "0x32B21B0", Offset = "0x32B15B0", Length = "0x9A")]
	[Token(Token = "0x6002477")]
	public static List<BaseRuntimePanel> GetSortedScreenOverlayPlayerPanels() { }

	[Address(RVA = "0x32B2250", Offset = "0x32B1650", Length = "0x9A")]
	[Token(Token = "0x6002476")]
	internal static List<BaseRuntimePanel> GetWorldSpacePlayerPanels() { }

	[Address(RVA = "0x32B22F0", Offset = "0x32B16F0", Length = "0x122")]
	[Token(Token = "0x6002470")]
	internal static void MarkPotentiallyEmpty(PanelSettings settings) { }

	[Address(RVA = "0x32B2420", Offset = "0x32B1820", Length = "0x23B")]
	[Token(Token = "0x600247A")]
	internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out Nullable<Int32>& targetDisplay) { }

	[Address(RVA = "0x32B2660", Offset = "0x32B1A60", Length = "0x1AC")]
	[Token(Token = "0x600247B")]
	internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<Int32>& targetDisplay) { }

	[Address(RVA = "0x32B2810", Offset = "0x32B1C10", Length = "0x61")]
	[Token(Token = "0x600247E")]
	internal static Vector2 PanelToScreenBottomLeftPosition(Vector2 panelPosition, int targetDisplay) { }

	[Address(RVA = "0x32B2880", Offset = "0x32B1C80", Length = "0x1AC")]
	[Token(Token = "0x600245C")]
	private static void RegisterCachedPanelInternal(int instanceID, IPanel panel) { }

	[Address(RVA = "0x32B2A30", Offset = "0x32B1E30", Length = "0x247")]
	[Token(Token = "0x600246B")]
	public static void RegisterEventSystem(object eventSystem) { }

	[Address(RVA = "0x32B4DD0", Offset = "0x32B41D0", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x6002456")]
	public static void remove_onCreatePanel(Action<BaseRuntimePanel> value) { }

	[Address(RVA = "0x32B2C80", Offset = "0x32B2080", Length = "0x23A")]
	[Token(Token = "0x600245D")]
	private static void RemoveCachedPanelInternal(int instanceID) { }

	[Address(RVA = "0x32B2EC0", Offset = "0x32B22C0", Length = "0x1E1")]
	[Token(Token = "0x6002471")]
	internal static void RemoveUnusedPanels() { }

	[Address(RVA = "0x32B30B0", Offset = "0x32B24B0", Length = "0x1EB")]
	[Token(Token = "0x600245E")]
	public static void RenderOffscreenPanels() { }

	[Address(RVA = "0x32B32A0", Offset = "0x32B26A0", Length = "0x256")]
	[Token(Token = "0x6002462")]
	internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority) { }

	[Address(RVA = "0x32B3500", Offset = "0x32B2900", Length = "0xDA")]
	[Token(Token = "0x6002460")]
	public static void RenderPanel(BaseRuntimePanel panel, bool restoreState = true) { }

	[Address(RVA = "0x32B35E0", Offset = "0x32B29E0", Length = "0x74")]
	[Token(Token = "0x600245F")]
	public static void RepaintPanel(BaseRuntimePanel panel) { }

	[Address(RVA = "0x32B3660", Offset = "0x32B2A60", Length = "0x1B4")]
	[Token(Token = "0x6002464")]
	public static void RepaintPanels(bool onlyOffscreen) { }

	[Address(RVA = "0x32B3820", Offset = "0x32B2C20", Length = "0x5A")]
	[Token(Token = "0x600247D")]
	internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }

	[Address(RVA = "0x32B3880", Offset = "0x32B2C80", Length = "0x61")]
	[Token(Token = "0x600247C")]
	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	[Address(RVA = "0x32B4EE0", Offset = "0x32B42E0", Length = "0x6E")]
	[CompilerGenerated]
	[Token(Token = "0x6002466")]
	private static void set_activeEventSystem(object value) { }

	[Address(RVA = "0x32B4F50", Offset = "0x32B4350", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6002469")]
	internal static void set_overrideUseDefaultEventSystem(Nullable<Boolean> value) { }

	[Address(RVA = "0x32B38F0", Offset = "0x32B2CF0", Length = "0x4F")]
	[Token(Token = "0x6002474")]
	internal static void SetPanelOrderingDirty() { }

	[Address(RVA = "0x32B3940", Offset = "0x32B2D40", Length = "0x4F")]
	[Token(Token = "0x6002475")]
	internal static void SetPanelsDrawInCameraDirty() { }

	[Address(RVA = "0x32B3990", Offset = "0x32B2D90", Length = "0x65B")]
	[Token(Token = "0x6002479")]
	private static void SortPanels() { }

	[Address(RVA = "0x32B3FF0", Offset = "0x32B33F0", Length = "0x134")]
	[Token(Token = "0x600246C")]
	public static void UnregisterEventSystem(object eventSystem) { }

	[Address(RVA = "0x32B4130", Offset = "0x32B3530", Length = "0x279")]
	[Token(Token = "0x600246F")]
	internal static void UpdateEventSystem() { }

	[Address(RVA = "0x32B43B0", Offset = "0x32B37B0", Length = "0x213")]
	[Token(Token = "0x600246E")]
	public static void UpdatePanels() { }

}

