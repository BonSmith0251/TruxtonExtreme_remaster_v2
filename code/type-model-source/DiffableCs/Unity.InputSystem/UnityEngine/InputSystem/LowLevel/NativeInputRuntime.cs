namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001D5")]
internal class NativeInputRuntime : IInputRuntime
{
	[CompilerGenerated]
	[Token(Token = "0x20001D6")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A9C")]
		public Action<InputUpdateType> value; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001198")]
		public <>c__DisplayClass10_0() { }

		[Address(RVA = "0x5C02B0", Offset = "0x5BF6B0", Length = "0x25")]
		[Token(Token = "0x6001199")]
		internal void <set_onBeforeUpdate>b__0(NativeInputUpdateType updateType) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001D7")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A9D")]
		public Func<InputUpdateType, Boolean> value; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600119A")]
		public <>c__DisplayClass13_0() { }

		[Address(RVA = "0x5C02B0", Offset = "0x5BF6B0", Length = "0x25")]
		[Token(Token = "0x600119B")]
		internal bool <set_onShouldRunUpdate>b__0(NativeInputUpdateType updateType) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001D8")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A9E")]
		public InputUpdateDelegate value; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600119C")]
		public <>c__DisplayClass7_0() { }

		[Address(RVA = "0x2A17240", Offset = "0x2A16640", Length = "0x1E5")]
		[Token(Token = "0x600119D")]
		internal void <set_onUpdate>b__0(NativeInputUpdateType updateType, NativeInputEventBuffer* eventBufferPtr) { }

	}

	[Token(Token = "0x4000A94")]
	public static readonly NativeInputRuntime instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A95")]
	private bool m_RunInBackground; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A96")]
	private Action m_ShutdownMethod; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A97")]
	private InputUpdateDelegate m_OnUpdate; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A98")]
	private Action<InputUpdateType> m_OnBeforeUpdate; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A99")]
	private Func<InputUpdateType, Boolean> m_OnShouldRunUpdate; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A9A")]
	private bool m_DidCallOnShutdown; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A9B")]
	private Action<Boolean> m_FocusChangedMethod; //Field offset: 0x40

	[Token(Token = "0x17000507")]
	public override double currentTime
	{
		[Address(RVA = "0x2A12DD0", Offset = "0x2A121D0", Length = "0x40")]
		[Token(Token = "0x6001188")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000508")]
	public override double currentTimeForFixedUpdate
	{
		[Address(RVA = "0x2A12D30", Offset = "0x2A12130", Length = "0x60")]
		[Token(Token = "0x6001189")]
		 get { } //Length: 96
	}

	[Token(Token = "0x17000509")]
	public override double currentTimeOffsetToRealtimeSinceStartup
	{
		[Address(RVA = "0x2A12D90", Offset = "0x2A12190", Length = "0x40")]
		[Token(Token = "0x600118A")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000505")]
	public override bool isPlayerFocused
	{
		[Address(RVA = "0x2A12E10", Offset = "0x2A12210", Length = "0x40")]
		[Token(Token = "0x6001185")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700050E")]
	public override bool normalizeScrollWheelDelta
	{
		[Address(RVA = "0x2A12E50", Offset = "0x2A12250", Length = "0x40")]
		[Token(Token = "0x6001193")]
		 get { } //Length: 64
		[Address(RVA = "0x2A13010", Offset = "0x2A12410", Length = "0x49")]
		[Token(Token = "0x6001194")]
		 set { } //Length: 73
	}

	[Token(Token = "0x17000500")]
	public override Action<InputUpdateType> onBeforeUpdate
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600117B")]
		 get { } //Length: 5
		[Address(RVA = "0x2A13060", Offset = "0x2A12460", Length = "0x13E")]
		[Token(Token = "0x600117C")]
		 set { } //Length: 318
	}

	[Token(Token = "0x17000502")]
	public override Action<Int32, String> onDeviceDiscovered
	{
		[Address(RVA = "0x2A12E90", Offset = "0x2A12290", Length = "0x40")]
		[Token(Token = "0x600117F")]
		 get { } //Length: 64
		[Address(RVA = "0x2A131A0", Offset = "0x2A125A0", Length = "0x49")]
		[Token(Token = "0x6001180")]
		 set { } //Length: 73
	}

	[Token(Token = "0x17000504")]
	public override Action<Boolean> onPlayerFocusChanged
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001183")]
		 get { } //Length: 5
		[Address(RVA = "0x2A131F0", Offset = "0x2A125F0", Length = "0x100")]
		[Token(Token = "0x6001184")]
		 set { } //Length: 256
	}

	[Token(Token = "0x17000501")]
	public override Func<InputUpdateType, Boolean> onShouldRunUpdate
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600117D")]
		 get { } //Length: 5
		[Address(RVA = "0x2A132F0", Offset = "0x2A126F0", Length = "0x13E")]
		[Token(Token = "0x600117E")]
		 set { } //Length: 318
	}

	[Token(Token = "0x17000503")]
	public override Action onShutdown
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001181")]
		 get { } //Length: 5
		[Address(RVA = "0x2A13430", Offset = "0x2A12830", Length = "0x100")]
		[Token(Token = "0x6001182")]
		 set { } //Length: 256
	}

	[Token(Token = "0x170004FF")]
	public override InputUpdateDelegate onUpdate
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001179")]
		 get { } //Length: 5
		[Address(RVA = "0x2A13530", Offset = "0x2A12930", Length = "0x139")]
		[Token(Token = "0x600117A")]
		 set { } //Length: 313
	}

	[Token(Token = "0x17000506")]
	public override float pollingFrequency
	{
		[Address(RVA = "0x2A12ED0", Offset = "0x2A122D0", Length = "0x40")]
		[Token(Token = "0x6001186")]
		 get { } //Length: 64
		[Address(RVA = "0x2A13670", Offset = "0x2A12A70", Length = "0x50")]
		[Token(Token = "0x6001187")]
		 set { } //Length: 80
	}

	[Token(Token = "0x1700050B")]
	public override bool runInBackground
	{
		[Address(RVA = "0x2A12F10", Offset = "0x2A12310", Length = "0x51")]
		[Token(Token = "0x600118C")]
		 get { } //Length: 81
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x600118D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700050D")]
	public override ScreenOrientation screenOrientation
	{
		[Address(RVA = "0x2A12F70", Offset = "0x2A12370", Length = "0x7")]
		[Token(Token = "0x6001192")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700050C")]
	public override Vector2 screenSize
	{
		[Address(RVA = "0x2A12F80", Offset = "0x2A12380", Length = "0x37")]
		[Token(Token = "0x6001191")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700050F")]
	public override float scrollWheelDeltaPerTick
	{
		[Address(RVA = "0x2A12FC0", Offset = "0x2A123C0", Length = "0x40")]
		[Token(Token = "0x6001195")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700050A")]
	public override float unscaledGameTime
	{
		[Address(RVA = "0x2A13000", Offset = "0x2A12400", Length = "0x7")]
		[Token(Token = "0x600118B")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x2A12CC0", Offset = "0x2A120C0", Length = "0x67")]
	[Token(Token = "0x6001197")]
	private static NativeInputRuntime() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001196")]
	public NativeInputRuntime() { }

	[Address(RVA = "0x2A12A80", Offset = "0x2A11E80", Length = "0x40")]
	[Token(Token = "0x6001175")]
	public override int AllocateDeviceId() { }

	[Address(RVA = "0x2A12AC0", Offset = "0x2A11EC0", Length = "0xDF")]
	[Token(Token = "0x6001178")]
	public override long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) { }

	[Address(RVA = "0x2A12DD0", Offset = "0x2A121D0", Length = "0x40")]
	[Token(Token = "0x6001188")]
	public override double get_currentTime() { }

	[Address(RVA = "0x2A12D30", Offset = "0x2A12130", Length = "0x60")]
	[Token(Token = "0x6001189")]
	public override double get_currentTimeForFixedUpdate() { }

	[Address(RVA = "0x2A12D90", Offset = "0x2A12190", Length = "0x40")]
	[Token(Token = "0x600118A")]
	public override double get_currentTimeOffsetToRealtimeSinceStartup() { }

	[Address(RVA = "0x2A12E10", Offset = "0x2A12210", Length = "0x40")]
	[Token(Token = "0x6001185")]
	public override bool get_isPlayerFocused() { }

	[Address(RVA = "0x2A12E50", Offset = "0x2A12250", Length = "0x40")]
	[Token(Token = "0x6001193")]
	public override bool get_normalizeScrollWheelDelta() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600117B")]
	public override Action<InputUpdateType> get_onBeforeUpdate() { }

	[Address(RVA = "0x2A12E90", Offset = "0x2A12290", Length = "0x40")]
	[Token(Token = "0x600117F")]
	public override Action<Int32, String> get_onDeviceDiscovered() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001183")]
	public override Action<Boolean> get_onPlayerFocusChanged() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600117D")]
	public override Func<InputUpdateType, Boolean> get_onShouldRunUpdate() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001181")]
	public override Action get_onShutdown() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001179")]
	public override InputUpdateDelegate get_onUpdate() { }

	[Address(RVA = "0x2A12ED0", Offset = "0x2A122D0", Length = "0x40")]
	[Token(Token = "0x6001186")]
	public override float get_pollingFrequency() { }

	[Address(RVA = "0x2A12F10", Offset = "0x2A12310", Length = "0x51")]
	[Token(Token = "0x600118C")]
	public override bool get_runInBackground() { }

	[Address(RVA = "0x2A12F70", Offset = "0x2A12370", Length = "0x7")]
	[Token(Token = "0x6001192")]
	public override ScreenOrientation get_screenOrientation() { }

	[Address(RVA = "0x2A12F80", Offset = "0x2A12380", Length = "0x37")]
	[Token(Token = "0x6001191")]
	public override Vector2 get_screenSize() { }

	[Address(RVA = "0x2A12FC0", Offset = "0x2A123C0", Length = "0x40")]
	[Token(Token = "0x6001195")]
	public override float get_scrollWheelDeltaPerTick() { }

	[Address(RVA = "0x2A13000", Offset = "0x2A12400", Length = "0x7")]
	[Token(Token = "0x600118B")]
	public override float get_unscaledGameTime() { }

	[Address(RVA = "0x2A12BA0", Offset = "0x2A11FA0", Length = "0x25")]
	[Token(Token = "0x6001190")]
	private void OnFocusChanged(bool focus) { }

	[Address(RVA = "0x1F33A80", Offset = "0x1F32E80", Length = "0x25")]
	[Token(Token = "0x600118E")]
	private void OnShutdown() { }

	[Address(RVA = "0x2A12BD0", Offset = "0x2A11FD0", Length = "0x37")]
	[Token(Token = "0x600118F")]
	private bool OnWantsToShutdown() { }

	[Address(RVA = "0x2A12C10", Offset = "0x2A12010", Length = "0x56")]
	[Token(Token = "0x6001177")]
	public override void QueueEvent(InputEvent* ptr) { }

	[Address(RVA = "0x2A13010", Offset = "0x2A12410", Length = "0x49")]
	[Token(Token = "0x6001194")]
	public override void set_normalizeScrollWheelDelta(bool value) { }

	[Address(RVA = "0x2A13060", Offset = "0x2A12460", Length = "0x13E")]
	[Token(Token = "0x600117C")]
	public override void set_onBeforeUpdate(Action<InputUpdateType> value) { }

	[Address(RVA = "0x2A131A0", Offset = "0x2A125A0", Length = "0x49")]
	[Token(Token = "0x6001180")]
	public override void set_onDeviceDiscovered(Action<Int32, String> value) { }

	[Address(RVA = "0x2A131F0", Offset = "0x2A125F0", Length = "0x100")]
	[Token(Token = "0x6001184")]
	public override void set_onPlayerFocusChanged(Action<Boolean> value) { }

	[Address(RVA = "0x2A132F0", Offset = "0x2A126F0", Length = "0x13E")]
	[Token(Token = "0x600117E")]
	public override void set_onShouldRunUpdate(Func<InputUpdateType, Boolean> value) { }

	[Address(RVA = "0x2A13430", Offset = "0x2A12830", Length = "0x100")]
	[Token(Token = "0x6001182")]
	public override void set_onShutdown(Action value) { }

	[Address(RVA = "0x2A13530", Offset = "0x2A12930", Length = "0x139")]
	[Token(Token = "0x600117A")]
	public override void set_onUpdate(InputUpdateDelegate value) { }

	[Address(RVA = "0x2A13670", Offset = "0x2A12A70", Length = "0x50")]
	[Token(Token = "0x6001187")]
	public override void set_pollingFrequency(float value) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x600118D")]
	public override void set_runInBackground(bool value) { }

	[Address(RVA = "0x2A12C70", Offset = "0x2A12070", Length = "0x47")]
	[Token(Token = "0x6001176")]
	public override void Update(InputUpdateType updateType) { }

}

