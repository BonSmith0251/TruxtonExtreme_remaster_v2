namespace System.Security.Util;

[Token(Token = "0x20002DD")]
internal sealed class TokenizerStringBlock
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C4D")]
	internal String[] m_block; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C4E")]
	internal TokenizerStringBlock m_next; //Field offset: 0x18

	[Address(RVA = "0x1EAE1D0", Offset = "0x1EAD5D0", Length = "0x55")]
	[Token(Token = "0x60017EA")]
	public TokenizerStringBlock() { }

}

