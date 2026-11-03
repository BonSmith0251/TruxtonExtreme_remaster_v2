namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000012")]
public struct bool3x3 : IEquatable<bool3x3>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000052")]
	public bool3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000053")]
	public bool3 c1; //Field offset: 0x3
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000054")]
	public bool3 c2; //Field offset: 0x6

	[Token(Token = "0x17000098")]
	public bool3 Item
	{
		[Address(RVA = "0x2A793D0", Offset = "0x2A787D0", Length = "0xB")]
		[Token(Token = "0x6000914")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2A7A360", Offset = "0x2A79760", Length = "0x2E")]
	[Token(Token = "0x6000900")]
	public bool3x3(bool3 c0, bool3 c1, bool3 c2) { }

	[Address(RVA = "0x2A7A2F0", Offset = "0x2A796F0", Length = "0x61")]
	[Token(Token = "0x6000901")]
	public bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22) { }

	[Address(RVA = "0x2A7A2B0", Offset = "0x2A796B0", Length = "0x3C")]
	[Token(Token = "0x6000902")]
	public bool3x3(bool v) { }

	[Address(RVA = "0x2A79D10", Offset = "0x2A79110", Length = "0xF6")]
	[Token(Token = "0x6000916")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2A79E10", Offset = "0x2A79210", Length = "0x7D")]
	[Token(Token = "0x6000915")]
	public override bool Equals(bool3x3 rhs) { }

	[Address(RVA = "0x2A793D0", Offset = "0x2A787D0", Length = "0xB")]
	[Token(Token = "0x6000914")]
	public bool3 get_Item(int index) { }

	[Address(RVA = "0x2A79E90", Offset = "0x2A79290", Length = "0x27")]
	[Token(Token = "0x6000917")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A7A390", Offset = "0x2A79790", Length = "0xB0")]
	[Token(Token = "0x600090D")]
	public static bool3x3 op_BitwiseAnd(bool lhs, bool3x3 rhs) { }

	[Address(RVA = "0x2A7A440", Offset = "0x2A79840", Length = "0xDB")]
	[Token(Token = "0x600090B")]
	public static bool3x3 op_BitwiseAnd(bool3x3 lhs, bool3x3 rhs) { }

	[Address(RVA = "0x2A7A520", Offset = "0x2A79920", Length = "0xB6")]
	[Token(Token = "0x600090C")]
	public static bool3x3 op_BitwiseAnd(bool3x3 lhs, bool rhs) { }

	[Address(RVA = "0x2A7A6A0", Offset = "0x2A79AA0", Length = "0xE6")]
	[Token(Token = "0x600090E")]
	public static bool3x3 op_BitwiseOr(bool3x3 lhs, bool3x3 rhs) { }

	[Address(RVA = "0x2A7A5E0", Offset = "0x2A799E0", Length = "0xBD")]
	[Token(Token = "0x600090F")]
	public static bool3x3 op_BitwiseOr(bool3x3 lhs, bool rhs) { }

	[Address(RVA = "0x2A7A790", Offset = "0x2A79B90", Length = "0xBC")]
	[Token(Token = "0x6000910")]
	public static bool3x3 op_BitwiseOr(bool lhs, bool3x3 rhs) { }

	[Address(RVA = "0x2A7A850", Offset = "0x2A79C50", Length = "0xA8")]
	[Token(Token = "0x6000906")]
	public static bool3x3 op_Equality(bool lhs, bool3x3 rhs) { }

	[Address(RVA = "0x2A7A9F0", Offset = "0x2A79DF0", Length = "0xA9")]
	[Token(Token = "0x6000905")]
	public static bool3x3 op_Equality(bool3x3 lhs, bool rhs) { }

	[Address(RVA = "0x2A7A900", Offset = "0x2A79D00", Length = "0xEB")]
	[Token(Token = "0x6000904")]
	public static bool3x3 op_Equality(bool3x3 lhs, bool3x3 rhs) { }

	[Address(RVA = "0x2A7AC20", Offset = "0x2A7A020", Length = "0xE6")]
	[Token(Token = "0x6000911")]
	public static bool3x3 op_ExclusiveOr(bool3x3 lhs, bool3x3 rhs) { }

	[Address(RVA = "0x2A7AAA0", Offset = "0x2A79EA0", Length = "0xBD")]
	[Token(Token = "0x6000912")]
	public static bool3x3 op_ExclusiveOr(bool3x3 lhs, bool rhs) { }

	[Address(RVA = "0x2A7AB60", Offset = "0x2A79F60", Length = "0xBC")]
	[Token(Token = "0x6000913")]
	public static bool3x3 op_ExclusiveOr(bool lhs, bool3x3 rhs) { }

	[Address(RVA = "0x2A278E0", Offset = "0x2A26CE0", Length = "0x3F")]
	[Token(Token = "0x6000903")]
	public static bool3x3 op_Implicit(bool v) { }

	[Address(RVA = "0x2A7ADC0", Offset = "0x2A7A1C0", Length = "0xA9")]
	[Token(Token = "0x6000908")]
	public static bool3x3 op_Inequality(bool3x3 lhs, bool rhs) { }

	[Address(RVA = "0x2A7AE70", Offset = "0x2A7A270", Length = "0xEB")]
	[Token(Token = "0x6000907")]
	public static bool3x3 op_Inequality(bool3x3 lhs, bool3x3 rhs) { }

	[Address(RVA = "0x2A7AD10", Offset = "0x2A7A110", Length = "0xA8")]
	[Token(Token = "0x6000909")]
	public static bool3x3 op_Inequality(bool lhs, bool3x3 rhs) { }

	[Address(RVA = "0x2A7AF60", Offset = "0x2A7A360", Length = "0xA5")]
	[Token(Token = "0x600090A")]
	public static bool3x3 op_LogicalNot(bool3x3 val) { }

	[Address(RVA = "0x2A79EC0", Offset = "0x2A792C0", Length = "0x3EF")]
	[Token(Token = "0x6000918")]
	public virtual string ToString() { }

}

