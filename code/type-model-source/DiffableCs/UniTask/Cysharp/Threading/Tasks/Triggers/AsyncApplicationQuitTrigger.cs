namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000181")]
public sealed class AsyncApplicationQuitTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x27717F0", Offset = "0x2770BF0", Length = "0x39")]
	[Token(Token = "0x60009F4")]
	public AsyncApplicationQuitTrigger() { }

	[Address(RVA = "0x2771450", Offset = "0x2770850", Length = "0x67")]
	[Token(Token = "0x60009F0")]
	public IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler() { }

	[Address(RVA = "0x27714C0", Offset = "0x27708C0", Length = "0x7C")]
	[Token(Token = "0x60009F1")]
	public IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2771780", Offset = "0x2770B80", Length = "0x6E")]
	[Token(Token = "0x60009EF")]
	private void OnApplicationQuit() { }

	[Address(RVA = "0x2771540", Offset = "0x2770940", Length = "0x10C")]
	[Token(Token = "0x60009F2")]
	public UniTask OnApplicationQuitAsync() { }

	[Address(RVA = "0x2771650", Offset = "0x2770A50", Length = "0x122")]
	[Token(Token = "0x60009F3")]
	public UniTask OnApplicationQuitAsync(CancellationToken cancellationToken) { }

}

