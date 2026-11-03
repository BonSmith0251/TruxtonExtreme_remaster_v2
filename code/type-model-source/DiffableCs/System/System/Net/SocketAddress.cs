namespace System.Net;

[DefaultMember("Item")]
[Token(Token = "0x2000253")]
public class SocketAddress
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000947")]
	internal int m_Size; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000948")]
	internal Byte[] m_Buffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000949")]
	private bool m_changed; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400094A")]
	private int m_hash; //Field offset: 0x24

	[Token(Token = "0x17000336")]
	public AddressFamily Family
	{
		[Address(RVA = "0x26ACDC0", Offset = "0x26AC1C0", Length = "0x36")]
		[Token(Token = "0x6000F98")]
		 get { } //Length: 54
	}

	[Token(Token = "0x17000338")]
	public byte Item
	{
		[Address(RVA = "0x26ACE00", Offset = "0x26AC200", Length = "0x75")]
		[Token(Token = "0x6000F9A")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000337")]
	public int Size
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000F99")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x26AC8C0", Offset = "0x26ABCC0", Length = "0x11D")]
	[Token(Token = "0x6000F9B")]
	public SocketAddress(AddressFamily family, int size) { }

	[Address(RVA = "0x26AC9E0", Offset = "0x26ABDE0", Length = "0x3DF")]
	[Token(Token = "0x6000F9C")]
	internal SocketAddress(IPAddress ipAddress) { }

	[Address(RVA = "0x26AC860", Offset = "0x26ABC60", Length = "0x57")]
	[Token(Token = "0x6000F9D")]
	internal SocketAddress(IPAddress ipaddress, int port) { }

	[Address(RVA = "0x26ABFA0", Offset = "0x26AB3A0", Length = "0x133")]
	[Token(Token = "0x6000FA0")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0x26ACDC0", Offset = "0x26AC1C0", Length = "0x36")]
	[Token(Token = "0x6000F98")]
	public AddressFamily get_Family() { }

	[Address(RVA = "0x26ACE00", Offset = "0x26AC200", Length = "0x75")]
	[Token(Token = "0x6000F9A")]
	public byte get_Item(int offset) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000F99")]
	public int get_Size() { }

	[Address(RVA = "0x26AC0E0", Offset = "0x26AB4E0", Length = "0x131")]
	[Token(Token = "0x6000FA1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x26AC220", Offset = "0x26AB620", Length = "0x2B0")]
	[Token(Token = "0x6000F9E")]
	internal IPAddress GetIPAddress() { }

	[Address(RVA = "0x26AC4E0", Offset = "0x26AB8E0", Length = "0xFD")]
	[Token(Token = "0x6000F9F")]
	internal IPEndPoint GetIPEndPoint() { }

	[Address(RVA = "0x26AC5E0", Offset = "0x26AB9E0", Length = "0x27C")]
	[Token(Token = "0x6000FA2")]
	public virtual string ToString() { }

}

