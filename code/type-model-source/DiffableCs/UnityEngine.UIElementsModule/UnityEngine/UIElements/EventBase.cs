namespace UnityEngine.UIElements;

[Token(Token = "0x20001C4")]
public abstract class EventBase : IDisposable
{
	[Flags]
	[Token(Token = "0x20001C5")]
	public enum EventPropagation : int
	{
		None = 0,
		Bubbles = 1,
		TricklesDown = 2,
		SkipDisabledElements = 4,
		BubblesOrTricklesDown = 3,
	}

	[Flags]
	[Token(Token = "0x20001C6")]
	private enum LifeCycleStatus : int
	{
		None = 0,
		PropagationStopped = 1,
		ImmediatePropagationStopped = 2,
		Dispatching = 4,
		Pooled = 8,
		IMGUIEventIsValid = 16,
		PropagateToIMGUI = 32,
		Dispatched = 64,
		Processed = 128,
		ProcessedByFocusController = 256,
	}

	[Token(Token = "0x400080D")]
	private static long s_LastTypeId; //Field offset: 0x0
	[Token(Token = "0x400080F")]
	private static ulong s_NextEventId; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400080E")]
	private readonly int <eventCategories>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000810")]
	private long <timestamp>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000811")]
	private ulong <eventId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000812")]
	private ulong <triggerEventId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000813")]
	private EventPropagation <propagation>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000814")]
	private LifeCycleStatus <lifeCycleStatus>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000815")]
	private VisualElement <elementTarget>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000816")]
	private PropagationPhase <propagationPhase>k__BackingField; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000817")]
	private IEventHandler m_CurrentTarget; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000818")]
	private Event m_ImguiEvent; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000819")]
	private Vector2 <originalMousePosition>k__BackingField; //Field offset: 0x58

	[Token(Token = "0x17000247")]
	public bool bubbles
	{
		[Address(RVA = "0x33C9FC0", Offset = "0x33C93C0", Length = "0xA")]
		[Token(Token = "0x6000CCA")]
		 get { } //Length: 10
		[Address(RVA = "0x33CA0B0", Offset = "0x33C94B0", Length = "0x19")]
		[Token(Token = "0x6000CCB")]
		 set { } //Length: 25
	}

