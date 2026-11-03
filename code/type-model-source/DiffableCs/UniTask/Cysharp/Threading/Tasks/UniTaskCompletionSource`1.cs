namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200010C")]
public class UniTaskCompletionSource : IUniTaskSource<T>, IUniTaskSource, IPromise<T>, IResolvePromise<T>, IRejectPromise, ICancelPromise
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003DD")]
	private CancellationToken cancellationToken; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003DE")]
	private T result; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003DF")]
	private ExceptionHolder exception; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E0")]
	private object gate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E1")]
	private Action<Object> singleContinuation; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E2")]
	private object singleState; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E3")]
	private List<ValueTuple`2<Action`1<Object>, Object>> secondaryContinuationList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E4")]
	private int intStatus; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E5")]
	private bool handled; //Field offset: 0x0

	[Token(Token = "0x1700004E")]
	public UniTask<T> Task
	{
		[Address(RVA = "0x112A360", Offset = "0x1129760", Length = "0x32")]
		[DebuggerHidden]
		[Token(Token = "0x6000691")]
		 get { } //Length: 50
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600068F")]
	public UniTaskCompletionSource`1() { }

	[Address(RVA = "0x1128840", Offset = "0x1127C40", Length = "0xF3")]
	[DebuggerHidden]
	[Token(Token = "0x6000696")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

	[Address(RVA = "0x112A360", Offset = "0x1129760", Length = "0x32")]
	[DebuggerHidden]
	[Token(Token = "0x6000691")]
	public UniTask<T> get_Task() { }

	[Address(RVA = "0x1128C30", Offset = "0x1128030", Length = "0xF7")]
	[DebuggerHidden]
	[Token(Token = "0x6000695")]
	public override T GetResult(short token) { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[DebuggerHidden]
	[Token(Token = "0x6000697")]
	public override UniTaskStatus GetStatus(short token) { }

	[Address(RVA = "0x1128DF0", Offset = "0x11281F0", Length = "0xB")]
	[DebuggerHidden]
	[Token(Token = "0x6000690")]
	internal void MarkHandled() { }

	[Address(RVA = "0x1128E00", Offset = "0x1128200", Length = "0x2BB")]
	[DebuggerHidden]
	[Token(Token = "0x6000699")]
	public override void OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x11294F0", Offset = "0x11288F0", Length = "0x58")]
	[DebuggerHidden]
	[Token(Token = "0x6000693")]
	public override bool TrySetCanceled(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1129790", Offset = "0x1128B90", Length = "0x120")]
	[DebuggerHidden]
	[Token(Token = "0x6000694")]
	public override bool TrySetException(Exception exception) { }

	[Address(RVA = "0x11298B0", Offset = "0x1128CB0", Length = "0x25")]
	[DebuggerHidden]
	[Token(Token = "0x6000692")]
	public override bool TrySetResult(T result) { }

	[Address(RVA = "0x11299F0", Offset = "0x1128DF0", Length = "0x336")]
	[DebuggerHidden]
	[Token(Token = "0x600069A")]
	private bool TrySignalCompletion(UniTaskStatus status) { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[DebuggerHidden]
	[Token(Token = "0x6000698")]
	public override UniTaskStatus UnsafeGetStatus() { }

}

