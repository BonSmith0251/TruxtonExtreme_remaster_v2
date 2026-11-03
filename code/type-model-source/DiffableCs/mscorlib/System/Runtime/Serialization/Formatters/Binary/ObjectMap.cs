namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000420")]
internal sealed class ObjectMap
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001046")]
	internal string objectName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001047")]
	internal Type objectType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001048")]
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001049")]
	internal Object[] typeInformationA; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400104A")]
	internal Type[] memberTypes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400104B")]
	internal String[] memberNames; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400104C")]
	internal ReadObjectInfo objectInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400104D")]
	internal bool isInitObjectInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400104E")]
	internal ObjectReader objectReader; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400104F")]
	internal int objectId; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001050")]
	internal BinaryAssemblyInfo assemblyInfo; //Field offset: 0x60

	[Address(RVA = "0x1F1DA90", Offset = "0x1F1CE90", Length = "0x2B2")]
	[Token(Token = "0x6001EE6")]
	internal ObjectMap(string objectName, Type objectType, String[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	[Address(RVA = "0x1F1D570", Offset = "0x1F1C970", Length = "0x51F")]
	[Token(Token = "0x6001EE7")]
	internal ObjectMap(string objectName, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	[Address(RVA = "0x1F1D400", Offset = "0x1F1C800", Length = "0xA0")]
	[Token(Token = "0x6001EE9")]
	internal static ObjectMap Create(string name, Type objectType, String[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	[Address(RVA = "0x1F1D4A0", Offset = "0x1F1C8A0", Length = "0xCD")]
	[Token(Token = "0x6001EEA")]
	internal static ObjectMap Create(string name, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	[Address(RVA = "0x1F1D3B0", Offset = "0x1F1C7B0", Length = "0x45")]
	[Token(Token = "0x6001EE8")]
	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref Object[] memberData) { }

}

