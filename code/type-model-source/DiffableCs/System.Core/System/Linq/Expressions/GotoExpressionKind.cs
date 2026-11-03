namespace System.Linq.Expressions;

[Token(Token = "0x2000081")]
public enum GotoExpressionKind : int
{
	Goto = 0,
	Return = 1,
	Break = 2,
	Continue = 3,
}

