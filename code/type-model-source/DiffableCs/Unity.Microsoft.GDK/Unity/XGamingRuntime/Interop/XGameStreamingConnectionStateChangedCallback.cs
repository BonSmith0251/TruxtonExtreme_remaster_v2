namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000365")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XGameStreamingConnectionStateChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x60D870", Offset = "0x60CC70", Length = "0xA6")]
	[Token(Token = "0x60011E1")]
	public XGameStreamingConnectionStateChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA18A0", Offset = "0x2BA0CA0", Length = "0xAB")]
	[Token(Token = "0x60011E3")]
	public override IAsyncResult BeginInvoke(IntPtr context, XGameStreamingClientId client, XGameStreamingConnectionState state, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60011E4")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x60011E2")]
	public override void Invoke(IntPtr context, XGameStreamingClientId client, XGameStreamingConnectionState state) { }

}

