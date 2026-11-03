namespace System.Xml.Serialization;

[Token(Token = "0x200011A")]
public class XmlReflectionImporter
{
	[CompilerGenerated]
	[Token(Token = "0x200011B")]
	private sealed class <>c
	{
		[Token(Token = "0x400064B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400064C")]
		public static Comparison<XmlReflectionMember> <>9__28_0; //Field offset: 0x8

		[Address(RVA = "0x255E770", Offset = "0x255DB70", Length = "0x67")]
		[Token(Token = "0x6000CB6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CB7")]
		public <>c() { }

		[Address(RVA = "0x255E670", Offset = "0x255DA70", Length = "0xF6")]
		[Token(Token = "0x6000CB8")]
		internal int <ImportClassMapping>b__28_0(XmlReflectionMember m1, XmlReflectionMember m2) { }

	}

	[Token(Token = "0x4000649")]
	private static readonly string errSimple; //Field offset: 0x0
	[Token(Token = "0x400064A")]
	private static readonly string errSimple2; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000642")]
	private string initialDefaultNamespace; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000643")]
	private XmlAttributeOverrides attributeOverrides; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000644")]
	private ArrayList includedTypes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000645")]
	private ReflectionHelper helper; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000646")]
	private int arrayChoiceCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000647")]
	private ArrayList relatedMaps; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000648")]
	private bool allowPrivateTypes; //Field offset: 0x40

	[Address(RVA = "0x256A690", Offset = "0x2569A90", Length = "0xA5")]
	[Token(Token = "0x6000CB5")]
	private static XmlReflectionImporter() { }

	[Address(RVA = "0x256A740", Offset = "0x2569B40", Length = "0x167")]
	[Token(Token = "0x6000C9C")]
	public XmlReflectionImporter(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	[Address(RVA = "0x2563130", Offset = "0x2562530", Length = "0x3E")]
	[Token(Token = "0x6000CB2")]
	private bool CanBeNull(TypeData type) { }

	[Address(RVA = "0x2563170", Offset = "0x2562570", Length = "0xD62")]
	[Token(Token = "0x6000CAE")]
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	[Address(RVA = "0x2563EE0", Offset = "0x25632E0", Length = "0x479")]
	[Token(Token = "0x6000CA1")]
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	[Address(RVA = "0x2564360", Offset = "0x2563760", Length = "0x1B7")]
	[Token(Token = "0x6000CB4")]
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	[Address(RVA = "0x2564520", Offset = "0x2563920", Length = "0xCB0")]
	[Token(Token = "0x6000CAD")]
	private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

	[Address(RVA = "0x25651E0", Offset = "0x25645E0", Length = "0x137")]
	[Token(Token = "0x6000CA5")]
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	[Address(RVA = "0x2565320", Offset = "0x2564720", Length = "0x4FA")]
	[Token(Token = "0x6000CB0")]
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	[Address(RVA = "0x2565820", Offset = "0x2564C20", Length = "0x92")]
	[Token(Token = "0x6000CA2")]
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false) { }

	[Address(RVA = "0x25658C0", Offset = "0x2564CC0", Length = "0x1217")]
	[Token(Token = "0x6000CA3")]
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false) { }

	[Address(RVA = "0x2566AE0", Offset = "0x2565EE0", Length = "0xFCB")]
	[Token(Token = "0x6000CAF")]
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	[Address(RVA = "0x2567AB0", Offset = "0x2566EB0", Length = "0x6AD")]
	[Token(Token = "0x6000CAA")]
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	[Address(RVA = "0x2568160", Offset = "0x2567560", Length = "0x125")]
	[Token(Token = "0x6000CAC")]
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	[Address(RVA = "0x2568290", Offset = "0x2567690", Length = "0x8C")]
	[Token(Token = "0x6000CA6")]
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	[Address(RVA = "0x2568320", Offset = "0x2567720", Length = "0xD7E")]
	[Token(Token = "0x6000CA7")]
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	[Address(RVA = "0x25690A0", Offset = "0x25684A0", Length = "0x1C9")]
	[Token(Token = "0x6000CA9")]
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	[Address(RVA = "0x2569270", Offset = "0x2568670", Length = "0x375")]
	[Token(Token = "0x6000CB1")]
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	[Address(RVA = "0x2569A60", Offset = "0x2568E60", Length = "0x1D")]
	[Token(Token = "0x6000C9E")]
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	[Address(RVA = "0x2569A40", Offset = "0x2568E40", Length = "0x1D")]
	[Token(Token = "0x6000C9D")]
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	[Address(RVA = "0x25695F0", Offset = "0x25689F0", Length = "0x430")]
	[Token(Token = "0x6000CA0")]
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	[Address(RVA = "0x2569A80", Offset = "0x2568E80", Length = "0x1C8")]
	[Token(Token = "0x6000C9F")]
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	[Address(RVA = "0x2569C50", Offset = "0x2569050", Length = "0x2C4")]
	[Token(Token = "0x6000CA8")]
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	[Address(RVA = "0x2569F20", Offset = "0x2569320", Length = "0x211")]
	[Token(Token = "0x6000CAB")]
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	[Address(RVA = "0x256A140", Offset = "0x2569540", Length = "0x436")]
	[Token(Token = "0x6000CB3")]
	public void IncludeType(Type type) { }

	[Address(RVA = "0x256A580", Offset = "0x2569980", Length = "0x107")]
	[Token(Token = "0x6000CA4")]
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

}

