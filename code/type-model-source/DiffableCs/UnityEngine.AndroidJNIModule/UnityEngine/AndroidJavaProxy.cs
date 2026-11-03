namespace UnityEngine;

[Token(Token = "0x2000006")]
public class AndroidJavaProxy
{
	[Token(Token = "0x4000007")]
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; //Field offset: 0x0
	[Token(Token = "0x4000008")]
	private static readonly IntPtr s_HashCodeMethodID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000005")]
	public readonly AndroidJavaClass javaInterface; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000006")]
	internal IntPtr proxyObject; //Field offset: 0x18

	[Address(RVA = "0x2FA53B0", Offset = "0x2FA47B0", Length = "0x17F")]
	[Token(Token = "0x6000017")]
	private static AndroidJavaProxy() { }

	[Address(RVA = "0x2FA5530", Offset = "0x2FA4930", Length = "0x7F")]
	[Token(Token = "0x600000C")]
	public AndroidJavaProxy(string javaInterface) { }

	[Address(RVA = "0x2FA55B0", Offset = "0x2FA49B0", Length = "0x39")]
	[Token(Token = "0x600000D")]
	public AndroidJavaProxy(AndroidJavaClass javaInterface) { }

	[Address(RVA = "0x2FA55F0", Offset = "0x2FA49F0", Length = "0x5C")]
	[Token(Token = "0x6000012")]
	public override bool equals(AndroidJavaObject obj) { }

	[Address(RVA = "0x2FA4310", Offset = "0x2FA3710", Length = "0x7E")]
	[Token(Token = "0x600000E")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2FA4390", Offset = "0x2FA3790", Length = "0x19")]
	[Token(Token = "0x6000015")]
	internal AndroidJavaObject GetProxyObject() { }

	[Address(RVA = "0x2FA43B0", Offset = "0x2FA37B0", Length = "0xB4")]
	[Token(Token = "0x6000016")]
	internal IntPtr GetRawProxy() { }

	[Address(RVA = "0x2FA5650", Offset = "0x2FA4A50", Length = "0xD7")]
	[Token(Token = "0x6000013")]
	public override int hashCode() { }

	[Address(RVA = "0x2FA4470", Offset = "0x2FA3870", Length = "0x9D1")]
	[Token(Token = "0x600000F")]
	public override AndroidJavaObject Invoke(string methodName, Object[] args) { }

	[Address(RVA = "0x2FA4E50", Offset = "0x2FA4250", Length = "0x1C7")]
	[Token(Token = "0x6000010")]
	public override AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	[Address(RVA = "0x2FA5020", Offset = "0x2FA4420", Length = "0x386")]
	[Token(Token = "0x6000011")]
	public override IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	[Address(RVA = "0x2FA5730", Offset = "0x2FA4B30", Length = "0x5B")]
	[Token(Token = "0x6000014")]
	public override string toString() { }

}

