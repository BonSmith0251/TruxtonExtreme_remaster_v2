namespace Steamworks;

[CallbackIdentity(163)]
[Token(Token = "0x20000E4")]
public struct GetAuthSessionTicketResponse_t
{
	[Token(Token = "0x40002BD")]
	public const int k_iCallback = 163; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BE")]
	public HAuthTicket m_hAuthTicket; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002BF")]
	public EResult m_eResult; //Field offset: 0x4

}

