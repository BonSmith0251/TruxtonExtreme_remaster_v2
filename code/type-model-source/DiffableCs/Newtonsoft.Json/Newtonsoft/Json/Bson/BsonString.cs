namespace Newtonsoft.Json.Bson;

[Token(Token = "0x20001E0")]
internal class BsonString : BsonValue
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400085E")]
	private int <ByteCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400085F")]
	private readonly bool <IncludeLength>k__BackingField; //Field offset: 0x34

	[Token(Token = "0x170002B9")]
	public int ByteCount
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001018")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001019")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002BA")]
	public bool IncludeLength
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600101A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x21AD740", Offset = "0x21ACB40", Length = "0x48")]
	[Token(Token = "0x600101B")]
	public BsonString(object value, bool includeLength) { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001018")]
	public int get_ByteCount() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600101A")]
	public bool get_IncludeLength() { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001019")]
	public void set_ByteCount(int value) { }

}

