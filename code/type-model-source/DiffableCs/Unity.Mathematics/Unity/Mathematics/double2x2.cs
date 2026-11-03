namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200001B")]
public struct double2x2 : IEquatable<double2x2>, IFormattable
{
	[Token(Token = "0x4000071")]
	public static readonly double2x2 identity; //Field offset: 0x0
	[Token(Token = "0x4000072")]
	public static readonly double2x2 zero; //Field offset: 0x20
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006F")]
	public double2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000070")]
	public double2 c1; //Field offset: 0x10

	[Token(Token = "0x1700020B")]
	public double2 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x6000BC6")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2AA5700", Offset = "0x2AA4B00", Length = "0x4A")]
	[Token(Token = "0x6000BCC")]
	private static double2x2() { }

	[Address(RVA = "0x2AA5880", Offset = "0x2AA4C80", Length = "0x3D")]
	[Token(Token = "0x6000B97")]
	public double2x2(float2x2 v) { }

	[Address(RVA = "0x2AA5910", Offset = "0x2AA4D10", Length = "0x26")]
	[Token(Token = "0x6000B96")]
	public double2x2(float v) { }

	[Address(RVA = "0x2AA58C0", Offset = "0x2AA4CC0", Length = "0x48")]
	[Token(Token = "0x6000B95")]
	public double2x2(uint2x2 v) { }

	[Address(RVA = "0x2AA5840", Offset = "0x2AA4C40", Length = "0x3C")]
	[Token(Token = "0x6000B94")]
	public double2x2(uint v) { }

	[Address(RVA = "0x2AA5940", Offset = "0x2AA4D40", Length = "0x43")]
	[Token(Token = "0x6000B93")]
	public double2x2(int2x2 v) { }

	[Address(RVA = "0x648E10", Offset = "0x648210", Length = "0xF")]
	[Token(Token = "0x6000B8D")]
	public double2x2(double2 c0, double2 c1) { }

	[Address(RVA = "0x2AA5750", Offset = "0x2AA4B50", Length = "0x55")]
	[Token(Token = "0x6000B91")]
	public double2x2(bool2x2 v) { }

	[Address(RVA = "0x2AA57E0", Offset = "0x2AA4BE0", Length = "0x22")]
	[Token(Token = "0x6000B90")]
	public double2x2(bool v) { }

	[Address(RVA = "0x2AA5810", Offset = "0x2AA4C10", Length = "0xC")]
	[Token(Token = "0x6000B8F")]
	public double2x2(double v) { }

	[Address(RVA = "0x2AA5820", Offset = "0x2AA4C20", Length = "0x1A")]
	[Token(Token = "0x6000B8E")]
	public double2x2(double m00, double m01, double m10, double m11) { }

	[Address(RVA = "0x2AA57B0", Offset = "0x2AA4BB0", Length = "0x2B")]
	[Token(Token = "0x6000B92")]
	public double2x2(int v) { }

	[Address(RVA = "0x2AA51F0", Offset = "0x2AA45F0", Length = "0xBC")]
	[Token(Token = "0x6000BC8")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AA5190", Offset = "0x2AA4590", Length = "0x54")]
	[Token(Token = "0x6000BC7")]
	public override bool Equals(double2x2 rhs) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x6000BC6")]
	public double2 get_Item(int index) { }

	[Address(RVA = "0x2AA52B0", Offset = "0x2AA46B0", Length = "0x26")]
	[Token(Token = "0x6000BC9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AA5A10", Offset = "0x2AA4E10", Length = "0x31")]
	[Token(Token = "0x6000BA6")]
	public static double2x2 op_Addition(double lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA59E0", Offset = "0x2AA4DE0", Length = "0x2F")]
	[Token(Token = "0x6000BA5")]
	public static double2x2 op_Addition(double2x2 lhs, double rhs) { }

	[Address(RVA = "0x2AA5990", Offset = "0x2AA4D90", Length = "0x47")]
	[Token(Token = "0x6000BA4")]
	public static double2x2 op_Addition(double2x2 lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA5A50", Offset = "0x2AA4E50", Length = "0x3A")]
	[Token(Token = "0x6000BB1")]
	public static double2x2 op_Decrement(double2x2 val) { }

	[Address(RVA = "0x2AA5A90", Offset = "0x2AA4E90", Length = "0x2F")]
	[Token(Token = "0x6000BAB")]
	public static double2x2 op_Division(double2x2 lhs, double rhs) { }

	[Address(RVA = "0x2AA5AC0", Offset = "0x2AA4EC0", Length = "0x47")]
	[Token(Token = "0x6000BAA")]
	public static double2x2 op_Division(double2x2 lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA5B10", Offset = "0x2AA4F10", Length = "0x3C")]
	[Token(Token = "0x6000BAC")]
	public static double2x2 op_Division(double lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA5CA0", Offset = "0x2AA50A0", Length = "0x88")]
	[Token(Token = "0x6000BC2")]
	public static bool2x2 op_Equality(double lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA5B50", Offset = "0x2AA4F50", Length = "0xA7")]
	[Token(Token = "0x6000BC0")]
	public static bool2x2 op_Equality(double2x2 lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA5C00", Offset = "0x2AA5000", Length = "0x95")]
	[Token(Token = "0x6000BC1")]
	public static bool2x2 op_Equality(double2x2 lhs, double rhs) { }

	[Address(RVA = "0x2A2D130", Offset = "0x2A2C530", Length = "0x28")]
	[Token(Token = "0x6000B99")]
	public static double2x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2A2CF10", Offset = "0x2A2C310", Length = "0x58")]
	[Token(Token = "0x6000B9A")]
	public static double2x2 op_Explicit(bool2x2 v) { }

	[Address(RVA = "0x2AA5F80", Offset = "0x2AA5380", Length = "0x64")]
	[Token(Token = "0x6000BBA")]
	public static bool2x2 op_GreaterThan(double lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA5E90", Offset = "0x2AA5290", Length = "0x7A")]
	[Token(Token = "0x6000BB8")]
	public static bool2x2 op_GreaterThan(double2x2 lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA5F10", Offset = "0x2AA5310", Length = "0x6F")]
	[Token(Token = "0x6000BB9")]
	public static bool2x2 op_GreaterThan(double2x2 lhs, double rhs) { }

	[Address(RVA = "0x2AA5D30", Offset = "0x2AA5130", Length = "0x64")]
	[Token(Token = "0x6000BBD")]
	public static bool2x2 op_GreaterThanOrEqual(double lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA5E20", Offset = "0x2AA5220", Length = "0x6F")]
	[Token(Token = "0x6000BBC")]
	public static bool2x2 op_GreaterThanOrEqual(double2x2 lhs, double rhs) { }

	[Address(RVA = "0x2AA5DA0", Offset = "0x2AA51A0", Length = "0x7A")]
	[Token(Token = "0x6000BBB")]
	public static bool2x2 op_GreaterThanOrEqual(double2x2 lhs, double2x2 rhs) { }

	[Address(RVA = "0x2A2D0C0", Offset = "0x2A2C4C0", Length = "0x68")]
	[Token(Token = "0x6000B9E")]
	public static double2x2 op_Implicit(uint2x2 v) { }

	[Address(RVA = "0x2A2D020", Offset = "0x2A2C420", Length = "0x37")]
	[Token(Token = "0x6000B9B")]
	public static double2x2 op_Implicit(int v) { }

	[Address(RVA = "0x2A2CFD0", Offset = "0x2A2C3D0", Length = "0x48")]
	[Token(Token = "0x6000BA0")]
	public static double2x2 op_Implicit(float2x2 v) { }

	[Address(RVA = "0x2A2CF00", Offset = "0x2A2C300", Length = "0xF")]
	[Token(Token = "0x6000B98")]
	public static double2x2 op_Implicit(double v) { }

	[Address(RVA = "0x2A2CF70", Offset = "0x2A2C370", Length = "0x3F")]
	[Token(Token = "0x6000B9D")]
	public static double2x2 op_Implicit(uint v) { }

	[Address(RVA = "0x2A2D060", Offset = "0x2A2C460", Length = "0x5E")]
	[Token(Token = "0x6000B9C")]
	public static double2x2 op_Implicit(int2x2 v) { }

	[Address(RVA = "0x2A2CEA0", Offset = "0x2A2C2A0", Length = "0x33")]
	[Token(Token = "0x6000B9F")]
	public static double2x2 op_Implicit(float v) { }

	[Address(RVA = "0x2AA5FF0", Offset = "0x2AA53F0", Length = "0x3A")]
	[Token(Token = "0x6000BB0")]
	public static double2x2 op_Increment(double2x2 val) { }

	[Address(RVA = "0x2AA60E0", Offset = "0x2AA54E0", Length = "0x88")]
	[Token(Token = "0x6000BC5")]
	public static bool2x2 op_Inequality(double lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA6170", Offset = "0x2AA5570", Length = "0x95")]
	[Token(Token = "0x6000BC4")]
	public static bool2x2 op_Inequality(double2x2 lhs, double rhs) { }

	[Address(RVA = "0x2AA6030", Offset = "0x2AA5430", Length = "0xA7")]
	[Token(Token = "0x6000BC3")]
	public static bool2x2 op_Inequality(double2x2 lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA6370", Offset = "0x2AA5770", Length = "0x6F")]
	[Token(Token = "0x6000BB4")]
	public static bool2x2 op_LessThan(double lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA63E0", Offset = "0x2AA57E0", Length = "0x67")]
	[Token(Token = "0x6000BB3")]
	public static bool2x2 op_LessThan(double2x2 lhs, double rhs) { }

	[Address(RVA = "0x2AA6450", Offset = "0x2AA5850", Length = "0x7A")]
	[Token(Token = "0x6000BB2")]
	public static bool2x2 op_LessThan(double2x2 lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA6300", Offset = "0x2AA5700", Length = "0x6F")]
	[Token(Token = "0x6000BB7")]
	public static bool2x2 op_LessThanOrEqual(double lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA6280", Offset = "0x2AA5680", Length = "0x7A")]
	[Token(Token = "0x6000BB5")]
	public static bool2x2 op_LessThanOrEqual(double2x2 lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA6210", Offset = "0x2AA5610", Length = "0x67")]
	[Token(Token = "0x6000BB6")]
	public static bool2x2 op_LessThanOrEqual(double2x2 lhs, double rhs) { }

	[Address(RVA = "0x2AA64D0", Offset = "0x2AA58D0", Length = "0x95")]
	[Token(Token = "0x6000BAD")]
	public static double2x2 op_Modulus(double2x2 lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA6570", Offset = "0x2AA5970", Length = "0x80")]
	[Token(Token = "0x6000BAF")]
	public static double2x2 op_Modulus(double lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA65F0", Offset = "0x2AA59F0", Length = "0x7F")]
	[Token(Token = "0x6000BAE")]
	public static double2x2 op_Modulus(double2x2 lhs, double rhs) { }

	[Address(RVA = "0x2AA66A0", Offset = "0x2AA5AA0", Length = "0x31")]
	[Token(Token = "0x6000BA3")]
	public static double2x2 op_Multiply(double lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA66E0", Offset = "0x2AA5AE0", Length = "0x47")]
	[Token(Token = "0x6000BA1")]
	public static double2x2 op_Multiply(double2x2 lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA6670", Offset = "0x2AA5A70", Length = "0x2F")]
	[Token(Token = "0x6000BA2")]
	public static double2x2 op_Multiply(double2x2 lhs, double rhs) { }

	[Address(RVA = "0x2AA6730", Offset = "0x2AA5B30", Length = "0x3C")]
	[Token(Token = "0x6000BA9")]
	public static double2x2 op_Subtraction(double lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA6770", Offset = "0x2AA5B70", Length = "0x2F")]
	[Token(Token = "0x6000BA8")]
	public static double2x2 op_Subtraction(double2x2 lhs, double rhs) { }

	[Address(RVA = "0x2AA67A0", Offset = "0x2AA5BA0", Length = "0x47")]
	[Token(Token = "0x6000BA7")]
	public static double2x2 op_Subtraction(double2x2 lhs, double2x2 rhs) { }

	[Address(RVA = "0x2AA67F0", Offset = "0x2AA5BF0", Length = "0x2F")]
	[Token(Token = "0x6000BBE")]
	public static double2x2 op_UnaryNegation(double2x2 val) { }

	[Address(RVA = "0x2AA6820", Offset = "0x2AA5C20", Length = "0x27")]
	[Token(Token = "0x6000BBF")]
	public static double2x2 op_UnaryPlus(double2x2 val) { }

	[Address(RVA = "0x2AA54F0", Offset = "0x2AA48F0", Length = "0x20A")]
	[Token(Token = "0x6000BCB")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x2AA52E0", Offset = "0x2AA46E0", Length = "0x204")]
	[Token(Token = "0x6000BCA")]
	public virtual string ToString() { }

}

