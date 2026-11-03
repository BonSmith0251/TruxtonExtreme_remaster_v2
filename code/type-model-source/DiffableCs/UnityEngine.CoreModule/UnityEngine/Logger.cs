namespace UnityEngine;

[Token(Token = "0x200014A")]
public class Logger : ILogger, ILogHandler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000572")]
	private ILogHandler <logHandler>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000573")]
	private bool <logEnabled>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000574")]
	private LogType <filterLogType>k__BackingField; //Field offset: 0x1C

	[Token(Token = "0x17000273")]
	public override LogType filterLogType
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000FCB")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000FCC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000272")]
	public override bool logEnabled
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000FC9")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000FCA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000271")]
	public override ILogHandler logHandler
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000FC7")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000FC8")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x304A390", Offset = "0x3049790", Length = "0x3D")]
	[Token(Token = "0x6000FC6")]
	public Logger(ILogHandler logHandler) { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000FCB")]
	public override LogType get_filterLogType() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000FC9")]
	public override bool get_logEnabled() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000FC7")]
	public override ILogHandler get_logHandler() { }

	[Address(RVA = "0x3049C30", Offset = "0x3049030", Length = "0x126")]
	[Token(Token = "0x6000FCE")]
	private static string GetString(object message) { }

	[Address(RVA = "0x3049D60", Offset = "0x3049160", Length = "0x1E")]
	[Token(Token = "0x6000FCD")]
	public override bool IsLogTypeAllowed(LogType logType) { }

	[Address(RVA = "0x304A120", Offset = "0x3049520", Length = "0x12A")]
	[Token(Token = "0x6000FCF")]
	public override void Log(LogType logType, object message) { }

	[Address(RVA = "0x304A250", Offset = "0x3049650", Length = "0x139")]
	[Token(Token = "0x6000FD0")]
	public override void Log(LogType logType, object message, object context) { }

	[Address(RVA = "0x3049D80", Offset = "0x3049180", Length = "0x172")]
	[Token(Token = "0x6000FD1")]
	public override void LogError(string tag, object message) { }

	[Address(RVA = "0x3049F00", Offset = "0x3049300", Length = "0xDB")]
	[Token(Token = "0x6000FD2")]
	public override void LogException(Exception exception, object context) { }

	[Address(RVA = "0x3049FE0", Offset = "0x30493E0", Length = "0x94")]
	[Token(Token = "0x6000FD3")]
	public override void LogFormat(LogType logType, string format, Object[] args) { }

	[Address(RVA = "0x304A080", Offset = "0x3049480", Length = "0x99")]
	[Token(Token = "0x6000FD4")]
	public override void LogFormat(LogType logType, object context, string format, Object[] args) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000FCC")]
	public override void set_filterLogType(LogType value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000FCA")]
	public override void set_logEnabled(bool value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000FC8")]
	public override void set_logHandler(ILogHandler value) { }

}

