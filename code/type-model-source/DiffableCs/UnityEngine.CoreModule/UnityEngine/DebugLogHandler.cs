namespace UnityEngine;

[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
[Token(Token = "0x20000B8")]
internal sealed class DebugLogHandler : ILogHandler
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000517")]
	public DebugLogHandler() { }

	[Address(RVA = "0x2FDDE00", Offset = "0x2FDD200", Length = "0x1C8")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6000512")]
	internal static void Internal_Log(LogType level, LogOption options, string msg, object obj) { }

	[Address(RVA = "0x2FDDDA0", Offset = "0x2FDD1A0", Length = "0x5E")]
	[Token(Token = "0x6000518")]
	private static void Internal_Log_Injected(LogType level, LogOption options, ref ManagedSpanWrapper msg, IntPtr obj) { }

	[Address(RVA = "0x2FDDD20", Offset = "0x2FDD120", Length = "0x7A")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6000513")]
	internal static void Internal_LogException(Exception ex, object obj) { }

	[Address(RVA = "0x2FDDCD0", Offset = "0x2FDD0D0", Length = "0x42")]
	[Token(Token = "0x6000519")]
	private static void Internal_LogException_Injected(Exception ex, IntPtr obj) { }

	[Address(RVA = "0x2FDDFD0", Offset = "0x2FDD3D0", Length = "0xC7")]
	[Token(Token = "0x6000516")]
	public override void LogException(Exception exception, object context) { }

	[Address(RVA = "0x2FDE0A0", Offset = "0x2FDD4A0", Length = "0x41")]
	[Token(Token = "0x6000514")]
	public override void LogFormat(LogType logType, object context, string format, Object[] args) { }

	[Address(RVA = "0x2FDE0F0", Offset = "0x2FDD4F0", Length = "0x50")]
	[Token(Token = "0x6000515")]
	public void LogFormat(LogType logType, LogOption logOptions, object context, string format, Object[] args) { }

}

