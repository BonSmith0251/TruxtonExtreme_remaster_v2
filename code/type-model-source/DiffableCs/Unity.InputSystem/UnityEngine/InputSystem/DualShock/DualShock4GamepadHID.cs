namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout(stateType = typeof(DualShock4HIDInputReport), hideInUI = True, isNoisy = True)]
[Token(Token = "0x2000162")]
public class DualShock4GamepadHID : DualShockGamepad, IEventPreProcessor, IInputStateCallbackReceiver
{
	[Token(Token = "0x2000163")]
	public struct DualShock4HIDGenericInputReport
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008F3")]
		public byte leftStickX; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x40008F4")]
		public byte leftStickY; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40008F5")]
		public byte rightStickX; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x40008F6")]
		public byte rightStickY; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40008F7")]
		public byte buttons0; //Field offset: 0x4
		[FieldOffset(Offset = "0x5")]
		[Token(Token = "0x40008F8")]
		public byte buttons1; //Field offset: 0x5
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x40008F9")]
		public byte buttons2; //Field offset: 0x6
		[FieldOffset(Offset = "0x7")]
		[Token(Token = "0x40008FA")]
		public byte leftTrigger; //Field offset: 0x7
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008FB")]
		public byte rightTrigger; //Field offset: 0x8

		[Token(Token = "0x17000429")]
		public static FourCC Format
		{
			[Address(RVA = "0x29E5180", Offset = "0x29E4580", Length = "0x3A")]
			[Token(Token = "0x6000F7D")]
			 get { } //Length: 58
		}

		[Address(RVA = "0x29E5180", Offset = "0x29E4580", Length = "0x3A")]
		[Token(Token = "0x6000F7D")]
		public static FourCC get_Format() { }

		[Address(RVA = "0x29EDEB0", Offset = "0x29ED2B0", Length = "0x41")]
		[Token(Token = "0x6000F7E")]
		public DualShock4HIDInputReport ToHIDInputReport() { }

	}

	[Token(Token = "0x40008F1")]
	internal const byte JitterMaskLow = 120; //Field offset: 0x0
	[Token(Token = "0x40008F2")]
	internal const byte JitterMaskHigh = 135; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40008EB")]
	private ButtonControl <leftTriggerButton>k__BackingField; //Field offset: 0x288
	[CompilerGenerated]
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40008EC")]
	private ButtonControl <rightTriggerButton>k__BackingField; //Field offset: 0x290
	[CompilerGenerated]
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40008ED")]
	private ButtonControl <playStationButton>k__BackingField; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40008EE")]
	private Nullable<Single> m_LowFrequencyMotorSpeed; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x40008EF")]
	private Nullable<Single> m_HighFrequenceyMotorSpeed; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x40008F0")]
	private Nullable<Color> m_LightBarColor; //Field offset: 0x2B0

	[Token(Token = "0x17000426")]
	public ButtonControl leftTriggerButton
	{
		[Address(RVA = "0x29EC870", Offset = "0x29EBC70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F6B")]
		 get { } //Length: 8
		[Address(RVA = "0x29EC8A0", Offset = "0x29EBCA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F6C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000428")]
	public ButtonControl playStationButton
	{
		[Address(RVA = "0x29EC880", Offset = "0x29EBC80", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F6F")]
		 get { } //Length: 8
		[Address(RVA = "0x29EC8C0", Offset = "0x29EBCC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F70")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000427")]
	public ButtonControl rightTriggerButton
	{
		[Address(RVA = "0x29EC890", Offset = "0x29EBC90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F6D")]
		 get { } //Length: 8
		[Address(RVA = "0x29EC8E0", Offset = "0x29EBCE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F6E")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000F7C")]
	public DualShock4GamepadHID() { }

	[Address(RVA = "0x29ECDC0", Offset = "0x29EC1C0", Length = "0xDC")]
	[Token(Token = "0x6000F71")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29EC870", Offset = "0x29EBC70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F6B")]
	public ButtonControl get_leftTriggerButton() { }

	[Address(RVA = "0x29EC880", Offset = "0x29EBC80", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F6F")]
	public ButtonControl get_playStationButton() { }

	[Address(RVA = "0x29EC890", Offset = "0x29EBC90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F6D")]
	public ButtonControl get_rightTriggerButton() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000F7B")]
	public override bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F79")]
	public override void OnNextUpdate() { }

	[Address(RVA = "0x29ECEA0", Offset = "0x29EC2A0", Length = "0x1C3")]
	[Token(Token = "0x6000F7A")]
	public override void OnStateEvent(InputEventPtr eventPtr) { }

	[Address(RVA = "0x29ED070", Offset = "0x29EC470", Length = "0x164")]
	[Token(Token = "0x6000F72")]
	public virtual void PauseHaptics() { }

	[Address(RVA = "0x29ED1E0", Offset = "0x29EC5E0", Length = "0x184")]
	[Token(Token = "0x6000F73")]
	public virtual void ResetHaptics() { }

	[Address(RVA = "0x29ED370", Offset = "0x29EC770", Length = "0x288")]
	[Token(Token = "0x6000F74")]
	public virtual void ResumeHaptics() { }

	[Address(RVA = "0x29EC8A0", Offset = "0x29EBCA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F6C")]
	protected void set_leftTriggerButton(ButtonControl value) { }

	[Address(RVA = "0x29EC8C0", Offset = "0x29EBCC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F70")]
	protected void set_playStationButton(ButtonControl value) { }

	[Address(RVA = "0x29EC8E0", Offset = "0x29EBCE0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F6E")]
	protected void set_rightTriggerButton(ButtonControl value) { }

	[Address(RVA = "0x29ED600", Offset = "0x29ECA00", Length = "0x1DB")]
	[Token(Token = "0x6000F75")]
	public virtual void SetLightBarColor(Color color) { }

	[Address(RVA = "0x29EDA90", Offset = "0x29ECE90", Length = "0x1D9")]
	[Token(Token = "0x6000F76")]
	public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	[Address(RVA = "0x29ED7E0", Offset = "0x29ECBE0", Length = "0x2AC")]
	[Token(Token = "0x6000F77")]
	public bool SetMotorSpeedsAndLightBarColor(float lowFrequency, float highFrequency, Color color) { }

	[Address(RVA = "0x29EDC70", Offset = "0x29ED070", Length = "0x231")]
	[Token(Token = "0x6000F78")]
	private override bool UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr) { }

}

