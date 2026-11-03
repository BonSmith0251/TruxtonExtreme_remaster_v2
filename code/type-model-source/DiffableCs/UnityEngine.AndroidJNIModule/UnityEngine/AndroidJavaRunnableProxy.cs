namespace UnityEngine;

[Token(Token = "0x2000005")]
internal class AndroidJavaRunnableProxy : AndroidJavaProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000004")]
	private AndroidJavaRunnable mRunnable; //Field offset: 0x20

	[Address(RVA = "0x2FA5840", Offset = "0x2FA4C40", Length = "0xDD")]
	[Token(Token = "0x6000009")]
	public AndroidJavaRunnableProxy(AndroidJavaRunnable runnable) { }

	[Address(RVA = "0x2FA5790", Offset = "0x2FA4B90", Length = "0xAB")]
	[Token(Token = "0x600000B")]
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	[Address(RVA = "0x2FA5920", Offset = "0x2FA4D20", Length = "0x25")]
	[Token(Token = "0x600000A")]
	public void run() { }

}

