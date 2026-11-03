namespace KANAI.Kernel;

[Token(Token = "0x2000039")]
public class VectorUtility
{
	[Token(Token = "0x40000EA")]
	private const float _PI2 = 6.2831855; //Field offset: 0x0
	[Token(Token = "0x40000EB")]
	private const int _arcDevide = 3600; //Field offset: 0x0
	[Token(Token = "0x40000EC")]
	private const int _arcAccuracy = 10; //Field offset: 0x0
	[Token(Token = "0x40000ED")]
	private const int _cosTable = 900; //Field offset: 0x0
	[Token(Token = "0x40000EE")]
	private static Single[] _SinTable; //Field offset: 0x0

	[Address(RVA = "0x1DF8B40", Offset = "0x1DF7F40", Length = "0x143")]
	[Token(Token = "0x60001D7")]
	private static VectorUtility() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000200")]
	public VectorUtility() { }

	[Address(RVA = "0x1DF6920", Offset = "0x1DF5D20", Length = "0x10")]
	[Token(Token = "0x60001F7")]
	public static float Abs(float value) { }

	[Address(RVA = "0x1DF6930", Offset = "0x1DF5D30", Length = "0xE3")]
	[Token(Token = "0x60001E1")]
	public static bool Between(Vector3 v, Vector3 _min, Vector3 _max) { }

	[Address(RVA = "0x1DF6A20", Offset = "0x1DF5E20", Length = "0xC1")]
	[Token(Token = "0x60001FB")]
	public static float CalcNear(float v1, float v2, float diff) { }

	[Address(RVA = "0x1DF6AF0", Offset = "0x1DF5EF0", Length = "0xE7")]
	[Token(Token = "0x60001E9")]
	public static Vector3 CircleSymbol(float trate, float trangeX, float trangeZ) { }

	[Address(RVA = "0x1DF6C50", Offset = "0x1DF6050", Length = "0x77")]
	[Token(Token = "0x60001D9")]
	public static Vector3 Clamp(Vector3 v, Vector3 _min, Vector3 _max) { }

	[Address(RVA = "0x1DF6BE0", Offset = "0x1DF5FE0", Length = "0x6F")]
	[Token(Token = "0x60001DA")]
	public static Vector2 Clamp(Vector2 v, Vector2 _min, Vector2 _max) { }

	[Address(RVA = "0x1DF6CD0", Offset = "0x1DF60D0", Length = "0x19E")]
	[Token(Token = "0x60001F0")]
	public static Vector3 ClosestPoint(Vector3 a, Vector3 b, Vector3 p) { }

	[Address(RVA = "0x1DF6E70", Offset = "0x1DF6270", Length = "0xAD")]
	[Token(Token = "0x60001F1")]
	public static float ClosestRate(Vector3 a, Vector3 b, Vector3 p) { }

	[Address(RVA = "0x1DF6F20", Offset = "0x1DF6320", Length = "0x24")]
	[Token(Token = "0x60001E0")]
	public static bool Compare(Vector3 l, Vector3 r) { }

	[Address(RVA = "0x1DF6F50", Offset = "0x1DF6350", Length = "0x48")]
	[Token(Token = "0x60001E5")]
	public static float Cos(int n) { }

	[Address(RVA = "0x1DF6FA0", Offset = "0x1DF63A0", Length = "0xCD")]
	[Token(Token = "0x60001E3")]
	public static float Cosf(float t) { }

	[Address(RVA = "0x1DF7070", Offset = "0x1DF6470", Length = "0x13B")]
	[Token(Token = "0x60001FF")]
	public static Vector3 CubicBeizer(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t) { }

	[Address(RVA = "0x1DF71B0", Offset = "0x1DF65B0", Length = "0x89")]
	[Token(Token = "0x60001EA")]
	public static float FreeFall(float trate) { }

	[Address(RVA = "0x1DF7240", Offset = "0x1DF6640", Length = "0x170")]
	[Token(Token = "0x60001F5")]
	public static float GetQuaternionDiff(Quaternion a, Quaternion b) { }

	[Address(RVA = "0x1DF73B0", Offset = "0x1DF67B0", Length = "0x19A")]
	[Token(Token = "0x60001E7")]
	public static Vector3 HomingDirection(Vector3 _dir, Vector3 _subpos, float _maxRSin, float _maxRCos) { }

	[Address(RVA = "0x1DF7550", Offset = "0x1DF6950", Length = "0x139")]
	[Token(Token = "0x60001E6")]
	public static Vector3 HomingDirection(Vector3 _dir, Vector3 _subpos, float _maxArc) { }

	[Address(RVA = "0x1DF7690", Offset = "0x1DF6A90", Length = "0xDC")]
	[Token(Token = "0x60001E8")]
	public static Vector3 InfinitySymbol(float trate, float trangeX, float trangeZ) { }

