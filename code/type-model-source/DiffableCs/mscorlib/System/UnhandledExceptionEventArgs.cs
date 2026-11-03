namespace System;

[Token(Token = "0x200014E")]
public class UnhandledExceptionEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400047B")]
	private object _exception; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400047C")]
	private bool _isTerminating; //Field offset: 0x18

	[Token(Token = "0x170000F1")]
	public object ExceptionObject
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000BA8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F2")]
	public bool IsTerminating
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000BA9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2056880", Offset = "0x2055C80", Length = "0x78")]
	[Token(Token = "0x6000BA7")]
	public UnhandledExceptionEventArgs(object exception, bool isTerminating) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000BA8")]
	public object get_ExceptionObject() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000BA9")]
	public bool get_IsTerminating() { }

}

