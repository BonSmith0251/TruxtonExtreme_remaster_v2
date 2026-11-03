namespace Newtonsoft.Json.Bson;

[Token(Token = "0x20001E2")]
internal class BsonRegex : BsonToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000861")]
	private BsonString <Pattern>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000862")]
	private BsonString <Options>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170002BD")]
	public BsonString Options
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001021")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001022")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002BC")]
	public BsonString Pattern
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600101F")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001020")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002BE")]
	public virtual BsonType Type
	{
		[Address(RVA = "0x21AD730", Offset = "0x21ACB30", Length = "0x3")]
		[Token(Token = "0x6001024")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x21AD650", Offset = "0x21ACA50", Length = "0xD9")]
	[Token(Token = "0x6001023")]
	public BsonRegex(string pattern, string options) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001021")]
	public BsonString get_Options() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600101F")]
	public BsonString get_Pattern() { }

	[Address(RVA = "0x21AD730", Offset = "0x21ACB30", Length = "0x3")]
	[Token(Token = "0x6001024")]
	public virtual BsonType get_Type() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001022")]
	public void set_Options(BsonString value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001020")]
	public void set_Pattern(BsonString value) { }

}

