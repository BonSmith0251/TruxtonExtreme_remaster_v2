namespace System.Net;

[Token(Token = "0x200023E")]
public class Authorization
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008D3")]
	private string m_Message; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008D4")]
	private bool m_Complete; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008D5")]
	internal string ModuleAuthenticationType; //Field offset: 0x20

	[Token(Token = "0x17000323")]
	public bool Complete
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000F5A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000322")]
	public string Message
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000F59")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2698150", Offset = "0x2697550", Length = "0x77")]
	[Token(Token = "0x6000F57")]
	public Authorization(string token) { }

	[Address(RVA = "0x26981D0", Offset = "0x26975D0", Length = "0x85")]
	[Token(Token = "0x6000F58")]
	public Authorization(string token, bool finished) { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000F5A")]
	public bool get_Complete() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000F59")]
	public string get_Message() { }

}

