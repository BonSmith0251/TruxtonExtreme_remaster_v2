namespace Steamworks;

[CallbackIdentity(4700)]
[Token(Token = "0x2000073")]
public struct SteamInventoryResultReady_t
{
	[Token(Token = "0x4000126")]
	public const int k_iCallback = 4700; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000127")]
	public SteamInventoryResult_t m_handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000128")]
	public EResult m_result; //Field offset: 0x4

}

