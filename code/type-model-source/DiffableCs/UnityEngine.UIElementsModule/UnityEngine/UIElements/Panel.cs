namespace UnityEngine.UIElements;

[Token(Token = "0x20002C0")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule"})]
internal class Panel : BaseVisualElementPanel
{
	[Token(Token = "0x4000B10")]
	internal const int k_DefaultPixelsPerUnit = 100; //Field offset: 0x0
	[Token(Token = "0x4000B20")]
	private static ProfilerMarker s_MarkerPickAll; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000B28")]
	private static LoadResourceFunction <loadResourceFunc>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000B2B")]
	private static TimeMsFunction <TimeSinceStartup>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000B30")]
	private static Action<Panel> beforeAnyRepaint; //Field offset: 0x18
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000B11")]
	private VisualElement m_RootContainer; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000B12")]
	private VisualTreeUpdater m_VisualTreeUpdater; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000B13")]
	private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000B14")]
	private string m_PanelName; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000B15")]
	private uint m_Version; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4000B16")]
	private uint m_RepaintVersion; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000B17")]
	private uint m_HierarchyVersion; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x4000B18")]
	private uint m_LastTickedHierarchyVersion; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000B19")]
	private ProfilerMarker m_MarkerPrepareRepaint; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000B1A")]
	private ProfilerMarker m_MarkerRender; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000B1B")]
	private ProfilerMarker m_MarkerValidateLayout; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000B1C")]
	private ProfilerMarker m_MarkerTickScheduledActions; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000B1D")]
	protected ProfilerMarker m_MarkerTickScheduledActionsPreLayout; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000B1E")]
	protected ProfilerMarker m_MarkerTickScheduledActionsPostLayout; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000B1F")]
	private ProfilerMarker m_MarkerPanelChangeReceiver; //Field offset: 0x170
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000B21")]
	private EventDispatcher <dispatcher>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000B22")]
	private ScriptableObject <ownerObject>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000B23")]
	private readonly ContextType <contextType>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000B24")]
	private SavePersistentViewData <saveViewData>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000B25")]
	private GetViewDataDictionary <getViewDataDictionary>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000B26")]
	private FocusController <focusController>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000B27")]
	private EventInterests <IMGUIEventInterests>k__BackingField; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1AB")]
	[Token(Token = "0x4000B29")]
	private bool m_JustReceivedFocus; //Field offset: 0x1AB
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000B2A")]
	private IDebugPanelChangeReceiver m_PanelChangeReceiver; //Field offset: 0x1B0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000B2C")]
	private int <IMGUIContainersCount>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000B2D")]
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000B2E")]
	private AtlasBase m_Atlas; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000B2F")]
	private bool m_ValidatingLayout; //Field offset: 0x1D0

	[Token(Token = "0x170003BE")]
	public virtual AtlasBase atlas
	{
		[Address(RVA = "0x3409BF0", Offset = "0x3408FF0", Length = "0xA")]
		[Token(Token = "0x6001315")]
		 get { } //Length: 10
		[Address(RVA = "0x3409CA0", Offset = "0x34090A0", Length = "0x82")]
		[Token(Token = "0x6001316")]
		 set { } //Length: 130
	}

	[Token(Token = "0x170003B0")]
	public virtual ContextType contextType
	{
		[Address(RVA = "0x2ED7400", Offset = "0x2ED6800", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60012FD")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170003AD")]
	public virtual EventDispatcher dispatcher
	{
		[Address(RVA = "0x1D11BB0", Offset = "0x1D10FB0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60012F7")]
		 get { } //Length: 8
		[Address(RVA = "0x24CEC90", Offset = "0x24CE090", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60012F8")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170003B3")]
	public virtual FocusController focusController
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001300")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001301")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170003B2")]
	public virtual GetViewDataDictionary getViewDataDictionary
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60012FF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003BD")]
	internal virtual uint hierarchyVersion
	{
		[Address(RVA = "0x3409C00", Offset = "0x3409000", Length = "0x7")]
		[Token(Token = "0x6001314")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x170003B9")]
	public virtual int IMGUIContainersCount
	{
		[Address(RVA = "0x3409B70", Offset = "0x3408F70", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600130F")]
		 get { } //Length: 7
		[Address(RVA = "0x3409C70", Offset = "0x3409070", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001310")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170003B4")]
	public virtual EventInterests IMGUIEventInterests
	{
		[Address(RVA = "0x3409B80", Offset = "0x3408F80", Length = "0x18")]
		[CompilerGenerated]
		[Token(Token = "0x6001302")]
		 get { } //Length: 24
		[Address(RVA = "0x3409C80", Offset = "0x3409080", Length = "0x15")]
		[CompilerGenerated]
		[Token(Token = "0x6001303")]
		 set { } //Length: 21
	}

	[Token(Token = "0x170003B5")]
	private static LoadResourceFunction loadResourceFunc
	{
		[Address(RVA = "0x3409C10", Offset = "0x3409010", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6001304")]
		private get { } //Length: 79
	}

	[Token(Token = "0x170003B6")]
	internal string name
	{
		[Address(RVA = "0x3180B00", Offset = "0x317FF00", Length = "0xA")]
		[Token(Token = "0x6001309")]
		internal get { } //Length: 10
		[Address(RVA = "0x3409D30", Offset = "0x3409130", Length = "0x2B")]
		[Token(Token = "0x600130A")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x170003AF")]
	public virtual ScriptableObject ownerObject
	{
		[Address(RVA = "0x291FDC0", Offset = "0x291F1C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60012FB")]
		 get { } //Length: 8
		[Address(RVA = "0x291FE30", Offset = "0x291F230", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60012FC")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170003B7")]
	public IDebugPanelChangeReceiver panelChangeReceiver
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[Token(Token = "0x600130B")]
		 get { } //Length: 8
		[Address(RVA = "0x3409D60", Offset = "0x3409160", Length = "0xA9")]
		[Token(Token = "0x600130C")]
		 set { } //Length: 169
	}

	[Token(Token = "0x170003BC")]
	internal virtual uint repaintVersion
	{
		[Address(RVA = "0x1D11C20", Offset = "0x1D11020", Length = "0x7")]
		[Token(Token = "0x6001313")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x170003BA")]
	public virtual IMGUIContainer rootIMGUIContainer
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001311")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003B1")]
	public virtual SavePersistentViewData saveViewData
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60012FE")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003AE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal virtual IStylePropertyAnimationSystem styleAnimationSystem
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[Token(Token = "0x60012F9")]
		internal get { } //Length: 8
		[Address(RVA = "0x3409E10", Offset = "0x3409210", Length = "0xDA")]
		[Token(Token = "0x60012FA")]
		internal set { } //Length: 218
	}

	[Obsolete("Use the non-static TimeSinceStartupFunc instead")]
	[Token(Token = "0x170003B8")]
	internal static TimeMsFunction TimeSinceStartup
	{
		[Address(RVA = "0x3409BA0", Offset = "0x3408FA0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x600130E")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170003BB")]
	internal virtual uint version
	{
		[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
		[Token(Token = "0x6001312")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x170003AC")]
	public virtual VisualElement visualTree
	{
		[Address(RVA = "0x3409C60", Offset = "0x3409060", Length = "0xA")]
		[Token(Token = "0x60012F6")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x34096B0", Offset = "0x3408AB0", Length = "0x5E")]
	[Token(Token = "0x6001329")]
	private static Panel() { }

	[Address(RVA = "0x3409710", Offset = "0x3408B10", Length = "0x45E")]
	[Token(Token = "0x6001317")]
	public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher) { }

	[Address(RVA = "0x3074EE0", Offset = "0x30742E0", Length = "0xB2")]
	[CompilerGenerated]
	[Token(Token = "0x600132A")]
	internal static Vector2Int <Pick>g__PixelOf|98_0(Vector2 p) { }

	[Address(RVA = "0x3408100", Offset = "0x3407500", Length = "0x26")]
	[Token(Token = "0x6001322")]
	public virtual void ApplyStyles() { }

	[Address(RVA = "0x3408130", Offset = "0x3407530", Length = "0x2F")]
	[Token(Token = "0x6001307")]
	internal void Blur() { }

	[Address(RVA = "0x3408160", Offset = "0x3407560", Length = "0x20B")]
	[Token(Token = "0x600130D")]
	private void CreateMarkers() { }

	[Address(RVA = "0x3408370", Offset = "0x3407770", Length = "0x264")]
	[Token(Token = "0x6001318")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x34085E0", Offset = "0x34079E0", Length = "0x8")]
	[Token(Token = "0x6001306")]
	internal void Focus() { }

	[Address(RVA = "0x3409BF0", Offset = "0x3408FF0", Length = "0xA")]
	[Token(Token = "0x6001315")]
	public virtual AtlasBase get_atlas() { }

	[Address(RVA = "0x2ED7400", Offset = "0x2ED6800", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60012FD")]
	public virtual ContextType get_contextType() { }

	[Address(RVA = "0x1D11BB0", Offset = "0x1D10FB0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60012F7")]
	public virtual EventDispatcher get_dispatcher() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001300")]
	public virtual FocusController get_focusController() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60012FF")]
	public virtual GetViewDataDictionary get_getViewDataDictionary() { }

	[Address(RVA = "0x3409C00", Offset = "0x3409000", Length = "0x7")]
	[Token(Token = "0x6001314")]
	internal virtual uint get_hierarchyVersion() { }

	[Address(RVA = "0x3409B70", Offset = "0x3408F70", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600130F")]
	public virtual int get_IMGUIContainersCount() { }

	[Address(RVA = "0x3409B80", Offset = "0x3408F80", Length = "0x18")]
	[CompilerGenerated]
	[Token(Token = "0x6001302")]
	public virtual EventInterests get_IMGUIEventInterests() { }

	[Address(RVA = "0x3409C10", Offset = "0x3409010", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6001304")]
	private static LoadResourceFunction get_loadResourceFunc() { }

	[Address(RVA = "0x3180B00", Offset = "0x317FF00", Length = "0xA")]
	[Token(Token = "0x6001309")]
	internal string get_name() { }

	[Address(RVA = "0x291FDC0", Offset = "0x291F1C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60012FB")]
	public virtual ScriptableObject get_ownerObject() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[Token(Token = "0x600130B")]
	public IDebugPanelChangeReceiver get_panelChangeReceiver() { }

	[Address(RVA = "0x1D11C20", Offset = "0x1D11020", Length = "0x7")]
	[Token(Token = "0x6001313")]
	internal virtual uint get_repaintVersion() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001311")]
	public virtual IMGUIContainer get_rootIMGUIContainer() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60012FE")]
	public virtual SavePersistentViewData get_saveViewData() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[Token(Token = "0x60012F9")]
	internal virtual IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	[Address(RVA = "0x3409BA0", Offset = "0x3408FA0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x600130E")]
	internal static TimeMsFunction get_TimeSinceStartup() { }

	[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
	[Token(Token = "0x6001312")]
	internal virtual uint get_version() { }

	[Address(RVA = "0x3409C60", Offset = "0x3409060", Length = "0xA")]
	[Token(Token = "0x60012F6")]
	public virtual VisualElement get_visualTree() { }

	[Address(RVA = "0x34085F0", Offset = "0x34079F0", Length = "0x21")]
	[Token(Token = "0x6001328")]
	internal virtual IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x3408620", Offset = "0x3407A20", Length = "0x13B")]
	[Token(Token = "0x6001305")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static object LoadResource(string pathName, Type type, float dpiScaling) { }

	[Address(RVA = "0x3408760", Offset = "0x3407B60", Length = "0x184")]
	[Token(Token = "0x6001326")]
	internal virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x34088F0", Offset = "0x3407CF0", Length = "0x341")]
	[Token(Token = "0x600131A")]
	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false) { }

	[Address(RVA = "0x3408DB0", Offset = "0x34081B0", Length = "0x159")]
	[Token(Token = "0x600131C")]
	public virtual VisualElement Pick(Vector2 point, int pointerId) { }

	[Address(RVA = "0x3408D20", Offset = "0x3408120", Length = "0x85")]
	[Token(Token = "0x6001319")]
	internal static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false) { }

	[Address(RVA = "0x3408C40", Offset = "0x3408040", Length = "0xD8")]
	[Token(Token = "0x600131B")]
	public virtual VisualElement PickAll(Vector2 point, List<VisualElement> picked) { }

	[Address(RVA = "0x3408F10", Offset = "0x3408310", Length = "0x9C")]
	[Token(Token = "0x6001325")]
	public virtual void Render() { }

	[Address(RVA = "0x3408FB0", Offset = "0x34083B0", Length = "0x1B5")]
	[Token(Token = "0x6001324")]
	public virtual void Repaint(Event e) { }

	[Address(RVA = "0x3409CA0", Offset = "0x34090A0", Length = "0x82")]
	[Token(Token = "0x6001316")]
	public virtual void set_atlas(AtlasBase value) { }

	[Address(RVA = "0x24CEC90", Offset = "0x24CE090", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60012F8")]
	public virtual void set_dispatcher(EventDispatcher value) { }

	[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001301")]
	public virtual void set_focusController(FocusController value) { }

	[Address(RVA = "0x3409C70", Offset = "0x3409070", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6001310")]
	public virtual void set_IMGUIContainersCount(int value) { }

	[Address(RVA = "0x3409C80", Offset = "0x3409080", Length = "0x15")]
	[CompilerGenerated]
	[Token(Token = "0x6001303")]
	public virtual void set_IMGUIEventInterests(EventInterests value) { }

	[Address(RVA = "0x3409D30", Offset = "0x3409130", Length = "0x2B")]
	[Token(Token = "0x600130A")]
	internal void set_name(string value) { }

	[Address(RVA = "0x291FE30", Offset = "0x291F230", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60012FC")]
	protected virtual void set_ownerObject(ScriptableObject value) { }

	[Address(RVA = "0x3409D60", Offset = "0x3409160", Length = "0xA9")]
	[Token(Token = "0x600130C")]
	public void set_panelChangeReceiver(IDebugPanelChangeReceiver value) { }

	[Address(RVA = "0x3409E10", Offset = "0x3409210", Length = "0xDA")]
	[Token(Token = "0x60012FA")]
	internal virtual void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	[Address(RVA = "0x3409170", Offset = "0x3408570", Length = "0x21")]
	[Token(Token = "0x6001327")]
	internal virtual void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x34091A0", Offset = "0x34085A0", Length = "0x233")]
	[Token(Token = "0x6001321")]
	public virtual void TickSchedulingUpdaters() { }

	[Address(RVA = "0x34093E0", Offset = "0x34087E0", Length = "0x26")]
	[Token(Token = "0x600131E")]
	public virtual void UpdateAnimations() { }

	[Address(RVA = "0x3409410", Offset = "0x3408810", Length = "0x23")]
	[Token(Token = "0x600131F")]
	public virtual void UpdateBindings() { }

	[Address(RVA = "0x3409440", Offset = "0x3408840", Length = "0x26")]
	[Token(Token = "0x6001320")]
	public virtual void UpdateDataBinding() { }

	[Address(RVA = "0x3409470", Offset = "0x3408870", Length = "0xEE")]
	[Token(Token = "0x6001323")]
	public virtual void UpdateForRepaint() { }

	[Address(RVA = "0x3409560", Offset = "0x3408960", Length = "0x3B")]
	[Token(Token = "0x6001308")]
	public void ValidateFocus() { }

	[Address(RVA = "0x34095A0", Offset = "0x34089A0", Length = "0x10B")]
	[Token(Token = "0x600131D")]
	public virtual void ValidateLayout() { }

}

