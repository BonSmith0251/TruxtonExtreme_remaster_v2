namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001E5")]
public sealed class AsyncUpdateTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2785890", Offset = "0x2784C90", Length = "0x39")]
	[Token(Token = "0x6000B52")]
	public AsyncUpdateTrigger() { }

	[Address(RVA = "0x2785570", Offset = "0x2784970", Length = "0x67")]
	[Token(Token = "0x6000B4E")]
	public IAsyncUpdateHandler GetUpdateAsyncHandler() { }

	[Address(RVA = "0x27854F0", Offset = "0x27848F0", Length = "0x7C")]
	[Token(Token = "0x6000B4F")]
	public IAsyncUpdateHandler GetUpdateAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2785820", Offset = "0x2784C20", Length = "0x6E")]
	[Token(Token = "0x6000B4D")]
	private void Update() { }

	[Address(RVA = "0x27855E0", Offset = "0x27849E0", Length = "0x10C")]
	[Token(Token = "0x6000B50")]
	public UniTask UpdateAsync() { }

	[Address(RVA = "0x27856F0", Offset = "0x2784AF0", Length = "0x122")]
	[Token(Token = "0x6000B51")]
	public UniTask UpdateAsync(CancellationToken cancellationToken) { }

}

