namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000013")]
public struct bool3x4 : IEquatable<bool3x4>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000055")]
	public bool3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000056")]
	public bool3 c1; //Field offset: 0x3
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000057")]
	public bool3 c2; //Field offset: 0x6
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000058")]
	public bool3 c3; //Field offset: 0x9

	[Token(Token = "0x17000099")]
	public bool3 Item
	{
		[Address(RVA = "0x2A793D0", Offset = "0x2A787D0", Length = "0xB")]
		[Token(Token = "0x600092D")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2A7B6D0", Offset = "0x2A7AAD0", Length = "0x46")]
	[Token(Token = "0x6000919")]
	public bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3) { }

	[Address(RVA = "0x2A7B640", Offset = "0x2A7AA40", Length = "0x86")]
	[Token(Token = "0x600091A")]
	public bool3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23) { }

	[Address(RVA = "0x2A7B5F0", Offset = "0x2A7A9F0", Length = "0x50")]
	[Token(Token = "0x600091B")]
	public bool3x4(bool v) { }

	[Address(RVA = "0x2A7B010", Offset = "0x2A7A410", Length = "0x99")]
	[Token(Token = "0x600092F")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2A72E30", Offset = "0x2A72230", Length = "0x7B8")]
	[Token(Token = "0x600092E")]
	public override bool Equals(bool3x4 rhs) { }

	[Address(RVA = "0x2A793D0", Offset = "0x2A787D0", Length = "0xB")]
	[Token(Token = "0x600092D")]
	public bool3 get_Item(int index) { }

	[Address(RVA = "0x2A7B0B0", Offset = "0x2A7A4B0", Length = "0x26")]
	[Token(Token = "0x6000930")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A7B720", Offset = "0x2A7AB20", Length = "0xEA")]
	[Token(Token = "0x6000926")]
	public static bool3x4 op_BitwiseAnd(bool lhs, bool3x4 rhs) { }

	[Address(RVA = "0x2A7B810", Offset = "0x2A7AC10", Length = "0x126")]
	[Token(Token = "0x6000924")]
	public static bool3x4 op_BitwiseAnd(bool3x4 lhs, bool3x4 rhs) { }

	[Address(RVA = "0x2A7B940", Offset = "0x2A7AD40", Length = "0xEE")]
	[Token(Token = "0x6000925")]
	public static bool3x4 op_BitwiseAnd(bool3x4 lhs, bool rhs) { }

	[Address(RVA = "0x2A7BC50", Offset = "0x2A7B050", Length = "0x133")]
	[Token(Token = "0x6000927")]
	public static bool3x4 op_BitwiseOr(bool3x4 lhs, bool3x4 rhs) { }

	[Address(RVA = "0x2A7BB40", Offset = "0x2A7AF40", Length = "0x10D")]
	[Token(Token = "0x6000928")]
	public static bool3x4 op_BitwiseOr(bool3x4 lhs, bool rhs) { }

	[Address(RVA = "0x2A7BA30", Offset = "0x2A7AE30", Length = "0x10D")]
	[Token(Token = "0x6000929")]
	public static bool3x4 op_BitwiseOr(bool lhs, bool3x4 rhs) { }

	[Address(RVA = "0x2A7BD90", Offset = "0x2A7B190", Length = "0xDC")]
	[Token(Token = "0x600091F")]
	public static bool3x4 op_Equality(bool lhs, bool3x4 rhs) { }

	[Address(RVA = "0x2A7BFC0", Offset = "0x2A7B3C0", Length = "0xDD")]
	[Token(Token = "0x600091E")]
	public static bool3x4 op_Equality(bool3x4 lhs, bool rhs) { }

	[Address(RVA = "0x2A7BE70", Offset = "0x2A7B270", Length = "0x144")]
	[Token(Token = "0x600091D")]
	public static bool3x4 op_Equality(bool3x4 lhs, bool3x4 rhs) { }

	[Address(RVA = "0x2A7C0A0", Offset = "0x2A7B4A0", Length = "0x133")]
	[Token(Token = "0x600092A")]
	public static bool3x4 op_ExclusiveOr(bool3x4 lhs, bool3x4 rhs) { }

	[Address(RVA = "0x2A7C1E0", Offset = "0x2A7B5E0", Length = "0x10D")]
	[Token(Token = "0x600092B")]
	public static bool3x4 op_ExclusiveOr(bool3x4 lhs, bool rhs) { }

	[Address(RVA = "0x2A7C2F0", Offset = "0x2A7B6F0", Length = "0x10D")]
	[Token(Token = "0x600092C")]
	public static bool3x4 op_ExclusiveOr(bool lhs, bool3x4 rhs) { }

	[Address(RVA = "0x2A27A40", Offset = "0x2A26E40", Length = "0x53")]
	[Token(Token = "0x600091C")]
	public static bool3x4 op_Implicit(bool v) { }

	[Address(RVA = "0x2A7C400", Offset = "0x2A7B800", Length = "0xDD")]
	[Token(Token = "0x6000921")]
	public static bool3x4 op_Inequality(bool3x4 lhs, bool rhs) { }

	[Address(RVA = "0x2A7C4E0", Offset = "0x2A7B8E0", Length = "0x144")]
	[Token(Token = "0x6000920")]
	public static bool3x4 op_Inequality(bool3x4 lhs, bool3x4 rhs) { }

	[Address(RVA = "0x2A7C630", Offset = "0x2A7BA30", Length = "0xDC")]
	[Token(Token = "0x6000922")]
	public static bool3x4 op_Inequality(bool lhs, bool3x4 rhs) { }

	[Address(RVA = "0x2A7C710", Offset = "0x2A7BB10", Length = "0xD6")]
	[Token(Token = "0x6000923")]
	public static bool3x4 op_LogicalNot(bool3x4 val) { }

	[Address(RVA = "0x2A7B0E0", Offset = "0x2A7A4E0", Length = "0x50C")]
	[Token(Token = "0x6000931")]
	public virtual string ToString() { }

}

