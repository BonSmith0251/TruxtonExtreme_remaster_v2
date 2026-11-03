namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Matrix4x4f")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000155")]
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
{
	[Token(Token = "0x400059E")]
	private static readonly Matrix4x4 zeroMatrix; //Field offset: 0x0
	[Token(Token = "0x400059F")]
	private static readonly Matrix4x4 identityMatrix; //Field offset: 0x40
	[FieldOffset(Offset = "0x0")]
	[NativeName("m_Data[0]")]
	[Token(Token = "0x400058E")]
	public float m00; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("m_Data[1]")]
	[Token(Token = "0x400058F")]
	public float m10; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("m_Data[2]")]
	[Token(Token = "0x4000590")]
	public float m20; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("m_Data[3]")]
	[Token(Token = "0x4000591")]
	public float m30; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("m_Data[4]")]
	[Token(Token = "0x4000592")]
	public float m01; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[NativeName("m_Data[5]")]
	[Token(Token = "0x4000593")]
	public float m11; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[NativeName("m_Data[6]")]
	[Token(Token = "0x4000594")]
	public float m21; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("m_Data[7]")]
	[Token(Token = "0x4000595")]
	public float m31; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[NativeName("m_Data[8]")]
	[Token(Token = "0x4000596")]
	public float m02; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[NativeName("m_Data[9]")]
	[Token(Token = "0x4000597")]
	public float m12; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[NativeName("m_Data[10]")]
	[Token(Token = "0x4000598")]
	public float m22; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[NativeName("m_Data[11]")]
	[Token(Token = "0x4000599")]
	public float m32; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[NativeName("m_Data[12]")]
	[Token(Token = "0x400059A")]
	public float m03; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[NativeName("m_Data[13]")]
	[Token(Token = "0x400059B")]
	public float m13; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[NativeName("m_Data[14]")]
	[Token(Token = "0x400059C")]
	public float m23; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[NativeName("m_Data[15]")]
	[Token(Token = "0x400059D")]
	public float m33; //Field offset: 0x3C

	[Token(Token = "0x1700028B")]
	public FrustumPlanes decomposeProjection
	{
		[Address(RVA = "0x304D080", Offset = "0x304C480", Length = "0x69")]
		[IsReadOnly]
		[Token(Token = "0x6001035")]
		 get { } //Length: 105
	}

	[Token(Token = "0x17000291")]
	public static Matrix4x4 identity
	{
		[Address(RVA = "0x304D0F0", Offset = "0x304C4F0", Length = "0x5B")]
		[Token(Token = "0x600105F")]
		 get { } //Length: 91
	}

	[Token(Token = "0x1700028C")]
	public Matrix4x4 inverse
	{
		[Address(RVA = "0x304C050", Offset = "0x304B450", Length = "0x81")]
		[IsReadOnly]
		[Token(Token = "0x600103E")]
		 get { } //Length: 129
	}

	[Token(Token = "0x1700028E")]
	public float Item
	{
		[Address(RVA = "0x304D070", Offset = "0x304C470", Length = "0xC")]
		[IsReadOnly]
		[Token(Token = "0x6001048")]
		 get { } //Length: 12
		[Address(RVA = "0x304D410", Offset = "0x304C810", Length = "0xF")]
		[Token(Token = "0x6001049")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700028F")]
	public float Item
	{
		[Address(RVA = "0x2C230C0", Offset = "0x2C224C0", Length = "0x118")]
		[IsReadOnly]
		[Token(Token = "0x600104A")]
		 get { } //Length: 280
		[Address(RVA = "0x27FF350", Offset = "0x27FE750", Length = "0x118")]
		[Token(Token = "0x600104B")]
		 set { } //Length: 280
	}

	[Token(Token = "0x1700028A")]
	public Vector3 lossyScale
	{
		[Address(RVA = "0x304D150", Offset = "0x304C550", Length = "0x63")]
		[IsReadOnly]
		[Token(Token = "0x6001034")]
		 get { } //Length: 99
	}

	[Token(Token = "0x17000289")]
	public Quaternion rotation
	{
		[Address(RVA = "0x304D1C0", Offset = "0x304C5C0", Length = "0x57")]
		[IsReadOnly]
		[Token(Token = "0x6001033")]
		 get { } //Length: 87
	}

	[Token(Token = "0x1700028D")]
	public Matrix4x4 transpose
	{
		[Address(RVA = "0x304D220", Offset = "0x304C620", Length = "0x81")]
		[IsReadOnly]
		[Token(Token = "0x6001040")]
		 get { } //Length: 129
	}

	[Token(Token = "0x17000290")]
	public static Matrix4x4 zero
	{
		[Address(RVA = "0x304D2B0", Offset = "0x304C6B0", Length = "0x5A")]
		[Token(Token = "0x600105E")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x304CEE0", Offset = "0x304C2E0", Length = "0x112")]
	[Token(Token = "0x6001062")]
	private static Matrix4x4() { }

	[Address(RVA = "0x304D000", Offset = "0x304C400", Length = "0x6D")]
	[Token(Token = "0x6001047")]
	public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	[Address(RVA = "0x304B6A0", Offset = "0x304AAA0", Length = "0x51")]
	[IsReadOnly]
	[ThreadSafe]
	[Token(Token = "0x6001032")]
	private FrustumPlanes DecomposeProjection() { }

	[Address(RVA = "0x304B650", Offset = "0x304AA50", Length = "0x42")]
	[Token(Token = "0x6001065")]
	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	[Address(RVA = "0x6CB9B0", Offset = "0x6CADB0", Length = "0x105")]
	[IsReadOnly]
	[Token(Token = "0x600104E")]
	public override bool Equals(Matrix4x4 other) { }

	[Address(RVA = "0x6CB9B0", Offset = "0x6CADB0", Length = "0x105")]
	[IsReadOnly]
	[Token(Token = "0x600104F")]
	public bool Equals(in Matrix4x4 other) { }

	[Address(RVA = "0x304B700", Offset = "0x304AB00", Length = "0xAB")]
	[IsReadOnly]
	[Token(Token = "0x600104D")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x304B830", Offset = "0x304AC30", Length = "0xC5")]
	[Token(Token = "0x6001046")]
	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	[Address(RVA = "0x304B900", Offset = "0x304AD00", Length = "0xA5")]
	[FreeFunction("MatrixScripting::Frustum", IsThreadSafe = True)]
	[Token(Token = "0x6001045")]
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[Address(RVA = "0x304B7B0", Offset = "0x304ABB0", Length = "0x78")]
	[Token(Token = "0x600106C")]
	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	[Address(RVA = "0x304D080", Offset = "0x304C480", Length = "0x69")]
	[IsReadOnly]
	[Token(Token = "0x6001035")]
	public FrustumPlanes get_decomposeProjection() { }

	[Address(RVA = "0x304D0F0", Offset = "0x304C4F0", Length = "0x5B")]
	[Token(Token = "0x600105F")]
	public static Matrix4x4 get_identity() { }

	[Address(RVA = "0x304C050", Offset = "0x304B450", Length = "0x81")]
	[IsReadOnly]
	[Token(Token = "0x600103E")]
	public Matrix4x4 get_inverse() { }

	[Address(RVA = "0x2C230C0", Offset = "0x2C224C0", Length = "0x118")]
	[IsReadOnly]
	[Token(Token = "0x600104A")]
	public float get_Item(int index) { }

	[Address(RVA = "0x304D070", Offset = "0x304C470", Length = "0xC")]
	[IsReadOnly]
	[Token(Token = "0x6001048")]
	public float get_Item(int row, int column) { }

	[Address(RVA = "0x304D150", Offset = "0x304C550", Length = "0x63")]
	[IsReadOnly]
	[Token(Token = "0x6001034")]
	public Vector3 get_lossyScale() { }

	[Address(RVA = "0x304D1C0", Offset = "0x304C5C0", Length = "0x57")]
	[IsReadOnly]
	[Token(Token = "0x6001033")]
	public Quaternion get_rotation() { }

	[Address(RVA = "0x304D220", Offset = "0x304C620", Length = "0x81")]
	[IsReadOnly]
	[Token(Token = "0x6001040")]
	public Matrix4x4 get_transpose() { }

	[Address(RVA = "0x304D2B0", Offset = "0x304C6B0", Length = "0x5A")]
	[Token(Token = "0x600105E")]
	public static Matrix4x4 get_zero() { }

	[Address(RVA = "0x6CBAC0", Offset = "0x6CAEC0", Length = "0x1D3")]
	[IsReadOnly]
	[Token(Token = "0x6001053")]
	public Vector4 GetColumn(int index) { }

	[Address(RVA = "0xD94610", Offset = "0xD93A10", Length = "0xB19")]
	[IsReadOnly]
	[Token(Token = "0x600104C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x304BA00", Offset = "0x304AE00", Length = "0x4D")]
	[IsReadOnly]
	[ThreadSafe]
	[Token(Token = "0x6001031")]
	private Vector3 GetLossyScale() { }

	[Address(RVA = "0x304B9B0", Offset = "0x304ADB0", Length = "0x42")]
	[Token(Token = "0x6001064")]
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x304BA50", Offset = "0x304AE50", Length = "0x15")]
	[IsReadOnly]
	[Token(Token = "0x6001055")]
	public Vector3 GetPosition() { }

	[Address(RVA = "0x304BAC0", Offset = "0x304AEC0", Length = "0x4B")]
	[IsReadOnly]
	[ThreadSafe]
	[Token(Token = "0x6001030")]
	private Quaternion GetRotation() { }

	[Address(RVA = "0x304BA70", Offset = "0x304AE70", Length = "0x42")]
	[Token(Token = "0x6001063")]
	private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	[Address(RVA = "0x304BB10", Offset = "0x304AF10", Length = "0xEF")]
	[IsReadOnly]
	[Token(Token = "0x6001054")]
	public Vector4 GetRow(int index) { }

	[Address(RVA = "0x304BCA0", Offset = "0x304B0A0", Length = "0x57")]
	[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = True)]
	[Token(Token = "0x600103C")]
	private static Matrix4x4 Internal_Inverse(in Matrix4x4 m) { }

	[Address(RVA = "0x304BC50", Offset = "0x304B050", Length = "0x42")]
	[Token(Token = "0x6001067")]
	private static void Internal_Inverse_Injected(in Matrix4x4 m, out Matrix4x4 ret) { }

	[Address(RVA = "0x304BC00", Offset = "0x304B000", Length = "0x42")]
	[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = True)]
	[Token(Token = "0x600103A")]
	private static bool Internal_Inverse3DAffine(in Matrix4x4 input, ref Matrix4x4 result) { }

	[Address(RVA = "0x304BD70", Offset = "0x304B170", Length = "0x77")]
	[FreeFunction("MatrixScripting::LookAt", IsThreadSafe = True)]
	[Token(Token = "0x6001043")]
	private static Matrix4x4 Internal_LookAt(in Vector3 from, in Vector3 to, in Vector3 up) { }

	[Address(RVA = "0x304BD00", Offset = "0x304B100", Length = "0x62")]
	[Token(Token = "0x600106B")]
	private static void Internal_LookAt_Injected(in Vector3 from, in Vector3 to, in Vector3 up, out Matrix4x4 ret) { }

	[Address(RVA = "0x304BDF0", Offset = "0x304B1F0", Length = "0x62")]
	[FreeFunction("MatrixScripting::SetTRS", IsThreadSafe = True)]
	[Token(Token = "0x6001038")]
	private static void Internal_SetTRS(ref Matrix4x4 m, in Vector3 pos, in Quaternion q, in Vector3 s) { }

	[Address(RVA = "0x304BFA0", Offset = "0x304B3A0", Length = "0x57")]
	[FreeFunction("MatrixScripting::Transpose", IsThreadSafe = True)]
	[Token(Token = "0x600103F")]
	private static Matrix4x4 Internal_Transpose(in Matrix4x4 m) { }

	[Address(RVA = "0x304BF50", Offset = "0x304B350", Length = "0x42")]
	[Token(Token = "0x6001068")]
	private static void Internal_Transpose_Injected(in Matrix4x4 m, out Matrix4x4 ret) { }

	[Address(RVA = "0x304BED0", Offset = "0x304B2D0", Length = "0x77")]
	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = True)]
	[Token(Token = "0x6001036")]
	private static Matrix4x4 Internal_TRS(in Vector3 pos, in Quaternion q, in Vector3 s) { }

	[Address(RVA = "0x304BE60", Offset = "0x304B260", Length = "0x62")]
	[Token(Token = "0x6001066")]
	private static void Internal_TRS_Injected(in Vector3 pos, in Quaternion q, in Vector3 s, out Matrix4x4 ret) { }

	[Address(RVA = "0x304C050", Offset = "0x304B450", Length = "0x81")]
	[Token(Token = "0x600103D")]
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	[Address(RVA = "0x304C000", Offset = "0x304B400", Length = "0x42")]
	[Token(Token = "0x600103B")]
	public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) { }

	[Address(RVA = "0x304C0E0", Offset = "0x304B4E0", Length = "0xA0")]
	[Token(Token = "0x6001044")]
	public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up) { }

	[Address(RVA = "0x304C180", Offset = "0x304B580", Length = "0xF1")]
	[IsReadOnly]
	[Token(Token = "0x6001058")]
	public Vector3 MultiplyPoint(Vector3 point) { }

	[Address(RVA = "0x5AA0D0", Offset = "0x5A94D0", Length = "0x362")]
	[IsReadOnly]
	[Token(Token = "0x6001059")]
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	[Address(RVA = "0x304C280", Offset = "0x304B680", Length = "0x89")]
	[IsReadOnly]
	[Token(Token = "0x600105A")]
	public Vector3 MultiplyVector(Vector3 vector) { }

	[Address(RVA = "0x284DB40", Offset = "0x284CF40", Length = "0x299")]
	[Token(Token = "0x6001052")]
	public static bool op_Equality(Matrix4x4 lhs, Matrix4x4 rhs) { }

	[Address(RVA = "0x1D47F90", Offset = "0x1D47390", Length = "0x44A")]
	[Token(Token = "0x6001050")]
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	[Address(RVA = "0x304D310", Offset = "0x304C710", Length = "0xFC")]
	[Token(Token = "0x6001051")]
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	[Address(RVA = "0x304C390", Offset = "0x304B790", Length = "0xA5")]
	[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = True)]
	[Token(Token = "0x6001041")]
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[Address(RVA = "0x304C310", Offset = "0x304B710", Length = "0x78")]
	[Token(Token = "0x6001069")]
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	[Address(RVA = "0x304C4C0", Offset = "0x304B8C0", Length = "0x87")]
	[FreeFunction("MatrixScripting::Perspective", IsThreadSafe = True)]
	[Token(Token = "0x6001042")]
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[Address(RVA = "0x304C440", Offset = "0x304B840", Length = "0x72")]
	[Token(Token = "0x600106A")]
	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }

	[Address(RVA = "0x1CC4B20", Offset = "0x1CC3F20", Length = "0x1A9")]
	[Token(Token = "0x600105D")]
	public static Matrix4x4 Rotate(Quaternion q) { }

	[Address(RVA = "0x304C550", Offset = "0x304B950", Length = "0x3A")]
	[Token(Token = "0x600105B")]
	public static Matrix4x4 Scale(Vector3 vector) { }

	[Address(RVA = "0x27FF350", Offset = "0x27FE750", Length = "0x118")]
	[Token(Token = "0x600104B")]
	public void set_Item(int index, float value) { }

	[Address(RVA = "0x304D410", Offset = "0x304C810", Length = "0xF")]
	[Token(Token = "0x6001049")]
	public void set_Item(int row, int column, float value) { }

	[Address(RVA = "0x304C590", Offset = "0x304B990", Length = "0x7F")]
	[Token(Token = "0x6001056")]
	public void SetColumn(int index, Vector4 column) { }

	[Address(RVA = "0x304C610", Offset = "0x304BA10", Length = "0x6C")]
	[Token(Token = "0x6001057")]
	public void SetRow(int index, Vector4 row) { }

	[Address(RVA = "0x304C680", Offset = "0x304BA80", Length = "0x62")]
	[Token(Token = "0x6001039")]
	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[Address(RVA = "0x304C7A0", Offset = "0x304BBA0", Length = "0x6E3")]
	[IsReadOnly]
	[Token(Token = "0x6001061")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x304C790", Offset = "0x304BB90", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x6001060")]
	public virtual string ToString() { }

	[Address(RVA = "0x304CE90", Offset = "0x304C290", Length = "0x46")]
	[Token(Token = "0x600105C")]
	public static Matrix4x4 Translate(Vector3 vector) { }

	[Address(RVA = "0x304C6F0", Offset = "0x304BAF0", Length = "0xA0")]
	[Token(Token = "0x6001037")]
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

}

