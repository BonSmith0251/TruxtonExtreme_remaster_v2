namespace Cysharp.Threading.Tasks.Internal;

[IsReadOnly]
[Token(Token = "0x200022E")]
internal struct ValueStopwatch
{
	[Token(Token = "0x40005F4")]
	private static readonly double TimestampToTicks; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005F5")]
	private readonly long startTimestamp; //Field offset: 0x0

	[Token(Token = "0x17000070")]
	public TimeSpan Elapsed
	{
		[Address(RVA = "0x2794120", Offset = "0x2793520", Length = "0x77")]
		[Token(Token = "0x6000C75")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000072")]
	public long ElapsedTicks
	{
		[Address(RVA = "0x2794030", Offset = "0x2793430", Length = "0xEB")]
		[Token(Token = "0x6000C77")]
		 get { } //Length: 235
	}

	[Token(Token = "0x17000071")]
	public bool IsInvalid
	{
		[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
		[Token(Token = "0x6000C76")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2793FB0", Offset = "0x27933B0", Length = "0x7D")]
	[Token(Token = "0x6000C78")]
	private static ValueStopwatch() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000C74")]
	private ValueStopwatch(long startTimestamp) { }

	[Address(RVA = "0x2794120", Offset = "0x2793520", Length = "0x77")]
	[Token(Token = "0x6000C75")]
	public TimeSpan get_Elapsed() { }

	[Address(RVA = "0x2794030", Offset = "0x2793430", Length = "0xEB")]
	[Token(Token = "0x6000C77")]
	public long get_ElapsedTicks() { }

	[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
	[Token(Token = "0x6000C76")]
	public bool get_IsInvalid() { }

	[Address(RVA = "0x2793F70", Offset = "0x2793370", Length = "0x40")]
	[Token(Token = "0x6000C73")]
	public static ValueStopwatch StartNew() { }

}

