namespace Steamworks;

[CallbackIdentity(2802)]
[Token(Token = "0x2000070")]
public struct SteamInputDeviceDisconnected_t
{
	[Token(Token = "0x4000116")]
	public const int k_iCallback = 2802; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000117")]
	public InputHandle_t m_ulDisconnectedDeviceHandle; //Field offset: 0x0

}

