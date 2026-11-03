namespace Newtonsoft.Json;

[AttributeUsage(2432, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x2000027")]
public sealed class JsonPropertyAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000051")]
	internal Nullable<NullValueHandling> _nullValueHandling; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000052")]
	internal Nullable<DefaultValueHandling> _defaultValueHandling; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000053")]
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000054")]
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000055")]
	internal Nullable<TypeNameHandling> _typeNameHandling; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000056")]
	internal Nullable<Boolean> _isReference; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000057")]
	internal Nullable<Int32> _order; //Field offset: 0x3C
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000058")]
	internal Nullable<Required> _required; //Field offset: 0x44
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000059")]
	internal Nullable<Boolean> _itemIsReference; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400005A")]
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400005B")]
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400005C")]
	private Type <ItemConverterType>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400005D")]
	private Object[] <ItemConverterParameters>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400005E")]
	private Type <NamingStrategyType>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400005F")]
	private Object[] <NamingStrategyParameters>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000060")]
	private string <PropertyName>k__BackingField; //Field offset: 0x80

	[Token(Token = "0x17000022")]
	public DefaultValueHandling DefaultValueHandling
	{
		[Address(RVA = "0x20CDE10", Offset = "0x20CD210", Length = "0x37")]
		[Token(Token = "0x60000BE")]
		 get { } //Length: 55
		[Address(RVA = "0x20CE0D0", Offset = "0x20CD4D0", Length = "0x5B")]
		[Token(Token = "0x60000BF")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000026")]
	public bool IsReference
	{
		[Address(RVA = "0x20CDE50", Offset = "0x20CD250", Length = "0x39")]
		[Token(Token = "0x60000C6")]
		 get { } //Length: 57
		[Address(RVA = "0x20CE130", Offset = "0x20CD530", Length = "0x5B")]
		[Token(Token = "0x60000C7")]
		 set { } //Length: 91
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x1700001E")]
	public Object[] ItemConverterParameters
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000B6")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60000B7")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700001D")]
	public Type ItemConverterType
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000B4")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[CompilerGenerated]
		[Token(Token = "0x60000B5")]
		 set { } //Length: 995
	}

	[Token(Token = "0x1700002C")]
	public bool ItemIsReference
	{
		[Address(RVA = "0x20CDE90", Offset = "0x20CD290", Length = "0x39")]
		[Token(Token = "0x60000D2")]
		 get { } //Length: 57
		[Address(RVA = "0x20CE190", Offset = "0x20CD590", Length = "0x5B")]
		[Token(Token = "0x60000D3")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700002A")]
	public ReferenceLoopHandling ItemReferenceLoopHandling
	{
		[Address(RVA = "0x20CDED0", Offset = "0x20CD2D0", Length = "0x37")]
		[Token(Token = "0x60000CE")]
		 get { } //Length: 55
		[Address(RVA = "0x20CE1F0", Offset = "0x20CD5F0", Length = "0x5B")]
		[Token(Token = "0x60000CF")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700002B")]
	public TypeNameHandling ItemTypeNameHandling
	{
		[Address(RVA = "0x20CDF10", Offset = "0x20CD310", Length = "0x37")]
		[Token(Token = "0x60000D0")]
		 get { } //Length: 55
		[Address(RVA = "0x20CE250", Offset = "0x20CD650", Length = "0x5B")]
		[Token(Token = "0x60000D1")]
		 set { } //Length: 91
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x17000020")]
	public Object[] NamingStrategyParameters
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000BA")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60000BB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700001F")]
	public Type NamingStrategyType
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000B8")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60000B9")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000021")]
	public NullValueHandling NullValueHandling
	{
		[Address(RVA = "0x20CDF50", Offset = "0x20CD350", Length = "0x37")]
		[Token(Token = "0x60000BC")]
		 get { } //Length: 55
		[Address(RVA = "0x20CE2B0", Offset = "0x20CD6B0", Length = "0x5B")]
		[Token(Token = "0x60000BD")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000024")]
	public ObjectCreationHandling ObjectCreationHandling
	{
		[Address(RVA = "0x20CDF90", Offset = "0x20CD390", Length = "0x37")]
		[Token(Token = "0x60000C2")]
		 get { } //Length: 55
		[Address(RVA = "0x20CE310", Offset = "0x20CD710", Length = "0x5B")]
		[Token(Token = "0x60000C3")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000027")]
	public int Order
	{
		[Address(RVA = "0x20CDFD0", Offset = "0x20CD3D0", Length = "0x37")]
		[Token(Token = "0x60000C8")]
		 get { } //Length: 55
		[Address(RVA = "0x20CE370", Offset = "0x20CD770", Length = "0x5B")]
		[Token(Token = "0x60000C9")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000029")]
	public string PropertyName
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000CC")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x60000CD")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000023")]
	public ReferenceLoopHandling ReferenceLoopHandling
	{
		[Address(RVA = "0x20CE010", Offset = "0x20CD410", Length = "0x37")]
		[Token(Token = "0x60000C0")]
		 get { } //Length: 55
		[Address(RVA = "0x20CE3D0", Offset = "0x20CD7D0", Length = "0x5B")]
		[Token(Token = "0x60000C1")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000028")]
	public Required Required
	{
		[Address(RVA = "0x20CE050", Offset = "0x20CD450", Length = "0x37")]
		[Token(Token = "0x60000CA")]
		 get { } //Length: 55
		[Address(RVA = "0x20CE430", Offset = "0x20CD830", Length = "0x5B")]
		[Token(Token = "0x60000CB")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000025")]
	public TypeNameHandling TypeNameHandling
	{
		[Address(RVA = "0x20CE090", Offset = "0x20CD490", Length = "0x37")]
		[Token(Token = "0x60000C4")]
		 get { } //Length: 55
		[Address(RVA = "0x20CE490", Offset = "0x20CD890", Length = "0x5B")]
		[Token(Token = "0x60000C5")]
		 set { } //Length: 91
	}

	[Address(RVA = "0x20CDDD0", Offset = "0x20CD1D0", Length = "0x37")]
	[NullableContext(1)]
	[Token(Token = "0x60000D5")]
	public JsonPropertyAttribute(string propertyName) { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60000D4")]
	public JsonPropertyAttribute() { }

	[Address(RVA = "0x20CDE10", Offset = "0x20CD210", Length = "0x37")]
	[Token(Token = "0x60000BE")]
	public DefaultValueHandling get_DefaultValueHandling() { }

	[Address(RVA = "0x20CDE50", Offset = "0x20CD250", Length = "0x39")]
	[Token(Token = "0x60000C6")]
	public bool get_IsReference() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000B6")]
	public Object[] get_ItemConverterParameters() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000B4")]
	public Type get_ItemConverterType() { }

	[Address(RVA = "0x20CDE90", Offset = "0x20CD290", Length = "0x39")]
	[Token(Token = "0x60000D2")]
	public bool get_ItemIsReference() { }

	[Address(RVA = "0x20CDED0", Offset = "0x20CD2D0", Length = "0x37")]
	[Token(Token = "0x60000CE")]
	public ReferenceLoopHandling get_ItemReferenceLoopHandling() { }

	[Address(RVA = "0x20CDF10", Offset = "0x20CD310", Length = "0x37")]
	[Token(Token = "0x60000D0")]
	public TypeNameHandling get_ItemTypeNameHandling() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000BA")]
	public Object[] get_NamingStrategyParameters() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000B8")]
	public Type get_NamingStrategyType() { }

	[Address(RVA = "0x20CDF50", Offset = "0x20CD350", Length = "0x37")]
	[Token(Token = "0x60000BC")]
	public NullValueHandling get_NullValueHandling() { }

	[Address(RVA = "0x20CDF90", Offset = "0x20CD390", Length = "0x37")]
	[Token(Token = "0x60000C2")]
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	[Address(RVA = "0x20CDFD0", Offset = "0x20CD3D0", Length = "0x37")]
	[Token(Token = "0x60000C8")]
	public int get_Order() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000CC")]
	public string get_PropertyName() { }

	[Address(RVA = "0x20CE010", Offset = "0x20CD410", Length = "0x37")]
	[Token(Token = "0x60000C0")]
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	[Address(RVA = "0x20CE050", Offset = "0x20CD450", Length = "0x37")]
	[Token(Token = "0x60000CA")]
	public Required get_Required() { }

	[Address(RVA = "0x20CE090", Offset = "0x20CD490", Length = "0x37")]
	[Token(Token = "0x60000C4")]
	public TypeNameHandling get_TypeNameHandling() { }

	[Address(RVA = "0x20CE0D0", Offset = "0x20CD4D0", Length = "0x5B")]
	[Token(Token = "0x60000BF")]
	public void set_DefaultValueHandling(DefaultValueHandling value) { }

	[Address(RVA = "0x20CE130", Offset = "0x20CD530", Length = "0x5B")]
	[Token(Token = "0x60000C7")]
	public void set_IsReference(bool value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60000B7")]
	public void set_ItemConverterParameters(Object[] value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[CompilerGenerated]
	[Token(Token = "0x60000B5")]
	public void set_ItemConverterType(Type value) { }

	[Address(RVA = "0x20CE190", Offset = "0x20CD590", Length = "0x5B")]
	[Token(Token = "0x60000D3")]
	public void set_ItemIsReference(bool value) { }

	[Address(RVA = "0x20CE1F0", Offset = "0x20CD5F0", Length = "0x5B")]
	[Token(Token = "0x60000CF")]
	public void set_ItemReferenceLoopHandling(ReferenceLoopHandling value) { }

	[Address(RVA = "0x20CE250", Offset = "0x20CD650", Length = "0x5B")]
	[Token(Token = "0x60000D1")]
	public void set_ItemTypeNameHandling(TypeNameHandling value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60000BB")]
	public void set_NamingStrategyParameters(Object[] value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60000B9")]
	public void set_NamingStrategyType(Type value) { }

	[Address(RVA = "0x20CE2B0", Offset = "0x20CD6B0", Length = "0x5B")]
	[Token(Token = "0x60000BD")]
	public void set_NullValueHandling(NullValueHandling value) { }

	[Address(RVA = "0x20CE310", Offset = "0x20CD710", Length = "0x5B")]
	[Token(Token = "0x60000C3")]
	public void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	[Address(RVA = "0x20CE370", Offset = "0x20CD770", Length = "0x5B")]
	[Token(Token = "0x60000C9")]
	public void set_Order(int value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[CompilerGenerated]
	[Token(Token = "0x60000CD")]
	public void set_PropertyName(string value) { }

	[Address(RVA = "0x20CE3D0", Offset = "0x20CD7D0", Length = "0x5B")]
	[Token(Token = "0x60000C1")]
	public void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	[Address(RVA = "0x20CE430", Offset = "0x20CD830", Length = "0x5B")]
	[Token(Token = "0x60000CB")]
	public void set_Required(Required value) { }

	[Address(RVA = "0x20CE490", Offset = "0x20CD890", Length = "0x5B")]
	[Token(Token = "0x60000C5")]
	public void set_TypeNameHandling(TypeNameHandling value) { }

}

