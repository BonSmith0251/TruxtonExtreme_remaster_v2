namespace System;

[Token(Token = "0x20000CC")]
internal class UncNameHelper
{

	[Address(RVA = "0x262AAB0", Offset = "0x2629EB0", Length = "0x20B")]
	[Token(Token = "0x6000431")]
	internal static bool IsValid(Char* name, ushort start, ref int returnedEnd, bool notImplicitFile) { }

	[Address(RVA = "0x262ACC0", Offset = "0x262A0C0", Length = "0x17D")]
	[Token(Token = "0x6000430")]
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

}

