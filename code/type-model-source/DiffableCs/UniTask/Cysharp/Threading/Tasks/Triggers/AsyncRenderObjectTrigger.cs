namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001CB")]
public sealed class AsyncRenderObjectTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277E710", Offset = "0x277DB10", Length = "0x39")]
	[Token(Token = "0x6000AF7")]
	public AsyncRenderObjectTrigger() { }

	[Address(RVA = "0x277E3F0", Offset = "0x277D7F0", Length = "0x67")]
	[Token(Token = "0x6000AF3")]
	public IAsyncOnRenderObjectHandler GetOnRenderObjectAsyncHandler() { }

	[Address(RVA = "0x277E370", Offset = "0x277D770", Length = "0x7C")]
	[Token(Token = "0x6000AF4")]
	public IAsyncOnRenderObjectHandler GetOnRenderObjectAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277E6A0", Offset = "0x277DAA0", Length = "0x6E")]
	[Token(Token = "0x6000AF2")]
	private void OnRenderObject() { }

	[Address(RVA = "0x277E460", Offset = "0x277D860", Length = "0x10C")]
	[Token(Token = "0x6000AF5")]
	public UniTask OnRenderObjectAsync() { }

	[Address(RVA = "0x277E570", Offset = "0x277D970", Length = "0x122")]
	[Token(Token = "0x6000AF6")]
	public UniTask OnRenderObjectAsync(CancellationToken cancellationToken) { }

}

