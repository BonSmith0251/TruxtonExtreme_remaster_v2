namespace Newtonsoft.Json.Bson;

[Token(Token = "0x20001DA")]
internal abstract class BsonToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000853")]
	private BsonToken <Parent>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000854")]
	private int <CalculatedSize>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170002B3")]
	public int CalculatedSize
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001003")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001004")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002B2")]
	public BsonToken Parent
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001001")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001002")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002B1")]
	public abstract BsonType Type
	{
		[Token(Token = "0x6001000")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001005")]
	protected BsonToken() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001003")]
	public int get_CalculatedSize() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001001")]
	public BsonToken get_Parent() { }

	[Token(Token = "0x6001000")]
	public abstract BsonType get_Type() { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001004")]
	public void set_CalculatedSize(int value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001002")]
	public void set_Parent(BsonToken value) { }

}

