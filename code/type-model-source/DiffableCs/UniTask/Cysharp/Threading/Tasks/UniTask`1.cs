namespace Cysharp.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncUniTaskMethodBuilder`1))]
[IsReadOnly]
[Token(Token = "0x20000EA")]
public struct UniTask
{
	[IsReadOnly]
	[Token(Token = "0x20000ED")]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A0")]
		private readonly UniTask<T> task; //Field offset: 0x0

		[Token(Token = "0x17000040")]
		public bool IsCompleted
		{
			[Address(RVA = "0x1645E00", Offset = "0x1645200", Length = "0x6E")]
			[DebuggerHidden]
			[Token(Token = "0x600060A")]
			 get { } //Length: 110
		}

		[Address(RVA = "0x1645130", Offset = "0x1644530", Length = "0x1F")]
		[DebuggerHidden]
		[Token(Token = "0x6000609")]
		public Awaiter(in UniTask<T>& task) { }

		[Address(RVA = "0x1645E00", Offset = "0x1645200", Length = "0x6E")]
		[DebuggerHidden]
		[Token(Token = "0x600060A")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x1637710", Offset = "0x1636B10", Length = "0xA8")]
		[DebuggerHidden]
		[Token(Token = "0x600060B")]
		public T GetResult() { }

		[Address(RVA = "0x163B5D0", Offset = "0x163A9D0", Length = "0xC9")]
		[DebuggerHidden]
		[Token(Token = "0x600060C")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x163D050", Offset = "0x163C450", Length = "0x99")]
		[DebuggerHidden]
		[Token(Token = "0x600060E")]
		public void SourceOnCompleted(Action<Object> continuation, object state) { }

		[Address(RVA = "0x1642350", Offset = "0x1641750", Length = "0xC9")]
		[DebuggerHidden]
		[Token(Token = "0x600060D")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[Token(Token = "0x20000EB")]
	private sealed class IsCanceledSource : IUniTaskSource<ValueTuple`2<Boolean, T>>, IUniTaskSource
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039B")]
		private readonly IUniTaskSource<T> source; //Field offset: 0x0

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[DebuggerHidden]
		[Token(Token = "0x60005FD")]
		public IsCanceledSource(IUniTaskSource<T> source) { }

		[Address(RVA = "0xAA7120", Offset = "0xAA6520", Length = "0x148")]
		[DebuggerHidden]
		[Token(Token = "0x60005FF")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0xAB1740", Offset = "0xAB0B40", Length = "0x13E")]
		[DebuggerHidden]
		[Token(Token = "0x60005FE")]
		public override ValueTuple<Boolean, T> GetResult(short token) { }

		[Address(RVA = "0xAB4830", Offset = "0xAB3C30", Length = "0x56")]
		[DebuggerHidden]
		[Token(Token = "0x6000600")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0xAB7AD0", Offset = "0xAB6ED0", Length = "0x7E")]
		[DebuggerHidden]
		[Token(Token = "0x6000602")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0xABD460", Offset = "0xABC860", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000601")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000EC")]
	private sealed class MemoizeSource : IUniTaskSource<T>, IUniTaskSource
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039C")]
		private IUniTaskSource<T> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039D")]
		private T result; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039E")]
		private ExceptionDispatchInfo exception; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039F")]
		private UniTaskStatus status; //Field offset: 0x0

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000603")]
		public MemoizeSource(IUniTaskSource<T> source) { }

		[Address(RVA = "0xCF8140", Offset = "0xCF7540", Length = "0x29")]
		[Token(Token = "0x6000605")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0xCF93E0", Offset = "0xCF87E0", Length = "0x277")]
		[Token(Token = "0x6000604")]
		public override T GetResult(short token) { }

		[Address(RVA = "0xCFE620", Offset = "0xCFDA20", Length = "0x61")]
		[Token(Token = "0x6000606")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0xD01AC0", Offset = "0xD00EC0", Length = "0x98")]
		[Token(Token = "0x6000607")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0xD05930", Offset = "0xD04D30", Length = "0x4F")]
		[Token(Token = "0x6000608")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000398")]
	private readonly IUniTaskSource<T> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000399")]
	private readonly T result; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400039A")]
	private readonly short token; //Field offset: 0x0

	[Token(Token = "0x1700003F")]
	public UniTaskStatus Status
	{
		[Address(RVA = "0x1131630", Offset = "0x1130A30", Length = "0x51")]
		[DebuggerHidden]
		[Token(Token = "0x60005F6")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x1131200", Offset = "0x1130600", Length = "0x46")]
	[DebuggerHidden]
	[Token(Token = "0x60005F4")]
	public UniTask`1(T result) { }

	[Address(RVA = "0x11312D0", Offset = "0x11306D0", Length = "0x35")]
	[DebuggerHidden]
	[Token(Token = "0x60005F5")]
	public UniTask`1(IUniTaskSource<T> source, short token) { }

	[Address(RVA = "0x112C7D0", Offset = "0x112BBD0", Length = "0x1C7")]
	[Token(Token = "0x60005F9")]
	public UniTask AsUniTask() { }

	[Address(RVA = "0x1131630", Offset = "0x1130A30", Length = "0x51")]
	[DebuggerHidden]
	[Token(Token = "0x60005F6")]
	public UniTaskStatus get_Status() { }

	[Address(RVA = "0x112D270", Offset = "0x112C670", Length = "0x62")]
	[DebuggerHidden]
	[Token(Token = "0x60005F7")]
	public Awaiter<T> GetAwaiter() { }

	[Address(RVA = "0x1131FF0", Offset = "0x11313F0", Length = "0x53")]
	[Token(Token = "0x60005FA")]
	public static UniTask op_Implicit(UniTask<T> self) { }

	[Address(RVA = "0x112D9C0", Offset = "0x112CDC0", Length = "0x123")]
	[Token(Token = "0x60005F8")]
	public UniTask<T> Preserve() { }

	[Address(RVA = "0x112E400", Offset = "0x112D800", Length = "0x1BD")]
	[Token(Token = "0x60005FB")]
	public UniTask<ValueTuple`2<Boolean, T>> SuppressCancellationThrow() { }

	[Address(RVA = "0x112F490", Offset = "0x112E890", Length = "0x11C")]
	[Token(Token = "0x60005FC")]
	public virtual string ToString() { }

}

