namespace UnityEngine;

[Token(Token = "0x2000008")]
public struct PenData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000027")]
	public Vector2 position; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000028")]
	public Vector2 tilt; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000029")]
	public PenStatus penStatus; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400002A")]
	public float twist; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002B")]
	public float pressure; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400002C")]
	public PenEventType contactType; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002D")]
	public Vector2 deltaPos; //Field offset: 0x20

}

