namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001D7")]
public sealed class AsyncTriggerExitTrigger : AsyncTriggerBase<Collider>
{

	[Address(RVA = "0x2780E20", Offset = "0x2780220", Length = "0x39")]
	[Token(Token = "0x6000B21")]
	public AsyncTriggerExitTrigger() { }

	[Address(RVA = "0x2780BD0", Offset = "0x277FFD0", Length = "0x67")]
	[Token(Token = "0x6000B1D")]
	public IAsyncOnTriggerExitHandler GetOnTriggerExitAsyncHandler() { }

	[Address(RVA = "0x2780B50", Offset = "0x277FF50", Length = "0x7C")]
	[Token(Token = "0x6000B1E")]
	public IAsyncOnTriggerExitHandler GetOnTriggerExitAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2780DD0", Offset = "0x27801D0", Length = "0x48")]
	[Token(Token = "0x6000B1C")]
	private void OnTriggerExit(Collider other) { }

	[Address(RVA = "0x2780D10", Offset = "0x2780110", Length = "0xB0")]
	[Token(Token = "0x6000B1F")]
	public UniTask<Collider> OnTriggerExitAsync() { }

	[Address(RVA = "0x2780C40", Offset = "0x2780040", Length = "0xC5")]
	[Token(Token = "0x6000B20")]
	public UniTask<Collider> OnTriggerExitAsync(CancellationToken cancellationToken) { }

}

