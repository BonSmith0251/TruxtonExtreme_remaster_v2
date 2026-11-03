namespace System.Xml.Schema;

[Token(Token = "0x200025D")]
internal class XmlAnyConverter : XmlBaseConverter
{
	[Token(Token = "0x4000CA5")]
	public static readonly XmlValueConverter Item; //Field offset: 0x0
	[Token(Token = "0x4000CA6")]
	public static readonly XmlValueConverter AnyAtomic; //Field offset: 0x8

	[Address(RVA = "0x24B34B0", Offset = "0x24B28B0", Length = "0x11A")]
	[Token(Token = "0x6001876")]
	private static XmlAnyConverter() { }

	[Address(RVA = "0x24B35D0", Offset = "0x24B29D0", Length = "0x57")]
	[Token(Token = "0x6001862")]
	protected XmlAnyConverter(XmlTypeCode typeCode) { }

	[Address(RVA = "0x24AFAC0", Offset = "0x24AEEC0", Length = "0x203")]
	[Token(Token = "0x600186D")]
	public virtual object ChangeType(decimal value, Type destinationType) { }

	[Address(RVA = "0x24B06D0", Offset = "0x24AFAD0", Length = "0x1B80")]
	[Token(Token = "0x6001872")]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24AFEC0", Offset = "0x24AF2C0", Length = "0x221")]
	[Token(Token = "0x6001871")]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24AFCD0", Offset = "0x24AF0D0", Length = "0x1E4")]
	[Token(Token = "0x6001870")]
	public virtual object ChangeType(long value, Type destinationType) { }

	[Address(RVA = "0x24B04E0", Offset = "0x24AF8E0", Length = "0x1E2")]
	[Token(Token = "0x600186F")]
	public virtual object ChangeType(int value, Type destinationType) { }

	[Address(RVA = "0x24B2260", Offset = "0x24B1660", Length = "0x1E5")]
	[Token(Token = "0x600186E")]
	public virtual object ChangeType(double value, Type destinationType) { }

	[Address(RVA = "0x24B00F0", Offset = "0x24AF4F0", Length = "0x1E5")]
	[Token(Token = "0x600186B")]
	public virtual object ChangeType(bool value, Type destinationType) { }

	[Address(RVA = "0x24B02E0", Offset = "0x24AF6E0", Length = "0x1F0")]
	[Token(Token = "0x600186C")]
	public virtual object ChangeType(DateTime value, Type destinationType) { }

	[Address(RVA = "0x24AF800", Offset = "0x24AEC00", Length = "0x141")]
	[Token(Token = "0x6001873")]
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24AF950", Offset = "0x24AED50", Length = "0x16F")]
	[Token(Token = "0x6001874")]
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B2450", Offset = "0x24B1850", Length = "0x1C6")]
	[Token(Token = "0x6001863")]
	public virtual bool ToBoolean(object value) { }

	[Address(RVA = "0x24B2860", Offset = "0x24B1C60", Length = "0x1D2")]
	[Token(Token = "0x6001864")]
	public virtual DateTime ToDateTime(object value) { }

	[Address(RVA = "0x24B2620", Offset = "0x24B1A20", Length = "0x23E")]
	[Token(Token = "0x6001865")]
	public virtual DateTimeOffset ToDateTimeOffset(object value) { }

	[Address(RVA = "0x24B2A40", Offset = "0x24B1E40", Length = "0x238")]
	[Token(Token = "0x6001866")]
	public virtual decimal ToDecimal(object value) { }

	[Address(RVA = "0x24B2C80", Offset = "0x24B2080", Length = "0x1C7")]
	[Token(Token = "0x6001867")]
	public virtual double ToDouble(object value) { }

	[Address(RVA = "0x24B2E50", Offset = "0x24B2250", Length = "0x1C2")]
	[Token(Token = "0x6001868")]
	public virtual int ToInt32(object value) { }

	[Address(RVA = "0x24B3020", Offset = "0x24B2420", Length = "0x1C3")]
	[Token(Token = "0x6001869")]
	public virtual long ToInt64(object value) { }

	[Address(RVA = "0x24B31F0", Offset = "0x24B25F0", Length = "0x94")]
	[Token(Token = "0x6001875")]
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	[Address(RVA = "0x24B3290", Offset = "0x24B2690", Length = "0x21A")]
	[Token(Token = "0x600186A")]
	public virtual float ToSingle(object value) { }

}

