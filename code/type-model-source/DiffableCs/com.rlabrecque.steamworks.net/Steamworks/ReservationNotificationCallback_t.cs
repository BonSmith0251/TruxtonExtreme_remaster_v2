namespace Steamworks;

[CallbackIdentity(5303)]
[Token(Token = "0x200008D")]
public struct ReservationNotificationCallback_t
{
	[Token(Token = "0x4000196")]
	public const int k_iCallback = 5303; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000197")]
	public PartyBeaconID_t m_ulBeaconID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000198")]
	public CSteamID m_steamIDJoiner; //Field offset: 0x8

}

