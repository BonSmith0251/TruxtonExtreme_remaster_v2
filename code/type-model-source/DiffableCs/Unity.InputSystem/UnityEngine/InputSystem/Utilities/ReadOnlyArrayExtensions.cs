namespace UnityEngine.InputSystem.Utilities;

[Extension]
[Token(Token = "0x2000266")]
public static class ReadOnlyArrayExtensions
{

	[Address(RVA = "0x8DFBD0", Offset = "0x8DEFD0", Length = "0xB8")]
	[Extension]
	[Token(Token = "0x6001664")]
	public static bool Contains(ReadOnlyArray<TValue> array, TValue value) { }

	[Address(RVA = "0x8DF960", Offset = "0x8DED60", Length = "0x90")]
	[Extension]
	[Token(Token = "0x6001665")]
	public static bool ContainsReference(ReadOnlyArray<TValue> array, TValue value) { }

	[Address(RVA = "0x8DFEF0", Offset = "0x8DF2F0", Length = "0x1A2")]
	[Extension]
	[Token(Token = "0x6001667")]
	internal static bool HaveEqualReferences(ReadOnlyArray<TValue> array1, IReadOnlyList<TValue> array2, int count = 2147483647) { }

	[Address(RVA = "0x8E00A0", Offset = "0x8DF4A0", Length = "0x57")]
	[Extension]
	[Token(Token = "0x6001666")]
	public static int IndexOfReference(ReadOnlyArray<TValue> array, TValue value) { }

}

