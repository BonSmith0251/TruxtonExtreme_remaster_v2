namespace System.Xml;

[Token(Token = "0x2000080")]
public enum WriteState : int
{
	Start = 0,
	Prolog = 1,
	Element = 2,
	Attribute = 3,
	Content = 4,
	Closed = 5,
	Error = 6,
}

