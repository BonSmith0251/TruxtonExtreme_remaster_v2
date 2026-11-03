namespace Unity.XGamingRuntime;

[Token(Token = "0x200020C")]
public enum XErrorOptions : uint
{
	None = 0,
	OutputDebugStringOnError = 1,
	DebugBreakOnError = 2,
	FailFastOnError = 4,
}

