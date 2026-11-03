namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000058")]
public static class FixedList128BytesExtensions
{

	[Address(RVA = "0x7F1A70", Offset = "0x7F0E70", Length = "0xD7")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60002FC")]
	public static bool Contains(ref FixedList128Bytes<T>& list, U value) { }

	[Address(RVA = "0x7F1B50", Offset = "0x7F0F50", Length = "0x120")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60002FB")]
	public static int IndexOf(ref FixedList128Bytes<T>& list, U value) { }

	[Address(RVA = "0x7F1D70", Offset = "0x7F1170", Length = "0xFC")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60002FD")]
	public static bool Remove(ref FixedList128Bytes<T>& list, U value) { }

	[Address(RVA = "0x7F1C70", Offset = "0x7F1070", Length = "0xFD")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60002FE")]
	public static bool RemoveSwapBack(ref FixedList128Bytes<T>& list, U value) { }

}

