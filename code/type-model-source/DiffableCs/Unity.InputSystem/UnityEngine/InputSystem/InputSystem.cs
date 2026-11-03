namespace UnityEngine.InputSystem;

[Token(Token = "0x2000069")]
public static class InputSystem
{
	[CompilerGenerated]
	[Token(Token = "0x200006E")]
	private sealed class <>c
	{
		[Token(Token = "0x4000261")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000262")]
		public static Func<InputEventPtr, InputControl> <>9__80_0; //Field offset: 0x8
		[Token(Token = "0x4000263")]
		public static Func<InputControl, Boolean> <>9__80_1; //Field offset: 0x10

		[Address(RVA = "0x29442D0", Offset = "0x29436D0", Length = "0x67")]
		[Token(Token = "0x6000508")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000509")]
		public <>c() { }

		[Address(RVA = "0x29441D0", Offset = "0x29435D0", Length = "0x16")]
		[Token(Token = "0x600050A")]
		internal InputControl <get_onAnyButtonPress>b__80_0(InputEventPtr e) { }

		[Address(RVA = "0x234E9B0", Offset = "0x234DDB0", Length = "0x7")]
		[Token(Token = "0x600050B")]
		internal bool <get_onAnyButtonPress>b__80_1(InputControl c) { }

	}

	[Token(Token = "0x200006C")]
	private struct DeltaStateEventBuffer
	{
		[CompilerGenerated]
		[Token(Token = "0x200006D")]
		[UnsafeValueType]
		internal struct <data>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000260")]
			public byte FixedElementField; //Field offset: 0x0

		}

		[Token(Token = "0x400025E")]
		public const int kMaxSize = 512; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025D")]
		public DeltaStateEvent stateEvent; //Field offset: 0x0
		[FieldOffset(Offset = "0x1D")]
		[FixedBuffer(typeof(byte), 511)]
		[Token(Token = "0x400025F")]
		public <data>e__FixedBuffer data; //Field offset: 0x1D

	}

	[Token(Token = "0x200006A")]
	private struct StateEventBuffer
	{
		[CompilerGenerated]
		[Token(Token = "0x200006B")]
		[UnsafeValueType]
		internal struct <data>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400025C")]
			public byte FixedElementField; //Field offset: 0x0

		}

		[Token(Token = "0x400025A")]
		public const int kMaxSize = 512; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000259")]
		public StateEvent stateEvent; //Field offset: 0x0
		[FieldOffset(Offset = "0x19")]
		[FixedBuffer(typeof(byte), 511)]
		[Token(Token = "0x400025B")]
		public <data>e__FixedBuffer data; //Field offset: 0x19

	}

	[Token(Token = "0x4000254")]
	internal const string kAssemblyVersion = "1.18.0"; //Field offset: 0x0
	[Token(Token = "0x4000255")]
	internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18"; //Field offset: 0x0
	[Token(Token = "0x4000256")]
	private static readonly ProfilerMarker k_InputResetMarker; //Field offset: 0x0
	[Token(Token = "0x4000257")]
	internal static InputManager s_Manager; //Field offset: 0x8
	[Token(Token = "0x4000258")]
	internal static InputRemoting s_Remote; //Field offset: 0x10

	[Token(Token = "0x1400000D")]
	public static event Action<Object, InputActionChange> onActionChange
	{
		[Address(RVA = "0x293F4B0", Offset = "0x293E8B0", Length = "0xB9")]
		[Token(Token = "0x60004F0")]
		 add { } //Length: 185
		[Address(RVA = "0x2940540", Offset = "0x293F940", Length = "0xB9")]
		[Token(Token = "0x60004F1")]
		 remove { } //Length: 185
	}

	[Token(Token = "0x1400000C")]
	public static event Action onActionsChange
	{
		[Address(RVA = "0x293F570", Offset = "0x293E970", Length = "0x69")]
		[Token(Token = "0x60004EE")]
		 add { } //Length: 105
		[Address(RVA = "0x2940600", Offset = "0x293FA00", Length = "0x69")]
		[Token(Token = "0x60004EF")]
		 remove { } //Length: 105
	}

