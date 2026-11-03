namespace UnityEngine.XR.WindowsMR.Input;

[InputControlLayout(displayName = "HoloLens Hand", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, hideInUI = True)]
[Token(Token = "0x2000015")]
public class HololensHand : XRController
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400006F")]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000070")]
	private ButtonControl <airTap>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000071")]
	private AxisControl <sourceLossRisk>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000072")]
	private Vector3Control <sourceLossMitigationDirection>k__BackingField; //Field offset: 0x1C8

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"triggerbutton"})]
	[Token(Token = "0x1700006B")]
	public ButtonControl airTap
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000F6")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000F7")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"gripVelocity"})]
	[Token(Token = "0x1700006A")]
	public Vector3Control deviceVelocity
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000F4")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000F5")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x1700006D")]
	public Vector3Control sourceLossMitigationDirection
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000FA")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000FB")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x1700006C")]
	public AxisControl sourceLossRisk
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000F8")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000F9")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28D98E0", Offset = "0x28D8CE0", Length = "0x7")]
	[Token(Token = "0x60000FD")]
	public HololensHand() { }

	[Address(RVA = "0x28DA190", Offset = "0x28D9590", Length = "0x12C")]
	[Token(Token = "0x60000FC")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000F6")]
	public ButtonControl get_airTap() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000F4")]
	public Vector3Control get_deviceVelocity() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000FA")]
	public Vector3Control get_sourceLossMitigationDirection() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000F8")]
	public AxisControl get_sourceLossRisk() { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000F7")]
	protected void set_airTap(ButtonControl value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000F5")]
	protected void set_deviceVelocity(Vector3Control value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000FB")]
	protected void set_sourceLossMitigationDirection(Vector3Control value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000F9")]
	protected void set_sourceLossRisk(AxisControl value) { }

}

