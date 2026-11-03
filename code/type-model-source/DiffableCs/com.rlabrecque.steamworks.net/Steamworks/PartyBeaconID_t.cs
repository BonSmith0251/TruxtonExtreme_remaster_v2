namespace Steamworks;

[Token(Token = "0x20001EE")]
public struct PartyBeaconID_t : IEquatable<PartyBeaconID_t>, IComparable<PartyBeaconID_t>
{
	[Token(Token = "0x4000B63")]
	public static readonly PartyBeaconID_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B64")]
	public ulong m_PartyBeaconID; //Field offset: 0x0

	[Address(RVA = "0x6391A0", Offset = "0x6385A0", Length = "0x3A")]
	[Token(Token = "0x6000BB0")]
	private static PartyBeaconID_t() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000BA6")]
	public PartyBeaconID_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000BAF")]
	public override int CompareTo(PartyBeaconID_t other) { }

	[Address(RVA = "0x639100", Offset = "0x638500", Length = "0x99")]
	[Token(Token = "0x6000BA8")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000BAE")]
	public override bool Equals(PartyBeaconID_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000BA9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000BAA")]
	public static bool op_Equality(PartyBeaconID_t x, PartyBeaconID_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BAC")]
	public static PartyBeaconID_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BAD")]
	public static ulong op_Explicit(PartyBeaconID_t that) { }

	[Address(RVA = "0x6391E0", Offset = "0x6385E0", Length = "0x52")]
	[Token(Token = "0x6000BAB")]
	public static bool op_Inequality(PartyBeaconID_t x, PartyBeaconID_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000BA7")]
	public virtual string ToString() { }

}

