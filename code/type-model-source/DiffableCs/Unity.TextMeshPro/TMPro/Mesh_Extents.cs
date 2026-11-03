namespace TMPro;

[Token(Token = "0x2000027")]
public struct Mesh_Extents
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000DF")]
	public Vector2 min; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000E0")]
	public Vector2 max; //Field offset: 0x8

	[Address(RVA = "0xE1C7E0", Offset = "0xE1BBE0", Length = "0x8")]
	[Token(Token = "0x6000146")]
	public Mesh_Extents(Vector2 min, Vector2 max) { }

	[Address(RVA = "0x2EAF1E0", Offset = "0x2EAE5E0", Length = "0x1DE")]
	[Token(Token = "0x6000147")]
	public virtual string ToString() { }

}

