namespace Steamworks;

[CallbackIdentity(2102)]
[Token(Token = "0x200006D")]
public struct HTTPRequestHeadersReceived_t
{
	[Token(Token = "0x400010C")]
	public const int k_iCallback = 2102; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010D")]
	public HTTPRequestHandle m_hRequest; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400010E")]
	public ulong m_ulContextValue; //Field offset: 0x8

}

