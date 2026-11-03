namespace System.Xml;

[Token(Token = "0x20000B1")]
internal sealed class EmptyEnumerator : IEnumerator
{

	[Token(Token = "0x170002B4")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x2535B70", Offset = "0x2534F70", Length = "0x5F")]
		[Token(Token = "0x60009D5")]
		private get { } //Length: 95
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60009D6")]
	public EmptyEnumerator() { }

	[Address(RVA = "0x2535B70", Offset = "0x2534F70", Length = "0x5F")]
	[Token(Token = "0x60009D5")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60009D3")]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60009D4")]
	private override void System.Collections.IEnumerator.Reset() { }

}

