namespace Steamworks;

[Token(Token = "0x20001B6")]
public struct servernetadr_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AC1")]
	private ushort m_usConnectionPort; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000AC2")]
	private ushort m_usQueryPort; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000AC3")]
	private uint m_unIP; //Field offset: 0x4

	[Address(RVA = "0x6464F0", Offset = "0x6458F0", Length = "0x6B")]
	[Token(Token = "0x60009DA")]
	public int CompareTo(servernetadr_t other) { }

	[Address(RVA = "0x646590", Offset = "0x645990", Length = "0xA4")]
	[Token(Token = "0x60009D5")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x646560", Offset = "0x645960", Length = "0x23")]
	[Token(Token = "0x60009D9")]
	public bool Equals(servernetadr_t other) { }

	[Address(RVA = "0x646640", Offset = "0x645A40", Length = "0xE")]
	[Token(Token = "0x60009D0")]
	public string GetConnectionAddressString() { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[Token(Token = "0x60009CC")]
	public ushort GetConnectionPort() { }

	[Address(RVA = "0x646660", Offset = "0x645A60", Length = "0x4A")]
	[Token(Token = "0x60009D6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60009CE")]
	public uint GetIP() { }

	[Address(RVA = "0x6466C0", Offset = "0x645AC0", Length = "0xF")]
	[Token(Token = "0x60009D1")]
	public string GetQueryAddressString() { }

	[Address(RVA = "0x6466D0", Offset = "0x645AD0", Length = "0x5")]
	[Token(Token = "0x60009CA")]
	public ushort GetQueryPort() { }

	[Address(RVA = "0x6466E0", Offset = "0x645AE0", Length = "0xD")]
	[Token(Token = "0x60009C9")]
	public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort) { }

	[Address(RVA = "0x646990", Offset = "0x645D90", Length = "0x31")]
	[Token(Token = "0x60009D7")]
	public static bool op_Equality(servernetadr_t x, servernetadr_t y) { }

	[Address(RVA = "0x6469D0", Offset = "0x645DD0", Length = "0x3B")]
	[Token(Token = "0x60009D4")]
	public static bool op_GreaterThan(servernetadr_t x, servernetadr_t y) { }

	[Address(RVA = "0x646A10", Offset = "0x645E10", Length = "0x31")]
	[Token(Token = "0x60009D8")]
	public static bool op_Inequality(servernetadr_t x, servernetadr_t y) { }

	[Address(RVA = "0x646A50", Offset = "0x645E50", Length = "0x3B")]
	[Token(Token = "0x60009D3")]
	public static bool op_LessThan(servernetadr_t x, servernetadr_t y) { }

	[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
	[Token(Token = "0x60009CD")]
	public void SetConnectionPort(ushort usPort) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x60009CF")]
	public void SetIP(uint unIP) { }

	[Address(RVA = "0x646700", Offset = "0x645B00", Length = "0x5")]
	[Token(Token = "0x60009CB")]
	public void SetQueryPort(ushort usPort) { }

	[Address(RVA = "0x646710", Offset = "0x645B10", Length = "0x279")]
	[Token(Token = "0x60009D2")]
	public static string ToString(uint unIP, ushort usPort) { }

}

