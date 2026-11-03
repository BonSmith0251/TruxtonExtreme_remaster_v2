namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Effects/Outline", 81)]
[Token(Token = "0x2000086")]
public class Outline : Shadow
{

	[Address(RVA = "0x344BCF0", Offset = "0x344B0F0", Length = "0x7")]
	[Token(Token = "0x600053F")]
	protected Outline() { }

	[Address(RVA = "0x344B980", Offset = "0x344AD80", Length = "0x36D")]
	[Token(Token = "0x6000540")]
	public virtual void ModifyMesh(VertexHelper vh) { }

}

