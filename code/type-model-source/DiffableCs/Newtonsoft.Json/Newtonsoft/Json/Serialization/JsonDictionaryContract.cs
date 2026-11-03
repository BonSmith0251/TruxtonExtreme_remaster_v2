namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x200011C")]
public class JsonDictionaryContract : JsonContainerContract
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	[Token(Token = "0x4000543")]
	private Func<String, String> <DictionaryKeyResolver>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000544")]
	private readonly Type <DictionaryKeyType>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000545")]
	private readonly Type <DictionaryValueType>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000546")]
	private JsonContract <KeyContract>k__BackingField; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000547")]
	private readonly Type _genericCollectionDefinitionType; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000548")]
	private Type _genericWrapperType; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000549")]
	private ObjectConstructor<Object> _genericWrapperCreator; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400054A")]
	private Func<Object> _genericTemporaryDictionaryCreator; //Field offset: 0xF8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400054B")]
	private readonly bool <ShouldCreateWrapper>k__BackingField; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400054C")]
	private readonly ConstructorInfo _parameterizedConstructor; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400054D")]
	private ObjectConstructor<Object> _overrideCreator; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400054E")]
	private ObjectConstructor<Object> _parameterizedCreator; //Field offset: 0x118
	[CompilerGenerated]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400054F")]
	private bool <HasParameterizedCreator>k__BackingField; //Field offset: 0x120

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	[Token(Token = "0x17000114")]
	public Func<String, String> DictionaryKeyResolver
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000816")]
		 get { } //Length: 8
		[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000817")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000115")]
	public Type DictionaryKeyType
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000818")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000116")]
	public Type DictionaryValueType
	{
		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000819")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700011B")]
	public bool HasParameterizedCreator
	{
		[Address(RVA = "0x2142350", Offset = "0x2141750", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000820")]
		 get { } //Length: 8
		[Address(RVA = "0x2142450", Offset = "0x2141850", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000821")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700011C")]
	internal bool HasParameterizedCreatorInternal
	{
		[Address(RVA = "0x21422E0", Offset = "0x21416E0", Length = "0x6E")]
		[Token(Token = "0x6000822")]
		internal get { } //Length: 110
	}

	[Token(Token = "0x17000117")]
	internal JsonContract KeyContract
	{
		[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600081A")]
		internal get { } //Length: 8
		[Address(RVA = "0x20D5140", Offset = "0x20D4540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600081B")]
		internal set { } //Length: 19
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x1700011A")]
	public ObjectConstructor<Object> OverrideCreator
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[Token(Token = "0x600081E")]
		 get { } //Length: 8
		[Address(RVA = "0x1CC9D00", Offset = "0x1CC9100", Length = "0x13")]
		[Token(Token = "0x600081F")]
		 set { } //Length: 19
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x17000119")]
	internal ObjectConstructor<Object> ParameterizedCreator
	{
		[Address(RVA = "0x2142360", Offset = "0x2141760", Length = "0xDD")]
		[Token(Token = "0x600081D")]
		internal get { } //Length: 221
	}

	[Token(Token = "0x17000118")]
	internal bool ShouldCreateWrapper
	{
		[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600081C")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x2141660", Offset = "0x2140A60", Length = "0xC70")]
	[NullableContext(1)]
	[Token(Token = "0x6000823")]
	public JsonDictionaryContract(Type underlyingType) { }

	[Address(RVA = "0x2141060", Offset = "0x2140460", Length = "0x2AB")]
	[NullableContext(1)]
	[Token(Token = "0x6000825")]
	internal IDictionary CreateTemporaryDictionary() { }

	[Address(RVA = "0x2141310", Offset = "0x2140710", Length = "0x347")]
	[NullableContext(1)]
	[Token(Token = "0x6000824")]
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000816")]
	public Func<String, String> get_DictionaryKeyResolver() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000818")]
	public Type get_DictionaryKeyType() { }

	[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000819")]
	public Type get_DictionaryValueType() { }

	[Address(RVA = "0x2142350", Offset = "0x2141750", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000820")]
	public bool get_HasParameterizedCreator() { }

	[Address(RVA = "0x21422E0", Offset = "0x21416E0", Length = "0x6E")]
	[Token(Token = "0x6000822")]
	internal bool get_HasParameterizedCreatorInternal() { }

	[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600081A")]
	internal JsonContract get_KeyContract() { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[Token(Token = "0x600081E")]
	public ObjectConstructor<Object> get_OverrideCreator() { }

	[Address(RVA = "0x2142360", Offset = "0x2141760", Length = "0xDD")]
	[Token(Token = "0x600081D")]
	internal ObjectConstructor<Object> get_ParameterizedCreator() { }

	[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600081C")]
	internal bool get_ShouldCreateWrapper() { }

	[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000817")]
	public void set_DictionaryKeyResolver(Func<String, String> value) { }

	[Address(RVA = "0x2142450", Offset = "0x2141850", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000821")]
	public void set_HasParameterizedCreator(bool value) { }

	[Address(RVA = "0x20D5140", Offset = "0x20D4540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600081B")]
	internal void set_KeyContract(JsonContract value) { }

	[Address(RVA = "0x1CC9D00", Offset = "0x1CC9100", Length = "0x13")]
	[Token(Token = "0x600081F")]
	public void set_OverrideCreator(ObjectConstructor<Object> value) { }

}

