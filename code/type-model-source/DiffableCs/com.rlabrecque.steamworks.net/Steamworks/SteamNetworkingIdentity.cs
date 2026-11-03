namespace Steamworks;

[Token(Token = "0x20001E0")]
public struct SteamNetworkingIdentity : IEquatable<SteamNetworkingIdentity>
{
	[Token(Token = "0x4000B3E")]
	public const int k_cbMaxGenericBytes = 32; //Field offset: 0x0
	[Token(Token = "0x4000B3C")]
	public const int k_cchMaxGenericString = 32; //Field offset: 0x0
	[Token(Token = "0x4000B3B")]
	public const int k_cchMaxString = 128; //Field offset: 0x0
	[Token(Token = "0x4000B3D")]
	public const int k_cchMaxXboxPairwiseID = 33; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B19")]
	public ESteamNetworkingIdentityType m_eType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B1A")]
	private int m_cbSize; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B1B")]
	private uint m_reserved0; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000B1C")]
	private uint m_reserved1; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B1D")]
	private uint m_reserved2; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B1E")]
	private uint m_reserved3; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B1F")]
	private uint m_reserved4; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000B20")]
	private uint m_reserved5; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B21")]
	private uint m_reserved6; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000B22")]
	private uint m_reserved7; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B23")]
	private uint m_reserved8; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000B24")]
	private uint m_reserved9; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B25")]
	private uint m_reserved10; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000B26")]
	private uint m_reserved11; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B27")]
	private uint m_reserved12; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000B28")]
	private uint m_reserved13; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B29")]
	private uint m_reserved14; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000B2A")]
	private uint m_reserved15; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B2B")]
	private uint m_reserved16; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000B2C")]
	private uint m_reserved17; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B2D")]
	private uint m_reserved18; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000B2E")]
	private uint m_reserved19; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B2F")]
	private uint m_reserved20; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000B30")]
	private uint m_reserved21; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B31")]
	private uint m_reserved22; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000B32")]
	private uint m_reserved23; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B33")]
	private uint m_reserved24; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000B34")]
	private uint m_reserved25; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B35")]
	private uint m_reserved26; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000B36")]
	private uint m_reserved27; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B37")]
	private uint m_reserved28; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000B38")]
	private uint m_reserved29; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B39")]
	private uint m_reserved30; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000B3A")]
	private uint m_reserved31; //Field offset: 0x84

	[Address(RVA = "0x636BF0", Offset = "0x635FF0", Length = "0x78")]
	[Token(Token = "0x6000B05")]
	public void Clear() { }

	[Address(RVA = "0x637180", Offset = "0x636580", Length = "0x8C")]
	[Token(Token = "0x6000B1D")]
	public override bool Equals(SteamNetworkingIdentity x) { }

	[Address(RVA = "0x636C70", Offset = "0x636070", Length = "0x78")]
	[Token(Token = "0x6000B15")]
	public ESteamNetworkingFakeIPType GetFakeIPType() { }

	[Address(RVA = "0x63B990", Offset = "0x63AD90", Length = "0x3E")]
	[Token(Token = "0x6000B1C")]
	public Byte[] GetGenericBytes(out int cbLen) { }

	[Address(RVA = "0x63B9D0", Offset = "0x63ADD0", Length = "0x81")]
	[Token(Token = "0x6000B1A")]
	public string GetGenericString() { }

	[Address(RVA = "0x63BA60", Offset = "0x63AE60", Length = "0x3E")]
	[Token(Token = "0x6000B12")]
	public SteamNetworkingIPAddr GetIPAddr() { }

	[Address(RVA = "0x636E80", Offset = "0x636280", Length = "0x78")]
	[Token(Token = "0x6000B14")]
	public uint GetIPv4() { }

	[Address(RVA = "0x636F00", Offset = "0x636300", Length = "0x78")]
	[Token(Token = "0x6000B0E")]
	public ulong GetPSNID() { }

	[Address(RVA = "0x636F80", Offset = "0x636380", Length = "0x78")]
	[Token(Token = "0x6000B10")]
	public ulong GetStadiaID() { }

	[Address(RVA = "0x63BAA0", Offset = "0x63AEA0", Length = "0xAF")]
	[Token(Token = "0x6000B08")]
	public CSteamID GetSteamID() { }

	[Address(RVA = "0x637000", Offset = "0x636400", Length = "0x78")]
	[Token(Token = "0x6000B0A")]
	public ulong GetSteamID64() { }

	[Address(RVA = "0x63BB50", Offset = "0x63AF50", Length = "0x81")]
	[Token(Token = "0x6000B0C")]
	public string GetXboxPairwiseID() { }

	[Address(RVA = "0x63BBE0", Offset = "0x63AFE0", Length = "0x16")]
	[Token(Token = "0x6000B16")]
	public bool IsFakeIP() { }

	[Address(RVA = "0x637290", Offset = "0x636690", Length = "0x7D")]
	[Token(Token = "0x6000B06")]
	public bool IsInvalid() { }

	[Address(RVA = "0x637310", Offset = "0x636710", Length = "0x7D")]
	[Token(Token = "0x6000B18")]
	public bool IsLocalHost() { }

	[Address(RVA = "0x63BC00", Offset = "0x63B000", Length = "0x1B7")]
	[Token(Token = "0x6000B1F")]
	public bool ParseString(string pszStr) { }

	[Address(RVA = "0x637470", Offset = "0x636870", Length = "0xA2")]
	[Token(Token = "0x6000B1B")]
	public bool SetGenericBytes(Byte[] data, uint cbLen) { }

	[Address(RVA = "0x63BDC0", Offset = "0x63B1C0", Length = "0x1B7")]
	[Token(Token = "0x6000B19")]
	public bool SetGenericString(string pszString) { }

	[Address(RVA = "0x63BF80", Offset = "0x63B380", Length = "0xD9")]
	[Token(Token = "0x6000B11")]
	public void SetIPAddr(SteamNetworkingIPAddr addr) { }

	[Address(RVA = "0x6376F0", Offset = "0x636AF0", Length = "0x93")]
	[Token(Token = "0x6000B13")]
	public void SetIPv4Addr(uint nIPv4, ushort nPort) { }

	[Address(RVA = "0x637790", Offset = "0x636B90", Length = "0x78")]
	[Token(Token = "0x6000B17")]
	public void SetLocalHost() { }

	[Address(RVA = "0x637810", Offset = "0x636C10", Length = "0x87")]
	[Token(Token = "0x6000B0D")]
	public void SetPSNID(ulong id) { }

	[Address(RVA = "0x6378A0", Offset = "0x636CA0", Length = "0x87")]
	[Token(Token = "0x6000B0F")]
	public void SetStadiaID(ulong id) { }

	[Address(RVA = "0x63C060", Offset = "0x63B460", Length = "0xB8")]
	[Token(Token = "0x6000B07")]
	public void SetSteamID(CSteamID steamID) { }

	[Address(RVA = "0x637930", Offset = "0x636D30", Length = "0x87")]
	[Token(Token = "0x6000B09")]
	public void SetSteamID64(ulong steamID) { }

	[Address(RVA = "0x63C120", Offset = "0x63B520", Length = "0x1B7")]
	[Token(Token = "0x6000B0B")]
	public bool SetXboxPairwiseID(string pszString) { }

	[Address(RVA = "0x63C2E0", Offset = "0x63B6E0", Length = "0xF8")]
	[Token(Token = "0x6000B1E")]
	public void ToString(out string buf) { }

}

