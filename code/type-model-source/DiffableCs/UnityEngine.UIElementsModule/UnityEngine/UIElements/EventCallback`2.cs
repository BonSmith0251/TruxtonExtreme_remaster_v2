namespace UnityEngine.UIElements;

[Token(Token = "0x20001CA")]
public sealed class EventCallback : MulticastDelegate
{

	[Address(RVA = "0x1BAC980", Offset = "0x1BABD80", Length = "0x125")]
	[Token(Token = "0x6000D08")]
	public EventCallback`2(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000D09")]
	public override void Invoke(TEventType evt, TCallbackArgs userArgs) { }

}

