namespace UnityEngine;

[Token(Token = "0x2000009")]
internal class AndroidReflection
{
	[Token(Token = "0x400000C")]
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; //Field offset: 0x0
	[Token(Token = "0x400000D")]
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; //Field offset: 0x8
	[Token(Token = "0x400000E")]
	private static readonly IntPtr s_ReflectionHelperGetMethodID; //Field offset: 0x10
	[Token(Token = "0x400000F")]
	private static readonly IntPtr s_ReflectionHelperGetFieldID; //Field offset: 0x18
	[Token(Token = "0x4000010")]
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; //Field offset: 0x20
	[Token(Token = "0x4000011")]
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; //Field offset: 0x28
	[Token(Token = "0x4000012")]
	private static readonly IntPtr s_ReflectionHelperCeateInvocationError; //Field offset: 0x30
	[Token(Token = "0x4000013")]
	private static readonly IntPtr s_FieldGetDeclaringClass; //Field offset: 0x38

	[Address(RVA = "0x2FA6170", Offset = "0x2FA5570", Length = "0x2D0")]
	[Token(Token = "0x6000038")]
	private static AndroidReflection() { }

	[Address(RVA = "0x2FA5950", Offset = "0x2FA4D50", Length = "0x144")]
	[Token(Token = "0x6000037")]
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	[Address(RVA = "0x2FA5AA0", Offset = "0x2FA4EA0", Length = "0x1B2")]
	[Token(Token = "0x6000034")]
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	[Address(RVA = "0x2FA5C60", Offset = "0x2FA5060", Length = "0xB8")]
	[Token(Token = "0x6000033")]
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	[Address(RVA = "0x2FA5D20", Offset = "0x2FA5120", Length = "0x219")]
	[Token(Token = "0x6000035")]
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	[Address(RVA = "0x2FA5F40", Offset = "0x2FA5340", Length = "0xB8")]
	[Token(Token = "0x6000032")]
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	[Address(RVA = "0x2FA6000", Offset = "0x2FA5400", Length = "0x26")]
	[Token(Token = "0x6000031")]
	public static bool IsAssignableFrom(Type t, Type from) { }

	[Address(RVA = "0x2154320", Offset = "0x2153720", Length = "0x19")]
	[Token(Token = "0x6000030")]
	public static bool IsPrimitive(Type t) { }

	[Address(RVA = "0x2FA6030", Offset = "0x2FA5430", Length = "0x135")]
	[Token(Token = "0x6000036")]
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

}

