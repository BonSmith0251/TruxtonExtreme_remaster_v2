namespace UnityEngine.Rendering.Universal.UTess;

[Token(Token = "0x20000A4")]
internal struct UHull
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002E8")]
	public float2 a; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002E9")]
	public float2 b; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002EA")]
	public int idx; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002EB")]
	public ArraySlice<Int32> ilarray; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002EC")]
	public int ilcount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002ED")]
	public ArraySlice<Int32> iuarray; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002EE")]
	public int iucount; //Field offset: 0x40

}

