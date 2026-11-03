namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "GearVR Controller", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, hideInUI = True)]
[Token(Token = "0x2000011")]
public class GearVRTrackedController : XRController
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400005A")]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x400005B")]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400005C")]
	private ButtonControl <back>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x400005D")]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x400005E")]
	private ButtonControl <touchpadClicked>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400005F")]
	private ButtonControl <touchpadTouched>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000060")]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000061")]
	private Vector3Control <deviceAcceleration>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000062")]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; //Field offset: 0x1F0

	[InputControl]
	[Token(Token = "0x17000057")]
	public ButtonControl back
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000C7")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000C8")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x1700005C")]
	public Vector3Control deviceAcceleration
	{
		[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000D1")]
		 get { } //Length: 8
		[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000D2")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x1700005D")]
	public Vector3Control deviceAngularAcceleration
	{
		[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000D3")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000D4")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x1700005B")]
	public Vector3Control deviceAngularVelocity
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000CF")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000D0")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000055")]
	public Vector2Control touchpad
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000C3")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000C4")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000059")]
	public ButtonControl touchpadClicked
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000CB")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000CC")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x1700005A")]
	public ButtonControl touchpadTouched
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000CD")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000CE")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000056")]
	public AxisControl trigger
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000C5")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000C6")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000058")]
	public ButtonControl triggerPressed
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000C9")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000CA")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28D98E0", Offset = "0x28D8CE0", Length = "0x7")]
	[Token(Token = "0x60000D6")]
	public GearVRTrackedController() { }

	[Address(RVA = "0x28D9D30", Offset = "0x28D9130", Length = "0x254")]
	[Token(Token = "0x60000D5")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000C7")]
	public ButtonControl get_back() { }

	[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000D1")]
	public Vector3Control get_deviceAcceleration() { }

	[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000D3")]
	public Vector3Control get_deviceAngularAcceleration() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000CF")]
	public Vector3Control get_deviceAngularVelocity() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000C3")]
	public Vector2Control get_touchpad() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000CB")]
	public ButtonControl get_touchpadClicked() { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000CD")]
	public ButtonControl get_touchpadTouched() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000C5")]
	public AxisControl get_trigger() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000C9")]
	public ButtonControl get_triggerPressed() { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000C8")]
	protected void set_back(ButtonControl value) { }

	[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000D2")]
	protected void set_deviceAcceleration(Vector3Control value) { }

	[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000D4")]
	protected void set_deviceAngularAcceleration(Vector3Control value) { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000D0")]
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000C4")]
	protected void set_touchpad(Vector2Control value) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000CC")]
	protected void set_touchpadClicked(ButtonControl value) { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000CE")]
	protected void set_touchpadTouched(ButtonControl value) { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000C6")]
	protected void set_trigger(AxisControl value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000CA")]
	protected void set_triggerPressed(ButtonControl value) { }

}

