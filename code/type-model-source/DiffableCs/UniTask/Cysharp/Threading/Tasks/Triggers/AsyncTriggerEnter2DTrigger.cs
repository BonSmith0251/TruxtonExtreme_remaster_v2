namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001D5")]
public sealed class AsyncTriggerEnter2DTrigger : AsyncTriggerBase<Collider2D>
{

	[Address(RVA = "0x27804F0", Offset = "0x277F8F0", Length = "0x39")]
	[Token(Token = "0x6000B1A")]
	public AsyncTriggerEnter2DTrigger() { }

	[Address(RVA = "0x27802A0", Offset = "0x277F6A0", Length = "0x67")]
	[Token(Token = "0x6000B16")]
	public IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler() { }

	[Address(RVA = "0x2780220", Offset = "0x277F620", Length = "0x7C")]
	[Token(Token = "0x6000B17")]
	public IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27804A0", Offset = "0x277F8A0", Length = "0x48")]
	[Token(Token = "0x6000B15")]
	private void OnTriggerEnter2D(Collider2D other) { }

	[Address(RVA = "0x27803E0", Offset = "0x277F7E0", Length = "0xB0")]
	[Token(Token = "0x6000B18")]
	public UniTask<Collider2D> OnTriggerEnter2DAsync() { }

	[Address(RVA = "0x2780310", Offset = "0x277F710", Length = "0xC5")]
	[Token(Token = "0x6000B19")]
	public UniTask<Collider2D> OnTriggerEnter2DAsync(CancellationToken cancellationToken) { }

}

