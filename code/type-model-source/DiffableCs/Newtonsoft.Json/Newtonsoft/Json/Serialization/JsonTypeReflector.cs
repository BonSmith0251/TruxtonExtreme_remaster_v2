namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200012F")]
internal static class JsonTypeReflector
{
	[CompilerGenerated]
	[Token(Token = "0x2000130")]
	private sealed class <>c
	{
		[Nullable(0)]
		[Token(Token = "0x40005B2")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		[Token(Token = "0x40005B3")]
		public static Func<Object, Type> <>9__22_1; //Field offset: 0x8

		[Address(RVA = "0x2170BD0", Offset = "0x216FFD0", Length = "0x67")]
		[Token(Token = "0x600096C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600096D")]
		public <>c() { }

		[Address(RVA = "0x21704A0", Offset = "0x216F8A0", Length = "0x6C")]
		[NullableContext(0)]
		[Token(Token = "0x600096E")]
		internal Type <GetCreator>b__22_1(object param) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000131")]
	private sealed class <>c__DisplayClass22_0
	{
		[FieldOffset(Offset = "0x10")]
		[Nullable(0)]
		[Token(Token = "0x40005B4")]
		public Type type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40005B5")]
		public Func<Object> defaultConstructor; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600096F")]
		public <>c__DisplayClass22_0() { }

		[Address(RVA = "0x2170670", Offset = "0x216FA70", Length = "0x3C4")]
		[Token(Token = "0x6000970")]
		internal object <GetCreator>b__0(Object[] parameters) { }

	}

	[Token(Token = "0x40005A5")]
	private static Nullable<Boolean> _dynamicCodeGeneration; //Field offset: 0x0
	[Token(Token = "0x40005A7")]
	public const string IdPropertyName = "$id"; //Field offset: 0x0
	[Token(Token = "0x40005A8")]
	public const string RefPropertyName = "$ref"; //Field offset: 0x0
	[Token(Token = "0x40005A9")]
	public const string TypePropertyName = "$type"; //Field offset: 0x0
	[Token(Token = "0x40005AA")]
	public const string ValuePropertyName = "$value"; //Field offset: 0x0
	[Token(Token = "0x40005AB")]
	public const string ArrayValuesPropertyName = "$values"; //Field offset: 0x0
	[Token(Token = "0x40005AC")]
	public const string ShouldSerializePrefix = "ShouldSerialize"; //Field offset: 0x0
	[Token(Token = "0x40005AD")]
	public const string SpecifiedPostfix = "Specified"; //Field offset: 0x0
	[Token(Token = "0x40005AE")]
	public const string ConcurrentDictionaryTypeName = "System.Collections.Concurrent.ConcurrentDictionary`2"; //Field offset: 0x0
	[Token(Token = "0x40005A6")]
	private static Nullable<Boolean> _fullyTrusted; //Field offset: 0x2
	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 1, 2, 1, 1})]
	[Token(Token = "0x40005AF")]
	private static readonly ThreadSafeStore<Type, Func`2<Object[], Object>> CreatorCache; //Field offset: 0x8
	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 2})]
	[Token(Token = "0x40005B0")]
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; //Field offset: 0x10
	[Nullable(2)]
	[Token(Token = "0x40005B1")]
	private static ReflectionObject _metadataTypeAttributeReflectionObject; //Field offset: 0x18

	[Token(Token = "0x1700016C")]
	public static bool DynamicCodeGeneration
	{
		[Address(RVA = "0x216C3F0", Offset = "0x216B7F0", Length = "0xED")]
		[Token(Token = "0x6000968")]
		 get { } //Length: 237
	}

	[Token(Token = "0x1700016D")]
	public static bool FullyTrusted
	{
		[Address(RVA = "0x216C4E0", Offset = "0x216B8E0", Length = "0x11C")]
		[Token(Token = "0x6000969")]
		 get { } //Length: 284
	}

	[Token(Token = "0x1700016E")]
	public static ReflectionDelegateFactory ReflectionDelegateFactory
	{
		[Address(RVA = "0x216C600", Offset = "0x216BA00", Length = "0x89")]
		[Token(Token = "0x600096A")]
		 get { } //Length: 137
	}

	[Address(RVA = "0x216C280", Offset = "0x216B680", Length = "0x170")]
	[Token(Token = "0x600096B")]
	private static JsonTypeReflector() { }

	[Address(RVA = "0x216B1B0", Offset = "0x216A5B0", Length = "0x1EC")]
	[Token(Token = "0x6000958")]
	public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter) { }

	[Address(RVA = "0x216B3A0", Offset = "0x216A7A0", Length = "0xE8")]
	[Token(Token = "0x600095D")]
	public static JsonConverter CreateJsonConverterInstance(Type converterType, Object[] args) { }

	[Address(RVA = "0x216B490", Offset = "0x216A890", Length = "0xE8")]
	[Token(Token = "0x600095E")]
	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, Object[] args) { }

	[Address(RVA = "0x216C3F0", Offset = "0x216B7F0", Length = "0xED")]
	[Token(Token = "0x6000968")]
	public static bool get_DynamicCodeGeneration() { }

	[Address(RVA = "0x216C4E0", Offset = "0x216B8E0", Length = "0x11C")]
	[Token(Token = "0x6000969")]
	public static bool get_FullyTrusted() { }

	[Address(RVA = "0x216C600", Offset = "0x216BA00", Length = "0x89")]
	[Token(Token = "0x600096A")]
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	[Address(RVA = "0x216B800", Offset = "0x216AC00", Length = "0x79")]
	[Token(Token = "0x6000961")]
	private static Type GetAssociatedMetadataType(Type type) { }

	[Address(RVA = "0x216B580", Offset = "0x216A980", Length = "0x277")]
	[Token(Token = "0x6000962")]
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	[Address(RVA = "0x84FA10", Offset = "0x84EE10", Length = "0x18B")]
	[Token(Token = "0x6000963")]
	private static T GetAttribute(Type type) { }

	[Address(RVA = "0x84F640", Offset = "0x84EA40", Length = "0x286")]
	[Token(Token = "0x6000964")]
	private static T GetAttribute(MemberInfo memberInfo) { }

	[Address(RVA = "0x84F8D0", Offset = "0x84ECD0", Length = "0x134")]
	[Token(Token = "0x6000967")]
	public static T GetAttribute(object provider) { }

	[Address(RVA = "0x84FBA0", Offset = "0x84EFA0", Length = "0x62")]
	[Token(Token = "0x6000957")]
	public static T GetCachedAttribute(object attributeProvider) { }

	[Address(RVA = "0x216B880", Offset = "0x216AC80", Length = "0x18F")]
	[Token(Token = "0x600095F")]
	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	[Address(RVA = "0x216BA10", Offset = "0x216AE10", Length = "0x16D")]
	[Token(Token = "0x6000960")]
	private static Func<Object[], Object> GetCreator(Type type) { }

	[Address(RVA = "0x216BB80", Offset = "0x216AF80", Length = "0xA6")]
	[Token(Token = "0x6000959")]
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	[Address(RVA = "0x216BC30", Offset = "0x216B030", Length = "0x271")]
	[Token(Token = "0x600095A")]
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	[Address(RVA = "0x216BEB0", Offset = "0x216B2B0", Length = "0x119")]
	[Token(Token = "0x600095C")]
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	[Address(RVA = "0x216BFD0", Offset = "0x216B3D0", Length = "0x1CE")]
	[Token(Token = "0x600095B")]
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	[Address(RVA = "0x216C1A0", Offset = "0x216B5A0", Length = "0x63")]
	[Token(Token = "0x6000965")]
	public static bool IsNonSerializable(object provider) { }

	[Address(RVA = "0x216C210", Offset = "0x216B610", Length = "0x63")]
	[Token(Token = "0x6000966")]
	public static bool IsSerializable(object provider) { }

}

