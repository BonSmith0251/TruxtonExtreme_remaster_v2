namespace System.Xml.Schema;

[Token(Token = "0x2000201")]
public class XmlSchemaChoice : XmlSchemaGroupBase
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B0B")]
	private XmlSchemaObjectCollection items; //Field offset: 0x78

	[Token(Token = "0x1700058E")]
	internal virtual bool IsEmpty
	{
		[Address(RVA = "0x2488DC0", Offset = "0x24881C0", Length = "0x7")]
		[Token(Token = "0x60014A7")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x1700058D")]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	public virtual XmlSchemaObjectCollection Items
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x60014A6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2488D20", Offset = "0x2488120", Length = "0x97")]
	[Token(Token = "0x60014A9")]
	public XmlSchemaChoice() { }

	[Address(RVA = "0x2488DC0", Offset = "0x24881C0", Length = "0x7")]
	[Token(Token = "0x60014A7")]
	internal virtual bool get_IsEmpty() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x60014A6")]
	public virtual XmlSchemaObjectCollection get_Items() { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[Token(Token = "0x60014A8")]
	internal virtual void SetItems(XmlSchemaObjectCollection newItems) { }

}

