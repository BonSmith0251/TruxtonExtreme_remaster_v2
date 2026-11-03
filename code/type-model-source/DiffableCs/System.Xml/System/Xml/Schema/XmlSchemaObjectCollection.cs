namespace System.Xml.Schema;

[DefaultMember("Item")]
[Token(Token = "0x2000231")]
public class XmlSchemaObjectCollection : CollectionBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BA5")]
	private XmlSchemaObject parent; //Field offset: 0x18

	[Token(Token = "0x1700061D")]
	public override XmlSchemaObject Item
	{
		[Address(RVA = "0x248F9C0", Offset = "0x248EDC0", Length = "0xA9")]
		[Token(Token = "0x6001609")]
		 get { } //Length: 169
		[Address(RVA = "0x248FA70", Offset = "0x248EE70", Length = "0x73")]
		[Token(Token = "0x600160A")]
		 set { } //Length: 115
	}

	[Address(RVA = "0x1E3EFC0", Offset = "0x1E3E3C0", Length = "0x7")]
	[Token(Token = "0x6001608")]
	public XmlSchemaObjectCollection() { }

	[Address(RVA = "0x248F600", Offset = "0x248EA00", Length = "0x61")]
	[Token(Token = "0x600160C")]
	public int Add(XmlSchemaObject item) { }

	[Address(RVA = "0x248F5D0", Offset = "0x248E9D0", Length = "0x2F")]
	[Token(Token = "0x6001614")]
	private void Add(XmlSchemaObjectCollection collToAdd) { }

	[Address(RVA = "0x248F670", Offset = "0x248EA70", Length = "0x7C")]
	[Token(Token = "0x6001613")]
	internal XmlSchemaObjectCollection Clone() { }

	[Address(RVA = "0x248F9C0", Offset = "0x248EDC0", Length = "0xA9")]
	[Token(Token = "0x6001609")]
	public override XmlSchemaObject get_Item(int index) { }

	[Address(RVA = "0x248F6F0", Offset = "0x248EAF0", Length = "0x79")]
	[Token(Token = "0x600160B")]
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	[Address(RVA = "0x248F770", Offset = "0x248EB70", Length = "0x73")]
	[Token(Token = "0x600160D")]
	public void Insert(int index, XmlSchemaObject item) { }

	[Address(RVA = "0x248F7F0", Offset = "0x248EBF0", Length = "0x23")]
	[Token(Token = "0x6001611")]
	protected virtual void OnClear() { }

	[Address(RVA = "0x248F820", Offset = "0x248EC20", Length = "0x23")]
	[Token(Token = "0x600160F")]
	protected virtual void OnInsert(int index, object item) { }

	[Address(RVA = "0x248F850", Offset = "0x248EC50", Length = "0x23")]
	[Token(Token = "0x6001612")]
	protected virtual void OnRemove(int index, object item) { }

	[Address(RVA = "0x248F880", Offset = "0x248EC80", Length = "0x63")]
	[Token(Token = "0x6001610")]
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	[Address(RVA = "0x248F8F0", Offset = "0x248ECF0", Length = "0xC5")]
	[Token(Token = "0x600160E")]
	public void Remove(XmlSchemaObject item) { }

	[Address(RVA = "0x248FA70", Offset = "0x248EE70", Length = "0x73")]
	[Token(Token = "0x600160A")]
	public override void set_Item(int index, XmlSchemaObject value) { }

}

