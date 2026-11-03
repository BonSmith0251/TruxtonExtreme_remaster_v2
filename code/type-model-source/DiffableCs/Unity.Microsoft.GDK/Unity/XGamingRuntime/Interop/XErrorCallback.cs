namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000352")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XErrorCallback : MulticastDelegate
{

	[Address(RVA = "0x2B80BC0", Offset = "0x2B7FFC0", Length = "0xA6")]
	[Token(Token = "0x60011B8")]
	public XErrorCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B7E8B0", Offset = "0x2B7DCB0", Length = "0x79")]
	[Token(Token = "0x60011BA")]
	public override IAsyncResult BeginInvoke(int hr, string msg, IntPtr context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
	[Token(Token = "0x60011BB")]
	public override bool EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x60011B9")]
	public override bool Invoke(int hr, string msg, IntPtr context) { }

}

