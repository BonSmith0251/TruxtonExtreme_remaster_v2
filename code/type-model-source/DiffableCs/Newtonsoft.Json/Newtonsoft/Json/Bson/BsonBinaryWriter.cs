namespace Newtonsoft.Json.Bson;

[Token(Token = "0x20001D5")]
internal class BsonBinaryWriter
{
	[Token(Token = "0x4000832")]
	private static readonly Encoding Encoding; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000833")]
	private readonly BinaryWriter _writer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000834")]
	private Byte[] _largeByteBuffer; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000835")]
	private DateTimeKind <DateTimeKindHandling>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170002AC")]
	public DateTimeKind DateTimeKindHandling
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000FCE")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000FCF")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x21AAAC0", Offset = "0x21A9EC0", Length = "0x76")]
	[Token(Token = "0x6000FDA")]
	private static BsonBinaryWriter() { }

	[Address(RVA = "0x21AAB40", Offset = "0x21A9F40", Length = "0x38")]
	[Token(Token = "0x6000FD0")]
	public BsonBinaryWriter(BinaryWriter writer) { }

	[Address(RVA = "0x21A91D0", Offset = "0x21A85D0", Length = "0x4")]
	[Token(Token = "0x6000FD7")]
	private int CalculateSize(int stringByteCount) { }

	[Address(RVA = "0x21A91E0", Offset = "0x21A85E0", Length = "0x670")]
	[Token(Token = "0x6000FD9")]
	private int CalculateSize(BsonToken t) { }

	[Address(RVA = "0x21A91C0", Offset = "0x21A85C0", Length = "0x10")]
	[Token(Token = "0x6000FD8")]
	private int CalculateSizeWithLength(int stringByteCount, bool includeSize) { }

	[Address(RVA = "0x2171280", Offset = "0x2170680", Length = "0x2A")]
	[Token(Token = "0x6000FD2")]
	public void Close() { }

	[Address(RVA = "0x21A98A0", Offset = "0x21A8CA0", Length = "0x2A")]
	[Token(Token = "0x6000FD1")]
	public void Flush() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000FCE")]
	public DateTimeKind get_DateTimeKindHandling() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000FCF")]
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	[Address(RVA = "0x21A98D0", Offset = "0x21A8CD0", Length = "0x211")]
	[Token(Token = "0x6000FD5")]
	private void WriteString(string s, int byteCount, Nullable<Int32> calculatedlengthPrefix) { }

	[Address(RVA = "0x21AA8F0", Offset = "0x21A9CF0", Length = "0x30")]
	[Token(Token = "0x6000FD3")]
	public void WriteToken(BsonToken t) { }

	[Address(RVA = "0x21A9AF0", Offset = "0x21A8EF0", Length = "0xDB8")]
	[Token(Token = "0x6000FD4")]
	private void WriteTokenInternal(BsonToken t) { }

	[Address(RVA = "0x21AA920", Offset = "0x21A9D20", Length = "0x194")]
	[Token(Token = "0x6000FD6")]
	public void WriteUtf8Bytes(string s, int byteCount) { }

}

