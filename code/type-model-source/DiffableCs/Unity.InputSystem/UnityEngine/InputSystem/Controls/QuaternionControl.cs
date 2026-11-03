namespace UnityEngine.InputSystem.Controls;

[Token(Token = "0x2000227")]
public class QuaternionControl : InputControl<Quaternion>
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000C2A")]
	private AxisControl <x>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000C2B")]
	private AxisControl <y>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000C2C")]
	private AxisControl <z>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000C2D")]
	private AxisControl <w>k__BackingField; //Field offset: 0x138

	[InputControl(displayName = "W")]
	[Token(Token = "0x170005C1")]
	public AxisControl w
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600143A")]
		 get { } //Length: 8
		[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600143B")]
		 set { } //Length: 19
	}

	[InputControl(displayName = "X")]
	[Token(Token = "0x170005BE")]
	public AxisControl x
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001434")]
		 get { } //Length: 8
		[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001435")]
		 set { } //Length: 19
	}

	[InputControl(displayName = "Y")]
	[Token(Token = "0x170005BF")]
	public AxisControl y
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001436")]
		 get { } //Length: 8
		[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001437")]
		 set { } //Length: 19
	}

	[InputControl(displayName = "Z")]
	[Token(Token = "0x170005C0")]
	public AxisControl z
	{
		[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001438")]
		 get { } //Length: 8
		[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001439")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x291F0B0", Offset = "0x291E4B0", Length = "0x76")]
	[Token(Token = "0x600143C")]
	public QuaternionControl() { }

	[Address(RVA = "0x291EA20", Offset = "0x291DE20", Length = "0x2B8")]
	[Token(Token = "0x6001440")]
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	[Address(RVA = "0x291ECE0", Offset = "0x291E0E0", Length = "0x125")]
	[Token(Token = "0x600143D")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600143A")]
	public AxisControl get_w() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001434")]
	public AxisControl get_x() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001436")]
	public AxisControl get_y() { }

	[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001438")]
	public AxisControl get_z() { }

	[Address(RVA = "0x291EE10", Offset = "0x291E210", Length = "0x15D")]
	[Token(Token = "0x600143E")]
	public virtual Quaternion ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600143B")]
	public void set_w(AxisControl value) { }

	[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001435")]
	public void set_x(AxisControl value) { }

	[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001437")]
	public void set_y(AxisControl value) { }

	[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001439")]
	public void set_z(AxisControl value) { }

	[Address(RVA = "0x291EF70", Offset = "0x291E370", Length = "0x130")]
	[Token(Token = "0x600143F")]
	public virtual void WriteValueIntoState(Quaternion value, Void* statePtr) { }

}

