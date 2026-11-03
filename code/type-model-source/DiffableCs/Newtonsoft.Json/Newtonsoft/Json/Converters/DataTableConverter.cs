namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001AF")]
public class DataTableConverter : JsonConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000EAF")]
	public DataTableConverter() { }

	[Address(RVA = "0x2191C20", Offset = "0x2191020", Length = "0x7D")]
	[Token(Token = "0x6000EAE")]
	public virtual bool CanConvert(Type valueType) { }

	[Address(RVA = "0x2191CA0", Offset = "0x21910A0", Length = "0x49F")]
	[Token(Token = "0x6000EAC")]
	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	[Address(RVA = "0x2192140", Offset = "0x2191540", Length = "0x1E0")]
	[Token(Token = "0x6000EAD")]
	private static Type GetColumnDataType(JsonReader reader) { }

	[Address(RVA = "0x2192360", Offset = "0x2191760", Length = "0x2FC")]
	[Token(Token = "0x6000EAB")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x2192660", Offset = "0x2191A60", Length = "0x557")]
	[Token(Token = "0x6000EAA")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

