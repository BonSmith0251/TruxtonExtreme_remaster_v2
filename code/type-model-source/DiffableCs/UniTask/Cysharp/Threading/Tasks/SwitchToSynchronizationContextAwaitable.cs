namespace Cysharp.Threading.Tasks;

[Token(Token = "0x20000FA")]
public struct SwitchToSynchronizationContextAwaitable
{
	[Token(Token = "0x20000FB")]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[Token(Token = "0x40003B9")]
		private static readonly SendOrPostCallback switchToCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003BA")]
		private readonly SynchronizationContext synchronizationContext; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003BB")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x8

		[Token(Token = "0x17000046")]
		public bool IsCompleted
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000638")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x2730190", Offset = "0x272F590", Length = "0x89")]
		[Token(Token = "0x600063D")]
		private static Awaiter() { }

		[Address(RVA = "0x11194D0", Offset = "0x11188D0", Length = "0x31")]
		[Token(Token = "0x6000637")]
		public Awaiter(SynchronizationContext synchronizationContext, CancellationToken cancellationToken) { }

		[Address(RVA = "0x272F2F0", Offset = "0x272E6F0", Length = "0x6A")]
		[Token(Token = "0x600063C")]
		private static void Callback(object state) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000638")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x272F580", Offset = "0x272E980", Length = "0x4A")]
		[Token(Token = "0x6000639")]
		public void GetResult() { }

		[Address(RVA = "0x272FA50", Offset = "0x272EE50", Length = "0x86")]
		[Token(Token = "0x600063A")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x2730070", Offset = "0x272F470", Length = "0x86")]
		[Token(Token = "0x600063B")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003B7")]
	private readonly SynchronizationContext synchronizationContext; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003B8")]
	private readonly CancellationToken cancellationToken; //Field offset: 0x8

	[Address(RVA = "0x11194D0", Offset = "0x11188D0", Length = "0x31")]
	[Token(Token = "0x6000635")]
	public SwitchToSynchronizationContextAwaitable(SynchronizationContext synchronizationContext, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2738640", Offset = "0x2737A40", Length = "0x44")]
	[Token(Token = "0x6000636")]
	public Awaiter GetAwaiter() { }

}

