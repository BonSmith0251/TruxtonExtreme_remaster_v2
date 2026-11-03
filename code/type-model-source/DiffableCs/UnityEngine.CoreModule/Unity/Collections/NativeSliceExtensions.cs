namespace Unity.Collections;

[Extension]
[Token(Token = "0x2000060")]
public static class NativeSliceExtensions
{

	[Address(RVA = "0x8905A0", Offset = "0x88F9A0", Length = "0x99")]
	[Extension]
	[Token(Token = "0x6000126")]
	public static NativeSlice<T> Slice(NativeArray<T> thisArray, int start, int length) { }

	[Address(RVA = "0x8906E0", Offset = "0x88FAE0", Length = "0x99")]
	[Extension]
	[Token(Token = "0x6000127")]
	public static NativeSlice<T> Slice(NativeSlice<T> thisSlice, int start, int length) { }

}

