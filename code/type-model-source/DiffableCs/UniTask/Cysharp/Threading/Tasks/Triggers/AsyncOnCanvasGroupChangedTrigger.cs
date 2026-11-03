namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200018B")]
public sealed class AsyncOnCanvasGroupChangedTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277A550", Offset = "0x2779950", Length = "0x39")]
	[Token(Token = "0x6000A17")]
	public AsyncOnCanvasGroupChangedTrigger() { }

	[Address(RVA = "0x277A1B0", Offset = "0x27795B0", Length = "0x67")]
	[Token(Token = "0x6000A13")]
	public IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler() { }

	[Address(RVA = "0x277A220", Offset = "0x2779620", Length = "0x7C")]
	[Token(Token = "0x6000A14")]
	public IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277A4E0", Offset = "0x27798E0", Length = "0x6E")]
	[Token(Token = "0x6000A12")]
	private void OnCanvasGroupChanged() { }

	[Address(RVA = "0x277A3D0", Offset = "0x27797D0", Length = "0x10C")]
	[Token(Token = "0x6000A15")]
	public UniTask OnCanvasGroupChangedAsync() { }

	[Address(RVA = "0x277A2A0", Offset = "0x27796A0", Length = "0x122")]
	[Token(Token = "0x6000A16")]
	public UniTask OnCanvasGroupChangedAsync(CancellationToken cancellationToken) { }

}

