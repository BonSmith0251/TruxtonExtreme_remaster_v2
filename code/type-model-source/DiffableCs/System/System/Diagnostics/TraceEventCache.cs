namespace System.Diagnostics;

[Token(Token = "0x20000FD")]
public class TraceEventCache
{
	[Token(Token = "0x400045D")]
	private static int processId; //Field offset: 0x0
	[Token(Token = "0x400045E")]
	private static string processName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400045F")]
	private long timeStamp; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000460")]
	private DateTime dateTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000461")]
	private string stackTrace; //Field offset: 0x20

	[Token(Token = "0x170000EB")]
	public string Callstack
	{
		[Address(RVA = "0x263E220", Offset = "0x263D620", Length = "0x3B")]
		[Token(Token = "0x6000623")]
		 get { } //Length: 59
	}

	[Token(Token = "0x170000ED")]
	public DateTime DateTime
	{
		[Address(RVA = "0x263E260", Offset = "0x263D660", Length = "0x95")]
		[Token(Token = "0x6000625")]
		 get { } //Length: 149
	}

	[Token(Token = "0x170000EC")]
	public Stack LogicalOperationStack
	{
		[Address(RVA = "0x263E300", Offset = "0x263D700", Length = "0x14B")]
		[Token(Token = "0x6000624")]
		 get { } //Length: 331
	}

	[Token(Token = "0x170000EE")]
	public int ProcessId
	{
		[Address(RVA = "0x263DF00", Offset = "0x263D300", Length = "0x46")]
		[Token(Token = "0x6000626")]
		 get { } //Length: 70
	}

	[Token(Token = "0x170000EF")]
	public string ThreadId
	{
		[Address(RVA = "0x263E450", Offset = "0x263D850", Length = "0x78")]
		[Token(Token = "0x6000627")]
		 get { } //Length: 120
	}

	[Token(Token = "0x170000F0")]
	public long Timestamp
	{
		[Address(RVA = "0x263E4D0", Offset = "0x263D8D0", Length = "0x54")]
		[Token(Token = "0x6000628")]
		 get { } //Length: 84
	}

	[Address(RVA = "0x263E1B0", Offset = "0x263D5B0", Length = "0x6A")]
	[Token(Token = "0x600062C")]
	public TraceEventCache() { }

	[Address(RVA = "0x263E220", Offset = "0x263D620", Length = "0x3B")]
	[Token(Token = "0x6000623")]
	public string get_Callstack() { }

	[Address(RVA = "0x263E260", Offset = "0x263D660", Length = "0x95")]
	[Token(Token = "0x6000625")]
	public DateTime get_DateTime() { }

	[Address(RVA = "0x263E300", Offset = "0x263D700", Length = "0x14B")]
	[Token(Token = "0x6000624")]
	public Stack get_LogicalOperationStack() { }

	[Address(RVA = "0x263DF00", Offset = "0x263D300", Length = "0x46")]
	[Token(Token = "0x6000626")]
	public int get_ProcessId() { }

	[Address(RVA = "0x263E450", Offset = "0x263D850", Length = "0x78")]
	[Token(Token = "0x6000627")]
	public string get_ThreadId() { }

	[Address(RVA = "0x263E4D0", Offset = "0x263D8D0", Length = "0x54")]
	[Token(Token = "0x6000628")]
	public long get_Timestamp() { }

	[Address(RVA = "0x263DF00", Offset = "0x263D300", Length = "0x46")]
	[Token(Token = "0x600062A")]
	internal static int GetProcessId() { }

	[Address(RVA = "0x20810E0", Offset = "0x20804E0", Length = "0x23")]
	[Token(Token = "0x600062B")]
	internal static int GetThreadId() { }

	[Address(RVA = "0x263DF50", Offset = "0x263D350", Length = "0x25D")]
	[Token(Token = "0x6000629")]
	private static void InitProcessInfo() { }

}

