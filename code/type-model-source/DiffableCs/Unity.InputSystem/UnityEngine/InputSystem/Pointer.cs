namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(PointerState), isGenericTypeOfDevice = True)]
[Token(Token = "0x2000094")]
public class Pointer : InputDevice, IInputStateCallbackReceiver
{
	[CompilerGenerated]
	[Token(Token = "0x4000403")]
	private static Pointer <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40003FD")]
	private Vector2Control <position>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40003FE")]
	private DeltaControl <delta>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40003FF")]
	private Vector2Control <radius>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000400")]
	private AxisControl <pressure>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000401")]
	private ButtonControl <press>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000402")]
	private IntegerControl <displayIndex>k__BackingField; //Field offset: 0x1B8

	[Token(Token = "0x17000289")]
	public internal static Pointer current
	{
		[Address(RVA = "0x29B0780", Offset = "0x29AFB80", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x600079F")]
		 get { } //Length: 54
		[Address(RVA = "0x29B07C0", Offset = "0x29AFBC0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x60007A0")]
		internal set { } //Length: 81
	}

	[Token(Token = "0x17000284")]
	public DeltaControl delta
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000795")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000796")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000288")]
	public IntegerControl displayIndex
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600079D")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600079E")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000283")]
	public Vector2Control position
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000793")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000794")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000287")]
	public ButtonControl press
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600079B")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600079C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000286")]
	public AxisControl pressure
	{
		[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000799")]
		 get { } //Length: 8
		[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600079A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000285")]
	public Vector2Control radius
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000797")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000798")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x60007A9")]
	public Pointer() { }

	[Address(RVA = "0x29B03D0", Offset = "0x29AF7D0", Length = "0x1B8")]
	[Token(Token = "0x60007A3")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29B0780", Offset = "0x29AFB80", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x600079F")]
	public static Pointer get_current() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000795")]
	public DeltaControl get_delta() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600079D")]
	public IntegerControl get_displayIndex() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000793")]
	public Vector2Control get_position() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600079B")]
	public ButtonControl get_press() { }

	[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000799")]
	public AxisControl get_pressure() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000797")]
	public Vector2Control get_radius() { }

	[Address(RVA = "0x29B0590", Offset = "0x29AF990", Length = "0x58")]
	[Token(Token = "0x60007A1")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29B05F0", Offset = "0x29AF9F0", Length = "0x87")]
	[Token(Token = "0x60007A4")]
	protected void OnNextUpdate() { }

	[Address(RVA = "0x29B0680", Offset = "0x29AFA80", Length = "0x90")]
	[Token(Token = "0x60007A2")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x29B0710", Offset = "0x29AFB10", Length = "0x54")]
	[Token(Token = "0x60007A5")]
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	[Address(RVA = "0x29B07C0", Offset = "0x29AFBC0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x60007A0")]
	internal static void set_current(Pointer value) { }

	[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000796")]
	protected void set_delta(DeltaControl value) { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600079E")]
	protected void set_displayIndex(IntegerControl value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000794")]
	protected void set_position(Vector2Control value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600079C")]
	protected void set_press(ButtonControl value) { }

	[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600079A")]
	protected void set_pressure(AxisControl value) { }

	[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000798")]
	protected void set_radius(Vector2Control value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60007A8")]
	private override bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	[Address(RVA = "0x29B0770", Offset = "0x29AFB70", Length = "0x7")]
	[Token(Token = "0x60007A6")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	[Address(RVA = "0x29B0710", Offset = "0x29AFB10", Length = "0x54")]
	[Token(Token = "0x60007A7")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

}

