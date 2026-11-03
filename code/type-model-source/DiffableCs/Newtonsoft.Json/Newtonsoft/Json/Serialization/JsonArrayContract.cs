namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x2000112")]
public class JsonArrayContract : JsonContainerContract
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400050F")]
	private readonly Type <CollectionItemType>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000510")]
	private readonly bool <IsMultidimensionalArray>k__BackingField; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000511")]
	private readonly Type _genericCollectionDefinitionType; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000512")]
	private Type _genericWrapperType; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000513")]
	private ObjectConstructor<Object> _genericWrapperCreator; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000514")]
	private Func<Object> _genericTemporaryCollectionCreator; //Field offset: 0xE8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000515")]
	private readonly bool <IsArray>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF1")]
	[Token(Token = "0x4000516")]
	private readonly bool <ShouldCreateWrapper>k__BackingField; //Field offset: 0xF1
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF2")]
	[Token(Token = "0x4000517")]
	private bool <CanDeserialize>k__BackingField; //Field offset: 0xF2
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000518")]
	private readonly ConstructorInfo _parameterizedConstructor; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000519")]
	private ObjectConstructor<Object> _parameterizedCreator; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400051A")]
	private ObjectConstructor<Object> _overrideCreator; //Field offset: 0x108
	[CompilerGenerated]
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400051B")]
	private bool <HasParameterizedCreator>k__BackingField; //Field offset: 0x110

	[Token(Token = "0x170000FD")]
	internal bool CanDeserialize
	{
		[Address(RVA = "0x213FE80", Offset = "0x213F280", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007D0")]
		internal get { } //Length: 8
		[Address(RVA = "0x2140010", Offset = "0x213F410", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60007D1")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170000F9")]
	public Type CollectionItemType
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007CC")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000100")]
	public bool HasParameterizedCreator
	{
		[Address(RVA = "0x213FF00", Offset = "0x213F300", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007D5")]
		 get { } //Length: 8
		[Address(RVA = "0x2140020", Offset = "0x213F420", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60007D6")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000101")]
	internal bool HasParameterizedCreatorInternal
	{
		[Address(RVA = "0x213FE90", Offset = "0x213F290", Length = "0x6E")]
		[Token(Token = "0x60007D7")]
		internal get { } //Length: 110
	}

	[Token(Token = "0x170000FB")]
	internal bool IsArray
	{
		[Address(RVA = "0x213FF10", Offset = "0x213F310", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007CE")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000FA")]
	public bool IsMultidimensionalArray
	{
		[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007CD")]
		 get { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x170000FF")]
	public ObjectConstructor<Object> OverrideCreator
	{
		[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
		[Token(Token = "0x60007D3")]
		 get { } //Length: 8
		[Address(RVA = "0x2140030", Offset = "0x213F430", Length = "0x29")]
		[Token(Token = "0x60007D4")]
		 set { } //Length: 41
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x170000FE")]
	internal ObjectConstructor<Object> ParameterizedCreator
	{
		[Address(RVA = "0x213FF20", Offset = "0x213F320", Length = "0xDD")]
		[Token(Token = "0x60007D2")]
		internal get { } //Length: 221
	}

	[Token(Token = "0x170000FC")]
	internal bool ShouldCreateWrapper
	{
		[Address(RVA = "0x2140000", Offset = "0x213F400", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007CF")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x213EA20", Offset = "0x213DE20", Length = "0x1456")]
	[NullableContext(1)]
	[Token(Token = "0x60007D8")]
	public JsonArrayContract(Type underlyingType) { }

	[Address(RVA = "0x213E180", Offset = "0x213D580", Length = "0x261")]
	[NullableContext(1)]
	[Token(Token = "0x60007DA")]
	internal IList CreateTemporaryCollection() { }

	[Address(RVA = "0x213E3F0", Offset = "0x213D7F0", Length = "0x484")]
	[NullableContext(1)]
	[Token(Token = "0x60007D9")]
	internal IWrappedCollection CreateWrapper(object list) { }

	[Address(RVA = "0x213FE80", Offset = "0x213F280", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007D0")]
	internal bool get_CanDeserialize() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007CC")]
	public Type get_CollectionItemType() { }

	[Address(RVA = "0x213FF00", Offset = "0x213F300", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007D5")]
	public bool get_HasParameterizedCreator() { }

	[Address(RVA = "0x213FE90", Offset = "0x213F290", Length = "0x6E")]
	[Token(Token = "0x60007D7")]
	internal bool get_HasParameterizedCreatorInternal() { }

	[Address(RVA = "0x213FF10", Offset = "0x213F310", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007CE")]
	internal bool get_IsArray() { }

	[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007CD")]
	public bool get_IsMultidimensionalArray() { }

	[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
	[Token(Token = "0x60007D3")]
	public ObjectConstructor<Object> get_OverrideCreator() { }

	[Address(RVA = "0x213FF20", Offset = "0x213F320", Length = "0xDD")]
	[Token(Token = "0x60007D2")]
	internal ObjectConstructor<Object> get_ParameterizedCreator() { }

	[Address(RVA = "0x2140000", Offset = "0x213F400", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007CF")]
	internal bool get_ShouldCreateWrapper() { }

	[Address(RVA = "0x2140010", Offset = "0x213F410", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60007D1")]
	private void set_CanDeserialize(bool value) { }

	[Address(RVA = "0x2140020", Offset = "0x213F420", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60007D6")]
	public void set_HasParameterizedCreator(bool value) { }

	[Address(RVA = "0x2140030", Offset = "0x213F430", Length = "0x29")]
	[Token(Token = "0x60007D4")]
	public void set_OverrideCreator(ObjectConstructor<Object> value) { }

	[Address(RVA = "0x213E880", Offset = "0x213DC80", Length = "0x19B")]
	[NullableContext(1)]
	[Token(Token = "0x60007DB")]
	private void StoreFSharpListCreatorIfNecessary(Type underlyingType) { }

}

