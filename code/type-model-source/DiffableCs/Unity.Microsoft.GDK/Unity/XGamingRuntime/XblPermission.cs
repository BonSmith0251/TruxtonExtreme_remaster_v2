namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001BE")]
public enum XblPermission : uint
{
	Unknown = 0,
	CommunicateUsingText = 1000,
	CommunicateUsingVideo = 1001,
	CommunicateUsingVoice = 1002,
	ViewTargetProfile = 1004,
	ViewTargetGameHistory = 1005,
	ViewTargetVideoHistory = 1006,
	ViewTargetMusicHistory = 1007,
	ViewTargetExerciseInfo = 1009,
	ViewTargetPresence = 1011,
	ViewTargetVideoStatus = 1012,
	ViewTargetMusicStatus = 1013,
	PlayMultiplayer = 1014,
	ViewTargetUserCreatedContent = 1018,
	BroadcastWithTwitch = 1019,
	WriteComment = 1022,
	ShareItem = 1024,
	ShareTargetContentToExternalNetworks = 1025,
}

