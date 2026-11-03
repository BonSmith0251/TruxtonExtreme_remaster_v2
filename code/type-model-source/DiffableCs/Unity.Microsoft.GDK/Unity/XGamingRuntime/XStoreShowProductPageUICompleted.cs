namespace Unity.XGamingRuntime;

[Token(Token = "0x200010F")]
public sealed class XStoreShowProductPageUICompleted : MulticastDelegate
{

	[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
	[Token(Token = "0x6000674")]
	public XStoreShowProductPageUICompleted(object object, IntPtr method) { }

	[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
	[Token(Token = "0x6000676")]
	public override IAsyncResult BeginInvoke(int hresult, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000677")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000675")]
	public override void Invoke(int hresult) { }

}

