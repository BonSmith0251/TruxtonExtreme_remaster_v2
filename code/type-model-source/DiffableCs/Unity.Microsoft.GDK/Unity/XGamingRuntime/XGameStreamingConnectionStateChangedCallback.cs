namespace Unity.XGamingRuntime;

[Token(Token = "0x200022C")]
public sealed class XGameStreamingConnectionStateChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x2B81150", Offset = "0x2B80550", Length = "0xA6")]
	[Token(Token = "0x6000B5B")]
	public XGameStreamingConnectionStateChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B810B0", Offset = "0x2B804B0", Length = "0x96")]
	[Token(Token = "0x6000B5D")]
	public override IAsyncResult BeginInvoke(IntPtr context, XGameStreamingClientId client, XGameStreamingConnectionState state, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000B5E")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6000B5C")]
	public override void Invoke(IntPtr context, XGameStreamingClientId client, XGameStreamingConnectionState state) { }

}

