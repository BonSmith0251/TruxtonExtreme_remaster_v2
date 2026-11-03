namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001DB")]
public enum XblPresenceFilter : uint
{
	Unknown = 0,
	TitleOnline = 1,
	TitleOffline = 2,
	TitleOnlineOutsideTitle = 3,
	AllOnline = 4,
	AllOffline = 5,
	AllTitle = 6,
	All = 7,
}

