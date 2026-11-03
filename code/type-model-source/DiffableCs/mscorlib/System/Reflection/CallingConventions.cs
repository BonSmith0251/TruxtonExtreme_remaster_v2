namespace System.Reflection;

[Flags]
[Token(Token = "0x20004DA")]
public enum CallingConventions : int
{
	Standard = 1,
	VarArgs = 2,
	Any = 3,
	HasThis = 32,
	ExplicitThis = 64,
}

