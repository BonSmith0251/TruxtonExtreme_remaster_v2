namespace System.Xml;

[Token(Token = "0x20000D2")]
internal class Ucs4Encoding4321 : Ucs4Encoding
{

	[Token(Token = "0x170002D5")]
	public virtual string EncodingName
	{
		[Address(RVA = "0x254BF90", Offset = "0x254B390", Length = "0x2C")]
		[Token(Token = "0x6000B33")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x254BEE0", Offset = "0x254B2E0", Length = "0xA3")]
	[Token(Token = "0x6000B32")]
	public Ucs4Encoding4321() { }

	[Address(RVA = "0x254BF90", Offset = "0x254B390", Length = "0x2C")]
	[Token(Token = "0x6000B33")]
	public virtual string get_EncodingName() { }

	[Address(RVA = "0x254BE80", Offset = "0x254B280", Length = "0x5A")]
	[Token(Token = "0x6000B34")]
	public virtual Byte[] GetPreamble() { }

}

