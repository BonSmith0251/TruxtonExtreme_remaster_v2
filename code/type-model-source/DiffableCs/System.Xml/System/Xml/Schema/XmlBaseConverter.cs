namespace System.Xml.Schema;

[Token(Token = "0x2000255")]
internal abstract class XmlBaseConverter : XmlValueConverter
{
	[Token(Token = "0x4000C85")]
	protected static readonly Type ICollectionType; //Field offset: 0x0
	[Token(Token = "0x4000C86")]
	protected static readonly Type IEnumerableType; //Field offset: 0x8
	[Token(Token = "0x4000C87")]
	protected static readonly Type IListType; //Field offset: 0x10
	[Token(Token = "0x4000C88")]
	protected static readonly Type ObjectArrayType; //Field offset: 0x18
	[Token(Token = "0x4000C89")]
	protected static readonly Type StringArrayType; //Field offset: 0x20
	[Token(Token = "0x4000C8A")]
	protected static readonly Type XmlAtomicValueArrayType; //Field offset: 0x28
	[Token(Token = "0x4000C8B")]
	protected static readonly Type DecimalType; //Field offset: 0x30
	[Token(Token = "0x4000C8C")]
	protected static readonly Type Int32Type; //Field offset: 0x38
	[Token(Token = "0x4000C8D")]
	protected static readonly Type Int64Type; //Field offset: 0x40
	[Token(Token = "0x4000C8E")]
	protected static readonly Type StringType; //Field offset: 0x48
	[Token(Token = "0x4000C8F")]
	protected static readonly Type XmlAtomicValueType; //Field offset: 0x50
	[Token(Token = "0x4000C90")]
	protected static readonly Type ObjectType; //Field offset: 0x58
	[Token(Token = "0x4000C91")]
	protected static readonly Type ByteType; //Field offset: 0x60
	[Token(Token = "0x4000C92")]
	protected static readonly Type Int16Type; //Field offset: 0x68
	[Token(Token = "0x4000C93")]
	protected static readonly Type SByteType; //Field offset: 0x70
	[Token(Token = "0x4000C94")]
	protected static readonly Type UInt16Type; //Field offset: 0x78
	[Token(Token = "0x4000C95")]
	protected static readonly Type UInt32Type; //Field offset: 0x80
	[Token(Token = "0x4000C96")]
	protected static readonly Type UInt64Type; //Field offset: 0x88
	[Token(Token = "0x4000C97")]
	protected static readonly Type XPathItemType; //Field offset: 0x90
	[Token(Token = "0x4000C98")]
	protected static readonly Type DoubleType; //Field offset: 0x98
	[Token(Token = "0x4000C99")]
	protected static readonly Type SingleType; //Field offset: 0xA0
	[Token(Token = "0x4000C9A")]
	protected static readonly Type DateTimeType; //Field offset: 0xA8
	[Token(Token = "0x4000C9B")]
	protected static readonly Type DateTimeOffsetType; //Field offset: 0xB0
	[Token(Token = "0x4000C9C")]
	protected static readonly Type BooleanType; //Field offset: 0xB8
	[Token(Token = "0x4000C9D")]
	protected static readonly Type ByteArrayType; //Field offset: 0xC0
	[Token(Token = "0x4000C9E")]
	protected static readonly Type XmlQualifiedNameType; //Field offset: 0xC8
	[Token(Token = "0x4000C9F")]
	protected static readonly Type UriType; //Field offset: 0xD0
	[Token(Token = "0x4000CA0")]
	protected static readonly Type TimeSpanType; //Field offset: 0xD8
	[Token(Token = "0x4000CA1")]
	protected static readonly Type XPathNavigatorType; //Field offset: 0xE0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C82")]
	private XmlSchemaType schemaType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C83")]
	private XmlTypeCode typeCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C84")]
	private Type clrTypeDefault; //Field offset: 0x20

