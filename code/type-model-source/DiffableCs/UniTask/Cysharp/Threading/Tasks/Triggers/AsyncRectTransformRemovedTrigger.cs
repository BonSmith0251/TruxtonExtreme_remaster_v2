namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001C7")]
public sealed class AsyncRectTransformRemovedTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277DF20", Offset = "0x277D320", Length = "0x39")]
	[Token(Token = "0x6000AE9")]
	public AsyncRectTransformRemovedTrigger() { }

	[Address(RVA = "0x277DC00", Offset = "0x277D000", Length = "0x67")]
	[Token(Token = "0x6000AE5")]
	public IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler() { }

	[Address(RVA = "0x277DB80", Offset = "0x277CF80", Length = "0x7C")]
	[Token(Token = "0x6000AE6")]
	public IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277DEB0", Offset = "0x277D2B0", Length = "0x6E")]
	[Token(Token = "0x6000AE4")]
	private void OnRectTransformRemoved() { }

	[Address(RVA = "0x277DC70", Offset = "0x277D070", Length = "0x10C")]
	[Token(Token = "0x6000AE7")]
	public UniTask OnRectTransformRemovedAsync() { }

	[Address(RVA = "0x277DD80", Offset = "0x277D180", Length = "0x122")]
	[Token(Token = "0x6000AE8")]
	public UniTask OnRectTransformRemovedAsync(CancellationToken cancellationToken) { }

}

