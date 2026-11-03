namespace UnityEngine.UI;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use IMeshModifier instead", True)]
[Token(Token = "0x2000084")]
public interface IVertexModifier
{

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", True)]
	[Token(Token = "0x600053C")]
	public void ModifyVertices(List<UIVertex> verts) { }

}

