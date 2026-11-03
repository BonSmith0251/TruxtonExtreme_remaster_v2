namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001C5")]
public sealed class AsyncRectTransformDimensionsChangeTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277DB40", Offset = "0x277CF40", Length = "0x39")]
	[Token(Token = "0x6000AE2")]
	public AsyncRectTransformDimensionsChangeTrigger() { }

	[Address(RVA = "0x277D7A0", Offset = "0x277CBA0", Length = "0x67")]
	[Token(Token = "0x6000ADE")]
	public IAsyncOnRectTransformDimensionsChangeHandler GetOnRectTransformDimensionsChangeAsyncHandler() { }

	[Address(RVA = "0x277D810", Offset = "0x277CC10", Length = "0x7C")]
	[Token(Token = "0x6000ADF")]
	public IAsyncOnRectTransformDimensionsChangeHandler GetOnRectTransformDimensionsChangeAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277DAD0", Offset = "0x277CED0", Length = "0x6E")]
	[Token(Token = "0x6000ADD")]
	private void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x277D890", Offset = "0x277CC90", Length = "0x10C")]
	[Token(Token = "0x6000AE0")]
	public UniTask OnRectTransformDimensionsChangeAsync() { }

	[Address(RVA = "0x277D9A0", Offset = "0x277CDA0", Length = "0x122")]
	[Token(Token = "0x6000AE1")]
	public UniTask OnRectTransformDimensionsChangeAsync(CancellationToken cancellationToken) { }

}

