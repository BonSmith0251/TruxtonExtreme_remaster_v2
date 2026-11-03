namespace System.Xml.Schema;

[Token(Token = "0x200020B")]
public abstract class XmlSchemaContentModel : XmlSchemaAnnotated
{

	[Token(Token = "0x170005BA")]
	[XmlIgnore]
	public abstract XmlSchemaContent Content
	{
		[Token(Token = "0x600150C")]
		 get { } //Length: 0
		[Token(Token = "0x600150D")]
		 set { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600150E")]
	protected XmlSchemaContentModel() { }

	[Token(Token = "0x600150C")]
	public abstract XmlSchemaContent get_Content() { }

	[Token(Token = "0x600150D")]
	public abstract void set_Content(XmlSchemaContent value) { }

}

