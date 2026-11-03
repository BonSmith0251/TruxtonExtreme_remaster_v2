namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200011A")]
public static class UnsafeListExtensions
{

	[Address(RVA = "0x9D8000", Offset = "0x9D7400", Length = "0x28D")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000BF1")]
	public static bool ArraysEqual(UnsafeList<T> container, in UnsafeList<T>& other) { }

	[Address(RVA = "0x9D8380", Offset = "0x9D7780", Length = "0xEE")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000BEC")]
	public static bool Contains(UnsafeList<T> list, U value) { }

	[Address(RVA = "0x9D8290", Offset = "0x9D7690", Length = "0xE3")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000BEE")]
	public static bool Contains(ReadOnly<T> list, U value) { }

	[Address(RVA = "0x9D8290", Offset = "0x9D7690", Length = "0xE3")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000BF0")]
	public static bool Contains(ParallelReader<T> list, U value) { }

	[Address(RVA = "0x9D8560", Offset = "0x9D7960", Length = "0x10C")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000BEB")]
	public static int IndexOf(UnsafeList<T> list, U value) { }

	[Address(RVA = "0x9D8470", Offset = "0x9D7870", Length = "0xEC")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000BED")]
	public static int IndexOf(ReadOnly<T> list, U value) { }

	[Address(RVA = "0x9D8470", Offset = "0x9D7870", Length = "0xEC")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000BEF")]
	public static int IndexOf(ParallelReader<T> list, U value) { }

}

