namespace Unity.XGamingRuntime;

[Token(Token = "0x20001D5")]
public sealed class XblSocialRelationshipChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x1B5CE70", Offset = "0x1B5C270", Length = "0xA6")]
	[Token(Token = "0x60009C0")]
	public XblSocialRelationshipChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B8C170", Offset = "0x2B8B570", Length = "0x80")]
	[Token(Token = "0x60009C2")]
	public override IAsyncResult BeginInvoke(XblSocialRelationshipChangeEventArgs eventArgs, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60009C3")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0xE2BDE0", Offset = "0xE2B1E0", Length = "0x2F")]
	[Token(Token = "0x60009C1")]
	public override void Invoke(XblSocialRelationshipChangeEventArgs eventArgs) { }

}

