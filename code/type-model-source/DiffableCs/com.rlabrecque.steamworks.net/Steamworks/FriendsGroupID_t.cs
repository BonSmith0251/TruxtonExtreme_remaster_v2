namespace Steamworks;

[Token(Token = "0x20001C2")]
public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
{
	[Token(Token = "0x4000AE8")]
	public static readonly FriendsGroupID_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AE9")]
	public short m_FriendsGroupID; //Field offset: 0x0

	[Address(RVA = "0x60A310", Offset = "0x609710", Length = "0x38")]
	[Token(Token = "0x6000A3A")]
	private static FriendsGroupID_t() { }

	[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
	[Token(Token = "0x6000A30")]
	public FriendsGroupID_t(short value) { }

	[Address(RVA = "0x60A230", Offset = "0x609630", Length = "0x8")]
	[Token(Token = "0x6000A39")]
	public override int CompareTo(FriendsGroupID_t other) { }

	[Address(RVA = "0x60A250", Offset = "0x609650", Length = "0x99")]
	[Token(Token = "0x6000A32")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x60A240", Offset = "0x609640", Length = "0x7")]
	[Token(Token = "0x6000A38")]
	public override bool Equals(FriendsGroupID_t other) { }

	[Address(RVA = "0x60A2F0", Offset = "0x6096F0", Length = "0x7")]
	[Token(Token = "0x6000A33")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x60A360", Offset = "0x609760", Length = "0x7")]
	[Token(Token = "0x6000A34")]
	public static bool op_Equality(FriendsGroupID_t x, FriendsGroupID_t y) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[Token(Token = "0x6000A36")]
	public static FriendsGroupID_t op_Explicit(short value) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[Token(Token = "0x6000A37")]
	public static short op_Explicit(FriendsGroupID_t that) { }

	[Address(RVA = "0x60A380", Offset = "0x609780", Length = "0x52")]
	[Token(Token = "0x6000A35")]
	public static bool op_Inequality(FriendsGroupID_t x, FriendsGroupID_t y) { }

	[Address(RVA = "0x60A300", Offset = "0x609700", Length = "0x7")]
	[Token(Token = "0x6000A31")]
	public virtual string ToString() { }

}

