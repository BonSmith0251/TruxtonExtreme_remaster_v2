namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200041E")]
internal sealed class ObjectNull
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001045")]
	internal int nullCount; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001EDC")]
	internal ObjectNull() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EE0")]
	public void Dump() { }

	[Address(RVA = "0x1F1DD50", Offset = "0x1F1D150", Length = "0x6F")]
	[Token(Token = "0x6001EDF")]
	public void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6001EDD")]
	internal void SetNullCount(int nullCount) { }

	[Address(RVA = "0x1F1DDC0", Offset = "0x1F1D1C0", Length = "0xF4")]
	[Token(Token = "0x6001EDE")]
	public override void Write(__BinaryWriter sout) { }

}

