namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002D0")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XAsyncProviderInterop : MulticastDelegate
{

	[Address(RVA = "0x2BA0230", Offset = "0x2B9F630", Length = "0xA6")]
	[Token(Token = "0x6000FB1")]
	public XAsyncProviderInterop(object object, IntPtr method) { }

	[Address(RVA = "0x2BA0150", Offset = "0x2B9F550", Length = "0xA2")]
	[Token(Token = "0x6000FB3")]
	public override IAsyncResult BeginInvoke(XAsyncOp op, XAsyncProviderData data, AsyncCallback callback, object object) { }

	[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
	[Token(Token = "0x6000FB4")]
	public override int EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x2BA0200", Offset = "0x2B9F600", Length = "0x2F")]
	[Token(Token = "0x6000FB2")]
	public override int Invoke(XAsyncOp op, XAsyncProviderData data) { }

}

