namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x200024D")]
public sealed class TimerCallback : MulticastDelegate
{

	[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
	[Token(Token = "0x6001392")]
	public TimerCallback(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6001393")]
	public override void Invoke(object state) { }

}

