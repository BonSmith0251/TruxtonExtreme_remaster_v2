namespace Steamworks;

[CallbackIdentity(4704)]
[Token(Token = "0x2000077")]
public struct SteamInventoryStartPurchaseResult_t
{
	[Token(Token = "0x4000131")]
	public const int k_iCallback = 4704; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000132")]
	public EResult m_result; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000133")]
	public ulong m_ulOrderID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000134")]
	public ulong m_ulTransID; //Field offset: 0x10

}

