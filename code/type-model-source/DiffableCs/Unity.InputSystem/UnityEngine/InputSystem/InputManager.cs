namespace UnityEngine.InputSystem;

[Token(Token = "0x20000C2")]
internal class InputManager
{
	[CompilerGenerated]
	[Token(Token = "0x20000C8")]
	private sealed class <>c
	{
		[Token(Token = "0x40004C2")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40004C3")]
		public static Func<InputDevice, String> <>9__191_0; //Field offset: 0x8

		[Address(RVA = "0x29CE450", Offset = "0x29CD850", Length = "0x67")]
		[Token(Token = "0x6000AF5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000AF6")]
		public <>c() { }

		[Address(RVA = "0x29CE400", Offset = "0x29CD800", Length = "0x24")]
		[Token(Token = "0x6000AF7")]
		internal string <MakeDeviceNameUnique>b__191_0(InputDevice x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C9")]
	private sealed class <>c__85
	{
		[Token(Token = "0x40004C4")]
		public static readonly <>c__85<TDevice> <>9; //Field offset: 0x0
		[Token(Token = "0x40004C5")]
		public static Func<InputDevice> <>9__85_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000AF8")]
		private static <>c__85`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000AF9")]
		public <>c__85`1() { }

		[Address(RVA = "0xA347A0", Offset = "0xA33BA0", Length = "0x14")]
		[Token(Token = "0x6000AFA")]
		internal InputDevice <RegisterPrecompiledLayout>b__85_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CA")]
	private sealed class <ListControlLayouts>d__100 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004C6")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004C7")]
		private string <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004C8")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004C9")]
		private string basedOn; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004CA")]
		public string <>3__basedOn; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40004CB")]
		public InputManager <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40004CC")]
		private InternedString <internedBasedOn>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40004CD")]
		private Enumerator<InternedString, Type> <>7__wrap2; //Field offset: 0x50
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40004CE")]
		private Enumerator<InternedString, String> <>7__wrap3; //Field offset: 0x80
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40004CF")]
		private Enumerator<InternedString, Func<InputControlLayout>> <>7__wrap4; //Field offset: 0xB0

