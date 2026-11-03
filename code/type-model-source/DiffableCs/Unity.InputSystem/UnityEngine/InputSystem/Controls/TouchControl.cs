namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(stateType = typeof(TouchState))]
[Token(Token = "0x2000229")]
public class TouchControl : InputControl<TouchState>
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000C32")]
	private TouchPressControl <press>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000C33")]
	private IntegerControl <displayIndex>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000C34")]
	private IntegerControl <touchId>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000C35")]
	private Vector2Control <position>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000C36")]
	private DeltaControl <delta>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000C37")]
	private AxisControl <pressure>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000C38")]
	private Vector2Control <radius>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000C39")]
	private TouchPhaseControl <phase>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000C3A")]
	private ButtonControl <indirectTouch>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000C3B")]
	private ButtonControl <tap>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000C3C")]
	private IntegerControl <tapCount>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000C3D")]
	private DoubleControl <startTime>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000C3E")]
	private Vector2Control <startPosition>k__BackingField; //Field offset: 0x1D0

	[Token(Token = "0x170005CA")]
	public DeltaControl delta
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001453")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001454")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005C7")]
	public IntegerControl displayIndex
	{
		[Address(RVA = "0x1D11BB0", Offset = "0x1D10FB0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600144D")]
		 get { } //Length: 8
		[Address(RVA = "0x24CEC90", Offset = "0x24CE090", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600144E")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005CE")]
	public ButtonControl indirectTouch
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600145B")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600145C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005D3")]
	public bool isInProgress
	{
		[Address(RVA = "0x291FD40", Offset = "0x291F140", Length = "0x60")]
		[Token(Token = "0x6001465")]
		 get { } //Length: 96
	}

	[Token(Token = "0x170005CD")]
	public TouchPhaseControl phase
	{
		[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001459")]
		 get { } //Length: 8
		[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600145A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005C9")]
	public Vector2Control position
	{
		[Address(RVA = "0x22EAA80", Offset = "0x22E9E80", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001451")]
		 get { } //Length: 8
		[Address(RVA = "0x291FDF0", Offset = "0x291F1F0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001452")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005C6")]
	public TouchPressControl press
	{
		[Address(RVA = "0x1D4E690", Offset = "0x1D4DA90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600144B")]
		 get { } //Length: 8
		[Address(RVA = "0x291FE10", Offset = "0x291F210", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600144C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005CB")]
	public AxisControl pressure
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001455")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001456")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005CC")]
	public Vector2Control radius
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001457")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001458")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005D2")]
	public Vector2Control startPosition
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001463")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001464")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005D1")]
	public DoubleControl startTime
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001461")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001462")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005CF")]
	public ButtonControl tap
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600145D")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600145E")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005D0")]
	public IntegerControl tapCount
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600145F")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001460")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005C8")]
	public IntegerControl touchId
	{
		[Address(RVA = "0x291FDC0", Offset = "0x291F1C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600144F")]
		 get { } //Length: 8
		[Address(RVA = "0x291FE30", Offset = "0x291F230", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001450")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x291FCD0", Offset = "0x291F0D0", Length = "0x62")]
	[Token(Token = "0x6001466")]
	public TouchControl() { }

	[Address(RVA = "0x291F840", Offset = "0x291EC40", Length = "0x375")]
	[Token(Token = "0x6001467")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001453")]
	public DeltaControl get_delta() { }

	[Address(RVA = "0x1D11BB0", Offset = "0x1D10FB0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600144D")]
	public IntegerControl get_displayIndex() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600145B")]
	public ButtonControl get_indirectTouch() { }

	[Address(RVA = "0x291FD40", Offset = "0x291F140", Length = "0x60")]
	[Token(Token = "0x6001465")]
	public bool get_isInProgress() { }

	[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001459")]
	public TouchPhaseControl get_phase() { }

	[Address(RVA = "0x22EAA80", Offset = "0x22E9E80", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001451")]
	public Vector2Control get_position() { }

	[Address(RVA = "0x1D4E690", Offset = "0x1D4DA90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600144B")]
	public TouchPressControl get_press() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001455")]
	public AxisControl get_pressure() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001457")]
	public Vector2Control get_radius() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001463")]
	public Vector2Control get_startPosition() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001461")]
	public DoubleControl get_startTime() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600145D")]
	public ButtonControl get_tap() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600145F")]
	public IntegerControl get_tapCount() { }

	[Address(RVA = "0x291FDC0", Offset = "0x291F1C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600144F")]
	public IntegerControl get_touchId() { }

	[Address(RVA = "0x291FBC0", Offset = "0x291EFC0", Length = "0x84")]
	[Token(Token = "0x6001468")]
	public virtual TouchState ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001454")]
	public void set_delta(DeltaControl value) { }

	[Address(RVA = "0x24CEC90", Offset = "0x24CE090", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600144E")]
	public void set_displayIndex(IntegerControl value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600145C")]
	public void set_indirectTouch(ButtonControl value) { }

	[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600145A")]
	public void set_phase(TouchPhaseControl value) { }

	[Address(RVA = "0x291FDF0", Offset = "0x291F1F0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001452")]
	public void set_position(Vector2Control value) { }

	[Address(RVA = "0x291FE10", Offset = "0x291F210", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600144C")]
	public void set_press(TouchPressControl value) { }

	[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001456")]
	public void set_pressure(AxisControl value) { }

	[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001458")]
	public void set_radius(Vector2Control value) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001464")]
	public void set_startPosition(Vector2Control value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001462")]
	public void set_startTime(DoubleControl value) { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600145E")]
	public void set_tap(ButtonControl value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001460")]
	public void set_tapCount(IntegerControl value) { }

	[Address(RVA = "0x291FE30", Offset = "0x291F230", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001450")]
	public void set_touchId(IntegerControl value) { }

	[Address(RVA = "0x291FC50", Offset = "0x291F050", Length = "0x7D")]
	[Token(Token = "0x6001469")]
	public virtual void WriteValueIntoState(TouchState value, Void* statePtr) { }

}

