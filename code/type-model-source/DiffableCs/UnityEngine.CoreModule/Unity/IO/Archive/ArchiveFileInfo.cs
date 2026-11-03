namespace Unity.IO.Archive;

[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000049")]
public struct ArchiveFileInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E1")]
	public string Filename; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000E2")]
	public ulong FileSize; //Field offset: 0x8

}

