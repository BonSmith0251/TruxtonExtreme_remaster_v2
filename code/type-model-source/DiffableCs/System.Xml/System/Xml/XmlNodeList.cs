namespace System.Xml;

[DefaultMember("ItemOf")]
[Token(Token = "0x20000A7")]
public abstract class XmlNodeList : IEnumerable, IDisposable
{

	[Token(Token = "0x1700026E")]
	public abstract int Count
	{
		[Token(Token = "0x6000928")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700026F")]
	public override XmlNode ItemOf
	{
		[Address(RVA = "0x207E9C0", Offset = "0x207DDC0", Length = "0x14")]
		[Token(Token = "0x600092A")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600092D")]
	protected XmlNodeList() { }

	[Token(Token = "0x6000928")]
	public abstract int get_Count() { }

	[Address(RVA = "0x207E9C0", Offset = "0x207DDC0", Length = "0x14")]
	[Token(Token = "0x600092A")]
	public override XmlNode get_ItemOf(int i) { }

	[Token(Token = "0x6000929")]
	public abstract IEnumerator GetEnumerator() { }

	[Token(Token = "0x6000927")]
	public abstract XmlNode Item(int index) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600092C")]
	protected override void PrivateDisposeNodeList() { }

	[Address(RVA = "0x1DDF660", Offset = "0x1DDEA60", Length = "0x14")]
	[Token(Token = "0x600092B")]
	private override void System.IDisposable.Dispose() { }

}

