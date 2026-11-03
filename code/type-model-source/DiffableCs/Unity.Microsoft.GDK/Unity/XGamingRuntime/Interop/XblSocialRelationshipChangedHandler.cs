namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000338")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
public sealed class XblSocialRelationshipChangedHandler : MulticastDelegate
{

	[Address(RVA = "0x639C90", Offset = "0x639090", Length = "0xB5")]
	[Token(Token = "0x60011A8")]
	public XblSocialRelationshipChangedHandler(object object, IntPtr method) { }

	[Address(RVA = "0x2B80E70", Offset = "0x2B80270", Length = "0x59")]
	[Token(Token = "0x60011AA")]
	public override IAsyncResult BeginInvoke(XblSocialRelationshipChangeEventArgs* eventArgs, IntPtr context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60011AB")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x60011A9")]
	public override void Invoke(XblSocialRelationshipChangeEventArgs* eventArgs, IntPtr context) { }

}

