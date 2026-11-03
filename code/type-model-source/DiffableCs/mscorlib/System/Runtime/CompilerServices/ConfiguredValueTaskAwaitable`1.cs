namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000477")]
public struct ConfiguredValueTaskAwaitable
{
	[IsReadOnly]
	[Token(Token = "0x2000478")]
	internal struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001252")]
		private readonly ValueTask<TResult> _value; //Field offset: 0x0

		[Token(Token = "0x170003F9")]
		public bool IsCompleted
		{
			[Address(RVA = "0x120FD00", Offset = "0x120F100", Length = "0x36")]
			[Token(Token = "0x60020CF")]
			 get { } //Length: 54
		}

		[Address(RVA = "0x120FC40", Offset = "0x120F040", Length = "0xD")]
		[Token(Token = "0x60020CE")]
		internal ConfiguredValueTaskAwaiter(ValueTask<TResult> value) { }

		[Address(RVA = "0x120FD00", Offset = "0x120F100", Length = "0x36")]
		[Token(Token = "0x60020CF")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x11FEC50", Offset = "0x11FE050", Length = "0x36")]
		[StackTraceHidden]
		[Token(Token = "0x60020D0")]
		public TResult GetResult() { }

		[Address(RVA = "0x17BE970", Offset = "0x17BDD70", Length = "0x24B")]
		[Token(Token = "0x60020D1")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x17BF0A0", Offset = "0x17BE4A0", Length = "0x248")]
		[Token(Token = "0x60020D2")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001251")]
	private readonly ValueTask<TResult> _value; //Field offset: 0x0

	[Address(RVA = "0x120FC40", Offset = "0x120F040", Length = "0xD")]
	[Token(Token = "0x60020CC")]
	internal ConfiguredValueTaskAwaitable`1(ValueTask<TResult> value) { }

	[Address(RVA = "0x12107B0", Offset = "0x120FBB0", Length = "0x44")]
	[Token(Token = "0x60020CD")]
	public ConfiguredValueTaskAwaiter<TResult> GetAwaiter() { }

}

