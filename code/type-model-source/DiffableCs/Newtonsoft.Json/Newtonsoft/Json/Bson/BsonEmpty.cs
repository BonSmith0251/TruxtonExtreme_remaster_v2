namespace Newtonsoft.Json.Bson;

[Token(Token = "0x20001DD")]
internal class BsonEmpty : BsonToken
{
	[Token(Token = "0x4000857")]
	public static readonly BsonToken Null; //Field offset: 0x0
	[Token(Token = "0x4000858")]
	public static readonly BsonToken Undefined; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000859")]
	private readonly BsonType <Type>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170002B6")]
	public virtual BsonType Type
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001011")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x21AAD30", Offset = "0x21AA130", Length = "0xB4")]
	[Token(Token = "0x6001012")]
	private static BsonEmpty() { }

	[Address(RVA = "0x21AADF0", Offset = "0x21AA1F0", Length = "0x26")]
	[Token(Token = "0x6001010")]
	private BsonEmpty(BsonType type) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001011")]
	public virtual BsonType get_Type() { }

}

