namespace UnityEngine;

[Token(Token = "0x200000A")]
[UsedByNativeCode]
internal sealed class _AndroidJNIHelper
{
	[Token(Token = "0x4000014")]
	private static int FRAME_SIZE_FOR_ARRAYS; //Field offset: 0x0

	[Address(RVA = "0x2FAB250", Offset = "0x2FAA650", Length = "0x39")]
	[Token(Token = "0x600004B")]
	private static _AndroidJNIHelper() { }

	[Address(RVA = "0x2FA6650", Offset = "0x2FA5A50", Length = "0xEED")]
	[Token(Token = "0x600003F")]
	public static AndroidJavaObject Box(object obj) { }

	[Address(RVA = "0x9EB520", Offset = "0x9EA920", Length = "0xC28")]
	[Token(Token = "0x6000042")]
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	[Address(RVA = "0x2FA7540", Offset = "0x2FA6940", Length = "0xD11")]
	[Token(Token = "0x6000041")]
	public static IntPtr ConvertToJNIArray(Array array) { }

	[Address(RVA = "0x2FA8A30", Offset = "0x2FA7E30", Length = "0x1A0")]
	[Token(Token = "0x6000039")]
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	[Address(RVA = "0x2FA8BE0", Offset = "0x2FA7FE0", Length = "0x10F")]
	[Token(Token = "0x600003A")]
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[Address(RVA = "0x2FA8260", Offset = "0x2FA7660", Length = "0x7C6")]
	[Token(Token = "0x600003C")]
	public static void CreateJNIArgArray(Object[] args, Span<jvalue> ret) { }

	[Address(RVA = "0x2FA8CF0", Offset = "0x2FA80F0", Length = "0x152")]
	[Token(Token = "0x6000040")]
	public static void DeleteJNIArgArray(Object[] args, Span<jvalue> jniArgs) { }

	[Address(RVA = "0x2FA8FA0", Offset = "0x2FA83A0", Length = "0x1BF")]
	[Token(Token = "0x6000043")]
	public static IntPtr GetConstructorID(IntPtr jclass, Object[] args) { }

	[Address(RVA = "0x2FA8E50", Offset = "0x2FA8250", Length = "0x14A")]
	[Token(Token = "0x6000045")]
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	[Address(RVA = "0x9FF860", Offset = "0x9FEC60", Length = "0xA7")]
	[Token(Token = "0x6000044")]
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

	[Address(RVA = "0x2FA9190", Offset = "0x2FA8590", Length = "0x17F")]
	[Token(Token = "0x6000046")]
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	[Address(RVA = "0x2FA9160", Offset = "0x2FA8560", Length = "0x25")]
	[Token(Token = "0x6000047")]
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	[Address(RVA = "0x9FF9C0", Offset = "0x9FEDC0", Length = "0x1F5")]
	[Token(Token = "0x600004A")]
	public static string GetSignature(Object[] args) { }

	[Address(RVA = "0x2FA9460", Offset = "0x2FA8860", Length = "0xD91")]
	[Token(Token = "0x6000048")]
	public static string GetSignature(object obj) { }

	[Address(RVA = "0x2FA9310", Offset = "0x2FA8710", Length = "0x14C")]
	[Token(Token = "0x6000049")]
	public static string GetSignature(Object[] args) { }

	[Address(RVA = "0x2FAA200", Offset = "0x2FA9600", Length = "0x7F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600003B")]
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	[Address(RVA = "0x2FAA980", Offset = "0x2FA9D80", Length = "0x8CF")]
	[Token(Token = "0x600003E")]
	public static object Unbox(AndroidJavaObject obj) { }

	[Address(RVA = "0x2FAA280", Offset = "0x2FA9680", Length = "0x6F3")]
	[Token(Token = "0x600003D")]
	public static object UnboxArray(AndroidJavaObject obj) { }

}

