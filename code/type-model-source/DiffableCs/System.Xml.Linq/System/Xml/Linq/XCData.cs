namespace System.Xml.Linq;

[Token(Token = "0x2000007")]
public class XCData : XText
{

	[Token(Token = "0x17000005")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2407BB0", Offset = "0x2406FB0", Length = "0x7E")]
	[Token(Token = "0x6000010")]
	public XCData(string value) { }

	[Address(RVA = "0x2407C30", Offset = "0x2407030", Length = "0x7F")]
	[Token(Token = "0x6000011")]
	public XCData(XCData other) { }

	[Address(RVA = "0x2407A80", Offset = "0x2406E80", Length = "0xAE")]
	[Token(Token = "0x6000014")]
	internal virtual XNode CloneNode() { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x6000012")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2407B30", Offset = "0x2406F30", Length = "0x7D")]
	[Token(Token = "0x6000013")]
	public virtual void WriteTo(XmlWriter writer) { }

}

