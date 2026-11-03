namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x2000378")]
public sealed class CrossContextDelegate : MulticastDelegate
{

	[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
	[Token(Token = "0x6001BCC")]
	public CrossContextDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
	[Token(Token = "0x6001BCD")]
	public override void Invoke() { }

}

