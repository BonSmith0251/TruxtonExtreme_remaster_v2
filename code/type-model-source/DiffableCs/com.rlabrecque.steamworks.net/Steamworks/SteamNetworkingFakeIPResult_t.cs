namespace Steamworks;

[CallbackIdentity(1223)]
[Token(Token = "0x2000101")]
public struct SteamNetworkingFakeIPResult_t
{
	[Token(Token = "0x400031F")]
	public const int k_iCallback = 1223; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000320")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000321")]
	public SteamNetworkingIdentity m_identity; //Field offset: 0x4
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000322")]
	public uint m_unIP; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000323")]
	public UInt16[] m_unPorts; //Field offset: 0x90

}

