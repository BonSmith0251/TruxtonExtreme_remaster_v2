namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000018")]
public struct bool4x4 : IEquatable<bool4x4>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000066")]
	public bool4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000067")]
	public bool4 c1; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000068")]
	public bool4 c2; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000069")]
	public bool4 c3; //Field offset: 0xC

	[Token(Token = "0x170001ED")]
	public bool4 Item
	{
		[Address(RVA = "0x9D75F0", Offset = "0x9D69F0", Length = "0x8")]
		[Token(Token = "0x6000B25")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x27F6A90", Offset = "0x27F5E90", Length = "0x12")]
	[Token(Token = "0x6000B11")]
	public bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3) { }

	[Address(RVA = "0x2AA3330", Offset = "0x2AA2730", Length = "0xA5")]
	[Token(Token = "0x6000B12")]
	public bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33) { }

	[Address(RVA = "0x2AA33E0", Offset = "0x2AA27E0", Length = "0x5C")]
	[Token(Token = "0x6000B13")]
	public bool4x4(bool v) { }

	[Address(RVA = "0x2AA2BC0", Offset = "0x2AA1FC0", Length = "0x90")]
	[Token(Token = "0x6000B27")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2A9DCA0", Offset = "0x2A9D0A0", Length = "0x1E28")]
	[Token(Token = "0x6000B26")]
	public override bool Equals(bool4x4 rhs) { }

	[Address(RVA = "0x9D75F0", Offset = "0x9D69F0", Length = "0x8")]
	[Token(Token = "0x6000B25")]
	public bool4 get_Item(int index) { }

	[Address(RVA = "0x2AA2C60", Offset = "0x2AA2060", Length = "0x1D")]
	[Token(Token = "0x6000B28")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AA3530", Offset = "0x2AA2930", Length = "0xE6")]
	[Token(Token = "0x6000B1E")]
	public static bool4x4 op_BitwiseAnd(bool lhs, bool4x4 rhs) { }

	[Address(RVA = "0x2AA3620", Offset = "0x2AA2A20", Length = "0x147")]
	[Token(Token = "0x6000B1C")]
	public static bool4x4 op_BitwiseAnd(bool4x4 lhs, bool4x4 rhs) { }

	[Address(RVA = "0x2AA3440", Offset = "0x2AA2840", Length = "0xEF")]
	[Token(Token = "0x6000B1D")]
	public static bool4x4 op_BitwiseAnd(bool4x4 lhs, bool rhs) { }

	[Address(RVA = "0x2AA3970", Offset = "0x2AA2D70", Length = "0x14E")]
	[Token(Token = "0x6000B1F")]
	public static bool4x4 op_BitwiseOr(bool4x4 lhs, bool4x4 rhs) { }

	[Address(RVA = "0x2AA3770", Offset = "0x2AA2B70", Length = "0xFC")]
	[Token(Token = "0x6000B20")]
	public static bool4x4 op_BitwiseOr(bool4x4 lhs, bool rhs) { }

	[Address(RVA = "0x2AA3870", Offset = "0x2AA2C70", Length = "0xF3")]
	[Token(Token = "0x6000B21")]
	public static bool4x4 op_BitwiseOr(bool lhs, bool4x4 rhs) { }

	[Address(RVA = "0x2AA3D00", Offset = "0x2AA3100", Length = "0xE5")]
	[Token(Token = "0x6000B17")]
	public static bool4x4 op_Equality(bool lhs, bool4x4 rhs) { }

	[Address(RVA = "0x2AA3AC0", Offset = "0x2AA2EC0", Length = "0xEF")]
	[Token(Token = "0x6000B16")]
	public static bool4x4 op_Equality(bool4x4 lhs, bool rhs) { }

	[Address(RVA = "0x2AA3BB0", Offset = "0x2AA2FB0", Length = "0x144")]
	[Token(Token = "0x6000B15")]
	public static bool4x4 op_Equality(bool4x4 lhs, bool4x4 rhs) { }

	[Address(RVA = "0x2AA3EF0", Offset = "0x2AA32F0", Length = "0x14E")]
	[Token(Token = "0x6000B22")]
	public static bool4x4 op_ExclusiveOr(bool4x4 lhs, bool4x4 rhs) { }

	[Address(RVA = "0x2AA4040", Offset = "0x2AA3440", Length = "0xFC")]
	[Token(Token = "0x6000B23")]
	public static bool4x4 op_ExclusiveOr(bool4x4 lhs, bool rhs) { }

	[Address(RVA = "0x2AA3DF0", Offset = "0x2AA31F0", Length = "0xF3")]
	[Token(Token = "0x6000B24")]
	public static bool4x4 op_ExclusiveOr(bool lhs, bool4x4 rhs) { }

	[Address(RVA = "0x2A27E30", Offset = "0x2A27230", Length = "0x5F")]
	[Token(Token = "0x6000B14")]
	public static bool4x4 op_Implicit(bool v) { }

	[Address(RVA = "0x2AA4380", Offset = "0x2AA3780", Length = "0xEF")]
	[Token(Token = "0x6000B19")]
	public static bool4x4 op_Inequality(bool4x4 lhs, bool rhs) { }

	[Address(RVA = "0x2AA4230", Offset = "0x2AA3630", Length = "0x144")]
	[Token(Token = "0x6000B18")]
	public static bool4x4 op_Inequality(bool4x4 lhs, bool4x4 rhs) { }

	[Address(RVA = "0x2AA4140", Offset = "0x2AA3540", Length = "0xE5")]
	[Token(Token = "0x6000B1A")]
	public static bool4x4 op_Inequality(bool lhs, bool4x4 rhs) { }

	[Address(RVA = "0x2AA4470", Offset = "0x2AA3870", Length = "0xE1")]
	[Token(Token = "0x6000B1B")]
	public static bool4x4 op_LogicalNot(bool4x4 val) { }

	[Address(RVA = "0x2AA2C80", Offset = "0x2AA2080", Length = "0x6A8")]
	[Token(Token = "0x6000B29")]
	public virtual string ToString() { }

}

