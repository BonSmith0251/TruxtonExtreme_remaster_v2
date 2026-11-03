namespace Steamworks;

[CallbackIdentity(4110)]
[Token(Token = "0x200009C")]
public struct MusicPlayerWantsLooped_t
{
	[Token(Token = "0x40001AA")]
	public const int k_iCallback = 4110; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001AB")]
	public bool m_bLooped; //Field offset: 0x0

}

