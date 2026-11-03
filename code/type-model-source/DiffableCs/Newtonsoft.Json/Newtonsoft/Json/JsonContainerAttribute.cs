namespace Newtonsoft.Json;

[AttributeUsage(1028, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x2000019")]
public abstract class JsonContainerAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002B")]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002C")]
	private string <Title>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002D")]
	private string <Description>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002E")]
	private Type <ItemConverterType>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400002F")]
	private Object[] <ItemConverterParameters>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000030")]
	private NamingStrategy <NamingStrategyInstance>k__BackingField; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000031")]
	internal Nullable<Boolean> _isReference; //Field offset: 0x40
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000032")]
	internal Nullable<Boolean> _itemIsReference; //Field offset: 0x42
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000033")]
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; //Field offset: 0x44
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000034")]
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; //Field offset: 0x4C
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000035")]
	private Type _namingStrategyType; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000036")]
	private Object[] _namingStrategyParameters; //Field offset: 0x60

	[Token(Token = "0x17000008")]
	public string Description
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000024")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000025")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000006")]
	public string Id
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000020")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000021")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000E")]
	public bool IsReference
	{
		[Address(RVA = "0x20C8010", Offset = "0x20C7410", Length = "0x39")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 57
		[Address(RVA = "0x20C8110", Offset = "0x20C7510", Length = "0x5B")]
		[Token(Token = "0x6000031")]
		 set { } //Length: 91
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x1700000A")]
	public Object[] ItemConverterParameters
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000028")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000029")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000009")]
	public Type ItemConverterType
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000026")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000027")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000F")]
	public bool ItemIsReference
	{
		[Address(RVA = "0x20C8050", Offset = "0x20C7450", Length = "0x39")]
		[Token(Token = "0x6000032")]
		 get { } //Length: 57
		[Address(RVA = "0x20C8170", Offset = "0x20C7570", Length = "0x5B")]
		[Token(Token = "0x6000033")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000010")]
	public ReferenceLoopHandling ItemReferenceLoopHandling
	{
		[Address(RVA = "0x20C8090", Offset = "0x20C7490", Length = "0x37")]
		[Token(Token = "0x6000034")]
		 get { } //Length: 55
		[Address(RVA = "0x20C81D0", Offset = "0x20C75D0", Length = "0x5B")]
		[Token(Token = "0x6000035")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000011")]
	public TypeNameHandling ItemTypeNameHandling
	{
		[Address(RVA = "0x20C80D0", Offset = "0x20C74D0", Length = "0x37")]
		[Token(Token = "0x6000036")]
		 get { } //Length: 55
		[Address(RVA = "0x20C8230", Offset = "0x20C7630", Length = "0x5B")]
		[Token(Token = "0x6000037")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700000D")]
	internal NamingStrategy NamingStrategyInstance
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600002E")]
		internal get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600002F")]
		internal set { } //Length: 13
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x1700000C")]
	public Object[] NamingStrategyParameters
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x600002C")]
		 get { } //Length: 5
		[Address(RVA = "0x20C8290", Offset = "0x20C7690", Length = "0x2E")]
		[Token(Token = "0x600002D")]
		 set { } //Length: 46
	}

	[Token(Token = "0x1700000B")]
	public Type NamingStrategyType
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600002A")]
		 get { } //Length: 5
		[Address(RVA = "0x20C82C0", Offset = "0x20C76C0", Length = "0x2E")]
		[Token(Token = "0x600002B")]
		 set { } //Length: 46
	}

	[Token(Token = "0x17000007")]
	public string Title
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000022")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000023")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[NullableContext(1)]
	[Token(Token = "0x6000039")]
	protected JsonContainerAttribute(string id) { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000038")]
	protected JsonContainerAttribute() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000024")]
	public string get_Description() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000020")]
	public string get_Id() { }

	[Address(RVA = "0x20C8010", Offset = "0x20C7410", Length = "0x39")]
	[Token(Token = "0x6000030")]
	public bool get_IsReference() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000028")]
	public Object[] get_ItemConverterParameters() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000026")]
	public Type get_ItemConverterType() { }

	[Address(RVA = "0x20C8050", Offset = "0x20C7450", Length = "0x39")]
	[Token(Token = "0x6000032")]
	public bool get_ItemIsReference() { }

	[Address(RVA = "0x20C8090", Offset = "0x20C7490", Length = "0x37")]
	[Token(Token = "0x6000034")]
	public ReferenceLoopHandling get_ItemReferenceLoopHandling() { }

	[Address(RVA = "0x20C80D0", Offset = "0x20C74D0", Length = "0x37")]
	[Token(Token = "0x6000036")]
	public TypeNameHandling get_ItemTypeNameHandling() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600002E")]
	internal NamingStrategy get_NamingStrategyInstance() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x600002C")]
	public Object[] get_NamingStrategyParameters() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600002A")]
	public Type get_NamingStrategyType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000022")]
	public string get_Title() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000025")]
	public void set_Description(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000021")]
	public void set_Id(string value) { }

	[Address(RVA = "0x20C8110", Offset = "0x20C7510", Length = "0x5B")]
	[Token(Token = "0x6000031")]
	public void set_IsReference(bool value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000029")]
	public void set_ItemConverterParameters(Object[] value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000027")]
	public void set_ItemConverterType(Type value) { }

	[Address(RVA = "0x20C8170", Offset = "0x20C7570", Length = "0x5B")]
	[Token(Token = "0x6000033")]
	public void set_ItemIsReference(bool value) { }

	[Address(RVA = "0x20C81D0", Offset = "0x20C75D0", Length = "0x5B")]
	[Token(Token = "0x6000035")]
	public void set_ItemReferenceLoopHandling(ReferenceLoopHandling value) { }

	[Address(RVA = "0x20C8230", Offset = "0x20C7630", Length = "0x5B")]
	[Token(Token = "0x6000037")]
	public void set_ItemTypeNameHandling(TypeNameHandling value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600002F")]
	internal void set_NamingStrategyInstance(NamingStrategy value) { }

	[Address(RVA = "0x20C8290", Offset = "0x20C7690", Length = "0x2E")]
	[Token(Token = "0x600002D")]
	public void set_NamingStrategyParameters(Object[] value) { }

	[Address(RVA = "0x20C82C0", Offset = "0x20C76C0", Length = "0x2E")]
	[Token(Token = "0x600002B")]
	public void set_NamingStrategyType(Type value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000023")]
	public void set_Title(string value) { }

}

