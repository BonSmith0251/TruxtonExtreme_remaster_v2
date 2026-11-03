namespace TMPro;

[Token(Token = "0x20000B6")]
public struct CaretInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000681")]
	public int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000682")]
	public CaretPosition position; //Field offset: 0x4

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x60006E2")]
	public CaretInfo(int index, CaretPosition position) { }

}

