namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000197")]
public sealed class AsyncCollisionStay2DTrigger : AsyncTriggerBase<Collision2D>
{

	[Address(RVA = "0x2773EB0", Offset = "0x27732B0", Length = "0x39")]
	[Token(Token = "0x6000A41")]
	public AsyncCollisionStay2DTrigger() { }

	[Address(RVA = "0x2773BE0", Offset = "0x2772FE0", Length = "0x67")]
	[Token(Token = "0x6000A3D")]
	public IAsyncOnCollisionStay2DHandler GetOnCollisionStay2DAsyncHandler() { }

	[Address(RVA = "0x2773C50", Offset = "0x2773050", Length = "0x7C")]
	[Token(Token = "0x6000A3E")]
	public IAsyncOnCollisionStay2DHandler GetOnCollisionStay2DAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2773E60", Offset = "0x2773260", Length = "0x48")]
	[Token(Token = "0x6000A3C")]
	private void OnCollisionStay2D(Collision2D coll) { }

	[Address(RVA = "0x2773DA0", Offset = "0x27731A0", Length = "0xB0")]
	[Token(Token = "0x6000A3F")]
	public UniTask<Collision2D> OnCollisionStay2DAsync() { }

	[Address(RVA = "0x2773CD0", Offset = "0x27730D0", Length = "0xC5")]
	[Token(Token = "0x6000A40")]
	public UniTask<Collision2D> OnCollisionStay2DAsync(CancellationToken cancellationToken) { }

}

