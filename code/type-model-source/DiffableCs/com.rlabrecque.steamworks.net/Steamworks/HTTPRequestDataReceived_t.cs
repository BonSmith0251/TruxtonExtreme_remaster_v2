namespace Steamworks;

[CallbackIdentity(2103)]
[Token(Token = "0x200006E")]
public struct HTTPRequestDataReceived_t
{
	[Token(Token = "0x400010F")]
	public const int k_iCallback = 2103; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000110")]
	public HTTPRequestHandle m_hRequest; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000111")]
	public ulong m_ulContextValue; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000112")]
	public uint m_cOffset; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000113")]
	public uint m_cBytesReceived; //Field offset: 0x14

}

