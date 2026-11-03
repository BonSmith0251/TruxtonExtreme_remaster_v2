namespace Steamworks;

[Token(Token = "0x2000175")]
public struct InputMotionData_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009EC")]
	public float rotQuatX; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009ED")]
	public float rotQuatY; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009EE")]
	public float rotQuatZ; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40009EF")]
	public float rotQuatW; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009F0")]
	public float posAccelX; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40009F1")]
	public float posAccelY; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009F2")]
	public float posAccelZ; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40009F3")]
	public float rotVelX; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009F4")]
	public float rotVelY; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009F5")]
	public float rotVelZ; //Field offset: 0x24

}

