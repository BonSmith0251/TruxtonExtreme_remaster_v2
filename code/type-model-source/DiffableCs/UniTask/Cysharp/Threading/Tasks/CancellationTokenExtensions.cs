namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x2000017")]
public static class CancellationTokenExtensions
{
	[CompilerGenerated]
	[Token(Token = "0x2000018")]
	private struct <ToCancellationTokenCore>d__6 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000050")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000051")]
		public UniTask task; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000052")]
		public CancellationTokenSource cts; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000053")]
		private Awaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x273E220", Offset = "0x273D620", Length = "0x2C8")]
		[Token(Token = "0x6000096")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000097")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x400004D")]
	private static readonly Action<Object> cancellationTokenCallback; //Field offset: 0x0
	[Token(Token = "0x400004E")]
	private static readonly Action<Object> disposeCallback; //Field offset: 0x8

	[Address(RVA = "0x2731360", Offset = "0x2730760", Length = "0xE4")]
	[Token(Token = "0x6000095")]
	private static CancellationTokenExtensions() { }

	[Address(RVA = "0x27307F0", Offset = "0x272FBF0", Length = "0x9B")]
	[Extension]
	[Token(Token = "0x6000093")]
	public static CancellationTokenRegistration AddTo(IDisposable disposable, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2730890", Offset = "0x272FC90", Length = "0x78")]
	[Token(Token = "0x600008F")]
	private static void Callback(object state) { }

	[Address(RVA = "0x2730910", Offset = "0x272FD10", Length = "0x91")]
	[Token(Token = "0x6000094")]
	private static void DisposeCallback(object state) { }

	[Address(RVA = "0x27309B0", Offset = "0x272FDB0", Length = "0x16F")]
	[Extension]
	[Token(Token = "0x6000091")]
	public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(CancellationToken cancellationToken, Action callback) { }

	[Address(RVA = "0x2730B20", Offset = "0x272FF20", Length = "0x16E")]
	[Extension]
	[Token(Token = "0x6000092")]
	public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(CancellationToken cancellationToken, Action<Object> callback, object state) { }

	[Address(RVA = "0x2730FF0", Offset = "0x27303F0", Length = "0x127")]
	[Extension]
	[Token(Token = "0x6000089")]
	public static CancellationToken ToCancellationToken(UniTask task) { }

	[Address(RVA = "0x2730D40", Offset = "0x2730140", Length = "0x2A5")]
	[Extension]
	[Token(Token = "0x600008A")]
	public static CancellationToken ToCancellationToken(UniTask task, CancellationToken linkToken) { }

	[Address(RVA = "0x79CCC0", Offset = "0x79C0C0", Length = "0x89")]
	[Extension]
	[Token(Token = "0x600008B")]
	public static CancellationToken ToCancellationToken(UniTask<T> task) { }

	[Address(RVA = "0x79CD50", Offset = "0x79C150", Length = "0x9A")]
	[Extension]
	[Token(Token = "0x600008C")]
	public static CancellationToken ToCancellationToken(UniTask<T> task, CancellationToken linkToken) { }

	[Address(RVA = "0x2730C90", Offset = "0x2730090", Length = "0xAC")]
	[AsyncStateMachine(typeof(<ToCancellationTokenCore>d__6))]
	[Token(Token = "0x600008D")]
	private static UniTaskVoid ToCancellationTokenCore(UniTask task, CancellationTokenSource cts) { }

	[Address(RVA = "0x2731120", Offset = "0x2730520", Length = "0x219")]
	[Extension]
	[Token(Token = "0x600008E")]
	public static ValueTuple<UniTask, CancellationTokenRegistration> ToUniTask(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2731340", Offset = "0x2730740", Length = "0x1F")]
	[Extension]
	[Token(Token = "0x6000090")]
	public static CancellationTokenAwaitable WaitUntilCanceled(CancellationToken cancellationToken) { }

}

