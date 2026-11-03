namespace Steamworks;

[CallbackIdentity(350)]
[Token(Token = "0x2000044")]
public struct EquippedProfileItemsChanged_t
{
	[Token(Token = "0x400005F")]
	public const int k_iCallback = 350; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000060")]
	public CSteamID m_steamID; //Field offset: 0x0

}

