namespace UnityEngine.UI;

[Token(Token = "0x2000085")]
public interface IMeshModifier
{

	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", False)]
	[Token(Token = "0x600053D")]
	public void ModifyMesh(Mesh mesh) { }

	[Token(Token = "0x600053E")]
	public void ModifyMesh(VertexHelper verts) { }

}

