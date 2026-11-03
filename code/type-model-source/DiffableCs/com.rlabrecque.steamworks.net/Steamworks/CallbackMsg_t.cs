namespace Steamworks;

[Token(Token = "0x200017D")]
public struct CallbackMsg_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A28")]
	public int m_hSteamUser; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000A29")]
	public int m_iCallback; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A2A")]
	public IntPtr m_pubParam; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A2B")]
	public int m_cubParam; //Field offset: 0x10

}

