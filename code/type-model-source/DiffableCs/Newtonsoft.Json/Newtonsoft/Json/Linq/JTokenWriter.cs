namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x200018B")]
public class JTokenWriter : JsonWriter
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000755")]
	private JContainer _token; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000756")]
	private JContainer _parent; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000757")]
	private JValue _value; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000758")]
	private JToken _current; //Field offset: 0x78

	[Token(Token = "0x1700022F")]
	public JToken CurrentToken
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6000D88")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000230")]
	public JToken Token
	{
		[Address(RVA = "0x219CFF0", Offset = "0x219C3F0", Length = "0x11")]
		[Token(Token = "0x6000D89")]
		 get { } //Length: 17
	}

	[Address(RVA = "0x219CF50", Offset = "0x219C350", Length = "0x93")]
	[NullableContext(1)]
	[Token(Token = "0x6000D8A")]
	public JTokenWriter(JContainer container) { }

	[Address(RVA = "0x219CF00", Offset = "0x219C300", Length = "0x49")]
	[Token(Token = "0x6000D8B")]
	public JTokenWriter() { }

	[Address(RVA = "0x219B150", Offset = "0x219A550", Length = "0xD1")]
	[Token(Token = "0x6000D96")]
	internal void AddJValue(JValue value, JsonToken token) { }

	[Address(RVA = "0x219B230", Offset = "0x219A630", Length = "0x5C")]
	[NullableContext(1)]
	[Token(Token = "0x6000D8F")]
	private void AddParent(JContainer container) { }

	[Address(RVA = "0x219B290", Offset = "0x219A690", Length = "0xCA")]
	[Token(Token = "0x6000D95")]
	private void AddRawValue(object value, JTokenType type, JsonToken token) { }

	[Address(RVA = "0x219B360", Offset = "0x219A760", Length = "0x7")]
	[Token(Token = "0x6000D8D")]
	public virtual void Close() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000D8C")]
	public virtual void Flush() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6000D88")]
	public JToken get_CurrentToken() { }

	[Address(RVA = "0x219CFF0", Offset = "0x219C3F0", Length = "0x11")]
	[Token(Token = "0x6000D89")]
	public JToken get_Token() { }

	[Address(RVA = "0x219B370", Offset = "0x219A770", Length = "0x81")]
	[Token(Token = "0x6000D90")]
	private void RemoveParent() { }

	[Address(RVA = "0x219B400", Offset = "0x219A800", Length = "0xBD")]
	[Token(Token = "0x6000D9B")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x219B370", Offset = "0x219A770", Length = "0x81")]
	[Token(Token = "0x6000D93")]
	protected virtual void WriteEnd(JsonToken token) { }

	[Address(RVA = "0x219B4C0", Offset = "0x219A8C0", Length = "0x30")]
	[Token(Token = "0x6000D98")]
	public virtual void WriteNull() { }

	[Address(RVA = "0x219B4F0", Offset = "0x219A8F0", Length = "0xFC")]
	[NullableContext(1)]
	[Token(Token = "0x6000D94")]
	public virtual void WritePropertyName(string name) { }

	[Address(RVA = "0x219B5F0", Offset = "0x219A9F0", Length = "0x7F")]
	[Token(Token = "0x6000D9A")]
	public virtual void WriteRaw(string json) { }

	[Address(RVA = "0x219B670", Offset = "0x219AA70", Length = "0x9B")]
	[Token(Token = "0x6000D91")]
	public virtual void WriteStartArray() { }

	[Address(RVA = "0x219B710", Offset = "0x219AB10", Length = "0xB0")]
	[NullableContext(1)]
	[Token(Token = "0x6000D92")]
	public virtual void WriteStartConstructor(string name) { }

	[Address(RVA = "0x219B7C0", Offset = "0x219ABC0", Length = "0x9B")]
	[Token(Token = "0x6000D8E")]
	public virtual void WriteStartObject() { }

	[Address(RVA = "0x219B970", Offset = "0x219AD70", Length = "0x391")]
	[NullableContext(1)]
	[Token(Token = "0x6000DB0")]
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	[Address(RVA = "0x219B860", Offset = "0x219AC60", Length = "0x102")]
	[NullableContext(1)]
	[Token(Token = "0x6000D87")]
	internal virtual Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken) { }

	[Address(RVA = "0x219BD10", Offset = "0x219B110", Length = "0xB2")]
	[Token(Token = "0x6000D99")]
	public virtual void WriteUndefined() { }

	[Address(RVA = "0x219C6B0", Offset = "0x219BAB0", Length = "0x105")]
	[Token(Token = "0x6000DAE")]
	public virtual void WriteValue(Guid value) { }

	[Address(RVA = "0x219C930", Offset = "0x219BD30", Length = "0xF8")]
	[Token(Token = "0x6000DAD")]
	public virtual void WriteValue(TimeSpan value) { }

	[Address(RVA = "0x219C5E0", Offset = "0x219B9E0", Length = "0xC3")]
	[Token(Token = "0x6000DAC")]
	public virtual void WriteValue(Byte[] value) { }

	[Address(RVA = "0x219C7C0", Offset = "0x219BBC0", Length = "0x105")]
	[Token(Token = "0x6000DAB")]
	public virtual void WriteValue(DateTimeOffset value) { }

	[Address(RVA = "0x219CDD0", Offset = "0x219C1D0", Length = "0x12C")]
	[Token(Token = "0x6000DAA")]
	public virtual void WriteValue(DateTime value) { }

	[Address(RVA = "0x219BFC0", Offset = "0x219B3C0", Length = "0x115")]
	[Token(Token = "0x6000DA9")]
	public virtual void WriteValue(decimal value) { }

	[Address(RVA = "0x219BDD0", Offset = "0x219B1D0", Length = "0x58")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000DA8")]
	public virtual void WriteValue(sbyte value) { }

	[Address(RVA = "0x219BE30", Offset = "0x219B230", Length = "0x58")]
	[Token(Token = "0x6000DA7")]
	public virtual void WriteValue(byte value) { }

	[Address(RVA = "0x219CBA0", Offset = "0x219BFA0", Length = "0x11B")]
	[Token(Token = "0x6000DA6")]
	public virtual void WriteValue(char value) { }

	[Address(RVA = "0x219C8D0", Offset = "0x219BCD0", Length = "0x59")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000DA5")]
	public virtual void WriteValue(ushort value) { }

	[Address(RVA = "0x219CA30", Offset = "0x219BE30", Length = "0x101")]
	[Token(Token = "0x6000DA3")]
	public virtual void WriteValue(bool value) { }

	[Address(RVA = "0x219CCC0", Offset = "0x219C0C0", Length = "0x10B")]
	[Token(Token = "0x6000DA2")]
	public virtual void WriteValue(double value) { }

	[Address(RVA = "0x219C0E0", Offset = "0x219B4E0", Length = "0xE7")]
	[Token(Token = "0x6000DA1")]
	public virtual void WriteValue(float value) { }

	[Address(RVA = "0x219C1D0", Offset = "0x219B5D0", Length = "0xDC")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000DA0")]
	public virtual void WriteValue(ulong value) { }

	[Address(RVA = "0x219C4D0", Offset = "0x219B8D0", Length = "0x101")]
	[Token(Token = "0x6000D9F")]
	public virtual void WriteValue(long value) { }

	[Address(RVA = "0x219BF60", Offset = "0x219B360", Length = "0x57")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000D9E")]
	public virtual void WriteValue(uint value) { }

	[Address(RVA = "0x219C470", Offset = "0x219B870", Length = "0x57")]
	[Token(Token = "0x6000D9D")]
	public virtual void WriteValue(int value) { }

	[Address(RVA = "0x219BE90", Offset = "0x219B290", Length = "0xC3")]
	[Token(Token = "0x6000D9C")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x219C2B0", Offset = "0x219B6B0", Length = "0x116")]
	[Token(Token = "0x6000DAF")]
	public virtual void WriteValue(Uri value) { }

	[Address(RVA = "0x219CB40", Offset = "0x219BF40", Length = "0x59")]
	[Token(Token = "0x6000DA4")]
	public virtual void WriteValue(short value) { }

	[Address(RVA = "0x219C3D0", Offset = "0x219B7D0", Length = "0x99")]
	[Token(Token = "0x6000D97")]
	public virtual void WriteValue(object value) { }

}

