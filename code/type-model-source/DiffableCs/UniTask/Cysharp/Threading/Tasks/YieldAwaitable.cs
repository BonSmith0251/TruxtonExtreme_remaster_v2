namespace Cysharp.Threading.Tasks;

[IsReadOnly]
[Token(Token = "0x20000EF")]
public struct YieldAwaitable
{
	[IsReadOnly]
	[Token(Token = "0x20000F0")]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A6")]
		private readonly PlayerLoopTiming timing; //Field offset: 0x0

		[Token(Token = "0x17000041")]
		public bool IsCompleted
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000613")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6000612")]
		public Awaiter(PlayerLoopTiming timing) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000613")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000614")]
		public void GetResult() { }

		[Address(RVA = "0x272F630", Offset = "0x272EA30", Length = "0x5A")]
		[Token(Token = "0x6000615")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x272FC50", Offset = "0x272F050", Length = "0x5A")]
		[Token(Token = "0x6000616")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003A5")]
	private readonly PlayerLoopTiming timing; //Field offset: 0x0

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600060F")]
	public YieldAwaitable(PlayerLoopTiming timing) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000610")]
	public Awaiter GetAwaiter() { }

	[Address(RVA = "0x274E8E0", Offset = "0x274DCE0", Length = "0x102")]
	[Token(Token = "0x6000611")]
	public UniTask ToUniTask() { }

}

