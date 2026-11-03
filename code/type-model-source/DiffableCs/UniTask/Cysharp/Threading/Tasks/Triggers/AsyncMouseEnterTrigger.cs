namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001AD")]
public sealed class AsyncMouseEnterTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2778EE0", Offset = "0x27782E0", Length = "0x39")]
	[Token(Token = "0x6000A8E")]
	public AsyncMouseEnterTrigger() { }

	[Address(RVA = "0x2778B40", Offset = "0x2777F40", Length = "0x67")]
	[Token(Token = "0x6000A8A")]
	public IAsyncOnMouseEnterHandler GetOnMouseEnterAsyncHandler() { }

	[Address(RVA = "0x2778BB0", Offset = "0x2777FB0", Length = "0x7C")]
	[Token(Token = "0x6000A8B")]
	public IAsyncOnMouseEnterHandler GetOnMouseEnterAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2778E70", Offset = "0x2778270", Length = "0x6E")]
	[Token(Token = "0x6000A89")]
	private void OnMouseEnter() { }

	[Address(RVA = "0x2778C30", Offset = "0x2778030", Length = "0x10C")]
	[Token(Token = "0x6000A8C")]
	public UniTask OnMouseEnterAsync() { }

	[Address(RVA = "0x2778D40", Offset = "0x2778140", Length = "0x122")]
	[Token(Token = "0x6000A8D")]
	public UniTask OnMouseEnterAsync(CancellationToken cancellationToken) { }

}

