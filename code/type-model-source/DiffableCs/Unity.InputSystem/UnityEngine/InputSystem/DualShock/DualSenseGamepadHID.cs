namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout(stateType = typeof(DualSenseHIDInputReport), displayName = "DualSense HID")]
[Token(Token = "0x200015D")]
public class DualSenseGamepadHID : DualShockGamepad, IEventMerger, IEventPreProcessor, IInputStateCallbackReceiver
{
	[Token(Token = "0x2000160")]
	public struct DualSenseHIDBluetoothInputReport
	{
		[Token(Token = "0x40008D4")]
		public const int ExpectedReportId = 49; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008D5")]
		public byte reportId; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40008D6")]
		public byte leftStickX; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x40008D7")]
		public byte leftStickY; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40008D8")]
		public byte rightStickX; //Field offset: 0x4
		[FieldOffset(Offset = "0x5")]
		[Token(Token = "0x40008D9")]
		public byte rightStickY; //Field offset: 0x5
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x40008DA")]
		public byte leftTrigger; //Field offset: 0x6
		[FieldOffset(Offset = "0x7")]
		[Token(Token = "0x40008DB")]
		public byte rightTrigger; //Field offset: 0x7
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x40008DC")]
		public byte buttons0; //Field offset: 0x9
		[FieldOffset(Offset = "0xA")]
		[Token(Token = "0x40008DD")]
		public byte buttons1; //Field offset: 0xA
		[FieldOffset(Offset = "0xB")]
		[Token(Token = "0x40008DE")]
		public byte buttons2; //Field offset: 0xB

		[Address(RVA = "0x29EC900", Offset = "0x29EBD00", Length = "0x44")]
		[Token(Token = "0x6000F68")]
		public DualSenseHIDInputReport ToHIDInputReport() { }

	}

	[Token(Token = "0x200015E")]
	public struct DualSenseHIDGenericInputReport
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008C8")]
		public byte reportId; //Field offset: 0x0

		[Token(Token = "0x17000425")]
		public static FourCC Format
		{
			[Address(RVA = "0x29E5180", Offset = "0x29E4580", Length = "0x3A")]
			[Token(Token = "0x6000F66")]
			 get { } //Length: 58
		}

