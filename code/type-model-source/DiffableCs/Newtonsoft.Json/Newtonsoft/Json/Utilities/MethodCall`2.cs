namespace Newtonsoft.Json.Utilities;

[Token(Token = "0x20000DE")]
internal sealed class MethodCall : MulticastDelegate
{

	[Address(RVA = "0xD0F0A0", Offset = "0xD0E4A0", Length = "0x125")]
	[Token(Token = "0x600067F")]
	public MethodCall`2(object object, IntPtr method) { }

	[Address(RVA = "0x639C50", Offset = "0x639050", Length = "0x31")]
	[Token(Token = "0x6000681")]
	public override IAsyncResult BeginInvoke(T target, Object[] args, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000682")]
	public override TResult EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[NullableContext(1)]
	[Token(Token = "0x6000680")]
	public override TResult Invoke(T target, Object[] args) { }

}

