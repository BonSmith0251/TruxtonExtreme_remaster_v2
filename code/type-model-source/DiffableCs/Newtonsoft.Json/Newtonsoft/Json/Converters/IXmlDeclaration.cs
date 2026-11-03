namespace Newtonsoft.Json.Converters;

[NullableContext(2)]
[Token(Token = "0x20001C5")]
internal interface IXmlDeclaration : IXmlNode
{

	[Token(Token = "0x1700026B")]
	public string Encoding
	{
		[Token(Token = "0x6000F3D")]
		 get { } //Length: 0
		[Token(Token = "0x6000F3E")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700026C")]
	public string Standalone
	{
		[Token(Token = "0x6000F3F")]
		 get { } //Length: 0
		[Token(Token = "0x6000F40")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700026A")]
	public string Version
	{
		[Token(Token = "0x6000F3C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000F3D")]
	public string get_Encoding() { }

	[Token(Token = "0x6000F3F")]
	public string get_Standalone() { }

	[Token(Token = "0x6000F3C")]
	public string get_Version() { }

	[Token(Token = "0x6000F3E")]
	public void set_Encoding(string value) { }

	[Token(Token = "0x6000F40")]
	public void set_Standalone(string value) { }

}

