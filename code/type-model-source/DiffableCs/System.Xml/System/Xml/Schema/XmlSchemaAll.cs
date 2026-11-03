namespace System.Xml.Schema;

[Token(Token = "0x20001F8")]
public class XmlSchemaAll : XmlSchemaGroupBase
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000AE8")]
	private XmlSchemaObjectCollection items; //Field offset: 0x78

	[Token(Token = "0x17000561")]
	internal virtual bool IsEmpty
	{
		[Address(RVA = "0x2487BD0", Offset = "0x2486FD0", Length = "0x3C")]
		[Token(Token = "0x6001445")]
		internal get { } //Length: 60
	}

	[Token(Token = "0x17000560")]
	[XmlElement("element", typeof(XmlSchemaElement))]
	public virtual XmlSchemaObjectCollection Items
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6001444")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2487B30", Offset = "0x2486F30", Length = "0x97")]
	[Token(Token = "0x6001447")]
	public XmlSchemaAll() { }

	[Address(RVA = "0x2487BD0", Offset = "0x2486FD0", Length = "0x3C")]
	[Token(Token = "0x6001445")]
	internal virtual bool get_IsEmpty() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6001444")]
	public virtual XmlSchemaObjectCollection get_Items() { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[Token(Token = "0x6001446")]
	internal virtual void SetItems(XmlSchemaObjectCollection newItems) { }

}

