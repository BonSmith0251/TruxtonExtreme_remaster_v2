namespace System.Xml;

[Token(Token = "0x2000091")]
internal sealed class XmlChildEnumerator : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000425")]
	internal XmlNode container; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000426")]
	internal XmlNode child; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000427")]
	internal bool isFirst; //Field offset: 0x20

	[Token(Token = "0x170001D8")]
	internal XmlNode Current
	{
		[Address(RVA = "0x2513B20", Offset = "0x2512F20", Length = "0x83")]
		[Token(Token = "0x60007A4")]
		internal get { } //Length: 131
	}

	[Token(Token = "0x170001D7")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x2513B20", Offset = "0x2512F20", Length = "0x83")]
		[Token(Token = "0x60007A3")]
		private get { } //Length: 131
	}

	[Address(RVA = "0x2513BB0", Offset = "0x2512FB0", Length = "0x66")]
	[Token(Token = "0x600079F")]
	internal XmlChildEnumerator(XmlNode container) { }

	[Address(RVA = "0x2513B20", Offset = "0x2512F20", Length = "0x83")]
	[Token(Token = "0x60007A4")]
	internal XmlNode get_Current() { }

	[Address(RVA = "0x2513A40", Offset = "0x2512E40", Length = "0x8E")]
	[Token(Token = "0x60007A1")]
	internal bool MoveNext() { }

	[Address(RVA = "0x2513B20", Offset = "0x2512F20", Length = "0x83")]
	[Token(Token = "0x60007A3")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Address(RVA = "0x2513A40", Offset = "0x2512E40", Length = "0x8E")]
	[Token(Token = "0x60007A0")]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[Address(RVA = "0x2513AD0", Offset = "0x2512ED0", Length = "0x43")]
	[Token(Token = "0x60007A2")]
	private override void System.Collections.IEnumerator.Reset() { }

}

