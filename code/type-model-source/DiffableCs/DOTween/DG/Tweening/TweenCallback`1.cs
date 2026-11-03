namespace DG.Tweening;

[Token(Token = "0x2000006")]
public sealed class TweenCallback : MulticastDelegate
{

	[Address(RVA = "0x10AAF90", Offset = "0x10AA390", Length = "0xA6")]
	[Token(Token = "0x6000009")]
	public TweenCallback`1(object object, IntPtr method) { }

	[Address(RVA = "0x10AAE20", Offset = "0x10AA220", Length = "0x80")]
	[Token(Token = "0x600000B")]
	public override IAsyncResult BeginInvoke(T value, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x600000C")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0xE2BBB0", Offset = "0xE2AFB0", Length = "0x24")]
	[Token(Token = "0x600000A")]
	public override void Invoke(T value) { }

}

