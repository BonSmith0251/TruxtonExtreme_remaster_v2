namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000411")]
internal sealed class BinaryCrossAppDomainAssembly
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001010")]
	internal int assemId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001011")]
	internal int assemblyIndex; //Field offset: 0x14

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001EA2")]
	internal BinaryCrossAppDomainAssembly() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EA4")]
	public void Dump() { }

	[Address(RVA = "0x1F178E0", Offset = "0x1F16CE0", Length = "0x3F")]
	[Token(Token = "0x6001EA3")]
	public override void Read(__BinaryParser input) { }

}

