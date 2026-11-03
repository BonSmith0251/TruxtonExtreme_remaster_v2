namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x200018C")]
public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
{
	[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
	[NullableContext(1)]
	[Token(Token = "0x200018D")]
	private class JValueDynamicProxy : DynamicProxy<JValue>
	{

		[Address(RVA = "0x219D510", Offset = "0x219C910", Length = "0x39")]
		[Token(Token = "0x6000DF2")]
		public JValueDynamicProxy() { }

		[Address(RVA = "0x219D010", Offset = "0x219C410", Length = "0x310")]
		[Token(Token = "0x6000DF1")]
		public virtual bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, out object result) { }

		[Address(RVA = "0x219D350", Offset = "0x219C750", Length = "0x1BF")]
		[Token(Token = "0x6000DF0")]
		public virtual bool TryConvert(JValue instance, ConvertBinder binder, out object result) { }

	}

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000759")]
	private JTokenType _valueType; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400075A")]
	private object _value; //Field offset: 0x38

	[Token(Token = "0x17000231")]
	public virtual bool HasValues
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000DC4")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000232")]
	public virtual JTokenType Type
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000DD0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000233")]
	public object Value
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000DD1")]
		 get { } //Length: 5
		[Address(RVA = "0x21A21B0", Offset = "0x21A15B0", Length = "0xDE")]
		[Token(Token = "0x6000DD2")]
		 set { } //Length: 222
	}

	[Address(RVA = "0x21A1F90", Offset = "0x21A1390", Length = "0xA5")]
	[Token(Token = "0x6000DBF")]
	public JValue(Guid value) { }

	[Address(RVA = "0x21A1BA0", Offset = "0x21A0FA0", Length = "0x7F")]
	[Token(Token = "0x6000DC2")]
	public JValue(object value) { }

	[Address(RVA = "0x21A1AF0", Offset = "0x21A0EF0", Length = "0xA2")]
	[Token(Token = "0x6000DC1")]
	public JValue(TimeSpan value) { }

	[Address(RVA = "0x21A1ED0", Offset = "0x21A12D0", Length = "0xC0")]
	[Token(Token = "0x6000DC0")]
	public JValue(Uri value) { }

	[Address(RVA = "0x21A1E60", Offset = "0x21A1260", Length = "0x6D")]
	[Token(Token = "0x6000DBE")]
	public JValue(string value) { }

	[Address(RVA = "0x21A1840", Offset = "0x21A0C40", Length = "0xAC")]
	[Token(Token = "0x6000DBD")]
	public JValue(bool value) { }

	[Address(RVA = "0x21A2100", Offset = "0x21A1500", Length = "0xA5")]
	[Token(Token = "0x6000DBC")]
	public JValue(DateTimeOffset value) { }

	[Address(RVA = "0x21A1D40", Offset = "0x21A1140", Length = "0x84")]
	[Token(Token = "0x6000DBA")]
	public JValue(float value) { }

	[Address(RVA = "0x21A18F0", Offset = "0x21A0CF0", Length = "0xA2")]
	[Token(Token = "0x6000DBB")]
	public JValue(DateTime value) { }

	[Address(RVA = "0x21A1640", Offset = "0x21A0A40", Length = "0x83")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000DB8")]
	public JValue(ulong value) { }

	[Address(RVA = "0x21A1DD0", Offset = "0x21A11D0", Length = "0x83")]
	[Token(Token = "0x6000DB7")]
	public JValue(char value) { }

	[Address(RVA = "0x21A2040", Offset = "0x21A1440", Length = "0xB5")]
	[Token(Token = "0x6000DB6")]
	public JValue(decimal value) { }

	[Address(RVA = "0x21A16D0", Offset = "0x21A0AD0", Length = "0xAB")]
	[Token(Token = "0x6000DB5")]
	public JValue(long value) { }

	[Address(RVA = "0x21A1A20", Offset = "0x21A0E20", Length = "0xCE")]
	[NullableContext(1)]
	[Token(Token = "0x6000DB4")]
	public JValue(JValue other) { }

	[Address(RVA = "0x21A1C20", Offset = "0x21A1020", Length = "0x118")]
	[NullableContext(1)]
	[Token(Token = "0x6000DB3")]
	internal JValue(JValue other, JsonCloneSettings settings) { }

	[Address(RVA = "0x21A19A0", Offset = "0x21A0DA0", Length = "0x76")]
	[Token(Token = "0x6000DB2")]
	internal JValue(object value, JTokenType type) { }

	[Address(RVA = "0x21A1780", Offset = "0x21A0B80", Length = "0xB5")]
	[Token(Token = "0x6000DB9")]
	public JValue(double value) { }

	[Address(RVA = "0x219D550", Offset = "0x219C950", Length = "0x143")]
	[NullableContext(1)]
	[Token(Token = "0x6000DC9")]
	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	[Address(RVA = "0x219DAE0", Offset = "0x219CEE0", Length = "0x128")]
	[Token(Token = "0x6000DC6")]
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	[Address(RVA = "0x219D6A0", Offset = "0x219CAA0", Length = "0x31A")]
	[NullableContext(1)]
	[Token(Token = "0x6000DC5")]
	private static int CompareBigInteger(BigInteger i1, object i2) { }

	[Address(RVA = "0x219D9C0", Offset = "0x219CDC0", Length = "0xE9")]
	[NullableContext(1)]
	[Token(Token = "0x6000DC7")]
	private static int CompareFloat(object objA, object objB) { }

	[Address(RVA = "0x219DAB0", Offset = "0x219CEB0", Length = "0x2E")]
	[Token(Token = "0x6000DDF")]
	public override int CompareTo(JValue obj) { }

	[Address(RVA = "0x219E6E0", Offset = "0x219DAE0", Length = "0x98")]
	[NullableContext(1)]
	[Token(Token = "0x6000DCA")]
	public static JValue CreateComment(string value) { }

	[Address(RVA = "0x219E780", Offset = "0x219DB80", Length = "0x8F")]
	[NullableContext(1)]
	[Token(Token = "0x6000DCC")]
	public static JValue CreateNull() { }

	[Address(RVA = "0x219E810", Offset = "0x219DC10", Length = "0x98")]
	[NullableContext(1)]
	[Token(Token = "0x6000DCB")]
	public static JValue CreateString(string value) { }

	[Address(RVA = "0x219E8B0", Offset = "0x219DCB0", Length = "0x8F")]
	[NullableContext(1)]
	[Token(Token = "0x6000DCD")]
	public static JValue CreateUndefined() { }

	[Address(RVA = "0x219E940", Offset = "0x219DD40", Length = "0xB0")]
	[NullableContext(1)]
	[Token(Token = "0x6000DC3")]
	internal virtual bool DeepEquals(JToken node) { }

	[Address(RVA = "0x219EA00", Offset = "0x219DE00", Length = "0xB0")]
	[Token(Token = "0x6000DD7")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x219EAC0", Offset = "0x219DEC0", Length = "0x4B")]
	[Token(Token = "0x6000DD6")]
	public override bool Equals(JValue other) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000DC4")]
	public virtual bool get_HasValues() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000DD0")]
	public virtual JTokenType get_Type() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000DD1")]
	public object get_Value() { }

	[Address(RVA = "0x219EB10", Offset = "0x219DF10", Length = "0x52")]
	[Token(Token = "0x6000DD4")]
	internal virtual int GetDeepHashCode() { }

	[Address(RVA = "0x219EB70", Offset = "0x219DF70", Length = "0x22")]
	[Token(Token = "0x6000DD8")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x219EBA0", Offset = "0x219DFA0", Length = "0xCC")]
	[NullableContext(1)]
	[Token(Token = "0x6000DDD")]
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	[Address(RVA = "0x219EC70", Offset = "0x219E070", Length = "0x57")]
	[Token(Token = "0x6000DCF")]
	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	[Address(RVA = "0x219ECD0", Offset = "0x219E0D0", Length = "0x498")]
	[Token(Token = "0x6000DCE")]
	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	[Address(RVA = "0x219F170", Offset = "0x219E570", Length = "0x92C")]
	[Token(Token = "0x6000DC8")]
	private static bool Operation(ExpressionType operation, object objA, object objB, out object result) { }

	[Address(RVA = "0x21A21B0", Offset = "0x21A15B0", Length = "0xDE")]
	[Token(Token = "0x6000DD2")]
	public void set_Value(object value) { }

	[Address(RVA = "0x219FAA0", Offset = "0x219EEA0", Length = "0xB2")]
	[Token(Token = "0x6000DDE")]
	private override int System.IComparable.CompareTo(object obj) { }

	[Address(RVA = "0x219FB60", Offset = "0x219EF60", Length = "0x6A")]
	[Token(Token = "0x6000DE0")]
	private override TypeCode System.IConvertible.GetTypeCode() { }

	[Address(RVA = "0x219FBD0", Offset = "0x219EFD0", Length = "0x49")]
	[Token(Token = "0x6000DE1")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x219FC20", Offset = "0x219F020", Length = "0x49")]
	[Token(Token = "0x6000DE4")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x219FC70", Offset = "0x219F070", Length = "0x49")]
	[Token(Token = "0x6000DE2")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x219FCC0", Offset = "0x219F0C0", Length = "0x49")]
	[Token(Token = "0x6000DEE")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x219FD10", Offset = "0x219F110", Length = "0x65")]
	[Token(Token = "0x6000DED")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x219FD80", Offset = "0x219F180", Length = "0x49")]
	[Token(Token = "0x6000DEC")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x219FDD0", Offset = "0x219F1D0", Length = "0x49")]
	[Token(Token = "0x6000DE5")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x219FE20", Offset = "0x219F220", Length = "0x49")]
	[Token(Token = "0x6000DE7")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x219FE70", Offset = "0x219F270", Length = "0x49")]
	[Token(Token = "0x6000DE9")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x219FEC0", Offset = "0x219F2C0", Length = "0x49")]
	[Token(Token = "0x6000DE3")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x219FF10", Offset = "0x219F310", Length = "0x49")]
	[Token(Token = "0x6000DEB")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x219FF60", Offset = "0x219F360", Length = "0x8")]
	[NullableContext(1)]
	[Token(Token = "0x6000DEF")]
	private override object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }

	[Address(RVA = "0x219FF70", Offset = "0x219F370", Length = "0x49")]
	[Token(Token = "0x6000DE6")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x219FFC0", Offset = "0x219F3C0", Length = "0x49")]
	[Token(Token = "0x6000DE8")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x21A0010", Offset = "0x219F410", Length = "0x49")]
	[Token(Token = "0x6000DEA")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x21A0240", Offset = "0x219F640", Length = "0xD")]
	[NullableContext(1)]
	[Token(Token = "0x6000DDB")]
	public override string ToString(IFormatProvider formatProvider) { }

	[Address(RVA = "0x21A00A0", Offset = "0x219F4A0", Length = "0x63")]
	[NullableContext(1)]
	[Token(Token = "0x6000DDA")]
	public string ToString(string format) { }

	[Address(RVA = "0x21A0060", Offset = "0x219F460", Length = "0x31")]
	[NullableContext(1)]
	[Token(Token = "0x6000DD9")]
	public virtual string ToString() { }

	[Address(RVA = "0x21A0110", Offset = "0x219F510", Length = "0x128")]
	[Token(Token = "0x6000DDC")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x21A0250", Offset = "0x219F650", Length = "0x4B")]
	[NullableContext(1)]
	[Token(Token = "0x6000DD5")]
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	[Address(RVA = "0x21A0CA0", Offset = "0x21A00A0", Length = "0x968")]
	[NullableContext(1)]
	[Token(Token = "0x6000DD3")]
	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[Address(RVA = "0x21A02A0", Offset = "0x219F6A0", Length = "0x9C0")]
	[NullableContext(1)]
	[Token(Token = "0x6000DB1")]
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

