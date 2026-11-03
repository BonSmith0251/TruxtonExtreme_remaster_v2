namespace System.Net.NetworkInformation;

[Token(Token = "0x20002E5")]
internal struct Win32_FIXED_INFO
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CA0")]
	public string HostName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CA1")]
	public string DomainName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CA2")]
	public IntPtr CurrentDnsServer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CA3")]
	public Win32_IP_ADDR_STRING DnsServerList; //Field offset: 0x18
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000CA4")]
	public NetBiosNodeType NodeType; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000CA5")]
	public string ScopeId; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000CA6")]
	public uint EnableRouting; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000CA7")]
	public uint EnableProxy; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000CA8")]
	public uint EnableDns; //Field offset: 0x50

}

