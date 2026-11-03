namespace Unity.IO.LowLevel.Unsafe;

[Token(Token = "0x200003D")]
public struct FileInfoResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A5")]
	public long FileSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000A6")]
	public FileState FileState; //Field offset: 0x8

}

