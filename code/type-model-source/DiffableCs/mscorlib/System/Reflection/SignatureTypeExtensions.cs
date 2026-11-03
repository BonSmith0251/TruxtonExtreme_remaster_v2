namespace System.Reflection;

[Extension]
[Token(Token = "0x2000500")]
internal static class SignatureTypeExtensions
{

	[Address(RVA = "0x1F6BAF0", Offset = "0x1F6AEF0", Length = "0x419")]
	[Extension]
	[Token(Token = "0x600236D")]
	internal static bool MatchesExactly(SignatureType pattern, Type actual) { }

	[Address(RVA = "0x1F6BF10", Offset = "0x1F6B310", Length = "0xC0")]
	[Extension]
	[Token(Token = "0x600236C")]
	public static bool MatchesParameterTypeExactly(Type pattern, ParameterInfo parameter) { }

	[Address(RVA = "0x1F6C010", Offset = "0x1F6B410", Length = "0x2C")]
	[Extension]
	[Token(Token = "0x6002370")]
	private static Type TryMakeArrayType(Type type) { }

	[Address(RVA = "0x1F6BFE0", Offset = "0x1F6B3E0", Length = "0x2C")]
	[Extension]
	[Token(Token = "0x6002371")]
	private static Type TryMakeArrayType(Type type, int rank) { }

	[Address(RVA = "0x1F6C040", Offset = "0x1F6B440", Length = "0x2C")]
	[Extension]
	[Token(Token = "0x6002372")]
	private static Type TryMakeByRefType(Type type) { }

	[Address(RVA = "0x1F6C070", Offset = "0x1F6B470", Length = "0x2C")]
	[Extension]
	[Token(Token = "0x6002374")]
	private static Type TryMakeGenericType(Type type, Type[] instantiation) { }

	[Address(RVA = "0x1F6C0A0", Offset = "0x1F6B4A0", Length = "0x2C")]
	[Extension]
	[Token(Token = "0x6002373")]
	private static Type TryMakePointerType(Type type) { }

	[Address(RVA = "0x1F6C110", Offset = "0x1F6B510", Length = "0x42A")]
	[Extension]
	[Token(Token = "0x600236F")]
	private static Type TryResolve(SignatureType signatureType, Type[] genericMethodParameters) { }

	[Address(RVA = "0x1F6C0D0", Offset = "0x1F6B4D0", Length = "0x3F")]
	[Extension]
	[Token(Token = "0x600236E")]
	internal static Type TryResolveAgainstGenericMethod(SignatureType signatureType, MethodInfo genericMethod) { }

}

