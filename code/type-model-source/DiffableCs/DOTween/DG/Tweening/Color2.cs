namespace DG.Tweening;

[Token(Token = "0x2000004")]
public struct Color2
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000C")]
	public Color ca; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000D")]
	public Color cb; //Field offset: 0x10

	[Address(RVA = "0x648E10", Offset = "0x648210", Length = "0xF")]
	[Token(Token = "0x6000001")]
	public Color2(Color ca, Color cb) { }

	[Address(RVA = "0x648E20", Offset = "0x648220", Length = "0x105")]
	[Token(Token = "0x6000002")]
	public static Color2 op_Addition(Color2 c1, Color2 c2) { }

	[Address(RVA = "0x648F30", Offset = "0x648330", Length = "0xC9")]
	[Token(Token = "0x6000004")]
	public static Color2 op_Multiply(Color2 c1, float f) { }

	[Address(RVA = "0x649000", Offset = "0x648400", Length = "0x106")]
	[Token(Token = "0x6000003")]
	public static Color2 op_Subtraction(Color2 c1, Color2 c2) { }

}

