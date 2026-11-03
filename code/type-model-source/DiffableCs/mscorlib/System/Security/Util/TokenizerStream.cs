namespace System.Security.Util;

[Token(Token = "0x20002DE")]
internal sealed class TokenizerStream
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C4F")]
	private int m_countTokens; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C50")]
	private TokenizerShortBlock m_headTokens; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C51")]
	private TokenizerShortBlock m_lastTokens; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C52")]
	private TokenizerShortBlock m_currentTokens; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C53")]
	private int m_indexTokens; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C54")]
	private TokenizerStringBlock m_headStrings; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C55")]
	private TokenizerStringBlock m_currentStrings; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C56")]
	private int m_indexStrings; //Field offset: 0x48

	[Address(RVA = "0x1EAE070", Offset = "0x1EAD470", Length = "0x15C")]
	[Token(Token = "0x60017EB")]
	internal TokenizerStream() { }

	[Address(RVA = "0x1EADB40", Offset = "0x1EACF40", Length = "0x13C")]
	[Token(Token = "0x60017ED")]
	internal void AddString(string str) { }

	[Address(RVA = "0x1EADC80", Offset = "0x1EAD080", Length = "0x130")]
	[Token(Token = "0x60017EC")]
	internal void AddToken(short token) { }

	[Address(RVA = "0x1EADDC0", Offset = "0x1EAD1C0", Length = "0x8C")]
	[Token(Token = "0x60017EF")]
	internal short GetNextFullToken() { }

	[Address(RVA = "0x1EADE50", Offset = "0x1EAD250", Length = "0x76")]
	[Token(Token = "0x60017F1")]
	internal string GetNextString() { }

	[Address(RVA = "0x1EADED0", Offset = "0x1EAD2D0", Length = "0x18")]
	[Token(Token = "0x60017F0")]
	internal short GetNextToken() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60017F4")]
	internal int GetTokenCount() { }

	[Address(RVA = "0x1EADEF0", Offset = "0x1EAD2F0", Length = "0x7F")]
	[Token(Token = "0x60017F5")]
	internal void GoToPosition(int position) { }

	[Address(RVA = "0x1EADF70", Offset = "0x1EAD370", Length = "0x52")]
	[Token(Token = "0x60017EE")]
	internal void Reset() { }

	[Address(RVA = "0x1EADFD0", Offset = "0x1EAD3D0", Length = "0x83")]
	[Token(Token = "0x60017F3")]
	internal void TagLastToken(short tag) { }

	[Address(RVA = "0x1EAE060", Offset = "0x1EAD460", Length = "0x7")]
	[Token(Token = "0x60017F2")]
	internal void ThrowAwayNextString() { }

}

