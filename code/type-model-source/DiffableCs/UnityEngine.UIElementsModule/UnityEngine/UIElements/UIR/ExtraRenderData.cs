namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005BF")]
internal class ExtraRenderData : LinkedPoolItem<ExtraRenderData>
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400145C")]
	public BasicNode<MeshHandle> extraMesh; //Field offset: 0x18

	[Address(RVA = "0x3303960", Offset = "0x3302D60", Length = "0x39")]
	[Token(Token = "0x6002938")]
	public ExtraRenderData() { }

}

