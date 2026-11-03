namespace System.Net.NetworkInformation;

[Token(Token = "0x20002EA")]
internal struct Win32_IP_ADDR_STRING
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CB5")]
	public IntPtr Next; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CB6")]
	public string IpAddress; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CB7")]
	public string IpMask; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CB8")]
	public uint Context; //Field offset: 0x18

}

