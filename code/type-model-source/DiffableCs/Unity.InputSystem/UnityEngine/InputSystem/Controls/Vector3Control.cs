namespace UnityEngine.InputSystem.Controls;

[Token(Token = "0x200022D")]
public class Vector3Control : InputControl<Vector3>
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000C41")]
	private AxisControl <x>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000C42")]
	private AxisControl <y>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000C43")]
	private AxisControl <z>k__BackingField; //Field offset: 0x128

	[InputControl(offset = 0, displayName = "X")]
	[Token(Token = "0x170005D6")]
	public AxisControl x
	{
		[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600147B")]
		 get { } //Length: 8
		[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600147C")]
		 set { } //Length: 19
	}

	[InputControl(offset = 4, displayName = "Y")]
	[Token(Token = "0x170005D7")]
	public AxisControl y
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600147D")]
		 get { } //Length: 8
		[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600147E")]
		 set { } //Length: 19
	}

	[InputControl(offset = 8, displayName = "Z")]
	[Token(Token = "0x170005D8")]
	public AxisControl z
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600147F")]
		 get { } //Length: 8
		[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001480")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x2921350", Offset = "0x2920750", Length = "0x72")]
	[Token(Token = "0x6001481")]
	public Vector3Control() { }

	[Address(RVA = "0x2920D50", Offset = "0x2920150", Length = "0x1F0")]
	[Token(Token = "0x6001486")]
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	[Address(RVA = "0x2920F50", Offset = "0x2920350", Length = "0xD0")]
	[Token(Token = "0x6001485")]
	public virtual float EvaluateMagnitude(Void* statePtr) { }

	[Address(RVA = "0x2921020", Offset = "0x2920420", Length = "0xED")]
	[Token(Token = "0x6001482")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600147B")]
	public AxisControl get_x() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600147D")]
	public AxisControl get_y() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600147F")]
	public AxisControl get_z() { }

	[Address(RVA = "0x2921110", Offset = "0x2920510", Length = "0x125")]
	[Token(Token = "0x6001483")]
	public virtual Vector3 ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600147C")]
	public void set_x(AxisControl value) { }

	[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600147E")]
	public void set_y(AxisControl value) { }

	[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001480")]
	public void set_z(AxisControl value) { }

	[Address(RVA = "0x2921240", Offset = "0x2920640", Length = "0x10E")]
	[Token(Token = "0x6001484")]
	public virtual void WriteValueIntoState(Vector3 value, Void* statePtr) { }

}

