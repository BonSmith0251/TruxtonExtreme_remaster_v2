namespace System;

[AttributeUsage(6140, Inherited = False)]
[Token(Token = "0x2000120")]
public sealed class ObsoleteAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000424")]
	private string _message; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000425")]
	private bool _error; //Field offset: 0x18

	[Token(Token = "0x17000095")]
	public bool IsError
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x600094E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000094")]
	public string Message
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600094D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2043AD0", Offset = "0x2042ED0", Length = "0x2D")]
	[Token(Token = "0x600094A")]
	public ObsoleteAttribute() { }

	[Address(RVA = "0x2043B50", Offset = "0x2042F50", Length = "0x36")]
	[Token(Token = "0x600094B")]
	public ObsoleteAttribute(string message) { }

	[Address(RVA = "0x2043B00", Offset = "0x2042F00", Length = "0x44")]
	[Token(Token = "0x600094C")]
	public ObsoleteAttribute(string message, bool error) { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x600094E")]
	public bool get_IsError() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600094D")]
	public string get_Message() { }

}

