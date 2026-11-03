namespace System.Xml;

[Token(Token = "0x20000D1")]
internal class Ucs4Encoding1234 : Ucs4Encoding
{

	[Token(Token = "0x170002D4")]
	public virtual string EncodingName
	{
		[Address(RVA = "0x254BBD0", Offset = "0x254AFD0", Length = "0x2C")]
		[Token(Token = "0x6000B30")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x254BB20", Offset = "0x254AF20", Length = "0xA3")]
	[Token(Token = "0x6000B2F")]
	public Ucs4Encoding1234() { }

	[Address(RVA = "0x254BBD0", Offset = "0x254AFD0", Length = "0x2C")]
	[Token(Token = "0x6000B30")]
	public virtual string get_EncodingName() { }

	[Address(RVA = "0x254BAC0", Offset = "0x254AEC0", Length = "0x5A")]
	[Token(Token = "0x6000B31")]
	public virtual Byte[] GetPreamble() { }

}

