namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
[InputControlLayout(stateType = typeof(GamepadState), isGenericTypeOfDevice = True)]
[Token(Token = "0x2000088")]
public class Gamepad : InputDevice, IDualMotorRumble, IHaptics
{
	[CompilerGenerated]
	[Token(Token = "0x4000307")]
	private static Gamepad <current>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x4000309")]
	private static int s_GamepadCount; //Field offset: 0x8
	[Token(Token = "0x400030A")]
	private static Gamepad[] s_Gamepads; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40002F8")]
	private ButtonControl <buttonWest>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40002F9")]
	private ButtonControl <buttonNorth>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40002FA")]
	private ButtonControl <buttonSouth>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40002FB")]
	private ButtonControl <buttonEast>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40002FC")]
	private ButtonControl <leftStickButton>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40002FD")]
	private ButtonControl <rightStickButton>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40002FE")]
	private ButtonControl <startButton>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40002FF")]
	private ButtonControl <selectButton>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000300")]
	private DpadControl <dpad>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000301")]
	private ButtonControl <leftShoulder>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000302")]
	private ButtonControl <rightShoulder>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000303")]
	private StickControl <leftStick>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000304")]
	private StickControl <rightStick>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000305")]
	private ButtonControl <leftTrigger>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000306")]
	private ButtonControl <rightTrigger>k__BackingField; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000308")]
	private DualMotorRumble m_Rumble; //Field offset: 0x208

