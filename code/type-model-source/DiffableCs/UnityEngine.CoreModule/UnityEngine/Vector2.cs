namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector2f")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000159")]
public struct Vector2 : IEquatable<Vector2>, IFormattable
{
	[Token(Token = "0x40005B8")]
	private static readonly Vector2 zeroVector; //Field offset: 0x0
	[Token(Token = "0x40005C0")]
	public const float kEpsilon = 1E-05; //Field offset: 0x0
	[Token(Token = "0x40005C1")]
	public const float kEpsilonNormalSqrt = 1E-15; //Field offset: 0x0
	[Token(Token = "0x40005B9")]
	private static readonly Vector2 oneVector; //Field offset: 0x8
	[Token(Token = "0x40005BA")]
	private static readonly Vector2 upVector; //Field offset: 0x10
	[Token(Token = "0x40005BB")]
	private static readonly Vector2 downVector; //Field offset: 0x18
	[Token(Token = "0x40005BC")]
	private static readonly Vector2 leftVector; //Field offset: 0x20
	[Token(Token = "0x40005BD")]
	private static readonly Vector2 rightVector; //Field offset: 0x28
	[Token(Token = "0x40005BE")]
	private static readonly Vector2 positiveInfinityVector; //Field offset: 0x30
	[Token(Token = "0x40005BF")]
	private static readonly Vector2 negativeInfinityVector; //Field offset: 0x38
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005B6")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40005B7")]
	public float y; //Field offset: 0x4

	[Token(Token = "0x170002A8")]
	public static Vector2 down
	{
		[Address(RVA = "0x3051590", Offset = "0x3050990", Length = "0x45")]
		[Token(Token = "0x6001147")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170002A1")]
	public float Item
	{
		[Address(RVA = "0x290C300", Offset = "0x290B700", Length = "0x72")]
		[IsReadOnly]
		[Token(Token = "0x600111E")]
		 get { } //Length: 114
		[Address(RVA = "0x3046520", Offset = "0x3045920", Length = "0x72")]
		[Token(Token = "0x600111F")]
		 set { } //Length: 114
	}

	[Token(Token = "0x170002A9")]
	public static Vector2 left
	{
		[Address(RVA = "0x30515E0", Offset = "0x30509E0", Length = "0x45")]
		[Token(Token = "0x6001148")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170002A3")]
	public float magnitude
	{
		[Address(RVA = "0x3051630", Offset = "0x3050A30", Length = "0xAF")]
		[IsReadOnly]
		[Token(Token = "0x6001130")]
		 get { } //Length: 175
	}

	[Token(Token = "0x170002AC")]
	public static Vector2 negativeInfinity
	{
		[Address(RVA = "0x30516E0", Offset = "0x3050AE0", Length = "0x45")]
		[Token(Token = "0x600114B")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170002A2")]
	public Vector2 normalized
	{
		[Address(RVA = "0x3051730", Offset = "0x3050B30", Length = "0x7")]
		[IsReadOnly]
		[Token(Token = "0x6001127")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170002A6")]
	public static Vector2 one
	{
		[Address(RVA = "0x3051740", Offset = "0x3050B40", Length = "0x45")]
		[Token(Token = "0x6001145")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170002AB")]
	public static Vector2 positiveInfinity
	{
		[Address(RVA = "0x3051790", Offset = "0x3050B90", Length = "0x45")]
		[Token(Token = "0x600114A")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170002AA")]
	public static Vector2 right
	{
		[Address(RVA = "0x30517E0", Offset = "0x3050BE0", Length = "0x45")]
		[Token(Token = "0x6001149")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170002A4")]
	public float sqrMagnitude
	{
		[Address(RVA = "0x3051830", Offset = "0x3050C30", Length = "0x16")]
		[IsReadOnly]
		[Token(Token = "0x6001131")]
		 get { } //Length: 22
	}

	[Token(Token = "0x170002A7")]
	public static Vector2 up
	{
		[Address(RVA = "0x3051850", Offset = "0x3050C50", Length = "0x45")]
		[Token(Token = "0x6001146")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170002A5")]
	public static Vector2 zero
	{
		[Address(RVA = "0x30518A0", Offset = "0x3050CA0", Length = "0x44")]
		[Token(Token = "0x6001144")]
		 get { } //Length: 68
	}

	[Address(RVA = "0x30514A0", Offset = "0x30508A0", Length = "0xEA")]
	[Token(Token = "0x600114C")]
	private static Vector2() { }

	[Address(RVA = "0x12F1450", Offset = "0x12F0850", Length = "0xA")]
	[Token(Token = "0x6001120")]
	public Vector2(float x, float y) { }

	[Address(RVA = "0x3050E40", Offset = "0x3050240", Length = "0x12B")]
	[Token(Token = "0x6001132")]
	public static float Angle(Vector2 from, Vector2 to) { }

	[Address(RVA = "0x3050F70", Offset = "0x3050370", Length = "0xFE")]
	[Token(Token = "0x6001134")]
	public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) { }

	[Address(RVA = "0x3051070", Offset = "0x3050470", Length = "0xAB")]
	[Token(Token = "0x6001133")]
	public static float Distance(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x3051120", Offset = "0x3050520", Length = "0x17")]
	[Token(Token = "0x600112F")]
	public static float Dot(in Vector2 lhs, in Vector2 rhs) { }

	[Address(RVA = "0x2A2CB20", Offset = "0x2A2BF20", Length = "0x2D")]
	[Token(Token = "0x600112E")]
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	[Address(RVA = "0x3051140", Offset = "0x3050540", Length = "0x1E")]
	[IsReadOnly]
	[Token(Token = "0x600112D")]
	public bool Equals(in Vector2 other) { }

	[Address(RVA = "0x2ACAFA0", Offset = "0x2ACA3A0", Length = "0x26")]
	[IsReadOnly]
	[Token(Token = "0x600112C")]
	public override bool Equals(Vector2 other) { }

	[Address(RVA = "0x3051160", Offset = "0x3050560", Length = "0x92")]
	[IsReadOnly]
	[Token(Token = "0x600112B")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x3051590", Offset = "0x3050990", Length = "0x45")]
	[Token(Token = "0x6001147")]
	public static Vector2 get_down() { }

	[Address(RVA = "0x290C300", Offset = "0x290B700", Length = "0x72")]
	[IsReadOnly]
	[Token(Token = "0x600111E")]
	public float get_Item(int index) { }

	[Address(RVA = "0x30515E0", Offset = "0x30509E0", Length = "0x45")]
	[Token(Token = "0x6001148")]
	public static Vector2 get_left() { }

	[Address(RVA = "0x3051630", Offset = "0x3050A30", Length = "0xAF")]
	[IsReadOnly]
	[Token(Token = "0x6001130")]
	public float get_magnitude() { }

	[Address(RVA = "0x30516E0", Offset = "0x3050AE0", Length = "0x45")]
	[Token(Token = "0x600114B")]
	public static Vector2 get_negativeInfinity() { }

	[Address(RVA = "0x3051730", Offset = "0x3050B30", Length = "0x7")]
	[IsReadOnly]
	[Token(Token = "0x6001127")]
	public Vector2 get_normalized() { }

	[Address(RVA = "0x3051740", Offset = "0x3050B40", Length = "0x45")]
	[Token(Token = "0x6001145")]
	public static Vector2 get_one() { }

	[Address(RVA = "0x3051790", Offset = "0x3050B90", Length = "0x45")]
	[Token(Token = "0x600114A")]
	public static Vector2 get_positiveInfinity() { }

	[Address(RVA = "0x30517E0", Offset = "0x3050BE0", Length = "0x45")]
	[Token(Token = "0x6001149")]
	public static Vector2 get_right() { }

	[Address(RVA = "0x3051830", Offset = "0x3050C30", Length = "0x16")]
	[IsReadOnly]
	[Token(Token = "0x6001131")]
	public float get_sqrMagnitude() { }

	[Address(RVA = "0x3051850", Offset = "0x3050C50", Length = "0x45")]
	[Token(Token = "0x6001146")]
	public static Vector2 get_up() { }

	[Address(RVA = "0x30518A0", Offset = "0x3050CA0", Length = "0x44")]
	[Token(Token = "0x6001144")]
	public static Vector2 get_zero() { }

	[Address(RVA = "0x3051200", Offset = "0x3050600", Length = "0x31")]
	[IsReadOnly]
	[Token(Token = "0x600112A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x21FC650", Offset = "0x21FBA50", Length = "0x65")]
	[Token(Token = "0x6001122")]
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	[Address(RVA = "0x2A4A960", Offset = "0x2A49D60", Length = "0x45")]
	[Token(Token = "0x6001123")]
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) { }

	[Address(RVA = "0x3051240", Offset = "0x3050640", Length = "0x31")]
	[Token(Token = "0x6001137")]
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	[Address(RVA = "0x3051280", Offset = "0x3050680", Length = "0x31")]
	[Token(Token = "0x6001136")]
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	[Address(RVA = "0x30512C0", Offset = "0x30506C0", Length = "0x7C")]
	[Token(Token = "0x6001125")]
	public static Vector2 Normalize(in Vector2 value) { }

	[Address(RVA = "0x3051340", Offset = "0x3050740", Length = "0x4E")]
	[Token(Token = "0x6001126")]
	public void Normalize() { }

	[Address(RVA = "0x2ACB400", Offset = "0x2ACA800", Length = "0x31")]
	[Token(Token = "0x6001138")]
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x2ACB4A0", Offset = "0x2ACA8A0", Length = "0x22")]
	[Token(Token = "0x600113F")]
	public static Vector2 op_Division(Vector2 a, float d) { }

	[Address(RVA = "0x2ACB4D0", Offset = "0x2ACA8D0", Length = "0x31")]
	[Token(Token = "0x600113B")]
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x30518F0", Offset = "0x3050CF0", Length = "0x43")]
	[Token(Token = "0x6001140")]
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
	[Token(Token = "0x6001142")]
	public static Vector2 op_Implicit(Vector3 v) { }

	[Address(RVA = "0x3051940", Offset = "0x3050D40", Length = "0x25")]
	[Token(Token = "0x6001143")]
	public static Vector3 op_Implicit(Vector2 v) { }

	[Address(RVA = "0x3051970", Offset = "0x3050D70", Length = "0x43")]
	[Token(Token = "0x6001141")]
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	[Address(RVA = "0x2ACBA50", Offset = "0x2ACAE50", Length = "0x22")]
	[Token(Token = "0x600113E")]
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	[Address(RVA = "0x2ACBA80", Offset = "0x2ACAE80", Length = "0x31")]
	[Token(Token = "0x600113A")]
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x2ACBA20", Offset = "0x2ACAE20", Length = "0x22")]
	[Token(Token = "0x600113D")]
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	[Address(RVA = "0x2ACBAC0", Offset = "0x2ACAEC0", Length = "0x31")]
	[Token(Token = "0x6001139")]
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x2ACBB50", Offset = "0x2ACAF50", Length = "0x28")]
	[Token(Token = "0x600113C")]
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	[Address(RVA = "0x2ACBA80", Offset = "0x2ACAE80", Length = "0x31")]
	[Token(Token = "0x6001124")]
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x12F1450", Offset = "0x12F0850", Length = "0xA")]
	[Token(Token = "0x6001121")]
	public void Set(float newX, float newY) { }

	[Address(RVA = "0x3046520", Offset = "0x3045920", Length = "0x72")]
	[Token(Token = "0x600111F")]
	public void set_Item(int index, float value) { }

	[Address(RVA = "0x2A4A420", Offset = "0x2A49820", Length = "0x1E")]
	[Token(Token = "0x6001135")]
	public static float SqrMagnitude(Vector2 a) { }

	[Address(RVA = "0x30513A0", Offset = "0x30507A0", Length = "0xF8")]
	[IsReadOnly]
	[Token(Token = "0x6001129")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x3051390", Offset = "0x3050790", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x6001128")]
	public virtual string ToString() { }

}

