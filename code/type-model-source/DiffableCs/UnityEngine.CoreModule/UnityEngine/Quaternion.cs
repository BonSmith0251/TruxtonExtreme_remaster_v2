namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Quaternion.h")]
[Token(Token = "0x2000157")]
[UsedByNativeCode]
public struct Quaternion : IEquatable<Quaternion>, IFormattable
{
	[Token(Token = "0x40005B3")]
	private static readonly Quaternion identityQuaternion; //Field offset: 0x0
	[Token(Token = "0x40005B4")]
	public const float kEpsilon = 1E-06; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005AF")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40005B0")]
	public float y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005B1")]
	public float z; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40005B2")]
	public float w; //Field offset: 0xC

	[Token(Token = "0x1700029F")]
	public Vector3 eulerAngles
	{
		[Address(RVA = "0x304E890", Offset = "0x304DC90", Length = "0x103")]
		[IsReadOnly]
		[Token(Token = "0x60010CD")]
		 get { } //Length: 259
	}

	[Token(Token = "0x1700029E")]
	public static Quaternion identity
	{
		[Address(RVA = "0x304E9A0", Offset = "0x304DDA0", Length = "0x42")]
		[Token(Token = "0x60010C2")]
		 get { } //Length: 66
	}

	[Token(Token = "0x170002A0")]
	public Quaternion normalized
	{
		[Address(RVA = "0x304E9F0", Offset = "0x304DDF0", Length = "0x25")]
		[IsReadOnly]
		[Token(Token = "0x60010D4")]
		 get { } //Length: 37
	}

	[Address(RVA = "0x304E850", Offset = "0x304DC50", Length = "0x3E")]
	[Token(Token = "0x60010DB")]
	private static Quaternion() { }

	[Address(RVA = "0x27F69A0", Offset = "0x27F5DA0", Length = "0x1A")]
	[Token(Token = "0x60010C1")]
	public Quaternion(float x, float y, float z, float w) { }

	[Address(RVA = "0x304D490", Offset = "0x304C890", Length = "0x6F")]
	[Token(Token = "0x60010CA")]
	public static float Angle(Quaternion a, Quaternion b) { }

	[Address(RVA = "0x304D490", Offset = "0x304C890", Length = "0x6F")]
	[Token(Token = "0x60010CB")]
	public static float Angle(in Quaternion a, in Quaternion b) { }

	[Address(RVA = "0x304D420", Offset = "0x304C820", Length = "0x67")]
	[Token(Token = "0x60010BD")]
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[Address(RVA = "0x1CE1880", Offset = "0x1CE0C80", Length = "0x33")]
	[Token(Token = "0x60010C9")]
	public static float Dot(in Quaternion a, in Quaternion b) { }

	[Address(RVA = "0x1CE1880", Offset = "0x1CE0C80", Length = "0x33")]
	[Token(Token = "0x60010C8")]
	public static float Dot(Quaternion a, Quaternion b) { }

	[Address(RVA = "0x6BE170", Offset = "0x6BD570", Length = "0x72")]
	[IsReadOnly]
	[Token(Token = "0x60010D8")]
	public bool Equals(in Quaternion other) { }

	[Address(RVA = "0x6BE170", Offset = "0x6BD570", Length = "0x72")]
	[IsReadOnly]
	[Token(Token = "0x60010D7")]
	public override bool Equals(Quaternion other) { }

	[Address(RVA = "0x304D500", Offset = "0x304C900", Length = "0xF5")]
	[IsReadOnly]
	[Token(Token = "0x60010D6")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x304D690", Offset = "0x304CA90", Length = "0x73")]
	[Token(Token = "0x60010CE")]
	public static Quaternion Euler(float x, float y, float z) { }

	[Address(RVA = "0x304D600", Offset = "0x304CA00", Length = "0x89")]
	[Token(Token = "0x60010CF")]
	public static Quaternion Euler(Vector3 euler) { }

	[Address(RVA = "0x304D710", Offset = "0x304CB10", Length = "0x67")]
	[Token(Token = "0x60010AF")]
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[Address(RVA = "0x304E890", Offset = "0x304DC90", Length = "0x103")]
	[IsReadOnly]
	[Token(Token = "0x60010CD")]
	public Vector3 get_eulerAngles() { }

	[Address(RVA = "0x304E9A0", Offset = "0x304DDA0", Length = "0x42")]
	[Token(Token = "0x60010C2")]
	public static Quaternion get_identity() { }

	[Address(RVA = "0x304E9F0", Offset = "0x304DDF0", Length = "0x25")]
	[IsReadOnly]
	[Token(Token = "0x60010D4")]
	public Quaternion get_normalized() { }

	[Address(RVA = "0x80AFF0", Offset = "0x80A3F0", Length = "0x6B")]
	[IsReadOnly]
	[Token(Token = "0x60010D5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x304D7E0", Offset = "0x304CBE0", Length = "0x5B")]
	[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = True)]
	[Token(Token = "0x60010BC")]
	private static Quaternion Internal_AngleAxis(float angle, in Vector3 axis) { }

	[Address(RVA = "0x304D780", Offset = "0x304CB80", Length = "0x52")]
	[Token(Token = "0x60010E3")]
	private static void Internal_AngleAxis_Injected(float angle, in Vector3 axis, out Quaternion ret) { }

	[Address(RVA = "0x304D890", Offset = "0x304CC90", Length = "0x4B")]
	[FreeFunction("EulerToQuaternion", IsThreadSafe = True)]
	[Token(Token = "0x60010B9")]
	private static Quaternion Internal_FromEulerRad(in Vector3 euler) { }

	[Address(RVA = "0x304D840", Offset = "0x304CC40", Length = "0x42")]
	[Token(Token = "0x60010E1")]
	private static void Internal_FromEulerRad_Injected(in Vector3 euler, out Quaternion ret) { }

	[Address(RVA = "0x304D940", Offset = "0x304CD40", Length = "0x5B")]
	[FreeFunction("FromToQuaternionSafe", IsThreadSafe = True)]
	[Token(Token = "0x60010AE")]
	private static Quaternion Internal_FromToRotation(in Vector3 fromDirection, in Vector3 toDirection) { }

	[Address(RVA = "0x304D8E0", Offset = "0x304CCE0", Length = "0x52")]
	[Token(Token = "0x60010DC")]
	private static void Internal_FromToRotation_Injected(in Vector3 fromDirection, in Vector3 toDirection, out Quaternion ret) { }

	[Address(RVA = "0x304D9F0", Offset = "0x304CDF0", Length = "0x4B")]
	[FreeFunction("QuaternionScripting::Inverse", IsThreadSafe = True)]
	[Token(Token = "0x60010B0")]
	private static Quaternion Internal_Inverse(in Quaternion rotation) { }

	[Address(RVA = "0x304D9A0", Offset = "0x304CDA0", Length = "0x42")]
	[Token(Token = "0x60010DD")]
	private static void Internal_Inverse_Injected(in Quaternion rotation, out Quaternion ret) { }

	[Address(RVA = "0x304DAB0", Offset = "0x304CEB0", Length = "0x6B")]
	[FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = True)]
	[Token(Token = "0x60010B4")]
	private static Quaternion Internal_Lerp(in Quaternion a, in Quaternion b, float t) { }

	[Address(RVA = "0x304DA40", Offset = "0x304CE40", Length = "0x62")]
	[Token(Token = "0x60010E0")]
	private static void Internal_Lerp_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret) { }

	[Address(RVA = "0x304DB80", Offset = "0x304CF80", Length = "0x5B")]
	[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = True)]
	[Token(Token = "0x60010BE")]
	private static Quaternion Internal_LookRotation(in Vector3 forward, in Vector3 upwards) { }

	[Address(RVA = "0x304DB20", Offset = "0x304CF20", Length = "0x52")]
	[Token(Token = "0x60010E4")]
	private static void Internal_LookRotation_Injected(in Vector3 forward, in Vector3 upwards, out Quaternion ret) { }

	[Address(RVA = "0x304DBE0", Offset = "0x304CFE0", Length = "0x82")]
	[Token(Token = "0x60010CC")]
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	[Address(RVA = "0x304DDC0", Offset = "0x304D1C0", Length = "0x6B")]
	[FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = True)]
	[Token(Token = "0x60010B2")]
	private static Quaternion Internal_Slerp(in Quaternion a, in Quaternion b, float t) { }

	[Address(RVA = "0x304DD50", Offset = "0x304D150", Length = "0x62")]
	[Token(Token = "0x60010DE")]
	private static void Internal_Slerp_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret) { }

	[Address(RVA = "0x304DCE0", Offset = "0x304D0E0", Length = "0x6B")]
	[FreeFunction("QuaternionScripting::SlerpUnclamped", IsThreadSafe = True)]
	[Token(Token = "0x60010B3")]
	private static Quaternion Internal_SlerpUnclamped(in Quaternion a, in Quaternion b, float t) { }

	[Address(RVA = "0x304DC70", Offset = "0x304D070", Length = "0x62")]
	[Token(Token = "0x60010DF")]
	private static void Internal_SlerpUnclamped_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret) { }

	[Address(RVA = "0x304DE30", Offset = "0x304D230", Length = "0x52")]
	[FreeFunction("QuaternionScripting::ToAxisAngle", IsThreadSafe = True)]
	[Token(Token = "0x60010BB")]
	private static void Internal_ToAxisAngleRad(in Quaternion q, out Vector3 axis, out float angle) { }

	[Address(RVA = "0x304DEE0", Offset = "0x304D2E0", Length = "0x4D")]
	[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = True)]
	[Token(Token = "0x60010BA")]
	private static Vector3 Internal_ToEulerRad(in Quaternion rotation) { }

	[Address(RVA = "0x304DE90", Offset = "0x304D290", Length = "0x42")]
	[Token(Token = "0x60010E2")]
	private static void Internal_ToEulerRad_Injected(in Quaternion rotation, out Vector3 ret) { }

	[Address(RVA = "0x304DF30", Offset = "0x304D330", Length = "0x57")]
	[Token(Token = "0x60010B1")]
	public static Quaternion Inverse(Quaternion rotation) { }

	[Address(RVA = "0x304DF90", Offset = "0x304D390", Length = "0xB")]
	[Token(Token = "0x60010C7")]
	private static bool IsEqualUsingDot(float dot) { }

	[Address(RVA = "0x304DFA0", Offset = "0x304D3A0", Length = "0x77")]
	[Token(Token = "0x60010B7")]
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[Address(RVA = "0x304E0D0", Offset = "0x304D4D0", Length = "0x67")]
	[Token(Token = "0x60010BF")]
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[Address(RVA = "0x304E020", Offset = "0x304D420", Length = "0xA2")]
	[ExcludeFromDocs]
	[Token(Token = "0x60010C0")]
	public static Quaternion LookRotation(Vector3 forward) { }

	[Address(RVA = "0x304E240", Offset = "0x304D640", Length = "0xF2")]
	[Token(Token = "0x60010D2")]
	public static Quaternion Normalize(Quaternion q) { }

	[Address(RVA = "0x304E140", Offset = "0x304D540", Length = "0xF2")]
	[Token(Token = "0x60010D3")]
	public static Quaternion Normalize(in Quaternion q) { }

	[Address(RVA = "0x304EA20", Offset = "0x304DE20", Length = "0x3D")]
	[Token(Token = "0x60010C5")]
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	[Address(RVA = "0x29D4570", Offset = "0x29D3970", Length = "0x5E0")]
	[Token(Token = "0x60010C6")]
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	[Address(RVA = "0x304EA60", Offset = "0x304DE60", Length = "0x165")]
	[Token(Token = "0x60010C4")]
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	[Address(RVA = "0x5AA440", Offset = "0x5A9840", Length = "0xEF")]
	[Token(Token = "0x60010C3")]
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	[Address(RVA = "0x304E340", Offset = "0x304D740", Length = "0x104")]
	[Token(Token = "0x60010D1")]
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	[Address(RVA = "0x304E4D0", Offset = "0x304D8D0", Length = "0x77")]
	[Token(Token = "0x60010B5")]
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[Address(RVA = "0x304E450", Offset = "0x304D850", Length = "0x77")]
	[Token(Token = "0x60010B8")]
	public static Quaternion SlerpUnclamped(in Quaternion a, in Quaternion b, float t) { }

	[Address(RVA = "0x304E450", Offset = "0x304D850", Length = "0x77")]
	[Token(Token = "0x60010B6")]
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[Address(RVA = "0x304E550", Offset = "0x304D950", Length = "0x62")]
	[Token(Token = "0x60010D0")]
	public void ToAngleAxis(out float angle, out Vector3 axis) { }

	[Address(RVA = "0x304E840", Offset = "0x304DC40", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x60010D9")]
	public virtual string ToString() { }

	[Address(RVA = "0x304E5C0", Offset = "0x304D9C0", Length = "0x279")]
	[IsReadOnly]
	[Token(Token = "0x60010DA")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

