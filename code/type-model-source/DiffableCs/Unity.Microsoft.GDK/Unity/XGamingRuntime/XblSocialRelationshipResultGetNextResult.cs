namespace Unity.XGamingRuntime;

[Token(Token = "0x20001D4")]
public sealed class XblSocialRelationshipResultGetNextResult : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x60009BC")]
	public XblSocialRelationshipResultGetNextResult(object object, IntPtr method) { }

	[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
	[Token(Token = "0x60009BE")]
	public override IAsyncResult BeginInvoke(int hresult, XblSocialRelationshipResult handle, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60009BF")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x60009BD")]
	public override void Invoke(int hresult, XblSocialRelationshipResult handle) { }

}

