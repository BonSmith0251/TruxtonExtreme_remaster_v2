namespace UnityEngine.InputSystem;

[Token(Token = "0x2000089")]
public class InputDevice : InputControl
{
	[Token(Token = "0x200008B")]
	public struct ControlBitRangeNode
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000332")]
		public ushort endBitOffset; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x4000333")]
		public short leftChildIndex; //Field offset: 0x2
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000334")]
		public ushort controlStartIndex; //Field offset: 0x4
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x4000335")]
		public byte controlCount; //Field offset: 0x6

		[Address(RVA = "0x2993600", Offset = "0x2992A00", Length = "0xF")]
		[Token(Token = "0x60006AB")]
		public ControlBitRangeNode(ushort endOffset) { }

	}

	[Flags]
	[Token(Token = "0x200008A")]
	public enum DeviceFlags : int
	{
		UpdateBeforeRender = 1,
		HasStateCallbacks = 2,
		HasControlsWithDefaultState = 4,
		HasDontResetControls = 1024,
		HasEventMerger = 8192,
		HasEventPreProcessor = 16384,
		Remote = 8,
		Native = 16,
		DisabledInFrontend = 32,
		DisabledInRuntime = 128,
		DisabledWhileInBackground = 256,
		DisabledStateHasBeenQueriedFromRuntime = 64,
		CanRunInBackground = 2048,
		CanRunInBackgroundHasBeenQueried = 4096,
	}

	[Token(Token = "0x400030B")]
	public const int InvalidDeviceId = 0; //Field offset: 0x0
	[Token(Token = "0x4000320")]
	internal const int kControlIndexBits = 10; //Field offset: 0x0
	[Token(Token = "0x4000321")]
	internal const int kStateOffsetBits = 13; //Field offset: 0x0
	[Token(Token = "0x4000322")]
	internal const int kStateSizeBits = 9; //Field offset: 0x0
	[Token(Token = "0x400030D")]
	internal const int kInvalidDeviceIndex = -1; //Field offset: 0x0
	[Token(Token = "0x400030C")]
	internal const int kLocalParticipantId = 0; //Field offset: 0x0
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400030E")]
	internal DeviceFlags m_DeviceFlags; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x400030F")]
	internal int m_DeviceId; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000310")]
	internal int m_ParticipantId; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000311")]
	internal int m_DeviceIndex; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000312")]
	internal uint m_CurrentProcessedEventBytesOnUpdate; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000313")]
	internal InputDeviceDescription m_Description; //Field offset: 0xF8
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000314")]
	internal double m_LastUpdateTimeInternal; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000315")]
	internal uint m_CurrentUpdateStepCount; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000316")]
	internal InternedString[] m_AliasesForEachControl; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000317")]
	internal InternedString[] m_UsagesForEachControl; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000318")]
	internal InputControl[] m_UsageToControl; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000319")]
	internal InputControl[] m_ChildrenForEachControl; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400031A")]
	internal HashSet<Int32> m_UpdatedButtons; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400031B")]
	internal List<ButtonControl> m_ButtonControlsCheckingPressState; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400031C")]
	internal bool m_UseCachePathForButtonPresses; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x400031D")]
	internal UInt32[] m_StateOffsetToControlMap; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x400031E")]
	internal ControlBitRangeNode[] m_ControlTreeNodes; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x400031F")]
	internal UInt16[] m_ControlTreeIndices; //Field offset: 0x188

	[Token(Token = "0x170001CA")]
	public bool added
	{
		[Address(RVA = "0x293A110", Offset = "0x2939510", Length = "0xB")]
		[Token(Token = "0x6000670")]
		 get { } //Length: 11
	}

	[Obsolete("Use 'InputSystem.devices' instead. (UnityUpgradable) -> InputSystem.devices", False)]
	[Token(Token = "0x170001D4")]
	public static ReadOnlyArray<InputDevice> all
	{
		[Address(RVA = "0x293A180", Offset = "0x2939580", Length = "0xA3")]
		[Token(Token = "0x600067A")]
		 get { } //Length: 163
	}

	[Token(Token = "0x170001D1")]
	public ReadOnlyArray<InputControl> allControls
	{
		[Address(RVA = "0x293A120", Offset = "0x2939520", Length = "0x56")]
		[Token(Token = "0x6000677")]
		 get { } //Length: 86
	}

	[Token(Token = "0x170001C9")]
	internal bool canDeviceRunInBackground
	{
		[Address(RVA = "0x293A230", Offset = "0x2939630", Length = "0xBB")]
		[Token(Token = "0x600066F")]
		internal get { } //Length: 187
	}

	[Token(Token = "0x170001C8")]
	public bool canRunInBackground
	{
		[Address(RVA = "0x293A230", Offset = "0x2939630", Length = "0xBB")]
		[Token(Token = "0x600066E")]
		 get { } //Length: 187
	}

	[Token(Token = "0x170001C6")]
	public InputDeviceDescription description
	{
		[Address(RVA = "0x293A2F0", Offset = "0x29396F0", Length = "0x31")]
		[Token(Token = "0x600066C")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170001CE")]
	public int deviceId
	{
		[Address(RVA = "0x8425F0", Offset = "0x8419F0", Length = "0x7")]
		[Token(Token = "0x6000674")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001D5")]
	internal bool disabledInFrontend
	{
		[Address(RVA = "0x293A330", Offset = "0x2939730", Length = "0xB")]
		[Token(Token = "0x6000688")]
		internal get { } //Length: 11
		[Address(RVA = "0x293A5F0", Offset = "0x29399F0", Length = "0x1F")]
		[Token(Token = "0x6000689")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x170001D6")]
	internal bool disabledInRuntime
	{
		[Address(RVA = "0x293A340", Offset = "0x2939740", Length = "0xE")]
		[Token(Token = "0x600068A")]
		internal get { } //Length: 14
		[Address(RVA = "0x293A610", Offset = "0x2939A10", Length = "0x21")]
		[Token(Token = "0x600068B")]
		internal set { } //Length: 33
	}

	[Token(Token = "0x170001D7")]
	internal bool disabledWhileInBackground
	{
		[Address(RVA = "0x293A350", Offset = "0x2939750", Length = "0xE")]
		[Token(Token = "0x600068C")]
		internal get { } //Length: 14
		[Address(RVA = "0x293A640", Offset = "0x2939A40", Length = "0x21")]
		[Token(Token = "0x600068D")]
		internal set { } //Length: 33
	}

	[Token(Token = "0x170001C7")]
	public bool enabled
	{
		[Address(RVA = "0x293A360", Offset = "0x2939760", Length = "0xC4")]
		[Token(Token = "0x600066D")]
		 get { } //Length: 196
	}

	[Token(Token = "0x170001D8")]
	internal bool hasControlsWithDefaultState
	{
		[Address(RVA = "0x293A430", Offset = "0x2939830", Length = "0xC")]
		[Token(Token = "0x6000690")]
		internal get { } //Length: 12
		[Address(RVA = "0x293A670", Offset = "0x2939A70", Length = "0x1F")]
		[Token(Token = "0x6000691")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x170001D9")]
	internal bool hasDontResetControls
	{
		[Address(RVA = "0x293A440", Offset = "0x2939840", Length = "0xC")]
		[Token(Token = "0x6000692")]
		internal get { } //Length: 12
		[Address(RVA = "0x293A690", Offset = "0x2939A90", Length = "0x21")]
		[Token(Token = "0x6000693")]
		internal set { } //Length: 33
	}

	[Token(Token = "0x170001DB")]
	internal bool hasEventMerger
	{
		[Address(RVA = "0x293A450", Offset = "0x2939850", Length = "0xC")]
		[Token(Token = "0x6000696")]
		internal get { } //Length: 12
		[Address(RVA = "0x293A6C0", Offset = "0x2939AC0", Length = "0x21")]
		[Token(Token = "0x6000697")]
		internal set { } //Length: 33
	}

	[Token(Token = "0x170001DC")]
	internal bool hasEventPreProcessor
	{
		[Address(RVA = "0x293A460", Offset = "0x2939860", Length = "0xC")]
		[Token(Token = "0x6000698")]
		internal get { } //Length: 12
		[Address(RVA = "0x293A6F0", Offset = "0x2939AF0", Length = "0x21")]
		[Token(Token = "0x6000699")]
		internal set { } //Length: 33
	}

	[Token(Token = "0x170001DA")]
	internal bool hasStateCallbacks
	{
		[Address(RVA = "0x293A470", Offset = "0x2939870", Length = "0xB")]
		[Token(Token = "0x6000694")]
		internal get { } //Length: 11
		[Address(RVA = "0x293A720", Offset = "0x2939B20", Length = "0x1F")]
		[Token(Token = "0x6000695")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x170001CF")]
	public double lastUpdateTime
	{
		[Address(RVA = "0x293A480", Offset = "0x2939880", Length = "0x46")]
		[Token(Token = "0x6000675")]
		 get { } //Length: 70
	}

	[Token(Token = "0x170001CC")]
	public bool native
	{
		[Address(RVA = "0x293A4D0", Offset = "0x29398D0", Length = "0xC")]
		[Token(Token = "0x6000672")]
		 get { } //Length: 12
	}

	[Token(Token = "0x170001CB")]
	public bool remote
	{
		[Address(RVA = "0x293A4E0", Offset = "0x29398E0", Length = "0xC")]
		[Token(Token = "0x6000671")]
		 get { } //Length: 12
	}

	[Token(Token = "0x170001CD")]
	public bool updateBeforeRender
	{
		[Address(RVA = "0x293A4F0", Offset = "0x29398F0", Length = "0xA")]
		[Token(Token = "0x6000673")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170001D3")]
	public virtual int valueSizeInBytes
	{
		[Address(RVA = "0x293A500", Offset = "0x2939900", Length = "0x4A")]
		[Token(Token = "0x6000679")]
		 get { } //Length: 74
	}

	[Token(Token = "0x170001D2")]
	public virtual Type valueType
	{
		[Address(RVA = "0x293A550", Offset = "0x2939950", Length = "0x4D")]
		[Token(Token = "0x6000678")]
		 get { } //Length: 77
	}

	[Token(Token = "0x170001D0")]
	public bool wasUpdatedThisFrame
	{
		[Address(RVA = "0x293A5A0", Offset = "0x29399A0", Length = "0x44")]
		[Token(Token = "0x6000676")]
		 get { } //Length: 68
	}

	[Address(RVA = "0x292DDF0", Offset = "0x292D1F0", Length = "0x6D")]
	[Token(Token = "0x600067B")]
	public InputDevice() { }

	[Address(RVA = "0x2938400", Offset = "0x2937800", Length = "0xAF")]
	[Token(Token = "0x600069A")]
	internal void AddDeviceUsage(InternedString usage) { }

	[Address(RVA = "0x843140", Offset = "0x842540", Length = "0x51D")]
	[Token(Token = "0x60006A3")]
	internal static TDevice Build(string layoutName = null, string layoutVariants = null, InputDeviceDescription deviceDescription = null, bool noPrecompiledLayouts = false) { }

	[Address(RVA = "0x29384B0", Offset = "0x29378B0", Length = "0x68")]
	[Token(Token = "0x600069C")]
	internal void ClearDeviceUsages() { }

	[Address(RVA = "0x2938520", Offset = "0x2937920", Length = "0x12D")]
	[Token(Token = "0x600067F")]
	public virtual bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	[Address(RVA = "0x2938650", Offset = "0x2937A50", Length = "0x1E")]
	[Token(Token = "0x600068F")]
	internal static void DecodeStateOffsetToControlMapEntry(uint entry, out uint controlIndex, out uint stateOffset, out uint stateSize) { }

	[Address(RVA = "0x2938670", Offset = "0x2937A70", Length = "0x488")]
	[Token(Token = "0x60006A6")]
	private void DumpControlBitRangeNode(int nodeIndex, ControlBitRangeNode node, uint startOffset, uint sizeInBits, List<String> output) { }

	[Address(RVA = "0x2938B00", Offset = "0x2937F00", Length = "0x1A6")]
	[Token(Token = "0x60006A7")]
	private void DumpControlTree(ControlBitRangeNode parentNode, uint startOffset, List<String> output) { }

	[Address(RVA = "0x2938CB0", Offset = "0x29380B0", Length = "0xCC")]
	[Token(Token = "0x60006A8")]
	internal string DumpControlTree() { }

	[Address(RVA = "0x2938D80", Offset = "0x2938180", Length = "0xE")]
	[Token(Token = "0x600068E")]
	internal static uint EncodeStateOffsetToControlMapEntry(uint controlIndex, uint stateOffsetInBits, uint stateSizeInBits) { }

	[Address(RVA = "0x2938D90", Offset = "0x2938190", Length = "0xEA")]
	[Token(Token = "0x6000686")]
	protected override long ExecuteCommand(InputDeviceCommand* commandPtr) { }

	[Address(RVA = "0x843660", Offset = "0x842A60", Length = "0x28B")]
	[Token(Token = "0x6000685")]
	public long ExecuteCommand(ref TCommand command) { }

	[Address(RVA = "0x2938E80", Offset = "0x2938280", Length = "0x65")]
	[Token(Token = "0x60006A0")]
	internal bool ExecuteDisableCommand() { }

	[Address(RVA = "0x2938EF0", Offset = "0x29382F0", Length = "0x6F")]
	[Token(Token = "0x600069F")]
	internal bool ExecuteEnableCommand() { }

	[Address(RVA = "0x293A110", Offset = "0x2939510", Length = "0xB")]
	[Token(Token = "0x6000670")]
	public bool get_added() { }

	[Address(RVA = "0x293A180", Offset = "0x2939580", Length = "0xA3")]
	[Token(Token = "0x600067A")]
	public static ReadOnlyArray<InputDevice> get_all() { }

	[Address(RVA = "0x293A120", Offset = "0x2939520", Length = "0x56")]
	[Token(Token = "0x6000677")]
	public ReadOnlyArray<InputControl> get_allControls() { }

	[Address(RVA = "0x293A230", Offset = "0x2939630", Length = "0xBB")]
	[Token(Token = "0x600066F")]
	internal bool get_canDeviceRunInBackground() { }

	[Address(RVA = "0x293A230", Offset = "0x2939630", Length = "0xBB")]
	[Token(Token = "0x600066E")]
	public bool get_canRunInBackground() { }

	[Address(RVA = "0x293A2F0", Offset = "0x29396F0", Length = "0x31")]
	[Token(Token = "0x600066C")]
	public InputDeviceDescription get_description() { }

	[Address(RVA = "0x8425F0", Offset = "0x8419F0", Length = "0x7")]
	[Token(Token = "0x6000674")]
	public int get_deviceId() { }

	[Address(RVA = "0x293A330", Offset = "0x2939730", Length = "0xB")]
	[Token(Token = "0x6000688")]
	internal bool get_disabledInFrontend() { }

	[Address(RVA = "0x293A340", Offset = "0x2939740", Length = "0xE")]
	[Token(Token = "0x600068A")]
	internal bool get_disabledInRuntime() { }

	[Address(RVA = "0x293A350", Offset = "0x2939750", Length = "0xE")]
	[Token(Token = "0x600068C")]
	internal bool get_disabledWhileInBackground() { }

	[Address(RVA = "0x293A360", Offset = "0x2939760", Length = "0xC4")]
	[Token(Token = "0x600066D")]
	public bool get_enabled() { }

	[Address(RVA = "0x293A430", Offset = "0x2939830", Length = "0xC")]
	[Token(Token = "0x6000690")]
	internal bool get_hasControlsWithDefaultState() { }

	[Address(RVA = "0x293A440", Offset = "0x2939840", Length = "0xC")]
	[Token(Token = "0x6000692")]
	internal bool get_hasDontResetControls() { }

	[Address(RVA = "0x293A450", Offset = "0x2939850", Length = "0xC")]
	[Token(Token = "0x6000696")]
	internal bool get_hasEventMerger() { }

	[Address(RVA = "0x293A460", Offset = "0x2939860", Length = "0xC")]
	[Token(Token = "0x6000698")]
	internal bool get_hasEventPreProcessor() { }

	[Address(RVA = "0x293A470", Offset = "0x2939870", Length = "0xB")]
	[Token(Token = "0x6000694")]
	internal bool get_hasStateCallbacks() { }

	[Address(RVA = "0x293A480", Offset = "0x2939880", Length = "0x46")]
	[Token(Token = "0x6000675")]
	public double get_lastUpdateTime() { }

	[Address(RVA = "0x293A4D0", Offset = "0x29398D0", Length = "0xC")]
	[Token(Token = "0x6000672")]
	public bool get_native() { }

	[Address(RVA = "0x293A4E0", Offset = "0x29398E0", Length = "0xC")]
	[Token(Token = "0x6000671")]
	public bool get_remote() { }

	[Address(RVA = "0x293A4F0", Offset = "0x29398F0", Length = "0xA")]
	[Token(Token = "0x6000673")]
	public bool get_updateBeforeRender() { }

	[Address(RVA = "0x293A500", Offset = "0x2939900", Length = "0x4A")]
	[Token(Token = "0x6000679")]
	public virtual int get_valueSizeInBytes() { }

	[Address(RVA = "0x293A550", Offset = "0x2939950", Length = "0x4D")]
	[Token(Token = "0x6000678")]
	public virtual Type get_valueType() { }

	[Address(RVA = "0x293A5A0", Offset = "0x29399A0", Length = "0x44")]
	[Token(Token = "0x6000676")]
	public bool get_wasUpdatedThisFrame() { }

	[Address(RVA = "0x2938F60", Offset = "0x2938360", Length = "0x65")]
	[Token(Token = "0x60006AA")]
	private static bool HasDataChangedInRange(Byte* deviceStatePtr, Void* statePtr, uint startOffset, uint sizeInBits) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000681")]
	public override void MakeCurrent() { }

	[Address(RVA = "0x2650990", Offset = "0x264FD90", Length = "0x14")]
	[Token(Token = "0x60006A1")]
	internal void NotifyAdded() { }

	[Address(RVA = "0x2938FD0", Offset = "0x29383D0", Length = "0x8E")]
	[Token(Token = "0x6000680")]
	internal void NotifyConfigurationChanged() { }

	[Address(RVA = "0x1E9E660", Offset = "0x1E9DA60", Length = "0x14")]
	[Token(Token = "0x60006A2")]
	internal void NotifyRemoved() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000682")]
	protected override void OnAdded() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000684")]
	protected override void OnConfigurationChanged() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000683")]
	protected override void OnRemoved() { }

	[Address(RVA = "0x2939060", Offset = "0x2938460", Length = "0xAC")]
	[Token(Token = "0x6000687")]
	internal bool QueryEnabledStateFromRuntime() { }

	[Address(RVA = "0x2939110", Offset = "0x2938510", Length = "0x3E")]
	[Token(Token = "0x600067C")]
	public virtual object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	[Address(RVA = "0x2939150", Offset = "0x2938550", Length = "0x102")]
	[Token(Token = "0x600067D")]
	public virtual object ReadValueFromStateAsObject(Void* statePtr) { }

	[Address(RVA = "0x2939260", Offset = "0x2938660", Length = "0x1DE")]
	[Token(Token = "0x600067E")]
	public virtual void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	[Address(RVA = "0x2939440", Offset = "0x2938840", Length = "0xD8")]
	[Token(Token = "0x600069B")]
	internal void RemoveDeviceUsage(InternedString usage) { }

	[Address(RVA = "0x2939520", Offset = "0x2938920", Length = "0x6F")]
	[Token(Token = "0x600069E")]
	internal bool RequestReset() { }

	[Address(RVA = "0x2939590", Offset = "0x2938990", Length = "0x6F")]
	[Token(Token = "0x600069D")]
	internal bool RequestSync() { }

	[Address(RVA = "0x293A5F0", Offset = "0x29399F0", Length = "0x1F")]
	[Token(Token = "0x6000689")]
	internal void set_disabledInFrontend(bool value) { }

	[Address(RVA = "0x293A610", Offset = "0x2939A10", Length = "0x21")]
	[Token(Token = "0x600068B")]
	internal void set_disabledInRuntime(bool value) { }

	[Address(RVA = "0x293A640", Offset = "0x2939A40", Length = "0x21")]
	[Token(Token = "0x600068D")]
	internal void set_disabledWhileInBackground(bool value) { }

	[Address(RVA = "0x293A670", Offset = "0x2939A70", Length = "0x1F")]
	[Token(Token = "0x6000691")]
	internal void set_hasControlsWithDefaultState(bool value) { }

	[Address(RVA = "0x293A690", Offset = "0x2939A90", Length = "0x21")]
	[Token(Token = "0x6000693")]
	internal void set_hasDontResetControls(bool value) { }

	[Address(RVA = "0x293A6C0", Offset = "0x2939AC0", Length = "0x21")]
	[Token(Token = "0x6000697")]
	internal void set_hasEventMerger(bool value) { }

	[Address(RVA = "0x293A6F0", Offset = "0x2939AF0", Length = "0x21")]
	[Token(Token = "0x6000699")]
	internal void set_hasEventPreProcessor(bool value) { }

	[Address(RVA = "0x293A720", Offset = "0x2939B20", Length = "0x1F")]
	[Token(Token = "0x6000695")]
	internal void set_hasStateCallbacks(bool value) { }

	[Address(RVA = "0x2939B50", Offset = "0x2938F50", Length = "0x17A")]
	[Token(Token = "0x60006A4")]
	internal void WriteChangedControlStates(Byte* deviceStateBuffer, Void* statePtr, uint stateSizeInBytes, uint stateOffsetInDevice) { }

	[Address(RVA = "0x2939600", Offset = "0x2938A00", Length = "0x542")]
	[Token(Token = "0x60006A9")]
	private void WriteChangedControlStatesInternal(Void* statePtr, Byte* deviceStatePtr, ControlBitRangeNode parentNode, uint startOffset) { }

	[Address(RVA = "0x2939CD0", Offset = "0x29390D0", Length = "0x437")]
	[Token(Token = "0x60006A5")]
	private void WritePartialChangedControlStatesInternal(uint stateSizeInBits, uint stateOffsetInDeviceInBits, ControlBitRangeNode parentNode, uint startOffset) { }

}

