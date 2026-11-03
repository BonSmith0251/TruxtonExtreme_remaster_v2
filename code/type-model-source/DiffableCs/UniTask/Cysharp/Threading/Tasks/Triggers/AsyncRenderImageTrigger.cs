namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001C9")]
[TupleElementNames(new IL2CPP_TYPE_STRING[] {"source", "destination"})]
public sealed class AsyncRenderImageTrigger : AsyncTriggerBase<ValueTuple`2<RenderTexture, RenderTexture>>
{

	[Address(RVA = "0x277E330", Offset = "0x277D730", Length = "0x39")]
	[Token(Token = "0x6000AF0")]
	public AsyncRenderImageTrigger() { }

	[Address(RVA = "0x277DF60", Offset = "0x277D360", Length = "0x67")]
	[Token(Token = "0x6000AEC")]
	public IAsyncOnRenderImageHandler GetOnRenderImageAsyncHandler() { }

	[Address(RVA = "0x277DFD0", Offset = "0x277D3D0", Length = "0x7C")]
	[Token(Token = "0x6000AED")]
	public IAsyncOnRenderImageHandler GetOnRenderImageAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277E2A0", Offset = "0x277D6A0", Length = "0x8E")]
	[Token(Token = "0x6000AEB")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	[Address(RVA = "0x277E180", Offset = "0x277D580", Length = "0x114")]
	[Token(Token = "0x6000AEE")]
	public UniTask<ValueTuple`2<RenderTexture, RenderTexture>> OnRenderImageAsync() { }

	[Address(RVA = "0x277E050", Offset = "0x277D450", Length = "0x12A")]
	[Token(Token = "0x6000AEF")]
	public UniTask<ValueTuple`2<RenderTexture, RenderTexture>> OnRenderImageAsync(CancellationToken cancellationToken) { }

}

