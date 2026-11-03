namespace System.Xml.Schema;

[Token(Token = "0x2000232")]
public class XmlSchemaObjectEnumerator : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BA6")]
	private IEnumerator enumerator; //Field offset: 0x10

	[Token(Token = "0x1700061E")]
	public XmlSchemaObject Current
	{
		[Address(RVA = "0x24982C0", Offset = "0x24976C0", Length = "0x95")]
		[Token(Token = "0x6001617")]
		 get { } //Length: 149
	}

	[Token(Token = "0x1700061F")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x2498270", Offset = "0x2497670", Length = "0x49")]
		[Token(Token = "0x600161A")]
		private get { } //Length: 73
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6001615")]
	internal XmlSchemaObjectEnumerator(IEnumerator enumerator) { }

	[Address(RVA = "0x24982C0", Offset = "0x24976C0", Length = "0x95")]
	[Token(Token = "0x6001617")]
	public XmlSchemaObject get_Current() { }

	[Address(RVA = "0x2498180", Offset = "0x2497580", Length = "0x46")]
	[Token(Token = "0x6001616")]
	public bool MoveNext() { }

	[Address(RVA = "0x2498270", Offset = "0x2497670", Length = "0x49")]
	[Token(Token = "0x600161A")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Address(RVA = "0x24981D0", Offset = "0x24975D0", Length = "0x46")]
	[Token(Token = "0x6001619")]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[Address(RVA = "0x2498220", Offset = "0x2497620", Length = "0x49")]
	[Token(Token = "0x6001618")]
	private override void System.Collections.IEnumerator.Reset() { }

}

