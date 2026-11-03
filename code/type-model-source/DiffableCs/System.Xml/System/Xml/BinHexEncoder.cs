namespace System.Xml;

[Token(Token = "0x200000C")]
internal static class BinHexEncoder
{

	[Address(RVA = "0x23EE830", Offset = "0x23EDC30", Length = "0x230")]
	[Token(Token = "0x6000013")]
	internal static void Encode(Byte[] buffer, int index, int count, XmlWriter writer) { }

	[Address(RVA = "0x23EEA70", Offset = "0x23EDE70", Length = "0x1D6")]
	[Token(Token = "0x6000014")]
	internal static string Encode(Byte[] inArray, int offsetIn, int count) { }

	[Address(RVA = "0x23EEC50", Offset = "0x23EE050", Length = "0x16D")]
	[Token(Token = "0x6000015")]
	private static int Encode(Byte[] inArray, int offsetIn, int count, Char[] outArray) { }

}

