namespace System;

[Token(Token = "0x20000B6")]
internal static class SecurityUtils
{

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000367")]
	private static void DemandGrantSet(Assembly assembly) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000366")]
	private static void DemandReflectionAccess(Type type) { }

	[Address(RVA = "0x260CBB0", Offset = "0x260BFB0", Length = "0xAE")]
	[Token(Token = "0x600036E")]
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	[Address(RVA = "0x260CC60", Offset = "0x260C060", Length = "0x12")]
	[Token(Token = "0x6000368")]
	private static bool HasReflectionPermission(Type type) { }

	[Address(RVA = "0x260CC80", Offset = "0x260C080", Length = "0x10B")]
	[Token(Token = "0x600036F")]
	internal static object MethodInfoInvoke(MethodInfo method, object target, Object[] args) { }

	[Address(RVA = "0x260CD90", Offset = "0x260C190", Length = "0x166")]
	[Token(Token = "0x600036C")]
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, Object[] args, bool allowNonPublic) { }

	[Address(RVA = "0x260CF00", Offset = "0x260C300", Length = "0x16B")]
	[Token(Token = "0x600036D")]
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, Object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	[Address(RVA = "0x260D070", Offset = "0x260C470", Length = "0xB1")]
	[Token(Token = "0x6000369")]
	internal static object SecureCreateInstance(Type type) { }

	[Address(RVA = "0x260D130", Offset = "0x260C530", Length = "0xF9")]
	[Token(Token = "0x600036A")]
	internal static object SecureCreateInstance(Type type, Object[] args, bool allowNonPublic) { }

	[Address(RVA = "0x260D230", Offset = "0x260C630", Length = "0xBD")]
	[Token(Token = "0x600036B")]
	internal static object SecureCreateInstance(Type type, Object[] args) { }

}

