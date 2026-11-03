namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x2000222")]
public sealed class ContextCallback : MulticastDelegate
{

	[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
	[Token(Token = "0x600124C")]
	public ContextCallback(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x600124D")]
	public override void Invoke(object state) { }

}

