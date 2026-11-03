namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200018D")]
public sealed class AsyncCollisionEnterTrigger : AsyncTriggerBase<Collision>
{

	[Address(RVA = "0x2773580", Offset = "0x2772980", Length = "0x39")]
	[Token(Token = "0x6000A1E")]
	public AsyncCollisionEnterTrigger() { }

	[Address(RVA = "0x27732B0", Offset = "0x27726B0", Length = "0x67")]
	[Token(Token = "0x6000A1A")]
	public IAsyncOnCollisionEnterHandler GetOnCollisionEnterAsyncHandler() { }

	[Address(RVA = "0x2773320", Offset = "0x2772720", Length = "0x7C")]
	[Token(Token = "0x6000A1B")]
	public IAsyncOnCollisionEnterHandler GetOnCollisionEnterAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2773530", Offset = "0x2772930", Length = "0x48")]
	[Token(Token = "0x6000A19")]
	private void OnCollisionEnter(Collision coll) { }

	[Address(RVA = "0x2773470", Offset = "0x2772870", Length = "0xB0")]
	[Token(Token = "0x6000A1C")]
	public UniTask<Collision> OnCollisionEnterAsync() { }

	[Address(RVA = "0x27733A0", Offset = "0x27727A0", Length = "0xC5")]
	[Token(Token = "0x6000A1D")]
	public UniTask<Collision> OnCollisionEnterAsync(CancellationToken cancellationToken) { }

}

