namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000017")]
public struct bool4x3 : IEquatable<bool4x3>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000063")]
	public bool4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000064")]
	public bool4 c1; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000065")]
	public bool4 c2; //Field offset: 0x8

	[Token(Token = "0x170001EC")]
	public bool4 Item
	{
		[Address(RVA = "0x9D75F0", Offset = "0x9D69F0", Length = "0x8")]
		[Token(Token = "0x6000B0C")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x12F4C60", Offset = "0x12F4060", Length = "0xB")]
	[Token(Token = "0x6000AF8")]
	public bool4x3(bool4 c0, bool4 c1, bool4 c2) { }

	[Address(RVA = "0x2AA1DD0", Offset = "0x2AA11D0", Length = "0x74")]
	[Token(Token = "0x6000AF9")]
	public bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32) { }

	[Address(RVA = "0x2AA1E50", Offset = "0x2AA1250", Length = "0x45")]
	[Token(Token = "0x6000AFA")]
	public bool4x3(bool v) { }

	[Address(RVA = "0x2AA16D0", Offset = "0x2AA0AD0", Length = "0x130")]
	[Token(Token = "0x6000B0E")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AA1810", Offset = "0x2AA0C10", Length = "0x7F")]
	[Token(Token = "0x6000B0D")]
	public override bool Equals(bool4x3 rhs) { }

	[Address(RVA = "0x9D75F0", Offset = "0x9D69F0", Length = "0x8")]
	[Token(Token = "0x6000B0C")]
	public bool4 get_Item(int index) { }

	[Address(RVA = "0x2AA1890", Offset = "0x2AA0C90", Length = "0x26")]
	[Token(Token = "0x6000B0F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AA1F60", Offset = "0x2AA1360", Length = "0xAC")]
	[Token(Token = "0x6000B05")]
	public static bool4x3 op_BitwiseAnd(bool lhs, bool4x3 rhs) { }

	[Address(RVA = "0x2AA2010", Offset = "0x2AA1410", Length = "0xFE")]
	[Token(Token = "0x6000B03")]
	public static bool4x3 op_BitwiseAnd(bool4x3 lhs, bool4x3 rhs) { }

	[Address(RVA = "0x2AA1EA0", Offset = "0x2AA12A0", Length = "0xB2")]
	[Token(Token = "0x6000B04")]
	public static bool4x3 op_BitwiseAnd(bool4x3 lhs, bool rhs) { }

	[Address(RVA = "0x2AA2110", Offset = "0x2AA1510", Length = "0x103")]
	[Token(Token = "0x6000B06")]
	public static bool4x3 op_BitwiseOr(bool4x3 lhs, bool4x3 rhs) { }

	[Address(RVA = "0x2AA2220", Offset = "0x2AA1620", Length = "0xBB")]
	[Token(Token = "0x6000B07")]
	public static bool4x3 op_BitwiseOr(bool4x3 lhs, bool rhs) { }

	[Address(RVA = "0x2AA22E0", Offset = "0x2AA16E0", Length = "0xB5")]
	[Token(Token = "0x6000B08")]
	public static bool4x3 op_BitwiseOr(bool lhs, bool4x3 rhs) { }

	[Address(RVA = "0x2AA2560", Offset = "0x2AA1960", Length = "0xAA")]
	[Token(Token = "0x6000AFE")]
	public static bool4x3 op_Equality(bool lhs, bool4x3 rhs) { }

	[Address(RVA = "0x2AA24A0", Offset = "0x2AA18A0", Length = "0xB1")]
	[Token(Token = "0x6000AFD")]
	public static bool4x3 op_Equality(bool4x3 lhs, bool rhs) { }

	[Address(RVA = "0x2AA23A0", Offset = "0x2AA17A0", Length = "0xFC")]
	[Token(Token = "0x6000AFC")]
	public static bool4x3 op_Equality(bool4x3 lhs, bool4x3 rhs) { }

	[Address(RVA = "0x2AA2610", Offset = "0x2AA1A10", Length = "0x103")]
	[Token(Token = "0x6000B09")]
	public static bool4x3 op_ExclusiveOr(bool4x3 lhs, bool4x3 rhs) { }

	[Address(RVA = "0x2AA27E0", Offset = "0x2AA1BE0", Length = "0xBB")]
	[Token(Token = "0x6000B0A")]
	public static bool4x3 op_ExclusiveOr(bool4x3 lhs, bool rhs) { }

	[Address(RVA = "0x2AA2720", Offset = "0x2AA1B20", Length = "0xB5")]
	[Token(Token = "0x6000B0B")]
	public static bool4x3 op_ExclusiveOr(bool lhs, bool4x3 rhs) { }

	[Address(RVA = "0x2A27CA0", Offset = "0x2A270A0", Length = "0x48")]
	[Token(Token = "0x6000AFB")]
	public static bool4x3 op_Implicit(bool v) { }

	[Address(RVA = "0x2AA28A0", Offset = "0x2AA1CA0", Length = "0xB1")]
	[Token(Token = "0x6000B00")]
	public static bool4x3 op_Inequality(bool4x3 lhs, bool rhs) { }

	[Address(RVA = "0x2AA2A10", Offset = "0x2AA1E10", Length = "0xFC")]
	[Token(Token = "0x6000AFF")]
	public static bool4x3 op_Inequality(bool4x3 lhs, bool4x3 rhs) { }

	[Address(RVA = "0x2AA2960", Offset = "0x2AA1D60", Length = "0xAA")]
	[Token(Token = "0x6000B01")]
	public static bool4x3 op_Inequality(bool lhs, bool4x3 rhs) { }

	[Address(RVA = "0x2AA2B10", Offset = "0x2AA1F10", Length = "0xA7")]
	[Token(Token = "0x6000B02")]
	public static bool4x3 op_LogicalNot(bool4x3 val) { }

	[Address(RVA = "0x2AA18C0", Offset = "0x2AA0CC0", Length = "0x50C")]
	[Token(Token = "0x6000B10")]
	public virtual string ToString() { }

}

