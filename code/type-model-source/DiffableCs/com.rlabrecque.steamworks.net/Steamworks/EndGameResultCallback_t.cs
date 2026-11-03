namespace Steamworks;

[CallbackIdentity(5215)]
[Token(Token = "0x200008A")]
public struct EndGameResultCallback_t
{
	[Token(Token = "0x400018B")]
	public const int k_iCallback = 5215; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018C")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400018D")]
	public ulong ullUniqueGameID; //Field offset: 0x8

}

