namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002B5")]
public static class InteropHelpers
{

	[Address(RVA = "0x84C910", Offset = "0x84BD10", Length = "0x1C8")]
	[Token(Token = "0x6000E17")]
	public static U[] MarshalArray(IntPtr ptr, uint count, Func<T, U> converter) { }

	[Address(RVA = "0x84C280", Offset = "0x84B680", Length = "0x170")]
	[Token(Token = "0x6000E18")]
	public static T[] MarshalArray(IntPtr ptr, uint count) { }

	[Address(RVA = "0x2B8EBF0", Offset = "0x2B8DFF0", Length = "0x17A")]
	[Token(Token = "0x6000E19")]
	public static String[] MarshalStringArrayAnsi(IntPtr ptr, uint count) { }

	[Address(RVA = "0x2B8ED70", Offset = "0x2B8E170", Length = "0xBA")]
	[Token(Token = "0x6000E16")]
	public static IntPtr MarshalStringUtf8(string str) { }

}

