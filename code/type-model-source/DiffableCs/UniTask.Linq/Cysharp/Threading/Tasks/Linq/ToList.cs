namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001F4")]
internal static class ToList
{
	[CompilerGenerated]
	[Token(Token = "0x20001F5")]
	private struct <ToListAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012CF")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012D0")]
		public AsyncUniTaskMethodBuilder<List`1<TSource>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012D1")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012D2")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012D3")]
		private List<TSource> <list>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012D4")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012D5")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012D6")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012D7")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012D8")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B69D10", Offset = "0x1B69110", Length = "0xA19")]
		[Token(Token = "0x6000894")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B6A730", Offset = "0x1B69B30", Length = "0x87")]
		[DebuggerHidden]
		[Token(Token = "0x6000895")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x945EC0", Offset = "0x9452C0", Length = "0x124")]
	[AsyncStateMachine(typeof(<ToListAsync>d__0`1))]
	[Token(Token = "0x6000893")]
	internal static UniTask<List`1<TSource>> ToListAsync(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

}

