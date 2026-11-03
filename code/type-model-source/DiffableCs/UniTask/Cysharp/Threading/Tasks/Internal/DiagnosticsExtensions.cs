namespace Cysharp.Threading.Tasks.Internal;

[Extension]
[Token(Token = "0x200020D")]
internal static class DiagnosticsExtensions
{
	[CompilerGenerated]
	[Token(Token = "0x200020E")]
	private sealed class <>c
	{
		[Token(Token = "0x40005B4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40005B5")]
		public static Func<ParameterInfo, String> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x40005B6")]
		public static Func<Type, String> <>9__6_0; //Field offset: 0x10
		[Token(Token = "0x40005B7")]
		public static Func<Type, String> <>9__6_1; //Field offset: 0x18

		[Address(RVA = "0x278D300", Offset = "0x278C700", Length = "0x67")]
		[Token(Token = "0x6000BF5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BF6")]
		public <>c() { }

		[Address(RVA = "0x278CAB0", Offset = "0x278BEB0", Length = "0x4C")]
		[Token(Token = "0x6000BF8")]
		internal string <BeautifyType>b__6_0(Type x) { }

		[Address(RVA = "0x278CB00", Offset = "0x278BF00", Length = "0x4C")]
		[Token(Token = "0x6000BF9")]
		internal string <BeautifyType>b__6_1(Type x) { }

		[Address(RVA = "0x278CB50", Offset = "0x278BF50", Length = "0xB4")]
		[Token(Token = "0x6000BF7")]
		internal string <CleanupAsyncStackTrace>b__3_0(ParameterInfo p) { }

	}

	[Token(Token = "0x40005B1")]
	private static bool displayFilenames; //Field offset: 0x0
	[Token(Token = "0x40005B2")]
	private static readonly Regex typeBeautifyRegex; //Field offset: 0x8
	[Token(Token = "0x40005B3")]
	private static readonly Dictionary<Type, String> builtInTypeNames; //Field offset: 0x10

	[Address(RVA = "0x27885F0", Offset = "0x27879F0", Length = "0x576")]
	[Token(Token = "0x6000BF4")]
	private static DiagnosticsExtensions() { }

	[Address(RVA = "0x2786E50", Offset = "0x2786250", Length = "0x31E")]
	[Token(Token = "0x6000BF3")]
	private static string AppendHyperLink(string path, string line) { }

	[Address(RVA = "0x2787170", Offset = "0x2786570", Length = "0x62C")]
	[Token(Token = "0x6000BF1")]
	private static string BeautifyType(Type t, bool shortName) { }

	[Address(RVA = "0x27877A0", Offset = "0x2786BA0", Length = "0x8DE")]
	[Extension]
	[Token(Token = "0x6000BEE")]
	public static string CleanupAsyncStackTrace(StackTrace stackTrace) { }

	[Address(RVA = "0x2788080", Offset = "0x2787480", Length = "0x169")]
	[Token(Token = "0x6000BF2")]
	private static bool IgnoreLine(MethodBase methodInfo) { }

	[Address(RVA = "0x27881F0", Offset = "0x27875F0", Length = "0x9C")]
	[Token(Token = "0x6000BEF")]
	private static bool IsAsync(MethodBase methodInfo) { }

	[Address(RVA = "0x2788290", Offset = "0x2787690", Length = "0x35F")]
	[Token(Token = "0x6000BF0")]
	private static bool TryResolveStateMachineMethod(ref MethodBase method, out Type declaringType) { }

}

