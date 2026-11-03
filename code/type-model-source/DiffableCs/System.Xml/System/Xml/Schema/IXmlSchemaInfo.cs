namespace System.Xml.Schema;

[Token(Token = "0x20001C7")]
public interface IXmlSchemaInfo
{

	[Token(Token = "0x170004C7")]
	public bool IsDefault
	{
		[Token(Token = "0x6001188")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004C8")]
	public bool IsNil
	{
		[Token(Token = "0x6001189")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004C9")]
	public XmlSchemaSimpleType MemberType
	{
		[Token(Token = "0x600118A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004CC")]
	public XmlSchemaAttribute SchemaAttribute
	{
		[Token(Token = "0x600118D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004CB")]
	public XmlSchemaElement SchemaElement
	{
		[Token(Token = "0x600118C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004CA")]
	public XmlSchemaType SchemaType
	{
		[Token(Token = "0x600118B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170004C6")]
	public XmlSchemaValidity Validity
	{
		[Token(Token = "0x6001187")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001188")]
	public bool get_IsDefault() { }

	[Token(Token = "0x6001189")]
	public bool get_IsNil() { }

	[Token(Token = "0x600118A")]
	public XmlSchemaSimpleType get_MemberType() { }

	[Token(Token = "0x600118D")]
	public XmlSchemaAttribute get_SchemaAttribute() { }

	[Token(Token = "0x600118C")]
	public XmlSchemaElement get_SchemaElement() { }

	[Token(Token = "0x600118B")]
	public XmlSchemaType get_SchemaType() { }

	[Token(Token = "0x6001187")]
	public XmlSchemaValidity get_Validity() { }

}

