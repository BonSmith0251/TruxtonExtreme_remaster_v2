namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000424")]
internal sealed class __BinaryWriter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400109C")]
	internal Stream sout; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400109D")]
	internal FormatterTypeStyle formatterTypeStyle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400109E")]
	internal Hashtable objectMapTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400109F")]
	internal ObjectWriter objectWriter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010A0")]
	internal BinaryWriter dataWriter; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40010A1")]
	internal int m_nestedObjectCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40010A2")]
	private int nullCount; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40010A3")]
	internal BinaryMethodCall binaryMethodCall; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40010A4")]
	internal BinaryMethodReturn binaryMethodReturn; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40010A5")]
	internal BinaryObject binaryObject; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40010A6")]
	internal BinaryObjectWithMap binaryObjectWithMap; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40010A7")]
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40010A8")]
	internal BinaryObjectString binaryObjectString; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40010A9")]
	internal BinaryArray binaryArray; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40010AA")]
	private Byte[] byteBuffer; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40010AB")]
	private int chunkSize; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40010AC")]
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40010AD")]
	internal MemberPrimitiveTyped memberPrimitiveTyped; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40010AE")]
	internal ObjectNull objectNull; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40010AF")]
	internal MemberReference memberReference; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40010B0")]
	internal BinaryAssembly binaryAssembly; //Field offset: 0xA8

	[Address(RVA = "0x1F31290", Offset = "0x1F30690", Length = "0x619")]
	[Token(Token = "0x6001F0D")]
	internal __BinaryWriter(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	[Address(RVA = "0x1F2E670", Offset = "0x1F2DA70", Length = "0xAE")]
	[Token(Token = "0x6001F38")]
	private void InternalWriteItemNull() { }

	[Address(RVA = "0x1F2E720", Offset = "0x1F2DB20", Length = "0x153")]
	[Token(Token = "0x6001F2B")]
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	[Address(RVA = "0x1F2E880", Offset = "0x1F2DC80", Length = "0x148")]
	[Token(Token = "0x6001F3A")]
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001F0E")]
	internal void WriteBegin() { }

	[Address(RVA = "0x1F2E9D0", Offset = "0x1F2DDD0", Length = "0x2A")]
	[Token(Token = "0x6001F10")]
	internal void WriteBoolean(bool value) { }

	[Address(RVA = "0x1F2EA00", Offset = "0x1F2DE00", Length = "0x2A")]
	[Token(Token = "0x6001F11")]
	internal void WriteByte(byte value) { }

	[Address(RVA = "0x1F2EA30", Offset = "0x1F2DE30", Length = "0x2A")]
	[Token(Token = "0x6001F12")]
	private void WriteBytes(Byte[] value) { }

	[Address(RVA = "0x1F2EA60", Offset = "0x1F2DE60", Length = "0x2F")]
	[Token(Token = "0x6001F13")]
	private void WriteBytes(Byte[] byteA, int offset, int size) { }

	[Address(RVA = "0x1F2EA90", Offset = "0x1F2DE90", Length = "0x2A")]
	[Token(Token = "0x6001F14")]
	internal void WriteChar(char value) { }

	[Address(RVA = "0x1F2EAC0", Offset = "0x1F2DEC0", Length = "0x2A")]
	[Token(Token = "0x6001F15")]
	internal void WriteChars(Char[] value) { }

	[Address(RVA = "0x1F2EAF0", Offset = "0x1F2DEF0", Length = "0x70")]
	[Token(Token = "0x6001F1F")]
	internal void WriteDateTime(DateTime value) { }

	[Address(RVA = "0x1F2EB70", Offset = "0x1F2DF70", Length = "0xB4")]
	[Token(Token = "0x6001F16")]
	internal void WriteDecimal(decimal value) { }

	[Address(RVA = "0x1F2EC30", Offset = "0x1F2E030", Length = "0x4")]
	[Token(Token = "0x6001F36")]
	internal void WriteDelayedNullItem() { }

	[Address(RVA = "0x1F2EC40", Offset = "0x1F2E040", Length = "0x2A")]
	[Token(Token = "0x6001F18")]
	internal void WriteDouble(double value) { }

	[Address(RVA = "0x1F2EC70", Offset = "0x1F2E070", Length = "0x2A")]
	[Token(Token = "0x6001F0F")]
	internal void WriteEnd() { }

	[Address(RVA = "0x1F2ECA0", Offset = "0x1F2E0A0", Length = "0x2A")]
	[Token(Token = "0x6001F19")]
	internal void WriteInt16(short value) { }

	[Address(RVA = "0x1F2ECD0", Offset = "0x1F2E0D0", Length = "0x2A")]
	[Token(Token = "0x6001F1A")]
	internal void WriteInt32(int value) { }

	[Address(RVA = "0x1F2ED00", Offset = "0x1F2E100", Length = "0x2A")]
	[Token(Token = "0x6001F1B")]
	internal void WriteInt64(long value) { }

	[Address(RVA = "0x1F2ED80", Offset = "0x1F2E180", Length = "0x55")]
	[Token(Token = "0x6001F34")]
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	[Address(RVA = "0x1F2ED30", Offset = "0x1F2E130", Length = "0x7")]
	[Token(Token = "0x6001F37")]
	internal void WriteItemEnd() { }

	[Address(RVA = "0x1F2ED40", Offset = "0x1F2E140", Length = "0x3F")]
	[Token(Token = "0x6001F39")]
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	[Address(RVA = "0x1F2EDE0", Offset = "0x1F2E1E0", Length = "0x1F5")]
	[Token(Token = "0x6001F2C")]
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	[Address(RVA = "0x1F2F170", Offset = "0x1F2E570", Length = "0x1C3")]
	[Token(Token = "0x6001F2F")]
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	[Address(RVA = "0x1F2EFE0", Offset = "0x1F2E3E0", Length = "0x20")]
	[Token(Token = "0x6001F32")]
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	[Address(RVA = "0x1F2F010", Offset = "0x1F2E410", Length = "0xF8")]
	[Token(Token = "0x6001F31")]
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	[Address(RVA = "0x1F2F110", Offset = "0x1F2E510", Length = "0x5B")]
	[Token(Token = "0x6001F33")]
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	[Address(RVA = "0x1F2F340", Offset = "0x1F2E740", Length = "0x83")]
	[Token(Token = "0x6001F26")]
	internal void WriteMethodCall() { }

	[Address(RVA = "0x1F2F3D0", Offset = "0x1F2E7D0", Length = "0x83")]
	[Token(Token = "0x6001F27")]
	internal void WriteMethodReturn() { }

	[Address(RVA = "0x1F2F460", Offset = "0x1F2E860", Length = "0xA")]
	[Token(Token = "0x6001F35")]
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	[Address(RVA = "0x1F2F470", Offset = "0x1F2E870", Length = "0xCA")]
	[Token(Token = "0x6001F30")]
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	[Address(RVA = "0x1F2F6C0", Offset = "0x1F2EAC0", Length = "0x8EE")]
	[Token(Token = "0x6001F28")]
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, String[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	[Address(RVA = "0x1F2F540", Offset = "0x1F2E940", Length = "0x58")]
	[Token(Token = "0x6001F2E")]
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Byte[] byteA) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001F23")]
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	[Address(RVA = "0x1F2F5A0", Offset = "0x1F2E9A0", Length = "0x112")]
	[Token(Token = "0x6001F29")]
	internal void WriteObjectString(int objectId, string value) { }

	[Address(RVA = "0x1F2FFB0", Offset = "0x1F2F3B0", Length = "0x1B2")]
	[Token(Token = "0x6001F2D")]
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, Int32[] lengthA, Int32[] lowerBoundA) { }

	[Address(RVA = "0x1F2EA00", Offset = "0x1F2DE00", Length = "0x2A")]
	[Token(Token = "0x6001F1C")]
	internal void WriteSByte(sbyte value) { }

	[Address(RVA = "0x1F301F0", Offset = "0x1F2F5F0", Length = "0x138")]
	[Token(Token = "0x6001F25")]
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	[Address(RVA = "0x1F30170", Offset = "0x1F2F570", Length = "0x7A")]
	[Token(Token = "0x6001F24")]
	internal void WriteSerializationHeaderEnd() { }

	[Address(RVA = "0x1F30870", Offset = "0x1F2FC70", Length = "0x2A")]
	[Token(Token = "0x6001F17")]
	internal void WriteSingle(float value) { }

	[Address(RVA = "0x1F30330", Offset = "0x1F2F730", Length = "0x4B4")]
	[Token(Token = "0x6001F2A")]
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	[Address(RVA = "0x1F308A0", Offset = "0x1F2FCA0", Length = "0x2A")]
	[Token(Token = "0x6001F1D")]
	internal void WriteString(string value) { }

	[Address(RVA = "0x1F308D0", Offset = "0x1F2FCD0", Length = "0x70")]
	[Token(Token = "0x6001F1E")]
	internal void WriteTimeSpan(TimeSpan value) { }

	[Address(RVA = "0x1F30950", Offset = "0x1F2FD50", Length = "0x2A")]
	[Token(Token = "0x6001F20")]
	internal void WriteUInt16(ushort value) { }

	[Address(RVA = "0x1F30980", Offset = "0x1F2FD80", Length = "0x2A")]
	[Token(Token = "0x6001F21")]
	internal void WriteUInt32(uint value) { }

	[Address(RVA = "0x1F309B0", Offset = "0x1F2FDB0", Length = "0x2A")]
	[Token(Token = "0x6001F22")]
	internal void WriteUInt64(ulong value) { }

	[Address(RVA = "0x1F309E0", Offset = "0x1F2FDE0", Length = "0x868")]
	[Token(Token = "0x6001F3B")]
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }

}

