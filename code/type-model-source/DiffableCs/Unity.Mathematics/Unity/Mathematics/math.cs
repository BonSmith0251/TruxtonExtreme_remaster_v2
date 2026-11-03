namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000006")]
public static class math
{
	[Token(Token = "0x2000009")]
	public struct LongDoubleUnion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003B")]
		public long longValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003C")]
		public double doubleValue; //Field offset: 0x0

	}

	[Token(Token = "0x2000007")]
	internal enum RotationOrder : byte
	{
		XYZ = 0,
		XZY = 1,
		YXZ = 2,
		YZX = 3,
		ZXY = 4,
		ZYX = 5,
		Default = 4,
	}

	[Token(Token = "0x2000008")]
	internal enum ShuffleComponent : byte
	{
		LeftX = 0,
		LeftY = 1,
		LeftZ = 2,
		LeftW = 3,
		RightX = 4,
		RightY = 5,
		RightZ = 6,
		RightW = 7,
	}

	[Token(Token = "0x400000A")]
	public const double E_DBL = 2.718281828459045; //Field offset: 0x0
	[Token(Token = "0x4000027")]
	public const float EPSILON = 1.1920929E-07; //Field offset: 0x0
	[Token(Token = "0x4000026")]
	public const float SQRT2 = 1.4142135; //Field offset: 0x0
	[Token(Token = "0x4000025")]
	public const float TORADIANS = 0.017453292; //Field offset: 0x0
	[Token(Token = "0x4000024")]
	public const float TODEGREES = 57.29578; //Field offset: 0x0
	[Token(Token = "0x4000023")]
	public const float TAU = 6.2831855; //Field offset: 0x0
	[Token(Token = "0x4000022")]
	public const float PIHALF = 1.5707964; //Field offset: 0x0
	[Token(Token = "0x4000021")]
	public const float PI2 = 6.2831855; //Field offset: 0x0
	[Token(Token = "0x4000020")]
	public const float PI = 3.1415927; //Field offset: 0x0
	[Token(Token = "0x400001F")]
	public const float LN10 = 2.3025851; //Field offset: 0x0
	[Token(Token = "0x400001E")]
	public const float LN2 = 0.6931472; //Field offset: 0x0
	[Token(Token = "0x400001D")]
	public const float LOG10E = 0.4342945; //Field offset: 0x0
	[Token(Token = "0x400001C")]
	public const float LOG2E = 1.442695; //Field offset: 0x0
	[Token(Token = "0x400001B")]
	public const float E = 2.7182817; //Field offset: 0x0
	[Token(Token = "0x400001A")]
	public const double DBL_MIN_NORMAL = 2.2250738585072014E-308; //Field offset: 0x0
	[Token(Token = "0x4000019")]
	public const float FLT_MIN_NORMAL = 1.1754944E-38; //Field offset: 0x0
	[Token(Token = "0x4000018")]
	public const double NAN_DBL = NaN; //Field offset: 0x0
	[Token(Token = "0x4000017")]
	public const double INFINITY_DBL = ∞; //Field offset: 0x0
	[Token(Token = "0x4000016")]
	public const double EPSILON_DBL = 2.220446049250313E-16; //Field offset: 0x0
	[Token(Token = "0x4000015")]
	public const double SQRT2_DBL = 1.4142135623730951; //Field offset: 0x0
	[Token(Token = "0x4000014")]
	public const double TORADIANS_DBL = 0.017453292519943295; //Field offset: 0x0
	[Token(Token = "0x4000013")]
	public const double TODEGREES_DBL = 57.29577951308232; //Field offset: 0x0
	[Token(Token = "0x4000012")]
	public const double TAU_DBL = 6.283185307179586; //Field offset: 0x0
	[Token(Token = "0x4000011")]
	public const double PIHALF_DBL = 1.5707963267948966; //Field offset: 0x0
	[Token(Token = "0x4000010")]
	public const double PI2_DBL = 6.283185307179586; //Field offset: 0x0
	[Token(Token = "0x400000F")]
	public const double PI_DBL = 3.141592653589793; //Field offset: 0x0
	[Token(Token = "0x400000E")]
	public const double LN10_DBL = 2.302585092994046; //Field offset: 0x0
	[Token(Token = "0x400000D")]
	public const double LN2_DBL = 0.6931471805599453; //Field offset: 0x0
	[Token(Token = "0x400000C")]
	public const double LOG10E_DBL = 0.4342944819032518; //Field offset: 0x0
	[Token(Token = "0x400000B")]
	public const double LOG2E_DBL = 1.4426950408889634; //Field offset: 0x0
	[Token(Token = "0x4000028")]
	public const float INFINITY = ∞; //Field offset: 0x0
	[Token(Token = "0x4000029")]
	public const float NAN = NaN; //Field offset: 0x0

	[Address(RVA = "0x2A24E10", Offset = "0x2A24210", Length = "0x44")]
	[Token(Token = "0x60003AE")]
	public static int2 abs(int2 x) { }

	[Address(RVA = "0x2A24F60", Offset = "0x2A24360", Length = "0x22")]
	[Token(Token = "0x60003B7")]
	public static double2 abs(double2 x) { }

	[Address(RVA = "0x2A24FE0", Offset = "0x2A243E0", Length = "0x18")]
	[Token(Token = "0x60003B6")]
	public static double abs(double x) { }

	[Address(RVA = "0x2A24D40", Offset = "0x2A24140", Length = "0x46")]
	[Token(Token = "0x60003B5")]
	public static float4 abs(float4 x) { }

	[Address(RVA = "0x2A24F90", Offset = "0x2A24390", Length = "0x4B")]
	[Token(Token = "0x60003B4")]
	public static float3 abs(float3 x) { }

	[Address(RVA = "0x2A25000", Offset = "0x2A24400", Length = "0x24")]
	[Token(Token = "0x60003B3")]
	public static float2 abs(float2 x) { }

	[Address(RVA = "0x2A24DA0", Offset = "0x2A241A0", Length = "0xD")]
	[Token(Token = "0x60003B2")]
	public static float abs(float x) { }

	[Address(RVA = "0x2A24D90", Offset = "0x2A24190", Length = "0xE")]
	[Token(Token = "0x60003B1")]
	public static long abs(long x) { }

	[Address(RVA = "0x2A24E60", Offset = "0x2A24260", Length = "0x7B")]
	[Token(Token = "0x60003B0")]
	public static int4 abs(int4 x) { }

	[Address(RVA = "0x2A24EE0", Offset = "0x2A242E0", Length = "0x7C")]
	[Token(Token = "0x60003AF")]
	public static int3 abs(int3 x) { }

	[Address(RVA = "0x2A24D00", Offset = "0x2A24100", Length = "0x3F")]
	[Token(Token = "0x60003B8")]
	public static double3 abs(double3 x) { }

	[Address(RVA = "0x2A24DB0", Offset = "0x2A241B0", Length = "0x51")]
	[Token(Token = "0x60003B9")]
	public static double4 abs(double4 x) { }

	[Address(RVA = "0x2A25030", Offset = "0x2A24430", Length = "0xA")]
	[Token(Token = "0x60003AD")]
	public static int abs(int x) { }

	[Address(RVA = "0x2A25610", Offset = "0x2A24A10", Length = "0x57")]
	[Token(Token = "0x60003FA")]
	public static float acos(float x) { }

	[Address(RVA = "0x2A25040", Offset = "0x2A24440", Length = "0xB4")]
	[Token(Token = "0x60003FB")]
	public static float2 acos(float2 x) { }

	[Address(RVA = "0x2A25100", Offset = "0x2A24500", Length = "0x120")]
	[Token(Token = "0x60003FC")]
	public static float3 acos(float3 x) { }

	[Address(RVA = "0x2A25380", Offset = "0x2A24780", Length = "0x17C")]
	[Token(Token = "0x60003FD")]
	public static float4 acos(float4 x) { }

	[Address(RVA = "0x2A25500", Offset = "0x2A24900", Length = "0x4E")]
	[Token(Token = "0x60003FE")]
	public static double acos(double x) { }

	[Address(RVA = "0x2A25550", Offset = "0x2A24950", Length = "0xB8")]
	[Token(Token = "0x60003FF")]
	public static double2 acos(double2 x) { }

	[Address(RVA = "0x2A25220", Offset = "0x2A24620", Length = "0x15C")]
	[Token(Token = "0x6000401")]
	public static double4 acos(double4 x) { }

	[Address(RVA = "0x2A25670", Offset = "0x2A24A70", Length = "0x108")]
	[Token(Token = "0x6000400")]
	public static double3 acos(double3 x) { }

	[Address(RVA = "0x2A1C7D0", Offset = "0x2A1BBD0", Length = "0x25B")]
	[Token(Token = "0x60006FA")]
	private static float3x3 adj(float3x3 m, out float det) { }

	[Address(RVA = "0x2A1C630", Offset = "0x2A1BA30", Length = "0x19D")]
	[Token(Token = "0x60006FB")]
	private static bool adjInverse(float3x3 m, out float3x3 i, float epsilon = 1E-30) { }

	[Address(RVA = "0x2A236A0", Offset = "0x2A22AA0", Length = "0x7E")]
	[Token(Token = "0x6000013")]
	public static AffineTransform AffineTransform(float3 translation, quaternion rotation) { }

	[Address(RVA = "0x2A23890", Offset = "0x2A22C90", Length = "0x97")]
	[Token(Token = "0x6000019")]
	public static AffineTransform AffineTransform(RigidTransform rigid) { }

	[Address(RVA = "0x2A23930", Offset = "0x2A22D30", Length = "0x94")]
	[Token(Token = "0x6000018")]
	public static AffineTransform AffineTransform(float3x4 m) { }

	[Address(RVA = "0x2A23590", Offset = "0x2A22990", Length = "0xDF")]
	[Token(Token = "0x6000017")]
	public static AffineTransform AffineTransform(float4x4 m) { }

	[Address(RVA = "0x2A23510", Offset = "0x2A22910", Length = "0x79")]
	[Token(Token = "0x6000016")]
	public static AffineTransform AffineTransform(float3x3 rotationScale) { }

	[Address(RVA = "0x2A23670", Offset = "0x2A22A70", Length = "0x2A")]
	[Token(Token = "0x6000015")]
	public static AffineTransform AffineTransform(float3 translation, float3x3 rotationScale) { }

	[Address(RVA = "0x2A23720", Offset = "0x2A22B20", Length = "0x164")]
	[Token(Token = "0x6000014")]
	public static AffineTransform AffineTransform(float3 translation, quaternion rotation, float3 scale) { }

	[Address(RVA = "0x2A258B0", Offset = "0x2A24CB0", Length = "0x20")]
	[Token(Token = "0x60004F5")]
	public static bool all(bool4 x) { }

	[Address(RVA = "0x2A257B0", Offset = "0x2A24BB0", Length = "0x11")]
	[Token(Token = "0x60004F6")]
	public static bool all(int2 x) { }

	[Address(RVA = "0x2A25790", Offset = "0x2A24B90", Length = "0x16")]
	[Token(Token = "0x60004F7")]
	public static bool all(int3 x) { }

	[Address(RVA = "0x2A25860", Offset = "0x2A24C60", Length = "0x1C")]
	[Token(Token = "0x60004F8")]
	public static bool all(int4 x) { }

	[Address(RVA = "0x2A257B0", Offset = "0x2A24BB0", Length = "0x11")]
	[Token(Token = "0x60004F9")]
	public static bool all(uint2 x) { }

	[Address(RVA = "0x2A25880", Offset = "0x2A24C80", Length = "0x28")]
	[Token(Token = "0x60004FC")]
	public static bool all(float2 x) { }

	[Address(RVA = "0x2A25860", Offset = "0x2A24C60", Length = "0x1C")]
	[Token(Token = "0x60004FB")]
	public static bool all(uint4 x) { }

	[Address(RVA = "0x2A25910", Offset = "0x2A24D10", Length = "0x13")]
	[Token(Token = "0x60004F4")]
	public static bool all(bool3 x) { }

	[Address(RVA = "0x2A25930", Offset = "0x2A24D30", Length = "0x2C")]
	[Token(Token = "0x60004FD")]
	public static bool all(float3 x) { }

	[Address(RVA = "0x2A258D0", Offset = "0x2A24CD0", Length = "0x38")]
	[Token(Token = "0x60004FE")]
	public static bool all(float4 x) { }

	[Address(RVA = "0x2A25960", Offset = "0x2A24D60", Length = "0x22")]
	[Token(Token = "0x60004FF")]
	public static bool all(double2 x) { }

	[Address(RVA = "0x2A25790", Offset = "0x2A24B90", Length = "0x16")]
	[Token(Token = "0x60004FA")]
	public static bool all(uint3 x) { }

	[Address(RVA = "0x2A25780", Offset = "0x2A24B80", Length = "0xF")]
	[Token(Token = "0x60004F3")]
	public static bool all(bool2 x) { }

	[Address(RVA = "0x2A257D0", Offset = "0x2A24BD0", Length = "0x47")]
	[Token(Token = "0x6000501")]
	public static bool all(double4 x) { }

	[Address(RVA = "0x2A25820", Offset = "0x2A24C20", Length = "0x3B")]
	[Token(Token = "0x6000500")]
	public static bool all(double3 x) { }

	[Address(RVA = "0x2A25990", Offset = "0x2A24D90", Length = "0x212")]
	[Token(Token = "0x60006F8")]
	public static float angle(quaternion q1, quaternion q2) { }

	[Address(RVA = "0x2A25C80", Offset = "0x2A25080", Length = "0x47")]
	[Token(Token = "0x60004F2")]
	public static bool any(double4 x) { }

	[Address(RVA = "0x2A25D20", Offset = "0x2A25120", Length = "0x38")]
	[Token(Token = "0x60004EF")]
	public static bool any(float4 x) { }

	[Address(RVA = "0x2A25CF0", Offset = "0x2A250F0", Length = "0x28")]
	[Token(Token = "0x60004ED")]
	public static bool any(float2 x) { }

	[Address(RVA = "0x2A25BB0", Offset = "0x2A24FB0", Length = "0x1C")]
	[Token(Token = "0x60004EC")]
	public static bool any(uint4 x) { }

	[Address(RVA = "0x2A25C00", Offset = "0x2A25000", Length = "0x16")]
	[Token(Token = "0x60004EB")]
	public static bool any(uint3 x) { }

	[Address(RVA = "0x2A25BD0", Offset = "0x2A24FD0", Length = "0x11")]
	[Token(Token = "0x60004EA")]
	public static bool any(uint2 x) { }

	[Address(RVA = "0x2A25BB0", Offset = "0x2A24FB0", Length = "0x1C")]
	[Token(Token = "0x60004E9")]
	public static bool any(int4 x) { }

	[Address(RVA = "0x2A25C00", Offset = "0x2A25000", Length = "0x16")]
	[Token(Token = "0x60004E8")]
	public static bool any(int3 x) { }

	[Address(RVA = "0x2A25BD0", Offset = "0x2A24FD0", Length = "0x11")]
	[Token(Token = "0x60004E7")]
	public static bool any(int2 x) { }

	[Address(RVA = "0x2A25DA0", Offset = "0x2A251A0", Length = "0x20")]
	[Token(Token = "0x60004E6")]
	public static bool any(bool4 x) { }

	[Address(RVA = "0x2A25CD0", Offset = "0x2A250D0", Length = "0x13")]
	[Token(Token = "0x60004E5")]
	public static bool any(bool3 x) { }

	[Address(RVA = "0x2A25BF0", Offset = "0x2A24FF0", Length = "0xF")]
	[Token(Token = "0x60004E4")]
	public static bool any(bool2 x) { }

	[Address(RVA = "0x2A25C20", Offset = "0x2A25020", Length = "0x22")]
	[Token(Token = "0x60004F0")]
	public static bool any(double2 x) { }

	[Address(RVA = "0x2A25C50", Offset = "0x2A25050", Length = "0x2C")]
	[Token(Token = "0x60004EE")]
	public static bool any(float3 x) { }

	[Address(RVA = "0x2A25D60", Offset = "0x2A25160", Length = "0x3B")]
	[Token(Token = "0x60004F1")]
	public static bool any(double3 x) { }

	[Address(RVA = "0x2A25DC0", Offset = "0x2A251C0", Length = "0x6")]
	[Token(Token = "0x600031E")]
	public static double asdouble(ulong x) { }

	[Address(RVA = "0x2A25DC0", Offset = "0x2A251C0", Length = "0x6")]
	[Token(Token = "0x600031D")]
	public static double asdouble(long x) { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[Token(Token = "0x6000316")]
	public static float3 asfloat(int3 x) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6000317")]
	public static float4 asfloat(int4 x) { }

	[Address(RVA = "0x1F8D390", Offset = "0x1F8C790", Length = "0x5")]
	[Token(Token = "0x6000318")]
	public static float asfloat(uint x) { }

	[Address(RVA = "0x2A25DD0", Offset = "0x2A251D0", Length = "0x1A")]
	[Token(Token = "0x6000319")]
	public static float2 asfloat(uint2 x) { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[Token(Token = "0x600031A")]
	public static float3 asfloat(uint3 x) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x600031B")]
	public static float4 asfloat(uint4 x) { }

	[Address(RVA = "0x2A25DD0", Offset = "0x2A251D0", Length = "0x1A")]
	[Token(Token = "0x6000315")]
	public static float2 asfloat(int2 x) { }

	[Address(RVA = "0x1F8D390", Offset = "0x1F8C790", Length = "0x5")]
	[Token(Token = "0x6000314")]
	public static float asfloat(int x) { }

	[Address(RVA = "0x2A25DF0", Offset = "0x2A251F0", Length = "0xB4")]
	[Token(Token = "0x6000413")]
	public static float2 asin(float2 x) { }

	[Address(RVA = "0x2A26010", Offset = "0x2A25410", Length = "0x120")]
	[Token(Token = "0x6000414")]
	public static float3 asin(float3 x) { }

	[Address(RVA = "0x2A26300", Offset = "0x2A25700", Length = "0x17C")]
	[Token(Token = "0x6000415")]
	public static float4 asin(float4 x) { }

	[Address(RVA = "0x2A26480", Offset = "0x2A25880", Length = "0x4E")]
	[Token(Token = "0x6000416")]
	public static double asin(double x) { }

	[Address(RVA = "0x2A26240", Offset = "0x2A25640", Length = "0xB8")]
	[Token(Token = "0x6000417")]
	public static double2 asin(double2 x) { }

	[Address(RVA = "0x2A26130", Offset = "0x2A25530", Length = "0x108")]
	[Token(Token = "0x6000418")]
	public static double3 asin(double3 x) { }

	[Address(RVA = "0x2A25EB0", Offset = "0x2A252B0", Length = "0x15C")]
	[Token(Token = "0x6000419")]
	public static double4 asin(double4 x) { }

	[Address(RVA = "0x2A264D0", Offset = "0x2A258D0", Length = "0x57")]
	[Token(Token = "0x6000412")]
	public static float asin(float x) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000300")]
	public static int asint(uint x) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000301")]
	public static int2 asint(uint2 x) { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[Token(Token = "0x6000302")]
	public static int3 asint(uint3 x) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6000303")]
	public static int4 asint(uint4 x) { }

	[Address(RVA = "0x1F8D3A0", Offset = "0x1F8C7A0", Length = "0x5")]
	[Token(Token = "0x6000304")]
	public static int asint(float x) { }

	[Address(RVA = "0x2A26530", Offset = "0x2A25930", Length = "0x9")]
	[Token(Token = "0x6000305")]
	public static int2 asint(float2 x) { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[Token(Token = "0x6000306")]
	public static int3 asint(float3 x) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6000307")]
	public static int4 asint(float4 x) { }

	[Address(RVA = "0x1F8CFC0", Offset = "0x1F8C3C0", Length = "0x6")]
	[Token(Token = "0x6000311")]
	public static long aslong(double x) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000310")]
	public static long aslong(ulong x) { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[Token(Token = "0x600030A")]
	public static uint3 asuint(int3 x) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x600030F")]
	public static uint4 asuint(float4 x) { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[Token(Token = "0x600030E")]
	public static uint3 asuint(float3 x) { }

	[Address(RVA = "0x2A26530", Offset = "0x2A25930", Length = "0x9")]
	[Token(Token = "0x600030D")]
	public static uint2 asuint(float2 x) { }

	[Address(RVA = "0x1F8D3A0", Offset = "0x1F8C7A0", Length = "0x5")]
	[Token(Token = "0x600030C")]
	public static uint asuint(float x) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x600030B")]
	public static uint4 asuint(int4 x) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000309")]
	public static uint2 asuint(int2 x) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000308")]
	public static uint asuint(int x) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000312")]
	public static ulong asulong(long x) { }

	[Address(RVA = "0x1F8CFC0", Offset = "0x1F8C3C0", Length = "0x6")]
	[Token(Token = "0x6000313")]
	public static ulong asulong(double x) { }

	[Address(RVA = "0x2A27000", Offset = "0x2A26400", Length = "0x15C")]
	[Token(Token = "0x60003E1")]
	public static double4 atan(double4 x) { }

	[Address(RVA = "0x2A271C0", Offset = "0x2A265C0", Length = "0x108")]
	[Token(Token = "0x60003E0")]
	public static double3 atan(double3 x) { }

	[Address(RVA = "0x2A27390", Offset = "0x2A26790", Length = "0x4E")]
	[Token(Token = "0x60003DE")]
	public static double atan(double x) { }

	[Address(RVA = "0x2A26D60", Offset = "0x2A26160", Length = "0x17C")]
	[Token(Token = "0x60003DD")]
	public static float4 atan(float4 x) { }

	[Address(RVA = "0x2A272D0", Offset = "0x2A266D0", Length = "0xB8")]
	[Token(Token = "0x60003DF")]
	public static double2 atan(double2 x) { }

	[Address(RVA = "0x2A26EE0", Offset = "0x2A262E0", Length = "0x120")]
	[Token(Token = "0x60003DC")]
	public static float3 atan(float3 x) { }

	[Address(RVA = "0x2A273E0", Offset = "0x2A267E0", Length = "0xB4")]
	[Token(Token = "0x60003DB")]
	public static float2 atan(float2 x) { }

	[Address(RVA = "0x2A27160", Offset = "0x2A26560", Length = "0x57")]
	[Token(Token = "0x60003DA")]
	public static float atan(float x) { }

	[Address(RVA = "0x2A268F0", Offset = "0x2A25CF0", Length = "0x6B")]
	[Token(Token = "0x60003E2")]
	public static float atan2(float y, float x) { }

	[Address(RVA = "0x2A26820", Offset = "0x2A25C20", Length = "0xCB")]
	[Token(Token = "0x60003E3")]
	public static float2 atan2(float2 y, float2 x) { }

	[Address(RVA = "0x2A266D0", Offset = "0x2A25AD0", Length = "0x145")]
	[Token(Token = "0x60003E4")]
	public static float3 atan2(float3 y, float3 x) { }

	[Address(RVA = "0x2A26A30", Offset = "0x2A25E30", Length = "0x1A9")]
	[Token(Token = "0x60003E5")]
	public static float4 atan2(float4 y, float4 x) { }

	[Address(RVA = "0x2A26670", Offset = "0x2A25A70", Length = "0x5E")]
	[Token(Token = "0x60003E6")]
	public static double atan2(double y, double x) { }

	[Address(RVA = "0x2A26960", Offset = "0x2A25D60", Length = "0xCF")]
	[Token(Token = "0x60003E7")]
	public static double2 atan2(double2 y, double2 x) { }

	[Address(RVA = "0x2A26540", Offset = "0x2A25940", Length = "0x124")]
	[Token(Token = "0x60003E8")]
	public static double3 atan2(double3 y, double3 x) { }

	[Address(RVA = "0x2A26BE0", Offset = "0x2A25FE0", Length = "0x17D")]
	[Token(Token = "0x60003E9")]
	public static double4 atan2(double4 y, double4 x) { }

	[Address(RVA = "0x2A274A0", Offset = "0x2A268A0", Length = "0x10")]
	[Token(Token = "0x6000600")]
	public static float3 back() { }

	[Address(RVA = "0x2A274B0", Offset = "0x2A268B0", Length = "0x41")]
	[Token(Token = "0x600031C")]
	public static int bitmask(bool4 value) { }

	[Address(RVA = "0x2A27520", Offset = "0x2A26920", Length = "0x12")]
	[Token(Token = "0x6000027")]
	public static bool2 bool2(bool2 xy) { }

	[Address(RVA = "0x2A27500", Offset = "0x2A26900", Length = "0xE")]
	[Token(Token = "0x6000026")]
	public static bool2 bool2(bool x, bool y) { }

	[Address(RVA = "0x2A27510", Offset = "0x2A26910", Length = "0xE")]
	[Token(Token = "0x6000028")]
	public static bool2 bool2(bool v) { }

	[Address(RVA = "0x2A27550", Offset = "0x2A26950", Length = "0x29")]
	[Token(Token = "0x6000032")]
	public static bool2x2 bool2x2(bool v) { }

	[Address(RVA = "0x2A27580", Offset = "0x2A26980", Length = "0x2B")]
	[Token(Token = "0x6000031")]
	public static bool2x2 bool2x2(bool m00, bool m01, bool m10, bool m11) { }

	[Address(RVA = "0x2A27540", Offset = "0x2A26940", Length = "0xF")]
	[Token(Token = "0x6000030")]
	public static bool2x2 bool2x2(bool2 c0, bool2 c1) { }

	[Address(RVA = "0x2A27620", Offset = "0x2A26A20", Length = "0x36")]
	[Token(Token = "0x6000038")]
	public static bool2x3 bool2x3(bool v) { }

	[Address(RVA = "0x2A275D0", Offset = "0x2A269D0", Length = "0x47")]
	[Token(Token = "0x6000037")]
	public static bool2x3 bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12) { }

	[Address(RVA = "0x2A275B0", Offset = "0x2A269B0", Length = "0x11")]
	[Token(Token = "0x6000036")]
	public static bool2x3 bool2x3(bool2 c0, bool2 c1, bool2 c2) { }

	[Address(RVA = "0x2A27690", Offset = "0x2A26A90", Length = "0x6A")]
	[Token(Token = "0x600003D")]
	public static bool2x4 bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13) { }

	[Address(RVA = "0x2A27660", Offset = "0x2A26A60", Length = "0x22")]
	[Token(Token = "0x600003C")]
	public static bool2x4 bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3) { }

	[Address(RVA = "0x2A27700", Offset = "0x2A26B00", Length = "0x4E")]
	[Token(Token = "0x600003E")]
	public static bool2x4 bool2x4(bool v) { }

	[Address(RVA = "0x2A27760", Offset = "0x2A26B60", Length = "0xC")]
	[Token(Token = "0x6000046")]
	public static bool3 bool3(bool v) { }

	[Address(RVA = "0x2A277B0", Offset = "0x2A26BB0", Length = "0x20")]
	[Token(Token = "0x6000045")]
	public static bool3 bool3(bool3 xyz) { }

	[Address(RVA = "0x2A27770", Offset = "0x2A26B70", Length = "0x11")]
	[Token(Token = "0x6000044")]
	public static bool3 bool3(bool2 xy, bool z) { }

	[Address(RVA = "0x2A27790", Offset = "0x2A26B90", Length = "0x13")]
	[Token(Token = "0x6000043")]
	public static bool3 bool3(bool x, bool2 yz) { }

	[Address(RVA = "0x2A27750", Offset = "0x2A26B50", Length = "0xE")]
	[Token(Token = "0x6000042")]
	public static bool3 bool3(bool x, bool y, bool z) { }

	[Address(RVA = "0x2A27810", Offset = "0x2A26C10", Length = "0x21")]
	[Token(Token = "0x600004E")]
	public static bool3x2 bool3x2(bool3 c0, bool3 c1) { }

	[Address(RVA = "0x2A277D0", Offset = "0x2A26BD0", Length = "0x3C")]
	[Token(Token = "0x600004F")]
	public static bool3x2 bool3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21) { }

	[Address(RVA = "0x2A27840", Offset = "0x2A26C40", Length = "0x2B")]
	[Token(Token = "0x6000050")]
	public static bool3x2 bool3x2(bool v) { }

	[Address(RVA = "0x2A27920", Offset = "0x2A26D20", Length = "0x31")]
	[Token(Token = "0x6000054")]
	public static bool3x3 bool3x3(bool3 c0, bool3 c1, bool3 c2) { }

	[Address(RVA = "0x2A27870", Offset = "0x2A26C70", Length = "0x64")]
	[Token(Token = "0x6000055")]
	public static bool3x3 bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22) { }

	[Address(RVA = "0x2A278E0", Offset = "0x2A26CE0", Length = "0x3F")]
	[Token(Token = "0x6000056")]
	public static bool3x3 bool3x3(bool v) { }

	[Address(RVA = "0x2A279F0", Offset = "0x2A26DF0", Length = "0x49")]
	[Token(Token = "0x600005A")]
	public static bool3x4 bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3) { }

	[Address(RVA = "0x2A27960", Offset = "0x2A26D60", Length = "0x89")]
	[Token(Token = "0x600005B")]
	public static bool3x4 bool3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23) { }

	[Address(RVA = "0x2A27A40", Offset = "0x2A26E40", Length = "0x53")]
	[Token(Token = "0x600005C")]
	public static bool3x4 bool3x4(bool v) { }

	[Address(RVA = "0x2A27B20", Offset = "0x2A26F20", Length = "0x1D")]
	[Token(Token = "0x6000065")]
	public static bool4 bool4(bool2 xy, bool2 zw) { }

	[Address(RVA = "0x2A27B40", Offset = "0x2A26F40", Length = "0x22")]
	[Token(Token = "0x6000067")]
	public static bool4 bool4(bool4 xyzw) { }

	[Address(RVA = "0x2A27B90", Offset = "0x2A26F90", Length = "0x29")]
	[Token(Token = "0x6000066")]
	public static bool4 bool4(bool3 xyz, bool w) { }

	[Address(RVA = "0x2A27AA0", Offset = "0x2A26EA0", Length = "0x1A")]
	[Token(Token = "0x6000064")]
	public static bool4 bool4(bool2 xy, bool z, bool w) { }

	[Address(RVA = "0x2A27B70", Offset = "0x2A26F70", Length = "0x1C")]
	[Token(Token = "0x6000061")]
	public static bool4 bool4(bool x, bool y, bool2 zw) { }

	[Address(RVA = "0x2A27AC0", Offset = "0x2A26EC0", Length = "0x1A")]
	[Token(Token = "0x6000062")]
	public static bool4 bool4(bool x, bool2 yz, bool w) { }

	[Address(RVA = "0x2A27B00", Offset = "0x2A26F00", Length = "0x15")]
	[Token(Token = "0x6000068")]
	public static bool4 bool4(bool v) { }

	[Address(RVA = "0x2A27AE0", Offset = "0x2A26EE0", Length = "0x17")]
	[Token(Token = "0x6000060")]
	public static bool4 bool4(bool x, bool y, bool z, bool w) { }

	[Address(RVA = "0x2A27BC0", Offset = "0x2A26FC0", Length = "0x26")]
	[Token(Token = "0x6000063")]
	public static bool4 bool4(bool x, bool3 yzw) { }

	[Address(RVA = "0x2A27C50", Offset = "0x2A27050", Length = "0x36")]
	[Token(Token = "0x6000072")]
	public static bool4x2 bool4x2(bool v) { }

	[Address(RVA = "0x2A27C90", Offset = "0x2A27090", Length = "0xE")]
	[Token(Token = "0x6000070")]
	public static bool4x2 bool4x2(bool4 c0, bool4 c1) { }

	[Address(RVA = "0x2A27BF0", Offset = "0x2A26FF0", Length = "0x52")]
	[Token(Token = "0x6000071")]
	public static bool4x2 bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31) { }

	[Address(RVA = "0x2A27CF0", Offset = "0x2A270F0", Length = "0xE")]
	[Token(Token = "0x6000076")]
	public static bool4x3 bool4x3(bool4 c0, bool4 c1, bool4 c2) { }

	[Address(RVA = "0x2A27D00", Offset = "0x2A27100", Length = "0x77")]
	[Token(Token = "0x6000077")]
	public static bool4x3 bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32) { }

	[Address(RVA = "0x2A27CA0", Offset = "0x2A270A0", Length = "0x48")]
	[Token(Token = "0x6000078")]
	public static bool4x3 bool4x3(bool v) { }

	[Address(RVA = "0x2A27D80", Offset = "0x2A27180", Length = "0xA8")]
	[Token(Token = "0x600007D")]
	public static bool4x4 bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33) { }

	[Address(RVA = "0x27F9F00", Offset = "0x27F9300", Length = "0x15")]
	[Token(Token = "0x600007C")]
	public static bool4x4 bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3) { }

	[Address(RVA = "0x2A27E30", Offset = "0x2A27230", Length = "0x5F")]
	[Token(Token = "0x600007E")]
	public static bool4x4 bool4x4(bool v) { }

	[Address(RVA = "0x2A27EF0", Offset = "0x2A272F0", Length = "0x108")]
	[Token(Token = "0x6000428")]
	public static double3 ceil(double3 x) { }

	[Address(RVA = "0x2A280C0", Offset = "0x2A274C0", Length = "0xB8")]
	[Token(Token = "0x6000427")]
	public static double2 ceil(double2 x) { }

	[Address(RVA = "0x2A28000", Offset = "0x2A27400", Length = "0xB4")]
	[Token(Token = "0x6000423")]
	public static float2 ceil(float2 x) { }

	[Address(RVA = "0x2A28300", Offset = "0x2A27700", Length = "0x15C")]
	[Token(Token = "0x6000429")]
	public static double4 ceil(double4 x) { }

	[Address(RVA = "0x2A28580", Offset = "0x2A27980", Length = "0x4E")]
	[Token(Token = "0x6000426")]
	public static double ceil(double x) { }

	[Address(RVA = "0x2A28180", Offset = "0x2A27580", Length = "0x17C")]
	[Token(Token = "0x6000425")]
	public static float4 ceil(float4 x) { }

	[Address(RVA = "0x2A28460", Offset = "0x2A27860", Length = "0x120")]
	[Token(Token = "0x6000424")]
	public static float3 ceil(float3 x) { }

	[Address(RVA = "0x2A27E90", Offset = "0x2A27290", Length = "0x57")]
	[Token(Token = "0x6000422")]
	public static float ceil(float x) { }

	[Address(RVA = "0x28AC0E0", Offset = "0x28AB4E0", Length = "0x3F")]
	[Token(Token = "0x6000594")]
	public static int ceillog2(int x) { }

	[Address(RVA = "0x2A285D0", Offset = "0x2A279D0", Length = "0xC8")]
	[Token(Token = "0x6000596")]
	public static int3 ceillog2(int3 x) { }

	[Address(RVA = "0x2A287B0", Offset = "0x2A27BB0", Length = "0x93")]
	[Token(Token = "0x6000595")]
	public static int2 ceillog2(int2 x) { }

	[Address(RVA = "0x28AC0E0", Offset = "0x28AB4E0", Length = "0x3F")]
	[Token(Token = "0x6000598")]
	public static int ceillog2(uint x) { }

	[Address(RVA = "0x2A287B0", Offset = "0x2A27BB0", Length = "0x93")]
	[Token(Token = "0x6000599")]
	public static int2 ceillog2(uint2 x) { }

	[Address(RVA = "0x2A285D0", Offset = "0x2A279D0", Length = "0xC8")]
	[Token(Token = "0x600059A")]
	public static int3 ceillog2(uint3 x) { }

	[Address(RVA = "0x2A286A0", Offset = "0x2A27AA0", Length = "0x106")]
	[Token(Token = "0x600059B")]
	public static int4 ceillog2(uint4 x) { }

	[Address(RVA = "0x2A286A0", Offset = "0x2A27AA0", Length = "0x106")]
	[Token(Token = "0x6000597")]
	public static int4 ceillog2(int4 x) { }

	[Address(RVA = "0x2A28D50", Offset = "0x2A28150", Length = "0x1F8")]
	[Token(Token = "0x6000591")]
	public static uint4 ceilpow2(uint4 x) { }

	[Address(RVA = "0x2A28F50", Offset = "0x2A28350", Length = "0x181")]
	[Token(Token = "0x600058F")]
	public static uint2 ceilpow2(uint2 x) { }

	[Address(RVA = "0x2A290E0", Offset = "0x2A284E0", Length = "0x1F8")]
	[Token(Token = "0x600058D")]
	public static int4 ceilpow2(int4 x) { }

	[Address(RVA = "0x2A28880", Offset = "0x2A27C80", Length = "0x14E")]
	[Token(Token = "0x6000590")]
	public static uint3 ceilpow2(uint3 x) { }

	[Address(RVA = "0x2A28D00", Offset = "0x2A28100", Length = "0x42")]
	[Token(Token = "0x6000592")]
	public static long ceilpow2(long x) { }

	[Address(RVA = "0x2A28CB0", Offset = "0x2A280B0", Length = "0x42")]
	[Token(Token = "0x6000593")]
	public static ulong ceilpow2(ulong x) { }

	[Address(RVA = "0x2A28B60", Offset = "0x2A27F60", Length = "0x14E")]
	[Token(Token = "0x600058C")]
	public static int3 ceilpow2(int3 x) { }

	[Address(RVA = "0x2A289D0", Offset = "0x2A27DD0", Length = "0x181")]
	[Token(Token = "0x600058B")]
	public static int2 ceilpow2(int2 x) { }

	[Address(RVA = "0x16BD800", Offset = "0x16BCC00", Length = "0x27")]
	[Token(Token = "0x600058A")]
	public static int ceilpow2(int x) { }

	[Address(RVA = "0x2A28850", Offset = "0x2A27C50", Length = "0x27")]
	[Token(Token = "0x600058E")]
	public static uint ceilpow2(uint x) { }

	[Address(RVA = "0x2A293E0", Offset = "0x2A287E0", Length = "0x80")]
	[Token(Token = "0x60005F8")]
	public static float4 chgsign(float4 x, float4 y) { }

	[Address(RVA = "0x2A29340", Offset = "0x2A28740", Length = "0x7D")]
	[Token(Token = "0x60005F7")]
	public static float3 chgsign(float3 x, float3 y) { }

	[Address(RVA = "0x2A292E0", Offset = "0x2A286E0", Length = "0x58")]
	[Token(Token = "0x60005F6")]
	public static float2 chgsign(float2 x, float2 y) { }

	[Address(RVA = "0x2A293C0", Offset = "0x2A287C0", Length = "0x15")]
	[Token(Token = "0x60005F5")]
	public static float chgsign(float x, float y) { }

	[Address(RVA = "0x2A29950", Offset = "0x2A28D50", Length = "0xB8")]
	[Token(Token = "0x6000395")]
	public static int3 clamp(int3 valueToClamp, int3 lowerBound, int3 upperBound) { }

	[Address(RVA = "0x2A29C00", Offset = "0x2A29000", Length = "0x5B")]
	[Token(Token = "0x6000394")]
	public static int2 clamp(int2 valueToClamp, int2 lowerBound, int2 upperBound) { }

	[Address(RVA = "0x2A29B00", Offset = "0x2A28F00", Length = "0x14")]
	[Token(Token = "0x6000393")]
	public static int clamp(int valueToClamp, int lowerBound, int upperBound) { }

	[Address(RVA = "0x2A29830", Offset = "0x2A28C30", Length = "0x14")]
	[Token(Token = "0x600039B")]
	public static long clamp(long valueToClamp, long lowerBound, long upperBound) { }

	[Address(RVA = "0x2A29A30", Offset = "0x2A28E30", Length = "0xC3")]
	[Token(Token = "0x6000396")]
	public static int4 clamp(int4 valueToClamp, int4 lowerBound, int4 upperBound) { }

	[Address(RVA = "0x2A29A10", Offset = "0x2A28E10", Length = "0x14")]
	[Token(Token = "0x6000397")]
	public static uint clamp(uint valueToClamp, uint lowerBound, uint upperBound) { }

	[Address(RVA = "0x2A297D0", Offset = "0x2A28BD0", Length = "0x5B")]
	[Token(Token = "0x6000398")]
	public static uint2 clamp(uint2 valueToClamp, uint2 lowerBound, uint2 upperBound) { }

	[Address(RVA = "0x2A29B20", Offset = "0x2A28F20", Length = "0xB8")]
	[Token(Token = "0x6000399")]
	public static uint3 clamp(uint3 valueToClamp, uint3 lowerBound, uint3 upperBound) { }

	[Address(RVA = "0x2A29460", Offset = "0x2A28860", Length = "0xC3")]
	[Token(Token = "0x600039A")]
	public static uint4 clamp(uint4 valueToClamp, uint4 lowerBound, uint4 upperBound) { }

	[Address(RVA = "0x8FDA70", Offset = "0x8FCE70", Length = "0x87")]
	[Token(Token = "0x600039D")]
	public static float clamp(float valueToClamp, float lowerBound, float upperBound) { }

	[Address(RVA = "0x2A29BE0", Offset = "0x2A28FE0", Length = "0x14")]
	[Token(Token = "0x600039C")]
	public static ulong clamp(ulong valueToClamp, ulong lowerBound, ulong upperBound) { }

	[Address(RVA = "0x2A29850", Offset = "0x2A28C50", Length = "0xF3")]
	[Token(Token = "0x600039F")]
	public static float3 clamp(float3 valueToClamp, float3 lowerBound, float3 upperBound) { }

	[Address(RVA = "0x2A29580", Offset = "0x2A28980", Length = "0x132")]
	[Token(Token = "0x60003A0")]
	public static float4 clamp(float4 valueToClamp, float4 lowerBound, float4 upperBound) { }

	[Address(RVA = "0x2A29530", Offset = "0x2A28930", Length = "0x41")]
	[Token(Token = "0x60003A1")]
	public static double clamp(double valueToClamp, double lowerBound, double upperBound) { }

	[Address(RVA = "0x2A29C60", Offset = "0x2A29060", Length = "0xA4")]
	[Token(Token = "0x60003A2")]
	public static double2 clamp(double2 valueToClamp, double2 lowerBound, double2 upperBound) { }

	[Address(RVA = "0x2A296C0", Offset = "0x2A28AC0", Length = "0x108")]
	[Token(Token = "0x60003A3")]
	public static double3 clamp(double3 valueToClamp, double3 lowerBound, double3 upperBound) { }

	[Address(RVA = "0x2A29D10", Offset = "0x2A29110", Length = "0x136")]
	[Token(Token = "0x60003A4")]
	public static double4 clamp(double4 valueToClamp, double4 lowerBound, double4 upperBound) { }

	[Address(RVA = "0x8FD9D0", Offset = "0x8FCDD0", Length = "0x9E")]
	[Token(Token = "0x600039E")]
	public static float2 clamp(float2 valueToClamp, float2 lowerBound, float2 upperBound) { }

	[Address(RVA = "0x2A2A010", Offset = "0x2A29410", Length = "0x11")]
	[Token(Token = "0x60005C0")]
	public static int cmax(int2 x) { }

	[Address(RVA = "0x2A2A090", Offset = "0x2A29490", Length = "0x4F")]
	[Token(Token = "0x60005CA")]
	public static double cmax(double3 x) { }

	[Address(RVA = "0x2A2A030", Offset = "0x2A29430", Length = "0x34")]
	[Token(Token = "0x60005C9")]
	public static double cmax(double2 x) { }

	[Address(RVA = "0x2A29EB0", Offset = "0x2A292B0", Length = "0x59")]
	[Token(Token = "0x60005C8")]
	public static float cmax(float4 x) { }

	[Address(RVA = "0x2A29FF0", Offset = "0x2A293F0", Length = "0x12")]
	[Token(Token = "0x60005C4")]
	public static uint cmax(uint3 x) { }

	[Address(RVA = "0x2A29F40", Offset = "0x2A29340", Length = "0x19")]
	[Token(Token = "0x60005C2")]
	public static int cmax(int4 x) { }

	[Address(RVA = "0x2A2A070", Offset = "0x2A29470", Length = "0x12")]
	[Token(Token = "0x60005C1")]
	public static int cmax(int3 x) { }

	[Address(RVA = "0x2A29E50", Offset = "0x2A29250", Length = "0x3D")]
	[Token(Token = "0x60005C7")]
	public static float cmax(float3 x) { }

	[Address(RVA = "0x2A29E90", Offset = "0x2A29290", Length = "0x11")]
	[Token(Token = "0x60005C3")]
	public static uint cmax(uint2 x) { }

	[Address(RVA = "0x2A29F10", Offset = "0x2A29310", Length = "0x29")]
	[Token(Token = "0x60005C6")]
	public static float cmax(float2 x) { }

	[Address(RVA = "0x2A29F80", Offset = "0x2A29380", Length = "0x6A")]
	[Token(Token = "0x60005CB")]
	public static double cmax(double4 x) { }

	[Address(RVA = "0x2A29F60", Offset = "0x2A29360", Length = "0x19")]
	[Token(Token = "0x60005C5")]
	public static uint cmax(uint4 x) { }

	[Address(RVA = "0x2A2A120", Offset = "0x2A29520", Length = "0x6A")]
	[Token(Token = "0x60005BF")]
	public static double cmin(double4 x) { }

	[Address(RVA = "0x2A2A2E0", Offset = "0x2A296E0", Length = "0x11")]
	[Token(Token = "0x60005B4")]
	public static int cmin(int2 x) { }

	[Address(RVA = "0x2A2A100", Offset = "0x2A29500", Length = "0x19")]
	[Token(Token = "0x60005B9")]
	public static uint cmin(uint4 x) { }

	[Address(RVA = "0x2A2A350", Offset = "0x2A29750", Length = "0x12")]
	[Token(Token = "0x60005B8")]
	public static uint cmin(uint3 x) { }

	[Address(RVA = "0x2A2A1F0", Offset = "0x2A295F0", Length = "0x11")]
	[Token(Token = "0x60005B7")]
	public static uint cmin(uint2 x) { }

	[Address(RVA = "0x2A2A190", Offset = "0x2A29590", Length = "0x19")]
	[Token(Token = "0x60005B6")]
	public static int cmin(int4 x) { }

	[Address(RVA = "0x2A2A0E0", Offset = "0x2A294E0", Length = "0x12")]
	[Token(Token = "0x60005B5")]
	public static int cmin(int3 x) { }

	[Address(RVA = "0x2A2A1B0", Offset = "0x2A295B0", Length = "0x34")]
	[Token(Token = "0x60005BD")]
	public static double cmin(double2 x) { }

	[Address(RVA = "0x2A2A250", Offset = "0x2A29650", Length = "0x59")]
	[Token(Token = "0x60005BC")]
	public static float cmin(float4 x) { }

	[Address(RVA = "0x2A2A300", Offset = "0x2A29700", Length = "0x4F")]
	[Token(Token = "0x60005BE")]
	public static double cmin(double3 x) { }

	[Address(RVA = "0x2A2A210", Offset = "0x2A29610", Length = "0x3D")]
	[Token(Token = "0x60005BB")]
	public static float cmin(float3 x) { }

	[Address(RVA = "0x2A2A2B0", Offset = "0x2A296B0", Length = "0x29")]
	[Token(Token = "0x60005BA")]
	public static float cmin(float2 x) { }

	[Address(RVA = "0x2A2A370", Offset = "0x2A29770", Length = "0x73")]
	[Token(Token = "0x60005EA")]
	public static int compress(Single* output, int index, float4 val, bool4 mask) { }

	[Address(RVA = "0x2A2A370", Offset = "0x2A29770", Length = "0x73")]
	[Token(Token = "0x60005E9")]
	public static int compress(UInt32* output, int index, uint4 val, bool4 mask) { }

	[Address(RVA = "0x2A2A3F0", Offset = "0x2A297F0", Length = "0x5D")]
	[Token(Token = "0x60005E8")]
	public static int compress(Int32* output, int index, int4 val, bool4 mask) { }

	[Address(RVA = "0x2A2A450", Offset = "0x2A29850", Length = "0x57")]
	[Token(Token = "0x60006E7")]
	public static quaternion conjugate(quaternion q) { }

	[Address(RVA = "0x2A2A8C0", Offset = "0x2A29CC0", Length = "0x4E")]
	[Token(Token = "0x60003EE")]
	public static double cos(double x) { }

	[Address(RVA = "0x2A2A910", Offset = "0x2A29D10", Length = "0x15C")]
	[Token(Token = "0x60003F1")]
	public static double4 cos(double4 x) { }

	[Address(RVA = "0x2A2A570", Offset = "0x2A29970", Length = "0x108")]
	[Token(Token = "0x60003F0")]
	public static double3 cos(double3 x) { }

	[Address(RVA = "0x2A2A800", Offset = "0x2A29C00", Length = "0xB8")]
	[Token(Token = "0x60003EF")]
	public static double2 cos(double2 x) { }

	[Address(RVA = "0x2A2A680", Offset = "0x2A29A80", Length = "0x57")]
	[Token(Token = "0x60003EA")]
	public static float cos(float x) { }

	[Address(RVA = "0x2A2A6E0", Offset = "0x2A29AE0", Length = "0x120")]
	[Token(Token = "0x60003EC")]
	public static float3 cos(float3 x) { }

	[Address(RVA = "0x2A2AA70", Offset = "0x2A29E70", Length = "0x17C")]
	[Token(Token = "0x60003ED")]
	public static float4 cos(float4 x) { }

	[Address(RVA = "0x2A2A4B0", Offset = "0x2A298B0", Length = "0xB4")]
	[Token(Token = "0x60003EB")]
	public static float2 cos(float2 x) { }

	[Address(RVA = "0x2A2ABF0", Offset = "0x2A29FF0", Length = "0xB4")]
	[Token(Token = "0x60003F3")]
	public static float2 cosh(float2 x) { }

	[Address(RVA = "0x2A2AE20", Offset = "0x2A2A220", Length = "0x120")]
	[Token(Token = "0x60003F4")]
	public static float3 cosh(float3 x) { }

	[Address(RVA = "0x2A2B0A0", Offset = "0x2A2A4A0", Length = "0x17C")]
	[Token(Token = "0x60003F5")]
	public static float4 cosh(float4 x) { }

	[Address(RVA = "0x2A2B2E0", Offset = "0x2A2A6E0", Length = "0x4E")]
	[Token(Token = "0x60003F6")]
	public static double cosh(double x) { }

	[Address(RVA = "0x2A2B220", Offset = "0x2A2A620", Length = "0xB8")]
	[Token(Token = "0x60003F7")]
	public static double2 cosh(double2 x) { }

	[Address(RVA = "0x2A2AD10", Offset = "0x2A2A110", Length = "0x108")]
	[Token(Token = "0x60003F8")]
	public static double3 cosh(double3 x) { }

	[Address(RVA = "0x2A2AF40", Offset = "0x2A2A340", Length = "0x15C")]
	[Token(Token = "0x60003F9")]
	public static double4 cosh(double4 x) { }

	[Address(RVA = "0x2A2ACB0", Offset = "0x2A2A0B0", Length = "0x57")]
	[Token(Token = "0x60003F2")]
	public static float cosh(float x) { }

	[Address(RVA = "0x2A2B4D0", Offset = "0x2A2A8D0", Length = "0x18")]
	[Token(Token = "0x600054F")]
	public static int2 countbits(int2 x) { }

	[Address(RVA = "0x2A2B330", Offset = "0x2A2A730", Length = "0x5A")]
	[Token(Token = "0x6000557")]
	public static int countbits(long x) { }

	[Address(RVA = "0x2A1CBD0", Offset = "0x2A1BFD0", Length = "0x1B0")]
	[Token(Token = "0x6000555")]
	public static int4 countbits(uint4 x) { }

	[Address(RVA = "0x2A2B390", Offset = "0x2A2A790", Length = "0x131")]
	[Token(Token = "0x6000554")]
	public static int3 countbits(uint3 x) { }

	[Address(RVA = "0x2A1CA30", Offset = "0x2A1BE30", Length = "0x19A")]
	[Token(Token = "0x6000553")]
	public static int2 countbits(uint2 x) { }

	[Address(RVA = "0x2A2B640", Offset = "0x2A2AA40", Length = "0x34")]
	[Token(Token = "0x6000552")]
	public static int countbits(uint x) { }

	[Address(RVA = "0x2A2B4F0", Offset = "0x2A2A8F0", Length = "0x60")]
	[Token(Token = "0x6000551")]
	public static int4 countbits(int4 x) { }

	[Address(RVA = "0x2A2B550", Offset = "0x2A2A950", Length = "0xEB")]
	[Token(Token = "0x6000550")]
	public static int3 countbits(int3 x) { }

	[Address(RVA = "0x2A2B330", Offset = "0x2A2A730", Length = "0x5A")]
	[Token(Token = "0x6000556")]
	public static int countbits(ulong x) { }

	[Address(RVA = "0x2A2B640", Offset = "0x2A2AA40", Length = "0x34")]
	[Token(Token = "0x600054E")]
	public static int countbits(int x) { }

	[Address(RVA = "0x2A2B6F0", Offset = "0x2A2AAF0", Length = "0x63")]
	[Token(Token = "0x60004DB")]
	public static double3 cross(double3 x, double3 y) { }

	[Address(RVA = "0x2A2B680", Offset = "0x2A2AA80", Length = "0x65")]
	[Token(Token = "0x60004DA")]
	public static float3 cross(float3 x, float3 y) { }

	[Address(RVA = "0x2A2B790", Offset = "0x2A2AB90", Length = "0xF")]
	[Token(Token = "0x60005D6")]
	public static double csum(double3 x) { }

	[Address(RVA = "0x2A2B7A0", Offset = "0x2A2ABA0", Length = "0xA")]
	[Token(Token = "0x60005D5")]
	public static double csum(double2 x) { }

	[Address(RVA = "0x2A2B7B0", Offset = "0x2A2ABB0", Length = "0x18")]
	[Token(Token = "0x60005D7")]
	public static double csum(double4 x) { }

	[Address(RVA = "0x2A2B760", Offset = "0x2A2AB60", Length = "0x18")]
	[Token(Token = "0x60005D4")]
	public static float csum(float4 x) { }

	[Address(RVA = "0x2A2B800", Offset = "0x2A2AC00", Length = "0xF")]
	[Token(Token = "0x60005D3")]
	public static float csum(float3 x) { }

	[Address(RVA = "0x2A2B7E0", Offset = "0x2A2ABE0", Length = "0x12")]
	[Token(Token = "0x60005D2")]
	public static float csum(float2 x) { }

	[Address(RVA = "0x672E70", Offset = "0x672270", Length = "0xC")]
	[Token(Token = "0x60005D1")]
	public static uint csum(uint4 x) { }

	[Address(RVA = "0x2A2B7D0", Offset = "0x2A2ABD0", Length = "0x9")]
	[Token(Token = "0x60005D0")]
	public static uint csum(uint3 x) { }

	[Address(RVA = "0x2A2B780", Offset = "0x2A2AB80", Length = "0xA")]
	[Token(Token = "0x60005CF")]
	public static uint csum(uint2 x) { }

	[Address(RVA = "0x672E70", Offset = "0x672270", Length = "0xC")]
	[Token(Token = "0x60005CE")]
	public static int csum(int4 x) { }

	[Address(RVA = "0x2A2B7D0", Offset = "0x2A2ABD0", Length = "0x9")]
	[Token(Token = "0x60005CD")]
	public static int csum(int3 x) { }

	[Address(RVA = "0x2A2B780", Offset = "0x2A2AB80", Length = "0xA")]
	[Token(Token = "0x60005CC")]
	public static int csum(int2 x) { }

	[Address(RVA = "0x2A2B810", Offset = "0x2A2AC10", Length = "0x15A")]
	[Token(Token = "0x6000023")]
	public static void decompose(AffineTransform a, out float3 translation, out quaternion rotation, out float3 scale) { }

	[Address(RVA = "0x2A2B9C0", Offset = "0x2A2ADC0", Length = "0x40")]
	[Token(Token = "0x60005B3")]
	public static double4 degrees(double4 x) { }

	[Address(RVA = "0x2A2BAE0", Offset = "0x2A2AEE0", Length = "0x27")]
	[Token(Token = "0x60005B1")]
	public static double2 degrees(double2 x) { }

	[Address(RVA = "0x2A2BA00", Offset = "0x2A2AE00", Length = "0x9")]
	[Token(Token = "0x60005B0")]
	public static double degrees(double x) { }

	[Address(RVA = "0x2A2BA40", Offset = "0x2A2AE40", Length = "0x5B")]
	[Token(Token = "0x60005AF")]
	public static float4 degrees(float4 x) { }

	[Address(RVA = "0x2A2BAA0", Offset = "0x2A2AEA0", Length = "0x3A")]
	[Token(Token = "0x60005AE")]
	public static float3 degrees(float3 x) { }

	[Address(RVA = "0x2A2BA10", Offset = "0x2A2AE10", Length = "0x2A")]
	[Token(Token = "0x60005AD")]
	public static float2 degrees(float2 x) { }

	[Address(RVA = "0x2A2B970", Offset = "0x2A2AD70", Length = "0x9")]
	[Token(Token = "0x60005AC")]
	public static float degrees(float x) { }

	[Address(RVA = "0x2A2B980", Offset = "0x2A2AD80", Length = "0x3B")]
	[Token(Token = "0x60005B2")]
	public static double3 degrees(double3 x) { }

	[Address(RVA = "0x2A2BB10", Offset = "0x2A2AF10", Length = "0x25F")]
	[Token(Token = "0x600014B")]
	public static double determinant(double4x4 m) { }

	[Address(RVA = "0x2A2C420", Offset = "0x2A2B820", Length = "0x26")]
	[Token(Token = "0x60000A3")]
	public static double determinant(double2x2 m) { }

	[Address(RVA = "0x2A2C2D0", Offset = "0x2A2B6D0", Length = "0xAB")]
	[Token(Token = "0x60001BF")]
	public static float determinant(float3x3 m) { }

	[Address(RVA = "0x2A2BD70", Offset = "0x2A2B170", Length = "0x10")]
	[Token(Token = "0x600025F")]
	public static int determinant(int2x2 m) { }

	[Address(RVA = "0x2A2C450", Offset = "0x2A2B850", Length = "0x18")]
	[Token(Token = "0x600016F")]
	public static float determinant(float2x2 m) { }

	[Address(RVA = "0x2A2BE40", Offset = "0x2A2B240", Length = "0x26E")]
	[Token(Token = "0x6000217")]
	public static float determinant(float4x4 m) { }

	[Address(RVA = "0x2A2C380", Offset = "0x2A2B780", Length = "0x9C")]
	[Token(Token = "0x60002AC")]
	public static int determinant(int3x3 m) { }

	[Address(RVA = "0x2A2C0B0", Offset = "0x2A2B4B0", Length = "0x21F")]
	[Token(Token = "0x60002FD")]
	public static int determinant(int4x4 m) { }

	[Address(RVA = "0x2A2BD80", Offset = "0x2A2B180", Length = "0xBB")]
	[Token(Token = "0x60000F3")]
	public static double determinant(double3x3 m) { }

	[Address(RVA = "0x2A2C720", Offset = "0x2A2BB20", Length = "0x11")]
	[Token(Token = "0x60004CA")]
	public static float distance(float x, float y) { }

	[Address(RVA = "0x2A2C760", Offset = "0x2A2BB60", Length = "0x3D")]
	[Token(Token = "0x60004CB")]
	public static float distance(float2 x, float2 y) { }

	[Address(RVA = "0x2A2C510", Offset = "0x2A2B910", Length = "0x4F")]
	[Token(Token = "0x60004CC")]
	public static float distance(float3 x, float3 y) { }

	[Address(RVA = "0x2A2C620", Offset = "0x2A2BA20", Length = "0x63")]
	[Token(Token = "0x60004CD")]
	public static float distance(float4 x, float4 y) { }

	[Address(RVA = "0x2A2C740", Offset = "0x2A2BB40", Length = "0x1C")]
	[Token(Token = "0x60004CE")]
	public static double distance(double x, double y) { }

	[Address(RVA = "0x2A2C690", Offset = "0x2A2BA90", Length = "0x8A")]
	[Token(Token = "0x60004CF")]
	public static double distance(double2 x, double2 y) { }

	[Address(RVA = "0x2A2C470", Offset = "0x2A2B870", Length = "0x9C")]
	[Token(Token = "0x60004D0")]
	public static double distance(double3 x, double3 y) { }

	[Address(RVA = "0x2A2C560", Offset = "0x2A2B960", Length = "0xB5")]
	[Token(Token = "0x60004D1")]
	public static double distance(double4 x, double4 y) { }

	[Address(RVA = "0x2A2C840", Offset = "0x2A2BC40", Length = "0x54")]
	[Token(Token = "0x60004D9")]
	public static double distancesq(double4 x, double4 y) { }

	[Address(RVA = "0x2A2C960", Offset = "0x2A2BD60", Length = "0x26")]
	[Token(Token = "0x60004D7")]
	public static double distancesq(double2 x, double2 y) { }

	[Address(RVA = "0x2A2C950", Offset = "0x2A2BD50", Length = "0xC")]
	[Token(Token = "0x60004D6")]
	public static double distancesq(double x, double y) { }

	[Address(RVA = "0x2A2C7A0", Offset = "0x2A2BBA0", Length = "0x35")]
	[Token(Token = "0x60004D3")]
	public static float distancesq(float2 x, float2 y) { }

	[Address(RVA = "0x2A2C900", Offset = "0x2A2BD00", Length = "0x49")]
	[Token(Token = "0x60004D4")]
	public static float distancesq(float3 x, float3 y) { }

	[Address(RVA = "0x2A2C8F0", Offset = "0x2A2BCF0", Length = "0xC")]
	[Token(Token = "0x60004D2")]
	public static float distancesq(float x, float y) { }

	[Address(RVA = "0x2A2C7E0", Offset = "0x2A2BBE0", Length = "0x5D")]
	[Token(Token = "0x60004D5")]
	public static float distancesq(float4 x, float4 y) { }

	[Address(RVA = "0x2A2C8A0", Offset = "0x2A2BCA0", Length = "0x43")]
	[Token(Token = "0x60004D8")]
	public static double distancesq(double3 x, double3 y) { }

	[Address(RVA = "0x2A2CA30", Offset = "0x2A2BE30", Length = "0x5")]
	[Token(Token = "0x60003C6")]
	public static double dot(double x, double y) { }

	[Address(RVA = "0x289BCD0", Offset = "0x289B0D0", Length = "0x17")]
	[Token(Token = "0x60003C7")]
	public static double dot(double2 x, double2 y) { }

	[Address(RVA = "0x2A2CA70", Offset = "0x2A2BE70", Length = "0x25")]
	[Token(Token = "0x60003C8")]
	public static double dot(double3 x, double3 y) { }

	[Address(RVA = "0x2A2C9A0", Offset = "0x2A2BDA0", Length = "0x33")]
	[Token(Token = "0x60003C9")]
	public static double dot(double4 x, double4 y) { }

	[Address(RVA = "0x2A2CAA0", Offset = "0x2A2BEA0", Length = "0x4D")]
	[Token(Token = "0x60006E9")]
	public static float dot(quaternion a, quaternion b) { }

	[Address(RVA = "0x1CE1880", Offset = "0x1CE0C80", Length = "0x33")]
	[Token(Token = "0x60003C5")]
	public static float dot(float4 x, float4 y) { }

	[Address(RVA = "0x2A2CAF0", Offset = "0x2A2BEF0", Length = "0x25")]
	[Token(Token = "0x60003C4")]
	public static float dot(float3 x, float3 y) { }

	[Address(RVA = "0x2A2CA60", Offset = "0x2A2BE60", Length = "0x5")]
	[Token(Token = "0x60003C2")]
	public static float dot(float x, float y) { }

	[Address(RVA = "0x2A2C9E0", Offset = "0x2A2BDE0", Length = "0x27")]
	[Token(Token = "0x60003C1")]
	public static uint dot(uint4 x, uint4 y) { }

	[Address(RVA = "0x2A2CA10", Offset = "0x2A2BE10", Length = "0x1B")]
	[Token(Token = "0x60003C0")]
	public static uint dot(uint3 x, uint3 y) { }

	[Address(RVA = "0x2A2CA40", Offset = "0x2A2BE40", Length = "0x18")]
	[Token(Token = "0x60003BF")]
	public static uint dot(uint2 x, uint2 y) { }

	[Address(RVA = "0x2A2CB20", Offset = "0x2A2BF20", Length = "0x2D")]
	[Token(Token = "0x60003C3")]
	public static float dot(float2 x, float2 y) { }

	[Address(RVA = "0x2A2C9E0", Offset = "0x2A2BDE0", Length = "0x27")]
	[Token(Token = "0x60003BD")]
	public static int dot(int4 x, int4 y) { }

	[Address(RVA = "0x2A2CA10", Offset = "0x2A2BE10", Length = "0x1B")]
	[Token(Token = "0x60003BC")]
	public static int dot(int3 x, int3 y) { }

	[Address(RVA = "0x2A2CA40", Offset = "0x2A2BE40", Length = "0x18")]
	[Token(Token = "0x60003BB")]
	public static int dot(int2 x, int2 y) { }

	[Address(RVA = "0x2A2C990", Offset = "0x2A2BD90", Length = "0x6")]
	[Token(Token = "0x60003BA")]
	public static int dot(int x, int y) { }

	[Address(RVA = "0x2A2C990", Offset = "0x2A2BD90", Length = "0x6")]
	[Token(Token = "0x60003BE")]
	public static uint dot(uint x, uint y) { }

	[Address(RVA = "0x2A2CE80", Offset = "0x2A2C280", Length = "0x1B")]
	[Token(Token = "0x6000085")]
	public static double2 double2(bool v) { }

	[Address(RVA = "0x2A2CC60", Offset = "0x2A2C060", Length = "0x24")]
	[Token(Token = "0x600008E")]
	public static double2 double2(float2 v) { }

	[Address(RVA = "0x2A2CD50", Offset = "0x2A2C150", Length = "0x18")]
	[Token(Token = "0x600008D")]
	public static double2 double2(float v) { }

	[Address(RVA = "0x2A2CD90", Offset = "0x2A2C190", Length = "0xE1")]
	[Token(Token = "0x600008C")]
	public static double2 double2(half2 v) { }

	[Address(RVA = "0x2A2CB50", Offset = "0x2A2BF50", Length = "0xD6")]
	[Token(Token = "0x600008B")]
	public static double2 double2(half v) { }

	[Address(RVA = "0x2A2CC30", Offset = "0x2A2C030", Length = "0x21")]
	[Token(Token = "0x6000089")]
	public static double2 double2(uint v) { }

	[Address(RVA = "0x2A2CCD0", Offset = "0x2A2C0D0", Length = "0x21")]
	[Token(Token = "0x6000088")]
	public static double2 double2(int2 v) { }

	[Address(RVA = "0x2A2CD30", Offset = "0x2A2C130", Length = "0x1D")]
	[Token(Token = "0x6000087")]
	public static double2 double2(int v) { }

	[Address(RVA = "0x2A2CC90", Offset = "0x2A2C090", Length = "0x32")]
	[Token(Token = "0x6000086")]
	public static double2 double2(bool2 v) { }

	[Address(RVA = "0x27F9D90", Offset = "0x27F9190", Length = "0xB")]
	[Token(Token = "0x6000084")]
	public static double2 double2(double v) { }

	[Address(RVA = "0x2A2CD00", Offset = "0x2A2C100", Length = "0x23")]
	[Token(Token = "0x600008A")]
	public static double2 double2(uint2 v) { }

	[Address(RVA = "0x27F9FA0", Offset = "0x27F93A0", Length = "0xD")]
	[Token(Token = "0x6000082")]
	public static double2 double2(double x, double y) { }

	[Address(RVA = "0x2A2CD70", Offset = "0x2A2C170", Length = "0x14")]
	[Token(Token = "0x6000083")]
	public static double2 double2(double2 xy) { }

	[Address(RVA = "0x2A2CFD0", Offset = "0x2A2C3D0", Length = "0x48")]
	[Token(Token = "0x60000A0")]
	public static double2x2 double2x2(float2x2 v) { }

	[Address(RVA = "0x2A2CEA0", Offset = "0x2A2C2A0", Length = "0x33")]
	[Token(Token = "0x600009F")]
	public static double2x2 double2x2(float v) { }

	[Address(RVA = "0x2A2D0C0", Offset = "0x2A2C4C0", Length = "0x68")]
	[Token(Token = "0x600009E")]
	public static double2x2 double2x2(uint2x2 v) { }

	[Address(RVA = "0x2A2CF70", Offset = "0x2A2C370", Length = "0x3F")]
	[Token(Token = "0x600009D")]
	public static double2x2 double2x2(uint v) { }

	[Address(RVA = "0x2A2D060", Offset = "0x2A2C460", Length = "0x5E")]
	[Token(Token = "0x600009C")]
	public static double2x2 double2x2(int2x2 v) { }

	[Address(RVA = "0x2A2D020", Offset = "0x2A2C420", Length = "0x37")]
	[Token(Token = "0x600009B")]
	public static double2x2 double2x2(int v) { }

	[Address(RVA = "0x2A2CEE0", Offset = "0x2A2C2E0", Length = "0x1C")]
	[Token(Token = "0x6000096")]
	public static double2x2 double2x2(double2 c0, double2 c1) { }

	[Address(RVA = "0x2A2CFB0", Offset = "0x2A2C3B0", Length = "0x1D")]
	[Token(Token = "0x6000097")]
	public static double2x2 double2x2(double m00, double m01, double m10, double m11) { }

	[Address(RVA = "0x2A2CF00", Offset = "0x2A2C300", Length = "0xF")]
	[Token(Token = "0x6000098")]
	public static double2x2 double2x2(double v) { }

	[Address(RVA = "0x2A2D130", Offset = "0x2A2C530", Length = "0x28")]
	[Token(Token = "0x6000099")]
	public static double2x2 double2x2(bool v) { }

	[Address(RVA = "0x2A2CF10", Offset = "0x2A2C310", Length = "0x58")]
	[Token(Token = "0x600009A")]
	public static double2x2 double2x2(bool2x2 v) { }

	[Address(RVA = "0x2A2D160", Offset = "0x2A2C560", Length = "0x5D")]
	[Token(Token = "0x60000AD")]
	public static double2x3 double2x3(uint v) { }

	[Address(RVA = "0x2A2D1C0", Offset = "0x2A2C5C0", Length = "0x4B")]
	[Token(Token = "0x60000AF")]
	public static double2x3 double2x3(float v) { }

	[Address(RVA = "0x2A2D340", Offset = "0x2A2C740", Length = "0xB2")]
	[Token(Token = "0x60000AE")]
	public static double2x3 double2x3(uint2x3 v) { }

	[Address(RVA = "0x2A2D230", Offset = "0x2A2C630", Length = "0x74")]
	[Token(Token = "0x60000B0")]
	public static double2x3 double2x3(float2x3 v) { }

	[Address(RVA = "0x2A2D4C0", Offset = "0x2A2C8C0", Length = "0xA6")]
	[Token(Token = "0x60000AC")]
	public static double2x3 double2x3(int2x3 v) { }

	[Address(RVA = "0x2A2D400", Offset = "0x2A2C800", Length = "0xB1")]
	[Token(Token = "0x60000AA")]
	public static double2x3 double2x3(bool2x3 v) { }

	[Address(RVA = "0x2A2D570", Offset = "0x2A2C970", Length = "0x33")]
	[Token(Token = "0x60000A7")]
	public static double2x3 double2x3(double m00, double m01, double m02, double m10, double m11, double m12) { }

	[Address(RVA = "0x2A2D210", Offset = "0x2A2C610", Length = "0x13")]
	[Token(Token = "0x60000A8")]
	public static double2x3 double2x3(double v) { }

	[Address(RVA = "0x2A2D2B0", Offset = "0x2A2C6B0", Length = "0x30")]
	[Token(Token = "0x60000A9")]
	public static double2x3 double2x3(bool v) { }

	[Address(RVA = "0x2A2D2E0", Offset = "0x2A2C6E0", Length = "0x51")]
	[Token(Token = "0x60000AB")]
	public static double2x3 double2x3(int v) { }

	[Address(RVA = "0x2A2D5B0", Offset = "0x2A2C9B0", Length = "0x2E")]
	[Token(Token = "0x60000A6")]
	public static double2x3 double2x3(double2 c0, double2 c1, double2 c2) { }

	[Address(RVA = "0x2A2DA90", Offset = "0x2A2CE90", Length = "0x6B")]
	[Token(Token = "0x60000B9")]
	public static double2x4 double2x4(int v) { }

	[Address(RVA = "0x2A2D750", Offset = "0x2A2CB50", Length = "0xB3")]
	[Token(Token = "0x60000B8")]
	public static double2x4 double2x4(bool2x4 v) { }

	[Address(RVA = "0x2A2D630", Offset = "0x2A2CA30", Length = "0x38")]
	[Token(Token = "0x60000B7")]
	public static double2x4 double2x4(bool v) { }

	[Address(RVA = "0x2A2D8E0", Offset = "0x2A2CCE0", Length = "0x17")]
	[Token(Token = "0x60000B6")]
	public static double2x4 double2x4(double v) { }

	[Address(RVA = "0x2A2DB00", Offset = "0x2A2CF00", Length = "0x49")]
	[Token(Token = "0x60000B5")]
	public static double2x4 double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13) { }

	[Address(RVA = "0x2A2D810", Offset = "0x2A2CC10", Length = "0xC8")]
	[Token(Token = "0x60000BA")]
	public static double2x4 double2x4(int2x4 v) { }

	[Address(RVA = "0x2A2D970", Offset = "0x2A2CD70", Length = "0x7B")]
	[Token(Token = "0x60000BB")]
	public static double2x4 double2x4(uint v) { }

	[Address(RVA = "0x2A2D670", Offset = "0x2A2CA70", Length = "0xDA")]
	[Token(Token = "0x60000BC")]
	public static double2x4 double2x4(uint2x4 v) { }

	[Address(RVA = "0x2A2D900", Offset = "0x2A2CD00", Length = "0x66")]
	[Token(Token = "0x60000BD")]
	public static double2x4 double2x4(float v) { }

	[Address(RVA = "0x2A2D9F0", Offset = "0x2A2CDF0", Length = "0x94")]
	[Token(Token = "0x60000BE")]
	public static double2x4 double2x4(float2x4 v) { }

	[Address(RVA = "0x2A2D5E0", Offset = "0x2A2C9E0", Length = "0x44")]
	[Token(Token = "0x60000B4")]
	public static double2x4 double2x4(double2 c0, double2 c1, double2 c2, double2 c3) { }

	[Address(RVA = "0x2A2DE80", Offset = "0x2A2D280", Length = "0x2A")]
	[Token(Token = "0x60000C9")]
	public static double3 double3(int v) { }

	[Address(RVA = "0x2A2E040", Offset = "0x2A2D440", Length = "0x3B")]
	[Token(Token = "0x60000D0")]
	public static double3 double3(float3 v) { }

	[Address(RVA = "0x2A2DB80", Offset = "0x2A2CF80", Length = "0x4E")]
	[Token(Token = "0x60000CA")]
	public static double3 double3(int3 v) { }

	[Address(RVA = "0x2A2DBD0", Offset = "0x2A2CFD0", Length = "0x14F")]
	[Token(Token = "0x60000CE")]
	public static double3 double3(half3 v) { }

	[Address(RVA = "0x2A2DD50", Offset = "0x2A2D150", Length = "0x12")]
	[Token(Token = "0x60000C2")]
	public static double3 double3(double x, double y, double z) { }

	[Address(RVA = "0x2A2DEB0", Offset = "0x2A2D2B0", Length = "0x1A")]
	[Token(Token = "0x60000C3")]
	public static double3 double3(double x, double2 yz) { }

	[Address(RVA = "0x2A2DDD0", Offset = "0x2A2D1D0", Length = "0x19")]
	[Token(Token = "0x60000C4")]
	public static double3 double3(double2 xy, double z) { }

	[Address(RVA = "0x2A2DB50", Offset = "0x2A2CF50", Length = "0x27")]
	[Token(Token = "0x60000CF")]
	public static double3 double3(float v) { }

	[Address(RVA = "0x2A2DD70", Offset = "0x2A2D170", Length = "0x10")]
	[Token(Token = "0x60000C6")]
	public static double3 double3(double v) { }

	[Address(RVA = "0x2A2DED0", Offset = "0x2A2D2D0", Length = "0x23")]
	[Token(Token = "0x60000C7")]
	public static double3 double3(bool v) { }

	[Address(RVA = "0x2A2DD80", Offset = "0x2A2D180", Length = "0x4D")]
	[Token(Token = "0x60000C8")]
	public static double3 double3(bool3 v) { }

	[Address(RVA = "0x2A2DF00", Offset = "0x2A2D300", Length = "0x132")]
	[Token(Token = "0x60000CD")]
	public static double3 double3(half v) { }

	[Address(RVA = "0x2A2DDF0", Offset = "0x2A2D1F0", Length = "0x52")]
	[Token(Token = "0x60000CC")]
	public static double3 double3(uint3 v) { }

	[Address(RVA = "0x2A2DD20", Offset = "0x2A2D120", Length = "0x30")]
	[Token(Token = "0x60000CB")]
	public static double3 double3(uint v) { }

	[Address(RVA = "0x2A2DE50", Offset = "0x2A2D250", Length = "0x26")]
	[Token(Token = "0x60000C5")]
	public static double3 double3(double3 xyz) { }

	[Address(RVA = "0x2A2E440", Offset = "0x2A2D840", Length = "0x42")]
	[Token(Token = "0x60000E1")]
	public static double3x2 double3x2(float v) { }

	[Address(RVA = "0x2A2E190", Offset = "0x2A2D590", Length = "0xA9")]
	[Token(Token = "0x60000E0")]
	public static double3x2 double3x2(uint3x2 v) { }

	[Address(RVA = "0x2A2E080", Offset = "0x2A2D480", Length = "0x61")]
	[Token(Token = "0x60000DF")]
	public static double3x2 double3x2(uint v) { }

	[Address(RVA = "0x2A2E360", Offset = "0x2A2D760", Length = "0x9D")]
	[Token(Token = "0x60000DE")]
	public static double3x2 double3x2(int3x2 v) { }

	[Address(RVA = "0x2A2E160", Offset = "0x2A2D560", Length = "0x2B")]
	[Token(Token = "0x60000DA")]
	public static double3x2 double3x2(double v) { }

	[Address(RVA = "0x2A2E2C0", Offset = "0x2A2D6C0", Length = "0x98")]
	[Token(Token = "0x60000DC")]
	public static double3x2 double3x2(bool3x2 v) { }

	[Address(RVA = "0x2A2E240", Offset = "0x2A2D640", Length = "0x71")]
	[Token(Token = "0x60000DB")]
	public static double3x2 double3x2(bool v) { }

	[Address(RVA = "0x2A2E400", Offset = "0x2A2D800", Length = "0x3A")]
	[Token(Token = "0x60000D9")]
	public static double3x2 double3x2(double m00, double m01, double m10, double m11, double m20, double m21) { }

	[Address(RVA = "0x2A2E4E0", Offset = "0x2A2D8E0", Length = "0x27")]
	[Token(Token = "0x60000D8")]
	public static double3x2 double3x2(double3 c0, double3 c1) { }

	[Address(RVA = "0x2A2E490", Offset = "0x2A2D890", Length = "0x47")]
	[Token(Token = "0x60000DD")]
	public static double3x2 double3x2(int v) { }

	[Address(RVA = "0x2A2E0F0", Offset = "0x2A2D4F0", Length = "0x6B")]
	[Token(Token = "0x60000E2")]
	public static double3x2 double3x2(float3x2 v) { }

	[Address(RVA = "0x2A2E9B0", Offset = "0x2A2DDB0", Length = "0x3A")]
	[Token(Token = "0x60000E6")]
	public static double3x3 double3x3(double3 c0, double3 c1, double3 c2) { }

	[Address(RVA = "0x2A2EAD0", Offset = "0x2A2DED0", Length = "0x3B")]
	[Token(Token = "0x60000E8")]
	public static double3x3 double3x3(double v) { }

	[Address(RVA = "0x2A2E920", Offset = "0x2A2DD20", Length = "0x83")]
	[Token(Token = "0x60000E9")]
	public static double3x3 double3x3(bool v) { }

	[Address(RVA = "0x2A2E570", Offset = "0x2A2D970", Length = "0xD7")]
	[Token(Token = "0x60000EA")]
	public static double3x3 double3x3(bool3x3 v) { }

	[Address(RVA = "0x2A2E8B0", Offset = "0x2A2DCB0", Length = "0x65")]
	[Token(Token = "0x60000EB")]
	public static double3x3 double3x3(int v) { }

	[Address(RVA = "0x2A2E7E0", Offset = "0x2A2DBE0", Length = "0xCF")]
	[Token(Token = "0x60000EC")]
	public static double3x3 double3x3(int3x3 v) { }

	[Address(RVA = "0x2A2E750", Offset = "0x2A2DB50", Length = "0x8C")]
	[Token(Token = "0x60000ED")]
	public static double3x3 double3x3(uint v) { }

	[Address(RVA = "0x2A2E9F0", Offset = "0x2A2DDF0", Length = "0xDF")]
	[Token(Token = "0x60000EE")]
	public static double3x3 double3x3(uint3x3 v) { }

	[Address(RVA = "0x2A2E510", Offset = "0x2A2D910", Length = "0x5C")]
	[Token(Token = "0x60000EF")]
	public static double3x3 double3x3(float v) { }

	[Address(RVA = "0x2A2E650", Offset = "0x2A2DA50", Length = "0x93")]
	[Token(Token = "0x60000F0")]
	public static double3x3 double3x3(float3x3 v) { }

	[Address(RVA = "0x2A2E6F0", Offset = "0x2A2DAF0", Length = "0x59")]
	[Token(Token = "0x60000E7")]
	public static double3x3 double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22) { }

	[Address(RVA = "0x2A2EBF0", Offset = "0x2A2DFF0", Length = "0x83")]
	[Token(Token = "0x60000FB")]
	public static double3x4 double3x4(int v) { }

	[Address(RVA = "0x2A2F120", Offset = "0x2A2E520", Length = "0x98")]
	[Token(Token = "0x60000F9")]
	public static double3x4 double3x4(bool v) { }

	[Address(RVA = "0x2A2EC80", Offset = "0x2A2E080", Length = "0xCB")]
	[Token(Token = "0x6000100")]
	public static double3x4 double3x4(float3x4 v) { }

	[Address(RVA = "0x2A2EEB0", Offset = "0x2A2E2B0", Length = "0x76")]
	[Token(Token = "0x60000FF")]
	public static double3x4 double3x4(float v) { }

	[Address(RVA = "0x2A2EE60", Offset = "0x2A2E260", Length = "0x50")]
	[Token(Token = "0x60000F6")]
	public static double3x4 double3x4(double3 c0, double3 c1, double3 c2, double3 c3) { }

	[Address(RVA = "0x2A2EB10", Offset = "0x2A2DF10", Length = "0x4B")]
	[Token(Token = "0x60000F8")]
	public static double3x4 double3x4(double v) { }

	[Address(RVA = "0x2A2EB60", Offset = "0x2A2DF60", Length = "0x81")]
	[Token(Token = "0x60000F7")]
	public static double3x4 double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23) { }

	[Address(RVA = "0x2A2ED50", Offset = "0x2A2E150", Length = "0x10E")]
	[Token(Token = "0x60000FC")]
	public static double3x4 double3x4(int3x4 v) { }

	[Address(RVA = "0x2A2EF30", Offset = "0x2A2E330", Length = "0xB7")]
	[Token(Token = "0x60000FD")]
	public static double3x4 double3x4(uint v) { }

	[Address(RVA = "0x2A2EFF0", Offset = "0x2A2E3F0", Length = "0x126")]
	[Token(Token = "0x60000FE")]
	public static double3x4 double3x4(uint3x4 v) { }

	[Address(RVA = "0x2A2F1C0", Offset = "0x2A2E5C0", Length = "0x11E")]
	[Token(Token = "0x60000FA")]
	public static double3x4 double3x4(bool3x4 v) { }

	[Address(RVA = "0x27F08A0", Offset = "0x27EFCA0", Length = "0x1D")]
	[Token(Token = "0x6000105")]
	public static double4 double4(double x, double y, double z, double w) { }

	[Address(RVA = "0x2A2F3A0", Offset = "0x2A2E7A0", Length = "0x1F")]
	[Token(Token = "0x6000106")]
	public static double4 double4(double x, double y, double2 zw) { }

	[Address(RVA = "0x2A2F630", Offset = "0x2A2EA30", Length = "0x2D")]
	[Token(Token = "0x6000108")]
	public static double4 double4(double x, double3 yzw) { }

	[Address(RVA = "0x2A2F6E0", Offset = "0x2A2EAE0", Length = "0x47")]
	[Token(Token = "0x6000111")]
	public static double4 double4(int4 v) { }

	[Address(RVA = "0x2A2F3E0", Offset = "0x2A2E7E0", Length = "0x15")]
	[Token(Token = "0x6000116")]
	public static double4 double4(float v) { }

	[Address(RVA = "0x2A2F2E0", Offset = "0x2A2E6E0", Length = "0x24")]
	[Token(Token = "0x6000115")]
	public static double4 double4(half4 v) { }

	[Address(RVA = "0x2A2F470", Offset = "0x2A2E870", Length = "0x18E")]
	[Token(Token = "0x6000114")]
	public static double4 double4(half v) { }

	[Address(RVA = "0x2A2F760", Offset = "0x2A2EB60", Length = "0x51")]
	[Token(Token = "0x6000113")]
	public static double4 double4(uint4 v) { }

	[Address(RVA = "0x2A2F730", Offset = "0x2A2EB30", Length = "0x2E")]
	[Token(Token = "0x6000112")]
	public static double4 double4(uint v) { }

	[Address(RVA = "0x2A2F430", Offset = "0x2A2E830", Length = "0x37")]
	[Token(Token = "0x6000110")]
	public static double4 double4(int v) { }

	[Address(RVA = "0x2A2F660", Offset = "0x2A2EA60", Length = "0x48")]
	[Token(Token = "0x6000117")]
	public static double4 double4(float4 v) { }

	[Address(RVA = "0x2A2F310", Offset = "0x2A2E710", Length = "0x5D")]
	[Token(Token = "0x600010F")]
	public static double4 double4(bool4 v) { }

	[Address(RVA = "0x2A2F6B0", Offset = "0x2A2EAB0", Length = "0x23")]
	[Token(Token = "0x600010E")]
	public static double4 double4(bool v) { }

	[Address(RVA = "0x2A2CF00", Offset = "0x2A2C300", Length = "0xF")]
	[Token(Token = "0x600010D")]
	public static double4 double4(double v) { }

	[Address(RVA = "0x2A2F370", Offset = "0x2A2E770", Length = "0x26")]
	[Token(Token = "0x600010C")]
	public static double4 double4(double4 xyzw) { }

	[Address(RVA = "0x2A2F400", Offset = "0x2A2E800", Length = "0x2B")]
	[Token(Token = "0x600010B")]
	public static double4 double4(double3 xyz, double w) { }

	[Address(RVA = "0x2A2F600", Offset = "0x2A2EA00", Length = "0x26")]
	[Token(Token = "0x600010A")]
	public static double4 double4(double2 xy, double2 zw) { }

	[Address(RVA = "0x2A2F7C0", Offset = "0x2A2EBC0", Length = "0x1E")]
	[Token(Token = "0x6000109")]
	public static double4 double4(double2 xy, double z, double w) { }

	[Address(RVA = "0x2A2F3C0", Offset = "0x2A2E7C0", Length = "0x1F")]
	[Token(Token = "0x6000107")]
	public static double4 double4(double x, double2 yz, double w) { }

	[Address(RVA = "0x2A2F7E0", Offset = "0x2A2EBE0", Length = "0x38")]
	[Token(Token = "0x6000128")]
	public static double4x2 double4x2(float v) { }

	[Address(RVA = "0x2A2FA30", Offset = "0x2A2EE30", Length = "0x88")]
	[Token(Token = "0x6000129")]
	public static double4x2 double4x2(float4x2 v) { }

	[Address(RVA = "0x2A2F820", Offset = "0x2A2EC20", Length = "0x23")]
	[Token(Token = "0x600011F")]
	public static double4x2 double4x2(double4 c0, double4 c1) { }

	[Address(RVA = "0x2A2FBC0", Offset = "0x2A2EFC0", Length = "0x9A")]
	[Token(Token = "0x6000127")]
	public static double4x2 double4x2(uint4x2 v) { }

	[Address(RVA = "0x2A2FAC0", Offset = "0x2A2EEC0", Length = "0x44")]
	[Token(Token = "0x6000120")]
	public static double4x2 double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31) { }

	[Address(RVA = "0x2A2F9B0", Offset = "0x2A2EDB0", Length = "0x73")]
	[Token(Token = "0x6000126")]
	public static double4x2 double4x2(uint v) { }

	[Address(RVA = "0x2A2F8E0", Offset = "0x2A2ECE0", Length = "0x2C")]
	[Token(Token = "0x6000121")]
	public static double4x2 double4x2(double v) { }

	[Address(RVA = "0x2A2F910", Offset = "0x2A2ED10", Length = "0x47")]
	[Token(Token = "0x6000124")]
	public static double4x2 double4x2(int v) { }

	[Address(RVA = "0x2A2FB10", Offset = "0x2A2EF10", Length = "0xA6")]
	[Token(Token = "0x6000123")]
	public static double4x2 double4x2(bool4x2 v) { }

	[Address(RVA = "0x2A2F960", Offset = "0x2A2ED60", Length = "0x41")]
	[Token(Token = "0x6000122")]
	public static double4x2 double4x2(bool v) { }

	[Address(RVA = "0x2A2F850", Offset = "0x2A2EC50", Length = "0x8A")]
	[Token(Token = "0x6000125")]
	public static double4x2 double4x2(int4x2 v) { }

	[Address(RVA = "0x2A2FFE0", Offset = "0x2A2F3E0", Length = "0x34")]
	[Token(Token = "0x600012D")]
	public static double4x3 double4x3(double4 c0, double4 c1, double4 c2) { }

	[Address(RVA = "0x2A2FED0", Offset = "0x2A2F2D0", Length = "0x92")]
	[Token(Token = "0x600012E")]
	public static double4x3 double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32) { }

	[Address(RVA = "0x2A30020", Offset = "0x2A2F420", Length = "0xAB")]
	[Token(Token = "0x6000134")]
	public static double4x3 double4x3(uint v) { }

	[Address(RVA = "0x2A2FD40", Offset = "0x2A2F140", Length = "0x45")]
	[Token(Token = "0x600012F")]
	public static double4x3 double4x3(double v) { }

	[Address(RVA = "0x2A2FD90", Offset = "0x2A2F190", Length = "0x135")]
	[Token(Token = "0x6000131")]
	public static double4x3 double4x3(bool4x3 v) { }

	[Address(RVA = "0x2A2FF70", Offset = "0x2A2F370", Length = "0x69")]
	[Token(Token = "0x6000132")]
	public static double4x3 double4x3(int v) { }

	[Address(RVA = "0x2A300D0", Offset = "0x2A2F4D0", Length = "0xCA")]
	[Token(Token = "0x6000133")]
	public static double4x3 double4x3(int4x3 v) { }

	[Address(RVA = "0x2A2FC60", Offset = "0x2A2F060", Length = "0xE0")]
	[Token(Token = "0x6000135")]
	public static double4x3 double4x3(uint4x3 v) { }

	[Address(RVA = "0x2A301A0", Offset = "0x2A2F5A0", Length = "0x59")]
	[Token(Token = "0x6000130")]
	public static double4x3 double4x3(bool v) { }

	[Address(RVA = "0x2A30260", Offset = "0x2A2F660", Length = "0xC7")]
	[Token(Token = "0x6000137")]
	public static double4x3 double4x3(float4x3 v) { }

	[Address(RVA = "0x2A30200", Offset = "0x2A2F600", Length = "0x57")]
	[Token(Token = "0x6000136")]
	public static double4x3 double4x3(float v) { }

	[Address(RVA = "0x2A30790", Offset = "0x2A2FB90", Length = "0x106")]
	[Token(Token = "0x6000145")]
	public static double4x4 double4x4(float4x4 v) { }

	[Address(RVA = "0x2A308A0", Offset = "0x2A2FCA0", Length = "0x73")]
	[Token(Token = "0x6000144")]
	public static double4x4 double4x4(float v) { }

	[Address(RVA = "0x2A30660", Offset = "0x2A2FA60", Length = "0x126")]
	[Token(Token = "0x6000143")]
	public static double4x4 double4x4(uint4x4 v) { }

	[Address(RVA = "0x2A30330", Offset = "0x2A2F730", Length = "0xE3")]
	[Token(Token = "0x6000142")]
	public static double4x4 double4x4(uint v) { }

	[Address(RVA = "0x2A30500", Offset = "0x2A2F900", Length = "0x10A")]
	[Token(Token = "0x6000141")]
	public static double4x4 double4x4(int4x4 v) { }

	[Address(RVA = "0x2A30920", Offset = "0x2A2FD20", Length = "0x49")]
	[Token(Token = "0x600013F")]
	public static double4x4 double4x4(bool4x4 v) { }

	[Address(RVA = "0x2A30480", Offset = "0x2A2F880", Length = "0x71")]
	[Token(Token = "0x600013E")]
	public static double4x4 double4x4(bool v) { }

	[Address(RVA = "0x2A30420", Offset = "0x2A2F820", Length = "0x5B")]
	[Token(Token = "0x600013D")]
	public static double4x4 double4x4(double v) { }

	[Address(RVA = "0x2A30A00", Offset = "0x2A2FE00", Length = "0xC6")]
	[Token(Token = "0x600013C")]
	public static double4x4 double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33) { }

	[Address(RVA = "0x2A30610", Offset = "0x2A2FA10", Length = "0x48")]
	[Token(Token = "0x600013B")]
	public static double4x4 double4x4(double4 c0, double4 c1, double4 c2, double4 c3) { }

	[Address(RVA = "0x2A30970", Offset = "0x2A2FD70", Length = "0x8B")]
	[Token(Token = "0x6000140")]
	public static double4x4 double4x4(int v) { }

	[Address(RVA = "0x2A30AD0", Offset = "0x2A2FED0", Length = "0x12")]
	[Token(Token = "0x60005FE")]
	public static float3 down() { }

	[Address(RVA = "0x2A24A60", Offset = "0x2A23E60", Length = "0x12C")]
	[Token(Token = "0x6000609")]
	public static float3 Euler(quaternion q, RotationOrder order = 4) { }

	[Address(RVA = "0x2A239D0", Offset = "0x2A22DD0", Length = "0x2E3")]
	[Token(Token = "0x6000603")]
	public static float3 EulerXYZ(quaternion q) { }

	[Address(RVA = "0x2A23CC0", Offset = "0x2A230C0", Length = "0x2B9")]
	[Token(Token = "0x6000604")]
	public static float3 EulerXZY(quaternion q) { }

	[Address(RVA = "0x2A23F80", Offset = "0x2A23380", Length = "0x2B8")]
	[Token(Token = "0x6000605")]
	public static float3 EulerYXZ(quaternion q) { }

	[Address(RVA = "0x2A24240", Offset = "0x2A23640", Length = "0x2B0")]
	[Token(Token = "0x6000606")]
	public static float3 EulerYZX(quaternion q) { }

	[Address(RVA = "0x2A244F0", Offset = "0x2A238F0", Length = "0x2B0")]
	[Token(Token = "0x6000607")]
	public static float3 EulerZXY(quaternion q) { }

	[Address(RVA = "0x2A247A0", Offset = "0x2A23BA0", Length = "0x2B8")]
	[Token(Token = "0x6000608")]
	public static float3 EulerZYX(quaternion q) { }

	[Address(RVA = "0x2A31B90", Offset = "0x2A30F90", Length = "0x1BB")]
	[Token(Token = "0x60006F0")]
	public static quaternion exp(quaternion q) { }

	[Address(RVA = "0x2A31F20", Offset = "0x2A31320", Length = "0xB4")]
	[Token(Token = "0x600045F")]
	public static float2 exp(float2 x) { }

	[Address(RVA = "0x2A32370", Offset = "0x2A31770", Length = "0x120")]
	[Token(Token = "0x6000460")]
	public static float3 exp(float3 x) { }

	[Address(RVA = "0x2A31DA0", Offset = "0x2A311A0", Length = "0x17C")]
	[Token(Token = "0x6000461")]
	public static float4 exp(float4 x) { }

	[Address(RVA = "0x2A31D50", Offset = "0x2A31150", Length = "0x4E")]
	[Token(Token = "0x6000462")]
	public static double exp(double x) { }

	[Address(RVA = "0x2A31FE0", Offset = "0x2A313E0", Length = "0xB8")]
	[Token(Token = "0x6000463")]
	public static double2 exp(double2 x) { }

	[Address(RVA = "0x2A320A0", Offset = "0x2A314A0", Length = "0x108")]
	[Token(Token = "0x6000464")]
	public static double3 exp(double3 x) { }

	[Address(RVA = "0x2A32210", Offset = "0x2A31610", Length = "0x15C")]
	[Token(Token = "0x6000465")]
	public static double4 exp(double4 x) { }

	[Address(RVA = "0x2A321B0", Offset = "0x2A315B0", Length = "0x57")]
	[Token(Token = "0x600045E")]
	public static float exp(float x) { }

	[Address(RVA = "0x2A30DF0", Offset = "0x2A301F0", Length = "0x197")]
	[Token(Token = "0x6000475")]
	public static double4 exp10(double4 x) { }

	[Address(RVA = "0x2A31140", Offset = "0x2A30540", Length = "0x56")]
	[Token(Token = "0x6000472")]
	public static double exp10(double x) { }

	[Address(RVA = "0x2A312E0", Offset = "0x2A306E0", Length = "0x5F")]
	[Token(Token = "0x600046E")]
	public static float exp10(float x) { }

	[Address(RVA = "0x2A30C40", Offset = "0x2A30040", Length = "0xC4")]
	[Token(Token = "0x600046F")]
	public static float2 exp10(float2 x) { }

	[Address(RVA = "0x2A30AF0", Offset = "0x2A2FEF0", Length = "0x14C")]
	[Token(Token = "0x6000470")]
	public static float3 exp10(float3 x) { }

	[Address(RVA = "0x2A30F90", Offset = "0x2A30390", Length = "0x1AD")]
	[Token(Token = "0x6000471")]
	public static float4 exp10(float4 x) { }

	[Address(RVA = "0x2A30D10", Offset = "0x2A30110", Length = "0xDC")]
	[Token(Token = "0x6000473")]
	public static double2 exp10(double2 x) { }

	[Address(RVA = "0x2A311A0", Offset = "0x2A305A0", Length = "0x13B")]
	[Token(Token = "0x6000474")]
	public static double3 exp10(double3 x) { }

	[Address(RVA = "0x2A31550", Offset = "0x2A30950", Length = "0xDC")]
	[Token(Token = "0x600046B")]
	public static double2 exp2(double2 x) { }

	[Address(RVA = "0x2A31770", Offset = "0x2A30B70", Length = "0x197")]
	[Token(Token = "0x600046D")]
	public static double4 exp2(double4 x) { }

	[Address(RVA = "0x2A319E0", Offset = "0x2A30DE0", Length = "0x1AD")]
	[Token(Token = "0x6000469")]
	public static float4 exp2(float4 x) { }

	[Address(RVA = "0x2A31340", Offset = "0x2A30740", Length = "0x14C")]
	[Token(Token = "0x6000468")]
	public static float3 exp2(float3 x) { }

	[Address(RVA = "0x2A31910", Offset = "0x2A30D10", Length = "0xC4")]
	[Token(Token = "0x6000467")]
	public static float2 exp2(float2 x) { }

	[Address(RVA = "0x2A31630", Offset = "0x2A30A30", Length = "0x13B")]
	[Token(Token = "0x600046C")]
	public static double3 exp2(double3 x) { }

	[Address(RVA = "0x2A314F0", Offset = "0x2A308F0", Length = "0x56")]
	[Token(Token = "0x600046A")]
	public static double exp2(double x) { }

	[Address(RVA = "0x2A31490", Offset = "0x2A30890", Length = "0x5F")]
	[Token(Token = "0x6000466")]
	public static float exp2(float x) { }

	[Address(RVA = "0x2A32490", Offset = "0x2A31890", Length = "0x5F")]
	[Token(Token = "0x60005EB")]
	public static float f16tof32(uint x) { }

	[Address(RVA = "0x2A328B0", Offset = "0x2A31CB0", Length = "0x24E")]
	[Token(Token = "0x60005EE")]
	public static float4 f16tof32(uint4 x) { }

	[Address(RVA = "0x2A324F0", Offset = "0x2A318F0", Length = "0x18A")]
	[Token(Token = "0x60005ED")]
	public static float3 f16tof32(uint3 x) { }

	[Address(RVA = "0x2A32680", Offset = "0x2A31A80", Length = "0x221")]
	[Token(Token = "0x60005EC")]
	public static float2 f16tof32(uint2 x) { }

	[Address(RVA = "0x2A32B00", Offset = "0x2A31F00", Length = "0x247")]
	[Token(Token = "0x60005F0")]
	public static uint2 f32tof16(float2 x) { }

	[Address(RVA = "0x2A32F20", Offset = "0x2A32320", Length = "0x2AD")]
	[Token(Token = "0x60005F2")]
	public static uint4 f32tof16(float4 x) { }

	[Address(RVA = "0x2A32D50", Offset = "0x2A32150", Length = "0x1CC")]
	[Token(Token = "0x60005F1")]
	public static uint3 f32tof16(float3 x) { }

	[Address(RVA = "0x2A1CD80", Offset = "0x2A1C180", Length = "0x79")]
	[Token(Token = "0x60005EF")]
	public static uint f32tof16(float x) { }

	[Address(RVA = "0x2A334F0", Offset = "0x2A328F0", Length = "0xDA")]
	[Token(Token = "0x6000545")]
	public static double4 faceforward(double4 n, double4 i, double4 ng) { }

	[Address(RVA = "0x2A33390", Offset = "0x2A32790", Length = "0xBC")]
	[Token(Token = "0x6000544")]
	public static double3 faceforward(double3 n, double3 i, double3 ng) { }

	[Address(RVA = "0x2A332A0", Offset = "0x2A326A0", Length = "0x62")]
	[Token(Token = "0x6000543")]
	public static double2 faceforward(double2 n, double2 i, double2 ng) { }

	[Address(RVA = "0x2A331D0", Offset = "0x2A325D0", Length = "0xCE")]
	[Token(Token = "0x6000542")]
	public static float4 faceforward(float4 n, float4 i, float4 ng) { }

	[Address(RVA = "0x2A33450", Offset = "0x2A32850", Length = "0x9C")]
	[Token(Token = "0x6000541")]
	public static float3 faceforward(float3 n, float3 i, float3 ng) { }

	[Address(RVA = "0x2A33310", Offset = "0x2A32710", Length = "0x79")]
	[Token(Token = "0x6000540")]
	public static float2 faceforward(float2 n, float2 i, float2 ng) { }

	[Address(RVA = "0x2A33E90", Offset = "0x2A33290", Length = "0x315")]
	[Token(Token = "0x600014A")]
	public static double4x4 fastinverse(double4x4 m) { }

	[Address(RVA = "0x2A34370", Offset = "0x2A33770", Length = "0x182")]
	[Token(Token = "0x6000102")]
	public static double3x4 fastinverse(double3x4 m) { }

	[Address(RVA = "0x2A335D0", Offset = "0x2A329D0", Length = "0x8B8")]
	[Token(Token = "0x6000216")]
	public static float4x4 fastinverse(float4x4 m) { }

	[Address(RVA = "0x2A341B0", Offset = "0x2A335B0", Length = "0x1B5")]
	[Token(Token = "0x60001CE")]
	public static float3x4 fastinverse(float3x4 m) { }

	[Address(RVA = "0x2A34590", Offset = "0x2A33990", Length = "0x9")]
	[Token(Token = "0x600014E")]
	public static float2 float2(float x, float y) { }

	[Address(RVA = "0x2A34710", Offset = "0x2A33B10", Length = "0x1A")]
	[Token(Token = "0x600014F")]
	public static float2 float2(float2 xy) { }

	[Address(RVA = "0x2A34810", Offset = "0x2A33C10", Length = "0xC")]
	[Token(Token = "0x6000150")]
	public static float2 float2(float v) { }

	[Address(RVA = "0x2A34550", Offset = "0x2A33950", Length = "0x3D")]
	[Token(Token = "0x6000152")]
	public static float2 float2(bool2 v) { }

	[Address(RVA = "0x2A345E0", Offset = "0x2A339E0", Length = "0x27")]
	[Token(Token = "0x6000156")]
	public static float2 float2(uint2 v) { }

	[Address(RVA = "0x2A34610", Offset = "0x2A33A10", Length = "0xC9")]
	[Token(Token = "0x6000158")]
	public static float2 float2(half2 v) { }

	[Address(RVA = "0x2A34730", Offset = "0x2A33B30", Length = "0xBD")]
	[Token(Token = "0x6000157")]
	public static float2 float2(half v) { }

	[Address(RVA = "0x2A34500", Offset = "0x2A33900", Length = "0x27")]
	[Token(Token = "0x6000151")]
	public static float2 float2(bool v) { }

	[Address(RVA = "0x2A346E0", Offset = "0x2A33AE0", Length = "0x25")]
	[Token(Token = "0x6000155")]
	public static float2 float2(uint v) { }

	[Address(RVA = "0x2A345C0", Offset = "0x2A339C0", Length = "0x1B")]
	[Token(Token = "0x6000154")]
	public static float2 float2(int2 v) { }

	[Address(RVA = "0x2A347F0", Offset = "0x2A33BF0", Length = "0x14")]
	[Token(Token = "0x6000159")]
	public static float2 float2(double v) { }

	[Address(RVA = "0x2A345A0", Offset = "0x2A339A0", Length = "0x17")]
	[Token(Token = "0x6000153")]
	public static float2 float2(int v) { }

	[Address(RVA = "0x2A34530", Offset = "0x2A33930", Length = "0x1B")]
	[Token(Token = "0x600015A")]
	public static float2 float2(double2 v) { }

	[Address(RVA = "0x2A349B0", Offset = "0x2A33DB0", Length = "0x33")]
	[Token(Token = "0x600016B")]
	public static float2x2 float2x2(double v) { }

	[Address(RVA = "0x2A34840", Offset = "0x2A33C40", Length = "0x78")]
	[Token(Token = "0x600016A")]
	public static float2x2 float2x2(uint2x2 v) { }

	[Address(RVA = "0x2A34960", Offset = "0x2A33D60", Length = "0x4F")]
	[Token(Token = "0x6000169")]
	public static float2x2 float2x2(uint v) { }

	[Address(RVA = "0x2A34A90", Offset = "0x2A33E90", Length = "0x58")]
	[Token(Token = "0x6000166")]
	public static float2x2 float2x2(bool2x2 v) { }

	[Address(RVA = "0x2A34A50", Offset = "0x2A33E50", Length = "0x3E")]
	[Token(Token = "0x6000165")]
	public static float2x2 float2x2(bool v) { }

	[Address(RVA = "0x27F4DE0", Offset = "0x27F41E0", Length = "0xB")]
	[Token(Token = "0x6000164")]
	public static float2x2 float2x2(float v) { }

	[Address(RVA = "0x2A34820", Offset = "0x2A33C20", Length = "0x1D")]
	[Token(Token = "0x6000163")]
	public static float2x2 float2x2(float m00, float m01, float m10, float m11) { }

	[Address(RVA = "0x2A348C0", Offset = "0x2A33CC0", Length = "0xB")]
	[Token(Token = "0x6000162")]
	public static float2x2 float2x2(float2 c0, float2 c1) { }

	[Address(RVA = "0x2A348D0", Offset = "0x2A33CD0", Length = "0x33")]
	[Token(Token = "0x6000167")]
	public static float2x2 float2x2(int v) { }

	[Address(RVA = "0x2A349F0", Offset = "0x2A33DF0", Length = "0x5A")]
	[Token(Token = "0x6000168")]
	public static float2x2 float2x2(int2x2 v) { }

	[Address(RVA = "0x2A34910", Offset = "0x2A33D10", Length = "0x4A")]
	[Token(Token = "0x600016C")]
	public static float2x2 float2x2(double2x2 v) { }

	[Address(RVA = "0x25DC8A0", Offset = "0x25DBCA0", Length = "0x81E")]
	[Token(Token = "0x6000172")]
	public static float2x3 float2x3(float2 c0, float2 c1, float2 c2) { }

	[Address(RVA = "0x2A34CB0", Offset = "0x2A340B0", Length = "0x33")]
	[Token(Token = "0x6000173")]
	public static float2x3 float2x3(float m00, float m01, float m02, float m10, float m11, float m12) { }

	[Address(RVA = "0x2A34AF0", Offset = "0x2A33EF0", Length = "0x15")]
	[Token(Token = "0x6000174")]
	public static float2x3 float2x3(float v) { }

	[Address(RVA = "0x2A34BE0", Offset = "0x2A33FE0", Length = "0x52")]
	[Token(Token = "0x6000175")]
	public static float2x3 float2x3(bool v) { }

	[Address(RVA = "0x2A34CF0", Offset = "0x2A340F0", Length = "0xB1")]
	[Token(Token = "0x6000176")]
	public static float2x3 float2x3(bool2x3 v) { }

	[Address(RVA = "0x2A34E80", Offset = "0x2A34280", Length = "0x4B")]
	[Token(Token = "0x6000177")]
	public static float2x3 float2x3(int v) { }

	[Address(RVA = "0x2A34C40", Offset = "0x2A34040", Length = "0x6A")]
	[Token(Token = "0x600017C")]
	public static float2x3 float2x3(double2x3 v) { }

	[Address(RVA = "0x2A34B10", Offset = "0x2A33F10", Length = "0x4B")]
	[Token(Token = "0x600017B")]
	public static float2x3 float2x3(double v) { }

	[Address(RVA = "0x2A34DB0", Offset = "0x2A341B0", Length = "0xCD")]
	[Token(Token = "0x600017A")]
	public static float2x3 float2x3(uint2x3 v) { }

	[Address(RVA = "0x2A34B60", Offset = "0x2A33F60", Length = "0x75")]
	[Token(Token = "0x6000179")]
	public static float2x3 float2x3(uint v) { }

	[Address(RVA = "0x2A34ED0", Offset = "0x2A342D0", Length = "0xA0")]
	[Token(Token = "0x6000178")]
	public static float2x3 float2x3(int2x3 v) { }

	[Address(RVA = "0x2A34F90", Offset = "0x2A34390", Length = "0x45")]
	[Token(Token = "0x6000183")]
	public static float2x4 float2x4(bool v) { }

	[Address(RVA = "0x2A35070", Offset = "0x2A34470", Length = "0xB3")]
	[Token(Token = "0x6000184")]
	public static float2x4 float2x4(bool2x4 v) { }

	[Address(RVA = "0x2A35290", Offset = "0x2A34690", Length = "0xF")]
	[Token(Token = "0x6000182")]
	public static float2x4 float2x4(float v) { }

	[Address(RVA = "0x2A34F70", Offset = "0x2A34370", Length = "0x1A")]
	[Token(Token = "0x6000180")]
	public static float2x4 float2x4(float2 c0, float2 c1, float2 c2, float2 c3) { }

	[Address(RVA = "0x2A34FE0", Offset = "0x2A343E0", Length = "0x8A")]
	[Token(Token = "0x600018A")]
	public static float2x4 float2x4(double2x4 v) { }

	[Address(RVA = "0x2A352A0", Offset = "0x2A346A0", Length = "0x66")]
	[Token(Token = "0x6000189")]
	public static float2x4 float2x4(double v) { }

	[Address(RVA = "0x2A35310", Offset = "0x2A34710", Length = "0xFA")]
	[Token(Token = "0x6000188")]
	public static float2x4 float2x4(uint2x4 v) { }

	[Address(RVA = "0x2A35130", Offset = "0x2A34530", Length = "0x9B")]
	[Token(Token = "0x6000187")]
	public static float2x4 float2x4(uint v) { }

	[Address(RVA = "0x2A35410", Offset = "0x2A34810", Length = "0xC0")]
	[Token(Token = "0x6000186")]
	public static float2x4 float2x4(int2x4 v) { }

	[Address(RVA = "0x2A35220", Offset = "0x2A34620", Length = "0x63")]
	[Token(Token = "0x6000185")]
	public static float2x4 float2x4(int v) { }

	[Address(RVA = "0x2A351D0", Offset = "0x2A345D0", Length = "0x49")]
	[Token(Token = "0x6000181")]
	public static float2x4 float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13) { }

	[Address(RVA = "0x2A35820", Offset = "0x2A34C20", Length = "0x23")]
	[Token(Token = "0x6000190")]
	public static float3 float3(float2 xy, float z) { }

	[Address(RVA = "0x2A356C0", Offset = "0x2A34AC0", Length = "0x12")]
	[Token(Token = "0x600018E")]
	public static float3 float3(float x, float y, float z) { }

	[Address(RVA = "0x2A35850", Offset = "0x2A34C50", Length = "0x2A")]
	[Token(Token = "0x6000191")]
	public static float3 float3(float3 xyz) { }

	[Address(RVA = "0x2A359F0", Offset = "0x2A34DF0", Length = "0x12")]
	[Token(Token = "0x6000192")]
	public static float3 float3(float v) { }

	[Address(RVA = "0x2A354D0", Offset = "0x2A348D0", Length = "0x30")]
	[Token(Token = "0x6000193")]
	public static float3 float3(bool v) { }

	[Address(RVA = "0x2A359A0", Offset = "0x2A34DA0", Length = "0x4D")]
	[Token(Token = "0x6000194")]
	public static float3 float3(bool3 v) { }

	[Address(RVA = "0x2A35540", Offset = "0x2A34940", Length = "0x27")]
	[Token(Token = "0x6000195")]
	public static float3 float3(int v) { }

	[Address(RVA = "0x2A358E0", Offset = "0x2A34CE0", Length = "0x23")]
	[Token(Token = "0x600018F")]
	public static float3 float3(float x, float2 yz) { }

	[Address(RVA = "0x2A35690", Offset = "0x2A34A90", Length = "0x27")]
	[Token(Token = "0x600019B")]
	public static float3 float3(double v) { }

	[Address(RVA = "0x2A35880", Offset = "0x2A34C80", Length = "0x5E")]
	[Token(Token = "0x6000198")]
	public static float3 float3(uint3 v) { }

	[Address(RVA = "0x2A35910", Offset = "0x2A34D10", Length = "0x3C")]
	[Token(Token = "0x6000197")]
	public static float3 float3(uint v) { }

	[Address(RVA = "0x2A35500", Offset = "0x2A34900", Length = "0x38")]
	[Token(Token = "0x600019C")]
	public static float3 float3(double3 v) { }

	[Address(RVA = "0x2A35950", Offset = "0x2A34D50", Length = "0x4B")]
	[Token(Token = "0x6000196")]
	public static float3 float3(int3 v) { }

	[Address(RVA = "0x2A35570", Offset = "0x2A34970", Length = "0x117")]
	[Token(Token = "0x6000199")]
	public static float3 float3(half v) { }

	[Address(RVA = "0x2A356E0", Offset = "0x2A34AE0", Length = "0x134")]
	[Token(Token = "0x600019A")]
	public static float3 float3(half3 v) { }

	[Address(RVA = "0x2A35CD0", Offset = "0x2A350D0", Length = "0x23")]
	[Token(Token = "0x60001A4")]
	public static float3x2 float3x2(float3 c0, float3 c1) { }

	[Address(RVA = "0x2A35D00", Offset = "0x2A35100", Length = "0x32")]
	[Token(Token = "0x60001A5")]
	public static float3x2 float3x2(float m00, float m01, float m10, float m11, float m20, float m21) { }

	[Address(RVA = "0x2A35E50", Offset = "0x2A35250", Length = "0x23")]
	[Token(Token = "0x60001A6")]
	public static float3x2 float3x2(float v) { }

	[Address(RVA = "0x2A35DC0", Offset = "0x2A351C0", Length = "0x90")]
	[Token(Token = "0x60001A8")]
	public static float3x2 float3x2(bool3x2 v) { }

	[Address(RVA = "0x2A35B90", Offset = "0x2A34F90", Length = "0x47")]
	[Token(Token = "0x60001A9")]
	public static float3x2 float3x2(int v) { }

	[Address(RVA = "0x2A35C30", Offset = "0x2A35030", Length = "0x91")]
	[Token(Token = "0x60001AA")]
	public static float3x2 float3x2(int3x2 v) { }

	[Address(RVA = "0x2A35D40", Offset = "0x2A35140", Length = "0x71")]
	[Token(Token = "0x60001AB")]
	public static float3x2 float3x2(uint v) { }

	[Address(RVA = "0x2A35A70", Offset = "0x2A34E70", Length = "0xBB")]
	[Token(Token = "0x60001AC")]
	public static float3x2 float3x2(uint3x2 v) { }

	[Address(RVA = "0x2A35BE0", Offset = "0x2A34FE0", Length = "0x4A")]
	[Token(Token = "0x60001AD")]
	public static float3x2 float3x2(double v) { }

	[Address(RVA = "0x2A35A10", Offset = "0x2A34E10", Length = "0x5E")]
	[Token(Token = "0x60001AE")]
	public static float3x2 float3x2(double3x2 v) { }

	[Address(RVA = "0x2A35B30", Offset = "0x2A34F30", Length = "0x59")]
	[Token(Token = "0x60001A7")]
	public static float3x2 float3x2(bool v) { }

	[Address(RVA = "0x2A36310", Offset = "0x2A35710", Length = "0xA8")]
	[Token(Token = "0x60001B9")]
	public static float3x3 float3x3(uint v) { }

	[Address(RVA = "0x2A35F40", Offset = "0x2A35340", Length = "0x90")]
	[Token(Token = "0x60001BC")]
	public static float3x3 float3x3(double3x3 v) { }

	[Address(RVA = "0x2A361D0", Offset = "0x2A355D0", Length = "0x36")]
	[Token(Token = "0x6000619")]
	public static float3x3 float3x3(quaternion rotation) { }

	[Address(RVA = "0x2A36090", Offset = "0x2A35490", Length = "0x51")]
	[Token(Token = "0x6000618")]
	public static float3x3 float3x3(float4x4 f4x4) { }

	[Address(RVA = "0x2A36160", Offset = "0x2A35560", Length = "0x69")]
	[Token(Token = "0x60001B7")]
	public static float3x3 float3x3(int v) { }

	[Address(RVA = "0x2A36470", Offset = "0x2A35870", Length = "0xD7")]
	[Token(Token = "0x60001B6")]
	public static float3x3 float3x3(bool3x3 v) { }

	[Address(RVA = "0x2A35E80", Offset = "0x2A35280", Length = "0x79")]
	[Token(Token = "0x60001B5")]
	public static float3x3 float3x3(bool v) { }

	[Address(RVA = "0x2A35F00", Offset = "0x2A35300", Length = "0x33")]
	[Token(Token = "0x60001B4")]
	public static float3x3 float3x3(float v) { }

	[Address(RVA = "0x2A360F0", Offset = "0x2A354F0", Length = "0x61")]
	[Token(Token = "0x60001B3")]
	public static float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) { }

	[Address(RVA = "0x2A363C0", Offset = "0x2A357C0", Length = "0x34")]
	[Token(Token = "0x60001B2")]
	public static float3x3 float3x3(float3 c0, float3 c1, float3 c2) { }

	[Address(RVA = "0x2A36210", Offset = "0x2A35610", Length = "0xFD")]
	[Token(Token = "0x60001BA")]
	public static float3x3 float3x3(uint3x3 v) { }

	[Address(RVA = "0x2A35FD0", Offset = "0x2A353D0", Length = "0xC0")]
	[Token(Token = "0x60001B8")]
	public static float3x3 float3x3(int3x3 v) { }

	[Address(RVA = "0x2A36400", Offset = "0x2A35800", Length = "0x6C")]
	[Token(Token = "0x60001BB")]
	public static float3x3 float3x3(double v) { }

	[Address(RVA = "0x2A368B0", Offset = "0x2A35CB0", Length = "0xFC")]
	[Token(Token = "0x60001C8")]
	public static float3x4 float3x4(int3x4 v) { }

	[Address(RVA = "0x2A36C10", Offset = "0x2A36010", Length = "0x48")]
	[Token(Token = "0x60001C2")]
	public static float3x4 float3x4(float3 c0, float3 c1, float3 c2, float3 c3) { }

	[Address(RVA = "0x2A36D40", Offset = "0x2A36140", Length = "0x83")]
	[Token(Token = "0x60001C3")]
	public static float3x4 float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23) { }

	[Address(RVA = "0x2A369B0", Offset = "0x2A35DB0", Length = "0x43")]
	[Token(Token = "0x60001C4")]
	public static float3x4 float3x4(float v) { }

	[Address(RVA = "0x2A367A0", Offset = "0x2A35BA0", Length = "0x79")]
	[Token(Token = "0x600001B")]
	public static float3x4 float3x4(AffineTransform transform) { }

	[Address(RVA = "0x2A365E0", Offset = "0x2A359E0", Length = "0x11E")]
	[Token(Token = "0x60001C6")]
	public static float3x4 float3x4(bool3x4 v) { }

	[Address(RVA = "0x2A36A00", Offset = "0x2A35E00", Length = "0xBB")]
	[Token(Token = "0x60001CC")]
	public static float3x4 float3x4(double3x4 v) { }

	[Address(RVA = "0x2A36700", Offset = "0x2A35B00", Length = "0x99")]
	[Token(Token = "0x60001C5")]
	public static float3x4 float3x4(bool v) { }

	[Address(RVA = "0x2A36550", Offset = "0x2A35950", Length = "0x8E")]
	[Token(Token = "0x60001CB")]
	public static float3x4 float3x4(double v) { }

	[Address(RVA = "0x2A36AC0", Offset = "0x2A35EC0", Length = "0x150")]
	[Token(Token = "0x60001CA")]
	public static float3x4 float3x4(uint3x4 v) { }

	[Address(RVA = "0x2A36C60", Offset = "0x2A36060", Length = "0xDF")]
	[Token(Token = "0x60001C9")]
	public static float3x4 float3x4(uint v) { }

	[Address(RVA = "0x2A36820", Offset = "0x2A35C20", Length = "0x8B")]
	[Token(Token = "0x60001C7")]
	public static float3x4 float3x4(int v) { }

	[Address(RVA = "0x2A372A0", Offset = "0x2A366A0", Length = "0x1B")]
	[Token(Token = "0x60001DA")]
	public static float4 float4(bool v) { }

	[Address(RVA = "0x2A37040", Offset = "0x2A36440", Length = "0x16A")]
	[Token(Token = "0x60001E0")]
	public static float4 float4(half v) { }

	[Address(RVA = "0x2A36E80", Offset = "0x2A36280", Length = "0x18B")]
	[Token(Token = "0x60001E1")]
	public static float4 float4(half4 v) { }

	[Address(RVA = "0x2A371E0", Offset = "0x2A365E0", Length = "0x16")]
	[Token(Token = "0x60001E2")]
	public static float4 float4(double v) { }

	[Address(RVA = "0x2A37370", Offset = "0x2A36770", Length = "0x61")]
	[Token(Token = "0x60001DF")]
	public static float4 float4(uint4 v) { }

	[Address(RVA = "0x2A34960", Offset = "0x2A33D60", Length = "0x4F")]
	[Token(Token = "0x60001DE")]
	public static float4 float4(uint v) { }

	[Address(RVA = "0x2A37250", Offset = "0x2A36650", Length = "0x43")]
	[Token(Token = "0x60001DD")]
	public static float4 float4(int4 v) { }

	[Address(RVA = "0x2A37200", Offset = "0x2A36600", Length = "0x13")]
	[Token(Token = "0x60001DC")]
	public static float4 float4(int v) { }

	[Address(RVA = "0x2A36DD0", Offset = "0x2A361D0", Length = "0x42")]
	[Token(Token = "0x60001E3")]
	public static float4 float4(double4 v) { }

	[Address(RVA = "0x2A36E20", Offset = "0x2A36220", Length = "0x5D")]
	[Token(Token = "0x60001DB")]
	public static float4 float4(bool4 v) { }

	[Address(RVA = "0x27F4DE0", Offset = "0x27F41E0", Length = "0xB")]
	[Token(Token = "0x60001D9")]
	public static float4 float4(float v) { }

	[Address(RVA = "0x2A371B0", Offset = "0x2A365B0", Length = "0x28")]
	[Token(Token = "0x60001D5")]
	public static float4 float4(float2 xy, float z, float w) { }

	[Address(RVA = "0x2A37300", Offset = "0x2A36700", Length = "0x2F")]
	[Token(Token = "0x60001D7")]
	public static float4 float4(float3 xyz, float w) { }

	[Address(RVA = "0x2A37330", Offset = "0x2A36730", Length = "0x3F")]
	[Token(Token = "0x60001D6")]
	public static float4 float4(float2 xy, float2 zw) { }

	[Address(RVA = "0x2A372C0", Offset = "0x2A366C0", Length = "0x31")]
	[Token(Token = "0x60001D4")]
	public static float4 float4(float x, float3 yzw) { }

	[Address(RVA = "0x2A37220", Offset = "0x2A36620", Length = "0x28")]
	[Token(Token = "0x60001D3")]
	public static float4 float4(float x, float2 yz, float w) { }

	[Address(RVA = "0x2A37010", Offset = "0x2A36410", Length = "0x28")]
	[Token(Token = "0x60001D2")]
	public static float4 float4(float x, float y, float2 zw) { }

	[Address(RVA = "0x27F4E50", Offset = "0x27F4250", Length = "0x1D")]
	[Token(Token = "0x60001D1")]
	public static float4 float4(float x, float y, float z, float w) { }

	[Address(RVA = "0x2A373E0", Offset = "0x2A367E0", Length = "0x2C")]
	[Token(Token = "0x60001D8")]
	public static float4 float4(float4 xyzw) { }

	[Address(RVA = "0x2A378A0", Offset = "0x2A36CA0", Length = "0xCE")]
	[Token(Token = "0x60001EF")]
	public static float4x2 float4x2(bool4x2 v) { }

	[Address(RVA = "0x2A37870", Offset = "0x2A36C70", Length = "0x25")]
	[Token(Token = "0x60001EE")]
	public static float4x2 float4x2(bool v) { }

	[Address(RVA = "0x2A37580", Offset = "0x2A36980", Length = "0x22")]
	[Token(Token = "0x60001ED")]
	public static float4x2 float4x2(float v) { }

	[Address(RVA = "0x2A37710", Offset = "0x2A36B10", Length = "0x6C")]
	[Token(Token = "0x60001EC")]
	public static float4x2 float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31) { }

	[Address(RVA = "0x2A37410", Offset = "0x2A36810", Length = "0x86")]
	[Token(Token = "0x60001F4")]
	public static float4x2 float4x2(double v) { }

	[Address(RVA = "0x2A375B0", Offset = "0x2A369B0", Length = "0xA2")]
	[Token(Token = "0x60001F5")]
	public static float4x2 float4x2(double4x2 v) { }

	[Address(RVA = "0x2A374A0", Offset = "0x2A368A0", Length = "0xD8")]
	[Token(Token = "0x60001F3")]
	public static float4x2 float4x2(uint4x2 v) { }

	[Address(RVA = "0x2A377B0", Offset = "0x2A36BB0", Length = "0xBB")]
	[Token(Token = "0x60001F2")]
	public static float4x2 float4x2(uint v) { }

	[Address(RVA = "0x27F0880", Offset = "0x27EFC80", Length = "0x12")]
	[Token(Token = "0x60001EB")]
	public static float4x2 float4x2(float4 c0, float4 c1) { }

	[Address(RVA = "0x2A37780", Offset = "0x2A36B80", Length = "0x23")]
	[Token(Token = "0x60001F0")]
	public static float4x2 float4x2(int v) { }

	[Address(RVA = "0x2A37660", Offset = "0x2A36A60", Length = "0xA2")]
	[Token(Token = "0x60001F1")]
	public static float4x2 float4x2(int4x2 v) { }

	[Address(RVA = "0x2A37DD0", Offset = "0x2A371D0", Length = "0x13D")]
	[Token(Token = "0x6000201")]
	public static float4x3 float4x3(uint4x3 v) { }

	[Address(RVA = "0x2A37FD0", Offset = "0x2A373D0", Length = "0x2A")]
	[Token(Token = "0x60001FB")]
	public static float4x3 float4x3(float v) { }

	[Address(RVA = "0x2A38000", Offset = "0x2A37400", Length = "0x34")]
	[Token(Token = "0x60001FC")]
	public static float4x3 float4x3(bool v) { }

	[Address(RVA = "0x2A37C60", Offset = "0x2A37060", Length = "0x16A")]
	[Token(Token = "0x60001FD")]
	public static float4x3 float4x3(bool4x3 v) { }

	[Address(RVA = "0x2A38040", Offset = "0x2A37440", Length = "0x33")]
	[Token(Token = "0x60001FE")]
	public static float4x3 float4x3(int v) { }

	[Address(RVA = "0x2A38080", Offset = "0x2A37480", Length = "0xEE")]
	[Token(Token = "0x60001FF")]
	public static float4x3 float4x3(int4x3 v) { }

	[Address(RVA = "0x2A37B40", Offset = "0x2A36F40", Length = "0x113")]
	[Token(Token = "0x6000200")]
	public static float4x3 float4x3(uint v) { }

	[Address(RVA = "0x2A37A70", Offset = "0x2A36E70", Length = "0xC2")]
	[Token(Token = "0x6000202")]
	public static float4x3 float4x3(double v) { }

	[Address(RVA = "0x2A37970", Offset = "0x2A36D70", Length = "0xF4")]
	[Token(Token = "0x6000203")]
	public static float4x3 float4x3(double4x3 v) { }

	[Address(RVA = "0x2A37F10", Offset = "0x2A37310", Length = "0xB7")]
	[Token(Token = "0x60001FA")]
	public static float4x3 float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32) { }

	[Address(RVA = "0x2A38170", Offset = "0x2A37570", Length = "0x1A")]
	[Token(Token = "0x60001F9")]
	public static float4x3 float4x3(float4 c0, float4 c1, float4 c2) { }

	[Address(RVA = "0x2A386D0", Offset = "0x2A37AD0", Length = "0x26")]
	[Token(Token = "0x6000207")]
	public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3) { }

	[Address(RVA = "0x2A38190", Offset = "0x2A37590", Length = "0xFB")]
	[Token(Token = "0x6000208")]
	public static float4x4 float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) { }

	[Address(RVA = "0x2A38640", Offset = "0x2A37A40", Length = "0x32")]
	[Token(Token = "0x6000209")]
	public static float4x4 float4x4(float v) { }

	[Address(RVA = "0x2A38850", Offset = "0x2A37C50", Length = "0x159")]
	[Token(Token = "0x600001A")]
	public static float4x4 float4x4(AffineTransform transform) { }

	[Address(RVA = "0x2A38680", Offset = "0x2A37A80", Length = "0x4B")]
	[Token(Token = "0x600061C")]
	public static float4x4 float4x4(RigidTransform transform) { }

	[Address(RVA = "0x2A38B20", Offset = "0x2A37F20", Length = "0x51")]
	[Token(Token = "0x600061B")]
	public static float4x4 float4x4(quaternion rotation, float3 translation) { }

	[Address(RVA = "0x2A38A10", Offset = "0x2A37E10", Length = "0x61")]
	[Token(Token = "0x600061A")]
	public static float4x4 float4x4(float3x3 rotation, float3 translation) { }

	[Address(RVA = "0x2A38B80", Offset = "0x2A37F80", Length = "0x39")]
	[Token(Token = "0x600020B")]
	public static float4x4 float4x4(bool4x4 v) { }

	[Address(RVA = "0x2A38400", Offset = "0x2A37800", Length = "0x140")]
	[Token(Token = "0x600020D")]
	public static float4x4 float4x4(int4x4 v) { }

	[Address(RVA = "0x2A38290", Offset = "0x2A37690", Length = "0x16B")]
	[Token(Token = "0x600020E")]
	public static float4x4 float4x4(uint v) { }

	[Address(RVA = "0x2A38700", Offset = "0x2A37B00", Length = "0x148")]
	[Token(Token = "0x6000211")]
	public static float4x4 float4x4(double4x4 v) { }

	[Address(RVA = "0x2A38540", Offset = "0x2A37940", Length = "0xFE")]
	[Token(Token = "0x6000210")]
	public static float4x4 float4x4(double v) { }

	[Address(RVA = "0x2A389B0", Offset = "0x2A37DB0", Length = "0x54")]
	[Token(Token = "0x600020F")]
	public static float4x4 float4x4(uint4x4 v) { }

	[Address(RVA = "0x2A38AD0", Offset = "0x2A37ED0", Length = "0x43")]
	[Token(Token = "0x600020C")]
	public static float4x4 float4x4(int v) { }

	[Address(RVA = "0x2A38A80", Offset = "0x2A37E80", Length = "0x43")]
	[Token(Token = "0x600020A")]
	public static float4x4 float4x4(bool v) { }

	[Address(RVA = "0x2A38BC0", Offset = "0x2A37FC0", Length = "0x57")]
	[Token(Token = "0x600041A")]
	public static float floor(float x) { }

	[Address(RVA = "0x2A1CF80", Offset = "0x2A1C380", Length = "0x120")]
	[Token(Token = "0x600041C")]
	public static float3 floor(float3 x) { }

	[Address(RVA = "0x2A1CE00", Offset = "0x2A1C200", Length = "0x17C")]
	[Token(Token = "0x600041D")]
	public static float4 floor(float4 x) { }

	[Address(RVA = "0x2A38D30", Offset = "0x2A38130", Length = "0x4E")]
	[Token(Token = "0x600041E")]
	public static double floor(double x) { }

	[Address(RVA = "0x2A38EE0", Offset = "0x2A382E0", Length = "0xB8")]
	[Token(Token = "0x600041F")]
	public static double2 floor(double2 x) { }

	[Address(RVA = "0x2A38C20", Offset = "0x2A38020", Length = "0x108")]
	[Token(Token = "0x6000420")]
	public static double3 floor(double3 x) { }

	[Address(RVA = "0x8FDB00", Offset = "0x8FCF00", Length = "0xB4")]
	[Token(Token = "0x600041B")]
	public static float2 floor(float2 x) { }

	[Address(RVA = "0x2A38D80", Offset = "0x2A38180", Length = "0x15C")]
	[Token(Token = "0x6000421")]
	public static double4 floor(double4 x) { }

	[Address(RVA = "0x28AC120", Offset = "0x28AB520", Length = "0x41")]
	[Token(Token = "0x600059C")]
	public static int floorlog2(int x) { }

	[Address(RVA = "0x2A39180", Offset = "0x2A38580", Length = "0x96")]
	[Token(Token = "0x600059D")]
	public static int2 floorlog2(int2 x) { }

	[Address(RVA = "0x2A390B0", Offset = "0x2A384B0", Length = "0xCE")]
	[Token(Token = "0x600059E")]
	public static int3 floorlog2(int3 x) { }

	[Address(RVA = "0x2A38FA0", Offset = "0x2A383A0", Length = "0x10E")]
	[Token(Token = "0x60005A3")]
	public static int4 floorlog2(uint4 x) { }

	[Address(RVA = "0x2A38FA0", Offset = "0x2A383A0", Length = "0x10E")]
	[Token(Token = "0x600059F")]
	public static int4 floorlog2(int4 x) { }

	[Address(RVA = "0x2A390B0", Offset = "0x2A384B0", Length = "0xCE")]
	[Token(Token = "0x60005A2")]
	public static int3 floorlog2(uint3 x) { }

	[Address(RVA = "0x2A39180", Offset = "0x2A38580", Length = "0x96")]
	[Token(Token = "0x60005A1")]
	public static int2 floorlog2(uint2 x) { }

	[Address(RVA = "0x28AC120", Offset = "0x28AB520", Length = "0x41")]
	[Token(Token = "0x60005A0")]
	public static int floorlog2(uint x) { }

	[Address(RVA = "0x2A39350", Offset = "0x2A38750", Length = "0x79")]
	[Token(Token = "0x6000491")]
	public static float4 fmod(float4 x, float4 y) { }

	[Address(RVA = "0x2A39220", Offset = "0x2A38620", Length = "0x65")]
	[Token(Token = "0x6000490")]
	public static float3 fmod(float3 x, float3 y) { }

	[Address(RVA = "0x2A39300", Offset = "0x2A38700", Length = "0x4A")]
	[Token(Token = "0x600048F")]
	public static float2 fmod(float2 x, float2 y) { }

	[Address(RVA = "0x2029E20", Offset = "0x2029220", Length = "0x5")]
	[Token(Token = "0x600048E")]
	public static float fmod(float x, float y) { }

	[Address(RVA = "0x2A39290", Offset = "0x2A38690", Length = "0x65")]
	[Token(Token = "0x6000494")]
	public static double3 fmod(double3 x, double3 y) { }

	[Address(RVA = "0x2A393D0", Offset = "0x2A387D0", Length = "0x79")]
	[Token(Token = "0x6000495")]
	public static double4 fmod(double4 x, double4 y) { }

	[Address(RVA = "0x2A394B0", Offset = "0x2A388B0", Length = "0x5")]
	[Token(Token = "0x6000492")]
	public static double fmod(double x, double y) { }

	[Address(RVA = "0x2A39450", Offset = "0x2A38850", Length = "0x51")]
	[Token(Token = "0x6000493")]
	public static double2 fmod(double2 x, double2 y) { }

	[Address(RVA = "0x2A39500", Offset = "0x2A38900", Length = "0x89")]
	[Token(Token = "0x6000617")]
	internal static uint4 fold_to_uint(double4 x) { }

	[Address(RVA = "0x2A39590", Offset = "0x2A38990", Length = "0x6E")]
	[Token(Token = "0x6000616")]
	internal static uint3 fold_to_uint(double3 x) { }

	[Address(RVA = "0x2A394C0", Offset = "0x2A388C0", Length = "0x3F")]
	[Token(Token = "0x6000615")]
	internal static uint2 fold_to_uint(double2 x) { }

	[Address(RVA = "0x2A39600", Offset = "0x2A38A00", Length = "0x15")]
	[Token(Token = "0x6000614")]
	internal static uint fold_to_uint(double x) { }

	[Address(RVA = "0x2A39750", Offset = "0x2A38B50", Length = "0x10")]
	[Token(Token = "0x60005FF")]
	public static float3 forward() { }

	[Address(RVA = "0x2A39620", Offset = "0x2A38A20", Length = "0x129")]
	[Token(Token = "0x60006FE")]
	public static float3 forward(quaternion q) { }

	[Address(RVA = "0x2A39DC0", Offset = "0x2A391C0", Length = "0x1C1")]
	[Token(Token = "0x6000441")]
	public static double4 frac(double4 x) { }

	[Address(RVA = "0x2A39A20", Offset = "0x2A38E20", Length = "0x15C")]
	[Token(Token = "0x6000440")]
	public static double3 frac(double3 x) { }

	[Address(RVA = "0x2A39CE0", Offset = "0x2A390E0", Length = "0xD9")]
	[Token(Token = "0x600043F")]
	public static double2 frac(double2 x) { }

	[Address(RVA = "0x2A397D0", Offset = "0x2A38BD0", Length = "0x56")]
	[Token(Token = "0x600043E")]
	public static double frac(double x) { }

	[Address(RVA = "0x2A39830", Offset = "0x2A38C30", Length = "0x1ED")]
	[Token(Token = "0x600043D")]
	public static float4 frac(float4 x) { }

	[Address(RVA = "0x2A39B80", Offset = "0x2A38F80", Length = "0x154")]
	[Token(Token = "0x600043C")]
	public static float3 frac(float3 x) { }

	[Address(RVA = "0x2A39760", Offset = "0x2A38B60", Length = "0x61")]
	[Token(Token = "0x600043A")]
	public static float frac(float x) { }

	[Address(RVA = "0x8FDBC0", Offset = "0x8FCFC0", Length = "0xC6")]
	[Token(Token = "0x600043B")]
	public static float2 frac(float2 x) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[Token(Token = "0x600021A")]
	public static half half(half x) { }

	[Address(RVA = "0x2A3A5E0", Offset = "0x2A399E0", Length = "0x7")]
	[Token(Token = "0x600021B")]
	public static half half(float v) { }

	[Address(RVA = "0x2A3A5D0", Offset = "0x2A399D0", Length = "0xB")]
	[Token(Token = "0x600021C")]
	public static half half(double v) { }

	[Address(RVA = "0x2A27540", Offset = "0x2A26940", Length = "0xF")]
	[Token(Token = "0x600021E")]
	public static half2 half2(half x, half y) { }

	[Address(RVA = "0x2A39FD0", Offset = "0x2A393D0", Length = "0x44")]
	[Token(Token = "0x6000224")]
	public static half2 half2(double2 v) { }

	[Address(RVA = "0x2A39F90", Offset = "0x2A39390", Length = "0x40")]
	[Token(Token = "0x6000223")]
	public static half2 half2(double v) { }

	[Address(RVA = "0x2A3A070", Offset = "0x2A39470", Length = "0x36")]
	[Token(Token = "0x6000222")]
	public static half2 half2(float2 v) { }

	[Address(RVA = "0x2A3A030", Offset = "0x2A39430", Length = "0x35")]
	[Token(Token = "0x6000221")]
	public static half2 half2(float v) { }

	[Address(RVA = "0x2A3A020", Offset = "0x2A39420", Length = "0xF")]
	[Token(Token = "0x6000220")]
	public static half2 half2(half v) { }

	[Address(RVA = "0x28A8400", Offset = "0x28A7800", Length = "0x12")]
	[Token(Token = "0x600021F")]
	public static half2 half2(half2 xy) { }

	[Address(RVA = "0x2A3A270", Offset = "0x2A39670", Length = "0x15")]
	[Token(Token = "0x6000228")]
	public static half3 half3(half x, half2 yz) { }

	[Address(RVA = "0x2A3A210", Offset = "0x2A39610", Length = "0xF")]
	[Token(Token = "0x600022B")]
	public static half3 half3(half v) { }

	[Address(RVA = "0x2A275B0", Offset = "0x2A269B0", Length = "0x11")]
	[Token(Token = "0x6000227")]
	public static half3 half3(half x, half y, half z) { }

	[Address(RVA = "0x2A3A220", Offset = "0x2A39620", Length = "0x48")]
	[Token(Token = "0x600022C")]
	public static half3 half3(float v) { }

	[Address(RVA = "0x2A3A1B0", Offset = "0x2A395B0", Length = "0x5A")]
	[Token(Token = "0x600022D")]
	public static half3 half3(float3 v) { }

	[Address(RVA = "0x2A3A0B0", Offset = "0x2A394B0", Length = "0x54")]
	[Token(Token = "0x600022E")]
	public static half3 half3(double v) { }

	[Address(RVA = "0x2A3A140", Offset = "0x2A39540", Length = "0x64")]
	[Token(Token = "0x600022F")]
	public static half3 half3(double3 v) { }

	[Address(RVA = "0x2A3A290", Offset = "0x2A39690", Length = "0x13")]
	[Token(Token = "0x6000229")]
	public static half3 half3(half2 xy, half z) { }

	[Address(RVA = "0x2A3A110", Offset = "0x2A39510", Length = "0x22")]
	[Token(Token = "0x600022A")]
	public static half3 half3(half3 xyz) { }

	[Address(RVA = "0x2A3A3D0", Offset = "0x2A397D0", Length = "0x54")]
	[Token(Token = "0x600023B")]
	public static half4 half4(float v) { }

	[Address(RVA = "0x2A3A2E0", Offset = "0x2A396E0", Length = "0x1A")]
	[Token(Token = "0x600023A")]
	public static half4 half4(half v) { }

	[Address(RVA = "0x2A3A500", Offset = "0x2A39900", Length = "0x2C")]
	[Token(Token = "0x6000239")]
	public static half4 half4(half4 xyzw) { }

	[Address(RVA = "0x2A27660", Offset = "0x2A26A60", Length = "0x22")]
	[Token(Token = "0x6000232")]
	public static half4 half4(half x, half y, half z, half w) { }

	[Address(RVA = "0x2A3A460", Offset = "0x2A39860", Length = "0x26")]
	[Token(Token = "0x6000233")]
	public static half4 half4(half x, half y, half2 zw) { }

	[Address(RVA = "0x2A3A430", Offset = "0x2A39830", Length = "0x2D")]
	[Token(Token = "0x6000238")]
	public static half4 half4(half3 xyz, half w) { }

	[Address(RVA = "0x2A3A3B0", Offset = "0x2A397B0", Length = "0x20")]
	[Token(Token = "0x6000237")]
	public static half4 half4(half2 xy, half2 zw) { }

	[Address(RVA = "0x2A3A300", Offset = "0x2A39700", Length = "0x24")]
	[Token(Token = "0x6000234")]
	public static half4 half4(half x, half2 yz, half w) { }

	[Address(RVA = "0x2A3A330", Offset = "0x2A39730", Length = "0x7D")]
	[Token(Token = "0x600023E")]
	public static half4 half4(double4 v) { }

	[Address(RVA = "0x2A3A490", Offset = "0x2A39890", Length = "0x67")]
	[Token(Token = "0x600023D")]
	public static half4 half4(double v) { }

	[Address(RVA = "0x2A3A530", Offset = "0x2A39930", Length = "0x2D")]
	[Token(Token = "0x6000235")]
	public static half4 half4(half x, half3 yzw) { }

	[Address(RVA = "0x2A3A560", Offset = "0x2A39960", Length = "0x63")]
	[Token(Token = "0x600023C")]
	public static half4 half4(float4 v) { }

	[Address(RVA = "0x2A3A2B0", Offset = "0x2A396B0", Length = "0x24")]
	[Token(Token = "0x6000236")]
	public static half4 half4(half2 xy, half z, half w) { }

	[Address(RVA = "0x2A3E290", Offset = "0x2A3D690", Length = "0x7C")]
	[Token(Token = "0x60001B0")]
	public static uint hash(float3x2 v) { }

	[Address(RVA = "0x2A3A5F0", Offset = "0x2A399F0", Length = "0x46")]
	[Token(Token = "0x600023F")]
	public static uint hash(half4 v) { }

	[Address(RVA = "0x2A3D710", Offset = "0x2A3CB10", Length = "0xF3")]
	[Token(Token = "0x6000781")]
	public static uint hash(uint3x4 v) { }

	[Address(RVA = "0x2A3DAC0", Offset = "0x2A3CEC0", Length = "0xB6")]
	[Token(Token = "0x6000773")]
	public static uint hash(uint3x3 v) { }

	[Address(RVA = "0x2A3B770", Offset = "0x2A3AB70", Length = "0x7C")]
	[Token(Token = "0x6000765")]
	public static uint hash(uint3x2 v) { }

	[Address(RVA = "0x2A3C480", Offset = "0x2A3B880", Length = "0x13B")]
	[Token(Token = "0x60000A4")]
	public static uint hash(double2x2 v) { }

	[Address(RVA = "0x2A3C320", Offset = "0x2A3B720", Length = "0x152")]
	[Token(Token = "0x600005E")]
	public static uint hash(bool3x4 v) { }

	[Address(RVA = "0x2A3A670", Offset = "0x2A39A70", Length = "0x5A")]
	[Token(Token = "0x600015B")]
	public static uint hash(float2 v) { }

	[Address(RVA = "0x2A3E060", Offset = "0x2A3D460", Length = "0xF5")]
	[Token(Token = "0x6000058")]
	public static uint hash(bool3x3 v) { }

	[Address(RVA = "0x2A3CEC0", Offset = "0x2A3C2C0", Length = "0x8")]
	[Token(Token = "0x60005FC")]
	public static uint hash(Void* pBuffer, int numBytes, uint seed = 0) { }

	[Address(RVA = "0x2A3BC40", Offset = "0x2A3B040", Length = "0x1D2")]
	[Token(Token = "0x60007C3")]
	public static uint hash(uint4x4 v) { }

	[Address(RVA = "0x2A3A6D0", Offset = "0x2A39AD0", Length = "0xD1")]
	[Token(Token = "0x60000E4")]
	public static uint hash(double3x2 v) { }

	[Address(RVA = "0x2A3CD20", Offset = "0x2A3C120", Length = "0x5A")]
	[Token(Token = "0x6000069")]
	public static uint hash(bool4 v) { }

	[Address(RVA = "0x2A3BE20", Offset = "0x2A3B220", Length = "0xD3")]
	[Token(Token = "0x6000074")]
	public static uint hash(bool4x2 v) { }

	[Address(RVA = "0x2A3C140", Offset = "0x2A3B540", Length = "0x14D")]
	[Token(Token = "0x60007B5")]
	public static uint hash(uint4x3 v) { }

	[Address(RVA = "0x2A3CAE0", Offset = "0x2A3BEE0", Length = "0x6C")]
	[Token(Token = "0x60000D1")]
	public static uint hash(double3 v) { }

	[Address(RVA = "0x2A3B720", Offset = "0x2A3AB20", Length = "0x4C")]
	[Token(Token = "0x60001E4")]
	public static uint hash(float4 v) { }

	[Address(RVA = "0x2A3DCF0", Offset = "0x2A3D0F0", Length = "0xBA")]
	[Token(Token = "0x60007A7")]
	public static uint hash(uint4x2 v) { }

	[Address(RVA = "0x2A3B260", Offset = "0x2A3A660", Length = "0x1E0")]
	[Token(Token = "0x60000B2")]
	public static uint hash(double2x3 v) { }

	[Address(RVA = "0x2A3ABB0", Offset = "0x2A39FB0", Length = "0x1CF")]
	[Token(Token = "0x6000218")]
	public static uint hash(float4x4 v) { }

	[Address(RVA = "0x2A3E160", Offset = "0x2A3D560", Length = "0x68")]
	[Token(Token = "0x6000225")]
	public static uint hash(half2 v) { }

	[Address(RVA = "0x2A3A960", Offset = "0x2A39D60", Length = "0x48")]
	[Token(Token = "0x6000794")]
	public static uint hash(uint4 v) { }

	[Address(RVA = "0x2A3AAB0", Offset = "0x2A39EB0", Length = "0xF3")]
	[Token(Token = "0x60001CF")]
	public static uint hash(float3x4 v) { }

	[Address(RVA = "0x2A3B040", Offset = "0x2A3A440", Length = "0x17F")]
	[Token(Token = "0x6000743")]
	public static uint hash(uint2x4 v) { }

	[Address(RVA = "0x2A3B970", Offset = "0x2A3AD70", Length = "0x280")]
	[Token(Token = "0x60000C0")]
	public static uint hash(double2x4 v) { }

	[Address(RVA = "0x2A3A640", Offset = "0x2A39A40", Length = "0x2A")]
	[Token(Token = "0x6000230")]
	public static uint hash(half3 v) { }

	[Address(RVA = "0x2A3DE00", Offset = "0x2A3D200", Length = "0xB6")]
	[Token(Token = "0x60001C0")]
	public static uint hash(float3x3 v) { }

	[Address(RVA = "0x2A3AAA0", Offset = "0x2A39EA0", Length = "0xF")]
	[Token(Token = "0x600021D")]
	public static uint hash(half v) { }

	[Address(RVA = "0x2A3C950", Offset = "0x2A3BD50", Length = "0x11E")]
	[Token(Token = "0x6000735")]
	public static uint hash(uint2x3 v) { }

	[Address(RVA = "0x2A3B210", Offset = "0x2A3A610", Length = "0x41")]
	[Token(Token = "0x6000752")]
	public static uint hash(uint3 v) { }

	[Address(RVA = "0x2A3CF20", Offset = "0x2A3C320", Length = "0x1F2")]
	[Token(Token = "0x6000040")]
	public static uint hash(bool2x4 v) { }

	[Address(RVA = "0x2A3C7D0", Offset = "0x2A3BBD0", Length = "0x17F")]
	[Token(Token = "0x600018C")]
	public static uint hash(float2x4 v) { }

	[Address(RVA = "0x2A3D8D0", Offset = "0x2A3CCD0", Length = "0xB3")]
	[Token(Token = "0x6000170")]
	public static uint hash(float2x2 v) { }

	[Address(RVA = "0x2A3E1D0", Offset = "0x2A3D5D0", Length = "0x7C")]
	[Token(Token = "0x600029E")]
	public static uint hash(int3x2 v) { }

	[Address(RVA = "0x2A3D990", Offset = "0x2A3CD90", Length = "0x12B")]
	[Token(Token = "0x6000205")]
	public static uint hash(float4x3 v) { }

	[Address(RVA = "0x2A3C290", Offset = "0x2A3B690", Length = "0x8D")]
	[Token(Token = "0x600008F")]
	public static uint hash(double2 v) { }

	[Address(RVA = "0x2A3D2C0", Offset = "0x2A3C6C0", Length = "0xB3")]
	[Token(Token = "0x6000260")]
	public static uint hash(int2x2 v) { }

	[Address(RVA = "0x2A3A7B0", Offset = "0x2A39BB0", Length = "0x1AD")]
	[Token(Token = "0x6000103")]
	public static uint hash(double3x4 v) { }

	[Address(RVA = "0x2A3B540", Offset = "0x2A3A940", Length = "0x11E")]
	[Token(Token = "0x600017E")]
	public static uint hash(float2x3 v) { }

	[Address(RVA = "0x2A3DB80", Offset = "0x2A3CF80", Length = "0x16F")]
	[Token(Token = "0x600003A")]
	public static uint hash(bool2x3 v) { }

	[Address(RVA = "0x2A3AD80", Offset = "0x2A3A180", Length = "0x22D")]
	[Token(Token = "0x600014C")]
	public static uint hash(double4x4 v) { }

	[Address(RVA = "0x2A3D120", Offset = "0x2A3C520", Length = "0x195")]
	[Token(Token = "0x6000139")]
	public static uint hash(double4x3 v) { }

	[Address(RVA = "0x2A3C6E0", Offset = "0x2A3BAE0", Length = "0xEA")]
	[Token(Token = "0x6000034")]
	public static uint hash(bool2x2 v) { }

	[Address(RVA = "0x2A3CB50", Offset = "0x2A3BF50", Length = "0x1C9")]
	[Token(Token = "0x60002FE")]
	public static uint hash(int4x4 v) { }

	[Address(RVA = "0x2A3D5E0", Offset = "0x2A3C9E0", Length = "0x124")]
	[Token(Token = "0x60002EF")]
	public static uint hash(int4x3 v) { }

	[Address(RVA = "0x2A3CA70", Offset = "0x2A3BE70", Length = "0x63")]
	[Token(Token = "0x6000029")]
	public static uint hash(bool2 v) { }

	[Address(RVA = "0x2A3B7F0", Offset = "0x2A3ABF0", Length = "0x17F")]
	[Token(Token = "0x600027C")]
	public static uint hash(int2x4 v) { }

	[Address(RVA = "0x2A3CED0", Offset = "0x2A3C2D0", Length = "0x41")]
	[Token(Token = "0x600019D")]
	public static uint hash(float3 v) { }

	[Address(RVA = "0x2A3BBF0", Offset = "0x2A3AFF0", Length = "0x4B")]
	[Token(Token = "0x6000714")]
	public static uint hash(uint2 v) { }

	[Address(RVA = "0x2A3AFB0", Offset = "0x2A3A3B0", Length = "0x89")]
	[Token(Token = "0x6000118")]
	public static uint hash(double4 v) { }

	[Address(RVA = "0x2A3E310", Offset = "0x2A3D710", Length = "0x7B")]
	[Token(Token = "0x6000707")]
	public static uint hash(RigidTransform t) { }

	[Address(RVA = "0x2A3E250", Offset = "0x2A3D650", Length = "0x3F")]
	[Token(Token = "0x60002CE")]
	public static uint hash(int4 v) { }

	[Address(RVA = "0x2A3B1C0", Offset = "0x2A3A5C0", Length = "0x48")]
	[Token(Token = "0x6000047")]
	public static uint hash(bool3 v) { }

	[Address(RVA = "0x2A3B720", Offset = "0x2A3AB20", Length = "0x4C")]
	[Token(Token = "0x60006FC")]
	public static uint hash(quaternion q) { }

	[Address(RVA = "0x2A3CD80", Offset = "0x2A3C180", Length = "0x13A")]
	[Token(Token = "0x600007A")]
	public static uint hash(bool4x3 v) { }

	[Address(RVA = "0x2A3D490", Offset = "0x2A3C890", Length = "0xA2")]
	[Token(Token = "0x6000052")]
	public static uint hash(bool3x2 v) { }

	[Address(RVA = "0x2A3DDB0", Offset = "0x2A3D1B0", Length = "0x41")]
	[Token(Token = "0x600028B")]
	public static uint hash(int3 v) { }

	[Address(RVA = "0x2A3D540", Offset = "0x2A3C940", Length = "0x9F")]
	[Token(Token = "0x60002E1")]
	public static uint hash(int4x2 v) { }

	[Address(RVA = "0x2A3A9B0", Offset = "0x2A39DB0", Length = "0xE9")]
	[Token(Token = "0x6000024")]
	public static uint hash(AffineTransform a) { }

	[Address(RVA = "0x2A3BFB0", Offset = "0x2A3B3B0", Length = "0x137")]
	[Token(Token = "0x60000F4")]
	public static uint hash(double3x3 v) { }

	[Address(RVA = "0x2A3BF00", Offset = "0x2A3B300", Length = "0xB0")]
	[Token(Token = "0x60001F7")]
	public static uint hash(float4x2 v) { }

	[Address(RVA = "0x2A3DEC0", Offset = "0x2A3D2C0", Length = "0x194")]
	[Token(Token = "0x6000080")]
	public static uint hash(bool4x4 v) { }

	[Address(RVA = "0x2A3C5C0", Offset = "0x2A3B9C0", Length = "0x11E")]
	[Token(Token = "0x600026E")]
	public static uint hash(int2x3 v) { }

	[Address(RVA = "0x2A3D810", Offset = "0x2A3CC10", Length = "0xB3")]
	[Token(Token = "0x6000727")]
	public static uint hash(uint2x2 v) { }

	[Address(RVA = "0x2A3D380", Offset = "0x2A3C780", Length = "0x10F")]
	[Token(Token = "0x600012B")]
	public static uint hash(double4x2 v) { }

	[Address(RVA = "0x2A3C0F0", Offset = "0x2A3B4F0", Length = "0x4B")]
	[Token(Token = "0x600024C")]
	public static uint hash(int2 v) { }

	[Address(RVA = "0x2A3B660", Offset = "0x2A3AA60", Length = "0xB6")]
	[Token(Token = "0x60002AD")]
	public static uint hash(int3x3 v) { }

	[Address(RVA = "0x2A3B440", Offset = "0x2A3A840", Length = "0xF3")]
	[Token(Token = "0x60002BB")]
	public static uint hash(int3x4 v) { }

	[Address(RVA = "0x2A3E390", Offset = "0x2A3D790", Length = "0x19C")]
	[Token(Token = "0x60005FA")]
	private static uint hash_with_unaligned_loads(Void* pBuffer, int numBytes, uint seed) { }

	[Address(RVA = "0x2A3E530", Offset = "0x2A3D930", Length = "0x21C")]
	[Token(Token = "0x60005FB")]
	private static uint hash_without_unaligned_loads(Void* pBuffer, int numBytes, uint seed) { }

	[Address(RVA = "0x2A3E800", Offset = "0x2A3DC00", Length = "0xEE")]
	[Token(Token = "0x60000E5")]
	public static uint3 hashwide(double3x2 v) { }

	[Address(RVA = "0x2A3F300", Offset = "0x2A3E700", Length = "0xB2")]
	[Token(Token = "0x6000119")]
	public static uint4 hashwide(double4 v) { }

	[Address(RVA = "0x2A3EFB0", Offset = "0x2A3E3B0", Length = "0x12C")]
	[Token(Token = "0x600017F")]
	public static uint2 hashwide(float2x3 v) { }

	[Address(RVA = "0x2A3F230", Offset = "0x2A3E630", Length = "0x67")]
	[Token(Token = "0x60001E5")]
	public static uint4 hashwide(float4 v) { }

	[Address(RVA = "0x2A3F8C0", Offset = "0x2A3ECC0", Length = "0x1BF")]
	[Token(Token = "0x600013A")]
	public static uint4 hashwide(double4x3 v) { }

	[Address(RVA = "0x2A40C40", Offset = "0x2A40040", Length = "0x162")]
	[Token(Token = "0x60007B6")]
	public static uint4 hashwide(uint4x3 v) { }

	[Address(RVA = "0x2A3FEE0", Offset = "0x2A3F2E0", Length = "0x11A")]
	[Token(Token = "0x6000025")]
	public static uint4 hashwide(AffineTransform a) { }

	[Address(RVA = "0x2A3FD10", Offset = "0x2A3F110", Length = "0x8D")]
	[Token(Token = "0x60000D2")]
	public static uint3 hashwide(double3 v) { }

	[Address(RVA = "0x2A406C0", Offset = "0x2A3FAC0", Length = "0x18E")]
	[Token(Token = "0x600018D")]
	public static uint2 hashwide(float2x4 v) { }

	[Address(RVA = "0x2A3F0E0", Offset = "0x2A3E4E0", Length = "0x78")]
	[Token(Token = "0x6000795")]
	public static uint4 hashwide(uint4 v) { }

	[Address(RVA = "0x2A3E750", Offset = "0x2A3DB50", Length = "0xA8")]
	[Token(Token = "0x60007A8")]
	public static uint4 hashwide(uint4x2 v) { }

	[Address(RVA = "0x2A411B0", Offset = "0x2A405B0", Length = "0xDA")]
	[Token(Token = "0x6000075")]
	public static uint4 hashwide(bool4x2 v) { }

	[Address(RVA = "0x2A42070", Offset = "0x2A41470", Length = "0x74")]
	[Token(Token = "0x600006A")]
	public static uint4 hashwide(bool4 v) { }

	[Address(RVA = "0x2A42360", Offset = "0x2A41760", Length = "0x12C")]
	[Token(Token = "0x6000736")]
	public static uint2 hashwide(uint2x3 v) { }

	[Address(RVA = "0x2A42700", Offset = "0x2A41B00", Length = "0x28F")]
	[Token(Token = "0x60000C1")]
	public static uint2 hashwide(double2x4 v) { }

	[Address(RVA = "0x2A3E8F0", Offset = "0x2A3DCF0", Length = "0x24F")]
	[Token(Token = "0x600014D")]
	public static uint4 hashwide(double4x4 v) { }

	[Address(RVA = "0x2A41990", Offset = "0x2A40D90", Length = "0xC4")]
	[Token(Token = "0x6000053")]
	public static uint3 hashwide(bool3x2 v) { }

	[Address(RVA = "0x2A41EB0", Offset = "0x2A412B0", Length = "0x6B")]
	[Token(Token = "0x600015C")]
	public static uint2 hashwide(float2 v) { }

	[Address(RVA = "0x2A41A60", Offset = "0x2A40E60", Length = "0x117")]
	[Token(Token = "0x6000059")]
	public static uint3 hashwide(bool3x3 v) { }

	[Address(RVA = "0x2A41020", Offset = "0x2A40420", Length = "0x18E")]
	[Token(Token = "0x6000744")]
	public static uint2 hashwide(uint2x4 v) { }

	[Address(RVA = "0x2A409E0", Offset = "0x2A3FDE0", Length = "0x153")]
	[Token(Token = "0x600007B")]
	public static uint4 hashwide(bool4x3 v) { }

	[Address(RVA = "0x2A41F20", Offset = "0x2A41320", Length = "0x14A")]
	[Token(Token = "0x60000A5")]
	public static uint2 hashwide(double2x2 v) { }

	[Address(RVA = "0x2A3FDA0", Offset = "0x2A3F1A0", Length = "0x132")]
	[Token(Token = "0x600012C")]
	public static uint4 hashwide(double4x2 v) { }

	[Address(RVA = "0x2A41920", Offset = "0x2A40D20", Length = "0x63")]
	[Token(Token = "0x6000753")]
	public static uint3 hashwide(uint3 v) { }

	[Address(RVA = "0x2A40BA0", Offset = "0x2A3FFA0", Length = "0x9D")]
	[Token(Token = "0x6000766")]
	public static uint3 hashwide(uint3x2 v) { }

	[Address(RVA = "0x2A41440", Offset = "0x2A40840", Length = "0xD6")]
	[Token(Token = "0x6000774")]
	public static uint3 hashwide(uint3x3 v) { }

	[Address(RVA = "0x2A42990", Offset = "0x2A41D90", Length = "0x1B1")]
	[Token(Token = "0x6000081")]
	public static uint4 hashwide(bool4x4 v) { }

	[Address(RVA = "0x2A3F490", Offset = "0x2A3E890", Length = "0x9F")]
	[Token(Token = "0x60001B1")]
	public static uint3 hashwide(float3x2 v) { }

	[Address(RVA = "0x2A40970", Offset = "0x2A3FD70", Length = "0x64")]
	[Token(Token = "0x6000048")]
	public static uint3 hashwide(bool3 v) { }

	[Address(RVA = "0x2A42490", Offset = "0x2A41890", Length = "0x1E8")]
	[Token(Token = "0x6000041")]
	public static uint2 hashwide(bool2x4 v) { }

	[Address(RVA = "0x2A3FA80", Offset = "0x2A3EE80", Length = "0x164")]
	[Token(Token = "0x600003B")]
	public static uint2 hashwide(bool2x3 v) { }

	[Address(RVA = "0x2A41B80", Offset = "0x2A40F80", Length = "0x1EE")]
	[Token(Token = "0x60000B3")]
	public static uint2 hashwide(double2x3 v) { }

	[Address(RVA = "0x2A40DB0", Offset = "0x2A401B0", Length = "0x9E")]
	[Token(Token = "0x6000090")]
	public static uint2 hashwide(double2 v) { }

	[Address(RVA = "0x2A3F2A0", Offset = "0x2A3E6A0", Length = "0x5C")]
	[Token(Token = "0x6000715")]
	public static uint2 hashwide(uint2 v) { }

	[Address(RVA = "0x2A3F3C0", Offset = "0x2A3E7C0", Length = "0xD0")]
	[Token(Token = "0x60001C1")]
	public static uint3 hashwide(float3x3 v) { }

	[Address(RVA = "0x2A42290", Offset = "0x2A41690", Length = "0xC2")]
	[Token(Token = "0x6000171")]
	public static uint2 hashwide(float2x2 v) { }

	[Address(RVA = "0x2A420F0", Offset = "0x2A414F0", Length = "0x115")]
	[Token(Token = "0x6000782")]
	public static uint3 hashwide(uint3x4 v) { }

	[Address(RVA = "0x2A416E0", Offset = "0x2A40AE0", Length = "0xE0")]
	[Token(Token = "0x6000035")]
	public static uint2 hashwide(bool2x2 v) { }

	[Address(RVA = "0x2A3F160", Offset = "0x2A3E560", Length = "0xC2")]
	[Token(Token = "0x6000728")]
	public static uint2 hashwide(uint2x2 v) { }

	[Address(RVA = "0x2A3F5F0", Offset = "0x2A3E9F0", Length = "0x57")]
	[Token(Token = "0x600002A")]
	public static uint2 hashwide(bool2 v) { }

	[Address(RVA = "0x2A3FBF0", Offset = "0x2A3EFF0", Length = "0x61")]
	[Token(Token = "0x600019E")]
	public static uint3 hashwide(float3 v) { }

	[Address(RVA = "0x2A3F530", Offset = "0x2A3E930", Length = "0xB3")]
	[Token(Token = "0x6000708")]
	public static uint4 hashwide(RigidTransform t) { }

	[Address(RVA = "0x2A3ECA0", Offset = "0x2A3E0A0", Length = "0x116")]
	[Token(Token = "0x60001D0")]
	public static uint3 hashwide(float3x4 v) { }

	[Address(RVA = "0x2A3F230", Offset = "0x2A3E630", Length = "0x67")]
	[Token(Token = "0x60006FD")]
	public static uint4 hashwide(quaternion q) { }

	[Address(RVA = "0x2A40360", Offset = "0x2A3F760", Length = "0x168")]
	[Token(Token = "0x600005F")]
	public static uint3 hashwide(bool3x4 v) { }

	[Address(RVA = "0x2A3EDC0", Offset = "0x2A3E1C0", Length = "0x1E9")]
	[Token(Token = "0x60007C4")]
	public static uint4 hashwide(uint4x4 v) { }

	[Address(RVA = "0x2A41DE0", Offset = "0x2A411E0", Length = "0xC7")]
	[Token(Token = "0x60001F8")]
	public static uint4 hashwide(float4x2 v) { }

	[Address(RVA = "0x2A42680", Offset = "0x2A41A80", Length = "0x78")]
	[Token(Token = "0x6000240")]
	public static uint4 hashwide(half4 v) { }

	[Address(RVA = "0x2A40B40", Offset = "0x2A3FF40", Length = "0x5A")]
	[Token(Token = "0x6000231")]
	public static uint3 hashwide(half3 v) { }

	[Address(RVA = "0x2A413C0", Offset = "0x2A407C0", Length = "0x79")]
	[Token(Token = "0x6000226")]
	public static uint2 hashwide(half2 v) { }

	[Address(RVA = "0x2A404D0", Offset = "0x2A3F8D0", Length = "0x1ED")]
	[Token(Token = "0x6000219")]
	public static uint4 hashwide(float4x4 v) { }

	[Address(RVA = "0x2A40850", Offset = "0x2A3FC50", Length = "0x115")]
	[Token(Token = "0x60002BC")]
	public static uint3 hashwide(int3x4 v) { }

	[Address(RVA = "0x2A41520", Offset = "0x2A40920", Length = "0x5C")]
	[Token(Token = "0x600024D")]
	public static uint2 hashwide(int2 v) { }

	[Address(RVA = "0x2A41290", Offset = "0x2A40690", Length = "0x12C")]
	[Token(Token = "0x600026F")]
	public static uint2 hashwide(int2x3 v) { }

	[Address(RVA = "0x2A3F730", Offset = "0x2A3EB30", Length = "0x18E")]
	[Token(Token = "0x600027D")]
	public static uint2 hashwide(int2x4 v) { }

	[Address(RVA = "0x2A41580", Offset = "0x2A40980", Length = "0x15F")]
	[Token(Token = "0x60002F0")]
	public static uint4 hashwide(int4x3 v) { }

	[Address(RVA = "0x2A41D70", Offset = "0x2A41170", Length = "0x61")]
	[Token(Token = "0x600028C")]
	public static uint3 hashwide(int3 v) { }

	[Address(RVA = "0x2A40170", Offset = "0x2A3F570", Length = "0x1ED")]
	[Token(Token = "0x60002FF")]
	public static uint4 hashwide(int4x4 v) { }

	[Address(RVA = "0x2A40E50", Offset = "0x2A40250", Length = "0x1CD")]
	[Token(Token = "0x6000104")]
	public static uint3 hashwide(double3x4 v) { }

	[Address(RVA = "0x2A40000", Offset = "0x2A3F400", Length = "0x9E")]
	[Token(Token = "0x600029F")]
	public static uint3 hashwide(int3x2 v) { }

	[Address(RVA = "0x2A3FC60", Offset = "0x2A3F060", Length = "0xA8")]
	[Token(Token = "0x60002E2")]
	public static uint4 hashwide(int4x2 v) { }

	[Address(RVA = "0x2A3EB40", Offset = "0x2A3DF40", Length = "0x160")]
	[Token(Token = "0x6000206")]
	public static uint4 hashwide(float4x3 v) { }

	[Address(RVA = "0x2A3F650", Offset = "0x2A3EA50", Length = "0xD7")]
	[Token(Token = "0x60002AE")]
	public static uint3 hashwide(int3x3 v) { }

	[Address(RVA = "0x2A400A0", Offset = "0x2A3F4A0", Length = "0xC2")]
	[Token(Token = "0x6000261")]
	public static uint2 hashwide(int2x2 v) { }

	[Address(RVA = "0x2A42210", Offset = "0x2A41610", Length = "0x76")]
	[Token(Token = "0x60002CF")]
	public static uint4 hashwide(int4 v) { }

	[Address(RVA = "0x2A417C0", Offset = "0x2A40BC0", Length = "0x155")]
	[Token(Token = "0x60000F5")]
	public static uint3 hashwide(double3x3 v) { }

	[Address(RVA = "0x28D8420", Offset = "0x28D7820", Length = "0x12")]
	[Token(Token = "0x6000247")]
	public static int2 int2(uint2 v) { }

	[Address(RVA = "0x2A42B90", Offset = "0x2A41F90", Length = "0x16")]
	[Token(Token = "0x6000244")]
	public static int2 int2(bool v) { }

	[Address(RVA = "0x2A42BF0", Offset = "0x2A41FF0", Length = "0xE")]
	[Token(Token = "0x6000243")]
	public static int2 int2(int v) { }

	[Address(RVA = "0x28D8420", Offset = "0x28D7820", Length = "0x12")]
	[Token(Token = "0x6000242")]
	public static int2 int2(int2 xy) { }

	[Address(RVA = "0x2A27C90", Offset = "0x2A27090", Length = "0xE")]
	[Token(Token = "0x6000241")]
	public static int2 int2(int x, int y) { }

	[Address(RVA = "0x2A42BD0", Offset = "0x2A41FD0", Length = "0x20")]
	[Token(Token = "0x6000245")]
	public static int2 int2(bool2 v) { }

	[Address(RVA = "0x2A42BF0", Offset = "0x2A41FF0", Length = "0xE")]
	[Token(Token = "0x6000246")]
	public static int2 int2(uint v) { }

	[Address(RVA = "0x2A42BB0", Offset = "0x2A41FB0", Length = "0x16")]
	[Token(Token = "0x6000248")]
	public static int2 int2(float v) { }

	[Address(RVA = "0x2A42B70", Offset = "0x2A41F70", Length = "0x16")]
	[Token(Token = "0x600024A")]
	public static int2 int2(double v) { }

	[Address(RVA = "0x2A42C00", Offset = "0x2A42000", Length = "0x1D")]
	[Token(Token = "0x600024B")]
	public static int2 int2(double2 v) { }

	[Address(RVA = "0x2A42B50", Offset = "0x2A41F50", Length = "0x1F")]
	[Token(Token = "0x6000249")]
	public static int2 int2(float2 v) { }

	[Address(RVA = "0x2A42D10", Offset = "0x2A42110", Length = "0x25")]
	[Token(Token = "0x6000258")]
	public static int2x2 int2x2(uint v) { }

	[Address(RVA = "0x2A42C20", Offset = "0x2A42020", Length = "0x9D")]
	[Token(Token = "0x6000257")]
	public static int2x2 int2x2(bool2x2 v) { }

	[Address(RVA = "0x2A42E90", Offset = "0x2A42290", Length = "0x59")]
	[Token(Token = "0x6000256")]
	public static int2x2 int2x2(bool v) { }

	[Address(RVA = "0x2A42D10", Offset = "0x2A42110", Length = "0x25")]
	[Token(Token = "0x6000255")]
	public static int2x2 int2x2(int v) { }

	[Address(RVA = "0x2A42D40", Offset = "0x2A42140", Length = "0x2B")]
	[Token(Token = "0x6000254")]
	public static int2x2 int2x2(int m00, int m01, int m10, int m11) { }

	[Address(RVA = "0x2A42E50", Offset = "0x2A42250", Length = "0x35")]
	[Token(Token = "0x600025C")]
	public static int2x2 int2x2(double v) { }

	[Address(RVA = "0x2A42D70", Offset = "0x2A42170", Length = "0x4C")]
	[Token(Token = "0x600025D")]
	public static int2x2 int2x2(double2x2 v) { }

	[Address(RVA = "0x2A42E00", Offset = "0x2A42200", Length = "0x49")]
	[Token(Token = "0x6000259")]
	public static int2x2 int2x2(uint2x2 v) { }

	[Address(RVA = "0x2A42CC0", Offset = "0x2A420C0", Length = "0x4A")]
	[Token(Token = "0x600025B")]
	public static int2x2 int2x2(float2x2 v) { }

	[Address(RVA = "0x2A348C0", Offset = "0x2A33CC0", Length = "0xB")]
	[Token(Token = "0x6000253")]
	public static int2x2 int2x2(int2 c0, int2 c1) { }

	[Address(RVA = "0x2A42DC0", Offset = "0x2A421C0", Length = "0x35")]
	[Token(Token = "0x600025A")]
	public static int2x2 int2x2(float v) { }

	[Address(RVA = "0x2A432C0", Offset = "0x2A426C0", Length = "0x89")]
	[Token(Token = "0x600026A")]
	public static int2x3 int2x3(float2x3 v) { }

	[Address(RVA = "0x2A43020", Offset = "0x2A42420", Length = "0x36")]
	[Token(Token = "0x6000264")]
	public static int2x3 int2x3(int v) { }

	[Address(RVA = "0x2A43240", Offset = "0x2A42640", Length = "0x7B")]
	[Token(Token = "0x6000265")]
	public static int2x3 int2x3(bool v) { }

	[Address(RVA = "0x2A430B0", Offset = "0x2A424B0", Length = "0x11E")]
	[Token(Token = "0x6000266")]
	public static int2x3 int2x3(bool2x3 v) { }

	[Address(RVA = "0x2A43060", Offset = "0x2A42460", Length = "0x4E")]
	[Token(Token = "0x600026B")]
	public static int2x3 int2x3(double v) { }

	[Address(RVA = "0x2A43020", Offset = "0x2A42420", Length = "0x36")]
	[Token(Token = "0x6000267")]
	public static int2x3 int2x3(uint v) { }

	[Address(RVA = "0x2A42F40", Offset = "0x2A42340", Length = "0x44")]
	[Token(Token = "0x6000263")]
	public static int2x3 int2x3(int m00, int m01, int m02, int m10, int m11, int m12) { }

	[Address(RVA = "0x2A42F90", Offset = "0x2A42390", Length = "0x8A")]
	[Token(Token = "0x6000268")]
	public static int2x3 int2x3(uint2x3 v) { }

	[Address(RVA = "0x2A431D0", Offset = "0x2A425D0", Length = "0x6D")]
	[Token(Token = "0x600026C")]
	public static int2x3 int2x3(double2x3 v) { }

	[Address(RVA = "0x2A42EF0", Offset = "0x2A422F0", Length = "0x4E")]
	[Token(Token = "0x6000269")]
	public static int2x3 int2x3(float v) { }

	[Address(RVA = "0x25DC8A0", Offset = "0x25DBCA0", Length = "0x81E")]
	[Token(Token = "0x6000262")]
	public static int2x3 int2x3(int2 c0, int2 c1, int2 c2) { }

	[Address(RVA = "0x2A43350", Offset = "0x2A42750", Length = "0x24")]
	[Token(Token = "0x6000274")]
	public static int2x4 int2x4(bool2x4 v) { }

	[Address(RVA = "0x2A43380", Offset = "0x2A42780", Length = "0x47")]
	[Token(Token = "0x6000275")]
	public static int2x4 int2x4(uint v) { }

	[Address(RVA = "0x2A433D0", Offset = "0x2A427D0", Length = "0x95")]
	[Token(Token = "0x6000276")]
	public static int2x4 int2x4(uint2x4 v) { }

	[Address(RVA = "0x2A43680", Offset = "0x2A42A80", Length = "0x67")]
	[Token(Token = "0x6000277")]
	public static int2x4 int2x4(float v) { }

	[Address(RVA = "0x27F0730", Offset = "0x27EFB30", Length = "0x18")]
	[Token(Token = "0x6000270")]
	public static int2x4 int2x4(int2 c0, int2 c1, int2 c2, int2 c3) { }

	[Address(RVA = "0x2A43570", Offset = "0x2A42970", Length = "0x67")]
	[Token(Token = "0x6000279")]
	public static int2x4 int2x4(double v) { }

	[Address(RVA = "0x2A436F0", Offset = "0x2A42AF0", Length = "0x8E")]
	[Token(Token = "0x600027A")]
	public static int2x4 int2x4(double2x4 v) { }

	[Address(RVA = "0x2A43470", Offset = "0x2A42870", Length = "0x5D")]
	[Token(Token = "0x6000271")]
	public static int2x4 int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13) { }

	[Address(RVA = "0x2A43380", Offset = "0x2A42780", Length = "0x47")]
	[Token(Token = "0x6000272")]
	public static int2x4 int2x4(int v) { }

	[Address(RVA = "0x2A434D0", Offset = "0x2A428D0", Length = "0x9D")]
	[Token(Token = "0x6000273")]
	public static int2x4 int2x4(bool v) { }

	[Address(RVA = "0x2A435E0", Offset = "0x2A429E0", Length = "0x9B")]
	[Token(Token = "0x6000278")]
	public static int2x4 int2x4(float2x4 v) { }

	[Address(RVA = "0x2A43820", Offset = "0x2A42C20", Length = "0x30")]
	[Token(Token = "0x6000286")]
	public static int3 int3(uint3 v) { }

	[Address(RVA = "0x2A43820", Offset = "0x2A42C20", Length = "0x30")]
	[Token(Token = "0x6000281")]
	public static int3 int3(int3 xyz) { }

	[Address(RVA = "0x2A43800", Offset = "0x2A42C00", Length = "0x11")]
	[Token(Token = "0x6000280")]
	public static int3 int3(int2 xy, int z) { }

	[Address(RVA = "0x2A437E0", Offset = "0x2A42BE0", Length = "0x12")]
	[Token(Token = "0x600027F")]
	public static int3 int3(int x, int2 yz) { }

	[Address(RVA = "0x2A437B0", Offset = "0x2A42BB0", Length = "0x2D")]
	[Token(Token = "0x6000288")]
	public static int3 int3(float3 v) { }

	[Address(RVA = "0x2A43850", Offset = "0x2A42C50", Length = "0x18")]
	[Token(Token = "0x6000289")]
	public static int3 int3(double v) { }

	[Address(RVA = "0x2A438D0", Offset = "0x2A42CD0", Length = "0x34")]
	[Token(Token = "0x600028A")]
	public static int3 int3(double3 v) { }

	[Address(RVA = "0x2A43890", Offset = "0x2A42C90", Length = "0x34")]
	[Token(Token = "0x6000284")]
	public static int3 int3(bool3 v) { }

	[Address(RVA = "0x2A43870", Offset = "0x2A42C70", Length = "0x18")]
	[Token(Token = "0x6000287")]
	public static int3 int3(float v) { }

	[Address(RVA = "0x2A27CF0", Offset = "0x2A270F0", Length = "0xE")]
	[Token(Token = "0x600027E")]
	public static int3 int3(int x, int y, int z) { }

	[Address(RVA = "0x2A437A0", Offset = "0x2A42BA0", Length = "0xC")]
	[Token(Token = "0x6000285")]
	public static int3 int3(uint v) { }

	[Address(RVA = "0x2A43780", Offset = "0x2A42B80", Length = "0x17")]
	[Token(Token = "0x6000283")]
	public static int3 int3(bool v) { }

	[Address(RVA = "0x2A437A0", Offset = "0x2A42BA0", Length = "0xC")]
	[Token(Token = "0x6000282")]
	public static int3 int3(int v) { }

	[Address(RVA = "0x2A43AC0", Offset = "0x2A42EC0", Length = "0x33")]
	[Token(Token = "0x6000297")]
	public static int3x2 int3x2(uint v) { }

	[Address(RVA = "0x2A43B70", Offset = "0x2A42F70", Length = "0x96")]
	[Token(Token = "0x6000296")]
	public static int3x2 int3x2(bool3x2 v) { }

	[Address(RVA = "0x2A43C10", Offset = "0x2A43010", Length = "0x4B")]
	[Token(Token = "0x6000299")]
	public static int3x2 int3x2(float v) { }

	[Address(RVA = "0x2A43AC0", Offset = "0x2A42EC0", Length = "0x33")]
	[Token(Token = "0x6000294")]
	public static int3x2 int3x2(int v) { }

	[Address(RVA = "0x2A43A70", Offset = "0x2A42E70", Length = "0x41")]
	[Token(Token = "0x6000293")]
	public static int3x2 int3x2(int m00, int m01, int m10, int m11, int m20, int m21) { }

	[Address(RVA = "0x2A35CD0", Offset = "0x2A350D0", Length = "0x23")]
	[Token(Token = "0x6000292")]
	public static int3x2 int3x2(int3 c0, int3 c1) { }

	[Address(RVA = "0x2A43B00", Offset = "0x2A42F00", Length = "0x70")]
	[Token(Token = "0x6000295")]
	public static int3x2 int3x2(bool v) { }

	[Address(RVA = "0x2A439F0", Offset = "0x2A42DF0", Length = "0x74")]
	[Token(Token = "0x600029A")]
	public static int3x2 int3x2(float3x2 v) { }

	[Address(RVA = "0x2A43970", Offset = "0x2A42D70", Length = "0x7A")]
	[Token(Token = "0x6000298")]
	public static int3x2 int3x2(uint3x2 v) { }

	[Address(RVA = "0x2A43910", Offset = "0x2A42D10", Length = "0x5C")]
	[Token(Token = "0x600029C")]
	public static int3x2 int3x2(double3x2 v) { }

	[Address(RVA = "0x2A43C60", Offset = "0x2A43060", Length = "0x4B")]
	[Token(Token = "0x600029B")]
	public static int3x2 int3x2(double v) { }

	[Address(RVA = "0x2A363C0", Offset = "0x2A357C0", Length = "0x34")]
	[Token(Token = "0x60002A0")]
	public static int3x3 int3x3(int3 c0, int3 c1, int3 c2) { }

	[Address(RVA = "0x2A43F70", Offset = "0x2A43370", Length = "0x61")]
	[Token(Token = "0x60002A1")]
	public static int3x3 int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22) { }

	[Address(RVA = "0x2A43CB0", Offset = "0x2A430B0", Length = "0x47")]
	[Token(Token = "0x60002A2")]
	public static int3x3 int3x3(int v) { }

	[Address(RVA = "0x2A44130", Offset = "0x2A43530", Length = "0x98")]
	[Token(Token = "0x60002A3")]
	public static int3x3 int3x3(bool v) { }

	[Address(RVA = "0x2A44050", Offset = "0x2A43450", Length = "0xD3")]
	[Token(Token = "0x60002A4")]
	public static int3x3 int3x3(bool3x3 v) { }

	[Address(RVA = "0x2A43CB0", Offset = "0x2A430B0", Length = "0x47")]
	[Token(Token = "0x60002A5")]
	public static int3x3 int3x3(uint v) { }

	[Address(RVA = "0x2A43ED0", Offset = "0x2A432D0", Length = "0x92")]
	[Token(Token = "0x60002A8")]
	public static int3x3 int3x3(float3x3 v) { }

	[Address(RVA = "0x2A43FE0", Offset = "0x2A433E0", Length = "0x6B")]
	[Token(Token = "0x60002A9")]
	public static int3x3 int3x3(double v) { }

	[Address(RVA = "0x2A43E20", Offset = "0x2A43220", Length = "0xA7")]
	[Token(Token = "0x60002AA")]
	public static int3x3 int3x3(double3x3 v) { }

	[Address(RVA = "0x2A43D70", Offset = "0x2A43170", Length = "0xA4")]
	[Token(Token = "0x60002A6")]
	public static int3x3 int3x3(uint3x3 v) { }

	[Address(RVA = "0x2A43D00", Offset = "0x2A43100", Length = "0x6B")]
	[Token(Token = "0x60002A7")]
	public static int3x3 int3x3(float v) { }

	[Address(RVA = "0x2A44460", Offset = "0x2A43860", Length = "0x5B")]
	[Token(Token = "0x60002B1")]
	public static int3x4 int3x4(int v) { }

	[Address(RVA = "0x2A441D0", Offset = "0x2A435D0", Length = "0xBB")]
	[Token(Token = "0x60002B2")]
	public static int3x4 int3x4(bool v) { }

	[Address(RVA = "0x2A36C10", Offset = "0x2A36010", Length = "0x48")]
	[Token(Token = "0x60002AF")]
	public static int3x4 int3x4(int3 c0, int3 c1, int3 c2, int3 c3) { }

	[Address(RVA = "0x2A44460", Offset = "0x2A43860", Length = "0x5B")]
	[Token(Token = "0x60002B4")]
	public static int3x4 int3x4(uint v) { }

	[Address(RVA = "0x2A44340", Offset = "0x2A43740", Length = "0x116")]
	[Token(Token = "0x60002B3")]
	public static int3x4 int3x4(bool3x4 v) { }

	[Address(RVA = "0x2A44740", Offset = "0x2A43B40", Length = "0xCB")]
	[Token(Token = "0x60002B5")]
	public static int3x4 int3x4(uint3x4 v) { }

	[Address(RVA = "0x2A44620", Offset = "0x2A43A20", Length = "0x8B")]
	[Token(Token = "0x60002B6")]
	public static int3x4 int3x4(float v) { }

	[Address(RVA = "0x2A444C0", Offset = "0x2A438C0", Length = "0xC7")]
	[Token(Token = "0x60002B7")]
	public static int3x4 int3x4(float3x4 v) { }

	[Address(RVA = "0x2A44590", Offset = "0x2A43990", Length = "0x8B")]
	[Token(Token = "0x60002B8")]
	public static int3x4 int3x4(double v) { }

	[Address(RVA = "0x2A44290", Offset = "0x2A43690", Length = "0xB0")]
	[Token(Token = "0x60002B9")]
	public static int3x4 int3x4(double3x4 v) { }

	[Address(RVA = "0x2A446B0", Offset = "0x2A43AB0", Length = "0x84")]
	[Token(Token = "0x60002B0")]
	public static int3x4 int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23) { }

	[Address(RVA = "0x2A44840", Offset = "0x2A43C40", Length = "0x1D")]
	[Token(Token = "0x60002C6")]
	public static int4 int4(bool v) { }

	[Address(RVA = "0x2A448A0", Offset = "0x2A43CA0", Length = "0x44")]
	[Token(Token = "0x60002C7")]
	public static int4 int4(bool4 v) { }

	[Address(RVA = "0x2A44960", Offset = "0x2A43D60", Length = "0x16")]
	[Token(Token = "0x60002BE")]
	public static int4 int4(int x, int y, int2 zw) { }

	[Address(RVA = "0x28D8440", Offset = "0x28D7840", Length = "0x19")]
	[Token(Token = "0x60002C2")]
	public static int4 int4(int2 xy, int2 zw) { }

	[Address(RVA = "0x27F9F00", Offset = "0x27F9300", Length = "0x15")]
	[Token(Token = "0x60002BD")]
	public static int4 int4(int x, int y, int z, int w) { }

	[Address(RVA = "0x2A449A0", Offset = "0x2A43DA0", Length = "0x34")]
	[Token(Token = "0x60002C3")]
	public static int4 int4(int3 xyz, int w) { }

	[Address(RVA = "0x2A44980", Offset = "0x2A43D80", Length = "0x15")]
	[Token(Token = "0x60002C1")]
	public static int4 int4(int2 xy, int z, int w) { }

	[Address(RVA = "0x2A44810", Offset = "0x2A43C10", Length = "0x2A")]
	[Token(Token = "0x60002C4")]
	public static int4 int4(int4 xyzw) { }

	[Address(RVA = "0x27F9D50", Offset = "0x27F9150", Length = "0xF")]
	[Token(Token = "0x60002C5")]
	public static int4 int4(int v) { }

	[Address(RVA = "0x2A449E0", Offset = "0x2A43DE0", Length = "0x16")]
	[Token(Token = "0x60002BF")]
	public static int4 int4(int x, int2 yz, int w) { }

	[Address(RVA = "0x2A44920", Offset = "0x2A43D20", Length = "0x18")]
	[Token(Token = "0x60002CC")]
	public static int4 int4(double v) { }

	[Address(RVA = "0x2A44A00", Offset = "0x2A43E00", Length = "0x34")]
	[Token(Token = "0x60002CB")]
	public static int4 int4(float4 v) { }

	[Address(RVA = "0x2A44940", Offset = "0x2A43D40", Length = "0x1F")]
	[Token(Token = "0x60002CA")]
	public static int4 int4(float v) { }

	[Address(RVA = "0x2A44810", Offset = "0x2A43C10", Length = "0x2A")]
	[Token(Token = "0x60002C9")]
	public static int4 int4(uint4 v) { }

	[Address(RVA = "0x27F9D50", Offset = "0x27F9150", Length = "0xF")]
	[Token(Token = "0x60002C8")]
	public static int4 int4(uint v) { }

	[Address(RVA = "0x2A448F0", Offset = "0x2A43CF0", Length = "0x2E")]
	[Token(Token = "0x60002CD")]
	public static int4 int4(double4 v) { }

	[Address(RVA = "0x2A44860", Offset = "0x2A43C60", Length = "0x35")]
	[Token(Token = "0x60002C0")]
	public static int4 int4(int x, int3 yzw) { }

	[Address(RVA = "0x2A44B60", Offset = "0x2A43F60", Length = "0x5F")]
	[Token(Token = "0x60002DB")]
	public static int4x2 int4x2(uint4x2 v) { }

	[Address(RVA = "0x2A44BC0", Offset = "0x2A43FC0", Length = "0x21")]
	[Token(Token = "0x60002DC")]
	public static int4x2 int4x2(float v) { }

	[Address(RVA = "0x2A44C20", Offset = "0x2A44020", Length = "0x8B")]
	[Token(Token = "0x60002DD")]
	public static int4x2 int4x2(float4x2 v) { }

	[Address(RVA = "0x2A44A40", Offset = "0x2A43E40", Length = "0x59")]
	[Token(Token = "0x60002DE")]
	public static int4x2 int4x2(double v) { }

	[Address(RVA = "0x2A44D60", Offset = "0x2A44160", Length = "0x4F")]
	[Token(Token = "0x60002D6")]
	public static int4x2 int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31) { }

	[Address(RVA = "0x2A44BF0", Offset = "0x2A43FF0", Length = "0x25")]
	[Token(Token = "0x60002D8")]
	public static int4x2 int4x2(bool v) { }

	[Address(RVA = "0x2A44B20", Offset = "0x2A43F20", Length = "0x39")]
	[Token(Token = "0x60002D7")]
	public static int4x2 int4x2(int v) { }

	[Address(RVA = "0x27F0880", Offset = "0x27EFC80", Length = "0x12")]
	[Token(Token = "0x60002D5")]
	public static int4x2 int4x2(int4 c0, int4 c1) { }

	[Address(RVA = "0x2A44AA0", Offset = "0x2A43EA0", Length = "0x78")]
	[Token(Token = "0x60002DF")]
	public static int4x2 int4x2(double4x2 v) { }

	[Address(RVA = "0x2A44CB0", Offset = "0x2A440B0", Length = "0xA2")]
	[Token(Token = "0x60002D9")]
	public static int4x2 int4x2(bool4x2 v) { }

	[Address(RVA = "0x2A44B20", Offset = "0x2A43F20", Length = "0x39")]
	[Token(Token = "0x60002DA")]
	public static int4x2 int4x2(uint v) { }

	[Address(RVA = "0x2A45180", Offset = "0x2A44580", Length = "0x34")]
	[Token(Token = "0x60002E6")]
	public static int4x3 int4x3(bool v) { }

	[Address(RVA = "0x2A44E30", Offset = "0x2A44230", Length = "0x4A")]
	[Token(Token = "0x60002E5")]
	public static int4x3 int4x3(int v) { }

	[Address(RVA = "0x2A44F60", Offset = "0x2A44360", Length = "0x115")]
	[Token(Token = "0x60002E7")]
	public static int4x3 int4x3(bool4x3 v) { }

	[Address(RVA = "0x2A44E30", Offset = "0x2A44230", Length = "0x4A")]
	[Token(Token = "0x60002E8")]
	public static int4x3 int4x3(uint v) { }

	[Address(RVA = "0x2A45100", Offset = "0x2A44500", Length = "0x7F")]
	[Token(Token = "0x60002E9")]
	public static int4x3 int4x3(uint4x3 v) { }

	[Address(RVA = "0x2A44F30", Offset = "0x2A44330", Length = "0x30")]
	[Token(Token = "0x60002EA")]
	public static int4x3 int4x3(float v) { }

	[Address(RVA = "0x2A451C0", Offset = "0x2A445C0", Length = "0xC1")]
	[Token(Token = "0x60002EB")]
	public static int4x3 int4x3(float4x3 v) { }

	[Address(RVA = "0x2A44DB0", Offset = "0x2A441B0", Length = "0x80")]
	[Token(Token = "0x60002EC")]
	public static int4x3 int4x3(double v) { }

	[Address(RVA = "0x2A44E80", Offset = "0x2A44280", Length = "0xAC")]
	[Token(Token = "0x60002ED")]
	public static int4x3 int4x3(double4x3 v) { }

	[Address(RVA = "0x2A38170", Offset = "0x2A37570", Length = "0x1A")]
	[Token(Token = "0x60002E3")]
	public static int4x3 int4x3(int4 c0, int4 c1, int4 c2) { }

	[Address(RVA = "0x2A45080", Offset = "0x2A44480", Length = "0x79")]
	[Token(Token = "0x60002E4")]
	public static int4x3 int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32) { }

	[Address(RVA = "0x2A386D0", Offset = "0x2A37AD0", Length = "0x26")]
	[Token(Token = "0x60002F1")]
	public static int4x4 int4x4(int4 c0, int4 c1, int4 c2, int4 c3) { }

	[Address(RVA = "0x2A453E0", Offset = "0x2A447E0", Length = "0x5E")]
	[Token(Token = "0x60002F3")]
	public static int4x4 int4x4(int v) { }

	[Address(RVA = "0x2A45290", Offset = "0x2A44690", Length = "0x43")]
	[Token(Token = "0x60002F4")]
	public static int4x4 int4x4(bool v) { }

	[Address(RVA = "0x2A45490", Offset = "0x2A44890", Length = "0x149")]
	[Token(Token = "0x60002F5")]
	public static int4x4 int4x4(bool4x4 v) { }

	[Address(RVA = "0x2A453E0", Offset = "0x2A447E0", Length = "0x5E")]
	[Token(Token = "0x60002F6")]
	public static int4x4 int4x4(uint v) { }

	[Address(RVA = "0x2A455E0", Offset = "0x2A449E0", Length = "0xA0")]
	[Token(Token = "0x60002F7")]
	public static int4x4 int4x4(uint4x4 v) { }

	[Address(RVA = "0x2A45440", Offset = "0x2A44840", Length = "0x42")]
	[Token(Token = "0x60002F8")]
	public static int4x4 int4x4(float v) { }

	[Address(RVA = "0x2A45680", Offset = "0x2A44A80", Length = "0xE8")]
	[Token(Token = "0x60002FB")]
	public static int4x4 int4x4(double4x4 v) { }

	[Address(RVA = "0x2A45820", Offset = "0x2A44C20", Length = "0xAC")]
	[Token(Token = "0x60002F2")]
	public static int4x4 int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33) { }

	[Address(RVA = "0x2A452E0", Offset = "0x2A446E0", Length = "0xF8")]
	[Token(Token = "0x60002F9")]
	public static int4x4 int4x4(float4x4 v) { }

	[Address(RVA = "0x2A45770", Offset = "0x2A44B70", Length = "0xA7")]
	[Token(Token = "0x60002FA")]
	public static int4x4 int4x4(double v) { }

	[Address(RVA = "0x2A47740", Offset = "0x2A46B40", Length = "0x1CC3")]
	[Token(Token = "0x6000215")]
	public static float4x4 inverse(float4x4 m) { }

	[Address(RVA = "0x2A458D0", Offset = "0x2A44CD0", Length = "0x16C")]
	[Token(Token = "0x6000022")]
	public static AffineTransform inverse(AffineTransform a) { }

	[Address(RVA = "0x2A49410", Offset = "0x2A48810", Length = "0x1E3")]
	[Token(Token = "0x6000702")]
	public static RigidTransform inverse(RigidTransform t) { }

	[Address(RVA = "0x2A45D70", Offset = "0x2A45170", Length = "0x17E7")]
	[Token(Token = "0x6000149")]
	public static double4x4 inverse(double4x4 m) { }

	[Address(RVA = "0x2A1D0A0", Offset = "0x2A1C4A0", Length = "0xB8")]
	[Token(Token = "0x60006E8")]
	public static quaternion inverse(quaternion q) { }

	[Address(RVA = "0x2A45AC0", Offset = "0x2A44EC0", Length = "0x215")]
	[Token(Token = "0x60001BE")]
	public static float3x3 inverse(float3x3 m) { }

	[Address(RVA = "0x2A45A40", Offset = "0x2A44E40", Length = "0x7C")]
	[Token(Token = "0x60000A2")]
	public static double2x2 inverse(double2x2 m) { }

	[Address(RVA = "0x2A47560", Offset = "0x2A46960", Length = "0x1DF")]
	[Token(Token = "0x60000F2")]
	public static double3x3 inverse(double3x3 m) { }

	[Address(RVA = "0x2A45CE0", Offset = "0x2A450E0", Length = "0x8C")]
	[Token(Token = "0x600016E")]
	public static float2x2 inverse(float2x2 m) { }

	[Address(RVA = "0x2A49830", Offset = "0x2A48C30", Length = "0x1B")]
	[Token(Token = "0x600031F")]
	public static bool isfinite(float x) { }

	[Address(RVA = "0x2A497A0", Offset = "0x2A48BA0", Length = "0x3C")]
	[Token(Token = "0x6000320")]
	public static bool2 isfinite(float2 x) { }

	[Address(RVA = "0x2A49600", Offset = "0x2A48A00", Length = "0x27")]
	[Token(Token = "0x6000323")]
	public static bool isfinite(double x) { }

	[Address(RVA = "0x2A497E0", Offset = "0x2A48BE0", Length = "0x4B")]
	[Token(Token = "0x6000324")]
	public static bool2 isfinite(double2 x) { }

	[Address(RVA = "0x2A49850", Offset = "0x2A48C50", Length = "0x7A")]
	[Token(Token = "0x6000325")]
	public static bool3 isfinite(double3 x) { }

	[Address(RVA = "0x2A49720", Offset = "0x2A48B20", Length = "0x7E")]
	[Token(Token = "0x6000326")]
	public static bool4 isfinite(double4 x) { }

	[Address(RVA = "0x2A496B0", Offset = "0x2A48AB0", Length = "0x6D")]
	[Token(Token = "0x6000322")]
	public static bool4 isfinite(float4 x) { }

	[Address(RVA = "0x2A49630", Offset = "0x2A48A30", Length = "0x73")]
	[Token(Token = "0x6000321")]
	public static bool3 isfinite(float3 x) { }

	[Address(RVA = "0x2A49B50", Offset = "0x2A48F50", Length = "0xB1")]
	[Token(Token = "0x600032A")]
	public static bool4 isinf(float4 x) { }

	[Address(RVA = "0x2A49AE0", Offset = "0x2A48EE0", Length = "0x69")]
	[Token(Token = "0x600032C")]
	public static bool2 isinf(double2 x) { }

	[Address(RVA = "0x2A49990", Offset = "0x2A48D90", Length = "0x29")]
	[Token(Token = "0x600032B")]
	public static bool isinf(double x) { }

	[Address(RVA = "0x2A498F0", Offset = "0x2A48CF0", Length = "0x93")]
	[Token(Token = "0x600032D")]
	public static bool3 isinf(double3 x) { }

	[Address(RVA = "0x2A499C0", Offset = "0x2A48DC0", Length = "0xB9")]
	[Token(Token = "0x600032E")]
	public static bool4 isinf(double4 x) { }

	[Address(RVA = "0x2A49C10", Offset = "0x2A49010", Length = "0x8C")]
	[Token(Token = "0x6000329")]
	public static bool3 isinf(float3 x) { }

	[Address(RVA = "0x2A49A80", Offset = "0x2A48E80", Length = "0x5A")]
	[Token(Token = "0x6000328")]
	public static bool2 isinf(float2 x) { }

	[Address(RVA = "0x2A498D0", Offset = "0x2A48CD0", Length = "0x1D")]
	[Token(Token = "0x6000327")]
	public static bool isinf(float x) { }

	[Address(RVA = "0x2A49D50", Offset = "0x2A49150", Length = "0x66")]
	[Token(Token = "0x6000336")]
	public static bool4 isnan(double4 x) { }

	[Address(RVA = "0x2048300", Offset = "0x2047700", Length = "0x11")]
	[Token(Token = "0x600032F")]
	public static bool isnan(float x) { }

	[Address(RVA = "0x2A49CA0", Offset = "0x2A490A0", Length = "0x5E")]
	[Token(Token = "0x6000335")]
	public static bool3 isnan(double3 x) { }

	[Address(RVA = "0x2A49DC0", Offset = "0x2A491C0", Length = "0x3D")]
	[Token(Token = "0x6000334")]
	public static bool2 isnan(double2 x) { }

	[Address(RVA = "0x2020040", Offset = "0x201F440", Length = "0x23")]
	[Token(Token = "0x6000333")]
	public static bool isnan(double x) { }

	[Address(RVA = "0x2A49E00", Offset = "0x2A49200", Length = "0x51")]
	[Token(Token = "0x6000332")]
	public static bool4 isnan(float4 x) { }

	[Address(RVA = "0x2A49E60", Offset = "0x2A49260", Length = "0x63")]
	[Token(Token = "0x6000331")]
	public static bool3 isnan(float3 x) { }

	[Address(RVA = "0x2A49D00", Offset = "0x2A49100", Length = "0x4B")]
	[Token(Token = "0x6000330")]
	public static bool2 isnan(float2 x) { }

	[Address(RVA = "0x2A49F40", Offset = "0x2A49340", Length = "0x3E")]
	[Token(Token = "0x6000338")]
	public static bool2 ispow2(int2 x) { }

	[Address(RVA = "0x2A49F80", Offset = "0x2A49380", Length = "0x69")]
	[Token(Token = "0x600033E")]
	public static bool4 ispow2(uint4 x) { }

	[Address(RVA = "0x2A4A040", Offset = "0x2A49440", Length = "0x5B")]
	[Token(Token = "0x600033D")]
	public static bool3 ispow2(uint3 x) { }

	[Address(RVA = "0x2A4A000", Offset = "0x2A49400", Length = "0x3E")]
	[Token(Token = "0x600033C")]
	public static bool2 ispow2(uint2 x) { }

	[Address(RVA = "0x2A49FF0", Offset = "0x2A493F0", Length = "0x10")]
	[Token(Token = "0x600033B")]
	public static bool ispow2(uint x) { }

	[Address(RVA = "0x2A4A0A0", Offset = "0x2A494A0", Length = "0x69")]
	[Token(Token = "0x600033A")]
	public static bool4 ispow2(int4 x) { }

	[Address(RVA = "0x2A49ED0", Offset = "0x2A492D0", Length = "0x5E")]
	[Token(Token = "0x6000339")]
	public static bool3 ispow2(int3 x) { }

	[Address(RVA = "0x2A49F30", Offset = "0x2A49330", Length = "0x10")]
	[Token(Token = "0x6000337")]
	public static bool ispow2(int x) { }

	[Address(RVA = "0x2A4A110", Offset = "0x2A49510", Length = "0x10")]
	[Token(Token = "0x6000601")]
	public static float3 left() { }

	[Address(RVA = "0x2A24DA0", Offset = "0x2A241A0", Length = "0xD")]
	[Token(Token = "0x60004BA")]
	public static float length(float x) { }

	[Address(RVA = "0x2A4A120", Offset = "0x2A49520", Length = "0x24")]
	[Token(Token = "0x60004BB")]
	public static float length(float2 x) { }

	[Address(RVA = "0x8FDC90", Offset = "0x8FD090", Length = "0x3D")]
	[Token(Token = "0x60004BC")]
	public static float length(float3 x) { }

	[Address(RVA = "0x2A4A290", Offset = "0x2A49690", Length = "0x53")]
	[Token(Token = "0x60004BD")]
	public static float length(float4 x) { }

	[Address(RVA = "0x2A24FE0", Offset = "0x2A243E0", Length = "0x18")]
	[Token(Token = "0x60004BE")]
	public static double length(double x) { }

	[Address(RVA = "0x2A1D160", Offset = "0x2A1C560", Length = "0xF2")]
	[Token(Token = "0x60004BF")]
	public static double length(double2 x) { }

	[Address(RVA = "0x2A4A150", Offset = "0x2A49550", Length = "0xA4")]
	[Token(Token = "0x60004C1")]
	public static double length(double4 x) { }

	[Address(RVA = "0x2A4A200", Offset = "0x2A49600", Length = "0x8F")]
	[Token(Token = "0x60004C0")]
	public static double length(double3 x) { }

	[Address(RVA = "0x2A4A290", Offset = "0x2A49690", Length = "0x53")]
	[Token(Token = "0x60006EA")]
	public static float length(quaternion q) { }

	[Address(RVA = "0x2A4A2F0", Offset = "0x2A496F0", Length = "0x4D")]
	[Token(Token = "0x60006EB")]
	public static float lengthsq(quaternion q) { }

	[Address(RVA = "0x2A4A360", Offset = "0x2A49760", Length = "0x33")]
	[Token(Token = "0x60004C8")]
	public static double lengthsq(double3 x) { }

	[Address(RVA = "0x2A4A340", Offset = "0x2A49740", Length = "0x1E")]
	[Token(Token = "0x60004C7")]
	public static double lengthsq(double2 x) { }

	[Address(RVA = "0x2A4A3E0", Offset = "0x2A497E0", Length = "0x40")]
	[Token(Token = "0x60004C9")]
	public static double lengthsq(double4 x) { }

	[Address(RVA = "0x2A4A2F0", Offset = "0x2A496F0", Length = "0x4D")]
	[Token(Token = "0x60004C5")]
	public static float lengthsq(float4 x) { }

	[Address(RVA = "0x2A4A3A0", Offset = "0x2A497A0", Length = "0x34")]
	[Token(Token = "0x60004C4")]
	public static float lengthsq(float3 x) { }

	[Address(RVA = "0x2A4A420", Offset = "0x2A49820", Length = "0x1E")]
	[Token(Token = "0x60004C3")]
	public static float lengthsq(float2 x) { }

	[Address(RVA = "0x1DE8820", Offset = "0x1DE7C20", Length = "0x5")]
	[Token(Token = "0x60004C2")]
	public static float lengthsq(float x) { }

	[Address(RVA = "0x28995F0", Offset = "0x28989F0", Length = "0x5")]
	[Token(Token = "0x60004C6")]
	public static double lengthsq(double x) { }

	[Address(RVA = "0x2A4A5E0", Offset = "0x2A499E0", Length = "0x4E")]
	[Token(Token = "0x6000367")]
	public static float2 lerp(float2 start, float2 end, float2 t) { }

	[Address(RVA = "0x2A4A630", Offset = "0x2A49A30", Length = "0xB4")]
	[Token(Token = "0x6000370")]
	public static double4 lerp(double4 start, double4 end, double4 t) { }

	[Address(RVA = "0x2A4A820", Offset = "0x2A49C20", Length = "0x64")]
	[Token(Token = "0x6000365")]
	public static float3 lerp(float3 start, float3 end, float t) { }

	[Address(RVA = "0x2A4A960", Offset = "0x2A49D60", Length = "0x45")]
	[Token(Token = "0x6000364")]
	public static float2 lerp(float2 start, float2 end, float t) { }

	[Address(RVA = "0x7A9510", Offset = "0x7A8910", Length = "0x10")]
	[Token(Token = "0x6000363")]
	public static float lerp(float start, float end, float t) { }

	[Address(RVA = "0x2A4A890", Offset = "0x2A49C90", Length = "0x46")]
	[Token(Token = "0x600036E")]
	public static double2 lerp(double2 start, double2 end, double2 t) { }

	[Address(RVA = "0x2A4A4C0", Offset = "0x2A498C0", Length = "0x3E")]
	[Token(Token = "0x600036B")]
	public static double2 lerp(double2 start, double2 end, double t) { }

	[Address(RVA = "0x2A4A9B0", Offset = "0x2A49DB0", Length = "0xB2")]
	[Token(Token = "0x6000366")]
	public static float4 lerp(float4 start, float4 end, float t) { }

	[Address(RVA = "0x2A4A6F0", Offset = "0x2A49AF0", Length = "0x8A")]
	[Token(Token = "0x600036F")]
	public static double3 lerp(double3 start, double3 end, double3 t) { }

	[Address(RVA = "0x2A4A500", Offset = "0x2A49900", Length = "0xDE")]
	[Token(Token = "0x6000369")]
	public static float4 lerp(float4 start, float4 end, float4 t) { }

	[Address(RVA = "0x2A4A780", Offset = "0x2A49B80", Length = "0x94")]
	[Token(Token = "0x600036D")]
	public static double4 lerp(double4 start, double4 end, double t) { }

	[Address(RVA = "0x2A4A440", Offset = "0x2A49840", Length = "0x72")]
	[Token(Token = "0x6000368")]
	public static float3 lerp(float3 start, float3 end, float3 t) { }

	[Address(RVA = "0x2A4AA70", Offset = "0x2A49E70", Length = "0xD")]
	[Token(Token = "0x600036A")]
	public static double lerp(double start, double end, double t) { }

	[Address(RVA = "0x2A4A8E0", Offset = "0x2A49CE0", Length = "0x71")]
	[Token(Token = "0x600036C")]
	public static double3 lerp(double3 start, double3 end, double t) { }

	[Address(RVA = "0x2A4C0E0", Offset = "0x2A4B4E0", Length = "0x1AA")]
	[Token(Token = "0x60006F2")]
	public static quaternion log(quaternion q) { }

	[Address(RVA = "0x2A4BF80", Offset = "0x2A4B380", Length = "0x15C")]
	[Token(Token = "0x600047D")]
	public static double4 log(double4 x) { }

	[Address(RVA = "0x2A4BD50", Offset = "0x2A4B150", Length = "0x108")]
	[Token(Token = "0x600047C")]
	public static double3 log(double3 x) { }

	[Address(RVA = "0x2A4B9A0", Offset = "0x2A4ADA0", Length = "0xB8")]
	[Token(Token = "0x600047B")]
	public static double2 log(double2 x) { }

	[Address(RVA = "0x2A4BA60", Offset = "0x2A4AE60", Length = "0x4E")]
	[Token(Token = "0x600047A")]
	public static double log(double x) { }

	[Address(RVA = "0x2A4BB10", Offset = "0x2A4AF10", Length = "0x17C")]
	[Token(Token = "0x6000479")]
	public static float4 log(float4 x) { }

	[Address(RVA = "0x2A4BE60", Offset = "0x2A4B260", Length = "0x120")]
	[Token(Token = "0x6000478")]
	public static float3 log(float3 x) { }

	[Address(RVA = "0x2A4BC90", Offset = "0x2A4B090", Length = "0xB4")]
	[Token(Token = "0x6000477")]
	public static float2 log(float2 x) { }

	[Address(RVA = "0x2A4BAB0", Offset = "0x2A4AEB0", Length = "0x57")]
	[Token(Token = "0x6000476")]
	public static float log(float x) { }

	[Address(RVA = "0x2A4B110", Offset = "0x2A4A510", Length = "0x57")]
	[Token(Token = "0x6000486")]
	public static float log10(float x) { }

	[Address(RVA = "0x2A4AF30", Offset = "0x2A4A330", Length = "0xB4")]
	[Token(Token = "0x6000487")]
	public static float2 log10(float2 x) { }

	[Address(RVA = "0x2A4AFF0", Offset = "0x2A4A3F0", Length = "0x120")]
	[Token(Token = "0x6000488")]
	public static float3 log10(float3 x) { }

	[Address(RVA = "0x2A4ACA0", Offset = "0x2A4A0A0", Length = "0x17C")]
	[Token(Token = "0x6000489")]
	public static float4 log10(float4 x) { }

	[Address(RVA = "0x2A4B170", Offset = "0x2A4A570", Length = "0x4E")]
	[Token(Token = "0x600048A")]
	public static double log10(double x) { }

	[Address(RVA = "0x2A4AA80", Offset = "0x2A49E80", Length = "0xB8")]
	[Token(Token = "0x600048B")]
	public static double2 log10(double2 x) { }

	[Address(RVA = "0x2A4AE20", Offset = "0x2A4A220", Length = "0x108")]
	[Token(Token = "0x600048C")]
	public static double3 log10(double3 x) { }

	[Address(RVA = "0x2A4AB40", Offset = "0x2A49F40", Length = "0x15C")]
	[Token(Token = "0x600048D")]
	public static double4 log10(double4 x) { }

	[Address(RVA = "0x2A4B700", Offset = "0x2A4AB00", Length = "0x11B")]
	[Token(Token = "0x6000484")]
	public static double3 log2(double3 x) { }

	[Address(RVA = "0x2A4B820", Offset = "0x2A4AC20", Length = "0x175")]
	[Token(Token = "0x6000485")]
	public static double4 log2(double4 x) { }

	[Address(RVA = "0x2A4B560", Offset = "0x2A4A960", Length = "0x196")]
	[Token(Token = "0x6000481")]
	public static float4 log2(float4 x) { }

	[Address(RVA = "0x2A4B420", Offset = "0x2A4A820", Length = "0x134")]
	[Token(Token = "0x6000480")]
	public static float3 log2(float3 x) { }

	[Address(RVA = "0x2A4B230", Offset = "0x2A4A630", Length = "0xC2")]
	[Token(Token = "0x600047F")]
	public static float2 log2(float2 x) { }

	[Address(RVA = "0x2A4B1C0", Offset = "0x2A4A5C0", Length = "0x62")]
	[Token(Token = "0x600047E")]
	public static float log2(float x) { }

	[Address(RVA = "0x2A4B300", Offset = "0x2A4A700", Length = "0xBF")]
	[Token(Token = "0x6000483")]
	public static double2 log2(double2 x) { }

	[Address(RVA = "0x2A4B3C0", Offset = "0x2A4A7C0", Length = "0x59")]
	[Token(Token = "0x6000482")]
	public static double log2(double x) { }

	[Address(RVA = "0x1C39710", Offset = "0x1C38B10", Length = "0x43")]
	[Token(Token = "0x600055C")]
	public static int lzcnt(uint x) { }

	[Address(RVA = "0x1C39710", Offset = "0x1C38B10", Length = "0x43")]
	[Token(Token = "0x6000558")]
	public static int lzcnt(int x) { }

	[Address(RVA = "0x2A4C530", Offset = "0x2A4B930", Length = "0x5A")]
	[Token(Token = "0x6000561")]
	public static int lzcnt(ulong x) { }

	[Address(RVA = "0x2A4C530", Offset = "0x2A4B930", Length = "0x5A")]
	[Token(Token = "0x6000560")]
	public static int lzcnt(long x) { }

	[Address(RVA = "0x2A4C490", Offset = "0x2A4B890", Length = "0x9B")]
	[Token(Token = "0x6000559")]
	public static int2 lzcnt(int2 x) { }

	[Address(RVA = "0x2A4C290", Offset = "0x2A4B690", Length = "0xDA")]
	[Token(Token = "0x600055A")]
	public static int3 lzcnt(int3 x) { }

	[Address(RVA = "0x2A4C370", Offset = "0x2A4B770", Length = "0x116")]
	[Token(Token = "0x600055B")]
	public static int4 lzcnt(int4 x) { }

	[Address(RVA = "0x2A4C370", Offset = "0x2A4B770", Length = "0x116")]
	[Token(Token = "0x600055F")]
	public static int4 lzcnt(uint4 x) { }

	[Address(RVA = "0x2A4C490", Offset = "0x2A4B890", Length = "0x9B")]
	[Token(Token = "0x600055D")]
	public static int2 lzcnt(uint2 x) { }

	[Address(RVA = "0x2A4C290", Offset = "0x2A4B690", Length = "0xDA")]
	[Token(Token = "0x600055E")]
	public static int3 lzcnt(uint3 x) { }

	[Address(RVA = "0x2A4C880", Offset = "0x2A4BC80", Length = "0xA3")]
	[Token(Token = "0x600038E")]
	public static float4 mad(float4 mulA, float4 mulB, float4 addC) { }

	[Address(RVA = "0x2A4C9C0", Offset = "0x2A4BDC0", Length = "0x5B")]
	[Token(Token = "0x600038D")]
	public static float3 mad(float3 mulA, float3 mulB, float3 addC) { }

	[Address(RVA = "0x2A4C930", Offset = "0x2A4BD30", Length = "0x7A")]
	[Token(Token = "0x6000392")]
	public static double4 mad(double4 mulA, double4 mulB, double4 addC) { }

	[Address(RVA = "0x2A4C7C0", Offset = "0x2A4BBC0", Length = "0x42")]
	[Token(Token = "0x600038C")]
	public static float2 mad(float2 mulA, float2 mulB, float2 addC) { }

	[Address(RVA = "0x2A4C650", Offset = "0x2A4BA50", Length = "0x42")]
	[Token(Token = "0x6000386")]
	public static uint2 mad(uint2 mulA, uint2 mulB, uint2 addC) { }

	[Address(RVA = "0x2A4C820", Offset = "0x2A4BC20", Length = "0x9")]
	[Token(Token = "0x600038B")]
	public static float mad(float mulA, float mulB, float addC) { }

	[Address(RVA = "0x2A4C810", Offset = "0x2A4BC10", Length = "0x9")]
	[Token(Token = "0x600038A")]
	public static ulong mad(ulong mulA, ulong mulB, ulong addC) { }

	[Address(RVA = "0x2A4C810", Offset = "0x2A4BC10", Length = "0x9")]
	[Token(Token = "0x6000389")]
	public static long mad(long mulA, long mulB, long addC) { }

	[Address(RVA = "0x2A4C590", Offset = "0x2A4B990", Length = "0xB1")]
	[Token(Token = "0x6000388")]
	public static uint4 mad(uint4 mulA, uint4 mulB, uint4 addC) { }

	[Address(RVA = "0x2A4C6A0", Offset = "0x2A4BAA0", Length = "0xB6")]
	[Token(Token = "0x6000387")]
	public static uint3 mad(uint3 mulA, uint3 mulB, uint3 addC) { }

	[Address(RVA = "0x2A4C6A0", Offset = "0x2A4BAA0", Length = "0xB6")]
	[Token(Token = "0x6000383")]
	public static int3 mad(int3 mulA, int3 mulB, int3 addC) { }

	[Address(RVA = "0x2A4C590", Offset = "0x2A4B990", Length = "0xB1")]
	[Token(Token = "0x6000384")]
	public static int4 mad(int4 mulA, int4 mulB, int4 addC) { }

	[Address(RVA = "0x2A4C830", Offset = "0x2A4BC30", Length = "0x9")]
	[Token(Token = "0x600038F")]
	public static double mad(double mulA, double mulB, double addC) { }

	[Address(RVA = "0x2A4C840", Offset = "0x2A4BC40", Length = "0x37")]
	[Token(Token = "0x6000390")]
	public static double2 mad(double2 mulA, double2 mulB, double2 addC) { }

	[Address(RVA = "0x2A4C9B0", Offset = "0x2A4BDB0", Length = "0x8")]
	[Token(Token = "0x6000385")]
	public static uint mad(uint mulA, uint mulB, uint addC) { }

	[Address(RVA = "0x2A4C650", Offset = "0x2A4BA50", Length = "0x42")]
	[Token(Token = "0x6000382")]
	public static int2 mad(int2 mulA, int2 mulB, int2 addC) { }

	[Address(RVA = "0x2A4C9B0", Offset = "0x2A4BDB0", Length = "0x8")]
	[Token(Token = "0x6000381")]
	public static int mad(int mulA, int mulB, int addC) { }

	[Address(RVA = "0x2A4C760", Offset = "0x2A4BB60", Length = "0x5D")]
	[Token(Token = "0x6000391")]
	public static double3 mad(double3 mulA, double3 mulB, double3 addC) { }

	[Address(RVA = "0x2A4CB30", Offset = "0x2A4BF30", Length = "0x76")]
	[Token(Token = "0x600035D")]
	public static float3 max(float3 x, float3 y) { }

	[Address(RVA = "0x2A4CE90", Offset = "0x2A4C290", Length = "0x8")]
	[Token(Token = "0x6000355")]
	public static uint max(uint x, uint y) { }

	[Address(RVA = "0x2A4CEA0", Offset = "0x2A4C2A0", Length = "0x2B")]
	[Token(Token = "0x6000356")]
	public static uint2 max(uint2 x, uint2 y) { }

	[Address(RVA = "0x2A4CD10", Offset = "0x2A4C110", Length = "0x54")]
	[Token(Token = "0x6000354")]
	public static int4 max(int4 x, int4 y) { }

	[Address(RVA = "0x2A4CAC0", Offset = "0x2A4BEC0", Length = "0x3B")]
	[Token(Token = "0x6000353")]
	public static int3 max(int3 x, int3 y) { }

	[Address(RVA = "0x2A4CB00", Offset = "0x2A4BF00", Length = "0x2B")]
	[Token(Token = "0x6000352")]
	public static int2 max(int2 x, int2 y) { }

	[Address(RVA = "0x2A4CC10", Offset = "0x2A4C010", Length = "0x8")]
	[Token(Token = "0x6000351")]
	public static int max(int x, int y) { }

	[Address(RVA = "0x2A4CCB0", Offset = "0x2A4C0B0", Length = "0x54")]
	[Token(Token = "0x6000358")]
	public static uint4 max(uint4 x, uint4 y) { }

	[Address(RVA = "0x2A4CC20", Offset = "0x2A4C020", Length = "0x87")]
	[Token(Token = "0x6000361")]
	public static double3 max(double3 x, double3 y) { }

	[Address(RVA = "0x2A4CD70", Offset = "0x2A4C170", Length = "0x61")]
	[Token(Token = "0x6000360")]
	public static double2 max(double2 x, double2 y) { }

	[Address(RVA = "0x2A4CBE0", Offset = "0x2A4BFE0", Length = "0x2B")]
	[Token(Token = "0x600035F")]
	public static double max(double x, double y) { }

	[Address(RVA = "0x2A4CED0", Offset = "0x2A4C2D0", Length = "0xB")]
	[Token(Token = "0x6000359")]
	public static long max(long x, long y) { }

	[Address(RVA = "0x2A4CBD0", Offset = "0x2A4BFD0", Length = "0xB")]
	[Token(Token = "0x600035A")]
	public static ulong max(ulong x, ulong y) { }

	[Address(RVA = "0x2A4CF20", Offset = "0x2A4C320", Length = "0x5F")]
	[Token(Token = "0x600035C")]
	public static float2 max(float2 x, float2 y) { }

	[Address(RVA = "0x2A4CA20", Offset = "0x2A4BE20", Length = "0x9D")]
	[Token(Token = "0x600035E")]
	public static float4 max(float4 x, float4 y) { }

	[Address(RVA = "0x2A4CBB0", Offset = "0x2A4BFB0", Length = "0x18")]
	[Token(Token = "0x600035B")]
	public static float max(float x, float y) { }

	[Address(RVA = "0x2A4CEE0", Offset = "0x2A4C2E0", Length = "0x3B")]
	[Token(Token = "0x6000357")]
	public static uint3 max(uint3 x, uint3 y) { }

	[Address(RVA = "0x2A4CDE0", Offset = "0x2A4C1E0", Length = "0xAD")]
	[Token(Token = "0x6000362")]
	public static double4 max(double4 x, double4 y) { }

	[Address(RVA = "0x2A4D3E0", Offset = "0x2A4C7E0", Length = "0xB")]
	[Token(Token = "0x6000347")]
	public static long min(long x, long y) { }

	[Address(RVA = "0x2A4D420", Offset = "0x2A4C820", Length = "0xB")]
	[Token(Token = "0x6000348")]
	public static ulong min(ulong x, ulong y) { }

	[Address(RVA = "0x8FDCD0", Offset = "0x8FD0D0", Length = "0x5F")]
	[Token(Token = "0x600034A")]
	public static float2 min(float2 x, float2 y) { }

	[Address(RVA = "0x2A4D020", Offset = "0x2A4C420", Length = "0x76")]
	[Token(Token = "0x600034B")]
	public static float3 min(float3 x, float3 y) { }

	[Address(RVA = "0x2A4D2E0", Offset = "0x2A4C6E0", Length = "0x9D")]
	[Token(Token = "0x600034C")]
	public static float4 min(float4 x, float4 y) { }

	[Address(RVA = "0x2A4D170", Offset = "0x2A4C570", Length = "0x2B")]
	[Token(Token = "0x600034D")]
	public static double min(double x, double y) { }

	[Address(RVA = "0x2A4D0A0", Offset = "0x2A4C4A0", Length = "0x61")]
	[Token(Token = "0x600034E")]
	public static double2 min(double2 x, double2 y) { }

	[Address(RVA = "0x2A4D280", Offset = "0x2A4C680", Length = "0x18")]
	[Token(Token = "0x6000349")]
	public static float min(float x, float y) { }

	[Address(RVA = "0x2A4CF80", Offset = "0x2A4C380", Length = "0x8")]
	[Token(Token = "0x600033F")]
	public static int min(int x, int y) { }

	[Address(RVA = "0x2A4D440", Offset = "0x2A4C840", Length = "0x3B")]
	[Token(Token = "0x6000341")]
	public static int3 min(int3 x, int3 y) { }

	[Address(RVA = "0x2A4D1A0", Offset = "0x2A4C5A0", Length = "0xAD")]
	[Token(Token = "0x6000350")]
	public static double4 min(double4 x, double4 y) { }

	[Address(RVA = "0x2A4D110", Offset = "0x2A4C510", Length = "0x54")]
	[Token(Token = "0x6000342")]
	public static int4 min(int4 x, int4 y) { }

	[Address(RVA = "0x2A4D430", Offset = "0x2A4C830", Length = "0x8")]
	[Token(Token = "0x6000343")]
	public static uint min(uint x, uint y) { }

	[Address(RVA = "0x2A4D250", Offset = "0x2A4C650", Length = "0x2B")]
	[Token(Token = "0x6000344")]
	public static uint2 min(uint2 x, uint2 y) { }

	[Address(RVA = "0x2A4D2A0", Offset = "0x2A4C6A0", Length = "0x3B")]
	[Token(Token = "0x6000345")]
	public static uint3 min(uint3 x, uint3 y) { }

	[Address(RVA = "0x2A4D380", Offset = "0x2A4C780", Length = "0x54")]
	[Token(Token = "0x6000346")]
	public static uint4 min(uint4 x, uint4 y) { }

	[Address(RVA = "0x2A4D3F0", Offset = "0x2A4C7F0", Length = "0x2B")]
	[Token(Token = "0x6000340")]
	public static int2 min(int2 x, int2 y) { }

	[Address(RVA = "0x2A4CF90", Offset = "0x2A4C390", Length = "0x87")]
	[Token(Token = "0x600034F")]
	public static double3 min(double3 x, double3 y) { }

	[Address(RVA = "0x2A4DAD0", Offset = "0x2A4CED0", Length = "0x1AD")]
	[Token(Token = "0x600049D")]
	public static double4 modf(double4 x, out double4 i) { }

	[Address(RVA = "0x2A4D480", Offset = "0x2A4C880", Length = "0x144")]
	[Token(Token = "0x600049C")]
	public static double3 modf(double3 x, out double3 i) { }

	[Address(RVA = "0x2A4DC80", Offset = "0x2A4D080", Length = "0xE5")]
	[Token(Token = "0x600049B")]
	public static double2 modf(double2 x, out double2 i) { }

	[Address(RVA = "0x2A4D800", Offset = "0x2A4CC00", Length = "0x62")]
	[Token(Token = "0x600049A")]
	public static double modf(double x, out double i) { }

	[Address(RVA = "0x2A4D5D0", Offset = "0x2A4C9D0", Length = "0x222")]
	[Token(Token = "0x6000499")]
	public static float4 modf(float4 x, out float4 i) { }

	[Address(RVA = "0x2A4D970", Offset = "0x2A4CD70", Length = "0x155")]
	[Token(Token = "0x6000498")]
	public static float3 modf(float3 x, out float3 i) { }

	[Address(RVA = "0x2A4D870", Offset = "0x2A4CC70", Length = "0xF3")]
	[Token(Token = "0x6000497")]
	public static float2 modf(float2 x, out float2 i) { }

	[Address(RVA = "0x2A4DD70", Offset = "0x2A4D170", Length = "0x6D")]
	[Token(Token = "0x6000496")]
	public static float modf(float x, out float i) { }

	[Address(RVA = "0x2A4DDE0", Offset = "0x2A4D1E0", Length = "0x10C")]
	[Token(Token = "0x6000612")]
	internal static float4 movehl(float4 a, float4 b) { }

	[Address(RVA = "0x2A1D260", Offset = "0x2A1C660", Length = "0x13D")]
	[Token(Token = "0x6000613")]
	internal static double4 movehl(double4 a, double4 b) { }

	[Address(RVA = "0x2A4DEF0", Offset = "0x2A4D2F0", Length = "0x10C")]
	[Token(Token = "0x6000610")]
	internal static float4 movelh(float4 a, float4 b) { }

	[Address(RVA = "0x2A1D3A0", Offset = "0x2A1C7A0", Length = "0x13D")]
	[Token(Token = "0x6000611")]
	internal static double4 movelh(double4 a, double4 b) { }

	[Address(RVA = "0x2A528E0", Offset = "0x2A51CE0", Length = "0x111")]
	[Token(Token = "0x60006A2")]
	public static int3 mul(int3x4 a, int4 b) { }

	[Address(RVA = "0x2A5EDB0", Offset = "0x2A5E1B0", Length = "0x643")]
	[Token(Token = "0x600064F")]
	public static float4x4 mul(float4x4 a, float4x4 b) { }

	[Address(RVA = "0x2A532D0", Offset = "0x2A526D0", Length = "0x76")]
	[Token(Token = "0x6000654")]
	public static double4 mul(double2 a, double2x4 b) { }

	[Address(RVA = "0x2A4F470", Offset = "0x2A4E870", Length = "0xBC")]
	[Token(Token = "0x600065B")]
	public static double3 mul(double4 a, double4x3 b) { }

	[Address(RVA = "0x2A50EB0", Offset = "0x2A502B0", Length = "0x4CE")]
	[Token(Token = "0x60006A5")]
	public static int3x4 mul(int3x4 a, int4x4 b) { }

	[Address(RVA = "0x2A53080", Offset = "0x2A52480", Length = "0x5C")]
	[Token(Token = "0x6000656")]
	public static double2 mul(double3 a, double3x2 b) { }

	[Address(RVA = "0x2A56D10", Offset = "0x2A56110", Length = "0x31E")]
	[Token(Token = "0x60006A4")]
	public static int3x3 mul(int3x4 a, int4x3 b) { }

	[Address(RVA = "0x2A55270", Offset = "0x2A54670", Length = "0x7A")]
	[Token(Token = "0x600065A")]
	public static double2 mul(double4 a, double4x2 b) { }

	[Address(RVA = "0x2A5D810", Offset = "0x2A5CC10", Length = "0x24B")]
	[Token(Token = "0x60006A3")]
	public static int3x2 mul(int3x4 a, int4x2 b) { }

	[Address(RVA = "0x2A2C9A0", Offset = "0x2A2BDA0", Length = "0x33")]
	[Token(Token = "0x6000659")]
	public static double mul(double4 a, double4 b) { }

	[Address(RVA = "0x2A59D10", Offset = "0x2A59110", Length = "0x4A7")]
	[Token(Token = "0x600064E")]
	public static float4x3 mul(float4x4 a, float4x3 b) { }

	[Address(RVA = "0x2A52BF0", Offset = "0x2A51FF0", Length = "0x62")]
	[Token(Token = "0x6000653")]
	public static double3 mul(double2 a, double2x3 b) { }

	[Address(RVA = "0x2A2CA70", Offset = "0x2A2BE70", Length = "0x25")]
	[Token(Token = "0x6000655")]
	public static double mul(double3 a, double3 b) { }

	[Address(RVA = "0x2A53CF0", Offset = "0x2A530F0", Length = "0x8F")]
	[Token(Token = "0x6000657")]
	public static double3 mul(double3 a, double3x3 b) { }

	[Address(RVA = "0x2A51380", Offset = "0x2A50780", Length = "0x2D8")]
	[Token(Token = "0x600064D")]
	public static float4x2 mul(float4x4 a, float4x2 b) { }

	[Address(RVA = "0x2A519E0", Offset = "0x2A50DE0", Length = "0xB2")]
	[Token(Token = "0x6000658")]
	public static double4 mul(double3 a, double3x4 b) { }

	[Address(RVA = "0x2A2C9E0", Offset = "0x2A2BDE0", Length = "0x27")]
	[Token(Token = "0x600068A")]
	public static int mul(int4 a, int4 b) { }

	[Address(RVA = "0x2A5ACF0", Offset = "0x2A5A0F0", Length = "0x293")]
	[Token(Token = "0x60006A0")]
	public static int3x3 mul(int3x3 a, int3x3 b) { }

	[Address(RVA = "0x2A2CA30", Offset = "0x2A2BE30", Length = "0x5")]
	[Token(Token = "0x6000650")]
	public static double mul(double a, double b) { }

	[Address(RVA = "0x2A570F0", Offset = "0x2A564F0", Length = "0x19E")]
	[Token(Token = "0x6000693")]
	public static int2x2 mul(int2x3 a, int3x2 b) { }

	[Address(RVA = "0x2A53350", Offset = "0x2A52750", Length = "0x26F")]
	[Token(Token = "0x6000694")]
	public static int2x3 mul(int2x3 a, int3x3 b) { }

	[Address(RVA = "0x2A501C0", Offset = "0x2A4F5C0", Length = "0x357")]
	[Token(Token = "0x6000695")]
	public static int2x4 mul(int2x3 a, int3x4 b) { }

	[Address(RVA = "0x2A527D0", Offset = "0x2A51BD0", Length = "0x104")]
	[Token(Token = "0x6000696")]
	public static int2 mul(int2x4 a, int4 b) { }

	[Address(RVA = "0x2A535C0", Offset = "0x2A529C0", Length = "0x227")]
	[Token(Token = "0x6000697")]
	public static int2x2 mul(int2x4 a, int4x2 b) { }

	[Address(RVA = "0x289BCD0", Offset = "0x289B0D0", Length = "0x17")]
	[Token(Token = "0x6000651")]
	public static double mul(double2 a, double2 b) { }

	[Address(RVA = "0x2A5C9A0", Offset = "0x2A5BDA0", Length = "0x3E")]
	[Token(Token = "0x6000652")]
	public static double2 mul(double2 a, double2x2 b) { }

	[Address(RVA = "0x2A4FA00", Offset = "0x2A4EE00", Length = "0x33D")]
	[Token(Token = "0x6000698")]
	public static int2x3 mul(int2x4 a, int4x3 b) { }

	[Address(RVA = "0x2A595C0", Offset = "0x2A589C0", Length = "0x3D6")]
	[Token(Token = "0x6000699")]
	public static int2x4 mul(int2x4 a, int4x4 b) { }

	[Address(RVA = "0x2A530E0", Offset = "0x2A524E0", Length = "0x93")]
	[Token(Token = "0x600069A")]
	public static int3 mul(int3x2 a, int2 b) { }

	[Address(RVA = "0x2A5DA60", Offset = "0x2A5CE60", Length = "0x121")]
	[Token(Token = "0x600069B")]
	public static int3x2 mul(int3x2 a, int2x2 b) { }

	[Address(RVA = "0x2A54470", Offset = "0x2A53870", Length = "0x1A0")]
	[Token(Token = "0x600069C")]
	public static int3x3 mul(int3x2 a, int2x3 b) { }

	[Address(RVA = "0x2A54BF0", Offset = "0x2A53FF0", Length = "0x333")]
	[Token(Token = "0x60006A1")]
	public static int3x4 mul(int3x3 a, int3x4 b) { }

	[Address(RVA = "0x2A55910", Offset = "0x2A54D10", Length = "0xBE")]
	[Token(Token = "0x6000692")]
	public static int2 mul(int2x3 a, int3 b) { }

	[Address(RVA = "0x2A53D80", Offset = "0x2A53180", Length = "0x19F")]
	[Token(Token = "0x6000690")]
	public static int2x3 mul(int2x2 a, int2x3 b) { }

	[Address(RVA = "0x2A5B1B0", Offset = "0x2A5A5B0", Length = "0x113")]
	[Token(Token = "0x600068F")]
	public static int2x2 mul(int2x2 a, int2x2 b) { }

	[Address(RVA = "0x2A53260", Offset = "0x2A52660", Length = "0x69")]
	[Token(Token = "0x600068E")]
	public static int2 mul(int2x2 a, int2 b) { }

	[Address(RVA = "0x2A4E260", Offset = "0x2A4D660", Length = "0xBE")]
	[Token(Token = "0x600068D")]
	public static int4 mul(int4 a, int4x4 b) { }

	[Address(RVA = "0x2A4EC70", Offset = "0x2A4E070", Length = "0x97")]
	[Token(Token = "0x600068C")]
	public static int3 mul(int4 a, int4x3 b) { }

	[Address(RVA = "0x2A55370", Offset = "0x2A54770", Length = "0x5B")]
	[Token(Token = "0x600068B")]
	public static int2 mul(int4 a, int4x2 b) { }

	[Address(RVA = "0x2A55000", Offset = "0x2A54400", Length = "0x264")]
	[Token(Token = "0x600069D")]
	public static int3x4 mul(int3x2 a, int2x4 b) { }

	[Address(RVA = "0x2A506A0", Offset = "0x2A4FAA0", Length = "0x9C")]
	[Token(Token = "0x6000689")]
	public static int4 mul(int3 a, int3x4 b) { }

	[Address(RVA = "0x2A4F530", Offset = "0x2A4E930", Length = "0x7F")]
	[Token(Token = "0x6000688")]
	public static int3 mul(int3 a, int3x3 b) { }

	[Address(RVA = "0x2A58F40", Offset = "0x2A58340", Length = "0x47")]
	[Token(Token = "0x6000687")]
	public static int2 mul(int3 a, int3x2 b) { }

	[Address(RVA = "0x2A2CA10", Offset = "0x2A2BE10", Length = "0x1B")]
	[Token(Token = "0x6000686")]
	public static int mul(int3 a, int3 b) { }

	[Address(RVA = "0x2A54F30", Offset = "0x2A54330", Length = "0xCD")]
	[Token(Token = "0x600069E")]
	public static int3 mul(int3x3 a, int3 b) { }

	[Address(RVA = "0x2A50740", Offset = "0x2A4FB40", Length = "0x19E")]
	[Token(Token = "0x600069F")]
	public static int3x2 mul(int3x3 a, int3x2 b) { }

	[Address(RVA = "0x2A4ED10", Offset = "0x2A4E110", Length = "0x21F")]
	[Token(Token = "0x6000691")]
	public static int2x4 mul(int2x2 a, int2x4 b) { }

	[Address(RVA = "0x2A4E7A0", Offset = "0x2A4DBA0", Length = "0x1AD")]
	[Token(Token = "0x600064C")]
	public static float4 mul(float4x4 a, float4 b) { }

	[Address(RVA = "0x2A5CFF0", Offset = "0x2A5C3F0", Length = "0x181")]
	[Token(Token = "0x6000676")]
	public static double4x2 mul(double4x2 a, double2x2 b) { }

	[Address(RVA = "0x2A599A0", Offset = "0x2A58DA0", Length = "0x368")]
	[Token(Token = "0x600064A")]
	public static float4x3 mul(float4x3 a, float3x3 b) { }

	[Address(RVA = "0x2A5A1C0", Offset = "0x2A595C0", Length = "0x8B")]
	[Token(Token = "0x6000634")]
	public static float2 mul(float2x4 a, float4 b) { }

	[Address(RVA = "0x2A4E320", Offset = "0x2A4D720", Length = "0x13E")]
	[Token(Token = "0x6000635")]
	public static float2x2 mul(float2x4 a, float4x2 b) { }

	[Address(RVA = "0x2A57A80", Offset = "0x2A56E80", Length = "0x1C9")]
	[Token(Token = "0x6000636")]
	public static float2x3 mul(float2x4 a, float4x3 b) { }

	[Address(RVA = "0x2A57F80", Offset = "0x2A57380", Length = "0xDD")]
	[Token(Token = "0x600065F")]
	public static double2x3 mul(double2x2 a, double2x3 b) { }

	[Address(RVA = "0x2A57710", Offset = "0x2A56B10", Length = "0x12E")]
	[Token(Token = "0x6000660")]
	public static double2x4 mul(double2x2 a, double2x4 b) { }

	[Address(RVA = "0x2A4E950", Offset = "0x2A4DD50", Length = "0x6A")]
	[Token(Token = "0x6000661")]
	public static double2 mul(double2x3 a, double3 b) { }

	[Address(RVA = "0x2A566A0", Offset = "0x2A55AA0", Length = "0xC8")]
	[Token(Token = "0x6000662")]
	public static double2x2 mul(double2x3 a, double3x2 b) { }

	[Address(RVA = "0x2A5C670", Offset = "0x2A5BA70", Length = "0x149")]
	[Token(Token = "0x6000663")]
	public static double2x3 mul(double2x3 a, double3x3 b) { }

	[Address(RVA = "0x2A55D20", Offset = "0x2A55120", Length = "0x88")]
	[Token(Token = "0x600065E")]
	public static double2x2 mul(double2x2 a, double2x2 b) { }

	[Address(RVA = "0x2A59400", Offset = "0x2A58800", Length = "0x1BD")]
	[Token(Token = "0x6000664")]
	public static double2x4 mul(double2x3 a, double3x4 b) { }

	[Address(RVA = "0x2A50520", Offset = "0x2A4F920", Length = "0x11C")]
	[Token(Token = "0x6000666")]
	public static double2x2 mul(double2x4 a, double4x2 b) { }

	[Address(RVA = "0x2A5CC90", Offset = "0x2A5C090", Length = "0x1B3")]
	[Token(Token = "0x6000667")]
	public static double2x3 mul(double2x4 a, double4x3 b) { }

	[Address(RVA = "0x2A582E0", Offset = "0x2A576E0", Length = "0x277")]
	[Token(Token = "0x6000637")]
	public static float2x4 mul(float2x4 a, float4x4 b) { }

	[Address(RVA = "0x2A5BBE0", Offset = "0x2A5AFE0", Length = "0x98")]
	[Token(Token = "0x600001E")]
	public static AffineTransform mul(AffineTransform a, float3x3 b) { }

	[Address(RVA = "0x2A508E0", Offset = "0x2A4FCE0", Length = "0x23F")]
	[Token(Token = "0x6000668")]
	public static double2x4 mul(double2x4 a, double4x4 b) { }

	[Address(RVA = "0x2A52580", Offset = "0x2A51980", Length = "0x74")]
	[Token(Token = "0x6000638")]
	public static float3 mul(float3x2 a, float2 b) { }

	[Address(RVA = "0x2A5F400", Offset = "0x2A5E800", Length = "0x143")]
	[Token(Token = "0x600001F")]
	public static float4 mul(AffineTransform a, float4 pos) { }

	[Address(RVA = "0x2A56050", Offset = "0x2A55450", Length = "0x89")]
	[Token(Token = "0x6000669")]
	public static double3 mul(double3x2 a, double2 b) { }

	[Address(RVA = "0x2A5DB90", Offset = "0x2A5CF90", Length = "0x8F")]
	[Token(Token = "0x6000665")]
	public static double2 mul(double2x4 a, double4 b) { }

	[Address(RVA = "0x2A4F920", Offset = "0x2A4ED20", Length = "0x93")]
	[Token(Token = "0x60006A6")]
	public static int4 mul(int4x2 a, int2 b) { }

	[Address(RVA = "0x2A4F5B0", Offset = "0x2A4E9B0", Length = "0x1ED")]
	[Token(Token = "0x6000633")]
	public static float2x4 mul(float2x3 a, float3x4 b) { }

	[Address(RVA = "0x2A50BC0", Offset = "0x2A4FFC0", Length = "0xF6")]
	[Token(Token = "0x6000631")]
	public static float2x2 mul(float2x3 a, float3x2 b) { }

	[Address(RVA = "0x2A5E880", Offset = "0x2A5DC80", Length = "0x106")]
	[Token(Token = "0x600062B")]
	public static float4 mul(float4 a, float4x4 b) { }

	[Address(RVA = "0x2A4F9C0", Offset = "0x2A4EDC0", Length = "0x3E")]
	[Token(Token = "0x600062C")]
	public static float2 mul(float2x2 a, float2 b) { }

	[Address(RVA = "0x2A4E6E0", Offset = "0x2A4DAE0", Length = "0xB4")]
	[Token(Token = "0x600062A")]
	public static float3 mul(float4 a, float4x3 b) { }

	[Address(RVA = "0x2A5A8D0", Offset = "0x2A59CD0", Length = "0x6E")]
	[Token(Token = "0x6000629")]
	public static float2 mul(float4 a, float4x2 b) { }

	[Address(RVA = "0x1CE1880", Offset = "0x1CE0C80", Length = "0x33")]
	[Token(Token = "0x6000628")]
	public static float mul(float4 a, float4 b) { }

	[Address(RVA = "0x2A5ABF0", Offset = "0x2A59FF0", Length = "0x9E")]
	[Token(Token = "0x600062D")]
	public static float2x2 mul(float2x2 a, float2x2 b) { }

	[Address(RVA = "0x2A553D0", Offset = "0x2A547D0", Length = "0xCA")]
	[Token(Token = "0x6000627")]
	public static float4 mul(float3 a, float3x4 b) { }

	[Address(RVA = "0x2A51C80", Offset = "0x2A51080", Length = "0x87")]
	[Token(Token = "0x6000626")]
	public static float3 mul(float3 a, float3x3 b) { }

	[Address(RVA = "0x2A57E10", Offset = "0x2A57210", Length = "0x168")]
	[Token(Token = "0x6000632")]
	public static float2x3 mul(float2x3 a, float3x3 b) { }

	[Address(RVA = "0x2A52040", Offset = "0x2A51440", Length = "0x52")]
	[Token(Token = "0x6000625")]
	public static float2 mul(float3 a, float3x2 b) { }

	[Address(RVA = "0x2A5DC20", Offset = "0x2A5D020", Length = "0x8D")]
	[Token(Token = "0x6000623")]
	public static float4 mul(float2 a, float2x4 b) { }

	[Address(RVA = "0x2A5AC90", Offset = "0x2A5A090", Length = "0x5C")]
	[Token(Token = "0x6000622")]
	public static float3 mul(float2 a, float2x3 b) { }

	[Address(RVA = "0x2A50B80", Offset = "0x2A4FF80", Length = "0x3B")]
	[Token(Token = "0x6000621")]
	public static float2 mul(float2 a, float2x2 b) { }

	[Address(RVA = "0x2A2CB20", Offset = "0x2A2BF20", Length = "0x2D")]
	[Token(Token = "0x6000620")]
	public static float mul(float2 a, float2 b) { }

	[Address(RVA = "0x2A2CA60", Offset = "0x2A2BE60", Length = "0x5")]
	[Token(Token = "0x600061F")]
	public static float mul(float a, float b) { }

	[Address(RVA = "0x2A5C130", Offset = "0x2A5B530", Length = "0xFA")]
	[Token(Token = "0x600062E")]
	public static float2x3 mul(float2x2 a, float2x3 b) { }

	[Address(RVA = "0x2A4E0F0", Offset = "0x2A4D4F0", Length = "0x163")]
	[Token(Token = "0x600062F")]
	public static float2x4 mul(float2x2 a, float2x4 b) { }

	[Address(RVA = "0x2A50640", Offset = "0x2A4FA40", Length = "0x57")]
	[Token(Token = "0x6000630")]
	public static float2 mul(float2x3 a, float3 b) { }

	[Address(RVA = "0x2A2CAF0", Offset = "0x2A2BEF0", Length = "0x25")]
	[Token(Token = "0x6000624")]
	public static float mul(float3 a, float3 b) { }

	[Address(RVA = "0x2A5A560", Offset = "0x2A59960", Length = "0x134")]
	[Token(Token = "0x6000639")]
	public static float3x2 mul(float3x2 a, float2x2 b) { }

	[Address(RVA = "0x2A5E740", Offset = "0x2A5DB40", Length = "0x137")]
	[Token(Token = "0x600066A")]
	public static double3x2 mul(double3x2 a, double2x2 b) { }

	[Address(RVA = "0x2A5EC00", Offset = "0x2A5E000", Length = "0x1AE")]
	[Token(Token = "0x600063A")]
	public static float3x3 mul(float3x2 a, float2x3 b) { }

	[Address(RVA = "0x2A554A0", Offset = "0x2A548A0", Length = "0x33E")]
	[Token(Token = "0x6000642")]
	public static float3x3 mul(float3x4 a, float4x3 b) { }

	[Address(RVA = "0x2A4FD40", Offset = "0x2A4F140", Length = "0x471")]
	[Token(Token = "0x6000643")]
	public static float3x4 mul(float3x4 a, float4x4 b) { }

	[Address(RVA = "0x2A52C60", Offset = "0x2A52060", Length = "0x41D")]
	[Token(Token = "0x600067C")]
	public static double4x4 mul(double4x3 a, double3x4 b) { }

	[Address(RVA = "0x2A4F7A0", Offset = "0x2A4EBA0", Length = "0x171")]
	[Token(Token = "0x600067D")]
	public static double4 mul(double4x4 a, double4 b) { }

	[Address(RVA = "0x2A57460", Offset = "0x2A56860", Length = "0x2A6")]
	[Token(Token = "0x600067E")]
	public static double4x2 mul(double4x4 a, double4x2 b) { }

	[Address(RVA = "0x2A54070", Offset = "0x2A53470", Length = "0x3FD")]
	[Token(Token = "0x600067F")]
	public static double4x3 mul(double4x4 a, double4x3 b) { }

	[Address(RVA = "0x2A537F0", Offset = "0x2A52BF0", Length = "0x4FF")]
	[Token(Token = "0x6000680")]
	public static double4x4 mul(double4x4 a, double4x4 b) { }

	[Address(RVA = "0x2A2C990", Offset = "0x2A2BD90", Length = "0x6")]
	[Token(Token = "0x6000681")]
	public static int mul(int a, int b) { }

	[Address(RVA = "0x2A5A250", Offset = "0x2A59650", Length = "0x310")]
	[Token(Token = "0x600067B")]
	public static double4x3 mul(double4x3 a, double3x3 b) { }

	[Address(RVA = "0x2A2CA40", Offset = "0x2A2BE40", Length = "0x18")]
	[Token(Token = "0x6000682")]
	public static int mul(int2 a, int2 b) { }

	[Address(RVA = "0x2A50B20", Offset = "0x2A4FF20", Length = "0x59")]
	[Token(Token = "0x6000684")]
	public static int3 mul(int2 a, int2x3 b) { }

	[Address(RVA = "0x2A57030", Offset = "0x2A56430", Length = "0xB1")]
	[Token(Token = "0x6000644")]
	public static float4 mul(float4x2 a, float2 b) { }

	[Address(RVA = "0x2A57C50", Offset = "0x2A57050", Length = "0x1B7")]
	[Token(Token = "0x6000645")]
	public static float4x2 mul(float4x2 a, float2x2 b) { }

	[Address(RVA = "0x2A54610", Offset = "0x2A53A10", Length = "0x276")]
	[Token(Token = "0x6000646")]
	public static float4x3 mul(float4x2 a, float2x3 b) { }

	[Address(RVA = "0x2A552F0", Offset = "0x2A546F0", Length = "0x71")]
	[Token(Token = "0x6000685")]
	public static int4 mul(int2 a, int2x4 b) { }

	[Address(RVA = "0x2A56770", Offset = "0x2A55B70", Length = "0x352")]
	[Token(Token = "0x6000647")]
	public static float4x4 mul(float4x2 a, float2x4 b) { }

	[Address(RVA = "0x2A5B080", Offset = "0x2A5A480", Length = "0x12B")]
	[Token(Token = "0x6000648")]
	public static float4 mul(float4x3 a, float3 b) { }

	[Address(RVA = "0x2A5B610", Offset = "0x2A5AA10", Length = "0x279")]
	[Token(Token = "0x6000649")]
	public static float4x2 mul(float4x3 a, float3x2 b) { }

	[Address(RVA = "0x2A55CE0", Offset = "0x2A550E0", Length = "0x32")]
	[Token(Token = "0x6000683")]
	public static int2 mul(int2 a, int2x2 b) { }

	[Address(RVA = "0x2A57840", Offset = "0x2A56C40", Length = "0x239")]
	[Token(Token = "0x600067A")]
	public static double4x2 mul(double4x3 a, double3x2 b) { }

	[Address(RVA = "0x2A557E0", Offset = "0x2A54BE0", Length = "0x126")]
	[Token(Token = "0x6000679")]
	public static double4 mul(double4x3 a, double3 b) { }

	[Address(RVA = "0x2A5F8A0", Offset = "0x2A5ECA0", Length = "0x2EC")]
	[Token(Token = "0x6000678")]
	public static double4x4 mul(double4x2 a, double2x4 b) { }

	[Address(RVA = "0x2A4E460", Offset = "0x2A4D860", Length = "0x27A")]
	[Token(Token = "0x600063B")]
	public static float3x4 mul(float3x2 a, float2x4 b) { }

	[Address(RVA = "0x2A53180", Offset = "0x2A52580", Length = "0xD2")]
	[Token(Token = "0x600063C")]
	public static float3 mul(float3x3 a, float3 b) { }

	[Address(RVA = "0x2A5CE50", Offset = "0x2A5C250", Length = "0x195")]
	[Token(Token = "0x600063D")]
	public static float3x2 mul(float3x3 a, float3x2 b) { }

	[Address(RVA = "0x2A1D4E0", Offset = "0x2A1C8E0", Length = "0x29F")]
	[Token(Token = "0x600063E")]
	public static float3x3 mul(float3x3 a, float3x3 b) { }

	[Address(RVA = "0x2A56340", Offset = "0x2A55740", Length = "0x35D")]
	[Token(Token = "0x600063F")]
	public static float3x4 mul(float3x3 a, float3x4 b) { }

	[Address(RVA = "0x2A51D10", Offset = "0x2A51110", Length = "0x1C9")]
	[Token(Token = "0x600066B")]
	public static double3x3 mul(double3x2 a, double2x3 b) { }

	[Address(RVA = "0x2A55BC0", Offset = "0x2A54FC0", Length = "0x11D")]
	[Token(Token = "0x6000640")]
	public static float3 mul(float3x4 a, float4 b) { }

	[Address(RVA = "0x2A5E4F0", Offset = "0x2A5D8F0", Length = "0x24F")]
	[Token(Token = "0x6000641")]
	public static float3x2 mul(float3x4 a, float4x2 b) { }

	[Address(RVA = "0x2A5F550", Offset = "0x2A5E950", Length = "0x25E")]
	[Token(Token = "0x600066C")]
	public static double3x4 mul(double3x2 a, double2x4 b) { }

	[Address(RVA = "0x2A5AF90", Offset = "0x2A5A390", Length = "0xF0")]
	[Token(Token = "0x600066D")]
	public static double3 mul(double3x3 a, double3 b) { }

	[Address(RVA = "0x2A52600", Offset = "0x2A51A00", Length = "0x1C3")]
	[Token(Token = "0x600066E")]
	public static double3x2 mul(double3x3 a, double3x2 b) { }

	[Address(RVA = "0x2A55DB0", Offset = "0x2A551B0", Length = "0x299")]
	[Token(Token = "0x600066F")]
	public static double3x3 mul(double3x3 a, double3x3 b) { }

	[Address(RVA = "0x2A51660", Offset = "0x2A50A60", Length = "0x373")]
	[Token(Token = "0x6000670")]
	public static double3x4 mul(double3x3 a, double3x4 b) { }

	[Address(RVA = "0x2A53F20", Offset = "0x2A53320", Length = "0x146")]
	[Token(Token = "0x6000671")]
	public static double3 mul(double3x4 a, double4 b) { }

	[Address(RVA = "0x2A56AD0", Offset = "0x2A55ED0", Length = "0x23B")]
	[Token(Token = "0x6000672")]
	public static double3x2 mul(double3x4 a, double4x2 b) { }

	[Address(RVA = "0x2A5D180", Offset = "0x2A5C580", Length = "0x35A")]
	[Token(Token = "0x6000673")]
	public static double3x3 mul(double3x4 a, double4x3 b) { }

	[Address(RVA = "0x2A5E100", Offset = "0x2A5D500", Length = "0x3EA")]
	[Token(Token = "0x6000674")]
	public static double3x4 mul(double3x4 a, double4x4 b) { }

	[Address(RVA = "0x2A58E90", Offset = "0x2A58290", Length = "0xAB")]
	[Token(Token = "0x6000675")]
	public static double4 mul(double4x2 a, double2 b) { }

	[Address(RVA = "0x2A5A6A0", Offset = "0x2A59AA0", Length = "0x229")]
	[Token(Token = "0x6000677")]
	public static double4x3 mul(double4x2 a, double2x3 b) { }

	[Address(RVA = "0x2A5BC80", Offset = "0x2A5B080", Length = "0x4AD")]
	[Token(Token = "0x600064B")]
	public static float4x4 mul(float4x3 a, float3x4 b) { }

	[Address(RVA = "0x2A52A00", Offset = "0x2A51E00", Length = "0x1E5")]
	[Token(Token = "0x60006A7")]
	public static int4x2 mul(int4x2 a, int2x2 b) { }

	[Address(RVA = "0x2A57290", Offset = "0x2A56690", Length = "0x3F")]
	[Token(Token = "0x600065D")]
	public static double2 mul(double2x2 a, double2 b) { }

	[Address(RVA = "0x2A58060", Offset = "0x2A57460", Length = "0x275")]
	[Token(Token = "0x60006A9")]
	public static int4x4 mul(int4x2 a, int2x4 b) { }

	[Address(RVA = "0x2A55910", Offset = "0x2A54D10", Length = "0xBE")]
	[Token(Token = "0x60006C3")]
	public static uint2 mul(uint2x3 a, uint3 b) { }

	[Address(RVA = "0x2A570F0", Offset = "0x2A564F0", Length = "0x19E")]
	[Token(Token = "0x60006C4")]
	public static uint2x2 mul(uint2x3 a, uint3x2 b) { }

	[Address(RVA = "0x2A53350", Offset = "0x2A52750", Length = "0x26F")]
	[Token(Token = "0x60006C5")]
	public static uint2x3 mul(uint2x3 a, uint3x3 b) { }

	[Address(RVA = "0x2A501C0", Offset = "0x2A4F5C0", Length = "0x357")]
	[Token(Token = "0x60006C6")]
	public static uint2x4 mul(uint2x3 a, uint3x4 b) { }

	[Address(RVA = "0x2A527D0", Offset = "0x2A51BD0", Length = "0x104")]
	[Token(Token = "0x60006C7")]
	public static uint2 mul(uint2x4 a, uint4 b) { }

	[Address(RVA = "0x2A535C0", Offset = "0x2A529C0", Length = "0x227")]
	[Token(Token = "0x60006C8")]
	public static uint2x2 mul(uint2x4 a, uint4x2 b) { }

	[Address(RVA = "0x2A5D4E0", Offset = "0x2A5C8E0", Length = "0x326")]
	[Token(Token = "0x60006B0")]
	public static int4x3 mul(int4x4 a, int4x3 b) { }

	[Address(RVA = "0x2A4FA00", Offset = "0x2A4EE00", Length = "0x33D")]
	[Token(Token = "0x60006C9")]
	public static uint2x3 mul(uint2x4 a, uint4x3 b) { }

	[Address(RVA = "0x2A559D0", Offset = "0x2A54DD0", Length = "0x1E2")]
	[Token(Token = "0x60006A8")]
	public static int4x3 mul(int4x2 a, int2x3 b) { }

	[Address(RVA = "0x2A530E0", Offset = "0x2A524E0", Length = "0x93")]
	[Token(Token = "0x60006CB")]
	public static uint3 mul(uint3x2 a, uint2 b) { }

	[Address(RVA = "0x2A58F40", Offset = "0x2A58340", Length = "0x47")]
	[Token(Token = "0x60006B8")]
	public static uint2 mul(uint3 a, uint3x2 b) { }

	[Address(RVA = "0x2A54470", Offset = "0x2A53870", Length = "0x1A0")]
	[Token(Token = "0x60006CD")]
	public static uint3x3 mul(uint3x2 a, uint2x3 b) { }

	[Address(RVA = "0x2A55000", Offset = "0x2A54400", Length = "0x264")]
	[Token(Token = "0x60006CE")]
	public static uint3x4 mul(uint3x2 a, uint2x4 b) { }

	[Address(RVA = "0x2A54F30", Offset = "0x2A54330", Length = "0xCD")]
	[Token(Token = "0x60006CF")]
	public static uint3 mul(uint3x3 a, uint3 b) { }

	[Address(RVA = "0x2A595C0", Offset = "0x2A589C0", Length = "0x3D6")]
	[Token(Token = "0x60006CA")]
	public static uint2x4 mul(uint2x4 a, uint4x4 b) { }

	[Address(RVA = "0x2A50740", Offset = "0x2A4FB40", Length = "0x19E")]
	[Token(Token = "0x60006D0")]
	public static uint3x2 mul(uint3x3 a, uint3x2 b) { }

	[Address(RVA = "0x2A5DCB0", Offset = "0x2A5D0B0", Length = "0x44B")]
	[Token(Token = "0x60006B1")]
	public static int4x4 mul(int4x4 a, int4x4 b) { }

	[Address(RVA = "0x2A4ED10", Offset = "0x2A4E110", Length = "0x21F")]
	[Token(Token = "0x60006C2")]
	public static uint2x4 mul(uint2x2 a, uint2x4 b) { }

	[Address(RVA = "0x2A4F530", Offset = "0x2A4E930", Length = "0x7F")]
	[Token(Token = "0x60006B9")]
	public static uint3 mul(uint3 a, uint3x3 b) { }

	[Address(RVA = "0x2A506A0", Offset = "0x2A4FAA0", Length = "0x9C")]
	[Token(Token = "0x60006BA")]
	public static uint4 mul(uint3 a, uint3x4 b) { }

	[Address(RVA = "0x2A2C9E0", Offset = "0x2A2BDE0", Length = "0x27")]
	[Token(Token = "0x60006BB")]
	public static uint mul(uint4 a, uint4 b) { }

	[Address(RVA = "0x2A55370", Offset = "0x2A54770", Length = "0x5B")]
	[Token(Token = "0x60006BC")]
	public static uint2 mul(uint4 a, uint4x2 b) { }

	[Address(RVA = "0x2A4EC70", Offset = "0x2A4E070", Length = "0x97")]
	[Token(Token = "0x60006BD")]
	public static uint3 mul(uint4 a, uint4x3 b) { }

	[Address(RVA = "0x2A5F7B0", Offset = "0x2A5EBB0", Length = "0xEE")]
	[Token(Token = "0x600065C")]
	public static double4 mul(double4 a, double4x4 b) { }

	[Address(RVA = "0x2A2C990", Offset = "0x2A2BD90", Length = "0x6")]
	[Token(Token = "0x60006B2")]
	public static uint mul(uint a, uint b) { }

	[Address(RVA = "0x2A4E260", Offset = "0x2A4D660", Length = "0xBE")]
	[Token(Token = "0x60006BE")]
	public static uint4 mul(uint4 a, uint4x4 b) { }

	[Address(RVA = "0x2A5B1B0", Offset = "0x2A5A5B0", Length = "0x113")]
	[Token(Token = "0x60006C0")]
	public static uint2x2 mul(uint2x2 a, uint2x2 b) { }

	[Address(RVA = "0x2A53D80", Offset = "0x2A53180", Length = "0x19F")]
	[Token(Token = "0x60006C1")]
	public static uint2x3 mul(uint2x2 a, uint2x3 b) { }

	[Address(RVA = "0x2A552F0", Offset = "0x2A546F0", Length = "0x71")]
	[Token(Token = "0x60006B6")]
	public static uint4 mul(uint2 a, uint2x4 b) { }

	[Address(RVA = "0x2A50B20", Offset = "0x2A4FF20", Length = "0x59")]
	[Token(Token = "0x60006B5")]
	public static uint3 mul(uint2 a, uint2x3 b) { }

	[Address(RVA = "0x2A55CE0", Offset = "0x2A550E0", Length = "0x32")]
	[Token(Token = "0x60006B4")]
	public static uint2 mul(uint2 a, uint2x2 b) { }

	[Address(RVA = "0x2A2CA40", Offset = "0x2A2BE40", Length = "0x18")]
	[Token(Token = "0x60006B3")]
	public static uint mul(uint2 a, uint2 b) { }

	[Address(RVA = "0x2A53260", Offset = "0x2A52660", Length = "0x69")]
	[Token(Token = "0x60006BF")]
	public static uint2 mul(uint2x2 a, uint2 b) { }

	[Address(RVA = "0x2A5E990", Offset = "0x2A5DD90", Length = "0x26B")]
	[Token(Token = "0x60006D1")]
	public static uint3x3 mul(uint3x3 a, uint3x3 b) { }

	[Address(RVA = "0x2A5DA60", Offset = "0x2A5CE60", Length = "0x121")]
	[Token(Token = "0x60006CC")]
	public static uint3x2 mul(uint3x2 a, uint2x2 b) { }

	[Address(RVA = "0x2A528E0", Offset = "0x2A51CE0", Length = "0x111")]
	[Token(Token = "0x60006D3")]
	public static uint3 mul(uint3x4 a, uint4 b) { }

	[Address(RVA = "0x2A5B2D0", Offset = "0x2A5A6D0", Length = "0x335")]
	[Token(Token = "0x60006D2")]
	public static uint3x4 mul(uint3x3 a, uint3x4 b) { }

	[Address(RVA = "0x2A54890", Offset = "0x2A53C90", Length = "0x352")]
	[Token(Token = "0x60006DE")]
	public static uint4x4 mul(uint4x3 a, uint3x4 b) { }

	[Address(RVA = "0x2A58CB0", Offset = "0x2A580B0", Length = "0x1DA")]
	[Token(Token = "0x60006DF")]
	public static uint4 mul(uint4x4 a, uint4 b) { }

	[Address(RVA = "0x2A560E0", Offset = "0x2A554E0", Length = "0x255")]
	[Token(Token = "0x60006E0")]
	public static uint4x2 mul(uint4x4 a, uint4x2 b) { }

	[Address(RVA = "0x2A5B890", Offset = "0x2A5AC90", Length = "0x342")]
	[Token(Token = "0x60006E1")]
	public static uint4x3 mul(uint4x4 a, uint4x3 b) { }

	[Address(RVA = "0x2A5C230", Offset = "0x2A5B630", Length = "0x43D")]
	[Token(Token = "0x60006E2")]
	public static uint4x4 mul(uint4x4 a, uint4x4 b) { }

	[Address(RVA = "0x2A572D0", Offset = "0x2A566D0", Length = "0x186")]
	[Token(Token = "0x600001D")]
	public static AffineTransform mul(float3x3 a, AffineTransform b) { }

	[Address(RVA = "0x2A51EE0", Offset = "0x2A512E0", Length = "0x15C")]
	[Token(Token = "0x60006F3")]
	public static quaternion mul(quaternion a, quaternion b) { }

	[Address(RVA = "0x8FDDC0", Offset = "0x8FD1C0", Length = "0x12E")]
	[Token(Token = "0x60006F4")]
	public static float3 mul(quaternion q, float3 v) { }

	[Address(RVA = "0x2A587C0", Offset = "0x2A57BC0", Length = "0x1AF")]
	[Token(Token = "0x600001C")]
	public static AffineTransform mul(AffineTransform a, AffineTransform b) { }

	[Address(RVA = "0x2A5C9E0", Offset = "0x2A5BDE0", Length = "0x2B0")]
	[Token(Token = "0x6000703")]
	public static RigidTransform mul(RigidTransform a, RigidTransform b) { }

	[Address(RVA = "0x2A5C7C0", Offset = "0x2A5BBC0", Length = "0x1DA")]
	[Token(Token = "0x60006AE")]
	public static int4 mul(int4x4 a, int4 b) { }

	[Address(RVA = "0x2A58970", Offset = "0x2A57D70", Length = "0x337")]
	[Token(Token = "0x60006AD")]
	public static int4x4 mul(int4x3 a, int3x4 b) { }

	[Address(RVA = "0x2A5A940", Offset = "0x2A59D40", Length = "0x2A6")]
	[Token(Token = "0x60006AC")]
	public static int4x3 mul(int4x3 a, int3x3 b) { }

	[Address(RVA = "0x2A4F180", Offset = "0x2A4E580", Length = "0x19F")]
	[Token(Token = "0x6000704")]
	public static float4 mul(RigidTransform a, float4 pos) { }

	[Address(RVA = "0x2A51AA0", Offset = "0x2A50EA0", Length = "0x1D3")]
	[Token(Token = "0x60006AB")]
	public static int4x2 mul(int4x3 a, int3x2 b) { }

	[Address(RVA = "0x2A4F320", Offset = "0x2A4E720", Length = "0x14F")]
	[Token(Token = "0x60006AA")]
	public static int4 mul(int4x3 a, int3 b) { }

	[Address(RVA = "0x2A50CC0", Offset = "0x2A500C0", Length = "0x1E6")]
	[Token(Token = "0x60006DC")]
	public static uint4x2 mul(uint4x3 a, uint3x2 b) { }

	[Address(RVA = "0x2A4F320", Offset = "0x2A4E720", Length = "0x14F")]
	[Token(Token = "0x60006DB")]
	public static uint4 mul(uint4x3 a, uint3 b) { }

	[Address(RVA = "0x2A4E9C0", Offset = "0x2A4DDC0", Length = "0x2A6")]
	[Token(Token = "0x60006DD")]
	public static uint4x3 mul(uint4x3 a, uint3x3 b) { }

	[Address(RVA = "0x2A559D0", Offset = "0x2A54DD0", Length = "0x1E2")]
	[Token(Token = "0x60006D9")]
	public static uint4x3 mul(uint4x2 a, uint2x3 b) { }

	[Address(RVA = "0x2A4EF30", Offset = "0x2A4E330", Length = "0x24D")]
	[Token(Token = "0x60006D4")]
	public static uint3x2 mul(uint3x4 a, uint4x2 b) { }

	[Address(RVA = "0x2A58560", Offset = "0x2A57960", Length = "0x255")]
	[Token(Token = "0x60006AF")]
	public static int4x2 mul(int4x4 a, int4x2 b) { }

	[Address(RVA = "0x2A56D10", Offset = "0x2A56110", Length = "0x31E")]
	[Token(Token = "0x60006D5")]
	public static uint3x3 mul(uint3x4 a, uint4x3 b) { }

	[Address(RVA = "0x2A520A0", Offset = "0x2A514A0", Length = "0x4D7")]
	[Token(Token = "0x60006D6")]
	public static uint3x4 mul(uint3x4 a, uint4x4 b) { }

	[Address(RVA = "0x2A4F920", Offset = "0x2A4ED20", Length = "0x93")]
	[Token(Token = "0x60006D7")]
	public static uint4 mul(uint4x2 a, uint2 b) { }

	[Address(RVA = "0x2A58F90", Offset = "0x2A58390", Length = "0x275")]
	[Token(Token = "0x60006DA")]
	public static uint4x4 mul(uint4x2 a, uint2x4 b) { }

	[Address(RVA = "0x2A2CA10", Offset = "0x2A2BE10", Length = "0x1B")]
	[Token(Token = "0x60006B7")]
	public static uint mul(uint3 a, uint3 b) { }

	[Address(RVA = "0x2A59210", Offset = "0x2A58610", Length = "0x1E2")]
	[Token(Token = "0x60006D8")]
	public static uint4x2 mul(uint4x2 a, uint2x2 b) { }

	[Address(RVA = "0x2A4E000", Offset = "0x2A4D400", Length = "0xED")]
	[Token(Token = "0x600060A")]
	public static float3x3 mulScale(float3x3 m, float3 s) { }

	[Address(RVA = "0x2A1D780", Offset = "0x2A1CB80", Length = "0x1FE")]
	[Token(Token = "0x60006F6")]
	public static quaternion nlerp(quaternion q1, quaternion q2, float t) { }

	[Address(RVA = "0x2A5FC10", Offset = "0x2A5F010", Length = "0x98")]
	[Token(Token = "0x60004B3")]
	public static double4 normalize(double4 x) { }

	[Address(RVA = "0x2A5FCB0", Offset = "0x2A5F0B0", Length = "0x50")]
	[Token(Token = "0x60004AE")]
	public static float2 normalize(float2 x) { }

	[Address(RVA = "0x2A1D980", Offset = "0x2A1CD80", Length = "0x42B")]
	[Token(Token = "0x60004B0")]
	public static float4 normalize(float4 x) { }

	[Address(RVA = "0x8FDD30", Offset = "0x8FD130", Length = "0x89")]
	[Token(Token = "0x60004AF")]
	public static float3 normalize(float3 x) { }

	[Address(RVA = "0x2A5FD00", Offset = "0x2A5F100", Length = "0xD9")]
	[Token(Token = "0x60006EC")]
	public static quaternion normalize(quaternion q) { }

	[Address(RVA = "0x2A5FDE0", Offset = "0x2A5F1E0", Length = "0x5D")]
	[Token(Token = "0x60004B1")]
	public static double2 normalize(double2 x) { }

	[Address(RVA = "0x2A5FB90", Offset = "0x2A5EF90", Length = "0x76")]
	[Token(Token = "0x60004B2")]
	public static double3 normalize(double3 x) { }

	[Address(RVA = "0x2A60300", Offset = "0x2A5F700", Length = "0xB4")]
	[Token(Token = "0x60004B5")]
	public static float3 normalizesafe(float3 x, float3 defaultvalue = null) { }

	[Address(RVA = "0x2A5FF10", Offset = "0x2A5F310", Length = "0x94")]
	[Token(Token = "0x60004B4")]
	public static float2 normalizesafe(float2 x, float2 defaultvalue = null) { }

	[Address(RVA = "0x2A601F0", Offset = "0x2A5F5F0", Length = "0x10F")]
	[Token(Token = "0x60006EE")]
	public static quaternion normalizesafe(quaternion q, quaternion defaultvalue) { }

	[Address(RVA = "0x2A600B0", Offset = "0x2A5F4B0", Length = "0x13E")]
	[Token(Token = "0x60006ED")]
	public static quaternion normalizesafe(quaternion q) { }

	[Address(RVA = "0x2A603C0", Offset = "0x2A5F7C0", Length = "0x87")]
	[Token(Token = "0x60004B7")]
	public static double2 normalizesafe(double2 x, double2 defaultvalue = null) { }

	[Address(RVA = "0x2A60450", Offset = "0x2A5F850", Length = "0xC5")]
	[Token(Token = "0x60004B8")]
	public static double3 normalizesafe(double3 x, double3 defaultvalue = null) { }

	[Address(RVA = "0x2A5FE40", Offset = "0x2A5F240", Length = "0xCB")]
	[Token(Token = "0x60004B9")]
	public static double4 normalizesafe(double4 x, double4 defaultvalue = null) { }

	[Address(RVA = "0x2A5FFB0", Offset = "0x2A5F3B0", Length = "0xF1")]
	[Token(Token = "0x60004B6")]
	public static float4 normalizesafe(float4 x, float4 defaultvalue = null) { }

	[Address(RVA = "0x2A605D0", Offset = "0x2A5F9D0", Length = "0xBE")]
	[Token(Token = "0x60005F4")]
	public static void orthonormal_basis(double3 normal, out double3 basis1, out double3 basis2) { }

	[Address(RVA = "0x2A60520", Offset = "0x2A5F920", Length = "0xA2")]
	[Token(Token = "0x60005F3")]
	public static void orthonormal_basis(float3 normal, out float3 basis1, out float3 basis2) { }

	[Address(RVA = "0x2A60690", Offset = "0x2A5FA90", Length = "0x233")]
	[Token(Token = "0x600061D")]
	public static float3x3 orthonormalize(float3x3 i) { }

	[Address(RVA = "0x2A60E60", Offset = "0x2A60260", Length = "0xC5")]
	[Token(Token = "0x600045B")]
	public static double2 pow(double2 x, double2 y) { }

	[Address(RVA = "0x2A60C70", Offset = "0x2A60070", Length = "0x61")]
	[Token(Token = "0x600045A")]
	public static double pow(double x, double y) { }

	[Address(RVA = "0x2A60F30", Offset = "0x2A60330", Length = "0x19F")]
	[Token(Token = "0x6000459")]
	public static float4 pow(float4 x, float4 y) { }

	[Address(RVA = "0x2A608D0", Offset = "0x2A5FCD0", Length = "0x13B")]
	[Token(Token = "0x6000458")]
	public static float3 pow(float3 x, float3 y) { }

	[Address(RVA = "0x2A60A10", Offset = "0x2A5FE10", Length = "0x11A")]
	[Token(Token = "0x600045C")]
	public static double3 pow(double3 x, double3 y) { }

	[Address(RVA = "0x2A60BA0", Offset = "0x2A5FFA0", Length = "0xC9")]
	[Token(Token = "0x6000457")]
	public static float2 pow(float2 x, float2 y) { }

	[Address(RVA = "0x2A60CE0", Offset = "0x2A600E0", Length = "0x173")]
	[Token(Token = "0x600045D")]
	public static double4 pow(double4 x, double4 y) { }

	[Address(RVA = "0x2A60B30", Offset = "0x2A5FF30", Length = "0x6E")]
	[Token(Token = "0x6000456")]
	public static float pow(float x, float y) { }

	[Address(RVA = "0x2A61130", Offset = "0x2A60530", Length = "0x126")]
	[Token(Token = "0x600053C")]
	public static double4 project(double4 a, double4 ontoB) { }

	[Address(RVA = "0x2A61260", Offset = "0x2A60660", Length = "0x74")]
	[Token(Token = "0x600053A")]
	public static double2 project(double2 a, double2 ontoB) { }

	[Address(RVA = "0x2A612E0", Offset = "0x2A606E0", Length = "0xA4")]
	[Token(Token = "0x6000535")]
	public static float3 project(float3 a, float3 ontoB) { }

	[Address(RVA = "0x2A610D0", Offset = "0x2A604D0", Length = "0x5C")]
	[Token(Token = "0x6000534")]
	public static float2 project(float2 a, float2 ontoB) { }

	[Address(RVA = "0x2A61390", Offset = "0x2A60790", Length = "0xED")]
	[Token(Token = "0x600053B")]
	public static double3 project(double3 a, double3 ontoB) { }

	[Address(RVA = "0x2A61480", Offset = "0x2A60880", Length = "0x104")]
	[Token(Token = "0x6000536")]
	public static float4 project(float4 a, float4 ontoB) { }

	[Address(RVA = "0x2A61740", Offset = "0x2A60B40", Length = "0xD0")]
	[Token(Token = "0x6000537")]
	public static float2 projectsafe(float2 a, float2 ontoB, float2 defaultValue = null) { }

	[Address(RVA = "0x2A61810", Offset = "0x2A60C10", Length = "0x129")]
	[Token(Token = "0x6000538")]
	public static float3 projectsafe(float3 a, float3 ontoB, float3 defaultValue = null) { }

	[Address(RVA = "0x2A61940", Offset = "0x2A60D40", Length = "0x1D1")]
	[Token(Token = "0x600053F")]
	public static double4 projectsafe(double4 a, double4 ontoB, double4 defaultValue = null) { }

	[Address(RVA = "0x2A61590", Offset = "0x2A60990", Length = "0x1A5")]
	[Token(Token = "0x6000539")]
	public static float4 projectsafe(float4 a, float4 ontoB, float4 defaultValue = null) { }

	[Address(RVA = "0x2A61B20", Offset = "0x2A60F20", Length = "0xBC")]
	[Token(Token = "0x600053D")]
	public static double2 projectsafe(double2 a, double2 ontoB, double2 defaultValue = null) { }

	[Address(RVA = "0x2A61BE0", Offset = "0x2A60FE0", Length = "0x183")]
	[Token(Token = "0x600053E")]
	public static double3 projectsafe(double3 a, double3 ontoB, double3 defaultValue = null) { }

	[Address(RVA = "0x2A61D70", Offset = "0x2A61170", Length = "0x2DB")]
	[Token(Token = "0x600061E")]
	public static float3x3 pseudoinverse(float3x3 m) { }

	[Address(RVA = "0x27F4E50", Offset = "0x27F4250", Length = "0x1D")]
	[Token(Token = "0x60006E3")]
	public static quaternion quaternion(float x, float y, float z, float w) { }

	[Address(RVA = "0x2A62050", Offset = "0x2A61450", Length = "0x48")]
	[Token(Token = "0x60006E6")]
	public static quaternion quaternion(float4x4 m) { }

	[Address(RVA = "0x2A620A0", Offset = "0x2A614A0", Length = "0x3D")]
	[Token(Token = "0x60006E5")]
	public static quaternion quaternion(float3x3 m) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x60006E4")]
	public static quaternion quaternion(float4 value) { }

	[Address(RVA = "0x2A62150", Offset = "0x2A61550", Length = "0x3A")]
	[Token(Token = "0x60005A6")]
	public static float3 radians(float3 x) { }

	[Address(RVA = "0x2A62190", Offset = "0x2A61590", Length = "0x2A")]
	[Token(Token = "0x60005A5")]
	public static float2 radians(float2 x) { }

	[Address(RVA = "0x2A621C0", Offset = "0x2A615C0", Length = "0x27")]
	[Token(Token = "0x60005A9")]
	public static double2 radians(double2 x) { }

	[Address(RVA = "0x2A620F0", Offset = "0x2A614F0", Length = "0x5B")]
	[Token(Token = "0x60005A7")]
	public static float4 radians(float4 x) { }

	[Address(RVA = "0x2A62230", Offset = "0x2A61630", Length = "0x9")]
	[Token(Token = "0x60005A8")]
	public static double radians(double x) { }

	[Address(RVA = "0x2A62240", Offset = "0x2A61640", Length = "0x40")]
	[Token(Token = "0x60005AB")]
	public static double4 radians(double4 x) { }

	[Address(RVA = "0x2A620E0", Offset = "0x2A614E0", Length = "0x9")]
	[Token(Token = "0x60005A4")]
	public static float radians(float x) { }

	[Address(RVA = "0x2A621F0", Offset = "0x2A615F0", Length = "0x3B")]
	[Token(Token = "0x60005AA")]
	public static double3 radians(double3 x) { }

	[Address(RVA = "0x2A62430", Offset = "0x2A61830", Length = "0x10")]
	[Token(Token = "0x6000442")]
	public static float rcp(float x) { }

	[Address(RVA = "0x2A62390", Offset = "0x2A61790", Length = "0x27")]
	[Token(Token = "0x6000447")]
	public static double2 rcp(double2 x) { }

	[Address(RVA = "0x2A622C0", Offset = "0x2A616C0", Length = "0x10")]
	[Token(Token = "0x6000446")]
	public static double rcp(double x) { }

	[Address(RVA = "0x2A623C0", Offset = "0x2A617C0", Length = "0x6B")]
	[Token(Token = "0x6000445")]
	public static float4 rcp(float4 x) { }

	[Address(RVA = "0x2A62300", Offset = "0x2A61700", Length = "0x43")]
	[Token(Token = "0x6000449")]
	public static double4 rcp(double4 x) { }

	[Address(RVA = "0x2A62280", Offset = "0x2A61680", Length = "0x3A")]
	[Token(Token = "0x6000448")]
	public static double3 rcp(double3 x) { }

	[Address(RVA = "0x2A622D0", Offset = "0x2A616D0", Length = "0x25")]
	[Token(Token = "0x6000443")]
	public static float2 rcp(float2 x) { }

	[Address(RVA = "0x2A62350", Offset = "0x2A61750", Length = "0x3E")]
	[Token(Token = "0x6000444")]
	public static float3 rcp(float3 x) { }

	[Address(RVA = "0x1F3D850", Offset = "0x1F3CC50", Length = "0x1F")]
	[Token(Token = "0x60005F9")]
	private static uint read32_little_endian(Void* pBuffer) { }

	[Address(RVA = "0x2A62670", Offset = "0x2A61A70", Length = "0x93")]
	[Token(Token = "0x6000529")]
	public static float3 reflect(float3 i, float3 n) { }

	[Address(RVA = "0x2A62440", Offset = "0x2A61840", Length = "0x5B")]
	[Token(Token = "0x6000528")]
	public static float2 reflect(float2 i, float2 n) { }

	[Address(RVA = "0x2A62610", Offset = "0x2A61A10", Length = "0x5E")]
	[Token(Token = "0x600052B")]
	public static double2 reflect(double2 i, double2 n) { }

	[Address(RVA = "0x2A62570", Offset = "0x2A61970", Length = "0x9D")]
	[Token(Token = "0x600052C")]
	public static double3 reflect(double3 i, double3 n) { }

	[Address(RVA = "0x2A624A0", Offset = "0x2A618A0", Length = "0xCF")]
	[Token(Token = "0x600052D")]
	public static double4 reflect(double4 i, double4 n) { }

	[Address(RVA = "0x2A62710", Offset = "0x2A61B10", Length = "0xE3")]
	[Token(Token = "0x600052A")]
	public static float4 reflect(float4 i, float4 n) { }

	[Address(RVA = "0x2A629F0", Offset = "0x2A61DF0", Length = "0x104")]
	[Token(Token = "0x600052E")]
	public static float2 refract(float2 i, float2 n, float indexOfRefraction) { }

	[Address(RVA = "0x2A62C60", Offset = "0x2A62060", Length = "0x15F")]
	[Token(Token = "0x600052F")]
	public static float3 refract(float3 i, float3 n, float indexOfRefraction) { }

	[Address(RVA = "0x2A62800", Offset = "0x2A61C00", Length = "0x1ED")]
	[Token(Token = "0x6000533")]
	public static double4 refract(double4 i, double4 n, double indexOfRefraction) { }

	[Address(RVA = "0x2A62F90", Offset = "0x2A62390", Length = "0x180")]
	[Token(Token = "0x6000530")]
	public static float4 refract(float4 i, float4 n, float indexOfRefraction) { }

	[Address(RVA = "0x2A62DC0", Offset = "0x2A621C0", Length = "0x1CF")]
	[Token(Token = "0x6000532")]
	public static double3 refract(double3 i, double3 n, double indexOfRefraction) { }

	[Address(RVA = "0x2A62B00", Offset = "0x2A61F00", Length = "0x157")]
	[Token(Token = "0x6000531")]
	public static double2 refract(double2 i, double2 n, double indexOfRefraction) { }

	[Address(RVA = "0x2A63350", Offset = "0x2A62750", Length = "0x22")]
	[Token(Token = "0x6000379")]
	public static float remap(float srcStart, float srcEnd, float dstStart, float dstEnd, float x) { }

	[Address(RVA = "0x2A632C0", Offset = "0x2A626C0", Length = "0x86")]
	[Token(Token = "0x600037A")]
	public static float2 remap(float2 srcStart, float2 srcEnd, float2 dstStart, float2 dstEnd, float2 x) { }

	[Address(RVA = "0x2A63710", Offset = "0x2A62B10", Length = "0x116")]
	[Token(Token = "0x600037B")]
	public static float3 remap(float3 srcStart, float3 srcEnd, float3 dstStart, float3 dstEnd, float3 x) { }

	[Address(RVA = "0x2A63110", Offset = "0x2A62510", Length = "0x175")]
	[Token(Token = "0x600037C")]
	public static float4 remap(float4 srcStart, float4 srcEnd, float4 dstStart, float4 dstEnd, float4 x) { }

	[Address(RVA = "0x2A63290", Offset = "0x2A62690", Length = "0x22")]
	[Token(Token = "0x600037D")]
	public static double remap(double srcStart, double srcEnd, double dstStart, double dstEnd, double x) { }

	[Address(RVA = "0x2A634D0", Offset = "0x2A628D0", Length = "0x96")]
	[Token(Token = "0x600037E")]
	public static double2 remap(double2 srcStart, double2 srcEnd, double2 dstStart, double2 dstEnd, double2 x) { }

	[Address(RVA = "0x2A63380", Offset = "0x2A62780", Length = "0x143")]
	[Token(Token = "0x600037F")]
	public static double3 remap(double3 srcStart, double3 srcEnd, double3 dstStart, double3 dstEnd, double3 x) { }

	[Address(RVA = "0x2A63570", Offset = "0x2A62970", Length = "0x19D")]
	[Token(Token = "0x6000380")]
	public static double4 remap(double4 srcStart, double4 srcEnd, double4 dstStart, double4 dstEnd, double4 x) { }

	[Address(RVA = "0x2A63830", Offset = "0x2A62C30", Length = "0x38")]
	[Token(Token = "0x600056C")]
	public static int reversebits(int x) { }

	[Address(RVA = "0x2A63870", Offset = "0x2A62C70", Length = "0x8D")]
	[Token(Token = "0x600056F")]
	public static int4 reversebits(int4 x) { }

	[Address(RVA = "0x2A63830", Offset = "0x2A62C30", Length = "0x38")]
	[Token(Token = "0x6000570")]
	public static uint reversebits(uint x) { }

	[Address(RVA = "0x2A1E1E0", Offset = "0x2A1D5E0", Length = "0x2ED")]
	[Token(Token = "0x6000571")]
	public static uint2 reversebits(uint2 x) { }

	[Address(RVA = "0x2A1E020", Offset = "0x2A1D420", Length = "0x1B1")]
	[Token(Token = "0x6000572")]
	public static uint3 reversebits(uint3 x) { }

	[Address(RVA = "0x2A1DDB0", Offset = "0x2A1D1B0", Length = "0x261")]
	[Token(Token = "0x6000573")]
	public static uint4 reversebits(uint4 x) { }

	[Address(RVA = "0x2A63900", Offset = "0x2A62D00", Length = "0x60")]
	[Token(Token = "0x6000574")]
	public static long reversebits(long x) { }

	[Address(RVA = "0x2A63960", Offset = "0x2A62D60", Length = "0x32")]
	[Token(Token = "0x600056D")]
	public static int2 reversebits(int2 x) { }

	[Address(RVA = "0x2A639A0", Offset = "0x2A62DA0", Length = "0x90")]
	[Token(Token = "0x600056E")]
	public static int3 reversebits(int3 x) { }

	[Address(RVA = "0x2A63900", Offset = "0x2A62D00", Length = "0x60")]
	[Token(Token = "0x6000575")]
	public static ulong reversebits(ulong x) { }

	[Address(RVA = "0x2A63A30", Offset = "0x2A62E30", Length = "0x10")]
	[Token(Token = "0x6000602")]
	public static float3 right() { }

	[Address(RVA = "0x2A24BB0", Offset = "0x2A23FB0", Length = "0x1B")]
	[Token(Token = "0x60006FF")]
	public static RigidTransform RigidTransform(quaternion rot, float3 pos) { }

	[Address(RVA = "0x2A24BD0", Offset = "0x2A23FD0", Length = "0x73")]
	[Token(Token = "0x6000700")]
	public static RigidTransform RigidTransform(float3x3 rotation, float3 translation) { }

	[Address(RVA = "0x2A24C50", Offset = "0x2A24050", Length = "0xAE")]
	[Token(Token = "0x6000701")]
	public static RigidTransform RigidTransform(float4x4 transform) { }

	[Address(RVA = "0x2A63C00", Offset = "0x2A63000", Length = "0xD4")]
	[Token(Token = "0x600057D")]
	public static uint4 rol(uint4 x, int n) { }

	[Address(RVA = "0x2A63DA0", Offset = "0x2A631A0", Length = "0xA5")]
	[Token(Token = "0x600057C")]
	public static uint3 rol(uint3 x, int n) { }

	[Address(RVA = "0x28D83F0", Offset = "0x28D77F0", Length = "0x1A")]
	[Token(Token = "0x600057F")]
	public static ulong rol(ulong x, int n) { }

	[Address(RVA = "0x2A63A40", Offset = "0x2A62E40", Length = "0x7C")]
	[Token(Token = "0x600057B")]
	public static uint2 rol(uint2 x, int n) { }

	[Address(RVA = "0x2025B80", Offset = "0x2024F80", Length = "0x19")]
	[Token(Token = "0x600057A")]
	public static uint rol(uint x, int n) { }

	[Address(RVA = "0x2A63B50", Offset = "0x2A62F50", Length = "0xA3")]
	[Token(Token = "0x6000579")]
	public static int4 rol(int4 x, int n) { }

	[Address(RVA = "0x2A63AC0", Offset = "0x2A62EC0", Length = "0x90")]
	[Token(Token = "0x6000578")]
	public static int3 rol(int3 x, int n) { }

	[Address(RVA = "0x2A63CE0", Offset = "0x2A630E0", Length = "0xB2")]
	[Token(Token = "0x6000577")]
	public static int2 rol(int2 x, int n) { }

	[Address(RVA = "0x2025B80", Offset = "0x2024F80", Length = "0x19")]
	[Token(Token = "0x6000576")]
	public static int rol(int x, int n) { }

	[Address(RVA = "0x28D83F0", Offset = "0x28D77F0", Length = "0x1A")]
	[Token(Token = "0x600057E")]
	public static long rol(long x, int n) { }

	[Address(RVA = "0x1ECFD20", Offset = "0x1ECF120", Length = "0x19")]
	[Token(Token = "0x6000580")]
	public static int ror(int x, int n) { }

	[Address(RVA = "0x1ECFD20", Offset = "0x1ECF120", Length = "0x19")]
	[Token(Token = "0x6000584")]
	public static uint ror(uint x, int n) { }

	[Address(RVA = "0x2A63E50", Offset = "0x2A63250", Length = "0x73")]
	[Token(Token = "0x6000585")]
	public static uint2 ror(uint2 x, int n) { }

	[Address(RVA = "0x2A640C0", Offset = "0x2A634C0", Length = "0x85")]
	[Token(Token = "0x6000582")]
	public static int3 ror(int3 x, int n) { }

	[Address(RVA = "0x2A63ED0", Offset = "0x2A632D0", Length = "0x97")]
	[Token(Token = "0x6000583")]
	public static int4 ror(int4 x, int n) { }

	[Address(RVA = "0x1ED13F0", Offset = "0x1ED07F0", Length = "0x1A")]
	[Token(Token = "0x6000589")]
	public static ulong ror(ulong x, int n) { }

	[Address(RVA = "0x1ED13F0", Offset = "0x1ED07F0", Length = "0x1A")]
	[Token(Token = "0x6000588")]
	public static long ror(long x, int n) { }

	[Address(RVA = "0x2A64150", Offset = "0x2A63550", Length = "0xCE")]
	[Token(Token = "0x6000587")]
	public static uint4 ror(uint4 x, int n) { }

	[Address(RVA = "0x2A63F70", Offset = "0x2A63370", Length = "0x9F")]
	[Token(Token = "0x6000586")]
	public static uint3 ror(uint3 x, int n) { }

	[Address(RVA = "0x2A64010", Offset = "0x2A63410", Length = "0xA5")]
	[Token(Token = "0x6000581")]
	public static int2 ror(int2 x, int n) { }

	[Address(RVA = "0x2A642F0", Offset = "0x2A636F0", Length = "0x14E")]
	[Token(Token = "0x6000705")]
	public static float3 rotate(RigidTransform a, float3 dir) { }

	[Address(RVA = "0x2A64520", Offset = "0x2A63920", Length = "0xCC")]
	[Token(Token = "0x6000020")]
	public static float3 rotate(AffineTransform a, float3 dir) { }

	[Address(RVA = "0x2A64440", Offset = "0x2A63840", Length = "0xD8")]
	[Token(Token = "0x6000146")]
	public static double3 rotate(double4x4 a, double3 b) { }

	[Address(RVA = "0x8FDDC0", Offset = "0x8FD1C0", Length = "0x12E")]
	[Token(Token = "0x60006F5")]
	public static float3 rotate(quaternion q, float3 v) { }

	[Address(RVA = "0x2A64220", Offset = "0x2A63620", Length = "0xC8")]
	[Token(Token = "0x6000212")]
	public static float3 rotate(float4x4 a, float3 b) { }

	[Address(RVA = "0x2A1E4D0", Offset = "0x2A1D8D0", Length = "0x3F7")]
	[Token(Token = "0x60006F9")]
	public static quaternion rotation(float3x3 m) { }

	[Address(RVA = "0x2A64960", Offset = "0x2A63D60", Length = "0x147")]
	[Token(Token = "0x6000431")]
	public static double4 round(double4 x) { }

	[Address(RVA = "0x2A645F0", Offset = "0x2A639F0", Length = "0xA9")]
	[Token(Token = "0x600042F")]
	public static double2 round(double2 x) { }

	[Address(RVA = "0x2A64AB0", Offset = "0x2A63EB0", Length = "0x167")]
	[Token(Token = "0x600042D")]
	public static float4 round(float4 x) { }

	[Address(RVA = "0x2A64800", Offset = "0x2A63C00", Length = "0x57")]
	[Token(Token = "0x600042A")]
	public static float round(float x) { }

	[Address(RVA = "0x2A647B0", Offset = "0x2A63BB0", Length = "0x4E")]
	[Token(Token = "0x600042E")]
	public static double round(double x) { }

	[Address(RVA = "0x2A646A0", Offset = "0x2A63AA0", Length = "0x10E")]
	[Token(Token = "0x600042C")]
	public static float3 round(float3 x) { }

	[Address(RVA = "0x2A64860", Offset = "0x2A63C60", Length = "0xF6")]
	[Token(Token = "0x6000430")]
	public static double3 round(double3 x) { }

	[Address(RVA = "0x2A64C20", Offset = "0x2A64020", Length = "0xAC")]
	[Token(Token = "0x600042B")]
	public static float2 round(float2 x) { }

	[Address(RVA = "0x2A1E8D0", Offset = "0x2A1DCD0", Length = "0x70")]
	[Token(Token = "0x60004AA")]
	public static double rsqrt(double x) { }

	[Address(RVA = "0x2A65110", Offset = "0x2A64510", Length = "0xC8")]
	[Token(Token = "0x60004A9")]
	public static float4 rsqrt(float4 x) { }

	[Address(RVA = "0x2A650F0", Offset = "0x2A644F0", Length = "0x1F")]
	[Token(Token = "0x60004A6")]
	public static float rsqrt(float x) { }

	[Address(RVA = "0x2A651E0", Offset = "0x2A645E0", Length = "0x50")]
	[Token(Token = "0x60004A7")]
	public static float2 rsqrt(float2 x) { }

	[Address(RVA = "0x2A64D60", Offset = "0x2A64160", Length = "0x183")]
	[Token(Token = "0x60004AC")]
	public static double3 rsqrt(double3 x) { }

	[Address(RVA = "0x2A64CD0", Offset = "0x2A640D0", Length = "0x85")]
	[Token(Token = "0x60004A8")]
	public static float3 rsqrt(float3 x) { }

	[Address(RVA = "0x2A65230", Offset = "0x2A64630", Length = "0x100")]
	[Token(Token = "0x60004AB")]
	public static double2 rsqrt(double2 x) { }

	[Address(RVA = "0x2A64EF0", Offset = "0x2A642F0", Length = "0x1FA")]
	[Token(Token = "0x60004AD")]
	public static double4 rsqrt(double4 x) { }

	[Address(RVA = "0x2A65400", Offset = "0x2A64800", Length = "0xFB")]
	[Token(Token = "0x60003AC")]
	public static double4 saturate(double4 x) { }

	[Address(RVA = "0x2A657B0", Offset = "0x2A64BB0", Length = "0x90")]
	[Token(Token = "0x60003AA")]
	public static double2 saturate(double2 x) { }

	[Address(RVA = "0x2A65500", Offset = "0x2A64900", Length = "0x4C")]
	[Token(Token = "0x60003A9")]
	public static double saturate(double x) { }

	[Address(RVA = "0x2A65550", Offset = "0x2A64950", Length = "0x108")]
	[Token(Token = "0x60003A8")]
	public static float4 saturate(float4 x) { }

	[Address(RVA = "0x2A65330", Offset = "0x2A64730", Length = "0xC1")]
	[Token(Token = "0x60003A7")]
	public static float3 saturate(float3 x) { }

	[Address(RVA = "0x2A65660", Offset = "0x2A64A60", Length = "0x29")]
	[Token(Token = "0x60003A6")]
	public static float2 saturate(float2 x) { }

	[Address(RVA = "0x2A65770", Offset = "0x2A64B70", Length = "0x3A")]
	[Token(Token = "0x60003A5")]
	public static float saturate(float x) { }

	[Address(RVA = "0x2A65690", Offset = "0x2A64A90", Length = "0xD8")]
	[Token(Token = "0x60003AB")]
	public static double3 saturate(double3 x) { }

	[Address(RVA = "0x2A65840", Offset = "0x2A64C40", Length = "0xFD")]
	[Token(Token = "0x600060B")]
	public static float3x3 scaleMul(float3 s, float3x3 m) { }

	[Address(RVA = "0x2A659D0", Offset = "0x2A64DD0", Length = "0x9")]
	[Token(Token = "0x6000512")]
	public static float select(float falseValue, float trueValue, bool test) { }

	[Address(RVA = "0x2A659E0", Offset = "0x2A64DE0", Length = "0xC")]
	[Token(Token = "0x6000513")]
	public static float2 select(float2 falseValue, float2 trueValue, bool test) { }

	[Address(RVA = "0x2A65A40", Offset = "0x2A64E40", Length = "0x17")]
	[Token(Token = "0x6000505")]
	public static int4 select(int4 falseValue, int4 trueValue, bool test) { }

	[Address(RVA = "0x2A65AE0", Offset = "0x2A64EE0", Length = "0x2D")]
	[Token(Token = "0x6000506")]
	public static int2 select(int2 falseValue, int2 trueValue, bool2 test) { }

	[Address(RVA = "0x2A65990", Offset = "0x2A64D90", Length = "0x3B")]
	[Token(Token = "0x6000507")]
	public static int3 select(int3 falseValue, int3 trueValue, bool3 test) { }

	[Address(RVA = "0x2A65B70", Offset = "0x2A64F70", Length = "0x6D")]
	[Token(Token = "0x6000508")]
	public static int4 select(int4 falseValue, int4 trueValue, bool4 test) { }

	[Address(RVA = "0x2A65980", Offset = "0x2A64D80", Length = "0x9")]
	[Token(Token = "0x6000509")]
	public static uint select(uint falseValue, uint trueValue, bool test) { }

	[Address(RVA = "0x2A659E0", Offset = "0x2A64DE0", Length = "0xC")]
	[Token(Token = "0x600050A")]
	public static uint2 select(uint2 falseValue, uint2 trueValue, bool test) { }

	[Address(RVA = "0x2A65AB0", Offset = "0x2A64EB0", Length = "0x2B")]
	[Token(Token = "0x600050B")]
	public static uint3 select(uint3 falseValue, uint3 trueValue, bool test) { }

	[Address(RVA = "0x2A65A40", Offset = "0x2A64E40", Length = "0x17")]
	[Token(Token = "0x600050C")]
	public static uint4 select(uint4 falseValue, uint4 trueValue, bool test) { }

	[Address(RVA = "0x2A65AE0", Offset = "0x2A64EE0", Length = "0x2D")]
	[Token(Token = "0x600050D")]
	public static uint2 select(uint2 falseValue, uint2 trueValue, bool2 test) { }

	[Address(RVA = "0x2A65980", Offset = "0x2A64D80", Length = "0x9")]
	[Token(Token = "0x6000502")]
	public static int select(int falseValue, int trueValue, bool test) { }

	[Address(RVA = "0x2A65990", Offset = "0x2A64D90", Length = "0x3B")]
	[Token(Token = "0x600050E")]
	public static uint3 select(uint3 falseValue, uint3 trueValue, bool3 test) { }

	[Address(RVA = "0x2A65AB0", Offset = "0x2A64EB0", Length = "0x2B")]
	[Token(Token = "0x6000514")]
	public static float3 select(float3 falseValue, float3 trueValue, bool test) { }

	[Address(RVA = "0x2A65AB0", Offset = "0x2A64EB0", Length = "0x2B")]
	[Token(Token = "0x6000504")]
	public static int3 select(int3 falseValue, int3 trueValue, bool test) { }

	[Address(RVA = "0x2A659F0", Offset = "0x2A64DF0", Length = "0x4F")]
	[Token(Token = "0x6000516")]
	public static float2 select(float2 falseValue, float2 trueValue, bool2 test) { }

	[Address(RVA = "0x2A65A40", Offset = "0x2A64E40", Length = "0x17")]
	[Token(Token = "0x6000515")]
	public static float4 select(float4 falseValue, float4 trueValue, bool test) { }

	[Address(RVA = "0x2A659E0", Offset = "0x2A64DE0", Length = "0xC")]
	[Token(Token = "0x6000503")]
	public static int2 select(int2 falseValue, int2 trueValue, bool test) { }

	[Address(RVA = "0x2A65B10", Offset = "0x2A64F10", Length = "0x60")]
	[Token(Token = "0x6000518")]
	public static float4 select(float4 falseValue, float4 trueValue, bool4 test) { }

	[Address(RVA = "0x2A659D0", Offset = "0x2A64DD0", Length = "0x9")]
	[Token(Token = "0x6000519")]
	public static double select(double falseValue, double trueValue, bool test) { }

	[Address(RVA = "0x2A65A40", Offset = "0x2A64E40", Length = "0x17")]
	[Token(Token = "0x600051A")]
	public static double2 select(double2 falseValue, double2 trueValue, bool test) { }

	[Address(RVA = "0x2A65CC0", Offset = "0x2A650C0", Length = "0x2C")]
	[Token(Token = "0x600051B")]
	public static double3 select(double3 falseValue, double3 trueValue, bool test) { }

	[Address(RVA = "0x2A65CF0", Offset = "0x2A650F0", Length = "0x28")]
	[Token(Token = "0x600051C")]
	public static double4 select(double4 falseValue, double4 trueValue, bool test) { }

	[Address(RVA = "0x2A65950", Offset = "0x2A64D50", Length = "0x2D")]
	[Token(Token = "0x600051D")]
	public static double2 select(double2 falseValue, double2 trueValue, bool2 test) { }

	[Address(RVA = "0x2A65B70", Offset = "0x2A64F70", Length = "0x6D")]
	[Token(Token = "0x600050F")]
	public static uint4 select(uint4 falseValue, uint4 trueValue, bool4 test) { }

	[Address(RVA = "0x2A65A60", Offset = "0x2A64E60", Length = "0x41")]
	[Token(Token = "0x6000517")]
	public static float3 select(float3 falseValue, float3 trueValue, bool3 test) { }

	[Address(RVA = "0x2A65940", Offset = "0x2A64D40", Length = "0xB")]
	[Token(Token = "0x6000511")]
	public static ulong select(ulong falseValue, ulong trueValue, bool test) { }

	[Address(RVA = "0x2A65C60", Offset = "0x2A65060", Length = "0x53")]
	[Token(Token = "0x600051E")]
	public static double3 select(double3 falseValue, double3 trueValue, bool3 test) { }

	[Address(RVA = "0x2A65940", Offset = "0x2A64D40", Length = "0xB")]
	[Token(Token = "0x6000510")]
	public static long select(long falseValue, long trueValue, bool test) { }

	[Address(RVA = "0x2A65BE0", Offset = "0x2A64FE0", Length = "0x73")]
	[Token(Token = "0x600051F")]
	public static double4 select(double4 falseValue, double4 trueValue, bool4 test) { }

	[Address(RVA = "0x2A1F300", Offset = "0x2A1E700", Length = "0xF8")]
	[Token(Token = "0x600004D")]
	internal static bool select_shuffle_component(bool3 a, bool3 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1F860", Offset = "0x2A1EC60", Length = "0x110")]
	[Token(Token = "0x60001EA")]
	internal static float select_shuffle_component(float4 a, float4 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1F620", Offset = "0x2A1EA20", Length = "0xFC")]
	[Token(Token = "0x60000D7")]
	internal static double select_shuffle_component(double3 a, double3 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1F740", Offset = "0x2A1EB40", Length = "0x100")]
	[Token(Token = "0x600079A")]
	internal static uint select_shuffle_component(uint4 a, uint4 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1E940", Offset = "0x2A1DD40", Length = "0xF0")]
	[Token(Token = "0x6000291")]
	internal static int select_shuffle_component(int3 a, int3 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1EC60", Offset = "0x2A1E060", Length = "0xE8")]
	[Token(Token = "0x6000095")]
	internal static double select_shuffle_component(double2 a, double2 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1EF90", Offset = "0x2A1E390", Length = "0x100")]
	[Token(Token = "0x60002D4")]
	internal static int select_shuffle_component(int4 a, int4 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1ED60", Offset = "0x2A1E160", Length = "0x104")]
	[Token(Token = "0x600006F")]
	internal static bool select_shuffle_component(bool4 a, bool4 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1F0B0", Offset = "0x2A1E4B0", Length = "0x118")]
	[Token(Token = "0x600011E")]
	internal static double select_shuffle_component(double4 a, double4 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1EA50", Offset = "0x2A1DE50", Length = "0xD8")]
	[Token(Token = "0x600071A")]
	internal static uint select_shuffle_component(uint2 a, uint2 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1EE90", Offset = "0x2A1E290", Length = "0xDC")]
	[Token(Token = "0x600002F")]
	internal static bool select_shuffle_component(bool2 a, bool2 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1EB40", Offset = "0x2A1DF40", Length = "0xFC")]
	[Token(Token = "0x60001A3")]
	internal static float select_shuffle_component(float3 a, float3 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1F530", Offset = "0x2A1E930", Length = "0xD8")]
	[Token(Token = "0x6000252")]
	internal static int select_shuffle_component(int2 a, int2 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1F420", Offset = "0x2A1E820", Length = "0xF8")]
	[Token(Token = "0x6000161")]
	internal static float select_shuffle_component(float2 a, float2 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A1F1F0", Offset = "0x2A1E5F0", Length = "0xF0")]
	[Token(Token = "0x6000758")]
	internal static uint select_shuffle_component(uint3 a, uint3 b, ShuffleComponent component) { }

	[Address(RVA = "0x2A67280", Offset = "0x2A66680", Length = "0x12B")]
	[Token(Token = "0x6000757")]
	public static uint4 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A67560", Offset = "0x2A66960", Length = "0xF7")]
	[Token(Token = "0x6000799")]
	public static uint4 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A66A40", Offset = "0x2A65E40", Length = "0xBD")]
	[Token(Token = "0x6000798")]
	public static uint3 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A66730", Offset = "0x2A65B30", Length = "0xA2")]
	[Token(Token = "0x6000251")]
	public static int4 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A67A00", Offset = "0x2A66E00", Length = "0x50")]
	[Token(Token = "0x600024F")]
	public static int2 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A67550", Offset = "0x2A66950", Length = "0x8")]
	[Token(Token = "0x600024E")]
	public static int shuffle(int2 left, int2 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A65D20", Offset = "0x2A65120", Length = "0x5F")]
	[Token(Token = "0x6000797")]
	public static uint2 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A66320", Offset = "0x2A65720", Length = "0x2B")]
	[Token(Token = "0x6000796")]
	public static uint shuffle(uint4 left, uint4 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A67040", Offset = "0x2A66440", Length = "0x8")]
	[Token(Token = "0x6000716")]
	public static uint shuffle(uint2 left, uint2 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A65F00", Offset = "0x2A65300", Length = "0x50")]
	[Token(Token = "0x6000717")]
	public static uint2 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A66520", Offset = "0x2A65920", Length = "0x7E")]
	[Token(Token = "0x6000718")]
	public static uint3 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A67950", Offset = "0x2A66D50", Length = "0xA2")]
	[Token(Token = "0x6000719")]
	public static uint4 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A66F20", Offset = "0x2A66320", Length = "0x89")]
	[Token(Token = "0x6000755")]
	public static uint2 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A67AD0", Offset = "0x2A66ED0", Length = "0xFC")]
	[Token(Token = "0x6000756")]
	public static uint3 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A673B0", Offset = "0x2A667B0", Length = "0x7E")]
	[Token(Token = "0x6000250")]
	public static int3 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A67BD0", Offset = "0x2A66FD0", Length = "0x3D")]
	[Token(Token = "0x6000754")]
	public static uint shuffle(uint3 left, uint3 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A67660", Offset = "0x2A66A60", Length = "0x111")]
	[Token(Token = "0x6000094")]
	public static double4 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A67C10", Offset = "0x2A67010", Length = "0x50")]
	[Token(Token = "0x600002C")]
	public static bool2 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A66010", Offset = "0x2A65410", Length = "0x7D")]
	[Token(Token = "0x600002D")]
	public static bool3 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A666A0", Offset = "0x2A65AA0", Length = "0x8D")]
	[Token(Token = "0x600002E")]
	public static bool4 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A67210", Offset = "0x2A66610", Length = "0x6D")]
	[Token(Token = "0x600015E")]
	public static float2 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A66B00", Offset = "0x2A65F00", Length = "0x3B")]
	[Token(Token = "0x6000049")]
	public static bool shuffle(bool3 left, bool3 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A678C0", Offset = "0x2A66CC0", Length = "0x85")]
	[Token(Token = "0x600004A")]
	public static bool2 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A66D00", Offset = "0x2A66100", Length = "0xE4")]
	[Token(Token = "0x600004B")]
	public static bool3 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A65E00", Offset = "0x2A65200", Length = "0xFD")]
	[Token(Token = "0x600004C")]
	public static bool4 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A665A0", Offset = "0x2A659A0", Length = "0x3D")]
	[Token(Token = "0x600028D")]
	public static int shuffle(int3 left, int3 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A66C70", Offset = "0x2A66070", Length = "0x89")]
	[Token(Token = "0x600028E")]
	public static int2 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A677C0", Offset = "0x2A66BC0", Length = "0xFC")]
	[Token(Token = "0x600028F")]
	public static int3 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A66DF0", Offset = "0x2A661F0", Length = "0x12B")]
	[Token(Token = "0x6000290")]
	public static int4 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A66090", Offset = "0x2A65490", Length = "0xF7")]
	[Token(Token = "0x60002D3")]
	public static int4 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A680A0", Offset = "0x2A674A0", Length = "0xBD")]
	[Token(Token = "0x60002D2")]
	public static int3 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A67DC0", Offset = "0x2A671C0", Length = "0x125")]
	[Token(Token = "0x60000D5")]
	public static double3 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A65D80", Offset = "0x2A65180", Length = "0x5F")]
	[Token(Token = "0x60002D1")]
	public static int2 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A68050", Offset = "0x2A67450", Length = "0x4C")]
	[Token(Token = "0x600006C")]
	public static bool2 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A67A50", Offset = "0x2A66E50", Length = "0x75")]
	[Token(Token = "0x600006D")]
	public static bool3 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A66FB0", Offset = "0x2A663B0", Length = "0x85")]
	[Token(Token = "0x600006E")]
	public static bool4 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A66C40", Offset = "0x2A66040", Length = "0x2B")]
	[Token(Token = "0x60002D0")]
	public static int shuffle(int4 left, int4 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A67130", Offset = "0x2A66530", Length = "0xD3")]
	[Token(Token = "0x6000093")]
	public static double3 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A664A0", Offset = "0x2A658A0", Length = "0x78")]
	[Token(Token = "0x6000092")]
	public static double2 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A674E0", Offset = "0x2A668E0", Length = "0x2B")]
	[Token(Token = "0x6000091")]
	public static double shuffle(double2 left, double2 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A67050", Offset = "0x2A66450", Length = "0xD4")]
	[Token(Token = "0x60001E8")]
	public static float3 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A67CB0", Offset = "0x2A670B0", Length = "0x62")]
	[Token(Token = "0x60001E7")]
	public static float2 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A67C60", Offset = "0x2A67060", Length = "0x41")]
	[Token(Token = "0x60000D3")]
	public static double shuffle(double3 left, double3 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A66190", Offset = "0x2A65590", Length = "0x2B")]
	[Token(Token = "0x60001E6")]
	public static float shuffle(float4 left, float4 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A65F50", Offset = "0x2A65350", Length = "0xBA")]
	[Token(Token = "0x60000D4")]
	public static double2 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A661C0", Offset = "0x2A655C0", Length = "0x158")]
	[Token(Token = "0x60000D6")]
	public static double4 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A65DE0", Offset = "0x2A651E0", Length = "0x8")]
	[Token(Token = "0x600006B")]
	public static bool shuffle(bool4 left, bool4 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A65DF0", Offset = "0x2A651F0", Length = "0x8")]
	[Token(Token = "0x600002B")]
	public static bool shuffle(bool2 left, bool2 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A667E0", Offset = "0x2A65BE0", Length = "0x8")]
	[Token(Token = "0x600015D")]
	public static float shuffle(float2 left, float2 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A67EF0", Offset = "0x2A672F0", Length = "0x15E")]
	[Token(Token = "0x60001A2")]
	public static float4 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A66910", Offset = "0x2A65D10", Length = "0x127")]
	[Token(Token = "0x60001E9")]
	public static float4 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A67780", Offset = "0x2A66B80", Length = "0x3D")]
	[Token(Token = "0x600011A")]
	public static double shuffle(double4 left, double4 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A665E0", Offset = "0x2A659E0", Length = "0xB2")]
	[Token(Token = "0x600011B")]
	public static double2 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A667F0", Offset = "0x2A65BF0", Length = "0x119")]
	[Token(Token = "0x600011C")]
	public static double3 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A66350", Offset = "0x2A65750", Length = "0x148")]
	[Token(Token = "0x600011D")]
	public static double4 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A68160", Offset = "0x2A67560", Length = "0x111")]
	[Token(Token = "0x60001A1")]
	public static float3 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A67D20", Offset = "0x2A67120", Length = "0x91")]
	[Token(Token = "0x60001A0")]
	public static float2 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y) { }

	[Address(RVA = "0x2A67510", Offset = "0x2A66910", Length = "0x3D")]
	[Token(Token = "0x600019F")]
	public static float shuffle(float3 left, float3 right, ShuffleComponent x) { }

	[Address(RVA = "0x2A66B40", Offset = "0x2A65F40", Length = "0xF6")]
	[Token(Token = "0x6000160")]
	public static float4 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) { }

	[Address(RVA = "0x2A67430", Offset = "0x2A66830", Length = "0xAA")]
	[Token(Token = "0x600015F")]
	public static float3 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) { }

	[Address(RVA = "0x2A68490", Offset = "0x2A67890", Length = "0xB8")]
	[Token(Token = "0x6000451")]
	public static float4 sign(float4 x) { }

	[Address(RVA = "0x2A68340", Offset = "0x2A67740", Length = "0x36")]
	[Token(Token = "0x6000452")]
	public static double sign(double x) { }

	[Address(RVA = "0x2A68600", Offset = "0x2A67A00", Length = "0xF2")]
	[Token(Token = "0x6000455")]
	public static double4 sign(double4 x) { }

	[Address(RVA = "0x2A685C0", Offset = "0x2A679C0", Length = "0x33")]
	[Token(Token = "0x600044B")]
	public static int2 sign(int2 x) { }

	[Address(RVA = "0x2A68700", Offset = "0x2A67B00", Length = "0x80")]
	[Token(Token = "0x6000450")]
	public static float3 sign(float3 x) { }

	[Address(RVA = "0x2A68380", Offset = "0x2A67780", Length = "0x5C")]
	[Token(Token = "0x600044F")]
	public static float2 sign(float2 x) { }

	[Address(RVA = "0x2A68460", Offset = "0x2A67860", Length = "0x28")]
	[Token(Token = "0x600044E")]
	public static float sign(float x) { }

	[Address(RVA = "0x2A683E0", Offset = "0x2A677E0", Length = "0x74")]
	[Token(Token = "0x6000453")]
	public static double2 sign(double2 x) { }

	[Address(RVA = "0x2A68290", Offset = "0x2A67690", Length = "0xAB")]
	[Token(Token = "0x6000454")]
	public static double3 sign(double3 x) { }

	[Address(RVA = "0x2A68550", Offset = "0x2A67950", Length = "0x6F")]
	[Token(Token = "0x600044D")]
	public static int4 sign(int4 x) { }

	[Address(RVA = "0x2A68780", Offset = "0x2A67B80", Length = "0x48")]
	[Token(Token = "0x600044C")]
	public static int3 sign(int3 x) { }

	[Address(RVA = "0x2A68280", Offset = "0x2A67680", Length = "0xF")]
	[Token(Token = "0x600044A")]
	public static int sign(int x) { }

	[Address(RVA = "0x2A68EC0", Offset = "0x2A682C0", Length = "0x4E")]
	[Token(Token = "0x6000406")]
	public static double sin(double x) { }

	[Address(RVA = "0x2A68E00", Offset = "0x2A68200", Length = "0xB8")]
	[Token(Token = "0x6000407")]
	public static double2 sin(double2 x) { }

	[Address(RVA = "0x2A68940", Offset = "0x2A67D40", Length = "0x120")]
	[Token(Token = "0x6000404")]
	public static float3 sin(float3 x) { }

	[Address(RVA = "0x2A68D40", Offset = "0x2A68140", Length = "0xB4")]
	[Token(Token = "0x6000403")]
	public static float2 sin(float2 x) { }

	[Address(RVA = "0x2A68BC0", Offset = "0x2A67FC0", Length = "0x17C")]
	[Token(Token = "0x6000405")]
	public static float4 sin(float4 x) { }

	[Address(RVA = "0x2A688E0", Offset = "0x2A67CE0", Length = "0x57")]
	[Token(Token = "0x6000402")]
	public static float sin(float x) { }

	[Address(RVA = "0x2A687D0", Offset = "0x2A67BD0", Length = "0x108")]
	[Token(Token = "0x6000408")]
	public static double3 sin(double3 x) { }

	[Address(RVA = "0x2A68A60", Offset = "0x2A67E60", Length = "0x15C")]
	[Token(Token = "0x6000409")]
	public static double4 sin(double4 x) { }

	[Address(RVA = "0x2A696D0", Offset = "0x2A68AD0", Length = "0xA2")]
	[Token(Token = "0x600054A")]
	public static void sincos(double x, out double s, out double c) { }

	[Address(RVA = "0x2A698E0", Offset = "0x2A68CE0", Length = "0x204")]
	[Token(Token = "0x600054C")]
	public static void sincos(double3 x, out double3 s, out double3 c) { }

	[Address(RVA = "0x2A68F10", Offset = "0x2A68310", Length = "0x28E")]
	[Token(Token = "0x600054D")]
	public static void sincos(double4 x, out double4 s, out double4 c) { }

	[Address(RVA = "0x2A69AF0", Offset = "0x2A68EF0", Length = "0xB8")]
	[Token(Token = "0x6000546")]
	public static void sincos(float x, out float s, out float c) { }

	[Address(RVA = "0x2A69780", Offset = "0x2A68B80", Length = "0x15B")]
	[Token(Token = "0x600054B")]
	public static void sincos(double2 x, out double2 s, out double2 c) { }

	[Address(RVA = "0x2A693D0", Offset = "0x2A687D0", Length = "0x2F8")]
	[Token(Token = "0x6000549")]
	public static void sincos(float4 x, out float4 s, out float4 c) { }

	[Address(RVA = "0x2A691A0", Offset = "0x2A685A0", Length = "0x225")]
	[Token(Token = "0x6000548")]
	public static void sincos(float3 x, out float3 s, out float3 c) { }

	[Address(RVA = "0x2A69BB0", Offset = "0x2A68FB0", Length = "0x166")]
	[Token(Token = "0x6000547")]
	public static void sincos(float2 x, out float2 s, out float2 c) { }

	[Address(RVA = "0x2A6A1C0", Offset = "0x2A695C0", Length = "0x57")]
	[Token(Token = "0x600040A")]
	public static float sinh(float x) { }

	[Address(RVA = "0x2A6A3A0", Offset = "0x2A697A0", Length = "0xB4")]
	[Token(Token = "0x600040B")]
	public static float2 sinh(float2 x) { }

	[Address(RVA = "0x2A69DE0", Offset = "0x2A691E0", Length = "0x120")]
	[Token(Token = "0x600040C")]
	public static float3 sinh(float3 x) { }

	[Address(RVA = "0x2A6A220", Offset = "0x2A69620", Length = "0x17C")]
	[Token(Token = "0x600040D")]
	public static float4 sinh(float4 x) { }

	[Address(RVA = "0x2A6A170", Offset = "0x2A69570", Length = "0x4E")]
	[Token(Token = "0x600040E")]
	public static double sinh(double x) { }

	[Address(RVA = "0x2A69D20", Offset = "0x2A69120", Length = "0xB8")]
	[Token(Token = "0x600040F")]
	public static double2 sinh(double2 x) { }

	[Address(RVA = "0x2A6A060", Offset = "0x2A69460", Length = "0x108")]
	[Token(Token = "0x6000410")]
	public static double3 sinh(double3 x) { }

	[Address(RVA = "0x2A69F00", Offset = "0x2A69300", Length = "0x15C")]
	[Token(Token = "0x6000411")]
	public static double4 sinh(double4 x) { }

	[Address(RVA = "0x2A6A460", Offset = "0x2A69860", Length = "0x30D")]
	[Token(Token = "0x60006F7")]
	public static quaternion slerp(quaternion q1, quaternion q2, float t) { }

	[Address(RVA = "0x2A6AE00", Offset = "0x2A6A200", Length = "0xCB")]
	[Token(Token = "0x60004DD")]
	public static float2 smoothstep(float2 xMin, float2 xMax, float2 x) { }

	[Address(RVA = "0x2A6AD90", Offset = "0x2A6A190", Length = "0x61")]
	[Token(Token = "0x60004DC")]
	public static float smoothstep(float xMin, float xMax, float x) { }

	[Address(RVA = "0x2A6A870", Offset = "0x2A69C70", Length = "0x15B")]
	[Token(Token = "0x60004DE")]
	public static float3 smoothstep(float3 xMin, float3 xMax, float3 x) { }

	[Address(RVA = "0x2A6AF50", Offset = "0x2A6A350", Length = "0x204")]
	[Token(Token = "0x60004DF")]
	public static float4 smoothstep(float4 xMin, float4 xMax, float4 x) { }

	[Address(RVA = "0x2A6AED0", Offset = "0x2A6A2D0", Length = "0x73")]
	[Token(Token = "0x60004E0")]
	public static double smoothstep(double xMin, double xMax, double x) { }

	[Address(RVA = "0x2A6A770", Offset = "0x2A69B70", Length = "0xF1")]
	[Token(Token = "0x60004E1")]
	public static double2 smoothstep(double2 xMin, double2 xMax, double2 x) { }

	[Address(RVA = "0x2A6ABF0", Offset = "0x2A69FF0", Length = "0x199")]
	[Token(Token = "0x60004E2")]
	public static double3 smoothstep(double3 xMin, double3 xMax, double3 x) { }

	[Address(RVA = "0x2A6A9D0", Offset = "0x2A69DD0", Length = "0x219")]
	[Token(Token = "0x60004E3")]
	public static double4 smoothstep(double4 xMin, double4 xMax, double4 x) { }

	[Address(RVA = "0x2A6B510", Offset = "0x2A6A910", Length = "0x75")]
	[Token(Token = "0x600049E")]
	public static float sqrt(float x) { }

	[Address(RVA = "0x2A6B6E0", Offset = "0x2A6AAE0", Length = "0x69")]
	[Token(Token = "0x60004A0")]
	public static float3 sqrt(float3 x) { }

	[Address(RVA = "0x2A6B160", Offset = "0x2A6A560", Length = "0x8B")]
	[Token(Token = "0x60004A1")]
	public static float4 sqrt(float4 x) { }

	[Address(RVA = "0x2A6B1F0", Offset = "0x2A6A5F0", Length = "0x68")]
	[Token(Token = "0x60004A2")]
	public static double sqrt(double x) { }

	[Address(RVA = "0x2A6B260", Offset = "0x2A6A660", Length = "0xEA")]
	[Token(Token = "0x60004A3")]
	public static double2 sqrt(double2 x) { }

	[Address(RVA = "0x2A6B590", Offset = "0x2A6A990", Length = "0x14D")]
	[Token(Token = "0x60004A4")]
	public static double3 sqrt(double3 x) { }

	[Address(RVA = "0x2A6B350", Offset = "0x2A6A750", Length = "0x1B4")]
	[Token(Token = "0x60004A5")]
	public static double4 sqrt(double4 x) { }

	[Address(RVA = "0x2A1F990", Offset = "0x2A1ED90", Length = "0x3D")]
	[Token(Token = "0x600049F")]
	public static float2 sqrt(float2 x) { }

	[Address(RVA = "0x28995F0", Offset = "0x28989F0", Length = "0x5")]
	[Token(Token = "0x60005DC")]
	public static double square(double x) { }

	[Address(RVA = "0x2A6B8A0", Offset = "0x2A6ACA0", Length = "0x3B")]
	[Token(Token = "0x60005DA")]
	public static float3 square(float3 x) { }

	[Address(RVA = "0x2A6B7D0", Offset = "0x2A6ABD0", Length = "0x68")]
	[Token(Token = "0x60005DB")]
	public static float4 square(float4 x) { }

	[Address(RVA = "0x1DE8820", Offset = "0x1DE7C20", Length = "0x5")]
	[Token(Token = "0x60005D8")]
	public static float square(float x) { }

	[Address(RVA = "0x2A6B960", Offset = "0x2A6AD60", Length = "0x69")]
	[Token(Token = "0x60005E7")]
	public static uint4 square(uint4 x) { }

	[Address(RVA = "0x2A6B7A0", Offset = "0x2A6ABA0", Length = "0x26")]
	[Token(Token = "0x60005DD")]
	public static double2 square(double2 x) { }

	[Address(RVA = "0x2A6B860", Offset = "0x2A6AC60", Length = "0x3A")]
	[Token(Token = "0x60005DE")]
	public static double3 square(double3 x) { }

	[Address(RVA = "0x2A6B750", Offset = "0x2A6AB50", Length = "0x46")]
	[Token(Token = "0x60005DF")]
	public static double4 square(double4 x) { }

	[Address(RVA = "0x2A6B9D0", Offset = "0x2A6ADD0", Length = "0x22")]
	[Token(Token = "0x60005D9")]
	public static float2 square(float2 x) { }

	[Address(RVA = "0x2A6B840", Offset = "0x2A6AC40", Length = "0x1A")]
	[Token(Token = "0x60005E1")]
	public static int2 square(int2 x) { }

	[Address(RVA = "0x2A6B8E0", Offset = "0x2A6ACE0", Length = "0x69")]
	[Token(Token = "0x60005E2")]
	public static int3 square(int3 x) { }

	[Address(RVA = "0x2A6B960", Offset = "0x2A6AD60", Length = "0x69")]
	[Token(Token = "0x60005E3")]
	public static int4 square(int4 x) { }

	[Address(RVA = "0x2A6B950", Offset = "0x2A6AD50", Length = "0x6")]
	[Token(Token = "0x60005E4")]
	public static uint square(uint x) { }

	[Address(RVA = "0x2A6B840", Offset = "0x2A6AC40", Length = "0x1A")]
	[Token(Token = "0x60005E5")]
	public static uint2 square(uint2 x) { }

	[Address(RVA = "0x2A6B8E0", Offset = "0x2A6ACE0", Length = "0x69")]
	[Token(Token = "0x60005E6")]
	public static uint3 square(uint3 x) { }

	[Address(RVA = "0x2A6B950", Offset = "0x2A6AD50", Length = "0x6")]
	[Token(Token = "0x60005E0")]
	public static int square(int x) { }

	[Address(RVA = "0x2A6BD00", Offset = "0x2A6B100", Length = "0x66")]
	[Token(Token = "0x6000521")]
	public static float2 step(float2 threshold, float2 x) { }

	[Address(RVA = "0x2A6BBE0", Offset = "0x2A6AFE0", Length = "0x6A")]
	[Token(Token = "0x6000522")]
	public static float3 step(float3 threshold, float3 x) { }

	[Address(RVA = "0x2A6BA40", Offset = "0x2A6AE40", Length = "0xC8")]
	[Token(Token = "0x6000523")]
	public static float4 step(float4 threshold, float4 x) { }

	[Address(RVA = "0x2A6BA20", Offset = "0x2A6AE20", Length = "0x1A")]
	[Token(Token = "0x6000524")]
	public static double step(double threshold, double x) { }

	[Address(RVA = "0x2A6BB80", Offset = "0x2A6AF80", Length = "0x5B")]
	[Token(Token = "0x6000525")]
	public static double2 step(double2 threshold, double2 x) { }

	[Address(RVA = "0x2A6BB10", Offset = "0x2A6AF10", Length = "0x6B")]
	[Token(Token = "0x6000526")]
	public static double3 step(double3 threshold, double3 x) { }

	[Address(RVA = "0x2A6BC50", Offset = "0x2A6B050", Length = "0xAA")]
	[Token(Token = "0x6000527")]
	public static double4 step(double4 threshold, double4 x) { }

	[Address(RVA = "0x2A6BA00", Offset = "0x2A6AE00", Length = "0x19")]
	[Token(Token = "0x6000520")]
	public static float step(float threshold, float x) { }

	[Address(RVA = "0x2A6C050", Offset = "0x2A6B450", Length = "0x108")]
	[Token(Token = "0x60003D0")]
	public static double3 tan(double3 x) { }

	[Address(RVA = "0x2A6BD70", Offset = "0x2A6B170", Length = "0xB8")]
	[Token(Token = "0x60003CF")]
	public static double2 tan(double2 x) { }

	[Address(RVA = "0x2A6BE30", Offset = "0x2A6B230", Length = "0xB4")]
	[Token(Token = "0x60003CB")]
	public static float2 tan(float2 x) { }

	[Address(RVA = "0x2A6BEF0", Offset = "0x2A6B2F0", Length = "0x15C")]
	[Token(Token = "0x60003D1")]
	public static double4 tan(double4 x) { }

	[Address(RVA = "0x2A6C210", Offset = "0x2A6B610", Length = "0x17C")]
	[Token(Token = "0x60003CD")]
	public static float4 tan(float4 x) { }

	[Address(RVA = "0x2A6C390", Offset = "0x2A6B790", Length = "0x120")]
	[Token(Token = "0x60003CC")]
	public static float3 tan(float3 x) { }

	[Address(RVA = "0x2A6C1B0", Offset = "0x2A6B5B0", Length = "0x57")]
	[Token(Token = "0x60003CA")]
	public static float tan(float x) { }

	[Address(RVA = "0x2A6C160", Offset = "0x2A6B560", Length = "0x4E")]
	[Token(Token = "0x60003CE")]
	public static double tan(double x) { }

	[Address(RVA = "0x2A6C9B0", Offset = "0x2A6BDB0", Length = "0x120")]
	[Token(Token = "0x60003D4")]
	public static float3 tanh(float3 x) { }

	[Address(RVA = "0x2A6C720", Offset = "0x2A6BB20", Length = "0x17C")]
	[Token(Token = "0x60003D5")]
	public static float4 tanh(float4 x) { }

	[Address(RVA = "0x2A6C8F0", Offset = "0x2A6BCF0", Length = "0xB4")]
	[Token(Token = "0x60003D3")]
	public static float2 tanh(float2 x) { }

	[Address(RVA = "0x2A6CAD0", Offset = "0x2A6BED0", Length = "0x57")]
	[Token(Token = "0x60003D2")]
	public static float tanh(float x) { }

	[Address(RVA = "0x2A6C4B0", Offset = "0x2A6B8B0", Length = "0x108")]
	[Token(Token = "0x60003D8")]
	public static double3 tanh(double3 x) { }

	[Address(RVA = "0x2A6C5C0", Offset = "0x2A6B9C0", Length = "0x15C")]
	[Token(Token = "0x60003D9")]
	public static double4 tanh(double4 x) { }

	[Address(RVA = "0x2A6C8A0", Offset = "0x2A6BCA0", Length = "0x4E")]
	[Token(Token = "0x60003D6")]
	public static double tanh(double x) { }

	[Address(RVA = "0x2A6CB30", Offset = "0x2A6BF30", Length = "0xB8")]
	[Token(Token = "0x60003D7")]
	public static double2 tanh(double2 x) { }

	[Address(RVA = "0x2A6CBF0", Offset = "0x2A6BFF0", Length = "0x17C")]
	[Token(Token = "0x6000706")]
	public static float3 transform(RigidTransform a, float3 pos) { }

	[Address(RVA = "0x8FDEF0", Offset = "0x8FD2F0", Length = "0x117")]
	[Token(Token = "0x6000213")]
	public static float3 transform(float4x4 a, float3 b) { }

	[Address(RVA = "0x2A6CE70", Offset = "0x2A6C270", Length = "0x112")]
	[Token(Token = "0x6000147")]
	public static double3 transform(double4x4 a, double3 b) { }

	[Address(RVA = "0x2A6CD70", Offset = "0x2A6C170", Length = "0xFF")]
	[Token(Token = "0x6000021")]
	public static float3 transform(AffineTransform a, float3 pos) { }

	[Address(RVA = "0x2A6D370", Offset = "0x2A6C770", Length = "0x52")]
	[Token(Token = "0x6000742")]
	public static uint4x2 transpose(uint2x4 v) { }

	[Address(RVA = "0x2A6D110", Offset = "0x2A6C510", Length = "0x41")]
	[Token(Token = "0x6000726")]
	public static uint2x2 transpose(uint2x2 v) { }

	[Address(RVA = "0x2A6D320", Offset = "0x2A6C720", Length = "0x4A")]
	[Token(Token = "0x60000BF")]
	public static double4x2 transpose(double2x4 v) { }

	[Address(RVA = "0x2A6DA50", Offset = "0x2A6CE50", Length = "0x50")]
	[Token(Token = "0x60001AF")]
	public static float2x3 transpose(float3x2 v) { }

	[Address(RVA = "0x2A6D2A0", Offset = "0x2A6C6A0", Length = "0x77")]
	[Token(Token = "0x6000780")]
	public static uint4x3 transpose(uint3x4 v) { }

	[Address(RVA = "0x2A6D110", Offset = "0x2A6C510", Length = "0x41")]
	[Token(Token = "0x600025E")]
	public static int2x2 transpose(int2x2 v) { }

	[Address(RVA = "0x2A6D160", Offset = "0x2A6C560", Length = "0x64")]
	[Token(Token = "0x6000764")]
	public static uint2x3 transpose(uint3x2 v) { }

	[Address(RVA = "0x2A6E060", Offset = "0x2A6D460", Length = "0x38")]
	[Token(Token = "0x60000B1")]
	public static double3x2 transpose(double2x3 v) { }

	[Address(RVA = "0x2A6DDF0", Offset = "0x2A6D1F0", Length = "0xA5")]
	[Token(Token = "0x60001BD")]
	public static float3x3 transpose(float3x3 v) { }

	[Address(RVA = "0x2A6D860", Offset = "0x2A6CC60", Length = "0xFF")]
	[Token(Token = "0x60001CD")]
	public static float4x3 transpose(float3x4 v) { }

	[Address(RVA = "0x2A6D740", Offset = "0x2A6CB40", Length = "0x58")]
	[Token(Token = "0x6000772")]
	public static uint3x3 transpose(uint3x3 v) { }

	[Address(RVA = "0x2A6DF20", Offset = "0x2A6D320", Length = "0x46")]
	[Token(Token = "0x6000734")]
	public static uint3x2 transpose(uint2x3 v) { }

	[Address(RVA = "0x2A6D5A0", Offset = "0x2A6C9A0", Length = "0x26")]
	[Token(Token = "0x60000A1")]
	public static double2x2 transpose(double2x2 v) { }

	[Address(RVA = "0x2A6D740", Offset = "0x2A6CB40", Length = "0x58")]
	[Token(Token = "0x60002AB")]
	public static int3x3 transpose(int3x3 v) { }

	[Address(RVA = "0x2A6D9B0", Offset = "0x2A6CDB0", Length = "0x9C")]
	[Token(Token = "0x60007C2")]
	public static uint4x4 transpose(uint4x4 v) { }

	[Address(RVA = "0x2A6D5D0", Offset = "0x2A6C9D0", Length = "0x77")]
	[Token(Token = "0x60007B4")]
	public static uint3x4 transpose(uint4x3 v) { }

	[Address(RVA = "0x2A6DAA0", Offset = "0x2A6CEA0", Length = "0x86")]
	[Token(Token = "0x60001F6")]
	public static float2x4 transpose(float4x2 v) { }

	[Address(RVA = "0x2A6D510", Offset = "0x2A6C910", Length = "0x4A")]
	[Token(Token = "0x600012A")]
	public static double2x4 transpose(double4x2 v) { }

	[Address(RVA = "0x2A6DC80", Offset = "0x2A6D080", Length = "0x16C")]
	[Token(Token = "0x6000214")]
	public static float4x4 transpose(float4x4 v) { }

	[Address(RVA = "0x2A6DF20", Offset = "0x2A6D320", Length = "0x46")]
	[Token(Token = "0x600026D")]
	public static int3x2 transpose(int2x3 v) { }

	[Address(RVA = "0x2A6DB30", Offset = "0x2A6CF30", Length = "0x7E")]
	[Token(Token = "0x6000138")]
	public static double3x4 transpose(double4x3 v) { }

	[Address(RVA = "0x2A6D7A0", Offset = "0x2A6CBA0", Length = "0xBA")]
	[Token(Token = "0x6000148")]
	public static double4x4 transpose(double4x4 v) { }

	[Address(RVA = "0x2A6D370", Offset = "0x2A6C770", Length = "0x52")]
	[Token(Token = "0x600027B")]
	public static int4x2 transpose(int2x4 v) { }

	[Address(RVA = "0x2A6D560", Offset = "0x2A6C960", Length = "0x36")]
	[Token(Token = "0x6000033")]
	public static bool2x2 transpose(bool2x2 v) { }

	[Address(RVA = "0x2A6D050", Offset = "0x2A6C450", Length = "0x7C")]
	[Token(Token = "0x6000073")]
	public static bool2x4 transpose(bool4x2 v) { }

	[Address(RVA = "0x2A6D160", Offset = "0x2A6C560", Length = "0x64")]
	[Token(Token = "0x600029D")]
	public static int2x3 transpose(int3x2 v) { }

	[Address(RVA = "0x2A6DFD0", Offset = "0x2A6D3D0", Length = "0x8A")]
	[Token(Token = "0x600005D")]
	public static bool4x3 transpose(bool3x4 v) { }

	[Address(RVA = "0x2A6DBB0", Offset = "0x2A6CFB0", Length = "0x5A")]
	[Token(Token = "0x6000057")]
	public static bool3x3 transpose(bool3x3 v) { }

	[Address(RVA = "0x2A6D1D0", Offset = "0x2A6C5D0", Length = "0x7A")]
	[Token(Token = "0x60007A6")]
	public static uint2x4 transpose(uint4x2 v) { }

	[Address(RVA = "0x2A6DF70", Offset = "0x2A6D370", Length = "0x5B")]
	[Token(Token = "0x6000051")]
	public static bool2x3 transpose(bool3x2 v) { }

	[Address(RVA = "0x2A6E0A0", Offset = "0x2A6D4A0", Length = "0x7A")]
	[Token(Token = "0x6000079")]
	public static bool3x4 transpose(bool4x3 v) { }

	[Address(RVA = "0x2A6DC10", Offset = "0x2A6D010", Length = "0x64")]
	[Token(Token = "0x600003F")]
	public static bool4x2 transpose(bool2x4 v) { }

	[Address(RVA = "0x2A6CF90", Offset = "0x2A6C390", Length = "0xB1")]
	[Token(Token = "0x600007F")]
	public static bool4x4 transpose(bool4x4 v) { }

	[Address(RVA = "0x2A6D0D0", Offset = "0x2A6C4D0", Length = "0x3E")]
	[Token(Token = "0x600016D")]
	public static float2x2 transpose(float2x2 v) { }

	[Address(RVA = "0x2A6D650", Offset = "0x2A6CA50", Length = "0x5C")]
	[Token(Token = "0x60000F1")]
	public static double3x3 transpose(double3x3 v) { }

	[Address(RVA = "0x2A6D4D0", Offset = "0x2A6C8D0", Length = "0x38")]
	[Token(Token = "0x60000E3")]
	public static double2x3 transpose(double3x2 v) { }

	[Address(RVA = "0x2A6D2A0", Offset = "0x2A6C6A0", Length = "0x77")]
	[Token(Token = "0x60002BA")]
	public static int4x3 transpose(int3x4 v) { }

	[Address(RVA = "0x2A6D3D0", Offset = "0x2A6C7D0", Length = "0xFF")]
	[Token(Token = "0x6000204")]
	public static float3x4 transpose(float4x3 v) { }

	[Address(RVA = "0x2A6DEA0", Offset = "0x2A6D2A0", Length = "0x7E")]
	[Token(Token = "0x6000101")]
	public static double4x3 transpose(double3x4 v) { }

	[Address(RVA = "0x2A6D250", Offset = "0x2A6C650", Length = "0x42")]
	[Token(Token = "0x6000039")]
	public static bool3x2 transpose(bool2x3 v) { }

	[Address(RVA = "0x2A6D5D0", Offset = "0x2A6C9D0", Length = "0x77")]
	[Token(Token = "0x60002EE")]
	public static int3x4 transpose(int4x3 v) { }

	[Address(RVA = "0x2A6D6B0", Offset = "0x2A6CAB0", Length = "0x86")]
	[Token(Token = "0x600018B")]
	public static float4x2 transpose(float2x4 v) { }

	[Address(RVA = "0x2A6D1D0", Offset = "0x2A6C5D0", Length = "0x7A")]
	[Token(Token = "0x60002E0")]
	public static int2x4 transpose(int4x2 v) { }

	[Address(RVA = "0x2A6D960", Offset = "0x2A6CD60", Length = "0x50")]
	[Token(Token = "0x600017D")]
	public static float3x2 transpose(float2x3 v) { }

	[Address(RVA = "0x2A6D9B0", Offset = "0x2A6CDB0", Length = "0x9C")]
	[Token(Token = "0x60002FC")]
	public static int4x4 transpose(int4x4 v) { }

	[Address(RVA = "0x2A6E500", Offset = "0x2A6D900", Length = "0x14F")]
	[Token(Token = "0x6000439")]
	public static double4 trunc(double4 x) { }

	[Address(RVA = "0x2A6E650", Offset = "0x2A6DA50", Length = "0xAD")]
	[Token(Token = "0x6000437")]
	public static double2 trunc(double2 x) { }

	[Address(RVA = "0x2A6E290", Offset = "0x2A6D690", Length = "0x50")]
	[Token(Token = "0x6000436")]
	public static double trunc(double x) { }

	[Address(RVA = "0x2A6E120", Offset = "0x2A6D520", Length = "0x16F")]
	[Token(Token = "0x6000435")]
	public static float4 trunc(float4 x) { }

	[Address(RVA = "0x2A6E3E0", Offset = "0x2A6D7E0", Length = "0x114")]
	[Token(Token = "0x6000434")]
	public static float3 trunc(float3 x) { }

	[Address(RVA = "0x2A6E700", Offset = "0x2A6DB00", Length = "0xB0")]
	[Token(Token = "0x6000433")]
	public static float2 trunc(float2 x) { }

	[Address(RVA = "0x2A6E7B0", Offset = "0x2A6DBB0", Length = "0x59")]
	[Token(Token = "0x6000432")]
	public static float trunc(float x) { }

	[Address(RVA = "0x2A6E2E0", Offset = "0x2A6D6E0", Length = "0xFC")]
	[Token(Token = "0x6000438")]
	public static double3 trunc(double3 x) { }

	[Address(RVA = "0x2A6E810", Offset = "0x2A6DC10", Length = "0xF7")]
	[Token(Token = "0x6000564")]
	public static int3 tzcnt(int3 x) { }

	[Address(RVA = "0x28A7D60", Offset = "0x28A7160", Length = "0x65")]
	[Token(Token = "0x600056A")]
	public static int tzcnt(long x) { }

	[Address(RVA = "0x2A6E9C0", Offset = "0x2A6DDC0", Length = "0x146")]
	[Token(Token = "0x6000569")]
	public static int4 tzcnt(uint4 x) { }

	[Address(RVA = "0x2A6E810", Offset = "0x2A6DC10", Length = "0xF7")]
	[Token(Token = "0x6000568")]
	public static int3 tzcnt(uint3 x) { }

	[Address(RVA = "0x2A6E910", Offset = "0x2A6DD10", Length = "0xA7")]
	[Token(Token = "0x6000567")]
	public static int2 tzcnt(uint2 x) { }

	[Address(RVA = "0x7D6040", Offset = "0x7D5440", Length = "0x48")]
	[Token(Token = "0x6000566")]
	public static int tzcnt(uint x) { }

	[Address(RVA = "0x2A6E9C0", Offset = "0x2A6DDC0", Length = "0x146")]
	[Token(Token = "0x6000565")]
	public static int4 tzcnt(int4 x) { }

	[Address(RVA = "0x2A6E910", Offset = "0x2A6DD10", Length = "0xA7")]
	[Token(Token = "0x6000563")]
	public static int2 tzcnt(int2 x) { }

	[Address(RVA = "0x7D6040", Offset = "0x7D5440", Length = "0x48")]
	[Token(Token = "0x6000562")]
	public static int tzcnt(int x) { }

	[Address(RVA = "0x28A7D60", Offset = "0x28A7160", Length = "0x65")]
	[Token(Token = "0x600056B")]
	public static int tzcnt(ulong x) { }

	[Address(RVA = "0x2A6EBE0", Offset = "0x2A6DFE0", Length = "0x4A")]
	[Token(Token = "0x6000711")]
	public static uint2 uint2(float2 v) { }

	[Address(RVA = "0x2A42BF0", Offset = "0x2A41FF0", Length = "0xE")]
	[Token(Token = "0x600070B")]
	public static uint2 uint2(uint v) { }

	[Address(RVA = "0x28D8420", Offset = "0x28D7820", Length = "0x12")]
	[Token(Token = "0x600070F")]
	public static uint2 uint2(int2 v) { }

	[Address(RVA = "0x2A42BF0", Offset = "0x2A41FF0", Length = "0xE")]
	[Token(Token = "0x600070E")]
	public static uint2 uint2(int v) { }

	[Address(RVA = "0x2A42BD0", Offset = "0x2A41FD0", Length = "0x20")]
	[Token(Token = "0x600070D")]
	public static uint2 uint2(bool2 v) { }

	[Address(RVA = "0x2A6EB10", Offset = "0x2A6DF10", Length = "0x42")]
	[Token(Token = "0x6000713")]
	public static uint2 uint2(double2 v) { }

	[Address(RVA = "0x2A42B90", Offset = "0x2A41F90", Length = "0x16")]
	[Token(Token = "0x600070C")]
	public static uint2 uint2(bool v) { }

	[Address(RVA = "0x2A6EB60", Offset = "0x2A6DF60", Length = "0x37")]
	[Token(Token = "0x6000712")]
	public static uint2 uint2(double v) { }

	[Address(RVA = "0x2A6EBA0", Offset = "0x2A6DFA0", Length = "0x36")]
	[Token(Token = "0x6000710")]
	public static uint2 uint2(float v) { }

	[Address(RVA = "0x28D8420", Offset = "0x28D7820", Length = "0x12")]
	[Token(Token = "0x600070A")]
	public static uint2 uint2(uint2 xy) { }

	[Address(RVA = "0x2A27C90", Offset = "0x2A27090", Length = "0xE")]
	[Token(Token = "0x6000709")]
	public static uint2 uint2(uint x, uint y) { }

	[Address(RVA = "0x2A42E90", Offset = "0x2A42290", Length = "0x59")]
	[Token(Token = "0x600071E")]
	public static uint2x2 uint2x2(bool v) { }

	[Address(RVA = "0x2A6EDB0", Offset = "0x2A6E1B0", Length = "0x8C")]
	[Token(Token = "0x6000723")]
	public static uint2x2 uint2x2(float2x2 v) { }

	[Address(RVA = "0x2A6EC30", Offset = "0x2A6E030", Length = "0x6E")]
	[Token(Token = "0x6000722")]
	public static uint2x2 uint2x2(float v) { }

	[Address(RVA = "0x2A6ED10", Offset = "0x2A6E110", Length = "0x9C")]
	[Token(Token = "0x6000725")]
	public static uint2x2 uint2x2(double2x2 v) { }

	[Address(RVA = "0x2A348C0", Offset = "0x2A33CC0", Length = "0xB")]
	[Token(Token = "0x600071B")]
	public static uint2x2 uint2x2(uint2 c0, uint2 c1) { }

	[Address(RVA = "0x2A42D40", Offset = "0x2A42140", Length = "0x2B")]
	[Token(Token = "0x600071C")]
	public static uint2x2 uint2x2(uint m00, uint m01, uint m10, uint m11) { }

	[Address(RVA = "0x2A42D10", Offset = "0x2A42110", Length = "0x25")]
	[Token(Token = "0x600071D")]
	public static uint2x2 uint2x2(uint v) { }

	[Address(RVA = "0x2A42E00", Offset = "0x2A42200", Length = "0x49")]
	[Token(Token = "0x6000721")]
	public static uint2x2 uint2x2(int2x2 v) { }

	[Address(RVA = "0x2A42D10", Offset = "0x2A42110", Length = "0x25")]
	[Token(Token = "0x6000720")]
	public static uint2x2 uint2x2(int v) { }

	[Address(RVA = "0x2A6ECA0", Offset = "0x2A6E0A0", Length = "0x6F")]
	[Token(Token = "0x6000724")]
	public static uint2x2 uint2x2(double v) { }

	[Address(RVA = "0x2A42C20", Offset = "0x2A42020", Length = "0x9D")]
	[Token(Token = "0x600071F")]
	public static uint2x2 uint2x2(bool2x2 v) { }

	[Address(RVA = "0x2A43020", Offset = "0x2A42420", Length = "0x36")]
	[Token(Token = "0x600072B")]
	public static uint2x3 uint2x3(uint v) { }

	[Address(RVA = "0x2A43240", Offset = "0x2A42640", Length = "0x7B")]
	[Token(Token = "0x600072C")]
	public static uint2x3 uint2x3(bool v) { }

	[Address(RVA = "0x25DC8A0", Offset = "0x25DBCA0", Length = "0x81E")]
	[Token(Token = "0x6000729")]
	public static uint2x3 uint2x3(uint2 c0, uint2 c1, uint2 c2) { }

	[Address(RVA = "0x2A430B0", Offset = "0x2A424B0", Length = "0x11E")]
	[Token(Token = "0x600072D")]
	public static uint2x3 uint2x3(bool2x3 v) { }

	[Address(RVA = "0x2A43020", Offset = "0x2A42420", Length = "0x36")]
	[Token(Token = "0x600072E")]
	public static uint2x3 uint2x3(int v) { }

	[Address(RVA = "0x2A42F90", Offset = "0x2A42390", Length = "0x8A")]
	[Token(Token = "0x600072F")]
	public static uint2x3 uint2x3(int2x3 v) { }

	[Address(RVA = "0x2A6EFD0", Offset = "0x2A6E3D0", Length = "0x99")]
	[Token(Token = "0x6000730")]
	public static uint2x3 uint2x3(float v) { }

	[Address(RVA = "0x2A6EEE0", Offset = "0x2A6E2E0", Length = "0xEB")]
	[Token(Token = "0x6000731")]
	public static uint2x3 uint2x3(float2x3 v) { }

	[Address(RVA = "0x2A6EE40", Offset = "0x2A6E240", Length = "0x9A")]
	[Token(Token = "0x6000732")]
	public static uint2x3 uint2x3(double v) { }

	[Address(RVA = "0x2A6F070", Offset = "0x2A6E470", Length = "0xDA")]
	[Token(Token = "0x6000733")]
	public static uint2x3 uint2x3(double2x3 v) { }

	[Address(RVA = "0x2A42F40", Offset = "0x2A42340", Length = "0x44")]
	[Token(Token = "0x600072A")]
	public static uint2x3 uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12) { }

	[Address(RVA = "0x2A6F150", Offset = "0x2A6E550", Length = "0x111")]
	[Token(Token = "0x600073F")]
	public static uint2x4 uint2x4(float2x4 v) { }

	[Address(RVA = "0x27F0730", Offset = "0x27EFB30", Length = "0x18")]
	[Token(Token = "0x6000737")]
	public static uint2x4 uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3) { }

	[Address(RVA = "0x2A43470", Offset = "0x2A42870", Length = "0x5D")]
	[Token(Token = "0x6000738")]
	public static uint2x4 uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13) { }

	[Address(RVA = "0x2A43380", Offset = "0x2A42780", Length = "0x47")]
	[Token(Token = "0x6000739")]
	public static uint2x4 uint2x4(uint v) { }

	[Address(RVA = "0x2A434D0", Offset = "0x2A428D0", Length = "0x9D")]
	[Token(Token = "0x600073A")]
	public static uint2x4 uint2x4(bool v) { }

	[Address(RVA = "0x2A43350", Offset = "0x2A42750", Length = "0x24")]
	[Token(Token = "0x600073B")]
	public static uint2x4 uint2x4(bool2x4 v) { }

	[Address(RVA = "0x2A43380", Offset = "0x2A42780", Length = "0x47")]
	[Token(Token = "0x600073C")]
	public static uint2x4 uint2x4(int v) { }

	[Address(RVA = "0x2A433D0", Offset = "0x2A427D0", Length = "0x95")]
	[Token(Token = "0x600073D")]
	public static uint2x4 uint2x4(int2x4 v) { }

	[Address(RVA = "0x2A6F270", Offset = "0x2A6E670", Length = "0xC4")]
	[Token(Token = "0x600073E")]
	public static uint2x4 uint2x4(float v) { }

	[Address(RVA = "0x2A6F410", Offset = "0x2A6E810", Length = "0x118")]
	[Token(Token = "0x6000741")]
	public static uint2x4 uint2x4(double2x4 v) { }

	[Address(RVA = "0x2A6F340", Offset = "0x2A6E740", Length = "0xC5")]
	[Token(Token = "0x6000740")]
	public static uint2x4 uint2x4(double v) { }

	[Address(RVA = "0x2A43820", Offset = "0x2A42C20", Length = "0x30")]
	[Token(Token = "0x600074D")]
	public static uint3 uint3(int3 v) { }

	[Address(RVA = "0x2A6F610", Offset = "0x2A6EA10", Length = "0x3F")]
	[Token(Token = "0x6000750")]
	public static uint3 uint3(double v) { }

	[Address(RVA = "0x2A6F530", Offset = "0x2A6E930", Length = "0x64")]
	[Token(Token = "0x600074F")]
	public static uint3 uint3(float3 v) { }

	[Address(RVA = "0x2A27CF0", Offset = "0x2A270F0", Length = "0xE")]
	[Token(Token = "0x6000745")]
	public static uint3 uint3(uint x, uint y, uint z) { }

	[Address(RVA = "0x2A437E0", Offset = "0x2A42BE0", Length = "0x12")]
	[Token(Token = "0x6000746")]
	public static uint3 uint3(uint x, uint2 yz) { }

	[Address(RVA = "0x2A43800", Offset = "0x2A42C00", Length = "0x11")]
	[Token(Token = "0x6000747")]
	public static uint3 uint3(uint2 xy, uint z) { }

	[Address(RVA = "0x2A43820", Offset = "0x2A42C20", Length = "0x30")]
	[Token(Token = "0x6000748")]
	public static uint3 uint3(uint3 xyz) { }

	[Address(RVA = "0x2A437A0", Offset = "0x2A42BA0", Length = "0xC")]
	[Token(Token = "0x6000749")]
	public static uint3 uint3(uint v) { }

	[Address(RVA = "0x2A43780", Offset = "0x2A42B80", Length = "0x17")]
	[Token(Token = "0x600074A")]
	public static uint3 uint3(bool v) { }

	[Address(RVA = "0x2A43890", Offset = "0x2A42C90", Length = "0x34")]
	[Token(Token = "0x600074B")]
	public static uint3 uint3(bool3 v) { }

	[Address(RVA = "0x2A437A0", Offset = "0x2A42BA0", Length = "0xC")]
	[Token(Token = "0x600074C")]
	public static uint3 uint3(int v) { }

	[Address(RVA = "0x2A6F650", Offset = "0x2A6EA50", Length = "0x3E")]
	[Token(Token = "0x600074E")]
	public static uint3 uint3(float v) { }

	[Address(RVA = "0x2A6F5A0", Offset = "0x2A6E9A0", Length = "0x6B")]
	[Token(Token = "0x6000751")]
	public static uint3 uint3(double3 v) { }

	[Address(RVA = "0x2A6F690", Offset = "0x2A6EA90", Length = "0x88")]
	[Token(Token = "0x6000762")]
	public static uint3x2 uint3x2(double v) { }

	[Address(RVA = "0x2A6F7E0", Offset = "0x2A6EBE0", Length = "0xCB")]
	[Token(Token = "0x6000761")]
	public static uint3x2 uint3x2(float3x2 v) { }

	[Address(RVA = "0x2A6F8B0", Offset = "0x2A6ECB0", Length = "0x87")]
	[Token(Token = "0x6000760")]
	public static uint3x2 uint3x2(float v) { }

	[Address(RVA = "0x2A43970", Offset = "0x2A42D70", Length = "0x7A")]
	[Token(Token = "0x600075F")]
	public static uint3x2 uint3x2(int3x2 v) { }

	[Address(RVA = "0x2A43AC0", Offset = "0x2A42EC0", Length = "0x33")]
	[Token(Token = "0x600075E")]
	public static uint3x2 uint3x2(int v) { }

	[Address(RVA = "0x2A43B70", Offset = "0x2A42F70", Length = "0x96")]
	[Token(Token = "0x600075D")]
	public static uint3x2 uint3x2(bool3x2 v) { }

	[Address(RVA = "0x2A43B00", Offset = "0x2A42F00", Length = "0x70")]
	[Token(Token = "0x600075C")]
	public static uint3x2 uint3x2(bool v) { }

	[Address(RVA = "0x2A43AC0", Offset = "0x2A42EC0", Length = "0x33")]
	[Token(Token = "0x600075B")]
	public static uint3x2 uint3x2(uint v) { }

	[Address(RVA = "0x2A43A70", Offset = "0x2A42E70", Length = "0x41")]
	[Token(Token = "0x600075A")]
	public static uint3x2 uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21) { }

	[Address(RVA = "0x2A35CD0", Offset = "0x2A350D0", Length = "0x23")]
	[Token(Token = "0x6000759")]
	public static uint3x2 uint3x2(uint3 c0, uint3 c1) { }

	[Address(RVA = "0x2A6F720", Offset = "0x2A6EB20", Length = "0xB4")]
	[Token(Token = "0x6000763")]
	public static uint3x2 uint3x2(double3x2 v) { }

	[Address(RVA = "0x2A6F940", Offset = "0x2A6ED40", Length = "0xC3")]
	[Token(Token = "0x6000770")]
	public static uint3x3 uint3x3(double v) { }

	[Address(RVA = "0x2A6FBF0", Offset = "0x2A6EFF0", Length = "0x12A")]
	[Token(Token = "0x6000771")]
	public static uint3x3 uint3x3(double3x3 v) { }

	[Address(RVA = "0x2A6FB20", Offset = "0x2A6EF20", Length = "0xC2")]
	[Token(Token = "0x600076E")]
	public static uint3x3 uint3x3(float v) { }

	[Address(RVA = "0x2A43D70", Offset = "0x2A43170", Length = "0xA4")]
	[Token(Token = "0x600076D")]
	public static uint3x3 uint3x3(int3x3 v) { }

	[Address(RVA = "0x2A43CB0", Offset = "0x2A430B0", Length = "0x47")]
	[Token(Token = "0x600076C")]
	public static uint3x3 uint3x3(int v) { }

	[Address(RVA = "0x2A44050", Offset = "0x2A43450", Length = "0xD3")]
	[Token(Token = "0x600076B")]
	public static uint3x3 uint3x3(bool3x3 v) { }

	[Address(RVA = "0x2A44130", Offset = "0x2A43530", Length = "0x98")]
	[Token(Token = "0x600076A")]
	public static uint3x3 uint3x3(bool v) { }

	[Address(RVA = "0x2A6FA10", Offset = "0x2A6EE10", Length = "0x109")]
	[Token(Token = "0x600076F")]
	public static uint3x3 uint3x3(float3x3 v) { }

	[Address(RVA = "0x2A43F70", Offset = "0x2A43370", Length = "0x61")]
	[Token(Token = "0x6000768")]
	public static uint3x3 uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22) { }

	[Address(RVA = "0x2A363C0", Offset = "0x2A357C0", Length = "0x34")]
	[Token(Token = "0x6000767")]
	public static uint3x3 uint3x3(uint3 c0, uint3 c1, uint3 c2) { }

	[Address(RVA = "0x2A43CB0", Offset = "0x2A430B0", Length = "0x47")]
	[Token(Token = "0x6000769")]
	public static uint3x3 uint3x3(uint v) { }

	[Address(RVA = "0x2A6FE20", Offset = "0x2A6F220", Length = "0x63")]
	[Token(Token = "0x600077F")]
	public static uint3x4 uint3x4(double3x4 v) { }

	[Address(RVA = "0x2A6FD20", Offset = "0x2A6F120", Length = "0xFE")]
	[Token(Token = "0x600077E")]
	public static uint3x4 uint3x4(double v) { }

	[Address(RVA = "0x2A6FEE0", Offset = "0x2A6F2E0", Length = "0xFD")]
	[Token(Token = "0x600077C")]
	public static uint3x4 uint3x4(float v) { }

	[Address(RVA = "0x2A6FE90", Offset = "0x2A6F290", Length = "0x47")]
	[Token(Token = "0x600077D")]
	public static uint3x4 uint3x4(float3x4 v) { }

	[Address(RVA = "0x2A44460", Offset = "0x2A43860", Length = "0x5B")]
	[Token(Token = "0x600077A")]
	public static uint3x4 uint3x4(int v) { }

	[Address(RVA = "0x2A44340", Offset = "0x2A43740", Length = "0x116")]
	[Token(Token = "0x6000779")]
	public static uint3x4 uint3x4(bool3x4 v) { }

	[Address(RVA = "0x2A441D0", Offset = "0x2A435D0", Length = "0xBB")]
	[Token(Token = "0x6000778")]
	public static uint3x4 uint3x4(bool v) { }

	[Address(RVA = "0x2A44460", Offset = "0x2A43860", Length = "0x5B")]
	[Token(Token = "0x6000777")]
	public static uint3x4 uint3x4(uint v) { }

	[Address(RVA = "0x2A446B0", Offset = "0x2A43AB0", Length = "0x84")]
	[Token(Token = "0x6000776")]
	public static uint3x4 uint3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23) { }

	[Address(RVA = "0x2A36C10", Offset = "0x2A36010", Length = "0x48")]
	[Token(Token = "0x6000775")]
	public static uint3x4 uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3) { }

	[Address(RVA = "0x2A44740", Offset = "0x2A43B40", Length = "0xCB")]
	[Token(Token = "0x600077B")]
	public static uint3x4 uint3x4(int3x4 v) { }

	[Address(RVA = "0x2A448A0", Offset = "0x2A43CA0", Length = "0x44")]
	[Token(Token = "0x600078D")]
	public static uint4 uint4(bool4 v) { }

	[Address(RVA = "0x2A700A0", Offset = "0x2A6F4A0", Length = "0x4F")]
	[Token(Token = "0x6000792")]
	public static uint4 uint4(double v) { }

	[Address(RVA = "0x2A700F0", Offset = "0x2A6F4F0", Length = "0x6C")]
	[Token(Token = "0x6000791")]
	public static uint4 uint4(float4 v) { }

	[Address(RVA = "0x2A70050", Offset = "0x2A6F450", Length = "0x4E")]
	[Token(Token = "0x6000790")]
	public static uint4 uint4(float v) { }

	[Address(RVA = "0x2A44810", Offset = "0x2A43C10", Length = "0x2A")]
	[Token(Token = "0x600078F")]
	public static uint4 uint4(int4 v) { }

	[Address(RVA = "0x27F9D50", Offset = "0x27F9150", Length = "0xF")]
	[Token(Token = "0x600078E")]
	public static uint4 uint4(int v) { }

	[Address(RVA = "0x2A44840", Offset = "0x2A43C40", Length = "0x1D")]
	[Token(Token = "0x600078C")]
	public static uint4 uint4(bool v) { }

	[Address(RVA = "0x2A6FFE0", Offset = "0x2A6F3E0", Length = "0x6A")]
	[Token(Token = "0x6000793")]
	public static uint4 uint4(double4 v) { }

	[Address(RVA = "0x2A44810", Offset = "0x2A43C10", Length = "0x2A")]
	[Token(Token = "0x600078A")]
	public static uint4 uint4(uint4 xyzw) { }

	[Address(RVA = "0x2A449A0", Offset = "0x2A43DA0", Length = "0x34")]
	[Token(Token = "0x6000789")]
	public static uint4 uint4(uint3 xyz, uint w) { }

	[Address(RVA = "0x28D8440", Offset = "0x28D7840", Length = "0x19")]
	[Token(Token = "0x6000788")]
	public static uint4 uint4(uint2 xy, uint2 zw) { }

	[Address(RVA = "0x2A44980", Offset = "0x2A43D80", Length = "0x15")]
	[Token(Token = "0x6000787")]
	public static uint4 uint4(uint2 xy, uint z, uint w) { }

	[Address(RVA = "0x2A44860", Offset = "0x2A43C60", Length = "0x35")]
	[Token(Token = "0x6000786")]
	public static uint4 uint4(uint x, uint3 yzw) { }

	[Address(RVA = "0x2A449E0", Offset = "0x2A43DE0", Length = "0x16")]
	[Token(Token = "0x6000785")]
	public static uint4 uint4(uint x, uint2 yz, uint w) { }

	[Address(RVA = "0x2A44960", Offset = "0x2A43D60", Length = "0x16")]
	[Token(Token = "0x6000784")]
	public static uint4 uint4(uint x, uint y, uint2 zw) { }

	[Address(RVA = "0x27F9F00", Offset = "0x27F9300", Length = "0x15")]
	[Token(Token = "0x6000783")]
	public static uint4 uint4(uint x, uint y, uint z, uint w) { }

	[Address(RVA = "0x27F9D50", Offset = "0x27F9150", Length = "0xF")]
	[Token(Token = "0x600078B")]
	public static uint4 uint4(uint v) { }

	[Address(RVA = "0x2A44CB0", Offset = "0x2A440B0", Length = "0xA2")]
	[Token(Token = "0x600079F")]
	public static uint4x2 uint4x2(bool4x2 v) { }

	[Address(RVA = "0x2A44B20", Offset = "0x2A43F20", Length = "0x39")]
	[Token(Token = "0x60007A0")]
	public static uint4x2 uint4x2(int v) { }

	[Address(RVA = "0x2A702B0", Offset = "0x2A6F6B0", Length = "0xF5")]
	[Token(Token = "0x60007A5")]
	public static uint4x2 uint4x2(double4x2 v) { }

	[Address(RVA = "0x2A703B0", Offset = "0x2A6F7B0", Length = "0x100")]
	[Token(Token = "0x60007A3")]
	public static uint4x2 uint4x2(float4x2 v) { }

	[Address(RVA = "0x2A704B0", Offset = "0x2A6F8B0", Length = "0xBA")]
	[Token(Token = "0x60007A4")]
	public static uint4x2 uint4x2(double v) { }

	[Address(RVA = "0x2A70160", Offset = "0x2A6F560", Length = "0x8F")]
	[Token(Token = "0x600079E")]
	public static uint4x2 uint4x2(bool v) { }

	[Address(RVA = "0x2A701F0", Offset = "0x2A6F5F0", Length = "0xB9")]
	[Token(Token = "0x60007A2")]
	public static uint4x2 uint4x2(float v) { }

	[Address(RVA = "0x2A44B20", Offset = "0x2A43F20", Length = "0x39")]
	[Token(Token = "0x600079D")]
	public static uint4x2 uint4x2(uint v) { }

	[Address(RVA = "0x2A44B60", Offset = "0x2A43F60", Length = "0x5F")]
	[Token(Token = "0x60007A1")]
	public static uint4x2 uint4x2(int4x2 v) { }

	[Address(RVA = "0x27F0880", Offset = "0x27EFC80", Length = "0x12")]
	[Token(Token = "0x600079B")]
	public static uint4x2 uint4x2(uint4 c0, uint4 c1) { }

	[Address(RVA = "0x2A44D60", Offset = "0x2A44160", Length = "0x4F")]
	[Token(Token = "0x600079C")]
	public static uint4x2 uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31) { }

	[Address(RVA = "0x2A705C0", Offset = "0x2A6F9C0", Length = "0x63")]
	[Token(Token = "0x60007B3")]
	public static uint4x3 uint4x3(double4x3 v) { }

	[Address(RVA = "0x2A70740", Offset = "0x2A6FB40", Length = "0x105")]
	[Token(Token = "0x60007B2")]
	public static uint4x3 uint4x3(double v) { }

	[Address(RVA = "0x2A70570", Offset = "0x2A6F970", Length = "0x47")]
	[Token(Token = "0x60007B1")]
	public static uint4x3 uint4x3(float4x3 v) { }

	[Address(RVA = "0x2A70630", Offset = "0x2A6FA30", Length = "0x104")]
	[Token(Token = "0x60007B0")]
	public static uint4x3 uint4x3(float v) { }

	[Address(RVA = "0x2A45100", Offset = "0x2A44500", Length = "0x7F")]
	[Token(Token = "0x60007AF")]
	public static uint4x3 uint4x3(int4x3 v) { }

	[Address(RVA = "0x2A44E30", Offset = "0x2A44230", Length = "0x4A")]
	[Token(Token = "0x60007AE")]
	public static uint4x3 uint4x3(int v) { }

	[Address(RVA = "0x2A44F60", Offset = "0x2A44360", Length = "0x115")]
	[Token(Token = "0x60007AD")]
	public static uint4x3 uint4x3(bool4x3 v) { }

	[Address(RVA = "0x2A70850", Offset = "0x2A6FC50", Length = "0xCB")]
	[Token(Token = "0x60007AC")]
	public static uint4x3 uint4x3(bool v) { }

	[Address(RVA = "0x2A44E30", Offset = "0x2A44230", Length = "0x4A")]
	[Token(Token = "0x60007AB")]
	public static uint4x3 uint4x3(uint v) { }

	[Address(RVA = "0x2A45080", Offset = "0x2A44480", Length = "0x79")]
	[Token(Token = "0x60007AA")]
	public static uint4x3 uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32) { }

	[Address(RVA = "0x2A38170", Offset = "0x2A37570", Length = "0x1A")]
	[Token(Token = "0x60007A9")]
	public static uint4x3 uint4x3(uint4 c0, uint4 c1, uint4 c2) { }

	[Address(RVA = "0x2A70A30", Offset = "0x2A6FE30", Length = "0x54")]
	[Token(Token = "0x60007BF")]
	public static uint4x4 uint4x4(float4x4 v) { }

	[Address(RVA = "0x2A453E0", Offset = "0x2A447E0", Length = "0x5E")]
	[Token(Token = "0x60007B9")]
	public static uint4x4 uint4x4(uint v) { }

	[Address(RVA = "0x2A70B10", Offset = "0x2A6FF10", Length = "0x2C")]
	[Token(Token = "0x60007BE")]
	public static uint4x4 uint4x4(float v) { }

	[Address(RVA = "0x2A45820", Offset = "0x2A44C20", Length = "0xAC")]
	[Token(Token = "0x60007B8")]
	public static uint4x4 uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33) { }

	[Address(RVA = "0x2A455E0", Offset = "0x2A449E0", Length = "0xA0")]
	[Token(Token = "0x60007BD")]
	public static uint4x4 uint4x4(int4x4 v) { }

	[Address(RVA = "0x2A453E0", Offset = "0x2A447E0", Length = "0x5E")]
	[Token(Token = "0x60007BC")]
	public static uint4x4 uint4x4(int v) { }

	[Address(RVA = "0x2A45490", Offset = "0x2A44890", Length = "0x149")]
	[Token(Token = "0x60007BB")]
	public static uint4x4 uint4x4(bool4x4 v) { }

	[Address(RVA = "0x2A70920", Offset = "0x2A6FD20", Length = "0x107")]
	[Token(Token = "0x60007BA")]
	public static uint4x4 uint4x4(bool v) { }

	[Address(RVA = "0x2A70B40", Offset = "0x2A6FF40", Length = "0x2C")]
	[Token(Token = "0x60007C0")]
	public static uint4x4 uint4x4(double v) { }

	[Address(RVA = "0x2A70A90", Offset = "0x2A6FE90", Length = "0x79")]
	[Token(Token = "0x60007C1")]
	public static uint4x4 uint4x4(double4x4 v) { }

	[Address(RVA = "0x2A386D0", Offset = "0x2A37AD0", Length = "0x26")]
	[Token(Token = "0x60007B7")]
	public static uint4x4 uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3) { }

	[Address(RVA = "0x2A70B70", Offset = "0x2A6FF70", Length = "0x169")]
	[Token(Token = "0x60006EF")]
	public static quaternion unitexp(quaternion q) { }

	[Address(RVA = "0x2A70CE0", Offset = "0x2A700E0", Length = "0x10E")]
	[Token(Token = "0x60006F1")]
	public static quaternion unitlog(quaternion q) { }

	[Address(RVA = "0x2A71040", Offset = "0x2A70440", Length = "0x7C")]
	[Token(Token = "0x6000373")]
	public static float3 unlerp(float3 start, float3 end, float3 x) { }

	[Address(RVA = "0x2A71190", Offset = "0x2A70590", Length = "0x10")]
	[Token(Token = "0x6000375")]
	public static double unlerp(double start, double end, double x) { }

	[Address(RVA = "0x2A70EA0", Offset = "0x2A702A0", Length = "0x49")]
	[Token(Token = "0x6000376")]
	public static double2 unlerp(double2 start, double2 end, double2 x) { }

	[Address(RVA = "0x2A70DF0", Offset = "0x2A701F0", Length = "0xA2")]
	[Token(Token = "0x6000377")]
	public static double3 unlerp(double3 start, double3 end, double3 x) { }

	[Address(RVA = "0x2A710C0", Offset = "0x2A704C0", Length = "0xCA")]
	[Token(Token = "0x6000378")]
	public static double4 unlerp(double4 start, double4 end, double4 x) { }

	[Address(RVA = "0x2A70EF0", Offset = "0x2A702F0", Length = "0x10")]
	[Token(Token = "0x6000371")]
	public static float unlerp(float start, float end, float x) { }

	[Address(RVA = "0x2A70FE0", Offset = "0x2A703E0", Length = "0x56")]
	[Token(Token = "0x6000372")]
	public static float2 unlerp(float2 start, float2 end, float2 x) { }

	[Address(RVA = "0x2A70F00", Offset = "0x2A70300", Length = "0xE0")]
	[Token(Token = "0x6000374")]
	public static float4 unlerp(float4 start, float4 end, float4 x) { }

	[Address(RVA = "0x2A711A0", Offset = "0x2A705A0", Length = "0x10C")]
	[Token(Token = "0x600060E")]
	internal static float4 unpackhi(float4 a, float4 b) { }

	[Address(RVA = "0x2A1F9D0", Offset = "0x2A1EDD0", Length = "0x13D")]
	[Token(Token = "0x600060F")]
	internal static double4 unpackhi(double4 a, double4 b) { }

	[Address(RVA = "0x2A712B0", Offset = "0x2A706B0", Length = "0x10C")]
	[Token(Token = "0x600060C")]
	internal static float4 unpacklo(float4 a, float4 b) { }

	[Address(RVA = "0x2A1FB10", Offset = "0x2A1EF10", Length = "0x35C")]
	[Token(Token = "0x600060D")]
	internal static double4 unpacklo(double4 a, double4 b) { }

	[Address(RVA = "0x2A713C0", Offset = "0x2A707C0", Length = "0x10")]
	[Token(Token = "0x60005FD")]
	public static float3 up() { }

}

