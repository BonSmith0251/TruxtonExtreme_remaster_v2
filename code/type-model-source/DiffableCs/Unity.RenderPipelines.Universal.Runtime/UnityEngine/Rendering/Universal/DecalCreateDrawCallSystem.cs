namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000086")]
internal class DecalCreateDrawCallSystem
{
	[BurstCompile]
	[Token(Token = "0x2000087")]
	private struct DrawCallJob : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x400028A")]
		public NativeArray<float4x4> decalToWorlds; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x400028B")]
		public NativeArray<float4x4> normalToWorlds; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[Token(Token = "0x400028C")]
		public NativeArray<float4x4> sizeOffsets; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[ReadOnly]
		[Token(Token = "0x400028D")]
		public NativeArray<float2> drawDistances; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[ReadOnly]
		[Token(Token = "0x400028E")]
		public NativeArray<float2> angleFades; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[ReadOnly]
		[Token(Token = "0x400028F")]
		public NativeArray<float4> uvScaleBiases; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[ReadOnly]
		[Token(Token = "0x4000290")]
		public NativeArray<Int32> layerMasks; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[ReadOnly]
		[Token(Token = "0x4000291")]
		public NativeArray<UInt64> sceneLayerMasks; //Field offset: 0x70
		[FieldOffset(Offset = "0x80")]
		[ReadOnly]
		[Token(Token = "0x4000292")]
		public NativeArray<Single> fadeFactors; //Field offset: 0x80
		[FieldOffset(Offset = "0x90")]
		[ReadOnly]
		[Token(Token = "0x4000293")]
		public NativeArray<BoundingSphere> boundingSpheres; //Field offset: 0x90
		[FieldOffset(Offset = "0xA0")]
		[ReadOnly]
		[Token(Token = "0x4000294")]
		public NativeArray<UInt32> renderingLayerMasks; //Field offset: 0xA0
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000295")]
		public Vector3 cameraPosition; //Field offset: 0xB0
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000296")]
		public ulong sceneCullingMask; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000297")]
		public int cullingMask; //Field offset: 0xC8
		[FieldOffset(Offset = "0xD0")]
		[ReadOnly]
		[Token(Token = "0x4000298")]
		public NativeArray<Int32> visibleDecalIndices; //Field offset: 0xD0
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4000299")]
		public int visibleDecalCount; //Field offset: 0xE0
		[FieldOffset(Offset = "0xE4")]
		[Token(Token = "0x400029A")]
		public float maxDrawDistance; //Field offset: 0xE4
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x400029B")]
		[WriteOnly]
		public NativeArray<float4x4> decalToWorldsDraw; //Field offset: 0xE8
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x400029C")]
		[WriteOnly]
		public NativeArray<float4x4> normalToDecalsDraw; //Field offset: 0xF8
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x400029D")]
		[WriteOnly]
		public NativeArray<Single> renderingLayerMasksDraw; //Field offset: 0x108
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x400029E")]
		[WriteOnly]
		public NativeArray<DecalSubDrawCall> subCalls; //Field offset: 0x118
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x400029F")]
		[WriteOnly]
		public NativeArray<Int32> subCallCount; //Field offset: 0x128

		[Address(RVA = "0x2D80DA0", Offset = "0x2D801A0", Length = "0x474")]
		[Token(Token = "0x600032A")]
		public override void Execute() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000287")]
	private DecalEntityManager m_EntityManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000288")]
	private ProfilingSampler m_Sampler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000289")]
	private float m_MaxDrawDistance; //Field offset: 0x20

	[Token(Token = "0x170000DD")]
	public float maxDrawDistance
	{
		[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
		[Token(Token = "0x6000325")]
		 get { } //Length: 6
		[Address(RVA = "0x1D719C0", Offset = "0x1D70DC0", Length = "0x6")]
		[Token(Token = "0x6000326")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2D74CD0", Offset = "0x2D740D0", Length = "0xA0")]
	[Token(Token = "0x6000327")]
	public DecalCreateDrawCallSystem(DecalEntityManager entityManager, float maxDrawDistance) { }

	[Address(RVA = "0x2D74680", Offset = "0x2D73A80", Length = "0x417")]
	[Token(Token = "0x6000328")]
	public void Execute() { }

	[Address(RVA = "0x2D74AA0", Offset = "0x2D73EA0", Length = "0x22D")]
	[Token(Token = "0x6000329")]
	private void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, DecalDrawCallChunk drawCallChunk, int count) { }

	[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
	[Token(Token = "0x6000325")]
	public float get_maxDrawDistance() { }

	[Address(RVA = "0x1D719C0", Offset = "0x1D70DC0", Length = "0x6")]
	[Token(Token = "0x6000326")]
	public void set_maxDrawDistance(float value) { }

}

