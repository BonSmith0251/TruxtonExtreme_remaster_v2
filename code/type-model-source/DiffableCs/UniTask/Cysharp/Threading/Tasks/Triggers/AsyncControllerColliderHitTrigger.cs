namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000199")]
public sealed class AsyncControllerColliderHitTrigger : AsyncTriggerBase<ControllerColliderHit>
{

	[Address(RVA = "0x27744D0", Offset = "0x27738D0", Length = "0x39")]
	[Token(Token = "0x6000A48")]
	public AsyncControllerColliderHitTrigger() { }

	[Address(RVA = "0x2774200", Offset = "0x2773600", Length = "0x67")]
	[Token(Token = "0x6000A44")]
	public IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler() { }

	[Address(RVA = "0x2774270", Offset = "0x2773670", Length = "0x7C")]
	[Token(Token = "0x6000A45")]
	public IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2774480", Offset = "0x2773880", Length = "0x48")]
	[Token(Token = "0x6000A43")]
	private void OnControllerColliderHit(ControllerColliderHit hit) { }

	[Address(RVA = "0x27743C0", Offset = "0x27737C0", Length = "0xB0")]
	[Token(Token = "0x6000A46")]
	public UniTask<ControllerColliderHit> OnControllerColliderHitAsync() { }

	[Address(RVA = "0x27742F0", Offset = "0x27736F0", Length = "0xC5")]
	[Token(Token = "0x6000A47")]
	public UniTask<ControllerColliderHit> OnControllerColliderHitAsync(CancellationToken cancellationToken) { }

}

