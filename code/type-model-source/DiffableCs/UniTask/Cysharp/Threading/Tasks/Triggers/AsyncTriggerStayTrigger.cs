namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001DB")]
public sealed class AsyncTriggerStayTrigger : AsyncTriggerBase<Collider>
{

	[Address(RVA = "0x2784730", Offset = "0x2783B30", Length = "0x39")]
	[Token(Token = "0x6000B2F")]
	public AsyncTriggerStayTrigger() { }

	[Address(RVA = "0x27844E0", Offset = "0x27838E0", Length = "0x67")]
	[Token(Token = "0x6000B2B")]
	public IAsyncOnTriggerStayHandler GetOnTriggerStayAsyncHandler() { }

	[Address(RVA = "0x2784460", Offset = "0x2783860", Length = "0x7C")]
	[Token(Token = "0x6000B2C")]
	public IAsyncOnTriggerStayHandler GetOnTriggerStayAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27846E0", Offset = "0x2783AE0", Length = "0x48")]
	[Token(Token = "0x6000B2A")]
	private void OnTriggerStay(Collider other) { }

	[Address(RVA = "0x2784550", Offset = "0x2783950", Length = "0xB0")]
	[Token(Token = "0x6000B2D")]
	public UniTask<Collider> OnTriggerStayAsync() { }

	[Address(RVA = "0x2784610", Offset = "0x2783A10", Length = "0xC5")]
	[Token(Token = "0x6000B2E")]
	public UniTask<Collider> OnTriggerStayAsync(CancellationToken cancellationToken) { }

}

