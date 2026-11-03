namespace Unity.XGamingRuntime;

[Token(Token = "0x20001CE")]
public sealed class XblConnectionStateChangeCallback : MulticastDelegate
{

	[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
	[Token(Token = "0x60009B0")]
	public XblConnectionStateChangeCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B84D60", Offset = "0x2B84160", Length = "0x79")]
	[Token(Token = "0x60009B2")]
	public override IAsyncResult BeginInvoke(XblRealTimeActivityConnectionState newConnectionState, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60009B3")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x60009B1")]
	public override void Invoke(XblRealTimeActivityConnectionState newConnectionState) { }

}

