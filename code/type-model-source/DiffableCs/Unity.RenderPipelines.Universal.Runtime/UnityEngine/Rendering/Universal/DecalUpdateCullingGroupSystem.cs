namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000096")]
internal class DecalUpdateCullingGroupSystem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002FA")]
	private Single[] m_BoundingDistance; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002FB")]
	private Camera m_Camera; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002FC")]
	private DecalEntityManager m_EntityManager; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002FD")]
	private ProfilingSampler m_Sampler; //Field offset: 0x28

	[Token(Token = "0x170000E1")]
	public float boundingDistance
	{
		[Address(RVA = "0x2D80D40", Offset = "0x2D80140", Length = "0x28")]
		[Token(Token = "0x600036B")]
		 get { } //Length: 40
		[Address(RVA = "0x2D80D70", Offset = "0x2D80170", Length = "0x28")]
		[Token(Token = "0x600036C")]
		 set { } //Length: 40
	}

	[Address(RVA = "0x2D80C50", Offset = "0x2D80050", Length = "0xE6")]
	[Token(Token = "0x600036D")]
	public DecalUpdateCullingGroupSystem(DecalEntityManager entityManager, float drawDistance) { }

	[Address(RVA = "0x2D807A0", Offset = "0x2D7FBA0", Length = "0x315")]
	[Token(Token = "0x600036E")]
	public void Execute(Camera camera) { }

	[Address(RVA = "0x2D80AC0", Offset = "0x2D7FEC0", Length = "0x18B")]
	[Token(Token = "0x600036F")]
	public void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, int count) { }

	[Address(RVA = "0x2D80D40", Offset = "0x2D80140", Length = "0x28")]
	[Token(Token = "0x600036B")]
	public float get_boundingDistance() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000370")]
	internal static ulong GetSceneCullingMaskFromCamera(Camera camera) { }

	[Address(RVA = "0x2D80D70", Offset = "0x2D80170", Length = "0x28")]
	[Token(Token = "0x600036C")]
	public void set_boundingDistance(float value) { }

}

