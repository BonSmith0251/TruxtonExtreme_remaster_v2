namespace Unity.XGamingRuntime;

[Token(Token = "0x20001CF")]
public sealed class XblConnectionResyncCallback : MulticastDelegate
{

	[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
	[Token(Token = "0x60009B4")]
	public XblConnectionResyncCallback(object object, IntPtr method) { }

	[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
	[Token(Token = "0x60009B6")]
	public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60009B7")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
	[Token(Token = "0x60009B5")]
	public override void Invoke() { }

}

