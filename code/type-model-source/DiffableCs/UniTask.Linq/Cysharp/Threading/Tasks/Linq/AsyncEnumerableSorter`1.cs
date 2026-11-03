namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200014E")]
internal abstract class AsyncEnumerableSorter
{
	[CompilerGenerated]
	[Token(Token = "0x200014F")]
	private struct <SortAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E3C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E3D")]
		public AsyncUniTaskMethodBuilder<Int32[]> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E3E")]
		public AsyncEnumerableSorter<TElement> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E3F")]
		public TElement[] elements; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E40")]
		public int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E41")]
		private Awaiter <>u__1; //Field offset: 0x0

		[Address(RVA = "0x19DE150", Offset = "0x19DD550", Length = "0x3CB")]
		[Token(Token = "0x6000676")]
		private override void MoveNext() { }

		[Address(RVA = "0x19DE520", Offset = "0x19DD920", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000677")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000675")]
	protected AsyncEnumerableSorter`1() { }

	[Token(Token = "0x6000672")]
	internal abstract int CompareKeys(int index1, int index2) { }

	[Token(Token = "0x6000671")]
	internal abstract UniTask ComputeKeysAsync(TElement[] elements, int count) { }

	[Address(RVA = "0x1008530", Offset = "0x1007930", Length = "0x257")]
	[Token(Token = "0x6000674")]
	private void QuickSort(Int32[] map, int left, int right) { }

	[Address(RVA = "0x1008790", Offset = "0x1007B90", Length = "0x129")]
	[AsyncStateMachine(typeof(<SortAsync>d__2))]
	[Token(Token = "0x6000673")]
	internal UniTask<Int32[]> SortAsync(TElement[] elements, int count) { }

}

