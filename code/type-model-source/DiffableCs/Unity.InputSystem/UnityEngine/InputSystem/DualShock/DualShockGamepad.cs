namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout(displayName = "PlayStation Controller")]
[Token(Token = "0x200015C")]
public class DualShockGamepad : Gamepad, IDualShockHaptics, IDualMotorRumble, IHaptics
{
	[CompilerGenerated]
	[Token(Token = "0x40008BD")]
	private static DualShockGamepad <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x40008B4")]
	private ButtonControl <touchpadButton>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x40008B5")]
	private ButtonControl <optionsButton>k__BackingField; //Field offset: 0x218
	[CompilerGenerated]
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x40008B6")]
	private ButtonControl <shareButton>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x40008B7")]
	private ButtonControl <L1>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x40008B8")]
	private ButtonControl <R1>k__BackingField; //Field offset: 0x230
	[CompilerGenerated]
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x40008B9")]
	private ButtonControl <L2>k__BackingField; //Field offset: 0x238
	[CompilerGenerated]
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x40008BA")]
	private ButtonControl <R2>k__BackingField; //Field offset: 0x240
	[CompilerGenerated]
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x40008BB")]
	private ButtonControl <L3>k__BackingField; //Field offset: 0x248
	[CompilerGenerated]
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x40008BC")]
	private ButtonControl <R3>k__BackingField; //Field offset: 0x250
	[CompilerGenerated]
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40008BE")]
	private HIDDeviceDescriptor <hidDescriptor>k__BackingField; //Field offset: 0x258

