namespace System.Reflection;

[Token(Token = "0x20004F0")]
public sealed class Missing : ISerializable
{
	[Token(Token = "0x400137C")]
	public static readonly Missing Value; //Field offset: 0x0

	[Address(RVA = "0x1F61990", Offset = "0x1F60D90", Length = "0x67")]
	[Token(Token = "0x6002298")]
	private static Missing() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002296")]
	private Missing() { }

	[Address(RVA = "0x1F61950", Offset = "0x1F60D50", Length = "0x3E")]
	[Token(Token = "0x6002297")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

