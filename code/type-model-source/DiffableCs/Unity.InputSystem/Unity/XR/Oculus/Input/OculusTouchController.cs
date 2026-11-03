namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Touch Controller", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, hideInUI = True)]
[Token(Token = "0x200000D")]
public class OculusTouchController : XRControllerWithRumble
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000042")]
	private Vector2Control <thumbstick>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000043")]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000044")]
	private AxisControl <grip>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000045")]
	private ButtonControl <primaryButton>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000046")]
	private ButtonControl <secondaryButton>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000047")]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000048")]
	private ButtonControl <start>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000049")]
	private ButtonControl <thumbstickClicked>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x400004A")]
	private ButtonControl <primaryTouched>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x400004B")]
	private ButtonControl <secondaryTouched>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400004C")]
	private AxisControl <triggerTouched>k__BackingField; //Field offset: 0x200
	[CompilerGenerated]
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400004D")]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400004E")]
	private ButtonControl <thumbstickTouched>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400004F")]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x218
	[CompilerGenerated]
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000050")]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000051")]
	private Vector3Control <deviceAcceleration>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000052")]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; //Field offset: 0x230

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"controllerAcceleration"})]
	[Token(Token = "0x1700004C")]
	public Vector3Control deviceAcceleration
	{
		[Address(RVA = "0x28EA900", Offset = "0x28E9D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000A9")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9A0", Offset = "0x28E9DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000AA")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"controllerAngularAcceleration"})]
	[Token(Token = "0x1700004D")]
	public Vector3Control deviceAngularAcceleration
	{
		[Address(RVA = "0x28EA8D0", Offset = "0x28E9CD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000AB")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA960", Offset = "0x28E9D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000AC")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"controllerAngularVelocity"})]
	[Token(Token = "0x1700004B")]
	public Vector3Control deviceAngularVelocity
	{
		[Address(RVA = "0x28EA8F0", Offset = "0x28E9CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000A7")]
		 get { } //Length: 8
		[Address(RVA = "0x2425700", Offset = "0x2424B00", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000A8")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"controllerVelocity"})]
	[Token(Token = "0x1700004A")]
	public Vector3Control deviceVelocity
	{
		[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000A5")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000A6")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x1700003F")]
	public AxisControl grip
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600008F")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000090")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"GripButton"})]
	[Token(Token = "0x17000042")]
	public ButtonControl gripPressed
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000095")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000096")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"A", "X", "Alternate"})]
	[Token(Token = "0x17000040")]
	public ButtonControl primaryButton
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000091")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000092")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"ATouched", "XTouched", "ATouch", "XTouch"})]
	[Token(Token = "0x17000045")]
	public ButtonControl primaryTouched
	{
		[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600009B")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600009C")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"B", "Y", "Primary"})]
	[Token(Token = "0x17000041")]
	public ButtonControl secondaryButton
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000093")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000094")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"BTouched", "YTouched", "BTouch", "YTouch"})]
	[Token(Token = "0x17000046")]
	public ButtonControl secondaryTouched
	{
		[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600009D")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600009E")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000043")]
	public ButtonControl start
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000097")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000098")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"Primary2DAxis", "Joystick"})]
	[Token(Token = "0x1700003D")]
	public Vector2Control thumbstick
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600008B")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600008C")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"JoystickOrPadPressed", "thumbstickClick"})]
	[Token(Token = "0x17000044")]
	public ButtonControl thumbstickClicked
	{
		[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000099")]
		 get { } //Length: 8
		[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600009A")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"JoystickOrPadTouched", "thumbstickTouch"})]
	[InputControl(name = "trackingState", layout = "Integer", aliases = new IL2CPP_TYPE_STRING[] {"controllerTrackingState"})]
	[InputControl(name = "isTracked", layout = "Button", aliases = new IL2CPP_TYPE_STRING[] {"ControllerIsTracked"})]
	[InputControl(name = "devicePosition", layout = "Vector3", aliases = new IL2CPP_TYPE_STRING[] {"controllerPosition"})]
	[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new IL2CPP_TYPE_STRING[] {"controllerRotation"})]
	[Token(Token = "0x17000049")]
	public ButtonControl thumbstickTouched
	{
		[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000A3")]
		 get { } //Length: 8
		[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000A4")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x1700003E")]
	public AxisControl trigger
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600008D")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600008E")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"indexButton", "indexTouched"})]
	[Token(Token = "0x17000048")]
	public ButtonControl triggerPressed
	{
		[Address(RVA = "0x28EA8E0", Offset = "0x28E9CE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000A1")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA980", Offset = "0x28E9D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000A2")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"indexTouch", "indexNearTouched"})]
	[Token(Token = "0x17000047")]
	public AxisControl triggerTouched
	{
		[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600009F")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000A0")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28D98E0", Offset = "0x28D8CE0", Length = "0x7")]
	[Token(Token = "0x60000AE")]
	public OculusTouchController() { }

	[Address(RVA = "0x28EAB50", Offset = "0x28E9F50", Length = "0x414")]
	[Token(Token = "0x60000AD")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EA900", Offset = "0x28E9D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000A9")]
	public Vector3Control get_deviceAcceleration() { }

	[Address(RVA = "0x28EA8D0", Offset = "0x28E9CD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000AB")]
	public Vector3Control get_deviceAngularAcceleration() { }

	[Address(RVA = "0x28EA8F0", Offset = "0x28E9CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000A7")]
	public Vector3Control get_deviceAngularVelocity() { }

	[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000A5")]
	public Vector3Control get_deviceVelocity() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600008F")]
	public AxisControl get_grip() { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000095")]
	public ButtonControl get_gripPressed() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000091")]
	public ButtonControl get_primaryButton() { }

	[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600009B")]
	public ButtonControl get_primaryTouched() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000093")]
	public ButtonControl get_secondaryButton() { }

	[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600009D")]
	public ButtonControl get_secondaryTouched() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000097")]
	public ButtonControl get_start() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600008B")]
	public Vector2Control get_thumbstick() { }

	[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000099")]
	public ButtonControl get_thumbstickClicked() { }

	[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000A3")]
	public ButtonControl get_thumbstickTouched() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600008D")]
	public AxisControl get_trigger() { }

	[Address(RVA = "0x28EA8E0", Offset = "0x28E9CE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000A1")]
	public ButtonControl get_triggerPressed() { }

	[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600009F")]
	public AxisControl get_triggerTouched() { }

	[Address(RVA = "0x28EA9A0", Offset = "0x28E9DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000AA")]
	protected void set_deviceAcceleration(Vector3Control value) { }

	[Address(RVA = "0x28EA960", Offset = "0x28E9D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000AC")]
	protected void set_deviceAngularAcceleration(Vector3Control value) { }

	[Address(RVA = "0x2425700", Offset = "0x2424B00", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000A8")]
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000A6")]
	protected void set_deviceVelocity(Vector3Control value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000090")]
	protected void set_grip(AxisControl value) { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000096")]
	protected void set_gripPressed(ButtonControl value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000092")]
	protected void set_primaryButton(ButtonControl value) { }

	[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600009C")]
	protected void set_primaryTouched(ButtonControl value) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000094")]
	protected void set_secondaryButton(ButtonControl value) { }

	[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600009E")]
	protected void set_secondaryTouched(ButtonControl value) { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000098")]
	protected void set_start(ButtonControl value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600008C")]
	protected void set_thumbstick(Vector2Control value) { }

	[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600009A")]
	protected void set_thumbstickClicked(ButtonControl value) { }

	[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000A4")]
	protected void set_thumbstickTouched(ButtonControl value) { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600008E")]
	protected void set_trigger(AxisControl value) { }

	[Address(RVA = "0x28EA980", Offset = "0x28E9D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000A2")]
	protected void set_triggerPressed(ButtonControl value) { }

	[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000A0")]
	protected void set_triggerTouched(AxisControl value) { }

}

