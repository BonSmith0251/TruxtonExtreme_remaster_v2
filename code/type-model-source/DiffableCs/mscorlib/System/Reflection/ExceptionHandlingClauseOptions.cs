namespace System.Reflection;

[Flags]
[Token(Token = "0x20004E1")]
public enum ExceptionHandlingClauseOptions : int
{
	Clause = 0,
	Filter = 1,
	Finally = 2,
	Fault = 4,
}

