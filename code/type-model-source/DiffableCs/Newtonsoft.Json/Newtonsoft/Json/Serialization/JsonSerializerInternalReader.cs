namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000127")]
internal class JsonSerializerInternalReader : JsonSerializerInternalBase
{
	[CompilerGenerated]
	[Token(Token = "0x200012A")]
	private sealed class <>c
	{
		[Nullable(0)]
		[Token(Token = "0x4000599")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		[Token(Token = "0x400059A")]
		public static Func<JsonProperty, String> <>9__38_0; //Field offset: 0x8
		[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1})]
		[Token(Token = "0x400059B")]
		public static Func<JsonProperty, String> <>9__38_2; //Field offset: 0x10
		[Nullable(0)]
		[Token(Token = "0x400059C")]
		public static Func<JsonProperty, JsonProperty> <>9__42_0; //Field offset: 0x18
		[Nullable(0)]
		[Token(Token = "0x400059D")]
		public static Func<JsonProperty, PropertyPresence> <>9__42_1; //Field offset: 0x20

		[Address(RVA = "0x2170CB0", Offset = "0x21700B0", Length = "0x67")]
		[Token(Token = "0x60008E3")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60008E4")]
		public <>c() { }

		[Address(RVA = "0x2144120", Offset = "0x2143520", Length = "0x17")]
		[NullableContext(0)]
		[Token(Token = "0x60008E5")]
		internal string <CreateObjectUsingCreatorWithParameters>b__38_0(JsonProperty p) { }

		[Address(RVA = "0x2144120", Offset = "0x2143520", Length = "0x17")]
		[NullableContext(0)]
		[Token(Token = "0x60008E6")]
		internal string <CreateObjectUsingCreatorWithParameters>b__38_2(JsonProperty p) { }

		[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
		[NullableContext(0)]
		[Token(Token = "0x60008E7")]
		internal JsonProperty <PopulateObject>b__42_0(JsonProperty m) { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[NullableContext(0)]
		[Token(Token = "0x60008E8")]
		internal PropertyPresence <PopulateObject>b__42_1(JsonProperty m) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012B")]
	private sealed class <>c__DisplayClass38_0
	{
		[FieldOffset(Offset = "0x10")]
		[Nullable(0)]
		[Token(Token = "0x400059E")]
		public JsonProperty property; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60008E9")]
		public <>c__DisplayClass38_0() { }

		[Address(RVA = "0x2170AE0", Offset = "0x216FEE0", Length = "0x1E")]
		[NullableContext(0)]
		[Token(Token = "0x60008EA")]
		internal bool <CreateObjectUsingCreatorWithParameters>b__1(CreatorPropertyContext p) { }

	}

	[Nullable(0)]
	[NullableContext(2)]
	[Token(Token = "0x2000129")]
	public class CreatorPropertyContext
	{
		[FieldOffset(Offset = "0x10")]
		[Nullable(1)]
		[Token(Token = "0x4000593")]
		public readonly string Name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000594")]
		public JsonProperty Property; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000595")]
		public JsonProperty ConstructorProperty; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000596")]
		public Nullable<PropertyPresence> Presence; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000597")]
		public object Value; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000598")]
		public bool Used; //Field offset: 0x38

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[NullableContext(1)]
		[Token(Token = "0x60008E2")]
		public CreatorPropertyContext(string name) { }

	}

	[NullableContext(0)]
	[Token(Token = "0x2000128")]
	public enum PropertyPresence : int
	{
		None = 0,
		Null = 1,
		Value = 2,
	}


	[Address(RVA = "0x21450D0", Offset = "0x21444D0", Length = "0xC8")]
	[Token(Token = "0x60008B2")]
	public JsonSerializerInternalReader(JsonSerializer serializer) { }

	[Address(RVA = "0x21453A0", Offset = "0x21447A0", Length = "0x2D7")]
	[Token(Token = "0x60008C8")]
	private void AddReference(JsonReader reader, string id, object value) { }

	[Address(RVA = "0x2145680", Offset = "0x2144A80", Length = "0x68A")]
	[NullableContext(2)]
	[Token(Token = "0x60008C7")]
	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue) { }

	[Address(RVA = "0x2145D10", Offset = "0x2145110", Length = "0x10D")]
	[Token(Token = "0x60008DC")]
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	[Address(RVA = "0x2145E20", Offset = "0x2145220", Length = "0xEE")]
	[NullableContext(2)]
	[Token(Token = "0x60008BB")]
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	[Address(RVA = "0x2145F10", Offset = "0x2145310", Length = "0x8F7")]
	[Token(Token = "0x60008D5")]
	private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	[Address(RVA = "0x21469B0", Offset = "0x2145DB0", Length = "0x7A7")]
	[Token(Token = "0x60008D3")]
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	[Address(RVA = "0x2146810", Offset = "0x2145C10", Length = "0x191")]
	[Token(Token = "0x60008D4")]
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	[Address(RVA = "0x2147160", Offset = "0x2146560", Length = "0x305")]
	[Token(Token = "0x60008B9")]
	private JToken CreateJObject(JsonReader reader) { }

	[Address(RVA = "0x2147470", Offset = "0x2146870", Length = "0x3BB")]
	[NullableContext(2)]
	[Token(Token = "0x60008B8")]
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	[Address(RVA = "0x2147830", Offset = "0x2146C30", Length = "0x8BE")]
	[NullableContext(2)]
	[Token(Token = "0x60008C3")]
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	[Address(RVA = "0x21480F0", Offset = "0x21474F0", Length = "0x2A2")]
	[Token(Token = "0x60008CC")]
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	[Address(RVA = "0x21483A0", Offset = "0x21477A0", Length = "0x36C")]
	[Token(Token = "0x60008CB")]
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	[Address(RVA = "0x2148710", Offset = "0x2147B10", Length = "0x2F9")]
	[Token(Token = "0x60008D9")]
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	[Address(RVA = "0x214A100", Offset = "0x2149500", Length = "0xDAC")]
	[NullableContext(2)]
	[Token(Token = "0x60008BE")]
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[Address(RVA = "0x2148A10", Offset = "0x2147E10", Length = "0x16EE")]
	[Token(Token = "0x60008D6")]
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<Object> creator, string id) { }

	[Address(RVA = "0x214AED0", Offset = "0x214A2D0", Length = "0x4DC")]
	[NullableContext(2)]
	[Token(Token = "0x60008BA")]
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[Address(RVA = "0x214B720", Offset = "0x214AB20", Length = "0x355")]
	[NullableContext(2)]
	[Token(Token = "0x60008B6")]
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	[Address(RVA = "0x214B3F0", Offset = "0x214A7F0", Length = "0x320")]
	[Token(Token = "0x60008D7")]
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	[Address(RVA = "0x214BA80", Offset = "0x214AE80", Length = "0x49A")]
	[Token(Token = "0x60008DF")]
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue) { }

