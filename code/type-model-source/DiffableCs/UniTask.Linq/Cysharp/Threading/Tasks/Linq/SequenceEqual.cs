namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000184")]
internal static class SequenceEqual
{
	[CompilerGenerated]
	[Token(Token = "0x2000185")]
	private struct <SequenceEqualAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F64")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F65")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F66")]
		public IUniTaskAsyncEnumerable<TSource> first; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F67")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F68")]
		public IUniTaskAsyncEnumerable<TSource> second; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F69")]
		public IEqualityComparer<TSource> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F6A")]
		private IUniTaskAsyncEnumerator<TSource> <e1>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F6B")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F6C")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F6D")]
		private bool <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F6E")]
		private IUniTaskAsyncEnumerator<TSource> <e2>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F6F")]
		private object <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F70")]
		private int <>7__wrap7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F71")]
		private bool <>7__wrap8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F72")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F73")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1984C90", Offset = "0x1984090", Length = "0xED6")]
		[Token(Token = "0x6000747")]
		private override void MoveNext() { }

		[Address(RVA = "0x1985B70", Offset = "0x1984F70", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000748")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x8EFE70", Offset = "0x8EF270", Length = "0x13B")]
	[AsyncStateMachine(typeof(<SequenceEqualAsync>d__0`1))]
	[Token(Token = "0x6000746")]
	internal static UniTask<Boolean> SequenceEqualAsync(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken) { }

}

