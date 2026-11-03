namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001EC")]
public enum XblVerifyStringResultCode : uint
{
	Success = 0,
	Offensive = 1,
	TooLong = 2,
	UnknownError = 3,
}

