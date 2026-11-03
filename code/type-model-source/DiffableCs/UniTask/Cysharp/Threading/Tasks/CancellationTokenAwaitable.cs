namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000019")]
public struct CancellationTokenAwaitable
{
	[Token(Token = "0x200001A")]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000055")]
		private CancellationToken cancellationToken; //Field offset: 0x0

		[Token(Token = "0x17000014")]
		public bool IsCompleted
		{
			[Address(RVA = "0x2730450", Offset = "0x272F850", Length = "0x74")]
			[Token(Token = "0x600009B")]
			 get { } //Length: 116
		}

		[Address(RVA = "0x2730360", Offset = "0x272F760", Length = "0xA")]
		[Token(Token = "0x600009A")]
		public Awaiter(CancellationToken cancellationToken) { }

		[Address(RVA = "0x2730450", Offset = "0x272F850", Length = "0x74")]
		[Token(Token = "0x600009B")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600009C")]
		public void GetResult() { }

		[Address(RVA = "0x272FAE0", Offset = "0x272EEE0", Length = "0x62")]
		[Token(Token = "0x600009D")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x272FAE0", Offset = "0x272EEE0", Length = "0x62")]
		[Token(Token = "0x600009E")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000054")]
	private CancellationToken cancellationToken; //Field offset: 0x0

	[Address(RVA = "0x2730360", Offset = "0x272F760", Length = "0xA")]
	[Token(Token = "0x6000098")]
	public CancellationTokenAwaitable(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27306A0", Offset = "0x272FAA0", Length = "0x22")]
	[Token(Token = "0x6000099")]
	public Awaiter GetAwaiter() { }

}

