namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200016E")]
public enum XblMultiplayerInitializationStage : uint
{
	Unknown = 0,
	None = 1,
	Joining = 2,
	Measuring = 3,
	Evaluating = 4,
	Failed = 5,
}

