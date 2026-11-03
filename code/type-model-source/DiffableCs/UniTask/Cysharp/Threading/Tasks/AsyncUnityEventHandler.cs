namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200015D")]
public class AsyncUnityEventHandler : IUniTaskSource, IDisposable, IAsyncClickEventHandler
{
	[Token(Token = "0x4000524")]
	private static Action<Object> cancellationCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000525")]
	private readonly UnityAction action; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000526")]
	private readonly UnityEvent unityEvent; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000527")]
	private CancellationToken cancellationToken; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000528")]
	private CancellationTokenRegistration registration; //Field offset: 0x28
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000529")]
	private bool isDisposed; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x400052A")]
	private bool callOnce; //Field offset: 0x41
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400052B")]
	private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x48

	[Address(RVA = "0x2784F60", Offset = "0x2784360", Length = "0x89")]
	[Token(Token = "0x6000858")]
	private static AsyncUnityEventHandler() { }

	[Address(RVA = "0x2784FF0", Offset = "0x27843F0", Length = "0x1E4")]
	[Token(Token = "0x600084E")]
	public AsyncUnityEventHandler(UnityEvent unityEvent, CancellationToken cancellationToken, bool callOnce) { }

	[Address(RVA = "0x2784AF0", Offset = "0x2783EF0", Length = "0x72")]
	[Token(Token = "0x6000851")]
	private static void CancellationCallback(object state) { }

	[Address(RVA = "0x2784B70", Offset = "0x2783F70", Length = "0xB2")]
	[Token(Token = "0x6000853")]
	private override UniTask Cysharp.Threading.Tasks.IAsyncClickEventHandler.OnClickAsync() { }

	[Address(RVA = "0x2784C30", Offset = "0x2784030", Length = "0x90")]
	[Token(Token = "0x6000854")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

	[Address(RVA = "0x2784CD0", Offset = "0x27840D0", Length = "0x49")]
	[Token(Token = "0x6000855")]
	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token) { }

	[Address(RVA = "0x2784D20", Offset = "0x2784120", Length = "0x70")]
	[Token(Token = "0x6000857")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x2784D90", Offset = "0x2784190", Length = "0x3A")]
	[Token(Token = "0x6000856")]
	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus() { }

	[Address(RVA = "0x2784DD0", Offset = "0x27841D0", Length = "0x70")]
	[Token(Token = "0x6000852")]
	public override void Dispose() { }

	[Address(RVA = "0x2784E40", Offset = "0x2784240", Length = "0x6F")]
	[Token(Token = "0x6000850")]
	private void Invoke() { }

	[Address(RVA = "0x2784EB0", Offset = "0x27842B0", Length = "0xA4")]
	[Token(Token = "0x600084F")]
	public UniTask OnInvokeAsync() { }

}

