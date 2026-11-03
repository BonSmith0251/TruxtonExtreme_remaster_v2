namespace System.Xml.Serialization;

[Token(Token = "0x20000F9")]
public interface IXmlSerializable
{

	[Token(Token = "0x6000BF3")]
	public XmlSchema GetSchema() { }

	[Token(Token = "0x6000BF4")]
	public void ReadXml(XmlReader reader) { }

	[Token(Token = "0x6000BF5")]
	public void WriteXml(XmlWriter writer) { }

}

