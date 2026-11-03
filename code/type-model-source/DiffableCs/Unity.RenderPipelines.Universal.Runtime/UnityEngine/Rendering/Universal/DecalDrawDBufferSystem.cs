namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000072")]
internal class DecalDrawDBufferSystem : DecalDrawSystem
{

	[Address(RVA = "0x2D751A0", Offset = "0x2D745A0", Length = "0x6C")]
	[Token(Token = "0x60002B4")]
	public DecalDrawDBufferSystem(DecalEntityManager entityManager) { }

	[Address(RVA = "0x2D75180", Offset = "0x2D74580", Length = "0x16")]
	[Token(Token = "0x60002B5")]
	protected virtual int GetPassIndex(DecalCachedChunk decalCachedChunk) { }

}

