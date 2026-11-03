namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000092")]
internal class DecalUpdateCachedSystem
{
	[BurstCompile]
	[Token(Token = "0x2000093")]
	internal struct UpdateTransformsJob : IJobParallelForTransform
	{
		[Token(Token = "0x40002E6")]
		private static readonly quaternion k_MinusYtoZRotation; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E7")]
		public NativeArray<float3> positions; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002E8")]
		public NativeArray<quaternion> rotations; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002E9")]
		public NativeArray<float3> scales; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002EA")]
		public NativeArray<Boolean> dirty; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[ReadOnly]
		[Token(Token = "0x40002EB")]
		public NativeArray<DecalScaleMode> scaleModes; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[ReadOnly]
		[Token(Token = "0x40002EC")]
		public NativeArray<float4x4> sizeOffsets; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40002ED")]
		[WriteOnly]
		public NativeArray<float4x4> decalToWorlds; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40002EE")]
		[WriteOnly]
		public NativeArray<float4x4> normalToWorlds; //Field offset: 0x70
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40002EF")]
		[WriteOnly]
		public NativeArray<BoundingSphere> boundingSpheres; //Field offset: 0x80
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40002F0")]
		public float minDistance; //Field offset: 0x90

		[Address(RVA = "0x2D8B910", Offset = "0x2D8AD10", Length = "0xBE")]
		[Token(Token = "0x6000363")]
		private static UpdateTransformsJob() { }

		[Address(RVA = "0x2D8AD60", Offset = "0x2D8A160", Length = "0x5E")]
		[Token(Token = "0x6000360")]
		private float DistanceBetweenQuaternions(quaternion a, quaternion b) { }

		[Address(RVA = "0x2D8ADC0", Offset = "0x2D8A1C0", Length = "0x8B2")]
		[Token(Token = "0x6000361")]
		public override void Execute(int index, TransformAccess transform) { }

		[Address(RVA = "0x2D8B680", Offset = "0x2D8AA80", Length = "0x290")]
		[Token(Token = "0x6000362")]
		private BoundingSphere GetDecalProjectBoundingSphere(Matrix4x4 decalToWorld) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002E3")]
	private DecalEntityManager m_EntityManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002E4")]
	private ProfilingSampler m_Sampler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E5")]
	private ProfilingSampler m_SamplerJob; //Field offset: 0x20

	[Address(RVA = "0x2D803D0", Offset = "0x2D7F7D0", Length = "0xCA")]
	[Token(Token = "0x600035D")]
	public DecalUpdateCachedSystem(DecalEntityManager entityManager) { }

	[Address(RVA = "0x2D80250", Offset = "0x2D7F650", Length = "0x17D")]
	[Token(Token = "0x600035E")]
	public void Execute() { }

	[Address(RVA = "0x2D7FF60", Offset = "0x2D7F360", Length = "0x2E3")]
	[Token(Token = "0x600035F")]
	private void Execute(DecalEntityChunk entityChunk, DecalCachedChunk cachedChunk, int count) { }

}

