namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x2000141")]
internal class JsonSchemaBuilder
{
	[CompilerGenerated]
	[Token(Token = "0x2000142")]
	private sealed class <>c__DisplayClass23_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005F1")]
		public JsonSchemaType type; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A55")]
		public <>c__DisplayClass23_0() { }

		[Address(RVA = "0x2170AA0", Offset = "0x216FEA0", Length = "0x40")]
		[Token(Token = "0x6000A56")]
		internal bool <MapType>b__0(KeyValuePair<String, JsonSchemaType> kv) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005EC")]
	private readonly IList<JsonSchema> _stack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005ED")]
	private readonly JsonSchemaResolver _resolver; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005EE")]
	private readonly IDictionary<String, JsonSchema> _documentSchemas; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005EF")]
	private JsonSchema _currentSchema; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005F0")]
	private JObject _rootSchema; //Field offset: 0x30

	[Token(Token = "0x170001A0")]
	private JsonSchema CurrentSchema
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000A46")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x215AE70", Offset = "0x215A270", Length = "0xDA")]
	[Token(Token = "0x6000A43")]
	public JsonSchemaBuilder(JsonSchemaResolver resolver) { }

	[Address(RVA = "0x2157340", Offset = "0x2156740", Length = "0x4E6")]
	[Token(Token = "0x6000A4A")]
	private JsonSchema BuildSchema(JToken token) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000A46")]
	private JsonSchema get_CurrentSchema() { }

	[Address(RVA = "0x2157940", Offset = "0x2156D40", Length = "0x17E")]
	[Token(Token = "0x6000A53")]
	internal static JsonSchemaType MapType(string type) { }

	[Address(RVA = "0x2157830", Offset = "0x2156C30", Length = "0x10C")]
	[Token(Token = "0x6000A54")]
	internal static string MapType(JsonSchemaType type) { }

	[Address(RVA = "0x2157AC0", Offset = "0x2156EC0", Length = "0xB4")]
	[Token(Token = "0x6000A45")]
	private JsonSchema Pop() { }

	[Address(RVA = "0x2157B80", Offset = "0x2156F80", Length = "0xD0")]
	[Token(Token = "0x6000A4F")]
	private void ProcessAdditionalItems(JToken token) { }

	[Address(RVA = "0x2157C60", Offset = "0x2157060", Length = "0xD0")]
	[Token(Token = "0x6000A4E")]
	private void ProcessAdditionalProperties(JToken token) { }

	[Address(RVA = "0x2157D40", Offset = "0x2157140", Length = "0x3B3")]
	[Token(Token = "0x6000A4D")]
	private void ProcessEnum(JToken token) { }

	[Address(RVA = "0x2158100", Offset = "0x2157500", Length = "0x331")]
	[Token(Token = "0x6000A4C")]
	private void ProcessExtends(JToken token) { }

	[Address(RVA = "0x2158440", Offset = "0x2157840", Length = "0x3F1")]
	[Token(Token = "0x6000A51")]
	private void ProcessItems(JToken token) { }

	[Address(RVA = "0x2158840", Offset = "0x2157C40", Length = "0x43F")]
	[Token(Token = "0x6000A50")]
	private IDictionary<String, JsonSchema> ProcessProperties(JToken token) { }

	[Address(RVA = "0x2158C80", Offset = "0x2158080", Length = "0x10AC")]
	[Token(Token = "0x6000A4B")]
	private void ProcessSchemaProperties(JObject schemaObject) { }

	[Address(RVA = "0x2159D30", Offset = "0x2159130", Length = "0x40C")]
	[Token(Token = "0x6000A52")]
	private Nullable<JsonSchemaType> ProcessType(JToken token) { }

	[Address(RVA = "0x215A140", Offset = "0x2159540", Length = "0xC6")]
	[Token(Token = "0x6000A44")]
	private void Push(JsonSchema value) { }

	[Address(RVA = "0x215A210", Offset = "0x2159610", Length = "0x117")]
	[Token(Token = "0x6000A47")]
	internal JsonSchema Read(JsonReader reader) { }

	[Address(RVA = "0x215A330", Offset = "0x2159730", Length = "0xA84")]
	[Token(Token = "0x6000A49")]
	private JsonSchema ResolveReferences(JsonSchema schema) { }

	[Address(RVA = "0x215ADC0", Offset = "0x215A1C0", Length = "0xAB")]
	[Token(Token = "0x6000A48")]
	private string UnescapeReference(string reference) { }

}

