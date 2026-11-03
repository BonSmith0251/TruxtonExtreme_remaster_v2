namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200057D")]
internal class DetachedAllocator : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001253")]
	private TempAllocator<Vertex> m_VertsPool; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001254")]
	private TempAllocator<UInt16> m_IndexPool; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001255")]
	private List<MeshWriteData> m_MeshWriteDataPool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001256")]
	private List<Int32> m_FillGradientMeshIndices; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001257")]
	private List<FillGradient> m_FillGradients; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001258")]
	private int m_FillGradientDataCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001259")]
	private List<Int32> m_FillTextureMeshIndices; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400125A")]
	private List<Texture> m_FillTextures; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400125B")]
	private int m_FillTextureDataCount; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400125C")]
	private int m_MeshWriteDataCount; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400125D")]
	private bool m_Disposed; //Field offset: 0x58

	[Address(RVA = "0x32DD420", Offset = "0x32DC820", Length = "0x253")]
	[Token(Token = "0x60027ED")]
	public DetachedAllocator() { }

	[Address(RVA = "0x32DD2E0", Offset = "0x32DC6E0", Length = "0xAA")]
	[Token(Token = "0x60027EE")]
	public override void Dispose() { }

	[Address(RVA = "0x32DD390", Offset = "0x32DC790", Length = "0x81")]
	[Token(Token = "0x60027EF")]
	protected void Dispose(bool disposing) { }

}

