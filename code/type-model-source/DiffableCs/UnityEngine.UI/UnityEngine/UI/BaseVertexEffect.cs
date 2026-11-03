namespace UnityEngine.UI;

[Obsolete("Use BaseMeshEffect instead", True)]
[Token(Token = "0x2000082")]
public abstract class BaseVertexEffect
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000534")]
	protected BaseVertexEffect() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", True)]
	[Token(Token = "0x6000533")]
	public abstract void ModifyVertices(List<UIVertex> vertices) { }

}

