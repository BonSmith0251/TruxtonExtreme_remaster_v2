namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000187")]
public sealed class AsyncBecameVisibleTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2772560", Offset = "0x2771960", Length = "0x39")]
	[Token(Token = "0x6000A09")]
	public AsyncBecameVisibleTrigger() { }

	[Address(RVA = "0x2772240", Offset = "0x2771640", Length = "0x67")]
	[Token(Token = "0x6000A05")]
	public IAsyncOnBecameVisibleHandler GetOnBecameVisibleAsyncHandler() { }

	[Address(RVA = "0x27721C0", Offset = "0x27715C0", Length = "0x7C")]
	[Token(Token = "0x6000A06")]
	public IAsyncOnBecameVisibleHandler GetOnBecameVisibleAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27724F0", Offset = "0x27718F0", Length = "0x6E")]
	[Token(Token = "0x6000A04")]
	private void OnBecameVisible() { }

	[Address(RVA = "0x27723E0", Offset = "0x27717E0", Length = "0x10C")]
	[Token(Token = "0x6000A07")]
	public UniTask OnBecameVisibleAsync() { }

	[Address(RVA = "0x27722B0", Offset = "0x27716B0", Length = "0x122")]
	[Token(Token = "0x6000A08")]
	public UniTask OnBecameVisibleAsync(CancellationToken cancellationToken) { }

}

