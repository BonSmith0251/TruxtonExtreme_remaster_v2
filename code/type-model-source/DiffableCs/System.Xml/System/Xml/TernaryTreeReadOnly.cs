namespace System.Xml;

[Token(Token = "0x200003A")]
internal class TernaryTreeReadOnly
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400012F")]
	private Byte[] nodeBuffer; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60001A0")]
	public TernaryTreeReadOnly(Byte[] nodeBuffer) { }

	[Address(RVA = "0x24ED0D0", Offset = "0x24EC4D0", Length = "0x14B")]
	[Token(Token = "0x60001A1")]
	public byte FindCaseInsensitiveString(string stringToFind) { }

}

