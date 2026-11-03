namespace Microsoft.Win32;

[Token(Token = "0x200007B")]
internal static class ThrowHelper
{

	[Address(RVA = "0x1E8ACC0", Offset = "0x1E8A0C0", Length = "0x54")]
	[Token(Token = "0x600020C")]
	internal static void ThrowArgumentException(string msg, string argument) { }

	[Address(RVA = "0x1E8AD20", Offset = "0x1E8A120", Length = "0x49")]
	[Token(Token = "0x600020D")]
	internal static void ThrowArgumentNullException(string argument) { }

	[Address(RVA = "0x1E8AD70", Offset = "0x1E8A170", Length = "0x54")]
	[Token(Token = "0x600020F")]
	internal static void ThrowObjectDisposedException(string objectName, string msg) { }

	[Address(RVA = "0x1E8ADD0", Offset = "0x1E8A1D0", Length = "0x49")]
	[Token(Token = "0x600020E")]
	internal static void ThrowSecurityException(string msg) { }

}