	[Address(RVA = "0x214BF20", Offset = "0x214B320", Length = "0x1BA")]
	[Token(Token = "0x60008C2")]
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	[Address(RVA = "0x214C0E0", Offset = "0x214B4E0", Length = "0x510")]
	[NullableContext(2)]
	[Token(Token = "0x60008C5")]
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	[Address(RVA = "0x214C6A0", Offset = "0x214BAA0", Length = "0x5E")]
	[Token(Token = "0x60008B5")]
	private JsonContract GetContract(Type type) { }

	[Address(RVA = "0x214C600", Offset = "0x214BA00", Length = "0x90")]
	[NullableContext(2)]
	[Token(Token = "0x60008B4")]
	private JsonContract GetContractSafe(Type type) { }

	[Address(RVA = "0x214C700", Offset = "0x214BB00", Length = "0xD3")]
	[NullableContext(2)]
	[Token(Token = "0x60008BD")]
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x214C7E0", Offset = "0x214BBE0", Length = "0x64")]
	[Token(Token = "0x60008BC")]
	internal string GetExpectedDescription(JsonContract contract) { }

	[Address(RVA = "0x214C8E0", Offset = "0x214BCE0", Length = "0x6D")]
	[Token(Token = "0x60008B7")]
	private JsonSerializerProxy GetInternalSerializer() { }

