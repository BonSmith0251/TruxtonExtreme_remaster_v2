namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000354")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XGameInviteEventCallback : MulticastDelegate
{

	[Address(RVA = "0x60DC10", Offset = "0x60D010", Length = "0xA6")]
	[Token(Token = "0x60011C0")]
	public XGameInviteEventCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60DBA0", Offset = "0x60CFA0", Length = "0x6C")]
	[Token(Token = "0x60011C2")]
	public override IAsyncResult BeginInvoke(IntPtr context, string inviteUri, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60011C3")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x60011C1")]
	public override void Invoke(IntPtr context, string inviteUri) { }

}