	[Token(Token = "0x1400000A")]
	public static event Action onAfterUpdate
	{
		[Address(RVA = "0x293F5E0", Offset = "0x293E9E0", Length = "0x114")]
		[Token(Token = "0x60004E4")]
		 add { } //Length: 276
		[Address(RVA = "0x2940670", Offset = "0x293FA70", Length = "0x114")]
		[Token(Token = "0x60004E5")]
		 remove { } //Length: 276
	}

	[Token(Token = "0x14000009")]
	public static event Action onBeforeUpdate
	{
		[Address(RVA = "0x293F700", Offset = "0x293EB00", Length = "0x114")]
		[Token(Token = "0x60004E2")]
		 add { } //Length: 276
		[Address(RVA = "0x2940790", Offset = "0x293FB90", Length = "0x114")]
		[Token(Token = "0x60004E3")]
		 remove { } //Length: 276
	}

	[Token(Token = "0x14000006")]
	public static event Action<InputDevice, InputDeviceChange> onDeviceChange
	{
		[Address(RVA = "0x293F820", Offset = "0x293EC20", Length = "0x166")]
		[Token(Token = "0x60004AE")]
		 add { } //Length: 358
		[Address(RVA = "0x29408B0", Offset = "0x293FCB0", Length = "0x166")]
		[Token(Token = "0x60004AF")]
		 remove { } //Length: 358
	}

	[Token(Token = "0x14000007")]
	public static event InputDeviceCommandDelegate onDeviceCommand
	{
		[Address(RVA = "0x293F990", Offset = "0x293ED90", Length = "0x166")]
		[Token(Token = "0x60004B0")]
		 add { } //Length: 358
		[Address(RVA = "0x2940A20", Offset = "0x293FE20", Length = "0x166")]
		[Token(Token = "0x60004B1")]
		 remove { } //Length: 358
	}

	[Token(Token = "0x14000008")]
	public static event InputDeviceFindControlLayoutDelegate onFindLayoutForDevice
	{
		[Address(RVA = "0x293FB00", Offset = "0x293EF00", Length = "0x114")]
		[Token(Token = "0x60004B2")]
		 add { } //Length: 276
		[Address(RVA = "0x2940B90", Offset = "0x293FF90", Length = "0x114")]
		[Token(Token = "0x60004B3")]
		 remove { } //Length: 276
	}

	[Token(Token = "0x14000005")]
	public static event Action<String, InputControlLayoutChange> onLayoutChange
	{
		[Address(RVA = "0x293FC20", Offset = "0x293F020", Length = "0x114")]
		[Token(Token = "0x6000496")]
		 add { } //Length: 276
		[Address(RVA = "0x2940CB0", Offset = "0x29400B0", Length = "0x114")]
		[Token(Token = "0x6000497")]
		 remove { } //Length: 276
	}

	[Token(Token = "0x1400000B")]
	public static event Action onSettingsChange
	{
		[Address(RVA = "0x293FD40", Offset = "0x293F140", Length = "0x69")]
		[Token(Token = "0x60004E8")]
		 add { } //Length: 105
		[Address(RVA = "0x2940DD0", Offset = "0x29401D0", Length = "0x69")]
		[Token(Token = "0x60004E9")]
		 remove { } //Length: 105
	}

	[Token(Token = "0x1700016C")]
	public static InputActionAsset actions
	{
		[Address(RVA = "0x293FDB0", Offset = "0x293F1B0", Length = "0x60")]
		[Token(Token = "0x60004EC")]
		 get { } //Length: 96
		[Address(RVA = "0x2940E40", Offset = "0x2940240", Length = "0x152")]
		[Token(Token = "0x60004ED")]
		 set { } //Length: 338
	}

