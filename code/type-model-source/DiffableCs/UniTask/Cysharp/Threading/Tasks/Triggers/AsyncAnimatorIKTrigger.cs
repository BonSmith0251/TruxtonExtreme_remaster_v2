namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000179")]
public sealed class AsyncAnimatorIKTrigger : AsyncTriggerBase<Int32>
{

	[Address(RVA = "0x27708B0", Offset = "0x276FCB0", Length = "0x39")]
	[Token(Token = "0x60009D8")]
	public AsyncAnimatorIKTrigger() { }

	[Address(RVA = "0x2770530", Offset = "0x276F930", Length = "0x67")]
	[Token(Token = "0x60009D4")]
	public IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler() { }

	[Address(RVA = "0x27705A0", Offset = "0x276F9A0", Length = "0x7C")]
	[Token(Token = "0x60009D5")]
	public IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2770860", Offset = "0x276FC60", Length = "0x46")]
	[Token(Token = "0x60009D3")]
	private void OnAnimatorIK(int layerIndex) { }

	[Address(RVA = "0x2770620", Offset = "0x276FA20", Length = "0x10C")]
	[Token(Token = "0x60009D6")]
	public UniTask<Int32> OnAnimatorIKAsync() { }

	[Address(RVA = "0x2770730", Offset = "0x276FB30", Length = "0x122")]
	[Token(Token = "0x60009D7")]
	public UniTask<Int32> OnAnimatorIKAsync(CancellationToken cancellationToken) { }

}

