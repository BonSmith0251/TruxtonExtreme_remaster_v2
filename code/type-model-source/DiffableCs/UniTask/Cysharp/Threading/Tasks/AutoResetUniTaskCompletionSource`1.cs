namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000109")]
public class AutoResetUniTaskCompletionSource : IUniTaskSource<T>, IUniTaskSource, ITaskPoolNode<AutoResetUniTaskCompletionSource`1<T>>, IPromise<T>, IResolvePromise<T>, IRejectPromise, ICancelPromise
{
	[CompilerGenerated]
	[Token(Token = "0x200010A")]
	private sealed class <>c
	{
		[Token(Token = "0x40003D4")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000681")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000682")]
		public <>c() { }

		[Address(RVA = "0xA35A50", Offset = "0xA34E50", Length = "0x77")]
		[Token(Token = "0x6000683")]
		internal int <.cctor>b__4_0() { }

	}

	[Token(Token = "0x40003D1")]
	private static TaskPool<AutoResetUniTaskCompletionSource`1<T>> pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003D2")]
	private AutoResetUniTaskCompletionSource<T> nextNode; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003D3")]
	private UniTaskCompletionSourceCore<T> core; //Field offset: 0x0

	[Token(Token = "0x1700004B")]
	public override AutoResetUniTaskCompletionSource<T>& NextNode
	{
		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x6000670")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004C")]
	public UniTask<T> Task
	{
		[Address(RVA = "0x1637400", Offset = "0x1636800", Length = "0x40")]
		[DebuggerHidden]
		[Token(Token = "0x6000677")]
		 get { } //Length: 64
	}

	[Address(RVA = "0x1637140", Offset = "0x1636540", Length = "0x172")]
	[Token(Token = "0x6000671")]
	private static AutoResetUniTaskCompletionSource`1() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000672")]
	private AutoResetUniTaskCompletionSource`1() { }

	[Address(RVA = "0x1635C70", Offset = "0x1635070", Length = "0x136")]
	[DebuggerHidden]
	[Token(Token = "0x6000673")]
	public static AutoResetUniTaskCompletionSource<T> Create() { }

	[Address(RVA = "0x16352F0", Offset = "0x16346F0", Length = "0x103")]
	[DebuggerHidden]
	[Token(Token = "0x6000674")]
	public static AutoResetUniTaskCompletionSource<T> CreateFromCanceled(CancellationToken cancellationToken, out short token) { }

	[Address(RVA = "0x1635400", Offset = "0x1634800", Length = "0x103")]
	[DebuggerHidden]
	[Token(Token = "0x6000675")]
	public static AutoResetUniTaskCompletionSource<T> CreateFromException(Exception exception, out short token) { }

	[Address(RVA = "0x1635B60", Offset = "0x1634F60", Length = "0x10E")]
	[DebuggerHidden]
	[Token(Token = "0x6000676")]
	public static AutoResetUniTaskCompletionSource<T> CreateFromResult(T result, out short token) { }

	[Address(RVA = "0x1636030", Offset = "0x1635430", Length = "0x2C")]
	[DebuggerHidden]
	[Token(Token = "0x600067C")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

	[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
	[Token(Token = "0x6000670")]
	public override AutoResetUniTaskCompletionSource<T>& get_NextNode() { }

	[Address(RVA = "0x1637400", Offset = "0x1636800", Length = "0x40")]
	[DebuggerHidden]
	[Token(Token = "0x6000677")]
	public UniTask<T> get_Task() { }

	[Address(RVA = "0x1636250", Offset = "0x1635650", Length = "0x97")]
	[DebuggerHidden]
	[Token(Token = "0x600067B")]
	public override T GetResult(short token) { }

	[Address(RVA = "0x1636410", Offset = "0x1635810", Length = "0x13D")]
	[DebuggerHidden]
	[Token(Token = "0x600067D")]
	public override UniTaskStatus GetStatus(short token) { }

	[Address(RVA = "0x1636550", Offset = "0x1635950", Length = "0x1C7")]
	[DebuggerHidden]
	[Token(Token = "0x600067F")]
	public override void OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x16367F0", Offset = "0x1635BF0", Length = "0xA9")]
	[DebuggerHidden]
	[Token(Token = "0x6000680")]
	private bool TryReturn() { }

	[Address(RVA = "0x1636AD0", Offset = "0x1635ED0", Length = "0x1B")]
	[DebuggerHidden]
	[Token(Token = "0x6000679")]
	public override bool TrySetCanceled(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1636B80", Offset = "0x1635F80", Length = "0x1B")]
	[DebuggerHidden]
	[Token(Token = "0x600067A")]
	public override bool TrySetException(Exception exception) { }

	[Address(RVA = "0x1636CC0", Offset = "0x16360C0", Length = "0x31")]
	[DebuggerHidden]
	[Token(Token = "0x6000678")]
	public override bool TrySetResult(T result) { }

	[Address(RVA = "0x1636D40", Offset = "0x1636140", Length = "0x91")]
	[DebuggerHidden]
	[Token(Token = "0x600067E")]
	public override UniTaskStatus UnsafeGetStatus() { }

}

