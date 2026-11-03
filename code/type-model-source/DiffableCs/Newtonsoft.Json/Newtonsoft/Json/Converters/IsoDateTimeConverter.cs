namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001B8")]
public class IsoDateTimeConverter : DateTimeConverterBase
{
	[Token(Token = "0x4000805")]
	private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000806")]
	private DateTimeStyles _dateTimeStyles; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Nullable(2)]
	[Token(Token = "0x4000807")]
	private string _dateTimeFormat; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Nullable(2)]
	[Token(Token = "0x4000808")]
	private CultureInfo _culture; //Field offset: 0x20

	[Token(Token = "0x17000250")]
	public CultureInfo Culture
	{
		[Address(RVA = "0x2196220", Offset = "0x2195620", Length = "0x54")]
		[Token(Token = "0x6000ED1")]
		 get { } //Length: 84
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000ED2")]
		 set { } //Length: 13
	}

	[Nullable(2)]
	[Token(Token = "0x1700024F")]
	public string DateTimeFormat
	{
		[Address(RVA = "0x1FA2610", Offset = "0x1FA1A10", Length = "0x1B")]
		[NullableContext(2)]
		[Token(Token = "0x6000ECF")]
		 get { } //Length: 27
		[Address(RVA = "0x2196280", Offset = "0x2195680", Length = "0x43")]
		[NullableContext(2)]
		[Token(Token = "0x6000ED0")]
		 set { } //Length: 67
	}

	[Token(Token = "0x1700024E")]
	public DateTimeStyles DateTimeStyles
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000ECD")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000ECE")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2196210", Offset = "0x2195610", Length = "0xE")]
	[Token(Token = "0x6000ED5")]
	public IsoDateTimeConverter() { }

	[Address(RVA = "0x2196220", Offset = "0x2195620", Length = "0x54")]
	[Token(Token = "0x6000ED1")]
	public CultureInfo get_Culture() { }

	[Address(RVA = "0x1FA2610", Offset = "0x1FA1A10", Length = "0x1B")]
	[NullableContext(2)]
	[Token(Token = "0x6000ECF")]
	public string get_DateTimeFormat() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000ECD")]
	public DateTimeStyles get_DateTimeStyles() { }

	[Address(RVA = "0x2195930", Offset = "0x2194D30", Length = "0x5A7")]
	[Token(Token = "0x6000ED4")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000ED2")]
	public void set_Culture(CultureInfo value) { }

	[Address(RVA = "0x2196280", Offset = "0x2195680", Length = "0x43")]
	[NullableContext(2)]
	[Token(Token = "0x6000ED0")]
	public void set_DateTimeFormat(string value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000ECE")]
	public void set_DateTimeStyles(DateTimeStyles value) { }

	[Address(RVA = "0x2195EE0", Offset = "0x21952E0", Length = "0x321")]
	[Token(Token = "0x6000ED3")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

