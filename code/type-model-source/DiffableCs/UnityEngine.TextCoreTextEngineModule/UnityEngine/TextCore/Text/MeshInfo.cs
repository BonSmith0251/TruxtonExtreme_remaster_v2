namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200002A")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct MeshInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000FC")]
	public int vertexCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000FD")]
	public TextCoreVertex[] vertexData; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000FE")]
	public Material material; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Ignore]
	[Token(Token = "0x40000FF")]
	public int vertexBufferSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Ignore]
	[Token(Token = "0x4000100")]
	public bool applySDF; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000101")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal GlyphRenderMode glyphRenderMode; //Field offset: 0x20

	[Address(RVA = "0x3183C50", Offset = "0x3183050", Length = "0xAE")]
	[Token(Token = "0x6000086")]
	public MeshInfo(int size, bool isIMGUI) { }

	[Address(RVA = "0x3183B90", Offset = "0x3182F90", Length = "0x46")]
	[Token(Token = "0x6000088")]
	internal void Clear(bool uploadChanges) { }

	[Address(RVA = "0x3183B40", Offset = "0x3182F40", Length = "0x46")]
	[Token(Token = "0x6000089")]
	internal void ClearUnusedVertices() { }

	[Address(RVA = "0x3183BE0", Offset = "0x3182FE0", Length = "0x6C")]
	[Token(Token = "0x6000087")]
	internal void ResizeMeshInfo(int size, bool isIMGUI) { }

}

