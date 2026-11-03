namespace System.Runtime.CompilerServices;

[Token(Token = "0x20004AF")]
internal static class JitHelpers
{

	[Address(RVA = "0x84DD50", Offset = "0x84D150", Length = "0x38")]
	[Token(Token = "0x6002169")]
	internal static T UnsafeCast(object o) { }

	[Address(RVA = "0x84DE30", Offset = "0x84D230", Length = "0x3A")]
	[Token(Token = "0x600216A")]
	internal static int UnsafeEnumCast(T val) { }

	[Address(RVA = "0x84DD90", Offset = "0x84D190", Length = "0x97")]
	[Token(Token = "0x600216B")]
	internal static long UnsafeEnumCastLong(T val) { }

}

