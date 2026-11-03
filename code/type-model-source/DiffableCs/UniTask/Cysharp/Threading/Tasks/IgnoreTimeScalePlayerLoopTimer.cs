namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000067")]
internal sealed class IgnoreTimeScalePlayerLoopTimer : PlayerLoopTimer
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000DB")]
	private int initialFrame; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000DC")]
	private float elapsed; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000DD")]
	private float interval; //Field offset: 0x38

	[Address(RVA = "0x2734B10", Offset = "0x2733F10", Length = "0xE0")]
	[Token(Token = "0x6000158")]
	public IgnoreTimeScalePlayerLoopTimer(TimeSpan interval, bool periodic, PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken, Action<Object> timerCallback, object state) { }

	[Address(RVA = "0x27349C0", Offset = "0x2733DC0", Length = "0x64")]
	[Token(Token = "0x6000159")]
	protected virtual bool MoveNextCore() { }

	[Address(RVA = "0x2734A30", Offset = "0x2733E30", Length = "0xDB")]
	[Token(Token = "0x600015A")]
	protected virtual void ResetCore(Nullable<TimeSpan> interval) { }

}

