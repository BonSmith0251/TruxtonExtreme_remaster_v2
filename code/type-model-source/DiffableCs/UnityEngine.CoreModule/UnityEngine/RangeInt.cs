namespace UnityEngine;

[Token(Token = "0x20001B9")]
public struct RangeInt
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000684")]
	public int start; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000685")]
	public int length; //Field offset: 0x4

	[Token(Token = "0x170002F4")]
	public int end
	{
		[Address(RVA = "0x2CF5F70", Offset = "0x2CF5370", Length = "0x8")]
		[Token(Token = "0x60013F4")]
		 get { } //Length: 8
	}

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x60013F5")]
	public RangeInt(int start, int length) { }

	[Address(RVA = "0x2CF5F70", Offset = "0x2CF5370", Length = "0x8")]
	[Token(Token = "0x60013F4")]
	public int get_end() { }

}

