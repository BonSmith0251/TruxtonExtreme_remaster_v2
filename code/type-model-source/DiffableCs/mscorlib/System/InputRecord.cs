namespace System;

[Token(Token = "0x20001E1")]
internal struct InputRecord
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000938")]
	public short EventType; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000939")]
	public bool KeyDown; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400093A")]
	public short RepeatCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x400093B")]
	public short VirtualKeyCode; //Field offset: 0x6
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400093C")]
	public short VirtualScanCode; //Field offset: 0x8
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x400093D")]
	public char Character; //Field offset: 0xA
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400093E")]
	public int ControlKeyState; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400093F")]
	private int pad1; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000940")]
	private bool pad2; //Field offset: 0x14

}

