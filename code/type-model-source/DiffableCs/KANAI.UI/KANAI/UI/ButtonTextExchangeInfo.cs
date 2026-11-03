namespace KANAI.UI;

[Token(Token = "0x2000006")]
public class ButtonTextExchangeInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000011")]
	public ButtonState _State; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000012")]
	public Color _Color; //Field offset: 0x14

	[Address(RVA = "0x1E16880", Offset = "0x1E15C80", Length = "0x13")]
	[Token(Token = "0x6000004")]
	public ButtonTextExchangeInfo() { }

}

