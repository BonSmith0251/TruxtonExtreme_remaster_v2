namespace System.Xml.Schema;

[Token(Token = "0x2000157")]
internal class LocatedActiveAxis : ActiveAxis
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400073B")]
	private int column; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400073C")]
	internal bool isMatched; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400073D")]
	internal KeySequence Ks; //Field offset: 0x30

	[Token(Token = "0x170003D5")]
	internal int Column
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000ECF")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x2584DD0", Offset = "0x25841D0", Length = "0x47")]
	[Token(Token = "0x6000ED0")]
	internal LocatedActiveAxis(Asttree astfield, KeySequence ks, int column) { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000ECF")]
	internal int get_Column() { }

	[Address(RVA = "0x2584DB0", Offset = "0x25841B0", Length = "0x18")]
	[Token(Token = "0x6000ED1")]
	internal void Reactivate(KeySequence ks) { }

}

