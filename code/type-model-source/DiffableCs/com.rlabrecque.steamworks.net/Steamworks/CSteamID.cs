namespace Steamworks;

[Token(Token = "0x20001BB")]
public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
{
	[Token(Token = "0x4000ACA")]
	public static readonly CSteamID Nil; //Field offset: 0x0
	[Token(Token = "0x4000ACB")]
	public static readonly CSteamID OutofDateGS; //Field offset: 0x8
	[Token(Token = "0x4000ACC")]
	public static readonly CSteamID LanModeGS; //Field offset: 0x10
	[Token(Token = "0x4000ACD")]
	public static readonly CSteamID NotInitYetGS; //Field offset: 0x18
	[Token(Token = "0x4000ACE")]
	public static readonly CSteamID NonSteamGS; //Field offset: 0x20
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000ACF")]
	public ulong m_SteamID; //Field offset: 0x0

	[Address(RVA = "0x607750", Offset = "0x606B50", Length = "0x1DE")]
	[Token(Token = "0x6000A22")]
	private static CSteamID() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x60009FE")]
	public CSteamID(ulong ulSteamID) { }

	[Address(RVA = "0x6079C0", Offset = "0x606DC0", Length = "0x84")]
	[Token(Token = "0x60009FC")]
	public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType) { }

	[Address(RVA = "0x607930", Offset = "0x606D30", Length = "0x84")]
	[Token(Token = "0x60009FD")]
	public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType) { }

	[Address(RVA = "0x606AE0", Offset = "0x605EE0", Length = "0x79")]
	[Token(Token = "0x6000A0D")]
	public bool BAnonAccount() { }

	[Address(RVA = "0x606B60", Offset = "0x605F60", Length = "0x4E")]
	[Token(Token = "0x6000A07")]
	public bool BAnonGameServerAccount() { }

	[Address(RVA = "0x606BB0", Offset = "0x605FB0", Length = "0x4F")]
	[Token(Token = "0x6000A0E")]
	public bool BAnonUserAccount() { }

	[Address(RVA = "0x606C00", Offset = "0x606000", Length = "0xC3")]
	[Token(Token = "0x6000A04")]
	public bool BBlankAnonAccount() { }

	[Address(RVA = "0x606CD0", Offset = "0x6060D0", Length = "0x4E")]
	[Token(Token = "0x6000A0A")]
	public bool BChatAccount() { }

	[Address(RVA = "0x606D20", Offset = "0x606120", Length = "0x4F")]
	[Token(Token = "0x6000A09")]
	public bool BClanAccount() { }

	[Address(RVA = "0x606D70", Offset = "0x606170", Length = "0x4F")]
	[Token(Token = "0x6000A0F")]
	public bool BConsoleUserAccount() { }

	[Address(RVA = "0x606DC0", Offset = "0x6061C0", Length = "0x4F")]
	[Token(Token = "0x6000A08")]
	public bool BContentServerAccount() { }

	[Address(RVA = "0x606E10", Offset = "0x606210", Length = "0x79")]
	[Token(Token = "0x6000A05")]
	public bool BGameServerAccount() { }

	[Address(RVA = "0x606E90", Offset = "0x606290", Length = "0x77")]
	[Token(Token = "0x6000A0C")]
	public bool BIndividualAccount() { }

	[Address(RVA = "0x606F10", Offset = "0x606310", Length = "0x4F")]
	[Token(Token = "0x6000A06")]
	public bool BPersistentGameServerAccount() { }

	[Address(RVA = "0x604930", Offset = "0x603D30", Length = "0x8")]
	[Token(Token = "0x6000A01")]
	public void Clear() { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000A21")]
	public override int CompareTo(CSteamID other) { }

	[Address(RVA = "0x606F60", Offset = "0x606360", Length = "0x94")]
	[Token(Token = "0x6000A02")]
	public void CreateBlankAnonLogon(EUniverse eUniverse) { }

	[Address(RVA = "0x607000", Offset = "0x606400", Length = "0x94")]
	[Token(Token = "0x6000A03")]
	public void CreateBlankAnonUserLogon(EUniverse eUniverse) { }

	[Address(RVA = "0x6070A0", Offset = "0x6064A0", Length = "0x99")]
	[Token(Token = "0x6000A1A")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000A20")]
	public override bool Equals(CSteamID other) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000A14")]
	public AccountID_t GetAccountID() { }

	[Address(RVA = "0x607150", Offset = "0x606550", Length = "0xB")]
	[Token(Token = "0x6000A16")]
	public EAccountType GetEAccountType() { }

	[Address(RVA = "0x607160", Offset = "0x606560", Length = "0x5")]
	[Token(Token = "0x6000A17")]
	public EUniverse GetEUniverse() { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000A1B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x607170", Offset = "0x606570", Length = "0xD")]
	[Token(Token = "0x6000A15")]
	public uint GetUnAccountInstance() { }

	[Address(RVA = "0x607180", Offset = "0x606580", Length = "0xDE")]
	[Token(Token = "0x6000A00")]
	public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType) { }

	[Address(RVA = "0x607260", Offset = "0x606660", Length = "0x79")]
	[Token(Token = "0x6000A0B")]
	public bool IsLobby() { }

	[Address(RVA = "0x6072E0", Offset = "0x6066E0", Length = "0x226")]
	[Token(Token = "0x6000A18")]
	public bool IsValid() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000A1C")]
	public static bool op_Equality(CSteamID x, CSteamID y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A1F")]
	public static ulong op_Explicit(CSteamID that) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A1E")]
	public static CSteamID op_Explicit(ulong value) { }

	[Address(RVA = "0x607A50", Offset = "0x606E50", Length = "0x52")]
	[Token(Token = "0x6000A1D")]
	public static bool op_Inequality(CSteamID x, CSteamID y) { }

	[Address(RVA = "0x607600", Offset = "0x606A00", Length = "0x14D")]
	[Token(Token = "0x60009FF")]
	public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType) { }

	[Address(RVA = "0x607510", Offset = "0x606910", Length = "0x6B")]
	[Token(Token = "0x6000A10")]
	public void SetAccountID(AccountID_t other) { }

	[Address(RVA = "0x607580", Offset = "0x606980", Length = "0x21")]
	[Token(Token = "0x6000A11")]
	public void SetAccountInstance(uint other) { }

	[Address(RVA = "0x6075B0", Offset = "0x6069B0", Length = "0x21")]
	[Token(Token = "0x6000A12")]
	public void SetEAccountType(EAccountType other) { }

	[Address(RVA = "0x6075E0", Offset = "0x6069E0", Length = "0x18")]
	[Token(Token = "0x6000A13")]
	public void SetEUniverse(EUniverse other) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000A19")]
	public virtual string ToString() { }

}

