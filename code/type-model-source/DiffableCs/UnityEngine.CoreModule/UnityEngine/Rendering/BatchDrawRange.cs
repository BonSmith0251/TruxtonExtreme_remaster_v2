namespace UnityEngine.Rendering;

[Token(Token = "0x20003A6")]
public struct BatchDrawRange
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B3A")]
	public BatchDrawCommandType drawCommandsType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B3B")]
	public uint drawCommandsBegin; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B3C")]
	public uint drawCommandsCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B3D")]
	public BatchFilterSettings filterSettings; //Field offset: 0x10

}

