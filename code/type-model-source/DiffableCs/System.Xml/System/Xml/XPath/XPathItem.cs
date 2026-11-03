namespace System.Xml.XPath;

[Token(Token = "0x20000EA")]
public abstract class XPathItem
{

	[Token(Token = "0x170002E8")]
	public abstract object TypedValue
	{
		[Token(Token = "0x6000BAF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002E7")]
	public abstract string Value
	{
		[Token(Token = "0x6000BAE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002EA")]
	public abstract bool ValueAsBoolean
	{
		[Token(Token = "0x6000BB1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002EB")]
	public abstract DateTime ValueAsDateTime
	{
		[Token(Token = "0x6000BB2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002EC")]
	public abstract double ValueAsDouble
	{
		[Token(Token = "0x6000BB3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002ED")]
	public abstract int ValueAsInt
	{
		[Token(Token = "0x6000BB4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002EE")]
	public abstract long ValueAsLong
	{
		[Token(Token = "0x6000BB5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002E9")]
	public abstract Type ValueType
	{
		[Token(Token = "0x6000BB0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002E6")]
	public abstract XmlSchemaType XmlType
	{
		[Token(Token = "0x6000BAD")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000BB8")]
	protected XPathItem() { }

	[Token(Token = "0x6000BAF")]
	public abstract object get_TypedValue() { }

	[Token(Token = "0x6000BAE")]
	public abstract string get_Value() { }

	[Token(Token = "0x6000BB1")]
	public abstract bool get_ValueAsBoolean() { }

	[Token(Token = "0x6000BB2")]
	public abstract DateTime get_ValueAsDateTime() { }

	[Token(Token = "0x6000BB3")]
	public abstract double get_ValueAsDouble() { }

	[Token(Token = "0x6000BB4")]
	public abstract int get_ValueAsInt() { }

	[Token(Token = "0x6000BB5")]
	public abstract long get_ValueAsLong() { }

	[Token(Token = "0x6000BB0")]
	public abstract Type get_ValueType() { }

	[Token(Token = "0x6000BAD")]
	public abstract XmlSchemaType get_XmlType() { }

	[Address(RVA = "0x254DC30", Offset = "0x254D030", Length = "0x17")]
	[Token(Token = "0x6000BB6")]
	public override object ValueAs(Type returnType) { }

	[Token(Token = "0x6000BB7")]
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

}

