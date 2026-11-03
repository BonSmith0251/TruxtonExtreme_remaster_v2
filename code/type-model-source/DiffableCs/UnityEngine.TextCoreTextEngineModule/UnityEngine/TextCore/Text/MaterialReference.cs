namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000027")]
internal struct MaterialReference
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000EC")]
	public int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000ED")]
	public FontAsset fontAsset; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000EE")]
	public SpriteAsset spriteAsset; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000EF")]
	public Material material; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F0")]
	public bool isFallbackMaterial; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000F1")]
	public Material fallbackMaterial; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000F2")]
	public float padding; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000F3")]
	public int referenceCount; //Field offset: 0x34

	[Address(RVA = "0x3183AC0", Offset = "0x3182EC0", Length = "0x72")]
	[Token(Token = "0x6000071")]
	public MaterialReference(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding) { }

	[Address(RVA = "0x3183630", Offset = "0x3182A30", Length = "0x23C")]
	[Token(Token = "0x6000072")]
	public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<Int32, Int32> materialReferenceIndexLookup) { }

	[Address(RVA = "0x3183870", Offset = "0x3182C70", Length = "0x245")]
	[Token(Token = "0x6000073")]
	public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<Int32, Int32> materialReferenceIndexLookup) { }

}

