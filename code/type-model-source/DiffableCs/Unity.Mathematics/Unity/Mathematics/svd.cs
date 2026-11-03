namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000053")]
public static class svd
{
	[Token(Token = "0x400013B")]
	public const float k_EpsilonDeterminant = 1E-06; //Field offset: 0x0
	[Token(Token = "0x400013C")]
	public const float k_EpsilonRCP = 1E-09; //Field offset: 0x0
	[Token(Token = "0x400013D")]
	public const float k_EpsilonNormalSqrt = 1E-15; //Field offset: 0x0
	[Token(Token = "0x400013E")]
	public const float k_EpsilonNormal = 1E-30; //Field offset: 0x0

	[Address(RVA = "0x2B2B740", Offset = "0x2B2AB40", Length = "0x14B")]
	[Token(Token = "0x6001EE8")]
	private static quaternion approxGivensQuat(float3 pq, float4 mask) { }

	[Address(RVA = "0x2B2BAB0", Offset = "0x2B2AEB0", Length = "0x72")]
	[Token(Token = "0x6001EE5")]
	private static void condNegSwap(bool c, ref float3 x, ref float3 y) { }

	[Address(RVA = "0x2B2B890", Offset = "0x2B2AC90", Length = "0x21C")]
	[Token(Token = "0x6001EE6")]
	private static quaternion condNegSwapQuat(bool c, quaternion q, float4 mask) { }

	[Address(RVA = "0x2B2BB30", Offset = "0x2B2AF30", Length = "0x1E")]
	[Token(Token = "0x6001EE4")]
	private static void condSwap(bool c, ref float x, ref float y) { }

	[Address(RVA = "0x2A1FE70", Offset = "0x2A1F270", Length = "0x5CC")]
	[Token(Token = "0x6001EEA")]
	private static quaternion givensQRFactorization(float3x3 b, out float3x3 r) { }

	[Address(RVA = "0x2B2BB50", Offset = "0x2B2AF50", Length = "0xD38")]
	[Token(Token = "0x6001EEB")]
	private static quaternion jacobiIteration(ref float3x3 s, int iterations = 5) { }

	[Address(RVA = "0x2A20440", Offset = "0x2A1F840", Length = "0x49B")]
	[Token(Token = "0x6001EE9")]
	private static quaternion qrGivensQuat(float2 pq, float4 mask) { }

	[Address(RVA = "0x2B2C890", Offset = "0x2B2BC90", Length = "0xF9")]
	[Token(Token = "0x6001EED")]
	private static float3 rcpsafe(float3 x, float epsilon = 1E-09) { }

	[Address(RVA = "0x2B2C990", Offset = "0x2B2BD90", Length = "0x2FE")]
	[Token(Token = "0x6001EEC")]
	private static float3 singularValuesDecomposition(float3x3 a, out quaternion u, out quaternion v) { }

	[Address(RVA = "0x2A208E0", Offset = "0x2A1FCE0", Length = "0x2EE")]
	[Token(Token = "0x6001EE7")]
	private static void sortSingularValues(ref float3x3 b, ref quaternion v) { }

	[Address(RVA = "0x2A20BD0", Offset = "0x2A1FFD0", Length = "0x2D2")]
	[Token(Token = "0x6001EEE")]
	public static float3x3 svdInverse(float3x3 a) { }

	[Address(RVA = "0x2A20EB0", Offset = "0x2A202B0", Length = "0x1DF")]
	[Token(Token = "0x6001EEF")]
	public static quaternion svdRotation(float3x3 a) { }

}

