namespace Steamworks;

[Token(Token = "0x200017E")]
public struct SteamNetConnectionInfo_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A2C")]
	public SteamNetworkingIdentity m_identityRemote; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A2D")]
	public long m_nUserData; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A2E")]
	public HSteamListenSocket m_hListenSocket; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A2F")]
	public SteamNetworkingIPAddr m_addrRemote; //Field offset: 0x98
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000A30")]
	public ushort m__pad1; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000A31")]
	public SteamNetworkingPOPID m_idPOPRemote; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000A32")]
	public SteamNetworkingPOPID m_idPOPRelay; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000A33")]
	public ESteamNetworkingConnectionState m_eState; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000A34")]
	public int m_eEndReason; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000A35")]
	private Byte[] m_szEndDebug_; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000A36")]
	private Byte[] m_szConnectionDescription_; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000A37")]
	public int m_nFlags; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000A38")]
	public UInt32[] reserved; //Field offset: 0xD8

	[Token(Token = "0x17000020")]
	public string m_szConnectionDescription
	{
		[Address(RVA = "0x63B4F0", Offset = "0x63A8F0", Length = "0x7E")]
		[Token(Token = "0x60008B6")]
		 get { } //Length: 126
		[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
		[Token(Token = "0x60008B7")]
		 set { } //Length: 168
	}

	[Token(Token = "0x1700001F")]
	public string m_szEndDebug
	{
		[Address(RVA = "0x63B570", Offset = "0x63A970", Length = "0x7E")]
		[Token(Token = "0x60008B4")]
		 get { } //Length: 126
		[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
		[Token(Token = "0x60008B5")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x63B4F0", Offset = "0x63A8F0", Length = "0x7E")]
	[Token(Token = "0x60008B6")]
	public string get_m_szConnectionDescription() { }

	[Address(RVA = "0x63B570", Offset = "0x63A970", Length = "0x7E")]
	[Token(Token = "0x60008B4")]
	public string get_m_szEndDebug() { }

	[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
	[Token(Token = "0x60008B7")]
	public void set_m_szConnectionDescription(string value) { }

	[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
	[Token(Token = "0x60008B5")]
	public void set_m_szEndDebug(string value) { }

}

