namespace KANAI.UI;

[Token(Token = "0x2000004")]
public enum ButtonState : int
{
	None = 0,
	Entering = 1,
	Pressing = 2,
	LongPress = 3,
	Repeating = 4,
	Invalid = 5,
}

