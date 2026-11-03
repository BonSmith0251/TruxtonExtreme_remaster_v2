namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002CE")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XAsyncWorkInterop : MulticastDelegate
{

	[Address(RVA = "0x1C11BF0", Offset = "0x1C10FF0", Length = "0xA6")]
	[Token(Token = "0x6000FAD")]
	public XAsyncWorkInterop(object object, IntPtr method) { }

	[Address(RVA = "0x60D690", Offset = "0x60CA90", Length = "0x5E")]
	[Token(Token = "0x6000FAF")]
	public override IAsyncResult BeginInvoke(IntPtr asyncBlock, AsyncCallback callback, object object) { }

	[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
	[Token(Token = "0x6000FB0")]
	public override int EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000FAE")]
	public override int Invoke(IntPtr asyncBlock) { }

}

