namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x2000237")]
public sealed class WaitOrTimerCallback : MulticastDelegate
{

	[Address(RVA = "0x1C4B400", Offset = "0x1C4A800", Length = "0x125")]
	[Token(Token = "0x60012FA")]
	public WaitOrTimerCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x60012FB")]
	public override void Invoke(object state, bool timedOut) { }

}

