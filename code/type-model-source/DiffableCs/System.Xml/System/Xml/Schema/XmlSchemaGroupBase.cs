namespace System.Xml.Schema;

[Token(Token = "0x2000225")]
public abstract class XmlSchemaGroupBase : XmlSchemaParticle
{

	[Token(Token = "0x170005F8")]
	[XmlIgnore]
	public abstract XmlSchemaObjectCollection Items
	{
		[Token(Token = "0x60015AD")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x248EAF0", Offset = "0x248DEF0", Length = "0x49")]
	[Token(Token = "0x60015AF")]
	protected XmlSchemaGroupBase() { }

	[Token(Token = "0x60015AD")]
	public abstract XmlSchemaObjectCollection get_Items() { }

	[Token(Token = "0x60015AE")]
	internal abstract void SetItems(XmlSchemaObjectCollection newItems) { }

}

