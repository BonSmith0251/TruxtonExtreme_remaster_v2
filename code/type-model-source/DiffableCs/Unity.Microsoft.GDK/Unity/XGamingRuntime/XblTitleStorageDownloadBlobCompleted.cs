namespace Unity.XGamingRuntime;

[Token(Token = "0x20001F4")]
public sealed class XblTitleStorageDownloadBlobCompleted : MulticastDelegate
{

	[Address(RVA = "0x2B7E930", Offset = "0x2B7DD30", Length = "0xA6")]
	[Token(Token = "0x6000A5B")]
	public XblTitleStorageDownloadBlobCompleted(object object, IntPtr method) { }

	[Address(RVA = "0x2B8CA40", Offset = "0x2B8BE40", Length = "0x70")]
	[Token(Token = "0x6000A5D")]
	public override IAsyncResult BeginInvoke(int hresult, XblTitleStorageBlobMetadata result, Byte[] blobBuffer, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000A5E")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6000A5C")]
	public override void Invoke(int hresult, XblTitleStorageBlobMetadata result, Byte[] blobBuffer) { }

}

