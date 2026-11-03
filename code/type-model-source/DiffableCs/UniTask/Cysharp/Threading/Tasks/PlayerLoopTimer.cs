namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000065")]
public abstract class PlayerLoopTimer : IDisposable, IPlayerLoopItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D0")]
	private readonly CancellationToken cancellationToken; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D1")]
	private readonly Action<Object> timerCallback; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D2")]
	private readonly object state; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D3")]
	private readonly PlayerLoopTiming playerLoopTiming; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000D4")]
	private readonly bool periodic; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x40000D5")]
	private bool isRunning; //Field offset: 0x2D
	[FieldOffset(Offset = "0x2E")]
	[Token(Token = "0x40000D6")]
	private bool tryStop; //Field offset: 0x2E
	[FieldOffset(Offset = "0x2F")]
	[Token(Token = "0x40000D7")]
	private bool isDisposed; //Field offset: 0x2F

	[Address(RVA = "0x2738340", Offset = "0x2737740", Length = "0x75")]
	[Token(Token = "0x600014B")]
	protected PlayerLoopTimer(bool periodic, PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken, Action<Object> timerCallback, object state) { }

	[Address(RVA = "0x2737DC0", Offset = "0x27371C0", Length = "0x18D")]
	[Token(Token = "0x600014C")]
	public static PlayerLoopTimer Create(TimeSpan interval, bool periodic, DelayType delayType, PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken, Action<Object> timerCallback, object state) { }

	[Address(RVA = "0x2737F50", Offset = "0x2737350", Length = "0xD4")]
	[Token(Token = "0x6000153")]
	private override bool Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext() { }

	[Address(RVA = "0x2738030", Offset = "0x2737430", Length = "0x5")]
	[Token(Token = "0x6000152")]
	public override void Dispose() { }

	[Token(Token = "0x6000154")]
	protected abstract bool MoveNextCore() { }

	[Token(Token = "0x6000151")]
	protected abstract void ResetCore(Nullable<TimeSpan> newInterval) { }

	[Address(RVA = "0x2738040", Offset = "0x2737440", Length = "0xCD")]
	[Token(Token = "0x600014E")]
	public void Restart() { }

	[Address(RVA = "0x2738110", Offset = "0x2737510", Length = "0xFD")]
	[Token(Token = "0x600014F")]
	public void Restart(TimeSpan interval) { }

	[Address(RVA = "0x2738210", Offset = "0x2737610", Length = "0x114")]
	[Token(Token = "0x600014D")]
	public static PlayerLoopTimer StartNew(TimeSpan interval, bool periodic, DelayType delayType, PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken, Action<Object> timerCallback, object state) { }

	[Address(RVA = "0x2738330", Offset = "0x2737730", Length = "0x5")]
	[Token(Token = "0x6000150")]
	public void Stop() { }

}

