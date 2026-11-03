namespace Unity.XGamingRuntime;

[Token(Token = "0x2000210")]
public sealed class XGameProtocolActivationCallback : MulticastDelegate
{

	[Address(RVA = "0x60DC10", Offset = "0x60D010", Length = "0xA6")]
	[Token(Token = "0x6000ADC")]
	public XGameProtocolActivationCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60DBA0", Offset = "0x60CFA0", Length = "0x6C")]
	[Token(Token = "0x6000ADE")]
	public override IAsyncResult BeginInvoke(IntPtr context, string protocolUri, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000ADF")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000ADD")]
	public override void Invoke(IntPtr context, string protocolUri) { }

}

