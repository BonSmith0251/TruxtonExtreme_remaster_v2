namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001D1")]
public enum XblReputationFeedbackType : uint
{
	FairPlayKillsTeammates = 0,
	FairPlayCheater = 1,
	FairPlayTampering = 2,
	FairPlayQuitter = 3,
	FairPlayKicked = 4,
	CommunicationsInappropriateVideo = 5,
	CommunicationsAbusiveVoice = 6,
	InappropriateUserGeneratedContent = 7,
	PositiveSkilledPlayer = 8,
	PositiveHelpfulPlayer = 9,
	PositiveHighQualityUserGeneratedContent = 10,
	CommsPhishing = 11,
	CommsPictureMessage = 12,
	CommsSpam = 13,
	CommsTextMessage = 14,
	CommsVoiceMessage = 15,
	FairPlayConsoleBanRequest = 16,
	FairPlayIdler = 17,
	FairPlayUserBanRequest = 18,
	UserContentGamerpic = 19,
	UserContentPersonalInfo = 20,
	FairPlayUnsporting = 21,
	FairPlayLeaderboardCheater = 22,
}

