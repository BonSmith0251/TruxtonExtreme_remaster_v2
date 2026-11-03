namespace System.IO;

[Token(Token = "0x2000662")]
public sealed class FileInfo : FileSystemInfo
{

	[Token(Token = "0x17000776")]
	public DirectoryInfo Directory
	{
		[Address(RVA = "0x1FF1180", Offset = "0x1FF0580", Length = "0xA6")]
		[Token(Token = "0x6002FA0")]
		 get { } //Length: 166
	}

	[Token(Token = "0x17000775")]
	public string DirectoryName
	{
		[Address(RVA = "0x1FF1130", Offset = "0x1FF0530", Length = "0x4D")]
		[Token(Token = "0x6002F9F")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000774")]
	public long Length
	{
		[Address(RVA = "0x1FF1230", Offset = "0x1FF0630", Length = "0xF6")]
		[Token(Token = "0x6002F9E")]
		 get { } //Length: 246
	}

	[Token(Token = "0x17000777")]
	public virtual string Name
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6002FA4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1FF1120", Offset = "0x1FF0520", Length = "0xE")]
	[Token(Token = "0x6002F9B")]
	private FileInfo() { }

	[Address(RVA = "0x1FF0CC0", Offset = "0x1FF00C0", Length = "0x14B")]
	[Token(Token = "0x6002F9C")]
	public FileInfo(string fileName) { }

	[Address(RVA = "0x1FF0F90", Offset = "0x1FF0390", Length = "0x189")]
	[Token(Token = "0x6002F9D")]
	internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	[Address(RVA = "0x1FF0E10", Offset = "0x1FF0210", Length = "0x17F")]
	[Token(Token = "0x6002FA3")]
	private FileInfo(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1FF0BE0", Offset = "0x1FEFFE0", Length = "0x64")]
	[Token(Token = "0x6002FA2")]
	public StreamWriter AppendText() { }

	[Address(RVA = "0x1FF0C50", Offset = "0x1FF0050", Length = "0x64")]
	[Token(Token = "0x6002FA1")]
	public StreamWriter CreateText() { }

	[Address(RVA = "0x1FF1180", Offset = "0x1FF0580", Length = "0xA6")]
	[Token(Token = "0x6002FA0")]
	public DirectoryInfo get_Directory() { }

	[Address(RVA = "0x1FF1130", Offset = "0x1FF0530", Length = "0x4D")]
	[Token(Token = "0x6002F9F")]
	public string get_DirectoryName() { }

	[Address(RVA = "0x1FF1230", Offset = "0x1FF0630", Length = "0xF6")]
	[Token(Token = "0x6002F9E")]
	public long get_Length() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6002FA4")]
	public virtual string get_Name() { }

}

