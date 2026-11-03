namespace UnityEngine.InputSystem.XR;

[InputControlLayout(stateType = typeof(PoseState))]
[Preserve]
[Token(Token = "0x20000E3")]
public class PoseControl : InputControl<PoseState>
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000568")]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000569")]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x400056A")]
	private Vector3Control <position>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x400056B")]
	private QuaternionControl <rotation>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x400056C")]
	private Vector3Control <velocity>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x400056D")]
	private Vector3Control <angularVelocity>k__BackingField; //Field offset: 0x1A0

	[Token(Token = "0x17000323")]
	public Vector3Control angularVelocity
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C17")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C18")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700031E")]
	public ButtonControl isTracked
	{
		[Address(RVA = "0x1D11BB0", Offset = "0x1D10FB0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C0D")]
		 get { } //Length: 8
		[Address(RVA = "0x24CEC90", Offset = "0x24CE090", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C0E")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000320")]
	public Vector3Control position
	{
		[Address(RVA = "0x22EAA80", Offset = "0x22E9E80", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C11")]
		 get { } //Length: 8
		[Address(RVA = "0x291FDF0", Offset = "0x291F1F0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C12")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000321")]
	public QuaternionControl rotation
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C13")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C14")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700031F")]
	public IntegerControl trackingState
	{
		[Address(RVA = "0x291FDC0", Offset = "0x291F1C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C0F")]
		 get { } //Length: 8
		[Address(RVA = "0x291FE30", Offset = "0x291F230", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C10")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000322")]
	public Vector3Control velocity
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C15")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C16")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x29CAE40", Offset = "0x29CA240", Length = "0x9B")]
	[Token(Token = "0x6000C19")]
	public PoseControl() { }

	[Address(RVA = "0x29CA5D0", Offset = "0x29C99D0", Length = "0x27C")]
	[Token(Token = "0x6000C1D")]
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	[Address(RVA = "0x29CA850", Offset = "0x29C9C50", Length = "0x1BD")]
	[Token(Token = "0x6000C1A")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C17")]
	public Vector3Control get_angularVelocity() { }

	[Address(RVA = "0x1D11BB0", Offset = "0x1D10FB0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C0D")]
	public ButtonControl get_isTracked() { }

	[Address(RVA = "0x22EAA80", Offset = "0x22E9E80", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C11")]
	public Vector3Control get_position() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C13")]
	public QuaternionControl get_rotation() { }

	[Address(RVA = "0x291FDC0", Offset = "0x291F1C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C0F")]
	public IntegerControl get_trackingState() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C15")]
	public Vector3Control get_velocity() { }

	[Address(RVA = "0x29CAA10", Offset = "0x29C9E10", Length = "0x20F")]
	[Token(Token = "0x6000C1B")]
	public virtual PoseState ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C18")]
	public void set_angularVelocity(Vector3Control value) { }

	[Address(RVA = "0x24CEC90", Offset = "0x24CE090", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C0E")]
	public void set_isTracked(ButtonControl value) { }

	[Address(RVA = "0x291FDF0", Offset = "0x291F1F0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C12")]
	public void set_position(Vector3Control value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C14")]
	public void set_rotation(QuaternionControl value) { }

	[Address(RVA = "0x291FE30", Offset = "0x291F230", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C10")]
	public void set_trackingState(IntegerControl value) { }

	[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C16")]
	public void set_velocity(Vector3Control value) { }

	[Address(RVA = "0x29CAC20", Offset = "0x29CA020", Length = "0x21C")]
	[Token(Token = "0x6000C1C")]
	public virtual void WriteValueIntoState(PoseState value, Void* statePtr) { }

}

