namespace UnityEngine.Windows.Speech;

[Token(Token = "0x2000219")]
public enum SpeechError : int
{
	NoError = 0,
	TopicLanguageNotSupported = 1,
	GrammarLanguageMismatch = 2,
	GrammarCompilationFailure = 3,
	AudioQualityFailure = 4,
	PauseLimitExceeded = 5,
	TimeoutExceeded = 6,
	NetworkFailure = 7,
	MicrophoneUnavailable = 8,
	UnknownError = 9,
}

