namespace Unity.XGamingRuntime;

[Flags]
[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000173")]
public enum XblMultiplayerSessionChangeTypes : uint
{
	None = 0,
	Everything = 1,
	HostDeviceTokenChange = 2,
	InitializationStateChange = 4,
	MatchmakingStatusChange = 8,
	MemberListChange = 16,
	MemberStatusChange = 32,
	SessionJoinabilityChange = 64,
	CustomPropertyChange = 128,
	MemberCustomPropertyChange = 256,
	TournamentPropertyChange = 512,
	ArbitrationPropertyChange = 1024,
}

