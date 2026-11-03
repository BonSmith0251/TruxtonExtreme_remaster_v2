namespace Unity.XGamingRuntime;

[Token(Token = "0x20001C4")]
public sealed class XblPrivacyGetMuteListCompleted : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x6000980")]
	public XblPrivacyGetMuteListCompleted(object object, IntPtr method) { }

	[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
	[Token(Token = "0x6000982")]
	public override IAsyncResult BeginInvoke(int hresult, UInt64[] xuids, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000983")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000981")]
	public override void Invoke(int hresult, UInt64[] xuids) { }

}

