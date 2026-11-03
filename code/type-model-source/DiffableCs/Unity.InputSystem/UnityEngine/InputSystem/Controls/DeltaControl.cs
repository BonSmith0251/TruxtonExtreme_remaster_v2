namespace UnityEngine.InputSystem.Controls;

[Preserve]
[Token(Token = "0x200021E")]
public class DeltaControl : Vector2Control
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000C12")]
	private AxisControl <up>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000C13")]
	private AxisControl <down>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000C14")]
	private AxisControl <left>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000C15")]
	private AxisControl <right>k__BackingField; //Field offset: 0x138

	[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = True, displayName = "Down")]
	[Preserve]
	[Token(Token = "0x170005B4")]
	public AxisControl down
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001409")]
		 get { } //Length: 8
		[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600140A")]
		 set { } //Length: 19
	}

	[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = True, displayName = "Left")]
	[Preserve]
	[Token(Token = "0x170005B5")]
	public AxisControl left
	{
		[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600140B")]
		 get { } //Length: 8
		[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600140C")]
		 set { } //Length: 19
	}

	[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = True, displayName = "Right")]
	[Preserve]
	[Token(Token = "0x170005B6")]
	public AxisControl right
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600140D")]
		 get { } //Length: 8
		[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600140E")]
		 set { } //Length: 19
	}

	[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = True, displayName = "Up")]
	[Preserve]
	[Token(Token = "0x170005B3")]
	public AxisControl up
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001407")]
		 get { } //Length: 8
		[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001408")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x290E630", Offset = "0x290DA30", Length = "0x7")]
	[Token(Token = "0x6001410")]
	public DeltaControl() { }

	[Address(RVA = "0x290E510", Offset = "0x290D910", Length = "0x114")]
	[Token(Token = "0x600140F")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001409")]
	public AxisControl get_down() { }

	[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600140B")]
	public AxisControl get_left() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600140D")]
	public AxisControl get_right() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001407")]
	public AxisControl get_up() { }

	[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600140A")]
	public void set_down(AxisControl value) { }

	[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600140C")]
	public void set_left(AxisControl value) { }

	[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600140E")]
	public void set_right(AxisControl value) { }

	[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001408")]
	public void set_up(AxisControl value) { }

}

