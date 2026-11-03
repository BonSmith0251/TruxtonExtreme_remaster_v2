namespace System.IO;

[Token(Token = "0x200063B")]
public class FileLoadException : IOException
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40018D0")]
	private readonly string <FileName>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40018D1")]
	private readonly string <FusionLog>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x17000745")]
	public string FileName
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002E34")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000746")]
	public string FusionLog
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002E35")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000744")]
	public virtual string Message
	{
		[Address(RVA = "0x1FD5760", Offset = "0x1FD4B60", Length = "0x8D")]
		[Token(Token = "0x6002E33")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x1FD5710", Offset = "0x1FD4B10", Length = "0x44")]
	[Token(Token = "0x6002E31")]
	public FileLoadException() { }

	[Address(RVA = "0x1FD56F0", Offset = "0x1FD4AF0", Length = "0x1E")]
	[Token(Token = "0x6002E32")]
	public FileLoadException(string message) { }

	[Address(RVA = "0x1FD5620", Offset = "0x1FD4A20", Length = "0xC4")]
	[Token(Token = "0x6002E37")]
	protected FileLoadException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1FD52C0", Offset = "0x1FD46C0", Length = "0x5A")]
	[Token(Token = "0x6002E39")]
	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002E34")]
	public string get_FileName() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002E35")]
	public string get_FusionLog() { }

	[Address(RVA = "0x1FD5760", Offset = "0x1FD4B60", Length = "0x8D")]
	[Token(Token = "0x6002E33")]
	public virtual string get_Message() { }

	[Address(RVA = "0x1FD5320", Offset = "0x1FD4720", Length = "0x102")]
	[Token(Token = "0x6002E38")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1FD5430", Offset = "0x1FD4830", Length = "0x1EF")]
	[Token(Token = "0x6002E36")]
	public virtual string ToString() { }

}

