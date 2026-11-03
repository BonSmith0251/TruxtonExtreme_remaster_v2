namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000195")]
public sealed class AsyncCollisionStayTrigger : AsyncTriggerBase<Collision>
{

	[Address(RVA = "0x27741C0", Offset = "0x27735C0", Length = "0x39")]
	[Token(Token = "0x6000A3A")]
	public AsyncCollisionStayTrigger() { }

	[Address(RVA = "0x2773EF0", Offset = "0x27732F0", Length = "0x67")]
	[Token(Token = "0x6000A36")]
	public IAsyncOnCollisionStayHandler GetOnCollisionStayAsyncHandler() { }

	[Address(RVA = "0x2773F60", Offset = "0x2773360", Length = "0x7C")]
	[Token(Token = "0x6000A37")]
	public IAsyncOnCollisionStayHandler GetOnCollisionStayAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2774170", Offset = "0x2773570", Length = "0x48")]
	[Token(Token = "0x6000A35")]
	private void OnCollisionStay(Collision coll) { }

	[Address(RVA = "0x2773FE0", Offset = "0x27733E0", Length = "0xB0")]
	[Token(Token = "0x6000A38")]
	public UniTask<Collision> OnCollisionStayAsync() { }

	[Address(RVA = "0x27740A0", Offset = "0x27734A0", Length = "0xC5")]
	[Token(Token = "0x6000A39")]
	public UniTask<Collision> OnCollisionStayAsync(CancellationToken cancellationToken) { }

}

