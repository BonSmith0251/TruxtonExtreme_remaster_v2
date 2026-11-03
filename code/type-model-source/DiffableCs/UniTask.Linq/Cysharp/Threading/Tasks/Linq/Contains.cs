namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200008D")]
internal static class Contains
{
	[CompilerGenerated]
	[Token(Token = "0x200008E")]
	private struct <ContainsAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000788")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000789")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400078A")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400078B")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400078C")]
		public IEqualityComparer<TSource> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400078D")]
		public TSource value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400078E")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400078F")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000790")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000791")]
		private bool <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000792")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000793")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1143D80", Offset = "0x1143180", Length = "0x1154")]
		[Token(Token = "0x600040A")]
		private override void MoveNext() { }

		[Address(RVA = "0x1144EE0", Offset = "0x11442E0", Length = "0x94")]
		[DebuggerHidden]
		[Token(Token = "0x600040B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x7AA380", Offset = "0x7A9780", Length = "0x2DB")]
	[AsyncStateMachine(typeof(<ContainsAsync>d__0`1))]
	[Token(Token = "0x6000409")]
	internal static UniTask<Boolean> ContainsAsync(IUniTaskAsyncEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken) { }

}

