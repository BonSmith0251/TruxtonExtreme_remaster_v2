namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000094")]
internal class DecalUpdateCulledSystem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F1")]
	private DecalEntityManager m_EntityManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002F2")]
	private ProfilingSampler m_Sampler; //Field offset: 0x18

	[Address(RVA = "0x2D80710", Offset = "0x2D7FB10", Length = "0x8D")]
	[Token(Token = "0x6000364")]
	public DecalUpdateCulledSystem(DecalEntityManager entityManager) { }

	[Address(RVA = "0x2D804A0", Offset = "0x2D7F8A0", Length = "0x1C1")]
	[Token(Token = "0x6000365")]
	public void Execute() { }

	[Address(RVA = "0x2D80670", Offset = "0x2D7FA70", Length = "0x99")]
	[Token(Token = "0x6000366")]
	private void Execute(DecalCulledChunk culledChunk, int count) { }

}