	[Token(Token = "0x17000679")]
	protected Type DefaultClrType
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60017B7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000676")]
	protected XmlSchemaType SchemaType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60017B4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000677")]
	protected XmlTypeCode TypeCode
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60017B5")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000678")]
	protected string XmlTypeName
	{
		[Address(RVA = "0x2497F70", Offset = "0x2497370", Length = "0x202")]
		[Token(Token = "0x60017B6")]
		 get { } //Length: 514
	}

	[Address(RVA = "0x24973B0", Offset = "0x24967B0", Length = "0x80F")]
	[Token(Token = "0x60017F4")]
	private static XmlBaseConverter() { }

	[Address(RVA = "0x2497BC0", Offset = "0x2496FC0", Length = "0x5F")]
	[Token(Token = "0x600177A")]
	protected XmlBaseConverter(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	[Address(RVA = "0x2497D10", Offset = "0x2497110", Length = "0x1E9")]
	[Token(Token = "0x6001777")]
	protected XmlBaseConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x2497C20", Offset = "0x2497020", Length = "0xE7")]
	[Token(Token = "0x6001778")]
	protected XmlBaseConverter(XmlTypeCode typeCode) { }

	[Address(RVA = "0x2497F00", Offset = "0x2497300", Length = "0x6F")]
	[Token(Token = "0x6001779")]
	protected XmlBaseConverter(XmlBaseConverter converterAtomic) { }

	[Address(RVA = "0x2491C60", Offset = "0x2491060", Length = "0x19")]
	[Token(Token = "0x60017D2")]
	protected static string AnyUriToString(Uri value) { }

	[Address(RVA = "0x2491C80", Offset = "0x2491080", Length = "0x49")]
	[Token(Token = "0x60017D3")]
	protected static string Base64BinaryToString(Byte[] value) { }

	[Address(RVA = "0x2491CD0", Offset = "0x24910D0", Length = "0x55")]
	[Token(Token = "0x60017BB")]
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x2491D80", Offset = "0x2491180", Length = "0x82")]
	[Token(Token = "0x60017AE")]
	public virtual object ChangeType(decimal value, Type destinationType) { }

	[Address(RVA = "0x2491F30", Offset = "0x2491330", Length = "0x57")]
	[Token(Token = "0x60017AF")]
	public virtual object ChangeType(double value, Type destinationType) { }

	[Address(RVA = "0x2491E10", Offset = "0x2491210", Length = "0x55")]
	[Token(Token = "0x60017B0")]
	public virtual object ChangeType(int value, Type destinationType) { }

	[Address(RVA = "0x2491ED0", Offset = "0x24912D0", Length = "0x56")]
	[Token(Token = "0x60017B1")]
	public virtual object ChangeType(long value, Type destinationType) { }

	[Address(RVA = "0x2491D60", Offset = "0x2491160", Length = "0x19")]
	[Token(Token = "0x60017B2")]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x2491D30", Offset = "0x2491130", Length = "0x25")]
	[Token(Token = "0x60017B3")]
	public virtual object ChangeType(object value, Type destinationType) { }

	[Address(RVA = "0x2491F90", Offset = "0x2491390", Length = "0x7F")]
	[Token(Token = "0x60017AD")]
	public virtual object ChangeType(DateTime value, Type destinationType) { }

	[Address(RVA = "0x2491E70", Offset = "0x2491270", Length = "0x55")]
	[Token(Token = "0x60017AC")]
	public virtual object ChangeType(bool value, Type destinationType) { }

	[Address(RVA = "0x2492010", Offset = "0x2491410", Length = "0x2FB")]
	[Token(Token = "0x60017B9")]
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	[Address(RVA = "0x2492310", Offset = "0x2491710", Length = "0x87")]
	[Token(Token = "0x60017DD")]
	protected static string DateOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x24923A0", Offset = "0x24917A0", Length = "0x4A")]
	[Token(Token = "0x60017E8")]
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	[Address(RVA = "0x24923F0", Offset = "0x24917F0", Length = "0x87")]
	[Token(Token = "0x60017DE")]
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x2492480", Offset = "0x2491880", Length = "0x7D")]
	[Token(Token = "0x60017D5")]
	protected static string DateTimeToString(DateTime value) { }

	[Address(RVA = "0x2492500", Offset = "0x2491900", Length = "0x7D")]
	[Token(Token = "0x60017D4")]
	protected static string DateToString(DateTime value) { }

	[Address(RVA = "0x2492580", Offset = "0x2491980", Length = "0x70")]
	[Token(Token = "0x60017D6")]
	protected static string DayTimeDurationToString(TimeSpan value) { }

	[Address(RVA = "0x24925F0", Offset = "0x24919F0", Length = "0x1EB")]
	[Token(Token = "0x60017E9")]
	internal static int DecimalToInt32(decimal value) { }

	[Address(RVA = "0x24927E0", Offset = "0x2491BE0", Length = "0x1F5")]
	[Token(Token = "0x60017EA")]
	protected static long DecimalToInt64(decimal value) { }

	[Address(RVA = "0x24929E0", Offset = "0x2491DE0", Length = "0x1E1")]
	[Token(Token = "0x60017EB")]
	protected static ulong DecimalToUInt64(decimal value) { }

	[Address(RVA = "0x2492BD0", Offset = "0x2491FD0", Length = "0x6A")]
	[Token(Token = "0x60017D7")]
	protected static string DurationToString(TimeSpan value) { }

	[Address(RVA = "0x2492C40", Offset = "0x2492040", Length = "0x87")]
	[Token(Token = "0x60017DF")]
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x2492CD0", Offset = "0x24920D0", Length = "0x7D")]
	[Token(Token = "0x60017D8")]
	protected static string GDayToString(DateTime value) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60017B7")]
	protected Type get_DefaultClrType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60017B4")]
	protected XmlSchemaType get_SchemaType() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60017B5")]
	protected XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x2497F70", Offset = "0x2497370", Length = "0x202")]
	[Token(Token = "0x60017B6")]
	protected string get_XmlTypeName() { }

	[Address(RVA = "0x2492D50", Offset = "0x2492150", Length = "0x87")]
	[Token(Token = "0x60017E1")]
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x2492DE0", Offset = "0x24921E0", Length = "0x7D")]
	[Token(Token = "0x60017DA")]
	protected static string GMonthDayToString(DateTime value) { }

	[Address(RVA = "0x2492E60", Offset = "0x2492260", Length = "0x87")]
	[Token(Token = "0x60017E0")]
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x2492EF0", Offset = "0x24922F0", Length = "0x7D")]
	[Token(Token = "0x60017D9")]
	protected static string GMonthToString(DateTime value) { }

	[Address(RVA = "0x2492F70", Offset = "0x2492370", Length = "0x87")]
	[Token(Token = "0x60017E3")]
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x2493000", Offset = "0x2492400", Length = "0x7D")]
	[Token(Token = "0x60017DC")]
	protected static string GYearMonthToString(DateTime value) { }

	[Address(RVA = "0x2493080", Offset = "0x2492480", Length = "0x87")]
	[Token(Token = "0x60017E2")]
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x2493110", Offset = "0x2492510", Length = "0x7D")]
	[Token(Token = "0x60017DB")]
	protected static string GYearToString(DateTime value) { }

	[Address(RVA = "0x2493190", Offset = "0x2492590", Length = "0xF1")]
	[Token(Token = "0x60017EC")]
	protected static byte Int32ToByte(int value) { }

	[Address(RVA = "0x2493290", Offset = "0x2492690", Length = "0xF6")]
	[Token(Token = "0x60017ED")]
	protected static short Int32ToInt16(int value) { }

	[Address(RVA = "0x2493390", Offset = "0x2492790", Length = "0xF6")]
	[Token(Token = "0x60017EE")]
	protected static sbyte Int32ToSByte(int value) { }

	[Address(RVA = "0x2493490", Offset = "0x2492890", Length = "0xF1")]
	[Token(Token = "0x60017EF")]
	protected static ushort Int32ToUInt16(int value) { }

	[Address(RVA = "0x2493590", Offset = "0x2492990", Length = "0xFC")]
	[Token(Token = "0x60017F0")]
	protected static int Int64ToInt32(long value) { }

	[Address(RVA = "0x2493690", Offset = "0x2492A90", Length = "0xF4")]
	[Token(Token = "0x60017F1")]
	protected static uint Int64ToUInt32(long value) { }

	[Address(RVA = "0x2493790", Offset = "0x2492B90", Length = "0x9C")]
	[Token(Token = "0x60017B8")]
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	[Address(RVA = "0x2493950", Offset = "0x2492D50", Length = "0x1D6")]
	[Token(Token = "0x60017E4")]
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x2493830", Offset = "0x2492C30", Length = "0x114")]
	[Token(Token = "0x60017BA")]
	protected static string QNameToString(XmlQualifiedName name) { }

	[Address(RVA = "0x2493B30", Offset = "0x2492F30", Length = "0x77")]
	[Token(Token = "0x60017BC")]
	protected static Byte[] StringToBase64Binary(string value) { }

	[Address(RVA = "0x2493D50", Offset = "0x2493150", Length = "0x75")]
	[Token(Token = "0x60017BD")]
	protected static DateTime StringToDate(string value) { }

	[Address(RVA = "0x2493BB0", Offset = "0x2492FB0", Length = "0x90")]
	[Token(Token = "0x60017C6")]
	protected static DateTimeOffset StringToDateOffset(string value) { }

	[Address(RVA = "0x2493CD0", Offset = "0x24930D0", Length = "0x75")]
	[Token(Token = "0x60017BE")]
	protected static DateTime StringToDateTime(string value) { }

	[Address(RVA = "0x2493C40", Offset = "0x2493040", Length = "0x90")]
	[Token(Token = "0x60017C7")]
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	[Address(RVA = "0x2493DD0", Offset = "0x24931D0", Length = "0x70")]
	[Token(Token = "0x60017BF")]
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	[Address(RVA = "0x2493E40", Offset = "0x2493240", Length = "0x6A")]
	[Token(Token = "0x60017C0")]
	protected static TimeSpan StringToDuration(string value) { }

	[Address(RVA = "0x2493F40", Offset = "0x2493340", Length = "0x75")]
	[Token(Token = "0x60017C1")]
	protected static DateTime StringToGDay(string value) { }

	[Address(RVA = "0x2493EB0", Offset = "0x24932B0", Length = "0x90")]
	[Token(Token = "0x60017C8")]
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	[Address(RVA = "0x2494160", Offset = "0x2493560", Length = "0x75")]
	[Token(Token = "0x60017C2")]
	protected static DateTime StringToGMonth(string value) { }

	[Address(RVA = "0x2494050", Offset = "0x2493450", Length = "0x75")]
	[Token(Token = "0x60017C3")]
	protected static DateTime StringToGMonthDay(string value) { }

	[Address(RVA = "0x2493FC0", Offset = "0x24933C0", Length = "0x90")]
	[Token(Token = "0x60017CA")]
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	[Address(RVA = "0x24940D0", Offset = "0x24934D0", Length = "0x90")]
	[Token(Token = "0x60017C9")]
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	[Address(RVA = "0x2494380", Offset = "0x2493780", Length = "0x75")]
	[Token(Token = "0x60017C4")]
	protected static DateTime StringToGYear(string value) { }

	[Address(RVA = "0x2494270", Offset = "0x2493670", Length = "0x75")]
	[Token(Token = "0x60017C5")]
	protected static DateTime StringToGYearMonth(string value) { }

	[Address(RVA = "0x24941E0", Offset = "0x24935E0", Length = "0x90")]
	[Token(Token = "0x60017CC")]
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	[Address(RVA = "0x24942F0", Offset = "0x24936F0", Length = "0x90")]
	[Token(Token = "0x60017CB")]
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	[Address(RVA = "0x2494400", Offset = "0x2493800", Length = "0xCA")]
	[Token(Token = "0x60017CD")]
	protected static Byte[] StringToHexBinary(string value) { }

	[Address(RVA = "0x24944D0", Offset = "0x24938D0", Length = "0x2DF")]
	[Token(Token = "0x60017CE")]
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x2494840", Offset = "0x2493C40", Length = "0x75")]
	[Token(Token = "0x60017CF")]
	protected static DateTime StringToTime(string value) { }

	[Address(RVA = "0x24947B0", Offset = "0x2493BB0", Length = "0x90")]
	[Token(Token = "0x60017D0")]
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	[Address(RVA = "0x24948C0", Offset = "0x2493CC0", Length = "0x70")]
	[Token(Token = "0x60017D1")]
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	[Address(RVA = "0x2494930", Offset = "0x2493D30", Length = "0x87")]
	[Token(Token = "0x60017E6")]
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x24949C0", Offset = "0x2493DC0", Length = "0x7D")]
	[Token(Token = "0x60017E5")]
	protected static string TimeToString(DateTime value) { }

	[Address(RVA = "0x2494DA0", Offset = "0x24941A0", Length = "0xB9")]
	[Token(Token = "0x6001780")]
	public virtual bool ToBoolean(object value) { }

	[Address(RVA = "0x2494E60", Offset = "0x2494260", Length = "0xD2")]
	[Token(Token = "0x600177E")]
	public virtual bool ToBoolean(long value) { }

	[Address(RVA = "0x2494A40", Offset = "0x2493E40", Length = "0xD0")]
	[Token(Token = "0x600177D")]
	public virtual bool ToBoolean(int value) { }

	[Address(RVA = "0x2494BE0", Offset = "0x2493FE0", Length = "0xDD")]
	[Token(Token = "0x600177C")]
	public virtual bool ToBoolean(double value) { }

	[Address(RVA = "0x2494CC0", Offset = "0x24940C0", Length = "0xDE")]
	[Token(Token = "0x600177B")]
	public virtual bool ToBoolean(DateTime value) { }

	[Address(RVA = "0x2494B20", Offset = "0x2493F20", Length = "0xB9")]
	[Token(Token = "0x600177F")]
	public virtual bool ToBoolean(string value) { }

	[Address(RVA = "0x24953D0", Offset = "0x24947D0", Length = "0xC5")]
	[Token(Token = "0x6001787")]
	public virtual DateTime ToDateTime(object value) { }

	[Address(RVA = "0x2495730", Offset = "0x2494B30", Length = "0xED")]
	[Token(Token = "0x6001782")]
	public virtual DateTime ToDateTime(DateTimeOffset value) { }

	[Address(RVA = "0x24954A0", Offset = "0x24948A0", Length = "0xDC")]
	[Token(Token = "0x6001784")]
	public virtual DateTime ToDateTime(int value) { }

	[Address(RVA = "0x2495200", Offset = "0x2494600", Length = "0xE9")]
	[Token(Token = "0x6001783")]
	public virtual DateTime ToDateTime(double value) { }

	[Address(RVA = "0x2495580", Offset = "0x2494980", Length = "0xDD")]
	[Token(Token = "0x6001781")]
	public virtual DateTime ToDateTime(bool value) { }

	[Address(RVA = "0x2495660", Offset = "0x2494A60", Length = "0xC5")]
	[Token(Token = "0x6001786")]
	public virtual DateTime ToDateTime(string value) { }

	[Address(RVA = "0x24952F0", Offset = "0x24946F0", Length = "0xDE")]
	[Token(Token = "0x6001785")]
	public virtual DateTime ToDateTime(long value) { }

	[Address(RVA = "0x2495020", Offset = "0x2494420", Length = "0xFD")]
	[Token(Token = "0x6001788")]
	public virtual DateTimeOffset ToDateTimeOffset(DateTime value) { }

	[Address(RVA = "0x2494F40", Offset = "0x2494340", Length = "0xD8")]
	[Token(Token = "0x6001789")]
	public virtual DateTimeOffset ToDateTimeOffset(string value) { }

	[Address(RVA = "0x2495120", Offset = "0x2494520", Length = "0xD8")]
	[Token(Token = "0x600178A")]
	public virtual DateTimeOffset ToDateTimeOffset(object value) { }

	[Address(RVA = "0x2495900", Offset = "0x2494D00", Length = "0xD5")]
	[Token(Token = "0x600178B")]
	public virtual decimal ToDecimal(string value) { }

	[Address(RVA = "0x2495820", Offset = "0x2494C20", Length = "0xD5")]
	[Token(Token = "0x600178C")]
	public virtual decimal ToDecimal(object value) { }

	[Address(RVA = "0x2495E00", Offset = "0x2495200", Length = "0xD3")]
	[Token(Token = "0x6001790")]
	public virtual double ToDouble(long value) { }

	[Address(RVA = "0x24959E0", Offset = "0x2494DE0", Length = "0xBA")]
	[Token(Token = "0x6001792")]
	public virtual double ToDouble(object value) { }

	[Address(RVA = "0x2495D20", Offset = "0x2495120", Length = "0xD1")]
	[Token(Token = "0x600178F")]
	public virtual double ToDouble(int value) { }

	[Address(RVA = "0x2495AA0", Offset = "0x2494EA0", Length = "0xDF")]
	[Token(Token = "0x600178E")]
	public virtual double ToDouble(DateTime value) { }

	[Address(RVA = "0x2495B80", Offset = "0x2494F80", Length = "0xD2")]
	[Token(Token = "0x600178D")]
	public virtual double ToDouble(bool value) { }

	[Address(RVA = "0x2495C60", Offset = "0x2495060", Length = "0xBA")]
	[Token(Token = "0x6001791")]
	public virtual double ToDouble(string value) { }

	[Address(RVA = "0x24962F0", Offset = "0x24956F0", Length = "0xCD")]
	[Token(Token = "0x6001793")]
	public virtual int ToInt32(bool value) { }

	[Address(RVA = "0x2496210", Offset = "0x2495610", Length = "0xD9")]
	[Token(Token = "0x6001795")]
	public virtual int ToInt32(double value) { }

	[Address(RVA = "0x2495FA0", Offset = "0x24953A0", Length = "0xDA")]
	[Token(Token = "0x6001794")]
	public virtual int ToInt32(DateTime value) { }

	[Address(RVA = "0x2496080", Offset = "0x2495480", Length = "0xB5")]
	[Token(Token = "0x6001798")]
	public virtual int ToInt32(object value) { }

	[Address(RVA = "0x2495EE0", Offset = "0x24952E0", Length = "0xB5")]
	[Token(Token = "0x6001797")]
	public virtual int ToInt32(string value) { }

	[Address(RVA = "0x2496140", Offset = "0x2495540", Length = "0xCE")]
	[Token(Token = "0x6001796")]
	public virtual int ToInt32(long value) { }

	[Address(RVA = "0x2496490", Offset = "0x2495890", Length = "0xDB")]
	[Token(Token = "0x600179A")]
	public virtual long ToInt64(DateTime value) { }

	[Address(RVA = "0x24967D0", Offset = "0x2495BD0", Length = "0xCE")]
	[Token(Token = "0x6001799")]
	public virtual long ToInt64(bool value) { }

	[Address(RVA = "0x2496630", Offset = "0x2495A30", Length = "0xDA")]
	[Token(Token = "0x600179B")]
	public virtual long ToInt64(double value) { }

	[Address(RVA = "0x24963C0", Offset = "0x24957C0", Length = "0xCD")]
	[Token(Token = "0x600179C")]
	public virtual long ToInt64(int value) { }

	[Address(RVA = "0x2496570", Offset = "0x2495970", Length = "0xB6")]
	[Token(Token = "0x600179D")]
	public virtual long ToInt64(string value) { }

	[Address(RVA = "0x2496710", Offset = "0x2495B10", Length = "0xB6")]
	[Token(Token = "0x600179E")]
	public virtual long ToInt64(object value) { }

	[Address(RVA = "0x2496960", Offset = "0x2495D60", Length = "0xDE")]
	[Token(Token = "0x600179F")]
	public virtual float ToSingle(double value) { }

	[Address(RVA = "0x24968A0", Offset = "0x2495CA0", Length = "0xBA")]
	[Token(Token = "0x60017A0")]
	public virtual float ToSingle(string value) { }

	[Address(RVA = "0x2496A40", Offset = "0x2495E40", Length = "0xBA")]
	[Token(Token = "0x60017A1")]
	public virtual float ToSingle(object value) { }

	[Address(RVA = "0x2496B00", Offset = "0x2495F00", Length = "0xBD")]
	[Token(Token = "0x60017A7")]
	public virtual string ToString(int value) { }

	[Address(RVA = "0x2497090", Offset = "0x2496490", Length = "0xBF")]
	[Token(Token = "0x60017A8")]
	public virtual string ToString(long value) { }

	[Address(RVA = "0x2496FC0", Offset = "0x24963C0", Length = "0xCA")]
	[Token(Token = "0x60017A9")]
	public virtual string ToString(float value) { }

	[Address(RVA = "0x2496C90", Offset = "0x2496090", Length = "0xB3")]
	[Token(Token = "0x60017AA")]
	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x2496BC0", Offset = "0x2495FC0", Length = "0xCE")]
	[Token(Token = "0x60017A4")]
	public virtual string ToString(DateTimeOffset value) { }

	[Address(RVA = "0x2496E20", Offset = "0x2496220", Length = "0xCB")]
	[Token(Token = "0x60017A3")]
	public virtual string ToString(DateTime value) { }

	[Address(RVA = "0x2497170", Offset = "0x2496570", Length = "0xBE")]
	[Token(Token = "0x60017A2")]
	public virtual string ToString(bool value) { }

	[Address(RVA = "0x2497150", Offset = "0x2496550", Length = "0x17")]
	[Token(Token = "0x60017AB")]
	public virtual string ToString(object value) { }

	[Address(RVA = "0x2496D50", Offset = "0x2496150", Length = "0xCE")]
	[Token(Token = "0x60017A5")]
	public virtual string ToString(decimal value) { }

	[Address(RVA = "0x2496EF0", Offset = "0x24962F0", Length = "0xCA")]
	[Token(Token = "0x60017A6")]
	public virtual string ToString(double value) { }

	[Address(RVA = "0x24972C0", Offset = "0x24966C0", Length = "0x75")]
	[Token(Token = "0x60017F2")]
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	[Address(RVA = "0x2497230", Offset = "0x2496630", Length = "0x90")]
	[Token(Token = "0x60017F3")]
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	[Address(RVA = "0x2497340", Offset = "0x2496740", Length = "0x70")]
	[Token(Token = "0x60017E7")]
	protected static string YearMonthDurationToString(TimeSpan value) { }

}

