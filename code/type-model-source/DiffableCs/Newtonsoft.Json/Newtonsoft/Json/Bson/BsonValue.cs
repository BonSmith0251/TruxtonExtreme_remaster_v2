namespace Newtonsoft.Json.Bson;

[Token(Token = "0x20001DE")]
internal class BsonValue : BsonToken
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400085A")]
	private readonly object _value; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400085B")]
	private readonly BsonType _type; //Field offset: 0x28

	[Token(Token = "0x170002B8")]
	public virtual BsonType Type
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6001015")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B7")]
	public object Value
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001014")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x21AD790", Offset = "0x21ACB90", Length = "0x44")]
	[Token(Token = "0x6001013")]
	public BsonValue(object value, BsonType type) { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6001015")]
	public virtual BsonType get_Type() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001014")]
	public object get_Value() { }

}

