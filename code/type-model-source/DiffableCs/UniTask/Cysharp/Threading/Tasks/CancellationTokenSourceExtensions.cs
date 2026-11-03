namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x200001B")]
public static class CancellationTokenSourceExtensions
{
	[Token(Token = "0x4000056")]
	private static readonly Action<Object> CancelCancellationTokenSourceStateDelegate; //Field offset: 0x0

	[Address(RVA = "0x27318B0", Offset = "0x2730CB0", Length = "0x89")]
	[Token(Token = "0x60000A4")]
	private static CancellationTokenSourceExtensions() { }

	[Address(RVA = "0x2731520", Offset = "0x2730920", Length = "0x128")]
	[Extension]
	[Token(Token = "0x60000A0")]
	public static IDisposable CancelAfterSlim(CancellationTokenSource cts, int millisecondsDelay, DelayType delayType = 0, PlayerLoopTiming delayTiming = 8) { }

	[Address(RVA = "0x2731450", Offset = "0x2730850", Length = "0xC5")]
	[Extension]
	[Token(Token = "0x60000A1")]
	public static IDisposable CancelAfterSlim(CancellationTokenSource cts, TimeSpan delayTimeSpan, DelayType delayType = 0, PlayerLoopTiming delayTiming = 8) { }

	[Address(RVA = "0x2731650", Offset = "0x2730A50", Length = "0x72")]
	[Token(Token = "0x600009F")]
	private static void CancelCancellationTokenSourceState(object state) { }

	[Address(RVA = "0x27317A0", Offset = "0x2730BA0", Length = "0x10F")]
	[Extension]
	[Token(Token = "0x60000A2")]
	public static void RegisterRaiseCancelOnDestroy(CancellationTokenSource cts, Component component) { }

	[Address(RVA = "0x27316D0", Offset = "0x2730AD0", Length = "0xC8")]
	[Extension]
	[Token(Token = "0x60000A3")]
	public static void RegisterRaiseCancelOnDestroy(CancellationTokenSource cts, GameObject gameObject) { }

}

