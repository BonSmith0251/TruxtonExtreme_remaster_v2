namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000076")]
internal class DecalDrawFowardEmissiveSystem : DecalDrawSystem
{

	[Address(RVA = "0x2D75340", Offset = "0x2D74740", Length = "0x6C")]
	[Token(Token = "0x60002C2")]
	public DecalDrawFowardEmissiveSystem(DecalEntityManager entityManager) { }

	[Address(RVA = "0x2D75320", Offset = "0x2D74720", Length = "0x16")]
	[Token(Token = "0x60002C3")]
	protected virtual int GetPassIndex(DecalCachedChunk decalCachedChunk) { }

}

