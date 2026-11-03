namespace System.Xml.Schema;

[Token(Token = "0x20001B7")]
internal class Datatype_uuid : Datatype_anySimpleType
{
	[Token(Token = "0x400084D")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400084E")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x170004C2")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A8410", Offset = "0x25A7810", Length = "0x4F")]
		[Token(Token = "0x6001106")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004C3")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001107")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170004C1")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A8460", Offset = "0x25A7860", Length = "0x4E")]
		[Token(Token = "0x6001105")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A82C0", Offset = "0x25A76C0", Length = "0xC6")]
	[Token(Token = "0x600110C")]
	private static Datatype_uuid() { }

	[Address(RVA = "0x25A8390", Offset = "0x25A7790", Length = "0x7A")]
	[Token(Token = "0x600110B")]
	public Datatype_uuid() { }

	[Address(RVA = "0x25A8000", Offset = "0x25A7400", Length = "0x8B")]
	[Token(Token = "0x6001108")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A8410", Offset = "0x25A7810", Length = "0x4F")]
	[Token(Token = "0x6001106")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001107")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A8460", Offset = "0x25A7860", Length = "0x4E")]
	[Token(Token = "0x6001105")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A8090", Offset = "0x25A7490", Length = "0x167")]
	[Token(Token = "0x6001109")]
	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	[Address(RVA = "0x25A8200", Offset = "0x25A7600", Length = "0xB4")]
	[Token(Token = "0x600110A")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

