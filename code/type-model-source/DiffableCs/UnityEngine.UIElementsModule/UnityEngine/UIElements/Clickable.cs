namespace UnityEngine.UIElements;

[Token(Token = "0x2000052")]
public class Clickable : PointerManipulator
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000188")]
	private Action<EventBase> clickedWithEventInfo; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000189")]
	private Action clicked; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400018A")]
	private readonly long m_Delay; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400018B")]
	private readonly long m_Interval; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400018C")]
	private bool <active>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400018D")]
	private Vector2 <lastMousePosition>k__BackingField; //Field offset: 0x4C
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400018E")]
	private int m_ActivePointerId; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400018F")]
	private bool m_AcceptClicksIfDisabled; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000190")]
	private IVisualElementScheduledItem m_Repeater; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000191")]
	private IVisualElementScheduledItem m_PendingActivePseudoStateReset; //Field offset: 0x68

	[Token(Token = "0x14000005")]
	public event Action clicked
	{
		[Address(RVA = "0x3221670", Offset = "0x3220A70", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000256")]
		 add { } //Length: 158
		[Address(RVA = "0x32217C0", Offset = "0x3220BC0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000257")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000004")]
	public event Action<EventBase> clickedWithEventInfo
	{
		[Address(RVA = "0x32215C0", Offset = "0x32209C0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000254")]
		 add { } //Length: 172
		[Address(RVA = "0x3221710", Offset = "0x3220B10", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000255")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x17000054")]
	internal bool acceptClicksIfDisabled
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[Token(Token = "0x600025C")]
		internal get { } //Length: 5
		[Address(RVA = "0x3221860", Offset = "0x3220C60", Length = "0x6B")]
		[Token(Token = "0x600025D")]
		internal set { } //Length: 107
	}

	[Token(Token = "0x17000052")]
	protected bool active
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000258")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000259")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000055")]
	private InvokePolicy invokePolicy
	{
		[Address(RVA = "0x1D4F6E0", Offset = "0x1D4EAE0", Length = "0xB")]
		[Token(Token = "0x600025E")]
		private get { } //Length: 11
	}

	[Token(Token = "0x17000053")]
	public private Vector2 lastMousePosition
	{
		[Address(RVA = "0x2E63A70", Offset = "0x2E62E70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600025A")]
		 get { } //Length: 19
		[Address(RVA = "0x32218D0", Offset = "0x3220CD0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600025B")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x3221490", Offset = "0x3220890", Length = "0x123")]
	[Token(Token = "0x6000261")]
	public Clickable(Action handler) { }

	[Address(RVA = "0x3221370", Offset = "0x3220770", Length = "0x11B")]
	[Token(Token = "0x6000260")]
	public Clickable(Action<EventBase> handler) { }

	[Address(RVA = "0x3221230", Offset = "0x3220630", Length = "0x138")]
	[Token(Token = "0x600025F")]
	public Clickable(Action handler, long delay, long interval) { }

	[Address(RVA = "0x3221670", Offset = "0x3220A70", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000256")]
	public void add_clicked(Action value) { }

	[Address(RVA = "0x32215C0", Offset = "0x32209C0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000254")]
	public void add_clickedWithEventInfo(Action<EventBase> value) { }

	[Address(RVA = "0x3220080", Offset = "0x321F480", Length = "0x7D")]
	[Token(Token = "0x600026B")]
	private bool ContainsPointer(int pointerId) { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[Token(Token = "0x600025C")]
	internal bool get_acceptClicksIfDisabled() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000258")]
	protected bool get_active() { }

	[Address(RVA = "0x1D4F6E0", Offset = "0x1D4EAE0", Length = "0xB")]
	[Token(Token = "0x600025E")]
	private InvokePolicy get_invokePolicy() { }

	[Address(RVA = "0x2E63A70", Offset = "0x2E62E70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600025A")]
	public Vector2 get_lastMousePosition() { }

	[Address(RVA = "0x3220100", Offset = "0x321F500", Length = "0x4C")]
	[Token(Token = "0x600026C")]
	protected void Invoke(EventBase evt) { }

	[Address(RVA = "0x3220150", Offset = "0x321F550", Length = "0x17")]
	[Token(Token = "0x6000263")]
	private bool IsRepeatable() { }

	[Address(RVA = "0x3220170", Offset = "0x321F570", Length = "0x79")]
	[Token(Token = "0x6000269")]
	private void OnPointerCancel(PointerCancelEvent evt) { }

	[Address(RVA = "0x32201F0", Offset = "0x321F5F0", Length = "0x64")]
	[Token(Token = "0x600026A")]
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	[Address(RVA = "0x3220260", Offset = "0x321F660", Length = "0xA2")]
	[Token(Token = "0x6000266")]
	protected void OnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0x3220310", Offset = "0x321F710", Length = "0x77")]
	[Token(Token = "0x6000267")]
	protected void OnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0x3220390", Offset = "0x321F790", Length = "0xA2")]
	[Token(Token = "0x6000268")]
	protected void OnPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x3220440", Offset = "0x321F840", Length = "0xDF")]
	[Token(Token = "0x6000262")]
	private void OnTimer(TimerState timerState) { }

	[Address(RVA = "0x3220520", Offset = "0x321F920", Length = "0x103")]
	[Token(Token = "0x6000272")]
	protected override void ProcessCancelEvent(EventBase evt, int pointerId) { }

	[Address(RVA = "0x3220630", Offset = "0x321FA30", Length = "0x2CE")]
	[Token(Token = "0x600026F")]
	protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x3220900", Offset = "0x321FD00", Length = "0x6B")]
	[Token(Token = "0x6000270")]
	protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	[Address(RVA = "0x3220970", Offset = "0x321FD70", Length = "0x171")]
	[Token(Token = "0x6000271")]
	protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x3220AF0", Offset = "0x321FEF0", Length = "0x2C3")]
	[Token(Token = "0x6000264")]
	protected virtual void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x32217C0", Offset = "0x3220BC0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000257")]
	public void remove_clicked(Action value) { }

	[Address(RVA = "0x3221710", Offset = "0x3220B10", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000255")]
	public void remove_clickedWithEventInfo(Action<EventBase> value) { }

	[Address(RVA = "0x3220DC0", Offset = "0x32201C0", Length = "0x4C")]
	[Token(Token = "0x600026E")]
	private void ResetActivePseudoState() { }

	[Address(RVA = "0x3221860", Offset = "0x3220C60", Length = "0x6B")]
	[Token(Token = "0x600025D")]
	internal void set_acceptClicksIfDisabled(bool value) { }

	[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000259")]
	protected void set_active(bool value) { }

	[Address(RVA = "0x32218D0", Offset = "0x3220CD0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600025B")]
	private void set_lastMousePosition(Vector2 value) { }

	[Address(RVA = "0x3220E10", Offset = "0x3220210", Length = "0x163")]
	[Token(Token = "0x600026D")]
	internal void SimulateSingleClick(EventBase evt, int delayMs = 100) { }

	[Address(RVA = "0x3220F80", Offset = "0x3220380", Length = "0x2AC")]
	[Token(Token = "0x6000265")]
	protected virtual void UnregisterCallbacksFromTarget() { }

}

