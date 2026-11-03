namespace Mono;

[Token(Token = "0x2000036")]
internal static class RuntimeMarshal
{

	[Address(RVA = "0x1E644E0", Offset = "0x1E638E0", Length = "0x22")]
	[Token(Token = "0x6000068")]
	internal static int AsciHexDigitValue(int c) { }

	[Address(RVA = "0x1E64510", Offset = "0x1E63910", Length = "0xF2")]
	[Token(Token = "0x6000067")]
	internal static Byte[] DecodeBlobArray(IntPtr ptr) { }

	[Address(RVA = "0x1E64610", Offset = "0x1E63A10", Length = "0x7E")]
	[Token(Token = "0x6000066")]
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	[Address(RVA = "0x1E64690", Offset = "0x1E63A90", Length = "0x5")]
	[Token(Token = "0x6000069")]
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }

	[Address(RVA = "0x1E646A0", Offset = "0x1E63AA0", Length = "0x2A")]
	[Token(Token = "0x6000065")]
	internal static SafeStringMarshal MarshalString(string str) { }

	[Address(RVA = "0x1E646D0", Offset = "0x1E63AD0", Length = "0xF0")]
	[Token(Token = "0x6000064")]
	internal static string PtrToUtf8String(IntPtr ptr) { }

}

