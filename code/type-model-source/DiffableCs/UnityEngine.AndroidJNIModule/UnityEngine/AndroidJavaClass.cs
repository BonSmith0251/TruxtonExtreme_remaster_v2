namespace UnityEngine;

[Token(Token = "0x2000008")]
public class AndroidJavaClass : AndroidJavaObject
{

	[Address(RVA = "0x2FA3320", Offset = "0x2FA2720", Length = "0x187")]
	[Token(Token = "0x600002E")]
	private void _AndroidJavaClass(string className) { }

	[Address(RVA = "0x2FA35B0", Offset = "0x2FA29B0", Length = "0x18E")]
	[Token(Token = "0x600002D")]
	public AndroidJavaClass(string className) { }

	[Address(RVA = "0x2FA34B0", Offset = "0x2FA28B0", Length = "0xFF")]
	[Token(Token = "0x600002F")]
	internal AndroidJavaClass(IntPtr jclass) { }

}

