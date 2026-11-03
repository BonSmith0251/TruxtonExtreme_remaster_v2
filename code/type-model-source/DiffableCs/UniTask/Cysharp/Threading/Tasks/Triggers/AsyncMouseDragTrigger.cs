namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001AB")]
public sealed class AsyncMouseDragTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2778B00", Offset = "0x2777F00", Length = "0x39")]
	[Token(Token = "0x6000A87")]
	public AsyncMouseDragTrigger() { }

	[Address(RVA = "0x2778760", Offset = "0x2777B60", Length = "0x67")]
	[Token(Token = "0x6000A83")]
	public IAsyncOnMouseDragHandler GetOnMouseDragAsyncHandler() { }

	[Address(RVA = "0x27787D0", Offset = "0x2777BD0", Length = "0x7C")]
	[Token(Token = "0x6000A84")]
	public IAsyncOnMouseDragHandler GetOnMouseDragAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2778A90", Offset = "0x2777E90", Length = "0x6E")]
	[Token(Token = "0x6000A82")]
	private void OnMouseDrag() { }

	[Address(RVA = "0x2778850", Offset = "0x2777C50", Length = "0x10C")]
	[Token(Token = "0x6000A85")]
	public UniTask OnMouseDragAsync() { }

	[Address(RVA = "0x2778960", Offset = "0x2777D60", Length = "0x122")]
	[Token(Token = "0x6000A86")]
	public UniTask OnMouseDragAsync(CancellationToken cancellationToken) { }

}

