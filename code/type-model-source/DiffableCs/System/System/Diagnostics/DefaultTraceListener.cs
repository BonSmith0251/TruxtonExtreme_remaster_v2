namespace System.Diagnostics;

[Token(Token = "0x200010E")]
public class DefaultTraceListener : TraceListener
{
	[Token(Token = "0x40004BE")]
	private static readonly bool OnWin32; //Field offset: 0x0
	[Token(Token = "0x40004BF")]
	private static readonly string MonoTracePrefix; //Field offset: 0x8
	[Token(Token = "0x40004C0")]
	private static readonly string MonoTraceFile; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004C1")]
	private string logFileName; //Field offset: 0x38

	[MonoTODO]
	[Token(Token = "0x17000106")]
	public string LogFileName
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000676")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x262D240", Offset = "0x262C640", Length = "0x1D8")]
	[Token(Token = "0x6000673")]
	private static DefaultTraceListener() { }

	[Address(RVA = "0x262D420", Offset = "0x262C820", Length = "0x5F")]
	[Token(Token = "0x6000675")]
	public DefaultTraceListener() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000676")]
	public string get_LogFileName() { }

	[Address(RVA = "0x262CB20", Offset = "0x262BF20", Length = "0x6D")]
	[Token(Token = "0x6000674")]
	private static string GetPrefix(string var, string target) { }

	[Address(RVA = "0x262D230", Offset = "0x262C630", Length = "0x8")]
	[Token(Token = "0x600067D")]
	public virtual void Write(string message) { }

	[Address(RVA = "0x262CB90", Offset = "0x262BF90", Length = "0xA5")]
	[Token(Token = "0x6000678")]
	private void WriteDebugString(string message) { }

	[Address(RVA = "0x262CC40", Offset = "0x262C040", Length = "0x1B6")]
	[Token(Token = "0x600067B")]
	private void WriteImpl(string message) { }

	[Address(RVA = "0x262CE00", Offset = "0x262C200", Length = "0x42")]
	[Token(Token = "0x600067E")]
	public virtual void WriteLine(string message) { }

	[Address(RVA = "0x262CE50", Offset = "0x262C250", Length = "0x15D")]
	[Token(Token = "0x600067C")]
	private void WriteLogFile(string message, string logFile) { }

	[Address(RVA = "0x262CFB0", Offset = "0x262C3B0", Length = "0x1DF")]
	[Token(Token = "0x6000679")]
	private void WriteMonoTrace(string message) { }

	[Address(RVA = "0x262D190", Offset = "0x262C590", Length = "0x89")]
	[Token(Token = "0x600067A")]
	private void WritePrefix() { }

	[Address(RVA = "0x262D220", Offset = "0x262C620", Length = "0x5")]
	[Token(Token = "0x6000677")]
	private static void WriteWindowsDebugString(Char* message) { }

}

