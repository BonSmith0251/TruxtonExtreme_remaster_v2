namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000154")]
internal class AsyncSelectorWithCancellationEnumerableSorter : AsyncEnumerableSorter<TElement>
{
	[CompilerGenerated]
	[Token(Token = "0x2000155")]
	private struct <ComputeKeysAsync>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E62")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E63")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E64")]
		public AsyncSelectorWithCancellationEnumerableSorter<TElement, TKey> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E65")]
		public int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E66")]
		public TElement[] elements; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E67")]
		private int <i>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E68")]
		private TKey[] <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E69")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E6A")]
		private Awaiter<TKey> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E6B")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1141000", Offset = "0x1140400", Length = "0x1097")]
		[Token(Token = "0x6000685")]
		private override void MoveNext() { }

		[Address(RVA = "0x113D7A0", Offset = "0x113CBA0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000686")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E5C")]
	private readonly Func<TElement, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E5D")]
	private readonly IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E5E")]
	private readonly bool descending; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E5F")]
	private readonly AsyncEnumerableSorter<TElement> next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E60")]
	private CancellationToken cancellationToken; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E61")]
	private TKey[] keys; //Field offset: 0x0

	[Address(RVA = "0x1169C40", Offset = "0x1169040", Length = "0x97")]
	[Token(Token = "0x6000682")]
	internal AsyncSelectorWithCancellationEnumerableSorter`2(Func<TElement, CancellationToken, UniTask`1<TKey>> keySelector, IComparer<TKey> comparer, bool descending, AsyncEnumerableSorter<TElement> next, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1169A80", Offset = "0x1168E80", Length = "0x1B9")]
	[Token(Token = "0x6000684")]
	internal virtual int CompareKeys(int index1, int index2) { }

	[Address(RVA = "0x1169810", Offset = "0x1168C10", Length = "0x261")]
	[AsyncStateMachine(typeof(<ComputeKeysAsync>d__7))]
	[Token(Token = "0x6000683")]
	internal virtual UniTask ComputeKeysAsync(TElement[] elements, int count) { }

}

