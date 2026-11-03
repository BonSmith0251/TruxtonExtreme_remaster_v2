namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001B5")]
public sealed class AsyncMouseUpAsButtonTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2779A80", Offset = "0x2778E80", Length = "0x39")]
	[Token(Token = "0x6000AAA")]
	public AsyncMouseUpAsButtonTrigger() { }

	[Address(RVA = "0x27796E0", Offset = "0x2778AE0", Length = "0x67")]
	[Token(Token = "0x6000AA6")]
	public IAsyncOnMouseUpAsButtonHandler GetOnMouseUpAsButtonAsyncHandler() { }

	[Address(RVA = "0x2779750", Offset = "0x2778B50", Length = "0x7C")]
	[Token(Token = "0x6000AA7")]
	public IAsyncOnMouseUpAsButtonHandler GetOnMouseUpAsButtonAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2779A10", Offset = "0x2778E10", Length = "0x6E")]
	[Token(Token = "0x6000AA5")]
	private void OnMouseUpAsButton() { }

	[Address(RVA = "0x27797D0", Offset = "0x2778BD0", Length = "0x10C")]
	[Token(Token = "0x6000AA8")]
	public UniTask OnMouseUpAsButtonAsync() { }

	[Address(RVA = "0x27798E0", Offset = "0x2778CE0", Length = "0x122")]
	[Token(Token = "0x6000AA9")]
	public UniTask OnMouseUpAsButtonAsync(CancellationToken cancellationToken) { }

}

