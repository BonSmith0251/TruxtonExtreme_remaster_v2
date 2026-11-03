namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200040C")]
internal static class BinaryConverter
{

	[Address(RVA = "0x1F168B0", Offset = "0x1F15CB0", Length = "0x37A")]
	[Token(Token = "0x6001E8C")]
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId) { }

	[Address(RVA = "0x1F16C30", Offset = "0x1F16030", Length = "0x270")]
	[Token(Token = "0x6001E8D")]
	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation) { }

	[Address(RVA = "0x1F16EB0", Offset = "0x1F162B0", Length = "0x1A4")]
	[Token(Token = "0x6001E8F")]
	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId) { }

	[Address(RVA = "0x1F17080", Offset = "0x1F16480", Length = "0xA4")]
	[Token(Token = "0x6001E90")]
	internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant) { }

	[Address(RVA = "0x1F17660", Offset = "0x1F16A60", Length = "0x254")]
	[Token(Token = "0x6001E8E")]
	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout) { }

}

