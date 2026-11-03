namespace Steamworks;

[Token(Token = "0x20001D7")]
public struct ISteamNetworkingConnectionSignaling
{

	[Address(RVA = "0x60CF60", Offset = "0x60C360", Length = "0x78")]
	[Token(Token = "0x6000ADD")]
	public void Release() { }

	[Address(RVA = "0x60CFE0", Offset = "0x60C3E0", Length = "0x1A0")]
	[Token(Token = "0x6000ADC")]
	public bool SendSignal(HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg) { }

}

