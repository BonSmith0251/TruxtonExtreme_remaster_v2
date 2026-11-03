namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000416")]
internal sealed class BinaryCrossAppDomainString
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001025")]
	internal int objectId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001026")]
	internal int value; //Field offset: 0x14

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001EB6")]
	internal BinaryCrossAppDomainString() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EB8")]
	public void Dump() { }

	[Address(RVA = "0x1F178E0", Offset = "0x1F16CE0", Length = "0x3F")]
	[Token(Token = "0x6001EB7")]
	public override void Read(__BinaryParser input) { }

}

