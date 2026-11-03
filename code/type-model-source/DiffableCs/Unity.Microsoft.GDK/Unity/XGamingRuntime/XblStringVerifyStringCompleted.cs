namespace Unity.XGamingRuntime;

[Token(Token = "0x20001E9")]
public sealed class XblStringVerifyStringCompleted : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x6000A2B")]
	public XblStringVerifyStringCompleted(object object, IntPtr method) { }

	[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
	[Token(Token = "0x6000A2D")]
	public override IAsyncResult BeginInvoke(int hresult, XblVerifyStringResult result, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000A2E")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000A2C")]
	public override void Invoke(int hresult, XblVerifyStringResult result) { }

}

