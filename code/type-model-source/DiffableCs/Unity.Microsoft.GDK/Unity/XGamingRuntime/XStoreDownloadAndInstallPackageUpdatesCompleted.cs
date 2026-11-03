namespace Unity.XGamingRuntime;

[Token(Token = "0x200012B")]
public sealed class XStoreDownloadAndInstallPackageUpdatesCompleted : MulticastDelegate
{

	[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
	[Token(Token = "0x60006E4")]
	public XStoreDownloadAndInstallPackageUpdatesCompleted(object object, IntPtr method) { }

	[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
	[Token(Token = "0x60006E6")]
	public override IAsyncResult BeginInvoke(int hresult, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60006E7")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x60006E5")]
	public override void Invoke(int hresult) { }

}

