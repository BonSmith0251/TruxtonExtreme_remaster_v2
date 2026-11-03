namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000051")]
public struct Random
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000137")]
	public uint state; //Field offset: 0x0

	[Address(RVA = "0x2B27ED0", Offset = "0x2B272D0", Length = "0x18")]
	[Token(Token = "0x6001E84")]
	public Random(uint seed) { }

	[Address(RVA = "0x2B27E30", Offset = "0x2B27230", Length = "0x60")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x6001EC3")]
	private static void CheckIndexForHash(uint index) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x6001EC2")]
	private void CheckInitState() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x6001EC5")]
	private void CheckNextIntMax(int max) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x6001EC6")]
	private void CheckNextIntMinMax(int min, int max) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x6001EC7")]
	private void CheckNextUIntMinMax(uint min, uint max) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x6001EC4")]
	private void CheckState() { }

	[Address(RVA = "0x2B27E90", Offset = "0x2B27290", Length = "0x3C")]
	[Token(Token = "0x6001E85")]
	public static Random CreateFromIndex(uint index) { }

	[Address(RVA = "0x2B27ED0", Offset = "0x2B272D0", Length = "0x18")]
	[Token(Token = "0x6001E87")]
	public void InitState(uint seed = 1851936439) { }

	[Address(RVA = "0x2B28040", Offset = "0x2B27440", Length = "0x21")]
	[Token(Token = "0x6001E88")]
	public bool NextBool() { }

	[Address(RVA = "0x2B27EF0", Offset = "0x2B272F0", Length = "0x87")]
	[Token(Token = "0x6001E89")]
	public bool2 NextBool2() { }

	[Address(RVA = "0x2B27F80", Offset = "0x2B27380", Length = "0x55")]
	[Token(Token = "0x6001E8A")]
	public bool3 NextBool3() { }

	[Address(RVA = "0x2B27FE0", Offset = "0x2B273E0", Length = "0x58")]
	[Token(Token = "0x6001E8B")]
	public bool4 NextBool4() { }

	[Address(RVA = "0x2B28780", Offset = "0x2B27B80", Length = "0x60")]
	[Token(Token = "0x6001EB0")]
	public double NextDouble() { }

	[Address(RVA = "0x2B287E0", Offset = "0x2B27BE0", Length = "0x64")]
	[Token(Token = "0x6001EB4")]
	public double NextDouble(double max) { }

	[Address(RVA = "0x2B28710", Offset = "0x2B27B10", Length = "0x6C")]
	[Token(Token = "0x6001EB8")]
	public double NextDouble(double min, double max) { }

	[Address(RVA = "0x2B28180", Offset = "0x2B27580", Length = "0xE5")]
	[Token(Token = "0x6001EB5")]
	public double2 NextDouble2(double2 max) { }

	[Address(RVA = "0x2B28270", Offset = "0x2B27670", Length = "0xC9")]
	[Token(Token = "0x6001EB1")]
	public double2 NextDouble2() { }

	[Address(RVA = "0x2B28340", Offset = "0x2B27740", Length = "0x118")]
	[Token(Token = "0x6001EB9")]
	public double2 NextDouble2(double2 min, double2 max) { }

	[Address(RVA = "0x2B28070", Offset = "0x2B27470", Length = "0x10E")]
	[Token(Token = "0x6001EBD")]
	public double2 NextDouble2Direction() { }

	[Address(RVA = "0x2B28460", Offset = "0x2B27860", Length = "0x64")]
	[Token(Token = "0x6001EB6")]
	public double3 NextDouble3(double3 max) { }

	[Address(RVA = "0x2B25720", Offset = "0x2B24B20", Length = "0x12E")]
	[Token(Token = "0x6001EB2")]
	public double3 NextDouble3() { }

	[Address(RVA = "0x2B284D0", Offset = "0x2B278D0", Length = "0xC5")]
	[Token(Token = "0x6001EBA")]
	public double3 NextDouble3(double3 min, double3 max) { }

	[Address(RVA = "0x2B25500", Offset = "0x2B24900", Length = "0x21C")]
	[Token(Token = "0x6001EBF")]
	public double3 NextDouble3Direction() { }

	[Address(RVA = "0x2B28690", Offset = "0x2B27A90", Length = "0x78")]
	[Token(Token = "0x6001EB7")]
	public double4 NextDouble4(double4 max) { }

	[Address(RVA = "0x2B285A0", Offset = "0x2B279A0", Length = "0xED")]
	[Token(Token = "0x6001EBB")]
	public double4 NextDouble4(double4 min, double4 max) { }

	[Address(RVA = "0x2B25850", Offset = "0x2B24C50", Length = "0x172")]
	[Token(Token = "0x6001EB3")]
	public double4 NextDouble4() { }

	[Address(RVA = "0x2B28FF0", Offset = "0x2B283F0", Length = "0x41")]
	[Token(Token = "0x6001EAC")]
	public float NextFloat(float min, float max) { }

	[Address(RVA = "0x2B29040", Offset = "0x2B28440", Length = "0x35")]
	[Token(Token = "0x6001EA4")]
	public float NextFloat() { }

	[Address(RVA = "0x2B28FB0", Offset = "0x2B283B0", Length = "0x39")]
	[Token(Token = "0x6001EA8")]
	public float NextFloat(float max) { }

	[Address(RVA = "0x2B28AE0", Offset = "0x2B27EE0", Length = "0xA0")]
	[Token(Token = "0x6001EA5")]
	public float2 NextFloat2() { }

	[Address(RVA = "0x2B28940", Offset = "0x2B27D40", Length = "0xDB")]
	[Token(Token = "0x6001EAD")]
	public float2 NextFloat2(float2 min, float2 max) { }

	[Address(RVA = "0x2B28A20", Offset = "0x2B27E20", Length = "0xB7")]
	[Token(Token = "0x6001EA9")]
	public float2 NextFloat2(float2 max) { }

	[Address(RVA = "0x2B28850", Offset = "0x2B27C50", Length = "0xE5")]
	[Token(Token = "0x6001EBC")]
	public float2 NextFloat2Direction() { }

	[Address(RVA = "0x2B28C30", Offset = "0x2B28030", Length = "0xD9")]
	[Token(Token = "0x6001EAA")]
	public float3 NextFloat3(float3 max) { }

	[Address(RVA = "0x2B28D10", Offset = "0x2B28110", Length = "0x10E")]
	[Token(Token = "0x6001EAE")]
	public float3 NextFloat3(float3 min, float3 max) { }

	[Address(RVA = "0x2B28B80", Offset = "0x2B27F80", Length = "0xB0")]
	[Token(Token = "0x6001EA6")]
	public float3 NextFloat3() { }

	[Address(RVA = "0x2B259D0", Offset = "0x2B24DD0", Length = "0x1B4")]
	[Token(Token = "0x6001EBE")]
	public float3 NextFloat3Direction() { }

	[Address(RVA = "0x2B28F20", Offset = "0x2B28320", Length = "0x86")]
	[Token(Token = "0x6001EAB")]
	public float4 NextFloat4(float4 max) { }

	[Address(RVA = "0x2B28E20", Offset = "0x2B28220", Length = "0xFA")]
	[Token(Token = "0x6001EAF")]
	public float4 NextFloat4(float4 min, float4 max) { }

	[Address(RVA = "0x2B25B90", Offset = "0x2B24F90", Length = "0xF2")]
	[Token(Token = "0x6001EA7")]
	public float4 NextFloat4() { }

	[Address(RVA = "0x2B297D0", Offset = "0x2B28BD0", Length = "0x30")]
	[Token(Token = "0x6001E94")]
	public int NextInt(int min, int max) { }

	[Address(RVA = "0x2B29800", Offset = "0x2B28C00", Length = "0x2E")]
	[Token(Token = "0x6001E90")]
	public int NextInt(int max) { }

	[Address(RVA = "0x2B29830", Offset = "0x2B28C30", Length = "0x24")]
	[Token(Token = "0x6001E8C")]
	public int NextInt() { }

	[Address(RVA = "0x2B29170", Offset = "0x2B28570", Length = "0xDB")]
	[Token(Token = "0x6001E95")]
	public int2 NextInt2(int2 min, int2 max) { }

	[Address(RVA = "0x2B290F0", Offset = "0x2B284F0", Length = "0x71")]
	[Token(Token = "0x6001E8D")]
	public int2 NextInt2() { }

	[Address(RVA = "0x2B29080", Offset = "0x2B28480", Length = "0x66")]
	[Token(Token = "0x6001E91")]
	public int2 NextInt2(int2 max) { }

	[Address(RVA = "0x2B29390", Offset = "0x2B28790", Length = "0x124")]
	[Token(Token = "0x6001E96")]
	public int3 NextInt3(int3 min, int3 max) { }

	[Address(RVA = "0x2B29250", Offset = "0x2B28650", Length = "0xA9")]
	[Token(Token = "0x6001E92")]
	public int3 NextInt3(int3 max) { }

	[Address(RVA = "0x2B29300", Offset = "0x2B28700", Length = "0x8D")]
	[Token(Token = "0x6001E8E")]
	public int3 NextInt3() { }

	[Address(RVA = "0x2B294C0", Offset = "0x2B288C0", Length = "0x16D")]
	[Token(Token = "0x6001E97")]
	public int4 NextInt4(int4 min, int4 max) { }

	[Address(RVA = "0x2B29630", Offset = "0x2B28A30", Length = "0xDE")]
	[Token(Token = "0x6001E93")]
	public int4 NextInt4(int4 max) { }

	[Address(RVA = "0x2B29710", Offset = "0x2B28B10", Length = "0xB2")]
	[Token(Token = "0x6001E8F")]
	public int4 NextInt4() { }

	[Address(RVA = "0x2B25C90", Offset = "0x2B25090", Length = "0x4B4")]
	[Token(Token = "0x6001EC0")]
	public quaternion NextQuaternionRotation() { }

	[Address(RVA = "0x2B29860", Offset = "0x2B28C60", Length = "0x1F")]
	[Token(Token = "0x6001EC1")]
	private uint NextState() { }

	[Address(RVA = "0x2B29D20", Offset = "0x2B29120", Length = "0x21")]
	[Token(Token = "0x6001E98")]
	public uint NextUInt() { }

	[Address(RVA = "0x2B29CF0", Offset = "0x2B290F0", Length = "0x2D")]
	[Token(Token = "0x6001E9C")]
	public uint NextUInt(uint max) { }

	[Address(RVA = "0x2B297D0", Offset = "0x2B28BD0", Length = "0x30")]
	[Token(Token = "0x6001EA0")]
	public uint NextUInt(uint min, uint max) { }

	[Address(RVA = "0x2B299B0", Offset = "0x2B28DB0", Length = "0x6A")]
	[Token(Token = "0x6001E99")]
	public uint2 NextUInt2() { }

	[Address(RVA = "0x2B29880", Offset = "0x2B28C80", Length = "0x62")]
	[Token(Token = "0x6001E9D")]
	public uint2 NextUInt2(uint2 max) { }

	[Address(RVA = "0x2B298F0", Offset = "0x2B28CF0", Length = "0xC0")]
	[Token(Token = "0x6001EA1")]
	public uint2 NextUInt2(uint2 min, uint2 max) { }

	[Address(RVA = "0x2B29AD0", Offset = "0x2B28ED0", Length = "0x82")]
	[Token(Token = "0x6001E9A")]
	public uint3 NextUInt3() { }

	[Address(RVA = "0x2B29A20", Offset = "0x2B28E20", Length = "0xA6")]
	[Token(Token = "0x6001E9E")]
	public uint3 NextUInt3(uint3 max) { }

	[Address(RVA = "0x2B29390", Offset = "0x2B28790", Length = "0x124")]
	[Token(Token = "0x6001EA2")]
	public uint3 NextUInt3(uint3 min, uint3 max) { }

	[Address(RVA = "0x2B29B60", Offset = "0x2B28F60", Length = "0xA3")]
	[Token(Token = "0x6001E9B")]
	public uint4 NextUInt4() { }

	[Address(RVA = "0x2B29C10", Offset = "0x2B29010", Length = "0xDA")]
	[Token(Token = "0x6001E9F")]
	public uint4 NextUInt4(uint4 max) { }

	[Address(RVA = "0x2B294C0", Offset = "0x2B288C0", Length = "0x16D")]
	[Token(Token = "0x6001EA3")]
	public uint4 NextUInt4(uint4 min, uint4 max) { }

	[Address(RVA = "0x2B29D50", Offset = "0x2B29150", Length = "0x24")]
	[Token(Token = "0x6001E86")]
	internal static uint WangHash(uint n) { }

}

