namespace Steamworks;

[CallbackIdentity(703)]
[Token(Token = "0x20000F8")]
public struct SteamAPICallCompleted_t
{
	[Token(Token = "0x4000309")]
	public const int k_iCallback = 703; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400030A")]
	public SteamAPICall_t m_hAsyncCall; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400030B")]
	public int m_iCallback; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400030C")]
	public uint m_cubParam; //Field offset: 0xC

}

