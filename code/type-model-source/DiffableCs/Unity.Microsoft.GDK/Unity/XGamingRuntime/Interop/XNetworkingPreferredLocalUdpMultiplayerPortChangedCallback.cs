namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000372")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x2B81970", Offset = "0x2B80D70", Length = "0xA6")]
	[Token(Token = "0x60011F1")]
	public XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B818F0", Offset = "0x2B80CF0", Length = "0x76")]
	[Token(Token = "0x60011F3")]
	public override IAsyncResult BeginInvoke(IntPtr context, ushort preferredLocalUdpMultiplayerPort, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60011F4")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x60011F2")]
	public override void Invoke(IntPtr context, ushort preferredLocalUdpMultiplayerPort) { }

}

