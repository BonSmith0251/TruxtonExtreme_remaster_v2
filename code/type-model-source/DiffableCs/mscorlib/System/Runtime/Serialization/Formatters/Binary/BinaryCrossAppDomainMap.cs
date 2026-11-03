namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000417")]
internal sealed class BinaryCrossAppDomainMap
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001027")]
	internal int crossAppDomainArrayIndex; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001EB9")]
	internal BinaryCrossAppDomainMap() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EBB")]
	public void Dump() { }

	[Address(RVA = "0x1F17920", Offset = "0x1F16D20", Length = "0x29")]
	[Token(Token = "0x6001EBA")]
	public override void Read(__BinaryParser input) { }

}

