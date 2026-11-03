namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200004B")]
public struct int4x3 : IEquatable<int4x3>, IFormattable
{
	[Token(Token = "0x400012E")]
	public static readonly int4x3 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400012B")]
	public int4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400012C")]
	public int4 c1; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400012D")]
	public int4 c2; //Field offset: 0x20

	[Token(Token = "0x1700099B")]
	public int4 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x6001DE9")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x1311590", Offset = "0x1310990", Length = "0x17")]
	[Token(Token = "0x6001DA4")]
	public int4x3(int4 c0, int4 c1, int4 c2) { }

	[Address(RVA = "0x2A92D30", Offset = "0x2A92130", Length = "0x76")]
	[Token(Token = "0x6001DA5")]
	public int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32) { }

	[Address(RVA = "0x2A92DB0", Offset = "0x2A921B0", Length = "0x47")]
	[Token(Token = "0x6001DA6")]
	public int4x3(int v) { }

	[Address(RVA = "0x2B0CC70", Offset = "0x2B0C070", Length = "0x31")]
	[Token(Token = "0x6001DA7")]
	public int4x3(bool v) { }

	[Address(RVA = "0x2A1B270", Offset = "0x2A1A670", Length = "0xEE")]
	[Token(Token = "0x6001DA8")]
	public int4x3(bool4x3 v) { }

	[Address(RVA = "0x2A92DB0", Offset = "0x2A921B0", Length = "0x47")]
	[Token(Token = "0x6001DA9")]
	public int4x3(uint v) { }

	[Address(RVA = "0x2A92E00", Offset = "0x2A92200", Length = "0xA2")]
	[Token(Token = "0x6001DAA")]
	public int4x3(uint4x3 v) { }

	[Address(RVA = "0x2B0CD30", Offset = "0x2B0C130", Length = "0x2D")]
	[Token(Token = "0x6001DAB")]
	public int4x3(float v) { }

	[Address(RVA = "0x2B0CD60", Offset = "0x2B0C160", Length = "0xBE")]
	[Token(Token = "0x6001DAC")]
	public int4x3(float4x3 v) { }

	[Address(RVA = "0x2B0CCB0", Offset = "0x2B0C0B0", Length = "0x7D")]
	[Token(Token = "0x6001DAD")]
	public int4x3(double v) { }

	[Address(RVA = "0x2B0CE20", Offset = "0x2B0C220", Length = "0xAC")]
	[Token(Token = "0x6001DAE")]
	public int4x3(double4x3 v) { }

	[Address(RVA = "0x2A92140", Offset = "0x2A91540", Length = "0x9A")]
	[Token(Token = "0x6001DEA")]
	public override bool Equals(int4x3 rhs) { }

	[Address(RVA = "0x2B0C120", Offset = "0x2B0B520", Length = "0x11B")]
	[Token(Token = "0x6001DEB")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x6001DE9")]
	public int4 get_Item(int index) { }

	[Address(RVA = "0x2B0C240", Offset = "0x2B0B640", Length = "0x2F")]
	[Token(Token = "0x6001DEC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A93060", Offset = "0x2A92460", Length = "0x15E")]
	[Token(Token = "0x6001DBB")]
	public static int4x3 op_Addition(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A92EB0", Offset = "0x2A922B0", Length = "0xD2")]
	[Token(Token = "0x6001DBC")]
	public static int4x3 op_Addition(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2A92F90", Offset = "0x2A92390", Length = "0xCC")]
	[Token(Token = "0x6001DBD")]
	public static int4x3 op_Addition(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A93290", Offset = "0x2A92690", Length = "0x15E")]
	[Token(Token = "0x6001DE0")]
	public static int4x3 op_BitwiseAnd(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A931C0", Offset = "0x2A925C0", Length = "0xCC")]
	[Token(Token = "0x6001DE1")]
	public static int4x3 op_BitwiseAnd(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2A933F0", Offset = "0x2A927F0", Length = "0xC6")]
	[Token(Token = "0x6001DE2")]
	public static int4x3 op_BitwiseAnd(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A936F0", Offset = "0x2A92AF0", Length = "0xC6")]
	[Token(Token = "0x6001DE5")]
	public static int4x3 op_BitwiseOr(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A93590", Offset = "0x2A92990", Length = "0x15E")]
	[Token(Token = "0x6001DE3")]
	public static int4x3 op_BitwiseOr(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A934C0", Offset = "0x2A928C0", Length = "0xCC")]
	[Token(Token = "0x6001DE4")]
	public static int4x3 op_BitwiseOr(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2A937C0", Offset = "0x2A92BC0", Length = "0xE0")]
	[Token(Token = "0x6001DC8")]
	public static int4x3 op_Decrement(int4x3 val) { }

	[Address(RVA = "0x2B0CFB0", Offset = "0x2B0C3B0", Length = "0xF2")]
	[Token(Token = "0x6001DC3")]
	public static int4x3 op_Division(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2B0CED0", Offset = "0x2B0C2D0", Length = "0xE0")]
	[Token(Token = "0x6001DC2")]
	public static int4x3 op_Division(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2B0D0B0", Offset = "0x2B0C4B0", Length = "0x172")]
	[Token(Token = "0x6001DC1")]
	public static int4x3 op_Division(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A93C10", Offset = "0x2A93010", Length = "0xA6")]
	[Token(Token = "0x6001DDB")]
	public static bool4x3 op_Equality(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A93CC0", Offset = "0x2A930C0", Length = "0x106")]
	[Token(Token = "0x6001DD9")]
	public static bool4x3 op_Equality(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A93DD0", Offset = "0x2A931D0", Length = "0xAC")]
	[Token(Token = "0x6001DDA")]
	public static bool4x3 op_Equality(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2A940B0", Offset = "0x2A934B0", Length = "0xC6")]
	[Token(Token = "0x6001DE8")]
	public static int4x3 op_ExclusiveOr(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A93F50", Offset = "0x2A93350", Length = "0x15E")]
	[Token(Token = "0x6001DE6")]
	public static int4x3 op_ExclusiveOr(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A93E80", Offset = "0x2A93280", Length = "0xCC")]
	[Token(Token = "0x6001DE7")]
	public static int4x3 op_ExclusiveOr(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2A45100", Offset = "0x2A44500", Length = "0x7F")]
	[Token(Token = "0x6001DB3")]
	public static int4x3 op_Explicit(uint4x3 v) { }

	[Address(RVA = "0x2A44F30", Offset = "0x2A44330", Length = "0x30")]
	[Token(Token = "0x6001DB4")]
	public static int4x3 op_Explicit(float v) { }

	[Address(RVA = "0x2A451C0", Offset = "0x2A445C0", Length = "0xC1")]
	[Token(Token = "0x6001DB5")]
	public static int4x3 op_Explicit(float4x3 v) { }

	[Address(RVA = "0x2A44DB0", Offset = "0x2A441B0", Length = "0x80")]
	[Token(Token = "0x6001DB6")]
	public static int4x3 op_Explicit(double v) { }

	[Address(RVA = "0x2A44E30", Offset = "0x2A44230", Length = "0x4A")]
	[Token(Token = "0x6001DB2")]
	public static int4x3 op_Explicit(uint v) { }

	[Address(RVA = "0x2A45180", Offset = "0x2A44580", Length = "0x34")]
	[Token(Token = "0x6001DB0")]
	public static int4x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2A44F60", Offset = "0x2A44360", Length = "0x115")]
	[Token(Token = "0x6001DB1")]
	public static int4x3 op_Explicit(bool4x3 v) { }

	[Address(RVA = "0x2A44E80", Offset = "0x2A44280", Length = "0xAC")]
	[Token(Token = "0x6001DB7")]
	public static int4x3 op_Explicit(double4x3 v) { }

	[Address(RVA = "0x2B0D600", Offset = "0x2B0CA00", Length = "0x106")]
	[Token(Token = "0x6001DCF")]
	public static bool4x3 op_GreaterThan(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2B0D550", Offset = "0x2B0C950", Length = "0xAC")]
	[Token(Token = "0x6001DD0")]
	public static bool4x3 op_GreaterThan(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2B0D4A0", Offset = "0x2B0C8A0", Length = "0xA6")]
	[Token(Token = "0x6001DD1")]
	public static bool4x3 op_GreaterThan(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2B0D230", Offset = "0x2B0C630", Length = "0x106")]
	[Token(Token = "0x6001DD2")]
	public static bool4x3 op_GreaterThanOrEqual(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2B0D3F0", Offset = "0x2B0C7F0", Length = "0xAC")]
	[Token(Token = "0x6001DD3")]
	public static bool4x3 op_GreaterThanOrEqual(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2B0D340", Offset = "0x2B0C740", Length = "0xA6")]
	[Token(Token = "0x6001DD4")]
	public static bool4x3 op_GreaterThanOrEqual(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A44E30", Offset = "0x2A44230", Length = "0x4A")]
	[Token(Token = "0x6001DAF")]
	public static int4x3 op_Implicit(int v) { }

	[Address(RVA = "0x2A946F0", Offset = "0x2A93AF0", Length = "0xE0")]
	[Token(Token = "0x6001DC7")]
	public static int4x3 op_Increment(int4x3 val) { }

	[Address(RVA = "0x2A947D0", Offset = "0x2A93BD0", Length = "0xAC")]
	[Token(Token = "0x6001DDD")]
	public static bool4x3 op_Inequality(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2A94880", Offset = "0x2A93C80", Length = "0x106")]
	[Token(Token = "0x6001DDC")]
	public static bool4x3 op_Inequality(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A94990", Offset = "0x2A93D90", Length = "0xA6")]
	[Token(Token = "0x6001DDE")]
	public static bool4x3 op_Inequality(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A94A40", Offset = "0x2A93E40", Length = "0xCD")]
	[Token(Token = "0x6001DD7")]
	public static int4x3 op_LeftShift(int4x3 x, int n) { }

	[Address(RVA = "0x2B0DA30", Offset = "0x2B0CE30", Length = "0x106")]
	[Token(Token = "0x6001DC9")]
	public static bool4x3 op_LessThan(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2B0DB40", Offset = "0x2B0CF40", Length = "0xA6")]
	[Token(Token = "0x6001DCB")]
	public static bool4x3 op_LessThan(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2B0D980", Offset = "0x2B0CD80", Length = "0xAC")]
	[Token(Token = "0x6001DCA")]
	public static bool4x3 op_LessThan(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2B0D820", Offset = "0x2B0CC20", Length = "0xA6")]
	[Token(Token = "0x6001DCE")]
	public static bool4x3 op_LessThanOrEqual(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2B0D8D0", Offset = "0x2B0CCD0", Length = "0xAC")]
	[Token(Token = "0x6001DCD")]
	public static bool4x3 op_LessThanOrEqual(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2B0D710", Offset = "0x2B0CB10", Length = "0x106")]
	[Token(Token = "0x6001DCC")]
	public static bool4x3 op_LessThanOrEqual(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2B0DBF0", Offset = "0x2B0CFF0", Length = "0xF2")]
	[Token(Token = "0x6001DC6")]
	public static int4x3 op_Modulus(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2B0DCF0", Offset = "0x2B0D0F0", Length = "0x172")]
	[Token(Token = "0x6001DC4")]
	public static int4x3 op_Modulus(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2B0DE70", Offset = "0x2B0D270", Length = "0xE0")]
	[Token(Token = "0x6001DC5")]
	public static int4x3 op_Modulus(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2A95520", Offset = "0x2A94920", Length = "0x16A")]
	[Token(Token = "0x6001DB8")]
	public static int4x3 op_Multiply(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A95440", Offset = "0x2A94840", Length = "0xD2")]
	[Token(Token = "0x6001DBA")]
	public static int4x3 op_Multiply(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A95360", Offset = "0x2A94760", Length = "0xD8")]
	[Token(Token = "0x6001DB9")]
	public static int4x3 op_Multiply(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2A95690", Offset = "0x2A94A90", Length = "0xC0")]
	[Token(Token = "0x6001DDF")]
	public static int4x3 op_OnesComplement(int4x3 val) { }

	[Address(RVA = "0x2B0DF50", Offset = "0x2B0D350", Length = "0xCD")]
	[Token(Token = "0x6001DD8")]
	public static int4x3 op_RightShift(int4x3 x, int n) { }

	[Address(RVA = "0x2A95830", Offset = "0x2A94C30", Length = "0xE3")]
	[Token(Token = "0x6001DC0")]
	public static int4x3 op_Subtraction(int lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A95A80", Offset = "0x2A94E80", Length = "0xCC")]
	[Token(Token = "0x6001DBF")]
	public static int4x3 op_Subtraction(int4x3 lhs, int rhs) { }

	[Address(RVA = "0x2A95920", Offset = "0x2A94D20", Length = "0x15E")]
	[Token(Token = "0x6001DBE")]
	public static int4x3 op_Subtraction(int4x3 lhs, int4x3 rhs) { }

	[Address(RVA = "0x2A95B50", Offset = "0x2A94F50", Length = "0xC0")]
	[Token(Token = "0x6001DD5")]
	public static int4x3 op_UnaryNegation(int4x3 val) { }

	[Address(RVA = "0x2A95C10", Offset = "0x2A95010", Length = "0xB6")]
	[Token(Token = "0x6001DD6")]
	public static int4x3 op_UnaryPlus(int4x3 val) { }

	[Address(RVA = "0x2B0C760", Offset = "0x2B0BB60", Length = "0x500")]
	[Token(Token = "0x6001DED")]
	public virtual string ToString() { }

	[Address(RVA = "0x2B0C270", Offset = "0x2B0B670", Length = "0x4EE")]
	[Token(Token = "0x6001DEE")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

