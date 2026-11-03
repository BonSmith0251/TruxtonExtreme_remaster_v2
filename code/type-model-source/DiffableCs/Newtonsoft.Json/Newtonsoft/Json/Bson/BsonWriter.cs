namespace Newtonsoft.Json.Bson;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
[Token(Token = "0x20001E5")]
public class BsonWriter : JsonWriter
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400087A")]
	private readonly BsonBinaryWriter _writer; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400087B")]
	private BsonToken _root; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400087C")]
	private BsonToken _parent; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400087D")]
	private string _propertyName; //Field offset: 0x78

	[Token(Token = "0x170002C1")]
	public DateTimeKind DateTimeKindHandling
	{
		[Address(RVA = "0x21AF220", Offset = "0x21AE620", Length = "0x1A")]
		[Token(Token = "0x600102A")]
		 get { } //Length: 26
		[Address(RVA = "0x21AF240", Offset = "0x21AE640", Length = "0x1A")]
		[Token(Token = "0x600102B")]
		 set { } //Length: 26
	}

	[Address(RVA = "0x21AF120", Offset = "0x21AE520", Length = "0xF2")]
	[Token(Token = "0x600102C")]
	public BsonWriter(Stream stream) { }

	[Address(RVA = "0x21AF050", Offset = "0x21AE450", Length = "0xC9")]
	[Token(Token = "0x600102D")]
	public BsonWriter(BinaryWriter writer) { }

	[Address(RVA = "0x21AD7E0", Offset = "0x21ACBE0", Length = "0x32")]
	[Token(Token = "0x6001038")]
	private void AddParent(BsonToken container) { }

	[Address(RVA = "0x21AD820", Offset = "0x21ACC20", Length = "0x3D0")]
	[Token(Token = "0x600103B")]
	internal void AddToken(BsonToken token) { }

	[Address(RVA = "0x21ADC00", Offset = "0x21AD000", Length = "0x89")]
	[Token(Token = "0x600103A")]
	private void AddValue(object value, BsonType type) { }

	[Address(RVA = "0x21ADC90", Offset = "0x21AD090", Length = "0x4C")]
	[Token(Token = "0x6001037")]
	public virtual void Close() { }

	[Address(RVA = "0x21ADCE0", Offset = "0x21AD0E0", Length = "0x33")]
	[Token(Token = "0x600102E")]
	public virtual void Flush() { }

	[Address(RVA = "0x21AF220", Offset = "0x21AE620", Length = "0x1A")]
	[Token(Token = "0x600102A")]
	public DateTimeKind get_DateTimeKindHandling() { }

	[Address(RVA = "0x21ADD20", Offset = "0x21AD120", Length = "0x27")]
	[Token(Token = "0x6001039")]
	private void RemoveParent() { }

	[Address(RVA = "0x21AF240", Offset = "0x21AE640", Length = "0x1A")]
	[Token(Token = "0x600102B")]
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	[Address(RVA = "0x21ADD50", Offset = "0x21AD150", Length = "0x40")]
	[Token(Token = "0x6001030")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x21ADDA0", Offset = "0x21AD1A0", Length = "0x76")]
	[Token(Token = "0x600102F")]
	protected virtual void WriteEnd(JsonToken token) { }

	[Address(RVA = "0x21ADE20", Offset = "0x21AD220", Length = "0x68")]
	[Token(Token = "0x600103D")]
	public virtual void WriteNull() { }

	[Address(RVA = "0x21ADE90", Offset = "0x21AD290", Length = "0xB4")]
	[Token(Token = "0x6001053")]
	public void WriteObjectId(Byte[] value) { }

	[Address(RVA = "0x21ADF50", Offset = "0x21AD350", Length = "0x32")]
	[Token(Token = "0x6001036")]
	public virtual void WritePropertyName(string name) { }

	[Address(RVA = "0x21ADFE0", Offset = "0x21AD3E0", Length = "0x40")]
	[Token(Token = "0x6001032")]
	public virtual void WriteRaw(string json) { }

	[Address(RVA = "0x21ADF90", Offset = "0x21AD390", Length = "0x40")]
	[Token(Token = "0x6001033")]
	public virtual void WriteRawValue(string json) { }

	[Address(RVA = "0x21AE030", Offset = "0x21AD430", Length = "0x14F")]
	[Token(Token = "0x6001054")]
	public void WriteRegex(string pattern, string options) { }

	[Address(RVA = "0x21AE180", Offset = "0x21AD580", Length = "0xD4")]
	[Token(Token = "0x6001034")]
	public virtual void WriteStartArray() { }

	[Address(RVA = "0x21AE260", Offset = "0x21AD660", Length = "0x40")]
	[Token(Token = "0x6001031")]
	public virtual void WriteStartConstructor(string name) { }

	[Address(RVA = "0x21AE2B0", Offset = "0x21AD6B0", Length = "0xD4")]
	[Token(Token = "0x6001035")]
	public virtual void WriteStartObject() { }

	[Address(RVA = "0x21AE390", Offset = "0x21AD790", Length = "0x69")]
	[Token(Token = "0x600103E")]
	public virtual void WriteUndefined() { }

	[Address(RVA = "0x21AE450", Offset = "0x21AD850", Length = "0x12C")]
	[Token(Token = "0x600103C")]
	public virtual void WriteValue(object value) { }

	[Address(RVA = "0x21AEF40", Offset = "0x21AE340", Length = "0x108")]
	[Token(Token = "0x6001052")]
	public virtual void WriteValue(Uri value) { }

	[Address(RVA = "0x21AEA90", Offset = "0x21ADE90", Length = "0xC2")]
	[Token(Token = "0x6001051")]
	public virtual void WriteValue(TimeSpan value) { }

	[Address(RVA = "0x21AEC60", Offset = "0x21AE060", Length = "0xA5")]
	[Token(Token = "0x6001050")]
	public virtual void WriteValue(Guid value) { }

	[Address(RVA = "0x21AE990", Offset = "0x21ADD90", Length = "0xB0")]
	[Token(Token = "0x600104F")]
	public virtual void WriteValue(Byte[] value) { }

	[Address(RVA = "0x21AE840", Offset = "0x21ADC40", Length = "0x79")]
	[Token(Token = "0x600104E")]
	public virtual void WriteValue(DateTimeOffset value) { }

	[Address(RVA = "0x21AEBB0", Offset = "0x21ADFB0", Length = "0xA7")]
	[Token(Token = "0x600104D")]
	public virtual void WriteValue(DateTime value) { }

	[Address(RVA = "0x21AE910", Offset = "0x21ADD10", Length = "0x79")]
	[Token(Token = "0x600104C")]
	public virtual void WriteValue(decimal value) { }

	[Address(RVA = "0x21AEE10", Offset = "0x21AE210", Length = "0x49")]
	[CLSCompliant(False)]
	[Token(Token = "0x600104B")]
	public virtual void WriteValue(sbyte value) { }

	[Address(RVA = "0x21AEA40", Offset = "0x21ADE40", Length = "0x49")]
	[Token(Token = "0x600104A")]
	public virtual void WriteValue(byte value) { }

	[Address(RVA = "0x21AE400", Offset = "0x21AD800", Length = "0x4A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001048")]
	public virtual void WriteValue(ushort value) { }

	[Address(RVA = "0x21AE8C0", Offset = "0x21ADCC0", Length = "0x4A")]
	[Token(Token = "0x6001047")]
	public virtual void WriteValue(short value) { }

	[Address(RVA = "0x21AED10", Offset = "0x21AE110", Length = "0xAD")]
	[Token(Token = "0x6001046")]
	public virtual void WriteValue(bool value) { }

	[Address(RVA = "0x21AEB60", Offset = "0x21ADF60", Length = "0x4C")]
	[Token(Token = "0x6001045")]
	public virtual void WriteValue(double value) { }

	[Address(RVA = "0x21AEDC0", Offset = "0x21AE1C0", Length = "0x4C")]
	[Token(Token = "0x6001044")]
	public virtual void WriteValue(float value) { }

	[Address(RVA = "0x21AE610", Offset = "0x21ADA10", Length = "0x90")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001043")]
	public virtual void WriteValue(ulong value) { }

	[Address(RVA = "0x21AE700", Offset = "0x21ADB00", Length = "0x4A")]
	[Token(Token = "0x6001042")]
	public virtual void WriteValue(long value) { }

	[Address(RVA = "0x21AE580", Offset = "0x21AD980", Length = "0x87")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001041")]
	public virtual void WriteValue(uint value) { }

	[Address(RVA = "0x21AE6B0", Offset = "0x21ADAB0", Length = "0x48")]
	[Token(Token = "0x6001040")]
	public virtual void WriteValue(int value) { }

	[Address(RVA = "0x21AE750", Offset = "0x21ADB50", Length = "0xE5")]
	[Token(Token = "0x6001049")]
	public virtual void WriteValue(char value) { }

	[Address(RVA = "0x21AEE60", Offset = "0x21AE260", Length = "0xD3")]
	[Token(Token = "0x600103F")]
	public virtual void WriteValue(string value) { }

}

