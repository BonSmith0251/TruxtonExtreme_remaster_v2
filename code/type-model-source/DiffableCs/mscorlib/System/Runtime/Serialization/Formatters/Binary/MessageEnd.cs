namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200041F")]
internal sealed class MessageEnd
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001EE1")]
	internal MessageEnd() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EE4")]
	public void Dump() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EE5")]
	public void Dump(Stream sout) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EE3")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1F1CDE0", Offset = "0x1F1C1E0", Length = "0x31")]
	[Token(Token = "0x6001EE2")]
	public override void Write(__BinaryWriter sout) { }

}

