namespace System.Xml.Schema;

[Token(Token = "0x2000204")]
public sealed class XmlSchemaCollectionEnumerator : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B17")]
	private IDictionaryEnumerator enumerator; //Field offset: 0x10

	[Token(Token = "0x1700059B")]
	public XmlSchema Current
	{
		[Address(RVA = "0x2488FB0", Offset = "0x24883B0", Length = "0x85")]
		[Token(Token = "0x60014C7")]
		 get { } //Length: 133
	}

	[Token(Token = "0x1700059C")]
	internal XmlSchemaCollectionNode CurrentNode
	{
		[Address(RVA = "0x2488F30", Offset = "0x2488330", Length = "0x7B")]
		[Token(Token = "0x60014C8")]
		internal get { } //Length: 123
	}

	[Token(Token = "0x1700059A")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x2488EC0", Offset = "0x24882C0", Length = "0x7")]
		[Token(Token = "0x60014C6")]
		private get { } //Length: 7
	}

	[Address(RVA = "0x2488ED0", Offset = "0x24882D0", Length = "0x51")]
	[Token(Token = "0x60014C2")]
	internal XmlSchemaCollectionEnumerator(Hashtable collection) { }

	[Address(RVA = "0x2488FB0", Offset = "0x24883B0", Length = "0x85")]
	[Token(Token = "0x60014C7")]
	public XmlSchema get_Current() { }

	[Address(RVA = "0x2488F30", Offset = "0x2488330", Length = "0x7B")]
	[Token(Token = "0x60014C8")]
	internal XmlSchemaCollectionNode get_CurrentNode() { }

	[Address(RVA = "0x2488DD0", Offset = "0x24881D0", Length = "0x46")]
	[Token(Token = "0x60014C5")]
	public bool MoveNext() { }

	[Address(RVA = "0x2488EC0", Offset = "0x24882C0", Length = "0x7")]
	[Token(Token = "0x60014C6")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Address(RVA = "0x2488E20", Offset = "0x2488220", Length = "0x46")]
	[Token(Token = "0x60014C4")]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[Address(RVA = "0x2488E70", Offset = "0x2488270", Length = "0x49")]
	[Token(Token = "0x60014C3")]
	private override void System.Collections.IEnumerator.Reset() { }

}

