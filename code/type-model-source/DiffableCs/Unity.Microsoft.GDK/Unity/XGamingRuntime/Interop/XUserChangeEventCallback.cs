namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003A4")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XUserChangeEventCallback : MulticastDelegate
{

	[Address(RVA = "0x60D870", Offset = "0x60CC70", Length = "0xA6")]
	[Token(Token = "0x6001250")]
	public XUserChangeEventCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA5380", Offset = "0x2BA4780", Length = "0xAB")]
	[Token(Token = "0x6001252")]
	public override IAsyncResult BeginInvoke(IntPtr context, XUserLocalId userLocalId, XUserChangeEvent changeEvent, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6001253")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6001251")]
	public override void Invoke(IntPtr context, XUserLocalId userLocalId, XUserChangeEvent changeEvent) { }

}

