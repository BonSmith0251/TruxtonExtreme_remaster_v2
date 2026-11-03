namespace System.Xml;

[Token(Token = "0x20000D4")]
internal class Ucs4Encoding3412 : Ucs4Encoding
{

	[Token(Token = "0x170002D7")]
	public virtual string EncodingName
	{
		[Address(RVA = "0x254BE50", Offset = "0x254B250", Length = "0x2C")]
		[Token(Token = "0x6000B39")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x254BDA0", Offset = "0x254B1A0", Length = "0xA3")]
	[Token(Token = "0x6000B38")]
	public Ucs4Encoding3412() { }

	[Address(RVA = "0x254BE50", Offset = "0x254B250", Length = "0x2C")]
	[Token(Token = "0x6000B39")]
	public virtual string get_EncodingName() { }

	[Address(RVA = "0x254BD40", Offset = "0x254B140", Length = "0x5A")]
	[Token(Token = "0x6000B3A")]
	public virtual Byte[] GetPreamble() { }

}

