namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001BF")]
public sealed class AsyncPostRenderTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277CFA0", Offset = "0x277C3A0", Length = "0x39")]
	[Token(Token = "0x6000ACD")]
	public AsyncPostRenderTrigger() { }

	[Address(RVA = "0x277CC80", Offset = "0x277C080", Length = "0x67")]
	[Token(Token = "0x6000AC9")]
	public IAsyncOnPostRenderHandler GetOnPostRenderAsyncHandler() { }

	[Address(RVA = "0x277CC00", Offset = "0x277C000", Length = "0x7C")]
	[Token(Token = "0x6000ACA")]
	public IAsyncOnPostRenderHandler GetOnPostRenderAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277CF30", Offset = "0x277C330", Length = "0x6E")]
	[Token(Token = "0x6000AC8")]
	private void OnPostRender() { }

	[Address(RVA = "0x277CE20", Offset = "0x277C220", Length = "0x10C")]
	[Token(Token = "0x6000ACB")]
	public UniTask OnPostRenderAsync() { }

	[Address(RVA = "0x277CCF0", Offset = "0x277C0F0", Length = "0x122")]
	[Token(Token = "0x6000ACC")]
	public UniTask OnPostRenderAsync(CancellationToken cancellationToken) { }

}

