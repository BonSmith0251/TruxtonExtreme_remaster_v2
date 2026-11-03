namespace TMPro;

[Token(Token = "0x20000AC")]
public class TMP_TextInfo
{
	[Token(Token = "0x4000645")]
	internal static Vector2 k_InfinityVectorPositive; //Field offset: 0x0
	[Token(Token = "0x4000646")]
	internal static Vector2 k_InfinityVectorNegative; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000647")]
	public TMP_Text textComponent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000648")]
	public int characterCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000649")]
	public int spriteCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400064A")]
	public int spaceCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400064B")]
	public int wordCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400064C")]
	public int linkCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400064D")]
	public int lineCount; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400064E")]
	public int pageCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400064F")]
	public int materialCount; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000650")]
	public TMP_CharacterInfo[] characterInfo; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000651")]
	public TMP_WordInfo[] wordInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000652")]
	public TMP_LinkInfo[] linkInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000653")]
	public TMP_LineInfo[] lineInfo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000654")]
	public TMP_PageInfo[] pageInfo; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000655")]
	public TMP_MeshInfo[] meshInfo; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000656")]
	private TMP_MeshInfo[] m_CachedMeshInfo; //Field offset: 0x68

	[Address(RVA = "0x2F17060", Offset = "0x2F16460", Length = "0x5C")]
	[Token(Token = "0x6000695")]
	private static TMP_TextInfo() { }

	[Address(RVA = "0x2F170C0", Offset = "0x2F164C0", Length = "0x133")]
	[Token(Token = "0x6000687")]
	public TMP_TextInfo() { }

	[Address(RVA = "0x2F173B0", Offset = "0x2F167B0", Length = "0x13B")]
	[Token(Token = "0x6000688")]
	internal TMP_TextInfo(int characterCount) { }

	[Address(RVA = "0x2F17200", Offset = "0x2F16600", Length = "0x1A6")]
	[Token(Token = "0x6000689")]
	public TMP_TextInfo(TMP_Text textComponent) { }

	[Address(RVA = "0x2F16A00", Offset = "0x2F15E00", Length = "0x6D")]
	[Token(Token = "0x600068A")]
	internal void Clear() { }

	[Address(RVA = "0x2F162A0", Offset = "0x2F156A0", Length = "0x146")]
	[Token(Token = "0x600068B")]
	internal void ClearAllData() { }

	[Address(RVA = "0x2F163F0", Offset = "0x2F157F0", Length = "0xAE")]
	[Token(Token = "0x600068D")]
	public void ClearAllMeshInfo() { }

	[Address(RVA = "0x2F164A0", Offset = "0x2F158A0", Length = "0x2D2")]
	[Token(Token = "0x6000690")]
	internal void ClearLineInfo() { }

	[Address(RVA = "0x2F16780", Offset = "0x2F15B80", Length = "0xBB")]
	[Token(Token = "0x600068C")]
	public void ClearMeshInfo(bool updateMesh) { }

	[Address(RVA = "0x2F16840", Offset = "0x2F15C40", Length = "0xF4")]
	[Token(Token = "0x6000691")]
	internal void ClearPageInfo() { }

	[Address(RVA = "0x2F16940", Offset = "0x2F15D40", Length = "0xBD")]
	[Token(Token = "0x600068F")]
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	[Address(RVA = "0x2F16A70", Offset = "0x2F15E70", Length = "0x52F")]
	[Token(Token = "0x6000692")]
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	[Address(RVA = "0x2F16FA0", Offset = "0x2F163A0", Length = "0xBA")]
	[Token(Token = "0x600068E")]
	public void ResetVertexLayout(bool isVolumetric) { }

	[Address(RVA = "0x93F9D0", Offset = "0x93EDD0", Length = "0x7C")]
	[Token(Token = "0x6000693")]
	public static void Resize(ref T[] array, int size) { }

	[Address(RVA = "0x93FA50", Offset = "0x93EE50", Length = "0xA4")]
	[Token(Token = "0x6000694")]
	public static void Resize(ref T[] array, int size, bool isBlockAllocated) { }

}

