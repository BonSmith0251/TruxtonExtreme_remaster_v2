namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200035B")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XGameSaveContainerInfoCallback : MulticastDelegate
{

	[Address(RVA = "0x2BA1680", Offset = "0x2BA0A80", Length = "0xA6")]
	[Token(Token = "0x60011D0")]
	public XGameSaveContainerInfoCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA15E0", Offset = "0x2BA09E0", Length = "0x97")]
	[Token(Token = "0x60011D2")]
	public override IAsyncResult BeginInvoke(XGameSaveContainerInfo info, IntPtr context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
	[Token(Token = "0x60011D3")]
	public override bool EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x1C14CC0", Offset = "0x1C140C0", Length = "0x36")]
	[Token(Token = "0x60011D1")]
	public override bool Invoke(XGameSaveContainerInfo info, IntPtr context) { }

}

