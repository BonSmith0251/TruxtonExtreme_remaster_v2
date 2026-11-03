namespace Cysharp.Threading.Tasks;

[Token(Token = "0x20000FC")]
public struct ReturnToSynchronizationContext
{
	[Token(Token = "0x20000FD")]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[Token(Token = "0x40003BF")]
		private static readonly SendOrPostCallback switchToCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003C0")]
		private readonly SynchronizationContext synchronizationContext; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003C1")]
		private readonly bool dontPostWhenSameContext; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003C2")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x10

		[Token(Token = "0x17000047")]
		public bool IsCompleted
		{
			[Address(RVA = "0x27304D0", Offset = "0x272F8D0", Length = "0x2A")]
			[Token(Token = "0x6000642")]
			 get { } //Length: 42
		}

		[Address(RVA = "0x2730220", Offset = "0x272F620", Length = "0x89")]
		[Token(Token = "0x6000647")]
		private static Awaiter() { }

		[Address(RVA = "0x2730370", Offset = "0x272F770", Length = "0x43")]
		[Token(Token = "0x6000640")]
		public Awaiter(SynchronizationContext synchronizationContext, bool dontPostWhenSameContext, CancellationToken cancellationToken) { }

		[Address(RVA = "0x272F3D0", Offset = "0x272E7D0", Length = "0x6A")]
		[Token(Token = "0x6000646")]
		private static void Callback(object state) { }

		[Address(RVA = "0x27304D0", Offset = "0x272F8D0", Length = "0x2A")]
		[Token(Token = "0x6000642")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0xAEF030", Offset = "0xAEE430", Length = "0x14")]
		[Token(Token = "0x6000641")]
		public Awaiter GetAwaiter() { }

		[Address(RVA = "0x272F490", Offset = "0x272E890", Length = "0x4A")]
		[Token(Token = "0x6000643")]
		public void GetResult() { }

		[Address(RVA = "0x272F690", Offset = "0x272EA90", Length = "0x86")]
		[Token(Token = "0x6000644")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x272FF80", Offset = "0x272F380", Length = "0x86")]
		[Token(Token = "0x6000645")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003BC")]
	private readonly SynchronizationContext syncContext; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003BD")]
	private readonly bool dontPostWhenSameContext; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003BE")]
	private readonly CancellationToken cancellationToken; //Field offset: 0x10

	[Address(RVA = "0x2730370", Offset = "0x272F770", Length = "0x43")]
	[Token(Token = "0x600063E")]
	public ReturnToSynchronizationContext(SynchronizationContext syncContext, bool dontPostWhenSameContext, CancellationToken cancellationToken) { }

	[Address(RVA = "0x27385E0", Offset = "0x27379E0", Length = "0x5A")]
	[Token(Token = "0x600063F")]
	public Awaiter DisposeAsync() { }

}

