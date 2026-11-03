namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003A5")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XUserDefaultAudioEndpointUtf16ChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x2BA17F0", Offset = "0x2BA0BF0", Length = "0xA6")]
	[Token(Token = "0x6001254")]
	public XUserDefaultAudioEndpointUtf16ChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA57F0", Offset = "0x2BA4BF0", Length = "0xC5")]
	[Token(Token = "0x6001256")]
	public override IAsyncResult BeginInvoke(IntPtr context, XUserLocalId user, XUserDefaultAudioEndpointKind defaultAudioEndpointKind, string endpointIdUtf16, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6001257")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
	[Token(Token = "0x6001255")]
	public override void Invoke(IntPtr context, XUserLocalId user, XUserDefaultAudioEndpointKind defaultAudioEndpointKind, string endpointIdUtf16) { }

}

