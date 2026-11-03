namespace System.Net.Sockets;

[Token(Token = "0x2000303")]
public struct IPPacketInformation
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D6F")]
	private IPAddress address; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D70")]
	private int networkInterface; //Field offset: 0x8

	[Address(RVA = "0x25DE8F0", Offset = "0x25DDCF0", Length = "0xBF")]
	[Token(Token = "0x6001472")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0x25DE9B0", Offset = "0x25DDDB0", Length = "0x48")]
	[Token(Token = "0x6001473")]
	public virtual int GetHashCode() { }

}

