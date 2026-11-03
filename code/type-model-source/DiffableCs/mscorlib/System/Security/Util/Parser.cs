namespace System.Security.Util;

[Token(Token = "0x20002D6")]
internal sealed class Parser
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C29")]
	private SecurityDocument _doc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C2A")]
	private Tokenizer _t; //Field offset: 0x18

	[Address(RVA = "0x1EA9380", Offset = "0x1EA8780", Length = "0x90")]
	[Token(Token = "0x60017D8")]
	private Parser(Tokenizer t) { }

	[Address(RVA = "0x1EA9280", Offset = "0x1EA8680", Length = "0xF5")]
	[Token(Token = "0x60017D9")]
	internal Parser(string input) { }

	[Address(RVA = "0x1EA8300", Offset = "0x1EA7700", Length = "0x235")]
	[Token(Token = "0x60017D6")]
	private int DetermineFormat(TokenizerStream stream) { }

	[Address(RVA = "0x1EA8540", Offset = "0x1EA7940", Length = "0x7A4")]
	[Token(Token = "0x60017D5")]
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	[Address(RVA = "0x1EA8D10", Offset = "0x1EA8110", Length = "0x2F")]
	[Token(Token = "0x60017D4")]
	internal SecurityElement GetTopElement() { }

	[Address(RVA = "0x1EA8D40", Offset = "0x1EA8140", Length = "0x539")]
	[Token(Token = "0x60017D7")]
	private void ParseContents() { }

}

