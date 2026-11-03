namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001F2")]
internal static class ToHashSet
{
	[CompilerGenerated]
	[Token(Token = "0x20001F3")]
	private struct <ToHashSetAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012C4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012C5")]
		public AsyncUniTaskMethodBuilder<HashSet`1<TSource>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012C6")]
		public IEqualityComparer<TSource> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012C7")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012C8")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012C9")]
		private HashSet<TSource> <set>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012CA")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012CB")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012CC")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012CD")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012CE")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B69230", Offset = "0x1B68630", Length = "0xA3F")]
		[Token(Token = "0x6000891")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B69C80", Offset = "0x1B69080", Length = "0x87")]
		[DebuggerHidden]
		[Token(Token = "0x6000892")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x945D80", Offset = "0x945180", Length = "0x13D")]
	[AsyncStateMachine(typeof(<ToHashSetAsync>d__0`1))]
	[Token(Token = "0x6000890")]
	internal static UniTask<HashSet`1<TSource>> ToHashSetAsync(IUniTaskAsyncEnumerable<TSource> source, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken) { }

}

