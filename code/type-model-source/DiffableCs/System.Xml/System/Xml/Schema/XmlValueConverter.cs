namespace System.Xml.Schema;

[Token(Token = "0x2000254")]
internal abstract class XmlValueConverter
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001776")]
	protected XmlValueConverter() { }

	[Token(Token = "0x6001774")]
	public abstract object ChangeType(object value, Type destinationType) { }

	[Token(Token = "0x6001773")]
	public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Token(Token = "0x6001772")]
	public abstract object ChangeType(DateTime value, Type destinationType) { }

	[Token(Token = "0x6001771")]
	public abstract object ChangeType(double value, Type destinationType) { }

	[Token(Token = "0x6001770")]
	public abstract object ChangeType(decimal value, Type destinationType) { }

	[Token(Token = "0x600176F")]
	public abstract object ChangeType(long value, Type destinationType) { }

	[Token(Token = "0x600176E")]
	public abstract object ChangeType(int value, Type destinationType) { }

	[Token(Token = "0x600176D")]
	public abstract object ChangeType(bool value, Type destinationType) { }

	[Token(Token = "0x6001775")]
	public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Token(Token = "0x600173C")]
	public abstract bool ToBoolean(long value) { }

	[Token(Token = "0x600173D")]
	public abstract bool ToBoolean(int value) { }

	[Token(Token = "0x600173E")]
	public abstract bool ToBoolean(double value) { }

	[Token(Token = "0x600173F")]
	public abstract bool ToBoolean(DateTime value) { }

	[Token(Token = "0x6001740")]
	public abstract bool ToBoolean(string value) { }

	[Token(Token = "0x6001741")]
	public abstract bool ToBoolean(object value) { }

	[Token(Token = "0x600175E")]
	public abstract DateTime ToDateTime(string value) { }

	[Token(Token = "0x600175F")]
	public abstract DateTime ToDateTime(object value) { }

	[Token(Token = "0x600175D")]
	public abstract DateTime ToDateTime(DateTimeOffset value) { }

	[Token(Token = "0x600175C")]
	public abstract DateTime ToDateTime(double value) { }

	[Token(Token = "0x600175B")]
	public abstract DateTime ToDateTime(long value) { }

	[Token(Token = "0x600175A")]
	public abstract DateTime ToDateTime(int value) { }

	[Token(Token = "0x6001759")]
	public abstract DateTime ToDateTime(bool value) { }

	[Token(Token = "0x6001762")]
	public abstract DateTimeOffset ToDateTimeOffset(object value) { }

	[Token(Token = "0x6001761")]
	public abstract DateTimeOffset ToDateTimeOffset(string value) { }

	[Token(Token = "0x6001760")]
	public abstract DateTimeOffset ToDateTimeOffset(DateTime value) { }

	[Token(Token = "0x600174F")]
	public abstract decimal ToDecimal(object value) { }

	[Token(Token = "0x600174E")]
	public abstract decimal ToDecimal(string value) { }

	[Token(Token = "0x6001753")]
	public abstract double ToDouble(DateTime value) { }

	[Token(Token = "0x6001754")]
	public abstract double ToDouble(string value) { }

	[Token(Token = "0x6001755")]
	public abstract double ToDouble(object value) { }

	[Token(Token = "0x6001752")]
	public abstract double ToDouble(long value) { }

	[Token(Token = "0x6001751")]
	public abstract double ToDouble(int value) { }

	[Token(Token = "0x6001750")]
	public abstract double ToDouble(bool value) { }

	[Token(Token = "0x6001742")]
	public abstract int ToInt32(bool value) { }

	[Token(Token = "0x6001743")]
	public abstract int ToInt32(long value) { }

	[Token(Token = "0x6001744")]
	public abstract int ToInt32(double value) { }

	[Token(Token = "0x6001747")]
	public abstract int ToInt32(object value) { }

	[Token(Token = "0x6001746")]
	public abstract int ToInt32(string value) { }

	[Token(Token = "0x6001745")]
	public abstract int ToInt32(DateTime value) { }

	[Token(Token = "0x6001748")]
	public abstract long ToInt64(bool value) { }

	[Token(Token = "0x6001749")]
	public abstract long ToInt64(int value) { }

	[Token(Token = "0x600174A")]
	public abstract long ToInt64(double value) { }

	[Token(Token = "0x600174B")]
	public abstract long ToInt64(DateTime value) { }

	[Token(Token = "0x600174C")]
	public abstract long ToInt64(string value) { }

	[Token(Token = "0x600174D")]
	public abstract long ToInt64(object value) { }

	[Token(Token = "0x6001756")]
	public abstract float ToSingle(double value) { }

	[Token(Token = "0x6001757")]
	public abstract float ToSingle(string value) { }

	[Token(Token = "0x6001758")]
	public abstract float ToSingle(object value) { }

	[Token(Token = "0x600176C")]
	public abstract string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	[Token(Token = "0x600176A")]
	public abstract string ToString(DateTimeOffset value) { }

	[Token(Token = "0x6001769")]
	public abstract string ToString(DateTime value) { }

	[Token(Token = "0x6001768")]
	public abstract string ToString(double value) { }

	[Token(Token = "0x6001767")]
	public abstract string ToString(float value) { }

	[Token(Token = "0x6001766")]
	public abstract string ToString(decimal value) { }

	[Token(Token = "0x6001765")]
	public abstract string ToString(long value) { }

	[Token(Token = "0x6001763")]
	public abstract string ToString(bool value) { }

	[Token(Token = "0x600176B")]
	public abstract string ToString(object value) { }

	[Token(Token = "0x6001764")]
	public abstract string ToString(int value) { }

}

