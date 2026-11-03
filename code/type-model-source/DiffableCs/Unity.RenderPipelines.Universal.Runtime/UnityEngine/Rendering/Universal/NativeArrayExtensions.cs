namespace UnityEngine.Rendering.Universal;

[Extension]
[Token(Token = "0x20001EB")]
internal static class NativeArrayExtensions
{

	[Address(RVA = "0x88EF80", Offset = "0x88E380", Length = "0x34")]
	[Extension]
	[Token(Token = "0x6000A8C")]
	public static T UnsafeElementAt(NativeArray<T> array, int index) { }

	[Address(RVA = "0x88EF40", Offset = "0x88E340", Length = "0x34")]
	[Extension]
	[Token(Token = "0x6000A8D")]
	public static T UnsafeElementAtMutable(NativeArray<T> array, int index) { }

}

