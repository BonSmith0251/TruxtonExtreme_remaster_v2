namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000475")]
public struct ConfiguredValueTaskAwaitable
{
	[IsReadOnly]
	[Token(Token = "0x2000476")]
	internal struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001250")]
		private readonly ValueTask _value; //Field offset: 0x0

		[Token(Token = "0x170003F8")]
		public bool IsCompleted
		{
			[Address(RVA = "0x1F33850", Offset = "0x1F32C50", Length = "0x49")]
			[Token(Token = "0x60020C8")]
			 get { } //Length: 73
		}

		[Address(RVA = "0x120FC40", Offset = "0x120F040", Length = "0xD")]
		[Token(Token = "0x60020C7")]
		internal ConfiguredValueTaskAwaiter(ValueTask value) { }

		[Address(RVA = "0x1F33850", Offset = "0x1F32C50", Length = "0x49")]
		[Token(Token = "0x60020C8")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x1F33320", Offset = "0x1F32720", Length = "0x49")]
		[StackTraceHidden]
		[Token(Token = "0x60020C9")]
		public void GetResult() { }

		[Address(RVA = "0x1F33370", Offset = "0x1F32770", Length = "0x267")]
		[Token(Token = "0x60020CA")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x1F335E0", Offset = "0x1F329E0", Length = "0x264")]
		[Token(Token = "0x60020CB")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400124F")]
	private readonly ValueTask _value; //Field offset: 0x0

	[Address(RVA = "0x120FC40", Offset = "0x120F040", Length = "0xD")]
	[Token(Token = "0x60020C5")]
	internal ConfiguredValueTaskAwaitable(ValueTask value) { }

	[Address(RVA = "0x1F33300", Offset = "0x1F32700", Length = "0x1F")]
	[Token(Token = "0x60020C6")]
	public ConfiguredValueTaskAwaiter GetAwaiter() { }

}

