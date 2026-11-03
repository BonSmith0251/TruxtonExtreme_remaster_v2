namespace Steamworks;

[CallbackIdentity(168)]
[Token(Token = "0x20000E9")]
public struct GetTicketForWebApiResponse_t
{
	[Token(Token = "0x40002D3")]
	public const int k_iCallback = 168; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002D4")]
	public HAuthTicket m_hAuthTicket; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002D5")]
	public EResult m_eResult; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002D6")]
	public int m_cubTicket; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002D7")]
	public Byte[] m_rgubTicket; //Field offset: 0x10

}

