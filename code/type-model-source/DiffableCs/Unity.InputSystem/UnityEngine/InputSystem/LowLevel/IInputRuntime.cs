namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001CD")]
internal interface IInputRuntime
{

	[Token(Token = "0x170004E7")]
	public double currentTime
	{
		[Token(Token = "0x6001146")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004E8")]
	public double currentTimeForFixedUpdate
	{
		[Token(Token = "0x6001147")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004EA")]
	public double currentTimeOffsetToRealtimeSinceStartup
	{
		[Token(Token = "0x6001149")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004E4")]
	public bool isPlayerFocused
	{
		[Token(Token = "0x6001141")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004EE")]
	public bool normalizeScrollWheelDelta
	{
		[Token(Token = "0x600114E")]
		 get { } //Length: 0
		[Token(Token = "0x600114F")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170004E0")]
	public Action<InputUpdateType> onBeforeUpdate
	{
		[Token(Token = "0x6001139")]
		 get { } //Length: 0
		[Token(Token = "0x600113A")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170004E2")]
	public Action<Int32, String> onDeviceDiscovered
	{
		[Token(Token = "0x600113D")]
		 get { } //Length: 0
		[Token(Token = "0x600113E")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170004E3")]
	public Action<Boolean> onPlayerFocusChanged
	{
		[Token(Token = "0x600113F")]
		 get { } //Length: 0
		[Token(Token = "0x6001140")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170004E1")]
	public Func<InputUpdateType, Boolean> onShouldRunUpdate
	{
		[Token(Token = "0x600113B")]
		 get { } //Length: 0
		[Token(Token = "0x600113C")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170004E5")]
	public Action onShutdown
	{
		[Token(Token = "0x6001142")]
		 get { } //Length: 0
		[Token(Token = "0x6001143")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170004DF")]
	public InputUpdateDelegate onUpdate
	{
		[Token(Token = "0x6001137")]
		 get { } //Length: 0
		[Token(Token = "0x6001138")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170004E6")]
	public float pollingFrequency
	{
		[Token(Token = "0x6001144")]
		 get { } //Length: 0
		[Token(Token = "0x6001145")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170004EB")]
	public bool runInBackground
	{
		[Token(Token = "0x600114A")]
		 get { } //Length: 0
		[Token(Token = "0x600114B")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170004ED")]
	public ScreenOrientation screenOrientation
	{
		[Token(Token = "0x600114D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004EC")]
	public Vector2 screenSize
	{
		[Token(Token = "0x600114C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004EF")]
	public float scrollWheelDeltaPerTick
	{
		[Token(Token = "0x6001150")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004E9")]
	public float unscaledGameTime
	{
		[Token(Token = "0x6001148")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001133")]
	public int AllocateDeviceId() { }

	[Token(Token = "0x6001136")]
	public long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) { }

	[Token(Token = "0x6001146")]
	public double get_currentTime() { }

	[Token(Token = "0x6001147")]
	public double get_currentTimeForFixedUpdate() { }

	[Token(Token = "0x6001149")]
	public double get_currentTimeOffsetToRealtimeSinceStartup() { }

	[Token(Token = "0x6001141")]
	public bool get_isPlayerFocused() { }

	[Token(Token = "0x600114E")]
	public bool get_normalizeScrollWheelDelta() { }

	[Token(Token = "0x6001139")]
	public Action<InputUpdateType> get_onBeforeUpdate() { }

	[Token(Token = "0x600113D")]
	public Action<Int32, String> get_onDeviceDiscovered() { }

	[Token(Token = "0x600113F")]
	public Action<Boolean> get_onPlayerFocusChanged() { }

	[Token(Token = "0x600113B")]
	public Func<InputUpdateType, Boolean> get_onShouldRunUpdate() { }

	[Token(Token = "0x6001142")]
	public Action get_onShutdown() { }

	[Token(Token = "0x6001137")]
	public InputUpdateDelegate get_onUpdate() { }

	[Token(Token = "0x6001144")]
	public float get_pollingFrequency() { }

	[Token(Token = "0x600114A")]
	public bool get_runInBackground() { }

	[Token(Token = "0x600114D")]
	public ScreenOrientation get_screenOrientation() { }

	[Token(Token = "0x600114C")]
	public Vector2 get_screenSize() { }

	[Token(Token = "0x6001150")]
	public float get_scrollWheelDeltaPerTick() { }

	[Token(Token = "0x6001148")]
	public float get_unscaledGameTime() { }

	[Token(Token = "0x6001135")]
	public void QueueEvent(InputEvent* ptr) { }

	[Token(Token = "0x600114F")]
	public void set_normalizeScrollWheelDelta(bool value) { }

	[Token(Token = "0x600113A")]
	public void set_onBeforeUpdate(Action<InputUpdateType> value) { }

	[Token(Token = "0x600113E")]
	public void set_onDeviceDiscovered(Action<Int32, String> value) { }

	[Token(Token = "0x6001140")]
	public void set_onPlayerFocusChanged(Action<Boolean> value) { }

	[Token(Token = "0x600113C")]
	public void set_onShouldRunUpdate(Func<InputUpdateType, Boolean> value) { }

	[Token(Token = "0x6001143")]
	public void set_onShutdown(Action value) { }

	[Token(Token = "0x6001138")]
	public void set_onUpdate(InputUpdateDelegate value) { }

	[Token(Token = "0x6001145")]
	public void set_pollingFrequency(float value) { }

	[Token(Token = "0x600114B")]
	public void set_runInBackground(bool value) { }

	[Token(Token = "0x6001134")]
	public void Update(InputUpdateType type) { }

}

