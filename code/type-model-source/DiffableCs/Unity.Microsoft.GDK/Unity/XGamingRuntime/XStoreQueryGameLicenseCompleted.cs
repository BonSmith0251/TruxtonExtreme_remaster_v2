namespace Unity.XGamingRuntime;

[Token(Token = "0x2000116")]
public sealed class XStoreQueryGameLicenseCompleted : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x6000690")]
	public XStoreQueryGameLicenseCompleted(object object, IntPtr method) { }

	[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
	[Token(Token = "0x6000692")]
	public override IAsyncResult BeginInvoke(int hresult, XStoreGameLicense license, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000693")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000691")]
	public override void Invoke(int hresult, XStoreGameLicense license) { }

}

