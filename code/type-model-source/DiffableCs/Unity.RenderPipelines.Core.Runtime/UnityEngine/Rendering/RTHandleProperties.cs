namespace UnityEngine.Rendering;

[Token(Token = "0x200019E")]
public struct RTHandleProperties
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007ED")]
	public Vector2Int previousViewportSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007EE")]
	public Vector2Int previousRenderTargetSize; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007EF")]
	public Vector2Int currentViewportSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007F0")]
	public Vector2Int currentRenderTargetSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007F1")]
	public Vector4 rtHandleScale; //Field offset: 0x20

}

