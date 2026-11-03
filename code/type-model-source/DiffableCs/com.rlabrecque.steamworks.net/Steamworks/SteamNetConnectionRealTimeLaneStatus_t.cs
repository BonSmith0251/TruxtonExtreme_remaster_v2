namespace Steamworks;

[Token(Token = "0x2000180")]
public struct SteamNetConnectionRealTimeLaneStatus_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A47")]
	public int m_cbPendingUnreliable; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000A48")]
	public int m_cbPendingReliable; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A49")]
	public int m_cbSentUnackedReliable; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000A4A")]
	public int _reservePad1; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A4B")]
	public SteamNetworkingMicroseconds m_usecQueueTime; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A4C")]
	public UInt32[] reserved; //Field offset: 0x18

}