	[Address(RVA = "0x214C950", Offset = "0x214BD50", Length = "0x7C")]
	[Token(Token = "0x60008E1")]
	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }

	[Address(RVA = "0x1F225E0", Offset = "0x1F219E0", Length = "0xA")]
	[Token(Token = "0x60008C9")]
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	[Address(RVA = "0x214C9D0", Offset = "0x214BDD0", Length = "0xCF")]
	[NullableContext(2)]
	[Token(Token = "0x60008C4")]
	private bool HasNoDefinedType(JsonContract contract) { }

	[Address(RVA = "0x214CAA0", Offset = "0x214BEA0", Length = "0x1AC")]
	[Token(Token = "0x60008CE")]
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	[Address(RVA = "0x214CC50", Offset = "0x214C050", Length = "0x1AC")]
	[Token(Token = "0x60008CD")]
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	[Address(RVA = "0x214F530", Offset = "0x214E930", Length = "0x5EB")]
	[Token(Token = "0x60008B3")]
	public void Populate(JsonReader reader, object target) { }

	[Address(RVA = "0x214CE00", Offset = "0x214C200", Length = "0xAC3")]
	[Token(Token = "0x60008CF")]
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	[Address(RVA = "0x214D8D0", Offset = "0x214CCD0", Length = "0x639")]
	[Token(Token = "0x60008D2")]
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	[Address(RVA = "0x214DF10", Offset = "0x214D310", Length = "0x87E")]
	[Token(Token = "0x60008D0")]
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	[Address(RVA = "0x214E790", Offset = "0x214DB90", Length = "0xD9A")]
	[Token(Token = "0x60008DA")]
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	[Address(RVA = "0x214FB20", Offset = "0x214EF20", Length = "0xB1")]
	[Token(Token = "0x60008DE")]
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	[Address(RVA = "0x21502E0", Offset = "0x214F6E0", Length = "0x692")]
	[NullableContext(2)]
	[Token(Token = "0x60008C0")]
	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[Address(RVA = "0x214FBE0", Offset = "0x214EFE0", Length = "0x6F5")]
	[NullableContext(2)]
	[Token(Token = "0x60008BF")]
	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[Address(RVA = "0x2150980", Offset = "0x214FD80", Length = "0x9B9")]
	[Token(Token = "0x60008D8")]
	private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	[Address(RVA = "0x2151340", Offset = "0x2150740", Length = "0x59F")]
	[NullableContext(2)]
	[Token(Token = "0x60008C1")]
	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	[Address(RVA = "0x21518E0", Offset = "0x2150CE0", Length = "0x129")]
	[Token(Token = "0x60008DD")]
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	[Address(RVA = "0x2151A10", Offset = "0x2150E10", Length = "0x10F")]
	[Token(Token = "0x60008E0")]
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, PropertyPresence> requiredProperties) { }

	[Address(RVA = "0x2151B20", Offset = "0x2150F20", Length = "0x3ED")]
	[Token(Token = "0x60008C6")]
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	[Address(RVA = "0x2151F10", Offset = "0x2151310", Length = "0x1CB")]
	[Token(Token = "0x60008DB")]
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	[Address(RVA = "0x21520E0", Offset = "0x21514E0", Length = "0x162")]
	[NullableContext(2)]
	[Token(Token = "0x60008CA")]
	private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	[Address(RVA = "0x2152250", Offset = "0x2151650", Length = "0x10F")]
	[Token(Token = "0x60008D1")]
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

}

