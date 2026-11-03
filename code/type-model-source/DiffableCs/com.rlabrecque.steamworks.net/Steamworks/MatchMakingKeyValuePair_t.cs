namespace Steamworks;

[Token(Token = "0x200017C")]
public struct MatchMakingKeyValuePair_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A26")]
	public string m_szKey; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A27")]
	public string m_szValue; //Field offset: 0x8

	[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
	[Token(Token = "0x60008B3")]
	private MatchMakingKeyValuePair_t(string strKey, string strValue) { }

}

