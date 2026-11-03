namespace System.Threading.Tasks;

[IsReadOnly]
[Token(Token = "0x200025F")]
internal struct ForceAsyncAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB9")]
	private readonly Task _task; //Field offset: 0x0

	[Token(Token = "0x170001D3")]
	public bool IsCompleted
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60013DF")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x60013DD")]
	internal ForceAsyncAwaiter(Task task) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60013DF")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60013DE")]
	public ForceAsyncAwaiter GetAwaiter() { }

	[Address(RVA = "0x20B1DB0", Offset = "0x20B11B0", Length = "0x44")]
	[Token(Token = "0x60013E0")]
	public void GetResult() { }

	[Address(RVA = "0x20B1E00", Offset = "0x20B1200", Length = "0x54")]
	[Token(Token = "0x60013E1")]
	public override void OnCompleted(Action action) { }

	[Address(RVA = "0x20B1E60", Offset = "0x20B1260", Length = "0x54")]
	[Token(Token = "0x60013E2")]
	public override void UnsafeOnCompleted(Action action) { }

}

