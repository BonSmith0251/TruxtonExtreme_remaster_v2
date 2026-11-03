namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200015E")]
public class AsyncUnityEventHandler : IUniTaskSource<T>, IUniTaskSource, IDisposable, IAsyncValueChangedEventHandler<T>, IAsyncEndEditEventHandler<T>, IAsyncEndTextSelectionEventHandler<T>, IAsyncTextSelectionEventHandler<T>, IAsyncDeselectEventHandler<T>, IAsyncSelectEventHandler<T>, IAsyncSubmitEventHandler<T>
{
	[Token(Token = "0x400052C")]
	private static Action<Object> cancellationCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400052D")]
	private readonly UnityAction<T> action; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400052E")]
	private readonly UnityEvent<T> unityEvent; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400052F")]
	private CancellationToken cancellationToken; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000530")]
	private CancellationTokenRegistration registration; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000531")]
	private bool isDisposed; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000532")]
	private bool callOnce; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000533")]
	private UniTaskCompletionSourceCore<T> core; //Field offset: 0x0

	[Address(RVA = "0x1632290", Offset = "0x1631690", Length = "0xED")]
	[Token(Token = "0x600086A")]
	private static AsyncUnityEventHandler`1() { }

	[Address(RVA = "0x16330D0", Offset = "0x16324D0", Length = "0x230")]
	[Token(Token = "0x6000859")]
	public AsyncUnityEventHandler`1(UnityEvent<T> unityEvent, CancellationToken cancellationToken, bool callOnce) { }

	[Address(RVA = "0x162FAA0", Offset = "0x162EEA0", Length = "0x129")]
	[Token(Token = "0x600085C")]
	private static void CancellationCallback(object state) { }

	[Address(RVA = "0x1630420", Offset = "0x162F820", Length = "0xA6")]
	[Token(Token = "0x6000862")]
	private override UniTask<T> Cysharp.Threading.Tasks.IAsyncDeselectEventHandler<T>.OnDeselectAsync() { }

	[Address(RVA = "0x1630420", Offset = "0x162F820", Length = "0xA6")]
	[Token(Token = "0x600085F")]
	private override UniTask<T> Cysharp.Threading.Tasks.IAsyncEndEditEventHandler<T>.OnEndEditAsync() { }

	[Address(RVA = "0x1630420", Offset = "0x162F820", Length = "0xA6")]
	[Token(Token = "0x6000860")]
	private override UniTask<T> Cysharp.Threading.Tasks.IAsyncEndTextSelectionEventHandler<T>.OnEndTextSelectionAsync() { }

	[Address(RVA = "0x1630420", Offset = "0x162F820", Length = "0xA6")]
	[Token(Token = "0x6000863")]
	private override UniTask<T> Cysharp.Threading.Tasks.IAsyncSelectEventHandler<T>.OnSelectAsync() { }

	[Address(RVA = "0x1630420", Offset = "0x162F820", Length = "0xA6")]
	[Token(Token = "0x6000864")]
	private override UniTask<T> Cysharp.Threading.Tasks.IAsyncSubmitEventHandler<T>.OnSubmitAsync() { }

	[Address(RVA = "0x1630420", Offset = "0x162F820", Length = "0xA6")]
	[Token(Token = "0x6000861")]
	private override UniTask<T> Cysharp.Threading.Tasks.IAsyncTextSelectionEventHandler<T>.OnTextSelectionAsync() { }

	[Address(RVA = "0x1630420", Offset = "0x162F820", Length = "0xA6")]
	[Token(Token = "0x600085E")]
	private override UniTask<T> Cysharp.Threading.Tasks.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync() { }

	[Address(RVA = "0x1630B60", Offset = "0x162FF60", Length = "0xB9")]
	[Token(Token = "0x6000866")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

	[Address(RVA = "0x1630F90", Offset = "0x1630390", Length = "0x1B")]
	[Token(Token = "0x6000867")]
	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token) { }

	[Address(RVA = "0x1630FD0", Offset = "0x16303D0", Length = "0x25")]
	[Token(Token = "0x6000869")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x1631320", Offset = "0x1630720", Length = "0x1B")]
	[Token(Token = "0x6000868")]
	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus() { }

	[Address(RVA = "0x16309F0", Offset = "0x162FDF0", Length = "0xA7")]
	[Token(Token = "0x6000865")]
	private override T Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(short token) { }

	[Address(RVA = "0x1631600", Offset = "0x1630A00", Length = "0xBC")]
	[Token(Token = "0x600085D")]
	public override void Dispose() { }

	[Address(RVA = "0x1631BC0", Offset = "0x1630FC0", Length = "0x1B")]
	[Token(Token = "0x600085B")]
	private void Invoke(T result) { }

	[Address(RVA = "0x1632020", Offset = "0x1631420", Length = "0x88")]
	[Token(Token = "0x600085A")]
	public UniTask<T> OnInvokeAsync() { }

}

