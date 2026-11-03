namespace UnityEngine.XR.WindowsMR.Input;

[InputControlLayout(displayName = "Windows MR Controller", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, hideInUI = True)]
[Token(Token = "0x2000016")]
public class WMRSpatialController : XRControllerWithRumble
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000073")]
	private Vector2Control <joystick>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000074")]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000075")]
	private AxisControl <grip>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000076")]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000077")]
	private ButtonControl <menu>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000078")]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000079")]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x400007A")]
	private ButtonControl <joystickClicked>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x400007B")]
	private ButtonControl <touchpadClicked>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x400007C")]
	private ButtonControl <touchpadTouched>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400007D")]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x200
	[CompilerGenerated]
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400007E")]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400007F")]
	private AxisControl <batteryLevel>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000080")]
	private AxisControl <sourceLossRisk>k__BackingField; //Field offset: 0x218
	[CompilerGenerated]
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000081")]
	private Vector3Control <sourceLossMitigationDirection>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000082")]
	private Vector3Control <pointerPosition>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000083")]
	private QuaternionControl <pointerRotation>k__BackingField; //Field offset: 0x230

	[InputControl(noisy = True)]
	[Token(Token = "0x1700007A")]
	public AxisControl batteryLevel
	{
		[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000116")]
		 get { } //Length: 8
		[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000117")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"gripAngularVelocity"})]
	[Token(Token = "0x17000079")]
	public Vector3Control deviceAngularVelocity
	{
		[Address(RVA = "0x28EA8E0", Offset = "0x28E9CE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000114")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA980", Offset = "0x28E9D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000115")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"gripVelocity"})]
	[Token(Token = "0x17000078")]
	public Vector3Control deviceVelocity
	{
		[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000112")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000113")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"gripaxis"})]
	[Token(Token = "0x17000070")]
	public AxisControl grip
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000102")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000103")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"gripbutton"})]
	[Token(Token = "0x17000071")]
	public ButtonControl gripPressed
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000104")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000105")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"Primary2DAxis", "thumbstickaxes"})]
	[Token(Token = "0x1700006E")]
	public Vector2Control joystick
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000FE")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000FF")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"thumbstickpressed"})]
	[Token(Token = "0x17000075")]
	public ButtonControl joystickClicked
	{
		[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600010C")]
		 get { } //Length: 8
		[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600010D")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"Primary", "menubutton"})]
	[Token(Token = "0x17000072")]
	public ButtonControl menu
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000106")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000107")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x1700007D")]
	public Vector3Control pointerPosition
	{
		[Address(RVA = "0x28EA900", Offset = "0x28E9D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600011C")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9A0", Offset = "0x28E9DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600011D")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"PointerOrientation"})]
	[Token(Token = "0x1700007E")]
	public QuaternionControl pointerRotation
	{
		[Address(RVA = "0x28EA8D0", Offset = "0x28E9CD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600011E")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA960", Offset = "0x28E9D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600011F")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x1700007C")]
	public Vector3Control sourceLossMitigationDirection
	{
		[Address(RVA = "0x28EA8F0", Offset = "0x28E9CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600011A")]
		 get { } //Length: 8
		[Address(RVA = "0x2425700", Offset = "0x2424B00", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600011B")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x1700007B")]
	public AxisControl sourceLossRisk
	{
		[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000118")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000119")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"Secondary2DAxis", "touchpadaxes"})]
	[Token(Token = "0x1700006F")]
	public Vector2Control touchpad
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000100")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000101")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"joystickorpadpressed", "touchpadpressed"})]
	[Token(Token = "0x17000076")]
	public ButtonControl touchpadClicked
	{
		[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600010E")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600010F")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"joystickorpadtouched", "touchpadtouched"})]
	[Token(Token = "0x17000077")]
	public ButtonControl touchpadTouched
	{
		[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000110")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000111")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"triggeraxis"})]
	[Token(Token = "0x17000073")]
	public AxisControl trigger
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000108")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000109")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"triggerbutton"})]
	[Token(Token = "0x17000074")]
	public ButtonControl triggerPressed
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600010A")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600010B")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28D98E0", Offset = "0x28D8CE0", Length = "0x7")]
	[Token(Token = "0x6000121")]
	public WMRSpatialController() { }

	[Address(RVA = "0x28F2870", Offset = "0x28F1C70", Length = "0x420")]
	[Token(Token = "0x6000120")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000116")]
	public AxisControl get_batteryLevel() { }

	[Address(RVA = "0x28EA8E0", Offset = "0x28E9CE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000114")]
	public Vector3Control get_deviceAngularVelocity() { }

	[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000112")]
	public Vector3Control get_deviceVelocity() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000102")]
	public AxisControl get_grip() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000104")]
	public ButtonControl get_gripPressed() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000FE")]
	public Vector2Control get_joystick() { }

	[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600010C")]
	public ButtonControl get_joystickClicked() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000106")]
	public ButtonControl get_menu() { }

	[Address(RVA = "0x28EA900", Offset = "0x28E9D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600011C")]
	public Vector3Control get_pointerPosition() { }

	[Address(RVA = "0x28EA8D0", Offset = "0x28E9CD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600011E")]
	public QuaternionControl get_pointerRotation() { }

	[Address(RVA = "0x28EA8F0", Offset = "0x28E9CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600011A")]
	public Vector3Control get_sourceLossMitigationDirection() { }

	[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000118")]
	public AxisControl get_sourceLossRisk() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000100")]
	public Vector2Control get_touchpad() { }

	[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600010E")]
	public ButtonControl get_touchpadClicked() { }

	[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000110")]
	public ButtonControl get_touchpadTouched() { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000108")]
	public AxisControl get_trigger() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600010A")]
	public ButtonControl get_triggerPressed() { }

	[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000117")]
	protected void set_batteryLevel(AxisControl value) { }

	[Address(RVA = "0x28EA980", Offset = "0x28E9D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000115")]
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000113")]
	protected void set_deviceVelocity(Vector3Control value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000103")]
	protected void set_grip(AxisControl value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000105")]
	protected void set_gripPressed(ButtonControl value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000FF")]
	protected void set_joystick(Vector2Control value) { }

	[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600010D")]
	protected void set_joystickClicked(ButtonControl value) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000107")]
	protected void set_menu(ButtonControl value) { }

	[Address(RVA = "0x28EA9A0", Offset = "0x28E9DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600011D")]
	protected void set_pointerPosition(Vector3Control value) { }

	[Address(RVA = "0x28EA960", Offset = "0x28E9D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600011F")]
	protected void set_pointerRotation(QuaternionControl value) { }

	[Address(RVA = "0x2425700", Offset = "0x2424B00", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600011B")]
	protected void set_sourceLossMitigationDirection(Vector3Control value) { }

	[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000119")]
	protected void set_sourceLossRisk(AxisControl value) { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000101")]
	protected void set_touchpad(Vector2Control value) { }

	[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600010F")]
	protected void set_touchpadClicked(ButtonControl value) { }

	[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000111")]
	protected void set_touchpadTouched(ButtonControl value) { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000109")]
	protected void set_trigger(AxisControl value) { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600010B")]
	protected void set_triggerPressed(ButtonControl value) { }

}

