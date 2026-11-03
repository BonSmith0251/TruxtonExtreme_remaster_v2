namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Pointer (1))]
[Token(Token = "0x20001F0")]
public abstract class MouseEventBase : EventBase<T>, IMouseEvent, IMouseEventInternal, IPointerOrMouseEvent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400086C")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400086D")]
	private Vector2 <mousePosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400086E")]
	private Vector2 <localMousePosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400086F")]
	private Vector2 <mouseDelta>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000870")]
	private int <clickCount>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000871")]
	private int <button>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000872")]
	private int <pressedButtons>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000873")]
	private IPointerEvent <sourcePointerEvent>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000874")]
	private bool <recomputeTopElementUnderMouse>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000280")]
	public override int button
	{
		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000DE5")]
		 get { } //Length: 7
		[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000DE6")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700027F")]
	public override int clickCount
	{
		[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000DE3")]
		 get { } //Length: 7
		[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000DE4")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000283")]
	public override bool commandKey
	{
		[Address(RVA = "0xAF07B0", Offset = "0xAEFBB0", Length = "0xA")]
		[Token(Token = "0x6000DEA")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000282")]
	public override bool ctrlKey
	{
		[Address(RVA = "0xAF07C0", Offset = "0xAEFBC0", Length = "0xA")]
		[Token(Token = "0x6000DE9")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000289")]
	public internal virtual IEventHandler currentTarget
	{
		[Address(RVA = "0xD11A60", Offset = "0xD10E60", Length = "0x19")]
		[Token(Token = "0x6000DF4")]
		 get { } //Length: 25
		[Address(RVA = "0xD11B20", Offset = "0xD10F20", Length = "0x109")]
		[Token(Token = "0x6000DF5")]
		internal set { } //Length: 265
	}

	[Token(Token = "0x1700027D")]
	public internal override Vector2 localMousePosition
	{
		[Address(RVA = "0xD11A80", Offset = "0xD10E80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000DDF")]
		 get { } //Length: 19
		[Address(RVA = "0xD11C30", Offset = "0xD11030", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DE0")]
		internal set { } //Length: 5
	}

	[Token(Token = "0x1700027B")]
	public override EventModifiers modifiers
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000DDB")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000DDC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700027E")]
	public override Vector2 mouseDelta
	{
		[Address(RVA = "0xD11AA0", Offset = "0xD10EA0", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x6000DE1")]
		 get { } //Length: 22
		[Address(RVA = "0xD11C40", Offset = "0xD11040", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DE2")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700027C")]
	public override Vector2 mousePosition
	{
		[Address(RVA = "0xD11AC0", Offset = "0xD10EC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000DDD")]
		 get { } //Length: 19
		[Address(RVA = "0xD11C50", Offset = "0xD11050", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DDE")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000281")]
	public override int pressedButtons
	{
		[Address(RVA = "0xD11AE0", Offset = "0xD10EE0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000DE7")]
		 get { } //Length: 7
		[Address(RVA = "0xD11C60", Offset = "0xD11060", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000DE8")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000285")]
	internal bool recomputeTopElementUnderMouse
	{
		[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000DED")]
		internal get { } //Length: 8
		[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000DEE")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000284")]
	internal IPointerEvent sourcePointerEvent
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000DEB")]
		internal get { } //Length: 8
		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000DEC")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000286")]
	private override IPointerEvent UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6000DEF")]
		private get { } //Length: 8
	}

	[Token(Token = "0x17000288")]
	private override Vector3 UnityEngine.UIElements.IPointerOrMouseEvent.deltaPosition
	{
		[Address(RVA = "0xD11990", Offset = "0xD10D90", Length = "0x21")]
		[Token(Token = "0x6000DF1")]
		private set { } //Length: 33
	}

	[Token(Token = "0x17000287")]
	private override Vector3 UnityEngine.UIElements.IPointerOrMouseEvent.position
	{
		[Address(RVA = "0xD11970", Offset = "0xD10D70", Length = "0x1D")]
		[Token(Token = "0x6000DF0")]
		private get { } //Length: 29
	}

	[Address(RVA = "0xD119C0", Offset = "0xD10DC0", Length = "0x7F")]
	[Token(Token = "0x6000DFD")]
	protected MouseEventBase`1() { }

	[Address(RVA = "0xD10730", Offset = "0xD0FB30", Length = "0x88")]
	[Token(Token = "0x6000DF8")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000DE5")]
	public override int get_button() { }

	[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000DE3")]
	public override int get_clickCount() { }

	[Address(RVA = "0xAF07B0", Offset = "0xAEFBB0", Length = "0xA")]
	[Token(Token = "0x6000DEA")]
	public override bool get_commandKey() { }

	[Address(RVA = "0xAF07C0", Offset = "0xAEFBC0", Length = "0xA")]
	[Token(Token = "0x6000DE9")]
	public override bool get_ctrlKey() { }

	[Address(RVA = "0xD11A60", Offset = "0xD10E60", Length = "0x19")]
	[Token(Token = "0x6000DF4")]
	public virtual IEventHandler get_currentTarget() { }

	[Address(RVA = "0xD11A80", Offset = "0xD10E80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000DDF")]
	public override Vector2 get_localMousePosition() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000DDB")]
	public override EventModifiers get_modifiers() { }

	[Address(RVA = "0xD11AA0", Offset = "0xD10EA0", Length = "0x16")]
	[CompilerGenerated]
	[Token(Token = "0x6000DE1")]
	public override Vector2 get_mouseDelta() { }

	[Address(RVA = "0xD11AC0", Offset = "0xD10EC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000DDD")]
	public override Vector2 get_mousePosition() { }

	[Address(RVA = "0xD11AE0", Offset = "0xD10EE0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000DE7")]
	public override int get_pressedButtons() { }

	[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000DED")]
	internal bool get_recomputeTopElementUnderMouse() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000DEB")]
	internal IPointerEvent get_sourcePointerEvent() { }

	[Address(RVA = "0xD10C90", Offset = "0xD10090", Length = "0x261")]
	[Token(Token = "0x6000DF9")]
	public static T GetPooled(Event systemEvent) { }

	[Address(RVA = "0xD107C0", Offset = "0xD0FBC0", Length = "0x4C2")]
	[Token(Token = "0x6000DFC")]
	protected static T GetPooled(IPointerEvent pointerEvent) { }

	[Address(RVA = "0xD11040", Offset = "0xD10440", Length = "0x2A9")]
	[Token(Token = "0x6000DFB")]
	public static T GetPooled(IMouseEvent triggerEvent) { }

	[Address(RVA = "0xD10F00", Offset = "0xD10300", Length = "0x134")]
	[Token(Token = "0x6000DFA")]
	internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition) { }

	[Address(RVA = "0xD112F0", Offset = "0xD106F0", Length = "0x4F")]
	[Token(Token = "0x6000DF2")]
	protected virtual void Init() { }

	[Address(RVA = "0xD11340", Offset = "0xD10740", Length = "0x116")]
	[Token(Token = "0x6000DF3")]
	private void LocalInit() { }

	[Address(RVA = "0xD11460", Offset = "0xD10860", Length = "0x194")]
	[Token(Token = "0x6000DF7")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0xD11600", Offset = "0xD10A00", Length = "0x360")]
	[Token(Token = "0x6000DF6")]
	protected private virtual void PreDispatch(IPanel panel) { }

	[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000DE6")]
	protected void set_button(int value) { }

	[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000DE4")]
	protected void set_clickCount(int value) { }

	[Address(RVA = "0xD11B20", Offset = "0xD10F20", Length = "0x109")]
	[Token(Token = "0x6000DF5")]
	internal virtual void set_currentTarget(IEventHandler value) { }

	[Address(RVA = "0xD11C30", Offset = "0xD11030", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000DE0")]
	internal void set_localMousePosition(Vector2 value) { }

	[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000DDC")]
	protected void set_modifiers(EventModifiers value) { }

	[Address(RVA = "0xD11C40", Offset = "0xD11040", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000DE2")]
	protected void set_mouseDelta(Vector2 value) { }

	[Address(RVA = "0xD11C50", Offset = "0xD11050", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000DDE")]
	protected void set_mousePosition(Vector2 value) { }

	[Address(RVA = "0xD11C60", Offset = "0xD11060", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000DE8")]
	protected void set_pressedButtons(int value) { }

	[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000DEE")]
	internal void set_recomputeTopElementUnderMouse(bool value) { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000DEC")]
	internal void set_sourcePointerEvent(IPointerEvent value) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6000DEF")]
	private override IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent() { }

	[Address(RVA = "0xD11970", Offset = "0xD10D70", Length = "0x1D")]
	[Token(Token = "0x6000DF0")]
	private override Vector3 UnityEngine.UIElements.IPointerOrMouseEvent.get_position() { }

	[Address(RVA = "0xD11990", Offset = "0xD10D90", Length = "0x21")]
	[Token(Token = "0x6000DF1")]
	private override void UnityEngine.UIElements.IPointerOrMouseEvent.set_deltaPosition(Vector3 value) { }

}

