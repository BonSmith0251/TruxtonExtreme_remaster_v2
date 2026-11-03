namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(JoystickState), isGenericTypeOfDevice = True)]
[Token(Token = "0x200008D")]
public class Joystick : InputDevice
{
	[CompilerGenerated]
	[Token(Token = "0x4000346")]
	private static Joystick <current>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x4000347")]
	private static int s_JoystickCount; //Field offset: 0x8
	[Token(Token = "0x4000348")]
	private static Joystick[] s_Joysticks; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000342")]
	private ButtonControl <trigger>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000343")]
	private StickControl <stick>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000344")]
	private AxisControl <twist>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000345")]
	private Vector2Control <hatswitch>k__BackingField; //Field offset: 0x1A8

	[Token(Token = "0x170001E2")]
	public static ReadOnlyArray<Joystick> all
	{
		[Address(RVA = "0x29AB340", Offset = "0x29AA740", Length = "0x6D")]
		[Token(Token = "0x60006B6")]
		 get { } //Length: 109
	}

	[Token(Token = "0x170001E1")]
	public private static Joystick current
	{
		[Address(RVA = "0x29AB3B0", Offset = "0x29AA7B0", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x60006B4")]
		 get { } //Length: 54
		[Address(RVA = "0x29AB3F0", Offset = "0x29AA7F0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x60006B5")]
		private set { } //Length: 81
	}

	[Token(Token = "0x170001E0")]
	public Vector2Control hatswitch
	{
		[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60006B2")]
		 get { } //Length: 8
		[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60006B3")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001DE")]
	public StickControl stick
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60006AE")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60006AF")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001DD")]
	public ButtonControl trigger
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60006AC")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60006AD")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001DF")]
	public AxisControl twist
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60006B0")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60006B1")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x60006BB")]
	public Joystick() { }

	[Address(RVA = "0x29AB010", Offset = "0x29AA410", Length = "0x138")]
	[Token(Token = "0x60006B7")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29AB340", Offset = "0x29AA740", Length = "0x6D")]
	[Token(Token = "0x60006B6")]
	public static ReadOnlyArray<Joystick> get_all() { }

	[Address(RVA = "0x29AB3B0", Offset = "0x29AA7B0", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x60006B4")]
	public static Joystick get_current() { }

	[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60006B2")]
	public Vector2Control get_hatswitch() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60006AE")]
	public StickControl get_stick() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60006AC")]
	public ButtonControl get_trigger() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60006B0")]
	public AxisControl get_twist() { }

	[Address(RVA = "0x29AB150", Offset = "0x29AA550", Length = "0x58")]
	[Token(Token = "0x60006B8")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29AB1B0", Offset = "0x29AA5B0", Length = "0x6E")]
	[Token(Token = "0x60006B9")]
	protected virtual void OnAdded() { }

	[Address(RVA = "0x29AB220", Offset = "0x29AA620", Length = "0x11D")]
	[Token(Token = "0x60006BA")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x29AB3F0", Offset = "0x29AA7F0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x60006B5")]
	private static void set_current(Joystick value) { }

	[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60006B3")]
	protected void set_hatswitch(Vector2Control value) { }

	[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60006AF")]
	protected void set_stick(StickControl value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60006AD")]
	protected void set_trigger(ButtonControl value) { }

	[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60006B1")]
	protected void set_twist(AxisControl value) { }

}

