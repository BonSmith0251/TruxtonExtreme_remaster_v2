namespace Unity.XGamingRuntime;

[Token(Token = "0x200013A")]
public enum XAsyncOp : uint
{
	Begin = 0,
	DoWork = 1,
	GetResult = 2,
	Cancel = 3,
	Cleanup = 4,
}

