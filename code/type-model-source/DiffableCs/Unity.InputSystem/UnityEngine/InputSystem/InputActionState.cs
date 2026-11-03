namespace UnityEngine.InputSystem;

[Token(Token = "0x2000045")]
internal class InputActionState : IInputStateChangeMonitor, ICloneable, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x200004F")]
	private sealed class <>c
	{
		[Token(Token = "0x40001EE")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001EF")]
		public static TypedRestore<GlobalState> <>9__143_0; //Field offset: 0x8
		[Token(Token = "0x40001F0")]
		public static Action <>9__143_1; //Field offset: 0x10

		[Address(RVA = "0x290BB00", Offset = "0x290AF00", Length = "0x67")]
		[Token(Token = "0x60003D5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60003D6")]
		public <>c() { }

		[Address(RVA = "0x290B670", Offset = "0x290AA70", Length = "0x16C")]
		[Token(Token = "0x60003D7")]
		internal void <SaveAndResetState>b__143_0(ref GlobalState state) { }

		[Address(RVA = "0x290B7E0", Offset = "0x290ABE0", Length = "0x40")]
		[Token(Token = "0x60003D8")]
		internal void <SaveAndResetState>b__143_1() { }

	}

	[Token(Token = "0x200004C")]
	internal struct ActionMapIndices
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001CC")]
		public int actionStartIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40001CD")]
		public int actionCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001CE")]
		public int controlStartIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40001CF")]
		public int controlCount; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001D0")]
		public int bindingStartIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001D1")]
		public int bindingCount; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001D2")]
		public int interactionStartIndex; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001D3")]
		public int interactionCount; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D4")]
		public int processorStartIndex; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40001D5")]
		public int processorCount; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001D6")]
		public int compositeStartIndex; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40001D7")]
		public int compositeCount; //Field offset: 0x2C

	}

	[Token(Token = "0x2000048")]
	public struct BindingState
	{
		[Flags]
		[Token(Token = "0x2000049")]
		internal enum Flags : int
		{
			ChainsWithNext = 1,
			EndOfChain = 2,
			Composite = 4,
			PartOfComposite = 8,
			InitialStateCheckPending = 16,
			WantsInitialStateCheck = 32,
		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019A")]
		private byte m_ControlCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x400019B")]
		private byte m_InteractionCount; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x400019C")]
		private byte m_ProcessorCount; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x400019D")]
		private byte m_MapIndex; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400019E")]
		private byte m_Flags; //Field offset: 0x4
		[FieldOffset(Offset = "0x5")]
		[Token(Token = "0x400019F")]
		private byte m_PartIndex; //Field offset: 0x5
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x40001A0")]
		private ushort m_ActionIndex; //Field offset: 0x6
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001A1")]
		private ushort m_CompositeOrCompositeBindingIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0xA")]
		[Token(Token = "0x40001A2")]
		private ushort m_ProcessorStartIndex; //Field offset: 0xA
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40001A3")]
		private ushort m_InteractionStartIndex; //Field offset: 0xC
		[FieldOffset(Offset = "0xE")]
		[Token(Token = "0x40001A4")]
		private ushort m_ControlStartIndex; //Field offset: 0xE
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A5")]
		private double m_PressTime; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001A6")]
		private int m_TriggerEventIdForComposite; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001A7")]
		private int __padding; //Field offset: 0x1C

		[Token(Token = "0x170000FB")]
		public int actionIndex
		{
			[Address(RVA = "0x28F82D0", Offset = "0x28F76D0", Length = "0x16")]
			[Token(Token = "0x6000385")]
			 get { } //Length: 22
			[Address(RVA = "0x28F83F0", Offset = "0x28F77F0", Length = "0xA7")]
			[Token(Token = "0x6000386")]
			 set { } //Length: 167
		}

		[Token(Token = "0x17000101")]
		public bool chainsWithNext
		{
			[Address(RVA = "0x28F82F0", Offset = "0x28F76F0", Length = "0x7")]
			[Token(Token = "0x6000391")]
			 get { } //Length: 7
			[Address(RVA = "0x28F84A0", Offset = "0x28F78A0", Length = "0x21")]
			[Token(Token = "0x6000392")]
			 set { } //Length: 33
		}

		[Token(Token = "0x170000FD")]
		public int compositeOrCompositeBindingIndex
		{
			[Address(RVA = "0x28F8300", Offset = "0x28F7700", Length = "0x16")]
			[Token(Token = "0x6000389")]
			 get { } //Length: 22
			[Address(RVA = "0x28F84D0", Offset = "0x28F78D0", Length = "0xA7")]
			[Token(Token = "0x600038A")]
			 set { } //Length: 167
		}

		[Token(Token = "0x170000F6")]
		public int controlCount
		{
			[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
			[Token(Token = "0x600037B")]
			 get { } //Length: 4
			[Address(RVA = "0x28F8580", Offset = "0x28F7980", Length = "0x94")]
			[Token(Token = "0x600037C")]
			 set { } //Length: 148
		}

		[Token(Token = "0x170000F5")]
		public int controlStartIndex
		{
			[Address(RVA = "0x28F8320", Offset = "0x28F7720", Length = "0x5")]
			[Token(Token = "0x6000379")]
			 get { } //Length: 5
			[Address(RVA = "0x28F8620", Offset = "0x28F7A20", Length = "0x97")]
			[Token(Token = "0x600037A")]
			 set { } //Length: 151
		}

		[Token(Token = "0x17000100")]
		public Flags flags
		{
			[Address(RVA = "0xAEF1A0", Offset = "0xAEE5A0", Length = "0x5")]
			[Token(Token = "0x600038F")]
			 get { } //Length: 5
			[Address(RVA = "0x1E16980", Offset = "0x1E15D80", Length = "0x4")]
			[Token(Token = "0x6000390")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000106")]
		public bool initialStateCheckPending
		{
			[Address(RVA = "0x28F8330", Offset = "0x28F7730", Length = "0x8")]
			[Token(Token = "0x600039A")]
			 get { } //Length: 8
			[Address(RVA = "0x28F86C0", Offset = "0x28F7AC0", Length = "0x21")]
			[Token(Token = "0x600039B")]
			 set { } //Length: 33
		}

		[Token(Token = "0x170000F8")]
		public int interactionCount
		{
			[Address(RVA = "0xDA0E10", Offset = "0xDA0210", Length = "0x5")]
			[Token(Token = "0x600037F")]
			 get { } //Length: 5
			[Address(RVA = "0x28F86F0", Offset = "0x28F7AF0", Length = "0x95")]
			[Token(Token = "0x6000380")]
			 set { } //Length: 149
		}

		[Token(Token = "0x170000F7")]
		public int interactionStartIndex
		{
			[Address(RVA = "0x28F8340", Offset = "0x28F7740", Length = "0x16")]
			[Token(Token = "0x600037D")]
			 get { } //Length: 22
			[Address(RVA = "0x28F8790", Offset = "0x28F7B90", Length = "0xA7")]
			[Token(Token = "0x600037E")]
			 set { } //Length: 167
		}

		[Token(Token = "0x17000104")]
		public bool isComposite
		{
			[Address(RVA = "0x28F8360", Offset = "0x28F7760", Length = "0xA")]
			[Token(Token = "0x6000396")]
			 get { } //Length: 10
			[Address(RVA = "0x28F8840", Offset = "0x28F7C40", Length = "0x21")]
			[Token(Token = "0x6000397")]
			 set { } //Length: 33
		}

		[Token(Token = "0x17000102")]
		public bool isEndOfChain
		{
			[Address(RVA = "0x28F8370", Offset = "0x28F7770", Length = "0x9")]
			[Token(Token = "0x6000393")]
			 get { } //Length: 9
			[Address(RVA = "0x28F8870", Offset = "0x28F7C70", Length = "0x21")]
			[Token(Token = "0x6000394")]
			 set { } //Length: 33
		}

		[Token(Token = "0x17000103")]
		public bool isPartOfChain
		{
			[Address(RVA = "0x28F8380", Offset = "0x28F7780", Length = "0x12")]
			[Token(Token = "0x6000395")]
			 get { } //Length: 18
		}

		[Token(Token = "0x17000105")]
		public bool isPartOfComposite
		{
			[Address(RVA = "0x28F83A0", Offset = "0x28F77A0", Length = "0xA")]
			[Token(Token = "0x6000398")]
			 get { } //Length: 10
			[Address(RVA = "0x28F88A0", Offset = "0x28F7CA0", Length = "0x21")]
			[Token(Token = "0x6000399")]
			 set { } //Length: 33
		}

		[Token(Token = "0x170000FC")]
		public int mapIndex
		{
			[Address(RVA = "0x604A20", Offset = "0x603E20", Length = "0x5")]
			[Token(Token = "0x6000387")]
			 get { } //Length: 5
			[Address(RVA = "0x28F88D0", Offset = "0x28F7CD0", Length = "0x95")]
			[Token(Token = "0x6000388")]
			 set { } //Length: 149
		}

		[Token(Token = "0x17000108")]
		public int partIndex
		{
			[Address(RVA = "0x28F83B0", Offset = "0x28F77B0", Length = "0x5")]
			[Token(Token = "0x600039E")]
			 get { } //Length: 5
			[Address(RVA = "0x28F8970", Offset = "0x28F7D70", Length = "0x6")]
			[Token(Token = "0x600039F")]
			 set { } //Length: 6
		}

		[Token(Token = "0x170000FF")]
		public double pressTime
		{
			[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
			[Token(Token = "0x600038D")]
			 get { } //Length: 6
			[Address(RVA = "0x28F8980", Offset = "0x28F7D80", Length = "0x6")]
			[Token(Token = "0x600038E")]
			 set { } //Length: 6
		}

		[Token(Token = "0x170000FA")]
		public int processorCount
		{
			[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
			[Token(Token = "0x6000383")]
			 get { } //Length: 5
			[Address(RVA = "0x28F8990", Offset = "0x28F7D90", Length = "0x95")]
			[Token(Token = "0x6000384")]
			 set { } //Length: 149
		}

		[Token(Token = "0x170000F9")]
		public int processorStartIndex
		{
			[Address(RVA = "0x28F83C0", Offset = "0x28F77C0", Length = "0x16")]
			[Token(Token = "0x6000381")]
			 get { } //Length: 22
			[Address(RVA = "0x28F8A30", Offset = "0x28F7E30", Length = "0xA7")]
			[Token(Token = "0x6000382")]
			 set { } //Length: 167
		}

		[Token(Token = "0x170000FE")]
		public int triggerEventIdForComposite
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x600038B")]
			 get { } //Length: 4
			[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
			[Token(Token = "0x600038C")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000107")]
		public bool wantsInitialStateCheck
		{
			[Address(RVA = "0x28F83E0", Offset = "0x28F77E0", Length = "0x8")]
			[Token(Token = "0x600039C")]
			 get { } //Length: 8
			[Address(RVA = "0x28F8AE0", Offset = "0x28F7EE0", Length = "0x21")]
			[Token(Token = "0x600039D")]
			 set { } //Length: 33
		}

		[Address(RVA = "0x28F82D0", Offset = "0x28F76D0", Length = "0x16")]
		[Token(Token = "0x6000385")]
		public int get_actionIndex() { }

		[Address(RVA = "0x28F82F0", Offset = "0x28F76F0", Length = "0x7")]
		[Token(Token = "0x6000391")]
		public bool get_chainsWithNext() { }

		[Address(RVA = "0x28F8300", Offset = "0x28F7700", Length = "0x16")]
		[Token(Token = "0x6000389")]
		public int get_compositeOrCompositeBindingIndex() { }

		[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
		[Token(Token = "0x600037B")]
		public int get_controlCount() { }

		[Address(RVA = "0x28F8320", Offset = "0x28F7720", Length = "0x5")]
		[Token(Token = "0x6000379")]
		public int get_controlStartIndex() { }

		[Address(RVA = "0xAEF1A0", Offset = "0xAEE5A0", Length = "0x5")]
		[Token(Token = "0x600038F")]
		public Flags get_flags() { }

		[Address(RVA = "0x28F8330", Offset = "0x28F7730", Length = "0x8")]
		[Token(Token = "0x600039A")]
		public bool get_initialStateCheckPending() { }

		[Address(RVA = "0xDA0E10", Offset = "0xDA0210", Length = "0x5")]
		[Token(Token = "0x600037F")]
		public int get_interactionCount() { }

		[Address(RVA = "0x28F8340", Offset = "0x28F7740", Length = "0x16")]
		[Token(Token = "0x600037D")]
		public int get_interactionStartIndex() { }

		[Address(RVA = "0x28F8360", Offset = "0x28F7760", Length = "0xA")]
		[Token(Token = "0x6000396")]
		public bool get_isComposite() { }

		[Address(RVA = "0x28F8370", Offset = "0x28F7770", Length = "0x9")]
		[Token(Token = "0x6000393")]
		public bool get_isEndOfChain() { }

		[Address(RVA = "0x28F8380", Offset = "0x28F7780", Length = "0x12")]
		[Token(Token = "0x6000395")]
		public bool get_isPartOfChain() { }

		[Address(RVA = "0x28F83A0", Offset = "0x28F77A0", Length = "0xA")]
		[Token(Token = "0x6000398")]
		public bool get_isPartOfComposite() { }

		[Address(RVA = "0x604A20", Offset = "0x603E20", Length = "0x5")]
		[Token(Token = "0x6000387")]
		public int get_mapIndex() { }

		[Address(RVA = "0x28F83B0", Offset = "0x28F77B0", Length = "0x5")]
		[Token(Token = "0x600039E")]
		public int get_partIndex() { }

		[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
		[Token(Token = "0x600038D")]
		public double get_pressTime() { }

		[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
		[Token(Token = "0x6000383")]
		public int get_processorCount() { }

		[Address(RVA = "0x28F83C0", Offset = "0x28F77C0", Length = "0x16")]
		[Token(Token = "0x6000381")]
		public int get_processorStartIndex() { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600038B")]
		public int get_triggerEventIdForComposite() { }

		[Address(RVA = "0x28F83E0", Offset = "0x28F77E0", Length = "0x8")]
		[Token(Token = "0x600039C")]
		public bool get_wantsInitialStateCheck() { }

		[Address(RVA = "0x28F83F0", Offset = "0x28F77F0", Length = "0xA7")]
		[Token(Token = "0x6000386")]
		public void set_actionIndex(int value) { }

		[Address(RVA = "0x28F84A0", Offset = "0x28F78A0", Length = "0x21")]
		[Token(Token = "0x6000392")]
		public void set_chainsWithNext(bool value) { }

		[Address(RVA = "0x28F84D0", Offset = "0x28F78D0", Length = "0xA7")]
		[Token(Token = "0x600038A")]
		public void set_compositeOrCompositeBindingIndex(int value) { }

		[Address(RVA = "0x28F8580", Offset = "0x28F7980", Length = "0x94")]
		[Token(Token = "0x600037C")]
		public void set_controlCount(int value) { }

		[Address(RVA = "0x28F8620", Offset = "0x28F7A20", Length = "0x97")]
		[Token(Token = "0x600037A")]
		public void set_controlStartIndex(int value) { }

		[Address(RVA = "0x1E16980", Offset = "0x1E15D80", Length = "0x4")]
		[Token(Token = "0x6000390")]
		public void set_flags(Flags value) { }

		[Address(RVA = "0x28F86C0", Offset = "0x28F7AC0", Length = "0x21")]
		[Token(Token = "0x600039B")]
		public void set_initialStateCheckPending(bool value) { }

		[Address(RVA = "0x28F86F0", Offset = "0x28F7AF0", Length = "0x95")]
		[Token(Token = "0x6000380")]
		public void set_interactionCount(int value) { }

		[Address(RVA = "0x28F8790", Offset = "0x28F7B90", Length = "0xA7")]
		[Token(Token = "0x600037E")]
		public void set_interactionStartIndex(int value) { }

		[Address(RVA = "0x28F8840", Offset = "0x28F7C40", Length = "0x21")]
		[Token(Token = "0x6000397")]
		public void set_isComposite(bool value) { }

		[Address(RVA = "0x28F8870", Offset = "0x28F7C70", Length = "0x21")]
		[Token(Token = "0x6000394")]
		public void set_isEndOfChain(bool value) { }

		[Address(RVA = "0x28F88A0", Offset = "0x28F7CA0", Length = "0x21")]
		[Token(Token = "0x6000399")]
		public void set_isPartOfComposite(bool value) { }

		[Address(RVA = "0x28F88D0", Offset = "0x28F7CD0", Length = "0x95")]
		[Token(Token = "0x6000388")]
		public void set_mapIndex(int value) { }

		[Address(RVA = "0x28F8970", Offset = "0x28F7D70", Length = "0x6")]
		[Token(Token = "0x600039F")]
		public void set_partIndex(int value) { }

		[Address(RVA = "0x28F8980", Offset = "0x28F7D80", Length = "0x6")]
		[Token(Token = "0x600038E")]
		public void set_pressTime(double value) { }

		[Address(RVA = "0x28F8990", Offset = "0x28F7D90", Length = "0x95")]
		[Token(Token = "0x6000384")]
		public void set_processorCount(int value) { }

		[Address(RVA = "0x28F8A30", Offset = "0x28F7E30", Length = "0xA7")]
		[Token(Token = "0x6000382")]
		public void set_processorStartIndex(int value) { }

		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x600038C")]
		public void set_triggerEventIdForComposite(int value) { }

		[Address(RVA = "0x28F8AE0", Offset = "0x28F7EE0", Length = "0x21")]
		[Token(Token = "0x600039D")]
		public void set_wantsInitialStateCheck(bool value) { }

	}

	[Token(Token = "0x200004E")]
	public struct GlobalState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001EB")]
		internal InlinedArray<GCHandle> globalList; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001EC")]
		internal CallbackArray<Action`2<Object, InputActionChange>> onActionChange; //Field offset: 0x18
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001ED")]
		internal CallbackArray<Action`1<Object>> onActionControlsChanged; //Field offset: 0x68

	}

	[Token(Token = "0x2000046")]
	public struct InteractionState
	{
		[Flags]
		[Token(Token = "0x2000047")]
		private enum Flags : int
		{
			TimerRunning = 1,
		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400018E")]
		private ushort m_TriggerControlIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x400018F")]
		private byte m_Phase; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x4000190")]
		private byte m_Flags; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000191")]
		private float m_TimerDuration; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000192")]
		private double m_StartTime; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000193")]
		private double m_TimerStartTime; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000194")]
		private double m_PerformedTime; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000195")]
		private float m_TotalTimeoutCompletionTimeDone; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000196")]
		private float m_TotalTimeoutCompletionTimeRemaining; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000197")]
		private long m_TimerMonitorIndex; //Field offset: 0x28

		[Token(Token = "0x170000F3")]
		public bool isTimerRunning
		{
			[Address(RVA = "0x290B170", Offset = "0x290A570", Length = "0x7")]
			[Token(Token = "0x6000375")]
			 get { } //Length: 7
			[Address(RVA = "0x290B1A0", Offset = "0x290A5A0", Length = "0x21")]
			[Token(Token = "0x6000376")]
			 set { } //Length: 33
		}

		[Token(Token = "0x170000ED")]
		public double performedTime
		{
			[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
			[Token(Token = "0x6000369")]
			 get { } //Length: 6
			[Address(RVA = "0x290B1D0", Offset = "0x290A5D0", Length = "0x6")]
			[Token(Token = "0x600036A")]
			 set { } //Length: 6
		}

		[Token(Token = "0x170000F4")]
		public InputActionPhase phase
		{
			[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
			[Token(Token = "0x6000377")]
			 get { } //Length: 5
			[Address(RVA = "0x290B1E0", Offset = "0x290A5E0", Length = "0x4")]
			[Token(Token = "0x6000378")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170000EC")]
		public double startTime
		{
			[Address(RVA = "0xDA0C90", Offset = "0xDA0090", Length = "0x6")]
			[Token(Token = "0x6000367")]
			 get { } //Length: 6
			[Address(RVA = "0x290B1F0", Offset = "0x290A5F0", Length = "0x6")]
			[Token(Token = "0x6000368")]
			 set { } //Length: 6
		}

		[Token(Token = "0x170000EF")]
		public float timerDuration
		{
			[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
			[Token(Token = "0x600036D")]
			 get { } //Length: 388
			[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
			[Token(Token = "0x600036E")]
			 set { } //Length: 6
		}

		[Token(Token = "0x170000F2")]
		public long timerMonitorIndex
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[Token(Token = "0x6000373")]
			 get { } //Length: 5
			[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
			[Token(Token = "0x6000374")]
			 set { } //Length: 5
		}

		[Token(Token = "0x170000EE")]
		public double timerStartTime
		{
			[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
			[Token(Token = "0x600036B")]
			 get { } //Length: 6
			[Address(RVA = "0x28F8980", Offset = "0x28F7D80", Length = "0x6")]
			[Token(Token = "0x600036C")]
			 set { } //Length: 6
		}

		[Token(Token = "0x170000F0")]
		public float totalTimeoutCompletionDone
		{
			[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
			[Token(Token = "0x600036F")]
			 get { } //Length: 6
			[Address(RVA = "0x1D719C0", Offset = "0x1D70DC0", Length = "0x6")]
			[Token(Token = "0x6000370")]
			 set { } //Length: 6
		}

		[Token(Token = "0x170000F1")]
		public float totalTimeoutCompletionTimeRemaining
		{
			[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
			[Token(Token = "0x6000371")]
			 get { } //Length: 6
			[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
			[Token(Token = "0x6000372")]
			 set { } //Length: 6
		}

		[Token(Token = "0x170000EB")]
		public int triggerControlIndex
		{
			[Address(RVA = "0x290B180", Offset = "0x290A580", Length = "0x14")]
			[Token(Token = "0x6000365")]
			 get { } //Length: 20
			[Address(RVA = "0x290B200", Offset = "0x290A600", Length = "0x75")]
			[Token(Token = "0x6000366")]
			 set { } //Length: 117
		}

		[Address(RVA = "0x290B170", Offset = "0x290A570", Length = "0x7")]
		[Token(Token = "0x6000375")]
		public bool get_isTimerRunning() { }

		[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
		[Token(Token = "0x6000369")]
		public double get_performedTime() { }

		[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
		[Token(Token = "0x6000377")]
		public InputActionPhase get_phase() { }

		[Address(RVA = "0xDA0C90", Offset = "0xDA0090", Length = "0x6")]
		[Token(Token = "0x6000367")]
		public double get_startTime() { }

		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[Token(Token = "0x600036D")]
		public float get_timerDuration() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000373")]
		public long get_timerMonitorIndex() { }

		[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
		[Token(Token = "0x600036B")]
		public double get_timerStartTime() { }

		[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
		[Token(Token = "0x600036F")]
		public float get_totalTimeoutCompletionDone() { }

		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[Token(Token = "0x6000371")]
		public float get_totalTimeoutCompletionTimeRemaining() { }

		[Address(RVA = "0x290B180", Offset = "0x290A580", Length = "0x14")]
		[Token(Token = "0x6000365")]
		public int get_triggerControlIndex() { }

		[Address(RVA = "0x290B1A0", Offset = "0x290A5A0", Length = "0x21")]
		[Token(Token = "0x6000376")]
		public void set_isTimerRunning(bool value) { }

		[Address(RVA = "0x290B1D0", Offset = "0x290A5D0", Length = "0x6")]
		[Token(Token = "0x600036A")]
		public void set_performedTime(double value) { }

		[Address(RVA = "0x290B1E0", Offset = "0x290A5E0", Length = "0x4")]
		[Token(Token = "0x6000378")]
		public void set_phase(InputActionPhase value) { }

		[Address(RVA = "0x290B1F0", Offset = "0x290A5F0", Length = "0x6")]
		[Token(Token = "0x6000368")]
		public void set_startTime(double value) { }

		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[Token(Token = "0x600036E")]
		public void set_timerDuration(float value) { }

		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[Token(Token = "0x6000374")]
		public void set_timerMonitorIndex(long value) { }

		[Address(RVA = "0x28F8980", Offset = "0x28F7D80", Length = "0x6")]
		[Token(Token = "0x600036C")]
		public void set_timerStartTime(double value) { }

		[Address(RVA = "0x1D719C0", Offset = "0x1D70DC0", Length = "0x6")]
		[Token(Token = "0x6000370")]
		public void set_totalTimeoutCompletionDone(float value) { }

		[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
		[Token(Token = "0x6000372")]
		public void set_totalTimeoutCompletionTimeRemaining(float value) { }

		[Address(RVA = "0x290B200", Offset = "0x290A600", Length = "0x75")]
		[Token(Token = "0x6000366")]
		public void set_triggerControlIndex(int value) { }

	}

	[Token(Token = "0x200004A")]
	internal struct TriggerState
	{
		[Flags]
		[Token(Token = "0x200004B")]
		internal enum Flags : int
		{
			HaveMagnitude = 1,
			PassThrough = 2,
			MayNeedConflictResolution = 4,
			HasMultipleConcurrentActuations = 8,
			InProcessing = 16,
			Button = 32,
			Pressed = 64,
		}

		[Token(Token = "0x40001AF")]
		public const int kMaxNumMaps = 255; //Field offset: 0x0
		[Token(Token = "0x40001B0")]
		public const int kMaxNumControls = 65535; //Field offset: 0x0
		[Token(Token = "0x40001B1")]
		public const int kMaxNumBindings = 65535; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B2")]
		private byte m_Phase; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x40001B3")]
		private byte m_Flags; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40001B4")]
		private byte m_MapIndex; //Field offset: 0x2
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40001B5")]
		private ushort m_ControlIndex; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001B6")]
		private double m_Time; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001B7")]
		private double m_StartTime; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001B8")]
		private ushort m_BindingIndex; //Field offset: 0x18
		[FieldOffset(Offset = "0x1A")]
		[Token(Token = "0x40001B9")]
		private ushort m_InteractionIndex; //Field offset: 0x1A
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001BA")]
		private float m_Magnitude; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001BB")]
		private uint m_LastPerformedInUpdate; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40001BC")]
		private uint m_LastCanceledInUpdate; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001BD")]
		private uint m_PressedInUpdate; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40001BE")]
		private uint m_ReleasedInUpdate; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001BF")]
		private uint m_LastCompletedInUpdate; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40001C0")]
		internal int framePerformed; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001C1")]
		internal int framePressed; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40001C2")]
		internal int frameReleased; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001C3")]
		internal int frameCompleted; //Field offset: 0x40

		[Token(Token = "0x17000115")]
		public int bindingIndex
		{
			[Address(RVA = "0x10A5BC0", Offset = "0x10A4FC0", Length = "0x5")]
			[Token(Token = "0x60003B2")]
			 get { } //Length: 5
			[Address(RVA = "0x290B350", Offset = "0x290A750", Length = "0x67")]
			[Token(Token = "0x60003B3")]
			 set { } //Length: 103
		}

		[Token(Token = "0x17000114")]
		public int controlIndex
		{
			[Address(RVA = "0x290B280", Offset = "0x290A680", Length = "0x16")]
			[Token(Token = "0x60003B0")]
			 get { } //Length: 22
			[Address(RVA = "0x290B3C0", Offset = "0x290A7C0", Length = "0x77")]
			[Token(Token = "0x60003B1")]
			 set { } //Length: 119
		}

		[Token(Token = "0x17000122")]
		public Flags flags
		{
			[Address(RVA = "0xDA0E10", Offset = "0xDA0210", Length = "0x5")]
			[Token(Token = "0x60003CC")]
			 get { } //Length: 5
			[Address(RVA = "0x290B440", Offset = "0x290A840", Length = "0x4")]
			[Token(Token = "0x60003CD")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000120")]
		public bool hasMultipleConcurrentActuations
		{
			[Address(RVA = "0x290B2A0", Offset = "0x290A6A0", Length = "0x8")]
			[Token(Token = "0x60003C8")]
			 get { } //Length: 8
			[Address(RVA = "0x290B450", Offset = "0x290A850", Length = "0x21")]
			[Token(Token = "0x60003C9")]
			 set { } //Length: 33
		}

		[Token(Token = "0x17000112")]
		public bool haveMagnitude
		{
			[Address(RVA = "0x290B2B0", Offset = "0x290A6B0", Length = "0x7")]
			[Token(Token = "0x60003AD")]
			 get { } //Length: 7
		}

		[Token(Token = "0x17000121")]
		public bool inProcessing
		{
			[Address(RVA = "0x290B2C0", Offset = "0x290A6C0", Length = "0x8")]
			[Token(Token = "0x60003CA")]
			 get { } //Length: 8
			[Address(RVA = "0x290B480", Offset = "0x290A880", Length = "0x21")]
			[Token(Token = "0x60003CB")]
			 set { } //Length: 33
		}

		[Token(Token = "0x17000116")]
		public int interactionIndex
		{
			[Address(RVA = "0x290B2D0", Offset = "0x290A6D0", Length = "0x16")]
			[Token(Token = "0x60003B4")]
			 get { } //Length: 22
			[Address(RVA = "0x290B4B0", Offset = "0x290A8B0", Length = "0x77")]
			[Token(Token = "0x60003B5")]
			 set { } //Length: 119
		}

		[Token(Token = "0x1700011D")]
		public bool isButton
		{
			[Address(RVA = "0x290B2F0", Offset = "0x290A6F0", Length = "0x8")]
			[Token(Token = "0x60003C2")]
			 get { } //Length: 8
			[Address(RVA = "0x290B530", Offset = "0x290A930", Length = "0x21")]
			[Token(Token = "0x60003C3")]
			 set { } //Length: 33
		}

		[Token(Token = "0x1700010E")]
		public bool isCanceled
		{
			[Address(RVA = "0x290B300", Offset = "0x290A700", Length = "0x7")]
			[Token(Token = "0x60003A6")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700010A")]
		public bool isDisabled
		{
			[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
			[Token(Token = "0x60003A2")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700011C")]
		public bool isPassThrough
		{
			[Address(RVA = "0x290B310", Offset = "0x290A710", Length = "0x8")]
			[Token(Token = "0x60003C0")]
			 get { } //Length: 8
			[Address(RVA = "0x290B560", Offset = "0x290A960", Length = "0x21")]
			[Token(Token = "0x60003C1")]
			 set { } //Length: 33
		}

		[Token(Token = "0x1700010D")]
		public bool isPerformed
		{
			[Address(RVA = "0x290B320", Offset = "0x290A720", Length = "0x7")]
			[Token(Token = "0x60003A5")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700011E")]
		public bool isPressed
		{
			[Address(RVA = "0x290B330", Offset = "0x290A730", Length = "0x8")]
			[Token(Token = "0x60003C4")]
			 get { } //Length: 8
			[Address(RVA = "0x290B590", Offset = "0x290A990", Length = "0x21")]
			[Token(Token = "0x60003C5")]
			 set { } //Length: 33
		}

		[Token(Token = "0x1700010C")]
		public bool isStarted
		{
			[Address(RVA = "0x2374F30", Offset = "0x2374330", Length = "0x7")]
			[Token(Token = "0x60003A4")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700010B")]
		public bool isWaiting
		{
			[Address(RVA = "0x2374F10", Offset = "0x2374310", Length = "0x7")]
			[Token(Token = "0x60003A3")]
			 get { } //Length: 7
		}

		[Token(Token = "0x17000119")]
		public uint lastCanceledInUpdate
		{
			[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
			[Token(Token = "0x60003BA")]
			 get { } //Length: 4
			[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
			[Token(Token = "0x60003BB")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000118")]
		public uint lastCompletedInUpdate
		{
			[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
			[Token(Token = "0x60003B8")]
			 get { } //Length: 4
			[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
			[Token(Token = "0x60003B9")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000117")]
		public uint lastPerformedInUpdate
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[Token(Token = "0x60003B6")]
			 get { } //Length: 4
			[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
			[Token(Token = "0x60003B7")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000111")]
		public float magnitude
		{
			[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
			[Token(Token = "0x60003AB")]
			 get { } //Length: 6
			[Address(RVA = "0x290B5C0", Offset = "0x290A9C0", Length = "0xA")]
			[Token(Token = "0x60003AC")]
			 set { } //Length: 10
		}

		[Token(Token = "0x17000113")]
		public int mapIndex
		{
			[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
			[Token(Token = "0x60003AE")]
			 get { } //Length: 5
			[Address(RVA = "0x290B5D0", Offset = "0x290A9D0", Length = "0x66")]
			[Token(Token = "0x60003AF")]
			 set { } //Length: 102
		}

		[Token(Token = "0x1700011F")]
		public bool mayNeedConflictResolution
		{
			[Address(RVA = "0x290B340", Offset = "0x290A740", Length = "0x8")]
			[Token(Token = "0x60003C6")]
			 get { } //Length: 8
			[Address(RVA = "0x290B640", Offset = "0x290AA40", Length = "0x21")]
			[Token(Token = "0x60003C7")]
			 set { } //Length: 33
		}

		[Token(Token = "0x17000109")]
		public InputActionPhase phase
		{
			[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
			[Token(Token = "0x60003A0")]
			 get { } //Length: 4
			[Address(RVA = "0x123BF80", Offset = "0x123B380", Length = "0x3")]
			[Token(Token = "0x60003A1")]
			 set { } //Length: 3
		}

		[Token(Token = "0x1700011A")]
		public uint pressedInUpdate
		{
			[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
			[Token(Token = "0x60003BC")]
			 get { } //Length: 4
			[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
			[Token(Token = "0x60003BD")]
			 set { } //Length: 4
		}

		[Token(Token = "0x1700011B")]
		public uint releasedInUpdate
		{
			[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
			[Token(Token = "0x60003BE")]
			 get { } //Length: 4
			[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
			[Token(Token = "0x60003BF")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000110")]
		public double startTime
		{
			[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
			[Token(Token = "0x60003A9")]
			 get { } //Length: 6
			[Address(RVA = "0x28F8980", Offset = "0x28F7D80", Length = "0x6")]
			[Token(Token = "0x60003AA")]
			 set { } //Length: 6
		}

		[Token(Token = "0x1700010F")]
		public double time
		{
			[Address(RVA = "0xDA0C90", Offset = "0xDA0090", Length = "0x6")]
			[Token(Token = "0x60003A7")]
			 get { } //Length: 6
			[Address(RVA = "0x290B1F0", Offset = "0x290A5F0", Length = "0x6")]
			[Token(Token = "0x60003A8")]
			 set { } //Length: 6
		}

		[Address(RVA = "0x10A5BC0", Offset = "0x10A4FC0", Length = "0x5")]
		[Token(Token = "0x60003B2")]
		public int get_bindingIndex() { }

		[Address(RVA = "0x290B280", Offset = "0x290A680", Length = "0x16")]
		[Token(Token = "0x60003B0")]
		public int get_controlIndex() { }

		[Address(RVA = "0xDA0E10", Offset = "0xDA0210", Length = "0x5")]
		[Token(Token = "0x60003CC")]
		public Flags get_flags() { }

		[Address(RVA = "0x290B2A0", Offset = "0x290A6A0", Length = "0x8")]
		[Token(Token = "0x60003C8")]
		public bool get_hasMultipleConcurrentActuations() { }

		[Address(RVA = "0x290B2B0", Offset = "0x290A6B0", Length = "0x7")]
		[Token(Token = "0x60003AD")]
		public bool get_haveMagnitude() { }

		[Address(RVA = "0x290B2C0", Offset = "0x290A6C0", Length = "0x8")]
		[Token(Token = "0x60003CA")]
		public bool get_inProcessing() { }

		[Address(RVA = "0x290B2D0", Offset = "0x290A6D0", Length = "0x16")]
		[Token(Token = "0x60003B4")]
		public int get_interactionIndex() { }

		[Address(RVA = "0x290B2F0", Offset = "0x290A6F0", Length = "0x8")]
		[Token(Token = "0x60003C2")]
		public bool get_isButton() { }

		[Address(RVA = "0x290B300", Offset = "0x290A700", Length = "0x7")]
		[Token(Token = "0x60003A6")]
		public bool get_isCanceled() { }

		[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
		[Token(Token = "0x60003A2")]
		public bool get_isDisabled() { }

		[Address(RVA = "0x290B310", Offset = "0x290A710", Length = "0x8")]
		[Token(Token = "0x60003C0")]
		public bool get_isPassThrough() { }

		[Address(RVA = "0x290B320", Offset = "0x290A720", Length = "0x7")]
		[Token(Token = "0x60003A5")]
		public bool get_isPerformed() { }

		[Address(RVA = "0x290B330", Offset = "0x290A730", Length = "0x8")]
		[Token(Token = "0x60003C4")]
		public bool get_isPressed() { }

		[Address(RVA = "0x2374F30", Offset = "0x2374330", Length = "0x7")]
		[Token(Token = "0x60003A4")]
		public bool get_isStarted() { }

		[Address(RVA = "0x2374F10", Offset = "0x2374310", Length = "0x7")]
		[Token(Token = "0x60003A3")]
		public bool get_isWaiting() { }

		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60003BA")]
		public uint get_lastCanceledInUpdate() { }

		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60003B8")]
		public uint get_lastCompletedInUpdate() { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60003B6")]
		public uint get_lastPerformedInUpdate() { }

		[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
		[Token(Token = "0x60003AB")]
		public float get_magnitude() { }

		[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
		[Token(Token = "0x60003AE")]
		public int get_mapIndex() { }

		[Address(RVA = "0x290B340", Offset = "0x290A740", Length = "0x8")]
		[Token(Token = "0x60003C6")]
		public bool get_mayNeedConflictResolution() { }

		[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
		[Token(Token = "0x60003A0")]
		public InputActionPhase get_phase() { }

		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60003BC")]
		public uint get_pressedInUpdate() { }

		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x60003BE")]
		public uint get_releasedInUpdate() { }

		[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
		[Token(Token = "0x60003A9")]
		public double get_startTime() { }

		[Address(RVA = "0xDA0C90", Offset = "0xDA0090", Length = "0x6")]
		[Token(Token = "0x60003A7")]
		public double get_time() { }

		[Address(RVA = "0x290B350", Offset = "0x290A750", Length = "0x67")]
		[Token(Token = "0x60003B3")]
		public void set_bindingIndex(int value) { }

		[Address(RVA = "0x290B3C0", Offset = "0x290A7C0", Length = "0x77")]
		[Token(Token = "0x60003B1")]
		public void set_controlIndex(int value) { }

		[Address(RVA = "0x290B440", Offset = "0x290A840", Length = "0x4")]
		[Token(Token = "0x60003CD")]
		public void set_flags(Flags value) { }

		[Address(RVA = "0x290B450", Offset = "0x290A850", Length = "0x21")]
		[Token(Token = "0x60003C9")]
		public void set_hasMultipleConcurrentActuations(bool value) { }

		[Address(RVA = "0x290B480", Offset = "0x290A880", Length = "0x21")]
		[Token(Token = "0x60003CB")]
		public void set_inProcessing(bool value) { }

		[Address(RVA = "0x290B4B0", Offset = "0x290A8B0", Length = "0x77")]
		[Token(Token = "0x60003B5")]
		public void set_interactionIndex(int value) { }

		[Address(RVA = "0x290B530", Offset = "0x290A930", Length = "0x21")]
		[Token(Token = "0x60003C3")]
		public void set_isButton(bool value) { }

		[Address(RVA = "0x290B560", Offset = "0x290A960", Length = "0x21")]
		[Token(Token = "0x60003C1")]
		public void set_isPassThrough(bool value) { }

		[Address(RVA = "0x290B590", Offset = "0x290A990", Length = "0x21")]
		[Token(Token = "0x60003C5")]
		public void set_isPressed(bool value) { }

		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x60003BB")]
		public void set_lastCanceledInUpdate(uint value) { }

		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x60003B9")]
		public void set_lastCompletedInUpdate(uint value) { }

		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x60003B7")]
		public void set_lastPerformedInUpdate(uint value) { }

		[Address(RVA = "0x290B5C0", Offset = "0x290A9C0", Length = "0xA")]
		[Token(Token = "0x60003AC")]
		public void set_magnitude(float value) { }

		[Address(RVA = "0x290B5D0", Offset = "0x290A9D0", Length = "0x66")]
		[Token(Token = "0x60003AF")]
		public void set_mapIndex(int value) { }

		[Address(RVA = "0x290B640", Offset = "0x290AA40", Length = "0x21")]
		[Token(Token = "0x60003C7")]
		public void set_mayNeedConflictResolution(bool value) { }

		[Address(RVA = "0x123BF80", Offset = "0x123B380", Length = "0x3")]
		[Token(Token = "0x60003A1")]
		public void set_phase(InputActionPhase value) { }

		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x60003BD")]
		public void set_pressedInUpdate(uint value) { }

		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[Token(Token = "0x60003BF")]
		public void set_releasedInUpdate(uint value) { }

		[Address(RVA = "0x28F8980", Offset = "0x28F7D80", Length = "0x6")]
		[Token(Token = "0x60003AA")]
		public void set_startTime(double value) { }

		[Address(RVA = "0x290B1F0", Offset = "0x290A5F0", Length = "0x6")]
		[Token(Token = "0x60003A8")]
		public void set_time(double value) { }

	}

	[Token(Token = "0x200004D")]
	internal struct UnmanagedMemory : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D8")]
		public Void* basePtr; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001D9")]
		public int mapCount; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40001DA")]
		public int actionCount; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001DB")]
		public int interactionCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001DC")]
		public int bindingCount; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001DD")]
		public int controlCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001DE")]
		public int compositeCount; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001DF")]
		public TriggerState* actionStates; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001E0")]
		public BindingState* bindingStates; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001E1")]
		public InteractionState* interactionStates; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001E2")]
		public Single* controlMagnitudes; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001E3")]
		public Single* compositeMagnitudes; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001E4")]
		public Int32* enabledControls; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001E5")]
		public UInt16* actionBindingIndicesAndCounts; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001E6")]
		public UInt16* actionBindingIndices; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40001E7")]
		public Int32* controlIndexToBindingIndex; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001E8")]
		public UInt16* controlGroupingAndComplexity; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40001E9")]
		public bool controlGroupingInitialized; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40001EA")]
		public ActionMapIndices* mapIndices; //Field offset: 0x78

		[Token(Token = "0x17000123")]
		public bool isAllocated
		{
			[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
			[Token(Token = "0x60003CE")]
			 get { } //Length: 8
		}

		[Token(Token = "0x17000124")]
		public int sizeInBytes
		{
			[Address(RVA = "0x290C0A0", Offset = "0x290B4A0", Length = "0x41")]
			[Token(Token = "0x60003CF")]
			 get { } //Length: 65
		}

		[Address(RVA = "0x290BB90", Offset = "0x290AF90", Length = "0x218")]
		[Token(Token = "0x60003D1")]
		public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount) { }

		[Address(RVA = "0x290BB70", Offset = "0x290AF70", Length = "0x11")]
		[Token(Token = "0x60003D0")]
		private static Byte* AllocFromBlob(ref Byte* top, int size) { }

		[Address(RVA = "0x290BDB0", Offset = "0x290B1B0", Length = "0x14D")]
		[Token(Token = "0x60003D4")]
		public UnmanagedMemory Clone() { }

		[Address(RVA = "0x290BF00", Offset = "0x290B300", Length = "0x13E")]
		[Token(Token = "0x60003D3")]
		public void CopyDataFrom(UnmanagedMemory memory) { }

		[Address(RVA = "0x290C040", Offset = "0x290B440", Length = "0x60")]
		[Token(Token = "0x60003D2")]
		public override void Dispose() { }

		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[Token(Token = "0x60003CE")]
		public bool get_isAllocated() { }

		[Address(RVA = "0x290C0A0", Offset = "0x290B4A0", Length = "0x41")]
		[Token(Token = "0x60003CF")]
		public int get_sizeInBytes() { }

	}

	[Token(Token = "0x4000179")]
	public const int kInvalidIndex = -1; //Field offset: 0x0
	[Token(Token = "0x4000188")]
	private static readonly ProfilerMarker k_InputInitialActionStateCheckMarker; //Field offset: 0x0
	[Token(Token = "0x4000189")]
	private static readonly ProfilerMarker k_InputActionResolveConflictMarker; //Field offset: 0x8
	[Token(Token = "0x400018A")]
	private static readonly ProfilerMarker k_InputActionCallbackMarker; //Field offset: 0x10
	[Token(Token = "0x400018B")]
	private static readonly ProfilerMarker k_InputOnActionChangeMarker; //Field offset: 0x18
	[Token(Token = "0x400018C")]
	private static readonly ProfilerMarker k_InputOnDeviceChangeMarker; //Field offset: 0x20
	[Token(Token = "0x400018D")]
	internal static GlobalState s_GlobalState; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400017A")]
	public InputActionMap[] maps; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400017B")]
	public InputControl[] controls; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400017C")]
	public IInputInteraction[] interactions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400017D")]
	public InputProcessor[] processors; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400017E")]
	public InputBindingComposite[] composites; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017F")]
	public int totalProcessorCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000180")]
	public UnmanagedMemory memory; //Field offset: 0x40
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000181")]
	private bool m_OnBeforeUpdateHooked; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC1")]
	[Token(Token = "0x4000182")]
	private bool m_OnAfterUpdateHooked; //Field offset: 0xC1
	[FieldOffset(Offset = "0xC2")]
	[Token(Token = "0x4000183")]
	private bool m_InProcessControlStateChange; //Field offset: 0xC2
	[FieldOffset(Offset = "0xC3")]
	[Token(Token = "0x4000184")]
	private bool m_Suppressed; //Field offset: 0xC3
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000185")]
	private InputEventPtr m_CurrentlyProcessingThisEvent; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000186")]
	private Action m_OnBeforeUpdateDelegate; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000187")]
	private Action m_OnAfterUpdateDelegate; //Field offset: 0xD8

	[Token(Token = "0x170000E2")]
	public TriggerState* actionStates
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60002FA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000E3")]
	public BindingState* bindingStates
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60002FB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000E6")]
	public UInt16* controlGroupingAndComplexity
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x60002FE")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000E5")]
	public Int32* controlIndexToBindingIndex
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x60002FD")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000E7")]
	public Single* controlMagnitudes
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x60002FF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000E8")]
	public UInt32* enabledControls
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x6000300")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000E4")]
	public InteractionState* interactionStates
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x60002FC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000E9")]
	public bool isProcessingControlStateChange
	{
		[Address(RVA = "0x290A030", Offset = "0x2909430", Length = "0x8")]
		[Token(Token = "0x6000301")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000EA")]
	public bool IsSuppressed
	{
		[Address(RVA = "0x290A020", Offset = "0x2909420", Length = "0x8")]
		[Token(Token = "0x600030C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000E1")]
	public ActionMapIndices* mapIndices
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[Token(Token = "0x60002F9")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000DD")]
	public int totalActionCount
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x60002F5")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000DE")]
	public int totalBindingCount
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x60002F6")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000DB")]
	public int totalCompositeCount
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[Token(Token = "0x60002F3")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000E0")]
	public int totalControlCount
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x60002F8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000DF")]
	public int totalInteractionCount
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x60002F7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000DC")]
	public int totalMapCount
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60002F4")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2909ED0", Offset = "0x29092D0", Length = "0x14B")]
	[Token(Token = "0x6000364")]
	private static InputActionState() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000363")]
	public InputActionState() { }

	[Address(RVA = "0x29007B0", Offset = "0x28FFBB0", Length = "0x26C")]
	[Token(Token = "0x6000358")]
	private void AddToGlobalList() { }

	[Address(RVA = "0x834810", Offset = "0x833C10", Length = "0x166")]
	[Token(Token = "0x600034F")]
	internal TValue ApplyProcessors(int bindingIndex, TValue value, InputControl<TValue> controlOfType = null) { }

	[Address(RVA = "0x2900A20", Offset = "0x28FFE20", Length = "0x2A6")]
	[Token(Token = "0x600033D")]
	private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, ref CallbackArray<Action`1<CallbackContext>>& listeners, string callbackName) { }

	[Address(RVA = "0x2900CD0", Offset = "0x29000D0", Length = "0x223")]
	[Token(Token = "0x600030B")]
	private bool CanUseDevice(InputDevice device) { }

	[Address(RVA = "0x2901200", Offset = "0x2900600", Length = "0x282")]
	[Token(Token = "0x600033B")]
	private bool ChangePhaseOfAction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled = 1) { }

	[Address(RVA = "0x2900F00", Offset = "0x2900300", Length = "0x2F8")]
	[Token(Token = "0x600033C")]
	private void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, ref TriggerState trigger, bool isDisablingAction = false) { }

	[Address(RVA = "0x2901490", Offset = "0x2900890", Length = "0x5AA")]
	[Token(Token = "0x600033A")]
	internal void ChangePhaseOfInteraction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformed = 1, InputActionPhase phaseAfterCanceled = 1, bool processNextInteractionOnCancel = true) { }

	[Address(RVA = "0x2901A40", Offset = "0x2900E40", Length = "0xD9")]
	[Token(Token = "0x6000304")]
	public void ClaimDataFrom(InputBindingResolver resolver) { }

	[Address(RVA = "0x2901B20", Offset = "0x2900F20", Length = "0x1C5")]
	[Token(Token = "0x6000308")]
	public InputActionState Clone() { }

	[Address(RVA = "0x2901CF0", Offset = "0x29010F0", Length = "0x1F8")]
	[Token(Token = "0x600035A")]
	private static void CompactGlobalList() { }

	[Address(RVA = "0x2901EF0", Offset = "0x29012F0", Length = "0x207")]
	[Token(Token = "0x6000303")]
	private void ComputeControlGroupingIfNecessary() { }

	[Address(RVA = "0x2902100", Offset = "0x2901500", Length = "0x2CB")]
	[Token(Token = "0x6000360")]
	internal static void DeferredResolutionOfBindings() { }

	[Address(RVA = "0x29025A0", Offset = "0x29019A0", Length = "0x384")]
	[Token(Token = "0x6000307")]
	private void Destroy(bool isFinalizing = false) { }

	[Address(RVA = "0x29023D0", Offset = "0x29017D0", Length = "0x1C8")]
	[Token(Token = "0x6000362")]
	internal static void DestroyAllActionMapStates() { }

	[Address(RVA = "0x2902930", Offset = "0x2901D30", Length = "0x19E")]
	[Token(Token = "0x6000361")]
	internal static void DisableAllActions() { }

	[Address(RVA = "0x2902AD0", Offset = "0x2901ED0", Length = "0x360")]
	[Token(Token = "0x600031D")]
	public void DisableAllActions(InputActionMap map) { }

	[Address(RVA = "0x2902F60", Offset = "0x2902360", Length = "0x200")]
	[Token(Token = "0x6000322")]
	private void DisableControls(int mapIndex, int controlStartIndex, int numControls) { }

	[Address(RVA = "0x2903170", Offset = "0x2902570", Length = "0x62")]
	[Token(Token = "0x600031E")]
	public void DisableControls(InputActionMap map) { }

	[Address(RVA = "0x2902E40", Offset = "0x2902240", Length = "0x115")]
	[Token(Token = "0x6000320")]
	private void DisableControls(InputAction action) { }

	[Address(RVA = "0x29031E0", Offset = "0x29025E0", Length = "0x172")]
	[Token(Token = "0x600031F")]
	public void DisableSingleAction(InputAction action) { }

	[Address(RVA = "0x2903360", Offset = "0x2902760", Length = "0xA")]
	[Token(Token = "0x6000306")]
	public override void Dispose() { }

	[Address(RVA = "0x2903370", Offset = "0x2902770", Length = "0x293")]
	[Token(Token = "0x6000319")]
	public void EnableAllActions(InputActionMap map) { }

	[Address(RVA = "0x2903730", Offset = "0x2902B30", Length = "0x1E9")]
	[Token(Token = "0x6000321")]
	private void EnableControls(int mapIndex, int controlStartIndex, int numControls) { }

	[Address(RVA = "0x2903610", Offset = "0x2902A10", Length = "0x115")]
	[Token(Token = "0x600031C")]
	private void EnableControls(InputAction action) { }

	[Address(RVA = "0x2903920", Offset = "0x2902D20", Length = "0x62")]
	[Token(Token = "0x600031A")]
	private void EnableControls(InputActionMap map) { }

	[Address(RVA = "0x2903990", Offset = "0x2902D90", Length = "0x17B")]
	[Token(Token = "0x600031B")]
	public void EnableSingleAction(InputAction action) { }

	[Address(RVA = "0x2903B10", Offset = "0x2902F10", Length = "0xE2")]
	[Token(Token = "0x6000350")]
	public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber) { }

	[Address(RVA = "0x2903C00", Offset = "0x2903000", Length = "0x22")]
	[Token(Token = "0x6000317")]
	public TriggerState FetchActionState(InputAction action) { }

	[Address(RVA = "0x2903C30", Offset = "0x2903030", Length = "0x44")]
	[Token(Token = "0x6000318")]
	public ActionMapIndices FetchMapIndices(InputActionMap map) { }

	[Address(RVA = "0x2903C80", Offset = "0x2903080", Length = "0xD9")]
	[Token(Token = "0x6000305")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2903D60", Offset = "0x2903160", Length = "0x2EC")]
	[Token(Token = "0x600035E")]
	internal static int FindAllEnabledActions(List<InputAction> result) { }

	[Address(RVA = "0x2904050", Offset = "0x2903450", Length = "0x8C")]
	[Token(Token = "0x6000313")]
	private int FindControlIndexOnBinding(int bindingIndex, InputControl control) { }

	[Address(RVA = "0x29040E0", Offset = "0x29034E0", Length = "0xD8")]
	[Token(Token = "0x600030E")]
	private void FinishBindingCompositeSetups() { }

	[Address(RVA = "0x29041C0", Offset = "0x29035C0", Length = "0x1B2")]
	[Token(Token = "0x6000310")]
	public void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, InputControlList<InputControl> activeControls, bool isFullResolve) { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60002FA")]
	public TriggerState* get_actionStates() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60002FB")]
	public BindingState* get_bindingStates() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x60002FE")]
	public UInt16* get_controlGroupingAndComplexity() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x60002FD")]
	public Int32* get_controlIndexToBindingIndex() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x60002FF")]
	public Single* get_controlMagnitudes() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x6000300")]
	public UInt32* get_enabledControls() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x60002FC")]
	public InteractionState* get_interactionStates() { }

	[Address(RVA = "0x290A030", Offset = "0x2909430", Length = "0x8")]
	[Token(Token = "0x6000301")]
	public bool get_isProcessingControlStateChange() { }

	[Address(RVA = "0x290A020", Offset = "0x2909420", Length = "0x8")]
	[Token(Token = "0x600030C")]
	public bool get_IsSuppressed() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[Token(Token = "0x60002F9")]
	public ActionMapIndices* get_mapIndices() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x60002F5")]
	public int get_totalActionCount() { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[Token(Token = "0x60002F6")]
	public int get_totalBindingCount() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[Token(Token = "0x60002F3")]
	public int get_totalCompositeCount() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x60002F8")]
	public int get_totalControlCount() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x60002F7")]
	public int get_totalInteractionCount() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60002F4")]
	public int get_totalMapCount() { }

	[Address(RVA = "0x2904380", Offset = "0x2903780", Length = "0x29")]
	[Token(Token = "0x6000333")]
	private ushort GetActionBindingStartIndexAndCount(int actionIndex, out ushort bindingCount) { }

	[Address(RVA = "0x29043B0", Offset = "0x29037B0", Length = "0x38")]
	[Token(Token = "0x6000347")]
	internal InputActionMap GetActionMap(int bindingIndex) { }

	[Address(RVA = "0x29043F0", Offset = "0x29037F0", Length = "0xD1")]
	[Token(Token = "0x600033E")]
	private object GetActionOrNoneString(ref TriggerState trigger) { }

	[Address(RVA = "0x29044D0", Offset = "0x29038D0", Length = "0x97")]
	[Token(Token = "0x6000340")]
	internal InputAction GetActionOrNull(ref TriggerState trigger) { }

	[Address(RVA = "0x2904570", Offset = "0x2903970", Length = "0x9B")]
	[Token(Token = "0x600033F")]
	internal InputAction GetActionOrNull(int bindingIndex) { }

	[Address(RVA = "0x29046B0", Offset = "0x2903AB0", Length = "0x81")]
	[Token(Token = "0x6000346")]
	internal InputBinding GetBinding(int bindingIndex) { }

	[Address(RVA = "0x2904610", Offset = "0x2903A10", Length = "0x42")]
	[Token(Token = "0x6000343")]
	internal int GetBindingIndexInMap(int bindingIndex) { }

	[Address(RVA = "0x2904660", Offset = "0x2903A60", Length = "0x37")]
	[Token(Token = "0x6000344")]
	internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap) { }

	[Address(RVA = "0x29046A0", Offset = "0x2903AA0", Length = "0xC")]
	[Token(Token = "0x6000345")]
	internal BindingState GetBindingState(int bindingIndex) { }

	[Address(RVA = "0x2904740", Offset = "0x2903B40", Length = "0x8")]
	[Token(Token = "0x600032E")]
	internal static int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex) { }

	[Address(RVA = "0x2904750", Offset = "0x2903B50", Length = "0x78")]
	[Token(Token = "0x6000351")]
	internal double GetCompositePartPressTime(int bindingIndex, int partNumber) { }

	[Address(RVA = "0x29047D0", Offset = "0x2903BD0", Length = "0x40")]
	[Token(Token = "0x6000341")]
	internal InputControl GetControl(ref TriggerState trigger) { }

	[Address(RVA = "0x2904820", Offset = "0x2903C20", Length = "0x3D")]
	[Token(Token = "0x6000342")]
	private IInputInteraction GetInteractionOrNull(ref TriggerState trigger) { }

	[Address(RVA = "0x2904860", Offset = "0x2903C60", Length = "0xA7")]
	[Token(Token = "0x600034A")]
	internal int GetValueSizeInBytes(int bindingIndex, int controlIndex) { }

	[Address(RVA = "0x2904910", Offset = "0x2903D10", Length = "0xA7")]
	[Token(Token = "0x600034B")]
	internal Type GetValueType(int bindingIndex, int controlIndex) { }

	[Address(RVA = "0x29049C0", Offset = "0x2903DC0", Length = "0x7C")]
	[Token(Token = "0x600030D")]
	public bool HasEnabledActions() { }

	[Address(RVA = "0x2904A40", Offset = "0x2903E40", Length = "0xE8")]
	[Token(Token = "0x6000327")]
	private void HookOnBeforeUpdate() { }

	[Address(RVA = "0x2904B30", Offset = "0x2903F30", Length = "0x461")]
	[Token(Token = "0x6000302")]
	public void Initialize(InputBindingResolver resolver) { }

	[Address(RVA = "0x2904FA0", Offset = "0x29043A0", Length = "0x110")]
	[Token(Token = "0x6000315")]
	private bool IsActionBoundToControlFromDevice(InputDevice device, int actionIndex) { }

	[Address(RVA = "0x29050C0", Offset = "0x29044C0", Length = "0xB4")]
	[Token(Token = "0x6000312")]
	private bool IsActiveControl(int bindingIndex, int controlIndex) { }

	[Address(RVA = "0x2905180", Offset = "0x2904580", Length = "0x60")]
	[Token(Token = "0x600034C")]
	internal static bool IsActuated(ref TriggerState trigger, float threshold = 0) { }

	[Address(RVA = "0x29051E0", Offset = "0x29045E0", Length = "0x555")]
	[Token(Token = "0x6000332")]
	private bool IsConflictingInput(ref TriggerState trigger, int actionIndex) { }

	[Address(RVA = "0x2905740", Offset = "0x2904B40", Length = "0x32")]
	[Token(Token = "0x6000325")]
	private bool IsControlEnabled(int controlIndex) { }

	[Address(RVA = "0x2905780", Offset = "0x2904B80", Length = "0x1AD")]
	[Token(Token = "0x600030A")]
	private bool IsUsingDevice(InputDevice device) { }

	[Address(RVA = "0x2905930", Offset = "0x2904D30", Length = "0x138")]
	[Token(Token = "0x600035B")]
	internal void NotifyListenersOfActionChange(InputActionChange change) { }

	[Address(RVA = "0x2905A70", Offset = "0x2904E70", Length = "0x10A")]
	[Token(Token = "0x600035C")]
	internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset) { }

	[Address(RVA = "0x2905B80", Offset = "0x2904F80", Length = "0x2DB")]
	[Token(Token = "0x6000329")]
	private void OnBeforeInitialUpdate() { }

	[Address(RVA = "0x2905E60", Offset = "0x2905260", Length = "0x38C")]
	[Token(Token = "0x600035F")]
	internal static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	[Address(RVA = "0x2906220", Offset = "0x2905620", Length = "0x4EB")]
	[Token(Token = "0x600030F")]
	internal void PrepareForBindingReResolution(bool needFullResolve, ref InputControlList<InputControl>& activeControls, ref bool hasEnabledActions) { }

	[Address(RVA = "0x2906710", Offset = "0x2905B10", Length = "0x1D6")]
	[Token(Token = "0x6000330")]
	private void ProcessButtonState(ref TriggerState trigger, int actionIndex, BindingState* bindingStatePtr) { }

	[Address(RVA = "0x29068F0", Offset = "0x2905CF0", Length = "0x806")]
	[Token(Token = "0x600032F")]
	private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, InputEventPtr eventPtr) { }

	[Address(RVA = "0x2907100", Offset = "0x2906500", Length = "0x386")]
	[Token(Token = "0x6000334")]
	private void ProcessDefaultInteraction(ref TriggerState trigger, int actionIndex) { }

	[Address(RVA = "0x2907490", Offset = "0x2906890", Length = "0x269")]
	[Token(Token = "0x6000335")]
	private void ProcessInteractions(ref TriggerState trigger, int interactionStartIndex, int interactionCount) { }

	[Address(RVA = "0x2907700", Offset = "0x2906B00", Length = "0x3CF")]
	[Token(Token = "0x6000336")]
	private void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex) { }

	[Address(RVA = "0x2907C10", Offset = "0x2907010", Length = "0x153")]
	[Token(Token = "0x6000353")]
	internal bool ReadCompositePartValue(int bindingIndex, int partNumber, Void* buffer, int bufferSize) { }

	[Address(RVA = "0x8354C0", Offset = "0x8348C0", Length = "0x2A6")]
	[Token(Token = "0x6000352")]
	internal TValue ReadCompositePartValue(int bindingIndex, int partNumber, Boolean* buttonValuePtr, out int controlIndex, TComparer comparer = null) { }

	[Address(RVA = "0x2907AD0", Offset = "0x2906ED0", Length = "0x13F")]
	[Token(Token = "0x6000354")]
	internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber) { }

	[Address(RVA = "0x2908080", Offset = "0x2907480", Length = "0x200")]
	[Token(Token = "0x600034D")]
	internal void ReadValue(int bindingIndex, int controlIndex, Void* buffer, int bufferSize, bool ignoreComposites = false) { }

	[Address(RVA = "0x835F20", Offset = "0x835320", Length = "0x66D")]
	[Token(Token = "0x600034E")]
	internal TValue ReadValue(int bindingIndex, int controlIndex, bool ignoreComposites = false) { }

	[Address(RVA = "0x2907D70", Offset = "0x2907170", Length = "0x122")]
	[Token(Token = "0x6000356")]
	internal bool ReadValueAsButton(int bindingIndex, int controlIndex) { }

	[Address(RVA = "0x2907EA0", Offset = "0x29072A0", Length = "0x1DE")]
	[Token(Token = "0x6000355")]
	internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites = false) { }

	[Address(RVA = "0x2908290", Offset = "0x2907690", Length = "0x1A9")]
	[Token(Token = "0x6000359")]
	private void RemoveMapFromGlobalList() { }

	[Address(RVA = "0x2908440", Offset = "0x2907840", Length = "0x289")]
	[Token(Token = "0x6000316")]
	public void ResetActionState(int actionIndex, InputActionPhase toPhase = 1, bool hardReset = false) { }

	[Address(RVA = "0x29086D0", Offset = "0x2907AD0", Length = "0x170")]
	[Token(Token = "0x6000314")]
	private void ResetActionStatesDrivenBy(InputDevice device) { }

	[Address(RVA = "0x2908850", Offset = "0x2907C50", Length = "0x354")]
	[Token(Token = "0x600035D")]
	private static void ResetGlobals() { }

	[Address(RVA = "0x2908C90", Offset = "0x2908090", Length = "0xC7")]
	[Token(Token = "0x6000349")]
	private void ResetInteractionState(int interactionIndex) { }

	[Address(RVA = "0x2908BB0", Offset = "0x2907FB0", Length = "0xD7")]
	[Token(Token = "0x6000348")]
	private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled) { }

	[Address(RVA = "0x2908D60", Offset = "0x2908160", Length = "0x919")]
	[Token(Token = "0x6000311")]
	private void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, InputControlList<InputControl> activeControls, bool isFullResolve) { }

	[Address(RVA = "0x2909680", Offset = "0x2908A80", Length = "0x25E")]
	[Token(Token = "0x6000357")]
	internal static ISavedState SaveAndResetState() { }

	[Address(RVA = "0x29098E0", Offset = "0x2908CE0", Length = "0x3D")]
	[Token(Token = "0x6000326")]
	private void SetControlEnabled(int controlIndex, bool state) { }

	[Address(RVA = "0x29099D0", Offset = "0x2908DD0", Length = "0x3C")]
	[Token(Token = "0x6000324")]
	private void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value) { }

	[Address(RVA = "0x2909920", Offset = "0x2908D20", Length = "0xAF")]
	[Token(Token = "0x6000323")]
	public void SetInitialStateCheckPending(int actionIndex, bool value = true) { }

	[Address(RVA = "0x2909A10", Offset = "0x2908E10", Length = "0x34")]
	[Token(Token = "0x6000337")]
	internal void SetTotalTimeoutCompletionTime(float seconds, ref TriggerState trigger) { }

	[Address(RVA = "0x2909A50", Offset = "0x2908E50", Length = "0x37")]
	[Token(Token = "0x6000331")]
	private static bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr) { }

	[Address(RVA = "0x2909A90", Offset = "0x2908E90", Length = "0x26")]
	[Token(Token = "0x600032D")]
	private void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex) { }

	[Address(RVA = "0x2909AC0", Offset = "0x2908EC0", Length = "0x1B3")]
	[Token(Token = "0x6000338")]
	internal void StartTimeout(float seconds, ref TriggerState trigger) { }

	[Address(RVA = "0x2909C80", Offset = "0x2909080", Length = "0xEC")]
	[Token(Token = "0x6000339")]
	private void StopTimeout(int interactionIndex) { }

	[Address(RVA = "0x2901B20", Offset = "0x2900F20", Length = "0x1C5")]
	[Token(Token = "0x6000309")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x2909D70", Offset = "0x2909170", Length = "0x33")]
	[Token(Token = "0x600032C")]
	private long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex) { }

	[Address(RVA = "0x2909DB0", Offset = "0x29091B0", Length = "0x7E")]
	[Token(Token = "0x6000328")]
	private void UnhookOnBeforeUpdate() { }

	[Address(RVA = "0x2909E30", Offset = "0x2909230", Length = "0x47")]
	[Token(Token = "0x600032A")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long mapControlAndBindingIndex) { }

	[Address(RVA = "0x2909E80", Offset = "0x2909280", Length = "0x42")]
	[Token(Token = "0x600032B")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex) { }

}

