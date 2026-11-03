namespace Steamworks;

[CallbackIdentity(2801)]
[Token(Token = "0x200006F")]
public struct SteamInputDeviceConnected_t
{
	[Token(Token = "0x4000114")]
	public const int k_iCallback = 2801; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000115")]
	public InputHandle_t m_ulConnectedDeviceHandle; //Field offset: 0x0

}

