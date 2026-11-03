namespace Steamworks;

[CallbackIdentity(4002)]
[Token(Token = "0x2000092")]
public struct VolumeHasChanged_t
{
	[Token(Token = "0x400019E")]
	public const int k_iCallback = 4002; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400019F")]
	public float m_flNewVolume; //Field offset: 0x0

}

