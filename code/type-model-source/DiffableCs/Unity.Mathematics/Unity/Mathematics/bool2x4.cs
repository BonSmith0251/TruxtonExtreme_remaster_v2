namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200000E")]
public struct bool2x4 : IEquatable<bool2x4>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000046")]
	public bool2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000047")]
	public bool2 c1; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000048")]
	public bool2 c2; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000049")]
	public bool2 c3; //Field offset: 0x6

	[Token(Token = "0x17000020")]
	public bool2 Item
	{
		[Address(RVA = "0x9D7650", Offset = "0x9D6A50", Length = "0x8")]
		[Token(Token = "0x6000844")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x27F6E80", Offset = "0x27F6280", Length = "0x17")]
	[Token(Token = "0x6000830")]
	public bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3) { }

	[Address(RVA = "0x2A76CC0", Offset = "0x2A760C0", Length = "0x5F")]
	[Token(Token = "0x6000831")]
	public bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13) { }

	[Address(RVA = "0x2A76D20", Offset = "0x2A76120", Length = "0x44")]
	[Token(Token = "0x6000832")]
	public bool2x4(bool v) { }

	[Address(RVA = "0x2A767F0", Offset = "0x2A75BF0", Length = "0xCC")]
	[Token(Token = "0x6000846")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2A768C0", Offset = "0x2A75CC0", Length = "0x51")]
	[Token(Token = "0x6000845")]
	public override bool Equals(bool2x4 rhs) { }

	[Address(RVA = "0x9D7650", Offset = "0x9D6A50", Length = "0x8")]
	[Token(Token = "0x6000844")]
	public bool2 get_Item(int index) { }

	[Address(RVA = "0x2A76920", Offset = "0x2A75D20", Length = "0xA")]
	[Token(Token = "0x6000847")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A76D70", Offset = "0x2A76170", Length = "0xDB")]
	[Token(Token = "0x600083D")]
	public static bool2x4 op_BitwiseAnd(bool lhs, bool2x4 rhs) { }

	[Address(RVA = "0x2A76F30", Offset = "0x2A76330", Length = "0x126")]
	[Token(Token = "0x600083B")]
	public static bool2x4 op_BitwiseAnd(bool2x4 lhs, bool2x4 rhs) { }

	[Address(RVA = "0x2A76E50", Offset = "0x2A76250", Length = "0xDB")]
	[Token(Token = "0x600083C")]
	public static bool2x4 op_BitwiseAnd(bool2x4 lhs, bool rhs) { }

	[Address(RVA = "0x2A77240", Offset = "0x2A76640", Length = "0x135")]
	[Token(Token = "0x600083E")]
	public static bool2x4 op_BitwiseOr(bool2x4 lhs, bool2x4 rhs) { }

	[Address(RVA = "0x2A77060", Offset = "0x2A76460", Length = "0xEC")]
	[Token(Token = "0x600083F")]
	public static bool2x4 op_BitwiseOr(bool2x4 lhs, bool rhs) { }

	[Address(RVA = "0x2A77150", Offset = "0x2A76550", Length = "0xED")]
	[Token(Token = "0x6000840")]
	public static bool2x4 op_BitwiseOr(bool lhs, bool2x4 rhs) { }

	[Address(RVA = "0x2A77460", Offset = "0x2A76860", Length = "0xDF")]
	[Token(Token = "0x6000836")]
	public static bool2x4 op_Equality(bool lhs, bool2x4 rhs) { }

	[Address(RVA = "0x2A77380", Offset = "0x2A76780", Length = "0xDF")]
	[Token(Token = "0x6000835")]
	public static bool2x4 op_Equality(bool2x4 lhs, bool rhs) { }

	[Address(RVA = "0x2A77540", Offset = "0x2A76940", Length = "0x107")]
	[Token(Token = "0x6000834")]
	public static bool2x4 op_Equality(bool2x4 lhs, bool2x4 rhs) { }

	[Address(RVA = "0x2A77740", Offset = "0x2A76B40", Length = "0x11D")]
	[Token(Token = "0x6000841")]
	public static bool2x4 op_ExclusiveOr(bool2x4 lhs, bool2x4 rhs) { }

	[Address(RVA = "0x2A77650", Offset = "0x2A76A50", Length = "0xED")]
	[Token(Token = "0x6000842")]
	public static bool2x4 op_ExclusiveOr(bool2x4 lhs, bool rhs) { }

	[Address(RVA = "0x2A77860", Offset = "0x2A76C60", Length = "0xED")]
	[Token(Token = "0x6000843")]
	public static bool2x4 op_ExclusiveOr(bool lhs, bool2x4 rhs) { }

	[Address(RVA = "0x2A27700", Offset = "0x2A26B00", Length = "0x4E")]
	[Token(Token = "0x6000833")]
	public static bool2x4 op_Implicit(bool v) { }

	[Address(RVA = "0x2A77950", Offset = "0x2A76D50", Length = "0xDF")]
	[Token(Token = "0x6000838")]
	public static bool2x4 op_Inequality(bool2x4 lhs, bool rhs) { }

	[Address(RVA = "0x2A77B10", Offset = "0x2A76F10", Length = "0x107")]
	[Token(Token = "0x6000837")]
	public static bool2x4 op_Inequality(bool2x4 lhs, bool2x4 rhs) { }

	[Address(RVA = "0x2A77A30", Offset = "0x2A76E30", Length = "0xDF")]
	[Token(Token = "0x6000839")]
	public static bool2x4 op_Inequality(bool lhs, bool2x4 rhs) { }

	[Address(RVA = "0x2A77C20", Offset = "0x2A77020", Length = "0xD3")]
	[Token(Token = "0x600083A")]
	public static bool2x4 op_LogicalNot(bool2x4 val) { }

	[Address(RVA = "0x2A76930", Offset = "0x2A75D30", Length = "0x38C")]
	[Token(Token = "0x6000848")]
	public virtual string ToString() { }

}

