namespace Steamworks;

[CallbackIdentity(347)]
[Token(Token = "0x2000041")]
public struct SetPersonaNameResponse_t
{
	[Token(Token = "0x4000058")]
	public const int k_iCallback = 347; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000059")]
	public bool m_bSuccess; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x400005A")]
	public bool m_bLocalSuccess; //Field offset: 0x1
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400005B")]
	public EResult m_result; //Field offset: 0x4

}

