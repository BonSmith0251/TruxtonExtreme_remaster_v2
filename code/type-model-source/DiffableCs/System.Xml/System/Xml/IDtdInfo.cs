namespace System.Xml;

[Token(Token = "0x2000026")]
internal interface IDtdInfo
{

	[Token(Token = "0x17000018")]
	public bool HasDefaultAttributes
	{
		[Token(Token = "0x6000137")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000019")]
	public bool HasNonCDataAttributes
	{
		[Token(Token = "0x6000138")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000017")]
	public string InternalDtdSubset
	{
		[Token(Token = "0x6000136")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000016")]
	public XmlQualifiedName Name
	{
		[Token(Token = "0x6000135")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000137")]
	public bool get_HasDefaultAttributes() { }

	[Token(Token = "0x6000138")]
	public bool get_HasNonCDataAttributes() { }

	[Token(Token = "0x6000136")]
	public string get_InternalDtdSubset() { }

	[Token(Token = "0x6000135")]
	public XmlQualifiedName get_Name() { }

	[Token(Token = "0x6000139")]
	public IDtdAttributeListInfo LookupAttributeList(string prefix, string localName) { }

	[Token(Token = "0x600013A")]
	public IDtdEntityInfo LookupEntity(string name) { }

}

