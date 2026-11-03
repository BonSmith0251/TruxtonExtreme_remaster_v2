namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200011E")]
internal class JsonFormatterConverter : IFormatterConverter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000554")]
	private readonly JsonSerializerInternalReader _reader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000555")]
	private readonly JsonISerializableContract _contract; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Nullable(2)]
	[Token(Token = "0x4000556")]
	private readonly JsonProperty _member; //Field offset: 0x20

	[Address(RVA = "0x2143230", Offset = "0x2142630", Length = "0x137")]
	[Token(Token = "0x600082E")]
	public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	[Address(RVA = "0x2142BF0", Offset = "0x2141FF0", Length = "0x160")]
	[Token(Token = "0x6000830")]
	public override object Convert(object value, Type type) { }

	[Address(RVA = "0x2142AC0", Offset = "0x2141EC0", Length = "0x123")]
	[Token(Token = "0x6000831")]
	public override object Convert(object value, TypeCode typeCode) { }

	[Address(RVA = "0x84E630", Offset = "0x84DA30", Length = "0x185")]
	[Token(Token = "0x600082F")]
	private T GetTokenValue(object value) { }

	[Address(RVA = "0x2142D60", Offset = "0x2142160", Length = "0x48")]
	[Token(Token = "0x6000832")]
	public override bool ToBoolean(object value) { }

	[Address(RVA = "0x2142DB0", Offset = "0x21421B0", Length = "0x48")]
	[Token(Token = "0x6000833")]
	public override byte ToByte(object value) { }

	[Address(RVA = "0x2142E00", Offset = "0x2142200", Length = "0x48")]
	[Token(Token = "0x6000834")]
	public override char ToChar(object value) { }

	[Address(RVA = "0x2142E50", Offset = "0x2142250", Length = "0x48")]
	[Token(Token = "0x6000835")]
	public override DateTime ToDateTime(object value) { }

	[Address(RVA = "0x2142EA0", Offset = "0x21422A0", Length = "0x66")]
	[Token(Token = "0x6000836")]
	public override decimal ToDecimal(object value) { }

	[Address(RVA = "0x2142F10", Offset = "0x2142310", Length = "0x48")]
	[Token(Token = "0x6000837")]
	public override double ToDouble(object value) { }

	[Address(RVA = "0x2142F60", Offset = "0x2142360", Length = "0x48")]
	[Token(Token = "0x6000838")]
	public override short ToInt16(object value) { }

	[Address(RVA = "0x2142FB0", Offset = "0x21423B0", Length = "0x48")]
	[Token(Token = "0x6000839")]
	public override int ToInt32(object value) { }

	[Address(RVA = "0x2143000", Offset = "0x2142400", Length = "0x48")]
	[Token(Token = "0x600083A")]
	public override long ToInt64(object value) { }

	[Address(RVA = "0x2143050", Offset = "0x2142450", Length = "0x48")]
	[Token(Token = "0x600083B")]
	public override sbyte ToSByte(object value) { }

	[Address(RVA = "0x21430A0", Offset = "0x21424A0", Length = "0x48")]
	[Token(Token = "0x600083C")]
	public override float ToSingle(object value) { }

	[Address(RVA = "0x21430F0", Offset = "0x21424F0", Length = "0x48")]
	[Token(Token = "0x600083D")]
	public override string ToString(object value) { }

	[Address(RVA = "0x2143140", Offset = "0x2142540", Length = "0x48")]
	[Token(Token = "0x600083E")]
	public override ushort ToUInt16(object value) { }

	[Address(RVA = "0x2143190", Offset = "0x2142590", Length = "0x48")]
	[Token(Token = "0x600083F")]
	public override uint ToUInt32(object value) { }

	[Address(RVA = "0x21431E0", Offset = "0x21425E0", Length = "0x48")]
	[Token(Token = "0x6000840")]
	public override ulong ToUInt64(object value) { }

}

