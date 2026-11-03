namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector3f")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeHeader("Runtime/Math/Vector3.h")]
[NativeType(Header = "Runtime/Math/Vector3.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000156")]
public struct Vector3 : IEquatable<Vector3>, IFormattable
{
	[Token(Token = "0x40005A0")]
	public const float kEpsilon = 1E-05; //Field offset: 0x0
	[Token(Token = "0x40005A1")]
	public const float kEpsilonNormalSqrt = 1E-15; //Field offset: 0x0
	[Token(Token = "0x40005A5")]
	private static readonly Vector3 zeroVector; //Field offset: 0x0
	[Token(Token = "0x40005A6")]
	private static readonly Vector3 oneVector; //Field offset: 0xC
	[Token(Token = "0x40005A7")]
	private static readonly Vector3 upVector; //Field offset: 0x18
	[Token(Token = "0x40005A8")]
	private static readonly Vector3 downVector; //Field offset: 0x24
	[Token(Token = "0x40005A9")]
	private static readonly Vector3 leftVector; //Field offset: 0x30
	[Token(Token = "0x40005AA")]
	private static readonly Vector3 rightVector; //Field offset: 0x3C
	[Token(Token = "0x40005AB")]
	private static readonly Vector3 forwardVector; //Field offset: 0x48
	[Token(Token = "0x40005AC")]
	private static readonly Vector3 backVector; //Field offset: 0x54
	[Token(Token = "0x40005AD")]
	private static readonly Vector3 positiveInfinityVector; //Field offset: 0x60
	[Token(Token = "0x40005AE")]
	private static readonly Vector3 negativeInfinityVector; //Field offset: 0x6C
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005A2")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40005A3")]
	public float y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005A4")]
	public float z; //Field offset: 0x8

	[Token(Token = "0x17000299")]
	public static Vector3 back
	{
		[Address(RVA = "0x3053450", Offset = "0x3052850", Length = "0x4B")]
		[Token(Token = "0x600109C")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700029B")]
	public static Vector3 down
	{
		[Address(RVA = "0x30534A0", Offset = "0x30528A0", Length = "0x4B")]
		[Token(Token = "0x600109E")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000298")]
	public static Vector3 forward
	{
		[Address(RVA = "0x30534F0", Offset = "0x30528F0", Length = "0x4B")]
		[Token(Token = "0x600109B")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000292")]
	public float Item
	{
		[Address(RVA = "0x2833600", Offset = "0x2832A00", Length = "0x81")]
		[IsReadOnly]
		[Token(Token = "0x6001077")]
		 get { } //Length: 129
		[Address(RVA = "0x2833690", Offset = "0x2832A90", Length = "0x81")]
		[Token(Token = "0x6001078")]
		 set { } //Length: 129
	}

	[Token(Token = "0x1700029C")]
	public static Vector3 left
	{
		[Address(RVA = "0x3053540", Offset = "0x3052940", Length = "0x4B")]
		[Token(Token = "0x600109F")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000294")]
	public float magnitude
	{
		[Address(RVA = "0x3053590", Offset = "0x3052990", Length = "0xE1")]
		[IsReadOnly]
		[Token(Token = "0x6001092")]
		 get { } //Length: 225
	}

	[Token(Token = "0x17000293")]
	public Vector3 normalized
	{
		[Address(RVA = "0x5D2EE0", Offset = "0x5D22E0", Length = "0x8C")]
		[IsReadOnly]
		[Token(Token = "0x6001087")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000297")]
	public static Vector3 one
	{
		[Address(RVA = "0x3053680", Offset = "0x3052A80", Length = "0x4B")]
		[Token(Token = "0x600109A")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700029D")]
	public static Vector3 right
	{
		[Address(RVA = "0x30536D0", Offset = "0x3052AD0", Length = "0x4B")]
		[Token(Token = "0x60010A0")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000295")]
	public float sqrMagnitude
	{
		[Address(RVA = "0x3053140", Offset = "0x3052540", Length = "0x23")]
		[IsReadOnly]
		[Token(Token = "0x6001094")]
		 get { } //Length: 35
	}

	[Token(Token = "0x1700029A")]
	public static Vector3 up
	{
		[Address(RVA = "0x3053720", Offset = "0x3052B20", Length = "0x4B")]
		[Token(Token = "0x600109D")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000296")]
	public static Vector3 zero
	{
		[Address(RVA = "0x3053770", Offset = "0x3052B70", Length = "0x4A")]
		[Token(Token = "0x6001099")]
		 get { } //Length: 74
	}

	[Address(RVA = "0x30532B0", Offset = "0x30526B0", Length = "0x173")]
	[Token(Token = "0x60010AB")]
	private static Vector3() { }

	[Address(RVA = "0x3053430", Offset = "0x3052830", Length = "0x11")]
	[Token(Token = "0x600107A")]
	public Vector3(float x, float y) { }

	[Address(RVA = "0x1DB7900", Offset = "0x1DB6D00", Length = "0xF")]
	[Token(Token = "0x6001079")]
	public Vector3(float x, float y, float z) { }

	[Address(RVA = "0x3051B20", Offset = "0x3050F20", Length = "0x159")]
	[Token(Token = "0x600108C")]
	public static float Angle(Vector3 from, Vector3 to) { }

	[Address(RVA = "0x30519C0", Offset = "0x3050DC0", Length = "0x159")]
	[Token(Token = "0x600108D")]
	public static float Angle(in Vector3 from, in Vector3 to) { }

	[Address(RVA = "0x3051C80", Offset = "0x3051080", Length = "0xFB")]
	[Token(Token = "0x6001090")]
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	[Address(RVA = "0x3051D80", Offset = "0x3051180", Length = "0x5C")]
	[Token(Token = "0x600107D")]
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x3051D80", Offset = "0x3051180", Length = "0x5C")]
	[Token(Token = "0x600107E")]
	public static Vector3 Cross(in Vector3 lhs, in Vector3 rhs) { }

	[Address(RVA = "0x3051DE0", Offset = "0x30511E0", Length = "0xC2")]
	[Token(Token = "0x600108F")]
	public static float Distance(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x2A2CAF0", Offset = "0x2A2BEF0", Length = "0x25")]
	[Token(Token = "0x6001089")]
	public static float Dot(in Vector3 lhs, in Vector3 rhs) { }

	[Address(RVA = "0x2A2CAF0", Offset = "0x2A2BEF0", Length = "0x25")]
	[Token(Token = "0x6001088")]
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x3051EB0", Offset = "0x30512B0", Length = "0xAA")]
	[IsReadOnly]
	[Token(Token = "0x6001080")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x2AD1B50", Offset = "0x2AD0F50", Length = "0x2B")]
	[IsReadOnly]
	[Token(Token = "0x6001082")]
	public bool Equals(in Vector3 other) { }

	[Address(RVA = "0x2AD1B50", Offset = "0x2AD0F50", Length = "0x2B")]
	[IsReadOnly]
	[Token(Token = "0x6001081")]
	public override bool Equals(Vector3 other) { }

	[Address(RVA = "0x3053450", Offset = "0x3052850", Length = "0x4B")]
	[Token(Token = "0x600109C")]
	public static Vector3 get_back() { }

	[Address(RVA = "0x30534A0", Offset = "0x30528A0", Length = "0x4B")]
	[Token(Token = "0x600109E")]
	public static Vector3 get_down() { }

	[Address(RVA = "0x30534F0", Offset = "0x30528F0", Length = "0x4B")]
	[Token(Token = "0x600109B")]
	public static Vector3 get_forward() { }

	[Address(RVA = "0x2833600", Offset = "0x2832A00", Length = "0x81")]
	[IsReadOnly]
	[Token(Token = "0x6001077")]
	public float get_Item(int index) { }

	[Address(RVA = "0x3053540", Offset = "0x3052940", Length = "0x4B")]
	[Token(Token = "0x600109F")]
	public static Vector3 get_left() { }

	[Address(RVA = "0x3053590", Offset = "0x3052990", Length = "0xE1")]
	[IsReadOnly]
	[Token(Token = "0x6001092")]
	public float get_magnitude() { }

	[Address(RVA = "0x5D2EE0", Offset = "0x5D22E0", Length = "0x8C")]
	[IsReadOnly]
	[Token(Token = "0x6001087")]
	public Vector3 get_normalized() { }

	[Address(RVA = "0x3053680", Offset = "0x3052A80", Length = "0x4B")]
	[Token(Token = "0x600109A")]
	public static Vector3 get_one() { }

	[Address(RVA = "0x30536D0", Offset = "0x3052AD0", Length = "0x4B")]
	[Token(Token = "0x60010A0")]
	public static Vector3 get_right() { }

	[Address(RVA = "0x3053140", Offset = "0x3052540", Length = "0x23")]
	[IsReadOnly]
	[Token(Token = "0x6001094")]
	public float get_sqrMagnitude() { }

	[Address(RVA = "0x3053720", Offset = "0x3052B20", Length = "0x4B")]
	[Token(Token = "0x600109D")]
	public static Vector3 get_up() { }

	[Address(RVA = "0x3053770", Offset = "0x3052B70", Length = "0x4A")]
	[Token(Token = "0x6001099")]
	public static Vector3 get_zero() { }

	[Address(RVA = "0x3051F60", Offset = "0x3051360", Length = "0x51")]
	[IsReadOnly]
	[Token(Token = "0x600107F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3052030", Offset = "0x3051430", Length = "0x75")]
	[FreeFunction("VectorScripting::RotateTowards", IsThreadSafe = True)]
	[Token(Token = "0x600106F")]
	private static Vector3 Internal_RotateTowards(in Vector3 current, in Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	[Address(RVA = "0x3051FC0", Offset = "0x30513C0", Length = "0x62")]
	[Token(Token = "0x60010AD")]
	private static void Internal_RotateTowards_Injected(in Vector3 current, in Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }

	[Address(RVA = "0x3052120", Offset = "0x3051520", Length = "0x6D")]
	[FreeFunction("VectorScripting::Slerp", IsThreadSafe = True)]
	[Token(Token = "0x600106D")]
	private static Vector3 Internal_Slerp(in Vector3 a, in Vector3 b, float t) { }

	[Address(RVA = "0x30520B0", Offset = "0x30514B0", Length = "0x62")]
	[Token(Token = "0x60010AC")]
	private static void Internal_Slerp_Injected(in Vector3 a, in Vector3 b, float t, out Vector3 ret) { }

	[Address(RVA = "0x30521E0", Offset = "0x30515E0", Length = "0x66")]
	[Token(Token = "0x6001071")]
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	[Address(RVA = "0x3052190", Offset = "0x3051590", Length = "0x4B")]
	[Token(Token = "0x6001072")]
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	[Address(RVA = "0x3052250", Offset = "0x3051650", Length = "0x10")]
	[Token(Token = "0x6001091")]
	public static float Magnitude(Vector3 vector) { }

	[Address(RVA = "0x3052260", Offset = "0x3051660", Length = "0x33")]
	[Token(Token = "0x6001097")]
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x3052260", Offset = "0x3051660", Length = "0x33")]
	[Token(Token = "0x6001098")]
	public static Vector3 Max(in Vector3 lhs, in Vector3 rhs) { }

	[Address(RVA = "0x30522A0", Offset = "0x30516A0", Length = "0x33")]
	[Token(Token = "0x6001096")]
	public static Vector3 Min(in Vector3 lhs, in Vector3 rhs) { }

	[Address(RVA = "0x30522A0", Offset = "0x30516A0", Length = "0x33")]
	[Token(Token = "0x6001095")]
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x30522E0", Offset = "0x30516E0", Length = "0x16B")]
	[Token(Token = "0x6001073")]
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[Address(RVA = "0x30524F0", Offset = "0x30518F0", Length = "0x94")]
	[Token(Token = "0x6001084")]
	public static Vector3 Normalize(Vector3 value) { }

	[Address(RVA = "0x1D303C0", Offset = "0x1D2F7C0", Length = "0x55")]
	[Token(Token = "0x6001086")]
	public void Normalize() { }

	[Address(RVA = "0x3052450", Offset = "0x3051850", Length = "0x94")]
	[Token(Token = "0x6001085")]
	public static Vector3 Normalize(in Vector3 value) { }

	[Address(RVA = "0x5AA9D0", Offset = "0x5A9DD0", Length = "0x31")]
	[Token(Token = "0x60010A1")]
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x1CFA4E0", Offset = "0x1CF98E0", Length = "0x2C")]
	[Token(Token = "0x60010A6")]
	public static Vector3 op_Division(Vector3 a, float d) { }

	[Address(RVA = "0x30537C0", Offset = "0x3052BC0", Length = "0x3F")]
	[Token(Token = "0x60010A7")]
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x3053800", Offset = "0x3052C00", Length = "0x7D2")]
	[Token(Token = "0x60010A8")]
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x2AD2780", Offset = "0x2AD1B80", Length = "0x26")]
	[Token(Token = "0x60010A4")]
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	[Address(RVA = "0x2AD2750", Offset = "0x2AD1B50", Length = "0x29")]
	[Token(Token = "0x60010A5")]
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	[Address(RVA = "0x5D2F70", Offset = "0x5D2370", Length = "0x31")]
	[Token(Token = "0x60010A2")]
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x2AD2810", Offset = "0x2AD1C10", Length = "0x31")]
	[Token(Token = "0x60010A3")]
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	[Address(RVA = "0x30526A0", Offset = "0x3051AA0", Length = "0x11B")]
	[Token(Token = "0x600108A")]
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	[Address(RVA = "0x3052590", Offset = "0x3051990", Length = "0x103")]
	[Token(Token = "0x600108B")]
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	[Address(RVA = "0x30527C0", Offset = "0x3051BC0", Length = "0x64")]
	[Token(Token = "0x6001083")]
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	[Address(RVA = "0x3052830", Offset = "0x3051C30", Length = "0x91")]
	[Token(Token = "0x6001070")]
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	[Address(RVA = "0x2AD2710", Offset = "0x2AD1B10", Length = "0x31")]
	[Token(Token = "0x600107C")]
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x1DB7900", Offset = "0x1DB6D00", Length = "0xF")]
	[Token(Token = "0x600107B")]
	public void Set(float newX, float newY, float newZ) { }

	[Address(RVA = "0x2833690", Offset = "0x2832A90", Length = "0x81")]
	[Token(Token = "0x6001078")]
	public void set_Item(int index, float value) { }

	[Address(RVA = "0x30528D0", Offset = "0x3051CD0", Length = "0xAB")]
	[Token(Token = "0x600108E")]
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	[Address(RVA = "0x3052980", Offset = "0x3051D80", Length = "0x83")]
	[Token(Token = "0x600106E")]
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[Address(RVA = "0x3052A10", Offset = "0x3051E10", Length = "0x347")]
	[Token(Token = "0x6001076")]
	public static Vector3 SmoothDamp(in Vector3 current, in Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	[Address(RVA = "0x30530A0", Offset = "0x30524A0", Length = "0x98")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001074")]
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

	[Address(RVA = "0x3052D60", Offset = "0x3052160", Length = "0x33D")]
	[Token(Token = "0x6001075")]
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	[Address(RVA = "0x3053140", Offset = "0x3052540", Length = "0x23")]
	[Token(Token = "0x6001093")]
	public static float SqrMagnitude(Vector3 vector) { }

	[Address(RVA = "0x3053170", Offset = "0x3052570", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x60010A9")]
	public virtual string ToString() { }

	[Address(RVA = "0x3053180", Offset = "0x3052580", Length = "0x127")]
	[IsReadOnly]
	[Token(Token = "0x60010AA")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

