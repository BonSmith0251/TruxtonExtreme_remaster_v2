namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001B1")]
public sealed class AsyncMouseOverTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x27796A0", Offset = "0x2778AA0", Length = "0x39")]
	[Token(Token = "0x6000A9C")]
	public AsyncMouseOverTrigger() { }

	[Address(RVA = "0x2779300", Offset = "0x2778700", Length = "0x67")]
	[Token(Token = "0x6000A98")]
	public IAsyncOnMouseOverHandler GetOnMouseOverAsyncHandler() { }

	[Address(RVA = "0x2779370", Offset = "0x2778770", Length = "0x7C")]
	[Token(Token = "0x6000A99")]
	public IAsyncOnMouseOverHandler GetOnMouseOverAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2779630", Offset = "0x2778A30", Length = "0x6E")]
	[Token(Token = "0x6000A97")]
	private void OnMouseOver() { }

	[Address(RVA = "0x2779520", Offset = "0x2778920", Length = "0x10C")]
	[Token(Token = "0x6000A9A")]
	public UniTask OnMouseOverAsync() { }

	[Address(RVA = "0x27793F0", Offset = "0x27787F0", Length = "0x122")]
	[Token(Token = "0x6000A9B")]
	public UniTask OnMouseOverAsync(CancellationToken cancellationToken) { }

}

