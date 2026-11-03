namespace Unity.XGamingRuntime;

[Token(Token = "0x200022B")]
public sealed class XGameStreamingClientPropertiesChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x60D9B0", Offset = "0x60CDB0", Length = "0xA6")]
	[Token(Token = "0x6000B57")]
	public XGameStreamingClientPropertiesChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B81030", Offset = "0x2B80430", Length = "0x71")]
	[Token(Token = "0x6000B59")]
	public override IAsyncResult BeginInvoke(IntPtr context, XGameStreamingClientId client, XGameStreamingClientProperty[] updatedProperties, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000B5A")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6000B58")]
	public override void Invoke(IntPtr context, XGameStreamingClientId client, XGameStreamingClientProperty[] updatedProperties) { }

}

