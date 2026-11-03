namespace System.Xml;

[Token(Token = "0x2000032")]
internal class IncrementalReadDummyDecoder : IncrementalReadDecoder
{

	[Token(Token = "0x17000044")]
	internal virtual bool IsFull
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600017C")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600017E")]
	public IncrementalReadDummyDecoder() { }

	[Address(RVA = "0x24EB0E0", Offset = "0x24EA4E0", Length = "0x4")]
	[Token(Token = "0x600017D")]
	internal virtual int Decode(Char[] chars, int startPos, int len) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600017C")]
	internal virtual bool get_IsFull() { }

}

