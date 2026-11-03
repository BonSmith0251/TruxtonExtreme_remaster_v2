namespace Unity.XGamingRuntime;

[Token(Token = "0x2000242")]
public sealed class XNetworkingConnectivityHintChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x60DC10", Offset = "0x60D010", Length = "0xA6")]
	[Token(Token = "0x6000BAD")]
	public XNetworkingConnectivityHintChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60DBA0", Offset = "0x60CFA0", Length = "0x6C")]
	[Token(Token = "0x6000BAF")]
	public override IAsyncResult BeginInvoke(IntPtr context, XNetworkingConnectivityHint connectivityHint, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000BB0")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000BAE")]
	public override void Invoke(IntPtr context, XNetworkingConnectivityHint connectivityHint) { }

}

