namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001A9")]
public sealed class AsyncMouseDownTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2778720", Offset = "0x2777B20", Length = "0x39")]
	[Token(Token = "0x6000A80")]
	public AsyncMouseDownTrigger() { }

	[Address(RVA = "0x2778380", Offset = "0x2777780", Length = "0x67")]
	[Token(Token = "0x6000A7C")]
	public IAsyncOnMouseDownHandler GetOnMouseDownAsyncHandler() { }

	[Address(RVA = "0x27783F0", Offset = "0x27777F0", Length = "0x7C")]
	[Token(Token = "0x6000A7D")]
	public IAsyncOnMouseDownHandler GetOnMouseDownAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27786B0", Offset = "0x2777AB0", Length = "0x6E")]
	[Token(Token = "0x6000A7B")]
	private void OnMouseDown() { }

	[Address(RVA = "0x27785A0", Offset = "0x27779A0", Length = "0x10C")]
	[Token(Token = "0x6000A7E")]
	public UniTask OnMouseDownAsync() { }

	[Address(RVA = "0x2778470", Offset = "0x2777870", Length = "0x122")]
	[Token(Token = "0x6000A7F")]
	public UniTask OnMouseDownAsync(CancellationToken cancellationToken) { }

}

