namespace Unity.XR.GoogleVr;

[InputControlLayout(displayName = "Daydream Controller", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, hideInUI = True)]
[Token(Token = "0x2000013")]
public class DaydreamController : XRController
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000063")]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000064")]
	private ButtonControl <volumeUp>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000065")]
	private ButtonControl <recentered>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000066")]
	private ButtonControl <volumeDown>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000067")]
	private ButtonControl <recentering>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000068")]
	private ButtonControl <app>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000069")]
	private ButtonControl <home>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x400006A")]
	private ButtonControl <touchpadClicked>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x400006B")]
	private ButtonControl <touchpadTouched>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x400006C")]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400006D")]
	private Vector3Control <deviceAcceleration>k__BackingField; //Field offset: 0x200

	[InputControl]
	[Token(Token = "0x17000063")]
	public ButtonControl app
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000E2")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000E3")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000068")]
	public Vector3Control deviceAcceleration
	{
		[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000EC")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000ED")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000067")]
	public Vector3Control deviceVelocity
	{
		[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000EA")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000EB")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000064")]
	public ButtonControl home
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000E5")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000060")]
	public ButtonControl recentered
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000DC")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000DD")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000062")]
	public ButtonControl recentering
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000E1")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x1700005E")]
	public Vector2Control touchpad
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000D8")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000D9")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000065")]
	public ButtonControl touchpadClicked
	{
		[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 8
		[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000E7")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000066")]
	public ButtonControl touchpadTouched
	{
		[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000E8")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000E9")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000061")]
	public ButtonControl volumeDown
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000DE")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000DF")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x1700005F")]
	public ButtonControl volumeUp
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000DB")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28D98E0", Offset = "0x28D8CE0", Length = "0x7")]
	[Token(Token = "0x60000EF")]
	public DaydreamController() { }

	[Address(RVA = "0x28D9620", Offset = "0x28D8A20", Length = "0x2B8")]
	[Token(Token = "0x60000EE")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000E2")]
	public ButtonControl get_app() { }

	[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000EC")]
	public Vector3Control get_deviceAcceleration() { }

	[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000EA")]
	public Vector3Control get_deviceVelocity() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000E4")]
	public ButtonControl get_home() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000DC")]
	public ButtonControl get_recentered() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000E0")]
	public ButtonControl get_recentering() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000D8")]
	public Vector2Control get_touchpad() { }

	[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000E6")]
	public ButtonControl get_touchpadClicked() { }

	[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000E8")]
	public ButtonControl get_touchpadTouched() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000DE")]
	public ButtonControl get_volumeDown() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000DA")]
	public ButtonControl get_volumeUp() { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000E3")]
	protected void set_app(ButtonControl value) { }

	[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000ED")]
	protected void set_deviceAcceleration(Vector3Control value) { }

	[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000EB")]
	protected void set_deviceVelocity(Vector3Control value) { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000E5")]
	protected void set_home(ButtonControl value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000DD")]
	protected void set_recentered(ButtonControl value) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000E1")]
	protected void set_recentering(ButtonControl value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000D9")]
	protected void set_touchpad(Vector2Control value) { }

	[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000E7")]
	protected void set_touchpadClicked(ButtonControl value) { }

	[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000E9")]
	protected void set_touchpadTouched(ButtonControl value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000DF")]
	protected void set_volumeDown(ButtonControl value) { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000DB")]
	protected void set_volumeUp(ButtonControl value) { }

}

