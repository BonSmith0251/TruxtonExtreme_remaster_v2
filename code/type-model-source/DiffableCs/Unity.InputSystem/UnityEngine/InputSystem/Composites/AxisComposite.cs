namespace UnityEngine.InputSystem.Composites;

[DisplayName("Positive/Negative Binding")]
[DisplayStringFormat("{negative}/{positive}")]
[Token(Token = "0x2000272")]
public class AxisComposite : InputBindingComposite<Single>
{
	[Token(Token = "0x2000273")]
	internal enum WhichSideWins : int
	{
		Neither = 0,
		Positive = 1,
		Negative = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000CFB")]
	public int negative; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[InputControl(layout = "Axis")]
	[Token(Token = "0x4000CFC")]
	public int positive; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CFD")]
	[Tooltip("Value to return when the negative side is fully actuated.")]
	public float minValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000CFE")]
	[Tooltip("Value to return when the positive side is fully actuated.")]
	public float maxValue; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CFF")]
	[Tooltip("If both the positive and negative side are actuated, decides what value to return. 'Neither' (default) means that the resulting value is the midpoint between min and max. 'Positive' means that max will be returned. 'Negative' means that min will be returned.")]
	public WhichSideWins whichSideWins; //Field offset: 0x20

	[Token(Token = "0x17000618")]
	public float midPoint
	{
		[Address(RVA = "0x2921700", Offset = "0x2920B00", Length = "0x13")]
		[Token(Token = "0x60016C0")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x29216B0", Offset = "0x2920AB0", Length = "0x47")]
	[Token(Token = "0x60016C3")]
	public AxisComposite() { }

	[Address(RVA = "0x29214F0", Offset = "0x29208F0", Length = "0x9A")]
	[Token(Token = "0x60016C2")]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x2921700", Offset = "0x2920B00", Length = "0x13")]
	[Token(Token = "0x60016C0")]
	public float get_midPoint() { }

	[Address(RVA = "0x2921590", Offset = "0x2920990", Length = "0x11D")]
	[Token(Token = "0x60016C1")]
	public virtual float ReadValue(ref InputBindingCompositeContext context) { }

}

