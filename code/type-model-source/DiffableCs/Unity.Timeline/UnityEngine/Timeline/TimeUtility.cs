namespace UnityEngine.Timeline;

[Token(Token = "0x2000080")]
internal static class TimeUtility
{
	[CompilerGenerated]
	[Token(Token = "0x2000081")]
	private sealed class <>c
	{
		[Token(Token = "0x4000197")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000198")]
		public static Func<Char, Boolean> <>9__19_0; //Field offset: 0x8
		[Token(Token = "0x4000199")]
		public static Func<Char, Boolean> <>9__19_1; //Field offset: 0x10
		[Token(Token = "0x400019A")]
		public static Func<Char, Boolean> <>9__20_0; //Field offset: 0x18

		[Address(RVA = "0x2F4A6D0", Offset = "0x2F49AD0", Length = "0x67")]
		[Token(Token = "0x6000390")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000391")]
		public <>c() { }

		[Address(RVA = "0x2F4A5B0", Offset = "0x2F499B0", Length = "0x2D")]
		[Token(Token = "0x6000392")]
		internal bool <ParseTimeCode>b__19_0(char c) { }

		[Address(RVA = "0x2F4A5E0", Offset = "0x2F499E0", Length = "0x11")]
		[Token(Token = "0x6000393")]
		internal bool <ParseTimeCode>b__19_1(char c) { }

		[Address(RVA = "0x2F4A5B0", Offset = "0x2F499B0", Length = "0x2D")]
		[Token(Token = "0x6000394")]
		internal bool <ParseTimeSeconds>b__20_0(char c) { }

	}

	[Token(Token = "0x4000193")]
	public static readonly double kTimeEpsilon; //Field offset: 0x0
	[Token(Token = "0x4000194")]
	public static readonly double kFrameRateEpsilon; //Field offset: 0x8
	[Token(Token = "0x4000195")]
	public static readonly double k_MaxTimelineDurationInSeconds; //Field offset: 0x10
	[Token(Token = "0x4000196")]
	public static readonly double kFrameRateRounding; //Field offset: 0x18

	[Address(RVA = "0x2F46390", Offset = "0x2F45790", Length = "0x94")]
	[Token(Token = "0x600038F")]
	private static TimeUtility() { }

	[Address(RVA = "0x2F44020", Offset = "0x2F43420", Length = "0x62")]
	[Token(Token = "0x600037C")]
	public static double FromFrames(int frames, double frameRate) { }

	[Address(RVA = "0x2F44090", Offset = "0x2F43490", Length = "0x65")]
	[Token(Token = "0x600037D")]
	public static double FromFrames(double frames, double frameRate) { }

	[Address(RVA = "0x2F44100", Offset = "0x2F43500", Length = "0x18F")]
	[Token(Token = "0x600038A")]
	public static double GetAnimationClipLength(AnimationClip clip) { }

	[Address(RVA = "0x2F44290", Offset = "0x2F43690", Length = "0xFB")]
	[Token(Token = "0x600038C")]
	public static FrameRate GetClosestFrameRate(double frameRate) { }

	[Address(RVA = "0x2F44390", Offset = "0x2F43790", Length = "0xAE")]
	[Token(Token = "0x600037F")]
	public static double GetEpsilon(double time, double frameRate) { }

	[Address(RVA = "0x2F44520", Offset = "0x2F43920", Length = "0x64")]
	[Token(Token = "0x6000381")]
	public static int NextFrame(double time, double frameRate) { }

	[Address(RVA = "0x2F44440", Offset = "0x2F43840", Length = "0xE0")]
	[Token(Token = "0x6000383")]
	public static double NextFrameTime(double time, double frameRate) { }

	[Address(RVA = "0x2F44590", Offset = "0x2F43990", Length = "0x168")]
	[Token(Token = "0x6000384")]
	public static bool OnFrameBoundary(double time, double frameRate, double epsilon) { }

	[Address(RVA = "0x2F44700", Offset = "0x2F43B00", Length = "0x1A7")]
	[Token(Token = "0x600037E")]
	public static bool OnFrameBoundary(double time, double frameRate) { }

	[Address(RVA = "0x2F448B0", Offset = "0x2F43CB0", Length = "0x5B7")]
	[Token(Token = "0x6000388")]
	public static double ParseTimeCode(string timeCode, double frameRate, double defaultValue) { }

	[Address(RVA = "0x2F44E70", Offset = "0x2F44270", Length = "0x40E")]
	[Token(Token = "0x6000389")]
	public static double ParseTimeSeconds(string timeCode, double frameRate, double defaultValue) { }

	[Address(RVA = "0x2F45390", Offset = "0x2F44790", Length = "0x94")]
	[Token(Token = "0x6000380")]
	public static int PreviousFrame(double time, double frameRate) { }

	[Address(RVA = "0x2F45280", Offset = "0x2F44680", Length = "0x10F")]
	[Token(Token = "0x6000382")]
	public static double PreviousFrameTime(double time, double frameRate) { }

	[Address(RVA = "0x2F45430", Offset = "0x2F44830", Length = "0xF2")]
	[Token(Token = "0x600038B")]
	private static string RemoveChar(string str, Func<Char, Boolean> charToRemoveFunc) { }

	[Address(RVA = "0x2F45530", Offset = "0x2F44930", Length = "0xE8")]
	[Token(Token = "0x6000385")]
	public static double RoundToFrame(double time, double frameRate) { }

	[Address(RVA = "0x2F45620", Offset = "0x2F44A20", Length = "0x123")]
	[Token(Token = "0x6000386")]
	public static string TimeAsFrames(double timeValue, double frameRate, string format = "F2") { }

	[Address(RVA = "0x2F45750", Offset = "0x2F44B50", Length = "0x4CE")]
	[Token(Token = "0x6000387")]
	public static string TimeAsTimeCode(double timeValue, double frameRate, string format = "F2") { }

	[Address(RVA = "0x2F45C20", Offset = "0x2F45020", Length = "0x65")]
	[Token(Token = "0x600037B")]
	public static double ToExactFrames(double time, double frameRate) { }

	[Address(RVA = "0x2F45C90", Offset = "0x2F45090", Length = "0x38")]
	[Token(Token = "0x600038D")]
	public static FrameRate ToFrameRate(StandardFrameRates enumValue) { }

	[Address(RVA = "0x2F45E70", Offset = "0x2F45270", Length = "0x136")]
	[Token(Token = "0x600037A")]
	public static int ToFrames(double time, double frameRate) { }

	[Address(RVA = "0x2F45FB0", Offset = "0x2F453B0", Length = "0x311")]
	[Token(Token = "0x600038E")]
	internal static bool ToStandardFrameRate(FrameRate rate, out StandardFrameRates standard) { }

	[Address(RVA = "0x2F462D0", Offset = "0x2F456D0", Length = "0xB4")]
	[Token(Token = "0x6000379")]
	private static void ValidateFrameRate(double frameRate) { }

}

