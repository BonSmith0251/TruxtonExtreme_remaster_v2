namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001C2")]
public sealed class InputEventTrace : IDisposable, IEnumerable<InputEventPtr>, IEnumerable
{
	[Token(Token = "0x20001C8")]
	internal struct DeviceInfo
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4000A6A")]
		internal int m_DeviceId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x4000A6B")]
		internal string m_Layout; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4000A6C")]
		internal FourCC m_StateFormat; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Token(Token = "0x4000A6D")]
		internal int m_StateSizeInBytes; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x4000A6E")]
		internal string m_FullLayoutJson; //Field offset: 0x18

		[Token(Token = "0x170004D7")]
		public int deviceId
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[Token(Token = "0x6001117")]
			 get { } //Length: 3
			[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
			[Token(Token = "0x6001118")]
			 set { } //Length: 3
		}

		[Token(Token = "0x170004D8")]
		public string layout
		{
			[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
			[Token(Token = "0x6001119")]
			 get { } //Length: 5
			[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
			[Token(Token = "0x600111A")]
			 set { } //Length: 13
		}

		[Token(Token = "0x170004D9")]
		public FourCC stateFormat
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x600111B")]
			 get { } //Length: 85
			[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
			[Token(Token = "0x600111C")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170004DA")]
		public int stateSizeInBytes
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[Token(Token = "0x600111D")]
			 get { } //Length: 4
			[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
			[Token(Token = "0x600111E")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6001117")]
		public int get_deviceId() { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6001119")]
		public string get_layout() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600111B")]
		public FourCC get_stateFormat() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x600111D")]
		public int get_stateSizeInBytes() { }

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6001118")]
		public void set_deviceId(int value) { }

		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[Token(Token = "0x600111A")]
		public void set_layout(string value) { }

		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x600111C")]
		public void set_stateFormat(FourCC value) { }

		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x600111E")]
		public void set_stateSizeInBytes(int value) { }

	}

	[Token(Token = "0x20001C3")]
	private class Enumerator : IEnumerator<InputEventPtr>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A54")]
		private InputEventTrace m_Trace; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A55")]
		private int m_ChangeCounter; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A56")]
		internal InputEventPtr m_Current; //Field offset: 0x20

		[Token(Token = "0x170004D0")]
		public override InputEventPtr Current
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x60010F7")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170004D1")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2A05B40", Offset = "0x2A04F40", Length = "0x45")]
			[Token(Token = "0x60010F8")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x2A05BF0", Offset = "0x2A04FF0", Length = "0x42")]
		[Token(Token = "0x60010F3")]
		public Enumerator(InputEventTrace trace) { }

		[Address(RVA = "0x2A05A10", Offset = "0x2A04E10", Length = "0x28")]
		[Token(Token = "0x60010F4")]
		public override void Dispose() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60010F7")]
		public override InputEventPtr get_Current() { }

		[Address(RVA = "0x2A05A40", Offset = "0x2A04E40", Length = "0xCF")]
		[Token(Token = "0x60010F5")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2A05B10", Offset = "0x2A04F10", Length = "0x23")]
		[Token(Token = "0x60010F6")]
		public override void Reset() { }

		[Address(RVA = "0x2A05B40", Offset = "0x2A04F40", Length = "0x45")]
		[Token(Token = "0x60010F8")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Flags]
	[Token(Token = "0x20001C4")]
	private enum FileFlags : int
	{
		FixedUpdate = 1,
	}

	[Token(Token = "0x20001C5")]
	internal class ReplayController : IDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20001C6")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A67")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000A68")]
			public static Comparison<InputEventPtr> <>9__38_0; //Field offset: 0x8

			[Address(RVA = "0x2A17580", Offset = "0x2A16980", Length = "0x67")]
			[Token(Token = "0x6001112")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6001113")]
			public <>c() { }

			[Address(RVA = "0x2A171E0", Offset = "0x2A165E0", Length = "0x4A")]
			[Token(Token = "0x6001114")]
			internal int <PlayAllEventsAccordingToTimestamps>b__38_0(InputEventPtr a, InputEventPtr b) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20001C7")]
		private sealed class <>c__DisplayClass43_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000A69")]
			public int originalDeviceId; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6001115")]
			public <>c__DisplayClass43_0() { }

			[Address(RVA = "0x2A17230", Offset = "0x2A16630", Length = "0x9")]
			[Token(Token = "0x6001116")]
			internal bool <ApplyDeviceMapping>b__0(DeviceInfo x) { }

		}

		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A59")]
		private bool <finished>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x4000A5A")]
		private bool <paused>k__BackingField; //Field offset: 0x11
		[CompilerGenerated]
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000A5B")]
		private int <position>k__BackingField; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A5C")]
		private InputEventTrace m_EventTrace; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A5D")]
		private Enumerator m_Enumerator; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A5E")]
		private InlinedArray<KeyValuePair`2<Int32, Int32>> m_DeviceIDMappings; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A5F")]
		private bool m_CreateNewDevices; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A60")]
		private InlinedArray<InputDevice> m_CreatedDevices; //Field offset: 0x48
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A61")]
		private Action m_OnFinished; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000A62")]
		private Action<InputEventPtr> m_OnEvent; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000A63")]
		private double m_StartTimeAsPerFirstEvent; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000A64")]
		private double m_StartTimeAsPerRuntime; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000A65")]
		private int m_AllEventsByTimeIndex; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000A66")]
		private List<InputEventPtr> m_AllEventsByTime; //Field offset: 0x88

		[Token(Token = "0x170004D6")]
		public IEnumerable<InputDevice> createdDevices
		{
			[Address(RVA = "0x2A16140", Offset = "0x2A15540", Length = "0x50")]
			[Token(Token = "0x6001100")]
			 get { } //Length: 80
		}

		[Token(Token = "0x170004D3")]
		public private bool finished
		{
			[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60010FA")]
			 get { } //Length: 5
			[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60010FB")]
			private set { } //Length: 4
		}

		[Token(Token = "0x170004D4")]
		public bool paused
		{
			[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60010FC")]
			 get { } //Length: 5
			[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60010FD")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170004D5")]
		public private int position
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60010FE")]
			 get { } //Length: 4
			[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60010FF")]
			private set { } //Length: 4
		}

		[Token(Token = "0x170004D2")]
		public InputEventTrace trace
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60010F9")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2A160C0", Offset = "0x2A154C0", Length = "0x7E")]
		[Token(Token = "0x6001101")]
		internal ReplayController(InputEventTrace trace) { }

		[Address(RVA = "0x2A14B20", Offset = "0x2A13F20", Length = "0x336")]
		[Token(Token = "0x6001111")]
		private int ApplyDeviceMapping(int originalDeviceId) { }

		[Address(RVA = "0x2A14E60", Offset = "0x2A14260", Length = "0x274")]
		[Token(Token = "0x6001102")]
		public override void Dispose() { }

		[Address(RVA = "0x2A150E0", Offset = "0x2A144E0", Length = "0xAA")]
		[Token(Token = "0x600110E")]
		private void Finished() { }

		[Address(RVA = "0x2A16140", Offset = "0x2A15540", Length = "0x50")]
		[Token(Token = "0x6001100")]
		public IEnumerable<InputDevice> get_createdDevices() { }

		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60010FA")]
		public bool get_finished() { }

		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60010FC")]
		public bool get_paused() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60010FE")]
		public int get_position() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60010F9")]
		public InputEventTrace get_trace() { }

		[Address(RVA = "0x2A15190", Offset = "0x2A14590", Length = "0x387")]
		[Token(Token = "0x6001110")]
		private bool MoveNext(bool skipFrameEvents, out InputEventPtr eventPtr) { }

		[Address(RVA = "0x2A15520", Offset = "0x2A14920", Length = "0x223")]
		[Token(Token = "0x600110D")]
		private void OnBeginFrame() { }

		[Address(RVA = "0x2A15750", Offset = "0x2A14B50", Length = "0x1F")]
		[Token(Token = "0x6001107")]
		public ReplayController OnEvent(Action<InputEventPtr> action) { }

		[Address(RVA = "0x65F1D0", Offset = "0x65E5D0", Length = "0x1F")]
		[Token(Token = "0x6001106")]
		public ReplayController OnFinished(Action action) { }

		[Address(RVA = "0x2A15A50", Offset = "0x2A14E50", Length = "0x91")]
		[Token(Token = "0x600110B")]
		public ReplayController PlayAllEvents() { }

		[Address(RVA = "0x2A15770", Offset = "0x2A14B70", Length = "0x2D7")]
		[Token(Token = "0x600110C")]
		public ReplayController PlayAllEventsAccordingToTimestamps() { }

		[Address(RVA = "0x2A15AF0", Offset = "0x2A14EF0", Length = "0x96")]
		[Token(Token = "0x600110A")]
		public ReplayController PlayAllFramesOneByOne() { }

		[Address(RVA = "0x2A15B90", Offset = "0x2A14F90", Length = "0x86")]
		[Token(Token = "0x6001108")]
		public ReplayController PlayOneEvent() { }

		[Address(RVA = "0x2A15C20", Offset = "0x2A15020", Length = "0x21D")]
		[Token(Token = "0x600110F")]
		private void QueueEvent(InputEventPtr eventPtr) { }

		[Address(RVA = "0x2A15E40", Offset = "0x2A15240", Length = "0x4F")]
		[Token(Token = "0x6001109")]
		public ReplayController Rewind() { }

		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60010FB")]
		private void set_finished(bool value) { }

		[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60010FD")]
		public void set_paused(bool value) { }

		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60010FF")]
		private void set_position(int value) { }

		[Address(RVA = "0x2A15E90", Offset = "0x2A15290", Length = "0x8")]
		[Token(Token = "0x6001105")]
		public ReplayController WithAllDevicesMappedToNewInstances() { }

		[Address(RVA = "0x2A15EA0", Offset = "0x2A152A0", Length = "0xC2")]
		[Token(Token = "0x6001103")]
		public ReplayController WithDeviceMappedFromTo(InputDevice recordedDevice, InputDevice playbackDevice) { }

		[Address(RVA = "0x2A15F70", Offset = "0x2A15370", Length = "0x143")]
		[Token(Token = "0x6001104")]
		public ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId) { }

	}

	[Token(Token = "0x4000A41")]
	private const int kDefaultBufferSize = 1048576; //Field offset: 0x0
	[Token(Token = "0x4000A42")]
	private static readonly ProfilerMarker k_InputEvenTraceMarker; //Field offset: 0x0
	[Token(Token = "0x4000A53")]
	private static int kFileVersion; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A43")]
	private int m_ChangeCounter; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A44")]
	private bool m_Enabled; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A45")]
	private Func<InputEventPtr, InputDevice, Boolean> m_OnFilterEvent; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000A46")]
	private int m_DeviceId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A47")]
	private CallbackArray<Action`1<InputEventPtr>> m_EventListeners; //Field offset: 0x28
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000A48")]
	private long m_EventBufferSize; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000A49")]
	private long m_MaxEventBufferSize; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000A4A")]
	private long m_GrowIncrementSize; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000A4B")]
	private long m_EventCount; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000A4C")]
	private long m_EventSizeInBytes; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000A4D")]
	private ulong m_EventBufferStorage; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000A4E")]
	private ulong m_EventBufferHeadStorage; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000A4F")]
	private ulong m_EventBufferTailStorage; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x4000A50")]
	private bool m_HasWrapped; //Field offset: 0xB8
	[FieldOffset(Offset = "0xB9")]
	[SerializeField]
	[Token(Token = "0x4000A51")]
	private bool m_RecordFrameMarkers; //Field offset: 0xB9
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x4000A52")]
	private DeviceInfo[] m_DeviceInfos; //Field offset: 0xC0

	[Token(Token = "0x14000026")]
	public event Action<InputEventPtr> onEvent
	{
		[Address(RVA = "0x29FABB0", Offset = "0x29F9FB0", Length = "0x49")]
		[Token(Token = "0x60010D4")]
		 add { } //Length: 73
		[Address(RVA = "0x29FAD10", Offset = "0x29FA110", Length = "0x49")]
		[Token(Token = "0x60010D5")]
		 remove { } //Length: 73
	}

	[Token(Token = "0x170004C8")]
	public long allocatedSizeInBytes
	{
		[Address(RVA = "0x29FAC40", Offset = "0x29FA040", Length = "0x12")]
		[Token(Token = "0x60010CF")]
		 get { } //Length: 18
	}

	[Token(Token = "0x170004C3")]
	public int deviceId
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60010C8")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x60010C9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004CA")]
	public ReadOnlyArray<DeviceInfo> deviceInfos
	{
		[Address(RVA = "0x29FAC60", Offset = "0x29FA060", Length = "0x5A")]
		[Token(Token = "0x60010D1")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170004C4")]
	public bool enabled
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x60010CA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004C6")]
	public long eventCount
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x60010CD")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170004C2")]
	public static FourCC FrameMarkerEvent
	{
		[Address(RVA = "0x29FAC00", Offset = "0x29FA000", Length = "0x3A")]
		[Token(Token = "0x60010C7")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170004CF")]
	private static FourCC kFileFormat
	{
		[Address(RVA = "0x29FACC0", Offset = "0x29FA0C0", Length = "0x3A")]
		[Token(Token = "0x60010F1")]
		private get { } //Length: 58
	}

	[Token(Token = "0x170004CC")]
	private Byte* m_EventBuffer
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x60010E7")]
		private get { } //Length: 8
		[Address(RVA = "0x2144890", Offset = "0x2143C90", Length = "0x8")]
		[Token(Token = "0x60010E8")]
		private set { } //Length: 8
	}

	[Token(Token = "0x170004CD")]
	private Byte* m_EventBufferHead
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x60010E9")]
		private get { } //Length: 8
		[Address(RVA = "0x2144A30", Offset = "0x2143E30", Length = "0x8")]
		[Token(Token = "0x60010EA")]
		private set { } //Length: 8
	}

	[Token(Token = "0x170004CE")]
	private Byte* m_EventBufferTail
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[Token(Token = "0x60010EB")]
		private get { } //Length: 8
		[Address(RVA = "0x29FAD60", Offset = "0x29FA160", Length = "0x8")]
		[Token(Token = "0x60010EC")]
		private set { } //Length: 8
	}

	[Token(Token = "0x170004C9")]
	public long maxSizeInBytes
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x60010D0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170004CB")]
	public Func<InputEventPtr, InputDevice, Boolean> onFilterEvent
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60010D2")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60010D3")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170004C5")]
	public bool recordFrameMarkers
	{
		[Address(RVA = "0x29FAD00", Offset = "0x29FA100", Length = "0x8")]
		[Token(Token = "0x60010CB")]
		 get { } //Length: 8
		[Address(RVA = "0x29FAD70", Offset = "0x29FA170", Length = "0xDF")]
		[Token(Token = "0x60010CC")]
		 set { } //Length: 223
	}

	[Token(Token = "0x170004C7")]
	public long totalEventSizeInBytes
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x60010CE")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x29FA9C0", Offset = "0x29F9DC0", Length = "0x73")]
	[Token(Token = "0x60010F2")]
	private static InputEventTrace() { }

	[Address(RVA = "0x29FAA40", Offset = "0x29F9E40", Length = "0x7D")]
	[Token(Token = "0x60010D7")]
	public InputEventTrace(long bufferSizeInBytes = 1048576, bool growBuffer = false, long maxBufferSizeInBytes = -1, long growIncrementSizeInBytes = -1) { }

	[Address(RVA = "0x29FAAC0", Offset = "0x29F9EC0", Length = "0xE6")]
	[Token(Token = "0x60010D6")]
	public InputEventTrace(InputDevice device, long bufferSizeInBytes = 1048576, bool growBuffer = false, long maxBufferSizeInBytes = -1, long growIncrementSizeInBytes = -1) { }

	[Address(RVA = "0x29FABB0", Offset = "0x29F9FB0", Length = "0x49")]
	[Token(Token = "0x60010D4")]
	public void add_onEvent(Action<InputEventPtr> value) { }

	[Address(RVA = "0x29F8670", Offset = "0x29F7A70", Length = "0x2A")]
	[Token(Token = "0x60010ED")]
	private void Allocate() { }

	[Address(RVA = "0x29F86A0", Offset = "0x29F7AA0", Length = "0x34")]
	[Token(Token = "0x60010E0")]
	public void Clear() { }

	[Address(RVA = "0x29F86E0", Offset = "0x29F7AE0", Length = "0x106")]
	[Token(Token = "0x60010E2")]
	public void Disable() { }

	[Address(RVA = "0x29F87F0", Offset = "0x29F7BF0", Length = "0x79")]
	[Token(Token = "0x60010E6")]
	public override void Dispose() { }

	[Address(RVA = "0x29F8870", Offset = "0x29F7C70", Length = "0x149")]
	[Token(Token = "0x60010E1")]
	public void Enable() { }

	[Address(RVA = "0x29FAC40", Offset = "0x29FA040", Length = "0x12")]
	[Token(Token = "0x60010CF")]
	public long get_allocatedSizeInBytes() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60010C8")]
	public int get_deviceId() { }

	[Address(RVA = "0x29FAC60", Offset = "0x29FA060", Length = "0x5A")]
	[Token(Token = "0x60010D1")]
	public ReadOnlyArray<DeviceInfo> get_deviceInfos() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x60010CA")]
	public bool get_enabled() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x60010CD")]
	public long get_eventCount() { }

	[Address(RVA = "0x29FAC00", Offset = "0x29FA000", Length = "0x3A")]
	[Token(Token = "0x60010C7")]
	public static FourCC get_FrameMarkerEvent() { }

	[Address(RVA = "0x29FACC0", Offset = "0x29FA0C0", Length = "0x3A")]
	[Token(Token = "0x60010F1")]
	private static FourCC get_kFileFormat() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x60010E7")]
	private Byte* get_m_EventBuffer() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x60010E9")]
	private Byte* get_m_EventBufferHead() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[Token(Token = "0x60010EB")]
	private Byte* get_m_EventBufferTail() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x60010D0")]
	public long get_maxSizeInBytes() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60010D2")]
	public Func<InputEventPtr, InputDevice, Boolean> get_onFilterEvent() { }

	[Address(RVA = "0x29FAD00", Offset = "0x29FA100", Length = "0x8")]
	[Token(Token = "0x60010CB")]
	public bool get_recordFrameMarkers() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x60010CE")]
	public long get_totalEventSizeInBytes() { }

	[Address(RVA = "0x29F89C0", Offset = "0x29F7DC0", Length = "0x54")]
	[Token(Token = "0x60010E4")]
	public override IEnumerator<InputEventPtr> GetEnumerator() { }

	[Address(RVA = "0x29F8A20", Offset = "0x29F7E20", Length = "0x7C")]
	[Token(Token = "0x60010E3")]
	public bool GetNextEvent(ref InputEventPtr current) { }

	[Address(RVA = "0x29F8BF0", Offset = "0x29F7FF0", Length = "0x260")]
	[Token(Token = "0x60010DC")]
	public static InputEventTrace LoadFrom(string filePath) { }

	[Address(RVA = "0x29F8AA0", Offset = "0x29F7EA0", Length = "0x143")]
	[Token(Token = "0x60010DD")]
	public static InputEventTrace LoadFrom(Stream stream) { }

	[Address(RVA = "0x29F8E60", Offset = "0x29F8260", Length = "0x11C")]
	[Token(Token = "0x60010EF")]
	private void OnBeforeUpdate() { }

	[Address(RVA = "0x29F8F80", Offset = "0x29F8380", Length = "0x58D")]
	[Token(Token = "0x60010F0")]
	private void OnInputEvent(InputEventPtr inputEvent, InputDevice device) { }

	[Address(RVA = "0x29F9620", Offset = "0x29F8A20", Length = "0x7F0")]
	[Token(Token = "0x60010DB")]
	public void ReadFrom(Stream stream) { }

	[Address(RVA = "0x29F9510", Offset = "0x29F8910", Length = "0x10F")]
	[Token(Token = "0x60010DA")]
	public void ReadFrom(string filePath) { }

	[Address(RVA = "0x29F9E20", Offset = "0x29F9220", Length = "0x72")]
	[Token(Token = "0x60010EE")]
	private void Release() { }

	[Address(RVA = "0x29FAD10", Offset = "0x29FA110", Length = "0x49")]
	[Token(Token = "0x60010D5")]
	public void remove_onEvent(Action<InputEventPtr> value) { }

	[Address(RVA = "0x29F9EA0", Offset = "0x29F92A0", Length = "0x5E")]
	[Token(Token = "0x60010DE")]
	public ReplayController Replay() { }

	[Address(RVA = "0x29F9F00", Offset = "0x29F9300", Length = "0x2AD")]
	[Token(Token = "0x60010DF")]
	public bool Resize(long newBufferSize, long newMaxBufferSize = -1) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x60010C9")]
	public void set_deviceId(int value) { }

	[Address(RVA = "0x2144890", Offset = "0x2143C90", Length = "0x8")]
	[Token(Token = "0x60010E8")]
	private void set_m_EventBuffer(Byte* value) { }

	[Address(RVA = "0x2144A30", Offset = "0x2143E30", Length = "0x8")]
	[Token(Token = "0x60010EA")]
	private void set_m_EventBufferHead(Byte* value) { }

	[Address(RVA = "0x29FAD60", Offset = "0x29FA160", Length = "0x8")]
	[Token(Token = "0x60010EC")]
	private void set_m_EventBufferTail(Byte* value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60010D3")]
	public void set_onFilterEvent(Func<InputEventPtr, InputDevice, Boolean> value) { }

	[Address(RVA = "0x29FAD70", Offset = "0x29FA170", Length = "0xDF")]
	[Token(Token = "0x60010CC")]
	public void set_recordFrameMarkers(bool value) { }

	[Address(RVA = "0x29F89C0", Offset = "0x29F7DC0", Length = "0x54")]
	[Token(Token = "0x60010E5")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x29FA8B0", Offset = "0x29F9CB0", Length = "0x10F")]
	[Token(Token = "0x60010D8")]
	public void WriteTo(string filePath) { }

	[Address(RVA = "0x29FA1B0", Offset = "0x29F95B0", Length = "0x6F6")]
	[Token(Token = "0x60010D9")]
	public void WriteTo(Stream stream) { }

}

