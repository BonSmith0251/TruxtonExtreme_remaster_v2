namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001D3")]
public sealed class AsyncTriggerEnterTrigger : AsyncTriggerBase<Collider>
{

	[Address(RVA = "0x2780800", Offset = "0x277FC00", Length = "0x39")]
	[Token(Token = "0x6000B13")]
	public AsyncTriggerEnterTrigger() { }

	[Address(RVA = "0x2780530", Offset = "0x277F930", Length = "0x67")]
	[Token(Token = "0x6000B0F")]
	public IAsyncOnTriggerEnterHandler GetOnTriggerEnterAsyncHandler() { }

	[Address(RVA = "0x27805A0", Offset = "0x277F9A0", Length = "0x7C")]
	[Token(Token = "0x6000B10")]
	public IAsyncOnTriggerEnterHandler GetOnTriggerEnterAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27807B0", Offset = "0x277FBB0", Length = "0x48")]
	[Token(Token = "0x6000B0E")]
	private void OnTriggerEnter(Collider other) { }

	[Address(RVA = "0x2780620", Offset = "0x277FA20", Length = "0xB0")]
	[Token(Token = "0x6000B11")]
	public UniTask<Collider> OnTriggerEnterAsync() { }

	[Address(RVA = "0x27806E0", Offset = "0x277FAE0", Length = "0xC5")]
	[Token(Token = "0x6000B12")]
	public UniTask<Collider> OnTriggerEnterAsync(CancellationToken cancellationToken) { }

}

