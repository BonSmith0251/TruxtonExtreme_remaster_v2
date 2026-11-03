namespace UnityEngine.Rendering.UnifiedRayTracing;

[BurstCompile]
[Token(Token = "0x200003D")]
internal struct ComputeTerrainMeshJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000179")]
	public NativeArray<Single> heightmap; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400017A")]
	public NativeArray<Boolean> holes; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400017B")]
	public int width; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400017C")]
	public int height; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400017D")]
	public float3 heightmapScale; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017E")]
	public NativeArray<float3> positions; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400017F")]
	public NativeArray<float2> uvs; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000180")]
	public NativeArray<float3> normals; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[NativeDisableParallelForRestriction]
	[Token(Token = "0x4000181")]
	public NativeArray<Int32> indices; //Field offset: 0x68

	[Address(RVA = "0x2F56590", Offset = "0x2F55990", Length = "0x408")]
	[Token(Token = "0x60000CA")]
	private static float3 CalculateTerrainNormal(NativeArray<Single> heightmap, int x, int y, int width, int height, float3 scale) { }

	[Address(RVA = "0x2F569A0", Offset = "0x2F55DA0", Length = "0xB9")]
	[Token(Token = "0x60000C8")]
	public void DisposeArrays() { }

	[Address(RVA = "0x2F56A60", Offset = "0x2F55E60", Length = "0x1DE")]
	[Token(Token = "0x60000C9")]
	public override void Execute(int index) { }

	[Address(RVA = "0x2F56C40", Offset = "0x2F56040", Length = "0x42")]
	[Token(Token = "0x60000CB")]
	private static float SampleHeight(int x, int y, int width, int height, NativeArray<Single> heightmap, float scale) { }

}

