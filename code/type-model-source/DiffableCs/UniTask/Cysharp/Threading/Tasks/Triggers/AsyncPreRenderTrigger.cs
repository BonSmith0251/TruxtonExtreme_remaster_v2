namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001C3")]
public sealed class AsyncPreRenderTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277D760", Offset = "0x277CB60", Length = "0x39")]
	[Token(Token = "0x6000ADB")]
	public AsyncPreRenderTrigger() { }

	[Address(RVA = "0x277D3C0", Offset = "0x277C7C0", Length = "0x67")]
	[Token(Token = "0x6000AD7")]
	public IAsyncOnPreRenderHandler GetOnPreRenderAsyncHandler() { }

	[Address(RVA = "0x277D430", Offset = "0x277C830", Length = "0x7C")]
	[Token(Token = "0x6000AD8")]
	public IAsyncOnPreRenderHandler GetOnPreRenderAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277D6F0", Offset = "0x277CAF0", Length = "0x6E")]
	[Token(Token = "0x6000AD6")]
	private void OnPreRender() { }

	[Address(RVA = "0x277D4B0", Offset = "0x277C8B0", Length = "0x10C")]
	[Token(Token = "0x6000AD9")]
	public UniTask OnPreRenderAsync() { }

	[Address(RVA = "0x277D5C0", Offset = "0x277C9C0", Length = "0x122")]
	[Token(Token = "0x6000ADA")]
	public UniTask OnPreRenderAsync(CancellationToken cancellationToken) { }

}

