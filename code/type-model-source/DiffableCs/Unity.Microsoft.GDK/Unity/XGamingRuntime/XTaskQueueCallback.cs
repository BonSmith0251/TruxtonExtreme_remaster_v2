namespace Unity.XGamingRuntime;

[Token(Token = "0x2000285")]
public sealed class XTaskQueueCallback : MulticastDelegate
{

	[Address(RVA = "0x2B83EF0", Offset = "0x2B832F0", Length = "0xA6")]
	[Token(Token = "0x6000D4B")]
	public XTaskQueueCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B83E70", Offset = "0x2B83270", Length = "0x75")]
	[Token(Token = "0x6000D4D")]
	public override IAsyncResult BeginInvoke(IntPtr context, bool canceled, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000D4E")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000D4C")]
	public override void Invoke(IntPtr context, bool canceled) { }

}

