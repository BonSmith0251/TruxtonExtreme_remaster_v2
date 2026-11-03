namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000060")]
public static class FixedList4096BytesExtensions
{

	[Address(RVA = "0x7F1A70", Offset = "0x7F0E70", Length = "0xD7")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000398")]
	public static bool Contains(ref FixedList4096Bytes<T>& list, U value) { }

	[Address(RVA = "0x7F1B50", Offset = "0x7F0F50", Length = "0x120")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000397")]
	public static int IndexOf(ref FixedList4096Bytes<T>& list, U value) { }

	[Address(RVA = "0x7F1D70", Offset = "0x7F1170", Length = "0xFC")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000399")]
	public static bool Remove(ref FixedList4096Bytes<T>& list, U value) { }

	[Address(RVA = "0x7F1C70", Offset = "0x7F1070", Length = "0xFD")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x600039A")]
	public static bool RemoveSwapBack(ref FixedList4096Bytes<T>& list, U value) { }

}

