namespace System.Xml.Serialization;

[Token(Token = "0x2000101")]
internal class TypeData
{
	[Token(Token = "0x4000600")]
	private static String[] keywords; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F4")]
	private Type type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005F5")]
	private string elementName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005F6")]
	private SchemaTypes sType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005F7")]
	private Type listItemType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005F8")]
	private string typeName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005F9")]
	private string fullTypeName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005FA")]
	private TypeData listItemTypeData; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005FB")]
	private TypeData mappedType; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005FC")]
	private XmlSchemaPatternFacet facet; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005FD")]
	private MethodInfo typeConvertor; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005FE")]
	private bool hasPublicConstructor; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x40005FF")]
	private bool nullableOverride; //Field offset: 0x61

	[Token(Token = "0x17000306")]
	public string FullTypeName
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000C14")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700030F")]
	public bool HasPublicConstructor
	{
		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[Token(Token = "0x6000C1E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000309")]
	public bool IsComplexType
	{
		[Address(RVA = "0x2545230", Offset = "0x2544630", Length = "0x2A")]
		[Token(Token = "0x6000C17")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000308")]
	public bool IsListType
	{
		[Address(RVA = "0x1DFC610", Offset = "0x1DFBA10", Length = "0x8")]
		[Token(Token = "0x6000C16")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700030B")]
	public bool IsNullable
	{
		[Address(RVA = "0x2545260", Offset = "0x2544660", Length = "0x15B")]
		[Token(Token = "0x6000C19")]
		 get { } //Length: 347
		[Address(RVA = "0x1FE3A30", Offset = "0x1FE2E30", Length = "0x4")]
		[Token(Token = "0x6000C1A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700030A")]
	public bool IsValueType
	{
		[Address(RVA = "0x25453C0", Offset = "0x25447C0", Length = "0x7B")]
		[Token(Token = "0x6000C18")]
		 get { } //Length: 123
	}

	[Token(Token = "0x1700030E")]
	public bool IsXsdType
	{
		[Address(RVA = "0x2545440", Offset = "0x2544840", Length = "0x9")]
		[Token(Token = "0x6000C1D")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700030D")]
	public Type ListItemType
	{
		[Address(RVA = "0x2545540", Offset = "0x2544940", Length = "0x932")]
		[Token(Token = "0x6000C1C")]
		 get { } //Length: 2354
	}

	[Token(Token = "0x1700030C")]
	public TypeData ListItemTypeData
	{
		[Address(RVA = "0x2545450", Offset = "0x2544850", Length = "0xEB")]
		[Token(Token = "0x6000C1B")]
		 get { } //Length: 235
	}

	[Token(Token = "0x17000307")]
	public SchemaTypes SchemaType
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000C15")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000305")]
	public Type Type
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C13")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000303")]
	public string TypeName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000C11")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000304")]
	public string XmlType
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000C12")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2543D80", Offset = "0x2543180", Length = "0xF36")]
	[Token(Token = "0x6000C22")]
	private static TypeData() { }

	[Address(RVA = "0x2545210", Offset = "0x2544610", Length = "0x1F")]
	[Token(Token = "0x6000C0D")]
	public TypeData(Type type, string elementName, bool isPrimitive) { }

	[Address(RVA = "0x2544CC0", Offset = "0x25440C0", Length = "0x546")]
	[Token(Token = "0x6000C0E")]
	public TypeData(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	[Address(RVA = "0x25437C0", Offset = "0x2542BC0", Length = "0xEE")]
	[Token(Token = "0x6000C10")]
	internal void ConvertForAssignment(ref object value) { }

	[Address(RVA = "0x25438B0", Offset = "0x2542CB0", Length = "0x10F")]
	[Token(Token = "0x6000C20")]
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000C14")]
	public string get_FullTypeName() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[Token(Token = "0x6000C1E")]
	public bool get_HasPublicConstructor() { }

	[Address(RVA = "0x2545230", Offset = "0x2544630", Length = "0x2A")]
	[Token(Token = "0x6000C17")]
	public bool get_IsComplexType() { }

	[Address(RVA = "0x1DFC610", Offset = "0x1DFBA10", Length = "0x8")]
	[Token(Token = "0x6000C16")]
	public bool get_IsListType() { }

	[Address(RVA = "0x2545260", Offset = "0x2544660", Length = "0x15B")]
	[Token(Token = "0x6000C19")]
	public bool get_IsNullable() { }

	[Address(RVA = "0x25453C0", Offset = "0x25447C0", Length = "0x7B")]
	[Token(Token = "0x6000C18")]
	public bool get_IsValueType() { }

	[Address(RVA = "0x2545440", Offset = "0x2544840", Length = "0x9")]
	[Token(Token = "0x6000C1D")]
	public bool get_IsXsdType() { }

	[Address(RVA = "0x2545540", Offset = "0x2544940", Length = "0x932")]
	[Token(Token = "0x6000C1C")]
	public Type get_ListItemType() { }

	[Address(RVA = "0x2545450", Offset = "0x2544850", Length = "0xEB")]
	[Token(Token = "0x6000C1B")]
	public TypeData get_ListItemTypeData() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000C15")]
	public SchemaTypes get_SchemaType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C13")]
	public Type get_Type() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000C11")]
	public string get_TypeName() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000C12")]
	public string get_XmlType() { }

	[Address(RVA = "0x25439C0", Offset = "0x2542DC0", Length = "0x1E9")]
	[Token(Token = "0x6000C21")]
	internal static Type GetGenericListItemType(Type type) { }

	[Address(RVA = "0x2543BB0", Offset = "0x2542FB0", Length = "0x11F")]
	[Token(Token = "0x6000C1F")]
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	[Address(RVA = "0x2543CD0", Offset = "0x25430D0", Length = "0xA7")]
	[Token(Token = "0x6000C0F")]
	private void LookupTypeConvertor() { }

	[Address(RVA = "0x1FE3A30", Offset = "0x1FE2E30", Length = "0x4")]
	[Token(Token = "0x6000C1A")]
	public void set_IsNullable(bool value) { }

}

