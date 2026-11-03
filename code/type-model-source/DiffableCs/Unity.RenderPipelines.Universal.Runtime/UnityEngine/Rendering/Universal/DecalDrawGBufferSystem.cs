namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000097")]
internal class DecalDrawGBufferSystem : DecalDrawSystem
{

	[Address(RVA = "0x2D753D0", Offset = "0x2D747D0", Length = "0x6C")]
	[Token(Token = "0x6000371")]
	public DecalDrawGBufferSystem(DecalEntityManager entityManager) { }

	[Address(RVA = "0x2D753B0", Offset = "0x2D747B0", Length = "0x16")]
	[Token(Token = "0x6000372")]
	protected virtual int GetPassIndex(DecalCachedChunk decalCachedChunk) { }

}

