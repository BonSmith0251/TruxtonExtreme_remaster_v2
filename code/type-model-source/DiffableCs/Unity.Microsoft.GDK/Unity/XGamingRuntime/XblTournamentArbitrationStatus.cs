namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000186")]
public enum XblTournamentArbitrationStatus : uint
{
	Waiting = 0,
	InProgress = 1,
	Complete = 2,
	Playing = 3,
	Incomplete = 4,
	Joining = 5,
}

