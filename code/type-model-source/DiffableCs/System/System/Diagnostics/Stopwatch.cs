namespace System.Diagnostics;

[Token(Token = "0x2000110")]
public class Stopwatch
{
	[Token(Token = "0x40004C2")]
	public static readonly long Frequency; //Field offset: 0x0
	[Token(Token = "0x40004C3")]
	public static readonly bool IsHighResolution; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004C4")]
	private long elapsed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004C5")]
	private long started; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004C6")]
	private bool is_running; //Field offset: 0x20

	[Token(Token = "0x17000108")]
	public TimeSpan Elapsed
	{
		[Address(RVA = "0x263D420", Offset = "0x263C820", Length = "0x198")]
		[Token(Token = "0x6000683")]
		 get { } //Length: 408
	}

	[Token(Token = "0x17000109")]
	public long ElapsedMilliseconds
	{
		[Address(RVA = "0x263D0C0", Offset = "0x263C4C0", Length = "0x2EC")]
		[Token(Token = "0x6000684")]
		 get { } //Length: 748
	}

	[Token(Token = "0x1700010A")]
	public long ElapsedTicks
	{
		[Address(RVA = "0x263D3B0", Offset = "0x263C7B0", Length = "0x63")]
		[Token(Token = "0x6000685")]
		 get { } //Length: 99
	}

	[Address(RVA = "0x263D070", Offset = "0x263C470", Length = "0x4C")]
	[Token(Token = "0x6000689")]
	private static Stopwatch() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000682")]
	public Stopwatch() { }

	[Address(RVA = "0x263D420", Offset = "0x263C820", Length = "0x198")]
	[Token(Token = "0x6000683")]
	public TimeSpan get_Elapsed() { }

	[Address(RVA = "0x263D0C0", Offset = "0x263C4C0", Length = "0x2EC")]
	[Token(Token = "0x6000684")]
	public long get_ElapsedMilliseconds() { }

	[Address(RVA = "0x263D3B0", Offset = "0x263C7B0", Length = "0x63")]
	[Token(Token = "0x6000685")]
	public long get_ElapsedTicks() { }

	[Address(RVA = "0x20C3B90", Offset = "0x20C2F90", Length = "0x5")]
	[Token(Token = "0x6000681")]
	public static long GetTimestamp() { }

	[Address(RVA = "0x263CF80", Offset = "0x263C380", Length = "0xD")]
	[Token(Token = "0x6000686")]
	public void Reset() { }

	[Address(RVA = "0x263CF90", Offset = "0x263C390", Length = "0x53")]
	[Token(Token = "0x6000687")]
	public void Start() { }

	[Address(RVA = "0x263CFF0", Offset = "0x263C3F0", Length = "0x72")]
	[Token(Token = "0x6000688")]
	public void Stop() { }

}

