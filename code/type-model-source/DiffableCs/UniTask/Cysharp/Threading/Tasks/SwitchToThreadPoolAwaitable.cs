namespace Cysharp.Threading.Tasks;

[Token(Token = "0x20000F6")]
public struct SwitchToThreadPoolAwaitable
{
	[Token(Token = "0x20000F7")]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[Token(Token = "0x40003B5")]
		private static readonly WaitCallback switchToCallback; //Field offset: 0x0

		[Token(Token = "0x17000044")]
		public bool IsCompleted
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000628")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27302B0", Offset = "0x272F6B0", Length = "0x89")]
		[Token(Token = "0x600062D")]
		private static Awaiter() { }

		[Address(RVA = "0x272F360", Offset = "0x272E760", Length = "0x6A")]
		[Token(Token = "0x600062C")]
		private static void Callback(object state) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000628")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000629")]
		public void GetResult() { }

		[Address(RVA = "0x272F780", Offset = "0x272EB80", Length = "0x5B")]
		[Token(Token = "0x600062A")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x2730010", Offset = "0x272F410", Length = "0x5B")]
		[Token(Token = "0x600062B")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}


	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000627")]
	public Awaiter GetAwaiter() { }

}

