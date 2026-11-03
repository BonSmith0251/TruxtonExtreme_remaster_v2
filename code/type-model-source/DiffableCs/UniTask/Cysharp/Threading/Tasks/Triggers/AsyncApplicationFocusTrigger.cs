namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200017D")]
public sealed class AsyncApplicationFocusTrigger : AsyncTriggerBase<Boolean>
{

	[Address(RVA = "0x2771050", Offset = "0x2770450", Length = "0x39")]
	[Token(Token = "0x60009E6")]
	public AsyncApplicationFocusTrigger() { }

	[Address(RVA = "0x2770CD0", Offset = "0x27700D0", Length = "0x67")]
	[Token(Token = "0x60009E2")]
	public IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler() { }

	[Address(RVA = "0x2770D40", Offset = "0x2770140", Length = "0x7C")]
	[Token(Token = "0x60009E3")]
	public IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2771000", Offset = "0x2770400", Length = "0x48")]
	[Token(Token = "0x60009E1")]
	private void OnApplicationFocus(bool hasFocus) { }

	[Address(RVA = "0x2770EF0", Offset = "0x27702F0", Length = "0x10C")]
	[Token(Token = "0x60009E4")]
	public UniTask<Boolean> OnApplicationFocusAsync() { }

	[Address(RVA = "0x2770DC0", Offset = "0x27701C0", Length = "0x122")]
	[Token(Token = "0x60009E5")]
	public UniTask<Boolean> OnApplicationFocusAsync(CancellationToken cancellationToken) { }

}

