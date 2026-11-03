namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000071")]
public sealed class TimeoutController : IDisposable
{
	[Token(Token = "0x40000F1")]
	private static readonly Action<Object> CancelCancellationTokenSourceStateDelegate; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000F2")]
	private CancellationTokenSource timeoutSource; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000F3")]
	private CancellationTokenSource linkedSource; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F4")]
	private PlayerLoopTimer timer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000F5")]
	private bool isDisposed; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000F6")]
	private readonly DelayType delayType; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000F7")]
	private readonly PlayerLoopTiming delayTiming; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000F8")]
	private readonly CancellationTokenSource originalLinkCancellationTokenSource; //Field offset: 0x38

	[Address(RVA = "0x2739770", Offset = "0x2738B70", Length = "0x89")]
	[Token(Token = "0x6000181")]
	private static TimeoutController() { }

	[Address(RVA = "0x2739910", Offset = "0x2738D10", Length = "0xA6")]
	[Token(Token = "0x600017A")]
	public TimeoutController(DelayType delayType = 0, PlayerLoopTiming delayTiming = 8) { }

	[Address(RVA = "0x2739800", Offset = "0x2738C00", Length = "0x101")]
	[Token(Token = "0x600017B")]
	public TimeoutController(CancellationTokenSource linkCancellationTokenSource, DelayType delayType = 0, PlayerLoopTiming delayTiming = 8) { }

	[Address(RVA = "0x2739220", Offset = "0x2738620", Length = "0x72")]
	[Token(Token = "0x6000179")]
	private static void CancelCancellationTokenSourceState(object state) { }

	[Address(RVA = "0x27392A0", Offset = "0x27386A0", Length = "0xD0")]
	[Token(Token = "0x6000180")]
	public override void Dispose() { }

	[Address(RVA = "0x2739380", Offset = "0x2738780", Length = "0x1D")]
	[Token(Token = "0x600017E")]
	public bool IsTimeout() { }

	[Address(RVA = "0x27393A0", Offset = "0x27387A0", Length = "0x1B")]
	[Token(Token = "0x600017F")]
	public void Reset() { }

	[Address(RVA = "0x2739700", Offset = "0x2738B00", Length = "0x67")]
	[Token(Token = "0x600017C")]
	public CancellationToken Timeout(int millisecondsTimeout) { }

	[Address(RVA = "0x27393C0", Offset = "0x27387C0", Length = "0x331")]
	[Token(Token = "0x600017D")]
	public CancellationToken Timeout(TimeSpan timeout) { }

}

