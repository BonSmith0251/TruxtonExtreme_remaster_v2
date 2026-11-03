namespace UnityEngine.Windows.Speech;

[Token(Token = "0x200021A")]
public enum DictationCompletionCause : int
{
	Complete = 0,
	AudioQualityFailure = 1,
	Canceled = 2,
	TimeoutExceeded = 3,
	PauseLimitExceeded = 4,
	NetworkFailure = 5,
	MicrophoneUnavailable = 6,
	UnknownError = 7,
}

