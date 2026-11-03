namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200041D")]
internal sealed class MemberReference
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001044")]
	internal int idRef; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001ED7")]
	internal MemberReference() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EDB")]
	public void Dump() { }

	[Address(RVA = "0x1F17920", Offset = "0x1F16D20", Length = "0x29")]
	[Token(Token = "0x6001EDA")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6001ED8")]
	internal void Set(int idRef) { }

	[Address(RVA = "0x1F1CD70", Offset = "0x1F1C170", Length = "0x62")]
	[Token(Token = "0x6001ED9")]
	public override void Write(__BinaryWriter sout) { }

}

