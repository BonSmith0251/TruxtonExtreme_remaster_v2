namespace Steamworks;

[CallbackIdentity(2101)]
[Token(Token = "0x200006C")]
public struct HTTPRequestCompleted_t
{
	[Token(Token = "0x4000106")]
	public const int k_iCallback = 2101; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000107")]
	public HTTPRequestHandle m_hRequest; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000108")]
	public ulong m_ulContextValue; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000109")]
	public bool m_bRequestSuccessful; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400010A")]
	public EHTTPStatusCode m_eStatusCode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400010B")]
	public uint m_unBodySize; //Field offset: 0x18

}

