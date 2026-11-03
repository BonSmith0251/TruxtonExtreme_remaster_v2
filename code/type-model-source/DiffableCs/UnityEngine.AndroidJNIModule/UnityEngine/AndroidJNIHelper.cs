namespace UnityEngine;

[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000C")]
[UsedByNativeCode]
public static class AndroidJNIHelper
{

	[Address(RVA = "0x2F9D0C0", Offset = "0x2F9C4C0", Length = "0x11B")]
	[Token(Token = "0x6000055")]
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	[Address(RVA = "0x2F9D000", Offset = "0x2F9C400", Length = "0x5D")]
	[Token(Token = "0x6000056")]
	public static IntPtr Box(int value) { }

	[Address(RVA = "0x2F9D060", Offset = "0x2F9C460", Length = "0x5E")]
	[Token(Token = "0x6000057")]
	public static IntPtr Box(bool value) { }

	[Address(RVA = "0x75C200", Offset = "0x75B600", Length = "0x60")]
	[Token(Token = "0x6000053")]
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	[Address(RVA = "0x2F9D320", Offset = "0x2F9C720", Length = "0x252")]
	[Token(Token = "0x600004F")]
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	[Address(RVA = "0x2F9D580", Offset = "0x2F9C980", Length = "0x140")]
	[Token(Token = "0x600004E")]
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[Address(RVA = "0x2F9D1E0", Offset = "0x2F9C5E0", Length = "0x13B")]
	[Token(Token = "0x6000050")]
	public static void CreateJNIArgArray(Object[] args, Span<jvalue> jniArgs) { }

	[Address(RVA = "0x2F9D6C0", Offset = "0x2F9CAC0", Length = "0x1A5")]
	[Token(Token = "0x6000051")]
	public static void DeleteJNIArgArray(Object[] args, Span<jvalue> jniArgs) { }

	[Address(RVA = "0x2F9DA70", Offset = "0x2F9CE70", Length = "0x59")]
	[Token(Token = "0x600004C")]
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	[Address(RVA = "0x2F9D870", Offset = "0x2F9CC70", Length = "0x1F0")]
	[Token(Token = "0x6000052")]
	public static IntPtr GetConstructorID(IntPtr jclass, Object[] args) { }

	[Address(RVA = "0x2F9DAD0", Offset = "0x2F9CED0", Length = "0x81")]
	[Token(Token = "0x600004D")]
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	[Address(RVA = "0x75C5D0", Offset = "0x75B9D0", Length = "0x9B")]
	[Token(Token = "0x6000054")]
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

}

