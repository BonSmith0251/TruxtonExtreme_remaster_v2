namespace UnityEngine.UIElements;

[Token(Token = "0x20002B9")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule", "UnityEngine.VectorGraphicsModule"})]
internal abstract class BaseVisualElementPanel : IPanel, IDisposable, IGroupBox
{
	[CompilerGenerated]
	[Token(Token = "0x20002BA")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B0E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000B0F")]
		public static Func<AbstractGenericMenu> <>9__28_0; //Field offset: 0x8

		[Address(RVA = "0x340CF40", Offset = "0x340C340", Length = "0x67")]
		[Token(Token = "0x60012E9")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60012EA")]
		public <>c() { }

		[Address(RVA = "0x340CE10", Offset = "0x340C210", Length = "0x44")]
		[Token(Token = "0x60012EB")]
		internal AbstractGenericMenu <.ctor>b__28_0() { }

	}

	[Token(Token = "0x4000B0B")]
	internal static readonly Vector2 s_OutsidePanelCoordinates; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AF5")]
	private Action<BaseVisualElementPanel> panelDisposed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AF6")]
	private UIElementsBridge m_UIElementsBridge; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AF7")]
	private float m_Scale; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AF8")]
	internal LayoutConfig layoutConfig; //Field offset: 0x28
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000AF9")]
	private float m_PixelsPerPoint; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000AFA")]
	private float <referenceSpritePixelsPerUnit>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000AFB")]
	private PanelClearSettings <clearSettings>k__BackingField; //Field offset: 0x70
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000AFC")]
	internal IPanelRenderer panelRenderer; //Field offset: 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000AFD")]
	private bool <duringLayoutPhase>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000AFE")]
	private RepaintData <repaintData>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000AFF")]
	private ICursorManager <cursorManager>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000B00")]
	private ContextualMenuManager <contextualMenuManager>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000B01")]
	private DataBindingManager <dataBindingManager>k__BackingField; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000B02")]
	private TimerEventScheduler m_Scheduler; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000B03")]
	private TimeFunction m_TimeSinceStartupFunc; //Field offset: 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000B04")]
	private bool <disposed>k__BackingField; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000B05")]
	internal ElementUnderPointer m_TopElementUnderPointers; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000B06")]
	private Action isFlatChanged; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000B07")]
	private bool m_IsFlat; //Field offset: 0xE0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000B08")]
	private Action atlasChanged; //Field offset: 0xE8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000B09")]
	private HierarchyEvent hierarchyChanged; //Field offset: 0xF0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000B0A")]
	private Action<IPanel> beforeUpdate; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000B0C")]
	public readonly Lazy<HashSet`1<TextElement>> textElementRegistry; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000B0D")]
	internal Func<AbstractGenericMenu> CreateMenuFunctor; //Field offset: 0x108

	[Token(Token = "0x14000029")]
	internal event Action atlasChanged
	{
		[Address(RVA = "0x33FCC00", Offset = "0x33FC000", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x60012DA")]
		internal add { } //Length: 162
		[Address(RVA = "0x33FD040", Offset = "0x33FC440", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x60012DB")]
		internal remove { } //Length: 162
	}

	[Token(Token = "0x1400002A")]
	internal event HierarchyEvent hierarchyChanged
	{
		[Address(RVA = "0x33FCCB0", Offset = "0x33FC0B0", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x60012DF")]
		internal add { } //Length: 162
		[Address(RVA = "0x33FD0F0", Offset = "0x33FC4F0", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x60012E0")]
		internal remove { } //Length: 162
	}

	[Token(Token = "0x14000028")]
	internal event Action isFlatChanged
	{
		[Address(RVA = "0x33FCD60", Offset = "0x33FC160", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x60012D5")]
		internal add { } //Length: 162
		[Address(RVA = "0x33FD1A0", Offset = "0x33FC5A0", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x60012D6")]
		internal remove { } //Length: 162
	}

	[Token(Token = "0x14000027")]
	internal event Action<BaseVisualElementPanel> panelDisposed
	{
		[Address(RVA = "0x33FCE10", Offset = "0x33FC210", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6001297")]
		internal add { } //Length: 172
		[Address(RVA = "0x33FD250", Offset = "0x33FC650", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6001298")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x170003AB")]
	public abstract AtlasBase atlas
	{
		[Token(Token = "0x60012DD")]
		 get { } //Length: 0
		[Token(Token = "0x60012DE")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000399")]
	internal PanelClearSettings clearSettings
	{
		[Address(RVA = "0x33FCEC0", Offset = "0x33FC2C0", Length = "0x14")]
		[CompilerGenerated]
		[Token(Token = "0x60012AA")]
		internal get { } //Length: 20
		[Address(RVA = "0x33FD300", Offset = "0x33FC700", Length = "0x11")]
		[CompilerGenerated]
		[Token(Token = "0x60012AB")]
		internal set { } //Length: 17
	}

	[Token(Token = "0x170003A7")]
	public abstract ContextType contextType
	{
		[Token(Token = "0x60012C3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170003A1")]
	public internal override ContextualMenuManager contextualMenuManager
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60012B8")]
		 get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60012B9")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170003A0")]
	internal override ICursorManager cursorManager
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60012B6")]
		internal get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60012B7")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170003A2")]
	internal override DataBindingManager dataBindingManager
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60012BA")]
		internal get { } //Length: 8
		[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60012BB")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170003A4")]
	public abstract EventDispatcher dispatcher
	{
		[Token(Token = "0x60012BD")]
		 get { } //Length: 0
		[Token(Token = "0x60012BE")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170003A9")]
	internal bool disposed
	{
		[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60012CB")]
		internal get { } //Length: 8
		[Address(RVA = "0x29E0AA0", Offset = "0x29DFEA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60012CC")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700039A")]
	internal bool duringLayoutPhase
	{
		[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60012AC")]
		internal get { } //Length: 8
		[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60012AD")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000393")]
	public abstract FocusController focusController
	{
		[Token(Token = "0x6001294")]
		 get { } //Length: 0
		[Token(Token = "0x6001295")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000391")]
	public abstract GetViewDataDictionary getViewDataDictionary
	{
		[Token(Token = "0x6001291")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700039E")]
	internal abstract uint hierarchyVersion
	{
		[Token(Token = "0x60012B1")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000392")]
	public abstract int IMGUIContainersCount
	{
		[Token(Token = "0x6001292")]
		 get { } //Length: 0
		[Token(Token = "0x6001293")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700038E")]
	public abstract EventInterests IMGUIEventInterests
	{
		[Token(Token = "0x600128C")]
		 get { } //Length: 0
		[Token(Token = "0x600128D")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700039B")]
	public override bool isDirty
	{
		[Address(RVA = "0x33FCEE0", Offset = "0x33FC2E0", Length = "0x49")]
		[Token(Token = "0x60012AE")]
		 get { } //Length: 73
	}

	[Token(Token = "0x170003AA")]
	public bool isFlat
	{
		[Address(RVA = "0x26CB620", Offset = "0x26CAA20", Length = "0x8")]
		[Token(Token = "0x60012D7")]
		 get { } //Length: 8
		[Address(RVA = "0x33FD320", Offset = "0x33FC720", Length = "0x44")]
		[Token(Token = "0x60012D8")]
		 set { } //Length: 68
	}

	[Token(Token = "0x1700038F")]
	public abstract ScriptableObject ownerObject
	{
		[Token(Token = "0x600128E")]
		 get { } //Length: 0
		[Token(Token = "0x600128F")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000398")]
	public float referenceSpritePixelsPerUnit
	{
		[Address(RVA = "0x16D0800", Offset = "0x16CFC00", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60012A8")]
		 get { } //Length: 6
		[Address(RVA = "0x16D0A90", Offset = "0x16CFE90", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60012A9")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700039F")]
	internal override RepaintData repaintData
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60012B4")]
		internal get { } //Length: 8
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60012B5")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700039D")]
	internal abstract uint repaintVersion
	{
		[Token(Token = "0x60012B0")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000394")]
	public abstract IMGUIContainer rootIMGUIContainer
	{
		[Token(Token = "0x6001296")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000390")]
	public abstract SavePersistentViewData saveViewData
	{
		[Token(Token = "0x6001290")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000396")]
	internal float scale
	{
		[Address(RVA = "0x33FCF30", Offset = "0x33FC330", Length = "0x8")]
		[Token(Token = "0x60012A5")]
		internal get { } //Length: 8
		[Address(RVA = "0x33FD370", Offset = "0x33FC770", Length = "0xA6")]
		[Token(Token = "0x60012A6")]
		internal set { } //Length: 166
	}

	[Token(Token = "0x17000397")]
	public override float scaledPixelsPerPoint
	{
		[Address(RVA = "0x33FCF40", Offset = "0x33FC340", Length = "0xD")]
		[Token(Token = "0x60012A7")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170003A5")]
	internal TimerEventScheduler scheduler
	{
		[Address(RVA = "0x33FCF50", Offset = "0x33FC350", Length = "0x77")]
		[Token(Token = "0x60012C0")]
		internal get { } //Length: 119
	}

	[Token(Token = "0x170003A6")]
	internal abstract IStylePropertyAnimationSystem styleAnimationSystem
	{
		[Token(Token = "0x60012C1")]
		internal get { } //Length: 0
		[Token(Token = "0x60012C2")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 0
	}

	[Token(Token = "0x170003A8")]
	internal TimeFunction TimeSinceStartupFunc
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x60012C4")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000395")]
	internal UIElementsBridge uiElementsBridge
	{
		[Address(RVA = "0x33FCFD0", Offset = "0x33FC3D0", Length = "0x66")]
		[Token(Token = "0x6001299")]
		internal get { } //Length: 102
	}

	[Token(Token = "0x1700039C")]
	internal abstract uint version
	{
		[Token(Token = "0x60012AF")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x170003A3")]
	public abstract VisualElement visualTree
	{
		[Token(Token = "0x60012BC")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x33FC8F0", Offset = "0x33FBCF0", Length = "0x40")]
	[Token(Token = "0x60012E8")]
	private static BaseVisualElementPanel() { }

	[Address(RVA = "0x33FC930", Offset = "0x33FBD30", Length = "0x2C6")]
	[Token(Token = "0x600129A")]
	protected BaseVisualElementPanel() { }

	[Address(RVA = "0x33FCC00", Offset = "0x33FC000", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x60012DA")]
	internal void add_atlasChanged(Action value) { }

	[Address(RVA = "0x33FCCB0", Offset = "0x33FC0B0", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x60012DF")]
	internal void add_hierarchyChanged(HierarchyEvent value) { }

	[Address(RVA = "0x33FCD60", Offset = "0x33FC160", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x60012D5")]
	internal void add_isFlatChanged(Action value) { }

	[Address(RVA = "0x33FCE10", Offset = "0x33FC210", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6001297")]
	internal void add_panelDisposed(Action<BaseVisualElementPanel> value) { }

	[Token(Token = "0x60012A4")]
	public abstract void ApplyStyles() { }

	[Address(RVA = "0x33FB930", Offset = "0x33FAD30", Length = "0x30")]
	[Token(Token = "0x60012D3")]
	internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent) { }

	[Address(RVA = "0x33FB970", Offset = "0x33FAD70", Length = "0x70")]
	[Token(Token = "0x60012D4")]
	internal bool CommitElementUnderPointers() { }

	[Address(RVA = "0x33FB9F0", Offset = "0x33FADF0", Length = "0x28")]
	[Token(Token = "0x60012E7")]
	internal AbstractGenericMenu CreateMenu() { }

	[Address(RVA = "0x33FBA20", Offset = "0x33FAE20", Length = "0x7")]
	[Token(Token = "0x60012C7")]
	internal static double DefaultTimeSinceStartup() { }

	[Address(RVA = "0x33FBAA0", Offset = "0x33FAEA0", Length = "0x16E")]
	[Token(Token = "0x600129C")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x33FBA30", Offset = "0x33FAE30", Length = "0x61")]
	[Token(Token = "0x600129B")]
	public override void Dispose() { }

	[Token(Token = "0x60012DD")]
	public abstract AtlasBase get_atlas() { }

	[Address(RVA = "0x33FCEC0", Offset = "0x33FC2C0", Length = "0x14")]
	[CompilerGenerated]
	[Token(Token = "0x60012AA")]
	internal PanelClearSettings get_clearSettings() { }

	[Token(Token = "0x60012C3")]
	public abstract ContextType get_contextType() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60012B8")]
	public override ContextualMenuManager get_contextualMenuManager() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60012B6")]
	internal override ICursorManager get_cursorManager() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60012BA")]
	internal override DataBindingManager get_dataBindingManager() { }

	[Token(Token = "0x60012BD")]
	public abstract EventDispatcher get_dispatcher() { }

	[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60012CB")]
	internal bool get_disposed() { }

	[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60012AC")]
	internal bool get_duringLayoutPhase() { }

	[Token(Token = "0x6001294")]
	public abstract FocusController get_focusController() { }

	[Token(Token = "0x6001291")]
	public abstract GetViewDataDictionary get_getViewDataDictionary() { }

	[Token(Token = "0x60012B1")]
	internal abstract uint get_hierarchyVersion() { }

	[Token(Token = "0x6001292")]
	public abstract int get_IMGUIContainersCount() { }

	[Token(Token = "0x600128C")]
	public abstract EventInterests get_IMGUIEventInterests() { }

	[Address(RVA = "0x33FCEE0", Offset = "0x33FC2E0", Length = "0x49")]
	[Token(Token = "0x60012AE")]
	public override bool get_isDirty() { }

	[Address(RVA = "0x26CB620", Offset = "0x26CAA20", Length = "0x8")]
	[Token(Token = "0x60012D7")]
	public bool get_isFlat() { }

	[Token(Token = "0x600128E")]
	public abstract ScriptableObject get_ownerObject() { }

	[Address(RVA = "0x16D0800", Offset = "0x16CFC00", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60012A8")]
	public float get_referenceSpritePixelsPerUnit() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60012B4")]
	internal override RepaintData get_repaintData() { }

	[Token(Token = "0x60012B0")]
	internal abstract uint get_repaintVersion() { }

	[Token(Token = "0x6001296")]
	public abstract IMGUIContainer get_rootIMGUIContainer() { }

	[Token(Token = "0x6001290")]
	public abstract SavePersistentViewData get_saveViewData() { }

	[Address(RVA = "0x33FCF30", Offset = "0x33FC330", Length = "0x8")]
	[Token(Token = "0x60012A5")]
	internal float get_scale() { }

	[Address(RVA = "0x33FCF40", Offset = "0x33FC340", Length = "0xD")]
	[Token(Token = "0x60012A7")]
	public override float get_scaledPixelsPerPoint() { }

	[Address(RVA = "0x33FCF50", Offset = "0x33FC350", Length = "0x77")]
	[Token(Token = "0x60012C0")]
	internal TimerEventScheduler get_scheduler() { }

	[Token(Token = "0x60012C1")]
	internal abstract IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x60012C4")]
	internal TimeFunction get_TimeSinceStartupFunc() { }

	[Address(RVA = "0x33FCFD0", Offset = "0x33FC3D0", Length = "0x66")]
	[Token(Token = "0x6001299")]
	internal UIElementsBridge get_uiElementsBridge() { }

	[Token(Token = "0x60012AF")]
	internal abstract uint get_version() { }

	[Token(Token = "0x60012BC")]
	public abstract VisualElement get_visualTree() { }

	[Address(RVA = "0x33FBC10", Offset = "0x33FB010", Length = "0x21")]
	[Token(Token = "0x60012CE")]
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	[Token(Token = "0x60012CD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x33FBC40", Offset = "0x33FB040", Length = "0x1C")]
	[Token(Token = "0x60012DC")]
	protected void InvokeAtlasChanged() { }

	[Address(RVA = "0x33FBC60", Offset = "0x33FB060", Length = "0x1F")]
	[Token(Token = "0x60012E2")]
	internal void InvokeBeforeUpdate() { }

	[Address(RVA = "0x33FBC80", Offset = "0x33FB080", Length = "0x26")]
	[Token(Token = "0x60012E1")]
	internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

	[Token(Token = "0x60012B2")]
	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag) { }

	[Address(RVA = "0x33FBCB0", Offset = "0x33FB0B0", Length = "0x80")]
	[Token(Token = "0x60012C8")]
	public override VisualElement Pick(Vector2 point) { }

	[Token(Token = "0x60012C9")]
	public abstract VisualElement Pick(Vector2 point, int pointerId) { }

	[Token(Token = "0x60012CA")]
	public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked) { }

	[Address(RVA = "0x33FBD30", Offset = "0x33FB130", Length = "0x15D")]
	[Token(Token = "0x60012D2")]
	internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent) { }

	[Address(RVA = "0x33FD040", Offset = "0x33FC440", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x60012DB")]
	internal void remove_atlasChanged(Action value) { }

	[Address(RVA = "0x33FD0F0", Offset = "0x33FC4F0", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x60012E0")]
	internal void remove_hierarchyChanged(HierarchyEvent value) { }

	[Address(RVA = "0x33FD1A0", Offset = "0x33FC5A0", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x60012D6")]
	internal void remove_isFlatChanged(Action value) { }

	[Address(RVA = "0x33FD250", Offset = "0x33FC650", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6001298")]
	internal void remove_panelDisposed(Action<BaseVisualElementPanel> value) { }

	[Address(RVA = "0x33FBE90", Offset = "0x33FB290", Length = "0x21")]
	[Token(Token = "0x60012CF")]
	internal void RemoveElementFromPointerCache(VisualElement e) { }

	[Address(RVA = "0x33FBEC0", Offset = "0x33FB2C0", Length = "0x4C")]
	[Token(Token = "0x60012E6")]
	public override void Render() { }

	[Token(Token = "0x600129D")]
	public abstract void Repaint(Event e) { }

	[Address(RVA = "0x33FBF10", Offset = "0x33FB310", Length = "0x29D")]
	[Token(Token = "0x60012BF")]
	internal void SendEvent(EventBase e, DispatchMode dispatchMode = 1) { }

	[Token(Token = "0x60012DE")]
	public abstract void set_atlas(AtlasBase value) { }

	[Address(RVA = "0x33FD300", Offset = "0x33FC700", Length = "0x11")]
	[CompilerGenerated]
	[Token(Token = "0x60012AB")]
	internal void set_clearSettings(PanelClearSettings value) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60012B9")]
	internal void set_contextualMenuManager(ContextualMenuManager value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60012B7")]
	internal override void set_cursorManager(ICursorManager value) { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60012BB")]
	internal override void set_dataBindingManager(DataBindingManager value) { }

	[Token(Token = "0x60012BE")]
	public abstract void set_dispatcher(EventDispatcher value) { }

	[Address(RVA = "0x29E0AA0", Offset = "0x29DFEA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60012CC")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60012AD")]
	internal void set_duringLayoutPhase(bool value) { }

	[Token(Token = "0x6001295")]
	public abstract void set_focusController(FocusController value) { }

	[Token(Token = "0x6001293")]
	public abstract void set_IMGUIContainersCount(int value) { }

	[Token(Token = "0x600128D")]
	public abstract void set_IMGUIEventInterests(EventInterests value) { }

	[Address(RVA = "0x33FD320", Offset = "0x33FC720", Length = "0x44")]
	[Token(Token = "0x60012D8")]
	public void set_isFlat(bool value) { }

	[Token(Token = "0x600128F")]
	protected abstract void set_ownerObject(ScriptableObject value) { }

	[Address(RVA = "0x16D0A90", Offset = "0x16CFE90", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60012A9")]
	public void set_referenceSpritePixelsPerUnit(float value) { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60012B5")]
	internal override void set_repaintData(RepaintData value) { }

	[Address(RVA = "0x33FD370", Offset = "0x33FC770", Length = "0xA6")]
	[Token(Token = "0x60012A6")]
	internal void set_scale(float value) { }

	[Token(Token = "0x60012C2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal abstract void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	[Address(RVA = "0x33FC1B0", Offset = "0x33FB5B0", Length = "0x102")]
	[Token(Token = "0x60012D9")]
	internal void SetSpecializedHierarchyFlagsUpdater() { }

	[Address(RVA = "0x33FC300", Offset = "0x33FB700", Length = "0x30")]
	[Token(Token = "0x60012D0")]
	internal void SetTopElementUnderPointer(int pointerId, VisualElement element, EventBase triggerEvent) { }

	[Address(RVA = "0x33FC2C0", Offset = "0x33FB6C0", Length = "0x30")]
	[Token(Token = "0x60012D1")]
	internal void SetTopElementUnderPointer(int pointerId, VisualElement element, Vector2 position) { }

	[Token(Token = "0x60012B3")]
	internal abstract void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	[Token(Token = "0x600129F")]
	public abstract void TickSchedulingUpdaters() { }

	[Address(RVA = "0x33FC340", Offset = "0x33FB740", Length = "0x17B")]
	[Token(Token = "0x60012C5")]
	public long TimeSinceStartupMs() { }

	[Address(RVA = "0x33FC4C0", Offset = "0x33FB8C0", Length = "0x154")]
	[Token(Token = "0x60012C6")]
	public double TimeSinceStartupSeconds() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012E4")]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012E5")]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	[Token(Token = "0x60012A1")]
	public abstract void UpdateAnimations() { }

	[Token(Token = "0x60012A2")]
	public abstract void UpdateBindings() { }

	[Token(Token = "0x60012A3")]
	public abstract void UpdateDataBinding() { }

	[Address(RVA = "0x33FC620", Offset = "0x33FBA20", Length = "0x2CB")]
	[Token(Token = "0x60012E3")]
	internal bool UpdateElementUnderPointers() { }

	[Token(Token = "0x60012A0")]
	public abstract void UpdateForRepaint() { }

	[Token(Token = "0x600129E")]
	public abstract void ValidateLayout() { }

}

