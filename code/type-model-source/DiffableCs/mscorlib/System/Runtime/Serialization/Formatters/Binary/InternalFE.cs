namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000436")]
internal sealed class InternalFE
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001167")]
	internal FormatterTypeStyle FEtypeFormat; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001168")]
	internal FormatterAssemblyStyle FEassemblyFormat; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001169")]
	internal TypeFilterLevel FEsecurityLevel; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400116A")]
	internal InternalSerializerTypeE FEserializerTypeEnum; //Field offset: 0x1C

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001FFC")]
	public InternalFE() { }

}

