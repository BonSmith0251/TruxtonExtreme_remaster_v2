namespace UnityEngine.InputSystem.Utilities;

[Extension]
[Token(Token = "0x2000246")]
internal static class InputArrayExtensions
{

	[Address(RVA = "0x838A90", Offset = "0x837E90", Length = "0x9B")]
	[Extension]
	[Token(Token = "0x6001546")]
	public static bool Contains(InlinedArray<TValue> array, TValue value) { }

	[Address(RVA = "0x838740", Offset = "0x837B40", Length = "0xA1")]
	[Extension]
	[Token(Token = "0x6001547")]
	public static bool ContainsReference(InlinedArray<TValue> array, TValue value) { }

	[Address(RVA = "0x838B30", Offset = "0x837F30", Length = "0x7B")]
	[Extension]
	[Token(Token = "0x6001545")]
	public static int IndexOfReference(InlinedArray<TValue> array, TValue value) { }

}

