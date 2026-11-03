namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000421")]
internal sealed class ObjectProgress
{
	[Token(Token = "0x4001051")]
	internal static int opRecordIdCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001052")]
	internal bool isInitial; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001053")]
	internal int count; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001054")]
	internal BinaryTypeEnum expectedType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001055")]
	internal object expectedTypeInformation; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001056")]
	internal string name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001057")]
	internal InternalObjectTypeE objectTypeEnum; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001058")]
	internal InternalMemberTypeE memberTypeEnum; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001059")]
	internal InternalMemberValueE memberValueEnum; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400105A")]
	internal Type dtType; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400105B")]
	internal int numItems; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400105C")]
	internal BinaryTypeEnum binaryTypeEnum; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400105D")]
	internal object typeInformation; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400105E")]
	internal int nullCount; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400105F")]
	internal int memberLength; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001060")]
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001061")]
	internal Object[] typeInformationA; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001062")]
	internal String[] memberNames; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001063")]
	internal Type[] memberTypes; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001064")]
	internal ParseRecord pr; //Field offset: 0x80

	[Address(RVA = "0x1F1E100", Offset = "0x1F1D500", Length = "0x39")]
	[Token(Token = "0x6001EEF")]
	private static ObjectProgress() { }

	[Address(RVA = "0x1F1E140", Offset = "0x1F1D540", Length = "0x73")]
	[Token(Token = "0x6001EEB")]
	internal ObjectProgress() { }

	[Address(RVA = "0x1F1DEC0", Offset = "0x1F1D2C0", Length = "0x4")]
	[Token(Token = "0x6001EED")]
	internal void ArrayCountIncrement(int value) { }

	[Address(RVA = "0x1F1DED0", Offset = "0x1F1D2D0", Length = "0x157")]
	[Token(Token = "0x6001EEE")]
	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	[Address(RVA = "0x1F1E030", Offset = "0x1F1D430", Length = "0xC7")]
	[Token(Token = "0x6001EEC")]
	internal void Init() { }

}