	[Token(Token = "0x17000165")]
	public static ReadOnlyArray<InputDevice> devices
	{
		[Address(RVA = "0x293FE10", Offset = "0x293F210", Length = "0x75")]
		[Token(Token = "0x60004AC")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000166")]
	public static ReadOnlyArray<InputDevice> disconnectedDevices
	{
		[Address(RVA = "0x293FE90", Offset = "0x293F290", Length = "0x9A")]
		[Token(Token = "0x60004AD")]
		 get { } //Length: 154
	}

	[Token(Token = "0x17000168")]
	internal static bool isProcessingEvents
	{
		[Address(RVA = "0x293FF30", Offset = "0x293F330", Length = "0x5F")]
		[Token(Token = "0x60004D6")]
		internal get { } //Length: 95
	}

	[Token(Token = "0x17000171")]
	public static InputMetrics metrics
	{
		[Address(RVA = "0x293FF90", Offset = "0x293F390", Length = "0x8F")]
		[Token(Token = "0x6000501")]
		 get { } //Length: 143
	}

	[Token(Token = "0x1700016A")]
	public static IObservable<InputControl> onAnyButtonPress
	{
		[Address(RVA = "0x2940020", Offset = "0x293F420", Length = "0x22F")]
		[Token(Token = "0x60004D9")]
		 get { } //Length: 559
	}

	[Token(Token = "0x17000169")]
	public static InputEventListener onEvent
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60004D7")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60004D8")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000167")]
	public static float pollingFrequency
	{
		[Address(RVA = "0x2940250", Offset = "0x293F650", Length = "0x5F")]
		[Token(Token = "0x60004B4")]
		 get { } //Length: 95
		[Address(RVA = "0x2940FA0", Offset = "0x29403A0", Length = "0x70")]
		[Token(Token = "0x60004B5")]
		 set { } //Length: 112
	}

	[Token(Token = "0x1700016D")]
	public static InputRemoting remoting
	{
		[Address(RVA = "0x29402B0", Offset = "0x293F6B0", Length = "0x4F")]
		[Token(Token = "0x60004FC")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700016F")]
	public static bool runInBackground
	{
		[Address(RVA = "0x2940300", Offset = "0x293F700", Length = "0x81")]
		[Token(Token = "0x60004FE")]
		 get { } //Length: 129
		[Address(RVA = "0x2941020", Offset = "0x2940420", Length = "0x104")]
		[Token(Token = "0x60004FF")]
		 set { } //Length: 260
	}

	[Token(Token = "0x17000170")]
	internal static float scrollWheelDeltaPerTick
	{
		[Address(RVA = "0x2940390", Offset = "0x293F790", Length = "0xDB")]
		[Token(Token = "0x6000500")]
		internal get { } //Length: 219
	}

	[Token(Token = "0x1700016B")]
	public static InputSettings settings
	{
		[Address(RVA = "0x2940470", Offset = "0x293F870", Length = "0x60")]
		[Token(Token = "0x60004E6")]
		 get { } //Length: 96
		[Address(RVA = "0x2941130", Offset = "0x2940530", Length = "0x159")]
		[Token(Token = "0x60004E7")]
		 set { } //Length: 345
	}

	[Token(Token = "0x1700016E")]
	public static Version version
	{
		[Address(RVA = "0x29404E0", Offset = "0x293F8E0", Length = "0x58")]
		[Token(Token = "0x60004FD")]
		 get { } //Length: 88
	}

	[Address(RVA = "0x293F440", Offset = "0x293E840", Length = "0x69")]
	[Token(Token = "0x6000502")]
	private static InputSystem() { }

	[Address(RVA = "0x293F4B0", Offset = "0x293E8B0", Length = "0xB9")]
	[Token(Token = "0x60004F0")]
	public static void add_onActionChange(Action<Object, InputActionChange> value) { }

	[Address(RVA = "0x293F570", Offset = "0x293E970", Length = "0x69")]
	[Token(Token = "0x60004EE")]
	public static void add_onActionsChange(Action value) { }

	[Address(RVA = "0x293F5E0", Offset = "0x293E9E0", Length = "0x114")]
	[Token(Token = "0x60004E4")]
	public static void add_onAfterUpdate(Action value) { }

	[Address(RVA = "0x293F700", Offset = "0x293EB00", Length = "0x114")]
	[Token(Token = "0x60004E2")]
	public static void add_onBeforeUpdate(Action value) { }

	[Address(RVA = "0x293F820", Offset = "0x293EC20", Length = "0x166")]
	[Token(Token = "0x60004AE")]
	public static void add_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	[Address(RVA = "0x293F990", Offset = "0x293ED90", Length = "0x166")]
	[Token(Token = "0x60004B0")]
	public static void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	[Address(RVA = "0x293FB00", Offset = "0x293EF00", Length = "0x114")]
	[Token(Token = "0x60004B2")]
	public static void add_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	[Address(RVA = "0x293FC20", Offset = "0x293F020", Length = "0x114")]
	[Token(Token = "0x6000496")]
	public static void add_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	[Address(RVA = "0x293FD40", Offset = "0x293F140", Length = "0x69")]
	[Token(Token = "0x60004E8")]
	public static void add_onSettingsChange(Action value) { }

	[Address(RVA = "0x293BB50", Offset = "0x293AF50", Length = "0xB7")]
	[Token(Token = "0x60004B9")]
	public static void AddDevice(InputDevice device) { }

	[Address(RVA = "0x293BD40", Offset = "0x293B140", Length = "0x107")]
	[Token(Token = "0x60004B8")]
	public static InputDevice AddDevice(InputDeviceDescription description) { }

	[Address(RVA = "0x84A3C0", Offset = "0x8497C0", Length = "0x1AE")]
	[Token(Token = "0x60004B7")]
	public static TDevice AddDevice(string name = null) { }

	[Address(RVA = "0x293BC10", Offset = "0x293B010", Length = "0x120")]
	[Token(Token = "0x60004B6")]
	public static InputDevice AddDevice(string layout, string name = null, string variants = null) { }

	[Address(RVA = "0x293BA10", Offset = "0x293AE10", Length = "0x83")]
	[Token(Token = "0x60004CF")]
	public static void AddDeviceUsage(InputDevice device, InternedString usage) { }

	[Address(RVA = "0x293BAA0", Offset = "0x293AEA0", Length = "0xAB")]
	[Token(Token = "0x60004CE")]
	public static void AddDeviceUsage(InputDevice device, string usage) { }

	[Address(RVA = "0x293BE50", Offset = "0x293B250", Length = "0xED")]
	[Token(Token = "0x60004EB")]
	private static void DisableActions(bool triggerSetupChanged = false) { }

	[Address(RVA = "0x293BF40", Offset = "0x293B340", Length = "0x40")]
	[Token(Token = "0x60004F9")]
	public static void DisableAllEnabledActions() { }

	[Address(RVA = "0x293BF80", Offset = "0x293B380", Length = "0x82")]
	[Token(Token = "0x60004C5")]
	public static void DisableDevice(InputDevice device, bool keepSendingEvents = false) { }

	[Address(RVA = "0x293C010", Offset = "0x293B410", Length = "0xF3")]
	[Token(Token = "0x60004EA")]
	private static void EnableActions() { }

	[Address(RVA = "0x293C110", Offset = "0x293B510", Length = "0x76")]
	[Token(Token = "0x60004C4")]
	public static void EnableDevice(InputDevice device) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000504")]
	internal static void EnsureInitialized() { }

	[Address(RVA = "0x293C190", Offset = "0x293B590", Length = "0x179")]
	[Token(Token = "0x60004D2")]
	public static InputControl FindControl(string path) { }

	[Address(RVA = "0x293C310", Offset = "0x293B710", Length = "0x80")]
	[Token(Token = "0x60004D3")]
	public static InputControlList<InputControl> FindControls(string path) { }

	[Address(RVA = "0x84A6C0", Offset = "0x849AC0", Length = "0x17A")]
	[Token(Token = "0x60004D4")]
	public static InputControlList<TControl> FindControls(string path) { }

	[Address(RVA = "0x84A570", Offset = "0x849970", Length = "0x141")]
	[Token(Token = "0x60004D5")]
	public static int FindControls(string path, ref InputControlList<TControl>& controls) { }

	[Address(RVA = "0x293C390", Offset = "0x293B790", Length = "0x5F")]
	[Token(Token = "0x60004BB")]
	public static void FlushDisconnectedDevices() { }

	[Address(RVA = "0x293FDB0", Offset = "0x293F1B0", Length = "0x60")]
	[Token(Token = "0x60004EC")]
	public static InputActionAsset get_actions() { }

	[Address(RVA = "0x293FE10", Offset = "0x293F210", Length = "0x75")]
	[Token(Token = "0x60004AC")]
	public static ReadOnlyArray<InputDevice> get_devices() { }

	[Address(RVA = "0x293FE90", Offset = "0x293F290", Length = "0x9A")]
	[Token(Token = "0x60004AD")]
	public static ReadOnlyArray<InputDevice> get_disconnectedDevices() { }

	[Address(RVA = "0x293FF30", Offset = "0x293F330", Length = "0x5F")]
	[Token(Token = "0x60004D6")]
	internal static bool get_isProcessingEvents() { }

	[Address(RVA = "0x293FF90", Offset = "0x293F390", Length = "0x8F")]
	[Token(Token = "0x6000501")]
	public static InputMetrics get_metrics() { }

	[Address(RVA = "0x2940020", Offset = "0x293F420", Length = "0x22F")]
	[Token(Token = "0x60004D9")]
	public static IObservable<InputControl> get_onAnyButtonPress() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60004D7")]
	public static InputEventListener get_onEvent() { }

	[Address(RVA = "0x2940250", Offset = "0x293F650", Length = "0x5F")]
	[Token(Token = "0x60004B4")]
	public static float get_pollingFrequency() { }

	[Address(RVA = "0x29402B0", Offset = "0x293F6B0", Length = "0x4F")]
	[Token(Token = "0x60004FC")]
	public static InputRemoting get_remoting() { }

	[Address(RVA = "0x2940300", Offset = "0x293F700", Length = "0x81")]
	[Token(Token = "0x60004FE")]
	public static bool get_runInBackground() { }

	[Address(RVA = "0x2940390", Offset = "0x293F790", Length = "0xDB")]
	[Token(Token = "0x6000500")]
	internal static float get_scrollWheelDeltaPerTick() { }

	[Address(RVA = "0x2940470", Offset = "0x293F870", Length = "0x60")]
	[Token(Token = "0x60004E6")]
	public static InputSettings get_settings() { }

	[Address(RVA = "0x29404E0", Offset = "0x293F8E0", Length = "0x58")]
	[Token(Token = "0x60004FD")]
	public static Version get_version() { }

	[Address(RVA = "0x293C6C0", Offset = "0x293BAC0", Length = "0x69")]
	[Token(Token = "0x60004BC")]
	public static InputDevice GetDevice(string nameOrLayout) { }

	[Address(RVA = "0x84AA80", Offset = "0x849E80", Length = "0xCD")]
	[Token(Token = "0x60004BD")]
	public static TDevice GetDevice() { }

	[Address(RVA = "0x293C460", Offset = "0x293B860", Length = "0x258")]
	[Token(Token = "0x60004BE")]
	public static InputDevice GetDevice(Type type) { }

	[Address(RVA = "0x84A840", Offset = "0x849C40", Length = "0x236")]
	[Token(Token = "0x60004BF")]
	public static TDevice GetDevice(InternedString usage) { }

	[Address(RVA = "0x84AB50", Offset = "0x849F50", Length = "0x86")]
	[Token(Token = "0x60004C0")]
	public static TDevice GetDevice(string usage) { }

	[Address(RVA = "0x293C3F0", Offset = "0x293B7F0", Length = "0x67")]
	[Token(Token = "0x60004C1")]
	public static InputDevice GetDeviceById(int deviceId) { }

	[Address(RVA = "0x293C730", Offset = "0x293BB30", Length = "0x12E")]
	[Token(Token = "0x60004A6")]
	public static string GetNameOfBaseLayout(string layoutName) { }

	[Address(RVA = "0x293C860", Offset = "0x293BC60", Length = "0xCE")]
	[Token(Token = "0x60004C2")]
	public static List<InputDeviceDescription> GetUnsupportedDevices() { }

	[Address(RVA = "0x293C930", Offset = "0x293BD30", Length = "0x69")]
	[Token(Token = "0x60004C3")]
	public static int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) { }

	[Address(RVA = "0x293C9A0", Offset = "0x293BDA0", Length = "0x2B5")]
	[Token(Token = "0x6000505")]
	private static void InitializeInPlayer(IInputRuntime runtime = null, InputSettings settings = null) { }

	[Address(RVA = "0x293CC60", Offset = "0x293C060", Length = "0x1A4")]
	[Token(Token = "0x60004A7")]
	public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName) { }

	[Address(RVA = "0x293CE10", Offset = "0x293C210", Length = "0x96")]
	[Token(Token = "0x60004FB")]
	public static int ListEnabledActions(List<InputAction> actions) { }

	[Address(RVA = "0x293CEB0", Offset = "0x293C2B0", Length = "0xFE")]
	[Token(Token = "0x60004FA")]
	public static List<InputAction> ListEnabledActions() { }

	[Address(RVA = "0x293CFB0", Offset = "0x293C3B0", Length = "0x76")]
	[Token(Token = "0x60004F5")]
	public static IEnumerable<String> ListInteractions() { }

	[Address(RVA = "0x293D100", Offset = "0x293C500", Length = "0x62")]
	[Token(Token = "0x60004A2")]
	public static IEnumerable<String> ListLayouts() { }

	[Address(RVA = "0x293D030", Offset = "0x293C430", Length = "0xC0")]
	[Token(Token = "0x60004A3")]
	public static IEnumerable<String> ListLayoutsBasedOn(string baseLayout) { }

	[Address(RVA = "0x293D170", Offset = "0x293C570", Length = "0x76")]
	[Token(Token = "0x60004AB")]
	public static IEnumerable<String> ListProcessors() { }

	[Address(RVA = "0x293D1F0", Offset = "0x293C5F0", Length = "0xF3")]
	[Token(Token = "0x60004A4")]
	public static InputControlLayout LoadLayout(string name) { }

	[Address(RVA = "0x84ABE0", Offset = "0x849FE0", Length = "0xA1")]
	[Token(Token = "0x60004A5")]
	public static InputControlLayout LoadLayout() { }

	[Address(RVA = "0x293D2F0", Offset = "0x293C6F0", Length = "0x132")]
	[Token(Token = "0x60004C9")]
	public static void PauseHaptics() { }

	[Address(RVA = "0x293D430", Offset = "0x293C830", Length = "0x32")]
	[Token(Token = "0x6000507")]
	private static void PerformDefaultPluginInitialization() { }

	[Address(RVA = "0x293D470", Offset = "0x293C870", Length = "0x1B6")]
	[Token(Token = "0x60004DE")]
	public static void QueueConfigChangeEvent(InputDevice device, double time = -1) { }

	[Address(RVA = "0x84AC90", Offset = "0x84A090", Length = "0x5FD")]
	[Token(Token = "0x60004DD")]
	public static void QueueDeltaStateEvent(InputControl control, TDelta delta, double time = -1) { }

	[Address(RVA = "0x293D630", Offset = "0x293CA30", Length = "0xED")]
	[Token(Token = "0x60004DA")]
	public static void QueueEvent(InputEventPtr eventPtr) { }

	[Address(RVA = "0x84B290", Offset = "0x84A690", Length = "0x81")]
	[Token(Token = "0x60004DB")]
	public static void QueueEvent(ref TEvent inputEvent) { }

	[Address(RVA = "0x84B700", Offset = "0x84AB00", Length = "0x252")]
	[Token(Token = "0x60004DC")]
	public static void QueueStateEvent(InputDevice device, TState state, double time = -1) { }

	[Address(RVA = "0x293D720", Offset = "0x293CB20", Length = "0x1D4")]
	[Token(Token = "0x60004DF")]
	public static void QueueTextEvent(InputDevice device, char character, double time = -1) { }

	[Address(RVA = "0x84B960", Offset = "0x84AD60", Length = "0x88")]
	[Token(Token = "0x60004F7")]
	public static void RegisterBindingComposite(string name = null) { }

	[Address(RVA = "0x293D900", Offset = "0x293CD00", Length = "0x188")]
	[Token(Token = "0x60004F6")]
	public static void RegisterBindingComposite(Type type, string name) { }

	[Address(RVA = "0x293DA90", Offset = "0x293CE90", Length = "0x185")]
	[Token(Token = "0x60004F2")]
	public static void RegisterInteraction(Type type, string name = null) { }

	[Address(RVA = "0x84B9F0", Offset = "0x84ADF0", Length = "0x88")]
	[Token(Token = "0x60004F3")]
	public static void RegisterInteraction(string name = null) { }

	[Address(RVA = "0x293E090", Offset = "0x293D490", Length = "0xFB")]
	[Token(Token = "0x600049A")]
	public static void RegisterLayout(string json, string name = null, Nullable<InputDeviceMatcher> matches = null) { }

	[Address(RVA = "0x293DEF0", Offset = "0x293D2F0", Length = "0x199")]
	[Token(Token = "0x6000498")]
	public static void RegisterLayout(Type type, string name = null, Nullable<InputDeviceMatcher> matches = null) { }

	[Address(RVA = "0x84BB40", Offset = "0x84AF40", Length = "0xA3")]
	[Token(Token = "0x6000499")]
	public static void RegisterLayout(string name = null, Nullable<InputDeviceMatcher> matches = null) { }

	[Address(RVA = "0x293DC20", Offset = "0x293D020", Length = "0x1B9")]
	[Token(Token = "0x600049E")]
	public static void RegisterLayoutBuilder(Func<InputControlLayout> buildMethod, string name, string baseLayout = null, Nullable<InputDeviceMatcher> matches = null) { }

	[Address(RVA = "0x293DDE0", Offset = "0x293D1E0", Length = "0x78")]
	[Token(Token = "0x600049C")]
	public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	[Address(RVA = "0x84BA80", Offset = "0x84AE80", Length = "0xB1")]
	[Token(Token = "0x600049D")]
	public static void RegisterLayoutMatcher(InputDeviceMatcher matcher) { }

	[Address(RVA = "0x293DE60", Offset = "0x293D260", Length = "0x82")]
	[Token(Token = "0x600049B")]
	public static void RegisterLayoutOverride(string json, string name = null) { }

	[Address(RVA = "0x84BBF0", Offset = "0x84AFF0", Length = "0x7F")]
	[Token(Token = "0x600049F")]
	public static void RegisterPrecompiledLayout(string metadata) { }

	[Address(RVA = "0x84BC70", Offset = "0x84B070", Length = "0x88")]
	[Token(Token = "0x60004A9")]
	public static void RegisterProcessor(string name = null) { }

	[Address(RVA = "0x293E190", Offset = "0x293D590", Length = "0x41F")]
	[Token(Token = "0x60004A8")]
	public static void RegisterProcessor(Type type, string name = null) { }

	[Address(RVA = "0x2940540", Offset = "0x293F940", Length = "0xB9")]
	[Token(Token = "0x60004F1")]
	public static void remove_onActionChange(Action<Object, InputActionChange> value) { }

	[Address(RVA = "0x2940600", Offset = "0x293FA00", Length = "0x69")]
	[Token(Token = "0x60004EF")]
	public static void remove_onActionsChange(Action value) { }

	[Address(RVA = "0x2940670", Offset = "0x293FA70", Length = "0x114")]
	[Token(Token = "0x60004E5")]
	public static void remove_onAfterUpdate(Action value) { }

	[Address(RVA = "0x2940790", Offset = "0x293FB90", Length = "0x114")]
	[Token(Token = "0x60004E3")]
	public static void remove_onBeforeUpdate(Action value) { }

	[Address(RVA = "0x29408B0", Offset = "0x293FCB0", Length = "0x166")]
	[Token(Token = "0x60004AF")]
	public static void remove_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	[Address(RVA = "0x2940A20", Offset = "0x293FE20", Length = "0x166")]
	[Token(Token = "0x60004B1")]
	public static void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	[Address(RVA = "0x2940B90", Offset = "0x293FF90", Length = "0x114")]
	[Token(Token = "0x60004B3")]
	public static void remove_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	[Address(RVA = "0x2940CB0", Offset = "0x29400B0", Length = "0x114")]
	[Token(Token = "0x6000497")]
	public static void remove_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	[Address(RVA = "0x2940DD0", Offset = "0x29401D0", Length = "0x69")]
	[Token(Token = "0x60004E9")]
	public static void remove_onSettingsChange(Action value) { }

	[Address(RVA = "0x293E6F0", Offset = "0x293DAF0", Length = "0x6C")]
	[Token(Token = "0x60004BA")]
	public static void RemoveDevice(InputDevice device) { }

	[Address(RVA = "0x293E640", Offset = "0x293DA40", Length = "0xAB")]
	[Token(Token = "0x60004D0")]
	public static void RemoveDeviceUsage(InputDevice device, string usage) { }

	[Address(RVA = "0x293E5B0", Offset = "0x293D9B0", Length = "0x83")]
	[Token(Token = "0x60004D1")]
	public static void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	[Address(RVA = "0x293E760", Offset = "0x293DB60", Length = "0x69")]
	[Token(Token = "0x60004A0")]
	public static void RemoveLayout(string name) { }

	[Address(RVA = "0x293E7D0", Offset = "0x293DBD0", Length = "0x7F")]
	[Token(Token = "0x60004C7")]
	public static void ResetDevice(InputDevice device, bool alsoResetDontResetControls = false) { }

	[Address(RVA = "0x293E850", Offset = "0x293DC50", Length = "0x135")]
	[Token(Token = "0x60004CB")]
	public static void ResetHaptics() { }

	[Address(RVA = "0x293E990", Offset = "0x293DD90", Length = "0x135")]
	[Token(Token = "0x60004CA")]
	public static void ResumeHaptics() { }

	[Address(RVA = "0x293EB70", Offset = "0x293DF70", Length = "0x6D")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	[Token(Token = "0x6000503")]
	private static void RunInitializeInPlayer() { }

	[Address(RVA = "0x293EAD0", Offset = "0x293DED0", Length = "0x90")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x6000506")]
	private static void RunInitialUpdate() { }

	[Address(RVA = "0x2940E40", Offset = "0x2940240", Length = "0x152")]
	[Token(Token = "0x60004ED")]
	public static void set_actions(InputActionAsset value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004D8")]
	public static void set_onEvent(InputEventListener value) { }

	[Address(RVA = "0x2940FA0", Offset = "0x29403A0", Length = "0x70")]
	[Token(Token = "0x60004B5")]
	public static void set_pollingFrequency(float value) { }

	[Address(RVA = "0x2941020", Offset = "0x2940420", Length = "0x104")]
	[Token(Token = "0x60004FF")]
	public static void set_runInBackground(bool value) { }

	[Address(RVA = "0x2941130", Offset = "0x2940530", Length = "0x159")]
	[Token(Token = "0x60004E7")]
	public static void set_settings(InputSettings value) { }

	[Address(RVA = "0x293ECC0", Offset = "0x293E0C0", Length = "0x83")]
	[Token(Token = "0x60004CD")]
	public static void SetDeviceUsage(InputDevice device, InternedString usage) { }

	[Address(RVA = "0x293EBE0", Offset = "0x293DFE0", Length = "0xD6")]
	[Token(Token = "0x60004CC")]
	public static void SetDeviceUsage(InputDevice device, string usage) { }

	[Address(RVA = "0x293ED50", Offset = "0x293E150", Length = "0x8C")]
	[Token(Token = "0x60004A1")]
	public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	[Address(RVA = "0x293EDE0", Offset = "0x293E1E0", Length = "0xDA")]
	[Token(Token = "0x60004F8")]
	public static Type TryGetBindingComposite(string name) { }

	[Address(RVA = "0x293EEC0", Offset = "0x293E2C0", Length = "0xD7")]
	[Token(Token = "0x60004F4")]
	public static Type TryGetInteraction(string name) { }

	[Address(RVA = "0x293EFA0", Offset = "0x293E3A0", Length = "0xD7")]
	[Token(Token = "0x60004AA")]
	public static Type TryGetProcessor(string name) { }

	[Address(RVA = "0x293F080", Offset = "0x293E480", Length = "0xBD")]
	[Obsolete("Use 'ResetDevice' instead.", False)]
	[Token(Token = "0x60004C8")]
	public static bool TryResetDevice(InputDevice device) { }

	[Address(RVA = "0x293F140", Offset = "0x293E540", Length = "0x12E")]
	[Token(Token = "0x60004C6")]
	public static bool TrySyncDevice(InputDevice device) { }

	[Address(RVA = "0x293F3E0", Offset = "0x293E7E0", Length = "0x5F")]
	[Token(Token = "0x60004E0")]
	public static void Update() { }

	[Address(RVA = "0x293F270", Offset = "0x293E670", Length = "0x16C")]
	[Token(Token = "0x60004E1")]
	internal static void Update(InputUpdateType updateType) { }

}

