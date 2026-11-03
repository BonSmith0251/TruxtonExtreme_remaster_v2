namespace UnityEngine.InputSystem;

[Extension]
[Token(Token = "0x2000073")]
public static class InputControlExtensions
{
	[CompilerGenerated]
	[Token(Token = "0x2000079")]
	private sealed class <GetAllButtonPresses>d__43 : IEnumerable<InputControl>, IEnumerable, IEnumerator<InputControl>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002BF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002C0")]
		private InputControl <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002C1")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002C2")]
		private InputEventPtr eventPtr; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002C3")]
		public InputEventPtr <>3__eventPtr; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40002C4")]
		private float magnitude; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40002C5")]
		public float <>3__magnitude; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40002C6")]
		private bool buttonControlsOnly; //Field offset: 0x40
		[FieldOffset(Offset = "0x41")]
		[Token(Token = "0x40002C7")]
		public bool <>3__buttonControlsOnly; //Field offset: 0x41
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40002C8")]
		private InputEventControlEnumerator <>7__wrap1; //Field offset: 0x48

		[Token(Token = "0x1700019A")]
		private override InputControl System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005CD")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700019B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005CF")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60005C9")]
		public <GetAllButtonPresses>d__43(int <>1__state) { }

		[Address(RVA = "0x2943B40", Offset = "0x2942F40", Length = "0x11")]
		[Token(Token = "0x60005CC")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x29436D0", Offset = "0x2942AD0", Length = "0x314")]
		[Token(Token = "0x60005CB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x29439F0", Offset = "0x2942DF0", Length = "0xA0")]
		[DebuggerHidden]
		[Token(Token = "0x60005D0")]
		private override IEnumerator<InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005CD")]
		private override InputControl System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>.get_Current() { }

		[Address(RVA = "0x29439F0", Offset = "0x2942DF0", Length = "0xA0")]
		[DebuggerHidden]
		[Token(Token = "0x60005D1")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005CF")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2943AA0", Offset = "0x2942EA0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60005CE")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2943AE0", Offset = "0x2942EE0", Length = "0x51")]
		[DebuggerHidden]
		[Token(Token = "0x60005CA")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000077")]
	internal struct ControlBuilder
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002BD")]
		private InputControl <control>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000198")]
		public internal InputControl control
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60005A7")]
			 get { } //Length: 4
			[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x60005A8")]
			internal set { } //Length: 8
		}

		[Address(RVA = "0x292C770", Offset = "0x292BB70", Length = "0xBB")]
		[Token(Token = "0x60005A9")]
		public ControlBuilder At(InputDevice device, int index) { }

		[Address(RVA = "0x292C830", Offset = "0x292BC30", Length = "0x5E")]
		[Token(Token = "0x60005B8")]
		public ControlBuilder DontReset(bool value) { }

		[Address(RVA = "0x292C890", Offset = "0x292BC90", Length = "0x1D")]
		[Token(Token = "0x60005BA")]
		public void Finish() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60005A7")]
		public InputControl get_control() { }

		[Address(RVA = "0x292C8B0", Offset = "0x292BCB0", Length = "0x37")]
		[Token(Token = "0x60005B9")]
		public ControlBuilder IsButton(bool value) { }

		[Address(RVA = "0x292C8F0", Offset = "0x292BCF0", Length = "0x27")]
		[Token(Token = "0x60005B6")]
		public ControlBuilder IsNoisy(bool value) { }

		[Address(RVA = "0x292C920", Offset = "0x292BD20", Length = "0x37")]
		[Token(Token = "0x60005B7")]
		public ControlBuilder IsSynthetic(bool value) { }

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60005A8")]
		internal void set_control(InputControl value) { }

		[Address(RVA = "0x292C960", Offset = "0x292BD60", Length = "0x2E")]
		[Token(Token = "0x60005B0")]
		public ControlBuilder WithAliases(int startIndex, int count) { }

		[Address(RVA = "0x292C990", Offset = "0x292BD90", Length = "0x2E")]
		[Token(Token = "0x60005B1")]
		public ControlBuilder WithChildren(int startIndex, int count) { }

		[Address(RVA = "0x292C9C0", Offset = "0x292BDC0", Length = "0x3E")]
		[Token(Token = "0x60005B3")]
		public ControlBuilder WithDefaultState(PrimitiveValue value) { }

		[Address(RVA = "0x292CA00", Offset = "0x292BE00", Length = "0x64")]
		[Token(Token = "0x60005AC")]
		public ControlBuilder WithDisplayName(string displayName) { }

		[Address(RVA = "0x292CA70", Offset = "0x292BE70", Length = "0x31")]
		[Token(Token = "0x60005AE")]
		public ControlBuilder WithLayout(InternedString layout) { }

		[Address(RVA = "0x292CAB0", Offset = "0x292BEB0", Length = "0x36")]
		[Token(Token = "0x60005B4")]
		public ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max) { }

		[Address(RVA = "0x292CAF0", Offset = "0x292BEF0", Length = "0x51")]
		[Token(Token = "0x60005AB")]
		public ControlBuilder WithName(string name) { }

		[Address(RVA = "0x292CB50", Offset = "0x292BF50", Length = "0x2F")]
		[Token(Token = "0x60005AA")]
		public ControlBuilder WithParent(InputControl parent) { }

		[Address(RVA = "0x9F1320", Offset = "0x9F0720", Length = "0xCE")]
		[Token(Token = "0x60005B5")]
		public ControlBuilder WithProcessor(TProcessor processor) { }

		[Address(RVA = "0x292CB80", Offset = "0x292BF80", Length = "0x64")]
		[Token(Token = "0x60005AD")]
		public ControlBuilder WithShortDisplayName(string shortDisplayName) { }

		[Address(RVA = "0x292CBF0", Offset = "0x292BFF0", Length = "0x20")]
		[Token(Token = "0x60005B2")]
		public ControlBuilder WithStateBlock(InputStateBlock stateBlock) { }

		[Address(RVA = "0x292CC20", Offset = "0x292C020", Length = "0x2E")]
		[Token(Token = "0x60005AF")]
		public ControlBuilder WithUsages(int startIndex, int count) { }

	}

	[Token(Token = "0x2000078")]
	internal struct DeviceBuilder
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002BE")]
		private InputDevice <device>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000199")]
		public internal InputDevice device
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60005BB")]
			 get { } //Length: 4
			[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x60005BC")]
			internal set { } //Length: 8
		}

		[Address(RVA = "0x292CC50", Offset = "0x292C050", Length = "0x2A2")]
		[Token(Token = "0x60005C8")]
		public void Finish() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60005BB")]
		public InputDevice get_device() { }

		[Address(RVA = "0x292C8F0", Offset = "0x292BCF0", Length = "0x27")]
		[Token(Token = "0x60005C3")]
		public DeviceBuilder IsNoisy(bool value) { }

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60005BC")]
		internal void set_device(InputDevice value) { }

		[Address(RVA = "0x292C990", Offset = "0x292BD90", Length = "0x2E")]
		[Token(Token = "0x60005C1")]
		public DeviceBuilder WithChildren(int startIndex, int count) { }

		[Address(RVA = "0x292CF00", Offset = "0x292C300", Length = "0x5F")]
		[Token(Token = "0x60005C5")]
		public DeviceBuilder WithControlAlias(int controlIndex, InternedString alias) { }

		[Address(RVA = "0x292CF60", Offset = "0x292C360", Length = "0x14E")]
		[Token(Token = "0x60005C7")]
		public DeviceBuilder WithControlTree(Byte[] controlTreeNodes, UInt16[] controlTreeIndicies) { }

		[Address(RVA = "0x292D0B0", Offset = "0x292C4B0", Length = "0xDF")]
		[Token(Token = "0x60005C4")]
		public DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control) { }

		[Address(RVA = "0x292CA00", Offset = "0x292BE00", Length = "0x64")]
		[Token(Token = "0x60005BE")]
		public DeviceBuilder WithDisplayName(string displayName) { }

		[Address(RVA = "0x292CA70", Offset = "0x292BE70", Length = "0x31")]
		[Token(Token = "0x60005C0")]
		public DeviceBuilder WithLayout(InternedString layout) { }

		[Address(RVA = "0x292CAF0", Offset = "0x292BEF0", Length = "0x51")]
		[Token(Token = "0x60005BD")]
		public DeviceBuilder WithName(string name) { }

		[Address(RVA = "0x292CB80", Offset = "0x292BF80", Length = "0x64")]
		[Token(Token = "0x60005BF")]
		public DeviceBuilder WithShortDisplayName(string shortDisplayName) { }

		[Address(RVA = "0x292CBF0", Offset = "0x292BFF0", Length = "0x20")]
		[Token(Token = "0x60005C2")]
		public DeviceBuilder WithStateBlock(InputStateBlock stateBlock) { }

		[Address(RVA = "0x292D190", Offset = "0x292C590", Length = "0x32")]
		[Token(Token = "0x60005C6")]
		public DeviceBuilder WithStateOffsetToControlIndexMap(UInt32[] map) { }

	}

	[Flags]
	[Token(Token = "0x2000074")]
	internal enum Enumerate : int
	{
		IgnoreControlsInDefaultState = 1,
		IgnoreControlsInCurrentState = 2,
		IncludeSyntheticControls = 4,
		IncludeNoisyControls = 8,
		IncludeNonLeafControls = 16,
	}

	[Token(Token = "0x2000075")]
	internal struct InputEventControlCollection : IEnumerable<InputControl>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A9")]
		internal InputDevice m_Device; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002AA")]
		internal InputEventPtr m_EventPtr; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002AB")]
		internal Enumerate m_Flags; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40002AC")]
		internal float m_MagnitudeThreshold; //Field offset: 0x14

		[Token(Token = "0x17000195")]
		public InputEventPtr eventPtr
		{
			[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
			[Token(Token = "0x600059B")]
			 get { } //Length: 5
		}

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x600059B")]
		public InputEventPtr get_eventPtr() { }

		[Address(RVA = "0x293A740", Offset = "0x2939B40", Length = "0x57")]
		[Token(Token = "0x600059C")]
		public InputEventControlEnumerator GetEnumerator() { }

		[Address(RVA = "0x293A7A0", Offset = "0x2939BA0", Length = "0xFB")]
		[Token(Token = "0x600059D")]
		private override IEnumerator<InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

		[Address(RVA = "0x293A8A0", Offset = "0x2939CA0", Length = "0xFB")]
		[Token(Token = "0x600059E")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x2000076")]
	internal struct InputEventControlEnumerator : IEnumerator<InputControl>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AD")]
		private Enumerate m_Flags; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002AE")]
		private readonly InputDevice m_Device; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002AF")]
		private readonly UInt32[] m_StateOffsetToControlIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002B0")]
		private readonly int m_StateOffsetToControlIndexLength; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002B1")]
		private readonly InputControl[] m_AllControls; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002B2")]
		private Byte* m_DefaultState; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002B3")]
		private Byte* m_CurrentState; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40002B4")]
		private Byte* m_NoiseMask; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40002B5")]
		private InputEventPtr m_EventPtr; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40002B6")]
		private InputControl m_CurrentControl; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40002B7")]
		private int m_CurrentIndexInStateOffsetToControlIndexMap; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40002B8")]
		private uint m_CurrentControlStateBitOffset; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40002B9")]
		private Byte* m_EventState; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40002BA")]
		private uint m_CurrentBitOffset; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x40002BB")]
		private uint m_EndBitOffset; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40002BC")]
		private float m_MagnitudeThreshold; //Field offset: 0x68

		[Token(Token = "0x17000196")]
		public override InputControl Current
		{
			[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
			[Token(Token = "0x60005A5")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000197")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
			[Token(Token = "0x60005A6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x293B340", Offset = "0x293A740", Length = "0x1DA")]
		[Token(Token = "0x600059F")]
		internal InputEventControlEnumerator(InputEventPtr eventPtr, InputDevice device, Enumerate flags, float magnitudeThreshold = 0) { }

		[Address(RVA = "0x293A9A0", Offset = "0x2939DA0", Length = "0x2F")]
		[Token(Token = "0x60005A1")]
		private bool CheckCurrent(uint numBits) { }

		[Address(RVA = "0x293A9D0", Offset = "0x2939DD0", Length = "0x2F")]
		[Token(Token = "0x60005A0")]
		private bool CheckDefault(uint numBits) { }

		[Address(RVA = "0x293AA00", Offset = "0x2939E00", Length = "0x7")]
		[Token(Token = "0x60005A4")]
		public override void Dispose() { }

		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60005A5")]
		public override InputControl get_Current() { }

		[Address(RVA = "0x293AA10", Offset = "0x2939E10", Length = "0x45A")]
		[Token(Token = "0x60005A2")]
		public override bool MoveNext() { }

		[Address(RVA = "0x293AE70", Offset = "0x293A270", Length = "0x4C5")]
		[Token(Token = "0x60005A3")]
		public override void Reset() { }

		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60005A6")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}


	[Address(RVA = "0x2931070", Offset = "0x2930470", Length = "0x10F")]
	[Extension]
	[Token(Token = "0x6000591")]
	internal static void AccumulateValueInEvent(InputControl<Vector2> control, Void* currentStatePtr, InputEventPtr newState) { }

	[Address(RVA = "0x2930F70", Offset = "0x2930370", Length = "0xF4")]
	[Extension]
	[Token(Token = "0x6000590")]
	public static void AccumulateValueInEvent(InputControl<Single> control, Void* currentStatePtr, InputEventPtr newState) { }

	[Address(RVA = "0x2931180", Offset = "0x2930580", Length = "0x399")]
	[Extension]
	[Token(Token = "0x6000593")]
	internal static string BuildPath(InputControl control, string deviceLayout, StringBuilder builder = null) { }

	[Address(RVA = "0x29317B0", Offset = "0x2930BB0", Length = "0x10B")]
	[Extension]
	[Token(Token = "0x6000584")]
	public static bool CheckStateIsAtDefault(InputControl control, Void* statePtr, Void* maskPtr = null) { }

	[Address(RVA = "0x29318C0", Offset = "0x2930CC0", Length = "0x10F")]
	[Extension]
	[Token(Token = "0x6000583")]
	public static bool CheckStateIsAtDefault(InputControl control) { }

	[Address(RVA = "0x2931670", Offset = "0x2930A70", Length = "0x136")]
	[Extension]
	[Token(Token = "0x6000586")]
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control, Void* statePtr) { }

	[Address(RVA = "0x2931520", Offset = "0x2930920", Length = "0x14B")]
	[Extension]
	[Token(Token = "0x6000585")]
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control) { }

	[Address(RVA = "0x2931AF0", Offset = "0x2930EF0", Length = "0xF1")]
	[Extension]
	[Token(Token = "0x6000589")]
	public static bool CompareState(InputControl control, Void* statePtr, Void* maskPtr = null) { }

	[Address(RVA = "0x2931BF0", Offset = "0x2930FF0", Length = "0x167")]
	[Extension]
	[Token(Token = "0x6000588")]
	public static bool CompareState(InputControl control, Void* firstStatePtr, Void* secondStatePtr, Void* maskPtr = null) { }

	[Address(RVA = "0x29319D0", Offset = "0x2930DD0", Length = "0x11C")]
	[Extension]
	[Token(Token = "0x6000587")]
	public static bool CompareStateIgnoringNoise(InputControl control, Void* statePtr) { }

	[Address(RVA = "0x83A4C0", Offset = "0x8398C0", Length = "0x2C9")]
	[Extension]
	[Token(Token = "0x6000582")]
	public static void CopyState(InputDevice device, out TState state) { }

	[Address(RVA = "0x2931D60", Offset = "0x2931160", Length = "0x190")]
	[Extension]
	[Token(Token = "0x6000581")]
	public static void CopyState(InputDevice device, Void* buffer, int bufferSizeInBytes) { }

	[Address(RVA = "0x2931F00", Offset = "0x2931300", Length = "0x44")]
	[Extension]
	[Token(Token = "0x6000595")]
	public static InputEventControlCollection EnumerateChangedControls(InputEventPtr eventPtr, InputDevice device = null, float magnitudeThreshold = 0) { }

	[Address(RVA = "0x2931F50", Offset = "0x2931350", Length = "0x2AA")]
	[Extension]
	[Token(Token = "0x6000594")]
	public static InputEventControlCollection EnumerateControls(InputEventPtr eventPtr, Enumerate flags, InputDevice device = null, float magnitudeThreshold = 0) { }

	[Address(RVA = "0x83A790", Offset = "0x839B90", Length = "0x298")]
	[Extension]
	[Token(Token = "0x6000592")]
	public static void FindControlsRecursive(InputControl parent, IList<TControl> controls, Func<TControl, Boolean> predicate) { }

	[Address(RVA = "0x83AA30", Offset = "0x839E30", Length = "0xB6")]
	[Extension]
	[Token(Token = "0x600056E")]
	public static TControl FindInParentChain(InputControl control) { }

	[Address(RVA = "0x2932200", Offset = "0x2931600", Length = "0x89")]
	[Extension]
	[IteratorStateMachine(typeof(<GetAllButtonPresses>d__43))]
	[Token(Token = "0x6000598")]
	public static IEnumerable<InputControl> GetAllButtonPresses(InputEventPtr eventPtr, float magnitude = -1, bool buttonControlsOnly = true) { }

	[Address(RVA = "0x2932290", Offset = "0x2931690", Length = "0x385")]
	[Extension]
	[Token(Token = "0x6000597")]
	public static InputControl GetFirstButtonPressOrNull(InputEventPtr eventPtr, float magnitude = -1, bool buttonControlsOnly = true) { }

	[Address(RVA = "0x2932960", Offset = "0x2931D60", Length = "0xE5")]
	[Extension]
	[Token(Token = "0x600058C")]
	public static Void* GetStatePtrFromStateEvent(InputControl control, InputEventPtr eventPtr) { }

	[Address(RVA = "0x2932620", Offset = "0x2931A20", Length = "0x335")]
	[Extension]
	[Token(Token = "0x600058D")]
	internal static Void* GetStatePtrFromStateEventUnchecked(InputControl control, InputEventPtr eventPtr, FourCC eventType) { }

	[Address(RVA = "0x2932A50", Offset = "0x2931E50", Length = "0x17")]
	[Extension]
	[Token(Token = "0x6000596")]
	public static bool HasButtonPress(InputEventPtr eventPtr, float magnitude = -1, bool buttonControlsOnly = true) { }

	[Address(RVA = "0x2932A70", Offset = "0x2931E70", Length = "0x11A")]
	[Extension]
	[Token(Token = "0x600058B")]
	public static bool HasValueChangeInEvent(InputControl control, InputEventPtr eventPtr) { }

	[Address(RVA = "0x2932B90", Offset = "0x2931F90", Length = "0xE6")]
	[Extension]
	[Token(Token = "0x600058A")]
	public static bool HasValueChangeInState(InputControl control, Void* statePtr) { }

	[Address(RVA = "0x2932C80", Offset = "0x2932080", Length = "0x1B3")]
	[Extension]
	[Token(Token = "0x6000570")]
	public static bool IsActuated(InputControl control, float threshold = 0) { }

	[Address(RVA = "0x2932E40", Offset = "0x2932240", Length = "0x217")]
	[Extension]
	[Token(Token = "0x600056F")]
	public static bool IsPressed(InputControl control, float buttonPressPoint = 0) { }

	[Address(RVA = "0x83AAF0", Offset = "0x839EF0", Length = "0x201")]
	[Extension]
	[Token(Token = "0x600058F")]
	public static void QueueValueChange(InputControl<TValue> control, TValue value, double time = -1) { }

	[Address(RVA = "0x2933060", Offset = "0x2932460", Length = "0x9F")]
	[Extension]
	[Token(Token = "0x6000573")]
	public static object ReadDefaultValueAsObject(InputControl control) { }

	[Address(RVA = "0x83AE90", Offset = "0x83A290", Length = "0x132")]
	[Extension]
	[Token(Token = "0x6000577")]
	public static TValue ReadUnprocessedValueFromEvent(InputControl<TValue> control, InputEventPtr eventPtr) { }

	[Address(RVA = "0x83AFD0", Offset = "0x83A3D0", Length = "0xCF")]
	[Extension]
	[Token(Token = "0x6000578")]
	public static bool ReadUnprocessedValueFromEvent(InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) { }

	[Address(RVA = "0x2933100", Offset = "0x2932500", Length = "0x85")]
	[Extension]
	[Token(Token = "0x6000571")]
	public static object ReadValueAsObject(InputControl control) { }

	[Address(RVA = "0x83B170", Offset = "0x83A570", Length = "0x186")]
	[Extension]
	[Token(Token = "0x6000575")]
	public static bool ReadValueFromEvent(InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) { }

	[Address(RVA = "0x83B300", Offset = "0x83A700", Length = "0x16F")]
	[Extension]
	[Token(Token = "0x6000574")]
	public static TValue ReadValueFromEvent(InputControl<TValue> control, InputEventPtr inputEvent) { }

	[Address(RVA = "0x2933190", Offset = "0x2932590", Length = "0xCB")]
	[Extension]
	[Token(Token = "0x6000576")]
	public static object ReadValueFromEventAsObject(InputControl control, InputEventPtr inputEvent) { }

	[Address(RVA = "0x2933260", Offset = "0x2932660", Length = "0xFC")]
	[Extension]
	[Token(Token = "0x6000572")]
	public static void ReadValueIntoBuffer(InputControl control, Void* buffer, int bufferSize) { }

	[Address(RVA = "0x2933360", Offset = "0x2932760", Length = "0x1F1")]
	[Extension]
	[Token(Token = "0x600058E")]
	public static bool ResetToDefaultStateInEvent(InputControl control, InputEventPtr eventPtr) { }

	[Address(RVA = "0x2933560", Offset = "0x2932960", Length = "0x2D0")]
	[Extension]
	[Token(Token = "0x600059A")]
	public static DeviceBuilder Setup(InputDevice device, int controlCount, int usageCount, int aliasCount) { }

	[Address(RVA = "0x2933840", Offset = "0x2932C40", Length = "0xE0")]
	[Extension]
	[Token(Token = "0x6000599")]
	public static ControlBuilder Setup(InputControl control) { }

	[Address(RVA = "0x2933920", Offset = "0x2932D20", Length = "0x92")]
	[Extension]
	[Token(Token = "0x6000579")]
	public static void WriteValueFromObjectIntoEvent(InputControl control, InputEventPtr eventPtr, object value) { }

	[Address(RVA = "0x83B8D0", Offset = "0x83ACD0", Length = "0xEC")]
	[Extension]
	[Token(Token = "0x6000580")]
	public static void WriteValueIntoEvent(InputControl<TValue> control, TValue value, InputEventPtr eventPtr) { }

	[Address(RVA = "0x83B470", Offset = "0x83A870", Length = "0x2FE")]
	[Extension]
	[Token(Token = "0x600057F")]
	public static void WriteValueIntoEvent(InputControl control, TValue value, InputEventPtr eventPtr) { }

	[Address(RVA = "0x29339C0", Offset = "0x2932DC0", Length = "0x1AD")]
	[Extension]
	[Token(Token = "0x600057A")]
	public static void WriteValueIntoState(InputControl control, Void* statePtr) { }

	[Address(RVA = "0x83BAC0", Offset = "0x83AEC0", Length = "0x23D")]
	[Extension]
	[Token(Token = "0x600057B")]
	public static void WriteValueIntoState(InputControl control, TValue value, Void* statePtr) { }

	[Address(RVA = "0x83C430", Offset = "0x83B830", Length = "0x116")]
	[Extension]
	[Token(Token = "0x600057C")]
	public static void WriteValueIntoState(InputControl<TValue> control, TValue value, Void* statePtr) { }

	[Address(RVA = "0x83C070", Offset = "0x83B470", Length = "0x103")]
	[Extension]
	[Token(Token = "0x600057D")]
	public static void WriteValueIntoState(InputControl<TValue> control, Void* statePtr) { }

	[Address(RVA = "0x83BD00", Offset = "0x83B100", Length = "0x364")]
	[Extension]
	[Token(Token = "0x600057E")]
	public static void WriteValueIntoState(InputControl<TValue> control, TValue value, ref TState state) { }

}

