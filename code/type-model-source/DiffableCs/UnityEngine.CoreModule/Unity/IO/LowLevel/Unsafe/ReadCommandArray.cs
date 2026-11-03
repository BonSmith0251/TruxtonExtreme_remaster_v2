namespace Unity.IO.LowLevel.Unsafe;

[Token(Token = "0x200003B")]
public struct ReadCommandArray
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A0")]
	public ReadCommand* ReadCommands; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000A1")]
	public int CommandCount; //Field offset: 0x8

}

