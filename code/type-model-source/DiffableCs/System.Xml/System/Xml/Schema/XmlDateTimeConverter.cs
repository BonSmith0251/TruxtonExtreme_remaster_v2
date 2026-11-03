namespace System.Xml.Schema;

[Token(Token = "0x2000258")]
internal class XmlDateTimeConverter : XmlBaseConverter
{

	[Address(RVA = "0x24B74C0", Offset = "0x24B68C0", Length = "0x59")]
	[Token(Token = "0x6001817")]
	protected XmlDateTimeConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24B5CD0", Offset = "0x24B50D0", Length = "0x3A9")]
	[Token(Token = "0x6001822")]
	public virtual object ChangeType(DateTime value, Type destinationType) { }

	[Address(RVA = "0x24B5040", Offset = "0x24B4440", Length = "0x3E2")]
	[Token(Token = "0x6001823")]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B5430", Offset = "0x24B4830", Length = "0x89A")]
	[Token(Token = "0x6001824")]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B6080", Offset = "0x24B5480", Length = "0x85")]
	[Token(Token = "0x6001818")]
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24B6750", Offset = "0x24B5B50", Length = "0x54")]
	[Token(Token = "0x6001819")]
	public virtual DateTime ToDateTime(DateTimeOffset value) { }

	[Address(RVA = "0x24B67B0", Offset = "0x24B5BB0", Length = "0x50")]
	[Token(Token = "0x600181A")]
	public virtual DateTime ToDateTime(string value) { }

	[Address(RVA = "0x24B69C0", Offset = "0x24B5DC0", Length = "0x398")]
	[Token(Token = "0x600181B")]
	public virtual DateTime ToDateTime(object value) { }

	[Address(RVA = "0x24B64F0", Offset = "0x24B58F0", Length = "0x23")]
	[Token(Token = "0x600181C")]
	public virtual DateTimeOffset ToDateTimeOffset(DateTime value) { }

	[Address(RVA = "0x24B6520", Offset = "0x24B5920", Length = "0x58")]
	[Token(Token = "0x600181D")]
	public virtual DateTimeOffset ToDateTimeOffset(string value) { }

	[Address(RVA = "0x24B6110", Offset = "0x24B5510", Length = "0x3D3")]
	[Token(Token = "0x600181E")]
	public virtual DateTimeOffset ToDateTimeOffset(object value) { }

	[Address(RVA = "0x24B6F70", Offset = "0x24B6370", Length = "0x198")]
	[Token(Token = "0x600181F")]
	public virtual string ToString(DateTime value) { }

	[Address(RVA = "0x24B6D60", Offset = "0x24B6160", Length = "0x1F0")]
	[Token(Token = "0x6001820")]
	public virtual string ToString(DateTimeOffset value) { }

	[Address(RVA = "0x24B7130", Offset = "0x24B6530", Length = "0x38D")]
	[Token(Token = "0x6001821")]
	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

}

