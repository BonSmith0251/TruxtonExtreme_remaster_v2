namespace UnityEngine.InputSystem.LowLevel;

[Extension]
[Token(Token = "0x20001DC")]
public static class InputState
{
	[Token(Token = "0x20001DD")]
	private class StateChangeMonitorDelegate : IInputStateChangeMonitor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A9F")]
		public Action<InputControl, Double, InputEventPtr, Int64> valueChangeCallback; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AA0")]
		public Action<InputControl, Double, Int64, Int32> timerExpiredCallback; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60011B4")]
		public StateChangeMonitorDelegate() { }

		[Address(RVA = "0x2A16490", Offset = "0x2A15890", Length = "0x2A")]
		[Token(Token = "0x60011B2")]
		public override void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) { }

		[Address(RVA = "0x2A164C0", Offset = "0x2A158C0", Length = "0x1E")]
		[Token(Token = "0x60011B3")]
		public override void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) { }

	}


	[Token(Token = "0x14000027")]
	public static event Action<InputDevice, InputEventPtr> onChange
	{
		[Address(RVA = "0x2A11410", Offset = "0x2A10810", Length = "0x69")]
		[Token(Token = "0x60011A7")]
		 add { } //Length: 105
		[Address(RVA = "0x2A11580", Offset = "0x2A10980", Length = "0x69")]
		[Token(Token = "0x60011A8")]
		 remove { } //Length: 105
	}

	[Token(Token = "0x17000513")]
	public static double currentTime
	{
		[Address(RVA = "0x2A11480", Offset = "0x2A10880", Length = "0x70")]
		[Token(Token = "0x60011A6")]
		 get { } //Length: 112
	}

	[Token(Token = "0x17000511")]
	public static InputUpdateType currentUpdateType
	{
		[Address(RVA = "0x2A11500", Offset = "0x2A10900", Length = "0x36")]
		[Token(Token = "0x60011A4")]
		 get { } //Length: 54
	}

	[Token(Token = "0x17000512")]
	public static uint updateCount
	{
		[Address(RVA = "0x2A11540", Offset = "0x2A10940", Length = "0x35")]
		[Token(Token = "0x60011A5")]
		 get { } //Length: 53
	}

	[Address(RVA = "0x2A11410", Offset = "0x2A10810", Length = "0x69")]
	[Token(Token = "0x60011A7")]
	public static void add_onChange(Action<InputDevice, InputEventPtr> value) { }

	[Address(RVA = "0x2A10AA0", Offset = "0x2A0FEA0", Length = "0x1BE")]
	[Token(Token = "0x60011AD")]
	public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1, uint groupIndex = 0) { }

	[Address(RVA = "0x2A10C60", Offset = "0x2A10060", Length = "0x10F")]
	[Token(Token = "0x60011AE")]
	public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, Action<InputControl, Double, InputEventPtr, Int64> valueChangeCallback, int monitorIndex = -1, Action<InputControl, Double, Int64, Int32> timerExpiredCallback = null) { }

	[Address(RVA = "0x2A109A0", Offset = "0x2A0FDA0", Length = "0xFE")]
	[Token(Token = "0x60011B0")]
	public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex = -1, int timerIndex = -1) { }

	[Address(RVA = "0x2A10D70", Offset = "0x2A10170", Length = "0x30F")]
	[Token(Token = "0x60011A9")]
	public static void Change(InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType = 0) { }

	[Address(RVA = "0x848F40", Offset = "0x848340", Length = "0x6A")]
	[Token(Token = "0x60011AA")]
	public static void Change(InputControl control, TState state, InputUpdateType updateType = 0, InputEventPtr eventPtr = null) { }

	[Address(RVA = "0x848FB0", Offset = "0x8483B0", Length = "0x2FE")]
	[Token(Token = "0x60011AB")]
	public static void Change(InputControl control, ref TState state, InputUpdateType updateType = 0, InputEventPtr eventPtr = null) { }

	[Address(RVA = "0x2A11480", Offset = "0x2A10880", Length = "0x70")]
	[Token(Token = "0x60011A6")]
	public static double get_currentTime() { }

	[Address(RVA = "0x2A11500", Offset = "0x2A10900", Length = "0x36")]
	[Token(Token = "0x60011A4")]
	public static InputUpdateType get_currentUpdateType() { }

	[Address(RVA = "0x2A11540", Offset = "0x2A10940", Length = "0x35")]
	[Token(Token = "0x60011A5")]
	public static uint get_updateCount() { }

	[Address(RVA = "0x2A11080", Offset = "0x2A10480", Length = "0x177")]
	[Extension]
	[Token(Token = "0x60011AC")]
	public static bool IsIntegerFormat(FourCC format) { }

	[Address(RVA = "0x2A11580", Offset = "0x2A10980", Length = "0x69")]
	[Token(Token = "0x60011A8")]
	public static void remove_onChange(Action<InputDevice, InputEventPtr> value) { }

	[Address(RVA = "0x2A112E0", Offset = "0x2A106E0", Length = "0x12F")]
	[Token(Token = "0x60011AF")]
	public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1) { }

	[Address(RVA = "0x2A11200", Offset = "0x2A10600", Length = "0xDD")]
	[Token(Token = "0x60011B1")]
	public static void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex = -1, int timerIndex = -1) { }

}

