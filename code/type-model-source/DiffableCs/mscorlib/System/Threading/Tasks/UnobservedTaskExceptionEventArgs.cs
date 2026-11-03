namespace System.Threading.Tasks;

[Token(Token = "0x2000289")]
public class UnobservedTaskExceptionEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B44")]
	private AggregateException m_exception; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B45")]
	internal bool m_observed; //Field offset: 0x18

	[Address(RVA = "0x20C4680", Offset = "0x20C3A80", Length = "0x65")]
	[Token(Token = "0x6001517")]
	public UnobservedTaskExceptionEventArgs(AggregateException exception) { }

}

