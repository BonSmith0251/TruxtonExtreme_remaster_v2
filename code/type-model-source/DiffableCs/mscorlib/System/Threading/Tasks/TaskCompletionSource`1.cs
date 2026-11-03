namespace System.Threading.Tasks;

[Token(Token = "0x2000253")]
public class TaskCompletionSource
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AA2")]
	private readonly Task<TResult> _task; //Field offset: 0x0

	[Token(Token = "0x170001C9")]
	public Task<TResult> Task
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60013A1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xFE4C80", Offset = "0xFE4080", Length = "0x7C")]
	[Token(Token = "0x600139D")]
	public TaskCompletionSource`1() { }

	[Address(RVA = "0xFE4980", Offset = "0xFE3D80", Length = "0x19")]
	[Token(Token = "0x600139E")]
	public TaskCompletionSource`1(TaskCreationOptions creationOptions) { }

	[Address(RVA = "0xFE48E0", Offset = "0xFE3CE0", Length = "0x17")]
	[Token(Token = "0x600139F")]
	public TaskCompletionSource`1(object state) { }

	[Address(RVA = "0xFE49C0", Offset = "0xFE3DC0", Length = "0x9E")]
	[Token(Token = "0x60013A0")]
	public TaskCompletionSource`1(object state, TaskCreationOptions creationOptions) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60013A1")]
	public Task<TResult> get_Task() { }

	[Address(RVA = "0xFE3760", Offset = "0xFE2B60", Length = "0xB7")]
	[Token(Token = "0x60013A4")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0xFE3E00", Offset = "0xFE3200", Length = "0x71")]
	[Token(Token = "0x60013A6")]
	public void SetResult(TResult result) { }

	[Address(RVA = "0xFE4080", Offset = "0xFE3480", Length = "0x7B")]
	[Token(Token = "0x60013A2")]
	private void SpinUntilCompleted() { }

	[Address(RVA = "0xFE4290", Offset = "0xFE3690", Length = "0x81")]
	[Token(Token = "0x60013A3")]
	public bool TrySetException(Exception exception) { }

	[Address(RVA = "0xFE4560", Offset = "0xFE3960", Length = "0x5A")]
	[Token(Token = "0x60013A5")]
	public bool TrySetResult(TResult result) { }

}

