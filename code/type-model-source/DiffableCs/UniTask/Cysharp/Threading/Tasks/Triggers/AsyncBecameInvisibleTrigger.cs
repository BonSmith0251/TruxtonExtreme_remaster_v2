namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000185")]
public sealed class AsyncBecameInvisibleTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2772180", Offset = "0x2771580", Length = "0x39")]
	[Token(Token = "0x6000A02")]
	public AsyncBecameInvisibleTrigger() { }

	[Address(RVA = "0x2771E60", Offset = "0x2771260", Length = "0x67")]
	[Token(Token = "0x60009FE")]
	public IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler() { }

	[Address(RVA = "0x2771DE0", Offset = "0x27711E0", Length = "0x7C")]
	[Token(Token = "0x60009FF")]
	public IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2772110", Offset = "0x2771510", Length = "0x6E")]
	[Token(Token = "0x60009FD")]
	private void OnBecameInvisible() { }

	[Address(RVA = "0x2772000", Offset = "0x2771400", Length = "0x10C")]
	[Token(Token = "0x6000A00")]
	public UniTask OnBecameInvisibleAsync() { }

	[Address(RVA = "0x2771ED0", Offset = "0x27712D0", Length = "0x122")]
	[Token(Token = "0x6000A01")]
	public UniTask OnBecameInvisibleAsync(CancellationToken cancellationToken) { }

}

