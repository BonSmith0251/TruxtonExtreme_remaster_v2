namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200001A")]
internal class IntersectNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000059")]
	internal TEdge Edge1; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400005A")]
	internal TEdge Edge2; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400005B")]
	internal IntPoint Pt; //Field offset: 0x20

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000035")]
	public IntersectNode() { }

}

