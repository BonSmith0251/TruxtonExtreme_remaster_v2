namespace Unity.XGamingRuntime;

[Token(Token = "0x2000130")]
public sealed class XGameUiShowMessageDialogCompleted : MulticastDelegate
{

	[Address(RVA = "0x1C4BA50", Offset = "0x1C4AE50", Length = "0xA6")]
	[Token(Token = "0x60006F8")]
	public XGameUiShowMessageDialogCompleted(object object, IntPtr method) { }

	[Address(RVA = "0x2B7CD10", Offset = "0x2B7C110", Length = "0x90")]
	[Token(Token = "0x60006FA")]
	public override IAsyncResult BeginInvoke(int hresult, XGameUiMessageDialogButton resultButton, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60006FB")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x60006F9")]
	public override void Invoke(int hresult, XGameUiMessageDialogButton resultButton) { }

}

