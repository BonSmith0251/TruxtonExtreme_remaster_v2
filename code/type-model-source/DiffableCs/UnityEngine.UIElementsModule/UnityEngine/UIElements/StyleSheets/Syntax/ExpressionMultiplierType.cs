namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x200064A")]
internal enum ExpressionMultiplierType : int
{
	None = 0,
	ZeroOrMore = 1,
	OneOrMore = 2,
	ZeroOrOne = 3,
	Ranges = 4,
	OneOrMoreComma = 5,
	GroupAtLeastOne = 6,
}

