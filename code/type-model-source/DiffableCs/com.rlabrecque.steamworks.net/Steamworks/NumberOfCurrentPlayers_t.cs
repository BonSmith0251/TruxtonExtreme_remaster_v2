namespace Steamworks;

[CallbackIdentity(1107)]
[Token(Token = "0x20000F0")]
public struct NumberOfCurrentPlayers_t
{
	[Token(Token = "0x40002F3")]
	public const int k_iCallback = 1107; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002F4")]
	public byte m_bSuccess; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002F5")]
	public int m_cPlayers; //Field offset: 0x4

}

