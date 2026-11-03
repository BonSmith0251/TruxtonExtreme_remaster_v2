namespace UnityEngine.InputSystem.Controls;

[Token(Token = "0x200022C")]
public class Vector2Control : InputControl<Vector2>
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000C3F")]
	private AxisControl <x>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000C40")]
	private AxisControl <y>k__BackingField; //Field offset: 0x118

	[InputControl(offset = 0, displayName = "X")]
	[Token(Token = "0x170005D4")]
	public AxisControl x
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001471")]
		 get { } //Length: 8
		[Address(RVA = "0x1CC9D00", Offset = "0x1CC9100", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001472")]
		 set { } //Length: 19
	}

	[InputControl(offset = 4, displayName = "Y")]
	[Token(Token = "0x170005D5")]
	public AxisControl y
	{
		[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001473")]
		 get { } //Length: 8
		[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001474")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x2920C70", Offset = "0x2920070", Length = "0x72")]
	[Token(Token = "0x6001475")]
	public Vector2Control() { }

	[Address(RVA = "0x29207A0", Offset = "0x291FBA0", Length = "0x171")]
	[Token(Token = "0x600147A")]
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	[Address(RVA = "0x2920920", Offset = "0x291FD20", Length = "0xC2")]
	[Token(Token = "0x6001479")]
	public virtual float EvaluateMagnitude(Void* statePtr) { }

	[Address(RVA = "0x29209F0", Offset = "0x291FDF0", Length = "0xB5")]
	[Token(Token = "0x6001476")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001471")]
	public AxisControl get_x() { }

	[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001473")]
	public AxisControl get_y() { }

	[Address(RVA = "0x2920AB0", Offset = "0x291FEB0", Length = "0xD6")]
	[Token(Token = "0x6001477")]
	public virtual Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x1CC9D00", Offset = "0x1CC9100", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001472")]
	public void set_x(AxisControl value) { }

	[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001474")]
	public void set_y(AxisControl value) { }

	[Address(RVA = "0x2920B90", Offset = "0x291FF90", Length = "0xDF")]
	[Token(Token = "0x6001478")]
	public virtual void WriteValueIntoState(Vector2 value, Void* statePtr) { }

}

