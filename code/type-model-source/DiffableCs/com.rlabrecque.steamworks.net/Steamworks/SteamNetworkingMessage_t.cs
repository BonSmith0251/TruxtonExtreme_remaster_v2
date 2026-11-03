namespace Steamworks;

[Token(Token = "0x20001E2")]
public struct SteamNetworkingMessage_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B42")]
	public IntPtr m_pData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B43")]
	public int m_cbSize; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000B44")]
	public HSteamNetConnection m_conn; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B45")]
	public SteamNetworkingIdentity m_identityPeer; //Field offset: 0x10
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B46")]
	public long m_nConnUserData; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B47")]
	public SteamNetworkingMicroseconds m_usecTimeReceived; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000B48")]
	public long m_nMessageNumber; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000B49")]
	public IntPtr m_pfnFreeData; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000B4A")]
	internal IntPtr m_pfnRelease; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000B4B")]
	public int m_nChannel; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000B4C")]
	public int m_nFlags; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000B4D")]
	public long m_nUserData; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000B4E")]
	public ushort m_idxLane; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD2")]
	[Token(Token = "0x4000B4F")]
	public ushort _pad1__; //Field offset: 0xD2

	[Address(RVA = "0x63C3E0", Offset = "0x63B7E0", Length = "0x156")]
	[Token(Token = "0x6000B2F")]
	public static SteamNetworkingMessage_t FromIntPtr(IntPtr pointer) { }

	[Address(RVA = "0x637BD0", Offset = "0x636FD0", Length = "0x78")]
	[Token(Token = "0x6000B2E")]
	public static void Release(IntPtr pointer) { }

	[Address(RVA = "0x63C540", Offset = "0x63B940", Length = "0x4E")]
	[Token(Token = "0x6000B2D")]
	public void Release() { }

}

