namespace UnityEngine.InputSystem.Controls;

[Token(Token = "0x2000228")]
public class StickControl : Vector2Control
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000C2E")]
	private ButtonControl <up>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000C2F")]
	private ButtonControl <down>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000C30")]
	private ButtonControl <left>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000C31")]
	private ButtonControl <right>k__BackingField; //Field offset: 0x138

	[InputControl(useStateFrom = "y", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = True, displayName = "Down")]
	[Token(Token = "0x170005C3")]
	public ButtonControl down
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001443")]
		 get { } //Length: 8
		[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001444")]
		 set { } //Length: 19
	}

	[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = True, displayName = "Left")]
	[Token(Token = "0x170005C4")]
	public ButtonControl left
	{
		[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001445")]
		 get { } //Length: 8
		[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001446")]
		 set { } //Length: 19
	}

	[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=0,clampMax=1", synthetic = True, displayName = "Right")]
	[Token(Token = "0x170005C5")]
	public ButtonControl right
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001447")]
		 get { } //Length: 8
		[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001448")]
		 set { } //Length: 19
	}

	[InputControl(useStateFrom = "y", processors = "axisDeadzone", parameters = "clamp=2,clampMin=0,clampMax=1", synthetic = True, displayName = "Up")]
	[InputControl(name = "x", minValue = -1, maxValue = 1, layout = "Axis", processors = "axisDeadzone")]
	[InputControl(name = "y", minValue = -1, maxValue = 1, layout = "Axis", processors = "axisDeadzone")]
	[Token(Token = "0x170005C2")]
	public ButtonControl up
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001441")]
		 get { } //Length: 8
		[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001442")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x290E630", Offset = "0x290DA30", Length = "0x7")]
	[Token(Token = "0x600144A")]
	public StickControl() { }

	[Address(RVA = "0x291F450", Offset = "0x291E850", Length = "0x114")]
	[Token(Token = "0x6001449")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001443")]
	public ButtonControl get_down() { }

	[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001445")]
	public ButtonControl get_left() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001447")]
	public ButtonControl get_right() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001441")]
	public ButtonControl get_up() { }

	[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001444")]
	public void set_down(ButtonControl value) { }

	[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001446")]
	public void set_left(ButtonControl value) { }

	[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001448")]
	public void set_right(ButtonControl value) { }

	[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001442")]
	public void set_up(ButtonControl value) { }

}

