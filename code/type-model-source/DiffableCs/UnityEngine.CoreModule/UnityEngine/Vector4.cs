namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector4f")]
[NativeHeader("Runtime/Math/Vector4.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x200015C")]
public struct Vector4 : IEquatable<Vector4>, IFormattable
{
	[Token(Token = "0x40005D5")]
	public const float kEpsilon = 1E-05; //Field offset: 0x0
	[Token(Token = "0x40005DA")]
	private static readonly Vector4 zeroVector; //Field offset: 0x0
	[Token(Token = "0x40005DB")]
	private static readonly Vector4 oneVector; //Field offset: 0x10
	[Token(Token = "0x40005DC")]
	private static readonly Vector4 positiveInfinityVector; //Field offset: 0x20
	[Token(Token = "0x40005DD")]
	private static readonly Vector4 negativeInfinityVector; //Field offset: 0x30
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005D6")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40005D7")]
	public float y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005D8")]
	public float z; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40005D9")]
	public float w; //Field offset: 0xC

	[Token(Token = "0x170002B7")]
	public float Item
	{
		[Address(RVA = "0x2833720", Offset = "0x2832B20", Length = "0x90")]
		[IsReadOnly]
		[Token(Token = "0x600117C")]
		 get { } //Length: 144
		[Address(RVA = "0x28337B0", Offset = "0x2832BB0", Length = "0x90")]
		[Token(Token = "0x600117D")]
		 set { } //Length: 144
	}

	[Token(Token = "0x170002B9")]
	public float magnitude
	{
		[Address(RVA = "0x3075D20", Offset = "0x3075120", Length = "0xA4")]
		[IsReadOnly]
		[Token(Token = "0x600118B")]
		 get { } //Length: 164
	}

	[Token(Token = "0x170002B8")]
	public Vector4 normalized
	{
		[Address(RVA = "0x3075DD0", Offset = "0x30751D0", Length = "0x84")]
		[IsReadOnly]
		[Token(Token = "0x6001189")]
		 get { } //Length: 132
	}

	[Token(Token = "0x170002BC")]
	public static Vector4 one
	{
		[Address(RVA = "0x3075E60", Offset = "0x3075260", Length = "0x43")]
		[Token(Token = "0x600118E")]
		 get { } //Length: 67
	}

	[Token(Token = "0x170002BA")]
	public float sqrMagnitude
	{
		[Address(RVA = "0x3075EB0", Offset = "0x30752B0", Length = "0x30")]
		[IsReadOnly]
		[Token(Token = "0x600118C")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170002BB")]
	public static Vector4 zero
	{
		[Address(RVA = "0x3075EE0", Offset = "0x30752E0", Length = "0x42")]
		[Token(Token = "0x600118D")]
		 get { } //Length: 66
	}

	[Address(RVA = "0x3075C60", Offset = "0x3075060", Length = "0x87")]
	[Token(Token = "0x600119D")]
	private static Vector4() { }

	[Address(RVA = "0x27F69A0", Offset = "0x27F5DA0", Length = "0x1A")]
	[Token(Token = "0x600117E")]
	public Vector4(float x, float y, float z, float w) { }

	[Address(RVA = "0x3075D00", Offset = "0x3075100", Length = "0x16")]
	[Token(Token = "0x600117F")]
	public Vector4(float x, float y, float z) { }

	[Address(RVA = "0x3075CF0", Offset = "0x30750F0", Length = "0x10")]
	[Token(Token = "0x6001180")]
	public Vector4(float x, float y) { }

	[Address(RVA = "0x1CE1880", Offset = "0x1CE0C80", Length = "0x33")]
	[Token(Token = "0x600118A")]
	public static float Dot(in Vector4 a, in Vector4 b) { }

	[Address(RVA = "0x23DE6F0", Offset = "0x23DDAF0", Length = "0x38")]
	[IsReadOnly]
	[Token(Token = "0x6001187")]
	public bool Equals(in Vector4 other) { }

	[Address(RVA = "0x23DE6F0", Offset = "0x23DDAF0", Length = "0x38")]
	[IsReadOnly]
	[Token(Token = "0x6001186")]
	public override bool Equals(Vector4 other) { }

	[Address(RVA = "0x3075840", Offset = "0x3074C40", Length = "0xBE")]
	[IsReadOnly]
	[Token(Token = "0x6001185")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x2833720", Offset = "0x2832B20", Length = "0x90")]
	[IsReadOnly]
	[Token(Token = "0x600117C")]
	public float get_Item(int index) { }

	[Address(RVA = "0x3075D20", Offset = "0x3075120", Length = "0xA4")]
	[IsReadOnly]
	[Token(Token = "0x600118B")]
	public float get_magnitude() { }

	[Address(RVA = "0x3075DD0", Offset = "0x30751D0", Length = "0x84")]
	[IsReadOnly]
	[Token(Token = "0x6001189")]
	public Vector4 get_normalized() { }

	[Address(RVA = "0x3075E60", Offset = "0x3075260", Length = "0x43")]
	[Token(Token = "0x600118E")]
	public static Vector4 get_one() { }

	[Address(RVA = "0x3075EB0", Offset = "0x30752B0", Length = "0x30")]
	[IsReadOnly]
	[Token(Token = "0x600118C")]
	public float get_sqrMagnitude() { }

	[Address(RVA = "0x3075EE0", Offset = "0x30752E0", Length = "0x42")]
	[Token(Token = "0x600118D")]
	public static Vector4 get_zero() { }

	[Address(RVA = "0x80AFF0", Offset = "0x80A3F0", Length = "0x6B")]
	[IsReadOnly]
	[Token(Token = "0x6001184")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3047B40", Offset = "0x3046F40", Length = "0x98")]
	[Token(Token = "0x6001182")]
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	[Address(RVA = "0x3075900", Offset = "0x3074D00", Length = "0x8A")]
	[Token(Token = "0x6001188")]
	public static Vector4 Normalize(in Vector4 a) { }

	[Address(RVA = "0x2AE0900", Offset = "0x2ADFD00", Length = "0x41")]
	[Token(Token = "0x600118F")]
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	[Address(RVA = "0x2AE0A20", Offset = "0x2ADFE20", Length = "0x11")]
	[Token(Token = "0x6001194")]
	public static Vector4 op_Division(Vector4 a, float d) { }

	[Address(RVA = "0x3048180", Offset = "0x3047580", Length = "0x51")]
	[Token(Token = "0x6001195")]
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
	[Token(Token = "0x600119A")]
	public static Vector2 op_Implicit(Vector4 v) { }

	[Address(RVA = "0x3075F50", Offset = "0x3075350", Length = "0x24")]
	[Token(Token = "0x6001199")]
	public static Vector4 op_Implicit(Vector2 v) { }

	[Address(RVA = "0x2A8CC90", Offset = "0x2A8C090", Length = "0x14")]
	[Token(Token = "0x6001198")]
	public static Vector3 op_Implicit(Vector4 v) { }

	[Address(RVA = "0x3075F30", Offset = "0x3075330", Length = "0x1B")]
	[Token(Token = "0x6001197")]
	public static Vector4 op_Implicit(Vector3 v) { }

	[Address(RVA = "0x30481E0", Offset = "0x30475E0", Length = "0x68")]
	[Token(Token = "0x6001196")]
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	[Address(RVA = "0x2AE1150", Offset = "0x2AE0550", Length = "0x11")]
	[Token(Token = "0x6001192")]
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	[Address(RVA = "0x2AE1170", Offset = "0x2AE0570", Length = "0x12")]
	[Token(Token = "0x6001193")]
	public static Vector4 op_Multiply(float d, Vector4 a) { }

	[Address(RVA = "0x2AE11F0", Offset = "0x2AE05F0", Length = "0x41")]
	[Token(Token = "0x6001190")]
	public static Vector4 op_Subtraction(Vector4 a, Vector4 b) { }

	[Address(RVA = "0x2AE1240", Offset = "0x2AE0640", Length = "0x11")]
	[Token(Token = "0x6001191")]
	public static Vector4 op_UnaryNegation(Vector4 a) { }

	[Address(RVA = "0x3075990", Offset = "0x3074D90", Length = "0x3A")]
	[Token(Token = "0x6001183")]
	public void Scale(Vector4 scale) { }

	[Address(RVA = "0x27F69A0", Offset = "0x27F5DA0", Length = "0x1A")]
	[Token(Token = "0x6001181")]
	public void Set(float newX, float newY, float newZ, float newW) { }

	[Address(RVA = "0x28337B0", Offset = "0x2832BB0", Length = "0x90")]
	[Token(Token = "0x600117D")]
	public void set_Item(int index, float value) { }

	[Address(RVA = "0x3075C50", Offset = "0x3075050", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x600119B")]
	public virtual string ToString() { }

	[Address(RVA = "0x30759D0", Offset = "0x3074DD0", Length = "0x279")]
	[IsReadOnly]
	[Token(Token = "0x600119C")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

