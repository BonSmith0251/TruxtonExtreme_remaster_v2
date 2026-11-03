namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000AE")]
internal static class ElementAt
{
	[CompilerGenerated]
	[Token(Token = "0x20000AF")]
	private struct <ElementAtAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400082E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400082F")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000830")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000831")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000832")]
		public int index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000833")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000834")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000835")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000836")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000837")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000838")]
		private int <i>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000839")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400083A")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16F22F0", Offset = "0x16F16F0", Length = "0x11C4")]
		[Token(Token = "0x6000473")]
		private override void MoveNext() { }

		[Address(RVA = "0x16F34C0", Offset = "0x16F28C0", Length = "0xC1")]
		[DebuggerHidden]
		[Token(Token = "0x6000474")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x7D2FA0", Offset = "0x7D23A0", Length = "0x2DE")]
	[AsyncStateMachine(typeof(<ElementAtAsync>d__0`1))]
	[Token(Token = "0x6000472")]
	public static UniTask<TSource> ElementAtAsync(IUniTaskAsyncEnumerable<TSource> source, int index, CancellationToken cancellationToken, bool defaultIfEmpty) { }

}

