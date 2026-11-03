namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200040F")]
internal sealed class SerializationHeaderRecord
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001007")]
	internal int binaryFormatterMajorVersion; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001008")]
	internal int binaryFormatterMinorVersion; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001009")]
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400100A")]
	internal int topId; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400100B")]
	internal int headerId; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400100C")]
	internal int majorVersion; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400100D")]
	internal int minorVersion; //Field offset: 0x28

	[Address(RVA = "0x1F29D20", Offset = "0x1F29120", Length = "0xE")]
	[Token(Token = "0x6001E97")]
	internal SerializationHeaderRecord() { }

	[Address(RVA = "0x1F29D30", Offset = "0x1F29130", Length = "0x59")]
	[Token(Token = "0x6001E98")]
	internal SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001E9C")]
	public void Dump() { }

	[Address(RVA = "0x1F29990", Offset = "0x1F28D90", Length = "0x6D")]
	[Token(Token = "0x6001E9A")]
	private static int GetInt32(Byte[] buffer, int index) { }

	[Address(RVA = "0x1F29A00", Offset = "0x1F28E00", Length = "0x23D")]
	[Token(Token = "0x6001E9B")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1F29C40", Offset = "0x1F29040", Length = "0xD5")]
	[Token(Token = "0x6001E99")]
	public override void Write(__BinaryWriter sout) { }

}

