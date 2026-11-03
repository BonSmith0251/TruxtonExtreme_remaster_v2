namespace UnityEngine.Rendering;

[Token(Token = "0x200014A")]
public class SphericalHarmonicsL2Utils
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000AF0")]
	public SphericalHarmonicsL2Utils() { }

	[Address(RVA = "0x2C379B0", Offset = "0x2C36DB0", Length = "0x86")]
	[Token(Token = "0x6000AEF")]
	public static Vector3 GetCoefficient(SphericalHarmonicsL2 sh, int index) { }

	[Address(RVA = "0x2C37A40", Offset = "0x2C36E40", Length = "0x134")]
	[Token(Token = "0x6000AE7")]
	public static void GetL1(SphericalHarmonicsL2 sh, out Vector3 L1_R, out Vector3 L1_G, out Vector3 L1_B) { }

	[Address(RVA = "0x2C37B80", Offset = "0x2C36F80", Length = "0x1E5")]
	[Token(Token = "0x6000AE8")]
	public static void GetL2(SphericalHarmonicsL2 sh, out Vector3 L2_0, out Vector3 L2_1, out Vector3 L2_2, out Vector3 L2_3, out Vector3 L2_4) { }

	[Address(RVA = "0x2C37D70", Offset = "0x2C37170", Length = "0x7B")]
	[Token(Token = "0x6000AEE")]
	public static void SetCoefficient(ref SphericalHarmonicsL2 sh, int index, Vector3 coefficient) { }

	[Address(RVA = "0x2C37DF0", Offset = "0x2C371F0", Length = "0x6E")]
	[Token(Token = "0x6000AE9")]
	public static void SetL0(ref SphericalHarmonicsL2 sh, Vector3 L0) { }

	[Address(RVA = "0x2C37FE0", Offset = "0x2C373E0", Length = "0x144")]
	[Token(Token = "0x6000AED")]
	public static void SetL1(ref SphericalHarmonicsL2 sh, Vector3 L1_R, Vector3 L1_G, Vector3 L1_B) { }

	[Address(RVA = "0x2C37E60", Offset = "0x2C37260", Length = "0x77")]
	[Token(Token = "0x6000AEC")]
	public static void SetL1B(ref SphericalHarmonicsL2 sh, Vector3 L1_B) { }

	[Address(RVA = "0x2C37EE0", Offset = "0x2C372E0", Length = "0x77")]
	[Token(Token = "0x6000AEB")]
	public static void SetL1G(ref SphericalHarmonicsL2 sh, Vector3 L1_G) { }

	[Address(RVA = "0x2C37F60", Offset = "0x2C37360", Length = "0x71")]
	[Token(Token = "0x6000AEA")]
	public static void SetL1R(ref SphericalHarmonicsL2 sh, Vector3 L1_R) { }

}

