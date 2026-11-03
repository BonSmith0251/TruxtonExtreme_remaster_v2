namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout(stateType = typeof(DualShock3HIDInputReport), hideInUI = True, displayName = "PS3 Controller")]
[Token(Token = "0x2000164")]
public class DualShock3GamepadHID : DualShockGamepad
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40008FC")]
	private ButtonControl <leftTriggerButton>k__BackingField; //Field offset: 0x288
	[CompilerGenerated]
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40008FD")]
	private ButtonControl <rightTriggerButton>k__BackingField; //Field offset: 0x290
	[CompilerGenerated]
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40008FE")]
	private ButtonControl <playStationButton>k__BackingField; //Field offset: 0x298

	[Token(Token = "0x1700042A")]
	public ButtonControl leftTriggerButton
	{
		[Address(RVA = "0x29EC870", Offset = "0x29EBC70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F7F")]
		 get { } //Length: 8
		[Address(RVA = "0x29EC8A0", Offset = "0x29EBCA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F80")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700042C")]
	public ButtonControl playStationButton
	{
		[Address(RVA = "0x29EC880", Offset = "0x29EBC80", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F83")]
		 get { } //Length: 8
		[Address(RVA = "0x29EC8C0", Offset = "0x29EBCC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F84")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700042B")]
	public ButtonControl rightTriggerButton
	{
		[Address(RVA = "0x29EC890", Offset = "0x29EBC90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F81")]
		 get { } //Length: 8
		[Address(RVA = "0x29EC8E0", Offset = "0x29EBCE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F82")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000F86")]
	public DualShock3GamepadHID() { }

	[Address(RVA = "0x29ECCA0", Offset = "0x29EC0A0", Length = "0xDC")]
	[Token(Token = "0x6000F85")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29EC870", Offset = "0x29EBC70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F7F")]
	public ButtonControl get_leftTriggerButton() { }

	[Address(RVA = "0x29EC880", Offset = "0x29EBC80", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F83")]
	public ButtonControl get_playStationButton() { }

	[Address(RVA = "0x29EC890", Offset = "0x29EBC90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F81")]
	public ButtonControl get_rightTriggerButton() { }

	[Address(RVA = "0x29EC8A0", Offset = "0x29EBCA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F80")]
	protected void set_leftTriggerButton(ButtonControl value) { }

	[Address(RVA = "0x29EC8C0", Offset = "0x29EBCC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F84")]
	protected void set_playStationButton(ButtonControl value) { }

	[Address(RVA = "0x29EC8E0", Offset = "0x29EBCE0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F82")]
	protected void set_rightTriggerButton(ButtonControl value) { }

}

