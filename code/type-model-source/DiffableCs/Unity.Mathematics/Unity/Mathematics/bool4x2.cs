namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000016")]
public struct bool4x2 : IEquatable<bool4x2>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000061")]
	public bool4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000062")]
	public bool4 c1; //Field offset: 0x4

	[Token(Token = "0x170001EB")]
	public bool4 Item
	{
		[Address(RVA = "0x9D75F0", Offset = "0x9D69F0", Length = "0x8")]
		[Token(Token = "0x6000AF3")]
		 get { } //Length: 8
	}

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6000ADF")]
	public bool4x2(bool4 c0, bool4 c1) { }

	[Address(RVA = "0x2AA0950", Offset = "0x2A9FD50", Length = "0x49")]
	[Token(Token = "0x6000AE0")]
	public bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31) { }

	[Address(RVA = "0x2AA0920", Offset = "0x2A9FD20", Length = "0x2E")]
	[Token(Token = "0x6000AE1")]
	public bool4x2(bool v) { }

	[Address(RVA = "0x2AA04B0", Offset = "0x2A9F8B0", Length = "0xC7")]
	[Token(Token = "0x6000AF5")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AA0460", Offset = "0x2A9F860", Length = "0x4C")]
	[Token(Token = "0x6000AF4")]
	public override bool Equals(bool4x2 rhs) { }

	[Address(RVA = "0x9D75F0", Offset = "0x9D69F0", Length = "0x8")]
	[Token(Token = "0x6000AF3")]
	public bool4 get_Item(int index) { }

	[Address(RVA = "0x2AA0580", Offset = "0x2A9F980", Length = "0xA")]
	[Token(Token = "0x6000AF6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AA09A0", Offset = "0x2A9FDA0", Length = "0xB3")]
	[Token(Token = "0x6000AEC")]
	public static bool4x2 op_BitwiseAnd(bool lhs, bool4x2 rhs) { }

	[Address(RVA = "0x2AA0A60", Offset = "0x2A9FE60", Length = "0xF8")]
	[Token(Token = "0x6000AEA")]
	public static bool4x2 op_BitwiseAnd(bool4x2 lhs, bool4x2 rhs) { }

	[Address(RVA = "0x2AA0B60", Offset = "0x2A9FF60", Length = "0xB7")]
	[Token(Token = "0x6000AEB")]
	public static bool4x2 op_BitwiseAnd(bool4x2 lhs, bool rhs) { }

	[Address(RVA = "0x2AA0C20", Offset = "0x2AA0020", Length = "0x100")]
	[Token(Token = "0x6000AED")]
	public static bool4x2 op_BitwiseOr(bool4x2 lhs, bool4x2 rhs) { }

	[Address(RVA = "0x2AA0D20", Offset = "0x2AA0120", Length = "0xC3")]
	[Token(Token = "0x6000AEE")]
	public static bool4x2 op_BitwiseOr(bool4x2 lhs, bool rhs) { }

	[Address(RVA = "0x2AA0DF0", Offset = "0x2AA01F0", Length = "0xBD")]
	[Token(Token = "0x6000AEF")]
	public static bool4x2 op_BitwiseOr(bool lhs, bool4x2 rhs) { }

	[Address(RVA = "0x2AA1060", Offset = "0x2AA0460", Length = "0xB7")]
	[Token(Token = "0x6000AE5")]
	public static bool4x2 op_Equality(bool lhs, bool4x2 rhs) { }

	[Address(RVA = "0x2AA0EB0", Offset = "0x2AA02B0", Length = "0xBD")]
	[Token(Token = "0x6000AE4")]
	public static bool4x2 op_Equality(bool4x2 lhs, bool rhs) { }

	[Address(RVA = "0x2AA0F70", Offset = "0x2AA0370", Length = "0xE6")]
	[Token(Token = "0x6000AE3")]
	public static bool4x2 op_Equality(bool4x2 lhs, bool4x2 rhs) { }

	[Address(RVA = "0x2AA1120", Offset = "0x2AA0520", Length = "0xEC")]
	[Token(Token = "0x6000AF0")]
	public static bool4x2 op_ExclusiveOr(bool4x2 lhs, bool4x2 rhs) { }

	[Address(RVA = "0x2AA12D0", Offset = "0x2AA06D0", Length = "0xC3")]
	[Token(Token = "0x6000AF1")]
	public static bool4x2 op_ExclusiveOr(bool4x2 lhs, bool rhs) { }

	[Address(RVA = "0x2AA1210", Offset = "0x2AA0610", Length = "0xBD")]
	[Token(Token = "0x6000AF2")]
	public static bool4x2 op_ExclusiveOr(bool lhs, bool4x2 rhs) { }

	[Address(RVA = "0x2A27C50", Offset = "0x2A27050", Length = "0x36")]
	[Token(Token = "0x6000AE2")]
	public static bool4x2 op_Implicit(bool v) { }

	[Address(RVA = "0x2AA1490", Offset = "0x2AA0890", Length = "0xBD")]
	[Token(Token = "0x6000AE7")]
	public static bool4x2 op_Inequality(bool4x2 lhs, bool rhs) { }

	[Address(RVA = "0x2AA13A0", Offset = "0x2AA07A0", Length = "0xE6")]
	[Token(Token = "0x6000AE6")]
	public static bool4x2 op_Inequality(bool4x2 lhs, bool4x2 rhs) { }

	[Address(RVA = "0x2AA1550", Offset = "0x2AA0950", Length = "0xB7")]
	[Token(Token = "0x6000AE8")]
	public static bool4x2 op_Inequality(bool lhs, bool4x2 rhs) { }

	[Address(RVA = "0x2AA1610", Offset = "0x2AA0A10", Length = "0xB1")]
	[Token(Token = "0x6000AE9")]
	public static bool4x2 op_LogicalNot(bool4x2 val) { }

	[Address(RVA = "0x2AA0590", Offset = "0x2A9F990", Length = "0x38C")]
	[Token(Token = "0x6000AF7")]
	public virtual string ToString() { }

}

