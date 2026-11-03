namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000191")]
public sealed class AsyncCollisionExitTrigger : AsyncTriggerBase<Collision>
{

	[Address(RVA = "0x2773BA0", Offset = "0x2772FA0", Length = "0x39")]
	[Token(Token = "0x6000A2C")]
	public AsyncCollisionExitTrigger() { }

	[Address(RVA = "0x2773950", Offset = "0x2772D50", Length = "0x67")]
	[Token(Token = "0x6000A28")]
	public IAsyncOnCollisionExitHandler GetOnCollisionExitAsyncHandler() { }

	[Address(RVA = "0x27738D0", Offset = "0x2772CD0", Length = "0x7C")]
	[Token(Token = "0x6000A29")]
	public IAsyncOnCollisionExitHandler GetOnCollisionExitAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2773B50", Offset = "0x2772F50", Length = "0x48")]
	[Token(Token = "0x6000A27")]
	private void OnCollisionExit(Collision coll) { }

	[Address(RVA = "0x2773A90", Offset = "0x2772E90", Length = "0xB0")]
	[Token(Token = "0x6000A2A")]
	public UniTask<Collision> OnCollisionExitAsync() { }

	[Address(RVA = "0x27739C0", Offset = "0x2772DC0", Length = "0xC5")]
	[Token(Token = "0x6000A2B")]
	public UniTask<Collision> OnCollisionExitAsync(CancellationToken cancellationToken) { }

}

