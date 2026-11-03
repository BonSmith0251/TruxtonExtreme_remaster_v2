namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000066")]
internal sealed class DeltaTimePlayerLoopTimer : PlayerLoopTimer
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D8")]
	private int initialFrame; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000D9")]
	private float elapsed; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000DA")]
	private float interval; //Field offset: 0x38

	[Address(RVA = "0x2733930", Offset = "0x2732D30", Length = "0xE0")]
	[Token(Token = "0x6000155")]
	public DeltaTimePlayerLoopTimer(TimeSpan interval, bool periodic, PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken, Action<Object> timerCallback, object state) { }

	[Address(RVA = "0x27337E0", Offset = "0x2732BE0", Length = "0x64")]
	[Token(Token = "0x6000156")]
	protected virtual bool MoveNextCore() { }

	[Address(RVA = "0x2733850", Offset = "0x2732C50", Length = "0xDB")]
	[Token(Token = "0x6000157")]
	protected virtual void ResetCore(Nullable<TimeSpan> interval) { }

}

