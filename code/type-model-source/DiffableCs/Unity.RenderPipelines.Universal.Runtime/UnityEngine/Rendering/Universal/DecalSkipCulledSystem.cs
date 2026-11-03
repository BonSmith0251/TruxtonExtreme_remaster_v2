namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000090")]
internal class DecalSkipCulledSystem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002C8")]
	private DecalEntityManager m_EntityManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002C9")]
	private ProfilingSampler m_Sampler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002CA")]
	private Camera m_Camera; //Field offset: 0x20

	[Address(RVA = "0x2D7FEC0", Offset = "0x2D7F2C0", Length = "0x8D")]
	[Token(Token = "0x6000355")]
	public DecalSkipCulledSystem(DecalEntityManager entityManager) { }

	[Address(RVA = "0x2D7FBE0", Offset = "0x2D7EFE0", Length = "0x206")]
	[Token(Token = "0x6000356")]
	public void Execute(Camera camera) { }

	[Address(RVA = "0x2D7FDF0", Offset = "0x2D7F1F0", Length = "0xC1")]
	[Token(Token = "0x6000357")]
	private void Execute(DecalCulledChunk culledChunk, int count) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000358")]
	internal static ulong GetSceneCullingMaskFromCamera(Camera camera) { }

}

