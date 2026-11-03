namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200019D")]
public sealed class AsyncDrawGizmosTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2775A70", Offset = "0x2774E70", Length = "0x39")]
	[Token(Token = "0x6000A56")]
	public AsyncDrawGizmosTrigger() { }

	[Address(RVA = "0x27756D0", Offset = "0x2774AD0", Length = "0x67")]
	[Token(Token = "0x6000A52")]
	public IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler() { }

	[Address(RVA = "0x2775740", Offset = "0x2774B40", Length = "0x7C")]
	[Token(Token = "0x6000A53")]
	public IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2775A00", Offset = "0x2774E00", Length = "0x6E")]
	[Token(Token = "0x6000A51")]
	private void OnDrawGizmos() { }

	[Address(RVA = "0x27757C0", Offset = "0x2774BC0", Length = "0x10C")]
	[Token(Token = "0x6000A54")]
	public UniTask OnDrawGizmosAsync() { }

	[Address(RVA = "0x27758D0", Offset = "0x2774CD0", Length = "0x122")]
	[Token(Token = "0x6000A55")]
	public UniTask OnDrawGizmosAsync(CancellationToken cancellationToken) { }

}

