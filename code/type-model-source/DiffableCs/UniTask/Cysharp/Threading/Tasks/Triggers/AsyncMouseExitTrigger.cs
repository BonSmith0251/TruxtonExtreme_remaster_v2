namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001AF")]
public sealed class AsyncMouseExitTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x27792C0", Offset = "0x27786C0", Length = "0x39")]
	[Token(Token = "0x6000A95")]
	public AsyncMouseExitTrigger() { }

	[Address(RVA = "0x2778FA0", Offset = "0x27783A0", Length = "0x67")]
	[Token(Token = "0x6000A91")]
	public IAsyncOnMouseExitHandler GetOnMouseExitAsyncHandler() { }

	[Address(RVA = "0x2778F20", Offset = "0x2778320", Length = "0x7C")]
	[Token(Token = "0x6000A92")]
	public IAsyncOnMouseExitHandler GetOnMouseExitAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2779250", Offset = "0x2778650", Length = "0x6E")]
	[Token(Token = "0x6000A90")]
	private void OnMouseExit() { }

	[Address(RVA = "0x2779140", Offset = "0x2778540", Length = "0x10C")]
	[Token(Token = "0x6000A93")]
	public UniTask OnMouseExitAsync() { }

	[Address(RVA = "0x2779010", Offset = "0x2778410", Length = "0x122")]
	[Token(Token = "0x6000A94")]
	public UniTask OnMouseExitAsync(CancellationToken cancellationToken) { }

}