	[Token(Token = "0x170001BB")]
	public ButtonControl aButton
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[Token(Token = "0x6000657")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001C5")]
	public static ReadOnlyArray<Gamepad> all
	{
		[Address(RVA = "0x292E070", Offset = "0x292D470", Length = "0x6D")]
		[Token(Token = "0x6000662")]
		 get { } //Length: 109
	}

	[Token(Token = "0x170001BC")]
	public ButtonControl bButton
	{
		[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
		[Token(Token = "0x6000658")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001AF")]
	public ButtonControl buttonEast
	{
		[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600063F")]
		 get { } //Length: 8
		[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000640")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001AD")]
	public ButtonControl buttonNorth
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600063B")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600063C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001AE")]
	public ButtonControl buttonSouth
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600063D")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600063E")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001AC")]
	public ButtonControl buttonWest
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000639")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600063A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001C1")]
	public ButtonControl circleButton
	{
		[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
		[Token(Token = "0x600065D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001C2")]
	public ButtonControl crossButton
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[Token(Token = "0x600065E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001C4")]
	public private static Gamepad current
	{
		[Address(RVA = "0x292E0E0", Offset = "0x292D4E0", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000660")]
		 get { } //Length: 54
		[Address(RVA = "0x292E120", Offset = "0x292D520", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6000661")]
		private set { } //Length: 81
	}

	[Token(Token = "0x170001B4")]
	public DpadControl dpad
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000649")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600064A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001C3")]
	public ButtonControl Item
	{
		[Address(RVA = "0x292DE60", Offset = "0x292D260", Length = "0x1D8")]
		[Token(Token = "0x600065F")]
		 get { } //Length: 472
	}

	[Token(Token = "0x170001B5")]
	public ButtonControl leftShoulder
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600064B")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600064C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001B7")]
	public StickControl leftStick
	{
		[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600064F")]
		 get { } //Length: 8
		[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000650")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001B0")]
	public ButtonControl leftStickButton
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000641")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000642")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001B9")]
	public ButtonControl leftTrigger
	{
		[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000653")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000654")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001B6")]
	public ButtonControl rightShoulder
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600064D")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600064E")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001B8")]
	public StickControl rightStick
	{
		[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000651")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000652")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001B1")]
	public ButtonControl rightStickButton
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000643")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000644")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001BA")]
	public ButtonControl rightTrigger
	{
		[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000655")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000656")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001B3")]
	public ButtonControl selectButton
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000647")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000648")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001C0")]
	public ButtonControl squareButton
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[Token(Token = "0x600065C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001B2")]
	public ButtonControl startButton
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000645")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000646")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001BF")]
	public ButtonControl triangleButton
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[Token(Token = "0x600065B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001BD")]
	public ButtonControl xButton
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[Token(Token = "0x6000659")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001BE")]
	public ButtonControl yButton
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[Token(Token = "0x600065A")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x292DDF0", Offset = "0x292D1F0", Length = "0x6D")]
	[Token(Token = "0x600066B")]
	public Gamepad() { }

	[Address(RVA = "0x292D7E0", Offset = "0x292CBE0", Length = "0x38E")]
	[Token(Token = "0x6000663")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[Token(Token = "0x6000657")]
	public ButtonControl get_aButton() { }

	[Address(RVA = "0x292E070", Offset = "0x292D470", Length = "0x6D")]
	[Token(Token = "0x6000662")]
	public static ReadOnlyArray<Gamepad> get_all() { }

	[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
	[Token(Token = "0x6000658")]
	public ButtonControl get_bButton() { }

	[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600063F")]
	public ButtonControl get_buttonEast() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600063B")]
	public ButtonControl get_buttonNorth() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600063D")]
	public ButtonControl get_buttonSouth() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000639")]
	public ButtonControl get_buttonWest() { }

	[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
	[Token(Token = "0x600065D")]
	public ButtonControl get_circleButton() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[Token(Token = "0x600065E")]
	public ButtonControl get_crossButton() { }

	[Address(RVA = "0x292E0E0", Offset = "0x292D4E0", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000660")]
	public static Gamepad get_current() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000649")]
	public DpadControl get_dpad() { }

	[Address(RVA = "0x292DE60", Offset = "0x292D260", Length = "0x1D8")]
	[Token(Token = "0x600065F")]
	public ButtonControl get_Item(GamepadButton button) { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600064B")]
	public ButtonControl get_leftShoulder() { }

	[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600064F")]
	public StickControl get_leftStick() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000641")]
	public ButtonControl get_leftStickButton() { }

	[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000653")]
	public ButtonControl get_leftTrigger() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600064D")]
	public ButtonControl get_rightShoulder() { }

	[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000651")]
	public StickControl get_rightStick() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000643")]
	public ButtonControl get_rightStickButton() { }

	[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000655")]
	public ButtonControl get_rightTrigger() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000647")]
	public ButtonControl get_selectButton() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[Token(Token = "0x600065C")]
	public ButtonControl get_squareButton() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000645")]
	public ButtonControl get_startButton() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[Token(Token = "0x600065B")]
	public ButtonControl get_triangleButton() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[Token(Token = "0x6000659")]
	public ButtonControl get_xButton() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[Token(Token = "0x600065A")]
	public ButtonControl get_yButton() { }

	[Address(RVA = "0x292DB70", Offset = "0x292CF70", Length = "0x51")]
	[Token(Token = "0x6000664")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x292DBD0", Offset = "0x292CFD0", Length = "0x6E")]
	[Token(Token = "0x6000665")]
	protected virtual void OnAdded() { }

	[Address(RVA = "0x292DC40", Offset = "0x292D040", Length = "0x113")]
	[Token(Token = "0x6000666")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x292DD60", Offset = "0x292D160", Length = "0x12")]
	[Token(Token = "0x6000667")]
	public override void PauseHaptics() { }

	[Address(RVA = "0x292DD80", Offset = "0x292D180", Length = "0x12")]
	[Token(Token = "0x6000669")]
	public override void ResetHaptics() { }

	[Address(RVA = "0x292DDA0", Offset = "0x292D1A0", Length = "0x12")]
	[Token(Token = "0x6000668")]
	public override void ResumeHaptics() { }

	[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000640")]
	protected void set_buttonEast(ButtonControl value) { }

	[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600063C")]
	protected void set_buttonNorth(ButtonControl value) { }

	[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600063E")]
	protected void set_buttonSouth(ButtonControl value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600063A")]
	protected void set_buttonWest(ButtonControl value) { }

	[Address(RVA = "0x292E120", Offset = "0x292D520", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6000661")]
	private static void set_current(Gamepad value) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600064A")]
	protected void set_dpad(DpadControl value) { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600064C")]
	protected void set_leftShoulder(ButtonControl value) { }

	[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000650")]
	protected void set_leftStick(StickControl value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000642")]
	protected void set_leftStickButton(ButtonControl value) { }

	[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000654")]
	protected void set_leftTrigger(ButtonControl value) { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600064E")]
	protected void set_rightShoulder(ButtonControl value) { }

	[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000652")]
	protected void set_rightStick(StickControl value) { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000644")]
	protected void set_rightStickButton(ButtonControl value) { }

	[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000656")]
	protected void set_rightTrigger(ButtonControl value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000648")]
	protected void set_selectButton(ButtonControl value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000646")]
	protected void set_startButton(ButtonControl value) { }

	[Address(RVA = "0x292DDC0", Offset = "0x292D1C0", Length = "0x27")]
	[Token(Token = "0x600066A")]
	public override void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

}

