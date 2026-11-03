namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200003D")]
public abstract class MoveNextSource : IUniTaskSource<Boolean>, IUniTaskSource
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009C")]
	protected UniTaskCompletionSourceCore<Boolean> completionSource; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600012F")]
	protected MoveNextSource() { }

	[Address(RVA = "0x2735100", Offset = "0x2734500", Length = "0x49")]
	[Token(Token = "0x600012C")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

	[Address(RVA = "0x2735150", Offset = "0x2734550", Length = "0x49")]
	[Token(Token = "0x6000128")]
	public override bool GetResult(short token) { }

	[Address(RVA = "0x27351A0", Offset = "0x27345A0", Length = "0x14E")]
	[Token(Token = "0x6000129")]
	public override UniTaskStatus GetStatus(short token) { }

	[Address(RVA = "0x27352F0", Offset = "0x27346F0", Length = "0x1D0")]
	[Token(Token = "0x600012A")]
	public override void OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x88A850", Offset = "0x889C50", Length = "0x11F")]
	[Token(Token = "0x600012D")]
	protected bool TryGetResult(Awaiter<T> awaiter, out T result) { }

	[Address(RVA = "0x27354D0", Offset = "0x27348D0", Length = "0x76")]
	[Token(Token = "0x600012E")]
	protected bool TryGetResult(Awaiter awaiter) { }

	[Address(RVA = "0x2735550", Offset = "0x2734950", Length = "0xAD")]
	[Token(Token = "0x600012B")]
	public override UniTaskStatus UnsafeGetStatus() { }

}

