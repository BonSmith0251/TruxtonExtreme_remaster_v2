namespace TMPro;

[Token(Token = "0x2000014")]
public struct MaterialReference
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002A")]
	public int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400002B")]
	public TMP_FontAsset fontAsset; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002C")]
	public TMP_SpriteAsset spriteAsset; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002D")]
	public Material material; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002E")]
	public bool isDefaultMaterial; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x400002F")]
	public bool isFallbackMaterial; //Field offset: 0x21
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000030")]
	public Material fallbackMaterial; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000031")]
	public float padding; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000032")]
	public int referenceCount; //Field offset: 0x34

	[Address(RVA = "0x2E99C40", Offset = "0x2E99040", Length = "0xB8")]
	[Token(Token = "0x600004D")]
	public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding) { }

	[Address(RVA = "0x2E998D0", Offset = "0x2E98CD0", Length = "0x274")]
	[Token(Token = "0x600004F")]
	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<Int32, Int32> materialReferenceIndexLookup) { }

	[Address(RVA = "0x2E99670", Offset = "0x2E98A70", Length = "0x254")]
	[Token(Token = "0x6000050")]
	public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<Int32, Int32> materialReferenceIndexLookup) { }

	[Address(RVA = "0x2E99B50", Offset = "0x2E98F50", Length = "0xE3")]
	[Token(Token = "0x600004E")]
	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

}