		[Token(Token = "0x170002C3")]
		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000B04")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170002C4")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000B06")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000AFB")]
		public <ListControlLayouts>d__100(int <>1__state) { }

		[Address(RVA = "0x29CE220", Offset = "0x29CD620", Length = "0x41")]
		[Token(Token = "0x6000AFE")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x29CE270", Offset = "0x29CD670", Length = "0x44")]
		[Token(Token = "0x6000AFF")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x29CE2C0", Offset = "0x29CD6C0", Length = "0x44")]
		[Token(Token = "0x6000B00")]
		private void <>m__Finally3() { }

		[Address(RVA = "0x29CE310", Offset = "0x29CD710", Length = "0x41")]
		[Token(Token = "0x6000B01")]
		private void <>m__Finally4() { }

		[Address(RVA = "0x29CE360", Offset = "0x29CD760", Length = "0x44")]
		[Token(Token = "0x6000B02")]
		private void <>m__Finally5() { }

		[Address(RVA = "0x29CE3B0", Offset = "0x29CD7B0", Length = "0x44")]
		[Token(Token = "0x6000B03")]
		private void <>m__Finally6() { }

		[Address(RVA = "0x29CD410", Offset = "0x29CC810", Length = "0x9F0")]
		[Token(Token = "0x6000AFD")]
		private override bool MoveNext() { }

		[Address(RVA = "0x29CDE20", Offset = "0x29CD220", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x6000B07")]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000B04")]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[Address(RVA = "0x29CDE20", Offset = "0x29CD220", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x6000B08")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000B06")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x29CDED0", Offset = "0x29CD2D0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000B05")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x29CDF10", Offset = "0x29CD310", Length = "0x2D0")]
		[DebuggerHidden]
		[Token(Token = "0x6000AFC")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20000C4")]
	public struct AvailableDevice
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B0")]
		public InputDeviceDescription description; //Field offset: 0x0
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40004B1")]
		public int deviceId; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40004B2")]
		public bool isNative; //Field offset: 0x3C
		[FieldOffset(Offset = "0x3D")]
		[Token(Token = "0x40004B3")]
		public bool isRemoved; //Field offset: 0x3D

	}

	[Token(Token = "0x20000C3")]
	public enum DeviceDisableScope : int
	{
		Everywhere = 0,
		InFrontendOnly = 1,
		TemporaryWhilePlayerIsInBackground = 2,
	}

	[Token(Token = "0x20000C6")]
	public struct StateChangeMonitorListener
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B9")]
		public InputControl control; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004BA")]
		public IInputStateChangeMonitor monitor; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004BB")]
		public long monitorIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004BC")]
		public uint groupIndex; //Field offset: 0x18

	}

	[Token(Token = "0x20000C7")]
	public struct StateChangeMonitorsForDevice
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BD")]
		public BitRegion[] memoryRegions; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004BE")]
		public StateChangeMonitorListener[] listeners; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004BF")]
		public DynamicBitfield signalled; //Field offset: 0x10
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004C0")]
		public bool needToUpdateOrderingOfMonitors; //Field offset: 0x30
		[FieldOffset(Offset = "0x31")]
		[Token(Token = "0x40004C1")]
		public bool needToCompactArrays; //Field offset: 0x31

		[Token(Token = "0x170002C2")]
		public int count
		{
			[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
			[Token(Token = "0x6000AEE")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x29CB370", Offset = "0x29CA770", Length = "0x1CC")]
		[Token(Token = "0x6000AEF")]
		public void Add(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex) { }

		[Address(RVA = "0x29CB540", Offset = "0x29CA940", Length = "0x86")]
		[Token(Token = "0x6000AF1")]
		public void Clear() { }

		[Address(RVA = "0x29CB5D0", Offset = "0x29CA9D0", Length = "0x73")]
		[Token(Token = "0x6000AF2")]
		public void CompactArrays() { }

		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000AEE")]
		public int get_count() { }

		[Address(RVA = "0x29CB720", Offset = "0x29CAB20", Length = "0xDE")]
		[Token(Token = "0x6000AF0")]
		public void Remove(IInputStateChangeMonitor monitor, long monitorIndex, bool deferRemoval) { }

		[Address(RVA = "0x29CB650", Offset = "0x29CAA50", Length = "0xC5")]
		[Token(Token = "0x6000AF3")]
		private void RemoveAt(int i) { }

		[Address(RVA = "0x29CB800", Offset = "0x29CAC00", Length = "0x15A")]
		[Token(Token = "0x6000AF4")]
		public void SortMonitorsByIndex() { }

	}

	[Token(Token = "0x20000C5")]
	private struct StateChangeMonitorTimeout
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B4")]
		public InputControl control; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004B5")]
		public double time; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004B6")]
		public IInputStateChangeMonitor monitor; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004B7")]
		public long monitorIndex; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004B8")]
		public int timerIndex; //Field offset: 0x20

	}

	[Token(Token = "0x4000471")]
	private static readonly ProfilerMarker k_InputUpdateProfilerMarker; //Field offset: 0x0
	[Token(Token = "0x4000472")]
	private static readonly ProfilerMarker k_InputTryFindMatchingControllerMarker; //Field offset: 0x8
	[Token(Token = "0x4000473")]
	private static readonly ProfilerMarker k_InputAddDeviceMarker; //Field offset: 0x10
	[Token(Token = "0x4000474")]
	private static readonly ProfilerMarker k_InputRestoreDevicesAfterReloadMarker; //Field offset: 0x18
	[Token(Token = "0x4000475")]
	private static readonly ProfilerMarker k_InputRegisterCustomTypesMarker; //Field offset: 0x20
	[Token(Token = "0x4000476")]
	private static readonly ProfilerMarker k_InputOnBeforeUpdateMarker; //Field offset: 0x28
	[Token(Token = "0x4000477")]
	private static readonly ProfilerMarker k_InputOnAfterUpdateMarker; //Field offset: 0x30
	[Token(Token = "0x4000478")]
	private static readonly ProfilerMarker k_InputOnSettingsChangeMarker; //Field offset: 0x38
	[Token(Token = "0x4000479")]
	private static readonly ProfilerMarker k_InputOnDeviceSettingsChangeMarker; //Field offset: 0x40
	[Token(Token = "0x400047A")]
	private static readonly ProfilerMarker k_InputOnEventMarker; //Field offset: 0x48
	[Token(Token = "0x400047B")]
	private static readonly ProfilerMarker k_InputOnLayoutChangeMarker; //Field offset: 0x50
	[Token(Token = "0x400047C")]
	private static readonly ProfilerMarker k_InputOnDeviceChangeMarker; //Field offset: 0x58
	[Token(Token = "0x400047D")]
	private static readonly ProfilerMarker k_InputOnActionsChangeMarker; //Field offset: 0x60
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400047E")]
	private bool m_CustomTypesRegistered; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400047F")]
	internal int m_LayoutRegistrationVersion; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000480")]
	private InputEventHandledPolicy m_InputEventHandledPolicy; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000481")]
	internal Collection m_Layouts; //Field offset: 0x20
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000482")]
	private TypeTable m_Processors; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000483")]
	private TypeTable m_Interactions; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000484")]
	private TypeTable m_Composites; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000485")]
	private int m_DevicesCount; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000486")]
	private InputDevice[] m_Devices; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000487")]
	private Dictionary<Int32, InputDevice> m_DevicesById; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000488")]
	internal int m_AvailableDeviceCount; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000489")]
	internal AvailableDevice[] m_AvailableDevices; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400048A")]
	internal int m_DisconnectedDevicesCount; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400048B")]
	internal InputDevice[] m_DisconnectedDevices; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400048C")]
	internal InputUpdateType m_UpdateMask; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x400048D")]
	private InputUpdateType m_CurrentUpdate; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400048E")]
	internal InputStateBuffers m_StateBuffers; //Field offset: 0xD0
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400048F")]
	private ScrollDeltaBehavior m_ScrollDeltaBehavior; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000490")]
	private CallbackArray<Action`2<InputDevice, InputDeviceChange>> m_DeviceChangeListeners; //Field offset: 0x110
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000491")]
	private CallbackArray<Action`2<InputDevice, InputEventPtr>> m_DeviceStateChangeListeners; //Field offset: 0x160
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000492")]
	private CallbackArray<InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000493")]
	internal CallbackArray<InputDeviceCommandDelegate> m_DeviceCommandCallbacks; //Field offset: 0x200
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000494")]
	private CallbackArray<Action`2<String, InputControlLayoutChange>> m_LayoutChangeListeners; //Field offset: 0x250
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000495")]
	private CallbackArray<Action`2<InputEventPtr, InputDevice>> m_EventListeners; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000496")]
	private CallbackArray<Action> m_BeforeUpdateListeners; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x4000497")]
	private CallbackArray<Action> m_AfterUpdateListeners; //Field offset: 0x340
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x4000498")]
	private CallbackArray<Action> m_SettingsChangedListeners; //Field offset: 0x390
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x4000499")]
	private CallbackArray<Action> m_ActionsChangedListeners; //Field offset: 0x3E0
	[FieldOffset(Offset = "0x430")]
	[Token(Token = "0x400049A")]
	private bool m_NativeBeforeUpdateHooked; //Field offset: 0x430
	[FieldOffset(Offset = "0x431")]
	[Token(Token = "0x400049B")]
	private bool m_HaveDevicesWithStateCallbackReceivers; //Field offset: 0x431
	[FieldOffset(Offset = "0x432")]
	[Token(Token = "0x400049C")]
	private bool m_HasFocus; //Field offset: 0x432
	[FieldOffset(Offset = "0x433")]
	[Token(Token = "0x400049D")]
	private bool m_DiscardOutOfFocusEvents; //Field offset: 0x433
	[FieldOffset(Offset = "0x438")]
	[Token(Token = "0x400049E")]
	private double m_FocusRegainedTime; //Field offset: 0x438
	[FieldOffset(Offset = "0x440")]
	[Token(Token = "0x400049F")]
	private InputEventStream m_InputEventStream; //Field offset: 0x440
	[FieldOffset(Offset = "0x4B8")]
	[Token(Token = "0x40004A0")]
	private InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate; //Field offset: 0x4B8
	[FieldOffset(Offset = "0x4C0")]
	[Token(Token = "0x40004A1")]
	private int m_DeviceFindExecuteCommandDeviceId; //Field offset: 0x4C0
	[FieldOffset(Offset = "0x4C8")]
	[Token(Token = "0x40004A2")]
	internal IInputRuntime m_Runtime; //Field offset: 0x4C8
	[FieldOffset(Offset = "0x4D0")]
	[Token(Token = "0x40004A3")]
	internal InputMetrics m_Metrics; //Field offset: 0x4D0
	[FieldOffset(Offset = "0x508")]
	[Token(Token = "0x40004A4")]
	internal InputSettings m_Settings; //Field offset: 0x508
	[FieldOffset(Offset = "0x510")]
	[Token(Token = "0x40004A5")]
	private bool m_OptimizedControlsFeatureEnabled; //Field offset: 0x510
	[FieldOffset(Offset = "0x511")]
	[Token(Token = "0x40004A6")]
	private bool m_ReadValueCachingFeatureEnabled; //Field offset: 0x511
	[FieldOffset(Offset = "0x512")]
	[Token(Token = "0x40004A7")]
	private bool m_ParanoidReadValueCachingChecksEnabled; //Field offset: 0x512
	[FieldOffset(Offset = "0x518")]
	[Token(Token = "0x40004A8")]
	private InputActionAsset m_Actions; //Field offset: 0x518
	[FieldOffset(Offset = "0x520")]
	[Token(Token = "0x40004A9")]
	private bool m_ShouldMakeCurrentlyUpdatingDeviceCurrent; //Field offset: 0x520
	[FieldOffset(Offset = "0x528")]
	[Token(Token = "0x40004AA")]
	internal StateChangeMonitorsForDevice[] m_StateChangeMonitors; //Field offset: 0x528
	[FieldOffset(Offset = "0x530")]
	[Token(Token = "0x40004AB")]
	private InlinedArray<StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts; //Field offset: 0x530

	[Token(Token = "0x14000019")]
	public event Action onActionsChange
	{
		[Address(RVA = "0x29A8C20", Offset = "0x29A8020", Length = "0x4C")]
		[Token(Token = "0x6000A7B")]
		 add { } //Length: 76
		[Address(RVA = "0x29A9360", Offset = "0x29A8760", Length = "0x4C")]
		[Token(Token = "0x6000A7C")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x14000017")]
	public event Action onAfterUpdate
	{
		[Address(RVA = "0x29A8C70", Offset = "0x29A8070", Length = "0x4C")]
		[Token(Token = "0x6000A77")]
		 add { } //Length: 76
		[Address(RVA = "0x29A93B0", Offset = "0x29A87B0", Length = "0x4C")]
		[Token(Token = "0x6000A78")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x14000016")]
	public event Action onBeforeUpdate
	{
		[Address(RVA = "0x29A8CC0", Offset = "0x29A80C0", Length = "0x56")]
		[Token(Token = "0x6000A75")]
		 add { } //Length: 86
		[Address(RVA = "0x29A9400", Offset = "0x29A8800", Length = "0x4C")]
		[Token(Token = "0x6000A76")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x14000010")]
	public event Action<InputDevice, InputDeviceChange> onDeviceChange
	{
		[Address(RVA = "0x29A8D20", Offset = "0x29A8120", Length = "0x4C")]
		[Token(Token = "0x6000A69")]
		 add { } //Length: 76
		[Address(RVA = "0x29A9450", Offset = "0x29A8850", Length = "0x4C")]
		[Token(Token = "0x6000A6A")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x14000012")]
	public event InputDeviceCommandDelegate onDeviceCommand
	{
		[Address(RVA = "0x29A8D70", Offset = "0x29A8170", Length = "0x4C")]
		[Token(Token = "0x6000A6D")]
		 add { } //Length: 76
		[Address(RVA = "0x29A94A0", Offset = "0x29A88A0", Length = "0x4C")]
		[Token(Token = "0x6000A6E")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x14000011")]
	public event Action<InputDevice, InputEventPtr> onDeviceStateChange
	{
		[Address(RVA = "0x29A8DC0", Offset = "0x29A81C0", Length = "0x4C")]
		[Token(Token = "0x6000A6B")]
		 add { } //Length: 76
		[Address(RVA = "0x29A94F0", Offset = "0x29A88F0", Length = "0x4C")]
		[Token(Token = "0x6000A6C")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x14000015")]
	public event Action<InputEventPtr, InputDevice> onEvent
	{
		[Address(RVA = "0x29A8E10", Offset = "0x29A8210", Length = "0x4C")]
		[Token(Token = "0x6000A73")]
		 add { } //Length: 76
		[Address(RVA = "0x29A9540", Offset = "0x29A8940", Length = "0x4C")]
		[Token(Token = "0x6000A74")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x14000013")]
	public event InputDeviceFindControlLayoutDelegate onFindControlLayoutForDevice
	{
		[Address(RVA = "0x29A8E60", Offset = "0x29A8260", Length = "0x56")]
		[Token(Token = "0x6000A6F")]
		 add { } //Length: 86
		[Address(RVA = "0x29A9590", Offset = "0x29A8990", Length = "0x4C")]
		[Token(Token = "0x6000A70")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x14000014")]
	public event Action<String, InputControlLayoutChange> onLayoutChange
	{
		[Address(RVA = "0x29A8EC0", Offset = "0x29A82C0", Length = "0x4C")]
		[Token(Token = "0x6000A71")]
		 add { } //Length: 76
		[Address(RVA = "0x29A95E0", Offset = "0x29A89E0", Length = "0x4C")]
		[Token(Token = "0x6000A72")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x14000018")]
	public event Action onSettingsChange
	{
		[Address(RVA = "0x29A8F10", Offset = "0x29A8310", Length = "0x4C")]
		[Token(Token = "0x6000A79")]
		 add { } //Length: 76
		[Address(RVA = "0x29A9630", Offset = "0x29A8A30", Length = "0x4C")]
		[Token(Token = "0x6000A7A")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x170002B5")]
	public InputActionAsset actions
	{
		[Address(RVA = "0x29A8F60", Offset = "0x29A8360", Length = "0x8")]
		[Token(Token = "0x6000A5E")]
		 get { } //Length: 8
		[Address(RVA = "0x29A9680", Offset = "0x29A8A80", Length = "0x2B")]
		[Token(Token = "0x6000A5F")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170002B2")]
	public TypeTable composites
	{
		[Address(RVA = "0x1D43810", Offset = "0x1D42C10", Length = "0xE")]
		[Token(Token = "0x6000A5A")]
		 get { } //Length: 14
	}

	[Token(Token = "0x170002B7")]
	public InputUpdateType defaultUpdateType
	{
		[Address(RVA = "0x29A8F70", Offset = "0x29A8370", Length = "0x1D")]
		[Token(Token = "0x6000A62")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170002AF")]
	public ReadOnlyArray<InputDevice> devices
	{
		[Address(RVA = "0x29A8F90", Offset = "0x29A8390", Length = "0x65")]
		[Token(Token = "0x6000A57")]
		 get { } //Length: 101
	}

	[Token(Token = "0x170002BD")]
	private bool gameHasFocus
	{
		[Address(RVA = "0x29A9000", Offset = "0x29A8400", Length = "0x31")]
		[Token(Token = "0x6000A7F")]
		private get { } //Length: 49
	}

	[Token(Token = "0x170002BC")]
	private bool gameIsPlaying
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000A7E")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170002BE")]
	private bool gameShouldGetInputRegardlessOfFocus
	{
		[Address(RVA = "0x29A9040", Offset = "0x29A8440", Length = "0x21")]
		[Token(Token = "0x6000A80")]
		private get { } //Length: 33
	}

	[Token(Token = "0x170002BA")]
	internal InputEventHandledPolicy inputEventHandledPolicy
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000A67")]
		internal get { } //Length: 4
		[Address(RVA = "0x29A96B0", Offset = "0x29A8AB0", Length = "0x9E")]
		[Token(Token = "0x6000A68")]
		internal set { } //Length: 158
	}

	[Token(Token = "0x170002B1")]
	public TypeTable interactions
	{
		[Address(RVA = "0x2161F30", Offset = "0x2161330", Length = "0xB")]
		[Token(Token = "0x6000A59")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170002BB")]
	public bool isProcessingEvents
	{
		[Address(RVA = "0x29A9070", Offset = "0x29A8470", Length = "0x8")]
		[Token(Token = "0x6000A7D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170002B3")]
	public InputMetrics metrics
	{
		[Address(RVA = "0x29A9080", Offset = "0x29A8480", Length = "0x1C1")]
		[Token(Token = "0x6000A5B")]
		 get { } //Length: 449
	}

	[Token(Token = "0x170002BF")]
	internal bool optimizedControlsFeatureEnabled
	{
		[Address(RVA = "0x29A9250", Offset = "0x29A8650", Length = "0x8")]
		[Token(Token = "0x6000AB9")]
		internal get { } //Length: 8
		[Address(RVA = "0x29A9750", Offset = "0x29A8B50", Length = "0x7")]
		[Token(Token = "0x6000ABA")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002C1")]
	internal bool paranoidReadValueCachingChecksEnabled
	{
		[Address(RVA = "0x29A9260", Offset = "0x29A8660", Length = "0x8")]
		[Token(Token = "0x6000ABD")]
		internal get { } //Length: 8
		[Address(RVA = "0x29A9760", Offset = "0x29A8B60", Length = "0x7")]
		[Token(Token = "0x6000ABE")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002B9")]
	public float pollingFrequency
	{
		[Address(RVA = "0x29A9270", Offset = "0x29A8670", Length = "0xCB")]
		[Token(Token = "0x6000A65")]
		 get { } //Length: 203
		[Address(RVA = "0x29A9770", Offset = "0x29A8B70", Length = "0xCC")]
		[Token(Token = "0x6000A66")]
		 set { } //Length: 204
	}

	[Token(Token = "0x170002B0")]
	public TypeTable processors
	{
		[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
		[Token(Token = "0x6000A58")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170002C0")]
	internal bool readValueCachingFeatureEnabled
	{
		[Address(RVA = "0x29A9340", Offset = "0x29A8740", Length = "0x8")]
		[Token(Token = "0x6000ABB")]
		internal get { } //Length: 8
		[Address(RVA = "0x29A9840", Offset = "0x29A8C40", Length = "0x7")]
		[Token(Token = "0x6000ABC")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002B8")]
	public ScrollDeltaBehavior scrollDeltaBehavior
	{
		[Address(RVA = "0x1E17330", Offset = "0x1E16730", Length = "0x7")]
		[Token(Token = "0x6000A63")]
		 get { } //Length: 7
		[Address(RVA = "0x29A9850", Offset = "0x29A8C50", Length = "0xE6")]
		[Token(Token = "0x6000A64")]
		 set { } //Length: 230
	}

	[Token(Token = "0x170002B4")]
	public InputSettings settings
	{
		[Address(RVA = "0x29A9350", Offset = "0x29A8750", Length = "0x8")]
		[Token(Token = "0x6000A5C")]
		 get { } //Length: 8
		[Address(RVA = "0x29A9940", Offset = "0x29A8D40", Length = "0xFD")]
		[Token(Token = "0x6000A5D")]
		 set { } //Length: 253
	}

	[Token(Token = "0x170002B6")]
	public InputUpdateType updateMask
	{
		[Address(RVA = "0x1D1EB80", Offset = "0x1D1DF80", Length = "0x7")]
		[Token(Token = "0x6000A60")]
		 get { } //Length: 7
		[Address(RVA = "0x29A9A40", Offset = "0x29A8E40", Length = "0x1F")]
		[Token(Token = "0x6000A61")]
		 set { } //Length: 31
	}

	[Address(RVA = "0x29A8900", Offset = "0x29A7D00", Length = "0x31F")]
	[Token(Token = "0x6000AEC")]
	private static InputManager() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000AEB")]
	public InputManager() { }

	[Address(RVA = "0x29A7A70", Offset = "0x29A6E70", Length = "0x6D")]
	[CompilerGenerated]
	[Token(Token = "0x6000AED")]
	private long <TryFindMatchingControlLayout>b__97_0(ref InputDeviceCommand commandRef) { }

	[Address(RVA = "0x29A8C20", Offset = "0x29A8020", Length = "0x4C")]
	[Token(Token = "0x6000A7B")]
	public void add_onActionsChange(Action value) { }

	[Address(RVA = "0x29A8C70", Offset = "0x29A8070", Length = "0x4C")]
	[Token(Token = "0x6000A77")]
	public void add_onAfterUpdate(Action value) { }

	[Address(RVA = "0x29A8CC0", Offset = "0x29A80C0", Length = "0x56")]
	[Token(Token = "0x6000A75")]
	public void add_onBeforeUpdate(Action value) { }

	[Address(RVA = "0x29A8D20", Offset = "0x29A8120", Length = "0x4C")]
	[Token(Token = "0x6000A69")]
	public void add_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	[Address(RVA = "0x29A8D70", Offset = "0x29A8170", Length = "0x4C")]
	[Token(Token = "0x6000A6D")]
	public void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	[Address(RVA = "0x29A8DC0", Offset = "0x29A81C0", Length = "0x4C")]
	[Token(Token = "0x6000A6B")]
	public void add_onDeviceStateChange(Action<InputDevice, InputEventPtr> value) { }

	[Address(RVA = "0x29A8E10", Offset = "0x29A8210", Length = "0x4C")]
	[Token(Token = "0x6000A73")]
	public void add_onEvent(Action<InputEventPtr, InputDevice> value) { }

	[Address(RVA = "0x29A8E60", Offset = "0x29A8260", Length = "0x56")]
	[Token(Token = "0x6000A6F")]
	public void add_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	[Address(RVA = "0x29A8EC0", Offset = "0x29A82C0", Length = "0x4C")]
	[Token(Token = "0x6000A71")]
	public void add_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	[Address(RVA = "0x29A8F10", Offset = "0x29A8310", Length = "0x4C")]
	[Token(Token = "0x6000A79")]
	public void add_onSettingsChange(Action value) { }

	[Address(RVA = "0x299A520", Offset = "0x2999920", Length = "0x3FB")]
	[Token(Token = "0x6000A8D")]
	private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout) { }

	[Address(RVA = "0x299A920", Offset = "0x2999D20", Length = "0x244")]
	[Token(Token = "0x6000ACF")]
	internal void AddAvailableDevicesThatAreNowRecognized() { }

	[Address(RVA = "0x299B070", Offset = "0x299A470", Length = "0x176")]
	[Token(Token = "0x6000A9B")]
	public InputDevice AddDevice(Type type, string name = null) { }

	[Address(RVA = "0x299B1F0", Offset = "0x299A5F0", Length = "0x16E")]
	[Token(Token = "0x6000A9C")]
	public InputDevice AddDevice(string layout, string name = null, InternedString variants = null) { }

	[Address(RVA = "0x299BBD0", Offset = "0x299AFD0", Length = "0x1DF")]
	[Token(Token = "0x6000A9D")]
	private InputDevice AddDevice(InternedString layout, int deviceId, string deviceName = null, InputDeviceDescription deviceDescription = null, DeviceFlags deviceFlags = 0, InternedString variants = null) { }

	[Address(RVA = "0x299B360", Offset = "0x299A760", Length = "0x86B")]
	[Token(Token = "0x6000A9E")]
	public void AddDevice(InputDevice device) { }

	[Address(RVA = "0x299BDB0", Offset = "0x299B1B0", Length = "0x53")]
	[Token(Token = "0x6000A9F")]
	public InputDevice AddDevice(InputDeviceDescription description) { }

	[Address(RVA = "0x299ADF0", Offset = "0x299A1F0", Length = "0x272")]
	[Token(Token = "0x6000AA0")]
	public InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName = null, int deviceId = 0, DeviceFlags deviceFlags = 0) { }

	[Address(RVA = "0x299ACE0", Offset = "0x299A0E0", Length = "0x108")]
	[Token(Token = "0x6000AA1")]
	public InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName = null, int deviceId = 0, DeviceFlags deviceFlags = 0) { }

	[Address(RVA = "0x299AB70", Offset = "0x2999F70", Length = "0x162")]
	[Token(Token = "0x6000A97")]
	public void AddDeviceUsage(InputDevice device, InternedString usage) { }

	[Address(RVA = "0x299BF00", Offset = "0x299B300", Length = "0x169")]
	[Token(Token = "0x6000AE0")]
	public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex) { }

	[Address(RVA = "0x299BE10", Offset = "0x299B210", Length = "0xE8")]
	[Token(Token = "0x6000AE3")]
	public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex) { }

	[Address(RVA = "0x299C070", Offset = "0x299B470", Length = "0x80")]
	[Token(Token = "0x6000ACD")]
	internal void ApplyActions() { }

	[Address(RVA = "0x299C0F0", Offset = "0x299B4F0", Length = "0x816")]
	[Token(Token = "0x6000ACC")]
	internal void ApplySettings() { }

	[Address(RVA = "0x299C910", Offset = "0x299BD10", Length = "0x27C")]
	[Token(Token = "0x6000AD6")]
	private bool AreMaximumEventBytesPerUpdateExceeded(uint totalEventBytesProcessed) { }

	[Address(RVA = "0x299CB90", Offset = "0x299BF90", Length = "0x1C0")]
	[Token(Token = "0x6000AC1")]
	private void AssignUniqueDeviceId(InputDevice device) { }

	[Address(RVA = "0x299CD60", Offset = "0x299C160", Length = "0x1B8")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6000AD9")]
	private void CheckAllDevicesOptimizedControlsHaveValidState() { }

	[Address(RVA = "0x299CF20", Offset = "0x299C320", Length = "0x119")]
	[Token(Token = "0x6000AB1")]
	internal void Destroy() { }

	[Address(RVA = "0x299D040", Offset = "0x299C440", Length = "0x8")]
	[Token(Token = "0x6000ADB")]
	internal void DontMakeCurrentlyUpdatingDeviceCurrent() { }

	[Address(RVA = "0x299D050", Offset = "0x299C450", Length = "0x418")]
	[Token(Token = "0x6000AAA")]
	public void EnableOrDisableDevice(InputDevice device, bool enable, DeviceDisableScope scope = 0) { }

	[Address(RVA = "0x847830", Offset = "0x846C30", Length = "0x90")]
	[Token(Token = "0x6000ACE")]
	internal long ExecuteGlobalCommand(ref TCommand command) { }

	[Address(RVA = "0x299D470", Offset = "0x299C870", Length = "0xB9")]
	[Token(Token = "0x6000A92")]
	private InternedString FindOrRegisterDeviceLayoutForType(Type type) { }

	[Address(RVA = "0x299D530", Offset = "0x299C930", Length = "0x485")]
	[Token(Token = "0x6000AE9")]
	internal void FireStateChangeNotifications(int deviceIndex, double internalTime, InputEvent* eventPtr) { }

	[Address(RVA = "0x299D9C0", Offset = "0x299CDC0", Length = "0xFA")]
	[Token(Token = "0x6000AE7")]
	public void FireStateChangeNotifications() { }

	[Address(RVA = "0x299DAC0", Offset = "0x299CEC0", Length = "0xAA")]
	[Token(Token = "0x6000ADF")]
	private bool FlipBuffersForDeviceIfNecessary(InputDevice device, InputUpdateType updateType) { }

	[Address(RVA = "0x299DB70", Offset = "0x299CF70", Length = "0x4E")]
	[Token(Token = "0x6000AA3")]
	public void FlushDisconnectedDevices() { }

	[Address(RVA = "0x29A8F60", Offset = "0x29A8360", Length = "0x8")]
	[Token(Token = "0x6000A5E")]
	public InputActionAsset get_actions() { }

	[Address(RVA = "0x1D43810", Offset = "0x1D42C10", Length = "0xE")]
	[Token(Token = "0x6000A5A")]
	public TypeTable get_composites() { }

	[Address(RVA = "0x29A8F70", Offset = "0x29A8370", Length = "0x1D")]
	[Token(Token = "0x6000A62")]
	public InputUpdateType get_defaultUpdateType() { }

	[Address(RVA = "0x29A8F90", Offset = "0x29A8390", Length = "0x65")]
	[Token(Token = "0x6000A57")]
	public ReadOnlyArray<InputDevice> get_devices() { }

	[Address(RVA = "0x29A9000", Offset = "0x29A8400", Length = "0x31")]
	[Token(Token = "0x6000A7F")]
	private bool get_gameHasFocus() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000A7E")]
	private bool get_gameIsPlaying() { }

	[Address(RVA = "0x29A9040", Offset = "0x29A8440", Length = "0x21")]
	[Token(Token = "0x6000A80")]
	private bool get_gameShouldGetInputRegardlessOfFocus() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000A67")]
	internal InputEventHandledPolicy get_inputEventHandledPolicy() { }

	[Address(RVA = "0x2161F30", Offset = "0x2161330", Length = "0xB")]
	[Token(Token = "0x6000A59")]
	public TypeTable get_interactions() { }

	[Address(RVA = "0x29A9070", Offset = "0x29A8470", Length = "0x8")]
	[Token(Token = "0x6000A7D")]
	public bool get_isProcessingEvents() { }

	[Address(RVA = "0x29A9080", Offset = "0x29A8480", Length = "0x1C1")]
	[Token(Token = "0x6000A5B")]
	public InputMetrics get_metrics() { }

	[Address(RVA = "0x29A9250", Offset = "0x29A8650", Length = "0x8")]
	[Token(Token = "0x6000AB9")]
	internal bool get_optimizedControlsFeatureEnabled() { }

	[Address(RVA = "0x29A9260", Offset = "0x29A8660", Length = "0x8")]
	[Token(Token = "0x6000ABD")]
	internal bool get_paranoidReadValueCachingChecksEnabled() { }

	[Address(RVA = "0x29A9270", Offset = "0x29A8670", Length = "0xCB")]
	[Token(Token = "0x6000A65")]
	public float get_pollingFrequency() { }

	[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
	[Token(Token = "0x6000A58")]
	public TypeTable get_processors() { }

	[Address(RVA = "0x29A9340", Offset = "0x29A8740", Length = "0x8")]
	[Token(Token = "0x6000ABB")]
	internal bool get_readValueCachingFeatureEnabled() { }

	[Address(RVA = "0x1E17330", Offset = "0x1E16730", Length = "0x7")]
	[Token(Token = "0x6000A63")]
	public ScrollDeltaBehavior get_scrollDeltaBehavior() { }

	[Address(RVA = "0x29A9350", Offset = "0x29A8750", Length = "0x8")]
	[Token(Token = "0x6000A5C")]
	public InputSettings get_settings() { }

	[Address(RVA = "0x1D1EB80", Offset = "0x1D1DF80", Length = "0x7")]
	[Token(Token = "0x6000A60")]
	public InputUpdateType get_updateMask() { }

	[Address(RVA = "0x8478D0", Offset = "0x846CD0", Length = "0xFE")]
	[Token(Token = "0x6000A95")]
	public int GetControls(string path, ref InputControlList<TControl>& controls) { }

	[Address(RVA = "0x299DBC0", Offset = "0x299CFC0", Length = "0xA0")]
	[Token(Token = "0x6000AA6")]
	public InputDevice GetDevice(string nameOrLayout) { }

	[Address(RVA = "0x299DC60", Offset = "0x299D060", Length = "0x1D5")]
	[Token(Token = "0x6000AA9")]
	public int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) { }

	[Address(RVA = "0x299DE40", Offset = "0x299D240", Length = "0x4E")]
	[Token(Token = "0x6000A9A")]
	internal bool HasDevice(InputDevice device) { }

	[Address(RVA = "0x299F640", Offset = "0x299EA40", Length = "0x408")]
	[Token(Token = "0x6000AB0")]
	internal void Initialize(IInputRuntime runtime, InputSettings settings) { }

	[Address(RVA = "0x299DE90", Offset = "0x299D290", Length = "0xAB")]
	[Token(Token = "0x6000AB2")]
	private void InitializeActions() { }

	[Address(RVA = "0x299DF40", Offset = "0x299D340", Length = "0x11EB")]
	[Token(Token = "0x6000AB3")]
	internal void InitializeData() { }

	[Address(RVA = "0x299F130", Offset = "0x299E530", Length = "0x1DB")]
	[Token(Token = "0x6000AC3")]
	private void InitializeDefaultState(InputDevice device) { }

	[Address(RVA = "0x299F310", Offset = "0x299E710", Length = "0x327")]
	[Token(Token = "0x6000AC4")]
	private void InitializeDeviceState(InputDevice device) { }

	[Address(RVA = "0x299FA50", Offset = "0x299EE50", Length = "0xB3")]
	[Token(Token = "0x6000AC8")]
	private void InstallBeforeUpdateHookIfNecessary() { }

	[Address(RVA = "0x299FB10", Offset = "0x299EF10", Length = "0x29E")]
	[Token(Token = "0x6000AB7")]
	internal void InstallGlobals() { }

	[Address(RVA = "0x299FDB0", Offset = "0x299F1B0", Length = "0x432")]
	[Token(Token = "0x6000AB6")]
	internal void InstallRuntime(IInputRuntime runtime) { }

	[Address(RVA = "0x29A01F0", Offset = "0x299F5F0", Length = "0x90")]
	[Token(Token = "0x6000ADA")]
	private void InvokeAfterUpdateCallback(InputUpdateType updateType) { }

	[Address(RVA = "0x29A0280", Offset = "0x299F680", Length = "0x103")]
	[Token(Token = "0x6000A87")]
	private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout) { }

	[Address(RVA = "0x29A0390", Offset = "0x299F790", Length = "0xF6")]
	[Token(Token = "0x6000A88")]
	private bool IsControlUsingLayout(InputControl control, InternedString layout) { }

	[Address(RVA = "0x29A0490", Offset = "0x299F890", Length = "0x14E")]
	[Token(Token = "0x6000A93")]
	private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName) { }

	[Address(RVA = "0x29A05E0", Offset = "0x299F9E0", Length = "0x8D")]
	[IteratorStateMachine(typeof(<ListControlLayouts>d__100))]
	[Token(Token = "0x6000A94")]
	public IEnumerable<String> ListControlLayouts(string basedOn = null) { }

	[Address(RVA = "0x29A0670", Offset = "0x299FA70", Length = "0x1D3")]
	[Token(Token = "0x6000ABF")]
	private void MakeDeviceNameUnique(InputDevice device) { }

	[Address(RVA = "0x29A0850", Offset = "0x299FC50", Length = "0x1B2")]
	[Token(Token = "0x6000AC6")]
	private JsonString MakeEscapedJsonString(string theString) { }

	[Address(RVA = "0x29A0A10", Offset = "0x299FE10", Length = "0x186")]
	[Token(Token = "0x6000AD7")]
	private string MakeStringWithEventsProcessedByDevice() { }

	[Address(RVA = "0x29A0BA0", Offset = "0x299FFA0", Length = "0x101")]
	[Token(Token = "0x6000A99")]
	private void NotifyUsageChanged(InputDevice device) { }

	[Address(RVA = "0x29A0CB0", Offset = "0x29A00B0", Length = "0x1FC")]
	[Token(Token = "0x6000ACB")]
	private void OnBeforeUpdate(InputUpdateType updateType) { }

	[Address(RVA = "0x29A0EB0", Offset = "0x29A02B0", Length = "0x4A0")]
	[Token(Token = "0x6000AD1")]
	internal void OnFocusChanged(bool focus) { }

	[Address(RVA = "0x29A1360", Offset = "0x29A0760", Length = "0x43D")]
	[Token(Token = "0x6000AC5")]
	private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[Address(RVA = "0x29A17A0", Offset = "0x29A0BA0", Length = "0x1026")]
	[Token(Token = "0x6000AD3")]
	private void OnUpdate(InputUpdateType updateType, ref InputEventBuffer eventBuffer) { }

	[Address(RVA = "0x29A27D0", Offset = "0x29A1BD0", Length = "0x546")]
	[Token(Token = "0x6000A84")]
	private void PerformLayoutPostRegistration(InternedString layoutName, InlinedArray<InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout = false, bool isOverride = false) { }

	[Address(RVA = "0x29A2F40", Offset = "0x29A2340", Length = "0x2F9")]
	[Token(Token = "0x6000AE8")]
	private bool ProcessStateChangeMonitors(int deviceIndex, Void* newStateFromEvent, Void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes) { }

	[Address(RVA = "0x29A2D20", Offset = "0x29A2120", Length = "0x219")]
	[Token(Token = "0x6000AEA")]
	private void ProcessStateChangeMonitorTimeouts() { }

	[Address(RVA = "0x29A3330", Offset = "0x29A2730", Length = "0xEF")]
	[Token(Token = "0x6000AAC")]
	public void QueueEvent(InputEventPtr ptr) { }

	[Address(RVA = "0x8479D0", Offset = "0x846DD0", Length = "0x8")]
	[Token(Token = "0x6000AAD")]
	public void QueueEvent(ref TEvent inputEvent) { }

	[Address(RVA = "0x29A3240", Offset = "0x29A2640", Length = "0xEF")]
	[Token(Token = "0x6000AAB")]
	private void QueueEvent(InputEvent* eventPtr) { }

	[Address(RVA = "0x29A3420", Offset = "0x29A2820", Length = "0x213")]
	[Token(Token = "0x6000AC2")]
	private void ReallocateStateBuffers() { }

	[Address(RVA = "0x29A3640", Offset = "0x29A2A40", Length = "0x194")]
	[Token(Token = "0x6000A8C")]
	private void RecreateDevice(InputDevice oldDevice, InternedString newLayout) { }

	[Address(RVA = "0x29A3AB0", Offset = "0x29A2EB0", Length = "0x20E")]
	[Token(Token = "0x6000A86")]
	private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout = false) { }

	[Address(RVA = "0x29A37E0", Offset = "0x29A2BE0", Length = "0x2C2")]
	[Token(Token = "0x6000A8B")]
	private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher) { }

	[Address(RVA = "0x29A4290", Offset = "0x29A3690", Length = "0x6AE")]
	[Token(Token = "0x6000A81")]
	public void RegisterControlLayout(string name, Type type) { }

	[Address(RVA = "0x29A4940", Offset = "0x29A3D40", Length = "0x564")]
	[Token(Token = "0x6000A82")]
	public void RegisterControlLayout(string json, string name = null, bool isOverride = false) { }

	[Address(RVA = "0x29A3CC0", Offset = "0x29A30C0", Length = "0x20D")]
	[Token(Token = "0x6000A83")]
	public void RegisterControlLayoutBuilder(Func<InputControlLayout> method, string name, string baseLayout = null) { }

	[Address(RVA = "0x29A4100", Offset = "0x29A3500", Length = "0x183")]
	[Token(Token = "0x6000A89")]
	public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	[Address(RVA = "0x29A3ED0", Offset = "0x29A32D0", Length = "0x223")]
	[Token(Token = "0x6000A8A")]
	public void RegisterControlLayoutMatcher(Type type, InputDeviceMatcher matcher) { }

	[Address(RVA = "0x29A50F0", Offset = "0x29A44F0", Length = "0x275")]
	[Token(Token = "0x6000AB4")]
	private static void RegisterCustomTypes(Type[] types) { }

	[Address(RVA = "0x29A4EB0", Offset = "0x29A42B0", Length = "0x23D")]
	[Token(Token = "0x6000AB5")]
	internal bool RegisterCustomTypes() { }

	[Address(RVA = "0x847A40", Offset = "0x846E40", Length = "0x2A1")]
	[Token(Token = "0x6000A85")]
	public void RegisterPrecompiledLayout(string metadata) { }

	[Address(RVA = "0x29A9360", Offset = "0x29A8760", Length = "0x4C")]
	[Token(Token = "0x6000A7C")]
	public void remove_onActionsChange(Action value) { }

	[Address(RVA = "0x29A93B0", Offset = "0x29A87B0", Length = "0x4C")]
	[Token(Token = "0x6000A78")]
	public void remove_onAfterUpdate(Action value) { }

	[Address(RVA = "0x29A9400", Offset = "0x29A8800", Length = "0x4C")]
	[Token(Token = "0x6000A76")]
	public void remove_onBeforeUpdate(Action value) { }

	[Address(RVA = "0x29A9450", Offset = "0x29A8850", Length = "0x4C")]
	[Token(Token = "0x6000A6A")]
	public void remove_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	[Address(RVA = "0x29A94A0", Offset = "0x29A88A0", Length = "0x4C")]
	[Token(Token = "0x6000A6E")]
	public void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	[Address(RVA = "0x29A94F0", Offset = "0x29A88F0", Length = "0x4C")]
	[Token(Token = "0x6000A6C")]
	public void remove_onDeviceStateChange(Action<InputDevice, InputEventPtr> value) { }

	[Address(RVA = "0x29A9540", Offset = "0x29A8940", Length = "0x4C")]
	[Token(Token = "0x6000A74")]
	public void remove_onEvent(Action<InputEventPtr, InputDevice> value) { }

	[Address(RVA = "0x29A9590", Offset = "0x29A8990", Length = "0x4C")]
	[Token(Token = "0x6000A70")]
	public void remove_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	[Address(RVA = "0x29A95E0", Offset = "0x29A89E0", Length = "0x4C")]
	[Token(Token = "0x6000A72")]
	public void remove_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	[Address(RVA = "0x29A9630", Offset = "0x29A8A30", Length = "0x4C")]
	[Token(Token = "0x6000A7A")]
	public void remove_onSettingsChange(Action value) { }

	[Address(RVA = "0x29A5370", Offset = "0x29A4770", Length = "0x363")]
	[Token(Token = "0x6000A8E")]
	public void RemoveControlLayout(string name) { }

	[Address(RVA = "0x29A5850", Offset = "0x29A4C50", Length = "0x65D")]
	[Token(Token = "0x6000AA2")]
	public void RemoveDevice(InputDevice device, bool keepOnListOfAvailableDevices = false) { }

	[Address(RVA = "0x29A56E0", Offset = "0x29A4AE0", Length = "0x162")]
	[Token(Token = "0x6000A98")]
	public void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	[Address(RVA = "0x29A5FF0", Offset = "0x29A53F0", Length = "0x17F")]
	[Token(Token = "0x6000AE2")]
	public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex) { }

	[Address(RVA = "0x29A6170", Offset = "0x29A5570", Length = "0x133")]
	[Token(Token = "0x6000AE1")]
	private void RemoveStateChangeMonitors(InputDevice device) { }

	[Address(RVA = "0x29A5EB0", Offset = "0x29A52B0", Length = "0x13D")]
	[Token(Token = "0x6000AE4")]
	public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex) { }

	[Address(RVA = "0x29A62B0", Offset = "0x29A56B0", Length = "0xF0")]
	[Token(Token = "0x6000AC0")]
	private static void ResetControlPathsRecursive(InputControl control) { }

	[Address(RVA = "0x29A63B0", Offset = "0x29A57B0", Length = "0xA9")]
	[Token(Token = "0x6000AD8")]
	private void ResetCurrentProcessedEventBytesForDevices() { }

	[Address(RVA = "0x29A6460", Offset = "0x29A5860", Length = "0x579")]
	[Token(Token = "0x6000AA4")]
	public void ResetDevice(InputDevice device, bool alsoResetDontResetControls = false, Nullable<Boolean> issueResetCommand = null) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AC9")]
	private void RestoreDevicesAfterDomainReloadIfNecessary() { }

	[Address(RVA = "0x29A9680", Offset = "0x29A8A80", Length = "0x2B")]
	[Token(Token = "0x6000A5F")]
	public void set_actions(InputActionAsset value) { }

	[Address(RVA = "0x29A96B0", Offset = "0x29A8AB0", Length = "0x9E")]
	[Token(Token = "0x6000A68")]
	internal void set_inputEventHandledPolicy(InputEventHandledPolicy value) { }

	[Address(RVA = "0x29A9750", Offset = "0x29A8B50", Length = "0x7")]
	[Token(Token = "0x6000ABA")]
	internal void set_optimizedControlsFeatureEnabled(bool value) { }

	[Address(RVA = "0x29A9760", Offset = "0x29A8B60", Length = "0x7")]
	[Token(Token = "0x6000ABE")]
	internal void set_paranoidReadValueCachingChecksEnabled(bool value) { }

	[Address(RVA = "0x29A9770", Offset = "0x29A8B70", Length = "0xCC")]
	[Token(Token = "0x6000A66")]
	public void set_pollingFrequency(float value) { }

	[Address(RVA = "0x29A9840", Offset = "0x29A8C40", Length = "0x7")]
	[Token(Token = "0x6000ABC")]
	internal void set_readValueCachingFeatureEnabled(bool value) { }

	[Address(RVA = "0x29A9850", Offset = "0x29A8C50", Length = "0xE6")]
	[Token(Token = "0x6000A64")]
	public void set_scrollDeltaBehavior(ScrollDeltaBehavior value) { }

	[Address(RVA = "0x29A9940", Offset = "0x29A8D40", Length = "0xFD")]
	[Token(Token = "0x6000A5D")]
	public void set_settings(InputSettings value) { }

	[Address(RVA = "0x29A9A40", Offset = "0x29A8E40", Length = "0x1F")]
	[Token(Token = "0x6000A61")]
	public void set_updateMask(InputUpdateType value) { }

	[Address(RVA = "0x29A69E0", Offset = "0x29A5DE0", Length = "0x1A4")]
	[Token(Token = "0x6000A96")]
	public void SetDeviceUsage(InputDevice device, InternedString usage) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000AD5")]
	private bool ShouldExitEarlyFromEventProcessing(InputUpdateType updateType) { }

	[Address(RVA = "0x29A6B90", Offset = "0x29A5F90", Length = "0x75")]
	[Token(Token = "0x6000AD4")]
	private bool ShouldFlushEventBuffer() { }

	[Address(RVA = "0x29A6C10", Offset = "0x29A6010", Length = "0x38")]
	[Token(Token = "0x6000AD0")]
	private bool ShouldRunDeviceInBackground(InputDevice device) { }

	[Address(RVA = "0x29A6C50", Offset = "0x29A6050", Length = "0x11")]
	[Token(Token = "0x6000AD2")]
	internal bool ShouldRunUpdate(InputUpdateType updateType) { }

	[Address(RVA = "0x29A6C70", Offset = "0x29A6070", Length = "0x114")]
	[Token(Token = "0x6000AE6")]
	public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor) { }

	[Address(RVA = "0x29A6D90", Offset = "0x29A6190", Length = "0x4B")]
	[Token(Token = "0x6000AE5")]
	private void SortStateChangeMonitorsIfNecessary(int deviceIndex) { }

	[Address(RVA = "0x29A6DE0", Offset = "0x29A61E0", Length = "0x463")]
	[Token(Token = "0x6000A91")]
	public InternedString TryFindMatchingControlLayout(ref InputDeviceDescription deviceDescription, int deviceId = 0) { }

	[Address(RVA = "0x29A7440", Offset = "0x29A6840", Length = "0x70")]
	[Token(Token = "0x6000AA7")]
	public InputDevice TryGetDevice(Type layoutType) { }

	[Address(RVA = "0x29A72D0", Offset = "0x29A66D0", Length = "0x163")]
	[Token(Token = "0x6000AA5")]
	public InputDevice TryGetDevice(string nameOrLayout) { }

	[Address(RVA = "0x29A7250", Offset = "0x29A6650", Length = "0x79")]
	[Token(Token = "0x6000AA8")]
	public InputDevice TryGetDeviceById(int id) { }

	[Address(RVA = "0x29A74B0", Offset = "0x29A68B0", Length = "0x25")]
	[Token(Token = "0x6000A90")]
	public InputControlLayout TryLoadControlLayout(InternedString name) { }

	[Address(RVA = "0x29A74E0", Offset = "0x29A68E0", Length = "0x283")]
	[Token(Token = "0x6000A8F")]
	public InputControlLayout TryLoadControlLayout(Type type) { }

	[Address(RVA = "0x29A7770", Offset = "0x29A6B70", Length = "0x2F3")]
	[Token(Token = "0x6000AC7")]
	private InputDevice TryMatchDisconnectedDevice(string deviceDescriptor) { }

	[Address(RVA = "0x29A7AE0", Offset = "0x29A6EE0", Length = "0x250")]
	[Token(Token = "0x6000AB8")]
	internal void UninstallGlobals() { }

	[Address(RVA = "0x29A85D0", Offset = "0x29A79D0", Length = "0xE1")]
	[Token(Token = "0x6000AAE")]
	public void Update() { }

	[Address(RVA = "0x29A8500", Offset = "0x29A7900", Length = "0xC1")]
	[Token(Token = "0x6000AAF")]
	public void Update(InputUpdateType updateType) { }

	[Address(RVA = "0x29A7EB0", Offset = "0x29A72B0", Length = "0x642")]
	[Token(Token = "0x6000ADD")]
	internal bool UpdateState(InputDevice device, InputUpdateType updateType, Void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, InputEventPtr eventPtr = null) { }

	[Address(RVA = "0x29A7D40", Offset = "0x29A7140", Length = "0x168")]
	[Token(Token = "0x6000ADC")]
	internal bool UpdateState(InputDevice device, InputEvent* eventPtr, InputUpdateType updateType) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000ACA")]
	private void WarnAboutDevicesFailingToRecreateAfterDomainReload() { }

	[Address(RVA = "0x29A86C0", Offset = "0x29A7AC0", Length = "0x235")]
	[Token(Token = "0x6000ADE")]
	private void WriteStateChange(DoubleBuffers buffers, int deviceIndex, ref InputStateBlock deviceStateBlock, uint stateOffsetInDevice, Void* statePtr, uint stateSizeInBytes, bool flippedBuffers) { }

}

