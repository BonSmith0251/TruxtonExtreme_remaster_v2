namespace Steamworks;

[Token(Token = "0x20001D8")]
public struct ISteamNetworkingSignalingRecvContext
{

	[Address(RVA = "0x60D180", Offset = "0x60C580", Length = "0xA0")]
	[Token(Token = "0x6000ADE")]
	public IntPtr OnConnectRequest(HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort) { }

	[Address(RVA = "0x60D220", Offset = "0x60C620", Length = "0xA2")]
	[Token(Token = "0x6000ADF")]
	public void SendRejectionSignal(ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg) { }

}

