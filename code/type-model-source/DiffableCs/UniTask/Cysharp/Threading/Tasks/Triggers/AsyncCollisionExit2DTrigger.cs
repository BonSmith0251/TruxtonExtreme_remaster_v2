namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000193")]
public sealed class AsyncCollisionExit2DTrigger : AsyncTriggerBase<Collision2D>
{

	[Address(RVA = "0x2773890", Offset = "0x2772C90", Length = "0x39")]
	[Token(Token = "0x6000A33")]
	public AsyncCollisionExit2DTrigger() { }

	[Address(RVA = "0x2773640", Offset = "0x2772A40", Length = "0x67")]
	[Token(Token = "0x6000A2F")]
	public IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler() { }

	[Address(RVA = "0x27735C0", Offset = "0x27729C0", Length = "0x7C")]
	[Token(Token = "0x6000A30")]
	public IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2773840", Offset = "0x2772C40", Length = "0x48")]
	[Token(Token = "0x6000A2E")]
	private void OnCollisionExit2D(Collision2D coll) { }

	[Address(RVA = "0x27736B0", Offset = "0x2772AB0", Length = "0xB0")]
	[Token(Token = "0x6000A31")]
	public UniTask<Collision2D> OnCollisionExit2DAsync() { }

	[Address(RVA = "0x2773770", Offset = "0x2772B70", Length = "0xC5")]
	[Token(Token = "0x6000A32")]
	public UniTask<Collision2D> OnCollisionExit2DAsync(CancellationToken cancellationToken) { }

}

