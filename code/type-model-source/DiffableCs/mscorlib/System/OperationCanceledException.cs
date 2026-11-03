namespace System;

[Token(Token = "0x2000121")]
public class OperationCanceledException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000426")]
	private CancellationToken _cancellationToken; //Field offset: 0x90

	[Token(Token = "0x17000096")]
	public private CancellationToken CancellationToken
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x600094F")]
		 get { } //Length: 8
		[Address(RVA = "0x2044210", Offset = "0x2043610", Length = "0x15")]
		[Token(Token = "0x6000950")]
		private set { } //Length: 21
	}

	[Address(RVA = "0x2044080", Offset = "0x2043480", Length = "0x81")]
	[Token(Token = "0x6000951")]
	public OperationCanceledException() { }

	[Address(RVA = "0x2044110", Offset = "0x2043510", Length = "0x61")]
	[Token(Token = "0x6000952")]
	public OperationCanceledException(string message) { }

	[Address(RVA = "0x2043FD0", Offset = "0x20433D0", Length = "0xA2")]
	[Token(Token = "0x6000953")]
	public OperationCanceledException(CancellationToken token) { }

	[Address(RVA = "0x2044180", Offset = "0x2043580", Length = "0x82")]
	[Token(Token = "0x6000954")]
	public OperationCanceledException(string message, CancellationToken token) { }

	[Address(RVA = "0x203CBA0", Offset = "0x203BFA0", Length = "0x74")]
	[Token(Token = "0x6000955")]
	protected OperationCanceledException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x600094F")]
	public CancellationToken get_CancellationToken() { }

	[Address(RVA = "0x2044210", Offset = "0x2043610", Length = "0x15")]
	[Token(Token = "0x6000950")]
	private void set_CancellationToken(CancellationToken value) { }

}

