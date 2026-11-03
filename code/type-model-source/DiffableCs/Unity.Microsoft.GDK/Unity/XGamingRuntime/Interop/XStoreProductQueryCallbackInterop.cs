namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000393")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XStoreProductQueryCallbackInterop : MulticastDelegate
{

	[Address(RVA = "0x2BA4150", Offset = "0x2BA3550", Length = "0xB5")]
	[Token(Token = "0x600121E")]
	public XStoreProductQueryCallbackInterop(object object, IntPtr method) { }

	[Address(RVA = "0x2BA4210", Offset = "0x2BA3610", Length = "0x97")]
	[Token(Token = "0x6001220")]
	public override IAsyncResult BeginInvoke(in XStoreProductInterop product, IntPtr context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2B824D0", Offset = "0x2B818D0", Length = "0x30")]
	[Token(Token = "0x6001221")]
	public override bool EndInvoke(in XStoreProductInterop product, IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x600121F")]
	public override bool Invoke(in XStoreProductInterop product, IntPtr context) { }

}

