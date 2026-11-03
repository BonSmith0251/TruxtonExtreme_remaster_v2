namespace Unity.XGamingRuntime;

[Token(Token = "0x2000113")]
public sealed class XStoreCanAcquireLicenseForPackageCompleted : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x6000684")]
	public XStoreCanAcquireLicenseForPackageCompleted(object object, IntPtr method) { }

	[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
	[Token(Token = "0x6000686")]
	public override IAsyncResult BeginInvoke(int hresult, XStoreCanAcquireLicenseResult result, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000687")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000685")]
	public override void Invoke(int hresult, XStoreCanAcquireLicenseResult result) { }

}

