namespace System.Xml.Serialization;

[Token(Token = "0x2000136")]
internal class XmlTypeMapElementInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006AF")]
	private string _elementName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006B0")]
	private string _namespace; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006B1")]
	private XmlSchemaForm _form; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006B2")]
	private XmlTypeMapMember _member; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006B3")]
	private object _choiceValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006B4")]
	private bool _isNullable; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40006B5")]
	private int _nestingLevel; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006B6")]
	private XmlTypeMapping _mappedType; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006B7")]
	private TypeData _type; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40006B8")]
	private bool _wrappedElement; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40006B9")]
	private int _explicitOrder; //Field offset: 0x54

	[Token(Token = "0x1700036D")]
	public object ChoiceValue
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000DBA")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000DBB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000371")]
	public string DataTypeName
	{
		[Address(RVA = "0x2591F20", Offset = "0x2591320", Length = "0x2F")]
		[Token(Token = "0x6000DC1")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000370")]
	public string DataTypeNamespace
	{
		[Address(RVA = "0x2591F50", Offset = "0x2591350", Length = "0x5D")]
		[Token(Token = "0x6000DC0")]
		 get { } //Length: 93
	}

	[Token(Token = "0x1700036E")]
	public string ElementName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000DBC")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000DBD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700037B")]
	public int ExplicitOrder
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x6000DD1")]
		 get { } //Length: 4
		[Address(RVA = "0x2592030", Offset = "0x2591430", Length = "0x4")]
		[Token(Token = "0x6000DD2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000372")]
	public XmlSchemaForm Form
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000DC2")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000DC3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000374")]
	public bool IsNullable
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x6000DC6")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[Token(Token = "0x6000DC7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000379")]
	public bool IsTextElement
	{
		[Address(RVA = "0x2591FB0", Offset = "0x25913B0", Length = "0x3D")]
		[Token(Token = "0x6000DCD")]
		 get { } //Length: 61
		[Address(RVA = "0x2592040", Offset = "0x2591440", Length = "0xB5")]
		[Token(Token = "0x6000DCE")]
		 set { } //Length: 181
	}

	[Token(Token = "0x1700037A")]
	public bool IsUnnamedAnyElement
	{
		[Address(RVA = "0x2591FF0", Offset = "0x25913F0", Length = "0x1D")]
		[Token(Token = "0x6000DCF")]
		 get { } //Length: 29
		[Address(RVA = "0x2592100", Offset = "0x2591500", Length = "0x96")]
		[Token(Token = "0x6000DD0")]
		 set { } //Length: 150
	}

	[Token(Token = "0x17000373")]
	public XmlTypeMapping MappedType
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000DC4")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6000DC5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000375")]
	public XmlTypeMapMember Member
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000DC8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000377")]
	public bool MultiReferenceType
	{
		[Address(RVA = "0x2592010", Offset = "0x2591410", Length = "0x13")]
		[Token(Token = "0x6000DCA")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700036F")]
	public string Namespace
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000DBE")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000DBF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000376")]
	public int NestingLevel
	{
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[Token(Token = "0x6000DC9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700036C")]
	public TypeData TypeData
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000DB9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000378")]
	public bool WrappedElement
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[Token(Token = "0x6000DCB")]
		 get { } //Length: 5
		[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
		[Token(Token = "0x6000DCC")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2591E60", Offset = "0x2591260", Length = "0xBE")]
	[Token(Token = "0x6000DB8")]
	public XmlTypeMapElementInfo(XmlTypeMapMember member, TypeData type) { }

	[Address(RVA = "0x2591D20", Offset = "0x2591120", Length = "0x135")]
	[Token(Token = "0x6000DD3")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000DBA")]
	public object get_ChoiceValue() { }

	[Address(RVA = "0x2591F20", Offset = "0x2591320", Length = "0x2F")]
	[Token(Token = "0x6000DC1")]
	public string get_DataTypeName() { }

	[Address(RVA = "0x2591F50", Offset = "0x2591350", Length = "0x5D")]
	[Token(Token = "0x6000DC0")]
	public string get_DataTypeNamespace() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000DBC")]
	public string get_ElementName() { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[Token(Token = "0x6000DD1")]
	public int get_ExplicitOrder() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000DC2")]
	public XmlSchemaForm get_Form() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x6000DC6")]
	public bool get_IsNullable() { }

	[Address(RVA = "0x2591FB0", Offset = "0x25913B0", Length = "0x3D")]
	[Token(Token = "0x6000DCD")]
	public bool get_IsTextElement() { }

	[Address(RVA = "0x2591FF0", Offset = "0x25913F0", Length = "0x1D")]
	[Token(Token = "0x6000DCF")]
	public bool get_IsUnnamedAnyElement() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000DC4")]
	public XmlTypeMapping get_MappedType() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000DC8")]
	public XmlTypeMapMember get_Member() { }

	[Address(RVA = "0x2592010", Offset = "0x2591410", Length = "0x13")]
	[Token(Token = "0x6000DCA")]
	public bool get_MultiReferenceType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000DBE")]
	public string get_Namespace() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000DB9")]
	public TypeData get_TypeData() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[Token(Token = "0x6000DCB")]
	public bool get_WrappedElement() { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x6000DD4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000DBB")]
	public void set_ChoiceValue(object value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000DBD")]
	public void set_ElementName(string value) { }

	[Address(RVA = "0x2592030", Offset = "0x2591430", Length = "0x4")]
	[Token(Token = "0x6000DD2")]
	public void set_ExplicitOrder(int value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000DC3")]
	public void set_Form(XmlSchemaForm value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[Token(Token = "0x6000DC7")]
	public void set_IsNullable(bool value) { }

	[Address(RVA = "0x2592040", Offset = "0x2591440", Length = "0xB5")]
	[Token(Token = "0x6000DCE")]
	public void set_IsTextElement(bool value) { }

	[Address(RVA = "0x2592100", Offset = "0x2591500", Length = "0x96")]
	[Token(Token = "0x6000DD0")]
	public void set_IsUnnamedAnyElement(bool value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6000DC5")]
	public void set_MappedType(XmlTypeMapping value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000DBF")]
	public void set_Namespace(string value) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[Token(Token = "0x6000DC9")]
	public void set_NestingLevel(int value) { }

	[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
	[Token(Token = "0x6000DCC")]
	public void set_WrappedElement(bool value) { }

}

