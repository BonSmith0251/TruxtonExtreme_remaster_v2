namespace Steamworks;

[Token(Token = "0x2000177")]
public struct SteamPartyBeaconLocation_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009FA")]
	public ESteamPartyBeaconLocationType m_eType; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009FB")]
	public ulong m_ulLocationID; //Field offset: 0x8

}

