namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000150")]
internal class SyncSelectorAsyncEnumerableSorter : AsyncEnumerableSorter<TElement>
{
	[CompilerGenerated]
	[Token(Token = "0x2000151")]
	private struct <ComputeKeysAsync>d__6 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E47")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E48")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E49")]
		public SyncSelectorAsyncEnumerableSorter<TElement, TKey> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E4A")]
		public int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E4B")]
		public TElement[] elements; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E4C")]
		private Awaiter <>u__1; //Field offset: 0x0

		[Address(RVA = "0x113FA70", Offset = "0x113EE70", Length = "0x502")]
		[Token(Token = "0x600067B")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600067C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E42")]
	private readonly Func<TElement, TKey> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E43")]
	private readonly IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E44")]
	private readonly bool descending; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E45")]
	private readonly AsyncEnumerableSorter<TElement> next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E46")]
	private TKey[] keys; //Field offset: 0x0

	[Address(RVA = "0xFD9770", Offset = "0xFD8B70", Length = "0x83")]
	[Token(Token = "0x6000678")]
	internal SyncSelectorAsyncEnumerableSorter`2(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, AsyncEnumerableSorter<TElement> next) { }

	[Address(RVA = "0xFD9370", Offset = "0xFD8770", Length = "0x220")]
	[Token(Token = "0x600067A")]
	internal virtual int CompareKeys(int index1, int index2) { }

	[Address(RVA = "0xFD95A0", Offset = "0xFD89A0", Length = "0x1C7")]
	[AsyncStateMachine(typeof(<ComputeKeysAsync>d__6))]
	[Token(Token = "0x6000679")]
	internal virtual UniTask ComputeKeysAsync(TElement[] elements, int count) { }

}

