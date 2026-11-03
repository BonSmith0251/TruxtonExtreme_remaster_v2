namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200037A")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XPackageEnumerationCallback : MulticastDelegate
{

	[Address(RVA = "0x2BA3410", Offset = "0x2BA2810", Length = "0xA6")]
	[Token(Token = "0x60011FE")]
	public XPackageEnumerationCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA3320", Offset = "0x2BA2720", Length = "0x97")]
	[Token(Token = "0x6001200")]
	public override IAsyncResult BeginInvoke(IntPtr context, XPackageDetails details, AsyncCallback callback, object object) { }

	[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
	[Token(Token = "0x6001201")]
	public override bool EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x2BA33C0", Offset = "0x2BA27C0", Length = "0x43")]
	[Token(Token = "0x60011FF")]
	public override bool Invoke(IntPtr context, XPackageDetails details) { }

}

