namespace UnityEngine.UIElements;

[Token(Token = "0x20001AE")]
public sealed class EventDispatcher
{
	[CompilerGenerated]
	[Token(Token = "0x20001B1")]
	private sealed class <>c
	{
		[Token(Token = "0x40007FA")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33DF6C0", Offset = "0x33DEAC0", Length = "0x67")]
		[Token(Token = "0x6000C6E")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C6F")]
		public <>c() { }

		[Address(RVA = "0x33DF290", Offset = "0x33DE690", Length = "0x55")]
		[Token(Token = "0x6000C70")]
		internal Queue<EventRecord> <.cctor>b__35_0() { }

	}

	[Token(Token = "0x20001B0")]
	private struct DispatchContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007F8")]
		public uint m_GateCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007F9")]
		public Queue<EventRecord> m_Queue; //Field offset: 0x8

	}

	[Token(Token = "0x20001AF")]
	private struct EventRecord
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007F6")]
		public EventBase m_Event; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007F7")]
		public BaseVisualElementPanel m_Panel; //Field offset: 0x8

	}

	[Token(Token = "0x40007E9")]
	private static readonly ObjectPool<Queue`1<EventRecord>> k_EventQueuePool; //Field offset: 0x0
	[Token(Token = "0x40007EE")]
	internal const int k_MaxGateDepth = 500; //Field offset: 0x0
	[Token(Token = "0x40007EF")]
	internal const int k_NumberOfEventsWithStackInfo = 10; //Field offset: 0x0
	[Token(Token = "0x40007F0")]
	internal const int k_NumberOfEventsWithEventInfo = 100; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007E8")]
	internal ClickDetector m_ClickDetector; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007EA")]
	private Queue<EventRecord> m_Queue; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007EB")]
	private readonly PointerDispatchState <pointerState>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007EC")]
	private uint m_GateCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40007ED")]
	private uint m_GateDepth; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007F1")]
	private int m_DispatchStackFrame; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007F2")]
	private EventBase m_CurrentEvent; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007F3")]
	private Stack<DispatchContext> m_DispatchContexts; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007F4")]
	private bool m_Immediate; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x40007F5")]
	private bool <processingEvents>k__BackingField; //Field offset: 0x49

	[Token(Token = "0x17000239")]
	private bool dispatchImmediately
	{
		[Address(RVA = "0x33CEBA0", Offset = "0x33CDFA0", Length = "0x15")]
		[Token(Token = "0x6000C65")]
		private get { } //Length: 21
	}

	[Token(Token = "0x17000238")]
	internal PointerDispatchState pointerState
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C62")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700023A")]
	private bool processingEvents
	{
		[Address(RVA = "0x2E37650", Offset = "0x2E36A50", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C66")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x33CE930", Offset = "0x33CDD30", Length = "0x107")]
	[Token(Token = "0x6000C6D")]
	private static EventDispatcher() { }

	[Address(RVA = "0x33CEA40", Offset = "0x33CDE40", Length = "0x152")]
	[Obsolete("Please use EventDispatcher.CreateDefault().")]
	[Token(Token = "0x6000C64")]
	internal EventDispatcher() { }

	[Address(RVA = "0x33CDAE0", Offset = "0x33CCEE0", Length = "0x7")]
	[Token(Token = "0x6000C69")]
	internal void CloseGate() { }

	[Address(RVA = "0x33CDAF0", Offset = "0x33CCEF0", Length = "0x17E")]
	[Token(Token = "0x6000C63")]
	internal static EventDispatcher CreateDefault() { }

	[Address(RVA = "0x33CDC70", Offset = "0x33CD070", Length = "0x1FA")]
	[Token(Token = "0x6000C67")]
	internal void Dispatch(EventBase evt, BaseVisualElementPanel panel, DispatchMode dispatchMode) { }

	[Address(RVA = "0x33CEBA0", Offset = "0x33CDFA0", Length = "0x15")]
	[Token(Token = "0x6000C65")]
	private bool get_dispatchImmediately() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C62")]
	internal PointerDispatchState get_pointerState() { }

	[Address(RVA = "0x33CDE70", Offset = "0x33CD270", Length = "0x3E9")]
	[Token(Token = "0x6000C68")]
	private bool HandleRecursiveState(EventBase evt) { }

	[Address(RVA = "0x33CE260", Offset = "0x33CD660", Length = "0xDD")]
	[Token(Token = "0x6000C6A")]
	internal void OpenGate() { }

	[Address(RVA = "0x33CE5E0", Offset = "0x33CD9E0", Length = "0x349")]
	[Token(Token = "0x6000C6C")]
	private void ProcessEvent(EventBase evt, BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33CE340", Offset = "0x33CD740", Length = "0x297")]
	[Token(Token = "0x6000C6B")]
	private void ProcessEventQueue() { }

	[Address(RVA = "0x2E37650", Offset = "0x2E36A50", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C66")]
	private void set_processingEvents(bool value) { }

}

