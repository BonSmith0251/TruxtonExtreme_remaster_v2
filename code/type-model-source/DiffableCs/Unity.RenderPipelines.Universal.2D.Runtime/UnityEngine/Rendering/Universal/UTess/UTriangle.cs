namespace UnityEngine.Rendering.Universal.UTess;

[Token(Token = "0x20000A8")]
internal struct UTriangle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002F5")]
	public float2 va; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002F6")]
	public float2 vb; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F7")]
	public float2 vc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002F8")]
	public UCircle c; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002F9")]
	public float area; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002FA")]
	public int3 indices; //Field offset: 0x28

}

