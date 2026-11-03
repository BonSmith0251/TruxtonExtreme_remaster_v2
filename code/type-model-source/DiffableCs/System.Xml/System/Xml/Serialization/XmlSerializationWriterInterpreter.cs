namespace System.Xml.Serialization;

[Token(Token = "0x200012E")]
internal class XmlSerializationWriterInterpreter : XmlSerializationWriter
{
	[Token(Token = "0x200012F")]
	private class CallbackInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000696")]
		private XmlSerializationWriterInterpreter _swi; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000697")]
		private XmlTypeMapping _typeMap; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x6000D91")]
		public CallbackInfo(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

		[Address(RVA = "0x257EDD0", Offset = "0x257E1D0", Length = "0x5F")]
		[Token(Token = "0x6000D93")]
		internal void WriteEnum(object ob) { }

		[Address(RVA = "0x257EE30", Offset = "0x257E230", Length = "0x5F")]
		[Token(Token = "0x6000D92")]
		internal void WriteObject(object ob) { }

	}

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000694")]
	private XmlMapping _typeMap; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000695")]
	private SerializationFormat _format; //Field offset: 0x50

	[Address(RVA = "0x25906E0", Offset = "0x258FAE0", Length = "0x42")]
	[Token(Token = "0x6000D78")]
	public XmlSerializationWriterInterpreter(XmlMapping typeMap) { }

	[Address(RVA = "0x258C3E0", Offset = "0x258B7E0", Length = "0xAD")]
	[Token(Token = "0x6000D90")]
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }

	[Address(RVA = "0x258C490", Offset = "0x258B890", Length = "0x118")]
	[Token(Token = "0x6000D8B")]
	private int GetListCount(TypeData listType, object ob) { }

	[Address(RVA = "0x258C5B0", Offset = "0x258B9B0", Length = "0xCD")]
	[Token(Token = "0x6000D83")]
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	[Address(RVA = "0x258C680", Offset = "0x258BA80", Length = "0x2E4")]
	[Token(Token = "0x6000D8F")]
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	[Address(RVA = "0x258C970", Offset = "0x258BD70", Length = "0x372")]
	[Token(Token = "0x6000D86")]
	internal static object ImplicitConvert(object obj, Type type) { }

	[Address(RVA = "0x258CCF0", Offset = "0x258C0F0", Length = "0x31B")]
	[Token(Token = "0x6000D79")]
	protected virtual void InitCallbacks() { }

	[Address(RVA = "0x258D010", Offset = "0x258C410", Length = "0x23F")]
	[Token(Token = "0x6000D84")]
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	[Address(RVA = "0x258D250", Offset = "0x258C650", Length = "0x4CA")]
	[Token(Token = "0x6000D8C")]
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	[Address(RVA = "0x258D720", Offset = "0x258CB20", Length = "0x4E8")]
	[Token(Token = "0x6000D81")]
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	[Address(RVA = "0x258DC10", Offset = "0x258D010", Length = "0x58C")]
	[Token(Token = "0x6000D82")]
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	[Address(RVA = "0x258E1A0", Offset = "0x258D5A0", Length = "0xD5")]
	[Token(Token = "0x6000D8E")]
	protected override void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	[Address(RVA = "0x258E280", Offset = "0x258D680", Length = "0x705")]
	[Token(Token = "0x6000D8A")]
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	[Address(RVA = "0x258E990", Offset = "0x258DD90", Length = "0x30B")]
	[Token(Token = "0x6000D89")]
	protected override void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	[Address(RVA = "0x258ECA0", Offset = "0x258E0A0", Length = "0x59C")]
	[Token(Token = "0x6000D85")]
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	[Address(RVA = "0x258F260", Offset = "0x258E660", Length = "0x5E")]
	[Token(Token = "0x6000D80")]
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	[Address(RVA = "0x258F2C0", Offset = "0x258E6C0", Length = "0x1FA")]
	[Token(Token = "0x6000D7C")]
	protected override void WriteMessage(XmlMembersMapping membersMap, Object[] parameters) { }

	[Address(RVA = "0x258F770", Offset = "0x258EB70", Length = "0x7B1")]
	[Token(Token = "0x6000D7B")]
	protected override void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	[Address(RVA = "0x258F620", Offset = "0x258EA20", Length = "0x140")]
	[Token(Token = "0x6000D7D")]
	protected override void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	[Address(RVA = "0x258F4C0", Offset = "0x258E8C0", Length = "0xA5")]
	[Token(Token = "0x6000D7E")]
	protected override void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	[Address(RVA = "0x258F570", Offset = "0x258E970", Length = "0xA5")]
	[Token(Token = "0x6000D7F")]
	protected override void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	[Address(RVA = "0x258FF30", Offset = "0x258F330", Length = "0x4D")]
	[Token(Token = "0x6000D8D")]
	protected override void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	[Address(RVA = "0x258FF80", Offset = "0x258F380", Length = "0x278")]
	[Token(Token = "0x6000D88")]
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	[Address(RVA = "0x2590200", Offset = "0x258F600", Length = "0x24D")]
	[Token(Token = "0x6000D87")]
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	[Address(RVA = "0x2590450", Offset = "0x258F850", Length = "0x286")]
	[Token(Token = "0x6000D7A")]
	public void WriteRoot(object ob) { }

}

