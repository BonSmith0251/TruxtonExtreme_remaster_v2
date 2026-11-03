namespace System.Net;

[Token(Token = "0x200024C")]
internal static class ExceptionHelper
{

	[Token(Token = "0x1700032D")]
	internal static NotImplementedException MethodNotImplementedException
	{
		[Address(RVA = "0x269A9E0", Offset = "0x2699DE0", Length = "0x6E")]
		[Token(Token = "0x6000F79")]
		internal get { } //Length: 110
	}

	[Token(Token = "0x1700032E")]
	internal static NotImplementedException PropertyNotImplementedException
	{
		[Address(RVA = "0x269AA50", Offset = "0x2699E50", Length = "0x6E")]
		[Token(Token = "0x6000F7A")]
		internal get { } //Length: 110
	}

	[Token(Token = "0x17000330")]
	internal static NotSupportedException PropertyNotSupportedException
	{
		[Address(RVA = "0x269AAC0", Offset = "0x2699EC0", Length = "0x6E")]
		[Token(Token = "0x6000F7C")]
		internal get { } //Length: 110
	}

	[Token(Token = "0x17000331")]
	internal static WebException RequestAbortedException
	{
		[Address(RVA = "0x269AB30", Offset = "0x2699F30", Length = "0x86")]
		[Token(Token = "0x6000F7D")]
		internal get { } //Length: 134
	}

	[Token(Token = "0x1700032F")]
	internal static WebException TimeoutException
	{
		[Address(RVA = "0x269ABC0", Offset = "0x2699FC0", Length = "0x65")]
		[Token(Token = "0x6000F7B")]
		internal get { } //Length: 101
	}

	[Address(RVA = "0x269A9E0", Offset = "0x2699DE0", Length = "0x6E")]
	[Token(Token = "0x6000F79")]
	internal static NotImplementedException get_MethodNotImplementedException() { }

	[Address(RVA = "0x269AA50", Offset = "0x2699E50", Length = "0x6E")]
	[Token(Token = "0x6000F7A")]
	internal static NotImplementedException get_PropertyNotImplementedException() { }

	[Address(RVA = "0x269AAC0", Offset = "0x2699EC0", Length = "0x6E")]
	[Token(Token = "0x6000F7C")]
	internal static NotSupportedException get_PropertyNotSupportedException() { }

	[Address(RVA = "0x269AB30", Offset = "0x2699F30", Length = "0x86")]
	[Token(Token = "0x6000F7D")]
	internal static WebException get_RequestAbortedException() { }

	[Address(RVA = "0x269ABC0", Offset = "0x2699FC0", Length = "0x65")]
	[Token(Token = "0x6000F7B")]
	internal static WebException get_TimeoutException() { }

}

