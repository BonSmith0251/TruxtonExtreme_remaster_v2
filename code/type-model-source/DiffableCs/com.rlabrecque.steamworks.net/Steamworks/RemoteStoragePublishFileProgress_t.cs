namespace Steamworks;

[CallbackIdentity(1329)]
[Token(Token = "0x20000C1")]
public struct RemoteStoragePublishFileProgress_t
{
	[Token(Token = "0x4000242")]
	public const int k_iCallback = 1329; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000243")]
	public double m_dPercentFile; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000244")]
	public bool m_bPreview; //Field offset: 0x8

}

