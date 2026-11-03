namespace UnityEngine.InputSystem.Utilities;

[Extension]
[Token(Token = "0x200026F")]
internal static class TypeHelpers
{

	[Address(RVA = "0x967780", Offset = "0x966B80", Length = "0x108")]
	[Extension]
	[Token(Token = "0x60016B1")]
	public static TObject As(object obj) { }

	[Address(RVA = "0x29298F0", Offset = "0x2928CF0", Length = "0x423")]
	[Token(Token = "0x60016B5")]
	public static Type GetGenericTypeArgumentFromHierarchy(Type type, Type genericTypeDefinition, int argumentIndex) { }

	[Address(RVA = "0x2929D20", Offset = "0x2929120", Length = "0x448")]
	[Extension]
	[Token(Token = "0x60016B4")]
	public static string GetNiceTypeName(Type type) { }

	[Address(RVA = "0x292A170", Offset = "0x2929570", Length = "0x1B0")]
	[Token(Token = "0x60016B3")]
	public static Type GetValueType(MemberInfo member) { }

	[Address(RVA = "0x292A330", Offset = "0x2929730", Length = "0x18")]
	[Extension]
	[Token(Token = "0x60016B2")]
	public static bool IsInt(TypeCode type) { }

}

