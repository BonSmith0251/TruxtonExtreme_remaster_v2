namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000168")]
public enum XblMatchmakingStatus : uint
{
	Unknown = 0,
	None = 1,
	Searching = 2,
	Expired = 3,
	Found = 4,
	Canceled = 5,
}

