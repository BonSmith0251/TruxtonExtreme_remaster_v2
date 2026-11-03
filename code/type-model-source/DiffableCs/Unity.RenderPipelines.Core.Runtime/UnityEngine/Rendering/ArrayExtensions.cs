namespace UnityEngine.Rendering;

[Extension]
[Token(Token = "0x20001AB")]
public static class ArrayExtensions
{

	[Address(RVA = "0x71B900", Offset = "0x71AD00", Length = "0x9A")]
	[Extension]
	[Token(Token = "0x6000CB7")]
	public static void FillArray(ref NativeArray<T>& array, in T value, int startIndex = 0, int length = -1) { }

	[Address(RVA = "0x71BB10", Offset = "0x71AF10", Length = "0xAB")]
	[Extension]
	[Token(Token = "0x6000CB4")]
	public static void ResizeArray(ref NativeArray<T>& array, int capacity) { }

	[Address(RVA = "0x2C394F0", Offset = "0x2C388F0", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x6000CB5")]
	public static void ResizeArray(ref TransformAccessArray array, int capacity) { }

	[Address(RVA = "0x71BD20", Offset = "0x71B120", Length = "0x89")]
	[Token(Token = "0x6000CB6")]
	public static void ResizeArray(ref T[] array, int capacity) { }

}

