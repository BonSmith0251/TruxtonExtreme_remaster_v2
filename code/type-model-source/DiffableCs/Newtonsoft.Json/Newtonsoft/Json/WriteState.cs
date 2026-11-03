namespace Newtonsoft.Json;

[Token(Token = "0x200008E")]
public enum WriteState : int
{
	Error = 0,
	Closed = 1,
	Object = 2,
	Array = 3,
	Constructor = 4,
	Property = 5,
	Start = 6,
}

