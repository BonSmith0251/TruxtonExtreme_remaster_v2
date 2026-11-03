namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200059E")]
internal class EntryRecorder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400137C")]
	private EntryPool m_EntryPool; //Field offset: 0x10

	[Address(RVA = "0x32F6260", Offset = "0x32F5660", Length = "0x72")]
	[Token(Token = "0x600288D")]
	public EntryRecorder(EntryPool entryPool) { }

	[Address(RVA = "0x32F5990", Offset = "0x32F4D90", Length = "0xDC")]
	[Token(Token = "0x60028A3")]
	private static void Append(Entry parentEntry, Entry entry) { }

	[Address(RVA = "0x32F57B0", Offset = "0x32F4BB0", Length = "0x1D3")]
	[Token(Token = "0x60028A2")]
	private static void AppendMeshEntry(Entry parentEntry, Entry entry) { }

	[Address(RVA = "0x32F5A70", Offset = "0x32F4E70", Length = "0x3C")]
	[Token(Token = "0x6002895")]
	public void BeginStencilMask(Entry parentEntry) { }

	[Address(RVA = "0x32F5AB0", Offset = "0x32F4EB0", Length = "0x3C")]
	[Token(Token = "0x60028A0")]
	public void CutRenderChain(Entry parentEntry) { }

	[Address(RVA = "0x32F5AF0", Offset = "0x32F4EF0", Length = "0x3C")]
	[Token(Token = "0x6002894")]
	public void DrawChildren(Entry parentEntry) { }

	[Address(RVA = "0x32F5B30", Offset = "0x32F4F30", Length = "0x82")]
	[Token(Token = "0x6002892")]
	public void DrawGradients(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, VectorImage gradientsOwner) { }

	[Address(RVA = "0x32F5BC0", Offset = "0x32F4FC0", Length = "0x75")]
	[Token(Token = "0x6002893")]
	public void DrawImmediate(Entry parentEntry, Action callback, bool cullingEnabled) { }

	[Address(RVA = "0x32F5D00", Offset = "0x32F5100", Length = "0xFC")]
	[Token(Token = "0x600288F")]
	public void DrawMesh(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, TextureId textureId, bool isPremultiplied = false) { }

	[Address(RVA = "0x32F5C40", Offset = "0x32F5040", Length = "0xB2")]
	[Token(Token = "0x600288E")]
	public void DrawMesh(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture, TextureOptions textureOptions = 0) { }

	[Address(RVA = "0x32F5E00", Offset = "0x32F5200", Length = "0x9D")]
	[Token(Token = "0x6002890")]
	public void DrawRasterText(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture, bool multiChannel) { }

	[Address(RVA = "0x32F5EA0", Offset = "0x32F52A0", Length = "0x99")]
	[Token(Token = "0x6002891")]
	public void DrawSdfText(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture, float scale, float sharpness) { }

	[Address(RVA = "0x32F5F40", Offset = "0x32F5340", Length = "0x3C")]
	[Token(Token = "0x6002896")]
	public void EndStencilMask(Entry parentEntry) { }

	[Address(RVA = "0x32F5F80", Offset = "0x32F5380", Length = "0x4C")]
	[Token(Token = "0x60028A1")]
	public Entry InsertPlaceholder(Entry parentEntry) { }

	[Address(RVA = "0x32F5FD0", Offset = "0x32F53D0", Length = "0x3C")]
	[Token(Token = "0x6002899")]
	public void PopClippingRect(Entry parentEntry) { }

	[Address(RVA = "0x32F6010", Offset = "0x32F5410", Length = "0x3C")]
	[Token(Token = "0x600289F")]
	public void PopDefaultMaterial(Entry parentEntry) { }

	[Address(RVA = "0x32F6050", Offset = "0x32F5450", Length = "0x3C")]
	[Token(Token = "0x600289D")]
	public void PopGroupMatrix(Entry parentEntry) { }

	[Address(RVA = "0x32F6090", Offset = "0x32F5490", Length = "0x3C")]
	[Token(Token = "0x600289B")]
	public void PopScissors(Entry parentEntry) { }

	[Address(RVA = "0x32F60D0", Offset = "0x32F54D0", Length = "0x3C")]
	[Token(Token = "0x6002897")]
	public void PopStencilMask(Entry parentEntry) { }

	[Address(RVA = "0x32F6110", Offset = "0x32F5510", Length = "0x3C")]
	[Token(Token = "0x6002898")]
	public void PushClippingRect(Entry parentEntry) { }

	[Address(RVA = "0x32F6150", Offset = "0x32F5550", Length = "0x8A")]
	[Token(Token = "0x600289E")]
	public void PushDefaultMaterial(Entry parentEntry, MaterialDefinition matDef) { }

	[Address(RVA = "0x32F61E0", Offset = "0x32F55E0", Length = "0x3C")]
	[Token(Token = "0x600289C")]
	public void PushGroupMatrix(Entry parentEntry) { }

	[Address(RVA = "0x32F6220", Offset = "0x32F5620", Length = "0x3C")]
	[Token(Token = "0x600289A")]
	public void PushScissors(Entry parentEntry) { }

}

