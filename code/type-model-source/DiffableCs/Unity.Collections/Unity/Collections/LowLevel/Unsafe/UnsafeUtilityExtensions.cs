namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200014B")]
public static class UnsafeUtilityExtensions
{

	[Address(RVA = "0x9DFF70", Offset = "0x9DF370", Length = "0x21")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000DBE")]
	public static Void* AddressOf(in T value) { }

	[Address(RVA = "0x9DFF70", Offset = "0x9DF370", Length = "0x21")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000DBF")]
	public static T AsRef(in T value) { }

	[Address(RVA = "0x28D4620", Offset = "0x28D3A20", Length = "0xCC")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000DC1")]
	private static void CheckIndexRange(int index, int capacity) { }

	[Address(RVA = "0x28D46F0", Offset = "0x28D3AF0", Length = "0x6D")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000DC0")]
	private static void CheckMemSwapOverlap(Byte* dst, Byte* src, long size) { }

	[Address(RVA = "0x28D4760", Offset = "0x28D3B60", Length = "0xB2")]
	[Token(Token = "0x6000DBB")]
	internal static void MemSwap(Void* ptr, Void* otherPtr, long size) { }

	[Address(RVA = "0x9DFFA0", Offset = "0x9DF3A0", Length = "0xC3")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000DBC")]
	public static T ReadArrayElementBoundsChecked(Void* source, int index, int capacity) { }

	[Address(RVA = "0x9E0070", Offset = "0x9DF470", Length = "0xC3")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000DBD")]
	public static void WriteArrayElementBoundsChecked(Void* destination, int index, T value, int capacity) { }

}

