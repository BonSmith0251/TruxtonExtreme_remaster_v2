namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200013C")]
internal class TraceJsonWriter : JsonWriter
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005C2")]
	private readonly JsonWriter _innerWriter; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005C3")]
	private readonly JsonTextWriter _textWriter; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40005C4")]
	private readonly StringWriter _sw; //Field offset: 0x70

	[Address(RVA = "0x216FBB0", Offset = "0x216EFB0", Length = "0x207")]
	[Token(Token = "0x60009B2")]
	public TraceJsonWriter(JsonWriter innerWriter) { }

	[Address(RVA = "0x216DDA0", Offset = "0x216D1A0", Length = "0x55")]
	[Token(Token = "0x60009E8")]
	public virtual void Close() { }

	[Address(RVA = "0x216DE00", Offset = "0x216D200", Length = "0x4C")]
	[Token(Token = "0x60009E9")]
	public virtual void Flush() { }

	[Address(RVA = "0x216DE50", Offset = "0x216D250", Length = "0x2A")]
	[Token(Token = "0x60009B3")]
	public string GetSerializedJsonMessage() { }

	[Address(RVA = "0x216DE80", Offset = "0x216D280", Length = "0x68")]
	[NullableContext(2)]
	[Token(Token = "0x60009DD")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x216DEF0", Offset = "0x216D2F0", Length = "0x55")]
	[Token(Token = "0x60009DF")]
	public virtual void WriteEndArray() { }

	[Address(RVA = "0x216DF50", Offset = "0x216D350", Length = "0x55")]
	[Token(Token = "0x60009E1")]
	public virtual void WriteEndConstructor() { }

	[Address(RVA = "0x216DFB0", Offset = "0x216D3B0", Length = "0x55")]
	[Token(Token = "0x60009E5")]
	public virtual void WriteEndObject() { }

	[Address(RVA = "0x216E010", Offset = "0x216D410", Length = "0x55")]
	[Token(Token = "0x60009C4")]
	public virtual void WriteNull() { }

	[Address(RVA = "0x216E0E0", Offset = "0x216D4E0", Length = "0x7A")]
	[Token(Token = "0x60009E3")]
	public virtual void WritePropertyName(string name, bool escape) { }

	[Address(RVA = "0x216E070", Offset = "0x216D470", Length = "0x68")]
	[Token(Token = "0x60009E2")]
	public virtual void WritePropertyName(string name) { }

	[Address(RVA = "0x216E1D0", Offset = "0x216D5D0", Length = "0x68")]
	[NullableContext(2)]
	[Token(Token = "0x60009E7")]
	public virtual void WriteRaw(string json) { }

	[Address(RVA = "0x216E160", Offset = "0x216D560", Length = "0x6A")]
	[NullableContext(2)]
	[Token(Token = "0x60009E6")]
	public virtual void WriteRawValue(string json) { }

	[Address(RVA = "0x216E240", Offset = "0x216D640", Length = "0x55")]
	[Token(Token = "0x60009DE")]
	public virtual void WriteStartArray() { }

	[Address(RVA = "0x216E2A0", Offset = "0x216D6A0", Length = "0x68")]
	[Token(Token = "0x60009E0")]
	public virtual void WriteStartConstructor(string name) { }

	[Address(RVA = "0x216E310", Offset = "0x216D710", Length = "0x55")]
	[Token(Token = "0x60009E4")]
	public virtual void WriteStartObject() { }

	[Address(RVA = "0x216E370", Offset = "0x216D770", Length = "0x55")]
	[Token(Token = "0x60009C3")]
	public virtual void WriteUndefined() { }

	[Address(RVA = "0x216EF90", Offset = "0x216E390", Length = "0x68")]
	[Token(Token = "0x60009D3")]
	public virtual void WriteValue(TimeSpan value) { }

	[Address(RVA = "0x216EAB0", Offset = "0x216DEB0", Length = "0xE3")]
	[Token(Token = "0x60009B5")]
	public virtual void WriteValue(Nullable<Decimal> value) { }

	[Address(RVA = "0x216F1D0", Offset = "0x216E5D0", Length = "0xBE")]
	[Token(Token = "0x60009D4")]
	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	[Address(RVA = "0x216EE60", Offset = "0x216E260", Length = "0x68")]
	[NullableContext(2)]
	[Token(Token = "0x60009D2")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x216F540", Offset = "0x216E940", Length = "0x65")]
	[Token(Token = "0x60009D5")]
	public virtual void WriteValue(uint value) { }

	[Address(RVA = "0x216F000", Offset = "0x216E400", Length = "0x68")]
	[Token(Token = "0x60009DA")]
	public virtual void WriteValue(ushort value) { }

	[Address(RVA = "0x216F930", Offset = "0x216ED30", Length = "0x68")]
	[Token(Token = "0x60009D7")]
	public virtual void WriteValue(ulong value) { }

	[Address(RVA = "0x216F7B0", Offset = "0x216EBB0", Length = "0xBE")]
	[Token(Token = "0x60009D8")]
	public virtual void WriteValue(Nullable<UInt64> value) { }

	[Address(RVA = "0x216F320", Offset = "0x216E720", Length = "0xC2")]
	[NullableContext(2)]
	[Token(Token = "0x60009D9")]
	public virtual void WriteValue(Uri value) { }

	[Address(RVA = "0x216E6D0", Offset = "0x216DAD0", Length = "0xAB")]
	[Token(Token = "0x60009D1")]
	public virtual void WriteValue(Nullable<Int16> value) { }

	[Address(RVA = "0x216EDB0", Offset = "0x216E1B0", Length = "0xAB")]
	[Token(Token = "0x60009DB")]
	public virtual void WriteValue(Nullable<UInt16> value) { }

	[Address(RVA = "0x216FA90", Offset = "0x216EE90", Length = "0xAE")]
	[Token(Token = "0x60009D6")]
	public virtual void WriteValue(Nullable<UInt32> value) { }

	[Address(RVA = "0x216FA20", Offset = "0x216EE20", Length = "0x68")]
	[Token(Token = "0x60009D0")]
	public virtual void WriteValue(short value) { }

	[Address(RVA = "0x216E620", Offset = "0x216DA20", Length = "0xAF")]
	[Token(Token = "0x60009CF")]
	public virtual void WriteValue(Nullable<SByte> value) { }

	[Address(RVA = "0x216E480", Offset = "0x216D880", Length = "0x6A")]
	[Token(Token = "0x60009CE")]
	public virtual void WriteValue(sbyte value) { }

	[Address(RVA = "0x216EA40", Offset = "0x216DE40", Length = "0x6A")]
	[Token(Token = "0x60009B6")]
	public virtual void WriteValue(bool value) { }

	[Address(RVA = "0x216ED00", Offset = "0x216E100", Length = "0xAF")]
	[Token(Token = "0x60009B7")]
	public virtual void WriteValue(Nullable<Boolean> value) { }

	[Address(RVA = "0x216E4F0", Offset = "0x216D8F0", Length = "0x6A")]
	[Token(Token = "0x60009B8")]
	public virtual void WriteValue(byte value) { }

	[Address(RVA = "0x216F070", Offset = "0x216E470", Length = "0xAF")]
	[Token(Token = "0x60009B9")]
	public virtual void WriteValue(Nullable<Byte> value) { }

	[Address(RVA = "0x216EC90", Offset = "0x216E090", Length = "0x68")]
	[Token(Token = "0x60009BA")]
	public virtual void WriteValue(char value) { }

	[Address(RVA = "0x216F120", Offset = "0x216E520", Length = "0xAB")]
	[Token(Token = "0x60009BB")]
	public virtual void WriteValue(Nullable<Char> value) { }

	[Address(RVA = "0x216F9A0", Offset = "0x216EDA0", Length = "0x7E")]
	[NullableContext(2)]
	[Token(Token = "0x60009BC")]
	public virtual void WriteValue(Byte[] value) { }

	[Address(RVA = "0x216F740", Offset = "0x216EB40", Length = "0x68")]
	[Token(Token = "0x60009BD")]
	public virtual void WriteValue(DateTime value) { }

	[Address(RVA = "0x216E560", Offset = "0x216D960", Length = "0xBE")]
	[Token(Token = "0x60009BE")]
	public virtual void WriteValue(Nullable<DateTime> value) { }

	[Address(RVA = "0x216E880", Offset = "0x216DC80", Length = "0x8A")]
	[Token(Token = "0x60009BF")]
	public virtual void WriteValue(DateTimeOffset value) { }

	[Address(RVA = "0x216E7F0", Offset = "0x216DBF0", Length = "0x8A")]
	[Token(Token = "0x60009B4")]
	public virtual void WriteValue(decimal value) { }

	[Address(RVA = "0x216EBA0", Offset = "0x216DFA0", Length = "0xE3")]
	[Token(Token = "0x60009C0")]
	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	[Address(RVA = "0x216E910", Offset = "0x216DD10", Length = "0x69")]
	[Token(Token = "0x60009C1")]
	public virtual void WriteValue(double value) { }

	[Address(RVA = "0x216EED0", Offset = "0x216E2D0", Length = "0xBF")]
	[Token(Token = "0x60009C2")]
	public virtual void WriteValue(Nullable<Double> value) { }

	[Address(RVA = "0x216F3F0", Offset = "0x216E7F0", Length = "0x69")]
	[Token(Token = "0x60009C5")]
	public virtual void WriteValue(float value) { }

	[Address(RVA = "0x216F870", Offset = "0x216EC70", Length = "0xB0")]
	[Token(Token = "0x60009C6")]
	public virtual void WriteValue(Nullable<Single> value) { }

	[Address(RVA = "0x216F290", Offset = "0x216E690", Length = "0x8A")]
	[Token(Token = "0x60009C7")]
	public virtual void WriteValue(Guid value) { }

	[Address(RVA = "0x216F460", Offset = "0x216E860", Length = "0xDB")]
	[Token(Token = "0x60009C8")]
	public virtual void WriteValue(Nullable<Guid> value) { }

	[Address(RVA = "0x216E780", Offset = "0x216DB80", Length = "0x65")]
	[Token(Token = "0x60009C9")]
	public virtual void WriteValue(int value) { }

	[Address(RVA = "0x216E3D0", Offset = "0x216D7D0", Length = "0xAE")]
	[Token(Token = "0x60009CA")]
	public virtual void WriteValue(Nullable<Int32> value) { }

	[Address(RVA = "0x216F5B0", Offset = "0x216E9B0", Length = "0x68")]
	[Token(Token = "0x60009CB")]
	public virtual void WriteValue(long value) { }

	[Address(RVA = "0x216E980", Offset = "0x216DD80", Length = "0xBE")]
	[Token(Token = "0x60009CC")]
	public virtual void WriteValue(Nullable<Int64> value) { }

	[Address(RVA = "0x216F620", Offset = "0x216EA20", Length = "0x11B")]
	[NullableContext(2)]
	[Token(Token = "0x60009CD")]
	public virtual void WriteValue(object value) { }

	[Address(RVA = "0x216FB40", Offset = "0x216EF40", Length = "0x68")]
	[Token(Token = "0x60009DC")]
	public virtual void WriteWhitespace(string ws) { }

}

