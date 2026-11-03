namespace Cysharp.Threading.Tasks;

[Token(Token = "0x20000F2")]
public struct SwitchToMainThreadAwaitable
{
	[Token(Token = "0x20000F3")]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003AF")]
		private readonly PlayerLoopTiming playerLoopTiming; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003B0")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x8

		[Token(Token = "0x17000042")]
		public bool IsCompleted
		{
			[Address(RVA = "0x27305A0", Offset = "0x272F9A0", Length = "0xA6")]
			[Token(Token = "0x600061B")]
			 get { } //Length: 166
		}

		[Address(RVA = "0x2730340", Offset = "0x272F740", Length = "0x11")]
		[Token(Token = "0x600061A")]
		public Awaiter(PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken) { }

		[Address(RVA = "0x27305A0", Offset = "0x272F9A0", Length = "0xA6")]
		[Token(Token = "0x600061B")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x272F4E0", Offset = "0x272E8E0", Length = "0x4A")]
		[Token(Token = "0x600061C")]
		public void GetResult() { }

		[Address(RVA = "0x272F5D0", Offset = "0x272E9D0", Length = "0x5A")]
		[Token(Token = "0x600061D")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x272FBF0", Offset = "0x272EFF0", Length = "0x5A")]
		[Token(Token = "0x600061E")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003AD")]
	private readonly PlayerLoopTiming playerLoopTiming; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003AE")]
	private readonly CancellationToken cancellationToken; //Field offset: 0x8

	[Address(RVA = "0x2730340", Offset = "0x272F740", Length = "0x11")]
	[Token(Token = "0x6000618")]
	public SwitchToMainThreadAwaitable(PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken) { }

	[Address(RVA = "0x27385B0", Offset = "0x27379B0", Length = "0x30")]
	[Token(Token = "0x6000619")]
	public Awaiter GetAwaiter() { }

}

