namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000068")]
internal sealed class RealtimePlayerLoopTimer : PlayerLoopTimer
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000DE")]
	private ValueStopwatch stopwatch; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000DF")]
	private long intervalTicks; //Field offset: 0x38

	[Address(RVA = "0x27384D0", Offset = "0x27378D0", Length = "0xE0")]
	[Token(Token = "0x600015B")]
	public RealtimePlayerLoopTimer(TimeSpan interval, bool periodic, PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken, Action<Object> timerCallback, object state) { }

	[Address(RVA = "0x27383C0", Offset = "0x27377C0", Length = "0x52")]
	[Token(Token = "0x600015C")]
	protected virtual bool MoveNextCore() { }

	[Address(RVA = "0x2738420", Offset = "0x2737820", Length = "0xAB")]
	[Token(Token = "0x600015D")]
	protected virtual void ResetCore(Nullable<TimeSpan> interval) { }

}

