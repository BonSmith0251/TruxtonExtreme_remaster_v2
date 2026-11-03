namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000011")]
public struct bool3x2 : IEquatable<bool3x2>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000050")]
	public bool3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000051")]
	public bool3 c1; //Field offset: 0x3

	[Token(Token = "0x17000097")]
	public bool3 Item
	{
		[Address(RVA = "0x2A793D0", Offset = "0x2A787D0", Length = "0xB")]
		[Token(Token = "0x60008FB")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2A793B0", Offset = "0x2A787B0", Length = "0x1E")]
	[Token(Token = "0x60008E7")]
	public bool3x2(bool3 c0, bool3 c1) { }

	[Address(RVA = "0x2A79340", Offset = "0x2A78740", Length = "0x39")]
	[Token(Token = "0x60008E8")]
	public bool3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21) { }

	[Address(RVA = "0x2A79380", Offset = "0x2A78780", Length = "0x28")]
	[Token(Token = "0x60008E9")]
	public bool3x2(bool v) { }

	[Address(RVA = "0x2A78EA0", Offset = "0x2A782A0", Length = "0xCE")]
	[Token(Token = "0x60008FD")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2A78F70", Offset = "0x2A78370", Length = "0x54")]
	[Token(Token = "0x60008FC")]
	public override bool Equals(bool3x2 rhs) { }

	[Address(RVA = "0x2A793D0", Offset = "0x2A787D0", Length = "0xB")]
	[Token(Token = "0x60008FB")]
	public bool3 get_Item(int index) { }

	[Address(RVA = "0x2A78FD0", Offset = "0x2A783D0", Length = "0x9A")]
	[Token(Token = "0x60008FE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A793E0", Offset = "0x2A787E0", Length = "0x82")]
	[Token(Token = "0x60008F4")]
	public static bool3x2 op_BitwiseAnd(bool lhs, bool3x2 rhs) { }

	[Address(RVA = "0x2A794F0", Offset = "0x2A788F0", Length = "0x9F")]
	[Token(Token = "0x60008F2")]
	public static bool3x2 op_BitwiseAnd(bool3x2 lhs, bool3x2 rhs) { }

	[Address(RVA = "0x2A79470", Offset = "0x2A78870", Length = "0x7B")]
	[Token(Token = "0x60008F3")]
	public static bool3x2 op_BitwiseAnd(bool3x2 lhs, bool rhs) { }

	[Address(RVA = "0x2A796B0", Offset = "0x2A78AB0", Length = "0xA8")]
	[Token(Token = "0x60008F5")]
	public static bool3x2 op_BitwiseOr(bool3x2 lhs, bool3x2 rhs) { }

	[Address(RVA = "0x2A79590", Offset = "0x2A78990", Length = "0x88")]
	[Token(Token = "0x60008F6")]
	public static bool3x2 op_BitwiseOr(bool3x2 lhs, bool rhs) { }

	[Address(RVA = "0x2A79620", Offset = "0x2A78A20", Length = "0x8E")]
	[Token(Token = "0x60008F7")]
	public static bool3x2 op_BitwiseOr(bool lhs, bool3x2 rhs) { }

	[Address(RVA = "0x2A79760", Offset = "0x2A78B60", Length = "0x73")]
	[Token(Token = "0x60008ED")]
	public static bool3x2 op_Equality(bool lhs, bool3x2 rhs) { }

	[Address(RVA = "0x2A79890", Offset = "0x2A78C90", Length = "0x74")]
	[Token(Token = "0x60008EC")]
	public static bool3x2 op_Equality(bool3x2 lhs, bool rhs) { }

	[Address(RVA = "0x2A797E0", Offset = "0x2A78BE0", Length = "0xA8")]
	[Token(Token = "0x60008EB")]
	public static bool3x2 op_Equality(bool3x2 lhs, bool3x2 rhs) { }

	[Address(RVA = "0x2A799A0", Offset = "0x2A78DA0", Length = "0xA8")]
	[Token(Token = "0x60008F8")]
	public static bool3x2 op_ExclusiveOr(bool3x2 lhs, bool3x2 rhs) { }

	[Address(RVA = "0x2A79910", Offset = "0x2A78D10", Length = "0x88")]
	[Token(Token = "0x60008F9")]
	public static bool3x2 op_ExclusiveOr(bool3x2 lhs, bool rhs) { }

	[Address(RVA = "0x2A79A50", Offset = "0x2A78E50", Length = "0x8E")]
	[Token(Token = "0x60008FA")]
	public static bool3x2 op_ExclusiveOr(bool lhs, bool3x2 rhs) { }

	[Address(RVA = "0x2A27840", Offset = "0x2A26C40", Length = "0x2B")]
	[Token(Token = "0x60008EA")]
	public static bool3x2 op_Implicit(bool v) { }

	[Address(RVA = "0x2A79B60", Offset = "0x2A78F60", Length = "0x74")]
	[Token(Token = "0x60008EF")]
	public static bool3x2 op_Inequality(bool3x2 lhs, bool rhs) { }

	[Address(RVA = "0x2A79BE0", Offset = "0x2A78FE0", Length = "0xA8")]
	[Token(Token = "0x60008EE")]
	public static bool3x2 op_Inequality(bool3x2 lhs, bool3x2 rhs) { }

	[Address(RVA = "0x2A79AE0", Offset = "0x2A78EE0", Length = "0x73")]
	[Token(Token = "0x60008F0")]
	public static bool3x2 op_Inequality(bool lhs, bool3x2 rhs) { }

	[Address(RVA = "0x2A79C90", Offset = "0x2A79090", Length = "0x73")]
	[Token(Token = "0x60008F1")]
	public static bool3x2 op_LogicalNot(bool3x2 val) { }

	[Address(RVA = "0x2A79070", Offset = "0x2A78470", Length = "0x2C6")]
	[Token(Token = "0x60008FF")]
	public virtual string ToString() { }

}

