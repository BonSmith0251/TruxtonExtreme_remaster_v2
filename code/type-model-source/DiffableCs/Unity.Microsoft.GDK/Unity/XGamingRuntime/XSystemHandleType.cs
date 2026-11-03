namespace Unity.XGamingRuntime;

[Token(Token = "0x200027C")]
public enum XSystemHandleType : uint
{
	AppCaptureScreenshotStream = 0,
	DisplayTimeoutDeferral = 1,
	GameSaveContainer = 2,
	GameSaveProvider = 3,
	GameSaveUpdate = 4,
	PackageInstallationMonitor = 5,
	PackageMount = 6,
	SpeechSynthesizer = 7,
	SpeechSynthesizerStream = 8,
	StoreContext = 9,
	StoreLicense = 10,
	StoreProductQuery = 11,
	TaskQueue = 12,
	User = 13,
	UserSignOutDeferral = 14,
	GameUiTextEntry = 15,
}

