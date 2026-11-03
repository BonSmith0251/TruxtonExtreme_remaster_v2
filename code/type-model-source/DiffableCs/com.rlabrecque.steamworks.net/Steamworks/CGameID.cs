namespace Steamworks;

[Token(Token = "0x20001B9")]
public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
{
	[Token(Token = "0x20001BA")]
	internal enum EGameIDType : int
	{
		k_EGameIDTypeApp = 0,
		k_EGameIDTypeGameMod = 1,
		k_EGameIDTypeShortcut = 2,
		k_EGameIDTypeP2P = 3,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AC4")]
	public ulong m_GameID; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x60009E3")]
	public CGameID(ulong GameID) { }

	[Address(RVA = "0x604AB0", Offset = "0x603EB0", Length = "0x72")]
	[Token(Token = "0x60009E4")]
	public CGameID(AppId_t nAppID) { }

	[Address(RVA = "0x604A30", Offset = "0x603E30", Length = "0x7E")]
	[Token(Token = "0x60009E5")]
	public CGameID(AppId_t nAppID, uint nModID) { }

	[Address(RVA = "0x604680", Offset = "0x603A80", Length = "0x8")]
	[Token(Token = "0x60009EA")]
	public AppId_t AppID() { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x60009FB")]
	public override int CompareTo(CGameID other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x60009FA")]
	public override bool Equals(CGameID other) { }

	[Address(RVA = "0x6046A0", Offset = "0x603AA0", Length = "0x81")]
	[Token(Token = "0x60009F4")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x60009F5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604750", Offset = "0x603B50", Length = "0xC")]
	[Token(Token = "0x60009E7")]
	public bool IsMod() { }

	[Address(RVA = "0x604760", Offset = "0x603B60", Length = "0xC")]
	[Token(Token = "0x60009E9")]
	public bool IsP2PFile() { }

	[Address(RVA = "0x604770", Offset = "0x603B70", Length = "0xC")]
	[Token(Token = "0x60009E8")]
	public bool IsShortcut() { }

	[Address(RVA = "0x604780", Offset = "0x603B80", Length = "0xC")]
	[Token(Token = "0x60009E6")]
	public bool IsSteamApp() { }

	[Address(RVA = "0x604790", Offset = "0x603B90", Length = "0x181")]
	[Token(Token = "0x60009ED")]
	public bool IsValid() { }

	[Address(RVA = "0x604920", Offset = "0x603D20", Length = "0x8")]
	[Token(Token = "0x60009EC")]
	public uint ModID() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x60009F6")]
	public static bool op_Equality(CGameID x, CGameID y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60009F9")]
	public static ulong op_Explicit(CGameID that) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60009F8")]
	public static CGameID op_Explicit(ulong value) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x60009F7")]
	public static bool op_Inequality(CGameID x, CGameID y) { }

	[Address(RVA = "0x604930", Offset = "0x603D30", Length = "0x8")]
	[Token(Token = "0x60009EE")]
	public void Reset() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x60009EF")]
	public void Set(ulong GameID) { }

	[Address(RVA = "0x604940", Offset = "0x603D40", Length = "0x6B")]
	[Token(Token = "0x60009F0")]
	private void SetAppID(AppId_t other) { }

	[Address(RVA = "0x6049B0", Offset = "0x603DB0", Length = "0x12")]
	[Token(Token = "0x60009F2")]
	private void SetModID(uint other) { }

	[Address(RVA = "0x6049D0", Offset = "0x603DD0", Length = "0x21")]
	[Token(Token = "0x60009F1")]
	private void SetType(EGameIDType other) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x60009F3")]
	public virtual string ToString() { }

	[Address(RVA = "0x604A20", Offset = "0x603E20", Length = "0x5")]
	[Token(Token = "0x60009EB")]
	public EGameIDType Type() { }

}

