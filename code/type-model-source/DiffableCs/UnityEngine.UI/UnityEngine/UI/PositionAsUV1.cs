namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Effects/Position As UV1", 82)]
[Token(Token = "0x2000087")]
public class PositionAsUV1 : BaseMeshEffect
{

	[Address(RVA = "0x21C5A40", Offset = "0x21C4E40", Length = "0x7")]
	[Token(Token = "0x6000541")]
	protected PositionAsUV1() { }

	[Address(RVA = "0x346F5F0", Offset = "0x346E9F0", Length = "0x11C")]
	[Token(Token = "0x6000542")]
	public virtual void ModifyMesh(VertexHelper vh) { }

}

