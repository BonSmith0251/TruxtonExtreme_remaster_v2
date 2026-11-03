namespace System.Text.RegularExpressions;

[Flags]
[Token(Token = "0x20000EF")]
public enum RegexOptions : int
{
	None = 0,
	IgnoreCase = 1,
	Multiline = 2,
	ExplicitCapture = 4,
	Compiled = 8,
	Singleline = 16,
	IgnorePatternWhitespace = 32,
	RightToLeft = 64,
	ECMAScript = 256,
	CultureInvariant = 512,
}

