namespace Unity.XR.OpenVR;

[InputControlLayout(displayName = "Windows MR Controller (OpenVR)", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, hideInUI = True)]
[Token(Token = "0x2000006")]
public class OpenVRControllerWMR : XRController
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400000E")]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x400000F")]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000010")]
	private ButtonControl <touchpadClick>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000011")]
	private ButtonControl <touchpadTouch>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000012")]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000013")]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000014")]
	private ButtonControl <menu>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000015")]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000016")]
	private AxisControl <grip>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000017")]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000018")]
	private Vector2Control <joystick>k__BackingField; //Field offset: 0x200

	[InputControl(noisy = True)]
	[Token(Token = "0x1700000A")]
	public Vector3Control deviceAngularVelocity
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000018")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000019")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000009")]
	public Vector3Control deviceVelocity
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000016")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000017")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000011")]
	public AxisControl grip
	{
		[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000026")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000027")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x1700000D")]
	public ButtonControl gripPressed
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600001E")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600001F")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"primary2DAxis"})]
	[Token(Token = "0x17000013")]
	public Vector2Control joystick
	{
		[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600002A")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600002B")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"primary"})]
	[Token(Token = "0x1700000F")]
	public ButtonControl menu
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000022")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000023")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"secondary2DAxis"})]
	[Token(Token = "0x17000012")]
	public Vector2Control touchpad
	{
		[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000028")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000029")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"primary2DAxisClick", "joystickOrPadPressed"})]
	[Token(Token = "0x1700000B")]
	public ButtonControl touchpadClick
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600001A")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600001B")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"primary2DAxisTouch", "joystickOrPadTouched"})]
	[Token(Token = "0x1700000C")]
	public ButtonControl touchpadTouch
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600001C")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600001D")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000010")]
	public AxisControl trigger
	{
		[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000024")]
		 get { } //Length: 8
		[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000025")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x1700000E")]
	public ButtonControl triggerPressed
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000020")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000021")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28D98E0", Offset = "0x28D8CE0", Length = "0x7")]
	[Token(Token = "0x600002D")]
	public OpenVRControllerWMR() { }

	[Address(RVA = "0x28EB020", Offset = "0x28EA420", Length = "0x2C4")]
	[Token(Token = "0x600002C")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000018")]
	public Vector3Control get_deviceAngularVelocity() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000016")]
	public Vector3Control get_deviceVelocity() { }

	[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000026")]
	public AxisControl get_grip() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600001E")]
	public ButtonControl get_gripPressed() { }

	[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600002A")]
	public Vector2Control get_joystick() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000022")]
	public ButtonControl get_menu() { }

	[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000028")]
	public Vector2Control get_touchpad() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600001A")]
	public ButtonControl get_touchpadClick() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600001C")]
	public ButtonControl get_touchpadTouch() { }

	[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000024")]
	public AxisControl get_trigger() { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000020")]
	public ButtonControl get_triggerPressed() { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000019")]
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000017")]
	protected void set_deviceVelocity(Vector3Control value) { }

	[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000027")]
	protected void set_grip(AxisControl value) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600001F")]
	protected void set_gripPressed(ButtonControl value) { }

	[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600002B")]
	protected void set_joystick(Vector2Control value) { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000023")]
	protected void set_menu(ButtonControl value) { }

	[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000029")]
	protected void set_touchpad(Vector2Control value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600001B")]
	protected void set_touchpadClick(ButtonControl value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600001D")]
	protected void set_touchpadTouch(ButtonControl value) { }

	[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000025")]
	protected void set_trigger(AxisControl value) { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000021")]
	protected void set_triggerPressed(ButtonControl value) { }

}

