namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000045")]
internal struct TextVertex
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D2")]
	public Vector3 position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001D3")]
	public Vector4 uv; //Field offset: 0xC
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40001D4")]
	public Vector2 uv2; //Field offset: 0x1C
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001D5")]
	public Color32 color; //Field offset: 0x24

}

