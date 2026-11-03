namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000120")]
internal static class UnsafePtrListExtensions
{

	[Address(RVA = "0x88A170", Offset = "0x889570", Length = "0x3D")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000C27")]
	public static UnsafeList<IntPtr>& ListData(ref UnsafePtrList<T>& from) { }

	[Address(RVA = "0x9DC0C0", Offset = "0x9DB4C0", Length = "0x5D")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000C28")]
	public static UnsafeList<IntPtr> ListDataRO(UnsafePtrList<T> from) { }

}

