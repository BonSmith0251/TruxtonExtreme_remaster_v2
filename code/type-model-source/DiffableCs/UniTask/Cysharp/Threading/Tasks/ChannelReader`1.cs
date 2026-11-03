namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200001F")]
public abstract class ChannelReader
{
	[CompilerGenerated]
	[Token(Token = "0x2000020")]
	private struct <ReadAsyncCore>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000059")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005A")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005B")]
		public ChannelReader<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005C")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005D")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x1977BE0", Offset = "0x1976FE0", Length = "0x721")]
		[Token(Token = "0x60000B5")]
		private override void MoveNext() { }

		[Address(RVA = "0x1978310", Offset = "0x1977710", Length = "0xC1")]
		[DebuggerHidden]
		[Token(Token = "0x60000B6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Token(Token = "0x17000017")]
	public abstract UniTask Completion
	{
		[Token(Token = "0x60000B0")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000B4")]
	protected ChannelReader`1() { }

	[Token(Token = "0x60000B0")]
	public abstract UniTask get_Completion() { }

	[Token(Token = "0x60000B3")]
	public abstract IUniTaskAsyncEnumerable<T> ReadAllAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x16D0F50", Offset = "0x16D0350", Length = "0x1BE")]
	[Token(Token = "0x60000B1")]
	public override UniTask<T> ReadAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x16D0CB0", Offset = "0x16D00B0", Length = "0x29F")]
	[AsyncStateMachine(typeof(<ReadAsyncCore>d__5))]
	[Token(Token = "0x60000B2")]
	private UniTask<T> ReadAsyncCore(CancellationToken cancellationToken = null) { }

	[Token(Token = "0x60000AE")]
	public abstract bool TryRead(out T item) { }

	[Token(Token = "0x60000AF")]
	public abstract UniTask<Boolean> WaitToReadAsync(CancellationToken cancellationToken = null) { }

}

