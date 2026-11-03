namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001DF")]
public sealed class AsyncValidateTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2785C70", Offset = "0x2785070", Length = "0x39")]
	[Token(Token = "0x6000B3D")]
	public AsyncValidateTrigger() { }

	[Address(RVA = "0x2785950", Offset = "0x2784D50", Length = "0x67")]
	[Token(Token = "0x6000B39")]
	public IAsyncOnValidateHandler GetOnValidateAsyncHandler() { }

	[Address(RVA = "0x27858D0", Offset = "0x2784CD0", Length = "0x7C")]
	[Token(Token = "0x6000B3A")]
	public IAsyncOnValidateHandler GetOnValidateAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2785C00", Offset = "0x2785000", Length = "0x6E")]
	[Token(Token = "0x6000B38")]
	private void OnValidate() { }

	[Address(RVA = "0x27859C0", Offset = "0x2784DC0", Length = "0x10C")]
	[Token(Token = "0x6000B3B")]
	public UniTask OnValidateAsync() { }

	[Address(RVA = "0x2785AD0", Offset = "0x2784ED0", Length = "0x122")]
	[Token(Token = "0x6000B3C")]
	public UniTask OnValidateAsync(CancellationToken cancellationToken) { }

}

