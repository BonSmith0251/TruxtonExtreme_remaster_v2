namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001A8")]
public enum XblTournamentRegistrationState : uint
{
	Unknown = 0,
	Pending = 1,
	Withdrawn = 2,
	Rejected = 3,
	Registered = 4,
	Completed = 5,
}

