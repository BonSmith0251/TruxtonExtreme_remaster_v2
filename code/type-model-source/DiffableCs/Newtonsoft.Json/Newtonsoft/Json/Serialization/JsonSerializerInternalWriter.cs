namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200012C")]
internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
{
	[FieldOffset(Offset = "0x38")]
	[Nullable(2)]
	[Token(Token = "0x400059F")]
	private Type _rootType; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005A0")]
	private int _rootLevel; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005A1")]
	private readonly List<Object> _serializeStack; //Field offset: 0x48

	[Address(RVA = "0x216A2E0", Offset = "0x21696E0", Length = "0x88")]
	[Token(Token = "0x60008EB")]
	public JsonSerializerInternalWriter(JsonSerializer serializer) { }

	[Address(RVA = "0x2162060", Offset = "0x2161460", Length = "0x88F")]
	[Token(Token = "0x60008FD")]
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	[Address(RVA = "0x21628F0", Offset = "0x2161CF0", Length = "0x40D")]
	[NullableContext(2)]
	[Token(Token = "0x60008F5")]
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x2162D80", Offset = "0x2162180", Length = "0x70")]
	[Token(Token = "0x60008EF")]
	private JsonContract GetContract(object value) { }

	[Address(RVA = "0x2162D00", Offset = "0x2162100", Length = "0x7D")]
	[NullableContext(2)]
	[Token(Token = "0x60008EE")]
	private JsonContract GetContractSafe(object value) { }

	[Address(RVA = "0x2162E00", Offset = "0x2162200", Length = "0xC8")]
	[Token(Token = "0x60008ED")]
	private JsonSerializerProxy GetInternalSerializer() { }

	[Address(RVA = "0x2162ED0", Offset = "0x21622D0", Length = "0x52C")]
	[Token(Token = "0x600090F")]
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	[Address(RVA = "0x2163420", Offset = "0x2162820", Length = "0x1A1")]
	[Token(Token = "0x60008F7")]
	private string GetReference(JsonWriter writer, object value) { }

	[Address(RVA = "0x21635D0", Offset = "0x21629D0", Length = "0x72")]
	[Token(Token = "0x6000910")]
	private void HandleError(JsonWriter writer, int initialDepth) { }

	[Address(RVA = "0x2163650", Offset = "0x2162A50", Length = "0xAB")]
	[Token(Token = "0x60008FF")]
	private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	[Address(RVA = "0x1F225E0", Offset = "0x1F219E0", Length = "0xA")]
	[Token(Token = "0x6000904")]
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	[Address(RVA = "0x1F225E0", Offset = "0x1F219E0", Length = "0xA")]
	[Token(Token = "0x6000903")]
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	[Address(RVA = "0x1F225E0", Offset = "0x1F219E0", Length = "0xA")]
	[Token(Token = "0x6000902")]
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	[Address(RVA = "0x2163700", Offset = "0x2162B00", Length = "0x1BF")]
	[Token(Token = "0x6000912")]
	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }

	[Address(RVA = "0x21638C0", Offset = "0x2162CC0", Length = "0x17A")]
	[Token(Token = "0x60008FB")]
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	[Address(RVA = "0x2163A40", Offset = "0x2162E40", Length = "0x17A")]
	[Token(Token = "0x60008FA")]
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	[Address(RVA = "0x2163BC0", Offset = "0x2162FC0", Length = "0x87")]
	[NullableContext(2)]
	[Token(Token = "0x60008F2")]
	private Nullable<Boolean> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x2168750", Offset = "0x2167B50", Length = "0x30C")]
	[NullableContext(2)]
	[Token(Token = "0x60008EC")]
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	[Address(RVA = "0x2163C50", Offset = "0x2163050", Length = "0x42F")]
	[Token(Token = "0x6000905")]
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x2164080", Offset = "0x2163480", Length = "0xAD8")]
	[Token(Token = "0x600090E")]
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x2164B60", Offset = "0x2163F60", Length = "0xFDB")]
	[Token(Token = "0x600090B")]
	private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x2165B40", Offset = "0x2164F40", Length = "0x94D")]
	[Token(Token = "0x600090A")]
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x2166490", Offset = "0x2165890", Length = "0x5B7")]
	[Token(Token = "0x6000906")]
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x2166A50", Offset = "0x2165E50", Length = "0x41B")]
	[Token(Token = "0x6000908")]
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, Int32[] indices) { }

	[Address(RVA = "0x2166E70", Offset = "0x2166270", Length = "0x247")]
	[Token(Token = "0x6000907")]
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x21670C0", Offset = "0x21664C0", Length = "0xB9F")]
	[Token(Token = "0x60008FC")]
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x2167C60", Offset = "0x2167060", Length = "0x2F4")]
	[Token(Token = "0x60008F0")]
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x2167F60", Offset = "0x2167360", Length = "0xAA")]
	[Token(Token = "0x60008F9")]
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	[Address(RVA = "0x2168010", Offset = "0x2167410", Length = "0x1A4")]
	[NullableContext(2)]
	[Token(Token = "0x60008F1")]
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x2168A60", Offset = "0x2167E60", Length = "0x1BF")]
	[Token(Token = "0x6000911")]
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	[Address(RVA = "0x2168C20", Offset = "0x2168020", Length = "0xA8")]
	[NullableContext(2)]
	[Token(Token = "0x600090C")]
	private bool ShouldWriteDynamicProperty(object memberValue) { }

	[Address(RVA = "0x2168CD0", Offset = "0x21680D0", Length = "0xCE")]
	[NullableContext(2)]
	[Token(Token = "0x60008F4")]
	private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	[Address(RVA = "0x2168DA0", Offset = "0x21681A0", Length = "0x1E0")]
	[NullableContext(2)]
	[Token(Token = "0x60008F3")]
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x2168F90", Offset = "0x2168390", Length = "0x211")]
	[NullableContext(2)]
	[Token(Token = "0x600090D")]
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x21691B0", Offset = "0x21685B0", Length = "0x2AF")]
	[Token(Token = "0x60008F8")]
	internal static bool TryConvertToString(object value, Type type, out string s) { }

	[Address(RVA = "0x2169460", Offset = "0x2168860", Length = "0x3C6")]
	[Token(Token = "0x60008FE")]
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x21699F0", Offset = "0x2168DF0", Length = "0x1F2")]
	[Token(Token = "0x60008F6")]
	private void WriteReference(JsonWriter writer, object value) { }

	[Address(RVA = "0x2169830", Offset = "0x2168C30", Length = "0x1B9")]
	[Token(Token = "0x6000900")]
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	[Address(RVA = "0x2169BF0", Offset = "0x2168FF0", Length = "0x4F5")]
	[Token(Token = "0x6000909")]
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[Address(RVA = "0x216A0F0", Offset = "0x21694F0", Length = "0x1E5")]
	[Token(Token = "0x6000901")]
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

}

