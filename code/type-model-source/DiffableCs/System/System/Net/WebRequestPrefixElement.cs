namespace System.Net;

[Token(Token = "0x200024D")]
internal class WebRequestPrefixElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000931")]
	public string Prefix; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000932")]
	internal IWebRequestCreate creator; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000933")]
	internal Type creatorType; //Field offset: 0x20

	[Token(Token = "0x17000332")]
	public IWebRequestCreate Creator
	{
		[Address(RVA = "0x26B0F60", Offset = "0x26B0360", Length = "0x1F4")]
		[Token(Token = "0x6000F7E")]
		 get { } //Length: 500
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000F7F")]
		 set { } //Length: 13
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000F80")]
	public WebRequestPrefixElement(string P, IWebRequestCreate C) { }

	[Address(RVA = "0x26B0F60", Offset = "0x26B0360", Length = "0x1F4")]
	[Token(Token = "0x6000F7E")]
	public IWebRequestCreate get_Creator() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000F7F")]
	public void set_Creator(IWebRequestCreate value) { }

}

