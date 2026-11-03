namespace System.Threading.Tasks;

[Token(Token = "0x2000252")]
public class TaskCanceledException : OperationCanceledException
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000AA1")]
	private readonly Task _canceledTask; //Field offset: 0x98

	[Address(RVA = "0x20B57D0", Offset = "0x20B4BD0", Length = "0x3C")]
	[Token(Token = "0x600139A")]
	public TaskCanceledException() { }

	[Address(RVA = "0x20B5730", Offset = "0x20B4B30", Length = "0x9B")]
	[Token(Token = "0x600139B")]
	public TaskCanceledException(Task task) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x600139C")]
	protected TaskCanceledException(SerializationInfo info, StreamingContext context) { }

}

