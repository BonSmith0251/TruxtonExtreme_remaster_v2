namespace System.IO;

[Token(Token = "0x200063D")]
public class FileNotFoundException : IOException
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40018D9")]
	private readonly string <FileName>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40018DA")]
	private readonly string <FusionLog>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x17000748")]
	public string FileName
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002E3F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000749")]
	public string FusionLog
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002E40")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000747")]
	public virtual string Message
	{
		[Address(RVA = "0x1FD5D40", Offset = "0x1FD5140", Length = "0xD7")]
		[Token(Token = "0x6002E3D")]
		 get { } //Length: 215
	}

	[Address(RVA = "0x1FD5BC0", Offset = "0x1FD4FC0", Length = "0x44")]
	[Token(Token = "0x6002E3A")]
	public FileNotFoundException() { }

	[Address(RVA = "0x1FD5CE0", Offset = "0x1FD50E0", Length = "0x1E")]
	[Token(Token = "0x6002E3B")]
	public FileNotFoundException(string message) { }

	[Address(RVA = "0x1FD5D00", Offset = "0x1FD5100", Length = "0x3F")]
	[Token(Token = "0x6002E3C")]
	public FileNotFoundException(string message, string fileName) { }

	[Address(RVA = "0x1FD5C10", Offset = "0x1FD5010", Length = "0xC4")]
	[Token(Token = "0x6002E42")]
	protected FileNotFoundException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002E3F")]
	public string get_FileName() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002E40")]
	public string get_FusionLog() { }

	[Address(RVA = "0x1FD5D40", Offset = "0x1FD5140", Length = "0xD7")]
	[Token(Token = "0x6002E3D")]
	public virtual string get_Message() { }

	[Address(RVA = "0x1FD57F0", Offset = "0x1FD4BF0", Length = "0x102")]
	[Token(Token = "0x6002E43")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1FD5900", Offset = "0x1FD4D00", Length = "0xCE")]
	[Token(Token = "0x6002E3E")]
	private void SetMessageField() { }

	[Address(RVA = "0x1FD59D0", Offset = "0x1FD4DD0", Length = "0x1EF")]
	[Token(Token = "0x6002E41")]
	public virtual string ToString() { }

}

