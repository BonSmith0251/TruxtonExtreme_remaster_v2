namespace DG.Tweening.Core;

[Token(Token = "0x20000A1")]
public static class Debugger
{
	[Token(Token = "0x20000A2")]
	public static class Sequence
	{

		[Address(RVA = "0x672F10", Offset = "0x672310", Length = "0x3C")]
		[Token(Token = "0x60003CC")]
		public static void LogAddAlreadySequencedTween(Tween t) { }

		[Address(RVA = "0x672F50", Offset = "0x672350", Length = "0x3C")]
		[Token(Token = "0x60003CB")]
		public static void LogAddInactiveTween(Tween t) { }

		[Address(RVA = "0x672F90", Offset = "0x672390", Length = "0x35")]
		[Token(Token = "0x60003CA")]
		public static void LogAddNullTween() { }

		[Address(RVA = "0x672FD0", Offset = "0x6723D0", Length = "0x35")]
		[Token(Token = "0x60003C8")]
		public static void LogAddToInactiveSequence() { }

		[Address(RVA = "0x673010", Offset = "0x672410", Length = "0x35")]
		[Token(Token = "0x60003C9")]
		public static void LogAddToLockedSequence() { }

		[Address(RVA = "0x673050", Offset = "0x672450", Length = "0x35")]
		[Token(Token = "0x60003C7")]
		public static void LogAddToNullSequence() { }

	}

	[Token(Token = "0x40001C2")]
	private static int _logPriority; //Field offset: 0x0
	[Token(Token = "0x40001C3")]
	private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN ► </b></color>"; //Field offset: 0x0

	[Token(Token = "0x1700000F")]
	public static int logPriority
	{
		[Address(RVA = "0x6697B0", Offset = "0x668BB0", Length = "0x35")]
		[Token(Token = "0x60003B4")]
		 get { } //Length: 53
	}

	[Address(RVA = "0x668900", Offset = "0x667D00", Length = "0x1C1")]
	[Token(Token = "0x60003C6")]
	private static void AddDebugDataToMessage(ref string message, Tween t) { }

	[Address(RVA = "0x6697B0", Offset = "0x668BB0", Length = "0x35")]
	[Token(Token = "0x60003B4")]
	public static int get_logPriority() { }

	[Address(RVA = "0x668AD0", Offset = "0x667ED0", Length = "0x4C")]
	[Token(Token = "0x60003C5")]
	private static string GetDebugDataMessage(Tween t) { }

	[Address(RVA = "0x6695A0", Offset = "0x6689A0", Length = "0x116")]
	[Token(Token = "0x60003B5")]
	public static void Log(object message) { }

	[Address(RVA = "0x668B20", Offset = "0x667F20", Length = "0x56")]
	[Token(Token = "0x60003C2")]
	public static void LogAddActiveTweenError(string errorInfo, Tween t) { }

	[Address(RVA = "0x668B80", Offset = "0x667F80", Length = "0x1BF")]
	[Token(Token = "0x60003B7")]
	public static void LogError(object message, Tween t = null) { }

	[Address(RVA = "0x668D40", Offset = "0x668140", Length = "0x35")]
	[Token(Token = "0x60003BB")]
	public static void LogInvalidTween(Tween t) { }

	[Address(RVA = "0x668DD0", Offset = "0x6681D0", Length = "0x5E")]
	[Token(Token = "0x60003C0")]
	public static void LogMissingMaterialProperty(int propertyId) { }

	[Address(RVA = "0x668D80", Offset = "0x668180", Length = "0x49")]
	[Token(Token = "0x60003BF")]
	public static void LogMissingMaterialProperty(string propertyName) { }

	[Address(RVA = "0x668E30", Offset = "0x668230", Length = "0x3C")]
	[Token(Token = "0x60003BC")]
	public static void LogNestedTween(Tween t) { }

	[Address(RVA = "0x668E70", Offset = "0x668270", Length = "0x3C")]
	[Token(Token = "0x60003BE")]
	public static void LogNonPathTween(Tween t) { }

	[Address(RVA = "0x668EB0", Offset = "0x6682B0", Length = "0x35")]
	[Token(Token = "0x60003BD")]
	public static void LogNullTween(Tween t) { }

	[Address(RVA = "0x668EF0", Offset = "0x6682F0", Length = "0x56")]
	[Token(Token = "0x60003C1")]
	public static void LogRemoveActiveTweenError(string errorInfo, Tween t) { }

	[Address(RVA = "0x668F50", Offset = "0x668350", Length = "0x103")]
	[Token(Token = "0x60003B9")]
	public static void LogReport(object message) { }

	[Address(RVA = "0x669060", Offset = "0x668460", Length = "0x251")]
	[Token(Token = "0x60003B8")]
	public static void LogSafeModeCapturedError(object message, Tween t = null) { }

	[Address(RVA = "0x6692C0", Offset = "0x6686C0", Length = "0x103")]
	[Token(Token = "0x60003BA")]
	public static void LogSafeModeReport(object message) { }

	[Address(RVA = "0x6693D0", Offset = "0x6687D0", Length = "0x1C2")]
	[Token(Token = "0x60003B6")]
	public static void LogWarning(object message, Tween t = null) { }

	[Address(RVA = "0x6696C0", Offset = "0x668AC0", Length = "0x5F")]
	[Token(Token = "0x60003C3")]
	public static void SetLogPriority(LogBehaviour logBehaviour) { }

	[Address(RVA = "0x669720", Offset = "0x668B20", Length = "0x85")]
	[Token(Token = "0x60003C4")]
	public static bool ShouldLogSafeModeCapturedError() { }

}

