namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200040D")]
internal static class IOUtil
{

	[Address(RVA = "0x1F1C710", Offset = "0x1F1BB10", Length = "0x8")]
	[Token(Token = "0x6001E91")]
	internal static bool FlagTest(MessageEnum flag, MessageEnum target) { }

	[Address(RVA = "0x1F1C720", Offset = "0x1F1BB20", Length = "0x8C")]
	[Token(Token = "0x6001E92")]
	internal static void WriteStringWithCode(string value, __BinaryWriter sout) { }

	[Address(RVA = "0x1F1C7B0", Offset = "0x1F1BBB0", Length = "0x142")]
	[Token(Token = "0x6001E93")]
	internal static void WriteWithCode(Type type, object value, __BinaryWriter sout) { }

}

