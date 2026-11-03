namespace System.Net.Sockets;

[Token(Token = "0x200030A")]
public class SendPacketsElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DA1")]
	internal string m_FilePath; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DA2")]
	internal Byte[] m_Buffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DA3")]
	internal int m_Offset; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000DA4")]
	internal int m_Count; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DA5")]
	private bool m_endOfPacket; //Field offset: 0x28

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001477")]
	private SendPacketsElement() { }

}

