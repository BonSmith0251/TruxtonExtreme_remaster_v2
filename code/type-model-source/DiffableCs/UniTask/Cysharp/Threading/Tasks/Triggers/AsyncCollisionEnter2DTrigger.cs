namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200018F")]
public sealed class AsyncCollisionEnter2DTrigger : AsyncTriggerBase<Collision2D>
{

	[Address(RVA = "0x2773270", Offset = "0x2772670", Length = "0x39")]
	[Token(Token = "0x6000A25")]
	public AsyncCollisionEnter2DTrigger() { }

	[Address(RVA = "0x2772FA0", Offset = "0x27723A0", Length = "0x67")]
	[Token(Token = "0x6000A21")]
	public IAsyncOnCollisionEnter2DHandler GetOnCollisionEnter2DAsyncHandler() { }

	[Address(RVA = "0x2773010", Offset = "0x2772410", Length = "0x7C")]
	[Token(Token = "0x6000A22")]
	public IAsyncOnCollisionEnter2DHandler GetOnCollisionEnter2DAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2773220", Offset = "0x2772620", Length = "0x48")]
	[Token(Token = "0x6000A20")]
	private void OnCollisionEnter2D(Collision2D coll) { }

	[Address(RVA = "0x2773160", Offset = "0x2772560", Length = "0xB0")]
	[Token(Token = "0x6000A23")]
	public UniTask<Collision2D> OnCollisionEnter2DAsync() { }

	[Address(RVA = "0x2773090", Offset = "0x2772490", Length = "0xC5")]
	[Token(Token = "0x6000A24")]
	public UniTask<Collision2D> OnCollisionEnter2DAsync(CancellationToken cancellationToken) { }

}

