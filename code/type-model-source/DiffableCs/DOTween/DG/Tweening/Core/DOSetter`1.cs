namespace DG.Tweening.Core;

[Token(Token = "0x20000A0")]
public sealed class DOSetter : MulticastDelegate
{

	[Address(RVA = "0x10AAF90", Offset = "0x10AA390", Length = "0xA6")]
	[Token(Token = "0x60003B0")]
	public DOSetter`1(object object, IntPtr method) { }

	[Address(RVA = "0x17CA380", Offset = "0x17C9780", Length = "0x80")]
	[Token(Token = "0x60003B2")]
	public override IAsyncResult BeginInvoke(T pNewValue, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60003B3")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0xE2BBB0", Offset = "0xE2AFB0", Length = "0x24")]
	[Token(Token = "0x60003B1")]
	public override void Invoke(T pNewValue) { }

}

