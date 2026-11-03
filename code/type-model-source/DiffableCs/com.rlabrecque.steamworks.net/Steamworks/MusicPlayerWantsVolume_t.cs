namespace Steamworks;

[CallbackIdentity(4011)]
[Token(Token = "0x200009D")]
public struct MusicPlayerWantsVolume_t
{
	[Token(Token = "0x40001AC")]
	public const int k_iCallback = 4011; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001AD")]
	public float m_flNewVolume; //Field offset: 0x0

}

