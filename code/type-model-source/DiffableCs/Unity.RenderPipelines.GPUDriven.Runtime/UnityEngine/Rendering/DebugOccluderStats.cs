namespace UnityEngine.Rendering;

[Token(Token = "0x200002A")]
internal struct DebugOccluderStats
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000082")]
	public int viewInstanceID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000083")]
	public int subviewCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000084")]
	public Vector2Int occluderMipLayoutSize; //Field offset: 0x8

}

