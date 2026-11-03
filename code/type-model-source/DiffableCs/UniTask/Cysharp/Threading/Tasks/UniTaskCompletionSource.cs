namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200010B")]
public class UniTaskCompletionSource : IUniTaskSource, IPromise, IResolvePromise, IRejectPromise, ICancelPromise
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003D5")]
	private CancellationToken cancellationToken; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003D6")]
	private ExceptionHolder exception; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003D7")]
	private object gate; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003D8")]
	private Action<Object> singleContinuation; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003D9")]
	private object singleState; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003DA")]
	private List<ValueTuple`2<Action`1<Object>, Object>> secondaryContinuationList; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003DB")]
	private int intStatus; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40003DC")]
	private bool handled; //Field offset: 0x44

	[Token(Token = "0x1700004D")]
	public UniTask Task
	{
		[Address(RVA = "0x2741BF0", Offset = "0x2740FF0", Length = "0x2D")]
		[DebuggerHidden]
		[Token(Token = "0x6000686")]
		 get { } //Length: 45
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000684")]
	public UniTaskCompletionSource() { }

	[Address(RVA = "0x2741BF0", Offset = "0x2740FF0", Length = "0x2D")]
	[DebuggerHidden]
	[Token(Token = "0x6000686")]
	public UniTask get_Task() { }

	[Address(RVA = "0x2741360", Offset = "0x2740760", Length = "0x101")]
	[DebuggerHidden]
	[Token(Token = "0x600068A")]
	public override void GetResult(short token) { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[DebuggerHidden]
	[Token(Token = "0x600068B")]
	public override UniTaskStatus GetStatus(short token) { }

	[Address(RVA = "0x2741470", Offset = "0x2740870", Length = "0xB")]
	[DebuggerHidden]
	[Token(Token = "0x6000685")]
	internal void MarkHandled() { }

	[Address(RVA = "0x2741480", Offset = "0x2740880", Length = "0x2BB")]
	[DebuggerHidden]
	[Token(Token = "0x600068D")]
	public override void OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x2741740", Offset = "0x2740B40", Length = "0x3B")]
	[DebuggerHidden]
	[Token(Token = "0x6000688")]
	public override bool TrySetCanceled(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2741780", Offset = "0x2740B80", Length = "0x11F")]
	[DebuggerHidden]
	[Token(Token = "0x6000689")]
	public override bool TrySetException(Exception exception) { }

	[Address(RVA = "0x27418A0", Offset = "0x2740CA0", Length = "0xD")]
	[DebuggerHidden]
	[Token(Token = "0x6000687")]
	public override bool TrySetResult() { }

	[Address(RVA = "0x27418B0", Offset = "0x2740CB0", Length = "0x336")]
	[DebuggerHidden]
	[Token(Token = "0x600068E")]
	private bool TrySignalCompletion(UniTaskStatus status) { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[DebuggerHidden]
	[Token(Token = "0x600068C")]
	public override UniTaskStatus UnsafeGetStatus() { }

}

