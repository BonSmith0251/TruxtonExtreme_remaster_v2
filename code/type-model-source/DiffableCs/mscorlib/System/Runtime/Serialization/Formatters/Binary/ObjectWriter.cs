namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200042E")]
internal sealed class ObjectWriter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010FF")]
	private Queue m_objectQueue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001100")]
	private ObjectIDGenerator m_idGenerator; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001101")]
	private int m_currentId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001102")]
	private ISurrogateSelector m_surrogates; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001103")]
	private StreamingContext m_context; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001104")]
	private __BinaryWriter serWriter; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001105")]
	private SerializationObjectManager m_objectManager; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001106")]
	private long topId; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001107")]
	private string topName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001108")]
	private Header[] headers; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001109")]
	private InternalFE formatterEnums; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400110A")]
	private SerializationBinder m_binder; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400110B")]
	private SerObjectInfoInit serObjectInfoInit; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400110C")]
	private IFormatterConverter m_formatterConverter; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400110D")]
	internal Object[] crossAppDomainArray; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400110E")]
	private object previousObj; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400110F")]
	private long previousId; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001110")]
	private Type previousType; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001111")]
	private InternalPrimitiveTypeE previousCode; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001112")]
	private Hashtable assemblyToIdTable; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001113")]
	private SerStack niPool; //Field offset: 0xB8

	[Token(Token = "0x170003E4")]
	internal SerializationObjectManager ObjectManager
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6001F92")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1F26640", Offset = "0x1F25A40", Length = "0x139")]
	[Token(Token = "0x6001F90")]
	internal ObjectWriter(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	[Address(RVA = "0x1F22430", Offset = "0x1F21830", Length = "0x1A4")]
	[Token(Token = "0x6001FA1")]
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	[Address(RVA = "0x1F225E0", Offset = "0x1F219E0", Length = "0xA")]
	[Token(Token = "0x6001FAD")]
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6001F92")]
	internal SerializationObjectManager get_ObjectManager() { }

	[Address(RVA = "0x1F225F0", Offset = "0x1F219F0", Length = "0x398")]
	[Token(Token = "0x6001FAA")]
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	[Address(RVA = "0x1F22990", Offset = "0x1F21D90", Length = "0xAC")]
	[Token(Token = "0x6001FAC")]
	private NameInfo GetNameInfo() { }

	[Address(RVA = "0x1F22A40", Offset = "0x1F21E40", Length = "0x1B3")]
	[Token(Token = "0x6001F9A")]
	private object GetNext(out long objID) { }

	[Address(RVA = "0x1F22C00", Offset = "0x1F22000", Length = "0x1F")]
	[Token(Token = "0x6001FAB")]
	private Type GetType(object obj) { }

	[Address(RVA = "0x1F22C20", Offset = "0x1F22020", Length = "0xF3")]
	[Token(Token = "0x6001F9B")]
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	[Address(RVA = "0x1F22D20", Offset = "0x1F22120", Length = "0x3F")]
	[Token(Token = "0x6001FA8")]
	private NameInfo MemberToNameInfo(string name) { }

	[Address(RVA = "0x1F22D60", Offset = "0x1F22160", Length = "0x21")]
	[Token(Token = "0x6001FAE")]
	private void PutNameInfo(NameInfo nameInfo) { }

	[Address(RVA = "0x1F22E50", Offset = "0x1F22250", Length = "0x7B")]
	[Token(Token = "0x6001F9C")]
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	[Address(RVA = "0x1F22D90", Offset = "0x1F22190", Length = "0xB0")]
	[Token(Token = "0x6001F9D")]
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	[Address(RVA = "0x1F22ED0", Offset = "0x1F222D0", Length = "0x5E5")]
	[Token(Token = "0x6001F91")]
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	[Address(RVA = "0x1F234C0", Offset = "0x1F228C0", Length = "0x9E")]
	[Token(Token = "0x6001FA9")]
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	[Address(RVA = "0x1F236E0", Offset = "0x1F22AE0", Length = "0x5C")]
	[Token(Token = "0x6001FA4")]
	private NameInfo TypeToNameInfo(Type type) { }

	[Address(RVA = "0x1F23630", Offset = "0x1F22A30", Length = "0xAB")]
	[Token(Token = "0x6001FA3")]
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	[Address(RVA = "0x1F237F0", Offset = "0x1F22BF0", Length = "0x74")]
	[Token(Token = "0x6001FA7")]
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	[Address(RVA = "0x1F23740", Offset = "0x1F22B40", Length = "0xAC")]
	[Token(Token = "0x6001FA5")]
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	[Address(RVA = "0x1F23560", Offset = "0x1F22960", Length = "0xCA")]
	[Token(Token = "0x6001FA6")]
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	[Address(RVA = "0x1F25D40", Offset = "0x1F25140", Length = "0x8F0")]
	[Token(Token = "0x6001F93")]
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	[Address(RVA = "0x1F258D0", Offset = "0x1F24CD0", Length = "0x467")]
	[Token(Token = "0x6001F94")]
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, String[] memberNames, Type[] memberTypes, Object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	[Address(RVA = "0x1F23BC0", Offset = "0x1F22FC0", Length = "0xE08")]
	[Token(Token = "0x6001F97")]
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	[Address(RVA = "0x1F23870", Offset = "0x1F22C70", Length = "0x34B")]
	[Token(Token = "0x6001F98")]
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	[Address(RVA = "0x1F24A10", Offset = "0x1F23E10", Length = "0x210")]
	[Token(Token = "0x6001F9E")]
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	[Address(RVA = "0x1F24DB0", Offset = "0x1F241B0", Length = "0x616")]
	[Token(Token = "0x6001F96")]
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	[Address(RVA = "0x1F24C30", Offset = "0x1F24030", Length = "0x175")]
	[Token(Token = "0x6001F95")]
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	[Address(RVA = "0x1F253D0", Offset = "0x1F247D0", Length = "0x1E")]
	[Token(Token = "0x6001F9F")]
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	[Address(RVA = "0x1F253F0", Offset = "0x1F247F0", Length = "0x246")]
	[Token(Token = "0x6001F99")]
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, Int32[] maxA, Array array, NameInfo arrayElemNameTypeInfo, Int32[] lowerBoundA) { }

	[Address(RVA = "0x1F25640", Offset = "0x1F24A40", Length = "0x13A")]
	[Token(Token = "0x6001FA2")]
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	[Address(RVA = "0x1F25780", Offset = "0x1F24B80", Length = "0x148")]
	[Token(Token = "0x6001FA0")]
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

}

