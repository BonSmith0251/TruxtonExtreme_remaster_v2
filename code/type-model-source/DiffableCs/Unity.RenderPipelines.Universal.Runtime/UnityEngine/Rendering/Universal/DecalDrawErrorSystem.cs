namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200007A")]
internal class DecalDrawErrorSystem : DecalDrawSystem
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000242")]
	private DecalTechnique m_Technique; //Field offset: 0x40

	[Address(RVA = "0x2D752A0", Offset = "0x2D746A0", Length = "0x7D")]
	[Token(Token = "0x60002CD")]
	public DecalDrawErrorSystem(DecalEntityManager entityManager, DecalTechnique technique) { }

	[Address(RVA = "0x2D75210", Offset = "0x2D74610", Length = "0x1D")]
	[Token(Token = "0x60002CF")]
	protected virtual Material GetMaterial(DecalEntityChunk decalEntityChunk) { }

	[Address(RVA = "0x2D75230", Offset = "0x2D74630", Length = "0x64")]
	[Token(Token = "0x60002CE")]
	protected virtual int GetPassIndex(DecalCachedChunk decalCachedChunk) { }

}

