namespace Newtonsoft.Json.Bson;

[Token(Token = "0x20001E1")]
internal class BsonBinary : BsonValue
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000860")]
	private BsonBinaryType <BinaryType>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170002BB")]
	public BsonBinaryType BinaryType
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600101C")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600101D")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x21AAB80", Offset = "0x21A9F80", Length = "0x48")]
	[Token(Token = "0x600101E")]
	public BsonBinary(Byte[] value, BsonBinaryType binaryType) { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600101C")]
	public BsonBinaryType get_BinaryType() { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600101D")]
	public void set_BinaryType(BsonBinaryType value) { }

}

