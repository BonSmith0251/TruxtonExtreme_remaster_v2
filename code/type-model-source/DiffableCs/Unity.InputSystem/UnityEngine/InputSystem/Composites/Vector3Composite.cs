namespace UnityEngine.InputSystem.Composites;

[DisplayName("Up/Down/Left/Right/Forward/Backward Composite")]
[DisplayStringFormat("{up}+{down}/{left}+{right}/{forward}+{backward}")]
[Token(Token = "0x200027E")]
public class Vector3Composite : InputBindingComposite<Vector3>
{
	[Token(Token = "0x200027F")]
	internal enum Mode : int
	{
		Analog = 0,
		DigitalNormalized = 1,
		Digital = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000D36")]
	public int up; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000D37")]
	public int down; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000D38")]
	public int left; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000D39")]
	public int right; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000D3A")]
	public int forward; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000D3B")]
	public int backward; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D3C")]
	public Mode mode; //Field offset: 0x28

	[Address(RVA = "0x292B840", Offset = "0x292AC40", Length = "0x54F")]
	[Token(Token = "0x60016E4")]
	public Vector3Composite() { }

	[Address(RVA = "0x292B550", Offset = "0x292A950", Length = "0x44")]
	[Token(Token = "0x60016E3")]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x292B5A0", Offset = "0x292A9A0", Length = "0x2A0")]
	[Token(Token = "0x60016E2")]
	public virtual Vector3 ReadValue(ref InputBindingCompositeContext context) { }

}

