namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200009B")]
internal class DecalDrawScreenSpaceSystem : DecalDrawSystem
{

	[Address(RVA = "0x2D75460", Offset = "0x2D74860", Length = "0x6C")]
	[Token(Token = "0x600037D")]
	public DecalDrawScreenSpaceSystem(DecalEntityManager entityManager) { }

	[Address(RVA = "0x2D75440", Offset = "0x2D74840", Length = "0x16")]
	[Token(Token = "0x600037E")]
	protected virtual int GetPassIndex(DecalCachedChunk decalCachedChunk) { }

}

