namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x200014C")]
internal class JsonSchemaNodeCollection : KeyedCollection<String, JsonSchemaNode>
{

	[Address(RVA = "0x215EFD0", Offset = "0x215E3D0", Length = "0x39")]
	[Token(Token = "0x6000AC7")]
	public JsonSchemaNodeCollection() { }

	[Address(RVA = "0xA503D0", Offset = "0xA4F7D0", Length = "0x17")]
	[Token(Token = "0x6000AC6")]
	protected virtual string GetKeyForItem(JsonSchemaNode item) { }

}

