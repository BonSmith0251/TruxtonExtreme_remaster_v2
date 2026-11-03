namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000203")]
internal sealed class ToObservable : IObservable<T>
{
	[CompilerGenerated]
	[Token(Token = "0x2000205")]
	private struct <RunAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001370")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001371")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001372")]
		public IUniTaskAsyncEnumerable<T> src; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001373")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001374")]
		public IObserver<T> observer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001375")]
		private IUniTaskAsyncEnumerator<T> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001376")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001377")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001378")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001379")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x19796F0", Offset = "0x1978AF0", Length = "0xA10")]
		[Token(Token = "0x60008CC")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60008CD")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000204")]
	public sealed class CancellationTokenDisposable : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400136F")]
		private readonly CancellationTokenSource cts; //Field offset: 0x0

		[Token(Token = "0x1700004B")]
		public CancellationToken Token
		{
			[Address(RVA = "0x16C7210", Offset = "0x16C6610", Length = "0x1D")]
			[Token(Token = "0x60008C9")]
			 get { } //Length: 29
		}

		[Address(RVA = "0x16C71A0", Offset = "0x16C65A0", Length = "0x66")]
		[Token(Token = "0x60008CB")]
		public CancellationTokenDisposable() { }

		[Address(RVA = "0x16C7160", Offset = "0x16C6560", Length = "0x3D")]
		[Token(Token = "0x60008CA")]
		public override void Dispose() { }

		[Address(RVA = "0x16C7210", Offset = "0x16C6610", Length = "0x1D")]
		[Token(Token = "0x60008C9")]
		public CancellationToken get_Token() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400136E")]
	private readonly IUniTaskAsyncEnumerable<T> source; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60008C6")]
	public ToObservable`1(IUniTaskAsyncEnumerable<T> source) { }

	[Address(RVA = "0x108F7A0", Offset = "0x108EBA0", Length = "0xF0")]
	[AsyncStateMachine(typeof(<RunAsync>d__3))]
	[Token(Token = "0x60008C8")]
	private static UniTaskVoid RunAsync(IUniTaskAsyncEnumerable<T> src, IObserver<T> observer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x108F890", Offset = "0x108EC90", Length = "0xEF")]
	[Token(Token = "0x60008C7")]
	public override IDisposable Subscribe(IObserver<T> observer) { }

}

