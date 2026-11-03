namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x2000121")]
public class JsonObjectContract : JsonContainerContract
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000558")]
	private MemberSerialization <MemberSerialization>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000559")]
	private Nullable<MissingMemberHandling> <MissingMemberHandling>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x400055A")]
	private Nullable<Required> <ItemRequired>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x400055B")]
	private Nullable<NullValueHandling> <ItemNullValueHandling>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	[FieldOffset(Offset = "0xE0")]
	[Nullable(1)]
	[Token(Token = "0x400055C")]
	private readonly JsonPropertyCollection <Properties>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400055D")]
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400055E")]
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF8")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	[Token(Token = "0x400055F")]
	private Func<String, String> <ExtensionDataNameResolver>k__BackingField; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000560")]
	internal bool ExtensionDataIsJToken; //Field offset: 0x100
	[FieldOffset(Offset = "0x101")]
	[Token(Token = "0x4000561")]
	private Nullable<Boolean> _hasRequiredOrDefaultValueProperties; //Field offset: 0x101
	[FieldOffset(Offset = "0x108")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000562")]
	private ObjectConstructor<Object> _overrideCreator; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000563")]
	private ObjectConstructor<Object> _parameterizedCreator; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000564")]
	private JsonPropertyCollection _creatorParameters; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000565")]
	private Type _extensionDataValueType; //Field offset: 0x120

	[Nullable(1)]
	[Token(Token = "0x17000125")]
	public JsonPropertyCollection CreatorParameters
	{
		[Address(RVA = "0x2143550", Offset = "0x2142950", Length = "0x87")]
		[NullableContext(1)]
		[Token(Token = "0x600084E")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000129")]
	public ExtensionDataGetter ExtensionDataGetter
	{
		[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000855")]
		 get { } //Length: 8
		[Address(RVA = "0xE26C30", Offset = "0xE26030", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000856")]
		 set { } //Length: 19
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	[Token(Token = "0x1700012B")]
	public Func<String, String> ExtensionDataNameResolver
	{
		[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000859")]
		 get { } //Length: 8
		[Address(RVA = "0x1D413A0", Offset = "0x1D407A0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600085A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000128")]
	public ExtensionDataSetter ExtensionDataSetter
	{
		[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000853")]
		 get { } //Length: 8
		[Address(RVA = "0x20D5300", Offset = "0x20D4700", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000854")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700012A")]
	public Type ExtensionDataValueType
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[Token(Token = "0x6000857")]
		 get { } //Length: 8
		[Address(RVA = "0x21438F0", Offset = "0x2142CF0", Length = "0xD9")]
		[Token(Token = "0x6000858")]
		 set { } //Length: 217
	}

	[Token(Token = "0x1700012C")]
	internal bool HasRequiredOrDefaultValueProperties
	{
		[Address(RVA = "0x21435E0", Offset = "0x21429E0", Length = "0x2DF")]
		[Token(Token = "0x600085B")]
		internal get { } //Length: 735
	}

	[Token(Token = "0x17000123")]
	public Nullable<NullValueHandling> ItemNullValueHandling
	{
		[Address(RVA = "0x21438C0", Offset = "0x2142CC0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600084B")]
		 get { } //Length: 8
		[Address(RVA = "0x21439D0", Offset = "0x2142DD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600084C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000122")]
	public Nullable<Required> ItemRequired
	{
		[Address(RVA = "0x21438D0", Offset = "0x2142CD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000849")]
		 get { } //Length: 8
		[Address(RVA = "0x21439E0", Offset = "0x2142DE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600084A")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000120")]
	public MemberSerialization MemberSerialization
	{
		[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000845")]
		 get { } //Length: 7
		[Address(RVA = "0x21439F0", Offset = "0x2142DF0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000846")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000121")]
	public Nullable<MissingMemberHandling> MissingMemberHandling
	{
		[Address(RVA = "0x21438E0", Offset = "0x2142CE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000847")]
		 get { } //Length: 8
		[Address(RVA = "0x2143A00", Offset = "0x2142E00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000848")]
		 set { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x17000126")]
	public ObjectConstructor<Object> OverrideCreator
	{
		[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
		[Token(Token = "0x600084F")]
		 get { } //Length: 8
		[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
		[Token(Token = "0x6000850")]
		 set { } //Length: 19
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x17000127")]
	internal ObjectConstructor<Object> ParameterizedCreator
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[Token(Token = "0x6000851")]
		internal get { } //Length: 8
		[Address(RVA = "0x1CC9D00", Offset = "0x1CC9100", Length = "0x13")]
		[Token(Token = "0x6000852")]
		internal set { } //Length: 19
	}

	[Nullable(1)]
	[Token(Token = "0x17000124")]
	public JsonPropertyCollection Properties
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[CompilerGenerated]
		[NullableContext(1)]
		[Token(Token = "0x600084D")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x21434C0", Offset = "0x21428C0", Length = "0x8C")]
	[NullableContext(1)]
	[Token(Token = "0x600085C")]
	public JsonObjectContract(Type underlyingType) { }

	[Address(RVA = "0x2143550", Offset = "0x2142950", Length = "0x87")]
	[NullableContext(1)]
	[Token(Token = "0x600084E")]
	public JsonPropertyCollection get_CreatorParameters() { }

	[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000855")]
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000859")]
	public Func<String, String> get_ExtensionDataNameResolver() { }

	[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000853")]
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[Token(Token = "0x6000857")]
	public Type get_ExtensionDataValueType() { }

	[Address(RVA = "0x21435E0", Offset = "0x21429E0", Length = "0x2DF")]
	[Token(Token = "0x600085B")]
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	[Address(RVA = "0x21438C0", Offset = "0x2142CC0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600084B")]
	public Nullable<NullValueHandling> get_ItemNullValueHandling() { }

	[Address(RVA = "0x21438D0", Offset = "0x2142CD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000849")]
	public Nullable<Required> get_ItemRequired() { }

	[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000845")]
	public MemberSerialization get_MemberSerialization() { }

	[Address(RVA = "0x21438E0", Offset = "0x2142CE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000847")]
	public Nullable<MissingMemberHandling> get_MissingMemberHandling() { }

	[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
	[Token(Token = "0x600084F")]
	public ObjectConstructor<Object> get_OverrideCreator() { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[Token(Token = "0x6000851")]
	internal ObjectConstructor<Object> get_ParameterizedCreator() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[CompilerGenerated]
	[NullableContext(1)]
	[Token(Token = "0x600084D")]
	public JsonPropertyCollection get_Properties() { }

	[Address(RVA = "0x21433B0", Offset = "0x21427B0", Length = "0x101")]
	[NullableContext(1)]
	[Token(Token = "0x600085D")]
	internal object GetUninitializedObject() { }

	[Address(RVA = "0xE26C30", Offset = "0xE26030", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000856")]
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	[Address(RVA = "0x1D413A0", Offset = "0x1D407A0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600085A")]
	public void set_ExtensionDataNameResolver(Func<String, String> value) { }

	[Address(RVA = "0x20D5300", Offset = "0x20D4700", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000854")]
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[Address(RVA = "0x21438F0", Offset = "0x2142CF0", Length = "0xD9")]
	[Token(Token = "0x6000858")]
	public void set_ExtensionDataValueType(Type value) { }

	[Address(RVA = "0x21439D0", Offset = "0x2142DD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600084C")]
	public void set_ItemNullValueHandling(Nullable<NullValueHandling> value) { }

	[Address(RVA = "0x21439E0", Offset = "0x2142DE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600084A")]
	public void set_ItemRequired(Nullable<Required> value) { }

	[Address(RVA = "0x21439F0", Offset = "0x2142DF0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000846")]
	public void set_MemberSerialization(MemberSerialization value) { }

	[Address(RVA = "0x2143A00", Offset = "0x2142E00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000848")]
	public void set_MissingMemberHandling(Nullable<MissingMemberHandling> value) { }

	[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
	[Token(Token = "0x6000850")]
	public void set_OverrideCreator(ObjectConstructor<Object> value) { }

	[Address(RVA = "0x1CC9D00", Offset = "0x1CC9100", Length = "0x13")]
	[Token(Token = "0x6000852")]
	internal void set_ParameterizedCreator(ObjectConstructor<Object> value) { }

}

