namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000418")]
internal sealed class MemberPrimitiveTyped
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001028")]
	internal InternalPrimitiveTypeE primitiveTypeEnum; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001029")]
	internal object value; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001EBC")]
	internal MemberPrimitiveTyped() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EC0")]
	public void Dump() { }

	[Address(RVA = "0x1F1CC30", Offset = "0x1F1C030", Length = "0x4F")]
	[Token(Token = "0x6001EBF")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1F16800", Offset = "0x1F15C00", Length = "0x13")]
	[Token(Token = "0x6001EBD")]
	internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value) { }

	[Address(RVA = "0x1F1CC80", Offset = "0x1F1C080", Length = "0x74")]
	[Token(Token = "0x6001EBE")]
	public override void Write(__BinaryWriter sout) { }

}

