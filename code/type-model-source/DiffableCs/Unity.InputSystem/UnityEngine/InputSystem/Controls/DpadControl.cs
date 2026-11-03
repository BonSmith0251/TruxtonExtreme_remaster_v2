namespace UnityEngine.InputSystem.Controls;

[Token(Token = "0x2000222")]
public class DpadControl : Vector2Control
{
	[Token(Token = "0x2000224")]
	public enum ButtonBits : int
	{
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3,
	}

	[InputControlLayout(hideInUI = True)]
	[Token(Token = "0x2000223")]
	internal class DpadAxisControl : AxisControl
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x130")]
		[Token(Token = "0x4000C22")]
		private int <component>k__BackingField; //Field offset: 0x130

		[Token(Token = "0x170005BB")]
		public int component
		{
			[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x6001426")]
			 get { } //Length: 7
			[Address(RVA = "0x290ECC0", Offset = "0x290E0C0", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x6001427")]
			 set { } //Length: 7
		}

		[Address(RVA = "0x290ECB0", Offset = "0x290E0B0", Length = "0x7")]
		[Token(Token = "0x600142A")]
		public DpadAxisControl() { }

		[Address(RVA = "0x290EB20", Offset = "0x290DF20", Length = "0x7B")]
		[Token(Token = "0x6001428")]
		protected virtual void FinishSetup() { }

		[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001426")]
		public int get_component() { }

		[Address(RVA = "0x290EBA0", Offset = "0x290DFA0", Length = "0x10C")]
		[Token(Token = "0x6001429")]
		public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

		[Address(RVA = "0x290ECC0", Offset = "0x290E0C0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001427")]
		public void set_component(int value) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000C1E")]
	private ButtonControl <up>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000C1F")]
	private ButtonControl <down>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000C20")]
	private ButtonControl <left>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000C21")]
	private ButtonControl <right>k__BackingField; //Field offset: 0x138

	[InputControl(bit = 1, displayName = "Down")]
	[Token(Token = "0x170005B8")]
	public ButtonControl down
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600141A")]
		 get { } //Length: 8
		[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600141B")]
		 set { } //Length: 19
	}

	[InputControl(bit = 2, displayName = "Left")]
	[Token(Token = "0x170005B9")]
	public ButtonControl left
	{
		[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600141C")]
		 get { } //Length: 8
		[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600141D")]
		 set { } //Length: 19
	}

	[InputControl(bit = 3, displayName = "Right")]
	[Token(Token = "0x170005BA")]
	public ButtonControl right
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600141E")]
		 get { } //Length: 8
		[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600141F")]
		 set { } //Length: 19
	}

	[InputControl(name = "x", layout = "DpadAxis", useStateFrom = "right", synthetic = True)]
	[InputControl(name = "y", layout = "DpadAxis", useStateFrom = "up", synthetic = True)]
	[InputControl(bit = 0, displayName = "Up")]
	[Token(Token = "0x170005B7")]
	public ButtonControl up
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001418")]
		 get { } //Length: 8
		[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001419")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x290F350", Offset = "0x290E750", Length = "0x65")]
	[Token(Token = "0x6001420")]
	public DpadControl() { }

	[Address(RVA = "0x290ECD0", Offset = "0x290E0D0", Length = "0x114")]
	[Token(Token = "0x6001421")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600141A")]
	public ButtonControl get_down() { }

	[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600141C")]
	public ButtonControl get_left() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600141E")]
	public ButtonControl get_right() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001418")]
	public ButtonControl get_up() { }

	[Address(RVA = "0x290EE10", Offset = "0x290E210", Length = "0x71")]
	[Token(Token = "0x6001424")]
	public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize = true) { }

	[Address(RVA = "0x290EDF0", Offset = "0x290E1F0", Length = "0x18")]
	[Token(Token = "0x6001425")]
	public static Vector2 MakeDpadVector(float up, float down, float left, float right) { }

	[Address(RVA = "0x290EE90", Offset = "0x290E290", Length = "0x2D3")]
	[Token(Token = "0x6001422")]
	public virtual Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600141B")]
	public void set_down(ButtonControl value) { }

	[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600141D")]
	public void set_left(ButtonControl value) { }

	[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600141F")]
	public void set_right(ButtonControl value) { }

	[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001419")]
	public void set_up(ButtonControl value) { }

	[Address(RVA = "0x290F170", Offset = "0x290E570", Length = "0x1D6")]
	[Token(Token = "0x6001423")]
	public virtual void WriteValueIntoState(Vector2 value, Void* statePtr) { }

}

