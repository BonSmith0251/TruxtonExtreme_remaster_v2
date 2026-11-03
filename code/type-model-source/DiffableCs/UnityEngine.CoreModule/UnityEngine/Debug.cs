namespace UnityEngine;

[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
[NativeHeader("Runtime/Diagnostics/IntegrityCheck.h")]
[NativeHeader("Runtime/Diagnostics/Validation.h")]
[Token(Token = "0x20000B9")]
public class Debug
{
	[Token(Token = "0x4000215")]
	internal static readonly ILogger s_DefaultLogger; //Field offset: 0x0
	[Token(Token = "0x4000216")]
	internal static ILogger s_Logger; //Field offset: 0x8

	[Token(Token = "0x170000E3")]
	public static bool isDebugBuild
	{
		[Address(RVA = "0x2FDFB90", Offset = "0x2FDEF90", Length = "0x2A")]
		[Token(Token = "0x6000531")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000E2")]
	public static ILogger unityLogger
	{
		[Address(RVA = "0x2FDFBC0", Offset = "0x2FDEFC0", Length = "0x4F")]
		[Token(Token = "0x600051A")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x2FDFA80", Offset = "0x2FDEE80", Length = "0x107")]
	[Token(Token = "0x6000534")]
	private static Debug() { }

	[Address(RVA = "0x2FDE300", Offset = "0x2FDD700", Length = "0xC5")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x600052D")]
	public static void Assert(bool condition, string message) { }

	[Address(RVA = "0x2FDE220", Offset = "0x2FDD620", Length = "0xD0")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x600052C")]
	public static void Assert(bool condition) { }

	[Address(RVA = "0x2FDE140", Offset = "0x2FDD540", Length = "0xD7")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x600052E")]
	public static void AssertFormat(bool condition, string format, Object[] args) { }

	[Address(RVA = "0x2FDE3D0", Offset = "0x2FDD7D0", Length = "0x280")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000532")]
	internal static bool CallOverridenDebugHandler(Exception exception, object obj) { }

	[Address(RVA = "0x2FDE770", Offset = "0x2FDDB70", Length = "0xEC")]
	[ExcludeFromDocs]
	[Token(Token = "0x600051B")]
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[Address(RVA = "0x2FDE6D0", Offset = "0x2FDDAD0", Length = "0x9C")]
	[FreeFunction("DebugDrawLine", IsThreadSafe = True)]
	[Token(Token = "0x600051C")]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[Address(RVA = "0x2FDE660", Offset = "0x2FDDA60", Length = "0x6D")]
	[Token(Token = "0x6000535")]
	private static void DrawLine_Injected(in Vector3 start, in Vector3 end, in Color color, float duration, bool depthTest) { }

	[Address(RVA = "0x2FDE8B0", Offset = "0x2FDDCB0", Length = "0x1BD")]
	[ThreadSafe]
	[Token(Token = "0x600051D")]
	public static int ExtractStackTraceNoAlloc(Byte* buffer, int bufferMax, string projectFolder) { }

	[Address(RVA = "0x2FDE860", Offset = "0x2FDDC60", Length = "0x50")]
	[Token(Token = "0x6000536")]
	private static int ExtractStackTraceNoAlloc_Injected(Byte* buffer, int bufferMax, ref ManagedSpanWrapper projectFolder) { }

	[Address(RVA = "0x2FDFB90", Offset = "0x2FDEF90", Length = "0x2A")]
	[Token(Token = "0x6000531")]
	public static bool get_isDebugBuild() { }

	[Address(RVA = "0x2FDFBC0", Offset = "0x2FDEFC0", Length = "0x4F")]
	[Token(Token = "0x600051A")]
	public static ILogger get_unityLogger() { }

	[Address(RVA = "0x2FDEA70", Offset = "0x2FDDE70", Length = "0x164")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000533")]
	internal static bool IsLoggingEnabled() { }

	[Address(RVA = "0x2FDF9C0", Offset = "0x2FDEDC0", Length = "0xB2")]
	[Token(Token = "0x600051E")]
	public static void Log(object message) { }

	[Address(RVA = "0x2FDF8F0", Offset = "0x2FDECF0", Length = "0xC6")]
	[Token(Token = "0x600051F")]
	public static void Log(object message, object context) { }

	[Address(RVA = "0x2FDECB0", Offset = "0x2FDE0B0", Length = "0xB5")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x600052F")]
	public static void LogAssertion(object message) { }

	[Address(RVA = "0x2FDEBE0", Offset = "0x2FDDFE0", Length = "0xC6")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x6000530")]
	public static void LogAssertionFormat(string format, Object[] args) { }

	[Address(RVA = "0x2FDEF20", Offset = "0x2FDE320", Length = "0xC3")]
	[Token(Token = "0x6000523")]
	public static void LogError(object message, object context) { }

	[Address(RVA = "0x2FDEFF0", Offset = "0x2FDE3F0", Length = "0xB2")]
	[Token(Token = "0x6000522")]
	public static void LogError(object message) { }

	[Address(RVA = "0x2FDEE50", Offset = "0x2FDE250", Length = "0xC3")]
	[Token(Token = "0x6000524")]
	public static void LogErrorFormat(string format, Object[] args) { }

	[Address(RVA = "0x2FDED70", Offset = "0x2FDE170", Length = "0xD2")]
	[Token(Token = "0x6000525")]
	public static void LogErrorFormat(object context, string format, Object[] args) { }

	[Address(RVA = "0x2FDF0B0", Offset = "0x2FDE4B0", Length = "0xB6")]
	[Token(Token = "0x6000526")]
	public static void LogException(Exception exception) { }

	[Address(RVA = "0x2FDF170", Offset = "0x2FDE570", Length = "0xBE")]
	[Token(Token = "0x6000527")]
	public static void LogException(Exception exception, object context) { }

	[Address(RVA = "0x2FDF230", Offset = "0x2FDE630", Length = "0x2A6")]
	[Token(Token = "0x6000521")]
	public static void LogFormat(LogType logType, LogOption logOptions, object context, string format, Object[] args) { }

	[Address(RVA = "0x2FDF4E0", Offset = "0x2FDE8E0", Length = "0xC6")]
	[Token(Token = "0x6000520")]
	public static void LogFormat(string format, Object[] args) { }

	[Address(RVA = "0x2FDF760", Offset = "0x2FDEB60", Length = "0xC6")]
	[Token(Token = "0x6000529")]
	public static void LogWarning(object message, object context) { }

	[Address(RVA = "0x2FDF830", Offset = "0x2FDEC30", Length = "0xB5")]
	[Token(Token = "0x6000528")]
	public static void LogWarning(object message) { }

	[Address(RVA = "0x2FDF680", Offset = "0x2FDEA80", Length = "0xD5")]
	[Token(Token = "0x600052B")]
	public static void LogWarningFormat(object context, string format, Object[] args) { }

	[Address(RVA = "0x2FDF5B0", Offset = "0x2FDE9B0", Length = "0xC6")]
	[Token(Token = "0x600052A")]
	public static void LogWarningFormat(string format, Object[] args) { }

}

