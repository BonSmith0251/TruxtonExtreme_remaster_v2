namespace Newtonsoft.Json.Serialization;

[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
[NullableContext(1)]
[Token(Token = "0x2000124")]
public class JsonPropertyCollection : KeyedCollection<String, JsonProperty>
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000588")]
	private readonly Type _type; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000589")]
	private readonly List<JsonProperty> _list; //Field offset: 0x38

	[Address(RVA = "0x2144410", Offset = "0x2143810", Length = "0x1C2")]
	[Token(Token = "0x60008A3")]
	public JsonPropertyCollection(Type type) { }

	[Address(RVA = "0x2143DE0", Offset = "0x21431E0", Length = "0x2E7")]
	[Token(Token = "0x60008A5")]
	public void AddProperty(JsonProperty property) { }

	[Address(RVA = "0x21440D0", Offset = "0x21434D0", Length = "0x42")]
	[Token(Token = "0x60008A6")]
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	[Address(RVA = "0x2144120", Offset = "0x2143520", Length = "0x17")]
	[Token(Token = "0x60008A4")]
	protected virtual string GetKeyForItem(JsonProperty item) { }

	[Address(RVA = "0x2144140", Offset = "0x2143540", Length = "0x1C1")]
	[Token(Token = "0x60008A8")]
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

	[Address(RVA = "0x2144310", Offset = "0x2143710", Length = "0xF3")]
	[Token(Token = "0x60008A7")]
	private bool TryGetProperty(string key, out JsonProperty item) { }

}

