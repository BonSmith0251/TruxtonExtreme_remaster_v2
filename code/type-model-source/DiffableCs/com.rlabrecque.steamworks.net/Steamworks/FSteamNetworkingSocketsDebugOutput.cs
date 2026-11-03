namespace Steamworks;

[Token(Token = "0x20001D9")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
public sealed class FSteamNetworkingSocketsDebugOutput : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x6000AE0")]
	public FSteamNetworkingSocketsDebugOutput(object object, IntPtr method) { }

	[Address(RVA = "0x60A0E0", Offset = "0x6094E0", Length = "0x87")]
	[Token(Token = "0x6000AE2")]
	public override IAsyncResult BeginInvoke(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000AE3")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000AE1")]
	public override void Invoke(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg) { }

}

