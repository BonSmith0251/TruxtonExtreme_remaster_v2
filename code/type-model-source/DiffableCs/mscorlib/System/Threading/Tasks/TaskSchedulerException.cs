namespace System.Threading.Tasks;

[Token(Token = "0x2000254")]
public class TaskSchedulerException : Exception
{

	[Address(RVA = "0x20B7480", Offset = "0x20B6880", Length = "0x5D")]
	[Token(Token = "0x60013A7")]
	public TaskSchedulerException() { }

	[Address(RVA = "0x20B74E0", Offset = "0x20B68E0", Length = "0x6C")]
	[Token(Token = "0x60013A8")]
	public TaskSchedulerException(Exception innerException) { }

	[Address(RVA = "0x20B7400", Offset = "0x20B6800", Length = "0x74")]
	[Token(Token = "0x60013A9")]
	protected TaskSchedulerException(SerializationInfo info, StreamingContext context) { }

}

