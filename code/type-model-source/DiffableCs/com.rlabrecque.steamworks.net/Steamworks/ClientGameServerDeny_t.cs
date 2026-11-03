namespace Steamworks;

[CallbackIdentity(113)]
[Token(Token = "0x20000DE")]
public struct ClientGameServerDeny_t
{
	[Token(Token = "0x40002AA")]
	public const int k_iCallback = 113; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002AB")]
	public uint m_uAppID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002AC")]
	public uint m_unGameServerIP; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002AD")]
	public ushort m_usGameServerPort; //Field offset: 0x8
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x40002AE")]
	public ushort m_bSecure; //Field offset: 0xA
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40002AF")]
	public uint m_uReason; //Field offset: 0xC

}

