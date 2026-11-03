namespace System.Reflection.Emit;

[Token(Token = "0x200052F")]
public sealed class LocalBuilder : LocalVariableInfo
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400149F")]
	private string name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014A0")]
	internal ILGenerator ilgen; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014A1")]
	private int startOffset; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40014A2")]
	private int endOffset; //Field offset: 0x34

}

