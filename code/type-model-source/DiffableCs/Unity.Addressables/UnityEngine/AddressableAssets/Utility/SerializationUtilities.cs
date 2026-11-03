namespace UnityEngine.AddressableAssets.Utility;

[Token(Token = "0x2000042")]
internal static class SerializationUtilities
{
	[Token(Token = "0x2000043")]
	public enum ObjectType : int
	{
		AsciiString = 0,
		UnicodeString = 1,
		UInt16 = 2,
		UInt32 = 3,
		Int32 = 4,
		Hash128 = 5,
		Type = 6,
		JsonObject = 7,
	}


	[Address(RVA = "0x1F29990", Offset = "0x1F28D90", Length = "0x6D")]
	[Token(Token = "0x60001B5")]
	internal static int ReadInt32FromByteArray(Byte[] data, int offset) { }

	[Address(RVA = "0x27B2640", Offset = "0x27B1A40", Length = "0x3E0")]
	[Token(Token = "0x60001B7")]
	internal static object ReadObjectFromByteArray(Byte[] keyData, int dataIndex) { }

	[Address(RVA = "0x27B2A40", Offset = "0x27B1E40", Length = "0x6A")]
	[Token(Token = "0x60001B6")]
	internal static int WriteInt32ToByteArray(Byte[] data, int val, int offset) { }

	[Address(RVA = "0x27B2AB0", Offset = "0x27B1EB0", Length = "0x88B")]
	[Token(Token = "0x60001B8")]
	internal static int WriteObjectToByteList(object obj, List<Byte> buffer) { }

}

