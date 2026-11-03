namespace Steamworks;

[CallbackIdentity(5302)]
[Token(Token = "0x200008C")]
public struct CreateBeaconCallback_t
{
	[Token(Token = "0x4000193")]
	public const int k_iCallback = 5302; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000194")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000195")]
	public PartyBeaconID_t m_ulBeaconID; //Field offset: 0x8

}

