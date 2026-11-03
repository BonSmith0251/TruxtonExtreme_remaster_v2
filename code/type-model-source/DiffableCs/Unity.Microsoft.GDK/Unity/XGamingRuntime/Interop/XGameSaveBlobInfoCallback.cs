namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200035A")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XGameSaveBlobInfoCallback : MulticastDelegate
{

	[Address(RVA = "0x2BA1530", Offset = "0x2BA0930", Length = "0xA6")]
	[Token(Token = "0x60011CC")]
	public XGameSaveBlobInfoCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA1490", Offset = "0x2BA0890", Length = "0x97")]
	[Token(Token = "0x60011CE")]
	public override IAsyncResult BeginInvoke(XGameSaveBlobInfo info, IntPtr context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
	[Token(Token = "0x60011CF")]
	public override bool EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0xF769C0", Offset = "0xF75DC0", Length = "0x24")]
	[Token(Token = "0x60011CD")]
	public override bool Invoke(XGameSaveBlobInfo info, IntPtr context) { }

}

