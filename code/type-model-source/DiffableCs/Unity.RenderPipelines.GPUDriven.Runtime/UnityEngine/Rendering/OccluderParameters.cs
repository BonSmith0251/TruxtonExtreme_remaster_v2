namespace UnityEngine.Rendering;

[Token(Token = "0x2000035")]
public struct OccluderParameters
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AE")]
	public int viewInstanceID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000AF")]
	public int subviewCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000B0")]
	public TextureHandle depthTexture; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B1")]
	public Vector2Int depthSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000B2")]
	public bool depthIsArray; //Field offset: 0x20

	[Address(RVA = "0x2CD36D0", Offset = "0x2CD2AD0", Length = "0xCF")]
	[Token(Token = "0x6000120")]
	public OccluderParameters(int viewInstanceID) { }

}

