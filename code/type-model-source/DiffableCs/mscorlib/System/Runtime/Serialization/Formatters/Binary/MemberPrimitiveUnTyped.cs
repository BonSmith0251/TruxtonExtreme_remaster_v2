namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200041C")]
internal sealed class MemberPrimitiveUnTyped
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001042")]
	internal InternalPrimitiveTypeE typeInformation; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001043")]
	internal object value; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001ED1")]
	internal MemberPrimitiveUnTyped() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001ED6")]
	public void Dump() { }

	[Address(RVA = "0x1F1CD00", Offset = "0x1F1C100", Length = "0x39")]
	[Token(Token = "0x6001ED5")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1F16800", Offset = "0x1F15C00", Length = "0x13")]
	[Token(Token = "0x6001ED2")]
	internal void Set(InternalPrimitiveTypeE typeInformation, object value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6001ED3")]
	internal void Set(InternalPrimitiveTypeE typeInformation) { }

	[Address(RVA = "0x1F1CD40", Offset = "0x1F1C140", Length = "0x27")]
	[Token(Token = "0x6001ED4")]
	public override void Write(__BinaryWriter sout) { }

}

