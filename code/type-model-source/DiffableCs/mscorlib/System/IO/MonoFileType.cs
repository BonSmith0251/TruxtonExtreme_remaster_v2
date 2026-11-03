namespace System.IO;

[Token(Token = "0x200067B")]
internal enum MonoFileType : int
{
	Unknown = 0,
	Disk = 1,
	Char = 2,
	Pipe = 3,
	Remote = 32768,
}

