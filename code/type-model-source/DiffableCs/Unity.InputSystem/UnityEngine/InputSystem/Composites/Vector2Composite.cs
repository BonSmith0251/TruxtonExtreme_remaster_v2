namespace UnityEngine.InputSystem.Composites;

[DisplayName("Up/Down/Left/Right Composite")]
[DisplayStringFormat("{up}/{left}/{down}/{right}")]
[Token(Token = "0x200027C")]
public class Vector2Composite : InputBindingComposite<Vector2>
{
	[Token(Token = "0x200027D")]
	internal enum Mode : int
	{
		Analog = 2,
		DigitalNormalized = 0,
		Digital = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000D2C")]
	public int up; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000D2D")]
	public int down; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000D2E")]
	public int left; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000D2F")]
	public int right; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Obsolete("Use Mode.DigitalNormalized with 'mode' instead")]
	[Token(Token = "0x4000D30")]
	public bool normalize; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000D31")]
	public Mode mode; //Field offset: 0x24

	[Address(RVA = "0x292B510", Offset = "0x292A910", Length = "0x3D")]
	[Token(Token = "0x60016E1")]
	public Vector2Composite() { }

	[Address(RVA = "0x292B300", Offset = "0x292A700", Length = "0x8F")]
	[Token(Token = "0x60016E0")]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x292B390", Offset = "0x292A790", Length = "0x17B")]
	[Token(Token = "0x60016DF")]
	public virtual Vector2 ReadValue(ref InputBindingCompositeContext context) { }

}

