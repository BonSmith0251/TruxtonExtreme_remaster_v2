namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200000C")]
public struct bool2x2 : IEquatable<bool2x2>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000041")]
	public bool2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000042")]
	public bool2 c1; //Field offset: 0x2

	[Token(Token = "0x1700001E")]
	public bool2 Item
	{
		[Address(RVA = "0x9D7650", Offset = "0x9D6A50", Length = "0x8")]
		[Token(Token = "0x6000812")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1F77C20", Offset = "0x1F77020", Length = "0x9")]
	[Token(Token = "0x60007FE")]
	public bool2x2(bool2 c0, bool2 c1) { }

	[Address(RVA = "0x2A75310", Offset = "0x2A74710", Length = "0x29")]
	[Token(Token = "0x60007FF")]
	public bool2x2(bool m00, bool m01, bool m10, bool m11) { }

	[Address(RVA = "0x2A752E0", Offset = "0x2A746E0", Length = "0x22")]
	[Token(Token = "0x6000800")]
	public bool2x2(bool v) { }

	[Address(RVA = "0x2A75000", Offset = "0x2A74400", Length = "0x9C")]
	[Token(Token = "0x6000814")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2A750A0", Offset = "0x2A744A0", Length = "0x26")]
	[Token(Token = "0x6000813")]
	public override bool Equals(bool2x2 rhs) { }

	[Address(RVA = "0x9D7650", Offset = "0x9D6A50", Length = "0x8")]
	[Token(Token = "0x6000812")]
	public bool2 get_Item(int index) { }

	[Address(RVA = "0x2A750D0", Offset = "0x2A744D0", Length = "0x9")]
	[Token(Token = "0x6000815")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A753B0", Offset = "0x2A747B0", Length = "0x6A")]
	[Token(Token = "0x600080B")]
	public static bool2x2 op_BitwiseAnd(bool lhs, bool2x2 rhs) { }

	[Address(RVA = "0x2A75420", Offset = "0x2A74820", Length = "0x84")]
	[Token(Token = "0x6000809")]
	public static bool2x2 op_BitwiseAnd(bool2x2 lhs, bool2x2 rhs) { }

	[Address(RVA = "0x2A75340", Offset = "0x2A74740", Length = "0x6A")]
	[Token(Token = "0x600080A")]
	public static bool2x2 op_BitwiseAnd(bool2x2 lhs, bool rhs) { }

	[Address(RVA = "0x2A75530", Offset = "0x2A74930", Length = "0x8B")]
	[Token(Token = "0x600080C")]
	public static bool2x2 op_BitwiseOr(bool2x2 lhs, bool2x2 rhs) { }

	[Address(RVA = "0x2A755C0", Offset = "0x2A749C0", Length = "0x72")]
	[Token(Token = "0x600080D")]
	public static bool2x2 op_BitwiseOr(bool2x2 lhs, bool rhs) { }

	[Address(RVA = "0x2A754B0", Offset = "0x2A748B0", Length = "0x72")]
	[Token(Token = "0x600080E")]
	public static bool2x2 op_BitwiseOr(bool lhs, bool2x2 rhs) { }

	[Address(RVA = "0x2A75640", Offset = "0x2A74A40", Length = "0x6C")]
	[Token(Token = "0x6000804")]
	public static bool2x2 op_Equality(bool lhs, bool2x2 rhs) { }

	[Address(RVA = "0x2A75730", Offset = "0x2A74B30", Length = "0x6C")]
	[Token(Token = "0x6000803")]
	public static bool2x2 op_Equality(bool2x2 lhs, bool rhs) { }

	[Address(RVA = "0x2A756B0", Offset = "0x2A74AB0", Length = "0x7B")]
	[Token(Token = "0x6000802")]
	public static bool2x2 op_Equality(bool2x2 lhs, bool2x2 rhs) { }

	[Address(RVA = "0x2A757A0", Offset = "0x2A74BA0", Length = "0x81")]
	[Token(Token = "0x600080F")]
	public static bool2x2 op_ExclusiveOr(bool2x2 lhs, bool2x2 rhs) { }

	[Address(RVA = "0x2A75830", Offset = "0x2A74C30", Length = "0x72")]
	[Token(Token = "0x6000810")]
	public static bool2x2 op_ExclusiveOr(bool2x2 lhs, bool rhs) { }

	[Address(RVA = "0x2A758B0", Offset = "0x2A74CB0", Length = "0x72")]
	[Token(Token = "0x6000811")]
	public static bool2x2 op_ExclusiveOr(bool lhs, bool2x2 rhs) { }

	[Address(RVA = "0x2A27550", Offset = "0x2A26950", Length = "0x29")]
	[Token(Token = "0x6000801")]
	public static bool2x2 op_Implicit(bool v) { }

	[Address(RVA = "0x2A759A0", Offset = "0x2A74DA0", Length = "0x6C")]
	[Token(Token = "0x6000806")]
	public static bool2x2 op_Inequality(bool2x2 lhs, bool rhs) { }

	[Address(RVA = "0x2A75A10", Offset = "0x2A74E10", Length = "0x7B")]
	[Token(Token = "0x6000805")]
	public static bool2x2 op_Inequality(bool2x2 lhs, bool2x2 rhs) { }

	[Address(RVA = "0x2A75930", Offset = "0x2A74D30", Length = "0x6C")]
	[Token(Token = "0x6000807")]
	public static bool2x2 op_Inequality(bool lhs, bool2x2 rhs) { }

	[Address(RVA = "0x2A75A90", Offset = "0x2A74E90", Length = "0x64")]
	[Token(Token = "0x6000808")]
	public static bool2x2 op_LogicalNot(bool2x2 val) { }

	[Address(RVA = "0x2A750E0", Offset = "0x2A744E0", Length = "0x1F8")]
	[Token(Token = "0x6000816")]
	public virtual string ToString() { }

}

