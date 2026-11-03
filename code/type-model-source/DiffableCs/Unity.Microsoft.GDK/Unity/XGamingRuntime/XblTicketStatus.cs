namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200016B")]
public enum XblTicketStatus : int
{
	Unknown = 0,
	Expired = 1,
	Searching = 2,
	Found = 3,
	Canceled = 4,
}