		[Address(RVA = "0x29E5180", Offset = "0x29E4580", Length = "0x3A")]
		[Token(Token = "0x6000F66")]
		public static FourCC get_Format() { }

	}

	[Token(Token = "0x2000161")]
	public struct DualSenseHIDMinimalInputReport
	{
		[Token(Token = "0x40008DF")]
		public static int ExpectedSize1; //Field offset: 0x0
		[Token(Token = "0x40008E0")]
		public static int ExpectedSize2; //Field offset: 0x4
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008E1")]
		public byte reportId; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x40008E2")]
		public byte leftStickX; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40008E3")]
		public byte leftStickY; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x40008E4")]
		public byte rightStickX; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40008E5")]
		public byte rightStickY; //Field offset: 0x4
		[FieldOffset(Offset = "0x5")]
		[Token(Token = "0x40008E6")]
		public byte buttons0; //Field offset: 0x5
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x40008E7")]
		public byte buttons1; //Field offset: 0x6
		[FieldOffset(Offset = "0x7")]
		[Token(Token = "0x40008E8")]
		public byte buttons2; //Field offset: 0x7
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008E9")]
		public byte leftTrigger; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x40008EA")]
		public byte rightTrigger; //Field offset: 0x9

		[Address(RVA = "0x29ECB40", Offset = "0x29EBF40", Length = "0x4E")]
		[Token(Token = "0x6000F6A")]
		private static DualSenseHIDMinimalInputReport() { }

		[Address(RVA = "0x29ECAF0", Offset = "0x29EBEF0", Length = "0x44")]
		[Token(Token = "0x6000F69")]
		public DualSenseHIDInputReport ToHIDInputReport() { }

	}

	[Token(Token = "0x200015F")]
	public struct DualSenseHIDUSBInputReport
	{
		[Token(Token = "0x40008C9")]
		public const int ExpectedReportId = 1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008CA")]
		public byte reportId; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x40008CB")]
		public byte leftStickX; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40008CC")]
		public byte leftStickY; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x40008CD")]
		public byte rightStickX; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40008CE")]
		public byte rightStickY; //Field offset: 0x4
		[FieldOffset(Offset = "0x5")]
		[Token(Token = "0x40008CF")]
		public byte leftTrigger; //Field offset: 0x5
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x40008D0")]
		public byte rightTrigger; //Field offset: 0x6
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008D1")]
		public byte buttons0; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x40008D2")]
		public byte buttons1; //Field offset: 0x9
		[FieldOffset(Offset = "0xA")]
		[Token(Token = "0x40008D3")]
		public byte buttons2; //Field offset: 0xA

		[Address(RVA = "0x29ECB90", Offset = "0x29EBF90", Length = "0x44")]
		[Token(Token = "0x6000F67")]
		public DualSenseHIDInputReport ToHIDInputReport() { }

	}

	[Token(Token = "0x40008C6")]
	internal const byte JitterMaskLow = 120; //Field offset: 0x0
	[Token(Token = "0x40008C7")]
	internal const byte JitterMaskHigh = 135; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40008BF")]
	private ButtonControl <leftTriggerButton>k__BackingField; //Field offset: 0x288
	[CompilerGenerated]
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40008C0")]
	private ButtonControl <rightTriggerButton>k__BackingField; //Field offset: 0x290
	[CompilerGenerated]
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40008C1")]
	private ButtonControl <playStationButton>k__BackingField; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40008C2")]
	private Nullable<Single> m_LowFrequencyMotorSpeed; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x40008C3")]
	private Nullable<Single> m_HighFrequenceyMotorSpeed; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x40008C4")]
	protected Nullable<Color> m_LightBarColor; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2C4")]
	[Token(Token = "0x40008C5")]
	private byte outputSequenceId; //Field offset: 0x2C4

	[Token(Token = "0x17000422")]
	public ButtonControl leftTriggerButton
	{
		[Address(RVA = "0x29EC870", Offset = "0x29EBC70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F50")]
		 get { } //Length: 8
		[Address(RVA = "0x29EC8A0", Offset = "0x29EBCA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F51")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000424")]
	public ButtonControl playStationButton
	{
		[Address(RVA = "0x29EC880", Offset = "0x29EBC80", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F54")]
		 get { } //Length: 8
		[Address(RVA = "0x29EC8C0", Offset = "0x29EBCC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F55")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000423")]
	public ButtonControl rightTriggerButton
	{
		[Address(RVA = "0x29EC890", Offset = "0x29EBC90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F52")]
		 get { } //Length: 8
		[Address(RVA = "0x29EC8E0", Offset = "0x29EBCE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F53")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000F65")]
	public DualSenseGamepadHID() { }

	[Address(RVA = "0x29EB870", Offset = "0x29EAC70", Length = "0xDC")]
	[Token(Token = "0x6000F56")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29EC870", Offset = "0x29EBC70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F50")]
	public ButtonControl get_leftTriggerButton() { }

	[Address(RVA = "0x29EC880", Offset = "0x29EBC80", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F54")]
	public ButtonControl get_playStationButton() { }

	[Address(RVA = "0x29EC890", Offset = "0x29EBC90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F52")]
	public ButtonControl get_rightTriggerButton() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000F64")]
	public override bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	[Address(RVA = "0x29EB950", Offset = "0x29EAD50", Length = "0x3B")]
	[Token(Token = "0x6000F5D")]
	private static bool MergeForward(DualSenseHIDUSBInputReport* currentState, DualSenseHIDUSBInputReport* nextState) { }

	[Address(RVA = "0x29EB990", Offset = "0x29EAD90", Length = "0x3B")]
	[Token(Token = "0x6000F5E")]
	private static bool MergeForward(DualSenseHIDBluetoothInputReport* currentState, DualSenseHIDBluetoothInputReport* nextState) { }

	[Address(RVA = "0x29EB9D0", Offset = "0x29EADD0", Length = "0x3B")]
	[Token(Token = "0x6000F5F")]
	private static bool MergeForward(DualSenseHIDMinimalInputReport* currentState, DualSenseHIDMinimalInputReport* nextState) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F62")]
	public override void OnNextUpdate() { }

	[Address(RVA = "0x29EBA10", Offset = "0x29EAE10", Length = "0x1C3")]
	[Token(Token = "0x6000F63")]
	public override void OnStateEvent(InputEventPtr eventPtr) { }

	[Address(RVA = "0x29EBBE0", Offset = "0x29EAFE0", Length = "0xB9")]
	[Token(Token = "0x6000F57")]
	public virtual void PauseHaptics() { }

	[Address(RVA = "0x29EBCA0", Offset = "0x29EB0A0", Length = "0x87")]
	[Token(Token = "0x6000F58")]
	public virtual void ResetHaptics() { }

	[Address(RVA = "0x29EBD30", Offset = "0x29EB130", Length = "0x77")]
	[Token(Token = "0x6000F59")]
	public virtual void ResumeHaptics() { }

	[Address(RVA = "0x29EC8A0", Offset = "0x29EBCA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F51")]
	protected void set_leftTriggerButton(ButtonControl value) { }

	[Address(RVA = "0x29EC8C0", Offset = "0x29EBCC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F55")]
	protected void set_playStationButton(ButtonControl value) { }

	[Address(RVA = "0x29EC8E0", Offset = "0x29EBCE0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F53")]
	protected void set_rightTriggerButton(ButtonControl value) { }

	[Address(RVA = "0x29EBDB0", Offset = "0x29EB1B0", Length = "0xAF")]
	[Token(Token = "0x6000F5A")]
	public virtual void SetLightBarColor(Color color) { }

	[Address(RVA = "0x29EC1B0", Offset = "0x29EB5B0", Length = "0xD9")]
	[Token(Token = "0x6000F5B")]
	public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	[Address(RVA = "0x29EBE60", Offset = "0x29EB260", Length = "0x34A")]
	[Token(Token = "0x6000F5C")]
	public bool SetMotorSpeedsAndLightBarColor(Nullable<Single> lowFrequency, Nullable<Single> highFrequency, Nullable<Color> color) { }

	[Address(RVA = "0x29EC290", Offset = "0x29EB690", Length = "0x2BE")]
	[Token(Token = "0x6000F60")]
	private override bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	[Address(RVA = "0x29EC550", Offset = "0x29EB950", Length = "0x31F")]
	[Token(Token = "0x6000F61")]
	private override bool UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr) { }

}

