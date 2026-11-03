namespace UnityEngine;

[Token(Token = "0x2000007")]
public class AndroidJavaObject : IDisposable
{
	[Token(Token = "0x4000009")]
	private static bool enableDebugPrints; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000A")]
	internal GlobalJavaObjectRef m_jobject; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000B")]
	internal GlobalJavaObjectRef m_jclass; //Field offset: 0x18

	[Address(RVA = "0x2FA3C50", Offset = "0x2FA3050", Length = "0x342")]
	[Token(Token = "0x6000021")]
	private void _AndroidJavaObject(IntPtr constructorID, Object[] args) { }

	[Address(RVA = "0x2FA3A90", Offset = "0x2FA2E90", Length = "0x1B6")]
	[Token(Token = "0x6000020")]
	private void _AndroidJavaObject(string className, Object[] args) { }

	[Address(RVA = "0x7606C0", Offset = "0x75FAC0", Length = "0xF55")]
	[Token(Token = "0x6000026")]
	protected ReturnType _Call(IntPtr methodID, Object[] args) { }

	[Address(RVA = "0x7605F0", Offset = "0x75F9F0", Length = "0xCA")]
	[Token(Token = "0x6000025")]
	protected ReturnType _Call(string methodName, Object[] args) { }

	[Address(RVA = "0x75E830", Offset = "0x75DC30", Length = "0xE6A")]
	[Token(Token = "0x6000028")]
	protected ReturnType _CallStatic(IntPtr methodID, Object[] args) { }

	[Address(RVA = "0x75F6A0", Offset = "0x75EAA0", Length = "0x81")]
	[Token(Token = "0x6000027")]
	protected ReturnType _CallStatic(string methodName, Object[] args) { }

	[Address(RVA = "0x21B18A0", Offset = "0x21B0CA0", Length = "0x1B")]
	[Token(Token = "0x600002C")]
	protected IntPtr _GetRawClass() { }

	[Address(RVA = "0x2FA3A70", Offset = "0x2FA2E70", Length = "0x13")]
	[Token(Token = "0x600002B")]
	protected IntPtr _GetRawObject() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000022")]
	internal AndroidJavaObject() { }

	[Address(RVA = "0x2FA3FA0", Offset = "0x2FA33A0", Length = "0x1AA")]
	[Token(Token = "0x6000019")]
	public AndroidJavaObject(IntPtr jobject) { }

	[Address(RVA = "0x2FA4150", Offset = "0x2FA3550", Length = "0x1BD")]
	[Token(Token = "0x6000018")]
	public AndroidJavaObject(string className, Object[] args) { }

	[Address(RVA = "0x2FA37F0", Offset = "0x2FA2BF0", Length = "0xC4")]
	[Token(Token = "0x6000029")]
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	[Address(RVA = "0x75C960", Offset = "0x75BD60", Length = "0xE0")]
	[Token(Token = "0x600001D")]
	public ReturnType Call(string methodName, Object[] args) { }

	[Address(RVA = "0x75C820", Offset = "0x75BC20", Length = "0x97")]
	[Token(Token = "0x600001E")]
	public ReturnType CallStatic(string methodName, Object[] args) { }

	[Address(RVA = "0x2FA38C0", Offset = "0x2FA2CC0", Length = "0x6E")]
	[Token(Token = "0x600001F")]
	protected void DebugPrint(string msg) { }

	[Address(RVA = "0x2FA39A0", Offset = "0x2FA2DA0", Length = "0xC6")]
	[Token(Token = "0x6000024")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2FA3930", Offset = "0x2FA2D30", Length = "0x61")]
	[Token(Token = "0x600001A")]
	public override void Dispose() { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x6000023")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x75CF00", Offset = "0x75C300", Length = "0xF8")]
	[Token(Token = "0x600002A")]
	internal static ReturnType FromJavaArray(IntPtr jobject) { }

	[Address(RVA = "0x21B18A0", Offset = "0x21B0CA0", Length = "0x1B")]
	[Token(Token = "0x600001C")]
	public IntPtr GetRawClass() { }

	[Address(RVA = "0x2FA3A70", Offset = "0x2FA2E70", Length = "0x13")]
	[Token(Token = "0x600001B")]
	public IntPtr GetRawObject() { }

}

