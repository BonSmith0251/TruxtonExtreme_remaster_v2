namespace Steamworks;

[CallbackIdentity(4701)]
[Token(Token = "0x2000074")]
public struct SteamInventoryFullUpdate_t
{
	[Token(Token = "0x4000129")]
	public const int k_iCallback = 4701; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400012A")]
	public SteamInventoryResult_t m_handle; //Field offset: 0x0

}

