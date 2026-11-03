namespace System.Xml.Serialization;

[Token(Token = "0x2000128")]
internal class XmlSerializationReaderInterpreter : XmlSerializationReader
{
	[Token(Token = "0x2000129")]
	private class FixupCallbackInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000683")]
		private XmlSerializationReaderInterpreter _sri; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000684")]
		private ClassMap _map; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000685")]
		private bool _isValueList; //Field offset: 0x20

		[Address(RVA = "0x1F29340", Offset = "0x1F28740", Length = "0x61")]
		[Token(Token = "0x6000D3F")]
		public FixupCallbackInfo(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

		[Address(RVA = "0x255E550", Offset = "0x255D950", Length = "0x34")]
		[Token(Token = "0x6000D40")]
		public void FixupMembers(object fixup) { }

	}

	[Token(Token = "0x200012A")]
	private class ReaderCallbackInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000686")]
		private XmlSerializationReaderInterpreter _sri; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000687")]
		private XmlTypeMapping _typeMap; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x6000D41")]
		public ReaderCallbackInfo(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

		[Address(RVA = "0x255E630", Offset = "0x255DA30", Length = "0x3E")]
		[Token(Token = "0x6000D42")]
		internal object ReadObject() { }

	}

	[Token(Token = "0x4000681")]
	private static readonly XmlQualifiedName AnyType; //Field offset: 0x0
	[Token(Token = "0x4000682")]
	private static readonly Object[] empty_array; //Field offset: 0x8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400067F")]
	private XmlMapping _typeMap; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000680")]
	private SerializationFormat _format; //Field offset: 0xD8

	[Address(RVA = "0x2570E60", Offset = "0x2570260", Length = "0xE0")]
	[Token(Token = "0x6000D3E")]
	private static XmlSerializationReaderInterpreter() { }

	[Address(RVA = "0x2570F40", Offset = "0x2570340", Length = "0x4B")]
	[Token(Token = "0x6000D18")]
	public XmlSerializationReaderInterpreter(XmlMapping typeMap) { }

	[Address(RVA = "0x256AAA0", Offset = "0x2569EA0", Length = "0x369")]
	[Token(Token = "0x6000D31")]
	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	[Address(RVA = "0x256AE10", Offset = "0x256A210", Length = "0x33E")]
	[Token(Token = "0x6000D37")]
	private void CopyEnumerableList(object source, object dest) { }

	[Address(RVA = "0x256B160", Offset = "0x256A560", Length = "0x5F")]
	[Token(Token = "0x6000D33")]
	private object CreateInstance(Type type) { }

	[Address(RVA = "0x256B150", Offset = "0x256A550", Length = "0x8")]
	[Token(Token = "0x6000D32")]
	private static object CreateInstance(Type type, bool nonPublic) { }

	[Address(RVA = "0x256B1C0", Offset = "0x256A5C0", Length = "0x90")]
	[Token(Token = "0x6000D34")]
	private object CreateList(Type listType) { }

	[Address(RVA = "0x256B260", Offset = "0x256A660", Length = "0x11")]
	[Token(Token = "0x6000D36")]
	private void FillList(object list, object items) { }

	[Address(RVA = "0x256B280", Offset = "0x256A680", Length = "0x309")]
	[Token(Token = "0x6000D25")]
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	[Address(RVA = "0x256B590", Offset = "0x256A990", Length = "0x170")]
	[Token(Token = "0x6000D3C")]
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	[Address(RVA = "0x256B710", Offset = "0x256AB10", Length = "0xCD")]
	[Token(Token = "0x6000D2B")]
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	[Address(RVA = "0x256B7E0", Offset = "0x256ABE0", Length = "0x11E")]
	[Token(Token = "0x6000D2E")]
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	[Address(RVA = "0x256B900", Offset = "0x256AD00", Length = "0x305")]
	[Token(Token = "0x6000D19")]
	protected virtual void InitCallbacks() { }

