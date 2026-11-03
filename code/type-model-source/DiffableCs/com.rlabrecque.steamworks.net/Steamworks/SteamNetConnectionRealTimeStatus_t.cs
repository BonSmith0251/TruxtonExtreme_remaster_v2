namespace Steamworks;

[Token(Token = "0x200017F")]
public struct SteamNetConnectionRealTimeStatus_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A39")]
	public ESteamNetworkingConnectionState m_eState; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000A3A")]
	public int m_nPing; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A3B")]
	public float m_flConnectionQualityLocal; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000A3C")]
	public float m_flConnectionQualityRemote; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A3D")]
	public float m_flOutPacketsPerSec; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A3E")]
	public float m_flOutBytesPerSec; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A3F")]
	public float m_flInPacketsPerSec; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000A40")]
	public float m_flInBytesPerSec; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A41")]
	public int m_nSendRateBytesPerSecond; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000A42")]
	public int m_cbPendingUnreliable; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A43")]
	public int m_cbPendingReliable; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000A44")]
	public int m_cbSentUnackedReliable; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A45")]
	public SteamNetworkingMicroseconds m_usecQueueTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A46")]
	public UInt32[] reserved; //Field offset: 0x38

}

