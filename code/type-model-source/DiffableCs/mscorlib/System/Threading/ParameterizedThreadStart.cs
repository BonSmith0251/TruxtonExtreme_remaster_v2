namespace System.Threading;

[Token(Token = "0x20001F8")]
public sealed class ParameterizedThreadStart : MulticastDelegate
{

	[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
	[Token(Token = "0x6001187")]
	public ParameterizedThreadStart(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6001188")]
	public override void Invoke(object obj) { }

}

