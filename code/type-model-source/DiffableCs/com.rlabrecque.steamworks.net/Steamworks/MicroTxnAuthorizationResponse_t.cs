namespace Steamworks;

[CallbackIdentity(152)]
[Token(Token = "0x20000E2")]
public struct MicroTxnAuthorizationResponse_t
{
	[Token(Token = "0x40002B7")]
	public const int k_iCallback = 152; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B8")]
	public uint m_unAppID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002B9")]
	public ulong m_ulOrderID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002BA")]
	public byte m_bAuthorized; //Field offset: 0x10

}

