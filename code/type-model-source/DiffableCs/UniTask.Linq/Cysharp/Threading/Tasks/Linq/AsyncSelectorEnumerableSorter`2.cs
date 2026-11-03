namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000152")]
internal class AsyncSelectorEnumerableSorter : AsyncEnumerableSorter<TElement>
{
	[CompilerGenerated]
	[Token(Token = "0x2000153")]
	private struct <ComputeKeysAsync>d__6 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E52")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E53")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E54")]
		public AsyncSelectorEnumerableSorter<TElement, TKey> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E55")]
		public int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E56")]
		public TElement[] elements; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E57")]
		private int <i>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E58")]
		private TKey[] <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E59")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E5A")]
		private Awaiter<TKey> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E5B")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x113FF80", Offset = "0x113F380", Length = "0x1075")]
		[Token(Token = "0x6000680")]
		private override void MoveNext() { }

		[Address(RVA = "0x113D7A0", Offset = "0x113CBA0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000681")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E4D")]
	private readonly Func<TElement, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E4E")]
	private readonly IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E4F")]
	private readonly bool descending; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E50")]
	private readonly AsyncEnumerableSorter<TElement> next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E51")]
	private TKey[] keys; //Field offset: 0x0

	[Address(RVA = "0xFD9770", Offset = "0xFD8B70", Length = "0x83")]
	[Token(Token = "0x600067D")]
	internal AsyncSelectorEnumerableSorter`2(Func<TElement, UniTask`1<TKey>> keySelector, IComparer<TKey> comparer, bool descending, AsyncEnumerableSorter<TElement> next) { }

	[Address(RVA = "0x1169650", Offset = "0x1168A50", Length = "0x1B9")]
	[Token(Token = "0x600067F")]
	internal virtual int CompareKeys(int index1, int index2) { }

	[Address(RVA = "0x1169810", Offset = "0x1168C10", Length = "0x261")]
	[AsyncStateMachine(typeof(<ComputeKeysAsync>d__6))]
	[Token(Token = "0x600067E")]
	internal virtual UniTask ComputeKeysAsync(TElement[] elements, int count) { }

}

