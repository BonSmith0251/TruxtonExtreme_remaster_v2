namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000195")]
public enum XblMultiplayerMatchStatus : uint
{
	None = 0,
	SubmittingMatchTicket = 1,
	Searching = 2,
	Found = 3,
	Joining = 4,
	WaitingForRemoteClientsToJoin = 5,
	Measuring = 6,
	UploadingQosMeasurements = 7,
	WaitingForRemoteClientsToUploadQos = 8,
	Evaluating = 9,
	Completed = 10,
	Resubmitting = 11,
	Expired = 12,
	Canceling = 13,
	Canceled = 14,
	Failed = 15,
}

