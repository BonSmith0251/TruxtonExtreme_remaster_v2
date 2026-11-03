namespace Unity.Collections;

[Extension]
[Token(Token = "0x2000062")]
public static class FixedListExtensions
{

	[Address(RVA = "0x7F1FB0", Offset = "0x7F13B0", Length = "0x8E")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600039D")]
	public static void Sort(ref FixedList32Bytes<T>& list) { }

	[Address(RVA = "0x7F1E70", Offset = "0x7F1270", Length = "0x139")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x600039E")]
	public static void Sort(ref FixedList32Bytes<T>& list, U comp) { }

	[Address(RVA = "0x7F1FB0", Offset = "0x7F13B0", Length = "0x8E")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600039F")]
	public static void Sort(ref FixedList64Bytes<T>& list) { }

	[Address(RVA = "0x7F1E70", Offset = "0x7F1270", Length = "0x139")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x60003A0")]
	public static void Sort(ref FixedList64Bytes<T>& list, U comp) { }

	[Address(RVA = "0x7F1FB0", Offset = "0x7F13B0", Length = "0x8E")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60003A1")]
	public static void Sort(ref FixedList128Bytes<T>& list) { }

	[Address(RVA = "0x7F1E70", Offset = "0x7F1270", Length = "0x139")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x60003A2")]
	public static void Sort(ref FixedList128Bytes<T>& list, U comp) { }

	[Address(RVA = "0x7F1FB0", Offset = "0x7F13B0", Length = "0x8E")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60003A3")]
	public static void Sort(ref FixedList512Bytes<T>& list) { }

	[Address(RVA = "0x7F1E70", Offset = "0x7F1270", Length = "0x139")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x60003A4")]
	public static void Sort(ref FixedList512Bytes<T>& list, U comp) { }

	[Address(RVA = "0x7F1FB0", Offset = "0x7F13B0", Length = "0x8E")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60003A5")]
	public static void Sort(ref FixedList4096Bytes<T>& list) { }

	[Address(RVA = "0x7F1E70", Offset = "0x7F1270", Length = "0x139")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x60003A6")]
	public static void Sort(ref FixedList4096Bytes<T>& list, U comp) { }

}

