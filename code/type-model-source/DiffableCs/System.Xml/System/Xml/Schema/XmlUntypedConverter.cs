namespace System.Xml.Schema;

[Token(Token = "0x200025C")]
internal class XmlUntypedConverter : XmlListConverter
{
	[Token(Token = "0x4000CA3")]
	public static readonly XmlValueConverter Untyped; //Field offset: 0x0
	[Token(Token = "0x4000CA4")]
	public static readonly XmlValueConverter UntypedList; //Field offset: 0x8
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CA2")]
	private bool allowListToList; //Field offset: 0x30

	[Address(RVA = "0x24C8DE0", Offset = "0x24C81E0", Length = "0x187")]
	[Token(Token = "0x6001861")]
	private static XmlUntypedConverter() { }

	[Address(RVA = "0x24C9070", Offset = "0x24C8470", Length = "0xCA")]
	[Token(Token = "0x600183A")]
	protected XmlUntypedConverter() { }

	[Address(RVA = "0x24C8F70", Offset = "0x24C8370", Length = "0xF3")]
	[Token(Token = "0x600183B")]
	protected XmlUntypedConverter(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	[Address(RVA = "0x24C2A20", Offset = "0x24C1E20", Length = "0x354")]
	[Token(Token = "0x600185F")]
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24C3230", Offset = "0x24C2630", Length = "0x1D1")]
	[Token(Token = "0x6001858")]
	public virtual object ChangeType(double value, Type destinationType) { }

	[Address(RVA = "0x24C4380", Offset = "0x24C3780", Length = "0x1D0")]
	[Token(Token = "0x6001856")]
	public virtual object ChangeType(DateTime value, Type destinationType) { }

	[Address(RVA = "0x24C3410", Offset = "0x24C2810", Length = "0x1D1")]
	[Token(Token = "0x6001855")]
	public virtual object ChangeType(bool value, Type destinationType) { }

	[Address(RVA = "0x24C4560", Offset = "0x24C3960", Length = "0x1CD")]
	[Token(Token = "0x6001859")]
	public virtual object ChangeType(int value, Type destinationType) { }

	[Address(RVA = "0x24C3050", Offset = "0x24C2450", Length = "0x1D0")]
	[Token(Token = "0x600185A")]
	public virtual object ChangeType(long value, Type destinationType) { }

	[Address(RVA = "0x24C35F0", Offset = "0x24C29F0", Length = "0xD83")]
	[Token(Token = "0x600185B")]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24C4920", Offset = "0x24C3D20", Length = "0x1963")]
	[Token(Token = "0x600185C")]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24C4730", Offset = "0x24C3B30", Length = "0x1EC")]
	[Token(Token = "0x6001857")]
	public virtual object ChangeType(decimal value, Type destinationType) { }

	[Address(RVA = "0x24C2D80", Offset = "0x24C2180", Length = "0x141")]
	[Token(Token = "0x600185D")]
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24C2ED0", Offset = "0x24C22D0", Length = "0x17B")]
	[Token(Token = "0x600185E")]
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24C6290", Offset = "0x24C5690", Length = "0x654")]
	[Token(Token = "0x6001860")]
	private bool SupportsType(Type clrType) { }

	[Address(RVA = "0x24C6AC0", Offset = "0x24C5EC0", Length = "0x96")]
	[Token(Token = "0x600183C")]
	public virtual bool ToBoolean(string value) { }

	[Address(RVA = "0x24C68F0", Offset = "0x24C5CF0", Length = "0x1C5")]
	[Token(Token = "0x600183D")]
	public virtual bool ToBoolean(object value) { }

	[Address(RVA = "0x24C6EA0", Offset = "0x24C62A0", Length = "0x1C5")]
	[Token(Token = "0x600183F")]
	public virtual DateTime ToDateTime(object value) { }

	[Address(RVA = "0x24C6E00", Offset = "0x24C6200", Length = "0x96")]
	[Token(Token = "0x600183E")]
	public virtual DateTime ToDateTime(string value) { }

	[Address(RVA = "0x24C6B60", Offset = "0x24C5F60", Length = "0x1DF")]
	[Token(Token = "0x6001841")]
	public virtual DateTimeOffset ToDateTimeOffset(object value) { }

	[Address(RVA = "0x24C6D40", Offset = "0x24C6140", Length = "0xB2")]
	[Token(Token = "0x6001840")]
	public virtual DateTimeOffset ToDateTimeOffset(string value) { }

	[Address(RVA = "0x24C7130", Offset = "0x24C6530", Length = "0x1E8")]
	[Token(Token = "0x6001843")]
	public virtual decimal ToDecimal(object value) { }

	[Address(RVA = "0x24C7070", Offset = "0x24C6470", Length = "0xB2")]
	[Token(Token = "0x6001842")]
	public virtual decimal ToDecimal(string value) { }

	[Address(RVA = "0x24C7320", Offset = "0x24C6720", Length = "0x1C6")]
	[Token(Token = "0x6001845")]
	public virtual double ToDouble(object value) { }

	[Address(RVA = "0x24C74F0", Offset = "0x24C68F0", Length = "0x96")]
	[Token(Token = "0x6001844")]
	public virtual double ToDouble(string value) { }

	[Address(RVA = "0x24C7630", Offset = "0x24C6A30", Length = "0x1C1")]
	[Token(Token = "0x6001847")]
	public virtual int ToInt32(object value) { }

	[Address(RVA = "0x24C7590", Offset = "0x24C6990", Length = "0x96")]
	[Token(Token = "0x6001846")]
	public virtual int ToInt32(string value) { }

	[Address(RVA = "0x24C79D0", Offset = "0x24C6DD0", Length = "0x96")]
	[Token(Token = "0x6001848")]
	public virtual long ToInt64(string value) { }

	[Address(RVA = "0x24C7800", Offset = "0x24C6C00", Length = "0x1C2")]
	[Token(Token = "0x6001849")]
	public virtual long ToInt64(object value) { }

	[Address(RVA = "0x24C7A70", Offset = "0x24C6E70", Length = "0x1C6")]
	[Token(Token = "0x600184B")]
	public virtual float ToSingle(object value) { }

	[Address(RVA = "0x24C7C40", Offset = "0x24C7040", Length = "0x96")]
	[Token(Token = "0x600184A")]
	public virtual float ToSingle(string value) { }

	[Address(RVA = "0x24C8D80", Offset = "0x24C8180", Length = "0x54")]
	[Token(Token = "0x600184E")]
	public virtual string ToString(DateTimeOffset value) { }

	[Address(RVA = "0x24C8C40", Offset = "0x24C8040", Length = "0x50")]
	[Token(Token = "0x6001853")]
	public virtual string ToString(float value) { }

	[Address(RVA = "0x24C8C90", Offset = "0x24C8090", Length = "0x49")]
	[Token(Token = "0x6001852")]
	public virtual string ToString(long value) { }

	[Address(RVA = "0x24C8CE0", Offset = "0x24C80E0", Length = "0x47")]
	[Token(Token = "0x6001851")]
	public virtual string ToString(int value) { }

	[Address(RVA = "0x24C8BF0", Offset = "0x24C7FF0", Length = "0x50")]
	[Token(Token = "0x6001850")]
	public virtual string ToString(double value) { }

	[Address(RVA = "0x24C7CE0", Offset = "0x24C70E0", Length = "0x54")]
	[Token(Token = "0x600184F")]
	public virtual string ToString(decimal value) { }

	[Address(RVA = "0x24C8BA0", Offset = "0x24C7FA0", Length = "0x49")]
	[Token(Token = "0x600184C")]
	public virtual string ToString(bool value) { }

	[Address(RVA = "0x24C7D40", Offset = "0x24C7140", Length = "0xE5C")]
	[Token(Token = "0x6001854")]
	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24C8D30", Offset = "0x24C8130", Length = "0x49")]
	[Token(Token = "0x600184D")]
	public virtual string ToString(DateTime value) { }

}

