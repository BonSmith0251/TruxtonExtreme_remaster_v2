namespace Steamworks;

[CallbackIdentity(210)]
[Token(Token = "0x2000050")]
public struct AssociateWithClanResult_t
{
	[Token(Token = "0x400008E")]
	public const int k_iCallback = 210; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400008F")]
	public EResult m_eResult; //Field offset: 0x0

}

