namespace System.Xml;

[Token(Token = "0x2000027")]
internal interface IDtdAttributeListInfo
{

	[Token(Token = "0x1700001A")]
	public bool HasNonCDataAttributes
	{
		[Token(Token = "0x600013B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600013B")]
	public bool get_HasNonCDataAttributes() { }

	[Token(Token = "0x600013C")]
	public IDtdAttributeInfo LookupAttribute(string prefix, string localName) { }

	[Token(Token = "0x600013D")]
	public IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes() { }

}

