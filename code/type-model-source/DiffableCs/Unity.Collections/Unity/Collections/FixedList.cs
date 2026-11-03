namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200004D")]
internal struct FixedList
{

	[Address(RVA = "0x7F2040", Offset = "0x7F1440", Length = "0x5A")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000215")]
	internal static int Capacity() { }

	[Address(RVA = "0x7F24A0", Offset = "0x7F18A0", Length = "0xC7")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000216")]
	internal static void CheckResize(int newLength) { }

	[Address(RVA = "0x7F2570", Offset = "0x7F1970", Length = "0x62")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000213")]
	internal static int PaddingBytes() { }

	[Address(RVA = "0x7F26F0", Offset = "0x7F1AF0", Length = "0x47")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000214")]
	internal static int StorageBytes() { }

}

