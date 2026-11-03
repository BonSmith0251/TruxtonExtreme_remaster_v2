namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001A7")]
public enum XblTournamentRegistrationReason : uint
{
	Unknown = 0,
	RegistrationClosed = 1,
	MemberAlreadyRegistered = 2,
	TournamentFull = 3,
	TeamEliminated = 4,
	TournamentCompleted = 5,
}

