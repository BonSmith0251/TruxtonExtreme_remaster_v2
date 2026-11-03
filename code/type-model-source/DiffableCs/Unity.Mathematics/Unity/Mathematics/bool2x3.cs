namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200000D")]
public struct bool2x3 : IEquatable<bool2x3>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000043")]
	public bool2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000044")]
	public bool2 c1; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000045")]
	public bool2 c2; //Field offset: 0x4

	[Token(Token = "0x1700001F")]
	public bool2 Item
	{
		[Address(RVA = "0x9D7650", Offset = "0x9D6A50", Length = "0x8")]
		[Token(Token = "0x600082B")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2A75FC0", Offset = "0x2A753C0", Length = "0xE")]
	[Token(Token = "0x6000817")]
	public bool2x3(bool2 c0, bool2 c1, bool2 c2) { }

	[Address(RVA = "0x2A75F30", Offset = "0x2A75330", Length = "0x44")]
	[Token(Token = "0x6000818")]
	public bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12) { }

	[Address(RVA = "0x2A75F80", Offset = "0x2A75380", Length = "0x33")]
	[Token(Token = "0x6000819")]
	public bool2x3(bool v) { }

	[Address(RVA = "0x2A75B00", Offset = "0x2A74F00", Length = "0xE9")]
	[Token(Token = "0x600082D")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2A75BF0", Offset = "0x2A74FF0", Length = "0x39")]
	[Token(Token = "0x600082C")]
	public override bool Equals(bool2x3 rhs) { }

	[Address(RVA = "0x9D7650", Offset = "0x9D6A50", Length = "0x8")]
	[Token(Token = "0x600082B")]
	public bool2 get_Item(int index) { }

	[Address(RVA = "0x2A75C30", Offset = "0x2A75030", Length = "0x24")]
	[Token(Token = "0x600082E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A76050", Offset = "0x2A75450", Length = "0x71")]
	[Token(Token = "0x6000824")]
	public static bool2x3 op_BitwiseAnd(bool lhs, bool2x3 rhs) { }

	[Address(RVA = "0x2A760D0", Offset = "0x2A754D0", Length = "0x93")]
	[Token(Token = "0x6000822")]
	public static bool2x3 op_BitwiseAnd(bool2x3 lhs, bool2x3 rhs) { }

	[Address(RVA = "0x2A75FD0", Offset = "0x2A753D0", Length = "0x72")]
	[Token(Token = "0x6000823")]
	public static bool2x3 op_BitwiseAnd(bool2x3 lhs, bool rhs) { }

	[Address(RVA = "0x2A761F0", Offset = "0x2A755F0", Length = "0x98")]
	[Token(Token = "0x6000825")]
	public static bool2x3 op_BitwiseOr(bool2x3 lhs, bool2x3 rhs) { }

	[Address(RVA = "0x2A76170", Offset = "0x2A75570", Length = "0x76")]
	[Token(Token = "0x6000826")]
	public static bool2x3 op_BitwiseOr(bool2x3 lhs, bool rhs) { }

	[Address(RVA = "0x2A76290", Offset = "0x2A75690", Length = "0x75")]
	[Token(Token = "0x6000827")]
	public static bool2x3 op_BitwiseOr(bool lhs, bool2x3 rhs) { }

	[Address(RVA = "0x2A76410", Offset = "0x2A75810", Length = "0x62")]
	[Token(Token = "0x600081D")]
	public static bool2x3 op_Equality(bool lhs, bool2x3 rhs) { }

	[Address(RVA = "0x2A763A0", Offset = "0x2A757A0", Length = "0x65")]
	[Token(Token = "0x600081C")]
	public static bool2x3 op_Equality(bool2x3 lhs, bool rhs) { }

	[Address(RVA = "0x2A76310", Offset = "0x2A75710", Length = "0x87")]
	[Token(Token = "0x600081B")]
	public static bool2x3 op_Equality(bool2x3 lhs, bool2x3 rhs) { }

	[Address(RVA = "0x2A76580", Offset = "0x2A75980", Length = "0x98")]
	[Token(Token = "0x6000828")]
	public static bool2x3 op_ExclusiveOr(bool2x3 lhs, bool2x3 rhs) { }

	[Address(RVA = "0x2A76480", Offset = "0x2A75880", Length = "0x76")]
	[Token(Token = "0x6000829")]
	public static bool2x3 op_ExclusiveOr(bool2x3 lhs, bool rhs) { }

	[Address(RVA = "0x2A76500", Offset = "0x2A75900", Length = "0x75")]
	[Token(Token = "0x600082A")]
	public static bool2x3 op_ExclusiveOr(bool lhs, bool2x3 rhs) { }

	[Address(RVA = "0x2A27620", Offset = "0x2A26A20", Length = "0x36")]
	[Token(Token = "0x600081A")]
	public static bool2x3 op_Implicit(bool v) { }

	[Address(RVA = "0x2A76620", Offset = "0x2A75A20", Length = "0x65")]
	[Token(Token = "0x600081F")]
	public static bool2x3 op_Inequality(bool2x3 lhs, bool rhs) { }

	[Address(RVA = "0x2A76690", Offset = "0x2A75A90", Length = "0x87")]
	[Token(Token = "0x600081E")]
	public static bool2x3 op_Inequality(bool2x3 lhs, bool2x3 rhs) { }

	[Address(RVA = "0x2A76720", Offset = "0x2A75B20", Length = "0x62")]
	[Token(Token = "0x6000820")]
	public static bool2x3 op_Inequality(bool lhs, bool2x3 rhs) { }

	[Address(RVA = "0x2A76790", Offset = "0x2A75B90", Length = "0x5F")]
	[Token(Token = "0x6000821")]
	public static bool2x3 op_LogicalNot(bool2x3 val) { }

	[Address(RVA = "0x2A75C60", Offset = "0x2A75060", Length = "0x2C6")]
	[Token(Token = "0x600082F")]
	public virtual string ToString() { }

}