	[Address(RVA = "0x1DF7770", Offset = "0x1DF6B70", Length = "0xE3")]
	[Token(Token = "0x60001D8")]
	public static void Initialize() { }

	[Address(RVA = "0x1DF7860", Offset = "0x1DF6C60", Length = "0x130")]
	[Token(Token = "0x60001FC")]
	public static bool IsInside(Vector2 p, Vector2 ta, Vector2 tb, Vector2 tc) { }

	[Address(RVA = "0x1DF7990", Offset = "0x1DF6D90", Length = "0x1B8")]
	[Token(Token = "0x60001FD")]
	public static bool IsInside(Vector3 p0, Bounds tbound) { }

	[Address(RVA = "0x1DF7B50", Offset = "0x1DF6F50", Length = "0x32")]
	[Token(Token = "0x60001F6")]
	public static bool IsLeftSide(float x1, float y1, float x2, float y2, float px, float py) { }

	[Address(RVA = "0x1DF7D80", Offset = "0x1DF7180", Length = "0xE2")]
	[Token(Token = "0x60001ED")]
	public static bool IsLineIntersection(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4) { }

	[Address(RVA = "0x1DF7B90", Offset = "0x1DF6F90", Length = "0xA4")]
	[Token(Token = "0x60001EE")]
	public static bool IsLineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4) { }

	[Address(RVA = "0x1DF7C40", Offset = "0x1DF7040", Length = "0x139")]
	[Token(Token = "0x60001EF")]
	public static bool IsLineIntersection(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y, float p4x, float p4y) { }

	[Address(RVA = "0x1DF7FB0", Offset = "0x1DF73B0", Length = "0x64")]
	[Token(Token = "0x60001F8")]
	public static bool IsZero(float value) { }

	[Address(RVA = "0x1DF7E70", Offset = "0x1DF7270", Length = "0x139")]
	[Token(Token = "0x60001F9")]
	public static bool IsZero(Vector3 v) { }

	[Address(RVA = "0x1DF8020", Offset = "0x1DF7420", Length = "0x1D")]
	[Token(Token = "0x60001DB")]
	public static float LenMax(float a, float b) { }

	[Address(RVA = "0x1DF8040", Offset = "0x1DF7440", Length = "0x1D")]
	[Token(Token = "0x60001DC")]
	public static float LenMin(float a, float b) { }

	[Address(RVA = "0x1DF8060", Offset = "0x1DF7460", Length = "0x236")]
	[Token(Token = "0x60001EC")]
	public static bool LineIntersection(out Vector2 intersection, Vector2 origin1, Vector2 direction1, Vector2 origin2, Vector2 direction2) { }

	[Address(RVA = "0x1DF82A0", Offset = "0x1DF76A0", Length = "0x340")]
	[Token(Token = "0x60001EB")]
	public static bool LineIntersection(out Vector3 intersection, Vector3 l1p1, Vector3 l1p2, Vector3 l2p1, Vector3 l2p2) { }

	[Address(RVA = "0x1DF85E0", Offset = "0x1DF79E0", Length = "0x3F")]
	[Token(Token = "0x60001F4")]
	public static Vector3 Muitiply(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x1DF8620", Offset = "0x1DF7A20", Length = "0x44")]
	[Token(Token = "0x60001DE")]
	public static float MultipleCeil(float value, float multiple) { }

	[Address(RVA = "0x1DF8670", Offset = "0x1DF7A70", Length = "0x44")]
	[Token(Token = "0x60001DD")]
	public static float MultipleFloor(float value, float multiple) { }

	[Address(RVA = "0x1DF86C0", Offset = "0x1DF7AC0", Length = "0xC7")]
	[Token(Token = "0x60001DF")]
	public static float MultipleRound(float value, float multiple) { }

	[Address(RVA = "0x1DF8790", Offset = "0x1DF7B90", Length = "0x7E")]
	[Token(Token = "0x60001FA")]
	public static bool NearEqual(float v1, float v2, float level = 0.0001) { }

	[Address(RVA = "0x1DF8810", Offset = "0x1DF7C10", Length = "0xA0")]
	[Token(Token = "0x60001FE")]
	public static string Print(Vector3 v0) { }

	[Address(RVA = "0x1DF88B0", Offset = "0x1DF7CB0", Length = "0x8F")]
	[Token(Token = "0x60001F2")]
	public static Vector3 ShakeXYZ(float rate) { }

	[Address(RVA = "0x1DF8940", Offset = "0x1DF7D40", Length = "0x6C")]
	[Token(Token = "0x60001F3")]
	public static Vector3 ShakeXZ(float rate) { }

	[Address(RVA = "0x1DF89B0", Offset = "0x1DF7DB0", Length = "0xB5")]
	[Token(Token = "0x60001E4")]
	public static float Sin(int n) { }

	[Address(RVA = "0x1DF8A70", Offset = "0x1DF7E70", Length = "0xC8")]
	[Token(Token = "0x60001E2")]
	public static float Sinf(float t) { }

}

