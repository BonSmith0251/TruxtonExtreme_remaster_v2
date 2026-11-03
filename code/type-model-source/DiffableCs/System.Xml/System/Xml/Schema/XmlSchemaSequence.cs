namespace System.Xml.Schema;

[Token(Token = "0x200023D")]
public class XmlSchemaSequence : XmlSchemaGroupBase
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000BC3")]
	private XmlSchemaObjectCollection items; //Field offset: 0x78

	[Token(Token = "0x17000636")]
	internal virtual bool IsEmpty
	{
		[Address(RVA = "0x2499990", Offset = "0x2498D90", Length = "0xAA")]
		[Token(Token = "0x600164C")]
		internal get { } //Length: 170
	}

	[Token(Token = "0x17000635")]
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public virtual XmlSchemaObjectCollection Items
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x600164B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2499920", Offset = "0x2498D20", Length = "0x66")]
	[Token(Token = "0x600164E")]
	public XmlSchemaSequence() { }

	[Address(RVA = "0x2499990", Offset = "0x2498D90", Length = "0xAA")]
	[Token(Token = "0x600164C")]
	internal virtual bool get_IsEmpty() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x600164B")]
	public virtual XmlSchemaObjectCollection get_Items() { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[Token(Token = "0x600164D")]
	internal virtual void SetItems(XmlSchemaObjectCollection newItems) { }

}

