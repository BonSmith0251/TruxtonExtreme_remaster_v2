namespace Cysharp.Threading.Tasks;

[Token(Token = "0x20000F8")]
public struct SwitchToTaskPoolAwaitable
{
	[Token(Token = "0x20000F9")]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[Token(Token = "0x40003B6")]
		private static readonly Action<Object> switchToCallback; //Field offset: 0x0

		[Token(Token = "0x17000045")]
		public bool IsCompleted
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600062F")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x2730100", Offset = "0x272F500", Length = "0x89")]
		[Token(Token = "0x6000634")]
		private static Awaiter() { }

		[Address(RVA = "0x272F280", Offset = "0x272E680", Length = "0x6A")]
		[Token(Token = "0x6000633")]
		private static void Callback(object state) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600062F")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000630")]
		public void GetResult() { }

		[Address(RVA = "0x272F7E0", Offset = "0x272EBE0", Length = "0x194")]
		[Token(Token = "0x6000631")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x272FCB0", Offset = "0x272F0B0", Length = "0x194")]
		[Token(Token = "0x6000632")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}


	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600062E")]
	public Awaiter GetAwaiter() { }

}

