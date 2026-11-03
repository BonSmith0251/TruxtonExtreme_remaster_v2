namespace System.Security.Util;

[Token(Token = "0x20002DC")]
internal sealed class TokenizerShortBlock
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C4B")]
	internal Int16[] m_block; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C4C")]
	internal TokenizerShortBlock m_next; //Field offset: 0x18

	[Address(RVA = "0x1EADAE0", Offset = "0x1EACEE0", Length = "0x55")]
	[Token(Token = "0x60017E9")]
	public TokenizerShortBlock() { }

}

