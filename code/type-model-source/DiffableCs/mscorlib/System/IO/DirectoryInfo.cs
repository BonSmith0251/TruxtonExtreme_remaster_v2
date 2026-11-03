namespace System.IO;

[Token(Token = "0x200065C")]
public sealed class DirectoryInfo : FileSystemInfo
{

	[Address(RVA = "0x1FD3C50", Offset = "0x1FD3050", Length = "0x7F")]
	[Token(Token = "0x6002F6C")]
	public DirectoryInfo(string path) { }

	[Address(RVA = "0x1FD3CD0", Offset = "0x1FD30D0", Length = "0x467")]
	[Token(Token = "0x6002F6D")]
	internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	[Address(RVA = "0x1FD4140", Offset = "0x1FD3540", Length = "0x1F")]
	[Token(Token = "0x6002F6F")]
	private DirectoryInfo(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1FD37E0", Offset = "0x1FD2BE0", Length = "0x460")]
	[Token(Token = "0x6002F6E")]
	private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

}

