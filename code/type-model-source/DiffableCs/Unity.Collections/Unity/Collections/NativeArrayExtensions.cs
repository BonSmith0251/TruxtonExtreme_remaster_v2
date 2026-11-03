namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000087")]
public static class NativeArrayExtensions
{
	[Token(Token = "0x2000088")]
	internal struct NativeArrayStaticId
	{
		[Token(Token = "0x40003AB")]
		internal static readonly SharedStatic<Int32> s_staticSafetyId; //Field offset: 0x0

		[Address(RVA = "0xD12470", Offset = "0xD11870", Length = "0xAD")]
		[Token(Token = "0x60006F1")]
		private static NativeArrayStaticId`1() { }

	}


	[Address(RVA = "0x88BDC0", Offset = "0x88B1C0", Length = "0x268")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60006EC")]
	public static bool ArraysEqual(NativeArray<T> container, NativeArray<T> other) { }

	[Address(RVA = "0x88C030", Offset = "0x88B430", Length = "0x168")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60006ED")]
	private static void CheckReinterpretSize(ref NativeArray<T>& array) { }

	[Address(RVA = "0x88C1A0", Offset = "0x88B5A0", Length = "0x52")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60006E2")]
	public static bool Contains(NativeArray<T> array, U value) { }

	[Address(RVA = "0x88C200", Offset = "0x88B600", Length = "0x52")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60006E4")]
	public static bool Contains(ReadOnly<T> array, U value) { }

	[Address(RVA = "0x88C390", Offset = "0x88B790", Length = "0xE9")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60006E6")]
	public static bool Contains(Void* ptr, int length, U value) { }

	[Address(RVA = "0x88C6E0", Offset = "0x88BAE0", Length = "0x66")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60006E8")]
	public static void CopyFrom(ref NativeArray<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x88C750", Offset = "0x88BB50", Length = "0x113")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60006E9")]
	public static void CopyFrom(ref NativeArray<T>& container, in NativeHashSet<T>& other) { }

	[Address(RVA = "0x88C5A0", Offset = "0x88B9A0", Length = "0x137")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60006EA")]
	public static void CopyFrom(ref NativeArray<T>& container, in UnsafeHashSet<T>& other) { }

	[Address(RVA = "0x88C870", Offset = "0x88BC70", Length = "0x114")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60006F0")]
	internal static void DisposeCheckAllocator(ref NativeArray<T>& array) { }

	[Address(RVA = "0x88CA20", Offset = "0x88BE20", Length = "0x129")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60006E3")]
	public static int IndexOf(NativeArray<T> array, U value) { }

	[Address(RVA = "0x88CB50", Offset = "0x88BF50", Length = "0x116")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60006E5")]
	public static int IndexOf(ReadOnly<T> array, U value) { }

	[Address(RVA = "0x88C990", Offset = "0x88BD90", Length = "0x84")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60006E7")]
	public static int IndexOf(Void* ptr, int length, U value) { }

	[Address(RVA = "0x88D050", Offset = "0x88C450", Length = "0x12C")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60006EE")]
	internal static void Initialize(ref NativeArray<T>& array, int length, AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0x88DB40", Offset = "0x88CF40", Length = "0x28F")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(AllocatorHandle)})]
	[Token(Token = "0x60006EF")]
	internal static void Initialize(ref NativeArray<T>& array, int length, ref U allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0x88EDA0", Offset = "0x88E1A0", Length = "0xE1")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60006EB")]
	public static NativeArray<U> Reinterpret(NativeArray<T> array) { }

}