	[Address(RVA = "0x256BC10", Offset = "0x256B010", Length = "0x76")]
	[Token(Token = "0x6000D35")]
	private object InitializeList(TypeData listType) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000D1A")]
	protected virtual void InitIDs() { }

	[Address(RVA = "0x256BC90", Offset = "0x256B090", Length = "0x7E")]
	[Token(Token = "0x6000D28")]
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	[Address(RVA = "0x256BD10", Offset = "0x256B110", Length = "0x64")]
	[Token(Token = "0x6000D26")]
	protected override void ProcessUnknownAttribute(object target) { }

	[Address(RVA = "0x256BD10", Offset = "0x256B110", Length = "0x64")]
	[Token(Token = "0x6000D27")]
	protected override void ProcessUnknownElement(object target) { }

	[Address(RVA = "0x256BD80", Offset = "0x256B180", Length = "0x517")]
	[Token(Token = "0x6000D22")]
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	[Address(RVA = "0x256C350", Offset = "0x256B750", Length = "0x2EC")]
	[Token(Token = "0x6000D20")]
	protected override object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	[Address(RVA = "0x256C2A0", Offset = "0x256B6A0", Length = "0xAA")]
	[Token(Token = "0x6000D21")]
	protected override void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	[Address(RVA = "0x256C640", Offset = "0x256BA40", Length = "0x160")]
	[Token(Token = "0x6000D1C")]
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	[Address(RVA = "0x256C7B0", Offset = "0x256BBB0", Length = "0x79")]
	[Token(Token = "0x6000D3B")]
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	[Address(RVA = "0x256C830", Offset = "0x256BC30", Length = "0x511")]
	[Token(Token = "0x6000D2F")]
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	[Address(RVA = "0x256CD50", Offset = "0x256C150", Length = "0x26B")]
	[Token(Token = "0x6000D30")]
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	[Address(RVA = "0x256CFC0", Offset = "0x256C3C0", Length = "0x25C9")]
	[Token(Token = "0x6000D23")]
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	[Address(RVA = "0x256F590", Offset = "0x256E990", Length = "0x55A")]
	[Token(Token = "0x6000D1D")]
	protected override object ReadMessage(XmlMembersMapping typeMap) { }

	[Address(RVA = "0x256FDE0", Offset = "0x256F1E0", Length = "0x40")]
	[Token(Token = "0x6000D1F")]
	protected override object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	[Address(RVA = "0x256FAF0", Offset = "0x256EEF0", Length = "0x2CC")]
	[Token(Token = "0x6000D2C")]
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	[Address(RVA = "0x2570020", Offset = "0x256F420", Length = "0xC0")]
	[Token(Token = "0x6000D3A")]
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	[Address(RVA = "0x25700F0", Offset = "0x256F4F0", Length = "0x175")]
	[Token(Token = "0x6000D2D")]
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	[Address(RVA = "0x2570380", Offset = "0x256F780", Length = "0x2A7")]
	[Token(Token = "0x6000D1B")]
	public object ReadRoot() { }

	[Address(RVA = "0x2570270", Offset = "0x256F670", Length = "0x10C")]
	[Token(Token = "0x6000D1E")]
	private object ReadRoot(XmlTypeMapping rootMap) { }

	[Address(RVA = "0x2570660", Offset = "0x256FA60", Length = "0x1AF")]
	[Token(Token = "0x6000D39")]
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	[Address(RVA = "0x2570630", Offset = "0x256FA30", Length = "0x21")]
	[Token(Token = "0x6000D38")]
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	[Address(RVA = "0x2570810", Offset = "0x256FC10", Length = "0x1F6")]
	[Token(Token = "0x6000D3D")]
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	[Address(RVA = "0x2570A10", Offset = "0x256FE10", Length = "0x1A3")]
	[Token(Token = "0x6000D24")]
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	[Address(RVA = "0x2570CA0", Offset = "0x25700A0", Length = "0x1BE")]
	[Token(Token = "0x6000D29")]
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	[Address(RVA = "0x2570BC0", Offset = "0x256FFC0", Length = "0xD5")]
	[Token(Token = "0x6000D2A")]
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

}

