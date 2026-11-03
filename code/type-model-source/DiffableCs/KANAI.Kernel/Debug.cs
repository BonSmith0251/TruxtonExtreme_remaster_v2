//Type is in global namespace

[Token(Token = "0x2000002")]
public static class Debug
{

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x6000005")]
	public static void Assert(object flag) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x6000006")]
	public static void Assert(object flag, object message) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x6000007")]
	public static void AssertFormat(bool condition, string format, Object[] args) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x6000001")]
	public static void Log(object message) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x6000008")]
	public static void LogAssertion(object message) { }

	[Address(RVA = "0x1DE7A90", Offset = "0x1DE6E90", Length = "0x49")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x6000003")]
	public static void LogError(object message) { }

	[Address(RVA = "0x1DE7A30", Offset = "0x1DE6E30", Length = "0x59")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x6000004")]
	public static void LogError(object message, object context) { }

	[Address(RVA = "0x1DE7960", Offset = "0x1DE6D60", Length = "0x59")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x600000F")]
	public static void LogErrorFormat(string format, Object[] args) { }

	[Address(RVA = "0x1DE79C0", Offset = "0x1DE6DC0", Length = "0x69")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x6000010")]
	public static void LogErrorFormat(object obj, string format, Object[] args) { }

	[Address(RVA = "0x1DE7AE0", Offset = "0x1DE6EE0", Length = "0x49")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x6000009")]
	public static void LogException(Exception exp) { }

	[Address(RVA = "0x1DE7B30", Offset = "0x1DE6F30", Length = "0x59")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x600000A")]
	public static void LogException(Exception exp, object context) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x600000B")]
	public static void LogFormat(string format, Object[] args) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x600000C")]
	public static void LogFormat(object obj, string format, Object[] args) { }

	[Address(RVA = "0x1DE7B90", Offset = "0x1DE6F90", Length = "0x59")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x600000D")]
	public static void LogWarnigFormat(string format, Object[] args) { }

	[Address(RVA = "0x1DE7C60", Offset = "0x1DE7060", Length = "0x49")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x6000002")]
	public static void LogWarning(object message) { }

	[Address(RVA = "0x1DE7BF0", Offset = "0x1DE6FF0", Length = "0x69")]
	[Conditional("NEVER_DEFINE_SYMBOL")]
	[Token(Token = "0x600000E")]
	public static void LogWarningFormat(object obj, string format, Object[] args) { }

}

