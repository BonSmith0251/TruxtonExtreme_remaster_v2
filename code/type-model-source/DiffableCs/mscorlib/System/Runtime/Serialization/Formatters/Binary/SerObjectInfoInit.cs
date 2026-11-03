namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000428")]
internal sealed class SerObjectInfoInit
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010D8")]
	internal Hashtable seenBeforeTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010D9")]
	internal int objectInfoIdCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010DA")]
	internal SerStack oiPool; //Field offset: 0x20

	[Address(RVA = "0x1F29450", Offset = "0x1F28850", Length = "0xB6")]
	[Token(Token = "0x6001F65")]
	public SerObjectInfoInit() { }

}

