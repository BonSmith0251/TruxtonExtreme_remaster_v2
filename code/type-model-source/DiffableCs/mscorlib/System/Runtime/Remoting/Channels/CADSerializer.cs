namespace System.Runtime.Remoting.Channels;

[Token(Token = "0x2000387")]
internal class CADSerializer
{

	[Address(RVA = "0x1EFBBA0", Offset = "0x1EFAFA0", Length = "0x3E")]
	[Token(Token = "0x6001BFC")]
	internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg) { }

	[Address(RVA = "0x1EFBCF0", Offset = "0x1EFB0F0", Length = "0x94")]
	[Token(Token = "0x6001C00")]
	internal static object DeserializeObject(MemoryStream mem) { }

	[Address(RVA = "0x1EFBBE0", Offset = "0x1EFAFE0", Length = "0x107")]
	[Token(Token = "0x6001BFE")]
	internal static object DeserializeObjectSafe(Byte[] mem) { }

	[Address(RVA = "0x1EFBD90", Offset = "0x1EFB190", Length = "0xF6")]
	[Token(Token = "0x6001BFD")]
	internal static MemoryStream SerializeMessage(IMessage msg) { }

	[Address(RVA = "0x1EFBE90", Offset = "0x1EFB290", Length = "0xF6")]
	[Token(Token = "0x6001BFF")]
	internal static MemoryStream SerializeObject(object obj) { }

}

