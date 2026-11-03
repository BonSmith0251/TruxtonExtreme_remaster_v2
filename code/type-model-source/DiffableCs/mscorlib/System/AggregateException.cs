namespace System;

[DebuggerDisplay("Count = {InnerExceptionCount}")]
[Token(Token = "0x20000AF")]
public class AggregateException : Exception
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400027D")]
	private ReadOnlyCollection<Exception> m_innerExceptions; //Field offset: 0x90

	[Token(Token = "0x1700004D")]
	public ReadOnlyCollection<Exception> InnerExceptions
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x60003D5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700004E")]
	public virtual string Message
	{
		[Address(RVA = "0x1F8BB40", Offset = "0x1F8AF40", Length = "0x1AD")]
		[Token(Token = "0x60003D7")]
		 get { } //Length: 429
	}

	[Address(RVA = "0x1F8BA10", Offset = "0x1F8AE10", Length = "0x12E")]
	[Token(Token = "0x60003CA")]
	public AggregateException() { }

	[Address(RVA = "0x1F8B200", Offset = "0x1F8A600", Length = "0xD5")]
	[Token(Token = "0x60003CB")]
	public AggregateException(IEnumerable<Exception> innerExceptions) { }

	[Address(RVA = "0x1F8B9C0", Offset = "0x1F8ADC0", Length = "0x4B")]
	[Token(Token = "0x60003CC")]
	public AggregateException(Exception[] innerExceptions) { }

	[Address(RVA = "0x1F8B3B0", Offset = "0x1F8A7B0", Length = "0xB5")]
	[Token(Token = "0x60003CD")]
	public AggregateException(string message, IEnumerable<Exception> innerExceptions) { }

	[Address(RVA = "0x1F8B2E0", Offset = "0x1F8A6E0", Length = "0x8")]
	[Token(Token = "0x60003CE")]
	public AggregateException(string message, Exception[] innerExceptions) { }

	[Address(RVA = "0x1F8B470", Offset = "0x1F8A870", Length = "0x281")]
	[Token(Token = "0x60003CF")]
	private AggregateException(string message, IList<Exception> innerExceptions) { }

	[Address(RVA = "0x1F8B700", Offset = "0x1F8AB00", Length = "0xD5")]
	[Token(Token = "0x60003D0")]
	internal AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	[Address(RVA = "0x1F8B2F0", Offset = "0x1F8A6F0", Length = "0xB5")]
	[Token(Token = "0x60003D1")]
	internal AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	[Address(RVA = "0x1F8AF50", Offset = "0x1F8A350", Length = "0x2A8")]
	[Token(Token = "0x60003D2")]
	private AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	[Address(RVA = "0x1F8B7E0", Offset = "0x1F8ABE0", Length = "0x1D6")]
	[Token(Token = "0x60003D3")]
	protected AggregateException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F8A980", Offset = "0x1F89D80", Length = "0x28A")]
	[Token(Token = "0x60003D6")]
	public AggregateException Flatten() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x60003D5")]
	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	[Address(RVA = "0x1F8BB40", Offset = "0x1F8AF40", Length = "0x1AD")]
	[Token(Token = "0x60003D7")]
	public virtual string get_Message() { }

	[Address(RVA = "0x1F8AC10", Offset = "0x1F8A010", Length = "0x128")]
	[Token(Token = "0x60003D4")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F8AD40", Offset = "0x1F8A140", Length = "0x202")]
	[Token(Token = "0x60003D8")]
	public virtual string ToString() { }

}

