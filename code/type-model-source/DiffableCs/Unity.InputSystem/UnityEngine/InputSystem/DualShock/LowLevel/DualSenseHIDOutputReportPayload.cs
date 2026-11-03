namespace UnityEngine.InputSystem.DualShock.LowLevel;

[Token(Token = "0x2000168")]
internal struct DualSenseHIDOutputReportPayload
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000909")]
	public byte enableFlags1; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x400090A")]
	public byte enableFlags2; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x400090B")]
	public byte highFrequencyMotorSpeed; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x400090C")]
	public byte lowFrequencyMotorSpeed; //Field offset: 0x3
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400090D")]
	public byte redColor; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x400090E")]
	public byte greenColor; //Field offset: 0x2D
	[FieldOffset(Offset = "0x2E")]
	[Token(Token = "0x400090F")]
	public byte blueColor; //Field offset: 0x2E

}

