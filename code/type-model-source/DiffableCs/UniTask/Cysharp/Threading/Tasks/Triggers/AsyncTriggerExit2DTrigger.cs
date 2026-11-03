namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001D9")]
public sealed class AsyncTriggerExit2DTrigger : AsyncTriggerBase<Collider2D>
{

	[Address(RVA = "0x2780B10", Offset = "0x277FF10", Length = "0x39")]
	[Token(Token = "0x6000B28")]
	public AsyncTriggerExit2DTrigger() { }

	[Address(RVA = "0x2780840", Offset = "0x277FC40", Length = "0x67")]
	[Token(Token = "0x6000B24")]
	public IAsyncOnTriggerExit2DHandler GetOnTriggerExit2DAsyncHandler() { }

	[Address(RVA = "0x27808B0", Offset = "0x277FCB0", Length = "0x7C")]
	[Token(Token = "0x6000B25")]
	public IAsyncOnTriggerExit2DHandler GetOnTriggerExit2DAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2780AC0", Offset = "0x277FEC0", Length = "0x48")]
	[Token(Token = "0x6000B23")]
	private void OnTriggerExit2D(Collider2D other) { }

	[Address(RVA = "0x2780A00", Offset = "0x277FE00", Length = "0xB0")]
	[Token(Token = "0x6000B26")]
	public UniTask<Collider2D> OnTriggerExit2DAsync() { }

	[Address(RVA = "0x2780930", Offset = "0x277FD30", Length = "0xC5")]
	[Token(Token = "0x6000B27")]
	public UniTask<Collider2D> OnTriggerExit2DAsync(CancellationToken cancellationToken) { }

}

