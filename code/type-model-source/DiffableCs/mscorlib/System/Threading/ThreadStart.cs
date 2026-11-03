namespace System.Threading;

[Token(Token = "0x20001FC")]
public sealed class ThreadStart : MulticastDelegate
{

	[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
	[Token(Token = "0x6001190")]
	public ThreadStart(object object, IntPtr method) { }

	[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
	[Token(Token = "0x6001191")]
	public override void Invoke() { }

}

