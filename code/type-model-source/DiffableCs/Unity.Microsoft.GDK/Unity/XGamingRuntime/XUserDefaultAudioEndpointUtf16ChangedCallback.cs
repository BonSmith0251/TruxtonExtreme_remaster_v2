namespace Unity.XGamingRuntime;

[Token(Token = "0x20002A1")]
public sealed class XUserDefaultAudioEndpointUtf16ChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x2B84750", Offset = "0x2B83B50", Length = "0xA6")]
	[Token(Token = "0x6000DAB")]
	public XUserDefaultAudioEndpointUtf16ChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B846A0", Offset = "0x2B83AA0", Length = "0xB0")]
	[Token(Token = "0x6000DAD")]
	public override IAsyncResult BeginInvoke(IntPtr context, XUserLocalId user, XUserDefaultAudioEndpointKind defaultAudioEndpointKind, string endpointIdUtf16, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000DAE")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
	[Token(Token = "0x6000DAC")]
	public override void Invoke(IntPtr context, XUserLocalId user, XUserDefaultAudioEndpointKind defaultAudioEndpointKind, string endpointIdUtf16) { }

}