	[Token(Token = "0x17000420")]
	public private static DualShockGamepad current
	{
		[Address(RVA = "0x29EE270", Offset = "0x29ED670", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000F47")]
		 get { } //Length: 54
		[Address(RVA = "0x29EE2E0", Offset = "0x29ED6E0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6000F48")]
		private set { } //Length: 81
	}

	[Token(Token = "0x17000421")]
	internal HIDDeviceDescriptor hidDescriptor
	{
		[Address(RVA = "0x29EE2B0", Offset = "0x29ED6B0", Length = "0x24")]
		[CompilerGenerated]
		[Token(Token = "0x6000F49")]
		internal get { } //Length: 36
		[Address(RVA = "0x29EE340", Offset = "0x29ED740", Length = "0x2E")]
		[CompilerGenerated]
		[Token(Token = "0x6000F4A")]
		private set { } //Length: 46
	}

	[InputControl(name = "leftShoulder", displayName = "L1", shortDisplayName = "L1")]
	[Token(Token = "0x1700041A")]
	public ButtonControl L1
	{
		[Address(RVA = "0x28EA900", Offset = "0x28E9D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F3B")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9A0", Offset = "0x28E9DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F3C")]
		 set { } //Length: 19
	}

	[InputControl(name = "leftTrigger", displayName = "L2", shortDisplayName = "L2")]
	[Token(Token = "0x1700041C")]
	public ButtonControl L2
	{
		[Address(RVA = "0x28EA8B0", Offset = "0x28E9CB0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F3F")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA920", Offset = "0x28E9D20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F40")]
		 set { } //Length: 19
	}

	[InputControl(name = "leftStickPress", displayName = "L3", shortDisplayName = "L3")]
	[Token(Token = "0x1700041E")]
	public ButtonControl L3
	{
		[Address(RVA = "0x28EA530", Offset = "0x28E9930", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F43")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA550", Offset = "0x28E9950", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F44")]
		 set { } //Length: 19
	}

	[InputControl(name = "start", displayName = "Options")]
	[Token(Token = "0x17000418")]
	public ButtonControl optionsButton
	{
		[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F37")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F38")]
		 set { } //Length: 19
	}

	[InputControl(name = "rightShoulder", displayName = "R1", shortDisplayName = "R1")]
	[Token(Token = "0x1700041B")]
	public ButtonControl R1
	{
		[Address(RVA = "0x28EA8D0", Offset = "0x28E9CD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F3D")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA960", Offset = "0x28E9D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F3E")]
		 set { } //Length: 19
	}

	[InputControl(name = "rightTrigger", displayName = "R2", shortDisplayName = "R2")]
	[Token(Token = "0x1700041D")]
	public ButtonControl R2
	{
		[Address(RVA = "0x28EA8C0", Offset = "0x28E9CC0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F41")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA940", Offset = "0x28E9D40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F42")]
		 set { } //Length: 19
	}

	[InputControl(name = "rightStickPress", displayName = "R3", shortDisplayName = "R3")]
	[Token(Token = "0x1700041F")]
	public ButtonControl R3
	{
		[Address(RVA = "0x28EA540", Offset = "0x28E9940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F45")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA570", Offset = "0x28E9970", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F46")]
		 set { } //Length: 19
	}

	[InputControl(name = "select", displayName = "Share")]
	[Token(Token = "0x17000419")]
	public ButtonControl shareButton
	{
		[Address(RVA = "0x28EA8F0", Offset = "0x28E9CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F39")]
		 get { } //Length: 8
		[Address(RVA = "0x2425700", Offset = "0x2424B00", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F3A")]
		 set { } //Length: 19
	}

	[InputControl(name = "buttonWest", displayName = "Square", shortDisplayName = "Square")]
	[InputControl(name = "buttonNorth", displayName = "Triangle", shortDisplayName = "Triangle")]
	[InputControl(name = "buttonEast", displayName = "Circle", shortDisplayName = "Circle")]
	[InputControl(name = "buttonSouth", displayName = "Cross", shortDisplayName = "Cross")]
	[InputControl]
	[Token(Token = "0x17000417")]
	public ButtonControl touchpadButton
	{
		[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F35")]
		 get { } //Length: 8
		[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F36")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000F4F")]
	public DualShockGamepad() { }

	[Address(RVA = "0x29EDFC0", Offset = "0x29ED3C0", Length = "0x1B4")]
	[Token(Token = "0x6000F4D")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29EE270", Offset = "0x29ED670", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000F47")]
	public static DualShockGamepad get_current() { }

	[Address(RVA = "0x29EE2B0", Offset = "0x29ED6B0", Length = "0x24")]
	[CompilerGenerated]
	[Token(Token = "0x6000F49")]
	internal HIDDeviceDescriptor get_hidDescriptor() { }

	[Address(RVA = "0x28EA900", Offset = "0x28E9D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F3B")]
	public ButtonControl get_L1() { }

	[Address(RVA = "0x28EA8B0", Offset = "0x28E9CB0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F3F")]
	public ButtonControl get_L2() { }

	[Address(RVA = "0x28EA530", Offset = "0x28E9930", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F43")]
	public ButtonControl get_L3() { }

	[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F37")]
	public ButtonControl get_optionsButton() { }

	[Address(RVA = "0x28EA8D0", Offset = "0x28E9CD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F3D")]
	public ButtonControl get_R1() { }

	[Address(RVA = "0x28EA8C0", Offset = "0x28E9CC0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F41")]
	public ButtonControl get_R2() { }

	[Address(RVA = "0x28EA540", Offset = "0x28E9940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F45")]
	public ButtonControl get_R3() { }

	[Address(RVA = "0x28EA8F0", Offset = "0x28E9CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F39")]
	public ButtonControl get_shareButton() { }

	[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F35")]
	public ButtonControl get_touchpadButton() { }

	[Address(RVA = "0x29EE180", Offset = "0x29ED580", Length = "0x58")]
	[Token(Token = "0x6000F4B")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29EE1E0", Offset = "0x29ED5E0", Length = "0x90")]
	[Token(Token = "0x6000F4C")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x29EE2E0", Offset = "0x29ED6E0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6000F48")]
	private static void set_current(DualShockGamepad value) { }

	[Address(RVA = "0x29EE340", Offset = "0x29ED740", Length = "0x2E")]
	[CompilerGenerated]
	[Token(Token = "0x6000F4A")]
	private void set_hidDescriptor(HIDDeviceDescriptor value) { }

	[Address(RVA = "0x28EA9A0", Offset = "0x28E9DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F3C")]
	protected void set_L1(ButtonControl value) { }

	[Address(RVA = "0x28EA920", Offset = "0x28E9D20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F40")]
	protected void set_L2(ButtonControl value) { }

	[Address(RVA = "0x28EA550", Offset = "0x28E9950", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F44")]
	protected void set_L3(ButtonControl value) { }

	[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F38")]
	protected void set_optionsButton(ButtonControl value) { }

	[Address(RVA = "0x28EA960", Offset = "0x28E9D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F3E")]
	protected void set_R1(ButtonControl value) { }

	[Address(RVA = "0x28EA940", Offset = "0x28E9D40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F42")]
	protected void set_R2(ButtonControl value) { }

	[Address(RVA = "0x28EA570", Offset = "0x28E9970", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F46")]
	protected void set_R3(ButtonControl value) { }

	[Address(RVA = "0x2425700", Offset = "0x2424B00", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F3A")]
	protected void set_shareButton(ButtonControl value) { }

	[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F36")]
	protected void set_touchpadButton(ButtonControl value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F4E")]
	public override void SetLightBarColor(Color color) { }

}