	[Token(Token = "0x1700024A")]
	internal bool bubblesOrTricklesDown
	{
		[Address(RVA = "0x33C9FB0", Offset = "0x33C93B0", Length = "0x8")]
		[Token(Token = "0x6000CD0")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000250")]
	public internal override IEventHandler currentTarget
	{
		[Address(RVA = "0x2F944D0", Offset = "0x2F938D0", Length = "0x7")]
		[Token(Token = "0x6000CDC")]
		 get { } //Length: 7
		[Address(RVA = "0x33CA0D0", Offset = "0x33C94D0", Length = "0x161")]
		[Token(Token = "0x6000CDD")]
		internal set { } //Length: 353
	}

	[Token(Token = "0x17000251")]
	public internal bool dispatch
	{
		[Address(RVA = "0x33C9FD0", Offset = "0x33C93D0", Length = "0xA")]
		[Token(Token = "0x6000CDE")]
		 get { } //Length: 10
		[Address(RVA = "0x33CA240", Offset = "0x33C9640", Length = "0x18")]
		[Token(Token = "0x6000CDF")]
		internal set { } //Length: 24
	}

	[Token(Token = "0x17000252")]
	private bool dispatched
	{
		[Address(RVA = "0x33C9FE0", Offset = "0x33C93E0", Length = "0xA")]
		[Token(Token = "0x6000CE1")]
		private get { } //Length: 10
		[Address(RVA = "0x33CA260", Offset = "0x33C9660", Length = "0x19")]
		[Token(Token = "0x6000CE2")]
		private set { } //Length: 25
	}

	[Token(Token = "0x1700024B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElement elementTarget
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD1")]
		internal get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD2")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000241")]
	internal int eventCategories
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBA")]
		internal get { } //Length: 85
	}

	[Token(Token = "0x17000243")]
	internal ulong eventId
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBD")]
		internal get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBE")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000240")]
	public override long eventTypeId
	{
		[Address(RVA = "0x1F521F0", Offset = "0x1F515F0", Length = "0x8")]
		[Token(Token = "0x6000CB9")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000257")]
	public Event imguiEvent
	{
		[Address(RVA = "0x33CA000", Offset = "0x33C9400", Length = "0x10")]
		[Token(Token = "0x6000CEB")]
		 get { } //Length: 16
		[Address(RVA = "0x33CA2A0", Offset = "0x33C96A0", Length = "0xC7")]
		[Token(Token = "0x6000CEC")]
		 set { } //Length: 199
	}

	[Token(Token = "0x17000256")]
	private bool imguiEventIsValid
	{
		[Address(RVA = "0x33C9FF0", Offset = "0x33C93F0", Length = "0xA")]
		[Token(Token = "0x6000CE9")]
		private get { } //Length: 10
		[Address(RVA = "0x33CA280", Offset = "0x33C9680", Length = "0x19")]
		[Token(Token = "0x6000CEA")]
		private set { } //Length: 25
	}

	[Token(Token = "0x1700024E")]
	public private bool isImmediatePropagationStopped
	{
		[Address(RVA = "0x33CA010", Offset = "0x33C9410", Length = "0xA")]
		[Token(Token = "0x6000CD8")]
		 get { } //Length: 10
		[Address(RVA = "0x33CA370", Offset = "0x33C9770", Length = "0x19")]
		[Token(Token = "0x6000CD9")]
		private set { } //Length: 25
	}

	[Token(Token = "0x1700024D")]
	public private bool isPropagationStopped
	{
		[Address(RVA = "0x33CA020", Offset = "0x33C9420", Length = "0xA")]
		[Token(Token = "0x6000CD5")]
		 get { } //Length: 10
		[Address(RVA = "0x33CA390", Offset = "0x33C9790", Length = "0x19")]
		[Token(Token = "0x6000CD6")]
		private set { } //Length: 25
	}

	[Token(Token = "0x17000246")]
	private LifeCycleStatus lifeCycleStatus
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC3")]
		private get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC4")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000258")]
	public private Vector2 originalMousePosition
	{
		[Address(RVA = "0x33CA030", Offset = "0x33C9430", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000CED")]
		 get { } //Length: 19
		[Address(RVA = "0x21448A0", Offset = "0x2143CA0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CEE")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000259")]
	protected bool pooled
	{
		[Address(RVA = "0x33CA050", Offset = "0x33C9450", Length = "0xA")]
		[Token(Token = "0x6000CF3")]
		 get { } //Length: 10
		[Address(RVA = "0x33CA3B0", Offset = "0x33C97B0", Length = "0x19")]
		[Token(Token = "0x6000CF4")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000253")]
	internal bool processed
	{
		[Address(RVA = "0x33CA070", Offset = "0x33C9470", Length = "0xD")]
		[Token(Token = "0x6000CE3")]
		internal get { } //Length: 13
		[Address(RVA = "0x33CA3F0", Offset = "0x33C97F0", Length = "0x1B")]
		[Token(Token = "0x6000CE4")]
		private set { } //Length: 27
	}

	[Token(Token = "0x17000254")]
	internal bool processedByFocusController
	{
		[Address(RVA = "0x33CA060", Offset = "0x33C9460", Length = "0xD")]
		[Token(Token = "0x6000CE5")]
		internal get { } //Length: 13
		[Address(RVA = "0x33CA3D0", Offset = "0x33C97D0", Length = "0x1B")]
		[Token(Token = "0x6000CE6")]
		internal set { } //Length: 27
	}

	[Token(Token = "0x17000255")]
	internal bool propagateToIMGUI
	{
		[Address(RVA = "0x33CA080", Offset = "0x33C9480", Length = "0xA")]
		[Token(Token = "0x6000CE7")]
		internal get { } //Length: 10
		[Address(RVA = "0x33CA410", Offset = "0x33C9810", Length = "0x19")]
		[Token(Token = "0x6000CE8")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x17000245")]
	internal EventPropagation propagation
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC1")]
		internal get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC2")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700024F")]
	internal PropagationPhase propagationPhase
	{
		[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000CDB")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000249")]
	internal bool skipDisabledElements
	{
		[Address(RVA = "0x33CA090", Offset = "0x33C9490", Length = "0xA")]
		[Token(Token = "0x6000CCE")]
		internal get { } //Length: 10
		[Address(RVA = "0x33CA430", Offset = "0x33C9830", Length = "0x19")]
		[Token(Token = "0x6000CCF")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x1700024C")]
	public IEventHandler target
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000CD3")]
		 get { } //Length: 5
		[Address(RVA = "0x33CA450", Offset = "0x33C9850", Length = "0x83")]
		[Token(Token = "0x6000CD4")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000242")]
	public private long timestamp
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBB")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBC")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000248")]
	public bool tricklesDown
	{
		[Address(RVA = "0x33CA0A0", Offset = "0x33C94A0", Length = "0xA")]
		[Token(Token = "0x6000CCC")]
		 get { } //Length: 10
		[Address(RVA = "0x33CA4E0", Offset = "0x33C98E0", Length = "0x19")]
		[Token(Token = "0x6000CCD")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000244")]
	private ulong triggerEventId
	{
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBF")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x33C9F70", Offset = "0x33C9370", Length = "0x39")]
	[Token(Token = "0x6000CF1")]
	protected EventBase() { }

	[Address(RVA = "0x33C9F20", Offset = "0x33C9320", Length = "0x4D")]
	[Token(Token = "0x6000CF2")]
	internal EventBase(EventCategory category) { }

	[Token(Token = "0x6000CF5")]
	internal abstract void Acquire() { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000CF7")]
	internal void AssignTimeStamp(long time) { }

	[Address(RVA = "0x33C9CB0", Offset = "0x33C90B0", Length = "0x44")]
	[Token(Token = "0x6000CC9")]
	internal override void Dispatch(BaseVisualElementPanel panel) { }

	[Token(Token = "0x6000CF6")]
	public abstract void Dispose() { }

	[Address(RVA = "0x33C9FC0", Offset = "0x33C93C0", Length = "0xA")]
	[Token(Token = "0x6000CCA")]
	public bool get_bubbles() { }

	[Address(RVA = "0x33C9FB0", Offset = "0x33C93B0", Length = "0x8")]
	[Token(Token = "0x6000CD0")]
	internal bool get_bubblesOrTricklesDown() { }

	[Address(RVA = "0x2F944D0", Offset = "0x2F938D0", Length = "0x7")]
	[Token(Token = "0x6000CDC")]
	public override IEventHandler get_currentTarget() { }

	[Address(RVA = "0x33C9FD0", Offset = "0x33C93D0", Length = "0xA")]
	[Token(Token = "0x6000CDE")]
	public bool get_dispatch() { }

	[Address(RVA = "0x33C9FE0", Offset = "0x33C93E0", Length = "0xA")]
	[Token(Token = "0x6000CE1")]
	private bool get_dispatched() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD1")]
	internal VisualElement get_elementTarget() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBA")]
	internal int get_eventCategories() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBD")]
	internal ulong get_eventId() { }

	[Address(RVA = "0x1F521F0", Offset = "0x1F515F0", Length = "0x8")]
	[Token(Token = "0x6000CB9")]
	public override long get_eventTypeId() { }

	[Address(RVA = "0x33CA000", Offset = "0x33C9400", Length = "0x10")]
	[Token(Token = "0x6000CEB")]
	public Event get_imguiEvent() { }

	[Address(RVA = "0x33C9FF0", Offset = "0x33C93F0", Length = "0xA")]
	[Token(Token = "0x6000CE9")]
	private bool get_imguiEventIsValid() { }

	[Address(RVA = "0x33CA010", Offset = "0x33C9410", Length = "0xA")]
	[Token(Token = "0x6000CD8")]
	public bool get_isImmediatePropagationStopped() { }

	[Address(RVA = "0x33CA020", Offset = "0x33C9420", Length = "0xA")]
	[Token(Token = "0x6000CD5")]
	public bool get_isPropagationStopped() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC3")]
	private LifeCycleStatus get_lifeCycleStatus() { }

	[Address(RVA = "0x33CA030", Offset = "0x33C9430", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000CED")]
	public Vector2 get_originalMousePosition() { }

	[Address(RVA = "0x33CA050", Offset = "0x33C9450", Length = "0xA")]
	[Token(Token = "0x6000CF3")]
	protected bool get_pooled() { }

	[Address(RVA = "0x33CA070", Offset = "0x33C9470", Length = "0xD")]
	[Token(Token = "0x6000CE3")]
	internal bool get_processed() { }

	[Address(RVA = "0x33CA060", Offset = "0x33C9460", Length = "0xD")]
	[Token(Token = "0x6000CE5")]
	internal bool get_processedByFocusController() { }

	[Address(RVA = "0x33CA080", Offset = "0x33C9480", Length = "0xA")]
	[Token(Token = "0x6000CE7")]
	internal bool get_propagateToIMGUI() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC1")]
	internal EventPropagation get_propagation() { }

	[Address(RVA = "0x33CA090", Offset = "0x33C9490", Length = "0xA")]
	[Token(Token = "0x6000CCE")]
	internal bool get_skipDisabledElements() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000CD3")]
	public IEventHandler get_target() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBB")]
	public long get_timestamp() { }

	[Address(RVA = "0x33CA0A0", Offset = "0x33C94A0", Length = "0xA")]
	[Token(Token = "0x6000CCC")]
	public bool get_tricklesDown() { }

	[Address(RVA = "0x33C9D00", Offset = "0x33C9100", Length = "0x7")]
	[Token(Token = "0x6000CEF")]
	protected override void Init() { }

	[Address(RVA = "0x33C9D10", Offset = "0x33C9110", Length = "0xE6")]
	[Token(Token = "0x6000CF0")]
	private void LocalInit() { }

	[Address(RVA = "0x33C9E00", Offset = "0x33C9200", Length = "0x73")]
	[Token(Token = "0x6000CE0")]
	internal void MarkReceivedByDispatcher() { }

	[Address(RVA = "0x33C9E80", Offset = "0x33C9280", Length = "0x29")]
	[Token(Token = "0x6000CC8")]
	protected private override void PostDispatch(IPanel panel) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("Override PostDispatch(IPanel panel) instead.")]
	[Token(Token = "0x6000CC7")]
	protected override void PostDispatch() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("Override PreDispatch(IPanel panel) instead.")]
	[Token(Token = "0x6000CC5")]
	protected override void PreDispatch() { }

	[Address(RVA = "0x23326B0", Offset = "0x2331AB0", Length = "0x14")]
	[Token(Token = "0x6000CC6")]
	protected private override void PreDispatch(IPanel panel) { }

	[Address(RVA = "0x33C9EB0", Offset = "0x33C92B0", Length = "0x43")]
	[Token(Token = "0x6000CB8")]
	protected static long RegisterEventType() { }

	[Address(RVA = "0x33CA0B0", Offset = "0x33C94B0", Length = "0x19")]
	[Token(Token = "0x6000CCB")]
	protected void set_bubbles(bool value) { }

	[Address(RVA = "0x33CA0D0", Offset = "0x33C94D0", Length = "0x161")]
	[Token(Token = "0x6000CDD")]
	internal override void set_currentTarget(IEventHandler value) { }

	[Address(RVA = "0x33CA240", Offset = "0x33C9640", Length = "0x18")]
	[Token(Token = "0x6000CDF")]
	internal void set_dispatch(bool value) { }

	[Address(RVA = "0x33CA260", Offset = "0x33C9660", Length = "0x19")]
	[Token(Token = "0x6000CE2")]
	private void set_dispatched(bool value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD2")]
	internal void set_elementTarget(VisualElement value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBE")]
	private void set_eventId(ulong value) { }

	[Address(RVA = "0x33CA2A0", Offset = "0x33C96A0", Length = "0xC7")]
	[Token(Token = "0x6000CEC")]
	protected void set_imguiEvent(Event value) { }

	[Address(RVA = "0x33CA280", Offset = "0x33C9680", Length = "0x19")]
	[Token(Token = "0x6000CEA")]
	private void set_imguiEventIsValid(bool value) { }

	[Address(RVA = "0x33CA370", Offset = "0x33C9770", Length = "0x19")]
	[Token(Token = "0x6000CD9")]
	private void set_isImmediatePropagationStopped(bool value) { }

	[Address(RVA = "0x33CA390", Offset = "0x33C9790", Length = "0x19")]
	[Token(Token = "0x6000CD6")]
	private void set_isPropagationStopped(bool value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC4")]
	private void set_lifeCycleStatus(LifeCycleStatus value) { }

	[Address(RVA = "0x21448A0", Offset = "0x2143CA0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CEE")]
	private void set_originalMousePosition(Vector2 value) { }

	[Address(RVA = "0x33CA3B0", Offset = "0x33C97B0", Length = "0x19")]
	[Token(Token = "0x6000CF4")]
	protected void set_pooled(bool value) { }

	[Address(RVA = "0x33CA3F0", Offset = "0x33C97F0", Length = "0x1B")]
	[Token(Token = "0x6000CE4")]
	private void set_processed(bool value) { }

	[Address(RVA = "0x33CA3D0", Offset = "0x33C97D0", Length = "0x1B")]
	[Token(Token = "0x6000CE6")]
	internal void set_processedByFocusController(bool value) { }

	[Address(RVA = "0x33CA410", Offset = "0x33C9810", Length = "0x19")]
	[Token(Token = "0x6000CE8")]
	internal void set_propagateToIMGUI(bool value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC2")]
	internal void set_propagation(EventPropagation value) { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000CDB")]
	internal void set_propagationPhase(PropagationPhase value) { }

	[Address(RVA = "0x33CA430", Offset = "0x33C9830", Length = "0x19")]
	[Token(Token = "0x6000CCF")]
	internal void set_skipDisabledElements(bool value) { }

	[Address(RVA = "0x33CA450", Offset = "0x33C9850", Length = "0x83")]
	[Token(Token = "0x6000CD4")]
	public void set_target(IEventHandler value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBC")]
	private void set_timestamp(long value) { }

	[Address(RVA = "0x33CA4E0", Offset = "0x33C98E0", Length = "0x19")]
	[Token(Token = "0x6000CCD")]
	protected void set_tricklesDown(bool value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBF")]
	private void set_triggerEventId(ulong value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[Token(Token = "0x6000CC0")]
	internal void SetTriggerEventId(ulong id) { }

	[Address(RVA = "0x33C9F00", Offset = "0x33C9300", Length = "0xF")]
	[Token(Token = "0x6000CDA")]
	public void StopImmediatePropagation() { }

	[Address(RVA = "0x33C9F10", Offset = "0x33C9310", Length = "0x7")]
	[Token(Token = "0x6000CD7")]
	public void StopPropagation() { }

}

