namespace System.Xml.Serialization;

[Token(Token = "0x2000143")]
internal class ClassMap : ObjectMap
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006DA")]
	private Hashtable _elements; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006DB")]
	private ArrayList _elementMembers; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006DC")]
	private Hashtable _attributeMembers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006DD")]
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006DE")]
	private ArrayList _flatLists; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006DF")]
	private ArrayList _allMembers; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006E0")]
	private ArrayList _membersWithDefault; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006E1")]
	private ArrayList _listMembers; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40006E2")]
	private XmlTypeMapMemberAnyElement _defaultAnyElement; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006E3")]
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006E4")]
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40006E5")]
	private XmlTypeMapMember _xmlTextCollector; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40006E6")]
	private XmlTypeMapMember _returnMember; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40006E7")]
	private bool _ignoreMemberNamespace; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x40006E8")]
	private bool _canBeSimpleType; //Field offset: 0x79
	[FieldOffset(Offset = "0x7A")]
	[Token(Token = "0x40006E9")]
	private Nullable<Boolean> _isOrderDependentMap; //Field offset: 0x7A

	[Token(Token = "0x1700039F")]
	public ArrayList AllMembers
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000E2E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700039D")]
	public ICollection AttributeMembers
	{
		[Address(RVA = "0x2580A90", Offset = "0x257FE90", Length = "0x30C")]
		[Token(Token = "0x6000E2C")]
		 get { } //Length: 780
	}

	[Token(Token = "0x1700039B")]
	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000E2A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700039A")]
	public XmlTypeMapMemberAnyElement DefaultAnyElementMember
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000E29")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700039E")]
	public ICollection ElementMembers
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000E2D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003A0")]
	public ArrayList FlatLists
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000E2F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003A5")]
	public bool HasSimpleContent
	{
		[Address(RVA = "0x2580DA0", Offset = "0x25801A0", Length = "0x59")]
		[Token(Token = "0x6000E35")]
		 get { } //Length: 89
	}

	[Token(Token = "0x17000399")]
	public bool IsOrderDependentMap
	{
		[Address(RVA = "0x2580E00", Offset = "0x2580200", Length = "0x26E")]
		[Token(Token = "0x6000E28")]
		 get { } //Length: 622
	}

	[Token(Token = "0x170003A1")]
	public ArrayList ListMembers
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000E30")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700039C")]
	public XmlTypeMapMemberNamespaces NamespaceDeclarations
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000E2B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003A3")]
	public XmlTypeMapMember ReturnMember
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6000E32")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003A4")]
	public XmlQualifiedName SimpleContentBaseType
	{
		[Address(RVA = "0x2581070", Offset = "0x2580470", Length = "0x214")]
		[Token(Token = "0x6000E33")]
		 get { } //Length: 532
	}

	[Token(Token = "0x170003A2")]
	public XmlTypeMapMember XmlTextCollector
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6000E31")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x25809F0", Offset = "0x257FDF0", Length = "0x9F")]
	[Token(Token = "0x6000E36")]
	public ClassMap() { }

	[Address(RVA = "0x257F5C0", Offset = "0x257E9C0", Length = "0xC74")]
	[Token(Token = "0x6000E22")]
	public void AddMember(XmlTypeMapMember member) { }

	[Address(RVA = "0x2580240", Offset = "0x257F640", Length = "0xCC")]
	[Token(Token = "0x6000E27")]
	private string BuildKey(string name, string ns, int explicitOrder) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000E2E")]
	public ArrayList get_AllMembers() { }

	[Address(RVA = "0x2580A90", Offset = "0x257FE90", Length = "0x30C")]
	[Token(Token = "0x6000E2C")]
	public ICollection get_AttributeMembers() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000E2A")]
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000E29")]
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000E2D")]
	public ICollection get_ElementMembers() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000E2F")]
	public ArrayList get_FlatLists() { }

	[Address(RVA = "0x2580DA0", Offset = "0x25801A0", Length = "0x59")]
	[Token(Token = "0x6000E35")]
	public bool get_HasSimpleContent() { }

	[Address(RVA = "0x2580E00", Offset = "0x2580200", Length = "0x26E")]
	[Token(Token = "0x6000E28")]
	public bool get_IsOrderDependentMap() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000E30")]
	public ArrayList get_ListMembers() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000E2B")]
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6000E32")]
	public XmlTypeMapMember get_ReturnMember() { }

	[Address(RVA = "0x2581070", Offset = "0x2580470", Length = "0x214")]
	[Token(Token = "0x6000E33")]
	public XmlQualifiedName get_SimpleContentBaseType() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6000E31")]
	public XmlTypeMapMember get_XmlTextCollector() { }

	[Address(RVA = "0x2580310", Offset = "0x257F710", Length = "0x150")]
	[Token(Token = "0x6000E24")]
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	[Address(RVA = "0x2580730", Offset = "0x257FB30", Length = "0x1FC")]
	[Token(Token = "0x6000E26")]
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	[Address(RVA = "0x2580470", Offset = "0x257F870", Length = "0x2BB")]
	[Token(Token = "0x6000E25")]
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	[Address(RVA = "0x2580930", Offset = "0x257FD30", Length = "0xB9")]
	[Token(Token = "0x6000E23")]
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	[Address(RVA = "0x2490EA0", Offset = "0x24902A0", Length = "0x4")]
	[Token(Token = "0x6000E34")]
	public void SetCanBeSimpleType(bool can) { }

}

