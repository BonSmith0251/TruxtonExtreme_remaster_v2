namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200059D")]
internal class Entry
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400136D")]
	public EntryType type; //Field offset: 0x10
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x400136E")]
	public EntryFlags flags; //Field offset: 0x12
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400136F")]
	public NativeSlice<Vertex> vertices; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001370")]
	public NativeSlice<UInt16> indices; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001371")]
	public Texture texture; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001372")]
	public float textScale; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001373")]
	public float fontSharpness; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001374")]
	public VectorImage gradientsOwner; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001375")]
	public Material material; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001376")]
	public MaterialPropertyBlock userProps; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001377")]
	public Action immediateCallback; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001378")]
	public TextureId textureId; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001379")]
	public Entry nextSibling; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400137A")]
	public Entry firstChild; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400137B")]
	public Entry lastChild; //Field offset: 0x80

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600288C")]
	public Entry() { }

	[Address(RVA = "0x32F62E0", Offset = "0x32F56E0", Length = "0x9B")]
	[Token(Token = "0x600288B")]
	public void Reset() { }

}

