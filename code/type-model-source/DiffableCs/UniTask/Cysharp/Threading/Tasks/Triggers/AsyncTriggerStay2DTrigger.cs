namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001DD")]
public sealed class AsyncTriggerStay2DTrigger : AsyncTriggerBase<Collider2D>
{

	[Address(RVA = "0x2784420", Offset = "0x2783820", Length = "0x39")]
	[Token(Token = "0x6000B36")]
	public AsyncTriggerStay2DTrigger() { }

	[Address(RVA = "0x27841D0", Offset = "0x27835D0", Length = "0x67")]
	[Token(Token = "0x6000B32")]
	public IAsyncOnTriggerStay2DHandler GetOnTriggerStay2DAsyncHandler() { }

	[Address(RVA = "0x2784150", Offset = "0x2783550", Length = "0x7C")]
	[Token(Token = "0x6000B33")]
	public IAsyncOnTriggerStay2DHandler GetOnTriggerStay2DAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27843D0", Offset = "0x27837D0", Length = "0x48")]
	[Token(Token = "0x6000B31")]
	private void OnTriggerStay2D(Collider2D other) { }

	[Address(RVA = "0x2784240", Offset = "0x2783640", Length = "0xB0")]
	[Token(Token = "0x6000B34")]
	public UniTask<Collider2D> OnTriggerStay2DAsync() { }

	[Address(RVA = "0x2784300", Offset = "0x2783700", Length = "0xC5")]
	[Token(Token = "0x6000B35")]
	public UniTask<Collider2D> OnTriggerStay2DAsync(CancellationToken cancellationToken) { }

}

