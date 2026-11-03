namespace Steamworks;

[CallbackIdentity(1332)]
[Token(Token = "0x20000C4")]
public struct RemoteStorageFileReadAsyncComplete_t
{
	[Token(Token = "0x400024B")]
	public const int k_iCallback = 1332; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400024C")]
	public SteamAPICall_t m_hFileReadAsync; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400024D")]
	public EResult m_eResult; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400024E")]
	public uint m_nOffset; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400024F")]
	public uint m_cubRead; //Field offset: 0x10

}

