namespace Newtonsoft.Json.Converters;

[NullableContext(2)]
[Token(Token = "0x20001C6")]
internal interface IXmlDocumentType : IXmlNode
{

	[Token(Token = "0x17000270")]
	public string InternalSubset
	{
		[Token(Token = "0x6000F44")]
		 get { } //Length: 0
	}

	[Nullable(1)]
	[Token(Token = "0x1700026D")]
	public string Name
	{
		[NullableContext(1)]
		[Token(Token = "0x6000F41")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700026F")]
	public string Public
	{
		[Token(Token = "0x6000F43")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700026E")]
	public string System
	{
		[Token(Token = "0x6000F42")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000F44")]
	public string get_InternalSubset() { }

	[NullableContext(1)]
	[Token(Token = "0x6000F41")]
	public string get_Name() { }

	[Token(Token = "0x6000F43")]
	public string get_Public() { }

	[Token(Token = "0x6000F42")]
	public string get_System() { }

}

