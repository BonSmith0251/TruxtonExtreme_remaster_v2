namespace Steamworks;

[Token(Token = "0x2000178")]
public struct P2PSessionState_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009FC")]
	public byte m_bConnectionActive; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x40009FD")]
	public byte m_bConnecting; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x40009FE")]
	public byte m_eP2PSessionError; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x40009FF")]
	public byte m_bUsingRelay; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000A00")]
	public int m_nBytesQueuedForSend; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A01")]
	public int m_nPacketsQueuedForSend; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000A02")]
	public uint m_nRemoteIP; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A03")]
	public ushort m_nRemotePort; //Field offset: 0x10

}

