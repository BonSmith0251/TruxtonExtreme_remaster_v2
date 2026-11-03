namespace KANAI.UI;

[Token(Token = "0x2000005")]
public class ButtonImageExchangeInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000D")]
	public ButtonState _State; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000E")]
	public Image _Target; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000F")]
	public Sprite _PoolSprite; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000010")]
	public Color _Color; //Field offset: 0x28

	[Address(RVA = "0x1E16850", Offset = "0x1E15C50", Length = "0x13")]
	[Token(Token = "0x6000003")]
	public ButtonImageExchangeInfo() { }

}

