namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000041")]
public struct int2x3 : IEquatable<int2x3>, IFormattable
{
	[Token(Token = "0x4000105")]
	public static readonly int2x3 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000102")]
	public int2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000103")]
	public int2 c1; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000104")]
	public int2 c2; //Field offset: 0x10

	[Token(Token = "0x170007CE")]
	public int2 Item
	{
		[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
		[Token(Token = "0x6001977")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1F73700", Offset = "0x1F72B00", Length = "0xC")]
	[Token(Token = "0x6001932")]
	public int2x3(int2 c0, int2 c1, int2 c2) { }

	[Address(RVA = "0x2AF8630", Offset = "0x2AF7A30", Length = "0x41")]
	[Token(Token = "0x6001933")]
	public int2x3(int m00, int m01, int m02, int m10, int m11, int m12) { }

	[Address(RVA = "0x2AF85A0", Offset = "0x2AF79A0", Length = "0x33")]
	[Token(Token = "0x6001934")]
	public int2x3(int v) { }

	[Address(RVA = "0x2A1AD30", Offset = "0x2A1A130", Length = "0x75")]
	[Token(Token = "0x6001935")]
	public int2x3(bool v) { }

	[Address(RVA = "0x2A1AC40", Offset = "0x2A1A040", Length = "0xE8")]
	[Token(Token = "0x6001936")]
	public int2x3(bool2x3 v) { }

	[Address(RVA = "0x2AF85A0", Offset = "0x2AF79A0", Length = "0x33")]
	[Token(Token = "0x6001937")]
	public int2x3(uint v) { }

	[Address(RVA = "0x2AF85E0", Offset = "0x2AF79E0", Length = "0x4A")]
	[Token(Token = "0x6001938")]
	public int2x3(uint2x3 v) { }

	[Address(RVA = "0x2AF84F0", Offset = "0x2AF78F0", Length = "0x4B")]
	[Token(Token = "0x6001939")]
	public int2x3(float v) { }

	[Address(RVA = "0x2AF8540", Offset = "0x2AF7940", Length = "0x5D")]
	[Token(Token = "0x600193A")]
	public int2x3(float2x3 v) { }

	[Address(RVA = "0x2AF8440", Offset = "0x2AF7840", Length = "0x4B")]
	[Token(Token = "0x600193B")]
	public int2x3(double v) { }

	[Address(RVA = "0x2AF8490", Offset = "0x2AF7890", Length = "0x56")]
	[Token(Token = "0x600193C")]
	public int2x3(double2x3 v) { }

	[Address(RVA = "0x2AF7D00", Offset = "0x2AF7100", Length = "0x66")]
	[Token(Token = "0x6001978")]
	public override bool Equals(int2x3 rhs) { }

	[Address(RVA = "0x2AF7D70", Offset = "0x2AF7170", Length = "0xF4")]
	[Token(Token = "0x6001979")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
	[Token(Token = "0x6001977")]
	public int2 get_Item(int index) { }

	[Address(RVA = "0x2AF7E70", Offset = "0x2AF7270", Length = "0x28")]
	[Token(Token = "0x600197A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AF86F0", Offset = "0x2AF7AF0", Length = "0x87")]
	[Token(Token = "0x6001949")]
	public static int2x3 op_Addition(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF8780", Offset = "0x2AF7B80", Length = "0x6D")]
	[Token(Token = "0x600194A")]
	public static int2x3 op_Addition(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF8680", Offset = "0x2AF7A80", Length = "0x69")]
	[Token(Token = "0x600194B")]
	public static int2x3 op_Addition(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF87F0", Offset = "0x2AF7BF0", Length = "0x8B")]
	[Token(Token = "0x600196E")]
	public static int2x3 op_BitwiseAnd(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF8880", Offset = "0x2AF7C80", Length = "0x72")]
	[Token(Token = "0x600196F")]
	public static int2x3 op_BitwiseAnd(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF8900", Offset = "0x2AF7D00", Length = "0x6E")]
	[Token(Token = "0x6001970")]
	public static int2x3 op_BitwiseAnd(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF8970", Offset = "0x2AF7D70", Length = "0x6E")]
	[Token(Token = "0x6001973")]
	public static int2x3 op_BitwiseOr(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF89E0", Offset = "0x2AF7DE0", Length = "0x8B")]
	[Token(Token = "0x6001971")]
	public static int2x3 op_BitwiseOr(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF8A70", Offset = "0x2AF7E70", Length = "0x72")]
	[Token(Token = "0x6001972")]
	public static int2x3 op_BitwiseOr(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF8AF0", Offset = "0x2AF7EF0", Length = "0x6B")]
	[Token(Token = "0x6001956")]
	public static int2x3 op_Decrement(int2x3 val) { }

	[Address(RVA = "0x2AF8C00", Offset = "0x2AF8000", Length = "0x86")]
	[Token(Token = "0x6001951")]
	public static int2x3 op_Division(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF8C90", Offset = "0x2AF8090", Length = "0x87")]
	[Token(Token = "0x6001950")]
	public static int2x3 op_Division(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF8B60", Offset = "0x2AF7F60", Length = "0x9F")]
	[Token(Token = "0x600194F")]
	public static int2x3 op_Division(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF8E10", Offset = "0x2AF8210", Length = "0x5F")]
	[Token(Token = "0x6001969")]
	public static bool2x3 op_Equality(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF8D20", Offset = "0x2AF8120", Length = "0x80")]
	[Token(Token = "0x6001967")]
	public static bool2x3 op_Equality(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF8DA0", Offset = "0x2AF81A0", Length = "0x65")]
	[Token(Token = "0x6001968")]
	public static bool2x3 op_Equality(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF8E70", Offset = "0x2AF8270", Length = "0x6E")]
	[Token(Token = "0x6001976")]
	public static int2x3 op_ExclusiveOr(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF8F60", Offset = "0x2AF8360", Length = "0x8B")]
	[Token(Token = "0x6001974")]
	public static int2x3 op_ExclusiveOr(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF8EE0", Offset = "0x2AF82E0", Length = "0x72")]
	[Token(Token = "0x6001975")]
	public static int2x3 op_ExclusiveOr(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2A42F90", Offset = "0x2A42390", Length = "0x8A")]
	[Token(Token = "0x6001941")]
	public static int2x3 op_Explicit(uint2x3 v) { }

	[Address(RVA = "0x2A42EF0", Offset = "0x2A422F0", Length = "0x4E")]
	[Token(Token = "0x6001942")]
	public static int2x3 op_Explicit(float v) { }

	[Address(RVA = "0x2A432C0", Offset = "0x2A426C0", Length = "0x89")]
	[Token(Token = "0x6001943")]
	public static int2x3 op_Explicit(float2x3 v) { }

	[Address(RVA = "0x2A43060", Offset = "0x2A42460", Length = "0x4E")]
	[Token(Token = "0x6001944")]
	public static int2x3 op_Explicit(double v) { }

	[Address(RVA = "0x2A43020", Offset = "0x2A42420", Length = "0x36")]
	[Token(Token = "0x6001940")]
	public static int2x3 op_Explicit(uint v) { }

	[Address(RVA = "0x2AF8FF0", Offset = "0x2AF83F0", Length = "0x26")]
	[Token(Token = "0x600193E")]
	public static int2x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2AF9020", Offset = "0x2AF8420", Length = "0x3A")]
	[Token(Token = "0x600193F")]
	public static int2x3 op_Explicit(bool2x3 v) { }

	[Address(RVA = "0x2A431D0", Offset = "0x2A425D0", Length = "0x6D")]
	[Token(Token = "0x6001945")]
	public static int2x3 op_Explicit(double2x3 v) { }

	[Address(RVA = "0x2AF91B0", Offset = "0x2AF85B0", Length = "0x80")]
	[Token(Token = "0x600195D")]
	public static bool2x3 op_GreaterThan(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9230", Offset = "0x2AF8630", Length = "0x65")]
	[Token(Token = "0x600195E")]
	public static bool2x3 op_GreaterThan(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF92A0", Offset = "0x2AF86A0", Length = "0x5F")]
	[Token(Token = "0x600195F")]
	public static bool2x3 op_GreaterThan(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9130", Offset = "0x2AF8530", Length = "0x80")]
	[Token(Token = "0x6001960")]
	public static bool2x3 op_GreaterThanOrEqual(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9060", Offset = "0x2AF8460", Length = "0x65")]
	[Token(Token = "0x6001961")]
	public static bool2x3 op_GreaterThanOrEqual(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF90D0", Offset = "0x2AF84D0", Length = "0x5F")]
	[Token(Token = "0x6001962")]
	public static bool2x3 op_GreaterThanOrEqual(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2A43020", Offset = "0x2A42420", Length = "0x36")]
	[Token(Token = "0x600193D")]
	public static int2x3 op_Implicit(int v) { }

	[Address(RVA = "0x2AF9300", Offset = "0x2AF8700", Length = "0x6B")]
	[Token(Token = "0x6001955")]
	public static int2x3 op_Increment(int2x3 val) { }

	[Address(RVA = "0x2AF93F0", Offset = "0x2AF87F0", Length = "0x65")]
	[Token(Token = "0x600196B")]
	public static bool2x3 op_Inequality(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF9370", Offset = "0x2AF8770", Length = "0x80")]
	[Token(Token = "0x600196A")]
	public static bool2x3 op_Inequality(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9460", Offset = "0x2AF8860", Length = "0x5F")]
	[Token(Token = "0x600196C")]
	public static bool2x3 op_Inequality(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF94C0", Offset = "0x2AF88C0", Length = "0x75")]
	[Token(Token = "0x6001965")]
	public static int2x3 op_LeftShift(int2x3 x, int n) { }

	[Address(RVA = "0x2AF9760", Offset = "0x2AF8B60", Length = "0x80")]
	[Token(Token = "0x6001957")]
	public static bool2x3 op_LessThan(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9700", Offset = "0x2AF8B00", Length = "0x5F")]
	[Token(Token = "0x6001959")]
	public static bool2x3 op_LessThan(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9690", Offset = "0x2AF8A90", Length = "0x65")]
	[Token(Token = "0x6001958")]
	public static bool2x3 op_LessThan(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF9630", Offset = "0x2AF8A30", Length = "0x5F")]
	[Token(Token = "0x600195C")]
	public static bool2x3 op_LessThanOrEqual(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9540", Offset = "0x2AF8940", Length = "0x65")]
	[Token(Token = "0x600195B")]
	public static bool2x3 op_LessThanOrEqual(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF95B0", Offset = "0x2AF89B0", Length = "0x80")]
	[Token(Token = "0x600195A")]
	public static bool2x3 op_LessThanOrEqual(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF97E0", Offset = "0x2AF8BE0", Length = "0x86")]
	[Token(Token = "0x6001954")]
	public static int2x3 op_Modulus(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9870", Offset = "0x2AF8C70", Length = "0x9F")]
	[Token(Token = "0x6001952")]
	public static int2x3 op_Modulus(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9910", Offset = "0x2AF8D10", Length = "0x87")]
	[Token(Token = "0x6001953")]
	public static int2x3 op_Modulus(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF9AA0", Offset = "0x2AF8EA0", Length = "0x91")]
	[Token(Token = "0x6001946")]
	public static int2x3 op_Multiply(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9A20", Offset = "0x2AF8E20", Length = "0x74")]
	[Token(Token = "0x6001948")]
	public static int2x3 op_Multiply(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF99A0", Offset = "0x2AF8DA0", Length = "0x78")]
	[Token(Token = "0x6001947")]
	public static int2x3 op_Multiply(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF9B40", Offset = "0x2AF8F40", Length = "0x68")]
	[Token(Token = "0x600196D")]
	public static int2x3 op_OnesComplement(int2x3 val) { }

	[Address(RVA = "0x2AF9BB0", Offset = "0x2AF8FB0", Length = "0x75")]
	[Token(Token = "0x6001966")]
	public static int2x3 op_RightShift(int2x3 x, int n) { }

	[Address(RVA = "0x2AF9C30", Offset = "0x2AF9030", Length = "0x75")]
	[Token(Token = "0x600194E")]
	public static int2x3 op_Subtraction(int lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9D40", Offset = "0x2AF9140", Length = "0x72")]
	[Token(Token = "0x600194D")]
	public static int2x3 op_Subtraction(int2x3 lhs, int rhs) { }

	[Address(RVA = "0x2AF9CB0", Offset = "0x2AF90B0", Length = "0x8B")]
	[Token(Token = "0x600194C")]
	public static int2x3 op_Subtraction(int2x3 lhs, int2x3 rhs) { }

	[Address(RVA = "0x2AF9DC0", Offset = "0x2AF91C0", Length = "0x68")]
	[Token(Token = "0x6001963")]
	public static int2x3 op_UnaryNegation(int2x3 val) { }

	[Address(RVA = "0x2AF9E30", Offset = "0x2AF9230", Length = "0x22DA")]
	[Token(Token = "0x6001964")]
	public static int2x3 op_UnaryPlus(int2x3 val) { }

	[Address(RVA = "0x2AF7EA0", Offset = "0x2AF72A0", Length = "0x2C0")]
	[Token(Token = "0x600197B")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AF8170", Offset = "0x2AF7570", Length = "0x2C6")]
	[Token(Token = "0x600197C")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

