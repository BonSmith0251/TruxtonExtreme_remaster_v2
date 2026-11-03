namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200017B")]
public sealed class AsyncAnimatorMoveTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2770C90", Offset = "0x2770090", Length = "0x39")]
	[Token(Token = "0x60009DF")]
	public AsyncAnimatorMoveTrigger() { }

	[Address(RVA = "0x27708F0", Offset = "0x276FCF0", Length = "0x67")]
	[Token(Token = "0x60009DB")]
	public IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler() { }

	[Address(RVA = "0x2770960", Offset = "0x276FD60", Length = "0x7C")]
	[Token(Token = "0x60009DC")]
	public IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2770C20", Offset = "0x2770020", Length = "0x6E")]
	[Token(Token = "0x60009DA")]
	private void OnAnimatorMove() { }

	[Address(RVA = "0x27709E0", Offset = "0x276FDE0", Length = "0x10C")]
	[Token(Token = "0x60009DD")]
	public UniTask OnAnimatorMoveAsync() { }

	[Address(RVA = "0x2770AF0", Offset = "0x276FEF0", Length = "0x122")]
	[Token(Token = "0x60009DE")]
	public UniTask OnAnimatorMoveAsync(CancellationToken cancellationToken) { }

}

