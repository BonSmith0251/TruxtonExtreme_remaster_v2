namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x2000149")]
internal class JsonSchemaModelBuilder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000635")]
	private JsonSchemaNodeCollection _nodes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000636")]
	private Dictionary<JsonSchemaNode, JsonSchemaModel> _nodeModels; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000637")]
	private JsonSchemaNode _node; //Field offset: 0x20

	[Address(RVA = "0x215E850", Offset = "0x215DC50", Length = "0xCD")]
	[Token(Token = "0x6000AB4")]
	public JsonSchemaModelBuilder() { }

	[Address(RVA = "0x215D360", Offset = "0x215C760", Length = "0x34")]
	[Token(Token = "0x6000AB2")]
	public void AddAdditionalItems(JsonSchemaNode parentNode, JsonSchema schema) { }

	[Address(RVA = "0x215D3A0", Offset = "0x215C7A0", Length = "0x34")]
	[Token(Token = "0x6000AB1")]
	public void AddAdditionalProperties(JsonSchemaNode parentNode, JsonSchema schema) { }

	[Address(RVA = "0x215D3E0", Offset = "0x215C7E0", Length = "0x148")]
	[Token(Token = "0x6000AB0")]
	public void AddItem(JsonSchemaNode parentNode, int index, JsonSchema schema) { }

	[Address(RVA = "0x215D530", Offset = "0x215C930", Length = "0x351")]
	[Token(Token = "0x6000AAE")]
	public void AddProperties(IDictionary<String, JsonSchema> source, IDictionary<String, JsonSchemaNode> target) { }

	[Address(RVA = "0x215D890", Offset = "0x215CC90", Length = "0x177")]
	[Token(Token = "0x6000AAF")]
	public void AddProperty(IDictionary<String, JsonSchemaNode> target, string propertyName, JsonSchema schema) { }

	[Address(RVA = "0x215DA10", Offset = "0x215CE10", Length = "0x667")]
	[Token(Token = "0x6000AAD")]
	public JsonSchemaNode AddSchema(JsonSchemaNode existingNode, JsonSchema schema) { }

	[Address(RVA = "0x215E750", Offset = "0x215DB50", Length = "0xFF")]
	[Token(Token = "0x6000AAC")]
	public JsonSchemaModel Build(JsonSchema schema) { }

	[Address(RVA = "0x215E080", Offset = "0x215D480", Length = "0x6C4")]
	[Token(Token = "0x6000AB3")]
	private JsonSchemaModel BuildNodeModel(JsonSchemaNode node) { }

}

