namespace System.Text.RegularExpressions;

[Token(Token = "0x20000F3")]
public abstract class RegexRunner
{
	[Token(Token = "0x4000444")]
	private const int TimeoutCheckFrequency = 1000; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000433")]
	protected private int runtextbeg; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000434")]
	protected private int runtextend; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000435")]
	protected private int runtextstart; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000436")]
	protected private string runtext; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000437")]
	protected private int runtextpos; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000438")]
	protected private Int32[] runtrack; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000439")]
	protected private int runtrackpos; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400043A")]
	protected private Int32[] runstack; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400043B")]
	protected private int runstackpos; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400043C")]
	protected private Int32[] runcrawl; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400043D")]
	protected private int runcrawlpos; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400043E")]
	protected private int runtrackcount; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400043F")]
	protected private Match runmatch; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000440")]
	protected private Regex runregex; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000441")]
	private int _timeout; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000442")]
	private bool _ignoreTimeout; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000443")]
	private int _timeoutOccursAt; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000445")]
	private int _timeoutChecksToSkip; //Field offset: 0x7C

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60005EE")]
	protected private RegexRunner() { }

	[Address(RVA = "0x263A4F0", Offset = "0x26398F0", Length = "0x89")]
	[Token(Token = "0x6000601")]
	protected void Capture(int capnum, int start, int end) { }

	[Address(RVA = "0x263A580", Offset = "0x2639980", Length = "0xDB")]
	[Token(Token = "0x60005F1")]
	protected void CheckTimeout() { }

	[Address(RVA = "0x263A660", Offset = "0x2639A60", Length = "0xE0")]
	[Token(Token = "0x60005FE")]
	protected void Crawl(int i) { }

	[Address(RVA = "0x263A750", Offset = "0x2639B50", Length = "0x1D")]
	[Token(Token = "0x6000600")]
	protected int Crawlpos() { }

	[Address(RVA = "0x263A770", Offset = "0x2639B70", Length = "0xD5")]
	[Token(Token = "0x60005F2")]
	private void DoCheckTimeout() { }

	[Address(RVA = "0x263A850", Offset = "0x2639C50", Length = "0xA0")]
	[Token(Token = "0x60005FD")]
	protected void DoubleCrawl() { }

	[Address(RVA = "0x263A900", Offset = "0x2639D00", Length = "0xA0")]
	[Token(Token = "0x60005FC")]
	protected void DoubleStack() { }

	[Address(RVA = "0x263A9B0", Offset = "0x2639DB0", Length = "0xA0")]
	[Token(Token = "0x60005FB")]
	protected void DoubleTrack() { }

	[Address(RVA = "0x263AA60", Offset = "0x2639E60", Length = "0x14D")]
	[Token(Token = "0x60005F8")]
	protected void EnsureStorage() { }

	[Token(Token = "0x60005F4")]
	protected abstract bool FindFirstChar() { }

	[Token(Token = "0x60005F3")]
	protected abstract void Go() { }

	[Address(RVA = "0x263ABB0", Offset = "0x2639FB0", Length = "0x2AC")]
	[Token(Token = "0x60005F6")]
	private void InitMatch() { }

	[Token(Token = "0x60005F5")]
	protected abstract void InitTrackCount() { }

	[Address(RVA = "0x263AE60", Offset = "0x263A260", Length = "0xE9")]
	[Token(Token = "0x60005F9")]
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	[Address(RVA = "0x263AF50", Offset = "0x263A350", Length = "0xE9")]
	[Token(Token = "0x60005FA")]
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	[Address(RVA = "0x263B040", Offset = "0x263A440", Length = "0x2A")]
	[Token(Token = "0x6000604")]
	protected bool IsMatched(int cap) { }

	[Address(RVA = "0x263B070", Offset = "0x263A470", Length = "0x2A")]
	[Token(Token = "0x6000605")]
	protected int MatchIndex(int cap) { }

	[Address(RVA = "0x263B0A0", Offset = "0x263A4A0", Length = "0x2A")]
	[Token(Token = "0x6000606")]
	protected int MatchLength(int cap) { }

	[Address(RVA = "0x263B0D0", Offset = "0x263A4D0", Length = "0x33")]
	[Token(Token = "0x60005FF")]
	protected int Popcrawl() { }

	[Address(RVA = "0x263B110", Offset = "0x263A510", Length = "0x437")]
	[Token(Token = "0x60005EF")]
	protected private Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	[Address(RVA = "0x263B550", Offset = "0x263A950", Length = "0x29")]
	[Token(Token = "0x60005F0")]
	private void StartTimeoutWatch() { }

	[Address(RVA = "0x263B580", Offset = "0x263A980", Length = "0x63")]
	[Token(Token = "0x60005F7")]
	private Match TidyMatch(bool quick) { }

	[Address(RVA = "0x263B5F0", Offset = "0x263A9F0", Length = "0x127")]
	[Token(Token = "0x6000602")]
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	[Address(RVA = "0x263B720", Offset = "0x263AB20", Length = "0x4E")]
	[Token(Token = "0x6000603")]
	protected void Uncapture() { }

}

