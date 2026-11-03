namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000023")]
internal struct Extents
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000CC")]
	public Vector2 min; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000CD")]
	public Vector2 max; //Field offset: 0x8

	[Address(RVA = "0x3171EE0", Offset = "0x31712E0", Length = "0x1DE")]
	[Token(Token = "0x6000069")]
	public virtual string ToString() { }

}

