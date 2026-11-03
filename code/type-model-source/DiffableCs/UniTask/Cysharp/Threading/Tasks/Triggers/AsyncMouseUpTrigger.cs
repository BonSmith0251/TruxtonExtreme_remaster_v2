namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001B3")]
public sealed class AsyncMouseUpTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2779E60", Offset = "0x2779260", Length = "0x39")]
	[Token(Token = "0x6000AA3")]
	public AsyncMouseUpTrigger() { }

	[Address(RVA = "0x2779B40", Offset = "0x2778F40", Length = "0x67")]
	[Token(Token = "0x6000A9F")]
	public IAsyncOnMouseUpHandler GetOnMouseUpAsyncHandler() { }

	[Address(RVA = "0x2779AC0", Offset = "0x2778EC0", Length = "0x7C")]
	[Token(Token = "0x6000AA0")]
	public IAsyncOnMouseUpHandler GetOnMouseUpAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2779DF0", Offset = "0x27791F0", Length = "0x6E")]
	[Token(Token = "0x6000A9E")]
	private void OnMouseUp() { }

	[Address(RVA = "0x2779CE0", Offset = "0x27790E0", Length = "0x10C")]
	[Token(Token = "0x6000AA1")]
	public UniTask OnMouseUpAsync() { }

	[Address(RVA = "0x2779BB0", Offset = "0x2778FB0", Length = "0x122")]
	[Token(Token = "0x6000AA2")]
	public UniTask OnMouseUpAsync(CancellationToken cancellationToken) { }

}

