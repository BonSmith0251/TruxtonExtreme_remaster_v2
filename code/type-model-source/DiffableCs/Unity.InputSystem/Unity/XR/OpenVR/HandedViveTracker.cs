namespace Unity.XR.OpenVR;

[InputControlLayout(displayName = "Handed Vive Tracker", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, hideInUI = True)]
[Token(Token = "0x200000A")]
public class HandedViveTracker : ViveTracker
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000025")]
	private AxisControl <grip>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000026")]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000027")]
	private ButtonControl <primary>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000028")]
	private ButtonControl <trackpadPressed>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000029")]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x1E0

	[InputControl]
	[Token(Token = "0x17000020")]
	public AxisControl grip
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600004B")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600004C")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000021")]
	public ButtonControl gripPressed
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600004D")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600004E")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000022")]
	public ButtonControl primary
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600004F")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000050")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"JoystickOrPadPressed"})]
	[Token(Token = "0x17000023")]
	public ButtonControl trackpadPressed
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000051")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000052")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000024")]
	public ButtonControl triggerPressed
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000053")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000054")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28DA180", Offset = "0x28D9580", Length = "0x7")]
	[Token(Token = "0x6000056")]
	public HandedViveTracker() { }

	[Address(RVA = "0x28D9F90", Offset = "0x28D9390", Length = "0x1E4")]
	[Token(Token = "0x6000055")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600004B")]
	public AxisControl get_grip() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600004D")]
	public ButtonControl get_gripPressed() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600004F")]
	public ButtonControl get_primary() { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000051")]
	public ButtonControl get_trackpadPressed() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000053")]
	public ButtonControl get_triggerPressed() { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600004C")]
	protected void set_grip(AxisControl value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600004E")]
	protected void set_gripPressed(ButtonControl value) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000050")]
	protected void set_primary(ButtonControl value) { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000052")]
	protected void set_trackpadPressed(ButtonControl value) { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000054")]
	protected void set_triggerPressed(ButtonControl value) { }

}

