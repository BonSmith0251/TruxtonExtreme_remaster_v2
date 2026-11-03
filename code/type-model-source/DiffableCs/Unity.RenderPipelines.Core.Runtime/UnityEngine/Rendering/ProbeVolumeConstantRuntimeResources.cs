namespace UnityEngine.Rendering;

[Token(Token = "0x2000132")]
internal static class ProbeVolumeConstantRuntimeResources
{
	[Token(Token = "0x40005C9")]
	private static ComputeBuffer m_SkySamplingDirectionsBuffer; //Field offset: 0x0
	[Token(Token = "0x40005CB")]
	private const int NB_SKY_PRECOMPUTED_DIRECTIONS = 255; //Field offset: 0x0
	[Token(Token = "0x40005CA")]
	private static ComputeBuffer m_AntiLeakDataBuffer; //Field offset: 0x8
	[Token(Token = "0x40005CC")]
	private static Vector3[] k_SkyDirections; //Field offset: 0x10
	[Token(Token = "0x40005CD")]
	private static UInt32[] k_AntiLeakData; //Field offset: 0x18

	[Address(RVA = "0x2C1AF90", Offset = "0x2C1A390", Length = "0x12D")]
	[Token(Token = "0x6000A99")]
	private static ProbeVolumeConstantRuntimeResources() { }

	[Address(RVA = "0x2C1A960", Offset = "0x2C19D60", Length = "0xE7")]
	[Token(Token = "0x6000A97")]
	internal static void Cleanup() { }

	[Address(RVA = "0x2C1AA50", Offset = "0x2C19E50", Length = "0x254")]
	[Token(Token = "0x6000A98")]
	private static Vector3[] GenerateSkyDirections() { }

	[Address(RVA = "0x2C1ACB0", Offset = "0x2C1A0B0", Length = "0x7F")]
	[Token(Token = "0x6000A94")]
	internal static void GetRuntimeResources(ref RuntimeResources rr) { }

	[Address(RVA = "0x2C1AD30", Offset = "0x2C1A130", Length = "0x4F")]
	[Token(Token = "0x6000A96")]
	public static Vector3[] GetSkySamplingDirections() { }

	[Address(RVA = "0x2C1AD80", Offset = "0x2C1A180", Length = "0x20C")]
	[Token(Token = "0x6000A95")]
	internal static void Initialize() { }

}

