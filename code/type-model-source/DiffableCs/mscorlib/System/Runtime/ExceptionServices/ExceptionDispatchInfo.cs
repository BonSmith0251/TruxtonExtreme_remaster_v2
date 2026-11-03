namespace System.Runtime.ExceptionServices;

[Token(Token = "0x2000467")]
public sealed class ExceptionDispatchInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400123A")]
	private Exception m_Exception; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400123B")]
	private object m_stackTrace; //Field offset: 0x18

	[Token(Token = "0x170003F5")]
	internal object BinaryStackTraceArray
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60020AF")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003F6")]
	public Exception SourceException
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60020B1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F34590", Offset = "0x1F33990", Length = "0x166")]
	[Token(Token = "0x60020AE")]
	private ExceptionDispatchInfo(Exception exception) { }

	[Address(RVA = "0x1F34300", Offset = "0x1F33700", Length = "0x204")]
	[Token(Token = "0x60020B0")]
	public static ExceptionDispatchInfo Capture(Exception source) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60020AF")]
	internal object get_BinaryStackTraceArray() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60020B1")]
	public Exception get_SourceException() { }

	[Address(RVA = "0x1F34510", Offset = "0x1F33910", Length = "0x42")]
	[StackTraceHidden]
	[Token(Token = "0x60020B2")]
	public void Throw() { }

	[Address(RVA = "0x1F34560", Offset = "0x1F33960", Length = "0x22")]
	[StackTraceHidden]
	[Token(Token = "0x60020B3")]
	public static void Throw(Exception source) { }

}

