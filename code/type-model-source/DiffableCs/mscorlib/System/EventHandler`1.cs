namespace System;

[Token(Token = "0x20000D2")]
public sealed class EventHandler : MulticastDelegate
{

	[Address(RVA = "0x1BACB40", Offset = "0x1BABF40", Length = "0x125")]
	[Token(Token = "0x600069F")]
	public EventHandler`1(object object, IntPtr method) { }

	[Address(RVA = "0x1BACAB0", Offset = "0x1BABEB0", Length = "0x89")]
	[Token(Token = "0x60006A0")]
	public override void Invoke(object sender, TEventArgs e) { }

}

