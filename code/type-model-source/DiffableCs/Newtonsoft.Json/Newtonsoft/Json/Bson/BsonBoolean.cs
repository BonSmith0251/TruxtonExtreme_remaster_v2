namespace Newtonsoft.Json.Bson;

[Token(Token = "0x20001DF")]
internal class BsonBoolean : BsonValue
{
	[Token(Token = "0x400085C")]
	public static readonly BsonBoolean False; //Field offset: 0x0
	[Token(Token = "0x400085D")]
	public static readonly BsonBoolean True; //Field offset: 0x8

	[Address(RVA = "0x21AABD0", Offset = "0x21A9FD0", Length = "0x10F")]
	[Token(Token = "0x6001017")]
	private static BsonBoolean() { }

	[Address(RVA = "0x21AACE0", Offset = "0x21AA0E0", Length = "0x4E")]
	[Token(Token = "0x6001016")]
	private BsonBoolean(bool value) { }

}

