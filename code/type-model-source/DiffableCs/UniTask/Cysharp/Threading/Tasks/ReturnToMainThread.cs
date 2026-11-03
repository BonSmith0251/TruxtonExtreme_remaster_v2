namespace Cysharp.Threading.Tasks;

[Token(Token = "0x20000F4")]
public struct ReturnToMainThread
{
	[IsReadOnly]
	[Token(Token = "0x20000F5")]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B3")]
		private readonly PlayerLoopTiming timing; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003B4")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x8

		[Token(Token = "0x17000043")]
		public bool IsCompleted
		{
			[Address(RVA = "0x2730500", Offset = "0x272F900", Length = "0x9F")]
			[Token(Token = "0x6000623")]
			 get { } //Length: 159
		}

		[Address(RVA = "0x2730340", Offset = "0x272F740", Length = "0x11")]
		[Token(Token = "0x6000621")]
		public Awaiter(PlayerLoopTiming timing, CancellationToken cancellationToken) { }

		[Address(RVA = "0x2730500", Offset = "0x272F900", Length = "0x9F")]
		[Token(Token = "0x6000623")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[Token(Token = "0x6000622")]
		public Awaiter GetAwaiter() { }

		[Address(RVA = "0x272F440", Offset = "0x272E840", Length = "0x4A")]
		[Token(Token = "0x6000624")]
		public void GetResult() { }

		[Address(RVA = "0x272F720", Offset = "0x272EB20", Length = "0x5A")]
		[Token(Token = "0x6000625")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x272FE50", Offset = "0x272F250", Length = "0x5A")]
		[Token(Token = "0x6000626")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003B1")]
	private readonly PlayerLoopTiming playerLoopTiming; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003B2")]
	private readonly CancellationToken cancellationToken; //Field offset: 0x8

	[Address(RVA = "0x2730340", Offset = "0x272F740", Length = "0x11")]
	[Token(Token = "0x600061F")]
	public ReturnToMainThread(PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken) { }

	[Address(RVA = "0x27385B0", Offset = "0x27379B0", Length = "0x30")]
	[Token(Token = "0x6000620")]
	public Awaiter DisposeAsync() { }

}

