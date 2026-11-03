namespace Newtonsoft.Json.Converters;

[Token(Token = "0x20001B0")]
public abstract class DateTimeConverterBase : JsonConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000EB1")]
	protected DateTimeConverterBase() { }

	[Address(RVA = "0x2192BC0", Offset = "0x2191FC0", Length = "0x149")]
	[NullableContext(1)]
	[Token(Token = "0x6000EB0")]
	public virtual bool CanConvert(Type objectType) { }

}

