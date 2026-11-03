namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x2000649")]
internal enum ExpressionCombinator : int
{
	None = 0,
	Or = 1,
	OrOr = 2,
	AndAnd = 3,
	Juxtaposition = 4,
	Group = 5,
}

