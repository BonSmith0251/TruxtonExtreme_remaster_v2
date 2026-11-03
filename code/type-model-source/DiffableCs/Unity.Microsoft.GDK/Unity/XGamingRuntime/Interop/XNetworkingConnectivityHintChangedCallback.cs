namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000371")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XNetworkingConnectivityHintChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x2BA29B0", Offset = "0x2BA1DB0", Length = "0xA6")]
	[Token(Token = "0x60011ED")]
	public XNetworkingConnectivityHintChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA2910", Offset = "0x2BA1D10", Length = "0x97")]
	[Token(Token = "0x60011EF")]
	public override IAsyncResult BeginInvoke(IntPtr context, XNetworkingConnectivityHint connectivityHint, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60011F0")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x169F5F0", Offset = "0x169E9F0", Length = "0x25")]
	[Token(Token = "0x60011EE")]
	public override void Invoke(IntPtr context, XNetworkingConnectivityHint connectivityHint) { }

}

