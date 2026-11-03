namespace System.Xml;

[Token(Token = "0x2000031")]
internal abstract class IncrementalReadDecoder
{

	[Token(Token = "0x17000043")]
	internal abstract bool IsFull
	{
		[Token(Token = "0x6000179")]
		internal get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600017B")]
	protected IncrementalReadDecoder() { }

	[Token(Token = "0x600017A")]
	internal abstract int Decode(Char[] chars, int startPos, int len) { }

	[Token(Token = "0x6000179")]
	internal abstract bool get_IsFull() { }

}

