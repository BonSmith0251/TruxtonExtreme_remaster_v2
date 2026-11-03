namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000061")]
public struct uint4x3 : IEquatable<uint4x3>, IFormattable
{
	[Token(Token = "0x4000174")]
	public static readonly uint4x3 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000171")]
	public uint4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000172")]
	public uint4 c1; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000173")]
	public uint4 c2; //Field offset: 0x20

	[Token(Token = "0x17000B88")]
	public uint4 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x600245E")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x1311590", Offset = "0x1310990", Length = "0x17")]
	[Token(Token = "0x6002419")]
	public uint4x3(uint4 c0, uint4 c1, uint4 c2) { }

	[Address(RVA = "0x2A92D30", Offset = "0x2A92130", Length = "0x76")]
	[Token(Token = "0x600241A")]
	public uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32) { }

	[Address(RVA = "0x2A92DB0", Offset = "0x2A921B0", Length = "0x47")]
	[Token(Token = "0x600241B")]
	public uint4x3(uint v) { }

	[Address(RVA = "0x2A22CF0", Offset = "0x2A220F0", Length = "0xC5")]
	[Token(Token = "0x600241C")]
	public uint4x3(bool v) { }

	[Address(RVA = "0x2A1B270", Offset = "0x2A1A670", Length = "0xEE")]
	[Token(Token = "0x600241D")]
	public uint4x3(bool4x3 v) { }

	[Address(RVA = "0x2A92DB0", Offset = "0x2A921B0", Length = "0x47")]
	[Token(Token = "0x600241E")]
	public uint4x3(int v) { }

	[Address(RVA = "0x2A92E00", Offset = "0x2A92200", Length = "0xA2")]
	[Token(Token = "0x600241F")]
	public uint4x3(int4x3 v) { }

	[Address(RVA = "0x2A22A90", Offset = "0x2A21E90", Length = "0xFE")]
	[Token(Token = "0x6002420")]
	public uint4x3(float v) { }

	[Address(RVA = "0x2A22830", Offset = "0x2A21C30", Length = "0x160")]
	[Token(Token = "0x6002421")]
	public uint4x3(float4x3 v) { }

	[Address(RVA = "0x2A22990", Offset = "0x2A21D90", Length = "0xFF")]
	[Token(Token = "0x6002422")]
	public uint4x3(double v) { }

	[Address(RVA = "0x2A22B90", Offset = "0x2A21F90", Length = "0x15A")]
	[Token(Token = "0x6002423")]
	public uint4x3(double4x3 v) { }

	[Address(RVA = "0x2A92140", Offset = "0x2A91540", Length = "0x9A")]
	[Token(Token = "0x600245F")]
	public override bool Equals(uint4x3 rhs) { }

	[Address(RVA = "0x2A921E0", Offset = "0x2A915E0", Length = "0x11B")]
	[Token(Token = "0x6002460")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x600245E")]
	public uint4 get_Item(int index) { }

	[Address(RVA = "0x2A92300", Offset = "0x2A91700", Length = "0x2F")]
	[Token(Token = "0x6002461")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A93060", Offset = "0x2A92460", Length = "0x15E")]
	[Token(Token = "0x6002430")]
	public static uint4x3 op_Addition(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A92EB0", Offset = "0x2A922B0", Length = "0xD2")]
	[Token(Token = "0x6002431")]
	public static uint4x3 op_Addition(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A92F90", Offset = "0x2A92390", Length = "0xCC")]
	[Token(Token = "0x6002432")]
	public static uint4x3 op_Addition(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A93290", Offset = "0x2A92690", Length = "0x15E")]
	[Token(Token = "0x6002455")]
	public static uint4x3 op_BitwiseAnd(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A931C0", Offset = "0x2A925C0", Length = "0xCC")]
	[Token(Token = "0x6002456")]
	public static uint4x3 op_BitwiseAnd(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A933F0", Offset = "0x2A927F0", Length = "0xC6")]
	[Token(Token = "0x6002457")]
	public static uint4x3 op_BitwiseAnd(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A936F0", Offset = "0x2A92AF0", Length = "0xC6")]
	[Token(Token = "0x600245A")]
	public static uint4x3 op_BitwiseOr(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A93590", Offset = "0x2A92990", Length = "0x15E")]
	[Token(Token = "0x6002458")]
	public static uint4x3 op_BitwiseOr(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A934C0", Offset = "0x2A928C0", Length = "0xCC")]
	[Token(Token = "0x6002459")]
	public static uint4x3 op_BitwiseOr(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A937C0", Offset = "0x2A92BC0", Length = "0xE0")]
	[Token(Token = "0x600243D")]
	public static uint4x3 op_Decrement(uint4x3 val) { }

	[Address(RVA = "0x2A93A20", Offset = "0x2A92E20", Length = "0xFF")]
	[Token(Token = "0x6002438")]
	public static uint4x3 op_Division(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A93B20", Offset = "0x2A92F20", Length = "0xED")]
	[Token(Token = "0x6002437")]
	public static uint4x3 op_Division(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A938A0", Offset = "0x2A92CA0", Length = "0x17F")]
	[Token(Token = "0x6002436")]
	public static uint4x3 op_Division(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A93C10", Offset = "0x2A93010", Length = "0xA6")]
	[Token(Token = "0x6002450")]
	public static bool4x3 op_Equality(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A93CC0", Offset = "0x2A930C0", Length = "0x106")]
	[Token(Token = "0x600244E")]
	public static bool4x3 op_Equality(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A93DD0", Offset = "0x2A931D0", Length = "0xAC")]
	[Token(Token = "0x600244F")]
	public static bool4x3 op_Equality(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A940B0", Offset = "0x2A934B0", Length = "0xC6")]
	[Token(Token = "0x600245D")]
	public static uint4x3 op_ExclusiveOr(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A93F50", Offset = "0x2A93350", Length = "0x15E")]
	[Token(Token = "0x600245B")]
	public static uint4x3 op_ExclusiveOr(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A93E80", Offset = "0x2A93280", Length = "0xCC")]
	[Token(Token = "0x600245C")]
	public static uint4x3 op_ExclusiveOr(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A45100", Offset = "0x2A44500", Length = "0x7F")]
	[Token(Token = "0x6002428")]
	public static uint4x3 op_Explicit(int4x3 v) { }

	[Address(RVA = "0x2A94180", Offset = "0x2A93580", Length = "0x28")]
	[Token(Token = "0x6002429")]
	public static uint4x3 op_Explicit(float v) { }

	[Address(RVA = "0x2A70570", Offset = "0x2A6F970", Length = "0x47")]
	[Token(Token = "0x600242A")]
	public static uint4x3 op_Explicit(float4x3 v) { }

	[Address(RVA = "0x2A941E0", Offset = "0x2A935E0", Length = "0x28")]
	[Token(Token = "0x600242B")]
	public static uint4x3 op_Explicit(double v) { }

	[Address(RVA = "0x2A44E30", Offset = "0x2A44230", Length = "0x4A")]
	[Token(Token = "0x6002427")]
	public static uint4x3 op_Explicit(int v) { }

	[Address(RVA = "0x2A941B0", Offset = "0x2A935B0", Length = "0x28")]
	[Token(Token = "0x6002425")]
	public static uint4x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2A44F60", Offset = "0x2A44360", Length = "0x115")]
	[Token(Token = "0x6002426")]
	public static uint4x3 op_Explicit(bool4x3 v) { }

	[Address(RVA = "0x2A705C0", Offset = "0x2A6F9C0", Length = "0x63")]
	[Token(Token = "0x600242C")]
	public static uint4x3 op_Explicit(double4x3 v) { }

	[Address(RVA = "0x2A94530", Offset = "0x2A93930", Length = "0x106")]
	[Token(Token = "0x6002444")]
	public static bool4x3 op_GreaterThan(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A94640", Offset = "0x2A93A40", Length = "0xAC")]
	[Token(Token = "0x6002445")]
	public static bool4x3 op_GreaterThan(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A94480", Offset = "0x2A93880", Length = "0xA6")]
	[Token(Token = "0x6002446")]
	public static bool4x3 op_GreaterThan(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A94210", Offset = "0x2A93610", Length = "0x106")]
	[Token(Token = "0x6002447")]
	public static bool4x3 op_GreaterThanOrEqual(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A943D0", Offset = "0x2A937D0", Length = "0xAC")]
	[Token(Token = "0x6002448")]
	public static bool4x3 op_GreaterThanOrEqual(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A94320", Offset = "0x2A93720", Length = "0xA6")]
	[Token(Token = "0x6002449")]
	public static bool4x3 op_GreaterThanOrEqual(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A44E30", Offset = "0x2A44230", Length = "0x4A")]
	[Token(Token = "0x6002424")]
	public static uint4x3 op_Implicit(uint v) { }

	[Address(RVA = "0x2A946F0", Offset = "0x2A93AF0", Length = "0xE0")]
	[Token(Token = "0x600243C")]
	public static uint4x3 op_Increment(uint4x3 val) { }

	[Address(RVA = "0x2A947D0", Offset = "0x2A93BD0", Length = "0xAC")]
	[Token(Token = "0x6002452")]
	public static bool4x3 op_Inequality(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A94880", Offset = "0x2A93C80", Length = "0x106")]
	[Token(Token = "0x6002451")]
	public static bool4x3 op_Inequality(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A94990", Offset = "0x2A93D90", Length = "0xA6")]
	[Token(Token = "0x6002453")]
	public static bool4x3 op_Inequality(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A94A40", Offset = "0x2A93E40", Length = "0xCD")]
	[Token(Token = "0x600244C")]
	public static uint4x3 op_LeftShift(uint4x3 x, int n) { }

	[Address(RVA = "0x2A94D80", Offset = "0x2A94180", Length = "0x106")]
	[Token(Token = "0x600243E")]
	public static bool4x3 op_LessThan(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A94E90", Offset = "0x2A94290", Length = "0xA6")]
	[Token(Token = "0x6002440")]
	public static bool4x3 op_LessThan(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A94F40", Offset = "0x2A94340", Length = "0xAC")]
	[Token(Token = "0x600243F")]
	public static bool4x3 op_LessThan(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A94B10", Offset = "0x2A93F10", Length = "0xA6")]
	[Token(Token = "0x6002443")]
	public static bool4x3 op_LessThanOrEqual(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A94BC0", Offset = "0x2A93FC0", Length = "0xAC")]
	[Token(Token = "0x6002442")]
	public static bool4x3 op_LessThanOrEqual(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A94C70", Offset = "0x2A94070", Length = "0x106")]
	[Token(Token = "0x6002441")]
	public static bool4x3 op_LessThanOrEqual(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A94FF0", Offset = "0x2A943F0", Length = "0xFF")]
	[Token(Token = "0x600243B")]
	public static uint4x3 op_Modulus(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A951E0", Offset = "0x2A945E0", Length = "0x17F")]
	[Token(Token = "0x6002439")]
	public static uint4x3 op_Modulus(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A950F0", Offset = "0x2A944F0", Length = "0xED")]
	[Token(Token = "0x600243A")]
	public static uint4x3 op_Modulus(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A95520", Offset = "0x2A94920", Length = "0x16A")]
	[Token(Token = "0x600242D")]
	public static uint4x3 op_Multiply(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A95440", Offset = "0x2A94840", Length = "0xD2")]
	[Token(Token = "0x600242F")]
	public static uint4x3 op_Multiply(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A95360", Offset = "0x2A94760", Length = "0xD8")]
	[Token(Token = "0x600242E")]
	public static uint4x3 op_Multiply(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A95690", Offset = "0x2A94A90", Length = "0xC0")]
	[Token(Token = "0x6002454")]
	public static uint4x3 op_OnesComplement(uint4x3 val) { }

	[Address(RVA = "0x2A95750", Offset = "0x2A94B50", Length = "0xD1")]
	[Token(Token = "0x600244D")]
	public static uint4x3 op_RightShift(uint4x3 x, int n) { }

	[Address(RVA = "0x2A95830", Offset = "0x2A94C30", Length = "0xE3")]
	[Token(Token = "0x6002435")]
	public static uint4x3 op_Subtraction(uint lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A95A80", Offset = "0x2A94E80", Length = "0xCC")]
	[Token(Token = "0x6002434")]
	public static uint4x3 op_Subtraction(uint4x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A95920", Offset = "0x2A94D20", Length = "0x15E")]
	[Token(Token = "0x6002433")]
	public static uint4x3 op_Subtraction(uint4x3 lhs, uint4x3 rhs) { }

	[Address(RVA = "0x2A95B50", Offset = "0x2A94F50", Length = "0xC0")]
	[Token(Token = "0x600244A")]
	public static uint4x3 op_UnaryNegation(uint4x3 val) { }

	[Address(RVA = "0x2A95C10", Offset = "0x2A95010", Length = "0xB6")]
	[Token(Token = "0x600244B")]
	public static uint4x3 op_UnaryPlus(uint4x3 val) { }

	[Address(RVA = "0x2A92330", Offset = "0x2A91730", Length = "0x500")]
	[Token(Token = "0x6002462")]
	public virtual string ToString() { }

	[Address(RVA = "0x2A92840", Offset = "0x2A91C40", Length = "0x4EE")]
	[Token(Token = "0x6002463")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

