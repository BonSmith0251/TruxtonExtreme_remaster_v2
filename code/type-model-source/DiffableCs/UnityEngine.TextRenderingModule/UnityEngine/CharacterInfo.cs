namespace UnityEngine;

[Token(Token = "0x200000D")]
[UsedByNativeCode]
public struct CharacterInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003F")]
	public int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Obsolete("CharacterInfo.uv is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead.")]
	[Token(Token = "0x4000040")]
	public Rect uv; //Field offset: 0x4
	[FieldOffset(Offset = "0x14")]
	[Obsolete("CharacterInfo.vert is deprecated. Use minX, maxX, minY, maxY instead.")]
	[Token(Token = "0x4000041")]
	public Rect vert; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[NativeName("advance")]
	[Obsolete("CharacterInfo.width is deprecated. Use advance instead.")]
	[Token(Token = "0x4000042")]
	public float width; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000043")]
	public int size; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000044")]
	public FontStyle style; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Obsolete("CharacterInfo.flipped is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead, which will be correct regardless of orientation.")]
	[Token(Token = "0x4000045")]
	public bool flipped; //Field offset: 0x30

}

