namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000F5")]
internal static class TypeExtensions
{

	[Address(RVA = "0x2153D80", Offset = "0x2153180", Length = "0x26")]
	[Extension]
	[Token(Token = "0x6000727")]
	public static Assembly Assembly(Type type) { }

	[Address(RVA = "0x2153DD0", Offset = "0x21531D0", Length = "0x190")]
	[Extension]
	[Token(Token = "0x600072F")]
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match) { }

	[Address(RVA = "0x2153DB0", Offset = "0x21531B0", Length = "0x1F")]
	[Extension]
	[Token(Token = "0x6000730")]
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	[Address(RVA = "0x2153F70", Offset = "0x2153370", Length = "0x26")]
	[Extension]
	[Token(Token = "0x6000726")]
	public static Type BaseType(Type type) { }

	[Address(RVA = "0x2153FA0", Offset = "0x21533A0", Length = "0x26")]
	[Extension]
	[Token(Token = "0x6000722")]
	public static bool ContainsGenericParameters(Type type) { }

	[Address(RVA = "0x2153FD0", Offset = "0x21533D0", Length = "0x255")]
	[Extension]
	[Token(Token = "0x6000731")]
	public static bool ImplementInterface(Type type, Type interfaceType) { }

	[Address(RVA = "0x2154230", Offset = "0x2153630", Length = "0x19")]
	[Extension]
	[Token(Token = "0x600072B")]
	public static bool IsAbstract(Type type) { }

	[Address(RVA = "0x2154250", Offset = "0x2153650", Length = "0x19")]
	[Extension]
	[Token(Token = "0x6000729")]
	public static bool IsClass(Type type) { }

	[Address(RVA = "0x2154270", Offset = "0x2153670", Length = "0x26")]
	[Extension]
	[Token(Token = "0x6000728")]
	public static bool IsEnum(Type type) { }

	[Address(RVA = "0x21542D0", Offset = "0x21536D0", Length = "0x26")]
	[Extension]
	[Token(Token = "0x6000724")]
	public static bool IsGenericType(Type type) { }

	[Address(RVA = "0x21542A0", Offset = "0x21536A0", Length = "0x26")]
	[Extension]
	[Token(Token = "0x6000725")]
	public static bool IsGenericTypeDefinition(Type type) { }

	[Address(RVA = "0x2154300", Offset = "0x2153700", Length = "0x19")]
	[Extension]
	[Token(Token = "0x6000723")]
	public static bool IsInterface(Type type) { }

	[Address(RVA = "0x2154320", Offset = "0x2153720", Length = "0x19")]
	[Extension]
	[Token(Token = "0x600072E")]
	public static bool IsPrimitive(Type type) { }

	[Address(RVA = "0x2154340", Offset = "0x2153740", Length = "0x19")]
	[Extension]
	[Token(Token = "0x600072A")]
	public static bool IsSealed(Type type) { }

	[Address(RVA = "0x2154360", Offset = "0x2153760", Length = "0x19")]
	[Extension]
	[Token(Token = "0x600072D")]
	public static bool IsValueType(Type type) { }

	[Address(RVA = "0x2154380", Offset = "0x2153780", Length = "0x19")]
	[Extension]
	[Token(Token = "0x600072C")]
	public static bool IsVisible(Type type) { }

	[Address(RVA = "0x21543A0", Offset = "0x21537A0", Length = "0x26")]
	[Extension]
	[Token(Token = "0x6000721")]
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	[Address(RVA = "0x21543D0", Offset = "0x21537D0", Length = "0x19")]
	[Extension]
	[Token(Token = "0x6000720")]
	public static MethodInfo Method(Delegate d) { }

}

