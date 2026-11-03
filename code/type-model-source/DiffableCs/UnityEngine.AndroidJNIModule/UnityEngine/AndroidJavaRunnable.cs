namespace UnityEngine;

[Token(Token = "0x2000002")]
public sealed class AndroidJavaRunnable : MulticastDelegate
{

	[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
	[Token(Token = "0x6000001")]
	public AndroidJavaRunnable(object object, IntPtr method) { }

	[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
	[Token(Token = "0x6000002")]
	public override void Invoke() { }

}

